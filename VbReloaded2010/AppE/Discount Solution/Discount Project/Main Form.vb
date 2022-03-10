' Project name:         Discount Project
' Project purpose:      Displays three discount amounts
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
        ' calculates and displays a 10%, 20%, and
        ' 30% discount on an item's price

        ' declare variables
        Dim price As Double
        Dim discount10 As Double
        Dim discount20 As Double
        Dim discount30 As Double

        ' calculate discounts
        discount10 = price * 0.1
        discount20 = price * 0.2
        discount30 = price * 0.3

        ' display discounts
        disc10Label.Text = discount10.ToString("N2")
        disc20Label.Text = discount20.ToString("N2")
        disc30Label.Text = discount30.ToString("N2")
    End Sub
End Class
