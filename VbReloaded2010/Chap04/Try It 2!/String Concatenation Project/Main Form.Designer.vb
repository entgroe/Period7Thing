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
        Me.firstTextBox = New System.Windows.Forms.TextBox()
        Me.lastTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.salaryTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.concatenatedString = New System.Windows.Forms.Label()
        Me.concatenateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&First name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Last name:"
        '
        'firstTextBox
        '
        Me.firstTextBox.Location = New System.Drawing.Point(17, 41)
        Me.firstTextBox.Name = "firstTextBox"
        Me.firstTextBox.Size = New System.Drawing.Size(100, 23)
        Me.firstTextBox.TabIndex = 1
        '
        'lastTextBox
        '
        Me.lastTextBox.Location = New System.Drawing.Point(164, 41)
        Me.lastTextBox.Name = "lastTextBox"
        Me.lastTextBox.Size = New System.Drawing.Size(100, 23)
        Me.lastTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Salary:"
        '
        'salaryTextBox
        '
        Me.salaryTextBox.Location = New System.Drawing.Point(303, 41)
        Me.salaryTextBox.Name = "salaryTextBox"
        Me.salaryTextBox.Size = New System.Drawing.Size(81, 23)
        Me.salaryTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Concatenated string:"
        '
        'concatenatedString
        '
        Me.concatenatedString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.concatenatedString.Location = New System.Drawing.Point(20, 109)
        Me.concatenatedString.Name = "concatenatedString"
        Me.concatenatedString.Size = New System.Drawing.Size(364, 31)
        Me.concatenatedString.TabIndex = 9
        '
        'concatenateButton
        '
        Me.concatenateButton.Location = New System.Drawing.Point(206, 164)
        Me.concatenateButton.Name = "concatenateButton"
        Me.concatenateButton.Size = New System.Drawing.Size(97, 32)
        Me.concatenateButton.TabIndex = 6
        Me.concatenateButton.Text = "&Concatenate"
        Me.concatenateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(309, 164)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 32)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 218)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.concatenateButton)
        Me.Controls.Add(Me.concatenatedString)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.salaryTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lastTextBox)
        Me.Controls.Add(Me.firstTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Concatenation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents firstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lastTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents salaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents concatenatedString As System.Windows.Forms.Label
    Friend WithEvents concatenateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
