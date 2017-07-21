Public Class Form1

    Dim draww As Boolean
    Dim mybrush As New SolidBrush(Color.Black)
    Dim thick As Integer = 20

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = MousePosition.X
        Label2.Text = MousePosition.Y

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        draw.FillEllipse(Brushes.Snow, 100, 200, 230, 230)
        draw.FillEllipse(Brushes.Snow, 95, 370, 275, 275)
        draw.FillEllipse(Brushes.Snow, 156, 90, 125, 125)
        draw.FillRectangle(Brushes.Black, 175, 20, 80, 80)
        draw.FillEllipse(Brushes.Black, 190, 300, 20, 20)
        draw.FillEllipse(Brushes.Black, 190, 350, 20, 20)
        draw.FillEllipse(Brushes.Black, 190, 250, 20, 20)
        draw.FillEllipse(Brushes.Black, 191, 138, 20, 20)
        draw.FillEllipse(Brushes.Black, 250, 138, 20, 20)
        draw.FillEllipse(Brushes.Orange, 229, 150, 20, 20)
        draw.FillRectangle(Brushes.Black, 161, 100, 110, 20)


    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        If draww = True Then
            draw.FillEllipse(mybrush, MousePosition.X - 10, MousePosition.Y - 30, thick, thick)

        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        draww = True
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        draww = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mybrush.Color = (Color.Aquamarine)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mybrush.Color = (Color.Black)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        mybrush.Color = (Color.AliceBlue)
    End Sub

    Private Sub Red_Click(sender As Object, e As EventArgs) Handles Red.Click
        mybrush.Color = (Color.Red)
    End Sub

    Private Sub Orange_Click(sender As Object, e As EventArgs) Handles Orange.Click
        mybrush.Color = (Color.Orange)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        mybrush.Color = (Color.Yellow)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        mybrush.Color = (Color.ForestGreen)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        mybrush.Color = (Color.Blue)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        mybrush.Color = (Color.BlueViolet)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mybrush.Color = (Color.DeepPink)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        mybrush.Color = (Color.LightCyan)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        mybrush.Color = (Color.Lavender)
    End Sub



    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        mybrush.Color = (Color.Tan)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mybrush.Color = (Color.Teal)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        draw.FillRectangle(Brushes.White, 0, 0, 1599, 899)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        mybrush.Color = (Color.White)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        mybrush.Color = (Color.SaddleBrown)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        thick = thick + 25
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        thick = thick - 25
        If thick < 0 Then
            thick = 5
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        thick = thick + 100
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            thick = TextBox1.Text
        Catch ex As Exception

        End Try

    End Sub


    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Insert Text Size" Then
            TextBox1.Text = ""
        End If
    End Sub
End Class