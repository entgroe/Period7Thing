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
        Me.cityListBox = New System.Windows.Forms.ListBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cityListBox
        '
        Me.cityListBox.FormattingEnabled = True
        Me.cityListBox.ItemHeight = 15
        Me.cityListBox.Items.AddRange(New Object() {"Boston", "Chicago", "Dallas", "Las Vegas"})
        Me.cityListBox.Location = New System.Drawing.Point(15, 15)
        Me.cityListBox.Name = "cityListBox"
        Me.cityListBox.Size = New System.Drawing.Size(88, 94)
        Me.cityListBox.TabIndex = 0
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(127, 82)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(87, 27)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 134)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.cityListBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cities"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cityListBox As System.Windows.Forms.ListBox
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
