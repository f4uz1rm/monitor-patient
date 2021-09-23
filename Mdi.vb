Public Class Mdi
    'Lebar Me
    Dim WidthMe As Integer = 1024
    'Tinggi Me 
    Dim HeightMe As Integer = 768
    'Lebar 
    Dim W As Integer = 255
    Dim H As Integer = 50
    Sub CloseFormAll()
        'Close Form
        AlarmHistory.Close()
        PatientInformation.Close()
        AddPatient.Close()
        ParameterSetup.Close()
        DefaultSetup.Close()
    End Sub
    Sub PanelHideAll()
        PanelAlarmSetup.Hide()
        PanelAlarmSetupHistory.Hide()
        PanelMonitorSetting.Hide()
        PanelPatientData.Hide()
        PanelNIBP.Hide()

        'Batas
        Panel_Setting.PanelAlarmHideAll()
        Panel_Setting.PanelMonitorSettingHideAll()
    End Sub
    Private Sub Mdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set Size
        PanelSetSize()
        'Panel Hide All Nav Bottom
        PanelHideAll()
        'Panel 
        'Panel_Setting.PanelAlarmHideAll()
        MonitorDisplayView(WidthMe - 5, HeightMe - 10)
        Me.Size = New Size(WidthMe, HeightMe)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelHideAll()
        MonitorDisplayView(WidthMe - 5, HeightMe - 10)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PanelHideAll()
        MonitorDisplayView(WidthMe - W, HeightMe - H)
        PanelAlarmSetup.Show()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelHideAll()
        PanelAlarmSetupHistory.Show()
        MonitorDisplayView(WidthMe - W, HeightMe - H)
        AlarmHistory.Focus()
        AlarmHistory.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PanelHideAll()
        PanelMonitorSetting.Show()
        MonitorDisplayView(WidthMe - W, HeightMe - H)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelHideAll()
        PanelPatientData.Show()
        MonitorDisplayView(WidthMe - W, HeightMe - H)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PanelHideAll()
        PanelNIBP.Show()
        MonitorDisplayView(WidthMe - W, HeightMe - H)
    End Sub

    Private Sub btn_alarmlimits_Click(sender As Object, e As EventArgs)
        Panel_Setting.PanelAlarmHideAll()
        PanelAlarmLimits.Show()
    End Sub


    Private Sub btn_lampbrightness_Click(sender As Object, e As EventArgs)
        Panel_Setting.PanelAlarmHideAll()
        PanelLampBrightness.Show()
    End Sub

    Private Sub btn_soundlevel_Click(sender As Object, e As EventArgs)
        Panel_Setting.PanelAlarmHideAll()
        PanelSoundLevel.Show()
    End Sub

    Private Sub btn_alarmlimits_Click_1(sender As Object, e As EventArgs) Handles btn_alarmlimits.Click
        Panel_Setting.PanelAlarmHideAll()
        PanelAlarmLimits.Show()
    End Sub

    Private Sub btn_lampbrightness_Click_1(sender As Object, e As EventArgs) Handles btn_lampbrightness.Click
        Panel_Setting.PanelAlarmHideAll()
        PanelLampBrightness.Show()
    End Sub

    Private Sub btn_soundlevel_Click_1(sender As Object, e As EventArgs) Handles btn_soundlevel.Click
        Panel_Setting.PanelAlarmHideAll()
        PanelSoundLevel.Show()
    End Sub

    Private Sub btn_screensetup_Click(sender As Object, e As EventArgs) Handles btn_screensetup.Click
        PanelMonitorSettingHideAll()
        PanelScreensetup.Show()
    End Sub

    Private Sub btn_colors_Click(sender As Object, e As EventArgs) Handles btn_colors.Click
        PanelMonitorSettingHideAll()
        PanelColors.Show()
    End Sub

    Private Sub btn_sound_Click(sender As Object, e As EventArgs) Handles btn_sound.Click
        PanelMonitorSettingHideAll()
        PanelSound.Show()
    End Sub

    Private Sub btn_screenbrightness_Click(sender As Object, e As EventArgs) Handles btn_screenbrightness.Click
        PanelMonitorSettingHideAll()
        PanelScreenBrightness.Show()
    End Sub

    Private Sub btn_default_Click(sender As Object, e As EventArgs) Handles btn_default.Click
        PanelMonitorSettingHideAll()
        CloseFormAll()
        DefaultSetup.Show()
    End Sub

    Private Sub btn_parametersetup_Click(sender As Object, e As EventArgs) Handles btn_parametersetup.Click
        PanelMonitorSettingHideAll()
        CloseFormAll()
        ParameterSetup.Show()
    End Sub

    Private Sub btn_view_patient_Click(sender As Object, e As EventArgs) Handles btn_view_patient.Click
        PanelMonitorSettingHideAll()
        CloseFormAll()
        PatientInformation.Show()
    End Sub

    Private Sub btn_add_patient_Click(sender As Object, e As EventArgs) Handles btn_add_patient.Click
        PanelMonitorSettingHideAll()
        CloseFormAll()
        AddPatient.Show()
    End Sub

    Private Sub btn_spo2_blue_Click(sender As Object, e As EventArgs) Handles btn_spo2_blue.Click
        ColorScreen("SPO2", Color.DeepSkyBlue)
    End Sub
    Private Sub btn_spo2_pink_Click(sender As Object, e As EventArgs) Handles btn_spo2_pink.Click
        ColorScreen("SPO2", Color.HotPink)
    End Sub

    Private Sub btn_spo2_yellow_Click(sender As Object, e As EventArgs) Handles btn_spo2_yellow.Click
        ColorScreen("SPO2", Color.Yellow)
    End Sub

    Private Sub btn_spo2_red_Click(sender As Object, e As EventArgs) Handles btn_spo2_red.Click
        ColorScreen("SPO2", Color.Red)
    End Sub

    Private Sub btn_spo2_green_Click(sender As Object, e As EventArgs) Handles btn_spo2_green.Click
        ColorScreen("SPO2", Color.Lime)
    End Sub

    Private Sub CheckBox_ECG1_OnChange(sender As Object, e As EventArgs) Handles CheckBox_ECG1.OnChange
        If CheckBox_ECG1.Checked = False Then
            MonitoringDisplay.PanelECG1.Hide()
        Else
            MonitoringDisplay.PanelECG1.Show()
        End If
    End Sub

    Private Sub CheckBox_ECG2_OnChange(sender As Object, e As EventArgs) Handles CheckBox_ECG2.OnChange
        If CheckBox_ECG2.Checked = False Then
            MonitoringDisplay.PanelECG2.Hide()
        Else
            MonitoringDisplay.PanelECG2.Show()
        End If
    End Sub

    Private Sub CheckBox_RR_OnChange(sender As Object, e As EventArgs) Handles CheckBox_RR.OnChange
        If CheckBox_RR.Checked = False Then
            MonitoringDisplay.PanelRR.Hide()
        Else
            MonitoringDisplay.PanelRR.Show()
        End If
    End Sub

    Private Sub CheckBox_SPO2_OnChange(sender As Object, e As EventArgs) Handles CheckBox_SPO2.OnChange
        If CheckBox_SPO2.Checked = False Then
            MonitoringDisplay.PanelSPO2.Hide()
        Else
            MonitoringDisplay.PanelSPO2.Show()
        End If
    End Sub

    Private Sub btn_ecg_blue_Click(sender As Object, e As EventArgs) Handles btn_ecg_blue.Click
        ColorScreen("ECG", Color.DeepSkyBlue)
    End Sub

    Private Sub btn_ecg_pink_Click(sender As Object, e As EventArgs) Handles btn_ecg_pink.Click
        ColorScreen("ECG", Color.HotPink)
    End Sub

    Private Sub btn_ecg_yellow_Click(sender As Object, e As EventArgs) Handles btn_ecg_yellow.Click
        ColorScreen("ECG", Color.Yellow)
    End Sub

    Private Sub btn_ecg_red_Click(sender As Object, e As EventArgs) Handles btn_ecg_red.Click
        ColorScreen("ECG", Color.Red)
    End Sub

    Private Sub btn_ecg_green_Click(sender As Object, e As EventArgs) Handles btn_ecg_green.Click
        ColorScreen("ECG", Color.Lime)
    End Sub

    Private Sub btn_nibr_blue_Click(sender As Object, e As EventArgs) Handles btn_nibr_blue.Click
        ColorScreen("NIBP", Color.DeepSkyBlue)
    End Sub

    Private Sub btn_nibr_pink_Click(sender As Object, e As EventArgs) Handles btn_nibr_pink.Click
        ColorScreen("NIBP", Color.HotPink)
    End Sub

    Private Sub btn_nibr_yellow_Click(sender As Object, e As EventArgs) Handles btn_nibr_yellow.Click
        ColorScreen("NIBP", Color.Yellow)
    End Sub

    Private Sub btn_nibr_red_Click(sender As Object, e As EventArgs) Handles btn_nibr_red.Click
        ColorScreen("NIBP", Color.Red)
    End Sub

    Private Sub btn_nibr_green_Click(sender As Object, e As EventArgs) Handles btn_nibr_green.Click
        ColorScreen("NIBP", Color.Lime)
    End Sub

    Private Sub btn_resp_blue_Click(sender As Object, e As EventArgs) Handles btn_resp_blue.Click
        ColorScreen("RR", Color.DeepSkyBlue)

    End Sub

    Private Sub btn_resp_pink_Click(sender As Object, e As EventArgs) Handles btn_resp_pink.Click
        ColorScreen("RR", Color.HotPink)
    End Sub

    Private Sub btn_resp_yellow_Click(sender As Object, e As EventArgs) Handles btn_resp_yellow.Click
        ColorScreen("RR", Color.Yellow)
    End Sub

    Private Sub btn_resp_red_Click(sender As Object, e As EventArgs) Handles btn_resp_red.Click
        ColorScreen("RR", Color.Red)
    End Sub

    Private Sub btn_resp_green_Click(sender As Object, e As EventArgs) Handles btn_resp_green.Click
        ColorScreen("RR", Color.Lime)
    End Sub

    Private Sub btn_temp_blue_Click(sender As Object, e As EventArgs) Handles btn_temp_blue.Click
        ColorScreen("TEMP", Color.Blue)
    End Sub

    Private Sub btn_temp_pink_Click(sender As Object, e As EventArgs) Handles btn_temp_pink.Click
        ColorScreen("TEMP", Color.HotPink)
    End Sub

    Private Sub btn_temp_yellow_Click(sender As Object, e As EventArgs) Handles btn_temp_yellow.Click
        ColorScreen("TEMP", Color.Yellow)
    End Sub

    Private Sub btn_temp_red_Click(sender As Object, e As EventArgs) Handles btn_temp_red.Click
        ColorScreen("TEMP", Color.Red)
    End Sub

    Private Sub btn_temp_green_Click(sender As Object, e As EventArgs) Handles btn_temp_green.Click
        ColorScreen("TEMP", Color.Green)
    End Sub
End Class