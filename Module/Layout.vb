Module Layout
    Function MonitorDisplayView(W As Integer, H As Integer)
        MonitoringDisplay.MdiParent = Mdi
        MonitoringDisplay.Size = New Size(W, H)
        MonitoringDisplay.Dock = DockStyle.Top.Left
        MonitoringDisplay.Show()
        Return {W, H}
    End Function
    Function ColorScreen(NameColor As String, ColorSelect As Color)
        Select Case NameColor
            Case "SPO2"
                MonitoringDisplay.Label31.ForeColor = ColorSelect
                MonitoringDisplay.Label32.ForeColor = ColorSelect
                MonitoringDisplay.Chart2.Series("spo2").Color = ColorSelect
                MonitoringDisplay.Label4.ForeColor = ColorSelect
                MonitoringDisplay.Label5.ForeColor = ColorSelect
                MonitoringDisplay.Label6.ForeColor = ColorSelect
                MonitoringDisplay.Label7.ForeColor = ColorSelect
                MonitoringDisplay.muispo2.ForeColor = ColorSelect
                MonitoringDisplay.pi1.ForeColor = ColorSelect
                MonitoringDisplay.Label33.ForeColor = ColorSelect
                MonitoringDisplay.Label34.ForeColor = ColorSelect
                MonitoringDisplay.bprm1.ForeColor = ColorSelect
            Case "ECG"
                MonitoringDisplay.Label25.ForeColor = ColorSelect
                MonitoringDisplay.Label26.ForeColor = ColorSelect
                MonitoringDisplay.Chart3.Series("ecg1").Color = ColorSelect
                MonitoringDisplay.Label30.ForeColor = ColorSelect
                MonitoringDisplay.Label15.ForeColor = ColorSelect
                MonitoringDisplay.Label13.ForeColor = ColorSelect
                MonitoringDisplay.Label12.ForeColor = ColorSelect
                MonitoringDisplay.ecghr.ForeColor = ColorSelect
            Case "NIBP"
                MonitoringDisplay.Label20.ForeColor = ColorSelect
                MonitoringDisplay.Label19.ForeColor = ColorSelect
                MonitoringDisplay.Label18.ForeColor = ColorSelect
                MonitoringDisplay.Label17.ForeColor = ColorSelect
                MonitoringDisplay.sysdys.ForeColor = ColorSelect
            Case "RR"
                MonitoringDisplay.Label16.ForeColor = ColorSelect
                MonitoringDisplay.Label11.ForeColor = ColorSelect
                MonitoringDisplay.Label10.ForeColor = ColorSelect
                MonitoringDisplay.Label9.ForeColor = ColorSelect
                MonitoringDisplay.Label8.ForeColor = ColorSelect
                MonitoringDisplay.Label3.ForeColor = ColorSelect
                MonitoringDisplay.ecgrr.ForeColor = ColorSelect
                MonitoringDisplay.Chart1.Series("rr").Color = ColorSelect
        End Select
        Return {NameColor, ColorSelect}
    End Function

    Function DefaultSetup(ColorSelect As Color)

        Return ColorSelect
    End Function
End Module
