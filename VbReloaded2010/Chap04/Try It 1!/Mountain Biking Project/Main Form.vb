Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' Example 1
        'Dim price As Double
        'Dim quantity As Integer
        'Dim total As Double
        'Dim discount As Double

        'Double.TryParse(priceTextBox.Text, price)
        'Integer.TryParse(quantityTextBox.Text, quantity)

        'total = price * quantity
        'If quantity > 5 Then
        '    discount = total * 0.1
        '    total = total - discount
        'End If
        'totalLabel.Text = total.ToString("C2")

        ' Example 2
        'Dim price As Double
        'Dim quantity As Integer
        'Dim total As Double
        'Dim discount As Double
        'Dim discountRate As Double

        'Double.TryParse(priceTextBox.Text, price)
        'Integer.TryParse(quantityTextBox.Text, quantity)

        'total = price * quantity
        'If quantity > 5 Then
        '    discountRate = 0.1
        'Else
        '    discountRate = 0.05
        'End If

        'discount = total * discountRate
        'total = total - discount

        'totalLabel.Text = total.ToString("C2")
    End Sub
End Class
