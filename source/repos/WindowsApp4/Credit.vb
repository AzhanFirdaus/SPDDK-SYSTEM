Imports System.Collections.ObjectModel
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports Npgsql

Public Class Credit
    Private connection As NpgsqlConnection
    Private ConnectionString As String = ConfigurationManager.AppSettings("ConnectionString")
    Private Sub Credit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()
        SessionManager.ClearSession()
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Credit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the logged-in user's name
        ToolStripTextBox1.Text = $"Hello, {SessionManager.LoggedInUsername}"

        ' Restrict visibility of menu items based on the user's role
        If SessionManager.UserRole <> "Administrator" Then
            ApproveRejectAccountToolStripMenuItem.Visible = False
            ChangeUserPasswordToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click

    End Sub
End Class