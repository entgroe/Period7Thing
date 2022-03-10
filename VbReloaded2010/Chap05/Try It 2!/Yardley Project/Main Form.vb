' Project name:         Yardley Project
' Project purpose:      Displays the price of a ticket
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click
        ' displays the ticket price

        Dim code As Integer
        Integer.TryParse(codeTextBox.Text, code)

        ' display appropriate price
        ' <enter the code from Figure 5-11 here>

    End Sub
End Class
