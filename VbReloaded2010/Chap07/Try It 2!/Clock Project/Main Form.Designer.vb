<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.v1Button = New System.Windows.Forms.Button()
        Me.minutesLabel = New System.Windows.Forms.Label()
        Me.secondsLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.v2Button = New System.Windows.Forms.Button()
        Me.v3Button = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Clock_Project.My.Resources.Resources.j0354384
        Me.PictureBox1.Location = New System.Drawing.Point(87, 33)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Minutes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Seconds:"
        '
        'v1Button
        '
        Me.v1Button.Location = New System.Drawing.Point(231, 67)
        Me.v1Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.v1Button.Name = "v1Button"
        Me.v1Button.Size = New System.Drawing.Size(86, 29)
        Me.v1Button.TabIndex = 0
        Me.v1Button.Text = "Version &1"
        Me.v1Button.UseVisualStyleBackColor = True
        '
        'minutesLabel
        '
        Me.minutesLabel.AutoSize = True
        Me.minutesLabel.Location = New System.Drawing.Point(59, 183)
        Me.minutesLabel.Name = "minutesLabel"
        Me.minutesLabel.Size = New System.Drawing.Size(17, 20)
        Me.minutesLabel.TabIndex = 5
        Me.minutesLabel.Text = "0"
        '
        'secondsLabel
        '
        Me.secondsLabel.AutoSize = True
        Me.secondsLabel.Location = New System.Drawing.Point(163, 183)
        Me.secondsLabel.Name = "secondsLabel"
        Me.secondsLabel.Size = New System.Drawing.Size(17, 20)
        Me.secondsLabel.TabIndex = 7
        Me.secondsLabel.Text = "0"
        Me.secondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(231, 178)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(86, 29)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'v2Button
        '
        Me.v2Button.Location = New System.Drawing.Point(231, 104)
        Me.v2Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.v2Button.Name = "v2Button"
        Me.v2Button.Size = New System.Drawing.Size(86, 29)
        Me.v2Button.TabIndex = 1
        Me.v2Button.Text = "Version &2"
        Me.v2Button.UseVisualStyleBackColor = True
        '
        'v3Button
        '
        Me.v3Button.Location = New System.Drawing.Point(231, 141)
        Me.v3Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.v3Button.Name = "v3Button"
        Me.v3Button.Size = New System.Drawing.Size(86, 29)
        Me.v3Button.TabIndex = 2
        Me.v3Button.Text = "Version &3"
        Me.v3Button.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 228)
        Me.Controls.Add(Me.v3Button)
        Me.Controls.Add(Me.v2Button)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.secondsLabel)
        Me.Controls.Add(Me.minutesLabel)
        Me.Controls.Add(Me.v1Button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents v1Button As System.Windows.Forms.Button
    Friend WithEvents minutesLabel As System.Windows.Forms.Label
    Friend WithEvents secondsLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents v2Button As System.Windows.Forms.Button
    Friend WithEvents v3Button As System.Windows.Forms.Button

End Class
