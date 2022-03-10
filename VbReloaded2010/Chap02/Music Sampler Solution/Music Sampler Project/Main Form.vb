Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub treysonButton_Click(sender As Object, e As EventArgs) Handles treysonButton.Click
        My.Computer.Audio.Play("treyson.wav")
    End Sub

    Private Sub feelingButton_Click(sender As Object, e As EventArgs) Handles feelingButton.Click
        My.Computer.Audio.Play(" FeelingGood.wav")
    End Sub

    Private Sub breakawayButton_Click(sender As Object, e As EventArgs) Handles breakawayButton.Click
        My.Computer.Audio.Play(" Breakaway.wav")
    End Sub

    Private Sub boomButton_Click(sender As Object, e As EventArgs) Handles boomButton.Click
        My.Computer.Audio.Play("BoomBoomPow.wav")
    End Sub

    Private Sub sydneyButton_Click(sender As Object, e As EventArgs) Handles sydneyButton.Click
        My.Computer.Audio.Play("sydney.wav")
    End Sub

    Private Sub thrillerButton_Click(sender As Object, e As EventArgs) Handles thrillerButton.Click
        My.Computer.Audio.Play(" Thriller.wav")
    End Sub

    Private Sub colorButton_Click(sender As Object, e As EventArgs) Handles colorButton.Click
        My.Computer.Audio.Play(" .wav")
    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click

    End Sub
End Class
