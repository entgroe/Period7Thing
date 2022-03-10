' Project name:         O'Reilly Project
' Project purpose:      Display the total cost
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private priceChart(,) As Integer = {{11, 75},
                                        {6, 90},
                                        {1, 100}}

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' display the total cost

        Dim quantity As Integer
        Dim pricePerPainting As Integer
        Dim totalCost As Integer

        Dim row As Integer
        Dim highRow As Integer =
            priceChart.GetUpperBound(0)
        Dim found As Boolean

        Integer.TryParse(quantityTextBox.Text, quantity)

        ' search the first column in each row
        Do While row <= highRow AndAlso found = False
            If quantity >= priceChart(row, 0) Then
                pricePerPainting = priceChart(row, 1)
                found = True
            Else
                row += 1
            End If
        Loop

        totalCost = quantity * pricePerPainting
        totalLabel.Text = totalCost.ToString("C0")
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub quantityTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles quantityTextBox.Enter
        ' select the existing text

        quantityTextBox.SelectAll()
    End Sub

    Private Sub quantityTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles quantityTextBox.KeyPress
        ' allow numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub quantityTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles quantityTextBox.TextChanged
        ' clear the total price

        totalLabel.Text = String.Empty
    End Sub
End Class
