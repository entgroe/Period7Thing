' Project name:         Colfax Project
' Project purpose:      Displays the total sales
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub salesTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles salesTextBox.KeyPress
        ' allows the text box to accept only numbers, the period,
        ' and the Backspace key for editing

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back _
            AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

    End Sub

    Private Sub addButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles addButton.Click
        ' accumulates the sales amounts entered by the user


    End Sub
End Class
