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
        Me.leftPictureBox = New System.Windows.Forms.PictureBox()
        Me.centerPictureBox = New System.Windows.Forms.PictureBox()
        Me.rightPictureBox = New System.Windows.Forms.PictureBox()
        Me.clickHereButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.leftPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.centerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'leftPictureBox
        '
        Me.leftPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.leftPictureBox.Location = New System.Drawing.Point(6, 6)
        Me.leftPictureBox.Name = "leftPictureBox"
        Me.leftPictureBox.Size = New System.Drawing.Size(85, 96)
        Me.leftPictureBox.TabIndex = 0
        Me.leftPictureBox.TabStop = False
        '
        'centerPictureBox
        '
        Me.centerPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.centerPictureBox.Location = New System.Drawing.Point(100, 6)
        Me.centerPictureBox.Name = "centerPictureBox"
        Me.centerPictureBox.Size = New System.Drawing.Size(85, 96)
        Me.centerPictureBox.TabIndex = 1
        Me.centerPictureBox.TabStop = False
        '
        'rightPictureBox
        '
        Me.rightPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rightPictureBox.Location = New System.Drawing.Point(194, 6)
        Me.rightPictureBox.Name = "rightPictureBox"
        Me.rightPictureBox.Size = New System.Drawing.Size(86, 96)
        Me.rightPictureBox.TabIndex = 2
        Me.rightPictureBox.TabStop = False
        '
        'clickHereButton
        '
        Me.clickHereButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clickHereButton.Image = Global.Slot_Machine_Project.My.Resources.Resources.j0236314
        Me.clickHereButton.Location = New System.Drawing.Point(304, 12)
        Me.clickHereButton.Name = "clickHereButton"
        Me.clickHereButton.Size = New System.Drawing.Size(89, 108)
        Me.clickHereButton.TabIndex = 0
        Me.clickHereButton.Text = "Click Here"
        Me.clickHereButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.clickHereButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(304, 139)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(89, 30)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.leftPictureBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.centerPictureBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rightPictureBox, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(286, 108)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 184)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clickHereButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slot Machine"
        CType(Me.leftPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.centerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leftPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents centerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents rightPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents clickHereButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
