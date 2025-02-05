Imports Npgsql
Imports System.Configuration

Public Class AccountInformation

    Private connection As NpgsqlConnection
    Private ConnectionString As String = ConfigurationManager.AppSettings("ConnectionString")
    Private Sub AccountInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialize the database connection

        connection = New NpgsqlConnection(connectionString)
        connection.Open()

        ' Fetch account information
        FetchAccountInformation()
        ' Display the logged-in user's name
        ToolStripTextBox1.Text = $"Hello, {SessionManager.LoggedInUsername}"

        ' Restrict visibility of menu items based on the user's role
        If SessionManager.UserRole <> "Administrator" Then
            ApproveRejectAccountToolStripMenuItem.Visible = False
            ChangeUserPasswordToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub

    Private Sub FetchAccountInformation()
        Dim query As String = "SELECT role, created_at FROM ""User"" WHERE username = @username"
        Dim cmd As New NpgsqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@username", SessionManager.LoggedInUsername)

        Try
            Dim reader As NpgsqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                lblUsername.Text = $"Username: {SessionManager.LoggedInUsername}"
                lblRole.Text = $"Role: {reader("role")}"
                lblCreated.Text = $"Created At: {reader("created_at")}"
            Else
                MessageBox.Show("Account information could not be retrieved.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub AccountInformation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Close the connection when the form closes
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()

        End If
        Application.Exit()
        SessionManager.ClearSession()
    End Sub

    Private Shared MainMenu As MainMenu = Nothing
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MainMenu Is Nothing OrElse MainMenu.IsDisposed Then
            MainMenu = New MainMenu()
        End If
        MainMenu.Show()
        Me.Dispose()
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


End Class
