' Project name:         Temperature Solution
' Project purpose:      Convert a temperature to
'                       either Celsius or Fahrenheit
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub ClearLabel(ByVal sender As Object, ByVal e As System.EventArgs
                           ) Handles tempTextBox.TextChanged,
                       toCelsiusRadioButton.Click,
                       toFahrenheitRadioButton.Click
        resultLabel.Text = String.Empty
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub tempTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tempTextBox.Enter
        tempTextBox.SelectAll()
    End Sub

End Class
