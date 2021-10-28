Module Notification
    Dim StatusActive As Boolean
    Dim QeueuValue As Integer = 0
    Function NotificationStatusECG(ValueStatus As Integer, NameStatus As String)
        If ValueStatus > MonitoringDisplay.LabelEcgMax.Text Then
            MonitoringDisplay.ButtonRed.Text = NameStatus
            MonitoringDisplay.ButtonYellow.Visible = False
            SendNotifFormAlarm(NameStatus)
            ' ColorScreen("ECG1", Color.Red)
            RedButton()
        ElseIf ValueStatus > MonitoringDisplay.LabelEcgMin.Text
            MonitoringDisplay.ButtonYellow.Text = NameStatus
            MonitoringDisplay.ButtonRed.Visible = False
            SendNotifFormAlarm(NameStatus)

            YellowButton()
        ElseIf ValueStatus < 120
            MonitoringDisplay.ButtonRed.Visible = False
            MonitoringDisplay.ButtonYellow.Visible = False

            StopBackgroundSound()
        End If
        'Send Alarm 
        Return ValueStatus
    End Function
    Function SendNotifFormAlarm(NameStatus As String)
        AlarmHistory.DataGridView1.Rows.Add(NameStatus, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("HH : mm"))
        AlarmHistory.DataGridView1.FirstDisplayedScrollingRowIndex = AlarmHistory.DataGridView1.RowCount - 1
        Return NameStatus
    End Function
    Function NotificationStatusSPO2(ValueStatus As Integer, NameStatus As String)
        If ValueStatus < MonitoringDisplay.LabelSpo2Min.Text Then
            MonitoringDisplay.ButtonRed.Text = NameStatus
            MonitoringDisplay.ButtonYellow.Visible = False
            SendNotifFormAlarm(NameStatus)
            ' ColorScreen("SPO2", Color.Red)
            RedButton()
        ElseIf ValueStatus < MonitoringDisplay.LabelSpo2Max.Text
            MonitoringDisplay.ButtonYellow.Text = NameStatus
            MonitoringDisplay.ButtonRed.Visible = False

            SendNotifFormAlarm(NameStatus)
            YellowButton()
        ElseIf ValueStatus > MonitoringDisplay.LabelSpo2Max.Text
            MonitoringDisplay.ButtonRed.Visible = False
            MonitoringDisplay.ButtonYellow.Visible = False

            If MonitoringDisplay.LabelStatusSpo2.Text = "Module working properly" Then
                AudioHBAlarm()
            End If
        End If
        'Send Alarm 
        Return ValueStatus

    End Function
    Function NotificationStatusRR(ValueStatus As Integer)
        Dim StatusName As String
        If ValueStatus > MonitoringDisplay.LabelRRMax.Text Then
            StatusName = "RR HIGH"
            MonitoringDisplay.ButtonRed.Text = StatusName
            MonitoringDisplay.ButtonYellow.Visible = False
            SendNotifFormAlarm(StatusName)
            ' ColorScreen("RR", Color.Red)
            RedButton()
        ElseIf ValueStatus < MonitoringDisplay.LabelRRMin.Text
            StatusName = "RR LOW"
            MonitoringDisplay.ButtonYellow.Text = StatusName
            MonitoringDisplay.ButtonRed.Visible = False
            SendNotifFormAlarm(StatusName)
            YellowButton()
        Else
            MonitoringDisplay.ButtonRed.Visible = False
            MonitoringDisplay.ButtonYellow.Visible = False
        End If
        'Send Alarm 
        Return ValueStatus

    End Function
    Sub Qeueu()
        If QeueuValue > 4 Then
            QeueuValue = 0
        End If
        MonitoringDisplay.ButtonBlue.Text = QeueuValue
        BlueButton()
    End Sub
    Sub BlueButton()
        If MonitoringDisplay.ButtonBlue.Visible = True Then
            QeueuValue = QeueuValue + 1
            MonitoringDisplay.ButtonBlue.Visible = False
            StatusActive = False
        ElseIf MonitoringDisplay.ButtonBlue.Visible = False
            MonitoringDisplay.ButtonBlue.Visible = True
            StatusActive = True
            AudioBlueAlarm()
        End If
        Application.DoEvents()
    End Sub
    Sub NameTxtBlue()
        Select Case QeueuValue
            Case 0
                MonitoringDisplay.ButtonBlue.Text = "BATTERY FAILURE"
            Case 1
                MonitoringDisplay.ButtonBlue.Text = "CHECK SPO2 LEAD"
            Case 2
                MonitoringDisplay.ButtonBlue.Text = "CHECK ECG LEAD"
            Case 3
                MonitoringDisplay.ButtonBlue.Text = "CHECK TEMP 1 LEAD"
            Case 4
                MonitoringDisplay.ButtonBlue.Text = "CHECK TEMP 2 LEAD"
        End Select
    End Sub
    Sub YellowButton()
        If MonitoringDisplay.ButtonYellow.Visible = True Then
            StatusActive = False
            MonitoringDisplay.ButtonYellow.Visible = False
            StopBackgroundSound()
            LedOffYellow()
        ElseIf MonitoringDisplay.ButtonYellow.Visible = False
            StatusActive = True
            MonitoringDisplay.ButtonYellow.Visible = True
            AudioYellowAlarm()
            LedOnYellow()
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
