' Project name:         Items Project
' Project purpose:      Demonstrates the Insert, Remove, 
'                       Remove At, and Clear methods of the 
'                       Items collection
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fills the list box with values, then selects the first value

        namesListBox.Items.Add("Jameston, Harry")
        namesListBox.Items.Add("Neven, John")
        namesListBox.Items.Add("Smith, Mary")
        namesListBox.Items.Add("Woods, Janet")
        namesListBox.Items.Add("Yardley, Pat")
        namesListBox.SelectedIndex = 0
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub insertButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles insertButton.Click
        ' adds a name at a specified position in the list box


    End Sub

    Private Sub removeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles removeButton.Click
        ' removes a specified name from the list box


    End Sub

    Private Sub removeAtButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles removeAtButton.Click
        ' removes a name from a specified position in the list box


    End Sub

    Private Sub clearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clearButton.Click
        ' removes all of the items from the list box


    End Sub

    Private Sub countButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles countButton.Click
        ' displays the number of items in the list box

 
    End Sub
End Class
