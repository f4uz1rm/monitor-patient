Imports System.Media
Imports System.IO
Module Audio
    Sub AudioTouchscreen()
        My.Computer.Audio.Play(My.Resources.fix_tochscreen,
                               AudioPlayMode.Background)
    End Sub
    Sub AudioHBAlarm()
        My.Computer.Audio.Play(My.Resources.fix_HB_sound,
                               AudioPlayMode.Background)
    End Sub
    Sub AudioRedAlarm()
        My.Computer.Audio.Play(My.Resources.fix_red_alarm,
            AudioPlayMode.Background)
    End Sub
    Sub AudioYellowAlarm()
        My.Computer.Audio.Play(My.Resources.fix_yellow_alarm,
            AudioPlayMode.Background)
    End Sub
    Sub AudioBlueAlarm()
        My.Computer.Audio.Play(My.Resources.fix_blue_alarm,
        AudioPlayMode.Background)
    End Sub
    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()
    End Sub

End Module
