' Project name:         Static Project
' Project purpose:      Demonstrates the use of a static variable.
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    ' class-level variable used to store the number of times the Count button is clicked
    Private numClicks As Integer

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub countButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles countButton.Click
        ' displays the number of times the button was clicked

        ' add 1 to the numClicks variable each time the button is clicked
        numClicks = numClicks + 1

        ' display message
        messageLabel.Text = "You have clicked the Count button " & _
            Convert.ToString(numClicks) & " time(s)."

    End Sub
End Class
