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
        Me.carPictureBox = New System.Windows.Forms.PictureBox()
        Me.msgLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clickMeButton = New System.Windows.Forms.Button()
        CType(Me.carPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'carPictureBox
        '
        Me.carPictureBox.Image = Global.Car_Project.My.Resources.Resources.j0398463
        Me.carPictureBox.Location = New System.Drawing.Point(48, 120)
        Me.carPictureBox.Name = "carPictureBox"
        Me.carPictureBox.Size = New System.Drawing.Size(306, 172)
        Me.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.carPictureBox.TabIndex = 0
        Me.carPictureBox.TabStop = False
        '
        'msgLabel
        '
        Me.msgLabel.AutoSize = True
        Me.msgLabel.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgLabel.Location = New System.Drawing.Point(36, 26)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(331, 51)
        Me.msgLabel.TabIndex = 1
        Me.msgLabel.Text = "I WANT THIS CAR!"
        Me.msgLabel.Visible = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(270, 313)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(84, 30)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clickMeButton
        '
        Me.clickMeButton.Location = New System.Drawing.Point(175, 313)
        Me.clickMeButton.Name = "clickMeButton"
        Me.clickMeButton.Size = New System.Drawing.Size(84, 30)
        Me.clickMeButton.TabIndex = 3
        Me.clickMeButton.Text = "&Click Me"
        Me.clickMeButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 360)
        Me.Controls.Add(Me.clickMeButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.msgLabel)
        Me.Controls.Add(Me.carPictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Dream Car"
        CType(Me.carPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents carPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents msgLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clickMeButton As System.Windows.Forms.Button

End Class
