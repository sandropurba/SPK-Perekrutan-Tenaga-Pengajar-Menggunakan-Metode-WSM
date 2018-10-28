Imports System.Data.OleDb
Public Class bobot
    Sub tampil()
        Using Tampil As New OleDbCommand("Select * From tbl_bobot", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                Dim c As Integer = 0
                While Data.Read
                    k1.Text = Data.Item("usia")
                    k2.Text = Data.Item("pendidikan_terakhir")
                    k3.Text = Data.Item("pengalaman_kerja")
                    k4.Text = Data.Item("dokumen")
                    k5.Text = Data.Item("interview")
                    c = c + 1
                End While
            End Using
        End Using
    End Sub
    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Using Hapus As New OleDbCommand("Delete From tbl_bobot", Koneksikan.open)
            Hapus.CommandType = CommandType.Text
            Hapus.ExecuteNonQuery()
        End Using

        Try
            Using Simpan As New OleDbCommand("Insert Into tbl_bobot Values('" & k1.Text & _
                                             "','" & k2.Text & _
                                             "','" & k3.Text & _
                                             "','" & k4.Text & _
                                             "','" & k5.Text & "')", Koneksikan.open)
                Simpan.CommandType = CommandType.Text
                Simpan.ExecuteNonQuery()
                MsgBox("Berhasil Menyimpan Data", MsgBoxStyle.Information, "Pemberitahuan")
                Call tampil()
            End Using
        Catch ex As Exception
            MsgBox("Gagal Menyimpan", MsgBoxStyle.Critical, "Peringatan")
        End Try
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Dispose()
    End Sub

    Private Sub bobot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()
    End Sub
End Class