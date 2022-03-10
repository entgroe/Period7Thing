' Project name:         Try It 3! Project
' Project purpose:      Examples of the PadLeft and PadRight methods
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub padLeft1Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles padLeft1Button.Click
        Dim num As String = "73"
        num = num.PadLeft(5)
        MessageBox.Show("The string is now '" & num & "'", "PadLeft Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub padRight2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles padRight2Button.Click
        Dim first As String = "Sue"
        first = first.PadRight(10)
        MessageBox.Show("The string is now '" & first & "'", "PadRight Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub padLeft3Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles padLeft3Button.Click
        Dim netPay As Double = 645.75
        Dim formattedPay As String
        formattedPay = netPay.ToString("C2").PadLeft(10, "*"c)
        MessageBox.Show("The formatted net pay is " & formattedPay, "PadLeft Example 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
