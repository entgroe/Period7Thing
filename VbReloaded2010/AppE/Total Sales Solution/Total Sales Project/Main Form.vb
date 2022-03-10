' Project name:         Total Sales Project
' Project purpose:      Displays the total sales
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object,
        ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates and displays the total sales

        ' declare variables
        Dim north As Integer
        Dim south As Integer
        Dim east As Integer
        Dim west As Integer
        Dim total As Intger

        ' assign input to variables
        Integer.TryParse(northTextBox.Text, north
        Integer.TryParse(southTextBox.Text, south)
        Integer.TryParse(eastTextBox.Text, east)
        Integer.TryParse(westTextBox.Text, west)

        ' calculate total sales
        tota = north + south + east + west

        ' display total sales
        totalLabel.Text = total.ToString("C0")
    End Sub
End Class
