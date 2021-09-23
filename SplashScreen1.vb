Public Class SplashScreen1
    Dim bootingtime As Integer = 7
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        bootingtime = bootingtime + 1
        If bootingtime = 3 Then
            Label1.Visible = True
            Label2.Visible = True
        ElseIf bootingtime = 4 Then
            Label1.Text = "Loading 20%"
        ElseIf bootingtime = 5 Then
            Label1.Text = "Loading 43%"
        ElseIf bootingtime = 6 Then
            Label1.Text = "Loading 74%"
        ElseIf bootingtime = 7 Then
            Label1.Text = "Loading 100%"
            Label2.Visible = False
        ElseIf bootingtime = 8 Then
            Timer1.Dispose()
            Me.Hide()
            MonitoringDisplay.Show()
        End If
    End Sub

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.FormBorderStyle = FormBorderStyle.None
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)
        Timer1.Enabled = True
    End Sub
End Class
