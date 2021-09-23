<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefaultSetup
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
        Me.btn_yes = New System.Windows.Forms.Button()
        Me.btn_no = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_yes
        '
        Me.btn_yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_yes.Location = New System.Drawing.Point(43, 84)
        Me.btn_yes.Name = "btn_yes"
        Me.btn_yes.Size = New System.Drawing.Size(55, 23)
        Me.btn_yes.TabIndex = 14
        Me.btn_yes.Text = "Yes"
        Me.btn_yes.UseVisualStyleBackColor = True
        '
        'btn_no
        '
        Me.btn_no.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_no.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_no.ForeColor = System.Drawing.Color.White
        Me.btn_no.Location = New System.Drawing.Point(122, 84)
        Me.btn_no.Name = "btn_no"
        Me.btn_no.Size = New System.Drawing.Size(52, 23)
        Me.btn_no.TabIndex = 15
        Me.btn_no.Text = "No"
        Me.btn_no.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 50)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Are you sure to change back" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to default setting?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DefaultSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 143)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_yes)
        Me.Controls.Add(Me.btn_no)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DefaultSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DefaultSetup"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_yes As Button
    Friend WithEvents btn_no As Button
    Friend WithEvents Label1 As Label
End Class
