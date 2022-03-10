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
        Me.akRadioButton = New System.Windows.Forms.RadioButton()
        Me.caRadioButton = New System.Windows.Forms.RadioButton()
        Me.hiRadioButton = New System.Windows.Forms.RadioButton()
        Me.orRadioButton = New System.Windows.Forms.RadioButton()
        Me.ndRadioButton = New System.Windows.Forms.RadioButton()
        Me.txRadioButton = New System.Windows.Forms.RadioButton()
        Me.wyRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shipLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'akRadioButton
        '
        Me.akRadioButton.AutoSize = True
        Me.akRadioButton.Checked = True
        Me.akRadioButton.Location = New System.Drawing.Point(20, 13)
        Me.akRadioButton.Name = "akRadioButton"
        Me.akRadioButton.Size = New System.Drawing.Size(59, 19)
        Me.akRadioButton.TabIndex = 0
        Me.akRadioButton.TabStop = True
        Me.akRadioButton.Text = "&Alaska"
        Me.akRadioButton.UseVisualStyleBackColor = True
        '
        'caRadioButton
        '
        Me.caRadioButton.AutoSize = True
        Me.caRadioButton.Location = New System.Drawing.Point(20, 38)
        Me.caRadioButton.Name = "caRadioButton"
        Me.caRadioButton.Size = New System.Drawing.Size(76, 19)
        Me.caRadioButton.TabIndex = 1
        Me.caRadioButton.Text = "&California"
        Me.caRadioButton.UseVisualStyleBackColor = True
        '
        'hiRadioButton
        '
        Me.hiRadioButton.AutoSize = True
        Me.hiRadioButton.Location = New System.Drawing.Point(20, 63)
        Me.hiRadioButton.Name = "hiRadioButton"
        Me.hiRadioButton.Size = New System.Drawing.Size(61, 19)
        Me.hiRadioButton.TabIndex = 2
        Me.hiRadioButton.Text = "&Hawaii"
        Me.hiRadioButton.UseVisualStyleBackColor = True
        '
        'orRadioButton
        '
        Me.orRadioButton.AutoSize = True
        Me.orRadioButton.Location = New System.Drawing.Point(20, 113)
        Me.orRadioButton.Name = "orRadioButton"
        Me.orRadioButton.Size = New System.Drawing.Size(65, 19)
        Me.orRadioButton.TabIndex = 4
        Me.orRadioButton.Text = "&Oregon"
        Me.orRadioButton.UseVisualStyleBackColor = True
        '
        'ndRadioButton
        '
        Me.ndRadioButton.AutoSize = True
        Me.ndRadioButton.Location = New System.Drawing.Point(20, 88)
        Me.ndRadioButton.Name = "ndRadioButton"
        Me.ndRadioButton.Size = New System.Drawing.Size(96, 19)
        Me.ndRadioButton.TabIndex = 3
        Me.ndRadioButton.Text = "&North Dakota"
        Me.ndRadioButton.UseVisualStyleBackColor = True
        '
        'txRadioButton
        '
        Me.txRadioButton.AutoSize = True
        Me.txRadioButton.Location = New System.Drawing.Point(20, 138)
        Me.txRadioButton.Name = "txRadioButton"
        Me.txRadioButton.Size = New System.Drawing.Size(54, 19)
        Me.txRadioButton.TabIndex = 5
        Me.txRadioButton.Text = "&Texas"
        Me.txRadioButton.UseVisualStyleBackColor = True
        '
        'wyRadioButton
        '
        Me.wyRadioButton.AutoSize = True
        Me.wyRadioButton.Location = New System.Drawing.Point(20, 163)
        Me.wyRadioButton.Name = "wyRadioButton"
        Me.wyRadioButton.Size = New System.Drawing.Size(77, 19)
        Me.wyRadioButton.TabIndex = 6
        Me.wyRadioButton.Text = "&Wyoming"
        Me.wyRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Shipping:"
        '
        'shipLabel
        '
        Me.shipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shipLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shipLabel.Location = New System.Drawing.Point(157, 34)
        Me.shipLabel.Name = "shipLabel"
        Me.shipLabel.Size = New System.Drawing.Size(75, 39)
        Me.shipLabel.TabIndex = 9
        Me.shipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(157, 159)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 205)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.shipLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wyRadioButton)
        Me.Controls.Add(Me.txRadioButton)
        Me.Controls.Add(Me.ndRadioButton)
        Me.Controls.Add(Me.orRadioButton)
        Me.Controls.Add(Me.hiRadioButton)
        Me.Controls.Add(Me.caRadioButton)
        Me.Controls.Add(Me.akRadioButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "United Packaging"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents akRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents caRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents hiRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents orRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ndRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents txRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents wyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents shipLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
