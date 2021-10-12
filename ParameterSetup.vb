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
        Tampil_ComboBox()
    End Sub

    Private Sub cb_td_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTDifference.SelectedIndexChanged
        If ComboBoxTDifference.SelectedItem = "Enable" Then
            MonitoringDisplay.Label28.Visible = True
            MonitoringDisplay.muitd.Visible = True
        ElseIf ComboBoxTDifference.SelectedItem = "Disable"
            MonitoringDisplay.Label28.Visible = False
            MonitoringDisplay.muitd.Visible = False
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Update_Parameter_Setup()
    End Sub

    Private Sub ComboBoxSetupT1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSetupT1.SelectedIndexChanged
        If ComboBoxSetupT1.SelectedItem = "Enable" Then
            MonitoringDisplay.Label27.Visible = True
            MonitoringDisplay.muitemp1.Visible = True
        ElseIf ComboBoxSetupT1.SelectedItem = "Disable"
            MonitoringDisplay.Label27.Visible = False
            MonitoringDisplay.muitemp1.Visible = False
        End If
    End Sub

    Private Sub ComboBoxSetupT2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSetupT2.SelectedIndexChanged
        If ComboBoxSetupT1.SelectedItem = "Enable" Then
            MonitoringDisplay.Label29.Visible = True
            MonitoringDisplay.muitemp2.Visible = True
        ElseIf ComboBoxSetupT1.SelectedItem = "Disable"
            MonitoringDisplay.Label29.Visible = False
            MonitoringDisplay.muitemp2.Visible = False
        End If
    End Sub
End Class