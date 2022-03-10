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
        Me.animalListBox = New System.Windows.Forms.ListBox()
        Me.codeListBox = New System.Windows.Forms.ListBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deptLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.animalLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Animals:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Codes:"
        '
        'animalListBox
        '
        Me.animalListBox.FormattingEnabled = True
        Me.animalListBox.ItemHeight = 15
        Me.animalListBox.Location = New System.Drawing.Point(24, 36)
        Me.animalListBox.Name = "animalListBox"
        Me.animalListBox.Size = New System.Drawing.Size(74, 49)
        Me.animalListBox.TabIndex = 2
        '
        'codeListBox
        '
        Me.codeListBox.FormattingEnabled = True
        Me.codeListBox.ItemHeight = 15
        Me.codeListBox.Location = New System.Drawing.Point(167, 36)
        Me.codeListBox.Name = "codeListBox"
        Me.codeListBox.Size = New System.Drawing.Size(56, 94)
        Me.codeListBox.TabIndex = 4
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(213, 227)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(61, 27)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Department name:"
        '
        'deptLabel
        '
        Me.deptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.deptLabel.Location = New System.Drawing.Point(168, 174)
        Me.deptLabel.Name = "deptLabel"
        Me.deptLabel.Size = New System.Drawing.Size(106, 27)
        Me.deptLabel.TabIndex = 8
        Me.deptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Animal's name:"
        '
        'animalLabel
        '
        Me.animalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.animalLabel.Location = New System.Drawing.Point(24, 174)
        Me.animalLabel.Name = "animalLabel"
        Me.animalLabel.Size = New System.Drawing.Size(106, 27)
        Me.animalLabel.TabIndex = 6
        Me.animalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 267)
        Me.Controls.Add(Me.animalLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.deptLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.codeListBox)
        Me.Controls.Add(Me.animalListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "More List Box Examples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents animalListBox As System.Windows.Forms.ListBox
    Friend WithEvents codeListBox As System.Windows.Forms.ListBox
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents deptLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents animalLabel As System.Windows.Forms.Label

End Class
