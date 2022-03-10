' Project name:         Bonus Project
' Project purpose:      Calculates a salesperson's bonus 
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates a bonus amount

        Dim sales As Double
        Dim bonus As Double

        Double.TryParse(salesTextBox.Text, sales)

        If sales <= 0 Then
            bonus = 0
        ElseIf sales <= 5000 Then
            bonus = sales * 0.05
        Else
            bonus = sales * 0.1
        End If

        bonusLabel.Text = bonus.ToString("C2")
        salesTextBox.Focus()
    End Sub

    Private Sub salesTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles salesTextBox.Enter
        salesTextBox.SelectAll()
    End Sub

    Private Sub salesTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles salesTextBox.TextChanged
        bonusLabel.Text = String.Empty
    End Sub

End Class
