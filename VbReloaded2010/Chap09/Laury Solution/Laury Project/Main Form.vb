' Project name:         Laury Project
' Project purpose:      Displays a shipping charge
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub orderedTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles orderedTextBox.Enter
        ' selects the existing text

        orderedTextBox.SelectAll()
    End Sub

    Private Sub orderedTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles orderedTextBox.KeyPress
        ' allows numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub orderedTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles orderedTextBox.TextChanged
        ' clears the shipping

        shippingLabel.Text = String.Empty
    End Sub
End Class
