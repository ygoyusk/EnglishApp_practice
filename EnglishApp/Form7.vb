Imports System.Data
Imports System.Data.SqlClient

Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'SQLserver接続
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try

                'SQL文作成
                Dim count_judg As Sql_Multiple = New Sql_Multiple
                Dim path1 As String
                path1 = "SQLQuery_count_judg"
                Call count_judg.readPath(path1)

                Dim count_question As Sql_Multiple = New Sql_Multiple
                Dim path2 As String
                path2 = "SQLQuery_count_Question"
                Call count_question.readPath(path2)

                'SQL実行
                Dim command_judg As New SqlCommand(count_judg.readPath(path1), sqlconn)
                Dim adapter_judg As New SqlDataAdapter(command_judg)
                Dim dt_judg As New DataTable
                adapter_judg.Fill(dt_judg)

                Dim command_question As New SqlCommand(count_question.readPath(path2), sqlconn)
                Dim adapter_question As New SqlDataAdapter(command_question)
                Dim dt_question As New DataTable
                adapter_question.Fill(dt_question)

                lblCountAnswer.Text = dt_judg.Rows(0).Item(0) & "問"
                lblCountQuestion.Text = dt_question.Rows(0).Item(0) & "問"

                Label9.Text = CInt(dt_judg.Rows(0).Item(0) / dt_question.Rows(0).Item(0) * 100) & "％"

            Catch ex As Exception
                Throw
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim frm2 As Form2 = New Form2
        frm2.Visible = True
        Me.Hide()

    End Sub
End Class