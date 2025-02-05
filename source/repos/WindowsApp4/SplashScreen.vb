Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading.Tasks

Public Class SplashScreen
    Private WithEvents splashTimer As New Timer()
    Private progressValue As Integer = 0 ' Variable to track progress bar value
    Private verificationCompleted As Boolean = False ' To track verification status
    Private verificationSuccess As Boolean = False ' To track if verification succeeded

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashTimer.Interval = 50 ' Timer interval (50 ms for smooth progress)
        splashTimer.Start()

        ' Start the file verification asynchronously
        PerformFileVerificationAsync()
    End Sub

    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        If progressValue < 100 Then
            progressValue += 1
        End If

        ' Ensure UI update is on the main thread
        If ProgressBar1.InvokeRequired Then
            ProgressBar1.Invoke(Sub() ProgressBar1.Value = progressValue)
        Else
            ProgressBar1.Value = progressValue
        End If

        ' Wait until verification completes and progress reaches 100
        If progressValue >= 100 AndAlso verificationCompleted Then
            splashTimer.Stop()

            If verificationSuccess Then
                Dim Login As New Login() ' Replace with your main form
                Login.Show()
                Me.Close()
            Else
                MessageBox.Show("File verification failed. Application cannot start. " &
                                "Ensure all files are present and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End If
        End If
    End Sub

    Private Async Sub PerformFileVerificationAsync()
        Await Task.Run(Sub()
                           Try
                               Dim manifestPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "manifest.txt")
                               If Not File.Exists(manifestPath) Then
                                   Throw New FileNotFoundException("Manifest file is missing.")
                               End If

                               ' Read and verify each file in the manifest
                               Dim lines As String() = File.ReadAllLines(manifestPath)
                               For Each line As String In lines
                                   Dim parts As String() = line.Split("="c)
                                   If parts.Length <> 2 Then Continue For ' Skip invalid lines

                                   Dim filePath As String = parts(0).Trim()
                                   Dim expectedHash As String = parts(1).Trim()

                                   ' Check if the file exists
                                   If Not File.Exists(filePath) Then
                                       Throw New FileNotFoundException($"Missing file: {filePath}")
                                   End If

                                   ' Check the file's integrity
                                   Dim actualHash As String = ComputeFileHash(filePath)
                                   If actualHash <> expectedHash Then
                                       Throw New InvalidDataException($"File integrity check failed: {filePath}")
                                   End If
                               Next

                               ' If all files are valid
                               verificationSuccess = True
                           Catch ex As Exception
                               verificationSuccess = False
                               LogError(ex) ' Log error for debugging
                           End Try
                       End Sub)

        verificationCompleted = True
    End Sub

    Private Function ComputeFileHash(filePath As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Using fileStream As FileStream = File.OpenRead(filePath)
                Dim hashBytes As Byte() = sha256.ComputeHash(fileStream)
                Return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant()
            End Using
        End Using
    End Function

    Private Sub LogError(ex As Exception)
        Dim logPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error_log.txt")
        Dim errorMessage As String = $"[{DateTime.Now}] {ex.Message}{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}"
        File.AppendAllText(logPath, errorMessage)
    End Sub

End Class
