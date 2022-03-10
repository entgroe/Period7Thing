' Project name:         Multi Project
' Project purpose:      Demonstrates a single selection and
'                       multi-selection list box
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fills the list box with values

        namesListBox.Items.Add("Debbie")
        namesListBox.Items.Add("Bill")
        namesListBox.Items.Add("Jim")
        namesListBox.Items.Add("Ahmad")
        namesListBox.Items.Add("Carol")
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub singleButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles singleButton.Click
        ' displays the item selected in the list box


    End Sub

    Private Sub multiButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles multiButton.Click
        ' displays the items selected in the list box


    End Sub
End Class
