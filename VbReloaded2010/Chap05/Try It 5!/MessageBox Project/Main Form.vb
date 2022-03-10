Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ex1Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex1Button.Click

        Dim button As DialogResult
        msgLabel.Text = ""

        button = MessageBox.Show("Delete this record?", "Payroll",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button2)
  
        If button = DialogResult.Yes Then
            msgLabel.Text = "Record deleted"
        End If
    End Sub

    Private Sub ex2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ex2Button.Click

        If MessageBox.Show("Play another game?", "Math Monster",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            msgLabel.Text = "New game"
        Else
            msgLabel.Text = "Game closed"
        End If
    End Sub
End Class
