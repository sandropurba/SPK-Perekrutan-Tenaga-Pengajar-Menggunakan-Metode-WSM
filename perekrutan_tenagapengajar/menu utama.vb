Public Class menu_utama

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub InputDataPelamarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataPelamarToolStripMenuItem.Click
        Dim anak As New Data_Pelamar
        anak.MdiParent = Me
        anak.Show()
    End Sub

    Private Sub InputDataKriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataKriteriaToolStripMenuItem.Click
        Dim anak As New Data_Kriteria
        anak.MdiParent = Me
        anak.Show()

    End Sub

    Private Sub PerhitunganWSMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerhitunganWSMToolStripMenuItem.Click
        Dim anak As New Proses_Pembuatan_Nilai
        anak.MdiParent = Me
        anak.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub DataKriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKriteriaToolStripMenuItem.Click
        Dim anak As New bobot
        anak.MdiParent = Me
        anak.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click

    End Sub

    Private Sub HasilPerhitunganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HasilPerhitunganToolStripMenuItem.Click
        Dim anak As New laporan
        anak.MdiParent = Me
        anak.Show()
    End Sub
End Class