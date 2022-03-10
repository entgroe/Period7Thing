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
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.sortAscendButton = New System.Windows.Forms.Button()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.sortDescendButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sorted state names:"
        '
        'stateLabel
        '
        Me.stateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stateLabel.Location = New System.Drawing.Point(22, 37)
        Me.stateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(106, 92)
        Me.stateLabel.TabIndex = 5
        '
        'sortAscendButton
        '
        Me.sortAscendButton.Location = New System.Drawing.Point(160, 67)
        Me.sortAscendButton.Margin = New System.Windows.Forms.Padding(2)
        Me.sortAscendButton.Name = "sortAscendButton"
        Me.sortAscendButton.Size = New System.Drawing.Size(118, 28)
        Me.sortAscendButton.TabIndex = 1
        Me.sortAscendButton.Text = "&Ascending Sort"
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(160, 34)
        Me.enterButton.Margin = New System.Windows.Forms.Padding(2)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(118, 28)
        Me.enterButton.TabIndex = 0
        Me.enterButton.Text = "&Enter State Names"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(160, 136)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(118, 28)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        '
        'sortDescendButton
        '
        Me.sortDescendButton.Location = New System.Drawing.Point(160, 101)
        Me.sortDescendButton.Margin = New System.Windows.Forms.Padding(2)
        Me.sortDescendButton.Name = "sortDescendButton"
        Me.sortDescendButton.Size = New System.Drawing.Size(118, 28)
        Me.sortDescendButton.TabIndex = 2
        Me.sortDescendButton.Text = "&Descending Sort"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 179)
        Me.Controls.Add(Me.sortDescendButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.sortAscendButton)
        Me.Controls.Add(Me.stateLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "State Names"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents stateLabel As System.Windows.Forms.Label
    Friend WithEvents sortAscendButton As System.Windows.Forms.Button
    Friend WithEvents enterButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents sortDescendButton As System.Windows.Forms.Button

End Class
