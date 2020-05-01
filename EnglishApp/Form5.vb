Imports System.Data
Imports System.Data.SqlClient

Public Class frmTest
    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim arr_question() As String
        Dim arr_answer() As String
        Dim int_count As Integer = 1

        '初期値
        lblcount.Text = int_count.ToString
        lblAnswer.Text = ""
        lblJudgment.Text = ""

        '表示・非表示
        lblAnswer.Visible = False
        lblJudgment.Visible = False

        btnAnswer.Enabled = True

        Try
            'SQLserver接続
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try

                'SQL作成
                'Dim sql As New System.Text.StringBuilder
                'sql.AppendLine("SELECT")
                'sql.AppendLine(" *")
                'sql.AppendLine(" FROM QATable")

                Dim read As Sql_Multiple = New Sql_Multiple
                Dim path As String
                path = "SQLQuery2"
                Call read.readPath(path)

                Dim delSql As Sql_Multiple = New Sql_Multiple
                Dim path2 As String
                path2 = "SQLQuery_del"
                Call delSql.readPath(path2)

                'SQL実行
                'Dim command As New SqlCommand(sql.ToString, sqlconn)
                Dim command As New SqlCommand(read.readPath(path), sqlconn)
                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable
                adapter.Fill(dt)

                Dim command2 As New SqlCommand(delSql.readPath(path2), sqlconn)
                Dim adapter2 As New SqlDataAdapter(command2)
                Dim dt2 As New DataTable
                adapter2.Fill(dt2)

                '問と答えの配列数を決める
                ReDim Preserve arr_question(dt.Rows.Count)
                ReDim Preserve arr_answer(dt.Rows.Count)

                '配列にDBの値を入れていく
                For colindex As Integer = 0 To dt.Columns.Count - 1
                    For rowindex As Integer = 0 To dt.Rows.Count - 1

                        If colindex = 0 Then
                            arr_question(rowindex) = dt.Rows(rowindex).Item(colindex).ToString
                        ElseIf colindex = 1 Then
                            arr_answer(rowindex) = dt.Rows(rowindex).Item(colindex).ToString
                        Else
                            Exit For
                        End If

                    Next
                Next

                '初期値
                lblQuestion.Text = arr_question(int_count - 1)
                lblAnswer.Text = arr_answer(int_count - 1)

                If int_count = dt.Rows.Count Then
                    btnEnd.Enabled = True
                Else
                    btnEnd.Visible = False
                    btnEnd.Enabled = False
                End If

            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click

        Try

            'SQLserver接続
            Dim connstr As String = My.Settings.sqlServer
            Dim sqlconn As New SqlConnection(connstr)
            Dim comm As New SqlCommand
            sqlconn.Open()

            'トランザクション
            Dim tran As SqlTransaction
            tran = sqlconn.BeginTransaction

            Try

                Dim read_judg As Sql_Multiple = New Sql_Multiple
                Dim path_judg_ins As String
                path_judg_ins = "SQLQuery_judg1"
                Call read_judg.readPath(path_judg_ins)

                'SQL実行
                comm = New SqlCommand(read_judg.readPath(path_judg_ins), sqlconn)
                Dim Ins As New SqlParameter
                Dim Ins2 As New SqlParameter

                '正解判定
                If txtAnswer.Text = lblAnswer.Text Then
                    lblJudgment.Text = "○"
                    lblJudgment.ForeColor = ForeColor.Blue
                    Ins = New SqlParameter("@a", lblcount.Text)
                    Ins2 = New SqlParameter("@b", 1)
                    comm.Parameters.Add(Ins)
                    comm.Parameters.Add(Ins2)
                    comm.Transaction = tran
                    Dim ret2 As String = comm.ExecuteNonQuery()
                Else
                    lblJudgment.Text = "×"
                    lblJudgment.ForeColor = ForeColor.Red
                    Ins = New SqlParameter("@a", lblcount.Text)
                    Ins2 = New SqlParameter("@b", 0)
                    comm.Parameters.Add(Ins)
                    comm.Parameters.Add(Ins2)
                    comm.Transaction = tran
                    Dim ret2 As String = comm.ExecuteNonQuery()
                End If

                'コミット
                tran.Commit()

            Catch ex As Exception

                'ロールバック
                tran.Rollback()
                Throw

            End Try

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

        '表示・非表示
        lblAnswer.Visible = True
        lblJudgment.Visible = True

        btnAnswer.Enabled = False

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Dim arr_question() As String
        Dim arr_answer() As String
        Dim int_count As Integer = CInt(lblcount.Text) + 1

        '初期値
        lblcount.Text = int_count.ToString
        txtAnswer.Text = ""
        lblJudgment.Text = ""

        '表示・非表示
        lblAnswer.Visible = False
        lblJudgment.Visible = False

        btnAnswer.Enabled = True

        Try

            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try

                'SQL作成
                'Dim sql As New System.Text.StringBuilder
                'sql.AppendLine("SELECT")
                'sql.AppendLine(" *")
                'sql.AppendLine(" FROM QATable")
                Dim read As Sql_Multiple = New Sql_Multiple
                Dim path_load As String
                path_load = "SQLQuery2"
                Call read.readPath(path_load)

                'SQL実行
                Dim command As New SqlCommand(read.readPath(path_load), sqlconn)
                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable
                adapter.Fill(dt)

                '問と答えの配列数を決める
                ReDim Preserve arr_question(dt.Rows.Count)
                ReDim Preserve arr_answer(dt.Rows.Count)

                '配列にDBの値を入れていく
                For colindex As Integer = 0 To dt.Columns.Count - 1
                    For rowindex As Integer = 0 To dt.Rows.Count - 1

                        If colindex = 0 Then
                            arr_question(rowindex) = dt.Rows(rowindex).Item(colindex).ToString
                        ElseIf colindex = 1 Then
                            arr_answer(rowindex) = dt.Rows(rowindex).Item(colindex).ToString
                        Else
                            Exit For
                        End If

                    Next
                Next

                '初期値
                lblQuestion.Text = arr_question(int_count - 1)
                lblAnswer.Text = arr_answer(int_count - 1)

                '「次の問題」ボタン使用可否
                If int_count = dt.Rows.Count Then
                    btnNext.Enabled = False
                Else
                    btnNext.Enabled = True
                End If

                If int_count = dt.Rows.Count Then
                    btnEnd.Visible = True
                    btnEnd.Enabled = True
                Else
                    btnEnd.Visible = False
                End If

            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click

        Dim result As Form7 = New Form7
        result.Visible = True
        Me.Hide()

    End Sub
End Class