' Project name:         Gadis Antiques Project
' Project purpose:      Display an employee's regular,
'                       overtime, and gross pay
' Created/revised by:   <your name> on <current date>

Option Strict On
Option Explicit On
Option Infer Off

Public Class MainForm

    Private Sub ClearLabels()
        regularLabel.Text = String.Empty
        overtimeLabel.Text = String.Empty
        grossLabel.Text = String.Empty
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fills the combo boxes with values

        For hours As Decimal = 0D To 50D Step 0.5D
            hoursComboBox.Items.Add(hours.ToString("N1"))
        Next hours
        hoursComboBox.SelectedItem = "40.0"

        For rates As Decimal = 7.75D To 12.5D Step 0.25D
            rateComboBox.Items.Add(rates.ToString("N2"))
        Next rates
        rateComboBox.SelectedItem = "10.00"
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' calculates the regular pay, overtime pay,
        ' and gross pay

        Const Message As String = _
            "Hours and rate cannot be less than 0."
        Dim hoursWorked As Double
        Dim payRate As Double
        Dim regularPay As Double
        Dim overtimePay As Double
        Dim grossPay As Double
        
        Double.TryParse(hoursComboBox.Text, hoursWorked)
        Double.TryParse(rateComboBox.Text, payRate)

        ' if both entries are valid, perform calculations
        ' and display the results; otherwise, display a message
        If hoursWorked >= 0 AndAlso payRate >= 0 Then
            If hoursWorked <= 40 Then
                ' calculate regular pay only
                regularPay = hoursWorked * payRate
            Else
                ' calculate regular and overtime pay
                regularPay = 40 * payRate
                overtimePay = (hoursWorked - 40) * payRate * 1.5
            End If

            ' calculate gross pay
            grossPay = regularPay + overtimePay

            ' display calculated results
            regularLabel.Text = regularPay.ToString("N2")
            overtimeLabel.Text = overtimePay.ToString("N2")
            grossLabel.Text = grossPay.ToString("N2")
        Else
            MessageBox.Show(Message, "Gadis Antiques",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub clearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clearButton.Click
        Call ClearLabels()
    End Sub

    Private Sub hoursComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hoursComboBox.TextChanged
        Call ClearLabels()
    End Sub

    Private Sub rateComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rateComboBox.TextChanged
        Call ClearLabels()
    End Sub
End Class
