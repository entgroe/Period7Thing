' Project name:         Grade Project
' Project purpose:      Displays a grade based on two test scores
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fills the list boxes with values

        For score As Integer = 0 To 100
            test1ListBox.Items.Add(score.ToString)
            test2ListBox.Items.Add(score.ToString)
        Next score

        test1ListBox.SelectedItem = "80"
        test2ListBox.SelectedItem = "80"
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearLabel(ByVal sender As Object, ByVal e As System.EventArgs) Handles test1ListBox.SelectedValueChanged, test2ListBox.SelectedValueChanged
        gradeLabel.Text = String.Empty
    End Sub

End Class
