' Project name:         Try It 4! Project
' Project purpose:      Examples of the Like operator
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ex1button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex1button.Click
        Dim firstName As String
        firstName = InputBox("First name", "Example 1")
        If firstName.ToUpper Like "B?LL" Then
            MessageBox.Show("True", "Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("False", "Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ex2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex2Button.Click
        If stateTextBox.Text Like "K*" Then
            MessageBox.Show("True", "Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("False", "Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ex3Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex3Button.Click
        Dim id As String
        id = InputBox("Enter ID", "Example 3")
        Do While id Like "###*"
            id = InputBox("Enter ID", "Example 3")
        Loop
    End Sub

    Private Sub ex4Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex4Button.Click
        Dim firstName As String
        firstName = InputBox("First name", "Example 4")
        If firstName.ToUpper Like "T[OI]M" Then
            MessageBox.Show("True", "Example 4", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("False", "Example 4", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ex5Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex5Button.Click
        Dim letter As String
        letter = InputBox("Enter one letter", "Example 5")
        If letter Like "[a-z]" Then
            MessageBox.Show("True", "Example 5", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("False", "Example 5", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ex6Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex6Button.Click
        Dim userEntry As String
        Dim nonLetter As Integer

        userEntry = InputBox("Enter one or more characters", "Example 6")
        For index As Integer = 0 To userEntry.Length - 1
            If userEntry.Substring(index, 1) Like "[!a-zA-Z]" Then
                nonLetter += 1
            End If
        Next index
        MessageBox.Show("Number of non-letters: " & nonLetter.ToString, "Example 6", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ex7Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex7Button.Click
        Dim userEntry As String
  
        userEntry = InputBox("Enter one or more characters", "Example 7")
        If userEntry Like "*.*" Then
            MessageBox.Show("The entry contains a period.", "Example 7", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("The entry does not contain a period.", "Example 7", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ex8Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex8Button.Click
        Dim userEntry As String

        userEntry = InputBox("Enter one or more characters", "Example 8")
        If userEntry.ToUpper Like "[A-Z][A-Z]##" Then
            MessageBox.Show("True", "Example 8", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("False", "Example 8", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
