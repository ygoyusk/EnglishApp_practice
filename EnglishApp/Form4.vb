Imports System.Data
Imports System.Data.SqlClient

Public Class frmLOGON

    Private Sub btnLogon_Click(sender As Object, e As EventArgs) Handles btnLogon.Click

        Dim userId() As String
        Dim password() As String

        'lblErrorMsg.Visible = False

        Try

            'SQLserver接続
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try

                'SQL作成
                Dim read As Sql_Multiple = New Sql_Multiple
                Dim path_btnLogin As String
                path_btnLogin = "SQLQuery_Login"
                Call read.readPath(path_btnLogin)

                'SQL実行
                'Dim command As New SqlCommand(sql.ToString, sqlconn)
                Dim command As New SqlCommand(read.readPath(path_btnLogin), sqlconn)
                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable
                adapter.Fill(dt)

                '配列数を決める
                ReDim Preserve userId(dt.Rows.Count)
                ReDim Preserve password(dt.Rows.Count)

                '配列にDBの値を入れていく
                For colindex As Integer = 0 To dt.Columns.Count - 1
                    For rowindex As Integer = 0 To dt.Rows.Count - 1

                        If colindex = 0 Then
                            userId(rowindex) = dt.Rows(rowindex).Item(colindex).ToString
                        ElseIf colindex = 1 Then
                            password(rowindex) = dt.Rows(rowindex).Item(colindex).ToString
                        Else
                            Exit For
                        End If

                    Next
                Next

                For i As Integer = 0 To dt.Rows.Count - 1

                    'ログインできた時の処理
                    If txtUserID.Text = userId(i) Then
                        If txtPassword.Text = password(i) Then
                            Dim frm2 As Form2 = New Form2
                            frm2.Visible = True
                            Me.Hide()
                            Exit For
                        Else
                            lblErrorMsg.Visible = True
                            lblErrorMsg.ForeColor = ForeColor.Red
                        End If
                    Else
                        lblErrorMsg.Visible = True
                        lblErrorMsg.ForeColor = ForeColor.Red
                    End If

                Next

                'Me.Hide()

            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub frmLOGON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userId() As String
        Dim password() As String

        lblErrorMsg.Visible = False
        txtPassword.PasswordChar = "*"c

        Try

            'SQLserver接続
            Dim sqlconn As New SqlConnection(My.Settings.sqlServer)
            sqlconn.Open()

            Try

                'SQL作成
                'Dim sql As New System.Text.StringBuilder
                'sql.AppendLine("SELECT")
                'sql.AppendLine(" *")
                'sql.AppendLine(" FROM LOGINTable")
                Dim read As Sql_Multiple = New Sql_Multiple
                Dim path As String
                path = "SQLQuery_Login"
                Call read.readPath(path)

                'SQL実行
                'Dim command As New SqlCommand(sql.ToString, sqlconn)
                Dim command As New SqlCommand(read.readPath(path), sqlconn)
                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable
                adapter.Fill(dt)

                '問と答えの配列数を決める
                ReDim Preserve userId(dt.Rows.Count)
                ReDim Preserve password(dt.Rows.Count)

                '配列にDBの値を入れていく
                For colindex As Integer = 0 To dt.Columns.Count - 1
                    For rowindex As Integer = 0 To dt.Rows.Count - 1

                        If colindex = 0 Then
                            userId(rowindex) = dt.Rows(rowindex).Item(colindex).ToString
                        ElseIf colindex = 1 Then
                            password(rowindex) = dt.Rows(rowindex).Item(colindex).ToString
                        Else
                            Exit For
                        End If

                    Next
                Next

                'For i As Integer = 0 To dt.Rows.Count - 1

                '    If txtUserID.Text = userId(i) Then
                '        If txtPassword.Text = password(i) Then
                '            'ログインできた時の処理
                '            Dim frm2 As Form2 = New Form2
                '            Me.Close()
                '            frm2.ShowDialog()
                '        Else
                '            lblErrorMsg.Visible = True
                '            lblErrorMsg.ForeColor = ForeColor.Red
                '        End If
                '    Else
                '        lblErrorMsg.Visible = True
                '        lblErrorMsg.ForeColor = ForeColor.Red
                '    End If

                'Next

            Catch ex As Exception
                Throw
            Finally
                sqlconn.Close()
            End Try
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class