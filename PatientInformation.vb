Option Strict Off
Imports System.ComponentModel
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
        MonitoringDisplay.LabelPatient.Text = txt_first_name.Text & " " & txt_last_name.Text
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
        Update_Data_Patient()
        Panel2.Hide()
        Panel3.Show()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Datetimepicker1_onValueChanged(sender As Object, e As EventArgs) Handles Datetimepicker1.onValueChanged
        Me.txt_age.Text = calculateAge(Me.Datetimepicker1.Value, Now)
    End Sub
    Function calculateAge(dateOfBird As Date, fromDate As Date) As String
        Dim dateNow As Date
        Dim tgl As Date
        Dim years As Long
        Dim months As Long
        Dim days As Long
        Dim yearWord As String
        Dim monthWord As String
        Dim dayWord As String
        dateNow = fromDate
        tgl = dateOfBird
        ' menghitung tahun
        years = DateDiff("yyyy", tgl, dateNow)
        If Month(tgl) > Month(dateNow) Then
            years = years - 1
        ElseIf Month(tgl) = Month(dateNow) And tgl.Day > dateNow.Day Then
            years = years - 1
        ElseIf Month(tgl) = Month(dateNow) And tgl.Day = dateNow.Day Then
            GoTo Finish ' jika bulan dan tanggal sama maka perhitungan selesai
        End If
        ' menghitung bulan
        tgl = DateAdd("yyyy", years, tgl)
        months = DateDiff("m", tgl, dateNow)
        If tgl.Day > dateNow.Day Then
            months = months - 1
        ElseIf Month(tgl) = Month(dateNow) And tgl.Day >= dateNow.Day Then
            months = months - 1
        End If
        tgl = DateAdd("m", months, tgl)
        ' menghitung hari
        days = DateDiff("d", tgl, dateNow)
Finish:
        yearWord = IIf(years = 0, "", years & " Tahun ")
        monthWord = IIf(months = 0, "", months & " Bulan ")
        dayWord = IIf(days = 0, "", days & " Hari ")
        calculateAge = yearWord & monthWord & dayWord
        calculateAge = Trim(calculateAge)
    End Function

    Private Sub btn_show_keyboard_Click(sender As Object, e As EventArgs) Handles btn_show_keyboard.Click
        Keyboard_Screen_Open()
    End Sub

    Private Sub PatientInformation_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Keyboard_Screen_Close()
    End Sub
End Class