' Project name:         Inventory Project
' Project purpose:      Displays the sum of the values contained in a two-dimensional array
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click
        ' displays the sum of the values stored in the inventory array

        Dim inventory(,) As Integer = {{34, 56}, _
                                       {75, 67}, _
                                       {5, 6}}


    End Sub
End Class
