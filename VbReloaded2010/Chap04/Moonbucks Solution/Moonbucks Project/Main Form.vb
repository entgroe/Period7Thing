' Project name:         Moonbucks Project
' Project purpose:      Calculates the total pounds of coffee
'                       ordered and the total price
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub printButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles printButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub clearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clearButton.Click
        ' prepares the screen for the next order

        nameTextBox.Text = String.Empty
        addressTextBox.Text = String.Empty
        cityTextBox.Text = String.Empty
        stateTextBox.Text = String.Empty
        zipTextBox.Text = String.Empty
        regularTextBox.Text = String.Empty
        decafTextBox.Text = String.Empty
        totalPoundsLabel.Text = String.Empty
        totalPriceLabel.Text = String.Empty
        nameTextBox.Focus()

    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates total pounds ordered and total price

        ' declare constant and variables
        Const PricePerPound As Double = 11.15
        Dim regularCoffee As Integer
        Dim decafCoffee As Integer
        Dim totalPounds As Integer
        Dim totalPrice As Double

        ' assign input to variables
        Integer.TryParse(regularTextBox.Text, regularCoffee)
        Integer.TryParse(decafTextBox.Text, decafCoffee)

        ' perform calculations
        totalPounds = regularCoffee + decafCoffee
        totalPrice = totalPounds * PricePerPound

        ' display calculated results
        totalPoundsLabel.Text = Convert.ToString(totalPounds)
        totalPriceLabel.Text = totalPrice.ToString("C2")

        clearButton.Focus()

    End Sub
End Class
