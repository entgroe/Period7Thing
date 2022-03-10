Public Class MainForm

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates the total sales 

        ' declare variables
        Dim salesAmount As Decimal
        Static totalSales As Decimal

        ' calculate and display the total sales
        Decimal.TryParse(salesTextBox.Text, salesAmount)
        totalSales = totalSales + salesAmount
        totalSalesLabel.Text = Convert.ToString(totalSales)
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
