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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fatherRadioButton = New System.Windows.Forms.RadioButton()
        Me.motherRadioButton = New System.Windows.Forms.RadioButton()
        Me.brotherRadioButton = New System.Windows.Forms.RadioButton()
        Me.sisterRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.italianRadioButton = New System.Windows.Forms.RadioButton()
        Me.spanishRadioButton = New System.Windows.Forms.RadioButton()
        Me.frenchRadioButton = New System.Windows.Forms.RadioButton()
        Me.translateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.translatedLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fatherRadioButton)
        Me.GroupBox1.Controls.Add(Me.motherRadioButton)
        Me.GroupBox1.Controls.Add(Me.brotherRadioButton)
        Me.GroupBox1.Controls.Add(Me.sisterRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 143)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "English"
        '
        'fatherRadioButton
        '
        Me.fatherRadioButton.Location = New System.Drawing.Point(13, 53)
        Me.fatherRadioButton.Name = "fatherRadioButton"
        Me.fatherRadioButton.Size = New System.Drawing.Size(112, 21)
        Me.fatherRadioButton.TabIndex = 1
        Me.fatherRadioButton.Text = "&Father"
        Me.fatherRadioButton.UseVisualStyleBackColor = True
        '
        'motherRadioButton
        '
        Me.motherRadioButton.Checked = True
        Me.motherRadioButton.Location = New System.Drawing.Point(13, 26)
        Me.motherRadioButton.Name = "motherRadioButton"
        Me.motherRadioButton.Size = New System.Drawing.Size(112, 21)
        Me.motherRadioButton.TabIndex = 0
        Me.motherRadioButton.TabStop = True
        Me.motherRadioButton.Text = "&Mother"
        Me.motherRadioButton.UseVisualStyleBackColor = True
        '
        'brotherRadioButton
        '
        Me.brotherRadioButton.Location = New System.Drawing.Point(13, 107)
        Me.brotherRadioButton.Name = "brotherRadioButton"
        Me.brotherRadioButton.Size = New System.Drawing.Size(112, 21)
        Me.brotherRadioButton.TabIndex = 3
        Me.brotherRadioButton.Text = "&Brother"
        Me.brotherRadioButton.UseVisualStyleBackColor = True
        '
        'sisterRadioButton
        '
        Me.sisterRadioButton.Location = New System.Drawing.Point(13, 80)
        Me.sisterRadioButton.Name = "sisterRadioButton"
        Me.sisterRadioButton.Size = New System.Drawing.Size(112, 21)
        Me.sisterRadioButton.TabIndex = 2
        Me.sisterRadioButton.Text = "&Sister"
        Me.sisterRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.italianRadioButton)
        Me.GroupBox2.Controls.Add(Me.spanishRadioButton)
        Me.GroupBox2.Controls.Add(Me.frenchRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(173, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(110, 112)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Translate to"
        '
        'italianRadioButton
        '
        Me.italianRadioButton.Location = New System.Drawing.Point(13, 53)
        Me.italianRadioButton.Name = "italianRadioButton"
        Me.italianRadioButton.Size = New System.Drawing.Size(85, 21)
        Me.italianRadioButton.TabIndex = 1
        Me.italianRadioButton.Text = "&Italian"
        Me.italianRadioButton.UseVisualStyleBackColor = True
        '
        'spanishRadioButton
        '
        Me.spanishRadioButton.Location = New System.Drawing.Point(13, 80)
        Me.spanishRadioButton.Name = "spanishRadioButton"
        Me.spanishRadioButton.Size = New System.Drawing.Size(85, 21)
        Me.spanishRadioButton.TabIndex = 2
        Me.spanishRadioButton.Text = "S&panish"
        Me.spanishRadioButton.UseVisualStyleBackColor = True
        '
        'frenchRadioButton
        '
        Me.frenchRadioButton.Checked = True
        Me.frenchRadioButton.Location = New System.Drawing.Point(13, 26)
        Me.frenchRadioButton.Name = "frenchRadioButton"
        Me.frenchRadioButton.Size = New System.Drawing.Size(85, 21)
        Me.frenchRadioButton.TabIndex = 0
        Me.frenchRadioButton.TabStop = True
        Me.frenchRadioButton.Text = "Frenc&h"
        Me.frenchRadioButton.UseVisualStyleBackColor = True
        '
        'translateButton
        '
        Me.translateButton.Location = New System.Drawing.Point(301, 12)
        Me.translateButton.Name = "translateButton"
        Me.translateButton.Size = New System.Drawing.Size(75, 28)
        Me.translateButton.TabIndex = 0
        Me.translateButton.Text = "&Translate"
        Me.translateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(301, 46)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 28)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'translatedLabel
        '
        Me.translatedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.translatedLabel.Location = New System.Drawing.Point(173, 127)
        Me.translatedLabel.Name = "translatedLabel"
        Me.translatedLabel.Size = New System.Drawing.Size(110, 25)
        Me.translatedLabel.TabIndex = 4
        Me.translatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 177)
        Me.Controls.Add(Me.translatedLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.translateButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Translator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents fatherRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents motherRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents brotherRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents sisterRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents italianRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents spanishRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents frenchRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents translateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents translatedLabel As System.Windows.Forms.Label

End Class
