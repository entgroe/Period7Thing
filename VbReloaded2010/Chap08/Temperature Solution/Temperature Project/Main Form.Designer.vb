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
        Me.toCelsiusRadioButton = New System.Windows.Forms.RadioButton()
        Me.toFahrenheitRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tempTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.convertButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'toCelsiusRadioButton
        '
        Me.toCelsiusRadioButton.AutoSize = True
        Me.toCelsiusRadioButton.Checked = True
        Me.toCelsiusRadioButton.Location = New System.Drawing.Point(116, 10)
        Me.toCelsiusRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.toCelsiusRadioButton.Name = "toCelsiusRadioButton"
        Me.toCelsiusRadioButton.Size = New System.Drawing.Size(85, 21)
        Me.toCelsiusRadioButton.TabIndex = 2
        Me.toCelsiusRadioButton.TabStop = True
        Me.toCelsiusRadioButton.Text = "To &Celsius"
        '
        'toFahrenheitRadioButton
        '
        Me.toFahrenheitRadioButton.AutoSize = True
        Me.toFahrenheitRadioButton.Location = New System.Drawing.Point(116, 33)
        Me.toFahrenheitRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.toFahrenheitRadioButton.Name = "toFahrenheitRadioButton"
        Me.toFahrenheitRadioButton.Size = New System.Drawing.Size(105, 21)
        Me.toFahrenheitRadioButton.TabIndex = 3
        Me.toFahrenheitRadioButton.Text = "To &Fahrenheit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Temperature:"
        '
        'tempTextBox
        '
        Me.tempTextBox.Location = New System.Drawing.Point(11, 36)
        Me.tempTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.tempTextBox.Name = "tempTextBox"
        Me.tempTextBox.Size = New System.Drawing.Size(71, 25)
        Me.tempTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Result:"
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resultLabel.Location = New System.Drawing.Point(11, 104)
        Me.resultLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(71, 26)
        Me.resultLabel.TabIndex = 7
        Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'convertButton
        '
        Me.convertButton.Location = New System.Drawing.Point(99, 96)
        Me.convertButton.Margin = New System.Windows.Forms.Padding(2)
        Me.convertButton.Name = "convertButton"
        Me.convertButton.Size = New System.Drawing.Size(79, 34)
        Me.convertButton.TabIndex = 4
        Me.convertButton.Text = "Con&vert"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(182, 96)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(79, 34)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 148)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.convertButton)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tempTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.toFahrenheitRadioButton)
        Me.Controls.Add(Me.toCelsiusRadioButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toCelsiusRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents toFahrenheitRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tempTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents resultLabel As System.Windows.Forms.Label
    Friend WithEvents convertButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
