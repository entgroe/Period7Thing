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
        Me.reportLabel = New System.Windows.Forms.Label()
        Me.getButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'reportLabel
        '
        Me.reportLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportLabel.Location = New System.Drawing.Point(14, 14)
        Me.reportLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.reportLabel.Name = "reportLabel"
        Me.reportLabel.Size = New System.Drawing.Size(288, 32)
        Me.reportLabel.TabIndex = 2
        Me.reportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'getButton
        '
        Me.getButton.Location = New System.Drawing.Point(146, 57)
        Me.getButton.Margin = New System.Windows.Forms.Padding(2)
        Me.getButton.Name = "getButton"
        Me.getButton.Size = New System.Drawing.Size(104, 31)
        Me.getButton.TabIndex = 0
        Me.getButton.Text = "&Get Student Info"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(254, 57)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(48, 31)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 106)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.getButton)
        Me.Controls.Add(Me.reportLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grades"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportLabel As System.Windows.Forms.Label
    Friend WithEvents getButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
