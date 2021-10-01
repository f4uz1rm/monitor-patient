Module LED
    Dim LED As String
    Sub KirimLed()
        Try
            MonitoringDisplay.SerialPort1.Write(LED & vbCrLf)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    'RED
    Sub LedOnRed()
        LED = "d"
        KirimLed()
    End Sub
    Sub LedOffRed()
        LED = "c"
        KirimLed()
    End Sub
    'Yellow
    Sub LedOnYellow()
        LED = "ds"
        KirimLed()
    End Sub
    Sub LedOffYellow()
        LED = "xc"
        KirimLed()
    End Sub
    'Green
    Sub LedOnHijau()
        LED = "s"
        KirimLed()
    End Sub
    Sub LedOffHijau()
        LED = "x"
        KirimLed()
    End Sub
    'Blue
    Sub LedOnBiru()
        LED = "f"
        KirimLed()
    End Sub
    Sub LedOffBiru()
        LED = "v"
        KirimLed()
    End Sub
End Module
