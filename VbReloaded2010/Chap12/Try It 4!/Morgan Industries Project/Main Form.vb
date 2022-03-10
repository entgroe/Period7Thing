' Project name:         Morgan Industries Project
' Project purpose:      Displays specific records from a dataset
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeesDataSet.tblEmploy' table. You can move, or remove it, as needed.
        Me.TblEmployTableAdapter.Fill(Me.EmployeesDataSet.tblEmploy)

    End Sub

    Private Sub findButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles findButton.Click
        ' selects records whose last name begins with the user's entry

        Const Prompt As String = "One or more letters " &
            "(leave empty to retrieve all records):"

        Dim findName As String =
            InputBox(Prompt, "Find Last Name").ToUpper

        Dim records = From employee In EmployeesDataSet.tblEmploy
                          Where employee.Last_Name.ToUpper Like findName & "*"
                          Select employee

        TblEmployBindingSource.DataSource = records.AsDataView
    End Sub

End Class
