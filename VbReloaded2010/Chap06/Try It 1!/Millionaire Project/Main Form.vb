' Project name:         Millionaire Project
' Project purpose:      Displays the account balance and  
'                       the number of years required for a
'                       one-time deposit to reach one million
'                       dollars, assuming the interest is
'                       compounded annually and no withdrawals
'                       or additional deposits are made
' Created/revised by:	<your name> on <current date>

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

    Private Sub rateTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rateTextBox.KeyPress
        ' accepts only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' display account balance and number of years

        Dim balance As Double
        Dim rate As Double
        Dim interest As Double
        Dim years As Integer    ' counter initialization

        Double.TryParse(depositTextBox.Text, balance)
        Double.TryParse(rateTextBox.Text, rate)

        Do While balance < 1000000
            interest = balance * rate
            balance += interest
            years += 1  ' counter update
        Loop

        balanceLabel.Text = "You will have " &
            balance.ToString("C2") &
            " in " & years.ToString & " years."
    End Sub
End Class
