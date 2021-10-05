Imports System.Data.OleDb
Module Data_Patient
    'Variable
    Dim AddForm As Form = AddPatient

    Sub Update_Data_Patient()
        Koneksi()
        Dim NameFrom As AddPatient = AddPatient
        If AddPatient.txt_first_name.Text = "" Then
            MsgBox("Kode Tidak Ada")
        Else
            Dim edit As String = "Update Table_Patient set Birth='" & NameFrom.Datetimepicker1.Value & "',First_Name='" & NameFrom.txt_first_name.Text & "',Last_Name='" & NameFrom.txt_last_name.Text & "',Age='" & NameFrom.txt_age.Text & "',Height='" & NameFrom.txt_height.Text & "',Weight='" & NameFrom.txt_weight.Text & "',Gender='" & NameFrom.cb_gender.selectedValue & "',Profession='" & NameFrom.txt_profession.Text & "',Doctor='" & NameFrom.txt_doctor.Text & "',Nurse='" & NameFrom.txt_nurse.Text & "'where ID='" & MonitoringDisplay.LabelKode.Text & "'"
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
        Tampil_DataGrid()
    End Sub
    Sub Tampil_DataGrid()
        Koneksi()
        da = New OleDbDataAdapter("SELECT * FROM Table_Patient", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Table_Patient")
        AddPatient.DataGridView1.DataSource = (ds.Tables("Table_Patient"))
    End Sub
    Sub Tampil_Texbox()
        Try
            Koneksi()
            syntak = "SELECT*FROM Table_Patient where ID='DP001'"
            cmd = New OleDbCommand(syntak, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                AddPatient.txt_first_name.Text = dr.Item("First_Name")
                AddPatient.txt_last_name.Text = dr.Item("Last_Name")
                AddPatient.Datetimepicker1.Value = dr.Item("Birth")
                AddPatient.txt_age.Text = dr.Item("Age")
                AddPatient.txt_height.Text = dr.Item("Height")
                AddPatient.txt_weight.Text = dr.Item("Weight")
                AddPatient.cb_gender.Text = dr.Item("Gender")
                AddPatient.txt_profession.Text = dr.Item("Profession")
                AddPatient.txt_doctor.Text = dr.Item("Doctor")
                AddPatient.txt_nurse.Text = dr.Item("Nurse")
                '
                PatientInformation.txt_first_name.Text = dr.Item("First_Name")
                PatientInformation.txt_last_name.Text = dr.Item("Last_Name")
                PatientInformation.Datetimepicker1.Value = dr.Item("Birth")
                PatientInformation.txt_age.Text = dr.Item("Age")
                PatientInformation.txt_height.Text = dr.Item("Height")
                PatientInformation.txt_weight.Text = dr.Item("Weight")
                PatientInformation.cb_gender.Text = dr.Item("Gender")
                PatientInformation.txt_profession.Text = dr.Item("Profession")
                PatientInformation.txt_doctor.Text = dr.Item("Doctor")
                PatientInformation.txt_nurse.Text = dr.Item("Nurse")
            End If
        Catch ex As Exception
        End Try
    End Sub
End Module
