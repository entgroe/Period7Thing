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
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Me.numLabel = New System.Windows.Forms.Label()
        Me.TblFriendsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FriendsDataSet = New Debug_Project.FriendsDataSet()
        Me.lastLabel = New System.Windows.Forms.Label()
        Me.firstLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.cityLabel = New System.Windows.Forms.Label()
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.zipLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.TblFriendsTableAdapter = New Debug_Project.FriendsDataSetTableAdapters.tblFriendsTableAdapter()
        Me.TableAdapterManager = New Debug_Project.FriendsDataSetTableAdapters.TableAdapterManager()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.TblFriendsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FriendsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(34, 39)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 17)
        Label1.TabIndex = 3
        Label1.Text = "Number:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(34, 79)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(34, 17)
        Label2.TabIndex = 5
        Label2.Text = "Last:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(34, 114)
        Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(35, 17)
        Label3.TabIndex = 7
        Label3.Text = "First:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(34, 150)
        Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(59, 17)
        Label4.TabIndex = 9
        Label4.Text = "Address:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(34, 185)
        Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(32, 17)
        Label5.TabIndex = 11
        Label5.Text = "City:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(34, 218)
        Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(40, 17)
        Label6.TabIndex = 13
        Label6.Text = "State:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(174, 218)
        Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(28, 17)
        Label7.TabIndex = 15
        Label7.Text = "ZIP:"
        '
        'numLabel
        '
        Me.numLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "Number", True))
        Me.numLabel.Location = New System.Drawing.Point(95, 39)
        Me.numLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.numLabel.Name = "numLabel"
        Me.numLabel.Size = New System.Drawing.Size(70, 22)
        Me.numLabel.TabIndex = 4
        '
        'TblFriendsBindingSource
        '
        Me.TblFriendsBindingSource.DataMember = "tblFriends"
        Me.TblFriendsBindingSource.DataSource = Me.FriendsDataSet
        '
        'FriendsDataSet
        '
        Me.FriendsDataSet.DataSetName = "FriendsDataSet"
        Me.FriendsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lastLabel
        '
        Me.lastLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "Last", True))
        Me.lastLabel.Location = New System.Drawing.Point(95, 80)
        Me.lastLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lastLabel.Name = "lastLabel"
        Me.lastLabel.Size = New System.Drawing.Size(199, 22)
        Me.lastLabel.TabIndex = 6
        '
        'firstLabel
        '
        Me.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "First", True))
        Me.firstLabel.Location = New System.Drawing.Point(95, 116)
        Me.firstLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.firstLabel.Name = "firstLabel"
        Me.firstLabel.Size = New System.Drawing.Size(199, 22)
        Me.firstLabel.TabIndex = 8
        '
        'addressLabel
        '
        Me.addressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addressLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "Address", True))
        Me.addressLabel.Location = New System.Drawing.Point(95, 151)
        Me.addressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(199, 22)
        Me.addressLabel.TabIndex = 10
        '
        'cityLabel
        '
        Me.cityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cityLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "City", True))
        Me.cityLabel.Location = New System.Drawing.Point(95, 185)
        Me.cityLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(199, 22)
        Me.cityLabel.TabIndex = 12
        '
        'stateLabel
        '
        Me.stateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stateLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "State", True))
        Me.stateLabel.Location = New System.Drawing.Point(95, 218)
        Me.stateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(49, 22)
        Me.stateLabel.TabIndex = 14
        '
        'zipLabel
        '
        Me.zipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.zipLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "ZIP", True))
        Me.zipLabel.Location = New System.Drawing.Point(211, 218)
        Me.zipLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.zipLabel.Name = "zipLabel"
        Me.zipLabel.Size = New System.Drawing.Size(83, 22)
        Me.zipLabel.TabIndex = 16
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(338, 101)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(86, 27)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(338, 70)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(2)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(86, 27)
        Me.nextButton.TabIndex = 1
        Me.nextButton.Text = "&Next"
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(338, 39)
        Me.previousButton.Margin = New System.Windows.Forms.Padding(2)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(86, 27)
        Me.previousButton.TabIndex = 0
        Me.previousButton.Text = "&Previous"
        '
        'TblFriendsTableAdapter
        '
        Me.TblFriendsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblFriendsTableAdapter = Me.TblFriendsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Debug_Project.FriendsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 297)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.numLabel)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.lastLabel)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.firstLabel)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.cityLabel)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.stateLabel)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.zipLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.previousButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.Text = "Friends"
        CType(Me.TblFriendsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FriendsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numLabel As System.Windows.Forms.Label
    Friend WithEvents lastLabel As System.Windows.Forms.Label
    Friend WithEvents firstLabel As System.Windows.Forms.Label
    Friend WithEvents addressLabel As System.Windows.Forms.Label
    Friend WithEvents cityLabel As System.Windows.Forms.Label
    Friend WithEvents stateLabel As System.Windows.Forms.Label
    Friend WithEvents zipLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents FriendsDataSet As Debug_Project.FriendsDataSet
    Friend WithEvents TblFriendsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblFriendsTableAdapter As Debug_Project.FriendsDataSetTableAdapters.tblFriendsTableAdapter
    Friend WithEvents TableAdapterManager As Debug_Project.FriendsDataSetTableAdapters.TableAdapterManager

End Class
