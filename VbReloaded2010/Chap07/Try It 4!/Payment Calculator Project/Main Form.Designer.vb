<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loanTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.paymentsLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.termListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Loan:"
        '
        'loanTextBox
        '
        Me.loanTextBox.Location = New System.Drawing.Point(62, 16)
        Me.loanTextBox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.loanTextBox.Name = "loanTextBox"
        Me.loanTextBox.Size = New System.Drawing.Size(84, 27)
        Me.loanTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Monthly payments:"
        '
        'paymentsLabel
        '
        Me.paymentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paymentsLabel.Location = New System.Drawing.Point(17, 121)
        Me.paymentsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.paymentsLabel.Name = "paymentsLabel"
        Me.paymentsLabel.Size = New System.Drawing.Size(147, 132)
        Me.paymentsLabel.TabIndex = 7
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(233, 187)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(97, 29)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(233, 224)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(97, 29)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Term (years):"
        '
        'termListBox
        '
        Me.termListBox.FormattingEnabled = True
        Me.termListBox.ItemHeight = 20
        Me.termListBox.Location = New System.Drawing.Point(266, 15)
        Me.termListBox.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.termListBox.Name = "termListBox"
        Me.termListBox.Size = New System.Drawing.Size(57, 84)
        Me.termListBox.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 273)
        Me.Controls.Add(Me.termListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.paymentsLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.loanTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents loanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents paymentsLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents termListBox As System.Windows.Forms.ListBox

End Class
