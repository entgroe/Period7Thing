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
        Me.ex1Button = New System.Windows.Forms.Button()
        Me.ex2Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.msgLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ex1Button
        '
        Me.ex1Button.Location = New System.Drawing.Point(87, 25)
        Me.ex1Button.Name = "ex1Button"
        Me.ex1Button.Size = New System.Drawing.Size(75, 23)
        Me.ex1Button.TabIndex = 0
        Me.ex1Button.Text = "Example &1"
        Me.ex1Button.UseVisualStyleBackColor = True
        '
        'ex2Button
        '
        Me.ex2Button.Location = New System.Drawing.Point(87, 54)
        Me.ex2Button.Name = "ex2Button"
        Me.ex2Button.Size = New System.Drawing.Size(75, 23)
        Me.ex2Button.TabIndex = 1
        Me.ex2Button.Text = "Example &2"
        Me.ex2Button.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(87, 83)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'msgLabel
        '
        Me.msgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msgLabel.Location = New System.Drawing.Point(26, 134)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(197, 23)
        Me.msgLabel.TabIndex = 3
        Me.msgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 177)
        Me.Controls.Add(Me.msgLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.ex2Button)
        Me.Controls.Add(Me.ex1Button)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MessageBox Examples"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ex1Button As System.Windows.Forms.Button
    Friend WithEvents ex2Button As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents msgLabel As System.Windows.Forms.Label

End Class
