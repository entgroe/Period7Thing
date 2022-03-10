' Project name:         Hunt Auditorium Project
' Project purpose:      Displays the ticket price
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private prices() As Integer = {150, 100, 95, 85}

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fill list box with values

        seatingListBox.Items.Add("Section A")
        seatingListBox.Items.Add("Section B")
        seatingListBox.Items.Add("Section C")
        seatingListBox.Items.Add("Section D")
        seatingListBox.SelectedIndex = 0
    End Sub

    Private Sub seatingListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seatingListBox.SelectedIndexChanged
        ' displays the price

        Dim subscript As Integer
        subscript = seatingListBox.SelectedIndex
        priceLabel.Text = prices(subscript).ToString("C0")
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
