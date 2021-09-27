Public Class ParameterSetup
    Private Sub ParameterSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub cb_t1_label_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_t1_label.SelectedIndexChanged
        If cb_t1_label.SelectedIndex = 0 Then
            MonitoringDisplay.Label27.Text = "C"
        ElseIf cb_t1_label.SelectedIndex = 1
            MonitoringDisplay.Label27.Text = "F"
        End If
    End Sub

    Private Sub cb_t2_label_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_t2_label.SelectedIndexChanged
        If cb_t2_label.SelectedIndex = 0 Then
            MonitoringDisplay.Label29.Text = "C"
        ElseIf cb_t2_label.SelectedIndex = 1
            MonitoringDisplay.Label29.Text = "F"
        End If
    End Sub

    Private Sub cb_td_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_td.SelectedIndexChanged
        If cb_td.SelectedIndex = 0 Then
            MonitoringDisplay.Label28.Text = "C"
        ElseIf cb_td.SelectedIndex = 1
            MonitoringDisplay.Label28.Text = "F"
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class