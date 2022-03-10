' Project name:         Months Two-Dimensional Project
' Project purpose:      Display month names in a list box
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private months(,) As String = {{"Jan", "31"},
                                   {"Feb", "28"},
                                   {"Mar", "31"},
                                   {"Apr", "30"}}

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub forNextButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles forNextButton.Click
        ' displays the array contents, row by row

        Dim highRow As Integer = months.GetUpperBound(0)
        Dim highCol As Integer = months.GetUpperBound(1)

        monthsListBox.Items.Clear()

        For row As Integer = 0 To highRow
            For col As Integer = 0 To highCol
                monthsListBox.Items.Add(months(row, col))
            Next col
        Next row
    End Sub

    Private Sub doLoopButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles doLoopButton.Click
        ' displays the array contents, column by column

        Dim highRow As Integer = months.GetUpperBound(0)
        Dim highCol As Integer = months.GetUpperBound(1)
        Dim row As Integer
        Dim col As Integer

        monthsListBox.Items.Clear()

        Do While col <= highCol
            row = 0
            Do While row <= highRow
                monthsListBox.Items.Add(months(row, col))
                row += 1
            Loop
            col += 1
        Loop
    End Sub

    Private Sub forEachNextButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles forEachNextButton.Click
        ' displays the array contents

        monthsListBox.Items.Clear()

        For Each monthElement As String In months
            monthsListBox.Items.Add(monthElement)
        Next monthElement
    End Sub
End Class
