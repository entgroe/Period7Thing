﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.radiusTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.areaLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Radius:"
        '
        'radiusTextBox
        '
        Me.radiusTextBox.Location = New System.Drawing.Point(70, 13)
        Me.radiusTextBox.Name = "radiusTextBox"
        Me.radiusTextBox.Size = New System.Drawing.Size(65, 25)
        Me.radiusTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Area:"
        '
        'areaLabel
        '
        Me.areaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.areaLabel.Location = New System.Drawing.Point(58, 47)
        Me.areaLabel.Name = "areaLabel"
        Me.areaLabel.Size = New System.Drawing.Size(77, 25)
        Me.areaLabel.TabIndex = 5
        Me.areaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(155, 10)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 28)
        Me.calcButton.TabIndex = 2
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(155, 45)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 28)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 89)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.areaLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radiusTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circle Area Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radiusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents areaLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
