Imports System.Data.OleDb
Public Class laporan
    Sub TampilData()
        Using Tampil As New OleDbCommand("Select * From tbl_keputusan", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                lvlaporan.Items.Clear()
                Dim c As Integer = 0
                If Data.HasRows = True Then
                    While Data.Read
                        lvlaporan.Items.Add(Data("no_pendaftaran"))
                        lvlaporan.Items(c).SubItems.Add(Data("nama"))
                        lvlaporan.Items(c).SubItems.Add(Data("usia"))
                        lvlaporan.Items(c).SubItems.Add(Data("pendidikan_terakhir"))
                        lvlaporan.Items(c).SubItems.Add(Data("pengalaman_kerja"))
                        lvlaporan.Items(c).SubItems.Add(Data("dokumen"))
                        lvlaporan.Items(c).SubItems.Add(Data("interview"))
                        lvlaporan.Items(c).SubItems.Add(Data("total"))
                        lvlaporan.Items(c).SubItems.Add(Data("keterangan"))
                        c = c + 1
                    End While
                End If
            End Using
        End Using
    End Sub
    Private Sub lvlaporan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvlaporan.SelectedIndexChanged

    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Laporan_Perhitungan.Show()
    End Sub

    Private Sub laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Dispose()
    End Sub
End Class