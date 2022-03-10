Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub blueButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles blueButton.Click
        blueButton.BackColor = Color.LightBlue
        blueButton.Text = "Azul"
        My.Computer.Audio.Play("blue.wav")

    End Sub

    Private Sub brownButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles brownButton.Click
        brownButton.BackColor = Color.Brown
        brownButton.Text = "Marron"
        My.Computer.Audio.Play("brown.wav")

    End Sub

    Private Sub grayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grayButton.Click
        grayButton.BackColor = Color.Gray
        grayButton.Text = "Gris"
        My.Computer.Audio.Play("gray.wav")

    End Sub

    Private Sub greenButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles greenButton.Click
        greenButton.BackColor = Color.Green
        greenButton.Text = "Verde"
        My.Computer.Audio.Play("green.wav")

    End Sub

    Private Sub orangeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles orangeButton.Click
        orangeButton.BackColor = Color.Orange
        orangeButton.Text = "Anaranjado"
        My.Computer.Audio.Play("orange.wav")

    End Sub

    Private Sub pinkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pinkButton.Click
        pinkButton.BackColor = Color.Pink
        pinkButton.Text = "Rosa"
        My.Computer.Audio.Play("pink.wav")

    End Sub

    Private Sub purpleButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles purpleButton.Click
        purpleButton.BackColor = Color.MediumPurple
        purpleButton.Text = "Morado"
        My.Computer.Audio.Play("purple.wav")

    End Sub

    Private Sub redButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles redButton.Click
        redButton.BackColor = Color.Red
        redButton.Text = "Rojo"
        My.Computer.Audio.Play("red.wav")

    End Sub

    Private Sub yellowButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles yellowButton.Click
        yellowButton.BackColor = Color.Yellow
        yellowButton.Text = "Amarillo"
        My.Computer.Audio.Play("yellow.wav")

    End Sub

    Private Sub startOverButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles startOverButton.Click
        blueButton.BackColor = Color.White
        brownButton.BackColor = Color.White
        grayButton.BackColor = Color.White
        greenButton.BackColor = Color.White
        orangeButton.BackColor = Color.White
        pinkButton.BackColor = Color.White
        purpleButton.BackColor = Color.White
        redButton.BackColor = Color.White
        yellowButton.BackColor = Color.White

    End Sub

    Private Sub printButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles printButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub fontButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fontButton.Click
        fontDialog.Font = Me.Font
        fontDialog.ShowDialog()
        Me.Font = fontDialog.Font

    End Sub
End Class
