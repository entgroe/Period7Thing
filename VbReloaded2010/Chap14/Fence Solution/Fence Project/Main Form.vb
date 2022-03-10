' Project name:         Fence Project
' Project purpose:      Calculates the cost of a fence
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub SelectText(ByVal sender As Object, ByVal e As System.EventArgs) Handles lengthTextBox.Enter,
                                        widthTextBox.Enter, footCostTextBox.Enter
        Dim x As TextBox
        x = TryCast(sender, TextBox)
        x.SelectAll()
    End Sub

    Private Sub ClearLabel(ByVal sender As Object, ByVal e As System.EventArgs) Handles lengthTextBox.TextChanged,
                                    widthTextBox.TextChanged, footCostTextBox.TextChanged
        totalCostLabel.Text = String.Empty
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
