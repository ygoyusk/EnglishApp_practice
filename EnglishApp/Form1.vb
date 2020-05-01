Public Class FrmWordApp

    '初期表示
    Private Sub FrmWordApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '単語のロード
        Dim arr_question() As String = {"りんご", "学校", "鉛筆", "机", "鞄", "本", "部屋", "コップ", "椅子", "頭"}
        Dim arr_answer() As String = {"apple", "school", "pencil", "desk", "bag", "book", "room", "cup", "chair", "head"}
        ReDim Preserve arr_question(10)
        ReDim Preserve arr_answer(10)
        arr_question(10) = "ネズミ"
        arr_answer(10) = "rat"
        Dim Int_count As Integer = 1


        '初期値
        lblCount.Text = Int_count.ToString
        lblQuestion.Text = arr_question(Int_count - 1)
        txtAnswer.Text = ""
        lblAnswer.Text = arr_answer(Int_count - 1)
        lblJudgment.Text = ""

        '表示・非表示
        lblAnswer.Visible = False
        lblJudgment.Visible = False

        '使用可否
        If Int_count = 1 Then
            btnBack.Enabled = False
        Else
            btnBack.Enabled = True
        End If

        If Int_count = 11 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If

    End Sub

    '正誤判定処理
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

    '前の問題ボタン押下時処理
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'ロード処理
        Dim arr_question() As String = {"りんご", "学校", "鉛筆", "机", "鞄", "本", "部屋", "コップ", "椅子", "頭"}
        Dim arr_answer() As String = {"apple", "school", "pencil", "desk", "bag", "book", "room", "cup", "chair", "head"}
        ReDim Preserve arr_question(10)
        ReDim Preserve arr_answer(10)
        arr_question(10) = "ネズミ"
        arr_answer(10) = "rat"
        Dim int_count As Integer = CInt(lblCount.Text) - 1

        '初期値
        lblCount.Text = int_count.ToString
        lblQuestion.Text = arr_question(int_count - 1)
        txtAnswer.Text = ""
        lblAnswer.Text = arr_answer(int_count - 1)
        lblJudgment.Text = ""

        '表示・非表示
        lblAnswer.Visible = False
        lblJudgment.Visible = False

        'ボタン使用可否
        If int_count = 1 Then
            btnBack.Enabled = False
        Else
            btnBack.Enabled = True
        End If

        If int_count = 11 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If
    End Sub

    '次の問題ボタン押下時処理
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'ロード処理
        Dim arr_question() As String = {"りんご", "学校", "鉛筆", "机", "鞄", "本", "部屋", "コップ", "椅子", "頭"}
        Dim arr_answer() As String = {"apple", "school", "pencil", "desk", "bag", "book", "room", "cup", "chair", "head"}
        ReDim Preserve arr_question(10)
        ReDim Preserve arr_answer(10)
        arr_question(10) = "ネズミ"
        arr_answer(10) = "rat"
        Dim int_count As Integer = CInt(lblCount.Text) + 1

        Console.Write(arr_question(10))

        '初期値
        lblCount.Text = int_count.ToString
        lblQuestion.Text = arr_question(int_count - 1)
        txtAnswer.Text = ""
        lblAnswer.Text = arr_answer(int_count - 1)
        lblJudgment.Text = ""

        '表示・非表示
        lblAnswer.Visible = False
        lblJudgment.Visible = False

        'ボタン使用可否
        If int_count = 1 Then
            btnBack.Enabled = False
        Else
            btnBack.Enabled = True
        End If

        If int_count = 11 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If
    End Sub

End Class