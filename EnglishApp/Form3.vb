Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Form3
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReflect_Click(sender As Object, e As EventArgs) Handles btnReflect.Click

        Try
            'SQLserver接続
            Dim connstr As String = My.Settings.sqlServer
            Dim sqlconn As New SqlConnection(connstr)
            Dim comm As New SqlCommand
            'Dim sqlWordCheck As String = "SELECT COUNT(*) FROM QATable WHERE word = @a"
            'Dim sqlInsert As String = "INSERT INTO QATable(word, EnglishWord) VALUES (@a, @b)"
            sqlconn.Open()

            'トランザクション
            Dim tran As SqlTransaction
            tran = sqlconn.BeginTransaction

            Try
                'Dim sql As System.Text.StringBuilder = New System.Text.StringBuilder()
                'sql.AppendLine("INSERT INTO QATable(word, EnglishWord)")
                'sql.AppendLine(" VALUES")
                'sql.AppendLine(" ('" & txtWord.Text & "'" & ", '" & txtEnglishWord.Text & "')")

                'Dim sqlr As System.Text.StringBuilder = New System.Text.StringBuilder()
                'sqlr.AppendLine("SELECT COUNT(*)")
                'sqlr.AppendLine(" FROM QATable")
                'sqlr.AppendLine(" WHERE word = '" & txtWord.Text & "'")

                'SQL作成
                Dim word_check As Sql_Multiple = New Sql_Multiple
                Dim path_wordCheck As String
                path_wordCheck = "SQLQuery3"
                Call word_check.readPath(path_wordCheck)

                Dim word_insert As Sql_Multiple = New Sql_Multiple
                Dim path_wordInsert As String
                path_wordInsert = "SQLQuery4"
                Call word_insert.readPath(path_wordInsert)

                'SQL実行
                'comm = New SqlCommand(sqlr.ToString, sqlconn)
                'comm.Transaction = tran
                'Dim ret As String = comm.ExecuteScalar()

                comm = New SqlCommand(word_check.readPath(path_wordCheck), sqlconn)
                Dim check As New SqlParameter("@a", txtWord.Text)
                comm.Parameters.Add(check)
                comm.Transaction = tran
                Dim ret As String = comm.ExecuteScalar()

                If CInt(ret) = 0 Then
                    'comm = New SqlCommand(sql.ToString, sqlconn)
                    'comm.Transaction = tran
                    'Dim com As String = comm.ExecuteNonQuery()
                    comm = New SqlCommand(word_insert.readPath(path_wordInsert), sqlconn)
                    Dim Ins As New SqlParameter("@a", txtWord.Text)
                    Dim Ins2 As New SqlParameter("@b", txtEnglishWord.Text)
                    comm.Parameters.Add(Ins)
                    comm.Parameters.Add(Ins2)
                    comm.Transaction = tran
                    Dim ret2 As String = comm.ExecuteNonQuery()
                End If

                'コミット
                tran.Commit()
                ClearTextBox(Me)

            Catch ex As Exception

                'ロールバック
                tran.Rollback()
                Throw

            End Try

            MsgBox("処理終了")

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

    End Sub

    Public Shared Sub ClearTextBox(ByVal hParent As Control)
        For Each clearBox As Control In hParent.Controls
            If clearBox.HasChildren = True Then
                ClearTextBox(clearBox)
            End If

            If TypeOf clearBox Is TextBoxBase Then
                clearBox.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click

        Dim wordList As Form6 = New Form6
        wordList.Visible = True

    End Sub
End Class