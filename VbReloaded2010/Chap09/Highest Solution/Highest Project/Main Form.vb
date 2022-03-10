' Project name:         Highest Project
' Project purpose:      Displays the highest score earned on the
'                       midterm exam and the highest score earned on 
'                       the final exam
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click
        ' displays the highest score earned on the midterm 
        ' and the highest score earned on the final

        ' declare array and fill with data
        ' midterm scores are in the first column
        ' final scores are in the second column
        Dim scores(,) As Integer = {{89, 98},
                                    {78, 45},
                                    {67, 89},
                                    {90, 99},
                                    {91, 70},
                                    {75, 76}}

    End Sub
End Class
