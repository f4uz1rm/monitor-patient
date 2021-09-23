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
End Module
