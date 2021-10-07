Module Notification
    Dim StatusActive As Boolean
    Function NotificationStatusECG(ValueStatus As Integer, NameStatus As String)
        If ValueStatus > 140 Then
            MonitoringDisplay.ButtonRed.Text = NameStatus
            MonitoringDisplay.ButtonYellow.Visible = False
            RedButton()
        ElseIf ValueStatus > 120
            MonitoringDisplay.ButtonYellow.Text = NameStatus
            MonitoringDisplay.ButtonRed.Visible = False
            YellowButton()
        ElseIf ValueStatus < 120
            MonitoringDisplay.ButtonRed.Visible = False
            MonitoringDisplay.ButtonYellow.Visible = False
            StopBackgroundSound()
        End If
        'Send Alarm 
        AlarmHistory.DataGridView1.Rows.Add(NameStatus, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("HH : mm"))
        AlarmHistory.DataGridView1.FirstDisplayedScrollingRowIndex = AlarmHistory.DataGridView1.RowCount - 1
        Return ValueStatus
    End Function
    Function NotificationStatusSPO2(ValueStatus As Integer, NameStatus As String)
        If ValueStatus < 60 Then
            MonitoringDisplay.ButtonRed.Text = NameStatus
            MonitoringDisplay.ButtonYellow.Visible = False
            RedButton()
        ElseIf ValueStatus < 95
            MonitoringDisplay.ButtonYellow.Text = NameStatus
            MonitoringDisplay.ButtonRed.Visible = False
            YellowButton()
        ElseIf ValueStatus > 95
            MonitoringDisplay.ButtonRed.Visible = False
            MonitoringDisplay.ButtonYellow.Visible = False
            If MonitoringDisplay.LabelStatusSpo2.Text = "Module working properly" Then
                AudioHBAlarm()
            End If
        End If
        'Send Alarm 
        AlarmHistory.DataGridView1.Rows.Add(NameStatus, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("HH : mm"))
        AlarmHistory.DataGridView1.FirstDisplayedScrollingRowIndex = AlarmHistory.DataGridView1.RowCount - 1
        Return ValueStatus

    End Function
    Function NotificationStatusRR(ValueStatus As Integer)
        Dim StatusName As String
        If ValueStatus > 40 Then
            StatusName = "RR HIGH"
            MonitoringDisplay.ButtonRed.Text = StatusName
            MonitoringDisplay.ButtonYellow.Visible = False
            RedButton()
        ElseIf ValueStatus < 5
            StatusName = "RR LOW"
            MonitoringDisplay.ButtonYellow.Text = StatusName
            MonitoringDisplay.ButtonRed.Visible = False
            YellowButton()
        Else
            MonitoringDisplay.ButtonRed.Visible = False
            MonitoringDisplay.ButtonYellow.Visible = False
        End If
        'Send Alarm 
        AlarmHistory.DataGridView1.Rows.Add(StatusName, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("HH : mm"))
        AlarmHistory.DataGridView1.FirstDisplayedScrollingRowIndex = AlarmHistory.DataGridView1.RowCount - 1
        Return ValueStatus

    End Function

    Sub BlueButton()
        If MonitoringDisplay.ButtonBlue.Visible = True Then
            MonitoringDisplay.ButtonBlue.Visible = False
            StatusActive = False
        ElseIf MonitoringDisplay.ButtonBlue.Visible = False
            MonitoringDisplay.ButtonBlue.Visible = True
            StatusActive = True
            AudioBlueAlarm()
        End If
        Application.DoEvents()
    End Sub
    Sub YellowButton()
        If MonitoringDisplay.ButtonYellow.Visible = True Then
            LedOffYellow()
            StatusActive = False
            MonitoringDisplay.ButtonYellow.Visible = False
            StopBackgroundSound()
        ElseIf MonitoringDisplay.ButtonYellow.Visible = False
            LedOnYellow()
            StatusActive = True
            MonitoringDisplay.ButtonYellow.Visible = True

            AudioYellowAlarm()
        End If
        Application.DoEvents()
    End Sub
    Sub RedButton()
        If MonitoringDisplay.ButtonRed.Visible = True Then
            LedOffRed()
            StatusActive = False
            MonitoringDisplay.ButtonRed.Visible = False

        ElseIf MonitoringDisplay.ButtonRed.Visible = False
            LedOnRed()
            StatusActive = True
            MonitoringDisplay.ButtonRed.Visible = True
            AudioRedAlarm()

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
