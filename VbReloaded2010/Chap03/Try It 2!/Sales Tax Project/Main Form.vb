Public Class MainForm

    Private Sub calcTax2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcTax2Button.Click
        ' calculates a 2% sales tax

        ' declare variables
        Dim sales As Double
        Dim tax2 As Double

        ' calculate and display the sales tax
        Double.TryParse(salesTextBox.Text, sales)
        tax2 = sales * 0.02
        taxLabel.Text = Convert.ToString(tax2)
    End Sub

    Private Sub calcTax5Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcTax5Button.Click
        ' calculates a 5% sales tax

        ' declare variables
        Dim sales As Double
        Dim tax5 As Double

        ' calculate and display the sales tax
        Double.TryParse(salesTextBox.Text, sales)
        tax5 = sales * 0.05
        taxLabel.Text = Convert.ToString(tax5)
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
