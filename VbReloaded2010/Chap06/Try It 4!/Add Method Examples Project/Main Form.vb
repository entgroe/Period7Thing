' Project name:         Add Method Examples Project
' Project purpose:      Add method examples for list boxes
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object,
        ByVal e As System.EventArgs) Handles Me.Load

        ' add items to the animalListBox
        animalListBox.Items.Add("Dog")
        animalListBox.Items.Add("Cat")
        animalListBox.Items.Add("Horse")

        ' add items to the codeListBox
        Dim code As Integer = 100
        Do While code <= 105
            codeListBox.Items.Add(code.ToString)
            code += 1
        Loop
    End Sub

End Class
