' Project name:         Clark Chicken Project
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
        ' adds items to the list box

        Dim worker As String

        worker = InputBox("Who is working today?", "Name")
        Do While worker <> String.Empty
            workerListBox.Items.Add(worker)
            worker = InputBox("Who else is working?", "Name")
        Loop
    End Sub
End Class
