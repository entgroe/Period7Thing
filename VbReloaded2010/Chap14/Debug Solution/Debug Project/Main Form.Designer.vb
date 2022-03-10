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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.origTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.discountListBox = New System.Windows.Forms.ListBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.newLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.modelTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Original price:"
        '
        'origTextBox
        '
        Me.origTextBox.Location = New System.Drawing.Point(25, 106)
        Me.origTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.origTextBox.Name = "origTextBox"
        Me.origTextBox.Size = New System.Drawing.Size(101, 23)
        Me.origTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Discount percentage:"
        '
        'discountListBox
        '
        Me.discountListBox.FormattingEnabled = True
        Me.discountListBox.ItemHeight = 15
        Me.discountListBox.Location = New System.Drawing.Point(170, 47)
        Me.discountListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.discountListBox.Name = "discountListBox"
        Me.discountListBox.Size = New System.Drawing.Size(75, 94)
        Me.discountListBox.TabIndex = 5
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(142, 153)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(121, 33)
        Me.calcButton.TabIndex = 8
        Me.calcButton.Text = "&Calculate New Price"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(267, 153)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(55, 33)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "New price:"
        '
        'newLabel
        '
        Me.newLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.newLabel.Location = New System.Drawing.Point(25, 156)
        Me.newLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.newLabel.Name = "newLabel"
        Me.newLabel.Size = New System.Drawing.Size(101, 30)
        Me.newLabel.TabIndex = 7
        Me.newLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Model:"
        '
        'modelTextBox
        '
        Me.modelTextBox.Location = New System.Drawing.Point(25, 47)
        Me.modelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.modelTextBox.Name = "modelTextBox"
        Me.modelTextBox.Size = New System.Drawing.Size(101, 23)
        Me.modelTextBox.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 213)
        Me.Controls.Add(Me.modelTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.discountListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.origTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer Workshop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents origTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents discountListBox As System.Windows.Forms.ListBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents newLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents modelTextBox As System.Windows.Forms.TextBox

End Class
