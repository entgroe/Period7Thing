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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.playerPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.computerPictureBox = New System.Windows.Forms.PictureBox()
        Me.winnerLabel = New System.Windows.Forms.Label()
        Me.paperPictureBox = New System.Windows.Forms.PictureBox()
        Me.scissorsPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rockPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.playerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.computerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scissorsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.rockPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(357, 336)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(55, 29)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Player:"
        '
        'playerPictureBox
        '
        Me.playerPictureBox.Location = New System.Drawing.Point(99, 48)
        Me.playerPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.playerPictureBox.Name = "playerPictureBox"
        Me.playerPictureBox.Size = New System.Drawing.Size(115, 86)
        Me.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.playerPictureBox.TabIndex = 4
        Me.playerPictureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Computer:"
        '
        'computerPictureBox
        '
        Me.computerPictureBox.Location = New System.Drawing.Point(238, 48)
        Me.computerPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.computerPictureBox.Name = "computerPictureBox"
        Me.computerPictureBox.Size = New System.Drawing.Size(115, 86)
        Me.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.computerPictureBox.TabIndex = 6
        Me.computerPictureBox.TabStop = False
        '
        'winnerLabel
        '
        Me.winnerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.winnerLabel.Location = New System.Drawing.Point(39, 151)
        Me.winnerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.winnerLabel.Name = "winnerLabel"
        Me.winnerLabel.Size = New System.Drawing.Size(373, 26)
        Me.winnerLabel.TabIndex = 5
        Me.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'paperPictureBox
        '
        Me.paperPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.paperPictureBox.Image = Global.RockPaperScissorsGame_Project.My.Resources.Resources.Paper
        Me.paperPictureBox.Location = New System.Drawing.Point(128, 5)
        Me.paperPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.paperPictureBox.Name = "paperPictureBox"
        Me.paperPictureBox.Size = New System.Drawing.Size(115, 76)
        Me.paperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.paperPictureBox.TabIndex = 9
        Me.paperPictureBox.TabStop = False
        '
        'scissorsPictureBox
        '
        Me.scissorsPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.scissorsPictureBox.Image = Global.RockPaperScissorsGame_Project.My.Resources.Resources.Scissors
        Me.scissorsPictureBox.Location = New System.Drawing.Point(252, 5)
        Me.scissorsPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.scissorsPictureBox.Name = "scissorsPictureBox"
        Me.scissorsPictureBox.Size = New System.Drawing.Size(115, 76)
        Me.scissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.scissorsPictureBox.TabIndex = 10
        Me.scissorsPictureBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Click the Rock, Paper, or Scissors image"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.paperPictureBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.scissorsPictureBox, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rockPictureBox, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(39, 223)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(373, 86)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'rockPictureBox
        '
        Me.rockPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rockPictureBox.Image = Global.RockPaperScissorsGame_Project.My.Resources.Resources.Rock
        Me.rockPictureBox.Location = New System.Drawing.Point(5, 5)
        Me.rockPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.rockPictureBox.Name = "rockPictureBox"
        Me.rockPictureBox.Size = New System.Drawing.Size(115, 76)
        Me.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.rockPictureBox.TabIndex = 11
        Me.rockPictureBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 376)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.winnerLabel)
        Me.Controls.Add(Me.computerPictureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.playerPictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rock, Paper, Scissors Game"
        CType(Me.playerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.computerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scissorsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.rockPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents playerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents computerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents winnerLabel As System.Windows.Forms.Label
    Friend WithEvents paperPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents scissorsPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rockPictureBox As System.Windows.Forms.PictureBox

End Class
