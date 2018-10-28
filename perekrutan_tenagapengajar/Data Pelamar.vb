Imports System.Data.OleDb
Public Class Data_Pelamar
    Sub TampilData()
        Using Tampil As New OleDbCommand("Select * From tbl_datapelamar", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                lvpelamar.Items.Clear()
                Dim c As Integer = 0
                If Data.HasRows = True Then
                    While Data.Read
                        lvpelamar.Items.Add(Data("no_pendaftaran"))
                        lvpelamar.Items(c).SubItems.Add(Data("nama"))
                        lvpelamar.Items(c).SubItems.Add(Data("alamat"))
                        lvpelamar.Items(c).SubItems.Add(Data("jenis_kelamin"))
                        lvpelamar.Items(c).SubItems.Add(Data("no_hp"))
                        lvpelamar.Items(c).SubItems.Add(Data("tempat_lahir"))
                        lvpelamar.Items(c).SubItems.Add(Data("tanggal_lahir"))
                        lvpelamar.Items(c).SubItems.Add(Data("agama"))
                        lvpelamar.Items(c).SubItems.Add(Data("status"))
                        c = c + 1
                    End While
                End If
            End Using
        End Using
    End Sub
    Sub bersih()
        txtpendaftaran.Clear()
        txtnama.Clear()
        txtalamat.Clear()
        txtjk.Text = "--PILIH--"
        txthp.Clear()
        txttempat.Clear()
        txttanggal.Clear()
        txtagama.Text = "--PILIH--"
        txtstatus.Text = "--PILIH--"

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Data_Pelamar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()

    End Sub


    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click

        Using Simpan As New OleDbCommand("Insert Into tbl_datapelamar Values('" & txtpendaftaran.Text & _
                                         "','" & txtnama.Text & _
                                         "','" & txtalamat.Text & _
                                         "','" & txtjk.Text & _
                                         "','" & txthp.Text & _
                                         "','" & txttempat.Text & _
                                         "','" & txttanggal.Text & _
                                         "','" & txtagama.Text & _
                                         "','" & txtstatus.Text & "')", Koneksikan.open)
            Simpan.CommandType = CommandType.Text
            Simpan.ExecuteNonQuery()
            MsgBox("Berhasil Menyimpan Data", MsgBoxStyle.Information, "Pemberitahuan")
            Call bersih()
            TampilData()
        End Using

    End Sub

    Private Sub btnbersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbersih.Click
        Call bersih()
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Using Hapus As New OleDbCommand("Delete From tbl_datapelamar Where no_pendaftaran='" & txtpendaftaran.Text & "'", Koneksikan.open)
            Hapus.CommandType = CommandType.Text
            Hapus.ExecuteNonQuery()
            MsgBox("Berhasil Menghapus Data", MsgBoxStyle.Information, "Pemberitahuan")
            btnbersih_Click(Nothing, Nothing)
            TampilData()
        End Using
    End Sub

    Private Sub btntutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntutup.Click
        Dispose()
    End Sub

    Private Sub lvpelamar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvpelamar.Click
        Try
            txtpendaftaran.Text = lvpelamar.SelectedItems(0).SubItems(0).Text
            txtnama.Text = lvpelamar.SelectedItems(0).SubItems(1).Text
            txtalamat.Text = lvpelamar.SelectedItems(0).SubItems(2).Text
            txtjk.Text = lvpelamar.SelectedItems(0).SubItems(3).Text
            txthp.Text = lvpelamar.SelectedItems(0).SubItems(4).Text
            txttempat.Text = lvpelamar.SelectedItems(0).SubItems(5).Text
            txttanggal.Text = lvpelamar.SelectedItems(0).SubItems(6).Text
            txtagama.Text = lvpelamar.SelectedItems(0).SubItems(7).Text
            txtstatus.Text = lvpelamar.SelectedItems(0).SubItems(8).Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lvpelamar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvpelamar.SelectedIndexChanged

    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If txtpendaftaran.Text <> "" Then
            Using Ubah As New OleDbCommand("update tbl_datapelamar set nama='" & txtnama.Text & _
                                            "',alamat='" & txtalamat.Text & _
                                            "',jenis_kelamin='" & txtjk.Text & _
                                            "',no_hp='" & txthp.Text & _
                                            "',tempat_lahir='" & txttempat.Text & _
                                            "',tanggal_lahir='" & txttanggal.Text & _
                                            "',agama='" & txtagama.Text & _
                                            "',status='" & txtstatus.Text & _
                                            "' where no_pendaftaran='" & txtpendaftaran.Text & "'", Koneksikan.open)
                Ubah.CommandType = CommandType.Text
                Ubah.ExecuteNonQuery()
                MsgBox("Berhasil Mengubah Data", MsgBoxStyle.Information, "Pemberitahuan")
                Call TampilData()
                Call bersih()
            End Using
        End If
    End Sub
End Class