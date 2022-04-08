﻿Public Class ySpeedTrackbar
    Private m_Previous As System.Nullable(Of Point) = Nothing
    Dim m_shapes As New Collection
    Dim c As Color
    Dim w As Integer
    Dim type As String


    Private Sub pictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        m_Previous = e.Location
        pictureBox1_MouseMove(sender, e)
    End Sub

    Private Sub pictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If m_Previous IsNot Nothing Then
            Dim d As Object

            ' d = New Line(PictureBox1.Image, m_Previous, e.Location)
            ' d.Pen = New Pen(c, w)
            'd.xspeed = xSpeedTrackBar.Value
            ' d.yspeed = ySpeedTrackbar.Value
            If type = "Line" Then
                d = New Line(PictureBox1.Image, m_Previous, e.Location)
                d.Pen = New Pen(c, w)
                d.xspeed = xSpeedTrackBar.Value
                'd.yspeed = ySpeedTrackbar.value
            End If


            If type = "Rectangle" Then
                d = New Rect(PictureBox1.Image, m_Previous, e.Location)
                d.fill = CheckBox2.Checked
                d.color1 = Button2.BackColor
                d.color2 = Button3.BackColor

                d.Pen = New Pen(c, w)
                d.w = TrackBar1.Value
                d.w = TrackBar2.Value

            End If


            If type = "polygon" Then
                d = New polygon(PictureBox1.Image, m_Previous, e.Location)
                d.Pen = New Pen(c, w)
                d.w = TrackBar1.Value
                d.w = TrackBar2.Value
            End If


            If type = "ngon" Then
                d = New ngon(PictureBox1.Image, m_Previous, e.Location)
                d.Pen = New Pen(c, w)
                d.radius = TrackBar5.Value
                d.sides = TrackBar4.Value
            End If


            If type = "picture" Then
                d = New PBox(PictureBox1.Image, m_Previous, e.Location)
                d.picture = PictureBox2.Image
                d.w = TrackBar6.Value
                d.h = TrackBar6.Value
            End If


            m_shapes.Add(d)
            PictureBox1.Invalidate()
            m_Previous = e.Location
        End If


    End Sub

    Private Sub pictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        m_Previous = Nothing
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If PictureBox1.Image Is Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
            End Using
            PictureBox1.Image = bmp
        End If

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        For Each s As Object In m_shapes
            s.Draw()
        Next
        If (CheckBox1.Checked) Then
            Refresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        c = ColorDialog1.Color
        Button1.BackColor = c

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        c = ColorDialog1.Color
        c = sender.backcolor



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c = sender.backcolor
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        w = TrackBar1.Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        type = "Line"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        type = "rectangle"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        type = "polygon"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        type = "ngon"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        type = "Picture"
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox2.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        type = "picture"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class