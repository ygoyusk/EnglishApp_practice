Public Class Sql_Multiple

    Public Function readPath(ByVal path As String) As String

        Dim sqlPath As String = ".\SQL\" & path & ".sql"
        If System.IO.File.Exists(sqlPath) = False Then
            Return ""
        End If

        Dim sr As New System.IO.StreamReader(sqlPath, System.Text.Encoding.Default)
        Dim strSql As String = sr.ReadToEnd()
        sr.Close()

        Return strSql

    End Function

End Class
