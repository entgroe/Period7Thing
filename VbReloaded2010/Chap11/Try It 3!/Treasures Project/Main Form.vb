' Project name:         Price List Project
' Project purpose:      Displays a product ID's price
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Structure Item
        Public id As String
        Public price As Integer
    End Structure

    ' declare an array of structure variables
    Private gifts(4) As Item

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' assign IDs and prices to the array
        gifts(0).id = "BX35"
        gifts(0).price = 13
        gifts(1).id = "CR20"
        gifts(1).price = 10
        gifts(2).id = "FE15"
        gifts(2).price = 12
        gifts(3).id = "KW10"
        gifts(3).price = 24
        gifts(4).id = "MM67"
        gifts(4).price = 4

        ' assign IDs to the list box
        For index As Integer = 0 To 4
            idListBox.Items.Add(gifts(index).id)
        Next index
        idListBox.SelectedIndex = 0
    End Sub

    Private Sub idListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles idListBox.SelectedIndexChanged
        ' displays the price associated with the
        ' ID selected by the user

        Dim index As Integer

        index = idListBox.SelectedIndex
        priceLabel.Text =
            gifts(index).price.ToString("C0")
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
