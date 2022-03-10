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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.totalWeekdayLabel = New System.Windows.Forms.Label
        Me.totalWeekendLabel = New System.Windows.Forms.Label
        Me.monTextBox = New System.Windows.Forms.TextBox
        Me.tuesTextBox = New System.Windows.Forms.TextBox
        Me.wedTextBox = New System.Windows.Forms.TextBox
        Me.thursTextBox = New System.Windows.Forms.TextBox
        Me.friTextBox = New System.Windows.Forms.TextBox
        Me.satTextBox = New System.Windows.Forms.TextBox
        Me.sunTextBox = New System.Windows.Forms.TextBox
        Me.calcButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monday:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Tuesday"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Wednesday:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 152)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Thu&rsday:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 167)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "&Friday"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 202)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "&saturday:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 228)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "&Sunday"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(132, 72)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total weekday hours:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(132, 95)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "&Total Weekend Hours:"
        '
        'totalWeekdayLabel
        '
        Me.totalWeekdayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalWeekdayLabel.Location = New System.Drawing.Point(284, 71)
        Me.totalWeekdayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalWeekdayLabel.Name = "totalWeekdayLabel"
        Me.totalWeekdayLabel.Size = New System.Drawing.Size(46, 21)
        Me.totalWeekdayLabel.TabIndex = 9
        '
        'totalWeekendLabel
        '
        Me.totalWeekendLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalWeekendLabel.Location = New System.Drawing.Point(300, 98)
        Me.totalWeekendLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalWeekendLabel.Name = "totalWeekendLabel"
        Me.totalWeekendLabel.Size = New System.Drawing.Size(46, 21)
        Me.totalWeekendLabel.TabIndex = 10
        '
        'monTextBox
        '
        Me.monTextBox.Location = New System.Drawing.Point(99, 71)
        Me.monTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.monTextBox.Name = "monTextBox"
        Me.monTextBox.Size = New System.Drawing.Size(29, 27)
        Me.monTextBox.TabIndex = 11
        '
        'tuesTextBox
        '
        Me.tuesTextBox.Location = New System.Drawing.Point(99, 95)
        Me.tuesTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.tuesTextBox.Name = "tuesTextBox"
        Me.tuesTextBox.Size = New System.Drawing.Size(29, 27)
        Me.tuesTextBox.TabIndex = 12
        '
        'wedTextBox
        '
        Me.wedTextBox.Location = New System.Drawing.Point(99, 122)
        Me.wedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.wedTextBox.Name = "wedTextBox"
        Me.wedTextBox.Size = New System.Drawing.Size(29, 27)
        Me.wedTextBox.TabIndex = 13
        '
        'thursTextBox
        '
        Me.thursTextBox.Location = New System.Drawing.Point(99, 150)
        Me.thursTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.thursTextBox.Name = "thursTextBox"
        Me.thursTextBox.Size = New System.Drawing.Size(29, 27)
        Me.thursTextBox.TabIndex = 14
        '
        'friTextBox
        '
        Me.friTextBox.Location = New System.Drawing.Point(99, 177)
        Me.friTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.friTextBox.Name = "friTextBox"
        Me.friTextBox.Size = New System.Drawing.Size(29, 27)
        Me.friTextBox.TabIndex = 15
        '
        'satTextBox
        '
        Me.satTextBox.Location = New System.Drawing.Point(99, 205)
        Me.satTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.satTextBox.Name = "satTextBox"
        Me.satTextBox.Size = New System.Drawing.Size(29, 27)
        Me.satTextBox.TabIndex = 16
        '
        'sunTextBox
        '
        Me.sunTextBox.Location = New System.Drawing.Point(99, 235)
        Me.sunTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.sunTextBox.Name = "sunTextBox"
        Me.sunTextBox.Size = New System.Drawing.Size(29, 27)
        Me.sunTextBox.TabIndex = 17
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(9, 19)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(119, 38)
        Me.calcButton.TabIndex = 18
        Me.calcButton.Text = "Calculate hours"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(132, 19)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(55, 38)
        Me.exitButton.TabIndex = 19
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 274)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.sunTextBox)
        Me.Controls.Add(Me.satTextBox)
        Me.Controls.Add(Me.friTextBox)
        Me.Controls.Add(Me.thursTextBox)
        Me.Controls.Add(Me.wedTextBox)
        Me.Controls.Add(Me.tuesTextBox)
        Me.Controls.Add(Me.monTextBox)
        Me.Controls.Add(Me.totalWeekendLabel)
        Me.Controls.Add(Me.totalWeekdayLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hours Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents totalWeekdayLabel As System.Windows.Forms.Label
    Friend WithEvents totalWeekendLabel As System.Windows.Forms.Label
    Friend WithEvents monTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tuesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents wedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents thursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents friTextBox As System.Windows.Forms.TextBox
    Friend WithEvents satTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sunTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
