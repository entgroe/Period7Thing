' Project name:         Carpet Calculator Project
' Project purpose:      Displays the number of square yards of 
'                       carpet and the cost of the carpet
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' fills the list boxes with data, then selects a default item

        For nums As Double = 4 To 30 Step 0.5
            lengthListBox.Items.Add(nums.ToString("N1"))
            widthListBox.Items.Add(nums.ToString("N1"))
        Next nums

        For prices As Double = 5 To 25 Step 0.5
            priceListBox.Items.Add(prices.ToString("N2"))
        Next prices

        lengthListBox.SelectedItem = "10.0"
        widthListBox.SelectedItem = "10.0"
        priceListBox.SelectedItem = "8.00"
    End Sub

    Private Sub ClearLabels(ByVal sender As Object, ByVal e As System.EventArgs
            ) Handles lengthListBox.SelectedValueChanged,
            widthListBox.SelectedValueChanged, priceListBox.SelectedValueChanged
        sqYdsLabel.Text = String.Empty
        costLabel.Text = String.Empty
    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click
        ' displays the number of square yards 
        ' and the cost of the carpet

        Dim floor As Rectangle
        Dim roomLength As Double
        Dim roomWidth As Double
        Dim priceSqYd As Double
        Dim sqYards As Double
        Dim cost As Double

        Double.TryParse(lengthListBox.SelectedItem.ToString, roomLength)
        Double.TryParse(widthListBox.SelectedItem.ToString, roomWidth)
        Double.TryParse(priceListBox.SelectedItem.ToString, priceSqYd)

        floor = New Rectangle(roomLength, roomWidth)

        ' calculate required square yards of carpet
        sqYards = floor.GetArea / 9
        ' calculate carpet cost
        cost = priceSqYd * sqYards

        ' display required square yards and carpet cost
        sqYdsLabel.Text = sqYards.ToString("N1")
        costLabel.Text = cost.ToString("C2")
    End Sub
End Class
