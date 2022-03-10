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
        Me.namesListBox = New System.Windows.Forms.ListBox()
        Me.insertButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.removeAtButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.countButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Names:"
        '
        'namesListBox
        '
        Me.namesListBox.FormattingEnabled = True
        Me.namesListBox.ItemHeight = 15
        Me.namesListBox.Location = New System.Drawing.Point(20, 33)
        Me.namesListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.namesListBox.Name = "namesListBox"
        Me.namesListBox.Size = New System.Drawing.Size(144, 139)
        Me.namesListBox.TabIndex = 1
        '
        'insertButton
        '
        Me.insertButton.Location = New System.Drawing.Point(217, 33)
        Me.insertButton.Margin = New System.Windows.Forms.Padding(2)
        Me.insertButton.Name = "insertButton"
        Me.insertButton.Size = New System.Drawing.Size(89, 28)
        Me.insertButton.TabIndex = 2
        Me.insertButton.Text = "&Insert"
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(217, 66)
        Me.removeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(89, 28)
        Me.removeButton.TabIndex = 3
        Me.removeButton.Text = "&Remove"
        '
        'removeAtButton
        '
        Me.removeAtButton.Location = New System.Drawing.Point(217, 100)
        Me.removeAtButton.Margin = New System.Windows.Forms.Padding(2)
        Me.removeAtButton.Name = "removeAtButton"
        Me.removeAtButton.Size = New System.Drawing.Size(89, 28)
        Me.removeAtButton.TabIndex = 4
        Me.removeAtButton.Text = "Remove &At"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(217, 133)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(89, 28)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "C&lear"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(217, 199)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(89, 28)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        '
        'countButton
        '
        Me.countButton.Location = New System.Drawing.Point(217, 167)
        Me.countButton.Margin = New System.Windows.Forms.Padding(2)
        Me.countButton.Name = "countButton"
        Me.countButton.Size = New System.Drawing.Size(89, 28)
        Me.countButton.TabIndex = 6
        Me.countButton.Text = "&Count"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 248)
        Me.Controls.Add(Me.countButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.removeAtButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.insertButton)
        Me.Controls.Add(Me.namesListBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Methods of the Items Collection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents namesListBox As System.Windows.Forms.ListBox
    Friend WithEvents insertButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents removeAtButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents countButton As System.Windows.Forms.Button

End Class
