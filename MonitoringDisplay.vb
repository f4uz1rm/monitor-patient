Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Xml
Imports System.IO
Imports System.Data.OleDb
Imports System.Threading
Imports System.Media
Imports System.Runtime.InteropServices
Public Class MonitoringDisplay
    Public Gain1 As Integer 'WaveSpo2
    Public Gain2 As Integer 'WaveSpo2
    Public GainECG1a As Integer
    Public GainECG1b As Integer
    Public GainResp1 As Integer
    Public GainResp2 As Integer
    Public comport As String
    Dim receivedData As String
    Dim commandCount As Integer = 0
    Dim detik As Integer = 0
    Dim detiks As Integer = 0
    Public detik2 As Integer = 0
    Dim detik3 As Integer = 0
    Public detik3s As Integer = 0
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
        HideButtonNaigation()

        'Connection - COM 5
        COM5Connecting()

        'Batas
        Button4.Focus()
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
    Dim App As New Process
    Sub OpenApp()
        App.StartInfo.FileName = PathLoc + "Multi_Para Monitor.exe"
        Thread.Sleep(5000)
        App.Start()
    End Sub
    Sub CloseMultiParameter()

    End Sub
    Private Sub MonitoringDisplay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SplashScreen1.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        LabelTanggal_Jam.Text = DateTime.Now.ToString("dd-MM-yyyy  HH : mm")
        Button1.TabIndex = 0
        TabIndex = +1
    End Sub
    Sub ReadingFileSPO2()
        Dim fileReader As String
        Dim minimumspo2 As Integer = LabelSpo2Min.Text
        Dim maximumspo2 As Integer = LabelSpo2Max.Text
        fileReader = My.Computer.FileSystem.ReadAllText("C:\M001 - Copy\Multi_Para Monitor V3\tpoint.txt", System.Text.Encoding.Default)
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

    Dim PathFileReader As String = "C:\M001 - Copy\Multi_Para Monitor V3\ecgrr.text"
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
        Return 0
    End Function

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
                ReadingFileChartSpo2()
                ReadingFileChartECG()
            Catch ex As Exception
            End Try
            td1 = td2 - td3
            td1 = td1.ToString("F1")
            muitd.Text = Math.Abs(td1)
        Catch ex As Exception
        End Try
    End Sub
    Dim MaxAxisX As Integer = 500
    Public MaxAxisXSpo2 As Integer = 1000
    Public MaxAxisECG1 As Integer = 1000
    Public MaxAxisResp As Integer = 1000
    Dim MinAxisX As Integer = 0
    Sub setchart()
        'Chart RR
        Chart1.ChartAreas(0).AxisX.Maximum = MaxAxisECG1
        Chart1.ChartAreas(0).AxisX.Minimum = MinAxisX

        'Chart SPO
        Chart2.ChartAreas(0).AxisX.Maximum = MaxAxisXSpo2
        Chart2.ChartAreas(0).AxisX.Minimum = MinAxisX
        'Chart2.ChartAreas(0).AxisY.Interval = 50
        'CHART ECG L1
        Chart3.ChartAreas(0).AxisX.Maximum = MaxAxisECG1
        Chart3.ChartAreas(0).AxisX.Minimum = MinAxisX

        'CHART ECG L2
        Chart4.ChartAreas(0).AxisX.Maximum = MaxAxisECG1
        Chart4.ChartAreas(0).AxisX.Minimum = MinAxisX


    End Sub
    Dim NameTemp1 As String = "txt\temp1.txt"
    Dim NameTemp2 As String = "txt\temp2.txt"
    'SPO2
    Dim SpO2 As String = "txt\m_uiSpO2.txt"
    'SPO2 Status
    Dim SpO2Status As String = "txt\statusSpo2.txt"
    'Wave
    Dim WaveSpo2 As String = "txt\waveSpo2.txt"
    Dim WaveEcg As String = "txt\waveEcg.txt"
    Dim WaveResp As String = "txt\waveResp.txt"

    Dim PulseRate As String = "txt\m_uiPulseRate.txt"
    Dim Pi As String = "txt\m_uiPi.txt"
    'ECG
    Dim ECG As String = "txt\m_uiHr.txt"
    Dim RR As String = "txt\m_uiRr.txt"
    'ECG Status
    Dim ECGStatus As String = "txt\statusEcg.txt"
    Sub TickTick()
        Try
            detik = detik + 1
            detiks = detiks + 1
            detik2 = detik2 + 5
            detik3 = detik3 + 1
            detik3s = detik3s + 5


            'Label15.Text = Val(LabelEcgMin.Text) - Val(LabelEcgMax.Text)


            Dim td1 As Double
            ReadingFileSPO2()
            ' ReadingFileTEMP1()
            'ReadingFileTEMP2()
            ReadingFileECGHR()
            ReadingFileECGRR()
            ReadingFileBPRM()
            ReadingFilePI1()
            'ReadingFileDYS()
            'ReadingFileSYS()
            Try

            Catch ex As Exception
            End Try
            td1 = td2 - td3
            td1 = td1.ToString("F1")
            muitd.Text = Math.Abs(td1)
        Catch ex As Exception
        End Try
    End Sub
    Sub ReadingFileChartECG()

        Try
            Dim fileReader2 As String
            Dim RRFile As String

            'Dim fileReader3 As String
            Dim ecg1 As Double
            Dim RR As Double
            'Dim ecg2 As Double
            fileReader2 = My.Computer.FileSystem.ReadAllText(PathLoc + WaveEcg, System.Text.Encoding.Default)
            RRFile = My.Computer.FileSystem.ReadAllText(PathLoc + WaveResp, System.Text.Encoding.Default)
            'If fileReader2 <> "654" Then
            ecg1 = fileReader2
            RR = RRFile
            LineWaveECG(ecg1)
            'ECGChart(GainECG1a, GainECG1b, GainEcgSet, Chart3, "ecg1a", "ecg1b", ecg1, MaxAxisECG1)
            ChartRead(GainECG1a, GainECG1b, GainEcgSet, Chart4, "ecg2a", "ecg2b", ecg1, MaxAxisECG1)
            'RR
            ChartRead(GainECG1a, GainECG1b, GainRespSet, Chart1, "rr1", "rr2", RR, MaxAxisResp)
        Catch ex As Exception
        End Try
    End Sub
    Public GainEcgSet As Integer = 5
    Public GainRespSet As Integer = 5
    Function ChartRead(G1 As Integer, G2 As Integer, GSet As Integer, NameChart As Chart, NameSeriesA As String, NameSeriesB As String, ValueReceived As Double, MaxValue As Integer)
        G1 = G1 + GainEcgSet
        G2 = G2 + GainEcgSet
        NameChart.Series(NameSeriesA).Points.AddXY(G1, (ValueReceived))

        'Line 1
        Select Case G1
            Case MaxValue
                G1 = 0
                NameChart.Series(NameSeriesA).Points.RemoveAt(0)
                NameChart.Series(NameSeriesB).Points.Clear()
                'Debug.WriteLine("SWITCH 1")
        End Select

        Select Case G1
            Case > MaxValue
                NameChart.Series(NameSeriesA).Points.RemoveAt(0)
                NameChart.Series(NameSeriesB).Points.AddXY(G2, (ValueReceived))
                'Debug.WriteLine("SWITCH 2")
        End Select

        'Line 2
        Select Case G2
            Case MaxValue
                G1 = 0
                NameChart.Series(NameSeriesB).Points.RemoveAt(0)
                NameChart.Series(NameSeriesA).Points.Clear()
                'Debug.WriteLine("SWITCH 3")
        End Select
        Select Case G2
            Case > MaxValue
                NameChart.Series(NameSeriesB).Points.RemoveAt(0)
                'Debug.WriteLine("SWITCH 4")
        End Select
        Return {G1, G2, GSet, NameChart, NameSeriesA, NameSeriesB, ValueReceived, MaxValue}
    End Function
    Sub LineWaveECG(y1 As Integer)
        GainECG1a = GainECG1a + GainEcgSet
        GainECG1b = GainECG1b + GainEcgSet
        Chart3.Series("ecg1a").Points.AddXY(GainECG1a, (y1))

        'Line 1
        Select Case GainECG1a
            Case MaxAxisECG1
                GainECG1b = 0
                Chart3.Series("ecg1a").Points.RemoveAt(0)
                Chart3.Series("ecg1b").Points.Clear()
                'Debug.WriteLine("SWITCH 1")
        End Select

        Select Case GainECG1a
            Case > MaxAxisECG1
                Chart3.Series("ecg1a").Points.RemoveAt(0)
                Chart3.Series("ecg1b").Points.AddXY(GainECG1b, (y1))
                'Debug.WriteLine("SWITCH 2")
        End Select

        'Line 2
        Select Case GainECG1b
            Case MaxAxisECG1
                GainECG1a = 0
                Chart3.Series("ecg1b").Points.RemoveAt(0)
                Chart3.Series("ecg1a").Points.Clear()
                'Debug.WriteLine("SWITCH 3")
        End Select
        Select Case GainECG1b
            Case > MaxAxisECG1
                Chart3.Series("ecg1b").Points.RemoveAt(0)
                'Debug.WriteLine("SWITCH 4")
        End Select

    End Sub
    Dim GainSet As Double = 5 'spo2
    Sub ReadingFileChartSpo2()
        Try
            Dim fileReader As String
            Dim y1 As Double

            fileReader = My.Computer.FileSystem.ReadAllText(PathLoc + WaveSpo2, System.Text.Encoding.Default)
            y1 = fileReader
            LineWaveSpo2(y1)
            Debug.WriteLine("DATA SPO2 : " & y1)
            'LabelGain1.Text = Gain1
            'LabelGain2.Text = Gain2
        Catch ex As Exception
        End Try
    End Sub
    Sub LineWaveSpo2(y1 As Integer)
        Gain1 = Gain1 + GainSet
        Gain2 = Gain2 + GainSet
        Chart2.Series("spo2").Points.AddXY(Gain1, (y1))

        'Line 1
        Select Case Gain1
            Case MaxAxisXSpo2
                Gain2 = 0
                Chart2.Series("spo2").Points.RemoveAt(0)
                Chart2.Series("spo3").Points.Clear()
                'Debug.WriteLine("SWITCH 1")
        End Select

        Select Case Gain1
            Case > MaxAxisXSpo2
                Chart2.Series("spo2").Points.RemoveAt(0)
                Chart2.Series("spo3").Points.AddXY(Gain2, (y1))
                'Debug.WriteLine("SWITCH 2")
        End Select

        'Line 2
        Select Case Gain2
            Case MaxAxisXSpo2
                Gain1 = 0
                Chart2.Series("spo3").Points.RemoveAt(0)
                Chart2.Series("spo2").Points.Clear()
                'Debug.WriteLine("SWITCH 3")
        End Select
        Select Case Gain2
            Case > MaxAxisXSpo2
                Chart2.Series("spo3").Points.RemoveAt(0)
                'Debug.WriteLine("SWITCH 4")
        End Select

    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles TimerReceivedData.Tick
        LabelTanggal_Jam.Text = Today & " " & TimeOfDay


        'running rr
        Try
            'Wave
            ReadingFileChartECG()
            ReadingFileChartSpo2()

            'INFO

            'ECG
            FileReaderInfo(PathLoc + ECG, ecghr)
            'RR
            FileReaderInfo(PathLoc + RR, ecgrr)
            'Label Status SPO
            FileReaderInfo(PathLoc + SpO2Status, LabelStatusSpo2) 'Statys SPO2
            'SPO2
            FileReaderInfo(PathLoc + SpO2, muispo2)
            'BPRM
            FileReaderInfo(PathLoc + PulseRate, bprm1)
            'P1
            FileReaderInfo(PathLoc + Pi, pi1)

            'TEMP
            FileReaderInfo(PathLoc + NameTemp1, muitemp1)

            FileReaderInfo(PathLoc + NameTemp2, muitemp2)


            'Status SPO2



            'FileReaderInfo(PathLoc + SpO2Status, LabelStatusSpo2)
            'Status SPO2
            'FileReaderInfo(PathLoc + ECGStatus, LabelStatusLead1)

            'Wave
            'ChartActive("spo2", muispo2.Text, Chart2)
            'WAVE ECG
            'ChartActive("ecg1", ecghr.Text, Chart3)
            'ChartActive("ecg2", ecghr.Text, Chart4)
            'ChartActive("rr", LabelRRMin.Text, Chart1)

            'ECG
            'ChartActive("ecg1", ecghr.Text, Chart3)
            'ChartActive("ecg2", ecghr.Text, Chart4)
            'SPO Chart
            'ChartActive("spo2", muispo2.Text, Chart2)
            'ChartActive("spo2", SetNormal, Chart2)

            'FilterSet()
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
                muitd.Text = "--"
            Case Else
                FileReaderInfo(PathLoc + NameTemp1, muitemp1)
                muitd.Text = (muitemp1.Text - muitemp2.Text)
                If muitd.Text < 0 Then
                    muitd.Text = (muitemp2.Text - muitemp1.Text)
                End If

        End Select

        Select Case muitemp2.Text
            Case 55
                muitemp2.Text = "--"
                muitd.Text = "--"
            Case Else
                FileReaderInfo(PathLoc + NameTemp2, muitemp2)
                muitd.Text = (muitemp1.Text - muitemp2.Text)
                If muitd.Text < 0 Then
                    muitd.Text = (muitemp2.Text - muitemp1.Text)
                End If
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
        'Console.WriteLine("Info :" & line)
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
        'Console.WriteLine("Wave" & line)
        'ChartActive(NameSeries, line, ChartName)
        ChartName.Series(NameSeries).Points.AddXY(detik3, line)
        Return 0
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
    Function ChartActive(NameSeries As String, ValueChartSeries As Integer, ChartName As Chart)
        If ChartName.Series(NameSeries).Points.AddXY(detik3, ValueChartSeries) >= ChartName.Size.Width Then
            ChartName.Series(NameSeries).Points.RemoveAt(0)
            'ChartName.Series(NameSeries).Points.Clear()
        Else
            ChartName.Series(NameSeries).Points.AddXY(detik3, ValueChartSeries)
        End If
        Return {NameSeries, ValueChartSeries, ChartName}
    End Function
    Private Sub TimerBlue_Tick(sender As Object, e As EventArgs)
        BlueButton()
    End Sub
    Private Sub MonitoringDisplay_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Mdi.WindowState = FormWindowState.Maximized
        Me.Dock = DockStyle.Fill
    End Sub

    Private Sub MonitoringDisplay_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        StopBackgroundSound()
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
            'ecghr.Text = "--"
            'EcgValue = 100
        Else
            'EcgValue = ecghr.Text
            'NotificationStatusECG(EcgValue, NameStatusECG)
        End If

        'If muispo2.Text = "--" Then
        'Spo2Value = 127
        'Else
        'Spo2Value = muispo2.Text
        'NotificationStatusSPO2(Spo2Value, NameStatusSPO2)
        'End If

        If ecgrr.Text = "--" Then
            'RRValue = 20
        Else
            'RRValue = ecgrr.Text
            'NotificationStatusRR(RRValue)
        End If

    End Sub

    Private Sub ButtonBlue_TextChanged(sender As Object, e As EventArgs) Handles ButtonBlue.TextChanged
        NameTxtBlue()
    End Sub

    Private Sub MonitoringDisplay_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CloseMultiParameter()
    End Sub

End Class
