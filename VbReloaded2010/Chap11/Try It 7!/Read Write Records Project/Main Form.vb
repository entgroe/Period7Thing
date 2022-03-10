' Project name:         Read Write Records Project
' Project purpose:      Examples of reading and writing records
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ex1Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex1Button.Click

        cityLabel.Text = String.Empty
        stateLabel.Text = String.Empty

        ' writes the record
        Dim outFile As IO.StreamWriter
        outFile = IO.File.CreateText("example1.txt")
        Dim city As String = "Raleigh"
        Dim state As String = "North Carolina"
        outFile.WriteLine(city & "," & state)
        outFile.Close()
        MessageBox.Show("Record written", "Example 1",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        ' reads the record
        Dim inFile As IO.StreamReader
        inFile = IO.File.OpenText("example1.txt")
        Dim cityState() As String
        cityState = inFile.ReadLine.Split(","c)
        cityLabel.Text = cityState(0)
        stateLabel.Text = cityState(1)
        inFile.Close()
        MessageBox.Show("Record read", "Example 1",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information)
    End Sub

    Private Sub ex2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex2Button.Click
        salespersonLabel.Text = String.Empty
        salesLabel.Text = String.Empty
        bonusLabel.Text = String.Empty

        ' writes the record
        Dim outSalesFile As IO.StreamWriter
        outSalesFile = IO.File.CreateText("example2.txt")
        Dim salesperson As String = "Jason Kricky"
        Dim sales As Integer = 5000
        Dim bonus As Integer = 250
        outSalesFile.WriteLine(salesperson & "#" &
                sales.ToString & "#" & bonus.ToString)
        outSalesFile.Close()
        MessageBox.Show("Record written", "Example 2",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        ' reads the record
        Dim inFile As IO.StreamReader
        inFile = IO.File.OpenText("example2.txt")
        Dim salesInfo() As String
        salesInfo = inFile.ReadLine.Split("#"c)
        salespersonLabel.Text = salesInfo(0)
        salesLabel.Text = salesInfo(1)
        bonusLabel.Text = salesInfo(2)
        inFile.Close()
        MessageBox.Show("Record read", "Example 2",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information)
    End Sub
End Class
