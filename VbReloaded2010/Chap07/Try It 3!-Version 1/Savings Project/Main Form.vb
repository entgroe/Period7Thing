' Project name:         Savings Project
' Project purpose:      Displays the account balance at the
'                       end of 3 years using rates of 3%, 4%, 
'                       and 5%, assuming the interest 
'                       is compounded annually and no withdrawals
'                       or additional deposits are made
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub depositTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles depositTextBox.KeyPress
        ' accepts only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' display account balance at the end of 3 years
        ' using annual interest rates of 3%, 4%, and 5%

        ' Version 1
        Dim balance As Double
        Dim interest As Double
        Dim deposit As Double

        balanceLabel.Text = String.Empty
        Double.TryParse(depositTextBox.Text, deposit)

        For rates As Double = 0.03 To 0.05 Step 0.01
            balance = deposit
            For years As Integer = 1 To 3
                interest = balance * rates
                balance += interest
            Next years
            balanceLabel.Text = balanceLabel.Text &
                rates.ToString("P0") & ":   " &
                balance.ToString("C2") &
                ControlChars.NewLine
        Next rates
    End Sub
End Class
