' Project name:         Employee List Project
' Project purpose:      Writes employee names to a sequential
'                       access file and reads the names from
'                       the file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub employTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles employTextBox.Enter
        employTextBox.SelectAll()
    End Sub

End Class
