Module LED
    Dim LED As String
    Function KirimLed(LedValue As String)
        Try
            MonitoringDisplay.SerialPort1.Write(LedValue & vbCrLf)
            ' & vbCrLf
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Function
    'RED
    Sub LedOnRed()
        LED = "d"
        KirimLed(LED)
    End Sub
    Sub LedOffRed()
        LED = "c"
        KirimLed(LED)
    End Sub
    'Yellow
    Sub LedOnYellow()
        LED = "ds"
        KirimLed(LED)
    End Sub
    Sub LedOffYellow()
        LED = "xc"
        KirimLed(LED)
    End Sub
    'Green
    Sub LedOnHijau()
        LED = "s"
        KirimLed(LED)
    End Sub
    Sub LedOffHijau()
        LED = "x"
        KirimLed(LED)
    End Sub
    'Blue
    Sub LedOnBiru()
        LED = "f"
        KirimLed(LED)
    End Sub
    Sub LedOffBiru()
        LED = "v"
        KirimLed(LED)
    End Sub
End Module
