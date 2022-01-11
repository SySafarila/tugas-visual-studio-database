Imports System.Data.OleDb
Public Class Form1
    Sub Kosong()
        tbKodeJenis.Clear()
        tbNamaJenis.Clear()
        TextBox3.Clear()
    End Sub
    Sub Isi()
        tbNamaJenis.Clear()
        tbNamaJenis.Focus()
    End Sub
    Sub TampilJenis()
        da = New OleDbDataAdapter("Select * From Jenis", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Jenis")
        DataGridView1.DataSource = ds.Tables("Jenis")
        DataGridView1.Refresh()
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(0).HeaderText = "Kode Jenis"
        DataGridView1.Columns(1).HeaderText = "Nama Jenis"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
