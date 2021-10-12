Module Panel_Setting
    Dim W As Integer = 250
    Dim H As Integer = 700
    Sub PanelAlarmHideAll()
        Mdi.PanelAlarmLimits.Hide()
        Mdi.PanelLampBrightness.Hide()
        Mdi.PanelSoundLevel.Hide()
    End Sub
    Sub PanelMonitorSettingHideAll()
        Mdi.PanelScreensetup.Hide()
        Mdi.PanelColors.Hide()
        Mdi.PanelSound.Hide()
        Mdi.PanelScreenBrightness.Hide()
    End Sub
    Sub PanelSetSize()
        Mdi.PanelAlarmSetup.Size = New Size(W, H)
        Mdi.PanelAlarmSetupHistory.Size = New Size(W, H)
        Mdi.PanelMonitorSetting.Size = New Size(W, H)
        Mdi.PanelPatientData.Size = New Size(W, H)
        Mdi.PanelNIBP.Size = New Size(W, H)
    End Sub
    Sub ResetDefault()
        MonitoringDisplay.PanelECG1.Show()
        ColorScreen("ECG1", Color.Lime)
        MonitoringDisplay.PanelECG2.Show()
        ColorScreen("ECG2", Color.Lime)
        MonitoringDisplay.PanelECG2.Show()
        ColorScreen("SPO2", Color.DeepSkyBlue)
        MonitoringDisplay.PanelSPO2.Show()
        ColorScreen("RR", Color.Lime)
        MonitoringDisplay.PanelRR.Show()
        ColorScreen("NIBP", Color.White)
        ColorScreen("TEMP", Color.White)
        MonitoringDisplay.Label27.Text = "T1"
        MonitoringDisplay.Label29.Text = "T2"
        MonitoringDisplay.Label28.Text = "TD"

        MonitoringDisplay.Label27.Visible = True
        MonitoringDisplay.Label28.Visible = True
        MonitoringDisplay.Label29.Visible = True
        MonitoringDisplay.muitemp1.Visible = True
        MonitoringDisplay.muitemp2.Visible = True
        MonitoringDisplay.muitd.Visible = True

    End Sub
End Module
