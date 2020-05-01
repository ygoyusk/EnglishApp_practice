<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblJudgment = New System.Windows.Forms.Label()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNext.Location = New System.Drawing.Point(500, 323)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(175, 75)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "次の問題"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAnswer.Location = New System.Drawing.Point(134, 226)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(101, 67)
        Me.btnAnswer.TabIndex = 1
        Me.btnAnswer.Text = "答え"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(403, 106)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(272, 55)
        Me.txtAnswer.TabIndex = 2
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(126, 109)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(116, 48)
        Me.lblQuestion.TabIndex = 3
        Me.lblQuestion.Text = "問題"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(395, 230)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(106, 48)
        Me.lblAnswer.TabIndex = 4
        Me.lblAnswer.Text = "答え"
        '
        'lblJudgment
        '
        Me.lblJudgment.AutoSize = True
        Me.lblJudgment.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblJudgment.Location = New System.Drawing.Point(559, 230)
        Me.lblJudgment.Name = "lblJudgment"
        Me.lblJudgment.Size = New System.Drawing.Size(116, 48)
        Me.lblJudgment.TabIndex = 5
        Me.lblJudgment.Text = "判定"
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblcount.Location = New System.Drawing.Point(79, 30)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(55, 35)
        Me.lblcount.TabIndex = 7
        Me.lblcount.Text = "No"
        '
        'btnEnd
        '
        Me.btnEnd.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(595, 29)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(80, 36)
        Me.btnEnd.TabIndex = 9
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 35)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "第"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 35)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "問"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.lblJudgment)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "frmTest"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Windows.Forms.Button
    Friend WithEvents btnAnswer As Windows.Forms.Button
    Friend WithEvents txtAnswer As Windows.Forms.TextBox
    Friend WithEvents lblQuestion As Windows.Forms.Label
    Friend WithEvents lblAnswer As Windows.Forms.Label
    Friend WithEvents lblJudgment As Windows.Forms.Label
    Friend WithEvents lblcount As Windows.Forms.Label
    Friend WithEvents btnEnd As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
