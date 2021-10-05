<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPatient
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
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_gender = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txt_nurse = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_doctor = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_profession = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_weight = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_height = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_age = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Datetimepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.txt_last_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_first_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_Edit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancle
        '
        Me.btn_cancle.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancle.ForeColor = System.Drawing.Color.White
        Me.btn_cancle.Location = New System.Drawing.Point(125, 466)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(52, 23)
        Me.btn_cancle.TabIndex = 47
        Me.btn_cancle.Text = "Cancel"
        Me.btn_cancle.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Add Patient"
        '
        'cb_gender
        '
        Me.cb_gender.BackColor = System.Drawing.Color.Transparent
        Me.cb_gender.BorderRadius = 3
        Me.cb_gender.DisabledColor = System.Drawing.Color.Gray
        Me.cb_gender.ForeColor = System.Drawing.Color.Black
        Me.cb_gender.Items = New String() {"Male", "Famale"}
        Me.cb_gender.Location = New System.Drawing.Point(30, 316)
        Me.cb_gender.Name = "cb_gender"
        Me.cb_gender.NomalColor = System.Drawing.Color.Transparent
        Me.cb_gender.onHoverColor = System.Drawing.Color.Silver
        Me.cb_gender.selectedIndex = 1
        Me.cb_gender.Size = New System.Drawing.Size(147, 33)
        Me.cb_gender.TabIndex = 67
        '
        'txt_nurse
        '
        Me.txt_nurse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nurse.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nurse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nurse.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nurse.HintText = ""
        Me.txt_nurse.isPassword = False
        Me.txt_nurse.LineFocusedColor = System.Drawing.Color.Lime
        Me.txt_nurse.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nurse.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txt_nurse.LineThickness = 3
        Me.txt_nurse.Location = New System.Drawing.Point(218, 390)
        Me.txt_nurse.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nurse.Name = "txt_nurse"
        Me.txt_nurse.Size = New System.Drawing.Size(222, 33)
        Me.txt_nurse.TabIndex = 66
        Me.txt_nurse.Text = " "
        Me.txt_nurse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_doctor
        '
        Me.txt_doctor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_doctor.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_doctor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_doctor.HintForeColor = System.Drawing.Color.Empty
        Me.txt_doctor.HintText = ""
        Me.txt_doctor.isPassword = False
        Me.txt_doctor.LineFocusedColor = System.Drawing.Color.Lime
        Me.txt_doctor.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_doctor.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txt_doctor.LineThickness = 3
        Me.txt_doctor.Location = New System.Drawing.Point(30, 390)
        Me.txt_doctor.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_doctor.Name = "txt_doctor"
        Me.txt_doctor.Size = New System.Drawing.Size(143, 33)
        Me.txt_doctor.TabIndex = 65
        Me.txt_doctor.Text = " "
        Me.txt_doctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_profession
        '
        Me.txt_profession.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_profession.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_profession.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_profession.HintForeColor = System.Drawing.Color.Empty
        Me.txt_profession.HintText = ""
        Me.txt_profession.isPassword = False
        Me.txt_profession.LineFocusedColor = System.Drawing.Color.Lime
        Me.txt_profession.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_profession.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txt_profession.LineThickness = 3
        Me.txt_profession.Location = New System.Drawing.Point(218, 316)
        Me.txt_profession.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_profession.Name = "txt_profession"
        Me.txt_profession.Size = New System.Drawing.Size(222, 33)
        Me.txt_profession.TabIndex = 64
        Me.txt_profession.Text = " "
        Me.txt_profession.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_weight
        '
        Me.txt_weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_weight.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_weight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_weight.HintForeColor = System.Drawing.Color.Empty
        Me.txt_weight.HintText = ""
        Me.txt_weight.isPassword = False
        Me.txt_weight.LineFocusedColor = System.Drawing.Color.Lime
        Me.txt_weight.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_weight.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txt_weight.LineThickness = 3
        Me.txt_weight.Location = New System.Drawing.Point(218, 239)
        Me.txt_weight.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(222, 33)
        Me.txt_weight.TabIndex = 63
        Me.txt_weight.Text = " "
        Me.txt_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_height
        '
        Me.txt_height.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_height.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_height.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_height.HintForeColor = System.Drawing.Color.Empty
        Me.txt_height.HintText = ""
        Me.txt_height.isPassword = False
        Me.txt_height.LineFocusedColor = System.Drawing.Color.Lime
        Me.txt_height.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_height.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txt_height.LineThickness = 3
        Me.txt_height.Location = New System.Drawing.Point(34, 239)
        Me.txt_height.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Size = New System.Drawing.Size(143, 33)
        Me.txt_height.TabIndex = 62
        Me.txt_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_age
        '
        Me.txt_age.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_age.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_age.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_age.HintForeColor = System.Drawing.Color.Empty
        Me.txt_age.HintText = ""
        Me.txt_age.isPassword = False
        Me.txt_age.LineFocusedColor = System.Drawing.Color.Lime
        Me.txt_age.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_age.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txt_age.LineThickness = 3
        Me.txt_age.Location = New System.Drawing.Point(218, 164)
        Me.txt_age.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(222, 33)
        Me.txt_age.TabIndex = 61
        Me.txt_age.Text = " "
        Me.txt_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Datetimepicker1
        '
        Me.Datetimepicker1.BackColor = System.Drawing.Color.Transparent
        Me.Datetimepicker1.BorderRadius = 0
        Me.Datetimepicker1.ForeColor = System.Drawing.Color.Black
        Me.Datetimepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datetimepicker1.FormatCustom = ""
        Me.Datetimepicker1.Location = New System.Drawing.Point(30, 164)
        Me.Datetimepicker1.Name = "Datetimepicker1"
        Me.Datetimepicker1.Size = New System.Drawing.Size(147, 33)
        Me.Datetimepicker1.TabIndex = 60
        Me.Datetimepicker1.Value = New Date(2021, 9, 22, 0, 0, 0, 0)
        '
        'txt_last_name
        '
        Me.txt_last_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_last_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_last_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_last_name.HintForeColor = System.Drawing.Color.Empty
        Me.txt_last_name.HintText = ""
        Me.txt_last_name.isPassword = False
        Me.txt_last_name.LineFocusedColor = System.Drawing.Color.Lime
        Me.txt_last_name.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_last_name.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txt_last_name.LineThickness = 3
        Me.txt_last_name.Location = New System.Drawing.Point(218, 85)
        Me.txt_last_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_last_name.Name = "txt_last_name"
        Me.txt_last_name.Size = New System.Drawing.Size(222, 33)
        Me.txt_last_name.TabIndex = 59
        Me.txt_last_name.Text = " "
        Me.txt_last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_first_name
        '
        Me.txt_first_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_first_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_first_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_first_name.HintForeColor = System.Drawing.Color.Empty
        Me.txt_first_name.HintText = ""
        Me.txt_first_name.isPassword = False
        Me.txt_first_name.LineFocusedColor = System.Drawing.Color.Lime
        Me.txt_first_name.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_first_name.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.txt_first_name.LineThickness = 3
        Me.txt_first_name.Location = New System.Drawing.Point(30, 85)
        Me.txt_first_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_first_name.Name = "txt_first_name"
        Me.txt_first_name.Size = New System.Drawing.Size(143, 33)
        Me.txt_first_name.TabIndex = 58
        Me.txt_first_name.Text = " "
        Me.txt_first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label21
        '
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label21.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(27, 289)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 23)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Gender"
        '
        'Label19
        '
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(215, 363)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 23)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Nurse"
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(215, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 23)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Profession"
        '
        'Label13
        '
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(215, 212)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 23)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Weight (Kg)"
        '
        'Label15
        '
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(215, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 23)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Age"
        '
        'Label17
        '
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(215, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 23)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Last Name"
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(27, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 23)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Doctor"
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(27, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 23)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Height (cm)"
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(27, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 23)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Birth"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(27, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "First Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 510)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 74)
        Me.DataGridView1.TabIndex = 68
        '
        'Button_Edit
        '
        Me.Button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Edit.Location = New System.Drawing.Point(30, 466)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(55, 23)
        Me.Button_Edit.TabIndex = 69
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'AddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 584)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cb_gender)
        Me.Controls.Add(Me.txt_nurse)
        Me.Controls.Add(Me.txt_doctor)
        Me.Controls.Add(Me.txt_profession)
        Me.Controls.Add(Me.txt_weight)
        Me.Controls.Add(Me.txt_height)
        Me.Controls.Add(Me.txt_age)
        Me.Controls.Add(Me.Datetimepicker1)
        Me.Controls.Add(Me.txt_last_name)
        Me.Controls.Add(Me.txt_first_name)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cancle)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddPatient"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cancle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_gender As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txt_nurse As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_doctor As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_profession As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_weight As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_height As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_age As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Datetimepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents txt_last_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_first_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_Edit As Button
End Class
