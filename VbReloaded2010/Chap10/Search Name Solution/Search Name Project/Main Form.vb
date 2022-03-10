' Project name:         Search Name Project
' Project purpose:      Displays a message that indicates
'                       whether a name begins with the search text 
'                       or comes before or after the search text
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub nameTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nameTextBox.Enter
        nameTextBox.SelectAll()
    End Sub

    Private Sub nameTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nameTextBox.TextChanged
        messageLabel.Text = String.Empty
    End Sub

    Private Sub searchTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchTextBox.Enter
        searchTextBox.SelectAll()
    End Sub

    Private Sub searchTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchTextBox.TextChanged
        messageLabel.Text = String.Empty
    End Sub

End Class
