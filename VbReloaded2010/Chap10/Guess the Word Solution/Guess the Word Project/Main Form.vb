' Project name:         Guess the Word Project
' Project purpose:      Simulates the Guess the 
'                       Word game 
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm


    Private Sub EnableDisableButtons(ByVal setting As Boolean)
        ' enable or disable letter buttons

        aButton.Enabled = setting
        bButton.Enabled = setting
        cButton.Enabled = setting
        dButton.Enabled = setting
        eButton.Enabled = setting
        fButton.Enabled = setting
        gButton.Enabled = setting
        hButton.Enabled = setting
        iButton.Enabled = setting
        jButton.Enabled = setting
        kButton.Enabled = setting
        lButton.Enabled = setting
        mButton.Enabled = setting
        nButton.Enabled = setting
        oButton.Enabled = setting
        pButton.Enabled = setting
        qButton.Enabled = setting
        rButton.Enabled = setting
        sButton.Enabled = setting
        tButton.Enabled = setting
        uButton.Enabled = setting
        vButton.Enabled = setting
        wButton.Enabled = setting
        xButton.Enabled = setting
        yButton.Enabled = setting
        zButton.Enabled = setting
    End Sub

    Private Sub CheckStatus(ByVal dashStatus As Boolean)
 
    End Sub

    Private Sub LetterButtons(ByVal sender As Object, ByVal e As System.EventArgs) Handles aButton.Click,
        bButton.Click, cButton.Click, dButton.Click, eButton.Click, jButton.Click, iButton.Click, hButton.Click,
        gButton.Click, fButton.Click, oButton.Click, nButton.Click, mButton.Click, lButton.Click, kButton.Click,
        tButton.Click, sButton.Click, rButton.Click, qButton.Click, pButton.Click, yButton.Click, xButton.Click,
        wButton.Click, vButton.Click, uButton.Click, zButton.Click
 
    End Sub

End Class
