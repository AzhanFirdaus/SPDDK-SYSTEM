Imports Npgsql
Imports System.Configuration
Imports BCrypt.Net

Public Class Login
    Private Shared RegisterInstance As Register = Nothing
    Private Shared mainMenuInstance As MainMenu = Nothing

    ' Declare the connection string once
    Private ConnectionString As String = ConfigurationManager.AppSettings("ConnectionString")
    Private connection As NpgsqlConnection

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If RegisterInstance Is Nothing OrElse RegisterInstance.IsDisposed Then
            RegisterInstance = New Register()
        End If
        RegisterInstance.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        ' Validate user input
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        ' Check connection state
        If connection Is Nothing OrElse connection.State <> ConnectionState.Open Then
            MessageBox.Show("Database connection is not ready. Please try again.")
            Return
        End If

        ' Verify login credentials
        If VerifyLogin(username, password) Then
            Dim status As String = GetUserStatus(username)
            Dim role As String = GetUserRole(username)

            Select Case status
                Case "Approved"
                    ' Set session data
                    SessionManager.LoggedInUsername = username
                    SessionManager.UserRole = role

                    ' Open the main menu
                    If mainMenuInstance Is Nothing OrElse mainMenuInstance.IsDisposed Then
                        mainMenuInstance = New MainMenu()
                    End If
                    mainMenuInstance.Show()
                    Me.Hide()
                Case "Pending"
                    MessageBox.Show("Your account is pending approval. Please wait for admin approval.")
                Case "Rejected"
                    MessageBox.Show("Your account has been rejected. Contact support for more details.")
                Case Else
                    MessageBox.Show("Invalid username or account does not exist.")
            End Select
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Function VerifyLogin(username As String, password As String) As Boolean
        Dim query As String = "SELECT password FROM ""User"" WHERE username = @username"
        Try
            Using command As New NpgsqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)

                Using reader As NpgsqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim storedHash As String = reader("password").ToString()

                        ' Verify password with bcrypt
                        Return BCrypt.Net.BCrypt.Verify(password, storedHash)
                    End If
                End Using
            End Using
            Return False ' User not found or password mismatch
        Catch ex As Exception
            ' Log the exception
            MessageBox.Show($"Error during login verification: {ex.Message}")
            Return False
        End Try
    End Function

    Private Function GetUserStatus(username As String) As String
        Dim query As String = "SELECT status FROM ""User"" WHERE username = @username"
        Try
            Using command As New NpgsqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)

                Using reader As NpgsqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Return reader("status").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving user status: {ex.Message}")
        End Try
        Return Nothing
    End Function

    Private Function GetUserRole(username As String) As String
        Dim query As String = "SELECT role FROM ""User"" WHERE username = @username"
        Try
            Using command As New NpgsqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)

                Using reader As NpgsqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Return reader("role").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving user role: {ex.Message}")
        End Try
        Return Nothing
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection = New NpgsqlConnection(ConnectionString)
            connection.Open()
            Debug.WriteLine("Database connection established.")
        Catch ex As Exception
            MessageBox.Show($"Error opening database connection: {ex.Message}")
        End Try

        txtPassword.PasswordChar = "●"c
        btnLogin.Focus()
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If txtPassword.PasswordChar = "●"c Then
            txtPassword.PasswordChar = ""
            PictureBox3.Image = My.Resources.EyeOpenIcon
        Else
            txtPassword.PasswordChar = "●"c
            PictureBox3.Image = My.Resources.EyeClosedIcon
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.PerformClick()
        End If
    End Sub
End Class