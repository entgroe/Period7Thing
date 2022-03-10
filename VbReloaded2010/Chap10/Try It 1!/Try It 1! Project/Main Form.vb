' Project name:         Try It 1! Project
' Project purpose:      Examples of the Length property,
'                       and the Trim, Remove, and Insert methods
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub length1Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles length1Button.Click
        Dim custName As String = "Kevin Jameswell"
        Dim numChars As Integer = custName.Length
        MessageBox.Show("Number of characters in Kevin Jameswell: " & numChars.ToString, "Length Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub length2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles length2Button.Click
        Dim numChars As Integer
        numChars = phoneTextBox.Text.Length
        MessageBox.Show("Number of characters in phoneTextBox: " & numChars.ToString, "Length Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub length3Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles length3Button.Click
        Dim zip As String
        Do
            zip = InputBox("5-digit ZIP code", "ZIP")
        Loop Until zip.Length = 5
        MessageBox.Show(zip, "Length Example 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub trim1Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles trim1Button.Click
        Dim city As String
        city = cityTextBox.Text.Trim
        cityTextBox.Text = city
    End Sub

    Private Sub remove2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles remove2Button.Click
        Dim fullName As String = "Cheryl Jones"
        lastTextBox.Text = fullName.Remove(0, 7)
    End Sub

    Private Sub remove3Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles remove3Button.Click
        Dim fullName As String = "Roberta Jones"
        firstTextBox.Text = fullName.Remove(7)
    End Sub

    Private Sub remove4Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles remove4Button.Click
        Dim firstName As String = "John"
        firstName = firstName.Remove(2, 1)
        firstTextBox.Text = firstName
    End Sub

    Private Sub insert1Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles insert1Button.Click
        Dim phone As String = "111-2222"
        phone = phone.Insert(0, "(877) ")
        MessageBox.Show(phone, "Insert Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub insert2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles insert2Button.Click
        Dim fullName As String = "Jose Munoz"
        fullName = fullName.Insert(5, "C. ")
        MessageBox.Show(fullName, "Insert Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
