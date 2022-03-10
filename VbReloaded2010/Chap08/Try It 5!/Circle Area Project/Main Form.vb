' Project name:         Circle Area Project
' Project purpose:      Displays the area of a circle
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Function GetCircleArea(ByVal radius As Double) As Double
        Dim area As Double
        area = 3.141593 * radius ^ 2
        Return area
    End Function

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        Dim circleRadius As Double
        Dim circleArea As Double

        Double.TryParse(radiusTextBox.Text, circleRadius)
        circleArea = GetCircleArea(circleRadius)
        areaLabel.Text = circleArea.ToString("N2")
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub radiusTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles radiusTextBox.Enter
        radiusTextBox.SelectAll()
    End Sub

    Private Sub radiusTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles radiusTextBox.KeyPress
        ' allow only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub radiusTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radiusTextBox.TextChanged
        areaLabel.Text = String.Empty
    End Sub
End Class
