<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.lblCountAnswer = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCountQuestion = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCountAnswer
        '
        Me.lblCountAnswer.AutoSize = True
        Me.lblCountAnswer.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCountAnswer.Location = New System.Drawing.Point(122, 180)
        Me.lblCountAnswer.Name = "lblCountAnswer"
        Me.lblCountAnswer.Size = New System.Drawing.Size(234, 97)
        Me.lblCountAnswer.TabIndex = 0
        Me.lblCountAnswer.Text = "正答"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(362, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 97)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "/"
        '
        'lblCountQuestion
        '
        Me.lblCountQuestion.AutoSize = True
        Me.lblCountQuestion.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCountQuestion.Location = New System.Drawing.Point(458, 180)
        Me.lblCountQuestion.Name = "lblCountQuestion"
        Me.lblCountQuestion.Size = New System.Drawing.Size(234, 97)
        Me.lblCountQuestion.TabIndex = 3
        Me.lblCountQuestion.Text = "全問"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(394, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 97)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "％"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(330, 97)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "正解数"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(433, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(330, 97)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "回答数"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(228, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(330, 97)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "正答率"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(664, 383)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 31)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCountQuestion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCountAnswer)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCountAnswer As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents lblCountQuestion As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents btnClose As Windows.Forms.Button
End Class
