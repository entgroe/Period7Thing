' Project name:         Debug Project
' Project purpose:      Displays the salary entered by the user
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub GetSalary(ByVal salary As Double)
        ' gets a salary from the user

        Dim salaryEntry As String
        salaryEntry = InputBox("Enter your salary:", "Salary")
        Double.TryParse(salaryEntry, salary)
    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click
        ' displays the salary entered by the user

        Dim mySalary As Double

        ' call a procedure to get the salary
        Call GetSalary(mySalary)

        ' display the salary
        salaryLabel.Text = mySalary.ToString("C2")
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
