<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mdi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mdi))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelAlarmSetup = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelSoundLevel = New System.Windows.Forms.Panel()
        Me.ButtonUP = New System.Windows.Forms.Button()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_soundlevel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelLampBrightness = New System.Windows.Forms.Panel()
        Me.btn_default_led = New System.Windows.Forms.Button()
        Me.btn_save_bright_led = New System.Windows.Forms.Button()
        Me.LabelBrightnessLed = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btn_lampbrightness = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelAlarmLimits = New System.Windows.Forms.Panel()
        Me.btn_default_alarm = New System.Windows.Forms.Button()
        Me.TextBoxRRMax = New System.Windows.Forms.TextBox()
        Me.TextBoxRRMin = New System.Windows.Forms.TextBox()
        Me.TextBoxNIBPMax = New System.Windows.Forms.TextBox()
        Me.TextBoxNIBPMin = New System.Windows.Forms.TextBox()
        Me.TextBoxSPO2Max = New System.Windows.Forms.TextBox()
        Me.TextBoxSPO2Min = New System.Windows.Forms.TextBox()
        Me.TextBoxECGMax = New System.Windows.Forms.TextBox()
        Me.TextBoxECGMin = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.btn_max_rr_min = New System.Windows.Forms.Button()
        Me.btn_max_rr_plus = New System.Windows.Forms.Button()
        Me.btn_min_rr_min = New System.Windows.Forms.Button()
        Me.btn_min_rr_plus = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.btn_max_nibp_min = New System.Windows.Forms.Button()
        Me.btn_max_nibp_plus = New System.Windows.Forms.Button()
        Me.btn_min_nibp_min = New System.Windows.Forms.Button()
        Me.btn_min_nibp_plus = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.btn_max_spo2_min = New System.Windows.Forms.Button()
        Me.btn_max_spo2_plus = New System.Windows.Forms.Button()
        Me.btn_min_spo2_min = New System.Windows.Forms.Button()
        Me.btn_min_spo2_plus = New System.Windows.Forms.Button()
        Me.btn_max_ecg_min = New System.Windows.Forms.Button()
        Me.btn_max_ecg_plus = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btn_min_ecg_min = New System.Windows.Forms.Button()
        Me.btn_min_ecg_plus = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_alarmlimits = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelAlarmSetupHistory = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PanelMonitorSetting = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_default = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelScreenBrightness = New System.Windows.Forms.Panel()
        Me.BunifuTrackbarScreenBrightness = New Bunifu.Framework.UI.BunifuTrackbar()
        Me.LabelScreenBrightness = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_screenbrightness = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_parametersetup = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelSound = New System.Windows.Forms.Panel()
        Me.btn_min_tochscreen = New System.Windows.Forms.Button()
        Me.btn_plus_tochscreen = New System.Windows.Forms.Button()
        Me.LabelTochscreen = New System.Windows.Forms.Label()
        Me.btn_min_hb = New System.Windows.Forms.Button()
        Me.tbn_plus_hb = New System.Windows.Forms.Button()
        Me.btn_min_alarm = New System.Windows.Forms.Button()
        Me.btn_plus_alarm = New System.Windows.Forms.Button()
        Me.LabelSoundHeartBeat = New System.Windows.Forms.Label()
        Me.LabelSoundAlarm = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_sound = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelColors = New System.Windows.Forms.Panel()
        Me.btn_temp_white = New System.Windows.Forms.Button()
        Me.btn_resp_white = New System.Windows.Forms.Button()
        Me.btn_nibp_white = New System.Windows.Forms.Button()
        Me.btn_spo2_white = New System.Windows.Forms.Button()
        Me.btn_ecg_white = New System.Windows.Forms.Button()
        Me.btn_temp_green = New System.Windows.Forms.Button()
        Me.btn_temp_red = New System.Windows.Forms.Button()
        Me.btn_temp_yellow = New System.Windows.Forms.Button()
        Me.btn_temp_pink = New System.Windows.Forms.Button()
        Me.btn_temp_blue = New System.Windows.Forms.Button()
        Me.btn_resp_green = New System.Windows.Forms.Button()
        Me.btn_resp_red = New System.Windows.Forms.Button()
        Me.btn_resp_yellow = New System.Windows.Forms.Button()
        Me.btn_resp_pink = New System.Windows.Forms.Button()
        Me.btn_resp_blue = New System.Windows.Forms.Button()
        Me.btn_nibr_green = New System.Windows.Forms.Button()
        Me.btn_nibr_red = New System.Windows.Forms.Button()
        Me.btn_nibr_yellow = New System.Windows.Forms.Button()
        Me.btn_nibr_pink = New System.Windows.Forms.Button()
        Me.btn_nibr_blue = New System.Windows.Forms.Button()
        Me.btn_spo2_green = New System.Windows.Forms.Button()
        Me.btn_spo2_red = New System.Windows.Forms.Button()
        Me.btn_spo2_yellow = New System.Windows.Forms.Button()
        Me.btn_spo2_pink = New System.Windows.Forms.Button()
        Me.btn_spo2_blue = New System.Windows.Forms.Button()
        Me.btn_ecg_green = New System.Windows.Forms.Button()
        Me.btn_ecg_red = New System.Windows.Forms.Button()
        Me.btn_ecg_yellow = New System.Windows.Forms.Button()
        Me.btn_ecg_pink = New System.Windows.Forms.Button()
        Me.btn_ecg_blue = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btn_colors = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelScreensetup = New System.Windows.Forms.Panel()
        Me.CheckBox_SPO2 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.CheckBox_RR = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CheckBox_ECG2 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CheckBox_ECG1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btn_screensetup = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PanelPatientData = New System.Windows.Forms.Panel()
        Me.btn_view_patient = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_add_patient = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PanelNIBP = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.btn_start_auto = New System.Windows.Forms.Button()
        Me.btn_stop_auto = New System.Windows.Forms.Button()
        Me.BunifuDropdownPatientType = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuDropdownDuration = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.btn_stop_manual = New System.Windows.Forms.Button()
        Me.btn_start_manual = New System.Windows.Forms.Button()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btn_lamp_min = New System.Windows.Forms.Button()
        Me.btn_lamp_plus = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.PanelAlarmSetup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelSoundLevel.SuspendLayout()
        Me.PanelLampBrightness.SuspendLayout()
        Me.PanelAlarmLimits.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelAlarmSetupHistory.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.PanelMonitorSetting.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelScreenBrightness.SuspendLayout()
        Me.PanelSound.SuspendLayout()
        Me.PanelColors.SuspendLayout()
        Me.PanelScreensetup.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.PanelPatientData.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.PanelNIBP.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 727)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1386, 61)
        Me.Panel2.TabIndex = 2
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_nibp
        Me.Button6.Location = New System.Drawing.Point(838, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(170, 60)
        Me.Button6.TabIndex = 6
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_patient_data
        Me.Button5.Location = New System.Drawing.Point(675, 1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(170, 60)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_monitor_setting
        Me.Button4.Location = New System.Drawing.Point(505, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 60)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_alarm_history
        Me.Button3.Location = New System.Drawing.Point(336, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 60)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_alarm_setup
        Me.Button2.Location = New System.Drawing.Point(166, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_home
        Me.Button1.Location = New System.Drawing.Point(-2, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelAlarmSetup
        '
        Me.PanelAlarmSetup.Controls.Add(Me.Panel1)
        Me.PanelAlarmSetup.Controls.Add(Me.Panel5)
        Me.PanelAlarmSetup.Controls.Add(Me.Panel4)
        Me.PanelAlarmSetup.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelAlarmSetup.Location = New System.Drawing.Point(0, 0)
        Me.PanelAlarmSetup.Name = "PanelAlarmSetup"
        Me.PanelAlarmSetup.Size = New System.Drawing.Size(300, 727)
        Me.PanelAlarmSetup.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelSoundLevel)
        Me.Panel1.Controls.Add(Me.btn_soundlevel)
        Me.Panel1.Controls.Add(Me.PanelLampBrightness)
        Me.Panel1.Controls.Add(Me.btn_lampbrightness)
        Me.Panel1.Controls.Add(Me.PanelAlarmLimits)
        Me.Panel1.Controls.Add(Me.btn_alarmlimits)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 726)
        Me.Panel1.TabIndex = 5
        '
        'PanelSoundLevel
        '
        Me.PanelSoundLevel.Controls.Add(Me.ButtonUP)
        Me.PanelSoundLevel.Controls.Add(Me.ButtonDown)
        Me.PanelSoundLevel.Controls.Add(Me.Label16)
        Me.PanelSoundLevel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSoundLevel.Location = New System.Drawing.Point(0, 621)
        Me.PanelSoundLevel.Name = "PanelSoundLevel"
        Me.PanelSoundLevel.Size = New System.Drawing.Size(300, 114)
        Me.PanelSoundLevel.TabIndex = 5
        '
        'ButtonUP
        '
        Me.ButtonUP.Location = New System.Drawing.Point(153, 42)
        Me.ButtonUP.Name = "ButtonUP"
        Me.ButtonUP.Size = New System.Drawing.Size(25, 23)
        Me.ButtonUP.TabIndex = 4
        Me.ButtonUP.Text = "+"
        Me.ButtonUP.UseVisualStyleBackColor = True
        '
        'ButtonDown
        '
        Me.ButtonDown.Location = New System.Drawing.Point(97, 42)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(25, 23)
        Me.ButtonDown.TabIndex = 3
        Me.ButtonDown.Text = "-"
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(64, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Level"
        '
        'btn_soundlevel
        '
        Me.btn_soundlevel.Activecolor = System.Drawing.Color.DarkGray
        Me.btn_soundlevel.BackColor = System.Drawing.Color.Transparent
        Me.btn_soundlevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_soundlevel.BorderRadius = 0
        Me.btn_soundlevel.ButtonText = "Sound Level"
        Me.btn_soundlevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_soundlevel.DisabledColor = System.Drawing.Color.Gray
        Me.btn_soundlevel.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_soundlevel.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_soundlevel.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_sound_volume
        Me.btn_soundlevel.Iconimage_right = CType(resources.GetObject("btn_soundlevel.Iconimage_right"), System.Drawing.Image)
        Me.btn_soundlevel.Iconimage_right_Selected = CType(resources.GetObject("btn_soundlevel.Iconimage_right_Selected"), System.Drawing.Image)
        Me.btn_soundlevel.Iconimage_Selected = CType(resources.GetObject("btn_soundlevel.Iconimage_Selected"), System.Drawing.Image)
        Me.btn_soundlevel.IconMarginLeft = 0
        Me.btn_soundlevel.IconMarginRight = 0
        Me.btn_soundlevel.IconRightVisible = True
        Me.btn_soundlevel.IconRightZoom = 0R
        Me.btn_soundlevel.IconVisible = True
        Me.btn_soundlevel.IconZoom = 50.0R
        Me.btn_soundlevel.IsTab = False
        Me.btn_soundlevel.Location = New System.Drawing.Point(0, 573)
        Me.btn_soundlevel.Name = "btn_soundlevel"
        Me.btn_soundlevel.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_soundlevel.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btn_soundlevel.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_soundlevel.selected = False
        Me.btn_soundlevel.Size = New System.Drawing.Size(300, 48)
        Me.btn_soundlevel.TabIndex = 3
        Me.btn_soundlevel.Text = "Sound Level"
        Me.btn_soundlevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_soundlevel.Textcolor = System.Drawing.Color.Black
        Me.btn_soundlevel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelLampBrightness
        '
        Me.PanelLampBrightness.Controls.Add(Me.btn_lamp_min)
        Me.PanelLampBrightness.Controls.Add(Me.btn_default_led)
        Me.PanelLampBrightness.Controls.Add(Me.btn_lamp_plus)
        Me.PanelLampBrightness.Controls.Add(Me.btn_save_bright_led)
        Me.PanelLampBrightness.Controls.Add(Me.LabelBrightnessLed)
        Me.PanelLampBrightness.Controls.Add(Me.Label20)
        Me.PanelLampBrightness.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLampBrightness.Location = New System.Drawing.Point(0, 433)
        Me.PanelLampBrightness.Name = "PanelLampBrightness"
        Me.PanelLampBrightness.Size = New System.Drawing.Size(300, 140)
        Me.PanelLampBrightness.TabIndex = 3
        '
        'btn_default_led
        '
        Me.btn_default_led.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_default_led.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_default_led.ForeColor = System.Drawing.Color.White
        Me.btn_default_led.Location = New System.Drawing.Point(46, 78)
        Me.btn_default_led.Name = "btn_default_led"
        Me.btn_default_led.Size = New System.Drawing.Size(75, 23)
        Me.btn_default_led.TabIndex = 16
        Me.btn_default_led.Text = "Default"
        Me.btn_default_led.UseVisualStyleBackColor = False
        '
        'btn_save_bright_led
        '
        Me.btn_save_bright_led.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_save_bright_led.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save_bright_led.ForeColor = System.Drawing.Color.White
        Me.btn_save_bright_led.Location = New System.Drawing.Point(134, 78)
        Me.btn_save_bright_led.Name = "btn_save_bright_led"
        Me.btn_save_bright_led.Size = New System.Drawing.Size(75, 23)
        Me.btn_save_bright_led.TabIndex = 15
        Me.btn_save_bright_led.Text = "Save"
        Me.btn_save_bright_led.UseVisualStyleBackColor = False
        '
        'LabelBrightnessLed
        '
        Me.LabelBrightnessLed.AutoSize = True
        Me.LabelBrightnessLed.Location = New System.Drawing.Point(122, 50)
        Me.LabelBrightnessLed.Name = "LabelBrightnessLed"
        Me.LabelBrightnessLed.Size = New System.Drawing.Size(13, 13)
        Me.LabelBrightnessLed.TabIndex = 3
        Me.LabelBrightnessLed.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(64, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Brightness"
        '
        'btn_lampbrightness
        '
        Me.btn_lampbrightness.Activecolor = System.Drawing.Color.DarkGray
        Me.btn_lampbrightness.BackColor = System.Drawing.Color.Transparent
        Me.btn_lampbrightness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_lampbrightness.BorderRadius = 0
        Me.btn_lampbrightness.ButtonText = "Lamp Brightness"
        Me.btn_lampbrightness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_lampbrightness.DisabledColor = System.Drawing.Color.Gray
        Me.btn_lampbrightness.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_lampbrightness.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_lampbrightness.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_lamp_brightness1
        Me.btn_lampbrightness.Iconimage_right = CType(resources.GetObject("btn_lampbrightness.Iconimage_right"), System.Drawing.Image)
        Me.btn_lampbrightness.Iconimage_right_Selected = CType(resources.GetObject("btn_lampbrightness.Iconimage_right_Selected"), System.Drawing.Image)
        Me.btn_lampbrightness.Iconimage_Selected = CType(resources.GetObject("btn_lampbrightness.Iconimage_Selected"), System.Drawing.Image)
        Me.btn_lampbrightness.IconMarginLeft = 0
        Me.btn_lampbrightness.IconMarginRight = 0
        Me.btn_lampbrightness.IconRightVisible = True
        Me.btn_lampbrightness.IconRightZoom = 0R
        Me.btn_lampbrightness.IconVisible = True
        Me.btn_lampbrightness.IconZoom = 50.0R
        Me.btn_lampbrightness.IsTab = False
        Me.btn_lampbrightness.Location = New System.Drawing.Point(0, 385)
        Me.btn_lampbrightness.Name = "btn_lampbrightness"
        Me.btn_lampbrightness.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_lampbrightness.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btn_lampbrightness.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_lampbrightness.selected = False
        Me.btn_lampbrightness.Size = New System.Drawing.Size(300, 48)
        Me.btn_lampbrightness.TabIndex = 2
        Me.btn_lampbrightness.Text = "Lamp Brightness"
        Me.btn_lampbrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_lampbrightness.Textcolor = System.Drawing.Color.Black
        Me.btn_lampbrightness.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelAlarmLimits
        '
        Me.PanelAlarmLimits.Controls.Add(Me.btn_default_alarm)
        Me.PanelAlarmLimits.Controls.Add(Me.TextBoxRRMax)
        Me.PanelAlarmLimits.Controls.Add(Me.TextBoxRRMin)
        Me.PanelAlarmLimits.Controls.Add(Me.TextBoxNIBPMax)
        Me.PanelAlarmLimits.Controls.Add(Me.TextBoxNIBPMin)
        Me.PanelAlarmLimits.Controls.Add(Me.TextBoxSPO2Max)
        Me.PanelAlarmLimits.Controls.Add(Me.TextBoxSPO2Min)
        Me.PanelAlarmLimits.Controls.Add(Me.TextBoxECGMax)
        Me.PanelAlarmLimits.Controls.Add(Me.TextBoxECGMin)
        Me.PanelAlarmLimits.Controls.Add(Me.Label42)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_max_rr_min)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_max_rr_plus)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_min_rr_min)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_min_rr_plus)
        Me.PanelAlarmLimits.Controls.Add(Me.Label39)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_max_nibp_min)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_max_nibp_plus)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_min_nibp_min)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_min_nibp_plus)
        Me.PanelAlarmLimits.Controls.Add(Me.Label37)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_max_spo2_min)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_max_spo2_plus)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_min_spo2_min)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_min_spo2_plus)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_max_ecg_min)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_max_ecg_plus)
        Me.PanelAlarmLimits.Controls.Add(Me.Label34)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_min_ecg_min)
        Me.PanelAlarmLimits.Controls.Add(Me.btn_min_ecg_plus)
        Me.PanelAlarmLimits.Controls.Add(Me.Label15)
        Me.PanelAlarmLimits.Controls.Add(Me.Label14)
        Me.PanelAlarmLimits.Controls.Add(Me.Label12)
        Me.PanelAlarmLimits.Controls.Add(Me.Label11)
        Me.PanelAlarmLimits.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAlarmLimits.Location = New System.Drawing.Point(0, 48)
        Me.PanelAlarmLimits.Name = "PanelAlarmLimits"
        Me.PanelAlarmLimits.Size = New System.Drawing.Size(300, 337)
        Me.PanelAlarmLimits.TabIndex = 1
        '
        'btn_default_alarm
        '
        Me.btn_default_alarm.Location = New System.Drawing.Point(81, 293)
        Me.btn_default_alarm.Name = "btn_default_alarm"
        Me.btn_default_alarm.Size = New System.Drawing.Size(75, 23)
        Me.btn_default_alarm.TabIndex = 53
        Me.btn_default_alarm.Text = "Default"
        Me.btn_default_alarm.UseVisualStyleBackColor = True
        '
        'TextBoxRRMax
        '
        Me.TextBoxRRMax.Location = New System.Drawing.Point(153, 257)
        Me.TextBoxRRMax.Name = "TextBoxRRMax"
        Me.TextBoxRRMax.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxRRMax.TabIndex = 52
        Me.TextBoxRRMax.Text = "40"
        Me.TextBoxRRMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRRMin
        '
        Me.TextBoxRRMin.Location = New System.Drawing.Point(52, 257)
        Me.TextBoxRRMin.Name = "TextBoxRRMin"
        Me.TextBoxRRMin.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxRRMin.TabIndex = 51
        Me.TextBoxRRMin.Text = "5"
        Me.TextBoxRRMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNIBPMax
        '
        Me.TextBoxNIBPMax.Location = New System.Drawing.Point(153, 184)
        Me.TextBoxNIBPMax.Name = "TextBoxNIBPMax"
        Me.TextBoxNIBPMax.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxNIBPMax.TabIndex = 50
        Me.TextBoxNIBPMax.Text = "0"
        Me.TextBoxNIBPMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNIBPMin
        '
        Me.TextBoxNIBPMin.Location = New System.Drawing.Point(52, 184)
        Me.TextBoxNIBPMin.Name = "TextBoxNIBPMin"
        Me.TextBoxNIBPMin.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxNIBPMin.TabIndex = 49
        Me.TextBoxNIBPMin.Text = "0"
        Me.TextBoxNIBPMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxSPO2Max
        '
        Me.TextBoxSPO2Max.Location = New System.Drawing.Point(153, 116)
        Me.TextBoxSPO2Max.Name = "TextBoxSPO2Max"
        Me.TextBoxSPO2Max.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxSPO2Max.TabIndex = 48
        Me.TextBoxSPO2Max.Text = "95"
        Me.TextBoxSPO2Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxSPO2Min
        '
        Me.TextBoxSPO2Min.Location = New System.Drawing.Point(54, 116)
        Me.TextBoxSPO2Min.Name = "TextBoxSPO2Min"
        Me.TextBoxSPO2Min.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxSPO2Min.TabIndex = 47
        Me.TextBoxSPO2Min.Text = "60"
        Me.TextBoxSPO2Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxECGMax
        '
        Me.TextBoxECGMax.Location = New System.Drawing.Point(153, 38)
        Me.TextBoxECGMax.Name = "TextBoxECGMax"
        Me.TextBoxECGMax.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxECGMax.TabIndex = 46
        Me.TextBoxECGMax.Text = "140"
        Me.TextBoxECGMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxECGMin
        '
        Me.TextBoxECGMin.Location = New System.Drawing.Point(54, 36)
        Me.TextBoxECGMin.Name = "TextBoxECGMin"
        Me.TextBoxECGMin.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxECGMin.TabIndex = 45
        Me.TextBoxECGMin.Text = "120"
        Me.TextBoxECGMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(129, 234)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(55, 13)
        Me.Label42.TabIndex = 44
        Me.Label42.Text = "RR MAX"
        '
        'btn_max_rr_min
        '
        Me.btn_max_rr_min.Location = New System.Drawing.Point(125, 255)
        Me.btn_max_rr_min.Name = "btn_max_rr_min"
        Me.btn_max_rr_min.Size = New System.Drawing.Size(22, 23)
        Me.btn_max_rr_min.TabIndex = 42
        Me.btn_max_rr_min.Text = "-"
        Me.btn_max_rr_min.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_max_rr_min.UseVisualStyleBackColor = True
        '
        'btn_max_rr_plus
        '
        Me.btn_max_rr_plus.Location = New System.Drawing.Point(194, 255)
        Me.btn_max_rr_plus.Name = "btn_max_rr_plus"
        Me.btn_max_rr_plus.Size = New System.Drawing.Size(22, 23)
        Me.btn_max_rr_plus.TabIndex = 41
        Me.btn_max_rr_plus.Text = "+"
        Me.btn_max_rr_plus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_max_rr_plus.UseVisualStyleBackColor = True
        '
        'btn_min_rr_min
        '
        Me.btn_min_rr_min.Location = New System.Drawing.Point(26, 255)
        Me.btn_min_rr_min.Name = "btn_min_rr_min"
        Me.btn_min_rr_min.Size = New System.Drawing.Size(22, 23)
        Me.btn_min_rr_min.TabIndex = 39
        Me.btn_min_rr_min.Text = "-"
        Me.btn_min_rr_min.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_min_rr_min.UseVisualStyleBackColor = True
        '
        'btn_min_rr_plus
        '
        Me.btn_min_rr_plus.Location = New System.Drawing.Point(95, 255)
        Me.btn_min_rr_plus.Name = "btn_min_rr_plus"
        Me.btn_min_rr_plus.Size = New System.Drawing.Size(22, 23)
        Me.btn_min_rr_plus.TabIndex = 38
        Me.btn_min_rr_plus.Text = "+"
        Me.btn_min_rr_plus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_min_rr_plus.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(129, 156)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(66, 13)
        Me.Label39.TabIndex = 37
        Me.Label39.Text = "NIBP MAX"
        '
        'btn_max_nibp_min
        '
        Me.btn_max_nibp_min.Location = New System.Drawing.Point(125, 181)
        Me.btn_max_nibp_min.Name = "btn_max_nibp_min"
        Me.btn_max_nibp_min.Size = New System.Drawing.Size(22, 23)
        Me.btn_max_nibp_min.TabIndex = 35
        Me.btn_max_nibp_min.Text = "-"
        Me.btn_max_nibp_min.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_max_nibp_min.UseVisualStyleBackColor = True
        '
        'btn_max_nibp_plus
        '
        Me.btn_max_nibp_plus.Location = New System.Drawing.Point(194, 181)
        Me.btn_max_nibp_plus.Name = "btn_max_nibp_plus"
        Me.btn_max_nibp_plus.Size = New System.Drawing.Size(22, 23)
        Me.btn_max_nibp_plus.TabIndex = 34
        Me.btn_max_nibp_plus.Text = "+"
        Me.btn_max_nibp_plus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_max_nibp_plus.UseVisualStyleBackColor = True
        '
        'btn_min_nibp_min
        '
        Me.btn_min_nibp_min.Location = New System.Drawing.Point(26, 181)
        Me.btn_min_nibp_min.Name = "btn_min_nibp_min"
        Me.btn_min_nibp_min.Size = New System.Drawing.Size(22, 23)
        Me.btn_min_nibp_min.TabIndex = 32
        Me.btn_min_nibp_min.Text = "-"
        Me.btn_min_nibp_min.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_min_nibp_min.UseVisualStyleBackColor = True
        '
        'btn_min_nibp_plus
        '
        Me.btn_min_nibp_plus.Location = New System.Drawing.Point(95, 181)
        Me.btn_min_nibp_plus.Name = "btn_min_nibp_plus"
        Me.btn_min_nibp_plus.Size = New System.Drawing.Size(22, 23)
        Me.btn_min_nibp_plus.TabIndex = 31
        Me.btn_min_nibp_plus.Text = "+"
        Me.btn_min_nibp_plus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_min_nibp_plus.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(129, 93)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(69, 13)
        Me.Label37.TabIndex = 30
        Me.Label37.Text = "SPO2 MAX"
        '
        'btn_max_spo2_min
        '
        Me.btn_max_spo2_min.Location = New System.Drawing.Point(126, 113)
        Me.btn_max_spo2_min.Name = "btn_max_spo2_min"
        Me.btn_max_spo2_min.Size = New System.Drawing.Size(22, 23)
        Me.btn_max_spo2_min.TabIndex = 28
        Me.btn_max_spo2_min.Text = "-"
        Me.btn_max_spo2_min.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_max_spo2_min.UseVisualStyleBackColor = True
        '
        'btn_max_spo2_plus
        '
        Me.btn_max_spo2_plus.Location = New System.Drawing.Point(195, 113)
        Me.btn_max_spo2_plus.Name = "btn_max_spo2_plus"
        Me.btn_max_spo2_plus.Size = New System.Drawing.Size(22, 23)
        Me.btn_max_spo2_plus.TabIndex = 27
        Me.btn_max_spo2_plus.Text = "+"
        Me.btn_max_spo2_plus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_max_spo2_plus.UseVisualStyleBackColor = True
        '
        'btn_min_spo2_min
        '
        Me.btn_min_spo2_min.Location = New System.Drawing.Point(27, 113)
        Me.btn_min_spo2_min.Name = "btn_min_spo2_min"
        Me.btn_min_spo2_min.Size = New System.Drawing.Size(22, 23)
        Me.btn_min_spo2_min.TabIndex = 25
        Me.btn_min_spo2_min.Text = "-"
        Me.btn_min_spo2_min.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_min_spo2_min.UseVisualStyleBackColor = True
        '
        'btn_min_spo2_plus
        '
        Me.btn_min_spo2_plus.Location = New System.Drawing.Point(96, 113)
        Me.btn_min_spo2_plus.Name = "btn_min_spo2_plus"
        Me.btn_min_spo2_plus.Size = New System.Drawing.Size(22, 23)
        Me.btn_min_spo2_plus.TabIndex = 24
        Me.btn_min_spo2_plus.Text = "+"
        Me.btn_min_spo2_plus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_min_spo2_plus.UseVisualStyleBackColor = True
        '
        'btn_max_ecg_min
        '
        Me.btn_max_ecg_min.Location = New System.Drawing.Point(125, 35)
        Me.btn_max_ecg_min.Name = "btn_max_ecg_min"
        Me.btn_max_ecg_min.Size = New System.Drawing.Size(22, 23)
        Me.btn_max_ecg_min.TabIndex = 22
        Me.btn_max_ecg_min.Text = "-"
        Me.btn_max_ecg_min.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_max_ecg_min.UseVisualStyleBackColor = True
        '
        'btn_max_ecg_plus
        '
        Me.btn_max_ecg_plus.Location = New System.Drawing.Point(194, 35)
        Me.btn_max_ecg_plus.Name = "btn_max_ecg_plus"
        Me.btn_max_ecg_plus.Size = New System.Drawing.Size(22, 23)
        Me.btn_max_ecg_plus.TabIndex = 21
        Me.btn_max_ecg_plus.Text = "+"
        Me.btn_max_ecg_plus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_max_ecg_plus.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(124, 12)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(84, 13)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "HR ECG MAX"
        '
        'btn_min_ecg_min
        '
        Me.btn_min_ecg_min.Location = New System.Drawing.Point(26, 35)
        Me.btn_min_ecg_min.Name = "btn_min_ecg_min"
        Me.btn_min_ecg_min.Size = New System.Drawing.Size(22, 23)
        Me.btn_min_ecg_min.TabIndex = 18
        Me.btn_min_ecg_min.Text = "-"
        Me.btn_min_ecg_min.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_min_ecg_min.UseVisualStyleBackColor = True
        '
        'btn_min_ecg_plus
        '
        Me.btn_min_ecg_plus.Location = New System.Drawing.Point(95, 35)
        Me.btn_min_ecg_plus.Name = "btn_min_ecg_plus"
        Me.btn_min_ecg_plus.Size = New System.Drawing.Size(22, 23)
        Me.btn_min_ecg_plus.TabIndex = 17
        Me.btn_min_ecg_plus.Text = "+"
        Me.btn_min_ecg_plus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_min_ecg_plus.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(29, 234)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "RR MIN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(29, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "NIBP MIN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "SPO2 MIN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "HR ECG MIN"
        '
        'btn_alarmlimits
        '
        Me.btn_alarmlimits.Activecolor = System.Drawing.Color.DarkGray
        Me.btn_alarmlimits.BackColor = System.Drawing.Color.Transparent
        Me.btn_alarmlimits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_alarmlimits.BorderRadius = 0
        Me.btn_alarmlimits.ButtonText = "Alarm Limits"
        Me.btn_alarmlimits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_alarmlimits.DisabledColor = System.Drawing.Color.Gray
        Me.btn_alarmlimits.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_alarmlimits.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_alarmlimits.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_alarm_limits1
        Me.btn_alarmlimits.Iconimage_right = CType(resources.GetObject("btn_alarmlimits.Iconimage_right"), System.Drawing.Image)
        Me.btn_alarmlimits.Iconimage_right_Selected = CType(resources.GetObject("btn_alarmlimits.Iconimage_right_Selected"), System.Drawing.Image)
        Me.btn_alarmlimits.Iconimage_Selected = CType(resources.GetObject("btn_alarmlimits.Iconimage_Selected"), System.Drawing.Image)
        Me.btn_alarmlimits.IconMarginLeft = 0
        Me.btn_alarmlimits.IconMarginRight = 0
        Me.btn_alarmlimits.IconRightVisible = True
        Me.btn_alarmlimits.IconRightZoom = 50.0R
        Me.btn_alarmlimits.IconVisible = True
        Me.btn_alarmlimits.IconZoom = 50.0R
        Me.btn_alarmlimits.IsTab = False
        Me.btn_alarmlimits.Location = New System.Drawing.Point(0, 0)
        Me.btn_alarmlimits.Name = "btn_alarmlimits"
        Me.btn_alarmlimits.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_alarmlimits.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btn_alarmlimits.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_alarmlimits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_alarmlimits.selected = False
        Me.btn_alarmlimits.Size = New System.Drawing.Size(300, 48)
        Me.btn_alarmlimits.TabIndex = 1
        Me.btn_alarmlimits.Text = "Alarm Limits"
        Me.btn_alarmlimits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_alarmlimits.Textcolor = System.Drawing.Color.Black
        Me.btn_alarmlimits.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 81)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(300, 56)
        Me.Panel5.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(80, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Alarm Setup "
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.GMed_PM01.My.Resources.Resources.logo
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 81)
        Me.Panel4.TabIndex = 3
        '
        'PanelAlarmSetupHistory
        '
        Me.PanelAlarmSetupHistory.Controls.Add(Me.Panel10)
        Me.PanelAlarmSetupHistory.Controls.Add(Me.Panel6)
        Me.PanelAlarmSetupHistory.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelAlarmSetupHistory.Location = New System.Drawing.Point(300, 0)
        Me.PanelAlarmSetupHistory.Name = "PanelAlarmSetupHistory"
        Me.PanelAlarmSetupHistory.Size = New System.Drawing.Size(300, 727)
        Me.PanelAlarmSetupHistory.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 81)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(300, 56)
        Me.Panel10.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Alarm Setup History"
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = Global.GMed_PM01.My.Resources.Resources.logo
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(300, 81)
        Me.Panel6.TabIndex = 4
        '
        'PanelMonitorSetting
        '
        Me.PanelMonitorSetting.Controls.Add(Me.Panel3)
        Me.PanelMonitorSetting.Controls.Add(Me.Panel11)
        Me.PanelMonitorSetting.Controls.Add(Me.Panel7)
        Me.PanelMonitorSetting.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMonitorSetting.Location = New System.Drawing.Point(600, 0)
        Me.PanelMonitorSetting.Name = "PanelMonitorSetting"
        Me.PanelMonitorSetting.Size = New System.Drawing.Size(300, 727)
        Me.PanelMonitorSetting.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_default)
        Me.Panel3.Controls.Add(Me.PanelScreenBrightness)
        Me.Panel3.Controls.Add(Me.btn_screenbrightness)
        Me.Panel3.Controls.Add(Me.btn_parametersetup)
        Me.Panel3.Controls.Add(Me.PanelSound)
        Me.Panel3.Controls.Add(Me.btn_sound)
        Me.Panel3.Controls.Add(Me.PanelColors)
        Me.Panel3.Controls.Add(Me.btn_colors)
        Me.Panel3.Controls.Add(Me.PanelScreensetup)
        Me.Panel3.Controls.Add(Me.btn_screensetup)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 137)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 698)
        Me.Panel3.TabIndex = 7
        '
        'btn_default
        '
        Me.btn_default.Activecolor = System.Drawing.Color.DarkGray
        Me.btn_default.BackColor = System.Drawing.Color.Transparent
        Me.btn_default.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_default.BorderRadius = 0
        Me.btn_default.ButtonText = "Default Setup"
        Me.btn_default.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_default.DisabledColor = System.Drawing.Color.Gray
        Me.btn_default.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_default.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_default.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_default_setup1
        Me.btn_default.Iconimage_right = Nothing
        Me.btn_default.Iconimage_right_Selected = Nothing
        Me.btn_default.Iconimage_Selected = Nothing
        Me.btn_default.IconMarginLeft = 0
        Me.btn_default.IconMarginRight = 0
        Me.btn_default.IconRightVisible = True
        Me.btn_default.IconRightZoom = 50.0R
        Me.btn_default.IconVisible = True
        Me.btn_default.IconZoom = 50.0R
        Me.btn_default.IsTab = True
        Me.btn_default.Location = New System.Drawing.Point(0, 921)
        Me.btn_default.Name = "btn_default"
        Me.btn_default.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_default.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btn_default.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_default.selected = False
        Me.btn_default.Size = New System.Drawing.Size(300, 48)
        Me.btn_default.TabIndex = 9
        Me.btn_default.Text = "Default Setup"
        Me.btn_default.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_default.Textcolor = System.Drawing.Color.Black
        Me.btn_default.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelScreenBrightness
        '
        Me.PanelScreenBrightness.Controls.Add(Me.BunifuTrackbarScreenBrightness)
        Me.PanelScreenBrightness.Controls.Add(Me.LabelScreenBrightness)
        Me.PanelScreenBrightness.Controls.Add(Me.Label8)
        Me.PanelScreenBrightness.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelScreenBrightness.Location = New System.Drawing.Point(0, 840)
        Me.PanelScreenBrightness.Name = "PanelScreenBrightness"
        Me.PanelScreenBrightness.Size = New System.Drawing.Size(300, 81)
        Me.PanelScreenBrightness.TabIndex = 8
        '
        'BunifuTrackbarScreenBrightness
        '
        Me.BunifuTrackbarScreenBrightness.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTrackbarScreenBrightness.BackgroudColor = System.Drawing.Color.DarkGray
        Me.BunifuTrackbarScreenBrightness.BorderRadius = 0
        Me.BunifuTrackbarScreenBrightness.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuTrackbarScreenBrightness.Location = New System.Drawing.Point(55, 38)
        Me.BunifuTrackbarScreenBrightness.MaximumValue = 100
        Me.BunifuTrackbarScreenBrightness.MinimumValue = 0
        Me.BunifuTrackbarScreenBrightness.Name = "BunifuTrackbarScreenBrightness"
        Me.BunifuTrackbarScreenBrightness.Size = New System.Drawing.Size(151, 30)
        Me.BunifuTrackbarScreenBrightness.SliderRadius = 50
        Me.BunifuTrackbarScreenBrightness.TabIndex = 18
        Me.BunifuTrackbarScreenBrightness.Value = 0
        '
        'LabelScreenBrightness
        '
        Me.LabelScreenBrightness.AutoSize = True
        Me.LabelScreenBrightness.Location = New System.Drawing.Point(213, 44)
        Me.LabelScreenBrightness.Name = "LabelScreenBrightness"
        Me.LabelScreenBrightness.Size = New System.Drawing.Size(13, 13)
        Me.LabelScreenBrightness.TabIndex = 3
        Me.LabelScreenBrightness.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Brightness"
        '
        'btn_screenbrightness
        '
        Me.btn_screenbrightness.Activecolor = System.Drawing.Color.DarkGray
        Me.btn_screenbrightness.BackColor = System.Drawing.Color.Transparent
        Me.btn_screenbrightness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_screenbrightness.BorderRadius = 0
        Me.btn_screenbrightness.ButtonText = "Screen Brightness"
        Me.btn_screenbrightness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_screenbrightness.DisabledColor = System.Drawing.Color.Gray
        Me.btn_screenbrightness.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_screenbrightness.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_screenbrightness.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_screen_brightness
        Me.btn_screenbrightness.Iconimage_right = Global.GMed_PM01.My.Resources.Resources.arrow_dropdown
        Me.btn_screenbrightness.Iconimage_right_Selected = Global.GMed_PM01.My.Resources.Resources.arrow_dropdown_activated
        Me.btn_screenbrightness.Iconimage_Selected = Global.GMed_PM01.My.Resources.Resources.arrow_dropdown_activated
        Me.btn_screenbrightness.IconMarginLeft = 0
        Me.btn_screenbrightness.IconMarginRight = 0
        Me.btn_screenbrightness.IconRightVisible = True
        Me.btn_screenbrightness.IconRightZoom = 0R
        Me.btn_screenbrightness.IconVisible = True
        Me.btn_screenbrightness.IconZoom = 50.0R
        Me.btn_screenbrightness.IsTab = False
        Me.btn_screenbrightness.Location = New System.Drawing.Point(0, 792)
        Me.btn_screenbrightness.Name = "btn_screenbrightness"
        Me.btn_screenbrightness.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_screenbrightness.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btn_screenbrightness.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_screenbrightness.selected = False
        Me.btn_screenbrightness.Size = New System.Drawing.Size(300, 48)
        Me.btn_screenbrightness.TabIndex = 7
        Me.btn_screenbrightness.Text = "Screen Brightness"
        Me.btn_screenbrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_screenbrightness.Textcolor = System.Drawing.Color.Black
        Me.btn_screenbrightness.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_parametersetup
        '
        Me.btn_parametersetup.Activecolor = System.Drawing.Color.DarkGray
        Me.btn_parametersetup.BackColor = System.Drawing.Color.Transparent
        Me.btn_parametersetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_parametersetup.BorderRadius = 0
        Me.btn_parametersetup.ButtonText = "Parameter Setup"
        Me.btn_parametersetup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_parametersetup.DisabledColor = System.Drawing.Color.Gray
        Me.btn_parametersetup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_parametersetup.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_parametersetup.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_parameter_setup
        Me.btn_parametersetup.Iconimage_right = Nothing
        Me.btn_parametersetup.Iconimage_right_Selected = Nothing
        Me.btn_parametersetup.Iconimage_Selected = Nothing
        Me.btn_parametersetup.IconMarginLeft = 0
        Me.btn_parametersetup.IconMarginRight = 0
        Me.btn_parametersetup.IconRightVisible = True
        Me.btn_parametersetup.IconRightZoom = 0R
        Me.btn_parametersetup.IconVisible = True
        Me.btn_parametersetup.IconZoom = 50.0R
        Me.btn_parametersetup.IsTab = False
        Me.btn_parametersetup.Location = New System.Drawing.Point(0, 744)
        Me.btn_parametersetup.Name = "btn_parametersetup"
        Me.btn_parametersetup.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_parametersetup.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btn_parametersetup.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_parametersetup.selected = False
        Me.btn_parametersetup.Size = New System.Drawing.Size(300, 48)
        Me.btn_parametersetup.TabIndex = 6
        Me.btn_parametersetup.Text = "Parameter Setup"
        Me.btn_parametersetup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_parametersetup.Textcolor = System.Drawing.Color.Black
        Me.btn_parametersetup.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelSound
        '
        Me.PanelSound.Controls.Add(Me.btn_min_tochscreen)
        Me.PanelSound.Controls.Add(Me.btn_plus_tochscreen)
        Me.PanelSound.Controls.Add(Me.LabelTochscreen)
        Me.PanelSound.Controls.Add(Me.btn_min_hb)
        Me.PanelSound.Controls.Add(Me.tbn_plus_hb)
        Me.PanelSound.Controls.Add(Me.btn_min_alarm)
        Me.PanelSound.Controls.Add(Me.btn_plus_alarm)
        Me.PanelSound.Controls.Add(Me.LabelSoundHeartBeat)
        Me.PanelSound.Controls.Add(Me.LabelSoundAlarm)
        Me.PanelSound.Controls.Add(Me.Label33)
        Me.PanelSound.Controls.Add(Me.Label32)
        Me.PanelSound.Controls.Add(Me.Label17)
        Me.PanelSound.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSound.Location = New System.Drawing.Point(0, 544)
        Me.PanelSound.Name = "PanelSound"
        Me.PanelSound.Size = New System.Drawing.Size(300, 200)
        Me.PanelSound.TabIndex = 5
        '
        'btn_min_tochscreen
        '
        Me.btn_min_tochscreen.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_min_tochscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_min_tochscreen.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_min_tochscreen.Location = New System.Drawing.Point(46, 149)
        Me.btn_min_tochscreen.Name = "btn_min_tochscreen"
        Me.btn_min_tochscreen.Size = New System.Drawing.Size(61, 23)
        Me.btn_min_tochscreen.TabIndex = 24
        Me.btn_min_tochscreen.Text = "-"
        Me.btn_min_tochscreen.UseVisualStyleBackColor = False
        '
        'btn_plus_tochscreen
        '
        Me.btn_plus_tochscreen.Location = New System.Drawing.Point(165, 149)
        Me.btn_plus_tochscreen.Name = "btn_plus_tochscreen"
        Me.btn_plus_tochscreen.Size = New System.Drawing.Size(61, 23)
        Me.btn_plus_tochscreen.TabIndex = 23
        Me.btn_plus_tochscreen.Text = "+"
        Me.btn_plus_tochscreen.UseVisualStyleBackColor = True
        '
        'LabelTochscreen
        '
        Me.LabelTochscreen.AutoSize = True
        Me.LabelTochscreen.Location = New System.Drawing.Point(129, 154)
        Me.LabelTochscreen.Name = "LabelTochscreen"
        Me.LabelTochscreen.Size = New System.Drawing.Size(13, 13)
        Me.LabelTochscreen.TabIndex = 22
        Me.LabelTochscreen.Text = "0"
        '
        'btn_min_hb
        '
        Me.btn_min_hb.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_min_hb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_min_hb.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_min_hb.Location = New System.Drawing.Point(46, 89)
        Me.btn_min_hb.Name = "btn_min_hb"
        Me.btn_min_hb.Size = New System.Drawing.Size(61, 23)
        Me.btn_min_hb.TabIndex = 21
        Me.btn_min_hb.Text = "-"
        Me.btn_min_hb.UseVisualStyleBackColor = False
        '
        'tbn_plus_hb
        '
        Me.tbn_plus_hb.Location = New System.Drawing.Point(165, 89)
        Me.tbn_plus_hb.Name = "tbn_plus_hb"
        Me.tbn_plus_hb.Size = New System.Drawing.Size(61, 23)
        Me.tbn_plus_hb.TabIndex = 20
        Me.tbn_plus_hb.Text = "+"
        Me.tbn_plus_hb.UseVisualStyleBackColor = True
        '
        'btn_min_alarm
        '
        Me.btn_min_alarm.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_min_alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_min_alarm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_min_alarm.Location = New System.Drawing.Point(46, 30)
        Me.btn_min_alarm.Name = "btn_min_alarm"
        Me.btn_min_alarm.Size = New System.Drawing.Size(61, 23)
        Me.btn_min_alarm.TabIndex = 19
        Me.btn_min_alarm.Text = "-"
        Me.btn_min_alarm.UseVisualStyleBackColor = False
        '
        'btn_plus_alarm
        '
        Me.btn_plus_alarm.Location = New System.Drawing.Point(165, 30)
        Me.btn_plus_alarm.Name = "btn_plus_alarm"
        Me.btn_plus_alarm.Size = New System.Drawing.Size(61, 23)
        Me.btn_plus_alarm.TabIndex = 18
        Me.btn_plus_alarm.Text = "+"
        Me.btn_plus_alarm.UseVisualStyleBackColor = True
        '
        'LabelSoundHeartBeat
        '
        Me.LabelSoundHeartBeat.AutoSize = True
        Me.LabelSoundHeartBeat.Location = New System.Drawing.Point(129, 94)
        Me.LabelSoundHeartBeat.Name = "LabelSoundHeartBeat"
        Me.LabelSoundHeartBeat.Size = New System.Drawing.Size(13, 13)
        Me.LabelSoundHeartBeat.TabIndex = 16
        Me.LabelSoundHeartBeat.Text = "0"
        '
        'LabelSoundAlarm
        '
        Me.LabelSoundAlarm.AutoSize = True
        Me.LabelSoundAlarm.Location = New System.Drawing.Point(126, 35)
        Me.LabelSoundAlarm.Name = "LabelSoundAlarm"
        Me.LabelSoundAlarm.Size = New System.Drawing.Size(13, 13)
        Me.LabelSoundAlarm.TabIndex = 13
        Me.LabelSoundAlarm.Text = "0"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(53, 123)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 13)
        Me.Label33.TabIndex = 5
        Me.Label33.Text = "Tochscreen"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(52, 65)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(58, 13)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "Heart Beat"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(52, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Alarms"
        '
        'btn_sound
        '
        Me.btn_sound.Activecolor = System.Drawing.Color.DarkGray
        Me.btn_sound.BackColor = System.Drawing.Color.Transparent
        Me.btn_sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sound.BorderRadius = 0
        Me.btn_sound.ButtonText = "Sound Volume"
        Me.btn_sound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sound.DisabledColor = System.Drawing.Color.Gray
        Me.btn_sound.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_sound.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_sound.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_sound_level
        Me.btn_sound.Iconimage_right = CType(resources.GetObject("btn_sound.Iconimage_right"), System.Drawing.Image)
        Me.btn_sound.Iconimage_right_Selected = CType(resources.GetObject("btn_sound.Iconimage_right_Selected"), System.Drawing.Image)
        Me.btn_sound.Iconimage_Selected = CType(resources.GetObject("btn_sound.Iconimage_Selected"), System.Drawing.Image)
        Me.btn_sound.IconMarginLeft = 0
        Me.btn_sound.IconMarginRight = 0
        Me.btn_sound.IconRightVisible = True
        Me.btn_sound.IconRightZoom = 0R
        Me.btn_sound.IconVisible = True
        Me.btn_sound.IconZoom = 50.0R
        Me.btn_sound.IsTab = False
        Me.btn_sound.Location = New System.Drawing.Point(0, 496)
        Me.btn_sound.Name = "btn_sound"
        Me.btn_sound.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_sound.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btn_sound.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_sound.selected = False
        Me.btn_sound.Size = New System.Drawing.Size(300, 48)
        Me.btn_sound.TabIndex = 4
        Me.btn_sound.Text = "Sound Volume"
        Me.btn_sound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sound.Textcolor = System.Drawing.Color.Black
        Me.btn_sound.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelColors
        '
        Me.PanelColors.Controls.Add(Me.btn_temp_white)
        Me.PanelColors.Controls.Add(Me.btn_resp_white)
        Me.PanelColors.Controls.Add(Me.btn_nibp_white)
        Me.PanelColors.Controls.Add(Me.btn_spo2_white)
        Me.PanelColors.Controls.Add(Me.btn_ecg_white)
        Me.PanelColors.Controls.Add(Me.btn_temp_green)
        Me.PanelColors.Controls.Add(Me.btn_temp_red)
        Me.PanelColors.Controls.Add(Me.btn_temp_yellow)
        Me.PanelColors.Controls.Add(Me.btn_temp_pink)
        Me.PanelColors.Controls.Add(Me.btn_temp_blue)
        Me.PanelColors.Controls.Add(Me.btn_resp_green)
        Me.PanelColors.Controls.Add(Me.btn_resp_red)
        Me.PanelColors.Controls.Add(Me.btn_resp_yellow)
        Me.PanelColors.Controls.Add(Me.btn_resp_pink)
        Me.PanelColors.Controls.Add(Me.btn_resp_blue)
        Me.PanelColors.Controls.Add(Me.btn_nibr_green)
        Me.PanelColors.Controls.Add(Me.btn_nibr_red)
        Me.PanelColors.Controls.Add(Me.btn_nibr_yellow)
        Me.PanelColors.Controls.Add(Me.btn_nibr_pink)
        Me.PanelColors.Controls.Add(Me.btn_nibr_blue)
        Me.PanelColors.Controls.Add(Me.btn_spo2_green)
        Me.PanelColors.Controls.Add(Me.btn_spo2_red)
        Me.PanelColors.Controls.Add(Me.btn_spo2_yellow)
        Me.PanelColors.Controls.Add(Me.btn_spo2_pink)
        Me.PanelColors.Controls.Add(Me.btn_spo2_blue)
        Me.PanelColors.Controls.Add(Me.btn_ecg_green)
        Me.PanelColors.Controls.Add(Me.btn_ecg_red)
        Me.PanelColors.Controls.Add(Me.btn_ecg_yellow)
        Me.PanelColors.Controls.Add(Me.btn_ecg_pink)
        Me.PanelColors.Controls.Add(Me.btn_ecg_blue)
        Me.PanelColors.Controls.Add(Me.Label31)
        Me.PanelColors.Controls.Add(Me.Label30)
        Me.PanelColors.Controls.Add(Me.Label29)
        Me.PanelColors.Controls.Add(Me.Label28)
        Me.PanelColors.Controls.Add(Me.Label27)
        Me.PanelColors.Controls.Add(Me.Label18)
        Me.PanelColors.Controls.Add(Me.Label26)
        Me.PanelColors.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelColors.Location = New System.Drawing.Point(0, 296)
        Me.PanelColors.Name = "PanelColors"
        Me.PanelColors.Size = New System.Drawing.Size(300, 200)
        Me.PanelColors.TabIndex = 3
        '
        'btn_temp_white
        '
        Me.btn_temp_white.BackColor = System.Drawing.Color.White
        Me.btn_temp_white.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_temp_white.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_temp_white.Location = New System.Drawing.Point(103, 155)
        Me.btn_temp_white.Name = "btn_temp_white"
        Me.btn_temp_white.Size = New System.Drawing.Size(17, 15)
        Me.btn_temp_white.TabIndex = 40
        Me.btn_temp_white.UseVisualStyleBackColor = False
        '
        'btn_resp_white
        '
        Me.btn_resp_white.BackColor = System.Drawing.Color.White
        Me.btn_resp_white.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_resp_white.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resp_white.Location = New System.Drawing.Point(103, 129)
        Me.btn_resp_white.Name = "btn_resp_white"
        Me.btn_resp_white.Size = New System.Drawing.Size(17, 15)
        Me.btn_resp_white.TabIndex = 39
        Me.btn_resp_white.UseVisualStyleBackColor = False
        '
        'btn_nibp_white
        '
        Me.btn_nibp_white.BackColor = System.Drawing.Color.White
        Me.btn_nibp_white.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_nibp_white.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nibp_white.Location = New System.Drawing.Point(103, 103)
        Me.btn_nibp_white.Name = "btn_nibp_white"
        Me.btn_nibp_white.Size = New System.Drawing.Size(17, 15)
        Me.btn_nibp_white.TabIndex = 38
        Me.btn_nibp_white.UseVisualStyleBackColor = False
        '
        'btn_spo2_white
        '
        Me.btn_spo2_white.BackColor = System.Drawing.Color.White
        Me.btn_spo2_white.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_spo2_white.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_spo2_white.Location = New System.Drawing.Point(103, 74)
        Me.btn_spo2_white.Name = "btn_spo2_white"
        Me.btn_spo2_white.Size = New System.Drawing.Size(17, 15)
        Me.btn_spo2_white.TabIndex = 37
        Me.btn_spo2_white.UseVisualStyleBackColor = False
        '
        'btn_ecg_white
        '
        Me.btn_ecg_white.BackColor = System.Drawing.Color.White
        Me.btn_ecg_white.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_ecg_white.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ecg_white.Location = New System.Drawing.Point(103, 45)
        Me.btn_ecg_white.Name = "btn_ecg_white"
        Me.btn_ecg_white.Size = New System.Drawing.Size(17, 15)
        Me.btn_ecg_white.TabIndex = 36
        Me.btn_ecg_white.UseVisualStyleBackColor = False
        '
        'btn_temp_green
        '
        Me.btn_temp_green.BackColor = System.Drawing.Color.Lime
        Me.btn_temp_green.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_temp_green.Location = New System.Drawing.Point(216, 155)
        Me.btn_temp_green.Name = "btn_temp_green"
        Me.btn_temp_green.Size = New System.Drawing.Size(17, 15)
        Me.btn_temp_green.TabIndex = 35
        Me.btn_temp_green.UseVisualStyleBackColor = False
        '
        'btn_temp_red
        '
        Me.btn_temp_red.BackColor = System.Drawing.Color.Red
        Me.btn_temp_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_temp_red.Location = New System.Drawing.Point(193, 155)
        Me.btn_temp_red.Name = "btn_temp_red"
        Me.btn_temp_red.Size = New System.Drawing.Size(17, 15)
        Me.btn_temp_red.TabIndex = 34
        Me.btn_temp_red.UseVisualStyleBackColor = False
        '
        'btn_temp_yellow
        '
        Me.btn_temp_yellow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_temp_yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_temp_yellow.Location = New System.Drawing.Point(170, 155)
        Me.btn_temp_yellow.Name = "btn_temp_yellow"
        Me.btn_temp_yellow.Size = New System.Drawing.Size(17, 15)
        Me.btn_temp_yellow.TabIndex = 33
        Me.btn_temp_yellow.UseVisualStyleBackColor = False
        '
        'btn_temp_pink
        '
        Me.btn_temp_pink.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_temp_pink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_temp_pink.Location = New System.Drawing.Point(148, 155)
        Me.btn_temp_pink.Name = "btn_temp_pink"
        Me.btn_temp_pink.Size = New System.Drawing.Size(17, 15)
        Me.btn_temp_pink.TabIndex = 32
        Me.btn_temp_pink.UseVisualStyleBackColor = False
        '
        'btn_temp_blue
        '
        Me.btn_temp_blue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btn_temp_blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_temp_blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_temp_blue.Location = New System.Drawing.Point(125, 155)
        Me.btn_temp_blue.Name = "btn_temp_blue"
        Me.btn_temp_blue.Size = New System.Drawing.Size(17, 15)
        Me.btn_temp_blue.TabIndex = 31
        Me.btn_temp_blue.UseVisualStyleBackColor = False
        '
        'btn_resp_green
        '
        Me.btn_resp_green.BackColor = System.Drawing.Color.Lime
        Me.btn_resp_green.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resp_green.Location = New System.Drawing.Point(216, 129)
        Me.btn_resp_green.Name = "btn_resp_green"
        Me.btn_resp_green.Size = New System.Drawing.Size(17, 15)
        Me.btn_resp_green.TabIndex = 30
        Me.btn_resp_green.UseVisualStyleBackColor = False
        '
        'btn_resp_red
        '
        Me.btn_resp_red.BackColor = System.Drawing.Color.Red
        Me.btn_resp_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resp_red.Location = New System.Drawing.Point(193, 129)
        Me.btn_resp_red.Name = "btn_resp_red"
        Me.btn_resp_red.Size = New System.Drawing.Size(17, 15)
        Me.btn_resp_red.TabIndex = 29
        Me.btn_resp_red.UseVisualStyleBackColor = False
        '
        'btn_resp_yellow
        '
        Me.btn_resp_yellow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_resp_yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resp_yellow.Location = New System.Drawing.Point(170, 129)
        Me.btn_resp_yellow.Name = "btn_resp_yellow"
        Me.btn_resp_yellow.Size = New System.Drawing.Size(17, 15)
        Me.btn_resp_yellow.TabIndex = 28
        Me.btn_resp_yellow.UseVisualStyleBackColor = False
        '
        'btn_resp_pink
        '
        Me.btn_resp_pink.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_resp_pink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resp_pink.Location = New System.Drawing.Point(148, 129)
        Me.btn_resp_pink.Name = "btn_resp_pink"
        Me.btn_resp_pink.Size = New System.Drawing.Size(17, 15)
        Me.btn_resp_pink.TabIndex = 27
        Me.btn_resp_pink.UseVisualStyleBackColor = False
        '
        'btn_resp_blue
        '
        Me.btn_resp_blue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btn_resp_blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_resp_blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resp_blue.Location = New System.Drawing.Point(125, 129)
        Me.btn_resp_blue.Name = "btn_resp_blue"
        Me.btn_resp_blue.Size = New System.Drawing.Size(17, 15)
        Me.btn_resp_blue.TabIndex = 26
        Me.btn_resp_blue.UseVisualStyleBackColor = False
        '
        'btn_nibr_green
        '
        Me.btn_nibr_green.BackColor = System.Drawing.Color.Lime
        Me.btn_nibr_green.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nibr_green.Location = New System.Drawing.Point(216, 103)
        Me.btn_nibr_green.Name = "btn_nibr_green"
        Me.btn_nibr_green.Size = New System.Drawing.Size(17, 15)
        Me.btn_nibr_green.TabIndex = 25
        Me.btn_nibr_green.UseVisualStyleBackColor = False
        '
        'btn_nibr_red
        '
        Me.btn_nibr_red.BackColor = System.Drawing.Color.Red
        Me.btn_nibr_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nibr_red.Location = New System.Drawing.Point(193, 103)
        Me.btn_nibr_red.Name = "btn_nibr_red"
        Me.btn_nibr_red.Size = New System.Drawing.Size(17, 15)
        Me.btn_nibr_red.TabIndex = 24
        Me.btn_nibr_red.UseVisualStyleBackColor = False
        '
        'btn_nibr_yellow
        '
        Me.btn_nibr_yellow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_nibr_yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nibr_yellow.Location = New System.Drawing.Point(170, 103)
        Me.btn_nibr_yellow.Name = "btn_nibr_yellow"
        Me.btn_nibr_yellow.Size = New System.Drawing.Size(17, 15)
        Me.btn_nibr_yellow.TabIndex = 23
        Me.btn_nibr_yellow.UseVisualStyleBackColor = False
        '
        'btn_nibr_pink
        '
        Me.btn_nibr_pink.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_nibr_pink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nibr_pink.Location = New System.Drawing.Point(148, 103)
        Me.btn_nibr_pink.Name = "btn_nibr_pink"
        Me.btn_nibr_pink.Size = New System.Drawing.Size(17, 15)
        Me.btn_nibr_pink.TabIndex = 22
        Me.btn_nibr_pink.UseVisualStyleBackColor = False
        '
        'btn_nibr_blue
        '
        Me.btn_nibr_blue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btn_nibr_blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_nibr_blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nibr_blue.Location = New System.Drawing.Point(125, 103)
        Me.btn_nibr_blue.Name = "btn_nibr_blue"
        Me.btn_nibr_blue.Size = New System.Drawing.Size(17, 15)
        Me.btn_nibr_blue.TabIndex = 21
        Me.btn_nibr_blue.UseVisualStyleBackColor = False
        '
        'btn_spo2_green
        '
        Me.btn_spo2_green.BackColor = System.Drawing.Color.Lime
        Me.btn_spo2_green.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_spo2_green.Location = New System.Drawing.Point(216, 74)
        Me.btn_spo2_green.Name = "btn_spo2_green"
        Me.btn_spo2_green.Size = New System.Drawing.Size(17, 15)
        Me.btn_spo2_green.TabIndex = 20
        Me.btn_spo2_green.UseVisualStyleBackColor = False
        '
        'btn_spo2_red
        '
        Me.btn_spo2_red.BackColor = System.Drawing.Color.Red
        Me.btn_spo2_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_spo2_red.Location = New System.Drawing.Point(193, 74)
        Me.btn_spo2_red.Name = "btn_spo2_red"
        Me.btn_spo2_red.Size = New System.Drawing.Size(17, 15)
        Me.btn_spo2_red.TabIndex = 19
        Me.btn_spo2_red.UseVisualStyleBackColor = False
        '
        'btn_spo2_yellow
        '
        Me.btn_spo2_yellow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_spo2_yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_spo2_yellow.Location = New System.Drawing.Point(170, 74)
        Me.btn_spo2_yellow.Name = "btn_spo2_yellow"
        Me.btn_spo2_yellow.Size = New System.Drawing.Size(17, 15)
        Me.btn_spo2_yellow.TabIndex = 18
        Me.btn_spo2_yellow.UseVisualStyleBackColor = False
        '
        'btn_spo2_pink
        '
        Me.btn_spo2_pink.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_spo2_pink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_spo2_pink.Location = New System.Drawing.Point(148, 74)
        Me.btn_spo2_pink.Name = "btn_spo2_pink"
        Me.btn_spo2_pink.Size = New System.Drawing.Size(17, 15)
        Me.btn_spo2_pink.TabIndex = 17
        Me.btn_spo2_pink.UseVisualStyleBackColor = False
        '
        'btn_spo2_blue
        '
        Me.btn_spo2_blue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btn_spo2_blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_spo2_blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_spo2_blue.Location = New System.Drawing.Point(125, 74)
        Me.btn_spo2_blue.Name = "btn_spo2_blue"
        Me.btn_spo2_blue.Size = New System.Drawing.Size(17, 15)
        Me.btn_spo2_blue.TabIndex = 16
        Me.btn_spo2_blue.UseVisualStyleBackColor = False
        '
        'btn_ecg_green
        '
        Me.btn_ecg_green.BackColor = System.Drawing.Color.Lime
        Me.btn_ecg_green.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ecg_green.Location = New System.Drawing.Point(216, 45)
        Me.btn_ecg_green.Name = "btn_ecg_green"
        Me.btn_ecg_green.Size = New System.Drawing.Size(17, 15)
        Me.btn_ecg_green.TabIndex = 15
        Me.btn_ecg_green.UseVisualStyleBackColor = False
        '
        'btn_ecg_red
        '
        Me.btn_ecg_red.BackColor = System.Drawing.Color.Red
        Me.btn_ecg_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ecg_red.Location = New System.Drawing.Point(193, 45)
        Me.btn_ecg_red.Name = "btn_ecg_red"
        Me.btn_ecg_red.Size = New System.Drawing.Size(17, 15)
        Me.btn_ecg_red.TabIndex = 14
        Me.btn_ecg_red.UseVisualStyleBackColor = False
        '
        'btn_ecg_yellow
        '
        Me.btn_ecg_yellow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ecg_yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ecg_yellow.Location = New System.Drawing.Point(170, 45)
        Me.btn_ecg_yellow.Name = "btn_ecg_yellow"
        Me.btn_ecg_yellow.Size = New System.Drawing.Size(17, 15)
        Me.btn_ecg_yellow.TabIndex = 13
        Me.btn_ecg_yellow.UseVisualStyleBackColor = False
        '
        'btn_ecg_pink
        '
        Me.btn_ecg_pink.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_ecg_pink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ecg_pink.Location = New System.Drawing.Point(148, 45)
        Me.btn_ecg_pink.Name = "btn_ecg_pink"
        Me.btn_ecg_pink.Size = New System.Drawing.Size(17, 15)
        Me.btn_ecg_pink.TabIndex = 12
        Me.btn_ecg_pink.UseVisualStyleBackColor = False
        '
        'btn_ecg_blue
        '
        Me.btn_ecg_blue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btn_ecg_blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_ecg_blue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ecg_blue.Location = New System.Drawing.Point(125, 45)
        Me.btn_ecg_blue.Name = "btn_ecg_blue"
        Me.btn_ecg_blue.Size = New System.Drawing.Size(17, 15)
        Me.btn_ecg_blue.TabIndex = 11
        Me.btn_ecg_blue.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(44, 157)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "Temp"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(44, 130)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(32, 13)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "Resp"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(45, 105)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(32, 13)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "NIBP"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(45, 76)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(35, 13)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "SPO2"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(45, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 13)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "ECG"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(158, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Color"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(43, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 13)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "Indicators"
        '
        'btn_colors
        '
        Me.btn_colors.Activecolor = System.Drawing.Color.DarkGray
        Me.btn_colors.BackColor = System.Drawing.Color.Transparent
        Me.btn_colors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_colors.BorderRadius = 0
        Me.btn_colors.ButtonText = "Colors"
        Me.btn_colors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_colors.DisabledColor = System.Drawing.Color.Gray
        Me.btn_colors.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_colors.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_colors.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_colors
        Me.btn_colors.Iconimage_right = CType(resources.GetObject("btn_colors.Iconimage_right"), System.Drawing.Image)
        Me.btn_colors.Iconimage_right_Selected = CType(resources.GetObject("btn_colors.Iconimage_right_Selected"), System.Drawing.Image)
        Me.btn_colors.Iconimage_Selected = CType(resources.GetObject("btn_colors.Iconimage_Selected"), System.Drawing.Image)
        Me.btn_colors.IconMarginLeft = 0
        Me.btn_colors.IconMarginRight = 0
        Me.btn_colors.IconRightVisible = True
        Me.btn_colors.IconRightZoom = 0R
        Me.btn_colors.IconVisible = True
        Me.btn_colors.IconZoom = 50.0R
        Me.btn_colors.IsTab = False
        Me.btn_colors.Location = New System.Drawing.Point(0, 248)
        Me.btn_colors.Name = "btn_colors"
        Me.btn_colors.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_colors.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btn_colors.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_colors.selected = False
        Me.btn_colors.Size = New System.Drawing.Size(300, 48)
        Me.btn_colors.TabIndex = 2
        Me.btn_colors.Text = "Colors"
        Me.btn_colors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_colors.Textcolor = System.Drawing.Color.Black
        Me.btn_colors.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelScreensetup
        '
        Me.PanelScreensetup.Controls.Add(Me.CheckBox_SPO2)
        Me.PanelScreensetup.Controls.Add(Me.CheckBox_RR)
        Me.PanelScreensetup.Controls.Add(Me.Label19)
        Me.PanelScreensetup.Controls.Add(Me.CheckBox_ECG2)
        Me.PanelScreensetup.Controls.Add(Me.Label25)
        Me.PanelScreensetup.Controls.Add(Me.CheckBox_ECG1)
        Me.PanelScreensetup.Controls.Add(Me.Label21)
        Me.PanelScreensetup.Controls.Add(Me.Label22)
        Me.PanelScreensetup.Controls.Add(Me.Label23)
        Me.PanelScreensetup.Controls.Add(Me.Label24)
        Me.PanelScreensetup.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelScreensetup.Location = New System.Drawing.Point(0, 48)
        Me.PanelScreensetup.Name = "PanelScreensetup"
        Me.PanelScreensetup.Size = New System.Drawing.Size(300, 200)
        Me.PanelScreensetup.TabIndex = 1
        '
        'CheckBox_SPO2
        '
        Me.CheckBox_SPO2.BackColor = System.Drawing.Color.Black
        Me.CheckBox_SPO2.ChechedOffColor = System.Drawing.Color.Black
        Me.CheckBox_SPO2.Checked = True
        Me.CheckBox_SPO2.CheckedOnColor = System.Drawing.Color.Black
        Me.CheckBox_SPO2.ForeColor = System.Drawing.Color.White
        Me.CheckBox_SPO2.Location = New System.Drawing.Point(184, 137)
        Me.CheckBox_SPO2.Name = "CheckBox_SPO2"
        Me.CheckBox_SPO2.Size = New System.Drawing.Size(20, 20)
        Me.CheckBox_SPO2.TabIndex = 15
        '
        'CheckBox_RR
        '
        Me.CheckBox_RR.BackColor = System.Drawing.Color.Black
        Me.CheckBox_RR.ChechedOffColor = System.Drawing.Color.Black
        Me.CheckBox_RR.Checked = True
        Me.CheckBox_RR.CheckedOnColor = System.Drawing.Color.Black
        Me.CheckBox_RR.ForeColor = System.Drawing.Color.White
        Me.CheckBox_RR.Location = New System.Drawing.Point(184, 105)
        Me.CheckBox_RR.Name = "CheckBox_RR"
        Me.CheckBox_RR.Size = New System.Drawing.Size(20, 20)
        Me.CheckBox_RR.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(46, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "SPO2"
        '
        'CheckBox_ECG2
        '
        Me.CheckBox_ECG2.BackColor = System.Drawing.Color.Black
        Me.CheckBox_ECG2.ChechedOffColor = System.Drawing.Color.Black
        Me.CheckBox_ECG2.Checked = True
        Me.CheckBox_ECG2.CheckedOnColor = System.Drawing.Color.Black
        Me.CheckBox_ECG2.ForeColor = System.Drawing.Color.White
        Me.CheckBox_ECG2.Location = New System.Drawing.Point(184, 76)
        Me.CheckBox_ECG2.Name = "CheckBox_ECG2"
        Me.CheckBox_ECG2.Size = New System.Drawing.Size(20, 20)
        Me.CheckBox_ECG2.TabIndex = 12
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(46, 83)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(38, 13)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "ECG 2"
        '
        'CheckBox_ECG1
        '
        Me.CheckBox_ECG1.BackColor = System.Drawing.Color.Black
        Me.CheckBox_ECG1.ChechedOffColor = System.Drawing.Color.Black
        Me.CheckBox_ECG1.Checked = True
        Me.CheckBox_ECG1.CheckedOnColor = System.Drawing.Color.Black
        Me.CheckBox_ECG1.ForeColor = System.Drawing.Color.White
        Me.CheckBox_ECG1.Location = New System.Drawing.Point(184, 40)
        Me.CheckBox_ECG1.Name = "CheckBox_ECG1"
        Me.CheckBox_ECG1.Size = New System.Drawing.Size(20, 20)
        Me.CheckBox_ECG1.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(46, 112)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(23, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "RR"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(46, 47)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 13)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "ECG 1"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(176, 14)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Show"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(44, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Indicators"
        '
        'btn_screensetup
        '
        Me.btn_screensetup.Activecolor = System.Drawing.Color.DarkGray
        Me.btn_screensetup.BackColor = System.Drawing.Color.Transparent
        Me.btn_screensetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_screensetup.BorderRadius = 0
        Me.btn_screensetup.ButtonText = "Screen Setup"
        Me.btn_screensetup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_screensetup.DisabledColor = System.Drawing.Color.Gray
        Me.btn_screensetup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_screensetup.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_screensetup.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_screen_setup
        Me.btn_screensetup.Iconimage_right = CType(resources.GetObject("btn_screensetup.Iconimage_right"), System.Drawing.Image)
        Me.btn_screensetup.Iconimage_right_Selected = CType(resources.GetObject("btn_screensetup.Iconimage_right_Selected"), System.Drawing.Image)
        Me.btn_screensetup.Iconimage_Selected = CType(resources.GetObject("btn_screensetup.Iconimage_Selected"), System.Drawing.Image)
        Me.btn_screensetup.IconMarginLeft = 0
        Me.btn_screensetup.IconMarginRight = 0
        Me.btn_screensetup.IconRightVisible = True
        Me.btn_screensetup.IconRightZoom = 0R
        Me.btn_screensetup.IconVisible = True
        Me.btn_screensetup.IconZoom = 50.0R
        Me.btn_screensetup.IsTab = False
        Me.btn_screensetup.Location = New System.Drawing.Point(0, 0)
        Me.btn_screensetup.Name = "btn_screensetup"
        Me.btn_screensetup.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_screensetup.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btn_screensetup.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_screensetup.selected = False
        Me.btn_screensetup.Size = New System.Drawing.Size(300, 48)
        Me.btn_screensetup.TabIndex = 0
        Me.btn_screensetup.Text = "Screen Setup"
        Me.btn_screensetup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_screensetup.Textcolor = System.Drawing.Color.Black
        Me.btn_screensetup.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label2)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 81)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(300, 56)
        Me.Panel11.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monitor Setting"
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = Global.GMed_PM01.My.Resources.Resources.logo
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(300, 81)
        Me.Panel7.TabIndex = 4
        '
        'PanelPatientData
        '
        Me.PanelPatientData.Controls.Add(Me.btn_view_patient)
        Me.PanelPatientData.Controls.Add(Me.btn_add_patient)
        Me.PanelPatientData.Controls.Add(Me.Panel12)
        Me.PanelPatientData.Controls.Add(Me.Panel8)
        Me.PanelPatientData.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelPatientData.Location = New System.Drawing.Point(900, 0)
        Me.PanelPatientData.Name = "PanelPatientData"
        Me.PanelPatientData.Size = New System.Drawing.Size(300, 727)
        Me.PanelPatientData.TabIndex = 6
        '
        'btn_view_patient
        '
        Me.btn_view_patient.Activecolor = System.Drawing.Color.DarkGray
        Me.btn_view_patient.BackColor = System.Drawing.Color.Transparent
        Me.btn_view_patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_view_patient.BorderRadius = 0
        Me.btn_view_patient.ButtonText = "View Patient"
        Me.btn_view_patient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_view_patient.DisabledColor = System.Drawing.Color.Gray
        Me.btn_view_patient.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_view_patient.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_view_patient.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_view_patient
        Me.btn_view_patient.Iconimage_right = Nothing
        Me.btn_view_patient.Iconimage_right_Selected = Nothing
        Me.btn_view_patient.Iconimage_Selected = Nothing
        Me.btn_view_patient.IconMarginLeft = 0
        Me.btn_view_patient.IconMarginRight = 0
        Me.btn_view_patient.IconRightVisible = True
        Me.btn_view_patient.IconRightZoom = 0R
        Me.btn_view_patient.IconVisible = True
        Me.btn_view_patient.IconZoom = 50.0R
        Me.btn_view_patient.IsTab = False
        Me.btn_view_patient.Location = New System.Drawing.Point(0, 185)
        Me.btn_view_patient.Name = "btn_view_patient"
        Me.btn_view_patient.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_view_patient.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btn_view_patient.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_view_patient.selected = False
        Me.btn_view_patient.Size = New System.Drawing.Size(300, 48)
        Me.btn_view_patient.TabIndex = 8
        Me.btn_view_patient.Text = "View Patient"
        Me.btn_view_patient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_view_patient.Textcolor = System.Drawing.Color.Black
        Me.btn_view_patient.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_add_patient
        '
        Me.btn_add_patient.Activecolor = System.Drawing.Color.DarkGray
        Me.btn_add_patient.BackColor = System.Drawing.Color.Transparent
        Me.btn_add_patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add_patient.BorderRadius = 0
        Me.btn_add_patient.ButtonText = "Add Patient"
        Me.btn_add_patient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_patient.DisabledColor = System.Drawing.Color.Gray
        Me.btn_add_patient.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_add_patient.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_add_patient.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_add_patient
        Me.btn_add_patient.Iconimage_right = Nothing
        Me.btn_add_patient.Iconimage_right_Selected = Nothing
        Me.btn_add_patient.Iconimage_Selected = Nothing
        Me.btn_add_patient.IconMarginLeft = 0
        Me.btn_add_patient.IconMarginRight = 0
        Me.btn_add_patient.IconRightVisible = True
        Me.btn_add_patient.IconRightZoom = 0R
        Me.btn_add_patient.IconVisible = True
        Me.btn_add_patient.IconZoom = 50.0R
        Me.btn_add_patient.IsTab = False
        Me.btn_add_patient.Location = New System.Drawing.Point(0, 137)
        Me.btn_add_patient.Name = "btn_add_patient"
        Me.btn_add_patient.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_add_patient.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btn_add_patient.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_add_patient.selected = False
        Me.btn_add_patient.Size = New System.Drawing.Size(300, 48)
        Me.btn_add_patient.TabIndex = 7
        Me.btn_add_patient.Text = "Add Patient"
        Me.btn_add_patient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_add_patient.Textcolor = System.Drawing.Color.Black
        Me.btn_add_patient.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Label4)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 81)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(300, 56)
        Me.Panel12.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Patient Data"
        '
        'Panel8
        '
        Me.Panel8.BackgroundImage = Global.GMed_PM01.My.Resources.Resources.logo
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(300, 81)
        Me.Panel8.TabIndex = 4
        '
        'PanelNIBP
        '
        Me.PanelNIBP.Controls.Add(Me.Panel16)
        Me.PanelNIBP.Controls.Add(Me.BunifuFlatButton7)
        Me.PanelNIBP.Controls.Add(Me.Panel15)
        Me.PanelNIBP.Controls.Add(Me.BunifuFlatButton6)
        Me.PanelNIBP.Controls.Add(Me.Panel13)
        Me.PanelNIBP.Controls.Add(Me.Panel9)
        Me.PanelNIBP.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelNIBP.Location = New System.Drawing.Point(1200, 0)
        Me.PanelNIBP.Name = "PanelNIBP"
        Me.PanelNIBP.Size = New System.Drawing.Size(300, 727)
        Me.PanelNIBP.TabIndex = 7
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.btn_start_auto)
        Me.Panel16.Controls.Add(Me.btn_stop_auto)
        Me.Panel16.Controls.Add(Me.BunifuDropdownPatientType)
        Me.Panel16.Controls.Add(Me.Label7)
        Me.Panel16.Controls.Add(Me.BunifuDropdownDuration)
        Me.Panel16.Controls.Add(Me.Label6)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 322)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(300, 207)
        Me.Panel16.TabIndex = 11
        '
        'btn_start_auto
        '
        Me.btn_start_auto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_start_auto.Location = New System.Drawing.Point(42, 162)
        Me.btn_start_auto.Name = "btn_start_auto"
        Me.btn_start_auto.Size = New System.Drawing.Size(75, 23)
        Me.btn_start_auto.TabIndex = 12
        Me.btn_start_auto.Text = "Start"
        Me.btn_start_auto.UseVisualStyleBackColor = True
        '
        'btn_stop_auto
        '
        Me.btn_stop_auto.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_stop_auto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_stop_auto.ForeColor = System.Drawing.Color.White
        Me.btn_stop_auto.Location = New System.Drawing.Point(123, 161)
        Me.btn_stop_auto.Name = "btn_stop_auto"
        Me.btn_stop_auto.Size = New System.Drawing.Size(75, 23)
        Me.btn_stop_auto.TabIndex = 13
        Me.btn_stop_auto.Text = "Stop"
        Me.btn_stop_auto.UseVisualStyleBackColor = False
        '
        'BunifuDropdownPatientType
        '
        Me.BunifuDropdownPatientType.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdownPatientType.BorderRadius = 3
        Me.BunifuDropdownPatientType.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdownPatientType.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdownPatientType.Items = New String() {"Adult ", "Child", "New Born"}
        Me.BunifuDropdownPatientType.Location = New System.Drawing.Point(39, 106)
        Me.BunifuDropdownPatientType.Name = "BunifuDropdownPatientType"
        Me.BunifuDropdownPatientType.NomalColor = System.Drawing.Color.Transparent
        Me.BunifuDropdownPatientType.onHoverColor = System.Drawing.Color.Silver
        Me.BunifuDropdownPatientType.selectedIndex = 0
        Me.BunifuDropdownPatientType.Size = New System.Drawing.Size(174, 35)
        Me.BunifuDropdownPatientType.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Patient Type"
        '
        'BunifuDropdownDuration
        '
        Me.BunifuDropdownDuration.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdownDuration.BorderRadius = 3
        Me.BunifuDropdownDuration.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdownDuration.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdownDuration.Items = New String() {"1 Minute", "2 Minute", "3 Minute", "4 Minute", "5 Minute", "10 Minute", "20 Minute", "30 Minute", "1 Hours", "2 Hours", "3 Hours", "4 Hours", "5 Hours"}
        Me.BunifuDropdownDuration.Location = New System.Drawing.Point(36, 32)
        Me.BunifuDropdownDuration.Name = "BunifuDropdownDuration"
        Me.BunifuDropdownDuration.NomalColor = System.Drawing.Color.Transparent
        Me.BunifuDropdownDuration.onHoverColor = System.Drawing.Color.Silver
        Me.BunifuDropdownDuration.selectedIndex = 0
        Me.BunifuDropdownDuration.Size = New System.Drawing.Size(174, 35)
        Me.BunifuDropdownDuration.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Duration"
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.DarkGray
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "Auto"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_auto_activated
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 50.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(0, 274)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(300, 48)
        Me.BunifuFlatButton7.TabIndex = 10
        Me.BunifuFlatButton7.Text = "Auto"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.btn_stop_manual)
        Me.Panel15.Controls.Add(Me.btn_start_manual)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 185)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(300, 89)
        Me.Panel15.TabIndex = 9
        '
        'btn_stop_manual
        '
        Me.btn_stop_manual.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_stop_manual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_stop_manual.ForeColor = System.Drawing.Color.White
        Me.btn_stop_manual.Location = New System.Drawing.Point(123, 25)
        Me.btn_stop_manual.Name = "btn_stop_manual"
        Me.btn_stop_manual.Size = New System.Drawing.Size(75, 23)
        Me.btn_stop_manual.TabIndex = 1
        Me.btn_stop_manual.Text = "Stop"
        Me.btn_stop_manual.UseVisualStyleBackColor = False
        '
        'btn_start_manual
        '
        Me.btn_start_manual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_start_manual.Location = New System.Drawing.Point(42, 25)
        Me.btn_start_manual.Name = "btn_start_manual"
        Me.btn_start_manual.Size = New System.Drawing.Size(75, 23)
        Me.btn_start_manual.TabIndex = 0
        Me.btn_start_manual.Text = "Start"
        Me.btn_start_manual.UseVisualStyleBackColor = True
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.DarkGray
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "Manual"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = Global.GMed_PM01.My.Resources.Resources.sidebar_manual_activated
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 50.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(0, 137)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(300, 48)
        Me.BunifuFlatButton6.TabIndex = 8
        Me.BunifuFlatButton6.Text = "Manual"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Label5)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 81)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(300, 56)
        Me.Panel13.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "NIBP"
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = Global.GMed_PM01.My.Resources.Resources.logo
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(300, 81)
        Me.Panel9.TabIndex = 4
        '
        'btn_lamp_min
        '
        Me.btn_lamp_min.Location = New System.Drawing.Point(84, 44)
        Me.btn_lamp_min.Name = "btn_lamp_min"
        Me.btn_lamp_min.Size = New System.Drawing.Size(22, 23)
        Me.btn_lamp_min.TabIndex = 55
        Me.btn_lamp_min.Text = "-"
        Me.btn_lamp_min.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_lamp_min.UseVisualStyleBackColor = True
        '
        'btn_lamp_plus
        '
        Me.btn_lamp_plus.Location = New System.Drawing.Point(153, 44)
        Me.btn_lamp_plus.Name = "btn_lamp_plus"
        Me.btn_lamp_plus.Size = New System.Drawing.Size(22, 23)
        Me.btn_lamp_plus.TabIndex = 54
        Me.btn_lamp_plus.Text = "+"
        Me.btn_lamp_plus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_lamp_plus.UseVisualStyleBackColor = True
        '
        'Mdi
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.PanelNIBP)
        Me.Controls.Add(Me.PanelPatientData)
        Me.Controls.Add(Me.PanelMonitorSetting)
        Me.Controls.Add(Me.PanelAlarmSetupHistory)
        Me.Controls.Add(Me.PanelAlarmSetup)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mdi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mdi"
        Me.Panel2.ResumeLayout(False)
        Me.PanelAlarmSetup.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelSoundLevel.ResumeLayout(False)
        Me.PanelSoundLevel.PerformLayout()
        Me.PanelLampBrightness.ResumeLayout(False)
        Me.PanelLampBrightness.PerformLayout()
        Me.PanelAlarmLimits.ResumeLayout(False)
        Me.PanelAlarmLimits.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PanelAlarmSetupHistory.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.PanelMonitorSetting.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelScreenBrightness.ResumeLayout(False)
        Me.PanelScreenBrightness.PerformLayout()
        Me.PanelSound.ResumeLayout(False)
        Me.PanelSound.PerformLayout()
        Me.PanelColors.ResumeLayout(False)
        Me.PanelColors.PerformLayout()
        Me.PanelScreensetup.ResumeLayout(False)
        Me.PanelScreensetup.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.PanelPatientData.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.PanelNIBP.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelAlarmSetup As Panel
    Friend WithEvents PanelAlarmSetupHistory As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelMonitorSetting As Panel
    Friend WithEvents PanelPatientData As Panel
    Friend WithEvents PanelNIBP As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelSound As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_sound As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelColors As Panel
    Friend WithEvents btn_colors As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelScreensetup As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btn_screensetup As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents CheckBox_SPO2 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents CheckBox_RR As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label19 As Label
    Friend WithEvents CheckBox_ECG2 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label25 As Label
    Friend WithEvents CheckBox_ECG1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelSoundLevel As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_soundlevel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelLampBrightness As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents btn_lampbrightness As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelAlarmLimits As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_alarmlimits As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btn_default As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelScreenBrightness As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_screenbrightness As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_parametersetup As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btn_view_patient As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_add_patient As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel16 As Panel
    Friend WithEvents BunifuDropdownPatientType As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label7 As Label
    Friend WithEvents BunifuDropdownDuration As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel15 As Panel
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_start_auto As Button
    Friend WithEvents btn_stop_auto As Button
    Friend WithEvents btn_stop_manual As Button
    Friend WithEvents btn_start_manual As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_temp_green As Button
    Friend WithEvents btn_temp_red As Button
    Friend WithEvents btn_temp_yellow As Button
    Friend WithEvents btn_temp_pink As Button
    Friend WithEvents btn_temp_blue As Button
    Friend WithEvents btn_resp_green As Button
    Friend WithEvents btn_resp_red As Button
    Friend WithEvents btn_resp_yellow As Button
    Friend WithEvents btn_resp_pink As Button
    Friend WithEvents btn_resp_blue As Button
    Friend WithEvents btn_nibr_green As Button
    Friend WithEvents btn_nibr_red As Button
    Friend WithEvents btn_nibr_yellow As Button
    Friend WithEvents btn_nibr_pink As Button
    Friend WithEvents btn_nibr_blue As Button
    Friend WithEvents btn_spo2_green As Button
    Friend WithEvents btn_spo2_red As Button
    Friend WithEvents btn_spo2_yellow As Button
    Friend WithEvents btn_spo2_pink As Button
    Friend WithEvents btn_spo2_blue As Button
    Friend WithEvents btn_ecg_green As Button
    Friend WithEvents btn_ecg_red As Button
    Friend WithEvents btn_ecg_yellow As Button
    Friend WithEvents btn_ecg_pink As Button
    Friend WithEvents btn_ecg_blue As Button
    Friend WithEvents btn_temp_white As Button
    Friend WithEvents btn_resp_white As Button
    Friend WithEvents btn_nibp_white As Button
    Friend WithEvents btn_spo2_white As Button
    Friend WithEvents btn_ecg_white As Button
    Friend WithEvents ButtonUP As Button
    Friend WithEvents ButtonDown As Button
    Friend WithEvents LabelBrightnessLed As Label
    Friend WithEvents LabelScreenBrightness As Label
    Friend WithEvents BunifuTrackbarScreenBrightness As Bunifu.Framework.UI.BunifuTrackbar
    Friend WithEvents LabelSoundHeartBeat As Label
    Friend WithEvents LabelSoundAlarm As Label
    Friend WithEvents btn_save_bright_led As Button
    Friend WithEvents btn_default_led As Button
    Friend WithEvents btn_min_alarm As Button
    Friend WithEvents btn_plus_alarm As Button
    Friend WithEvents btn_min_hb As Button
    Friend WithEvents tbn_plus_hb As Button
    Friend WithEvents btn_min_tochscreen As Button
    Friend WithEvents btn_plus_tochscreen As Button
    Friend WithEvents LabelTochscreen As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents btn_max_rr_min As Button
    Friend WithEvents btn_max_rr_plus As Button
    Friend WithEvents btn_min_rr_min As Button
    Friend WithEvents btn_min_rr_plus As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents btn_max_nibp_min As Button
    Friend WithEvents btn_max_nibp_plus As Button
    Friend WithEvents btn_min_nibp_min As Button
    Friend WithEvents btn_min_nibp_plus As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents btn_max_spo2_min As Button
    Friend WithEvents btn_max_spo2_plus As Button
    Friend WithEvents btn_min_spo2_min As Button
    Friend WithEvents btn_min_spo2_plus As Button
    Friend WithEvents btn_max_ecg_min As Button
    Friend WithEvents btn_max_ecg_plus As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents btn_min_ecg_min As Button
    Friend WithEvents btn_min_ecg_plus As Button
    Friend WithEvents TextBoxRRMax As TextBox
    Friend WithEvents TextBoxRRMin As TextBox
    Friend WithEvents TextBoxNIBPMax As TextBox
    Friend WithEvents TextBoxNIBPMin As TextBox
    Friend WithEvents TextBoxSPO2Max As TextBox
    Friend WithEvents TextBoxSPO2Min As TextBox
    Friend WithEvents TextBoxECGMax As TextBox
    Friend WithEvents TextBoxECGMin As TextBox
    Friend WithEvents btn_default_alarm As Button
    Friend WithEvents btn_lamp_min As Button
    Friend WithEvents btn_lamp_plus As Button
End Class
