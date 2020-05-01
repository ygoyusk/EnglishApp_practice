<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWordApp
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblJudgment = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCount.Location = New System.Drawing.Point(29, 21)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(111, 33)
        Me.lblCount.TabIndex = 0
        Me.lblCount.Text = "問題数"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(66, 84)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(116, 48)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "出題"
        '
        'btnAnswer
        '
        Me.btnAnswer.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAnswer.Location = New System.Drawing.Point(86, 183)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(85, 48)
        Me.btnAnswer.TabIndex = 2
        Me.btnAnswer.Text = "答え"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnBack.Location = New System.Drawing.Point(33, 319)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(247, 101)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "前の問題"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNext.Location = New System.Drawing.Point(419, 319)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(247, 101)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "次の問題"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(331, 84)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(335, 55)
        Me.txtAnswer.TabIndex = 5
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(323, 183)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(106, 48)
        Me.lblAnswer.TabIndex = 6
        Me.lblAnswer.Text = "答え"
        '
        'lblJudgment
        '
        Me.lblJudgment.AutoSize = True
        Me.lblJudgment.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblJudgment.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblJudgment.Location = New System.Drawing.Point(513, 169)
        Me.lblJudgment.Name = "lblJudgment"
        Me.lblJudgment.Size = New System.Drawing.Size(92, 64)
        Me.lblJudgment.TabIndex = 7
        Me.lblJudgment.Text = "○"
        '
        'FrmWordApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.Controls.Add(Me.lblJudgment)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblCount)
        Me.Name = "FrmWordApp"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCount As Windows.Forms.Label
    Friend WithEvents lblQuestion As Windows.Forms.Label
    Friend WithEvents btnAnswer As Windows.Forms.Button
    Friend WithEvents btnBack As Windows.Forms.Button
    Friend WithEvents btnNext As Windows.Forms.Button
    Friend WithEvents txtAnswer As Windows.Forms.TextBox
    Friend WithEvents lblAnswer As Windows.Forms.Label
    Friend WithEvents lblJudgment As Windows.Forms.Label
End Class
