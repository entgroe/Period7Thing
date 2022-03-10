﻿' Project name:         Magazine Project
' Project purpose:      Selects specific records
'                       Also displays the average cost of a magazine
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MagazinesDataSet.tblMagazine' table. You can move, or remove it, as needed.
        Me.TblMagazineTableAdapter.Fill(Me.MagazinesDataSet.tblMagazine)

    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub allButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles allButton.Click
        ' displays all the records

        Dim records = From mag In MagazinesDataSet.tblMagazine Select mag
        TblMagazineBindingSource.DataSource = records.AsDataView
    End Sub
End Class