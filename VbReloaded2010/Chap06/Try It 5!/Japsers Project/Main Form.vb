' Project name:         Jaspers Project
' Project purpose:      Adds names during run time
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub addButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles addButton.Click
        ' adds the name entered in the text box
        ' to the list box

        workerListBox.Items.Add(nameTextBox.Text)
    End Sub

End Class
