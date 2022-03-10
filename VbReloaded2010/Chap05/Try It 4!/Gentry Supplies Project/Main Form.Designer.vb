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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.northCarolinaRadioButton = New System.Windows.Forms.RadioButton()
        Me.alabamaRadioButton = New System.Windows.Forms.RadioButton()
        Me.louisianaRadioButton = New System.Windows.Forms.RadioButton()
        Me.georgiaRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.overnightRadioButton = New System.Windows.Forms.RadioButton()
        Me.standardRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shipLabel = New System.Windows.Forms.Label()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.northCarolinaRadioButton)
        Me.GroupBox1.Controls.Add(Me.alabamaRadioButton)
        Me.GroupBox1.Controls.Add(Me.louisianaRadioButton)
        Me.GroupBox1.Controls.Add(Me.georgiaRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 37)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(146, 128)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "State"
        '
        'northCarolinaRadioButton
        '
        Me.northCarolinaRadioButton.Location = New System.Drawing.Point(15, 92)
        Me.northCarolinaRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.northCarolinaRadioButton.Name = "northCarolinaRadioButton"
        Me.northCarolinaRadioButton.Size = New System.Drawing.Size(103, 19)
        Me.northCarolinaRadioButton.TabIndex = 3
        Me.northCarolinaRadioButton.Text = "&North Carolina"
        '
        'alabamaRadioButton
        '
        Me.alabamaRadioButton.Checked = True
        Me.alabamaRadioButton.Location = New System.Drawing.Point(15, 18)
        Me.alabamaRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.alabamaRadioButton.Name = "alabamaRadioButton"
        Me.alabamaRadioButton.Size = New System.Drawing.Size(72, 19)
        Me.alabamaRadioButton.TabIndex = 0
        Me.alabamaRadioButton.TabStop = True
        Me.alabamaRadioButton.Text = "&Alabama"
        '
        'louisianaRadioButton
        '
        Me.louisianaRadioButton.Location = New System.Drawing.Point(15, 67)
        Me.louisianaRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.louisianaRadioButton.Name = "louisianaRadioButton"
        Me.louisianaRadioButton.Size = New System.Drawing.Size(75, 19)
        Me.louisianaRadioButton.TabIndex = 2
        Me.louisianaRadioButton.Text = "&Louisiana"
        '
        'georgiaRadioButton
        '
        Me.georgiaRadioButton.Location = New System.Drawing.Point(15, 43)
        Me.georgiaRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.georgiaRadioButton.Name = "georgiaRadioButton"
        Me.georgiaRadioButton.Size = New System.Drawing.Size(66, 19)
        Me.georgiaRadioButton.TabIndex = 1
        Me.georgiaRadioButton.Text = "&Georgia"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.overnightRadioButton)
        Me.GroupBox2.Controls.Add(Me.standardRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(194, 37)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(114, 83)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Delivery"
        '
        'overnightRadioButton
        '
        Me.overnightRadioButton.Location = New System.Drawing.Point(11, 44)
        Me.overnightRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.overnightRadioButton.Name = "overnightRadioButton"
        Me.overnightRadioButton.Size = New System.Drawing.Size(78, 19)
        Me.overnightRadioButton.TabIndex = 1
        Me.overnightRadioButton.Text = "&Overnight"
        '
        'standardRadioButton
        '
        Me.standardRadioButton.Checked = True
        Me.standardRadioButton.Location = New System.Drawing.Point(11, 20)
        Me.standardRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.standardRadioButton.Name = "standardRadioButton"
        Me.standardRadioButton.Size = New System.Drawing.Size(72, 19)
        Me.standardRadioButton.TabIndex = 0
        Me.standardRadioButton.TabStop = True
        Me.standardRadioButton.Text = "&Standard"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Shipping charge:"
        '
        'shipLabel
        '
        Me.shipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shipLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shipLabel.Location = New System.Drawing.Point(352, 57)
        Me.shipLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.shipLabel.Name = "shipLabel"
        Me.shipLabel.Size = New System.Drawing.Size(116, 60)
        Me.shipLabel.TabIndex = 5
        Me.shipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(194, 132)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(201, 33)
        Me.displayButton.TabIndex = 0
        Me.displayButton.Text = "&Display Shipping Charge"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(399, 132)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(69, 33)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 202)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.shipLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gentry Supplies"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents northCarolinaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents alabamaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents louisianaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents georgiaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents overnightRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents standardRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents shipLabel As System.Windows.Forms.Label
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
