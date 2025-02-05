Public Class SessionManager
    Public Shared Property LoggedInUsername As String
    Public Shared Property UserRole As String

    ' Method to clear session data
    Public Shared Sub ClearSession()
        LoggedInUsername = Nothing
        UserRole = Nothing
    End Sub
End Class
