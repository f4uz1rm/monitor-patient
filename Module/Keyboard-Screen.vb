Option Strict On
Imports System.ComponentModel

Module Keyboard_Screen
    Public mprcTabTip As Process
    Sub Keyboard_Screen_Open()
        If mprcTabTip Is Nothing OrElse mprcTabTip.HasExited Then
            If mprcTabTip IsNot Nothing AndAlso mprcTabTip.HasExited Then
                mprcTabTip.Close()
            End If
            mprcTabTip = Process.Start("C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe")
        End If
    End Sub
    Sub Keyboard_Screen_Close()
        For Each pkiller As Process In Process.GetProcesses
            If String.Compare(pkiller.ProcessName, "tabtip", True) = 0 Then
                pkiller.Kill()
            End If
        Next
    End Sub
End Module
