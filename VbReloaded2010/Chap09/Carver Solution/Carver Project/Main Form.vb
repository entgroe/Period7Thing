' Project name:         Carver Project
' Project purpose:      Displays a grade based on the number of 
'                       points the user enters
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub pointsTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pointsTextBox.Enter
        pointsTextBox.SelectAll()
    End Sub

    Private Sub pointsTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pointsTextBox.KeyPress
        ' allows numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub pointsTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pointsTextBox.TextChanged
        gradeLabel.Text = String.Empty
    End Sub

End Class
