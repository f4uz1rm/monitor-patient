Module LayoutReset
    Public Function MonitorDisplayView(W As Integer, H As Integer)
        MonitoringDisplay.MdiParent = Mdi
        MonitoringDisplay.Size = New Size(W, H)
        MonitoringDisplay.Dock = DockStyle.Top.Fill
        MonitoringDisplay.Show()
        Return {W, H}
    End Function
    Function ColorScreen(NameColor As String, ColorSelect As Color)
        Select Case NameColor
            Case "SPO2"
                MonitoringDisplay.LabelStatusSpo2.ForeColor = ColorSelect
                MonitoringDisplay.Label31.ForeColor = ColorSelect
                MonitoringDisplay.Label32.ForeColor = ColorSelect
                MonitoringDisplay.Chart2.Series("spo2").Color = ColorSelect
                MonitoringDisplay.Label4.ForeColor = ColorSelect
                MonitoringDisplay.Label5.ForeColor = ColorSelect
                MonitoringDisplay.LabelSpo2Max.ForeColor = ColorSelect
                MonitoringDisplay.LabelSpo2Min.ForeColor = ColorSelect
                MonitoringDisplay.muispo2.ForeColor = ColorSelect
                MonitoringDisplay.pi1.ForeColor = ColorSelect
                MonitoringDisplay.Label33.ForeColor = ColorSelect
                MonitoringDisplay.Label34.ForeColor = ColorSelect
                MonitoringDisplay.bprm1.ForeColor = ColorSelect
            Case "ECG1"
                MonitoringDisplay.LabelStatusLead1.ForeColor = ColorSelect
                MonitoringDisplay.LabelStatusLead2.ForeColor = ColorSelect
                MonitoringDisplay.Label25.ForeColor = ColorSelect
                MonitoringDisplay.Label26.ForeColor = ColorSelect
                MonitoringDisplay.Label30.ForeColor = ColorSelect
                MonitoringDisplay.Label15.ForeColor = ColorSelect
                MonitoringDisplay.LabelEcgMax.ForeColor = ColorSelect
                MonitoringDisplay.LabelEcgMin.ForeColor = ColorSelect
                MonitoringDisplay.ecghr.ForeColor = ColorSelect
                MonitoringDisplay.Chart3.Series("ecg1").Color = ColorSelect
                MonitoringDisplay.Chart4.Series("ecg2").Color = ColorSelect
            Case "NIBP"
                MonitoringDisplay.Label20.ForeColor = ColorSelect
                MonitoringDisplay.Label19.ForeColor = ColorSelect
                MonitoringDisplay.Label18.ForeColor = ColorSelect
                MonitoringDisplay.Label17.ForeColor = ColorSelect
                MonitoringDisplay.sysdys.ForeColor = ColorSelect
            Case "RR"
                MonitoringDisplay.LabelRrStatus.ForeColor = ColorSelect
                MonitoringDisplay.Label16.ForeColor = ColorSelect
                MonitoringDisplay.Label11.ForeColor = ColorSelect
                MonitoringDisplay.Label10.ForeColor = ColorSelect
                MonitoringDisplay.Label9.ForeColor = ColorSelect
                MonitoringDisplay.LabelRRMax.ForeColor = ColorSelect
                MonitoringDisplay.LabelRRMin.ForeColor = ColorSelect
                MonitoringDisplay.ecgrr.ForeColor = ColorSelect
                MonitoringDisplay.Chart1.Series("rr").Color = ColorSelect
            Case "TEMP"
                MonitoringDisplay.Label24.ForeColor = ColorSelect
                MonitoringDisplay.Label23.ForeColor = ColorSelect
                MonitoringDisplay.Label22.ForeColor = ColorSelect
                MonitoringDisplay.Label14.ForeColor = ColorSelect
                MonitoringDisplay.Label27.ForeColor = ColorSelect
                MonitoringDisplay.Label28.ForeColor = ColorSelect
                MonitoringDisplay.Label29.ForeColor = ColorSelect
                MonitoringDisplay.muitemp1.ForeColor = ColorSelect
                MonitoringDisplay.muitemp2.ForeColor = ColorSelect
                MonitoringDisplay.muitd.ForeColor = ColorSelect
        End Select
        Return {NameColor, ColorSelect}
    End Function

    Function DefaultSetup(ColorSelect As Color)
        Return ColorSelect
    End Function

    'Show Keyboard
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private osk As String = "C:\Windows\System32\osk.exe"
    Private pOSK As Process = Nothing

    Public Sub Keyboard_Show()
        'An instance is running => Dan wordt pOSK het bestaande proces
        For Each pkiller As Process In Process.GetProcesses
            If String.Compare(pkiller.ProcessName, "osk", True) = 0 Then pOSK = pkiller
        Next

        'If no instance of OSK is running than create one depending on 32/64 bit
        For Each pkiller As Process In Process.GetProcesses
            If Not (String.Compare(pkiller.ProcessName, "osk", True) = 0) And (pOSK Is Nothing) Then

                Dim old As Long
                If Environment.Is64BitOperatingSystem Then
                    '64 Bit
                    If Wow64DisableWow64FsRedirection(old) Then
                        pOSK = Process.Start(osk)
                        Wow64EnableWow64FsRedirection(old)
                    End If
                Else
                    '32 Bit
                    pOSK = Process.Start(osk)
                End If
                Exit For
            End If
        Next
    End Sub

End Module
