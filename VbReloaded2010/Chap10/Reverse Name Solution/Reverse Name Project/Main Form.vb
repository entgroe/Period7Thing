' Project name:         Reverse Project
' Project purpose:      Changes a name from first name and last name
'                       to last name, a comma, a space, and the first name
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub nameTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nameTextBox.Enter
        nameTextBox.SelectAll()
    End Sub

    Private Sub nameTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nameTextBox.TextChanged
        nameLabel.Text = String.Empty
    End Sub

End Class
