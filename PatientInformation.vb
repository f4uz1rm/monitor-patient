Imports System.Data.OleDb
Public Class PatientInformation
    Private Sub PatientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.FormBorderStyle = FormBorderStyle.None
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)
        Panel2.Hide()
        Tampil_Texbox()
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Update_Data_Patient()
    End Sub

    Function InputTextBox(Status As Boolean)
        txt_first_name.Enabled = Status
        txt_last_name.Enabled = Status
        Datetimepicker1.Enabled = Status
        txt_age.Enabled = Status
        txt_height.Enabled = Status
        txt_weight.Enabled = Status
        cb_gender.Enabled = Status
        txt_profession.Enabled = Status
        txt_doctor.Enabled = Status
        txt_nurse.Enabled = Status
        Return Status
    End Function

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Panel2.Show()
        Panel3.Hide()
    End Sub
    Sub DeleteTextBoxAll()
        txt_first_name.Text = ""
        txt_last_name.Text = ""
        Datetimepicker1.Text = ""
        txt_age.Text = ""
        txt_height.Text = ""
        txt_weight.Text = ""
        cb_gender.Text = ""
        txt_profession.Text = ""
        txt_doctor.Text = ""
        txt_nurse.Text = ""
    End Sub

    Private Sub btn_no_Click(sender As Object, e As EventArgs) Handles btn_no.Click
        Panel3.Show()
        Panel2.Hide()
    End Sub

    Private Sub btn_yes_Click(sender As Object, e As EventArgs) Handles btn_yes.Click
        DeleteTextBoxAll()
        Panel2.Hide()
        Panel3.Show()
    End Sub
End Class