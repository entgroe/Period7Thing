' Project name:         Carroll Company Project
' Project purpose:      Calculates and displays a gross pay amount
'                       based on the number of hours worked.
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates and displays a gross pay amount
        ' or an error message

        Dim hours As Double
        Dim grossPay As Double

        Double.TryParse(hoursTextBox.Text, hours)

        ' Example 1
        If hours >= 0 AndAlso hours <= 40 Then
            ' calculate and display gross pay
            grossPay = hours * 10.65
            grossLabel.Text = grossPay.ToString("C2")
        Else
            ' display an error message
            grossLabel.Text = "Error"
        End If

        ' Example 2
        'If hours < 0 OrElse hours > 40 Then
        '    ' display an error message
        '    grossLabel.Text = "Error"
        'Else
        '    ' calculate and display gross pay
        '    grossPay = hours * 10.65
        '    grossLabel.Text = grossPay.ToString("C2")
        'End If
    End Sub

End Class
