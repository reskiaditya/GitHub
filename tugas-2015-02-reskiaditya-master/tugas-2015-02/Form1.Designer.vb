<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kalkulator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.samadengan = New System.Windows.Forms.Button()
        Me.minus = New System.Windows.Forms.Button()
        Me.plus = New System.Windows.Forms.Button()
        Me.clearr = New System.Windows.Forms.Button()
        Me.kali = New System.Windows.Forms.Button()
        Me.Bagi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.Location = New System.Drawing.Point(8, 13)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(225, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(55, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(101, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(9, 85)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 40)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(55, 85)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 40)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(101, 85)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 40)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(9, 39)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(40, 40)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(55, 39)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(40, 40)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(101, 39)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(40, 40)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(9, 177)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(40, 40)
        Me.Button10.TabIndex = 0
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'samadengan
        '
        Me.samadengan.Location = New System.Drawing.Point(55, 177)
        Me.samadengan.Name = "samadengan"
        Me.samadengan.Size = New System.Drawing.Size(86, 40)
        Me.samadengan.TabIndex = 11
        Me.samadengan.Text = "="
        Me.samadengan.UseVisualStyleBackColor = True
        '
        'minus
        '
        Me.minus.Location = New System.Drawing.Point(147, 177)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(40, 40)
        Me.minus.TabIndex = 13
        Me.minus.Text = "-"
        Me.minus.UseVisualStyleBackColor = True
        '
        'plus
        '
        Me.plus.Location = New System.Drawing.Point(147, 131)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(40, 40)
        Me.plus.TabIndex = 12
        Me.plus.Text = "+"
        Me.plus.UseVisualStyleBackColor = True
        '
        'clearr
        '
        Me.clearr.Location = New System.Drawing.Point(147, 39)
        Me.clearr.Name = "clearr"
        Me.clearr.Size = New System.Drawing.Size(86, 86)
        Me.clearr.TabIndex = 14
        Me.clearr.Text = "clear"
        Me.clearr.UseVisualStyleBackColor = True
        '
        'kali
        '
        Me.kali.Location = New System.Drawing.Point(193, 131)
        Me.kali.Name = "kali"
        Me.kali.Size = New System.Drawing.Size(40, 40)
        Me.kali.TabIndex = 15
        Me.kali.Text = "*"
        Me.kali.UseVisualStyleBackColor = True
        '
        'Bagi
        '
        Me.Bagi.Location = New System.Drawing.Point(193, 177)
        Me.Bagi.Name = "Bagi"
        Me.Bagi.Size = New System.Drawing.Size(40, 40)
        Me.Bagi.TabIndex = 16
        Me.Bagi.Text = "/"
        Me.Bagi.UseVisualStyleBackColor = True
        '
        'Kalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 226)
        Me.Controls.Add(Me.Bagi)
        Me.Controls.Add(Me.kali)
        Me.Controls.Add(Me.clearr)
        Me.Controls.Add(Me.plus)
        Me.Controls.Add(Me.minus)
        Me.Controls.Add(Me.samadengan)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Kalkulator"
        Me.Text = "Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents samadengan As System.Windows.Forms.Button
    Friend WithEvents minus As System.Windows.Forms.Button
    Friend WithEvents plus As System.Windows.Forms.Button
    Friend WithEvents clearr As System.Windows.Forms.Button
    Friend WithEvents kali As System.Windows.Forms.Button
    Friend WithEvents Bagi As System.Windows.Forms.Button

End Class
