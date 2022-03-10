' Project name:         Contestant Project
' Project purpose:      Write names to and read names from a sequential access file
' Created/revised by:   <your name> on <current date>

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub nameTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nameTextBox.Enter
        nameTextBox.SelectAll()
    End Sub

    Private Sub writeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles writeButton.Click
        ' writes a name to a sequential access file

        ' declare a StreamWriter variable
        Dim outFile As IO.StreamWriter

        ' open the file for append
        outFile = IO.File.AppendText("contestants.txt")
        ' write the name on a separate line in the file
        outFile.WriteLine(nameTextBox.Text)
        ' close the file
        outFile.Close()

        ' clear the list box, then set the focus
        contestantsListBox.Items.Clear()
        nameTextBox.Focus()
    End Sub

    Private Sub readButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles readButton.Click
        ' reads names from a sequential access file 
        ' and displays them in the interface

        Dim inFile As IO.StreamReader
        Dim name As String

        ' clear previous names from the list box
        contestantsListBox.Items.Clear()

        ' determine whether the file exists
        If IO.File.Exists("contestants.txt") Then
            ' open the file for input
            inFile = IO.File.OpenText("contestants.txt")
            ' process loop instructions until end of file
            Do Until inFile.Peek = -1
                ' read a name
                name = inFile.ReadLine
                ' add name to list box
                contestantsListBox.Items.Add(name)
            Loop
            ' close the file
            inFile.Close()
        Else
            MessageBox.Show(
                "Can't find the contestants.txt file",
                "Game Show Contestants",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        End If
    End Sub
End Class
