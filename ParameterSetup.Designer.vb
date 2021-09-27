<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParameterSetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxECG1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxGraphMode = New System.Windows.Forms.ComboBox()
        Me.ComboBoxECG2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxApneaTime = New System.Windows.Forms.ComboBox()
        Me.ComboBoxRespLevel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxGain = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxRespSpeed = New System.Windows.Forms.ComboBox()
        Me.ComboBoxECGSpeed = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxSensitivity = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxPressure = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBoxAutoMode = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox13 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cb_t1_label = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cb_td = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cb_t2_label = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ECG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ECG 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Graph Mode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apnea Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ECG 2"
        '
        'ComboBoxECG1
        '
        Me.ComboBoxECG1.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBoxECG1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxECG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxECG1.FormattingEnabled = True
        Me.ComboBoxECG1.Items.AddRange(New Object() {"Lead I", "Lead II", "Lead II", "Lead AVR", "Lead AVL", "Lead AVF"})
        Me.ComboBoxECG1.Location = New System.Drawing.Point(46, 72)
        Me.ComboBoxECG1.Name = "ComboBoxECG1"
        Me.ComboBoxECG1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxECG1.TabIndex = 5
        '
        'ComboBoxGraphMode
        '
        Me.ComboBoxGraphMode.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBoxGraphMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGraphMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxGraphMode.FormattingEnabled = True
        Me.ComboBoxGraphMode.Items.AddRange(New Object() {"Diagnostic Mode", "Monitor Mode", "HAREST Mode", "Surgery Mode"})
        Me.ComboBoxGraphMode.Location = New System.Drawing.Point(215, 72)
        Me.ComboBoxGraphMode.Name = "ComboBoxGraphMode"
        Me.ComboBoxGraphMode.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxGraphMode.TabIndex = 6
        '
        'ComboBoxECG2
        '
        Me.ComboBoxECG2.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBoxECG2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxECG2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxECG2.FormattingEnabled = True
        Me.ComboBoxECG2.Items.AddRange(New Object() {"Lead I", "Lead II", "Lead II", "Lead AVR", "Lead AVL", "Lead AVF"})
        Me.ComboBoxECG2.Location = New System.Drawing.Point(46, 112)
        Me.ComboBoxECG2.Name = "ComboBoxECG2"
        Me.ComboBoxECG2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxECG2.TabIndex = 7
        '
        'ComboBoxApneaTime
        '
        Me.ComboBoxApneaTime.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBoxApneaTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxApneaTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxApneaTime.FormattingEnabled = True
        Me.ComboBoxApneaTime.Items.AddRange(New Object() {"5 s", "10 s", "15 s", "20 s"})
        Me.ComboBoxApneaTime.Location = New System.Drawing.Point(215, 112)
        Me.ComboBoxApneaTime.Name = "ComboBoxApneaTime"
        Me.ComboBoxApneaTime.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxApneaTime.TabIndex = 8
        '
        'ComboBoxRespLevel
        '
        Me.ComboBoxRespLevel.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBoxRespLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRespLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxRespLevel.FormattingEnabled = True
        Me.ComboBoxRespLevel.Items.AddRange(New Object() {"Sensitivity 1", "Sensitivity 2", "Sensitivity 3", "Sensitivity 4", "Sensitivity 5 (Most)"})
        Me.ComboBoxRespLevel.Location = New System.Drawing.Point(215, 154)
        Me.ComboBoxRespLevel.Name = "ComboBoxRespLevel"
        Me.ComboBoxRespLevel.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxRespLevel.TabIndex = 12
        '
        'ComboBoxGain
        '
        Me.ComboBoxGain.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBoxGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxGain.FormattingEnabled = True
        Me.ComboBoxGain.Items.AddRange(New Object() {"X 0.25", "X 0.5", "X 1", "X 2"})
        Me.ComboBoxGain.Location = New System.Drawing.Point(46, 154)
        Me.ComboBoxGain.Name = "ComboBoxGain"
        Me.ComboBoxGain.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxGain.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Resp Level"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Gain"
        '
        'ComboBoxRespSpeed
        '
        Me.ComboBoxRespSpeed.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBoxRespSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRespSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxRespSpeed.FormattingEnabled = True
        Me.ComboBoxRespSpeed.Items.AddRange(New Object() {"500 dot/s", "250 dot/s", "100 dot/s", "50 dot/s"})
        Me.ComboBoxRespSpeed.Location = New System.Drawing.Point(215, 195)
        Me.ComboBoxRespSpeed.Name = "ComboBoxRespSpeed"
        Me.ComboBoxRespSpeed.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxRespSpeed.TabIndex = 16
        '
        'ComboBoxECGSpeed
        '
        Me.ComboBoxECGSpeed.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBoxECGSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxECGSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxECGSpeed.FormattingEnabled = True
        Me.ComboBoxECGSpeed.Items.AddRange(New Object() {"500 dot/s", "250 dot/s", "100 dot/s"})
        Me.ComboBoxECGSpeed.Location = New System.Drawing.Point(46, 195)
        Me.ComboBoxECGSpeed.Name = "ComboBoxECGSpeed"
        Me.ComboBoxECGSpeed.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxECGSpeed.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(212, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Resp Speed"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "ECG Speed"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "SPO2"
        '
        'ComboBoxSensitivity
        '
        Me.ComboBoxSensitivity.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBoxSensitivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSensitivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxSensitivity.FormattingEnabled = True
        Me.ComboBoxSensitivity.Items.AddRange(New Object() {"Sensitivity 1 ( Low )", "Sensitivity 2", "Sensitivity 3", "Sensitivity 4", "Sensitivity 5 (High)"})
        Me.ComboBoxSensitivity.Location = New System.Drawing.Point(49, 287)
        Me.ComboBoxSensitivity.Name = "ComboBoxSensitivity"
        Me.ComboBoxSensitivity.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSensitivity.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 271)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Sensitivity"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(46, 323)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 18)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "NIBP"
        '
        'ComboBoxPressure
        '
        Me.ComboBoxPressure.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBoxPressure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPressure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxPressure.FormattingEnabled = True
        Me.ComboBoxPressure.Items.AddRange(New Object() {"Adult Mode", "Child Mode", "NewBorn Mode"})
        Me.ComboBoxPressure.Location = New System.Drawing.Point(50, 374)
        Me.ComboBoxPressure.Name = "ComboBoxPressure"
        Me.ComboBoxPressure.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPressure.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(48, 358)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Pressure"
        '
        'ComboBoxAutoMode
        '
        Me.ComboBoxAutoMode.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBoxAutoMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAutoMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxAutoMode.FormattingEnabled = True
        Me.ComboBoxAutoMode.Items.AddRange(New Object() {"1 Minute", "2 Minute", "3 Minute", "4 Minute", "5 Minute", "10 Minute", "15 Minute", "30 Minute", "60 Minute", "90 Minute", "2 HOurs", "3 Hours", "4 Hours", "8 Hours", ""})
        Me.ComboBoxAutoMode.Location = New System.Drawing.Point(215, 374)
        Me.ComboBoxAutoMode.Name = "ComboBoxAutoMode"
        Me.ComboBoxAutoMode.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxAutoMode.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(213, 358)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Auto Mode"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(48, 413)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 18)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Tempratures"
        '
        'ComboBox12
        '
        Me.ComboBox12.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Location = New System.Drawing.Point(51, 463)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox12.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(49, 447)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Setup T1"
        '
        'ComboBox13
        '
        Me.ComboBox13.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox13.FormattingEnabled = True
        Me.ComboBox13.Location = New System.Drawing.Point(215, 463)
        Me.ComboBox13.Name = "ComboBox13"
        Me.ComboBox13.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox13.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(213, 447)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Setup T2"
        '
        'cb_t1_label
        '
        Me.cb_t1_label.BackColor = System.Drawing.SystemColors.Control
        Me.cb_t1_label.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_t1_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_t1_label.FormattingEnabled = True
        Me.cb_t1_label.Items.AddRange(New Object() {"C", "F"})
        Me.cb_t1_label.Location = New System.Drawing.Point(353, 463)
        Me.cb_t1_label.Name = "cb_t1_label"
        Me.cb_t1_label.Size = New System.Drawing.Size(121, 21)
        Me.cb_t1_label.TabIndex = 31
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(351, 447)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "T1 Label"
        '
        'cb_td
        '
        Me.cb_td.BackColor = System.Drawing.SystemColors.Control
        Me.cb_td.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_td.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_td.FormattingEnabled = True
        Me.cb_td.Items.AddRange(New Object() {"C", "F"})
        Me.cb_td.Location = New System.Drawing.Point(215, 524)
        Me.cb_td.Name = "cb_td"
        Me.cb_td.Size = New System.Drawing.Size(121, 21)
        Me.cb_td.TabIndex = 35
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(213, 508)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "T Difference"
        '
        'cb_t2_label
        '
        Me.cb_t2_label.BackColor = System.Drawing.SystemColors.Control
        Me.cb_t2_label.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_t2_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_t2_label.FormattingEnabled = True
        Me.cb_t2_label.Items.AddRange(New Object() {"C", "F"})
        Me.cb_t2_label.Location = New System.Drawing.Point(51, 524)
        Me.cb_t2_label.Name = "cb_t2_label"
        Me.cb_t2_label.Size = New System.Drawing.Size(121, 21)
        Me.cb_t2_label.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(49, 508)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "T2 Label"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(325, 588)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 36
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(420, 588)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 37
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ParameterSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 638)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.cb_td)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cb_t2_label)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cb_t1_label)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ComboBox13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ComboBox12)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ComboBoxAutoMode)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ComboBoxPressure)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBoxSensitivity)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBoxRespSpeed)
        Me.Controls.Add(Me.ComboBoxECGSpeed)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBoxRespLevel)
        Me.Controls.Add(Me.ComboBoxGain)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBoxApneaTime)
        Me.Controls.Add(Me.ComboBoxECG2)
        Me.Controls.Add(Me.ComboBoxGraphMode)
        Me.Controls.Add(Me.ComboBoxECG1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ParameterSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parameter Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxECG1 As ComboBox
    Friend WithEvents ComboBoxGraphMode As ComboBox
    Friend WithEvents ComboBoxECG2 As ComboBox
    Friend WithEvents ComboBoxApneaTime As ComboBox
    Friend WithEvents ComboBoxRespLevel As ComboBox
    Friend WithEvents ComboBoxGain As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxRespSpeed As ComboBox
    Friend WithEvents ComboBoxECGSpeed As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBoxSensitivity As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBoxPressure As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBoxAutoMode As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox13 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cb_t1_label As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cb_td As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cb_t2_label As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonClose As Button
End Class
