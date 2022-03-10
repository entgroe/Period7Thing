' Project name:         Color Project
' Project purpose:      Displays an item's color 
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub itemTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles itemTextBox.Enter
        itemTextBox.SelectAll()
    End Sub

    Private Sub itemTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles itemTextBox.TextChanged
        colorLabel.Text = String.Empty
    End Sub

End Class
