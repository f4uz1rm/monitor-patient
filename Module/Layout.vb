Module Layout
    Function MonitorDisplayView(W As Integer, H As Integer)
        MonitoringDisplay.MdiParent = Mdi
        MonitoringDisplay.Size = New Size(W, H)
        MonitoringDisplay.Dock = DockStyle.Top.Left
        MonitoringDisplay.Show()
        Return {W, H}
    End Function
End Module
