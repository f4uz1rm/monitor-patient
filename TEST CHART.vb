Public Class TEST_CHART
    Private Sub TEST_CHART_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myGraphics As Graphics = PictureBox1.CreateGraphics
        For i As Integer = 0 To 1000
            myGraphics.DrawLine(Pens.Black, i, 100 + CInt(Math.Sin(i)), i + 1, 100 + CInt(Math.Cos(i + 1)))
        Next i
    End Sub
End Class