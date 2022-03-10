' Project name:         Sales Express Project
' Project purpose:      Displays the average sales amount
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub averageButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles averageButton.Click
        ' calculates and displays the average sales amount

        Const Prompt As String = "Enter a sales amount. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const Title As String = "Sales Entry"
        Dim inputSales As String
        Dim sales As Double
        Dim salesCounter As Integer
        Dim salesAccumulator As Double
        Dim salesAverage As Double

        ' remove contents of text box
        salesTextBox.Text = ""

        ' get first sales amount
        inputSales = InputBox(Prompt, Title)

        ' repeat as long as the user enters a sales amount
        Do While inputSales <> String.Empty
            ' convert the sales amount to a number
            Double.TryParse(inputSales, sales)

            ' update the counter and accumulator
            salesCounter = salesCounter + 1
            salesAccumulator = salesAccumulator + sales

            ' display the sales amount in the text box
            salesTextBox.Text = salesTextBox.Text &
                sales.ToString("N2") & ControlChars.NewLine

            ' get the next sales amount
            inputSales = InputBox(Prompt, Title)
        Loop

        ' verify that the salesCounter is greater than 0
        If salesCounter > 0 Then
            salesAverage = salesAccumulator / salesCounter
            averageLabel.Text = salesAverage.ToString("C2")
        Else
            averageLabel.Text = "N/A"
        End If
    End Sub

End Class
