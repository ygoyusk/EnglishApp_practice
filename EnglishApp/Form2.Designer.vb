<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblJudgment = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLOGOUT = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnBack.Location = New System.Drawing.Point(103, 323)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(170, 70)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "前の問題"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNext.Location = New System.Drawing.Point(507, 323)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(180, 70)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "次の問題"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAnswer.Location = New System.Drawing.Point(169, 222)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(104, 59)
        Me.btnAnswer.TabIndex = 2
        Me.btnAnswer.Text = "答え"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button4.Location = New System.Drawing.Point(642, 125)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 46)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "問題追加"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(367, 120)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(248, 55)
        Me.txtAnswer.TabIndex = 4
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(359, 222)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(106, 48)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.Text = "答え"
        '
        'lblJudgment
        '
        Me.lblJudgment.AutoSize = True
        Me.lblJudgment.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblJudgment.Location = New System.Drawing.Point(499, 222)
        Me.lblJudgment.Name = "lblJudgment"
        Me.lblJudgment.Size = New System.Drawing.Size(116, 48)
        Me.lblJudgment.TabIndex = 6
        Me.lblJudgment.Text = "判定"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(176, 123)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(116, 48)
        Me.lblQuestion.TabIndex = 7
        Me.lblQuestion.Text = "問題"
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblcount.Location = New System.Drawing.Point(68, 30)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(55, 35)
        Me.lblcount.TabIndex = 8
        Me.lblcount.Text = "No"
        Me.lblcount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 35)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "第"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 35)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "問"
        '
        'btnLOGOUT
        '
        Me.btnLOGOUT.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnLOGOUT.Location = New System.Drawing.Point(694, 30)
        Me.btnLOGOUT.Name = "btnLOGOUT"
        Me.btnLOGOUT.Size = New System.Drawing.Size(100, 30)
        Me.btnLOGOUT.TabIndex = 11
        Me.btnLOGOUT.Text = "ログアウト"
        Me.btnLOGOUT.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTest.Location = New System.Drawing.Point(507, 32)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(136, 39)
        Me.btnTest.TabIndex = 12
        Me.btnTest.Text = "テストモード"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnLOGOUT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblJudgment)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Windows.Forms.Button
    Friend WithEvents btnNext As Windows.Forms.Button
    Friend WithEvents btnAnswer As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents txtAnswer As Windows.Forms.TextBox
    Friend WithEvents lblAnswer As Windows.Forms.Label
    Friend WithEvents lblJudgment As Windows.Forms.Label
    Friend WithEvents lblQuestion As Windows.Forms.Label
    Friend WithEvents lblcount As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btnLOGOUT As Windows.Forms.Button
    Friend WithEvents btnTest As Windows.Forms.Button
End Class
