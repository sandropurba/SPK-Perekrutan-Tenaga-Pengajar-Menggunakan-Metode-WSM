Imports System.Data.OleDb
Public Class Proses_Pembuatan_Nilai
    Sub TampilData()
        Using Tampil As New OleDbCommand("Select * From tbl_kriteria ORDER BY no_pendaftaran asc", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                lvdata.Items.Clear()
                Dim c As Integer = 0
                If Data.HasRows = True Then
                    While Data.Read
                        lvdata.Items.Add(Data("no_pendaftaran"))
                        lvdata.Items(c).SubItems.Add(Data("nama"))
                        lvdata.Items(c).SubItems.Add(Data("usia"))
                        lvdata.Items(c).SubItems.Add(Data("pendidikan_terakhir"))
                        lvdata.Items(c).SubItems.Add(Data("pengalaman_kerja"))
                        lvdata.Items(c).SubItems.Add(Data("dokumen"))
                        lvdata.Items(c).SubItems.Add(Data("interview"))
                        c = c + 1
                    End While
                End If
            End Using
        End Using
    End Sub
    Sub TampilBobot()
        Using Tampil As New OleDbCommand("Select * From tbl_bobot", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                lvbobot.Items.Clear()
                Dim c As Integer = 0
                If Data.HasRows = True Then
                    While Data.Read
                        lvbobot.Items.Add(Data("usia"))
                        lvbobot.Items(c).SubItems.Add(Data("pendidikan_terakhir"))
                        lvbobot.Items(c).SubItems.Add(Data("pengalaman_kerja"))
                        lvbobot.Items(c).SubItems.Add(Data("dokumen"))
                        lvbobot.Items(c).SubItems.Add(Data("interview"))
                        c = c + 1
                    End While
                End If
            End Using
        End Using
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvdata.SelectedIndexChanged

    End Sub

    Private Sub lvbobotkriteria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvbobot.SelectedIndexChanged

    End Sub

    Private Sub Proses_Pembuatan_Nilai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilBobot()
        Call TampilData()
    End Sub

    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproses.Click
        Dim n = lvdata.Items.Count
        Dim x = lvbobot.Items.Count
        Dim Hasil(n) As Double
        Dim Total_Vektor_S As Double = 0
        Dim z As String
        Using Tampil As New OleDbCommand("Select * From tbl_datapelamar", Koneksikan.open)
            Using Data As OleDbDataReader = Tampil.ExecuteReader
                lvperangkingan.Items.Clear()
                Dim c As Integer = 0
                If Data.HasRows = True Then
                    While Data.Read
                        z = Data("nama")
                    End While
                End If
            End Using
        End Using
        For i = 1 To lvdata.Items.Count
            lvperangkingan.Items.Add(lvdata.Items(i - 1).SubItems(0).Text)
            lvperangkingan.Items(i - 1).SubItems.Add(lvdata.Items(i - 1).SubItems(1).Text)
            lvperangkingan.Items(i - 1).SubItems.Add(lvdata.Items(i - 1).SubItems(2).Text * lvbobot.Items(0).SubItems(0).Text)
            lvperangkingan.Items(i - 1).SubItems.Add(lvdata.Items(i - 1).SubItems(3).Text * lvbobot.Items(0).SubItems(1).Text)
            lvperangkingan.Items(i - 1).SubItems.Add(lvdata.Items(i - 1).SubItems(4).Text * lvbobot.Items(0).SubItems(2).Text)
            lvperangkingan.Items(i - 1).SubItems.Add(lvdata.Items(i - 1).SubItems(5).Text * lvbobot.Items(0).SubItems(3).Text)
            lvperangkingan.Items(i - 1).SubItems.Add(lvdata.Items(i - 1).SubItems(6).Text * lvbobot.Items(0).SubItems(4).Text)
            lvperangkingan.Items(i - 1).SubItems.Add(Val(lvperangkingan.Items(i - 1).SubItems(2).Text) + Val(lvperangkingan.Items(i - 1).SubItems(3).Text) + Val(lvperangkingan.Items(i - 1).SubItems(4).Text) + Val(lvperangkingan.Items(i - 1).SubItems(5).Text) + Val(lvperangkingan.Items(i - 1).SubItems(6).Text))
            lvperangkingan.Items(i - 1).SubItems.Add("-")
        Next i

        'RANKING
        For i = 1 To lvdata.Items.Count
            Dim Max As Double = 0
            For j = 1 To lvdata.Items.Count
                If Max < lvperangkingan.Items(j - 1).SubItems(7).Text And lvperangkingan.Items(j - 1).SubItems(8).Text = "-" Then
                    Max = lvperangkingan.Items(j - 1).SubItems(7).Text
                End If
            Next j
            For j = 1 To lvdata.Items.Count
                If Max = lvperangkingan.Items(j - 1).SubItems(7).Text Then
                    lvperangkingan.Items(j - 1).SubItems(8).Text = "Rangking " & i.ToString
                End If
            Next j
        Next i

        'HAPUS DATA TABLE
        Using Hapus As New OleDbCommand("Delete From tbl_keputusan", Koneksikan.open)
            Hapus.CommandType = CommandType.Text
            Hapus.ExecuteNonQuery()
        End Using
        MsgBox("Analisa Selesai", MsgBoxStyle.Information, "Pemberitahuan")

        'SIMPAN KE TABEL
        For i = 1 To lvdata.Items.Count
            Using Simpan As New OleDbCommand("Insert Into tbl_keputusan Values('" & lvperangkingan.Items(i - 1).SubItems(0).Text & "','" & lvperangkingan.Items(i - 1).SubItems(1).Text & "'," & lvperangkingan.Items(i - 1).SubItems(2).Text & ",'" & lvperangkingan.Items(i - 1).SubItems(3).Text & "','" & lvperangkingan.Items(i - 1).SubItems(4).Text & "','" & lvperangkingan.Items(i - 1).SubItems(5).Text & "','" & lvperangkingan.Items(i - 1).SubItems(6).Text & "','" & lvperangkingan.Items(i - 1).SubItems(7).Text & "','" & lvperangkingan.Items(i - 1).SubItems(8).Text & "')", Koneksikan.open)
                Simpan.CommandType = CommandType.Text
                Simpan.ExecuteNonQuery()
            End Using
        Next i
        
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Laporan_Perhitungan.Show()
    End Sub
End Class