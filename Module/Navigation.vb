Imports System.InvalidCastException
Module Navigation
    'Side Bar Navigation
    Sub PanelHideAll()
        Mdi.CloseFormAll()
        Mdi.PanelAlarmSetup.Hide()
        AlarmHistory.Close()
        Mdi.PanelAlarmSetupHistory.Hide()
        Mdi.PanelMonitorSetting.Hide()
        Mdi.PanelPatientData.Hide()
        Mdi.PanelNIBP.Hide()
    End Sub
    Dim ColorActive As Color = Color.Gray
    Dim ColorNonActive As Color = Color.White
    Function NavBottom(BtnValue As String, Status As Boolean)
        ResetNavButton()
        Select Case BtnValue
            Case "Home"
                If Status = True Then
                    Mdi.Button1.Image = My.Resources.taskbar_home_activated
                    Mdi.Button1.BackColor = ColorActive
                Else
                    Mdi.Button1.Image = My.Resources.taskbar_home
                    Mdi.Button1.BackColor = ColorNonActive
                End If
            Case "Alarm-Setting"
                If Status = True Then
                    Mdi.Button2.Image = My.Resources.taskbar_alarm_setup_activated
                    Mdi.Button2.BackColor = ColorActive
                Else
                    Mdi.Button2.Image = My.Resources.taskbar_alarm_setup
                    Mdi.Button2.BackColor = ColorNonActive
                End If
            Case "Alarm-History"
                If Status = True Then
                    Mdi.Button3.Image = My.Resources.taskbar_alarm_history_activated
                    Mdi.Button3.BackColor = ColorActive
                Else
                    Mdi.Button3.Image = My.Resources.taskbar_alarm_history
                    Mdi.Button3.BackColor = ColorNonActive
                End If
            Case "Monitor-Setting"
                If Status = True Then
                    Mdi.Button4.Image = My.Resources.taskbar_monitor_setting_activated
                    Mdi.Button4.BackColor = ColorActive
                Else
                    Mdi.Button4.Image = My.Resources.taskbar_monitor_setting
                    Mdi.Button4.BackColor = ColorNonActive
                End If
            Case "Patient-Data"
                If Status = True Then
                    Mdi.Button5.Image = My.Resources.taskbar_patient_data_activated
                    Mdi.Button5.BackColor = ColorActive
                Else
                    Mdi.Button5.Image = My.Resources.taskbar_patient_data
                    Mdi.Button5.BackColor = ColorNonActive
                End If
            Case "NIBP"
                If Status = True Then
                    Mdi.Button6.Image = My.Resources.taskbar_nibp_activated
                    Mdi.Button6.BackColor = ColorActive
                Else
                    Mdi.Button6.Image = My.Resources.taskbar_nibp
                    Mdi.Button6.BackColor = ColorNonActive
                End If
        End Select
        Return BtnValue
    End Function

    Sub ResetNavButton()
        Mdi.Button1.BackColor = ColorNonActive
        Mdi.Button1.Image = My.Resources.taskbar_home
        Mdi.Button2.BackColor = ColorNonActive
        Mdi.Button2.Image = My.Resources.taskbar_alarm_setup
        Mdi.Button3.BackColor = ColorNonActive
        Mdi.Button3.Image = My.Resources.taskbar_alarm_history
        Mdi.Button4.BackColor = ColorNonActive
        Mdi.Button4.Image = My.Resources.taskbar_monitor_setting
        Mdi.Button5.BackColor = ColorNonActive
        Mdi.Button5.Image = My.Resources.taskbar_patient_data
        Mdi.Button6.BackColor = ColorNonActive
        Mdi.Button6.Image = My.Resources.taskbar_nibp
    End Sub

End Module
