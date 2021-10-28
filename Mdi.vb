Imports System.Runtime.InteropServices
Imports System.Management
Imports System.ComponentModel

Public Class Mdi
    'Lebar Me
    Dim WidthMe As Integer = 1024
    'Tinggi Me 
    Dim HeightMe As Integer = 768
    'Lebar 
    Dim W As Integer = 255
    Dim H As Integer = 50
    'Nav Bottom
    Dim ValueArrowButton As Integer
    Sub CloseFormAll()
        'Close Form
        AlarmHistory.Close()
        PatientInformation.Close()
        AddPatient.Close()
        ParameterSetup.Close()
        DefaultSetup.Close()
    End Sub
    Sub PanelHideAll()
        LedOffYellow()
        PanelAlarmSetup.Hide()
        AlarmHistory.Close()
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
        'Function Keyboard
        Me.KeyPreview = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AudioTouchscreen()
        PanelHideAll()
        MonitorDisplayView(WidthMe - 5, HeightMe - 10)
        NavBottom("Home", True)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AudioTouchscreen()
        PanelHideAll()
        MonitorDisplayView(WidthMe - W, HeightMe - H)
        PanelAlarmSetup.Show()
        Button2.Select()
        NavBottom("Alarm-Setting", True)


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AudioTouchscreen()
        PanelHideAll()
        PanelAlarmSetupHistory.Show()
        MonitorDisplayView(WidthMe - W, HeightMe - H)
        AlarmHistory.btn_close.Select()
        AlarmHistory.Show()
        NavBottom("Alarm-History", True)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AudioTouchscreen()
        PanelHideAll()
        PanelMonitorSetting.Show()
        MonitorDisplayView(WidthMe - W, HeightMe - H)
        NavBottom("Monitor-Setting", True)


    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AudioTouchscreen()
        PanelHideAll()
        PanelPatientData.Show()
        MonitorDisplayView(WidthMe - W, HeightMe - H)
        NavBottom("Patient-Data", True)


    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AudioTouchscreen()
        PanelHideAll()
        PanelNIBP.Show()
        MonitorDisplayView(WidthMe - W, HeightMe - H)
        NavBottom("NIBP", True)


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
        LedOnYellow()
        Panel_Setting.PanelAlarmHideAll()
        PanelLampBrightness.Show()
    End Sub

    Private Sub btn_soundlevel_Click_1(sender As Object, e As EventArgs) Handles btn_soundlevel.Click
        Panel_Setting.PanelAlarmHideAll()
        PanelSoundLevel.Show()
        'Sound Level

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
        ColorScreen("ECG1", Color.DeepSkyBlue)
    End Sub

    Private Sub btn_ecg_pink_Click(sender As Object, e As EventArgs) Handles btn_ecg_pink.Click
        ColorScreen("ECG1", Color.HotPink)
    End Sub

    Private Sub btn_ecg_yellow_Click(sender As Object, e As EventArgs) Handles btn_ecg_yellow.Click
        ColorScreen("ECG1", Color.Yellow)
    End Sub

    Private Sub btn_ecg_red_Click(sender As Object, e As EventArgs) Handles btn_ecg_red.Click
        ColorScreen("ECG1", Color.Red)
    End Sub

    Private Sub btn_ecg_green_Click(sender As Object, e As EventArgs) Handles btn_ecg_green.Click
        ColorScreen("ECG1", Color.Lime)
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
        ColorScreen("TEMP", Color.DeepSkyBlue)
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
        ColorScreen("TEMP", Color.Lime)
    End Sub

    Private Sub btn_ecg_white_Click(sender As Object, e As EventArgs) Handles btn_ecg_white.Click
        ColorScreen("ECG1", Color.White)
    End Sub

    Private Sub btn_spo2_white_Click(sender As Object, e As EventArgs) Handles btn_spo2_white.Click
        ColorScreen("SPO2", Color.White)
    End Sub

    Private Sub btn_nibp_white_Click(sender As Object, e As EventArgs) Handles btn_nibp_white.Click
        ColorScreen("NIBP", Color.White)
    End Sub

    Private Sub btn_resp_white_Click(sender As Object, e As EventArgs) Handles btn_resp_white.Click
        ColorScreen("RR", Color.White)
    End Sub

    Private Sub btn_temp_white_Click(sender As Object, e As EventArgs) Handles btn_temp_white.Click
        ColorScreen("TEMP", Color.White)
    End Sub

    Private Sub Mdi_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                Debug.WriteLine("Kiri")
                ValueArrowButton -= 1
                If ValueArrowButton <= 1 Then
                    ValueArrowButton = 1
                End If
                Pilih()
            Case Keys.Right
                Debug.WriteLine("Kanan")
                ValueArrowButton += 1
                If ValueArrowButton > 6 Then
                    ValueArrowButton = 6
                End If
                Pilih()
            Case Keys.Enter
                SwitchTombol()
            'Keyboard Function
            Case Keys.D1, Keys.LControlKey, Keys.LMenu
                Button1.PerformClick()
            Case Keys.D2, Keys.LControlKey, Keys.LMenu
                Button2.PerformClick()
            Case Keys.D3, Keys.LControlKey, Keys.LMenu
                Button3.PerformClick()
            Case Keys.D4, Keys.LControlKey, Keys.LMenu
                Button4.PerformClick()
            Case Keys.D5, Keys.LControlKey, Keys.LMenu
                Button5.PerformClick()
            Case Keys.D6, Keys.LControlKey, Keys.LMenu
                Button6.PerformClick()
        End Select
    End Sub
    Sub Pilih()
        If ValueArrowButton = Button1.TabIndex Then
            NavBottom("Home", True)
            Button1.Select()
            Button1.Focus()
        ElseIf ValueArrowButton = Button2.TabIndex Then
            NavBottom("Alarm-Setting", True)
            Button2.Select()
            Button2.Focus()
        ElseIf ValueArrowButton = Button3.TabIndex Then
            NavBottom("Alarm-History", True)
            Button3.Select()
            Button3.Focus()
        ElseIf ValueArrowButton = Button4.TabIndex Then
            NavBottom("Monitor-Setting", True)
            Button4.Select()
            Button4.Focus()
        ElseIf ValueArrowButton = Button5.TabIndex Then
            NavBottom("Patient-Data", True)
            Button5.Select()
            Button5.Focus()
        ElseIf ValueArrowButton = Button6.TabIndex Then
            NavBottom("NIBP", True)
            Button6.Select()
            Button6.Focus()
        End If
    End Sub
    'Button 
    Sub SwitchTombol()
        Select Case ValueArrowButton
            Case 1
                Button1.PerformClick()
            Case 2
                Button2.PerformClick()
            Case 3
                Button3.PerformClick()
            Case 4
                Button4.PerformClick()
            Case 5
                Button5.PerformClick()
            Case 6
                Button6.PerformClick()
            Case Else
                Debug.WriteLine("Not between 1 and 10, inclusive")
        End Select
    End Sub
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8
    Private Sub ButtonUP_Click(sender As Object, e As EventArgs) Handles ButtonUP.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
    End Sub
    Private Sub ButtonDown_Click(sender As Object, e As EventArgs) Handles ButtonDown.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
    End Sub
    Private Sub BunifuTrackbarScreenBrightness_ValueChanged(sender As Object, e As EventArgs) Handles BunifuTrackbarScreenBrightness.ValueChanged
        Dim mclass As New ManagementClass("WmiMonitorBrightnessMethods")
        mclass.Scope = New ManagementScope("\\.\root\wmi")
        Dim instances As ManagementObjectCollection = mclass.GetInstances()

        For Each instance As ManagementObject In instances
            Dim timeout As ULong = 1
            ' in seconds
            Dim brightness As UShort = CUShort(BunifuTrackbarScreenBrightness.Value)
            ' in percent
            Dim args As Object() = New Object() {timeout, brightness}
            instance.InvokeMethod("WmiSetBrightness", args)
        Next
        LabelScreenBrightness.Text = BunifuTrackbarScreenBrightness.Value
    End Sub
    Dim LedBrightness As String
    Dim SoundAlarm, SoundHeartbeat, SoundTochscreen As Double

    Private Sub btn_save_bright_led_Click(sender As Object, e As EventArgs) Handles btn_save_bright_led.Click
        LedBrightness = LabelBrightnessLed.Text
        KirimLed(LedBrightnessValue)
    End Sub
    Private Sub btn_default_led_Click(sender As Object, e As EventArgs) Handles btn_default_led.Click
        LedBrightness = 0
        LabelBrightnessLed.Text = 100
        KirimLed(LedBrightnessValue)
    End Sub


    Private Sub tbn_plus_hb_Click(sender As Object, e As EventArgs) Handles tbn_plus_hb.Click
        If SoundHeartbeat >= 0.9 Then
            SoundHeartbeat = 0.9
        Else
            SoundHeartbeat = SoundHeartbeat + 0.1
            LabelSoundHeartBeat.Text = SoundHeartbeat
            PlaySoundAlarm(SoundHeartbeat, HBalarm)
        End If
    End Sub

    Private Sub btn_min_hb_Click(sender As Object, e As EventArgs) Handles btn_min_hb.Click
        If SoundHeartbeat <= 0.1 Then
            SoundHeartbeat = 0.1
            PlaySoundAlarm(SoundHeartbeat, HBalarm)
        Else
            SoundHeartbeat = SoundHeartbeat - 0.1
            LabelSoundHeartBeat.Text = SoundHeartbeat
            PlaySoundAlarm(SoundHeartbeat, HBalarm)
        End If
    End Sub


    Private Sub LabelSoundAlarm_TextChanged(sender As Object, e As EventArgs) Handles LabelSoundAlarm.TextChanged
        TextChange(LabelSoundAlarm)
    End Sub
    Sub TextChange(LabelName As Label)
        Select Case LabelName.Text
            Case 0.1
                LabelName.Text = 10
            Case 0.2
                LabelName.Text = 20
            Case 0.3
                LabelName.Text = 30
            Case 0.4
                LabelName.Text = 40
            Case 0.5
                LabelName.Text = 50
            Case 0.6
                LabelName.Text = 60
            Case 0.7
                LabelName.Text = 70
            Case 0.8
                LabelName.Text = 80
            Case 0.9
                LabelName.Text = 90
            Case 1
                LabelName.Text = 100
            Case 0.0
                LabelName.Text = 10
        End Select
    End Sub

    Private Sub LabelSoundHeartBeat_TextChanged(sender As Object, e As EventArgs) Handles LabelSoundHeartBeat.TextChanged
        TextChange(LabelSoundHeartBeat)
    End Sub

    Dim Wave1 As New NAudio.Wave.WaveOut 'Wave out device for playing the sound
    Dim redalarm() As Byte = IO.File.ReadAllBytes(PathAudio & "fix-red-alarm.wav") 'Your Buffer
    Dim HBalarm() As Byte = IO.File.ReadAllBytes(PathAudio & "fix-HB-sound.wav")
    Dim AudioToch() As Byte = IO.File.ReadAllBytes(PathAudio & "fix_tochscreen.wav")
    Sub PlaySoundAlarm(value As Double, valueByte() As Byte)

        Dim data As New IO.MemoryStream(valueByte) 'Data stream for the buffer
        Wave1.Init(New NAudio.Wave.BlockAlignReductionStream(NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(New NAudio.Wave.WaveFileReader(data))))
        Wave1.Volume = value 'Sets the Volume to 10%
        Wave1.Stop()
        Wave1.Play()
    End Sub
    Private Sub btn_plus_alarm_Click(sender As Object, e As EventArgs) Handles btn_plus_alarm.Click
        If SoundAlarm >= 0.9 Then
            SoundAlarm = 0.9
            PlaySoundAlarm(SoundAlarm, redalarm)
        Else
            SoundAlarm = SoundAlarm + 0.1
            LabelSoundAlarm.Text = SoundAlarm
            PlaySoundAlarm(SoundAlarm, redalarm)
        End If

    End Sub

    Private Sub BunifuDropdownPatientType_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdownPatientType.onItemSelected
        MonitoringDisplay.LabelTypePatient.Text = BunifuDropdownPatientType.selectedValue
    End Sub
    Dim ECGMin As Integer = 120
    Dim ECGMax As Integer = 140
    Private Sub btn_min_ecg_min_Click(sender As Object, e As EventArgs) Handles btn_min_ecg_min.Click
        If TextBoxECGMin.Text <= 0 Then
            ECGMin = 0
        Else
            ECGMin = ECGMin - 1
        End If
        TextBoxECGMin.Text = ECGMin
    End Sub

    Private Sub btn_min_ecg_plus_Click(sender As Object, e As EventArgs) Handles btn_min_ecg_plus.Click
        If TextBoxECGMin.Text >= ECGMax Then
            ECGMin = ECGMax
        Else
            ECGMin = ECGMin + 1
        End If
        TextBoxECGMin.Text = ECGMin
    End Sub

    Private Sub TextBoxECGMin_TextChanged(sender As Object, e As EventArgs) Handles TextBoxECGMin.TextChanged
        MonitoringDisplay.LabelEcgMin.Text = ECGMin
    End Sub

    Private Sub btn_max_ecg_plus_Click(sender As Object, e As EventArgs) Handles btn_max_ecg_plus.Click
        ECGMax = ECGMax + 1
        TextBoxECGMax.Text = ECGMax
    End Sub

    Private Sub btn_max_ecg_min_Click(sender As Object, e As EventArgs) Handles btn_max_ecg_min.Click
        If TextBoxECGMax.Text <= ECGMin Then
            ECGMax = ECGMin
        Else
            ECGMax = ECGMax - 1
        End If
        TextBoxECGMax.Text = ECGMax
    End Sub

    Private Sub TextBoxECGMax_TextChanged(sender As Object, e As EventArgs) Handles TextBoxECGMax.TextChanged
        MonitoringDisplay.LabelEcgMax.Text = ECGMax
    End Sub
    Dim SPO2Min As Integer = 60
    Dim Spo2Max As Integer = 95
    Private Sub btn_min_spo2_min_Click(sender As Object, e As EventArgs) Handles btn_min_spo2_min.Click
        If TextBoxSPO2Min.Text <= 0 Then
            SPO2Min = 0
        Else
            SPO2Min = SPO2Min - 1
        End If
        TextBoxSPO2Min.Text = SPO2Min
    End Sub

    Private Sub btn_min_spo2_plus_Click(sender As Object, e As EventArgs) Handles btn_min_spo2_plus.Click
        If TextBoxSPO2Min.Text >= Spo2Max Then
            SPO2Min = Spo2Max
        Else
            SPO2Min = SPO2Min + 1
        End If
        TextBoxSPO2Min.Text = SPO2Min
    End Sub

    Private Sub TextBoxSPO2Min_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSPO2Min.TextChanged
        MonitoringDisplay.LabelSpo2Min.Text = SPO2Min
    End Sub

    Private Sub btn_max_spo2_min_Click(sender As Object, e As EventArgs) Handles btn_max_spo2_min.Click
        If TextBoxSPO2Max.Text <= SPO2Min Then
            Spo2Max = SPO2Min
        Else
            Spo2Max = Spo2Max - 1
        End If
        TextBoxSPO2Max.Text = Spo2Max
    End Sub

    Private Sub btn_max_spo2_plus_Click(sender As Object, e As EventArgs) Handles btn_max_spo2_plus.Click
        Spo2Max = Spo2Max + 1
        TextBoxSPO2Max.Text = Spo2Max
    End Sub

    Private Sub TextBoxSPO2Max_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSPO2Max.TextChanged
        MonitoringDisplay.LabelSpo2Max.Text = Spo2Max
    End Sub
    Dim RRMin As Integer = 5
    Dim RRMax As Integer = 40
    Private Sub btn_min_rr_min_Click(sender As Object, e As EventArgs) Handles btn_min_rr_min.Click
        If TextBoxRRMin.Text <= 0 Then
            RRMin = 0
        Else
            RRMin = RRMin - 1
        End If
        TextBoxRRMin.Text = RRMin
    End Sub

    Private Sub btn_min_rr_plus_Click(sender As Object, e As EventArgs) Handles btn_min_rr_plus.Click
        If TextBoxRRMin.Text >= RRMax Then
            RRMin = RRMax
        Else
            RRMin = RRMin + 1
        End If
        TextBoxRRMin.Text = RRMin
    End Sub

    Private Sub TextBoxRRMin_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRRMin.TextChanged
        MonitoringDisplay.LabelRRMin.Text = RRMin
    End Sub

    Private Sub btn_max_rr_min_Click(sender As Object, e As EventArgs) Handles btn_max_rr_min.Click
        If TextBoxRRMax.Text <= RRMin Then
            RRMax = RRMin
        Else
            RRMax = RRMax - 1
        End If
        TextBoxRRMax.Text = RRMax
    End Sub

    Private Sub btn_max_rr_plus_Click(sender As Object, e As EventArgs) Handles btn_max_rr_plus.Click
        RRMax = RRMax + 1
        TextBoxRRMax.Text = RRMax
    End Sub

    Private Sub TextBoxRRMax_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRRMax.TextChanged
        MonitoringDisplay.LabelRRMax.Text = RRMax
    End Sub

    Private Sub btn_default_alarm_Click(sender As Object, e As EventArgs) Handles btn_default_alarm.Click
        ECGMin = 120
        ECGMax = 140
        SPO2Min = 60
        Spo2Max = 95
        RRMin = 5
        RRMax = 40

        TextBoxECGMin.Text = ECGMin
        TextBoxECGMax.Text = ECGMax
        TextBoxSPO2Min.Text = SPO2Min
        TextBoxSPO2Max.Text = Spo2Max
        TextBoxRRMin.Text = RRMin
        TextBoxRRMax.Text = RRMax
    End Sub
    Dim LedBrightnessValue As Double
    Private Sub btn_lamp_plus_Click(sender As Object, e As EventArgs) Handles btn_lamp_plus.Click
        If LabelBrightnessLed.Text >= 100 Then
            LedBrightnessValue = 10
            LabelBrightnessLed.Text = 100
        Else
            LedBrightnessValue = LedBrightnessValue + 1
            LabelBrightnessLed.Text = LabelBrightnessLed.Text + 10
        End If
    End Sub

    Private Sub btn_lamp_min_Click(sender As Object, e As EventArgs) Handles btn_lamp_min.Click
        If LabelBrightnessLed.Text <= 10 Then
            LedBrightnessValue = 1
            LabelBrightnessLed.Text = 10
        Else
            LedBrightnessValue = LedBrightnessValue - 1
            LabelBrightnessLed.Text = LabelBrightnessLed.Text - 10
        End If
    End Sub

    Private Sub btn_min_tochscreen_Click(sender As Object, e As EventArgs) Handles btn_min_tochscreen.Click
        If SoundTochscreen <= 0.1 Then
            SoundTochscreen = 0.1
            PlaySoundAlarm(SoundTochscreen, AudioToch)
        Else
            SoundTochscreen = SoundTochscreen - 0.1
            LabelTochscreen.Text = SoundTochscreen
            PlaySoundAlarm(SoundTochscreen, AudioToch)
        End If
    End Sub
    Private Sub btn_plus_tochscreen_Click(sender As Object, e As EventArgs) Handles btn_plus_tochscreen.Click
        If SoundTochscreen >= 0.9 Then
            SoundTochscreen = 0.9
            PlaySoundAlarm(SoundTochscreen, AudioToch)
        Else
            SoundTochscreen = SoundTochscreen + 0.1
            LabelTochscreen.Text = SoundTochscreen
            PlaySoundAlarm(SoundTochscreen, AudioToch)
        End If
    End Sub


    Private Sub LabelTochscreen_TextChanged(sender As Object, e As EventArgs) Handles LabelTochscreen.TextChanged
        TextChange(LabelTochscreen)
    End Sub

    Private Sub Mdi_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        PlaySoundAlarm(SoundTochscreen, AudioToch)
    End Sub

    Private Sub btn_min_ecg_min_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_min_alarm_Click(sender As Object, e As EventArgs) Handles btn_min_alarm.Click
        If SoundAlarm <= 0.1 Then
            SoundAlarm = 0.1
            PlaySoundAlarm(SoundAlarm, redalarm)
        Else
            SoundAlarm = SoundAlarm - 0.1
            LabelSoundAlarm.Text = SoundAlarm
            PlaySoundAlarm(SoundAlarm, redalarm)
        End If
    End Sub

    Private Sub Mdi_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Wave1.Dispose()
    End Sub
End Class