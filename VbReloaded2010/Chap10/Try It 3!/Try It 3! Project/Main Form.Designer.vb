<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.padRight2Button = New System.Windows.Forms.Button()
        Me.padLeft1Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.padLeft3Button = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.padLeft3Button)
        Me.GroupBox3.Controls.Add(Me.padRight2Button)
        Me.GroupBox3.Controls.Add(Me.padLeft1Button)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(215, 137)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PadLeft and PadRight methods"
        '
        'padRight2Button
        '
        Me.padRight2Button.Location = New System.Drawing.Point(55, 56)
        Me.padRight2Button.Name = "padRight2Button"
        Me.padRight2Button.Size = New System.Drawing.Size(104, 26)
        Me.padRight2Button.TabIndex = 1
        Me.padRight2Button.Text = "Example &2"
        Me.padRight2Button.UseVisualStyleBackColor = True
        '
        'padLeft1Button
        '
        Me.padLeft1Button.Location = New System.Drawing.Point(55, 24)
        Me.padLeft1Button.Name = "padLeft1Button"
        Me.padLeft1Button.Size = New System.Drawing.Size(104, 26)
        Me.padLeft1Button.TabIndex = 0
        Me.padLeft1Button.Text = "Example &1"
        Me.padLeft1Button.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(158, 155)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(69, 26)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'padLeft3Button
        '
        Me.padLeft3Button.Location = New System.Drawing.Point(55, 88)
        Me.padLeft3Button.Name = "padLeft3Button"
        Me.padLeft3Button.Size = New System.Drawing.Size(104, 26)
        Me.padLeft3Button.TabIndex = 2
        Me.padLeft3Button.Text = "Example &3"
        Me.padLeft3Button.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 201)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Try It 3!"
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents padRight2Button As System.Windows.Forms.Button
    Friend WithEvents padLeft1Button As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents padLeft3Button As System.Windows.Forms.Button

End Class
