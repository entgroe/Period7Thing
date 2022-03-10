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
        Me.goldRadioButton = New System.Windows.Forms.RadioButton()
        Me.silverRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.basicRadioButton = New System.Windows.Forms.RadioButton()
        Me.bronzeRadioButton = New System.Windows.Forms.RadioButton()
        Me.hbiCheckBox = New System.Windows.Forms.CheckBox()
        Me.showtimerCheckBox = New System.Windows.Forms.CheckBox()
        Me.cinematicCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.localCheckBox = New System.Windows.Forms.CheckBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'goldRadioButton
        '
        Me.goldRadioButton.Location = New System.Drawing.Point(16, 97)
        Me.goldRadioButton.Name = "goldRadioButton"
        Me.goldRadioButton.Size = New System.Drawing.Size(50, 19)
        Me.goldRadioButton.TabIndex = 3
        Me.goldRadioButton.TabStop = True
        Me.goldRadioButton.Text = "&Gold"
        Me.goldRadioButton.UseVisualStyleBackColor = True
        '
        'silverRadioButton
        '
        Me.silverRadioButton.Location = New System.Drawing.Point(16, 72)
        Me.silverRadioButton.Name = "silverRadioButton"
        Me.silverRadioButton.Size = New System.Drawing.Size(53, 19)
        Me.silverRadioButton.TabIndex = 2
        Me.silverRadioButton.TabStop = True
        Me.silverRadioButton.Text = "&Silver"
        Me.silverRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.basicRadioButton)
        Me.GroupBox1.Controls.Add(Me.bronzeRadioButton)
        Me.GroupBox1.Controls.Add(Me.goldRadioButton)
        Me.GroupBox1.Controls.Add(Me.silverRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 127)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cable packages"
        '
        'basicRadioButton
        '
        Me.basicRadioButton.Checked = True
        Me.basicRadioButton.Location = New System.Drawing.Point(16, 22)
        Me.basicRadioButton.Name = "basicRadioButton"
        Me.basicRadioButton.Size = New System.Drawing.Size(52, 19)
        Me.basicRadioButton.TabIndex = 0
        Me.basicRadioButton.TabStop = True
        Me.basicRadioButton.Text = "&Basic"
        Me.basicRadioButton.UseVisualStyleBackColor = True
        '
        'bronzeRadioButton
        '
        Me.bronzeRadioButton.Location = New System.Drawing.Point(16, 47)
        Me.bronzeRadioButton.Name = "bronzeRadioButton"
        Me.bronzeRadioButton.Size = New System.Drawing.Size(61, 19)
        Me.bronzeRadioButton.TabIndex = 1
        Me.bronzeRadioButton.TabStop = True
        Me.bronzeRadioButton.Text = "Bron&ze"
        Me.bronzeRadioButton.UseVisualStyleBackColor = True
        '
        'hbiCheckBox
        '
        Me.hbiCheckBox.Location = New System.Drawing.Point(11, 22)
        Me.hbiCheckBox.Name = "hbiCheckBox"
        Me.hbiCheckBox.Size = New System.Drawing.Size(131, 19)
        Me.hbiCheckBox.TabIndex = 0
        Me.hbiCheckBox.Text = "&HBI movie channels"
        Me.hbiCheckBox.UseVisualStyleBackColor = True
        '
        'showtimerCheckBox
        '
        Me.showtimerCheckBox.Location = New System.Drawing.Point(11, 47)
        Me.showtimerCheckBox.Name = "showtimerCheckBox"
        Me.showtimerCheckBox.Size = New System.Drawing.Size(169, 19)
        Me.showtimerCheckBox.TabIndex = 1
        Me.showtimerCheckBox.Text = "Show&timer movie channels"
        Me.showtimerCheckBox.UseVisualStyleBackColor = True
        '
        'cinematicCheckBox
        '
        Me.cinematicCheckBox.Location = New System.Drawing.Point(11, 72)
        Me.cinematicCheckBox.Name = "cinematicCheckBox"
        Me.cinematicCheckBox.Size = New System.Drawing.Size(166, 19)
        Me.cinematicCheckBox.TabIndex = 2
        Me.cinematicCheckBox.Text = "Cine&matic movie channels"
        Me.cinematicCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.localCheckBox)
        Me.GroupBox2.Controls.Add(Me.hbiCheckBox)
        Me.GroupBox2.Controls.Add(Me.cinematicCheckBox)
        Me.GroupBox2.Controls.Add(Me.showtimerCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(158, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 127)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional features"
        '
        'localCheckBox
        '
        Me.localCheckBox.Location = New System.Drawing.Point(11, 97)
        Me.localCheckBox.Name = "localCheckBox"
        Me.localCheckBox.Size = New System.Drawing.Size(98, 19)
        Me.localCheckBox.TabIndex = 3
        Me.localCheckBox.Text = "&Local stations"
        Me.localCheckBox.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(80, 153)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(130, 28)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "&Calculate Cable Bill"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(216, 153)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 28)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 201)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charleston Cable Company"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents goldRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents silverRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents basicRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents bronzeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents hbiCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents showtimerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents cinematicCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents localCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
