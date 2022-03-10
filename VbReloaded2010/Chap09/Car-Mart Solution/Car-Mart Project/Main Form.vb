' Project name:         Car-Mart Project
' Project purpose:      Displays the highest commission 
'                       amount and the number of salespeople
'                       who earned that amount
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub highestButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles highestButton.Click
        ' displays the highest commission amount and the 
        ' number of salespeople who earned that amount

        Dim commission() As Integer = {1000, 2000, 4500, 100,
                                       5000, 100, 6700, 5000,
                                       780, 890, 150, 5100,
                                       6700, 5100, 3000, 200}

        Dim highSub As Integer = commission.GetUpperBound(0)
        Dim highestComm As Integer = commission(0)
        Dim salespeople As Integer = 1

        For x As Integer = 1 To highSub
            If commission(x) = highestComm Then
                salespeople += 1
            Else
                If commission(x) > highestComm Then
                    highestComm = commission(x)
                    salespeople = 1
                End If
            End If
        Next x

        highestLabel.Text = highestComm.ToString("C0")
        salespeopleLabel.Text = salespeople.ToString("N0")
    End Sub
End Class
