<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPatient
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
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.TextBox8 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TextBox7 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TextBox6 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TextBox5 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TextBox4 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TextBox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Datetimepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.TextBox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TextBox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
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
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save.Location = New System.Drawing.Point(32, 458)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(55, 23)
        Me.btn_save.TabIndex = 46
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancle
        '
        Me.btn_cancle.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancle.ForeColor = System.Drawing.Color.White
        Me.btn_cancle.Location = New System.Drawing.Point(111, 458)
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
        Me.Label1.Size = New System.Drawing.Size(134, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Add Patient"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox1.BorderRadius = 3
        Me.ComboBox1.DisabledColor = System.Drawing.Color.Gray
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.Items = New String() {"Male", "Famale"}
        Me.ComboBox1.Location = New System.Drawing.Point(30, 316)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.NomalColor = System.Drawing.Color.Transparent
        Me.ComboBox1.onHoverColor = System.Drawing.Color.Silver
        Me.ComboBox1.selectedIndex = -1
        Me.ComboBox1.Size = New System.Drawing.Size(147, 33)
        Me.ComboBox1.TabIndex = 67
        '
        'TextBox8
        '
        Me.TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox8.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox8.HintText = ""
        Me.TextBox8.isPassword = False
        Me.TextBox8.LineFocusedColor = System.Drawing.Color.Lime
        Me.TextBox8.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBox8.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.TextBox8.LineThickness = 3
        Me.TextBox8.Location = New System.Drawing.Point(218, 390)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(143, 33)
        Me.TextBox8.TabIndex = 66
        Me.TextBox8.Text = " "
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextBox7
        '
        Me.TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox7.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox7.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox7.HintText = ""
        Me.TextBox7.isPassword = False
        Me.TextBox7.LineFocusedColor = System.Drawing.Color.Lime
        Me.TextBox7.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBox7.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.TextBox7.LineThickness = 3
        Me.TextBox7.Location = New System.Drawing.Point(30, 390)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(143, 33)
        Me.TextBox7.TabIndex = 65
        Me.TextBox7.Text = " "
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextBox6
        '
        Me.TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox6.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox6.HintText = ""
        Me.TextBox6.isPassword = False
        Me.TextBox6.LineFocusedColor = System.Drawing.Color.Lime
        Me.TextBox6.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBox6.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.TextBox6.LineThickness = 3
        Me.TextBox6.Location = New System.Drawing.Point(218, 316)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(143, 33)
        Me.TextBox6.TabIndex = 64
        Me.TextBox6.Text = " "
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextBox5
        '
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox5.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox5.HintText = ""
        Me.TextBox5.isPassword = False
        Me.TextBox5.LineFocusedColor = System.Drawing.Color.Lime
        Me.TextBox5.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBox5.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.TextBox5.LineThickness = 3
        Me.TextBox5.Location = New System.Drawing.Point(218, 239)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(143, 33)
        Me.TextBox5.TabIndex = 63
        Me.TextBox5.Text = " "
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextBox4
        '
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox4.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox4.HintText = ""
        Me.TextBox4.isPassword = False
        Me.TextBox4.LineFocusedColor = System.Drawing.Color.Lime
        Me.TextBox4.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBox4.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.TextBox4.LineThickness = 3
        Me.TextBox4.Location = New System.Drawing.Point(34, 239)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(143, 33)
        Me.TextBox4.TabIndex = 62
        Me.TextBox4.Text = " "
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextBox3
        '
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox3.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox3.HintText = ""
        Me.TextBox3.isPassword = False
        Me.TextBox3.LineFocusedColor = System.Drawing.Color.Lime
        Me.TextBox3.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBox3.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.TextBox3.LineThickness = 3
        Me.TextBox3.Location = New System.Drawing.Point(218, 164)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(143, 33)
        Me.TextBox3.TabIndex = 61
        Me.TextBox3.Text = " "
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'TextBox2
        '
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox2.HintText = ""
        Me.TextBox2.isPassword = False
        Me.TextBox2.LineFocusedColor = System.Drawing.Color.Lime
        Me.TextBox2.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBox2.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.TextBox2.LineThickness = 3
        Me.TextBox2.Location = New System.Drawing.Point(218, 85)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 33)
        Me.TextBox2.TabIndex = 59
        Me.TextBox2.Text = " "
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.HintForeColor = System.Drawing.Color.Empty
        Me.TextBox1.HintText = ""
        Me.TextBox1.isPassword = False
        Me.TextBox1.LineFocusedColor = System.Drawing.Color.Lime
        Me.TextBox1.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBox1.LineMouseHoverColor = System.Drawing.Color.Lime
        Me.TextBox1.LineThickness = 3
        Me.TextBox1.Location = New System.Drawing.Point(30, 85)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 33)
        Me.TextBox1.TabIndex = 58
        Me.TextBox1.Text = " "
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Label13.Text = "Wight (Kg)"
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
        'AddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 493)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Datetimepicker1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_cancle)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddPatient"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_cancle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents TextBox8 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TextBox7 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TextBox6 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TextBox5 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TextBox4 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TextBox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Datetimepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents TextBox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TextBox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
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
End Class
