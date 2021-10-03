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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelPatientName = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerReceivedData = New System.Windows.Forms.Timer(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonBlue = New System.Windows.Forms.Button()
        Me.ButtonYellow = New System.Windows.Forms.Button()
        Me.ButtonRed = New System.Windows.Forms.Button()
        Me.TimerRandom = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PanelRR = New System.Windows.Forms.Panel()
        Me.LabelRrStatus = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PanelSPO2 = New System.Windows.Forms.Panel()
        Me.LabelStatusSpo2 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.PanelECG2 = New System.Windows.Forms.Panel()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LabelStatusLead2 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.PanelECG1 = New System.Windows.Forms.Panel()
        Me.LabelStatusLead1 = New System.Windows.Forms.Label()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelEcgMin = New System.Windows.Forms.Label()
        Me.LabelEcgMax = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ecghr = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.pi1 = New System.Windows.Forms.Label()
        Me.bprm1 = New System.Windows.Forms.Label()
        Me.LabelSpo2Min = New System.Windows.Forms.Label()
        Me.LabelSpo2Max = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.muispo2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LabelRRMin = New System.Windows.Forms.Label()
        Me.LabelRRMax = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ecgrr = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TimerBlue = New System.Windows.Forms.Timer(Me.components)
        Me.TimerNotification = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCOM3 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCOM5 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLedAll = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAudio = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTypePatient = New System.Windows.Forms.Label()
        Me.TimerSpo2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMax = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMin = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelRR.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSPO2.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelECG2.SuspendLayout()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelECG1.SuspendLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
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
        'LabelPatientName
        '
        Me.LabelPatientName.AutoSize = True
        Me.LabelPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPatientName.ForeColor = System.Drawing.Color.White
        Me.LabelPatientName.Location = New System.Drawing.Point(12, 9)
        Me.LabelPatientName.Name = "LabelPatientName"
        Me.LabelPatientName.Size = New System.Drawing.Size(253, 24)
        Me.LabelPatientName.TabIndex = 7
        Me.LabelPatientName.Text = "Patient Name : John Doe |"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 250
        '
        'TimerReceivedData
        '
        Me.TimerReceivedData.Enabled = True
        Me.TimerReceivedData.Interval = 1
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
        'ButtonBlue
        '
        Me.ButtonBlue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ButtonBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBlue.ForeColor = System.Drawing.Color.Black
        Me.ButtonBlue.Location = New System.Drawing.Point(346, 9)
        Me.ButtonBlue.Name = "ButtonBlue"
        Me.ButtonBlue.Size = New System.Drawing.Size(146, 27)
        Me.ButtonBlue.TabIndex = 54
        Me.ButtonBlue.Text = "BATTERY FAILURE"
        Me.ButtonBlue.UseVisualStyleBackColor = False
        Me.ButtonBlue.Visible = False
        '
        'ButtonYellow
        '
        Me.ButtonYellow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonYellow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonYellow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonYellow.ForeColor = System.Drawing.Color.Black
        Me.ButtonYellow.Location = New System.Drawing.Point(498, 9)
        Me.ButtonYellow.Name = "ButtonYellow"
        Me.ButtonYellow.Size = New System.Drawing.Size(146, 27)
        Me.ButtonYellow.TabIndex = 55
        Me.ButtonYellow.UseVisualStyleBackColor = False
        Me.ButtonYellow.Visible = False
        '
        'ButtonRed
        '
        Me.ButtonRed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRed.BackColor = System.Drawing.Color.Red
        Me.ButtonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRed.ForeColor = System.Drawing.Color.Black
        Me.ButtonRed.Location = New System.Drawing.Point(650, 9)
        Me.ButtonRed.Name = "ButtonRed"
        Me.ButtonRed.Size = New System.Drawing.Size(146, 27)
        Me.ButtonRed.TabIndex = 56
        Me.ButtonRed.Text = " "
        Me.ButtonRed.UseVisualStyleBackColor = False
        Me.ButtonRed.Visible = False
        '
        'TimerRandom
        '
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
        Me.Panel5.Location = New System.Drawing.Point(0, 210)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(699, 518)
        Me.Panel5.TabIndex = 3
        '
        'PanelRR
        '
        Me.PanelRR.Controls.Add(Me.LabelRrStatus)
        Me.PanelRR.Controls.Add(Me.Chart1)
        Me.PanelRR.Controls.Add(Me.Label11)
        Me.PanelRR.Controls.Add(Me.Label16)
        Me.PanelRR.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRR.Location = New System.Drawing.Point(0, 337)
        Me.PanelRR.Name = "PanelRR"
        Me.PanelRR.Size = New System.Drawing.Size(699, 141)
        Me.PanelRR.TabIndex = 4
        '
        'LabelRrStatus
        '
        Me.LabelRrStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelRrStatus.AutoSize = True
        Me.LabelRrStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRrStatus.ForeColor = System.Drawing.Color.Lime
        Me.LabelRrStatus.Location = New System.Drawing.Point(104, 10)
        Me.LabelRrStatus.Name = "LabelRrStatus"
        Me.LabelRrStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelRrStatus.Size = New System.Drawing.Size(57, 15)
        Me.LabelRrStatus.TabIndex = 66
        Me.LabelRrStatus.Text = "100 dot/s"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea1.AxisX.LabelStyle.Enabled = False
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisY.LabelStyle.Enabled = False
        ChartArea1.AxisY.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.AxisY.MajorTickMark.Enabled = False
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.IsSoftShadows = False
        Me.Chart1.Location = New System.Drawing.Point(104, 18)
        Me.Chart1.Name = "Chart1"
        Series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.Lime
        Series1.Name = "rr"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(573, 140)
        Me.Chart1.TabIndex = 63
        Me.Chart1.Text = "Chart1"
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
        'PanelSPO2
        '
        Me.PanelSPO2.Controls.Add(Me.LabelStatusSpo2)
        Me.PanelSPO2.Controls.Add(Me.Chart2)
        Me.PanelSPO2.Controls.Add(Me.Label32)
        Me.PanelSPO2.Controls.Add(Me.Label31)
        Me.PanelSPO2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSPO2.Location = New System.Drawing.Point(0, 181)
        Me.PanelSPO2.Name = "PanelSPO2"
        Me.PanelSPO2.Size = New System.Drawing.Size(699, 156)
        Me.PanelSPO2.TabIndex = 3
        '
        'LabelStatusSpo2
        '
        Me.LabelStatusSpo2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStatusSpo2.AutoSize = True
        Me.LabelStatusSpo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelStatusSpo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelStatusSpo2.Location = New System.Drawing.Point(104, 8)
        Me.LabelStatusSpo2.Name = "LabelStatusSpo2"
        Me.LabelStatusSpo2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelStatusSpo2.Size = New System.Drawing.Size(89, 17)
        Me.LabelStatusSpo2.TabIndex = 63
        Me.LabelStatusSpo2.Text = "Status SPO2"
        '
        'Chart2
        '
        Me.Chart2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea2.AxisX.LabelStyle.Enabled = False
        ChartArea2.AxisX.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisX.MajorTickMark.Enabled = False
        ChartArea2.AxisY.LabelAutoFitStyle = CType((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap), System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)
        ChartArea2.AxisY.LabelStyle.Enabled = False
        ChartArea2.AxisY.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisY.LineWidth = 0
        ChartArea2.AxisY.MajorGrid.Enabled = False
        ChartArea2.AxisY.MajorGrid.Interval = 0R
        ChartArea2.AxisY.MajorGrid.IntervalOffset = 0R
        ChartArea2.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.MajorTickMark.Enabled = False
        ChartArea2.AxisY.MajorTickMark.Interval = 0R
        ChartArea2.AxisY.MajorTickMark.IntervalOffset = 0R
        ChartArea2.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BorderColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.IsSoftShadows = False
        Me.Chart2.Location = New System.Drawing.Point(104, 40)
        Me.Chart2.Name = "Chart2"
        Series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.DeepSkyBlue
        Series2.Name = "spo2"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(573, 140)
        Me.Chart2.TabIndex = 64
        Me.Chart2.Text = "Chart2"
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
        Me.Label31.Location = New System.Drawing.Point(31, 8)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(68, 25)
        Me.Label31.TabIndex = 56
        Me.Label31.Text = "SpO2"
        '
        'PanelECG2
        '
        Me.PanelECG2.Controls.Add(Me.Chart4)
        Me.PanelECG2.Controls.Add(Me.LabelStatusLead2)
        Me.PanelECG2.Controls.Add(Me.Label30)
        Me.PanelECG2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelECG2.Location = New System.Drawing.Point(0, 0)
        Me.PanelECG2.Name = "PanelECG2"
        Me.PanelECG2.Size = New System.Drawing.Size(699, 181)
        Me.PanelECG2.TabIndex = 1
        '
        'Chart4
        '
        Me.Chart4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea3.AxisX.LabelStyle.Enabled = False
        ChartArea3.AxisX.LineColor = System.Drawing.Color.Transparent
        ChartArea3.AxisX.MajorGrid.Enabled = False
        ChartArea3.AxisY.LabelStyle.Enabled = False
        ChartArea3.AxisY.LineColor = System.Drawing.Color.Transparent
        ChartArea3.AxisY.LineWidth = 50
        ChartArea3.AxisY.MajorGrid.Enabled = False
        ChartArea3.AxisY.MajorTickMark.Enabled = False
        ChartArea3.BackColor = System.Drawing.Color.Transparent
        ChartArea3.BorderColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea3)
        Me.Chart4.IsSoftShadows = False
        Me.Chart4.Location = New System.Drawing.Point(104, 46)
        Me.Chart4.Name = "Chart4"
        Series3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Color = System.Drawing.Color.Lime
        Series3.Name = "ecg2"
        Me.Chart4.Series.Add(Series3)
        Me.Chart4.Size = New System.Drawing.Size(573, 140)
        Me.Chart4.TabIndex = 65
        Me.Chart4.Text = "Chart4"
        '
        'LabelStatusLead2
        '
        Me.LabelStatusLead2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStatusLead2.AutoSize = True
        Me.LabelStatusLead2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatusLead2.ForeColor = System.Drawing.Color.Lime
        Me.LabelStatusLead2.Location = New System.Drawing.Point(104, 14)
        Me.LabelStatusLead2.Name = "LabelStatusLead2"
        Me.LabelStatusLead2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelStatusLead2.Size = New System.Drawing.Size(323, 15)
        Me.LabelStatusLead2.TabIndex = 64
        Me.LabelStatusLead2.Text = "Channel 2, Lead I, Gain x 1.00, Diagnosis Mode. 500 dot/s"
        '
        'Label30
        '
        Me.Label30.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label30.ForeColor = System.Drawing.Color.Lime
        Me.Label30.Location = New System.Drawing.Point(48, 14)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 17)
        Me.Label30.TabIndex = 59
        Me.Label30.Text = "Lead II"
        '
        'PanelECG1
        '
        Me.PanelECG1.Controls.Add(Me.LabelStatusLead1)
        Me.PanelECG1.Controls.Add(Me.Chart3)
        Me.PanelECG1.Controls.Add(Me.Label26)
        Me.PanelECG1.Controls.Add(Me.Label25)
        Me.PanelECG1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelECG1.Location = New System.Drawing.Point(0, 0)
        Me.PanelECG1.Name = "PanelECG1"
        Me.PanelECG1.Size = New System.Drawing.Size(699, 210)
        Me.PanelECG1.TabIndex = 0
        '
        'LabelStatusLead1
        '
        Me.LabelStatusLead1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStatusLead1.AutoSize = True
        Me.LabelStatusLead1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatusLead1.ForeColor = System.Drawing.Color.Lime
        Me.LabelStatusLead1.Location = New System.Drawing.Point(104, 42)
        Me.LabelStatusLead1.Name = "LabelStatusLead1"
        Me.LabelStatusLead1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelStatusLead1.Size = New System.Drawing.Size(319, 15)
        Me.LabelStatusLead1.TabIndex = 65
        Me.LabelStatusLead1.Text = "Channel I, Lead I, Gain x 1.00, Diagnosis Mode. 500 dot/s"
        '
        'Chart3
        '
        Me.Chart3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        ChartArea4.AxisX.LabelStyle.Enabled = False
        ChartArea4.AxisX.LineColor = System.Drawing.Color.Transparent
        ChartArea4.AxisX.MajorGrid.Enabled = False
        ChartArea4.AxisY.LabelStyle.Enabled = False
        ChartArea4.AxisY.LineColor = System.Drawing.Color.Transparent
        ChartArea4.AxisY.LineWidth = 50
        ChartArea4.AxisY.MajorGrid.Enabled = False
        ChartArea4.AxisY.MajorTickMark.Enabled = False
        ChartArea4.BackColor = System.Drawing.Color.Transparent
        ChartArea4.BorderColor = System.Drawing.Color.Transparent
        ChartArea4.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea4)
        Me.Chart3.IsSoftShadows = False
        Me.Chart3.Location = New System.Drawing.Point(104, 70)
        Me.Chart3.Name = "Chart3"
        Series4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Color = System.Drawing.Color.Lime
        Series4.Name = "ecg1"
        Me.Chart3.Series.Add(Series4)
        Me.Chart3.Size = New System.Drawing.Size(573, 140)
        Me.Chart3.TabIndex = 66
        Me.Chart3.Text = "Chart3"
        '
        'Label26
        '
        Me.Label26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label26.ForeColor = System.Drawing.Color.Lime
        Me.Label26.Location = New System.Drawing.Point(51, 42)
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
        Me.Label25.Size = New System.Drawing.Size(64, 25)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "ECG "
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
        Me.muitemp2.Location = New System.Drawing.Point(218, 131)
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
        Me.Label14.Location = New System.Drawing.Point(21, 170)
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
        Me.Label22.Location = New System.Drawing.Point(21, 151)
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
        Me.Label23.Location = New System.Drawing.Point(21, 134)
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
        Me.muitemp1.Location = New System.Drawing.Point(105, 134)
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
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.LabelEcgMin)
        Me.Panel2.Controls.Add(Me.LabelEcgMax)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.ecghr)
        Me.Panel2.Location = New System.Drawing.Point(713, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(299, 157)
        Me.Panel2.TabIndex = 62
        '
        'LabelEcgMin
        '
        Me.LabelEcgMin.AutoSize = True
        Me.LabelEcgMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelEcgMin.ForeColor = System.Drawing.Color.Lime
        Me.LabelEcgMin.Location = New System.Drawing.Point(17, 116)
        Me.LabelEcgMin.Name = "LabelEcgMin"
        Me.LabelEcgMin.Size = New System.Drawing.Size(24, 17)
        Me.LabelEcgMin.TabIndex = 60
        Me.LabelEcgMin.Text = "60"
        '
        'LabelEcgMax
        '
        Me.LabelEcgMax.AutoSize = True
        Me.LabelEcgMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelEcgMax.ForeColor = System.Drawing.Color.Lime
        Me.LabelEcgMax.Location = New System.Drawing.Point(17, 93)
        Me.LabelEcgMax.Name = "LabelEcgMax"
        Me.LabelEcgMax.Size = New System.Drawing.Size(32, 17)
        Me.LabelEcgMax.TabIndex = 59
        Me.LabelEcgMax.Text = "120"
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
        Me.Panel3.Controls.Add(Me.LabelSpo2Min)
        Me.Panel3.Controls.Add(Me.LabelSpo2Max)
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
        Me.Label33.Location = New System.Drawing.Point(218, 93)
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
        Me.Label34.Location = New System.Drawing.Point(218, 28)
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
        Me.pi1.Location = New System.Drawing.Point(214, 112)
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
        Me.bprm1.Location = New System.Drawing.Point(216, 45)
        Me.bprm1.Name = "bprm1"
        Me.bprm1.Size = New System.Drawing.Size(33, 30)
        Me.bprm1.TabIndex = 67
        Me.bprm1.Text = "--"
        '
        'LabelSpo2Min
        '
        Me.LabelSpo2Min.AutoSize = True
        Me.LabelSpo2Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelSpo2Min.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelSpo2Min.Location = New System.Drawing.Point(20, 112)
        Me.LabelSpo2Min.Name = "LabelSpo2Min"
        Me.LabelSpo2Min.Size = New System.Drawing.Size(24, 17)
        Me.LabelSpo2Min.TabIndex = 66
        Me.LabelSpo2Min.Text = "60"
        '
        'LabelSpo2Max
        '
        Me.LabelSpo2Max.AutoSize = True
        Me.LabelSpo2Max.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelSpo2Max.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelSpo2Max.Location = New System.Drawing.Point(13, 91)
        Me.LabelSpo2Max.Name = "LabelSpo2Max"
        Me.LabelSpo2Max.Size = New System.Drawing.Size(32, 17)
        Me.LabelSpo2Max.TabIndex = 65
        Me.LabelSpo2Max.Text = "100"
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
        Me.Label4.Location = New System.Drawing.Point(16, 32)
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
        Me.muispo2.Location = New System.Drawing.Point(56, 51)
        Me.muispo2.Name = "muispo2"
        Me.muispo2.Size = New System.Drawing.Size(95, 91)
        Me.muispo2.TabIndex = 62
        Me.muispo2.Text = "--"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.LabelRRMin)
        Me.Panel4.Controls.Add(Me.LabelRRMax)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.ecgrr)
        Me.Panel4.Location = New System.Drawing.Point(710, 366)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(302, 111)
        Me.Panel4.TabIndex = 64
        '
        'LabelRRMin
        '
        Me.LabelRRMin.AutoSize = True
        Me.LabelRRMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelRRMin.ForeColor = System.Drawing.Color.Lime
        Me.LabelRRMin.Location = New System.Drawing.Point(23, 79)
        Me.LabelRRMin.Name = "LabelRRMin"
        Me.LabelRRMin.Size = New System.Drawing.Size(24, 17)
        Me.LabelRRMin.TabIndex = 61
        Me.LabelRRMin.Text = "60"
        '
        'LabelRRMax
        '
        Me.LabelRRMax.AutoSize = True
        Me.LabelRRMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelRRMax.ForeColor = System.Drawing.Color.Lime
        Me.LabelRRMax.Location = New System.Drawing.Point(16, 62)
        Me.LabelRRMax.Name = "LabelRRMax"
        Me.LabelRRMax.Size = New System.Drawing.Size(32, 17)
        Me.LabelRRMax.TabIndex = 60
        Me.LabelRRMax.Text = "100"
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
        Me.ecgrr.Location = New System.Drawing.Point(72, 13)
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
        'TimerBlue
        '
        Me.TimerBlue.Enabled = True
        Me.TimerBlue.Interval = 1000
        '
        'TimerNotification
        '
        Me.TimerNotification.Enabled = True
        Me.TimerNotification.Interval = 1000
        '
        'TimerCOM3
        '
        Me.TimerCOM3.Interval = 500
        '
        'TimerCOM5
        '
        Me.TimerCOM5.Enabled = True
        Me.TimerCOM5.Interval = 500
        '
        'TimerLedAll
        '
        Me.TimerLedAll.Interval = 1000
        '
        'TimerAudio
        '
        Me.TimerAudio.Interval = 1500
        '
        'LabelTypePatient
        '
        Me.LabelTypePatient.AutoSize = True
        Me.LabelTypePatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTypePatient.ForeColor = System.Drawing.Color.White
        Me.LabelTypePatient.Location = New System.Drawing.Point(262, 11)
        Me.LabelTypePatient.Name = "LabelTypePatient"
        Me.LabelTypePatient.Size = New System.Drawing.Size(58, 24)
        Me.LabelTypePatient.TabIndex = 66
        Me.LabelTypePatient.Text = "Adult"
        '
        'TimerSpo2
        '
        Me.TimerSpo2.Enabled = True
        Me.TimerSpo2.Interval = 1
        '
        'TimerMax
        '
        Me.TimerMax.Enabled = True
        Me.TimerMax.Interval = 1000
        '
        'TimerMin
        '
        Me.TimerMin.Enabled = True
        Me.TimerMin.Interval = 1000
        '
        'MonitoringDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.LabelTypePatient)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonRed)
        Me.Controls.Add(Me.ButtonYellow)
        Me.Controls.Add(Me.ButtonBlue)
        Me.Controls.Add(Me.LabelPatientName)
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
        Me.PanelRR.ResumeLayout(False)
        Me.PanelRR.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSPO2.ResumeLayout(False)
        Me.PanelSPO2.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelECG2.ResumeLayout(False)
        Me.PanelECG2.PerformLayout()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelECG1.ResumeLayout(False)
        Me.PanelECG1.PerformLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
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
    Friend WithEvents LabelPatientName As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents TimerReceivedData As Timer
    Friend WithEvents ButtonBlue As Button
    Friend WithEvents ButtonYellow As Button
    Friend WithEvents ButtonRed As Button
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
    Friend WithEvents Label30 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelEcgMin As Label
    Friend WithEvents LabelEcgMax As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ecghr As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents pi1 As Label
    Friend WithEvents bprm1 As Label
    Friend WithEvents LabelSpo2Min As Label
    Friend WithEvents LabelSpo2Max As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents muispo2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelRRMin As Label
    Friend WithEvents LabelRRMax As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ecgrr As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PanelRR As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PanelSPO2 As Panel
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TimerBlue As Timer
    Friend WithEvents PanelECG2 As Panel
    Friend WithEvents TimerNotification As Timer
    Friend WithEvents TimerCOM3 As Timer
    Friend WithEvents TimerCOM5 As Timer
    Friend WithEvents TimerLedAll As Timer
    Friend WithEvents TimerAudio As Timer
    Friend WithEvents LabelTypePatient As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LabelStatusSpo2 As Label
    Friend WithEvents LabelStatusLead2 As Label
    Friend WithEvents LabelStatusLead1 As Label
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart4 As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents LabelRrStatus As Label
    Friend WithEvents TimerSpo2 As Timer
    Friend WithEvents TimerMax As Timer
    Friend WithEvents TimerMin As Timer
End Class
