' Project name:         Sunshine Cellular Project
' Project purpose:      Calculates the total number of phones 
'                       ordered and the total price
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates the total number of phones 
        ' ordered and the total price

        ' declare constants and variables
        Const PhonePrice As Decimal = 100D
        Const TaxRate As Decimal = 0.05D
        Dim silverPhones As Integer
        Dim bluePhones As Integer
        Dim totalPhones As Integer
        Dim subtotal As Decimal
        Dim salesTax As Decimal
        Dim totalPrice As Decimal

        ' assign user input to variables
        Integer.TryParse(silverTextBox.Text, silverPhones)
        Integer.TryParse(blueTextBox.Text, bluePhones)

        ' perform calculations
        totalPhones = silverPhones + bluePhones
        subtotal = totalPhones * PhonePrice
        salesTax = subtotal * TaxRate
        totalPrice = subtotal + salesTax

        ' display calculated amounts
        totalPhonesLabel.Text = Convert.ToString(totalPhones)
        totalPriceLabel.Text = totalPrice.ToString("C2")
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clearButton.Click
        ' prepares the screen for the next order

        nameTextBox.Text = String.Empty
        addressTextBox.Text = String.Empty
        cityTextBox.Text = String.Empty
        stateTextBox.Text = String.Empty
        zipTextBox.Text = String.Empty
        silverTextBox.Text = String.Empty
        blueTextBox.Text = String.Empty
        totalPhonesLabel.Text = String.Empty
        totalPriceLabel.Text = String.Empty
        nameTextBox.Focus()
    End Sub
End Class
