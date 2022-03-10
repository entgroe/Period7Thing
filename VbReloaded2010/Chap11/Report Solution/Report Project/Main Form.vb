' Project name:         Report Project
' Project purpose:      Writes a report to a sequential access file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Structure StateInfo
        Public name As String
        Public sales As Integer
    End Structure

    Private stateSales(2) As StateInfo

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fill array with values

        stateSales(0).name = "California"
        stateSales(0).sales = 15000
        stateSales(1).name = "Montana"
        stateSales(1).sales = 10000
        stateSales(2).name = "Wyoming"
        stateSales(2).sales = 7000
    End Sub

End Class
