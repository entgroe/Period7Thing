' Project name:         Clock Project
' Projecct purpose:     Displays minutes and seconds
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub v1Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles v1Button.Click
        ' displays minutes (from 0 through 2 only) 
        ' and seconds (from 0 through 5 only)

        For minutes As Integer = 0 To 2
            minutesLabel.Text = minutes.ToString
            For seconds As Integer = 0 To 5
                secondsLabel.Text = seconds.ToString
                ' refresh interface, then pause execution
                Me.Refresh()
                System.Threading.Thread.Sleep(500)
            Next seconds
        Next minutes
    End Sub

    Private Sub v2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles v2Button.Click
        ' displays minutes (from 0 through 2 only) 
        ' and seconds (from 0 through 5 only)

        Dim minutes As Integer
        Dim seconds As Integer

        Do While minutes <= 2
            minutesLabel.Text = minutes.ToString
            seconds = 0
            Do While seconds <= 5
                secondsLabel.Text = seconds.ToString
                ' refresh interface, then pause execution
                Me.Refresh()
                System.Threading.Thread.Sleep(500)
                seconds += 1
            Loop
            minutes += 1
        Loop
    End Sub

    Private Sub v3Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles v3Button.Click
        ' displays minutes (from 0 through 2 only) 
        ' and seconds (from 0 through 5 only)

        Dim minutes As Integer

        Do While minutes <= 2
            minutesLabel.Text = minutes.ToString
             For seconds As Integer = 0 To 5
                secondsLabel.Text = seconds.ToString
                ' refresh interface, then pause execution
                Me.Refresh()
                System.Threading.Thread.Sleep(500)
            Next seconds
            minutes += 1
        Loop
    End Sub
End Class
