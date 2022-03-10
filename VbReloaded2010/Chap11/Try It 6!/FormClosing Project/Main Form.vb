' Project name:         FormClosing Project
' Project purpose:      FormClosing examples
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        namesListBox.SelectedIndex = 0
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ' Example 1
        Dim outFile As IO.StreamWriter
        outFile = IO.File.CreateText("example1.txt")
        For Each name As String In namesListBox.Items
            outFile.WriteLine(name)
        Next name
        outFile.Close()
        MessageBox.Show("The names were written to the file.",
                        "FormClosing Examples",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        ' Example 2
        Dim button As DialogResult
        button = MessageBox.Show("Do you want to exit?",
                                 "FormClosing Examples",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Exclamation,
                                 MessageBoxDefaultButton.Button2)

        If button = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
