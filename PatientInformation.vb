Public Class PatientInformation
    Private Sub PatientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.FormBorderStyle = FormBorderStyle.None
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        InputTextBox(True)
    End Sub

    Function InputTextBox(Status As Boolean)
        TextBox1.Enabled = Status
        TextBox2.Enabled = Status
        TextBox3.Enabled = Status
        TextBox4.Enabled = Status
        TextBox5.Enabled = Status
        TextBox6.Enabled = Status
        TextBox7.Enabled = Status
        TextBox8.Enabled = Status
        ComboBox1.Enabled = Status
        DateTimePicker1.Enabled = Status
    End Function
End Class