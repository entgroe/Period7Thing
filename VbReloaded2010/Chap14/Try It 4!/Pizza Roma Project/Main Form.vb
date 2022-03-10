' Project name:         Pizza Roma Project
' Project purpose:      Display the number of square pizza slices that can be cut from a square pizza
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub entirePizzaTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles entirePizzaTextBox.Enter
        entirePizzaTextBox.SelectAll()
    End Sub

    Private Sub pizzaSliceTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pizzaSliceTextBox.Enter
        pizzaSliceTextBox.SelectAll()
    End Sub

    Private Sub CancelKeys(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs
                                            ) Handles entirePizzaTextBox.KeyPress, pizzaSliceTextBox.KeyPress
        ' allows only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(ByVal sender As Object, ByVal e As System.EventArgs
                        ) Handles entirePizzaTextBox.TextChanged, pizzaSliceTextBox.TextChanged
        slicesLabel.Text = String.Empty
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' displays the number of square pizza slices
        ' that can be cut from a square pizza

        Dim entirePizza As New Rectangle
        Dim pizzaSlice As New Rectangle
        Dim entireArea As Double
        Dim sliceArea As Double
        Dim slices As Double

        Double.TryParse(entirePizzaTextBox.Text, entirePizza.Length)
        Double.TryParse(entirePizzaTextBox.Text, entirePizza.Width)
        Double.TryParse(pizzaSliceTextBox.Text, pizzaSlice.Length)
        Double.TryParse(pizzaSliceTextBox.Text, pizzaSlice.Width)

        ' calculate area of entire pizza and pizza slice
        entireArea = entirePizza.GetArea
        sliceArea = pizzaSlice.GetArea
        ' calculate and display number of slices
        slices = entireArea / sliceArea
        slicesLabel.Text = slices.ToString("N1")
    End Sub
End Class
