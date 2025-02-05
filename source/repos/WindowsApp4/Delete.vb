Imports Npgsql
Imports System.Configuration
Imports System.IO

Public Class Delete
    Private Shared connection As NpgsqlConnection = Nothing
    Private Shared ReadOnly ConnectionString As String = ConfigurationManager.AppSettings("ConnectionString")

    ' Initialize the shared connection
    Private Shared Sub InitializeConnection()
        If connection Is Nothing Then
            connection = New NpgsqlConnection(ConnectionString)
        End If
    End Sub

    ' Load event for the form
    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display logged-in user's name
        ToolStripTextBox1.Text = $"Hello, {SessionManager.LoggedInUsername}"

        ' Restrict visibility of menu items based on the user's role
        If SessionManager.UserRole <> "Administrator" Then
            ApproveRejectAccountToolStripMenuItem.Visible = False
            ChangeUserPasswordToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub

    ' Search and display data
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            InitializeConnection()
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' SQL query to fetch matching data
            Dim query As String = "SELECT * FROM ""Aset"" WHERE nama LIKE @Nama"
            Dim cmd As New NpgsqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Nama", "%" & txtNama.Text & "%")

            Dim adapter As New NpgsqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Bind DataTable to DataGridView
            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = table

            ' Check if 'gambar' column exists in the DataGridView
            Dim gambarColumn As DataGridViewImageColumn = Nothing
            If DataGridView1.Columns.Contains("gambar") Then
                ' Remove default 'gambar' column
                DataGridView1.Columns.Remove("gambar")

                ' Add 'gambar' column as an ImageColumn with Zoom layout
                gambarColumn = New DataGridViewImageColumn() With {
                .Name = "gambar",
                .HeaderText = "Gambar",
                .ImageLayout = DataGridViewImageCellLayout.Zoom,
                .DataPropertyName = "gambar"
            }
                DataGridView1.Columns.Insert(1, gambarColumn)
            End If
            If DataGridView1.Columns("Delete") Is Nothing Then
                Dim deleteButton As New DataGridViewButtonColumn() With {
                    .Name = "Delete",
                    .HeaderText = "Delete",
                    .Text = "Delete",
                    .UseColumnTextForButtonValue = True
                }
                DataGridView1.Columns.Add(deleteButton)
            End If
            ' Adjust column sizes
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    ' Handle cell content click for delete action
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "Delete" Then
            Dim nama As String = DataGridView1.Rows(e.RowIndex).Cells("nama").Value.ToString()
            DeleteRecord(nama)
        End If
    End Sub

    ' Delete a record from the database
    Private Sub DeleteRecord(nama As String)
        Try
            InitializeConnection()
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "DELETE FROM ""Aset"" WHERE nama = @Nama"
            Dim cmd As New NpgsqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Nama", nama)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Record deleted successfully!")

            ' Refresh the DataGridView
            btnCari.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Form closing event
    Private Sub Delete_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Application.Exit()
        SessionManager.ClearSession()
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
    Private Shared MainMenu As MainMenu = Nothing
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click



        If MainMenu Is Nothing OrElse MainMenu.IsDisposed Then
            MainMenu = New MainMenu()
        End If
        MainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub
End Class
