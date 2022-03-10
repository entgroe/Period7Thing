' Project name:         Delivery Project
' Project purpose:      Selects the appropriate delivery method
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fills the list box with values

        deliveryListBox.Items.Add("Standard Mail")
        deliveryListBox.Items.Add("Priority Mail")
        deliveryListBox.Items.Add("FedEx Standard")
        deliveryListBox.Items.Add("FedEx Overnight")
        deliveryListBox.Items.Add("UPS")
    End Sub

    Private Sub idTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles idTextBox.Enter
        idTextBox.SelectAll()
    End Sub

    Private Sub idTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles idTextBox.TextChanged
        ' clears the list box selection

        deliveryListBox.SelectedIndex = -1
    End Sub

End Class
