Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Xml
Imports System.IO
Imports System.Data.OleDb
Imports System.Media
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

    Sub Tampil_Nama_Patient()
        Try
            Koneksi()
            syntak = "SELECT*FROM Table_Patient where ID='DP001'"
            cmd = New OleDbCommand(syntak, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                LabelPatient.Text = dr.Item("First_Name") & " " & dr.Item("Last_Name")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MonitoringDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil_Nama_Patient()
        'OpenMultiParameter()
        HideButtonNaigation()

        'Connection - COM 5
        COM5Connecting()


        'Batas
        Button4.Focus()
        Timer1.Enabled = True
        'Try Connection For Button
        'Try
        'comport = "COM5"
        'KoneksiButton()
        'Catch ex As Exception
        'MsgBox("Connection Failed")
        'End Try
        setchart()
        'Timer3.Enabled = False
        'Timer4.Enabled = False
        'Timer5.Enabled = False
    End Sub

    Sub OpenMultiParameter()
        Dim myFile As New System.Diagnostics.Process
        With myFile
            .StartInfo.WorkingDirectory = "C:\Users\GAMING\Documents\GitHub\Multi_Para_Monitor\Debug\"
            .StartInfo.FileName = "Multi_Para Monitor.exe"
        End With
        myFile.Start()
    End Sub
    Sub CloseMultiParameter()

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
        LabelSpo2Min.Text = receivedData
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
        fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\GAMING\Documents\GitHub\Multi_Para_Monitor\Debug\txt\m_uiSpO2.txt", System.Text.Encoding.Default)
        If fileReader <> "127" Then
            muispo2.Text = fileReader
            If fileReader < minimumspo2 Then
                minimumspo2 = fileReader
                LabelSpo2Min.Text = minimumspo2
            End If
            If fileReader > maximumspo2 Then
                maximumspo2 = fileReader
                LabelSpo2Max.Text = maximumspo2
            End If
        Else
            muispo2.Text = "--"
        End If


    End Sub
    Sub ReadingFileTEMP1()
        Dim fileReader As String
        Dim minimumtemp1 As Integer = 9999
        Dim maximumtemp1 As Integer = 0
        fileReader = My.Computer.FileSystem.ReadAllText("", System.Text.Encoding.Default)
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
    Dim PathFileReader As String = "C:\Users\KQ\Documents\Visual Studio 2015\Projects\Multi_Para Monitor V3\ecgrr.text"
    Function ReadingFileChartRR(NameFile As String, NameChart As Chart)
        Try
            Dim fileReader4 As String
            Dim resp1 As Double
            Dim minimumtemp1 As Integer = 9999
            Dim maximumtemp1 As Integer = 0
            fileReader4 = My.Computer.FileSystem.ReadAllText(PathFileReader, System.Text.Encoding.Default)
            If fileReader4 <> "654" Then
                resp1 = Val(fileReader4)
                NameChart.Series("rr").Points.AddXY(detik3, Val(resp1))
            Else
                NameChart.Series("rr").Points.AddXY(detik3, Val(resp1))
            End If
            If detik3 >= 600 Then
                NameChart.Series("rr").Points.Clear()
                detik3 = 0
            End If
        Catch ex As Exception
        End Try
    End Function
    Sub ReadingFileChartECG()

        Try
            Dim fileReader2 As String
            'Dim fileReader3 As String
            Dim ecg1 As Double
            'Dim ecg2 As Double


            fileReader2 = My.Computer.FileSystem.ReadAllText("C:\Users\KQ\Documents\Visual Studio 2015\Projects\Multi_Para Monitor V3\ecgwave2.txt", System.Text.Encoding.Default)
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
            LabelEcgMin.Text = detik
            LabelEcgMax.Text = detik - 250
            Label15.Text = Val(LabelEcgMin.Text) - Val(LabelEcgMax.Text)


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




    Dim MaxAxisX As Integer = 600
    Dim MinAxisX As Integer
    Sub setchart()
        'Chart RR
        Chart1.ChartAreas(0).AxisX.Maximum = MaxAxisX
        'Chart SPO
        Chart2.ChartAreas(0).AxisX.Minimum = MinAxisX
        Chart2.ChartAreas(0).AxisX.Maximum = MaxAxisX
        'CHART ECG L1
        Chart3.ChartAreas(0).AxisX.Maximum = MaxAxisX
        'CHART ECG L2
        Chart4.ChartAreas(0).AxisX.Maximum = MaxAxisX

    End Sub
    Dim NameTemp1 As String = "txt\temp1.txt"
    Dim NameTemp2 As String = "txt\temp2.txt"
    'SPO2
    Dim SpO2 As String = "txt\m_uiSpO2.txt"
    'SPO2 Status
    Dim SpO2Status As String = "txt\statusSpo2.txt"
    Dim PulseRate As String = "txt\m_uiPulseRate.txt"
    Dim Pi As String = "txt\m_uiPi.txt"
    'ECG
    Dim ECG As String = "txt\m_uiHr.txt"
    Dim RR As String = "txt\m_uiRr.txt"
    'ECG Status
    Dim ECGStatus As String = "txt\statusEcg.txt"
    Dim SetNormal As Integer = 90

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'running ecg
        Try
            'SPO
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles TimerReceivedData.Tick
        'running rr

        Try
            'SPO2
            FileReaderInfo(PathLoc + SpO2, muispo2)
            FileReaderInfo(PathLoc + PulseRate, bprm1)
            FileReaderInfo(PathLoc + Pi, pi1)

            'TEMP
            FileReaderInfo(PathLoc + NameTemp1, muitemp1)
            FileReaderInfo(PathLoc + NameTemp2, muitemp2)
            'ECG
            FileReaderInfo(PathLoc + ECG, ecghr)
            'RR
            FileReaderInfo(PathLoc + RR, ecgrr)
            'Status SPO2
            FileReaderInfo(PathLoc + SpO2Status, LabelStatusSpo2)

            'FileReaderInfo(PathLoc + SpO2Status, LabelStatusSpo2)
            'Status SPO2
            'FileReaderInfo(PathLoc + ECGStatus, LabelStatusLead1)

            'Wave
            'ChartActive("spo2", muispo2.Text, Chart2)
            'WAVE ECG
            ChartActive("ecg1", ecghr.Text, Chart3)
            ChartActive("ecg2", ecghr.Text, Chart4)
            ChartActive("rr", LabelRRMin.Text, Chart1)

            'ECG
            'ChartActive("ecg1", ecghr.Text, Chart3)
            'ChartActive("ecg2", ecghr.Text, Chart4)
            'SPO Chart
            'ChartActive("spo2", muispo2.Text, Chart2)
            'ChartActive("spo2", SetNormal, Chart2)

            FilterSet()
        Catch ex As Exception

        End Try
    End Sub

    Sub FilterSet()
        Select Case muispo2.Text
            Case "127"
                muispo2.Text = "--"
            Case Else
                FileReaderInfo(PathLoc + SpO2, muispo2)
        End Select


        Select Case bprm1.Text
            Case "511"
                bprm1.Text = "--"
            Case Else
                FileReaderInfo(PathLoc + PulseRate, bprm1)
        End Select

        Select Case pi1.Text
            Case "0"
                pi1.Text = "--"
            Case Else
                FileReaderInfo(PathLoc + Pi, pi1)
        End Select

        Select Case ecghr.Text
            Case 30
                ecghr.Text = "--"
            Case Else
                FileReaderInfo(PathLoc + ECG, ecghr)
        End Select

        Select Case muitemp1.Text
            Case 55
                muitemp1.Text = "--"
            Case Else
                FileReaderInfo(PathLoc + NameTemp1, muitemp1)
        End Select

        Select Case muitemp2.Text
            Case 55
                muitemp2.Text = "--"
            Case Else
                FileReaderInfo(PathLoc + NameTemp2, muitemp2)
        End Select

    End Sub
    Function FileReaderInfo(PathLoc As String, LabelName As Label)
        ' Store the line in this String.
        Dim line As String
        Dim FilePath As String = PathLoc
        ' Create new StreamReader instance with Using block.
        Using reader As StreamReader = New StreamReader(FilePath)
            ' Read one line from file
            line = reader.ReadLine
        End Using

        ' Write the line we read from "file.txt"
        Console.WriteLine("Info :" & line)
        LabelName.Text = line
        Return {PathLoc}
    End Function


    Function FileReaderWave(PathLoc As String, NameSeries As String, ChartName As Chart)
        ' Store the line in this String.
        Dim line As String
        Dim FilePath As String = PathLoc
        ' Create new StreamReader instance with Using block.
        Using reader As StreamReader = New StreamReader(FilePath)
            ' Read one line from file
            line = reader.ReadLine
        End Using

        ' Write the line we read from "file.txt"
        Console.WriteLine("Wave" & line)
        'ChartActive(NameSeries, line, ChartName)
        ChartName.Series(NameSeries).Points.AddXY(detik3, line)
    End Function
    Public isMouseDown As Boolean = False
    Public mouseOffset As Point
    Private Sub MonitoringDisplay_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub MonitoringDisplay_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Mdi.Location = mousePos
        End If
    End Sub

    Private Sub MonitoringDisplay_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub
    Shared MyValue As New Random()
    Dim NameSeries As String
    Dim ValueChartSeries As String
    Dim ChartValue As Chart

    Private Sub TimerRandom_Tick(sender As Object, e As EventArgs)
        ecghr.Text = MyValue.Next(110, 180)
        muispo2.Text = MyValue.Next(110, 180)
        muitd.Text = MyValue.Next(10, 70)
        muitemp1.Text = MyValue.Next(10, 70)
        muitemp2.Text = MyValue.Next(10, 70)
        ecgrr.Text = MyValue.Next(50, 60)
        sysdys.Text = MyValue.Next(10, 70) & "/" & MyValue.Next(10, 70)
        ChartActive("rr", ecgrr.Text, Chart1)
        ChartActive("spo2", muispo2.Text, Chart2)
        ChartActive("ecg1", ecghr.Text, Chart3)
        ChartActive("ecg2", ecghr.Text, Chart4)
        AudioHBAlarm()
    End Sub
    Function ChartActive(NameSeries As String, ValueChartSeries As Integer, ChartName As Chart)
        If ChartName.Series(NameSeries).Points.AddXY(detik3, ValueChartSeries) >= ChartName.Size.Width Then
            ChartName.Series(NameSeries).Points.RemoveAt(0)
            'ChartName.Series(NameSeries).Points.Clear()
        Else
            ChartName.Series(NameSeries).Points.AddXY(detik3, ValueChartSeries)
        End If
        Return {NameSeries, ValueChartSeries, ChartName}
    End Function
    Private Sub TimerBlue_Tick(sender As Object, e As EventArgs) Handles TimerBlue.Tick
        BlueButton()
    End Sub


    Private Sub TimerCOM3_Tick(sender As Object, e As EventArgs) Handles TimerCOM3.Tick
        COM3Connecting()
    End Sub
    Sub COM3Connecting()
        SerialPort1.Close()
        SerialPort1.PortName = "COM3"
        SerialPort1.BaudRate = 1200
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
        SerialPort1.ReadTimeout = 10000
        SerialPort1.Open()
        MsgBox("Connection Success COM 3")
        SerialPort1.Close()
        TimerCOM3.Stop()
        MsgBox("Disconnection Success COM 3")

    End Sub



    Private Sub MonitoringDisplay_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Mdi.WindowState = FormWindowState.Maximized
        Me.Dock = DockStyle.Fill
    End Sub

    Private Sub MonitoringDisplay_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        StopBackgroundSound()
    End Sub

    Private Sub TimerSpo2_Tick(sender As Object, e As EventArgs) Handles TimerSpo2.Tick
        If muispo2.Text = "--" Then
            ChartActive("spo2", 80, Chart2)

        Else
            ChartActive("spo2", muispo2.Text, Chart2)

        End If

    End Sub

    Private Sub TimerMax_Tick(sender As Object, e As EventArgs) Handles TimerMax.Tick
        ChartActive("spo2", 80, Chart2)
    End Sub

    Private Sub TimerMin_Tick(sender As Object, e As EventArgs) Handles TimerMin.Tick
        If bprm1.Text = "--" Then
            ChartActive("spo2", 80, Chart2)
        Else
            ChartActive("spo2", bprm1.Text, Chart2)
        End If
    End Sub
    Dim StatusActive As Boolean
    Dim NameStatusECG As String = "ECG HIGH"
    Dim NameStatusSPO2 As String = "SPO2 LOW"
    Dim NameStatusRR As String = "RR"
    Dim EcgValue As Integer
    Dim RRValue As Integer
    Dim Spo2Value As Integer
    Private Sub TimerNotification_Tick(sender As Object, e As EventArgs) Handles TimerNotification.Tick
        If ecghr.Text = "--" Then
            EcgValue = 100
        Else
            EcgValue = ecghr.Text
            NotificationStatusECG(EcgValue, NameStatusECG)
        End If

        If muispo2.Text = 127 Then

            Spo2Value = 127
        Else
            Spo2Value = muispo2.Text
            NotificationStatusSPO2(Spo2Value, NameStatusSPO2)
        End If

        If ecgrr.Text = "--" Then
            RRValue = 20
        Else
            RRValue = ecgrr.Text
            NotificationStatusRR(RRValue)
        End If
    End Sub
End Class
