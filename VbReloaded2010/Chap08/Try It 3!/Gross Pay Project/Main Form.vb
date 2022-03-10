' Project name:         Gross Pay Project
' Project purpose:      Displays the gross pay
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub CalcGrossPay(ByVal hours As Double,
                             ByVal rate As Double,
                             ByRef gross As Double)
        ' calculates the gross pay

        gross = hours * rate
        ' add overtime, if necessary
        If hours > 40 Then
            gross = gross + (hours - 40) * rate / 2
        End If
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' displays gross pay

        Dim hoursWkd As Double
        Dim rateOfPay As Double
        Dim grossPay As Double

        hoursWkd =
            Convert.ToDouble(hoursListBox.SelectedItem)
        rateOfPay =
            Convert.ToDouble(rateListBox.SelectedItem)

        ' use a Sub procedure to calculate the gross pay
        Call CalcGrossPay(hoursWkd, rateOfPay, grossPay)

        grossLabel.Text = grossPay.ToString("C2")
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fills list boxes with values, then 
        ' selects a default item

        For hours As Double = 0.5 To 50 Step 0.5
            hoursListBox.Items.Add(hours.ToString("N1"))
        Next hours

        For rates As Double = 7.25 To 10.5 Step 0.25
            rateListBox.Items.Add(rates.ToString("N2"))
        Next rates

        hoursListBox.SelectedItem = "40.0"
        rateListBox.SelectedIndex = 0
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub hoursListBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hoursListBox.SelectedValueChanged
        grossLabel.Text = String.Empty
    End Sub

    Private Sub rateListBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rateListBox.SelectedValueChanged
        grossLabel.Text = String.Empty
    End Sub
End Class
