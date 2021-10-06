Module Notification
    Dim StatusActive As Boolean
    Function NotificationStatusECG(ValueStatus As Integer, NameStatus As String)
        If ValueStatus > 140 Then
            MonitoringDisplay.ButtonRed.Text = NameStatus
            MonitoringDisplay.ButtonYellow.Visible = False
            RedButton()

        ElseIf ValueStatus >= 120 Then
            MonitoringDisplay.ButtonYellow.Text = NameStatus
            MonitoringDisplay.ButtonRed.Visible = False
            YellowButton()

        ElseIf ValueStatus < 120 Then
            MonitoringDisplay.ButtonRed.Visible = False
            MonitoringDisplay.ButtonYellow.Visible = False
        End If
        'Send Alarm 
        AlarmHistory.DataGridView1.Rows.Add(NameStatus, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("HH : mm"))
        AlarmHistory.DataGridView1.FirstDisplayedScrollingRowIndex = AlarmHistory.DataGridView1.RowCount - 1
        Return ValueStatus

    End Function
    Sub BlueButton()
        If MonitoringDisplay.ButtonBlue.Visible = True Then
            MonitoringDisplay.ButtonBlue.Visible = False
            StatusActive = False
            AudioBlueAlarm()
        ElseIf MonitoringDisplay.ButtonBlue.Visible = False Then
            MonitoringDisplay.ButtonBlue.Visible = True
            StatusActive = True
        End If
        Application.DoEvents()
    End Sub
    Sub YellowButton()
        If MonitoringDisplay.ButtonYellow.Visible = True Then
            LedOffYellow()
            MonitoringDisplay.ButtonYellow.Visible = False
            StatusActive = False
            AudioYellowAlarm()
        ElseIf MonitoringDisplay.ButtonYellow.Visible = False Then
            LedOnYellow()
            MonitoringDisplay.ButtonYellow.Visible = True
            StatusActive = True
        End If
        Application.DoEvents()
    End Sub
    Sub RedButton()
        If MonitoringDisplay.ButtonRed.Visible = True Then
            LedOffRed()
            MonitoringDisplay.ButtonRed.Visible = False
            AudioRedAlarm()
            StatusActive = False
        ElseIf MonitoringDisplay.ButtonRed.Visible = False Then
            LedOnRed()
            MonitoringDisplay.ButtonRed.Visible = True
            StatusActive = True
        End If
        Application.DoEvents()
    End Sub
    Function NotifECG(value As Integer, name As String)
        Select Case value
            Case > 120
                MonitoringDisplay.ButtonYellow.Text = "ECG HIGH"
                AudioYellowAlarm()
            Case > 140
                MonitoringDisplay.ButtonRed.Text = "ECG HIGH"
                MonitoringDisplay.ecghr.ForeColor = Color.Red
                AudioRedAlarm()
        End Select
        Return {value, name}
    End Function
    Function NotifSPO2(value As Integer, name As String)
        Select Case value
            Case < 95
                MonitoringDisplay.ButtonYellow.Text = "SPO2 LOW"
            Case < 60
                MonitoringDisplay.ButtonRed.Text = "SPO2 LOW"
                MonitoringDisplay.muispo2.ForeColor = Color.Red
            Case Else
                MonitoringDisplay.muispo2.ForeColor = Color.DeepSkyBlue
        End Select
        Return {value, name}
    End Function
    Function NotifRR(value As Integer, name As String)
        Select Case value
            Case < 5
                MonitoringDisplay.ButtonRed.Text = "RR LOW"
                MonitoringDisplay.ecgrr.ForeColor = Color.Red
            Case > 40
                MonitoringDisplay.ButtonYellow.Text = "RR HIGH"
            Case Else
                MonitoringDisplay.ecgrr.ForeColor = Color.Lime
        End Select
        Return {value, name}
    End Function
End Module
