' Project name:         Phone Project
' Project purpose:      Removes any hyphens, spaces, and
'                       parentheses from a phone number
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub numberTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles numberTextBox.Enter
        numberTextBox.SelectAll()
    End Sub

    Private Sub numberTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numberTextBox.TextChanged
        numberLabel.Text = String.Empty
    End Sub

End Class
