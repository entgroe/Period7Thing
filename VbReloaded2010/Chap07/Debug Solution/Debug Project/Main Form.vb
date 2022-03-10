' Project name:         Debug Project
' Project purpose:      Displays a bonus amount
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub salesTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles salesTextBox.Enter
        ' select the existing text

        salesTextBox.SelectAll()
    End Sub

    Private Sub salesTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles salesTextBox.KeyPress
        ' allow numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub salesTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles salesTextBox.TextChanged
        bonusLabel.Text = String.Empty
    End Sub

    Private Sub ratesListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ratesListBox.SelectedIndexChanged
        bonusLabel.Text = String.Empty
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' display rates from .03 through .06
        ' in increments of .01 in the list box

        For rates As Double = 0.03 To 0.06 Step 0.01
            ratesListBox.Items.Add(rates.ToString)
        Next rates
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' displays the bonus

        Dim sales As Double
        Dim rate As Double
        Dim bonus As Double

        Double.TryParse(salesTextBox.Text, sales)
        rate = Convert.ToDouble(ratesListBox.SelectedItem)

        bonus = sales * rate
        bonusLabel.Text = bonus.ToString("C2")
    End Sub
End Class
