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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.totalWeekdayLabel = New System.Windows.Forms.Label()
        Me.totalWeekendLabel = New System.Windows.Forms.Label()
        Me.monTextBox = New System.Windows.Forms.TextBox()
        Me.tuesTextBox = New System.Windows.Forms.TextBox()
        Me.wedTextBox = New System.Windows.Forms.TextBox()
        Me.thursTextBox = New System.Windows.Forms.TextBox()
        Me.friTextBox = New System.Windows.Forms.TextBox()
        Me.satTextBox = New System.Windows.Forms.TextBox()
        Me.sunTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Monday:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Tuesday:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Wednesday:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Thu&rsday:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 125)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Friday:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 152)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "&Saturday:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 180)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "S&unday:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(141, 15)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total weekday hours:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(141, 42)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Total weekend hours:"
        '
        'totalWeekdayLabel
        '
        Me.totalWeekdayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalWeekdayLabel.Location = New System.Drawing.Point(267, 14)
        Me.totalWeekdayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalWeekdayLabel.Name = "totalWeekdayLabel"
        Me.totalWeekdayLabel.Size = New System.Drawing.Size(44, 23)
        Me.totalWeekdayLabel.TabIndex = 17
        '
        'totalWeekendLabel
        '
        Me.totalWeekendLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalWeekendLabel.Location = New System.Drawing.Point(267, 42)
        Me.totalWeekendLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalWeekendLabel.Name = "totalWeekendLabel"
        Me.totalWeekendLabel.Size = New System.Drawing.Size(44, 23)
        Me.totalWeekendLabel.TabIndex = 19
        '
        'monTextBox
        '
        Me.monTextBox.Location = New System.Drawing.Point(90, 12)
        Me.monTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.monTextBox.Name = "monTextBox"
        Me.monTextBox.Size = New System.Drawing.Size(29, 23)
        Me.monTextBox.TabIndex = 1
        '
        'tuesTextBox
        '
        Me.tuesTextBox.Location = New System.Drawing.Point(90, 40)
        Me.tuesTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.tuesTextBox.Name = "tuesTextBox"
        Me.tuesTextBox.Size = New System.Drawing.Size(29, 23)
        Me.tuesTextBox.TabIndex = 3
        '
        'wedTextBox
        '
        Me.wedTextBox.Location = New System.Drawing.Point(90, 67)
        Me.wedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.wedTextBox.Name = "wedTextBox"
        Me.wedTextBox.Size = New System.Drawing.Size(29, 23)
        Me.wedTextBox.TabIndex = 5
        '
        'thursTextBox
        '
        Me.thursTextBox.Location = New System.Drawing.Point(90, 95)
        Me.thursTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.thursTextBox.Name = "thursTextBox"
        Me.thursTextBox.Size = New System.Drawing.Size(29, 23)
        Me.thursTextBox.TabIndex = 7
        '
        'friTextBox
        '
        Me.friTextBox.Location = New System.Drawing.Point(90, 122)
        Me.friTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.friTextBox.Name = "friTextBox"
        Me.friTextBox.Size = New System.Drawing.Size(29, 23)
        Me.friTextBox.TabIndex = 9
        '
        'satTextBox
        '
        Me.satTextBox.Location = New System.Drawing.Point(90, 150)
        Me.satTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.satTextBox.Name = "satTextBox"
        Me.satTextBox.Size = New System.Drawing.Size(29, 23)
        Me.satTextBox.TabIndex = 11
        '
        'sunTextBox
        '
        Me.sunTextBox.Location = New System.Drawing.Point(90, 177)
        Me.sunTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.sunTextBox.Name = "sunTextBox"
        Me.sunTextBox.Size = New System.Drawing.Size(29, 23)
        Me.sunTextBox.TabIndex = 13
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(191, 140)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(120, 31)
        Me.calcButton.TabIndex = 14
        Me.calcButton.Text = "&Calculate Hours"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(191, 175)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 31)
        Me.exitButton.TabIndex = 15
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 218)
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
        Me.MaximizeBox = False
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
