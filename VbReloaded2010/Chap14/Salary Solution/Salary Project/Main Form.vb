' Project name:         Salary Project
' Project purpose:      Calculates an employee's new salary
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub SelectText(ByVal sender As Object, ByVal e As System.EventArgs) Handles nameTextBox.Enter,
                                                    currentTextBox.Enter, raisePercentTextBox.Enter
        Dim x As TextBox
        x = TryCast(sender, TextBox)
        x.SelectAll()
    End Sub


    Private Sub ClearLabel(ByVal sender As Object, ByVal e As System.EventArgs) Handles currentTextBox.TextChanged,
                                                    raisePercentTextBox.TextChanged
        newLabel.Text = String.Empty
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates the new salary

        ' declare variables
        Dim percent As Double
        Dim ourWorker As New Worker

        ' assign name and salary to Worker object's properties

        ' assign raise percentage to a variable

        ' calculate and display the new salary
  
    End Sub

End Class
