Imports Npgsql
Imports System.Configuration
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Insert
    Private ConnectionString As String = ConfigurationManager.AppSettings("ConnectionString")
    Private imageData As Byte() ' To store the image data

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize dropdown items and set style
        cbxKategori.Items.Add("Dewan")
        cbxKategori.Items.Add("Kuarters")
        cbxKategori.DropDownStyle = ComboBoxStyle.DropDownList
        ' Display the logged-in user's name
        ToolStripTextBox1.Text = $"Hello, {SessionManager.LoggedInUsername}"

        ' Restrict visibility of menu items based on the user's role
        If SessionManager.UserRole <> "Administrator" Then
            ApproveRejectAccountToolStripMenuItem.Visible = False
            ChangeUserPasswordToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        ' Open file dialog to select image
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)

            ' Convert image to byte array
            Using ms As New MemoryStream()
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                imageData = ms.ToArray()
            End Using
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Define validation patterns
        Dim namePattern As String = "^[A-Za-z\s]+$"  ' Only letters and spaces
        Dim phonePattern As String = "^\d{9,11}$"
        Dim addressPattern As String = ".+"           ' At least one character
        Dim coordinatesPattern As String = "^[0-9\.\-]+$"  ' Numbers, periods, and hyphens
        Dim areaPattern As String = "^\d+(\.\d+)?$"  ' Numeric values, with optional decimal
        Dim facilityPattern As String = ".+"          ' At least one character
        Dim PenyeliaPattern As String = ".+"          ' At least one character
        Dim kategoripattern As String = ".+"

        ' Validate fields
        If Not Regex.IsMatch(txtNama.Text, namePattern) Then
            MessageBox.Show("Invalid Name. Only letters and spaces are allowed.")
            Return
        End If

        If Not Regex.IsMatch(txtTel.Text, phonePattern) Then
            MessageBox.Show("Invalid Phone Number. It must be between 9 and 11 digits.")
            Return
        End If

        If Not Regex.IsMatch(txtAlamat.Text, addressPattern) Then
            MessageBox.Show("Address field cannot be empty.")
            Return
        End If

        If Not Regex.IsMatch(txtKoordinat.Text, coordinatesPattern) Then
            MessageBox.Show("Invalid Coordinates. Only numbers, periods, and hyphens are allowed.")
            Return
        End If

        If Not Regex.IsMatch(txtKeluasan.Text, areaPattern) Then
            MessageBox.Show("Invalid Area. Please enter a valid numeric value.")
            Return
        End If

        If Not Regex.IsMatch(txtFasiliti.Text, facilityPattern) Then
            MessageBox.Show("Facility field cannot be empty.")
            Return
        End If

        If Not Regex.IsMatch(txtPenyelia.Text, PenyeliaPattern) Then
            MessageBox.Show("Penyelia field cannot be empty.")
            Return
        End If

        If String.IsNullOrEmpty(cbxKategori.SelectedItem?.ToString()) OrElse Not Regex.IsMatch(cbxKategori.SelectedItem.ToString(), kategoripattern) Then
            MessageBox.Show("Please choose a Category.")
            Return
        End If

        ' Ensure image data is present
        If imageData Is Nothing OrElse imageData.Length = 0 Then
            MessageBox.Show("Please upload an image before submitting.")
            Return
        End If

        ' Database connection


        Using conn As New NpgsqlConnection(ConnectionString)
            ' Check for duplicates
            Dim checkCmd As New NpgsqlCommand("SELECT COUNT(*) FROM ""Aset"" WHERE Nama = @nama AND Alamat = @alamat AND Koordinat = @koordinat", conn)
            checkCmd.Parameters.AddWithValue("@nama", txtNama.Text)
            checkCmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            checkCmd.Parameters.AddWithValue("@koordinat", txtKoordinat.Text)

            Try
                conn.Open()
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Duplicate entry found. The asset with this name and address already exists.")
                    Return
                End If

                ' Insert data with extended timeout for large images
                Dim insertCmd As New NpgsqlCommand("INSERT INTO ""Aset"" (Nama, Alamat, Koordinat, Keluasan, Fasiliti, Kategori, Penyelia, Telefon, Gambar, InsertedBy, InsertedAt) VALUES (@nama, @alamat, @koordinat, @keluasan, @fasiliti, @kategori, @penyelia, @telefon, @gambar, @insertedBy, @insertedAt)", conn)
                insertCmd.Parameters.AddWithValue("@nama", txtNama.Text)
                insertCmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
                insertCmd.Parameters.AddWithValue("@koordinat", txtKoordinat.Text)
                insertCmd.Parameters.AddWithValue("@Keluasan", txtKeluasan.Text)
                insertCmd.Parameters.AddWithValue("@fasiliti", txtFasiliti.Text)
                insertCmd.Parameters.AddWithValue("@kategori", cbxKategori.SelectedItem.ToString())
                insertCmd.Parameters.AddWithValue("@penyelia", txtPenyelia.Text)
                insertCmd.Parameters.AddWithValue("@telefon", txtTel.Text)
                insertCmd.Parameters.AddWithValue("@gambar", imageData)
                insertCmd.Parameters.AddWithValue("@insertedby", SessionManager.LoggedInUsername) ' Use the session username
                insertCmd.Parameters.AddWithValue("@insertedat", DateTime.Now) ' Use the current timestamp
                insertCmd.CommandTimeout = 120 ' Increased timeout for large data

                insertCmd.ExecuteNonQuery()
                MessageBox.Show("Data successfully inserted.")

            Catch ex As Exception
                MessageBox.Show("Error during insert: " & ex.Message)
            Finally
                conn.Close()
                Dim Main As New MainMenu()
                Main.Show()
                Me.Hide()
            End Try
        End Using
    End Sub

    Private Sub Insert_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Shared MainMenu As MainMenu = Nothing
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MainMenu Is Nothing OrElse MainMenu.IsDisposed Then
            MainMenu = New MainMenu()
        End If
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNama.Clear()
        txtAlamat.Clear()
        txtFasiliti.Clear()
        txtKeluasan.Clear()
        txtKoordinat.Clear()
        txtPenyelia.Clear()
        txtTel.Clear()

        cbxKategori.SelectedIndex = -1
        PictureBox1.Image = Nothing
        imageData = Nothing
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Insert_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        For Each ctrl As Control In Me.Controls
            ctrl.Left = (Me.ClientSize.Width - ctrl.Width) \ 2
            ctrl.Top = (Me.ClientSize.Height - ctrl.Height) \ 2
            Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
            Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
        Next
    End Sub

    Private Sub MainMenu_Resize_1(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2

    End Sub
    Private Shared ResetInstance As Reset = Nothing
    Private Sub ResetPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetPasswordToolStripMenuItem.Click
        ' Check if the Reset instance is Nothing or has been disposed
        If ResetInstance Is Nothing OrElse ResetInstance.IsDisposed Then
            ResetInstance = New Reset()

        End If

        ' Show the Reset form
        ResetInstance.Show()
        Me.Hide()
    End Sub
    Private Shared AprroveAccount As ApproveAccount = Nothing
    Private Sub ApproveRejectAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApproveRejectAccountToolStripMenuItem.Click


        ' Check if the mainMenuInstance is Nothing or has been disposed
        If AprroveAccount Is Nothing OrElse AprroveAccount.IsDisposed Then
            ' If it's Nothing or disposed, create a new instance
            AprroveAccount = New ApproveAccount()
        End If

        ' Show the MainMenu form
        AprroveAccount.Show()

        ' Close the current form (Result form) instead of hiding
        Me.Hide()
    End Sub
    Private Shared ChangePassword As ChangePassword = Nothing
    Private Sub ChangeUserPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeUserPasswordToolStripMenuItem.Click
        ' Check if the mainMenuInstance is Nothing or has been disposed
        If ChangePassword Is Nothing OrElse ChangePassword.IsDisposed Then
            ' If it's Nothing or disposed, create a new instance
            ChangePassword = New ChangePassword()
        End If

        ' Show the MainMenu form
        ChangePassword.Show()

        ' Close the current form (Result form) instead of hiding
        Me.Hide()
    End Sub
    Private Shared Login As Login = Nothing
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        SessionManager.ClearSession()
        If Login Is Nothing OrElse Login.IsDisposed Then
            ' If it's Nothing or disposed, create a new instance
            Login = New Login()
        End If
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Exitlog = MessageBox.Show("Are You Sure You Want To Exit The Application?", "Confirm Exit", MessageBoxButtons.YesNo)
        If Exitlog = DialogResult.Yes Then
            SessionManager.ClearSession()
            Application.Exit()
        End If
    End Sub
    Private Shared AccountInformation As AccountInformation = Nothing
    Private Sub AccountInfo_Click(sender As Object, e As EventArgs) Handles AccountInfo.Click
        ' Check if the mainMenuInstance is Nothing or has been disposed
        If AccountInformation Is Nothing OrElse AccountInformation.IsDisposed Then
            ' If it's Nothing or disposed, create a new instance
            AccountInformation = New AccountInformation()
        End If

        ' Show the MainMenu form
        AccountInformation.Show()

        ' Close the current form (Result form) instead of hiding
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtKeluasan_TextChanged(sender As Object, e As EventArgs) Handles txtKeluasan.TextChanged

    End Sub
End Class
