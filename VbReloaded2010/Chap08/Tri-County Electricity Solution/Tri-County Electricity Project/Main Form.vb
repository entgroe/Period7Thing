' Project name:         Tri-County Electricity Project
' Project purpose:      Displays the monthly electric bill
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Dim charge As Double
    Dim previous As Integer
    Dim current As Integer
    Dim usage As Integer
    Dim total As Double

    Private Sub CalcResidential() total As Integer 



    Const UnitCharge As Double = 0.09
        Const MinFee As Double = 17.65


        charge = units * UnitCharge
        charge = MinFee

        If charge < MinFee Then
            Charge = MinFee
        End If

    Private Function GetCommercialTotal(ByVal units As Integer) As Double

        Const UnitCharge As Double = 0.12
        Const MinFee As Double = 21.75
        charge = units * UnitCharge
        Charge = MinFee


    Private Sub currentTextBox_TextChanged(sender As Object, e As EventArgs) Handles currentTextBox.TextChanged, previousTextBox.TextChanged, residentialRadioButton.Click, commercialRadioButton.Click
        Dim thisTextbox As TextBox
        thisTextbox = TryCast(sender, TextBox)
        thisTextbox.SelectAll()
        usageLabel.Text = String.Empty
        totalLabel.Text = String.Empty
    End Sub



    Private Sub previousTextBox_TextChanged(sender As Object, e As EventArgs) Handles previousTextBox.KeyPress, previousTextBox.KeyPress


        If (e.Keychar < "0" OrElse e.KeyChar > "9") AndAlso
        e.Keychar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub



    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub






End Class
