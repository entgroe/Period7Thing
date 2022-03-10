' Project name:         Hours Worked Project
' Project purpose:      Displays the total hours worked
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object,
        ByVal e As System.EventArgs) Handles calcButton.Click
        ' displays total number of hours worked during 4 weeks

        Dim week1 As Decimal
        Dim week2 As Decimal
        Dim week3 As Decimal
        Dim week4 As Decimal
        Dim total As Decimal

        ' assign input to variables
        Decimal.TryParse(week1TextBox.Text, week1)
        Decimal.TryParse(week2TextBox.Text, week2)
        Decimal.TryParse(week3TextBox.Text, week2)
        Decimal.TryParse(week4TextBox.Text, week4)

        ' calculate total hours worked
        total = week1 + week2 + week3 + week4

        ' display total hours worked
        totalLabel.Text = total.ToString
    End Sub
End Class
