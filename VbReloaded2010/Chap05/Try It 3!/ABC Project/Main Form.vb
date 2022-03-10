' Project name:         ABC Project
' Project purpose:      Displays the price per item, which is
'                       based on the number of items ordered
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayPriceButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayPriceButton.Click
        ' displays the price per item

        Dim ordered As Integer
        Dim price As Integer

        ' assign user input to a variable
        Integer.TryParse(numberTextBox.Text, ordered)

        ' determine the price per item 
        ' <enter the code from Figure 5-13 here>


        ' display the price per item, then set the focus
        priceLabel.Text = price.ToString("C2")
        numberTextBox.Focus()
    End Sub
End Class
