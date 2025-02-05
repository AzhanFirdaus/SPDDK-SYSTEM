Imports Npgsql
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions ' For Regex

Public Class ChangePassword
    Private connection As NpgsqlConnection
    Private ConnectionString As String = ConfigurationManager.AppSettings("ConnectionString")

    ' Load employee data with role 'employee' into DataGridView
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New NpgsqlConnection(ConnectionString)
        connection.Open()

        LoadEmployeeData()
        ' Display the logged-in user's name
        ToolStripTextBox1.Text = $"Hello, {SessionManager.LoggedInUsername}"

        ' Restrict visibility of menu items based on the user's role
        If SessionManager.UserRole <> "Administrator" Then
            ApproveRejectAccountToolStripMenuItem.Visible = False
            ChangeUserPasswordToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub

    ' Load employee data (role = 'employee') into DataGridView
    Private Sub LoadEmployeeData()
        Dim query As String = "SELECT id, username, email, role FROM ""User"" WHERE role = 'Employee'"
        Dim cmd As New NpgsqlCommand(query, connection)

        Try
            Dim adapter As New NpgsqlDataAdapter(cmd)
            Dim table As New DataTable()

            ' Fill the DataTable with employee data
            adapter.Fill(table)

            ' Bind the data to DataGridView
            DataGridView1.DataSource = table

            ' Enable text wrapping for all cells
            For Each column As DataGridViewColumn In DataGridView1.Columns
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Next

            ' Adjust the AutoSizeColumnsMode
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            ' Add a 'Tukar' button for each row
            AddTukarButtonColumn()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Add 'Tukar' button for each row in DataGridView
    Private Sub AddTukarButtonColumn()
        Dim tukarButton As New DataGridViewButtonColumn()
        tukarButton.Name = "Tukar"
        tukarButton.Text = "Tukar"
        tukarButton.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(tukarButton)
    End Sub

    ' Password validation function
    Private Function IsValidPassword(password As String) As Boolean
        Dim passwordPattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$"
        Return Regex.IsMatch(password, passwordPattern)
    End Function

    ' Handle DataGridView button clicks
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Ensure the clicked cell is the 'Tukar' button
        If e.ColumnIndex = DataGridView1.Columns("Tukar").Index Then
            Dim userId As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("id").Value)

            ' Prompt the admin for the new password
            Dim newPassword As String = InputBox("Enter new password", "New Password")
            If newPassword = "" Then Return

            If Not IsValidPassword(newPassword) Then
                MessageBox.Show("Password must be at least 8 characters long, contain at least one lowercase letter, one uppercase letter, one number, and one special character.")
                Return
            End If

            Dim verifyPassword As String = InputBox("Verify new password", "Verify Password")
            If newPassword = verifyPassword Then
                Dim hashedPassword As String = HashPassword(newPassword)
                UpdatePasswordInDatabase(userId, hashedPassword)
            Else
                MessageBox.Show("Passwords do not match.")
            End If
        End If
    End Sub

    ' Update the user's password in the database
    Private Sub UpdatePasswordInDatabase(userId As Integer, hashedPassword As String)
        Dim query As String = "UPDATE ""User"" SET password = @password WHERE id = @id"
        Dim cmd As New NpgsqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@password", hashedPassword)
        cmd.Parameters.AddWithValue("@id", userId)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Password updated successfully.")
            LoadEmployeeData() ' Refresh the data
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Hash the password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    ' Navigation and other UI logic
    Private Shared MainMenu As MainMenu = Nothing

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MainMenu Is Nothing OrElse MainMenu.IsDisposed Then
            MainMenu = New MainMenu()
        End If
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub ChangePassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Application.Exit()
        SessionManager.ClearSession()
    End Sub

    Private Sub MainMenu_Resize_1(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
    End Sub

    ' Menu navigation logic
    Private Shared ResetInstance As Reset = Nothing
    Private Sub ResetPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetPasswordToolStripMenuItem.Click
        If ResetInstance Is Nothing OrElse ResetInstance.IsDisposed Then
            ResetInstance = New Reset()
        End If
        ResetInstance.Show()
        Me.Hide()
    End Sub

    Private Shared ApproveAccount As ApproveAccount = Nothing
    Private Sub ApproveRejectAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApproveRejectAccountToolStripMenuItem.Click
        If ApproveAccount Is Nothing OrElse ApproveAccount.IsDisposed Then
            ApproveAccount = New ApproveAccount()
        End If
        ApproveAccount.Show()
        Me.Hide()
    End Sub

    Private Shared ChangePassword As ChangePassword = Nothing
    Private Sub ChangeUserPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeUserPasswordToolStripMenuItem.Click
        If ChangePassword Is Nothing OrElse ChangePassword.IsDisposed Then
            ChangePassword = New ChangePassword()
        End If
        ChangePassword.Show()
        Me.Hide()
    End Sub

    Private Shared Login As Login = Nothing
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

    Private Shared AccountInformation As AccountInformation = Nothing
    Private Sub AccountInfo_Click(sender As Object, e As EventArgs) Handles AccountInfo.Click
        If AccountInformation Is Nothing OrElse AccountInformation.IsDisposed Then
            AccountInformation = New AccountInformation()
        End If
        AccountInformation.Show()
        Me.Hide()
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        ' Placeholder for Account menu logic
    End Sub
End Class
