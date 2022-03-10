' Project name:         Replace Method Project
' Project purpose:      Replaces dashes with the empty string
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

    Private Sub replaceButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles replaceButton.Click
        ' replaces the dashes in a social security number
        ' with the empty string

    End Sub

End Class

