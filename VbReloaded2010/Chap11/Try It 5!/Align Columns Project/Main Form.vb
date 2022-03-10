' Project name:         Align Columns Project
' Project purpose:      Examples of aligning columns of information
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ex1Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex1Button.Click
        ' right-aligns a list of numbers

        Dim formatPrice As String
        For price As Decimal = 9D To 11D Step 0.5D
            formatPrice = price.ToString("N2").PadLeft(8)
            priceListBox.Items.Add(formatPrice)
        Next price
    End Sub

    Private Sub ex2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex2Button.Click
        ' aligns the second column when the first column 
        ' contains strings with varying lengths

        Dim outFile As IO.StreamWriter
        Dim heading As String =
            "Name" & Strings.Space(11) & "City"
        Dim name As String
        Dim city As String

        outFile = IO.File.CreateText("example2.txt")
        outFile.WriteLine(heading)

        name = InputBox("Enter name:", "Name")
        Do While name <> String.Empty
            city = InputBox("Enter city:", "City")
            outFile.WriteLine(name.PadRight(15) & city)
            name = InputBox("Enter name:", "Name")
        Loop
        outFile.Close()
    End Sub
End Class
