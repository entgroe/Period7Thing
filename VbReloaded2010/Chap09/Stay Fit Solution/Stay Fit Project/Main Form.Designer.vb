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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.membershipListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.goldLabel = New System.Windows.Forms.Label()
        Me.silverLabel = New System.Windows.Forms.Label()
        Me.bronzeLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = Global.Stay_Fit_Project.My.Resources.Resources.bd06529_
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 188)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Join the fun!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Memberships:"
        '
        'membershipListBox
        '
        Me.membershipListBox.FormattingEnabled = True
        Me.membershipListBox.ItemHeight = 17
        Me.membershipListBox.Location = New System.Drawing.Point(254, 33)
        Me.membershipListBox.Name = "membershipListBox"
        Me.membershipListBox.Size = New System.Drawing.Size(87, 55)
        Me.membershipListBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gold:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Silver:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Bronze:"
        '
        'goldLabel
        '
        Me.goldLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.goldLabel.Location = New System.Drawing.Point(64, 24)
        Me.goldLabel.Name = "goldLabel"
        Me.goldLabel.Size = New System.Drawing.Size(53, 20)
        Me.goldLabel.TabIndex = 5
        Me.goldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'silverLabel
        '
        Me.silverLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.silverLabel.Location = New System.Drawing.Point(64, 58)
        Me.silverLabel.Name = "silverLabel"
        Me.silverLabel.Size = New System.Drawing.Size(53, 20)
        Me.silverLabel.TabIndex = 7
        Me.silverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bronzeLabel
        '
        Me.bronzeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bronzeLabel.Location = New System.Drawing.Point(64, 92)
        Me.bronzeLabel.Name = "bronzeLabel"
        Me.bronzeLabel.Size = New System.Drawing.Size(53, 20)
        Me.bronzeLabel.TabIndex = 9
        Me.bronzeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(416, 160)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(66, 27)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.bronzeLabel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.silverLabel)
        Me.GroupBox1.Controls.Add(Me.goldLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(354, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 125)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fees"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 213)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.membershipListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stay Fit Health Club"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents membershipListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents goldLabel As System.Windows.Forms.Label
    Friend WithEvents silverLabel As System.Windows.Forms.Label
    Friend WithEvents bronzeLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
