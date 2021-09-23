Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Xml
Imports System.IO
Public Class MonitoringDisplay
    Public comport As String
    Dim receivedData As String
    Dim commandCount As Integer = 0
    Dim detik As Integer = 0
    Dim detiks As Integer = 0
    Dim detik2 As Integer = 0
    Dim detik3 As Integer = 0
    Dim detik3s As Integer = 0
    Dim awal As Integer = 0
    Dim tikrun1 As Integer = 0
    Public td2 As Double = 0
    Public td3 As Double = 0
    Dim syst As Double
    Dim dyst As Double
    Dim cobawaktu As String = ""
    Sub HideButtonNaigation()
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Button6.Hide()
    End Sub

    Private Sub MonitoringDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideButtonNaigation()
        Button4.Focus()
        Timer1.Enabled = True
        'Try Connection For Button
        Try
            comport = "COM5"
            KoneksiButton()

        Catch ex As Exception
            'MsgBox("Connection Failed")
        End Try
        setchart()
        Timer3.Enabled = True
        Timer4.Enabled = True
        Timer5.Enabled = True
        'setchart()
    End Sub

    Private Sub MonitoringDisplay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SplashScreen1.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.BackColor = Color.FromArgb(242, 242, 242) Then
            Button1.BackColor = Color.FromArgb(102, 102, 102)
            'incative other button
            Button2.BackColor = Color.FromArgb(242, 242, 242)
            Button2.Image = My.Resources.taskbar_alarm_setup
            Button3.BackColor = Color.FromArgb(242, 242, 242)
            Button3.Image = My.Resources.taskbar_alarm_history
            Button4.BackColor = Color.FromArgb(242, 242, 242)
            Button4.Image = My.Resources.taskbar_monitor_setting
            Button5.BackColor = Color.FromArgb(242, 242, 242)
            Button5.Image = My.Resources.taskbar_patient_data
            Button6.BackColor = Color.FromArgb(242, 242, 242)
            Button6.Image = My.Resources.taskbar_nibp
            Button1.Image = My.Resources.taskbar_home_activated
            AlarmHistory.Close()
        ElseIf Button1.BackColor = Color.FromArgb(102, 102, 102) Then
            'Button1.BackColor = Color.FromArgb(242, 242, 242)
            'Button1.Image = My.Resources.taskbar_home
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mdi.Show()
        If Button2.BackColor = Color.FromArgb(242, 242, 242) Then
            Button2.BackColor = Color.FromArgb(102, 102, 102)
            Button2.Image = My.Resources.taskbar_alarm_setup_activated
            'incative other button
            Button1.BackColor = Color.FromArgb(242, 242, 242)
            Button1.Image = My.Resources.taskbar_home
            Button3.BackColor = Color.FromArgb(242, 242, 242)
            Button3.Image = My.Resources.taskbar_alarm_history
            Button4.BackColor = Color.FromArgb(242, 242, 242)
            Button4.Image = My.Resources.taskbar_monitor_setting
            Button5.BackColor = Color.FromArgb(242, 242, 242)
            Button5.Image = My.Resources.taskbar_patient_data
            Button6.BackColor = Color.FromArgb(242, 242, 242)
            Button6.Image = My.Resources.taskbar_nibp
            AlarmHistory.Close()

        ElseIf Button2.BackColor = Color.FromArgb(102, 102, 102) Then
            Button2.BackColor = Color.FromArgb(242, 242, 242)
            Button2.Image = My.Resources.taskbar_alarm_setup
            Button1.PerformClick()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.BackColor = Color.FromArgb(242, 242, 242) Then
            Button3.BackColor = Color.FromArgb(102, 102, 102)
            Button3.Image = My.Resources.taskbar_alarm_history_activated
            'incative other button
            Button1.BackColor = Color.FromArgb(242, 242, 242)
            Button1.Image = My.Resources.taskbar_home
            Button2.BackColor = Color.FromArgb(242, 242, 242)
            Button2.Image = My.Resources.taskbar_alarm_setup
            Button4.BackColor = Color.FromArgb(242, 242, 242)
            Button4.Image = My.Resources.taskbar_monitor_setting
            Button5.BackColor = Color.FromArgb(242, 242, 242)
            Button5.Image = My.Resources.taskbar_patient_data
            Button6.BackColor = Color.FromArgb(242, 242, 242)
            Button6.Image = My.Resources.taskbar_nibp
            AlarmHistory.Show()
        ElseIf Button3.BackColor = Color.FromArgb(102, 102, 102) Then
            Button3.BackColor = Color.FromArgb(242, 242, 242)
            Button3.Image = My.Resources.taskbar_alarm_history
            AlarmHistory.Close()
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.BackColor = Color.FromArgb(242, 242, 242) Then
            Button4.BackColor = Color.FromArgb(102, 102, 102)
            Button4.Image = My.Resources.taskbar_monitor_setting_activated
            'incative other button
            Button1.BackColor = Color.FromArgb(242, 242, 242)
            Button1.Image = My.Resources.taskbar_home
            Button2.BackColor = Color.FromArgb(242, 242, 242)
            Button2.Image = My.Resources.taskbar_alarm_setup
            Button3.BackColor = Color.FromArgb(242, 242, 242)
            Button3.Image = My.Resources.taskbar_alarm_history
            Button5.BackColor = Color.FromArgb(242, 242, 242)
            Button5.Image = My.Resources.taskbar_patient_data
            Button6.BackColor = Color.FromArgb(242, 242, 242)
            Button6.Image = My.Resources.taskbar_nibp
            AlarmHistory.Close()
        ElseIf Button4.BackColor = Color.FromArgb(102, 102, 102) Then
            Button4.BackColor = Color.FromArgb(242, 242, 242)
            Button4.Image = My.Resources.taskbar_monitor_setting
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.BackColor = Color.FromArgb(242, 242, 242) Then
            Button5.BackColor = Color.FromArgb(102, 102, 102)
            Button5.Image = My.Resources.taskbar_patient_data_activated
            'incative other button
            Button1.BackColor = Color.FromArgb(242, 242, 242)
            Button1.Image = My.Resources.taskbar_home
            Button2.BackColor = Color.FromArgb(242, 242, 242)
            Button2.Image = My.Resources.taskbar_alarm_setup
            Button3.BackColor = Color.FromArgb(242, 242, 242)
            Button3.Image = My.Resources.taskbar_alarm_history
            Button4.BackColor = Color.FromArgb(242, 242, 242)
            Button4.Image = My.Resources.taskbar_monitor_setting
            Button6.BackColor = Color.FromArgb(242, 242, 242)
            Button6.Image = My.Resources.taskbar_nibp
            AlarmHistory.Close()
        ElseIf Button5.BackColor = Color.FromArgb(102, 102, 102) Then
            Button5.BackColor = Color.FromArgb(242, 242, 242)
            Button5.Image = My.Resources.taskbar_patient_data
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.BackColor = Color.FromArgb(242, 242, 242) Then
            Button6.BackColor = Color.FromArgb(102, 102, 102)
            Button6.Image = My.Resources.taskbar_nibp_activated
            'incative other button
            Button1.BackColor = Color.FromArgb(242, 242, 242)
            Button1.Image = My.Resources.taskbar_home
            Button2.BackColor = Color.FromArgb(242, 242, 242)
            Button2.Image = My.Resources.taskbar_alarm_setup
            Button3.BackColor = Color.FromArgb(242, 242, 242)
            Button3.Image = My.Resources.taskbar_alarm_history
            Button4.BackColor = Color.FromArgb(242, 242, 242)
            Button4.Image = My.Resources.taskbar_monitor_setting
            Button5.BackColor = Color.FromArgb(242, 242, 242)
            Button5.Image = My.Resources.taskbar_patient_data
            AlarmHistory.Close()
        ElseIf Button6.BackColor = Color.FromArgb(102, 102, 102) Then
            Button6.BackColor = Color.FromArgb(242, 242, 242)
            Button6.Image = My.Resources.taskbar_nibp
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("dd-MM-yyyy  HH : mm")
        Button1.TabIndex = 0
        TabIndex = +1
    End Sub

    Sub KoneksiButton()
        If (comport <> "") Then
            SerialPort1.Close()
            SerialPort1.PortName = comport
            SerialPort1.BaudRate = 9600
            SerialPort1.DataBits = 8
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.Handshake = Handshake.None
            SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
            SerialPort1.ReadTimeout = 10000
            SerialPort1.Open()
            Timer2.Enabled = True
            'MsgBox("Connection Success")
        Else
            MessageBox.Show("Select a Port", "Connect Port", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        receivedData = ReceiveSerialData()
        Label7.Text = receivedData
        If receivedData.Contains("q") Then
            Button1.PerformClick()
        ElseIf receivedData.Contains("w") Then
            Button2.PerformClick()
        ElseIf receivedData.Contains("e") Then
            Button3.PerformClick()
        ElseIf receivedData.Contains("r") Then
            Button4.PerformClick()
        ElseIf receivedData.Contains("t") Then
            Button5.PerformClick()
        ElseIf receivedData.Contains("y") Then
            Button6.PerformClick()
        ElseIf receivedData.Contains("u") Then
            MsgBox("Button Pushed OK")
        ElseIf receivedData.Contains("o") Then
            MsgBox("Move Right OK")
        ElseIf receivedData.Contains("p") Then
            MsgBox("Move Left OK")
        End If
    End Sub

    Sub ReadingFileSPO2()
        Dim fileReader As String
        Dim minimumspo2 As Integer = 9999
        Dim maximumspo2 As Integer = 0
        fileReader = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\tpoint.txt", System.Text.Encoding.Default)
        If fileReader <> "127" Then
            muispo2.Text = fileReader
            If fileReader < minimumspo2 Then
                minimumspo2 = fileReader
                Label7.Text = minimumspo2
            End If
            If fileReader > maximumspo2 Then
                maximumspo2 = fileReader
                Label6.Text = maximumspo2
            End If
        Else
            muispo2.Text = "--"
        End If


    End Sub
    Sub ReadingFileTEMP1()
        Dim fileReader As String
        Dim minimumtemp1 As Integer = 9999
        Dim maximumtemp1 As Integer = 0
        fileReader = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\temp1.txt", System.Text.Encoding.Default)
        If fileReader <> "555" Then
            muitemp1.Text = fileReader
            td2 = fileReader
            'If fileReader < minimumtemp1 Then
            '    minimumtemp1 = fileReader
            '    Label14.Text = minimumtemp1
            'End If
            'If fileReader > maximumtemp1 Then
            '    maximumtemp1 = fileReader
            '    Label22.Text = maximumtemp1
            'End If
        Else
            muitemp1.Text = "--.-"
        End If


    End Sub

    Sub ReadingFileTEMP2()
        Dim fileReader As String
        Dim minimumtemp1 As Integer = 9999
        Dim maximumtemp1 As Integer = 0
        fileReader = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\temp2.txt", System.Text.Encoding.Default)
        If fileReader <> "555" Then
            muitemp2.Text = fileReader
            td3 = fileReader
            'If fileReader < minimumtemp1 Then
            '    minimumtemp1 = fileReader
            '    Label14.Text = minimumtemp1
            'End If
            'If fileReader > maximumtemp1 Then
            '    maximumtemp1 = fileReader
            '    Label22.Text = maximumtemp1
            'End If
        Else
            muitemp2.Text = "--.-"
        End If
    End Sub

    Sub ReadingFileECGHR()
        Dim fileReader As String
        Dim minimumtemp1 As Integer = 9999
        Dim maximumtemp1 As Integer = 0
        fileReader = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\ecghr.txt", System.Text.Encoding.Default)
        If fileReader <> "65436" Then
            ecghr.Text = fileReader
            'td3 = fileReader
            'If fileReader < minimumtemp1 Then
            '    minimumtemp1 = fileReader
            '    Label14.Text = minimumtemp1
            'End If
            'If fileReader > maximumtemp1 Then
            '    maximumtemp1 = fileReader
            '    Label22.Text = maximumtemp1
            'End If
        Else
            ecghr.Text = "---"
        End If
    End Sub

    Sub ReadingFileECGRR()
        Dim fileReader As String
        Dim minimumtemp1 As Integer = 9999
        Dim maximumtemp1 As Integer = 0
        fileReader = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\ecgrr.txt", System.Text.Encoding.Default)
        If fileReader <> "65436" Then
            ecgrr.Text = fileReader
            'td3 = fileReader
            'If fileReader < minimumtemp1 Then
            '    minimumtemp1 = fileReader
            '    Label14.Text = minimumtemp1
            'End If
            'If fileReader > maximumtemp1 Then
            '    maximumtemp1 = fileReader
            '    Label22.Text = maximumtemp1
            'End If
        Else
            ecgrr.Text = "---"
        End If
    End Sub

    Sub ReadingFileBPRM()
        Dim fileReader As String
        Dim minimumtemp1 As Integer = 9999
        Dim maximumtemp1 As Integer = 0
        fileReader = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\bprm.txt", System.Text.Encoding.Default)
        If fileReader <> "511" Then
            bprm1.Text = fileReader
            'td3 = fileReader
            'If fileReader < minimumtemp1 Then
            '    minimumtemp1 = fileReader
            '    Label14.Text = minimumtemp1
            'End If
            'If fileReader > maximumtemp1 Then
            '    maximumtemp1 = fileReader
            '    Label22.Text = maximumtemp1
            'End If
        Else
            bprm1.Text = "---"
        End If
    End Sub

    Sub ReadingFilePI1()
        Dim fileReader As String
        Dim piii As Double
        Dim minimumtemp1 As Integer = 9999
        Dim maximumtemp1 As Integer = 0
        fileReader = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\pi1.txt", System.Text.Encoding.Default)
        If fileReader <> "511" Then
            piii = Val(fileReader)
            pi1.Text = piii.ToString("F1")
            'td3 = fileReader
            'If fileReader < minimumtemp1 Then
            '    minimumtemp1 = fileReader
            '    Label14.Text = minimumtemp1
            'End If
            'If fileReader > maximumtemp1 Then
            '    maximumtemp1 = fileReader
            '    Label22.Text = maximumtemp1
            'End If
        Else
            pi1.Text = "---"
        End If
    End Sub

    Sub ReadingFileDYS()
        Dim fileReader As String
        Dim minimumtemp1 As Integer = 9999
        Dim maximumtemp1 As Integer = 0
        fileReader = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\dys.txt", System.Text.Encoding.Default)
        If fileReader <> "65203" Then
            dyst = Val(fileReader)
            'pi1.Text = dyst.ToString("F1")
            'td3 = fileReader
            'If fileReader < minimumtemp1 Then
            '    minimumtemp1 = fileReader
            '    Label14.Text = minimumtemp1
            'End If
            'If fileReader > maximumtemp1 Then
            '    maximumtemp1 = fileReader
            '    Label22.Text = maximumtemp1
            'End If
        Else
            ''muitemp2.Text = "---"
        End If
    End Sub

    Sub ReadingFileSYS()
        Dim fileReader As String

        Dim minimumtemp1 As Integer = 9999
        Dim maximumtemp1 As Integer = 0
        fileReader = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\sys.txt", System.Text.Encoding.Default)
        If fileReader <> "65203" Then
            syst = Val(fileReader)
            sysdys.Text = syst & "/" & dyst
            'td3 = fileReader
            'If fileReader < minimumtemp1 Then
            '    minimumtemp1 = fileReader
            '    Label14.Text = minimumtemp1
            'End If
            'If fileReader > maximumtemp1 Then
            '    maximumtemp1 = fileReader
            '    Label22.Text = maximumtemp1
            'End If
        Else
            sysdys.Text = "---"
        End If
    End Sub
    Sub ReadingFileCHART()
        Try
            Dim fileReader As String
            Dim y1 As Double

            fileReader = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\y1.txt", System.Text.Encoding.Default)
            y1 = Val(fileReader)
            Chart2.Series("spo2").Points.AddXY(detik2, Val(y1))

            If detik2 = 599 Then
                detik3s = 0
            End If

            If detik2 >= 600 Then
                Chart2.Series("spo2").Points.RemoveAt(0)
                Chart2.Series("spo3").Points.AddXY(detik3s, Val(y1))
            End If

            If detik3s = 599 Then
                Chart2.Series("spo2").Points.Clear()
                detik2 = 0
            End If

            If detik3s >= 600 Then
                Chart2.Series("spo3").Points.RemoveAt(0)
                Chart2.Series("spo2").Points.AddXY(detik2, Val(y1))
            End If

        Catch ex As Exception
        End Try
    End Sub


    Sub ReadingFileChartRR()
        Try
            Dim fileReader4 As String
            Dim resp1 As Double
            Dim minimumtemp1 As Integer = 9999
            Dim maximumtemp1 As Integer = 0
            fileReader4 = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\ecgresp.txt", System.Text.Encoding.Default)
            If fileReader4 <> "654" Then
                resp1 = Val(fileReader4)
                Chart1.Series("rr").Points.AddXY(detik3, Val(resp1))
            Else
                Chart1.Series("rr").Points.AddXY(detik3, Val(resp1))
            End If
            If detik3 >= 600 Then
                Chart1.Series("rr").Points.Clear()
                detik3 = 0
            End If
        Catch ex As Exception
        End Try
    End Sub


    Sub ReadingFileChartECG()
        Try
            Dim fileReader2 As String
            Dim fileReader3 As String
            Dim ecg1 As Double
            Dim ecg2 As Double


            fileReader2 = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\ecgwave2.txt", System.Text.Encoding.Default)
            'If fileReader2 <> "654" Then
            ecg1 = Val(fileReader2)

            Chart3.Series("ecg1").Points.AddXY(detik, Val(ecg1))
            'Else
            'Chart3.Series("ecg1").Points.AddXY(detik, Val(ecg1))
            'End If
            'If detiks Then
            'Chart3.Series("ecg1a").Enabled = False

            If detik < 249 Then
                Chart3.Series("ecg1a").Points.RemoveAt(0)
                Chart3.ChartAreas(0).AxisX.Maximum = 250
                Timer4.Interval = 1
            End If

            If detik = 249 Then
                Chart3.Series("ecg1a").Points.Clear()
                Chart3.ChartAreas(0).AxisX.Maximum = 250
                Timer4.Enabled = False
                Timer4.Interval = 1
                Timer4.Enabled = True
            End If

            If detik >= 250 Then
                'Chart3.Series("ecg1a").Enabled = True
                Chart3.Series("ecg1").Points.RemoveAt(0)
                Chart3.Series("ecg1a").Points.AddXY(detik - 250, Val(ecg1))
                Chart3.ChartAreas(0).AxisX.Maximum = 250
                Timer4.Interval = 1
            End If

            If detik >= 500 Then
                Chart3.Series("ecg1").Points.Clear()
                detik = 0
                Timer4.Enabled = False
                Timer4.Interval = 1
                Timer4.Enabled = True
                Chart3.ChartAreas(0).AxisX.Maximum = 250
            End If

            'fileReader3 = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\ecgwave.txt", System.Text.Encoding.Default)
            'If fileReader3 <> "654" Then
            '    ecg2 = Val(fileReader3)
            '    Chart4.Series("ecg2").Points.AddXY(detik, Val(ecg2))
            'Else
            '    Chart4.Series("ecg2").Points.AddXY(detik, Val(ecg2))
            'End If

            'If detik >= 250 Then
            '    Chart3.Series("ecg1").Points.Clear()
            '    Chart4.Series("ecg2").Points.Clear()
            '    detik = 0
            '    Chart3.ChartAreas(0).AxisX.Minimum = 0
            '    Chart3.ChartAreas(0).AxisX.Maximum = 250
            '    Chart4.ChartAreas(0).AxisX.Minimum = 0
            '    Chart4.ChartAreas(0).AxisX.Maximum = 250
            'End If

        Catch ex As Exception
        End Try
    End Sub
    '

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            detik = detik + 1
            detiks = detiks + 1
            detik2 = detik2 + 1
            detik3 = detik3 + 1
            detik3s = detik3s + 1
            Label12.Text = detik
            Label13.Text = detik - 250
            Label15.Text = Val(Label12.Text) - Val(Label13.Text)


            Dim td1 As Double
            ReadingFileSPO2()
            ReadingFileTEMP1()
            ReadingFileTEMP2()
            ReadingFileECGHR()
            ReadingFileECGRR()
            ReadingFileBPRM()
            ReadingFilePI1()
            ReadingFileDYS()
            ReadingFileSYS()
            Try
                ReadingFileCHART()
            Catch ex As Exception
            End Try
            td1 = td2 - td3
            td1 = td1.ToString("F1")
            muitd.Text = Math.Abs(td1)
        Catch ex As Exception
        End Try
    End Sub

    Sub setchart()
        'CHART RR
        Chart1.Series.Add("rr")
        Chart1.Series("rr").ChartType = SeriesChartType.Spline
        Chart1.Series("rr").Color = Color.Lime
        Dim CArea1 As ChartArea = Chart1.ChartAreas(0)
        CArea1.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Regular)
        CArea1.AxisX.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea1.AxisX.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea1.AxisY.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea1.AxisX.Maximum = 600
        CArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Regular)
        CArea1.AxisY.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea1.AxisY.LabelStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea1.AxisX.LabelStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea1.AxisY.MajorTickMark.Enabled = False

        'CHART SPO2
        Chart2.Series.Add("spo2")
        Chart2.Series("spo2").ChartType = SeriesChartType.Spline
        Chart2.Series("spo2").Color = Color.DodgerBlue

        Chart2.Series.Add("spo3")
        Chart2.Series("spo3").ChartType = SeriesChartType.Spline
        Chart2.Series("spo3").Color = Color.DodgerBlue

        Dim CArea2 As ChartArea = Chart2.ChartAreas(0)
        CArea2.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea2.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Regular)
        CArea2.AxisX.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea2.AxisX.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea2.AxisY.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea2.AxisX.Maximum = 600
        CArea2.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Regular)
        CArea2.AxisY.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea2.AxisY.LabelStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea2.AxisX.LabelStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea2.AxisY.MajorTickMark.Enabled = False

        'CHART ECG L1
        Chart3.Series.Add("ecg1")
        Chart3.Series("ecg1").ChartType = SeriesChartType.Spline
        Chart3.Series("ecg1").Color = Color.Lime

        Chart3.Series.Add("ecg1a")
        Chart3.Series("ecg1a").ChartType = SeriesChartType.Spline
        Chart3.Series("ecg1a").Color = Color.Lime


        Dim CArea3 As ChartArea = Chart3.ChartAreas(0)
        CArea3.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea3.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Regular)
        CArea3.AxisX.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea3.AxisX.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea3.AxisY.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea3.AxisX.Maximum = 250
        CArea3.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Regular)
        CArea3.AxisY.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea3.AxisY.LabelStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea3.AxisX.LabelStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF")
        'CArea3.AxisX.LabelStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea3.AxisX.MajorTickMark.Enabled = True
        CArea3.AxisY.Minimum = -650
        CArea3.AxisY.Maximum = 1300


        'CHART ECG L2
        Chart4.Series.Add("ecg2")
        Chart4.Series("ecg2").ChartType = SeriesChartType.Spline
        Chart4.Series("ecg2").Color = Color.Lime
        Dim CArea4 As ChartArea = Chart4.ChartAreas(0)
        CArea4.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea4.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Regular)
        CArea4.AxisX.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea4.AxisX.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea4.AxisY.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea4.AxisX.Maximum = 250
        CArea4.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Regular)
        CArea4.AxisY.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea4.AxisY.LabelStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        CArea4.AxisX.LabelStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1A1A1A")
        'CArea4.AxisX.LabelStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF")
        CArea4.AxisY.MajorTickMark.Enabled = False
        CArea4.AxisY.Minimum = -650
        CArea4.AxisY.Maximum = 1300

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'running ecg
        Try
            ReadingFileChartECG()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        'running rr
        Try
            ReadingFileChartRR()
        Catch ex As Exception

        End Try
    End Sub
End Class