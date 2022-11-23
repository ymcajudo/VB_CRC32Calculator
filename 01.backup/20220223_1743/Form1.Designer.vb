<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tb_InputData = New System.Windows.Forms.TextBox()
        Me.rb_ASCII = New System.Windows.Forms.RadioButton()
        Me.rb_Hex = New System.Windows.Forms.RadioButton()
        Me.bt_CRC32 = New System.Windows.Forms.Button()
        Me.tb_CRCResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_InputData
        '
        Me.tb_InputData.Location = New System.Drawing.Point(144, 23)
        Me.tb_InputData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_InputData.Multiline = True
        Me.tb_InputData.Name = "tb_InputData"
        Me.tb_InputData.Size = New System.Drawing.Size(526, 252)
        Me.tb_InputData.TabIndex = 0
        '
        'rb_ASCII
        '
        Me.rb_ASCII.AutoSize = True
        Me.rb_ASCII.Location = New System.Drawing.Point(172, 341)
        Me.rb_ASCII.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rb_ASCII.Name = "rb_ASCII"
        Me.rb_ASCII.Size = New System.Drawing.Size(59, 20)
        Me.rb_ASCII.TabIndex = 1
        Me.rb_ASCII.TabStop = True
        Me.rb_ASCII.Text = "ASCII"
        Me.rb_ASCII.UseVisualStyleBackColor = True
        '
        'rb_Hex
        '
        Me.rb_Hex.AutoSize = True
        Me.rb_Hex.Location = New System.Drawing.Point(172, 299)
        Me.rb_Hex.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rb_Hex.Name = "rb_Hex"
        Me.rb_Hex.Size = New System.Drawing.Size(48, 20)
        Me.rb_Hex.TabIndex = 2
        Me.rb_Hex.TabStop = True
        Me.rb_Hex.Text = "Hex"
        Me.rb_Hex.UseVisualStyleBackColor = True
        '
        'bt_CRC32
        '
        Me.bt_CRC32.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_CRC32.Location = New System.Drawing.Point(495, 299)
        Me.bt_CRC32.Name = "bt_CRC32"
        Me.bt_CRC32.Size = New System.Drawing.Size(175, 64)
        Me.bt_CRC32.TabIndex = 3
        Me.bt_CRC32.Text = "CRC-32"
        Me.bt_CRC32.UseVisualStyleBackColor = True
        '
        'tb_CRCResult
        '
        Me.tb_CRCResult.Location = New System.Drawing.Point(279, 340)
        Me.tb_CRCResult.Name = "tb_CRCResult"
        Me.tb_CRCResult.Size = New System.Drawing.Size(162, 23)
        Me.tb_CRCResult.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Input Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CRC-32 result"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(419, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Copyright 2022. Myeongjin Kim. All rights reserved."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 410)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_CRCResult)
        Me.Controls.Add(Me.bt_CRC32)
        Me.Controls.Add(Me.rb_Hex)
        Me.Controls.Add(Me.rb_ASCII)
        Me.Controls.Add(Me.tb_InputData)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "CRC-32 Calculator by MJ Kim"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_InputData As TextBox
    Friend WithEvents rb_ASCII As RadioButton
    Friend WithEvents rb_Hex As RadioButton
    Friend WithEvents bt_CRC32 As Button
    Friend WithEvents tb_CRCResult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
