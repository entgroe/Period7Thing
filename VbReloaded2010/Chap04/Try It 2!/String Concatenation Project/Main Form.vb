Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub concatenateButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles concatenateButton.Click
        Dim firstName As String
        Dim lastName As String
        Dim salary As Integer

        firstName = firstTextBox.Text
        lastName = lastTextBox.Text
        Integer.TryParse(salaryTextBox.Text, salary)

        concatenatedString.Text = firstName & lastName
        'concatenatedString.Text = firstName & " " & lastName
        'concatenatedString.Text = lastName & ", " & firstName
        'concatenatedString.Text = firstName & " earns " & salary.ToString("C0")
    End Sub
End Class
