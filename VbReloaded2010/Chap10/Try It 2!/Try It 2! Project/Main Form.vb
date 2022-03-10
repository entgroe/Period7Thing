' Project name:         Try It 2! Project
' Project purpose:      Examples of the Contains, IndexOf, and Substring methods
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub contains1Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles contains1Button.Click
        Dim cityState As String = "Nashville, TN"
        Dim isContained As Boolean
        isContained = cityState.Contains("TN")
        MessageBox.Show("The Contains method returns " & isContained.ToString, "Contains Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub contains2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles contains2Button.Click
        Dim cityState As String = "Nashville, TN"
        Dim isContained As Boolean
        isContained = cityState.Contains("Tn")
        MessageBox.Show("The Contains method returns " & isContained.ToString, "Contains Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub contains3Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles contains3Button.Click
        Dim address As String = "345 Main Ave."
        If address.ToUpper.Contains("MAIN AVE.") Then
            MessageBox.Show("The address contains MAIN AVE.", "Contains Example 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("The address does not contain MAIN AVE.", "Contains Example 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub indexOf4Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles indexOf4Button.Click
        Dim cityState As String = "Nashville, TN"
        Dim charIndex As Integer
        charIndex = cityState.IndexOf("TN")
        MessageBox.Show("The IndexOf method returns " & charIndex.ToString, "IndexOf Example 4", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub indexOf5Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles indexOf5Button.Click
        Dim cityState As String = "Nashville, TN"
        Dim charIndex As Integer
        charIndex = cityState.IndexOf("Tn")
        MessageBox.Show("The IndexOf method returns " & charIndex.ToString, "IndexOf Example 5", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub indexOf6Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles indexOf6Button.Click
        Dim address As String = "345 Main Ave."
        Dim charIndex As Integer
        charIndex = address.ToLower.IndexOf("main ave.", 5)
        MessageBox.Show("The IndexOf method returns " & charIndex.ToString, "IndexOf Example 6", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub substring1Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles substring1Button.Click
        Dim fullName As String = "Herman Gutierez"
        Dim first As String = fullName.Substring(0, 6)
        Dim last As String = fullName.Substring(7)
        MessageBox.Show("First name: " & first & ControlChars.NewLine & "Last name: " & last,
                        "Substring Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub substring2Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles substring2Button.Click
        Dim employeeNum As String = "38F45"
        Dim dept As String = employeeNum.Substring(2, 1)
        MessageBox.Show("Department: " & dept, "Substring Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
