' Project name:         Timer Example Project
' Project purpose:      Blink a message 10 times
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub blinkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles blinkButton.Click
        ' turns the timer on
        blinkTimer.Enabled = True
    End Sub

    Private Sub blinkTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles blinkTimer.Tick
        ' blinks the welcomeLabel 10 times

        Static numBlinks As Integer = 1

        If numBlinks < 11 Then
            If welcomeLabel.Visible = True Then
                welcomeLabel.Visible = False
            Else
                welcomeLabel.Visible = True
                numBlinks += 1
            End If
        Else
            blinkTimer.Enabled = False
        End If
    End Sub
End Class
