' Project name:         Voter Project
' Project purpose:      Displays a message that indicates
'                       whether a person can vote
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click
        ' displays a message based on a person's
        ' age and registration status

        Const VoteMsg As String = "You can vote."
        Const RegisterMsg As String =
            "You must register before you can vote."
        Const TooYoungMsg As String = "You are too young to vote."
        Dim age As Integer

        ' store age in a variable
        Integer.TryParse(ageTextBox.Text, age)

        ' display appropriate message
        If age >= 18 Then
            If registeredCheckBox.Checked = True Then
                messageLabel.Text = VoteMsg
            Else
                messageLabel.Text = RegisterMsg
            End If
        Else
            messageLabel.Text = TooYoungMsg
        End If
    End Sub

    Private Sub ageTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ageTextBox.KeyPress
        ' allows the text box to accept only numbers 
        ' and the Backspace key

        ' <enter the code from Figure 5-20 here>

    End Sub
End Class
