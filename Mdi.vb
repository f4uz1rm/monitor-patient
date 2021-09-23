Public Class Mdi
    'Lebar Me
    Dim WidthMe As Integer = 1045
    'Tinggi Me 
    Dim HeightMe As Integer = 800
    'Lebar 
    Dim WidthMonitor As Integer = 1024
    'Tinggi
    Dim HeightMonitor As Integer = 768
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
        MonitorDisplayView(WidthMonitor, HeightMonitor)
        Me.Size = New Size(WidthMe, HeightMe)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelHideAll()
        MonitorDisplayView(WidthMonitor, HeightMonitor)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PanelHideAll()
        MonitorDisplayView(WidthMonitor, HeightMonitor)
        PanelAlarmSetup.Show()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelHideAll()
        PanelAlarmSetupHistory.Show()
        MonitorDisplayView(WidthMonitor, HeightMonitor)
        AlarmHistory.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PanelHideAll()
        PanelMonitorSetting.Show()
        MonitorDisplayView(WidthMonitor, HeightMonitor)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelHideAll()
        PanelPatientData.Show()
        MonitorDisplayView(WidthMonitor, HeightMonitor)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PanelHideAll()
        PanelNIBP.Show()
        MonitorDisplayView(WidthMonitor, HeightMonitor)
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
End Class