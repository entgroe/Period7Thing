' Project name:         AddSub Project
' Project purpose:      Displays either the sum of or the 
'                       difference between two numbers.
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub subtractionCheckBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles subtractionCheckBox.Click
        ' assigns the appropriate arithmetic operator
        ' to the operationLabel

        If subtractionCheckBox.Checked = True Then
            operationLabel.Text = "-"
        Else
            operationLabel.Text = "+"
        End If
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates either the sum of or the 
        ' difference between two numbers

        Dim num1 As Double
        Dim num2 As Double
        Dim answer As Double

        ' convert number input to Double
        Double.TryParse(num1TextBox.Text, num1)
        Double.TryParse(num2TextBox.Text, num2)

        ' calculate and display the sum or the difference
        If subtractionCheckBox.Checked = False Then
            answer = num1 + num2
        Else
            answer = num1 - num2
        End If
        answerLabel.Text = answer.ToString()

    End Sub
End Class
