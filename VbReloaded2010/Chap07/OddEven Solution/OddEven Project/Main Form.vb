' Project name:         OddEven Project
' Project purpose:      Displays the odd and even numbers
'                       between two integers
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub number1TextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles number1TextBox.Enter
        number1TextBox.SelectAll()
    End Sub

    Private Sub number2TextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles number2TextBox.Enter
        number2TextBox.SelectAll()
    End Sub

    Private Sub number1TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles number1TextBox.TextChanged
        oddLabel.Text = String.Empty
        evenLabel.Text = String.Empty
    End Sub

    Private Sub number2TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles number2TextBox.TextChanged
        oddLabel.Text = String.Empty
        evenLabel.Text = String.Empty
    End Sub

End Class
