Public Class DefaultSetup
    Private Sub btn_yes_Click(sender As Object, e As EventArgs) Handles btn_yes.Click
        ResetDefault()
        Me.Close()
    End Sub

    Private Sub btn_no_Click(sender As Object, e As EventArgs) Handles btn_no.Click
        Me.Close()
    End Sub
End Class