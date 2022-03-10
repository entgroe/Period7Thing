' Project name:         Pool Project
' Project purpose:      Display the number of gallons 
'                       needed to fill a rectangular pool
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Public Function GetGallons(ByVal len As Double,
                               ByVal wid As Double,
                               ByVal dep As Double) As Double
        ' calculates and returns the number of gallons

        Const GalPerCubicFoot As Double = 7.48

        Return len * wid * dep * GalPerCubicFoot
    End Function

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' displays the number of gallons

        Dim poolLength As Double
        Dim poolWidth As Double
        Dim poolDepth As Double
        Dim gallons As Double

        Double.TryParse(lengthTextBox.Text, poolLength)
        Double.TryParse(widthTextBox.Text, poolWidth)
        Double.TryParse(depthTextBox.Text, poolDepth)

        gallons =
            GetGallons(poolLength, poolWidth, poolDepth)
        gallonsLabel.Text = gallons.ToString("N0")

        lengthTextBox.Focus()
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub SelectText(ByVal sender As Object, ByVal e As System.EventArgs
                            ) Handles lengthTextBox.Enter, widthTextBox.Enter,
                            depthTextBox.Enter
        Dim curTextBox As TextBox
        curTextBox = TryCast(sender, TextBox)
        curTextBox.SelectAll()
    End Sub

    Private Sub CancelKeys(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs
                        ) Handles lengthTextBox.KeyPress, widthTextBox.KeyPress,
                        depthTextBox.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearGallons(ByVal sender As Object, ByVal e As System.EventArgs
                         ) Handles lengthTextBox.TextChanged,
                         widthTextBox.TextChanged, depthTextBox.TextChanged
        gallonsLabel.Text = String.Empty
    End Sub
End Class
