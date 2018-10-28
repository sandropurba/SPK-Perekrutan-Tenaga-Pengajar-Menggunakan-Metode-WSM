<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InputDataPelamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InputDataKriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataKriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProsesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PerhitunganWSMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HasilPerhitunganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProsesToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1040, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataPelamarToolStripMenuItem, Me.InputDataKriteriaToolStripMenuItem, Me.DataKriteriaToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(43, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'InputDataPelamarToolStripMenuItem
        '
        Me.InputDataPelamarToolStripMenuItem.Name = "InputDataPelamarToolStripMenuItem"
        Me.InputDataPelamarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.InputDataPelamarToolStripMenuItem.Text = "Input Data Pelamar"
        '
        'InputDataKriteriaToolStripMenuItem
        '
        Me.InputDataKriteriaToolStripMenuItem.Name = "InputDataKriteriaToolStripMenuItem"
        Me.InputDataKriteriaToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.InputDataKriteriaToolStripMenuItem.Text = "Input Alternatif"
        '
        'DataKriteriaToolStripMenuItem
        '
        Me.DataKriteriaToolStripMenuItem.Name = "DataKriteriaToolStripMenuItem"
        Me.DataKriteriaToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DataKriteriaToolStripMenuItem.Text = "Data Kriteria"
        '
        'ProsesToolStripMenuItem
        '
        Me.ProsesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerhitunganWSMToolStripMenuItem})
        Me.ProsesToolStripMenuItem.Name = "ProsesToolStripMenuItem"
        Me.ProsesToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.ProsesToolStripMenuItem.Text = "Proses"
        '
        'PerhitunganWSMToolStripMenuItem
        '
        Me.PerhitunganWSMToolStripMenuItem.Name = "PerhitunganWSMToolStripMenuItem"
        Me.PerhitunganWSMToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.PerhitunganWSMToolStripMenuItem.Text = "Perhitungan WSM"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HasilPerhitunganToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'HasilPerhitunganToolStripMenuItem
        '
        Me.HasilPerhitunganToolStripMenuItem.Name = "HasilPerhitunganToolStripMenuItem"
        Me.HasilPerhitunganToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.HasilPerhitunganToolStripMenuItem.Text = "Hasil Perhitungan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(62, 21)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'menu_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.perekrutan_tenagapengajar.My.Resources.Resources.asdadasdads
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 468)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menu_utama"
        Me.ShowIcon = False
        Me.Text = "Sistem Perekrutan Tenaga Pengajar SD S GKPS Bandar Kuala"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataPelamarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataKriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerhitunganWSMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HasilPerhitunganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
