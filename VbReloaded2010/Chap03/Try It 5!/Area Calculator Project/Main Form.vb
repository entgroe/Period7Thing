' Project name:         Area Calculator Project
' Project purpose:      Calculates the area of a circle
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates the area of a circle

        ' declare named constant and variables
        Const Pi As Double = 3.141593
        Dim radius As Double
        Dim area As Double
        
        ' calculate and display the area
        Double.TryParse(radiusTextBox.Text, radius)
        area = Pi * radius * radius
        areaLabel.Text = Convert.ToString(area)
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
