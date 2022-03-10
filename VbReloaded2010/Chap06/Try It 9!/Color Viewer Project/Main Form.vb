' Project name:         Color Viewer Project
' Project purpose:      Change the background color of a label
'                       from blue to yellow and then to red
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub viewButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles viewButton.Click
        ' changes the background color of the colorLabel

        ' disable the button
        viewButton.Enabled = False

        ' change the colors
        colorLabel.BackColor = Color.Blue
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)

        colorLabel.BackColor = Color.Yellow
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)

        colorLabel.BackColor = Color.Red

        ' enable the button
        viewButton.Enabled = True
    End Sub
End Class
