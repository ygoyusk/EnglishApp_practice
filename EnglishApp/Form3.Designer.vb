<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblWrod = New System.Windows.Forms.Label()
        Me.lblEnglishWord = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.txtEnglishWord = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReflect = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWrod
        '
        Me.lblWrod.AutoSize = True
        Me.lblWrod.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblWrod.Location = New System.Drawing.Point(160, 97)
        Me.lblWrod.Name = "lblWrod"
        Me.lblWrod.Size = New System.Drawing.Size(120, 35)
        Me.lblWrod.TabIndex = 0
        Me.lblWrod.Text = "日本語"
        '
        'lblEnglishWord
        '
        Me.lblEnglishWord.AutoSize = True
        Me.lblEnglishWord.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblEnglishWord.Location = New System.Drawing.Point(160, 190)
        Me.lblEnglishWord.Name = "lblEnglishWord"
        Me.lblEnglishWord.Size = New System.Drawing.Size(85, 35)
        Me.lblEnglishWord.TabIndex = 1
        Me.lblEnglishWord.Text = "英語"
        '
        'txtWord
        '
        Me.txtWord.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtWord.Location = New System.Drawing.Point(339, 90)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(219, 42)
        Me.txtWord.TabIndex = 2
        '
        'txtEnglishWord
        '
        Me.txtEnglishWord.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtEnglishWord.Location = New System.Drawing.Point(339, 183)
        Me.txtEnglishWord.Name = "txtEnglishWord"
        Me.txtEnglishWord.Size = New System.Drawing.Size(219, 42)
        Me.txtEnglishWord.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClose.Location = New System.Drawing.Point(142, 318)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(143, 61)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReflect
        '
        Me.btnReflect.Font = New System.Drawing.Font("MS UI Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnReflect.Location = New System.Drawing.Point(496, 318)
        Me.btnReflect.Name = "btnReflect"
        Me.btnReflect.Size = New System.Drawing.Size(143, 61)
        Me.btnReflect.TabIndex = 5
        Me.btnReflect.Text = "反映"
        Me.btnReflect.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnList.Location = New System.Drawing.Point(586, 30)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(152, 43)
        Me.btnList.TabIndex = 6
        Me.btnList.Text = "登録単語一覧"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnReflect)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtEnglishWord)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblEnglishWord)
        Me.Controls.Add(Me.lblWrod)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWrod As Windows.Forms.Label
    Friend WithEvents lblEnglishWord As Windows.Forms.Label
    Friend WithEvents txtWord As Windows.Forms.TextBox
    Friend WithEvents txtEnglishWord As Windows.Forms.TextBox
    Friend WithEvents btnClose As Windows.Forms.Button
    Friend WithEvents btnReflect As Windows.Forms.Button
    Friend WithEvents btnList As Windows.Forms.Button
End Class
