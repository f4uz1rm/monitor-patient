Option Strict Off
Imports System.ComponentModel
Public Class AddPatient
    Private Sub AddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub btn_cancle_Click(sender As Object, e As EventArgs) Handles btn_cancle.Click
        Me.Close()
        Keyboard_Screen_Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        Add_Patient_Update_Data_Patient()
        MonitoringDisplay.LabelPatient.Text = txt_first_name.Text & " " & txt_last_name.Text
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

    Private Sub AddPatient_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Keyboard_Screen_Close()
    End Sub
End Class