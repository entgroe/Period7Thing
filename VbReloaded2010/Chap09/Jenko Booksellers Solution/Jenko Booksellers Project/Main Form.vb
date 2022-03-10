' Project name:         Jenko Booksellers Project
' Project purpose:      Display the total of the sales
'                       stored in a two-dimensional array
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' display the total sales

        Dim sales(,) As Double = {{1200.33, 2350.75},
                                  {3677.8, 2456.05},
                                  {750.67, 1345.99}}
        Dim total As Double

        ' accumulate array values
        For Each saleElement As Double In sales
            total += saleElement
        Next saleElement

        totalLabel.Text = total.ToString("C2")
    End Sub
End Class
