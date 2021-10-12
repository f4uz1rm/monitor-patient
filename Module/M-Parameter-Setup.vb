Imports System.Data.OleDb
Module M_Parameter_Setup
    'Variable
    Dim AddForm As Form = AddPatient
    Sub Update_Parameter_Setup()
        Koneksi()
        Dim NameFrom As ParameterSetup = ParameterSetup
        If NameFrom.ComboBoxECG1.Text = "" Then
            MsgBox("Kode Tidak Ada")
        Else
            Dim edit As String = "Update Table_Parameter set ECG_1='" & NameFrom.ComboBoxECG1.SelectedItem & "',ECG_2='" & NameFrom.ComboBoxECG2.SelectedItem & "',Gain='" & NameFrom.ComboBoxGain.SelectedItem & "',ECG_Speed='" & NameFrom.ComboBoxECGSpeed.SelectedItem & "',Graph_Mode='" & NameFrom.ComboBoxGraphMode.SelectedItem & "',Apnea_Time='" & NameFrom.ComboBoxApneaTime.SelectedItem & "',Resp_Level='" & NameFrom.ComboBoxRespLevel.SelectedItem & "',Resp_Speed='" & NameFrom.ComboBoxRespSpeed.SelectedItem & "',SPO2_Sensitivity='" & NameFrom.ComboBoxSensitivity.SelectedItem & "',Pressure='" & NameFrom.ComboBoxPressure.SelectedItem & "',Auto_Mode='" & NameFrom.ComboBoxAutoMode.SelectedItem & "',Setup_T1='" & NameFrom.ComboBoxSetupT1.SelectedItem & "',Setup_T2='" & NameFrom.ComboBoxSetupT2.SelectedItem & "',T1_Label='" & NameFrom.TextBoxT1Label.Text & "',T2_Label='" & NameFrom.TextBoxT2Label.Text & "',T_Difference='" & NameFrom.ComboBoxTDifference.SelectedItem & "'where ID='" & NameFrom.Label_ID.Text & "'"
            cmd = New OleDbCommand(edit, conn)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Ubah", MsgBoxStyle.Information, "Info")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
        conn.Close()
        Tampil_ComboBox()
    End Sub
    Sub Tampil_ComboBox()
        Dim NameForm As ParameterSetup = ParameterSetup
        Try
            Koneksi()
            syntak = "SELECT*FROM Table_Parameter where ID='PS001'"
            cmd = New OleDbCommand(syntak, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                NameForm.ComboBoxECG1.Text = dr.Item("ECG_1")
                NameForm.ComboBoxECG2.Text = dr.Item("ECG_2")
                NameForm.ComboBoxGain.Text = dr.Item("Gain")
                NameForm.ComboBoxECGSpeed.Text = dr.Item("ECG_Speed")
                NameForm.ComboBoxGraphMode.Text = dr.Item("Graph_Mode")
                NameForm.ComboBoxApneaTime.Text = dr.Item("Apnea_Time")
                NameForm.ComboBoxRespLevel.Text = dr.Item("Resp_Level")
                NameForm.ComboBoxRespSpeed.Text = dr.Item("Resp_Speed")
                NameForm.ComboBoxSensitivity.Text = dr.Item("SPO2_Sensitivity")
                NameForm.ComboBoxPressure.Text = dr.Item("Pressure")
                NameForm.ComboBoxAutoMode.Text = dr.Item("Auto_Mode")
                NameForm.ComboBoxSetupT1.Text = dr.Item("Setup_T1")
                NameForm.ComboBoxSetupT2.Text = dr.Item("Setup_T2")
                NameForm.TextBoxT1Label.Text = dr.Item("T1_Label")
                NameForm.TextBoxT2Label.Text = dr.Item("T2_Label")
                NameForm.ComboBoxTDifference.Text = dr.Item("T_Difference")
                MonitoringDisplay.Label27.Text = dr.Item("T1_Label")
                MonitoringDisplay.Label29.Text = dr.Item("T2_Label")
            End If
        Catch ex As Exception
        End Try
    End Sub
End Module