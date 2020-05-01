Imports System.Data
Imports System.Data.SqlClient

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'SQLserver接続
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try

                'SQL文作成
                Dim read As Sql_Multiple = New Sql_Multiple
                Dim path As String
                path = "SQLQuery2"
                Call read.readPath(path)

                'SQL実行
                Dim command As New SqlCommand(read.readPath(path), sqlconn)
                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable
                adapter.Fill(dt)

                'DataGridViewにDBの内容を表示
                dgvWordCollection.DataSource = dt

            Catch ex As Exception

                Throw

            End Try

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

    End Sub
End Class