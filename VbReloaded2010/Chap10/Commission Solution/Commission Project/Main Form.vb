' Project name:         Commission Project
' Project purpose:      Displays a commission
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub salesTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles salesTextBox.Enter
        salesTextBox.SelectAll()
    End Sub

    Private Sub salesTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles salesTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
             e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub salesTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles salesTextBox.TextChanged
        commissionLabel.Text = String.Empty
    End Sub

End Class
