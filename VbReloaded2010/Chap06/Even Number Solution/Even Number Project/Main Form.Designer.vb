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
        Me.evenNumsLabel = New System.Windows.Forms.Label()
        Me.pretestButton = New System.Windows.Forms.Button()
        Me.posttestButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'evenNumsLabel
        '
        Me.evenNumsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.evenNumsLabel.Location = New System.Drawing.Point(26, 32)
        Me.evenNumsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.evenNumsLabel.Name = "evenNumsLabel"
        Me.evenNumsLabel.Size = New System.Drawing.Size(26, 143)
        Me.evenNumsLabel.TabIndex = 3
        Me.evenNumsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pretestButton
        '
        Me.pretestButton.Location = New System.Drawing.Point(104, 32)
        Me.pretestButton.Margin = New System.Windows.Forms.Padding(2)
        Me.pretestButton.Name = "pretestButton"
        Me.pretestButton.Size = New System.Drawing.Size(152, 35)
        Me.pretestButton.TabIndex = 0
        Me.pretestButton.Text = "&Do...Loop Pretest"
        '
        'posttestButton
        '
        Me.posttestButton.Location = New System.Drawing.Point(104, 71)
        Me.posttestButton.Margin = New System.Windows.Forms.Padding(2)
        Me.posttestButton.Name = "posttestButton"
        Me.posttestButton.Size = New System.Drawing.Size(152, 35)
        Me.posttestButton.TabIndex = 1
        Me.posttestButton.Text = "Do...&Loop Posttest"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(104, 110)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(152, 35)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 199)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.posttestButton)
        Me.Controls.Add(Me.pretestButton)
        Me.Controls.Add(Me.evenNumsLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Even Numbers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents evenNumsLabel As System.Windows.Forms.Label
    Friend WithEvents pretestButton As System.Windows.Forms.Button
    Friend WithEvents posttestButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
