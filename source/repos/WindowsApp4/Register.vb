Imports Npgsql
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Register
    Private connection As NpgsqlConnection
    Private ConnectionString As String = ConfigurationManager.AppSettings("ConnectionString")

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New NpgsqlConnection(ConnectionString)
        connection.Open()
        txtPassword.PasswordChar = "●"c
    End Sub

    Private Sub Register_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Application.Exit()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Validate inputs
        If Not IsValidUsername(username) Then
            MessageBox.Show("Invalid username!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsValidPassword(password) Then
            MessageBox.Show("Weak password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check for duplicates
        If UserExists(username, email) Then
            MessageBox.Show("Username or email already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Hash password with bcrypt
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)

        Try
            InsertUserIntoDatabase(username, hashedPassword, email)
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Clear()
            txtEmail.Clear()
            txtPassword.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to check if a user already exists
    Private Function UserExists(username As String, email As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM ""User"" WHERE LOWER(username) = LOWER(@username) OR LOWER(email) = LOWER(@Email)"
        Using command As New NpgsqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@Email", email)
            Return Convert.ToInt32(command.ExecuteScalar()) > 0
        End Using
    End Function

    Private Sub InsertUserIntoDatabase(username As String, hashedPassword As String, email As String)
        Dim query As String = "INSERT INTO ""User"" (username, password, email, status, role, created_at) VALUES (@username, @password, @Email, @status, @role, @created_at)"
        Using command As New NpgsqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", hashedPassword)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@status", "Pending")
            command.Parameters.AddWithValue("@role", "Employee")
            command.Parameters.AddWithValue("@created_at", DateTime.Now)
            command.ExecuteNonQuery()
        End Using
    End Sub


    ' Validation functions
    Private Function IsValidUsername(username As String) As Boolean
        Dim usernamePattern As String = "^[a-zA-Z0-9]{3,15}$"
        Return Regex.IsMatch(username, usernamePattern)
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
    End Function

    Private Function IsValidPassword(password As String) As Boolean
        Dim passwordPattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$"
        Return Regex.IsMatch(password, passwordPattern)
    End Function

    ' Password hashing function
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

    ' Event handler for navigating to the login form
    Private Shared LoginInstance As Login = Nothing
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If LoginInstance Is Nothing OrElse LoginInstance.IsDisposed Then
            LoginInstance = New Login()
        End If
        LoginInstance.Show()
        Me.Hide()
    End Sub

    ' Resize event to center controls dynamically
    Private Sub Register_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        For Each ctrl As Control In Me.Controls
            ctrl.Left = (Me.ClientSize.Width - ctrl.Width) \ 2
            ctrl.Top = (Me.ClientSize.Height - ctrl.Height) \ 2
            Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
            Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
        Next
    End Sub
    Private Sub IncreaseFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseFontToolStripMenuItem.Click
        IncreaseAllFonts()
    End Sub

    Private Sub DecreaseFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseFontToolStripMenuItem.Click
        DecreaseAllFonts()
    End Sub

    Private Sub AdjustAllFonts(container As Control, delta As Single)
        For Each ctrl As Control In container.Controls
            If ctrl.Font IsNot Nothing Then
                Dim currentFont As Font = ctrl.Font
                Dim newSize As Single = Math.Max(1, currentFont.Size + delta)
                ctrl.Font = New Font(currentFont.FontFamily, newSize, currentFont.Style)
            End If

            If ctrl.Controls.Count > 0 Then
                AdjustAllFonts(ctrl, delta)
            End If
        Next
    End Sub

    Private Sub IncreaseAllFonts()
        AdjustAllFonts(Me, 1)
    End Sub

    Private Sub DecreaseAllFonts()
        AdjustAllFonts(Me, -1)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Exitlog = MessageBox.Show("Are You Sure You Want To Exit The Application?", "Confirm Exit", MessageBoxButtons.YesNo)
        If Exitlog = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.BackColor = SystemColors.Control
        If txtPassword.PasswordChar = "●"c Then
            ' If PasswordChar is set to dots, show the password
            txtPassword.PasswordChar = "" ' Clear PasswordChar to show password
            PictureBox3.Image = My.Resources.EyeOpenIcon ' Update to open eye icon
        Else
            ' If PasswordChar is empty, hide the password with dots
            txtPassword.PasswordChar = "●"c ' Set PasswordChar back to dots
            PictureBox3.Image = My.Resources.EyeClosedIcon ' Update to closed eye icon
        End If
    End Sub
End Class