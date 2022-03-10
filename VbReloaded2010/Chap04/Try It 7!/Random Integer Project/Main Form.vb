' Project name:         Random Integer Project
' Project purpose:      Displays random numbers from 1 through 10.
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub generateButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles generateButton.Click
        ' displays random numbers from 1 through 10

        Dim number As Integer
        Dim randomGenerator As New Random

        ' generate and display random number
        number = randomGenerator.Next(1, 11)
        randomLabel.Text = Convert.ToString(number)
    End Sub
End Class
