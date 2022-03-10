' Project name:         Hinsbrook School Project
' Project purpose:      Display the amount sold for
'                       each candy type
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fill the list box with values

        candyListBox.Items.Add("Chocolate Bar")
        candyListBox.Items.Add("Chocolate Bar-Peanuts")
        candyListBox.Items.Add("Kit Kat")
        candyListBox.Items.Add("Peanut Butter Cups")
        candyListBox.Items.Add("Take 5 Bar")
        candyListBox.SelectedIndex = 0
    End Sub

    Private Sub addButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles addButton.Click
        ' add amount sold to the appropriate total

        Static candies(4) As Integer
        Dim sold As Integer
        Dim subscript As Integer

        Integer.TryParse(soldTextBox.Text, sold)
        subscript = candyListBox.SelectedIndex

        ' update array value
        candies(subscript) += sold

        ' display array values
        cbLabel.Text = candies(0).ToString
        cbpLabel.Text = candies(1).ToString
        kkLabel.Text = candies(2).ToString
        pbcLabel.Text = candies(3).ToString
        t5bLabel.Text = candies(4).ToString

        soldTextBox.Focus()
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub soldTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles soldTextBox.Enter
        ' select existing text

        soldTextBox.SelectAll()
    End Sub

    Private Sub soldTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles soldTextBox.KeyPress
        ' allow numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(ByVal sender As Object, ByVal e As System.EventArgs) Handles soldTextBox.TextChanged, candyListBox.SelectedIndexChanged
        ' clear labels

        cbLabel.Text = String.Empty
        cbpLabel.Text = String.Empty
        kkLabel.Text = String.Empty
        pbcLabel.Text = String.Empty
        t5bLabel.Text = String.Empty
    End Sub

End Class
