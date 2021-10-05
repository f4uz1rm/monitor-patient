Public Class TEST_DATABASE
    Private Sub TEST_DATABASE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Table_Patient", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Table_Patient")
        DataGridView1.DataSource = (ds.Tables("Table_Patient"))
    End Sub
End Class