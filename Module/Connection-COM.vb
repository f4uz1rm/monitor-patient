Module Connection_COM
    Sub COM5Connecting()
        MonitoringDisplay.SerialPort1.Close()
        MonitoringDisplay.SerialPort1.PortName = "COM5"
        MonitoringDisplay.SerialPort1.BaudRate = 9600
        MonitoringDisplay.SerialPort1.DataBits = 8
        MonitoringDisplay.SerialPort1.Parity = MonitoringDisplay.SerialPort1.Parity.None
        MonitoringDisplay.SerialPort1.StopBits = MonitoringDisplay.SerialPort1.StopBits.One
        MonitoringDisplay.SerialPort1.Handshake = MonitoringDisplay.SerialPort1.Handshake.None
        MonitoringDisplay.SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
        MonitoringDisplay.SerialPort1.ReadTimeout = 10000
        MonitoringDisplay.SerialPort1.Open()
        'MsgBox("Connection Success")
    End Sub
End Module
