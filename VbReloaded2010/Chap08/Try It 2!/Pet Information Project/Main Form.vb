' Project name:         Pet Information Project
' Project purpose:      Displays a message containing
'                       a pet's name and age
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub ShowMsg(ByVal pet As String, ByVal age As Integer)
        ' calculates age on next birthday, and
        ' displays name and next age in a message

        age = age + 1

        msgLabel.Text = "On his or her next birthday," &
            " your pet " & pet & " will be " &
            age & " years old."
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click
        ' gets the pet information, then calls 
        ' a procedure to display the information

        Dim inputName As String
        Dim inputAge As String
        Dim currentAge As Integer

        inputName = InputBox("Pet's name:", "Name")
        inputAge = InputBox("Pet's age (years):", "Age")
        Integer.TryParse(inputAge, currentAge)

        Call ShowMsg(inputName, currentAge)
    End Sub
End Class
