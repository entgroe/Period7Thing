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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.nameButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.codeButton = New System.Windows.Forms.Button()
        Me.allButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TblMagazineDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MagNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblMagazineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MagazinesDataSet = New Magazine_Project.MagazinesDataSet()
        Me.TblMagazineTableAdapter = New Magazine_Project.MagazinesDataSetTableAdapters.tblMagazineTableAdapter()
        Me.TableAdapterManager = New Magazine_Project.MagazinesDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblMagazineDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMagazineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MagazinesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameButton
        '
        Me.nameButton.Location = New System.Drawing.Point(316, 370)
        Me.nameButton.Name = "nameButton"
        Me.nameButton.Size = New System.Drawing.Size(180, 31)
        Me.nameButton.TabIndex = 2
        Me.nameButton.Text = "Display &MagName Java"
        Me.nameButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(502, 370)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(69, 31)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'codeButton
        '
        Me.codeButton.Location = New System.Drawing.Point(156, 370)
        Me.codeButton.Name = "codeButton"
        Me.codeButton.Size = New System.Drawing.Size(154, 31)
        Me.codeButton.TabIndex = 1
        Me.codeButton.Text = "Display &Code PG24"
        Me.codeButton.UseVisualStyleBackColor = True
        '
        'allButton
        '
        Me.allButton.Location = New System.Drawing.Point(38, 370)
        Me.allButton.Name = "allButton"
        Me.allButton.Size = New System.Drawing.Size(112, 31)
        Me.allButton.TabIndex = 0
        Me.allButton.Text = "Display &All"
        Me.allButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TblMagazineDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 300)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'TblMagazineDataGridView
        '
        Me.TblMagazineDataGridView.AllowUserToAddRows = False
        Me.TblMagazineDataGridView.AllowUserToDeleteRows = False
        Me.TblMagazineDataGridView.AutoGenerateColumns = False
        Me.TblMagazineDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblMagazineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblMagazineDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.MagNameDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn})
        Me.TblMagazineDataGridView.DataSource = Me.TblMagazineBindingSource
        Me.TblMagazineDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblMagazineDataGridView.Location = New System.Drawing.Point(3, 19)
        Me.TblMagazineDataGridView.Name = "TblMagazineDataGridView"
        Me.TblMagazineDataGridView.ReadOnly = True
        Me.TblMagazineDataGridView.RowHeadersVisible = False
        Me.TblMagazineDataGridView.RowTemplate.Height = 24
        Me.TblMagazineDataGridView.Size = New System.Drawing.Size(530, 278)
        Me.TblMagazineDataGridView.TabIndex = 0
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MagNameDataGridViewTextBoxColumn
        '
        Me.MagNameDataGridViewTextBoxColumn.DataPropertyName = "MagName"
        Me.MagNameDataGridViewTextBoxColumn.HeaderText = "MagName"
        Me.MagNameDataGridViewTextBoxColumn.Name = "MagNameDataGridViewTextBoxColumn"
        Me.MagNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "Cost"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CostDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        Me.CostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblMagazineBindingSource
        '
        Me.TblMagazineBindingSource.DataMember = "tblMagazine"
        Me.TblMagazineBindingSource.DataSource = Me.MagazinesDataSet
        '
        'MagazinesDataSet
        '
        Me.MagazinesDataSet.DataSetName = "MagazinesDataSet"
        Me.MagazinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMagazineTableAdapter
        '
        Me.TblMagazineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblMagazineTableAdapter = Me.TblMagazineTableAdapter
        Me.TableAdapterManager.UpdateOrder = Magazine_Project.MagazinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 427)
        Me.Controls.Add(Me.nameButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.codeButton)
        Me.Controls.Add(Me.allButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazines"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TblMagazineDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMagazineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MagazinesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nameButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents codeButton As System.Windows.Forms.Button
    Friend WithEvents allButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TblMagazineDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MagazinesDataSet As Magazine_Project.MagazinesDataSet
    Friend WithEvents TblMagazineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMagazineTableAdapter As Magazine_Project.MagazinesDataSetTableAdapters.tblMagazineTableAdapter
    Friend WithEvents TableAdapterManager As Magazine_Project.MagazinesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MagNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
