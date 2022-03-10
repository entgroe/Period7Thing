' Project name:         Cd Collection Project
' Project purpose:      Allows the user to add, delete, 
'                       and modify records and also
'                       search for a specific artist
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub TblCdsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblCdsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblCdsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CDDataSet)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CDDataSet.tblCds' table. You can move, or remove it, as needed.
        Me.TblCdsTableAdapter.Fill(Me.CDDataSet.tblCds)

    End Sub
End Class
