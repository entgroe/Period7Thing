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
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.salesTextBox = New System.Windows.Forms.TextBox()
        Me.calcTax5Button = New System.Windows.Forms.Button()
        Me.calcTax2Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tax:"
        '
        'taxLabel
        '
        Me.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taxLabel.Location = New System.Drawing.Point(59, 47)
        Me.taxLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(89, 23)
        Me.taxLabel.TabIndex = 6
        Me.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesTextBox
        '
        Me.salesTextBox.Location = New System.Drawing.Point(59, 18)
        Me.salesTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.salesTextBox.Name = "salesTextBox"
        Me.salesTextBox.Size = New System.Drawing.Size(89, 27)
        Me.salesTextBox.TabIndex = 1
        '
        'calcTax5Button
        '
        Me.calcTax5Button.Location = New System.Drawing.Point(198, 49)
        Me.calcTax5Button.Margin = New System.Windows.Forms.Padding(2)
        Me.calcTax5Button.Name = "calcTax5Button"
        Me.calcTax5Button.Size = New System.Drawing.Size(138, 30)
        Me.calcTax5Button.TabIndex = 3
        Me.calcTax5Button.Text = "Calculate &5% Tax"
        '
        'calcTax2Button
        '
        Me.calcTax2Button.Location = New System.Drawing.Point(198, 15)
        Me.calcTax2Button.Margin = New System.Windows.Forms.Padding(2)
        Me.calcTax2Button.Name = "calcTax2Button"
        Me.calcTax2Button.Size = New System.Drawing.Size(138, 30)
        Me.calcTax2Button.TabIndex = 2
        Me.calcTax2Button.Text = "Calculate &2% Tax"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(198, 83)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(138, 30)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 134)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcTax2Button)
        Me.Controls.Add(Me.calcTax5Button)
        Me.Controls.Add(Me.salesTextBox)
        Me.Controls.Add(Me.taxLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Tax Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents taxLabel As System.Windows.Forms.Label
    Friend WithEvents salesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcTax5Button As System.Windows.Forms.Button
    Friend WithEvents calcTax2Button As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class