Imports Npgsql
Imports Npgsql.Internal
Imports System.Configuration
Imports System.Drawing.Printing
Imports System.IO
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.IO.Image
Imports System.Drawing
Imports System.Drawing.Imaging
Imports Microsoft.Web.WebView2.WinForms
Imports System.Reflection

Public Class Result
    Public SelectedName As String
    ' Shared connection object
    Private connection As NpgsqlConnection
    Private ConnectionString As String = ConfigurationManager.AppSettings("ConnectionString")

    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize and open the shared connection if it's not already open
        If connection Is Nothing Then
            connection = New NpgsqlConnection(ConnectionString)
            connection.Open()
        End If

        ' Load the details based on the selected Dewan name
        LoadDewanDetails(SelectedName)

    End Sub

    Private Sub LoadDewanDetails(dewanName As String)
        ' Define the query to fetch details based on the Dewan name
        Dim query As String = "SELECT * FROM ""Aset"" WHERE nama = @Nama"
        Dim cmd As New NpgsqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@Nama", dewanName)

        Try
            ' Execute the query using the shared connection
            Dim reader As NpgsqlDataReader = cmd.ExecuteReader()

            ' If data is found, display the details
            If reader.Read() Then
                lblNama.Text = reader("Nama").ToString()
                lblAlamat.Text = reader("Alamat").ToString()
                lblKategori.Text = reader("Kategori").ToString()
                lblKoordinat.Text = reader("Koordinat").ToString()
                lblKeluasan.Text = reader("Keluasan").ToString()
                lblFasiliti.Text = reader("Fasiliti").ToString()
                lblPenyelia1.Text = reader("Penyelia").ToString()
                lblTel.Text = reader("Telefon").ToString()
                ' Retrieve and display the 'AddedBy' and 'CreatedAt' information
                lblAddedBy.Text = If(reader("InsertedBy") IsNot DBNull.Value, reader("InsertedBy").ToString(), "N/A")
                lblCreatedAt.Text = If(reader("InsertedAt") IsNot DBNull.Value, Convert.ToDateTime(reader("InsertedAt")).ToString("g"), "N/A")
                ' Retrieve the image data from the database
                Dim imageData As Byte() = TryCast(reader("Gambar"), Byte())

                ' If image data is available, convert it to an image and display it in PictureBox1
                If imageData IsNot Nothing Then
                    Dim image As System.Drawing.Image ' Explicitly reference System.Drawing.Image
                    Using ms As New MemoryStream(imageData)
                        image = System.Drawing.Image.FromStream(ms) ' Use System.Drawing.Image.FromStream
                    End Using
                    PictureBox1.Image = image
                Else
                    ' If no image is stored, display a default image or leave the PictureBox empty
                    PictureBox1.Image = Nothing
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & Environment.NewLine & "Stack Trace: " & ex.StackTrace & If(ex.InnerException IsNot Nothing, Environment.NewLine & "Inner Exception: " & ex.InnerException.Message, ""))
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

    Private Sub Result_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ensure the connection is closed when the form closes
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Application.Exit()
    End Sub

    Private Sub Result_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        For Each ctrl As Control In Me.Controls
            Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
            Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
        Next
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
            AccountInformation = New AccountInformation()
        End If

        ' Show the MainMenu form
        AccountInformation.Show()

        ' Close the current form (Result form) instead of hiding
        Me.Hide()
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        ' Display the logged-in user's name
        ToolStripTextBox1.Text = $"Hello, {SessionManager.LoggedInUsername}"

        ' Restrict visibility of menu items based on the user's role
        If SessionManager.UserRole <> "Administrator" Then
            ApproveRejectAccountToolStripMenuItem.Visible = False
            ChangeUserPasswordToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        saveFileDialog.Title = "Save Asset Details"
        saveFileDialog.FileName = "AssetDetails.pdf"

        ' Save to Desktop as a test
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim filePath As String = saveFileDialog.FileName
                If String.IsNullOrEmpty(filePath) Then
                    MessageBox.Show("File path is invalid.")
                    Return
                End If

                ' Start creating the PDF
                Using writer As New PdfWriter(filePath)
                    Using pdf As New PdfDocument(writer)
                        Dim document As New Document(pdf)

                        ' Add content to the PDF
                        document.Add(New Paragraph("Asset Details").SetFontSize(16).SetBold())
                        document.Add(New Paragraph($"Name: {lblNama.Text}"))
                        document.Add(New Paragraph($"Address: {lblAlamat.Text}"))
                        document.Add(New Paragraph($"Category: {lblKategori.Text}"))
                        document.Add(New Paragraph($"Coordinates: {lblKoordinat.Text}"))
                        document.Add(New Paragraph($"Size: {lblKeluasan.Text}"))
                        document.Add(New Paragraph($"Facilities: {lblFasiliti.Text}"))
                        document.Add(New Paragraph($"Supervisor: {lblPenyelia1.Text}"))
                        document.Add(New Paragraph($"Phone: {lblTel.Text}"))
                        document.Add(New Paragraph($"Added By: {lblAddedBy.Text}"))
                        document.Add(New Paragraph($"Created At: {lblCreatedAt.Text}"))

                        ' Add the image if available
                        If PictureBox1.Image IsNot Nothing Then
                            ' Create a deep copy of the image
                            Dim clonedImage As New Bitmap(PictureBox1.Image)

                            ' Convert the cloned image to a memory stream
                            Using ms As New MemoryStream()
                                clonedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                                Dim imageData As Byte() = ms.ToArray()
                                Dim itextImage As iText.Layout.Element.Image = New iText.Layout.Element.Image(ImageDataFactory.Create(imageData))
                                itextImage.ScaleToFit(400, 400) ' Scale the image to fit in the document
                                document.Add(itextImage)
                            End Using

                            ' Dispose of the cloned image to release resources
                            clonedImage.Dispose()
                        End If

                        ' Close the document
                        document.Close()
                    End Using
                End Using

                MessageBox.Show("PDF downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As iText.Kernel.Exceptions.PdfException
                ' Show detailed PDF exception error
                MessageBox.Show("PDF generation error: " & ex.Message & vbCrLf & "Details: " & ex.StackTrace, "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                ' Catch other errors and show detailed message
                MessageBox.Show("Error while generating PDF: " & ex.Message & vbCrLf & ex.StackTrace, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub






    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintPageHandler

        Dim printDialog As New PrintDialog()
        printDialog.Document = printDoc

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        Dim font As New Font("Arial", 12)

        ' Start Y position for text
        Dim currentY As Integer = 50

        ' Print details
        g.DrawString("Asset Details", New Font("Arial", 16, FontStyle.Bold), Brushes.Black, New Point(100, currentY))
        currentY += 50
        g.DrawString($"Name: {lblNama.Text}", font, Brushes.Black, New Point(100, currentY))
        currentY += 30
        g.DrawString($"Address: {lblAlamat.Text}", font, Brushes.Black, New Point(100, currentY))
        currentY += 30
        g.DrawString($"Category: {lblKategori.Text}", font, Brushes.Black, New Point(100, currentY))
        currentY += 30
        g.DrawString($"Coordinates: {lblKoordinat.Text}", font, Brushes.Black, New Point(100, currentY))
        currentY += 30
        g.DrawString($"Size: {lblKeluasan.Text}", font, Brushes.Black, New Point(100, currentY))
        currentY += 30
        g.DrawString($"Facilities: {lblFasiliti.Text}", font, Brushes.Black, New Point(100, currentY))
        currentY += 30
        g.DrawString($"Supervisor: {lblPenyelia1.Text}", font, Brushes.Black, New Point(100, currentY))
        currentY += 30
        g.DrawString($"Phone: {lblTel.Text}", font, Brushes.Black, New Point(100, currentY))
        currentY += 30
        g.DrawString($"Added By: {lblAddedBy.Text}", font, Brushes.Black, New Point(100, currentY))
        currentY += 30
        g.DrawString($"Created At: {lblCreatedAt.Text}", font, Brushes.Black, New Point(100, currentY))
        currentY += 30

        ' Print image if available
        If PictureBox1.Image IsNot Nothing Then
            Dim maxImageWidth As Integer = e.PageBounds.Width - 200 ' Leave margins
            Dim maxImageHeight As Integer = e.PageBounds.Height - currentY - 50 ' Space below text

            Dim imageWidth As Integer = PictureBox1.Image.Width
            Dim imageHeight As Integer = PictureBox1.Image.Height

            ' Calculate aspect ratio
            Dim scaleFactor As Single = Math.Min(maxImageWidth / imageWidth, maxImageHeight / imageHeight)
            Dim scaledWidth As Integer = CInt(imageWidth * scaleFactor)
            Dim scaledHeight As Integer = CInt(imageHeight * scaleFactor)

            ' Draw image starting at the current Y position
            g.DrawImage(PictureBox1.Image, New Rectangle(100, currentY, scaledWidth, scaledHeight))
        End If
    End Sub

End Class




