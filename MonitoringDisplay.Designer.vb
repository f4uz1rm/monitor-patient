<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonitoringDisplay
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TimerRandom = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.muitemp2 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.muitd = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.muitemp1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.sysdys = New System.Windows.Forms.Label()
        Me.PanelECG1 = New System.Windows.Forms.Panel()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ecghr = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.pi1 = New System.Windows.Forms.Label()
        Me.bprm1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.muispo2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ecgrr = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PanelECG2 = New System.Windows.Forms.Panel()
        Me.Chart5 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Chart6 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PanelRR = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PanelSPO2 = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelECG1.SuspendLayout()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PanelECG2.SuspendLayout()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRR.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSPO2.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(818, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "01-01-2021   00:00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Patient Name : John Doe | Adult"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'Timer5
        '
        Me.Timer5.Interval = 1
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_nibp
        Me.Button6.Location = New System.Drawing.Point(839, 709)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(170, 60)
        Me.Button6.TabIndex = 5
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_patient_data
        Me.Button5.Location = New System.Drawing.Point(676, 709)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(170, 60)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_monitor_setting
        Me.Button4.Location = New System.Drawing.Point(506, 709)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 60)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_alarm_history
        Me.Button3.Location = New System.Drawing.Point(337, 709)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 60)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_alarm_setup
        Me.Button2.Location = New System.Drawing.Point(167, 709)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 60)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.GMed_PM01.My.Resources.Resources.taskbar_home_activated
        Me.Button1.Location = New System.Drawing.Point(-1, 709)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(346, 9)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(146, 27)
        Me.Button7.TabIndex = 54
        Me.Button7.Text = "BATTERY FAILURE"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(498, 9)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(146, 27)
        Me.Button8.TabIndex = 55
        Me.Button8.Text = "SPO2 LOW"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = System.Drawing.Color.Red
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(650, 9)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(146, 27)
        Me.Button9.TabIndex = 56
        Me.Button9.Text = "ECG HIGH"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'TimerRandom
        '
        Me.TimerRandom.Enabled = True
        Me.TimerRandom.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.PanelECG1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 823)
        Me.Panel1.TabIndex = 57
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PanelRR)
        Me.Panel5.Controls.Add(Me.PanelSPO2)
        Me.Panel5.Controls.Add(Me.PanelECG2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 181)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(699, 518)
        Me.Panel5.TabIndex = 3
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(187, 147)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(25, 17)
        Me.Label29.TabIndex = 52
        Me.Label29.Text = "T2"
        '
        'muitemp2
        '
        Me.muitemp2.AutoSize = True
        Me.muitemp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.muitemp2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.muitemp2.Location = New System.Drawing.Point(217, 132)
        Me.muitemp2.Name = "muitemp2"
        Me.muitemp2.Size = New System.Drawing.Size(34, 31)
        Me.muitemp2.TabIndex = 51
        Me.muitemp2.Text = "--"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(77, 187)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(27, 17)
        Me.Label28.TabIndex = 50
        Me.Label28.Text = "TD"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(79, 144)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(25, 17)
        Me.Label27.TabIndex = 49
        Me.Label27.Text = "T1"
        '
        'muitd
        '
        Me.muitd.AutoSize = True
        Me.muitd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.muitd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.muitd.Location = New System.Drawing.Point(105, 170)
        Me.muitd.Name = "muitd"
        Me.muitd.Size = New System.Drawing.Size(34, 31)
        Me.muitd.TabIndex = 48
        Me.muitd.Text = "--"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(33, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 17)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "30"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(33, 141)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 17)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "40"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(33, 124)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(23, 17)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "°C"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(19, 98)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(135, 25)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "Temperature"
        '
        'muitemp1
        '
        Me.muitemp1.AutoSize = True
        Me.muitemp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.muitemp1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.muitemp1.Location = New System.Drawing.Point(105, 129)
        Me.muitemp1.Name = "muitemp1"
        Me.muitemp1.Size = New System.Drawing.Size(34, 31)
        Me.muitemp1.TabIndex = 43
        Me.muitemp1.Text = "--"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(21, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 17)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "dys"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(21, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 17)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "sys"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(21, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 17)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "mmHg"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(19, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 25)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "NIBP"
        '
        'sysdys
        '
        Me.sysdys.AutoSize = True
        Me.sysdys.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold)
        Me.sysdys.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.sysdys.Location = New System.Drawing.Point(89, 29)
        Me.sysdys.Name = "sysdys"
        Me.sysdys.Size = New System.Drawing.Size(138, 63)
        Me.sysdys.TabIndex = 38
        Me.sysdys.Text = "---/--"
        '
        'PanelECG1
        '
        Me.PanelECG1.Controls.Add(Me.Chart4)
        Me.PanelECG1.Controls.Add(Me.Label30)
        Me.PanelECG1.Controls.Add(Me.Label26)
        Me.PanelECG1.Controls.Add(Me.Label25)
        Me.PanelECG1.Controls.Add(Me.Chart3)
        Me.PanelECG1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelECG1.Location = New System.Drawing.Point(0, 0)
        Me.PanelECG1.Name = "PanelECG1"
        Me.PanelECG1.Size = New System.Drawing.Size(699, 181)
        Me.PanelECG1.TabIndex = 0
        '
        'Chart4
        '
        Me.Chart4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea7.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea7.BorderColor = System.Drawing.Color.Transparent
        ChartArea7.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea7)
        Me.Chart4.IsSoftShadows = False
        Me.Chart4.Location = New System.Drawing.Point(81, 136)
        Me.Chart4.Name = "Chart4"
        Me.Chart4.Size = New System.Drawing.Size(615, 109)
        Me.Chart4.TabIndex = 61
        Me.Chart4.Text = "Chart1"
        '
        'Label30
        '
        Me.Label30.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label30.ForeColor = System.Drawing.Color.Lime
        Me.Label30.Location = New System.Drawing.Point(78, 118)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 17)
        Me.Label30.TabIndex = 59
        Me.Label30.Text = "Lead II"
        '
        'Label26
        '
        Me.Label26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label26.ForeColor = System.Drawing.Color.Lime
        Me.Label26.Location = New System.Drawing.Point(78, 42)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 17)
        Me.Label26.TabIndex = 58
        Me.Label26.Text = "Lead I"
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.Lime
        Me.Label25.Location = New System.Drawing.Point(28, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 25)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "ECG I"
        '
        'Chart3
        '
        Me.Chart3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea8.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea8.BorderColor = System.Drawing.Color.Transparent
        ChartArea8.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea8)
        Me.Chart3.IsSoftShadows = False
        Me.Chart3.Location = New System.Drawing.Point(81, 9)
        Me.Chart3.Name = "Chart3"
        Me.Chart3.Size = New System.Drawing.Size(615, 106)
        Me.Chart3.TabIndex = 60
        Me.Chart3.Text = "Chart1"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.ecghr)
        Me.Panel2.Location = New System.Drawing.Point(713, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(299, 157)
        Me.Panel2.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Lime
        Me.Label12.Location = New System.Drawing.Point(17, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 17)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "60"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(17, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 17)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "120"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Lime
        Me.Label15.Location = New System.Drawing.Point(12, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 25)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "ECG"
        '
        'ecghr
        '
        Me.ecghr.AutoSize = True
        Me.ecghr.Font = New System.Drawing.Font("Nirmala UI", 80.0!, System.Drawing.FontStyle.Bold)
        Me.ecghr.ForeColor = System.Drawing.Color.Lime
        Me.ecghr.Location = New System.Drawing.Point(61, 8)
        Me.ecghr.Name = "ecghr"
        Me.ecghr.Size = New System.Drawing.Size(146, 142)
        Me.ecghr.TabIndex = 57
        Me.ecghr.Text = "--"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.Label33)
        Me.Panel3.Controls.Add(Me.Label34)
        Me.Panel3.Controls.Add(Me.pi1)
        Me.Panel3.Controls.Add(Me.bprm1)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.muispo2)
        Me.Panel3.Location = New System.Drawing.Point(713, 189)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(296, 171)
        Me.Panel3.TabIndex = 63
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(247, 99)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(20, 17)
        Me.Label33.TabIndex = 70
        Me.Label33.Text = "%"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(247, 32)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(40, 17)
        Me.Label34.TabIndex = 69
        Me.Label34.Text = "bprm"
        '
        'pi1
        '
        Me.pi1.AutoSize = True
        Me.pi1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold)
        Me.pi1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pi1.Location = New System.Drawing.Point(246, 117)
        Me.pi1.Name = "pi1"
        Me.pi1.Size = New System.Drawing.Size(33, 30)
        Me.pi1.TabIndex = 68
        Me.pi1.Text = "--"
        '
        'bprm1
        '
        Me.bprm1.AutoSize = True
        Me.bprm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold)
        Me.bprm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bprm1.Location = New System.Drawing.Point(245, 52)
        Me.bprm1.Name = "bprm1"
        Me.bprm1.Size = New System.Drawing.Size(33, 30)
        Me.bprm1.TabIndex = 67
        Me.bprm1.Text = "--"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(26, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 17)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "--"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(26, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 17)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "--"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 17)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "SpO2"
        '
        'muispo2
        '
        Me.muispo2.AutoSize = True
        Me.muispo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold)
        Me.muispo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.muispo2.Location = New System.Drawing.Point(69, 49)
        Me.muispo2.Name = "muispo2"
        Me.muispo2.Size = New System.Drawing.Size(95, 91)
        Me.muispo2.TabIndex = 62
        Me.muispo2.Text = "--"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.ecgrr)
        Me.Panel4.Location = New System.Drawing.Point(710, 366)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(302, 111)
        Me.Panel4.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(19, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 17)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "60"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(16, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 17)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "100"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(16, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "bpm"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Lime
        Me.Label10.Location = New System.Drawing.Point(14, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 25)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "RR"
        '
        'ecgrr
        '
        Me.ecgrr.AutoSize = True
        Me.ecgrr.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold)
        Me.ecgrr.ForeColor = System.Drawing.Color.Lime
        Me.ecgrr.Location = New System.Drawing.Point(72, -4)
        Me.ecgrr.Name = "ecgrr"
        Me.ecgrr.Size = New System.Drawing.Size(95, 91)
        Me.ecgrr.TabIndex = 57
        Me.ecgrr.Text = "--"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.Label29)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.muitemp2)
        Me.Panel6.Controls.Add(Me.sysdys)
        Me.Panel6.Controls.Add(Me.Label28)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label27)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.muitd)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.muitemp1)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Controls.Add(Me.Label24)
        Me.Panel6.Controls.Add(Me.Label23)
        Me.Panel6.Location = New System.Drawing.Point(710, 487)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(302, 216)
        Me.Panel6.TabIndex = 65
        '
        'PanelECG2
        '
        Me.PanelECG2.Controls.Add(Me.Chart5)
        Me.PanelECG2.Controls.Add(Me.Label21)
        Me.PanelECG2.Controls.Add(Me.Label35)
        Me.PanelECG2.Controls.Add(Me.Label36)
        Me.PanelECG2.Controls.Add(Me.Chart6)
        Me.PanelECG2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelECG2.Location = New System.Drawing.Point(0, 0)
        Me.PanelECG2.Name = "PanelECG2"
        Me.PanelECG2.Size = New System.Drawing.Size(699, 181)
        Me.PanelECG2.TabIndex = 1
        '
        'Chart5
        '
        Me.Chart5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea9.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea9.BorderColor = System.Drawing.Color.Transparent
        ChartArea9.Name = "ChartArea1"
        Me.Chart5.ChartAreas.Add(ChartArea9)
        Me.Chart5.IsSoftShadows = False
        Me.Chart5.Location = New System.Drawing.Point(81, 136)
        Me.Chart5.Name = "Chart5"
        Me.Chart5.Size = New System.Drawing.Size(615, 109)
        Me.Chart5.TabIndex = 61
        Me.Chart5.Text = "Chart1"
        '
        'Label21
        '
        Me.Label21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label21.ForeColor = System.Drawing.Color.Lime
        Me.Label21.Location = New System.Drawing.Point(78, 118)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 17)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "Lead II"
        '
        'Label35
        '
        Me.Label35.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label35.ForeColor = System.Drawing.Color.Lime
        Me.Label35.Location = New System.Drawing.Point(78, 42)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(47, 17)
        Me.Label35.TabIndex = 58
        Me.Label35.Text = "Lead I"
        '
        'Label36
        '
        Me.Label36.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label36.ForeColor = System.Drawing.Color.Lime
        Me.Label36.Location = New System.Drawing.Point(28, 17)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(76, 25)
        Me.Label36.TabIndex = 57
        Me.Label36.Text = "ECG II"
        '
        'Chart6
        '
        Me.Chart6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart6.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea10.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea10.BorderColor = System.Drawing.Color.Transparent
        ChartArea10.Name = "ChartArea1"
        Me.Chart6.ChartAreas.Add(ChartArea10)
        Me.Chart6.IsSoftShadows = False
        Me.Chart6.Location = New System.Drawing.Point(81, 9)
        Me.Chart6.Name = "Chart6"
        Me.Chart6.Size = New System.Drawing.Size(615, 106)
        Me.Chart6.TabIndex = 60
        Me.Chart6.Text = "Chart1"
        '
        'PanelRR
        '
        Me.PanelRR.Controls.Add(Me.Label11)
        Me.PanelRR.Controls.Add(Me.Label16)
        Me.PanelRR.Controls.Add(Me.Chart1)
        Me.PanelRR.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRR.Location = New System.Drawing.Point(0, 306)
        Me.PanelRR.Name = "PanelRR"
        Me.PanelRR.Size = New System.Drawing.Size(699, 141)
        Me.PanelRR.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Lime
        Me.Label11.Location = New System.Drawing.Point(63, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 17)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "bpm"
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Lime
        Me.Label16.Location = New System.Drawing.Point(31, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 25)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "RR"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea11.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea11.BorderColor = System.Drawing.Color.Transparent
        ChartArea11.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea11)
        Me.Chart1.IsSoftShadows = False
        Me.Chart1.Location = New System.Drawing.Point(81, -1)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(615, 140)
        Me.Chart1.TabIndex = 59
        Me.Chart1.Text = "Chart1"
        '
        'PanelSPO2
        '
        Me.PanelSPO2.Controls.Add(Me.Label32)
        Me.PanelSPO2.Controls.Add(Me.Label31)
        Me.PanelSPO2.Controls.Add(Me.Chart2)
        Me.PanelSPO2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSPO2.Location = New System.Drawing.Point(0, 181)
        Me.PanelSPO2.Name = "PanelSPO2"
        Me.PanelSPO2.Size = New System.Drawing.Size(699, 125)
        Me.PanelSPO2.TabIndex = 3
        '
        'Label32
        '
        Me.Label32.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(78, 56)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(20, 17)
        Me.Label32.TabIndex = 57
        Me.Label32.Text = "%"
        '
        'Label31
        '
        Me.Label31.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(30, 22)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(68, 25)
        Me.Label31.TabIndex = 56
        Me.Label31.Text = "SpO2"
        '
        'Chart2
        '
        Me.Chart2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea12.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea12.BorderColor = System.Drawing.Color.Transparent
        ChartArea12.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea12)
        Me.Chart2.IsSoftShadows = False
        Me.Chart2.Location = New System.Drawing.Point(81, 5)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Size = New System.Drawing.Size(615, 140)
        Me.Chart2.TabIndex = 62
        Me.Chart2.Text = "Chart1"
        '
        'MonitoringDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MonitoringDisplay"
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MonitoringDisplay"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.PanelECG1.ResumeLayout(False)
        Me.PanelECG1.PerformLayout()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PanelECG2.ResumeLayout(False)
        Me.PanelECG2.PerformLayout()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRR.ResumeLayout(False)
        Me.PanelRR.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSPO2.ResumeLayout(False)
        Me.PanelSPO2.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents TimerRandom As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents muitemp2 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents muitd As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents muitemp1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents sysdys As Label
    Friend WithEvents PanelECG1 As Panel
    Friend WithEvents Chart4 As DataVisualization.Charting.Chart
    Friend WithEvents Label30 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ecghr As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents pi1 As Label
    Friend WithEvents bprm1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents muispo2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ecgrr As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PanelRR As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents PanelSPO2 As Panel
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents PanelECG2 As Panel
    Friend WithEvents Chart5 As DataVisualization.Charting.Chart
    Friend WithEvents Label21 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Chart6 As DataVisualization.Charting.Chart
End Class
