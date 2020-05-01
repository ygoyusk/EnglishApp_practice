Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim arr_question() As String
        Dim arr_answer() As String
        Dim int_count As Integer = 1

        '初期値
        lblcount.Text = int_count.ToString
        txtAnswer.Text = ""
        lblJudgment.Text = ""

        '表示・非表示
        lblAnswer.Visible = False
        lblJudgment.Visible = False

        '「前の問題」ボタン使用可否
        If int_count = 1 Then
            btnBack.Enabled = False
        Else
            btnBack.Enabled = True
        End If

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
                Dim path_load As String
                path_load = "SQLQuery2"
                Call read.readPath(path_load)

                'Dim fileName As String = ".\SQL\SQLQuery2.sql"
                'If System.IO.File.Exists(fileName) = False Then
                '    Return
                'End If

                'Dim sr As New System.IO.StreamReader(".\SQL\SQLQuery2.sql", System.Text.Encoding.Default)
                'Dim strSql As String = sr.ReadToEnd()
                'sr.Close()

                'SQL実行
                'Dim command As New SqlCommand(Sql.ToString, sqlconn)
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

        '正解判定
        If txtAnswer.Text = lblAnswer.Text Then
            lblJudgment.Text = "○"
            lblJudgment.ForeColor = ForeColor.Blue
        Else
            lblJudgment.Text = "×"
            lblJudgment.ForeColor = ForeColor.Red
        End If

        '表示・非表示
        lblAnswer.Visible = True
        lblJudgment.Visible = True

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim arr_question() As String
        Dim arr_answer() As String
        Dim int_count As Integer = CInt(lblcount.Text) - 1

        '初期値
        lblcount.Text = int_count.ToString
        txtAnswer.Text = ""
        lblJudgment.Text = ""

        '表示・非表示
        lblAnswer.Visible = False
        lblJudgment.Visible = False

        '「前の問題」ボタン使用可否
        If int_count = 1 Then
            btnBack.Enabled = False
        Else
            btnBack.Enabled = True
        End If

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
                Dim path_btnBack As String
                path_btnBack = "SQLQuery2"
                Call read.readPath(path_btnBack)

                'SQL実行
                'Dim command As New SqlCommand(Sql.ToString, sqlconn)
                Dim command As New SqlCommand(read.readPath(path_btnBack), sqlconn)
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

            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try
        Catch ex As Exception
            Throw
        End Try

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

        '「前の問題」ボタン使用可否
        If int_count = 1 Then
            btnBack.Enabled = False
        Else
            btnBack.Enabled = True
        End If

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
                Dim path_btnNext As String
                path_btnNext = "SQLQuery2"
                Call read.readPath(path_btnNext)

                'SQL実行
                'Dim command As New SqlCommand(Sql.ToString, sqlconn)
                Dim command As New SqlCommand(read.readPath(path_btnNext), sqlconn)
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

            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim frm3 As Form3 = New Form3
        frm3.Visible = True

    End Sub

    Private Sub btnLOGOUT_Click(sender As Object, e As EventArgs) Handles btnLOGOUT.Click

        Dim frmIn As frmLOGON = New frmLOGON
        frmIn.Visible = True
        Me.Hide()

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        Dim frmTe As frmTest = New frmTest
        frmTe.Visible = True
        Me.Hide()

    End Sub

End Class