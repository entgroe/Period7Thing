' Project name:         Zip Project
' Project purpose:      Displays a shipping charge
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub zipTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles zipTextBox.Enter
        zipTextBox.SelectAll()
    End Sub

    Private Sub zipTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles zipTextBox.TextChanged
        shippingLabel.Text = String.Empty
    End Sub

End Class
