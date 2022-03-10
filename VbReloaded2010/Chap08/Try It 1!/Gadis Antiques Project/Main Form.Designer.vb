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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hoursComboBox = New System.Windows.Forms.ComboBox()
        Me.rateComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.regularLabel = New System.Windows.Forms.Label()
        Me.overtimeLabel = New System.Windows.Forms.Label()
        Me.grossLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Hours:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Rate:"
        '
        'hoursComboBox
        '
        Me.hoursComboBox.FormattingEnabled = True
        Me.hoursComboBox.Location = New System.Drawing.Point(125, 45)
        Me.hoursComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.hoursComboBox.Name = "hoursComboBox"
        Me.hoursComboBox.Size = New System.Drawing.Size(73, 23)
        Me.hoursComboBox.TabIndex = 1
        '
        'rateComboBox
        '
        Me.rateComboBox.FormattingEnabled = True
        Me.rateComboBox.Location = New System.Drawing.Point(225, 45)
        Me.rateComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.rateComboBox.Name = "rateComboBox"
        Me.rateComboBox.Size = New System.Drawing.Size(73, 23)
        Me.rateComboBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 13)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Regular pay:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 13)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Overtime pay:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 13)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Gross pay:"
        '
        'regularLabel
        '
        Me.regularLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.regularLabel.Location = New System.Drawing.Point(18, 38)
        Me.regularLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.regularLabel.Name = "regularLabel"
        Me.regularLabel.Size = New System.Drawing.Size(84, 23)
        Me.regularLabel.TabIndex = 3
        Me.regularLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'overtimeLabel
        '
        Me.overtimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.overtimeLabel.Location = New System.Drawing.Point(123, 38)
        Me.overtimeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.overtimeLabel.Name = "overtimeLabel"
        Me.overtimeLabel.Size = New System.Drawing.Size(84, 23)
        Me.overtimeLabel.TabIndex = 4
        Me.overtimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grossLabel
        '
        Me.grossLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grossLabel.Location = New System.Drawing.Point(235, 38)
        Me.grossLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.grossLabel.Name = "grossLabel"
        Me.grossLabel.Size = New System.Drawing.Size(84, 23)
        Me.grossLabel.TabIndex = 5
        Me.grossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(149, 193)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 30)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(228, 193)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 30)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "C&lear"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(307, 193)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 30)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.regularLabel)
        Me.Panel1.Controls.Add(Me.grossLabel)
        Me.Panel1.Controls.Add(Me.overtimeLabel)
        Me.Panel1.Location = New System.Drawing.Point(39, 88)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 84)
        Me.Panel1.TabIndex = 7
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 249)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.rateComboBox)
        Me.Controls.Add(Me.hoursComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gadis Antiques"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents hoursComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents rateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents regularLabel As System.Windows.Forms.Label
    Friend WithEvents overtimeLabel As System.Windows.Forms.Label
    Friend WithEvents grossLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
