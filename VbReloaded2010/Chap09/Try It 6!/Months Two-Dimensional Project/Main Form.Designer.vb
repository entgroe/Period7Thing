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
        Me.monthsListBox = New System.Windows.Forms.ListBox()
        Me.forNextButton = New System.Windows.Forms.Button()
        Me.doLoopButton = New System.Windows.Forms.Button()
        Me.forEachNextButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Months:"
        '
        'monthsListBox
        '
        Me.monthsListBox.FormattingEnabled = True
        Me.monthsListBox.ItemHeight = 17
        Me.monthsListBox.Location = New System.Drawing.Point(35, 47)
        Me.monthsListBox.Name = "monthsListBox"
        Me.monthsListBox.Size = New System.Drawing.Size(52, 140)
        Me.monthsListBox.TabIndex = 1
        '
        'forNextButton
        '
        Me.forNextButton.Location = New System.Drawing.Point(119, 27)
        Me.forNextButton.Name = "forNextButton"
        Me.forNextButton.Size = New System.Drawing.Size(121, 29)
        Me.forNextButton.TabIndex = 2
        Me.forNextButton.Text = "&For...Next"
        Me.forNextButton.UseVisualStyleBackColor = True
        '
        'doLoopButton
        '
        Me.doLoopButton.Location = New System.Drawing.Point(119, 65)
        Me.doLoopButton.Name = "doLoopButton"
        Me.doLoopButton.Size = New System.Drawing.Size(121, 29)
        Me.doLoopButton.TabIndex = 3
        Me.doLoopButton.Text = "&Do...Loop"
        Me.doLoopButton.UseVisualStyleBackColor = True
        '
        'forEachNextButton
        '
        Me.forEachNextButton.Location = New System.Drawing.Point(119, 103)
        Me.forEachNextButton.Name = "forEachNextButton"
        Me.forEachNextButton.Size = New System.Drawing.Size(121, 29)
        Me.forEachNextButton.TabIndex = 4
        Me.forEachNextButton.Text = "For &Each...Next"
        Me.forEachNextButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(119, 141)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(121, 29)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 209)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.forEachNextButton)
        Me.Controls.Add(Me.doLoopButton)
        Me.Controls.Add(Me.forNextButton)
        Me.Controls.Add(Me.monthsListBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Months Two-Dimensional"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents monthsListBox As System.Windows.Forms.ListBox
    Friend WithEvents forNextButton As System.Windows.Forms.Button
    Friend WithEvents doLoopButton As System.Windows.Forms.Button
    Friend WithEvents forEachNextButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
