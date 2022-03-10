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
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.fontButton = New System.Windows.Forms.Button()
        Me.colorButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Location = New System.Drawing.Point(44, 35)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(242, 15)
        Me.messageLabel.TabIndex = 3
        Me.messageLabel.Text = "Examples of the Font and Color Dialog Boxes"
        '
        'fontButton
        '
        Me.fontButton.Location = New System.Drawing.Point(223, 81)
        Me.fontButton.Name = "fontButton"
        Me.fontButton.Size = New System.Drawing.Size(75, 23)
        Me.fontButton.TabIndex = 0
        Me.fontButton.Text = "&Font"
        Me.fontButton.UseVisualStyleBackColor = True
        '
        'colorButton
        '
        Me.colorButton.Location = New System.Drawing.Point(223, 111)
        Me.colorButton.Name = "colorButton"
        Me.colorButton.Size = New System.Drawing.Size(75, 23)
        Me.colorButton.TabIndex = 1
        Me.colorButton.Text = "&Color"
        Me.colorButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(223, 141)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 210)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.colorButton)
        Me.Controls.Add(Me.fontButton)
        Me.Controls.Add(Me.messageLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dialog Examples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents messageLabel As System.Windows.Forms.Label
    Friend WithEvents fontButton As System.Windows.Forms.Button
    Friend WithEvents colorButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
