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
        Panel2.Hide()
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
        Datetimepicker1.Enabled = Status
        Return Status
    End Function

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Panel2.Show()
        Panel3.Hide()
    End Sub
    Sub DeleteTextBoxAll()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComboBox1.Text = ""
        DateTimePicker1.Text = ""
    End Sub

    Private Sub btn_no_Click(sender As Object, e As EventArgs) Handles btn_no.Click
        Panel3.Show()
        Panel2.Hide()
    End Sub

    Private Sub btn_yes_Click(sender As Object, e As EventArgs) Handles btn_yes.Click
        DeleteTextBoxAll()
        Panel2.Hide()
        Panel3.Show()
    End Sub
End Class