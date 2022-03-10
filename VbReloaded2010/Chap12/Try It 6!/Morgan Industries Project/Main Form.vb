' Project name:         Morgan Industries Project
' Project purpose:      Displays the records stored in a dataset
'                       Also displays the average pay rate for 
'                       all employees, part-time employees, and
'                       fullo-time employees
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class MainForm

    Private Sub TblEmployBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblEmployBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TblEmployBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.EmployeesDataSet)
            MessageBox.Show("Changes saved", "Morgan Industries",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Morgan Industries",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeesDataSet.tblEmploy' table. You can move, or remove it, as needed.
        Me.TblEmployTableAdapter.Fill(Me.EmployeesDataSet.tblEmploy)

    End Sub

    Private Sub avgAllItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles avgAllItem.Click
        ' displays the average pay rate for all employees

        Dim avgRate As Double =
            Aggregate employee In EmployeesDataSet.tblEmploy
            Select employee.Rate Into Average()

        MessageBox.Show("Average pay rate for all employees: " &
                        avgRate.ToString("C2"), "Morgan Industries",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub avgParttimeItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles avgParttimeItem.Click
        ' displays the average pay rate for part-time employees

        Dim avgRate As Double =
            Aggregate employee In EmployeesDataSet.tblEmploy
            Where employee.Status.ToUpper = "P"
            Select employee.Rate Into Average()

        MessageBox.Show("Average pay rate for part-time employees: " &
                        avgRate.ToString("C2"), "Morgan Industries",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub avgFulltimeItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles avgFulltimeItem.Click
        ' displays the average pay rate for full-time employees

        Dim avgRate As Double =
            Aggregate employee In EmployeesDataSet.tblEmploy
            Where employee.Status.ToUpper = "F"
            Select employee.Rate Into Average()

        MessageBox.Show("Average pay rate for full-time employees: " &
                        avgRate.ToString("C2"), "Morgan Industries",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class
