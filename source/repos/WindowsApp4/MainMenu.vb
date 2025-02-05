Imports System.Configuration
Imports Npgsql

Public Class MainMenu
    Private connection As NpgsqlConnection
    Private ConnectionString As String = ConfigurationManager.AppSettings("ConnectionString")

    Private Shared InsertInstance As Insert = Nothing
    Private Shared DeleteInstance As Delete = Nothing
    Private Shared CariInstance As Result = Nothing
    Private Shared ResetInstance As Reset = Nothing
    Private Shared AprroveAccount As ApproveAccount = Nothing
    Private Shared ChangePassword As ChangePassword = Nothing
    Private Shared Login As Login = Nothing
    Private Shared AccountInformation As AccountInformation = Nothing

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Open the database connection manually
        Try
            connection = New NpgsqlConnection(ConnectionString)
            connection.Open()
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database: " & ex.Message)
            Return
        End Try

        ' Add items to cbxKategori
        cbxKategori.Items.Add("Dewan")
        cbxKategori.Items.Add("Kuarters")
        cbxKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cbxNama.DropDownStyle = ComboBoxStyle.DropDownList

        ' Display the logged-in user's name
        ToolStripTextBox1.Text = $"Hello, {SessionManager.LoggedInUsername}"

        ' Restrict visibility of menu items based on the user's role
        If SessionManager.UserRole <> "Administrator" Then
            ApproveRejectAccountToolStripMenuItem.Visible = False
            ChangeUserPasswordToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub

    Private Sub MainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Close the database connection manually
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Application.Exit()
    End Sub

    Private Sub cbxKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxKategori.SelectedIndexChanged
        ' Clear the previous items in cbxNama
        cbxNama.Items.Clear()

        ' Get the selected category
        Dim selectedCategory As String = cbxKategori.SelectedItem.ToString()

        ' Fetch and populate cbxNama based on the selected category
        LoadNamesByCategory(selectedCategory)
    End Sub

    Private Sub LoadNamesByCategory(category As String)
        If String.IsNullOrEmpty(category) Then
            MessageBox.Show("Category cannot be empty.")
            Return
        End If

        Dim query As String = "SELECT nama FROM ""Aset"" WHERE kategori = @kategori"
        Dim cmd As New NpgsqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@kategori", category)

        Try
            ' Check if the connection is open
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If

            Dim reader As NpgsqlDataReader = cmd.ExecuteReader()

            ' Check if reader contains rows
            If reader IsNot Nothing AndAlso reader.HasRows Then
                cbxNama.Items.Clear()
                While reader.Read()
                    cbxNama.Items.Add(reader("nama").ToString())
                End While
            Else
                MessageBox.Show("No data found for the selected category.")
            End If

            reader.Close()
        Catch ex As NpgsqlException
            ' Catch specific database-related exceptions
            Debug.WriteLine("PostgreSQL error: " & ex.Message)
            MessageBox.Show("PostgreSQL error: " & ex.Message)
        Catch ex As Exception
            ' Catch general exceptions
            Debug.WriteLine("Error loading names: " & ex.Message)
            MessageBox.Show("Error loading names: " & ex.Message)
        End Try
    End Sub


    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ' Ensure that the user has selected a name
        If cbxNama.SelectedItem IsNot Nothing Then
            Dim selectedDewanName As String = cbxNama.SelectedItem.ToString()

            If CariInstance Is Nothing OrElse CariInstance.IsDisposed Then
                CariInstance = New Result()
            End If

            CariInstance.SelectedName = selectedDewanName
            CariInstance.Show()
            Me.Dispose()
        Else
            MessageBox.Show("Sila pilih nama Dewan.")
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If InsertInstance Is Nothing OrElse InsertInstance.IsDisposed Then
            InsertInstance = New Insert()
        End If
        InsertInstance.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DeleteInstance Is Nothing OrElse DeleteInstance.IsDisposed Then
            DeleteInstance = New Delete()
        End If
        DeleteInstance.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Resize_1(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
    End Sub

    Private Sub ResetPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetPasswordToolStripMenuItem.Click
        If ResetInstance Is Nothing OrElse ResetInstance.IsDisposed Then
            ResetInstance = New Reset()
        End If
        ResetInstance.Show()
        Me.Hide()
    End Sub

    Private Sub ApproveRejectAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApproveRejectAccountToolStripMenuItem.Click
        If AprroveAccount Is Nothing OrElse AprroveAccount.IsDisposed Then
            AprroveAccount = New ApproveAccount()
        End If
        AprroveAccount.Show()
        Me.Hide()
    End Sub

    Private Sub ChangeUserPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeUserPasswordToolStripMenuItem.Click
        If ChangePassword Is Nothing OrElse ChangePassword.IsDisposed Then
            ChangePassword = New ChangePassword()
        End If
        ChangePassword.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        SessionManager.ClearSession()
        If Login Is Nothing OrElse Login.IsDisposed Then
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

    Private Sub AccountInfo_Click(sender As Object, e As EventArgs) Handles AccountInfo.Click
        If AccountInformation Is Nothing OrElse AccountInformation.IsDisposed Then
            AccountInformation = New AccountInformation()
        End If
        AccountInformation.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
