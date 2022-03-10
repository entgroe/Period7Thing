' Project name:         Translator Project
' Project purpose:      Translate English words into French, Spanish, or Italian
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearLabel(ByVal sender As Object, ByVal e As System.EventArgs
                           ) Handles fatherRadioButton.Click,
                       frenchRadioButton.Click, italianRadioButton.Click,
                       sisterRadioButton.Click, motherRadioButton.Click,
                       brotherRadioButton.Click, spanishRadioButton.Click
        translatedLabel.Text = String.Empty
    End Sub

End Class
