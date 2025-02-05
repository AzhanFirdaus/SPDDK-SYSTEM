Imports System.Configuration
Imports Npgsql
Imports BCrypt.Net

Public Class Reset
    Private connection As NpgsqlConnection
    Private ConnectionString As String = ConfigurationManager.AppSettings("ConnectionString")

    Private Sub Reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the database connection
        connection = New NpgsqlConnection(ConnectionString)
        connection.Open()

        ' Display the logged-in user's username for reference
        lblUsername.Text = $"Reset Password for {SessionManager.LoggedInUsername}"
        ToolStripTextBox1.Text = $"Hello, {SessionManager.LoggedInUsername}"

        ' Restrict visibility of menu items based on the user's role
        If SessionManager.UserRole <> "Administrator" Then
            ApproveRejectAccountToolStripMenuItem.Visible = False
            ChangeUserPasswordToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub

    Private Function HashPassword(password As String) As String
        ' Hash the password using bcrypt
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function

    Private Function VerifyPassword(inputPassword As String, hashedPassword As String) As Boolean
        ' Verify the password using bcrypt
        Return BCrypt.Net.BCrypt.Verify(inputPassword, hashedPassword)
    End Function

    Private Sub Reset_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ensure the connection is closed when the form closes
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ' Validate the input
        If txtpassword.Text <> txtverify.Text Then
            MessageBox.Show("Passwords do not match. Please try again.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtpassword.Text) Then
            MessageBox.Show("Password cannot be empty.")
            Return
        End If

        ' Hash the new password
        Dim hashedPassword As String = HashPassword(txtpassword.Text)

        ' Update the password for the logged-in user
        Dim query As String = "UPDATE ""User"" SET password = @password WHERE username = @username"
        Dim cmd As New NpgsqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@password", hashedPassword)
        cmd.Parameters.AddWithValue("@username", SessionManager.LoggedInUsername)

        Try
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Password successfully updated!")
                Me.Hide()
                txtpassword.Clear()
                txtverify.Clear()

            Else
                MessageBox.Show("Failed to update password. Please check the username.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Shared MainMenu As MainMenu = Nothing
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MainMenu Is Nothing OrElse MainMenu.IsDisposed Then
            MainMenu = New MainMenu()
        End If
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Resize_1(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
    End Sub

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

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        ' Placeholder for toolstrip action
    End Sub
End Class
