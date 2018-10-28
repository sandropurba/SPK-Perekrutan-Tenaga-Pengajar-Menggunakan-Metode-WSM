Imports System.Data.OleDb
Public Class Data_Kriteria
    Sub TampilData()
        Using Tampil As New OleDbCommand("Select * From tbl_datapelamar", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                lvpendaftaran.Items.Clear()
                Dim c As Integer = 0
                If Data.HasRows = True Then
                    While Data.Read
                        lvpendaftaran.Items.Add(Data("no_pendaftaran"))
                        lvpendaftaran.Items(c).SubItems.Add(Data("nama"))
                        c = c + 1
                    End While
                End If
            End Using
        End Using
    End Sub

    Sub TampilkanData()
        Using Tampil As New OleDbCommand("Select * From tbl_kriteria ORDER BY no_pendaftaran asc", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                lvkriteria.Items.Clear()
                Dim c As Integer = 0
                If Data.HasRows = True Then
                    While Data.Read
                        lvkriteria.Items.Add(Data("no_pendaftaran"))
                        lvkriteria.Items(c).SubItems.Add(Data("nama"))
                        lvkriteria.Items(c).SubItems.Add(Data("usia"))
                        lvkriteria.Items(c).SubItems.Add(Data("pendidikan_terakhir"))
                        lvkriteria.Items(c).SubItems.Add(Data("pengalaman_kerja"))
                        lvkriteria.Items(c).SubItems.Add(Data("dokumen"))
                        lvkriteria.Items(c).SubItems.Add(Data("interview"))
                        c = c + 1
                    End While
                End If
            End Using
        End Using
    End Sub
    Private Sub Data_Kriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()
        Call TampilkanData()
        Call bersih()
    End Sub
    Sub bersih()
        txtpendaftaran.Clear()
        cusia.Text = "--Pilih--"
        cpendidikan.Text = "--Pilih--"
        cpengalaman.Text = "--Pilih--"
        cdokumen.Text = "--Pilih--"
        cinterview.Text = "--Pilih--"
    End Sub
    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim v1, v2, v3, v4, v5 As String

        'USIA
        If cusia.Text = "35 - 45 Tahun" Then
            v1 = 0.35
        ElseIf cusia.Text = "29 - 34 Tahun" Then
            v1 = 0.3
        ElseIf cusia.Text = "23 - 28 Tahun" Then
            v1 = 0.2
        Else
            v1 = 0.15
        End If

        'PENDIDIKAN
        If cpendidikan.Text = "S1" Then
            v2 = 0.4
        ElseIf cpendidikan.Text = "D3" Then
            v2 = 0.35
        Else
            v2 = 0.25
        End If

        'PENGALAMAN
        If cpengalaman.Text = "≥ 11 Tahun" Then
            v3 = 0.35
        ElseIf cpengalaman.Text = "7 - 10 Tahun" Then
            v3 = 0.3
        ElseIf cpengalaman.Text = "4 - 6 Tahun" Then
            v3 = 0.2
        Else
            v3 = 0.15
        End If

        'DOKUMEN

        If cdokumen.Text = "Sangat Lengkap" Then
            v4 = 0.35
        ElseIf cdokumen.Text = "Lengkap" Then
            v4 = 0.3
        ElseIf cdokumen.Text = "Cukup Lengkap" Then
            v4 = 0.2
        Else
            v4 = 0.15
        End If

        'INTERVIEW

        If cinterview.Text = "Sangat Baik" Then
            v5 = 0.35
        ElseIf cinterview.Text = "Baik" Then
            v5 = 0.3
        ElseIf cinterview.Text = "Cukup Baik" Then
            v5 = 0.2
        Else
            v5 = 0.15
        End If

        Try
            Using Simpan As New OleDbCommand("Insert Into tbl_kriteria Values('" & txtpendaftaran.Text & _
                                             "','" & tnama.Text & _
                                             "','" & v1 & _
                                             "','" & v2 & _
                                             "','" & v3 & _
                                             "','" & v4 & _
                                             "','" & v5 & "')", Koneksikan.open)
                Simpan.CommandType = CommandType.Text
                Simpan.ExecuteNonQuery()
                MsgBox("Berhasil Menyimpan Data", MsgBoxStyle.Information, "Pemberitahuan")
                Call bersih()
                TampilkanData()
                TampilData()
            End Using
        Catch ex As Exception
            MsgBox("Data Sudah Di Masukkan", MsgBoxStyle.Critical, "Peringatan")
        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Using Ubah As New OleDbCommand("Update tbl_kriteria Set nama='" & tnama.Text & _
                                       "',usia='" & cusia.Text & _
                                       "',pendidikan_terakhir='" & cpendidikan.Text & _
                                       "',pengalaman_kerja='" & cpengalaman.Text & _
                                       "',dokumen='" & cdokumen.Text & _
                                       "',interview='" & cinterview.Text & _
                                       "' Where no_pendaftaran='" & txtpendaftaran.Text & "'", Koneksikan.open)
            Ubah.CommandType = CommandType.Text
            Ubah.ExecuteNonQuery()
            MsgBox("Berhasil Mengubah Data", MsgBoxStyle.Information, "Pemberitahuan")
        End Using
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Using Hapus As New OleDbCommand("Delete From tbl_kriteria Where no_pendaftaran='" & txtpendaftaran.Text & "'", Koneksikan.open)
            Hapus.CommandType = CommandType.Text
            Hapus.ExecuteNonQuery()
            MsgBox("Berhasil Menghapus Data", MsgBoxStyle.Information, "Pemberitahuan")
            Call bersih()
            TampilkanData()
        End Using
    End Sub

    Private Sub btntutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntutup.Click
        Dispose()
    End Sub

    Private Sub lvkriteria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvkriteria.Click
        Try
            txtpendaftaran.Text = lvkriteria.SelectedItems(0).SubItems(0).Text
            tnama.Text = lvkriteria.SelectedItems(0).SubItems(1).Text
            cusia.Text = lvkriteria.SelectedItems(0).SubItems(2).Text
            cpendidikan.Text = lvkriteria.SelectedItems(0).SubItems(3).Text
            cpengalaman.Text = lvkriteria.SelectedItems(0).SubItems(4).Text
            cdokumen.Text = lvkriteria.SelectedItems(0).SubItems(5).Text
            cinterview.Text = lvkriteria.SelectedItems(0).SubItems(6).Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lvkriteria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvkriteria.SelectedIndexChanged

    End Sub

    Private Sub lvpendaftaran_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvpendaftaran.Click
        Try
            txtpendaftaran.Text = lvpendaftaran.SelectedItems(0).SubItems(0).Text
            tnama.Text = lvpendaftaran.SelectedItems(0).SubItems(1).Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lvpendaftaran_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvpendaftaran.SelectedIndexChanged

    End Sub

    Private Sub cpengalaman_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpengalaman.SelectedIndexChanged

    End Sub
End Class