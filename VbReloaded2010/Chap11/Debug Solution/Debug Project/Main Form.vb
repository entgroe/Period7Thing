' Project name:         Debug Project
' Project purpose:      Calculates the bonus and then saves the name and 
'                       bonus amount to a sequential access file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub nameTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nameTextBox.Enter
        nameTextBox.SelectAll()
    End Sub

    Private Sub nameTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nameTextBox.TextChanged
        bonusLabel.Text = String.Empty
    End Sub

    Private Sub salesTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles salesTextBox.Enter
        salesTextBox.SelectAll()
    End Sub

    Private Sub salesTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles salesTextBox.TextChanged
        bonusLabel.Text = String.Empty
    End Sub

    Private Sub calcAndSaveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcAndSaveButton.Click
        ' writes the name and a 5% bonus amount to a sequential access file

        Dim outFile As IO.StreamWriter
        Dim sales As Double
        Dim bonus As Double

        ' assign sales amount to a variable
        Double.TryParse(salesTextBox.Text, sales)
        ' calculate and display bonus
        bonus = sales * 0.05
        bonusLabel.Text = bonus.ToString("N2")

        ' save name and bonus to the file
        outFile = IO.File.AppendText("bonus.txt")
        outFile.WriteLine(nameTextBox.Text)
        outFile.WriteLine(bonusLabel.Text)

        ' set the focus
        nameTextBox.Focus()
    End Sub
End Class
