' Project name:         Count Project
' Project purpose:      Displays the number of times the numbers 1 through 9
'                       appear in a two-dimensional array
' Created/revised by:   <your name> on <current date>

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click
        ' displays the number of times a value appears in a two-dimensional array

        Dim numbers(,) As Integer = {{1, 8},
                                    {4, 5},
                                    {7, 9},
                                    {3, 1},
                                    {9, 3},
                                    {5, 9},
                                    {8, 8},
                                    {9, 9},
                                    {7, 3},
                                    {2, 1},
                                    {5, 4}}


    End Sub

End Class
