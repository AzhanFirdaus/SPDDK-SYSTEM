Imports System.Configuration
Imports Npgsql

Public Class ApproveAccount
    Private connection As NpgsqlConnection
    Private ConnectionString As String = ConfigurationManager.AppSettings("ConnectionString")

    Private Sub ApproveAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New NpgsqlConnection(connectionString)
        connection.Open()

        LoadUserData()
        ' Display the logged-in user's name
        ToolStripTextBox1.Text = $"Hello, {SessionManager.LoggedInUsername}"

        ' Restrict visibility of menu items based on the user's role
        If SessionManager.UserRole <> "Administrator" Then
            ApproveRejectAccountToolStripMenuItem.Visible = False
            ChangeUserPasswordToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub

    Private Sub LoadUserData()
        Dim query As String = "SELECT id, username, email, role, status FROM ""User"" WHERE status = 'Pending'"
        Dim cmd As New NpgsqlCommand(query, connection)

        Try
            Dim adapter As New NpgsqlDataAdapter(cmd)
            Dim table As New DataTable()

            ' Fill the DataTable with user data
            adapter.Fill(table)

            ' Bind the data to DataGridView
            DataGridView1.DataSource = table

            ' Add Approve and Reject buttons
            AddButtonsToGrid()

            ' Configure DataGridView for better visibility
            ConfigureDataGridView()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub AddButtonsToGrid()
        ' Add Approve button
        Dim approveButton As New DataGridViewButtonColumn()
        approveButton.Name = "Approve"
        approveButton.Text = "Approve"
        approveButton.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(approveButton)

        ' Add Reject button
        Dim rejectButton As New DataGridViewButtonColumn()
        rejectButton.Name = "Reject"
        rejectButton.Text = "Reject"
        rejectButton.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(rejectButton)
    End Sub

    Private Sub ConfigureDataGridView()
        ' Enable column auto-sizing
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        ' Set wrap mode for cell content
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next

        ' Adjust row height to fit content
        DataGridView1.AutoResizeRows()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Ensure the clicked cell is a button
        If e.ColumnIndex = DataGridView1.Columns("Approve").Index OrElse e.ColumnIndex = DataGridView1.Columns("Reject").Index Then
            Dim userId As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("id").Value)
            Dim action As String = DataGridView1.Columns(e.ColumnIndex).Name ' "Approve" or "Reject"

            UpdateUserStatus(userId, action)
        End If
    End Sub

    Private Sub UpdateUserStatus(userId As Integer, action As String)
        Dim newStatus As String = If(action = "Approve", "Approved", "Rejected")
        Dim query As String = "UPDATE ""User"" SET status = @status WHERE id = @id"

        Dim cmd As New NpgsqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@status", newStatus)
        cmd.Parameters.AddWithValue("@id", userId)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show($"User {action}d successfully.")
            ' Reload data
            LoadUserData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Shared MainMenu As MainMenu = Nothing

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Check if the mainMenuInstance is Nothing or has been disposed
        If MainMenu Is Nothing OrElse MainMenu.IsDisposed Then
            ' If it's Nothing or disposed, create a new instance
            MainMenu = New MainMenu()
        End If

        ' Show the MainMenu form
        MainMenu.Show()

        ' Close the current form (Result form) instead of hiding
        Me.Hide()
    End Sub

    Private Sub ApproveAccount_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Close the connection when the form closes
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
End Class
