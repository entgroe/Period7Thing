' Project name:         Gentry Supplies Project
' Project purpose:      Displays a shipping charge based
'                       on the state and delivery method
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click
        ' displays the appropriate shipping charge

        Dim shipCharge As Integer

        ' determine state shipping charge
        ' <enter the multiple-alternative selection structure from Figure 5-15 here>


        ' add $10 for overnight delivery
        ' <enter the single-alternative selection structure from Figure 5-15 here>


        ' display shipping charge
        shipLabel.Text = shipCharge.ToString("C2")
    End Sub
End Class
