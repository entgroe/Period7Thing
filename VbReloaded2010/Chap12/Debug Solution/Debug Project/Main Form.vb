' Project name:         Debug Project
' Project purpose:      Displays the contents of a dataset
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FriendsDataSet.tblFriends' table. You can move, or remove it, as needed.
        Me.TblFriendsTableAdapter.Fill(Me.FriendsDataSet)

    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub previousButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles previousButton.Click
        ' move to the previous record

        TblFriendsBindingSource.MovePrevious()
    End Sub

    Private Sub nextButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nextButton.Click
        ' move to the next record

        TblFriendsBindingSource.MoveLast()
    End Sub
End Class
