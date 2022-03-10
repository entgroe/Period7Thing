' Project name:         Debug Project
' Project purpose:      Displays the new price for a computer
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub ClearLabel(ByVal sender As Object, ByVal e As System.EventArgs
                           ) Handles modelTextBox.TextChanged, discountListBox.SelectedValueChanged,
                            origTextBox.TextChanged
        newLabel.Text = String.Empty
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fills the list box with values and then selects the first value

        discountListBox.Items.Add("None")
        For discount As Decimal = 0.05D To 0.15D Step 0.01D
            discountListBox.Items.Add(discount.ToString)
        Next discount
        discountListBox.SelectedIndex = 0
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates the new price for a computer

        Dim computerPurchased As New Computer
        Dim rate As Decimal
        Dim newPrice As Decimal

        Computer.Id = modelTextBox.Text
        Computer.Price = origTextBox.Text
        Decimal.TryParse(discountListBox.SelectedItem.ToString, rate)

        newPrice = Computer.CalcNewPrice(rate)
        newLabel.Text = newPrice.ToString("C2")
    End Sub
End Class
