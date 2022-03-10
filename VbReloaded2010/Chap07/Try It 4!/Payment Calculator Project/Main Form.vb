' Project name:         Payment Calculator Project
' Project purpose:      Displays the monthly payments on a loan
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fills the termListBox with terms of 2, 3, 
        ' 4, and 5 years

        For term As Integer = 2 To 5
            termListBox.Items.Add(term.ToString)
        Next term

        ' select the 4-year term
        termListBox.SelectedItem = "4"
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates the monthly payments on a loan 
        ' using interest rates of 5% through 10% 

        Dim term As Integer
        Dim loan As Double
        Dim monthlyPayment As Double

        ' assign input to variables
        Double.TryParse(loanTextBox.Text, loan)
        term = Convert.ToInt32(termListBox.SelectedItem)

        ' clear contents of the paymentsLabel
        paymentsLabel.Text = String.Empty

        ' calculate and display monthly payments
        For rate As Double = 0.05 To 0.1 Step 0.01
            monthlyPayment =
                -Financial.Pmt(rate / 12, term * 12, loan)
            paymentsLabel.Text = paymentsLabel.Text &
                rate.ToString("P0") & ":  " &
                monthlyPayment.ToString("C2") &
                ControlChars.NewLine
        Next rate

        loanTextBox.Focus()
    End Sub

    Private Sub loanTextBox_Enter(ByVal sender As Object,
        ByVal e As System.EventArgs) Handles loanTextBox.Enter
        ' selects the existing text when the text box 
        ' receives the focus

        loanTextBox.SelectAll()
    End Sub

    Private Sub loanTextBox_TextChanged(ByVal sender As Object,
        ByVal e As System.EventArgs) Handles loanTextBox.TextChanged
        ' clears the paymentsLabel when
        ' the contents of the text box changes

        paymentsLabel.Text = String.Empty
    End Sub

    Private Sub termListBox_SelectedIndexChanged(
        ByVal sender As Object, ByVal e As System.EventArgs) Handles termListBox.SelectedIndexChanged
        ' clears the paymentsLabel when the term changes

        paymentsLabel.Text = String.Empty
    End Sub

    'Private Sub termListBox_SelectedValueChanged(
    '    ByVal sender As Object, ByVal e As System.EventArgs) Handles termListBox.SelectedValueChanged
    '    ' clears the paymentsLabel when the term changes

    '    paymentsLabel.Text = String.Empty
    'End Sub
End Class
