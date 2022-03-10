' Project name:         State Project
' Project purpose:      Displays state names in either
'                       ascending or descending order
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    ' class-level array
    Private stateNames(4) As String

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub enterButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles enterButton.Click
        ' allows the user to enter five state names
        ' stores the state names in the class-level
        ' stateNames array

        Dim highSub As Integer = stateNames.GetUpperBound(0)
        For subscript As Integer = 0 To highSub
            stateNames(subscript) =
                InputBox("State name", "State Names")
        Next subscript
    End Sub

    Private Sub sortAscendButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sortAscendButton.Click
        ' sorts the array values in ascending order, then
        ' displays them in the stateLabel

        Array.Sort(stateNames)

        stateLabel.Text = String.Empty
        For Each name As String In stateNames
            stateLabel.Text =
                stateLabel.Text & name & ControlChars.NewLine
        Next name
    End Sub

    Private Sub sortDescendButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sortDescendButton.Click
        ' sorts the array values in descending order, then
        ' displays them in the stateLabel

        Array.Sort(stateNames)
        Array.Reverse(stateNames)

        stateLabel.Text = String.Empty
        For Each name As String In stateNames
            stateLabel.Text =
                stateLabel.Text & name & ControlChars.NewLine
        Next name
    End Sub
End Class
