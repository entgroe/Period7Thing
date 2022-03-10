' Project name:         ImageList Example Project
' Project purpose:      Displays the images contained in the image list control
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub viewButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles viewButton.Click
        ' view images, one at a time

        Dim numImages As Integer = ImageList1.Images.Count

        For index As Integer = 0 To numImages - 1
            viewerPictureBox.Image =
                ImageList1.Images.Item(index)
            Me.Refresh()
            System.Threading.Thread.Sleep(500)
        Next index
    End Sub
End Class
