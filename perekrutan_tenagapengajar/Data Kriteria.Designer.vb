<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Kriteria
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tnama = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cinterview = New System.Windows.Forms.ComboBox
        Me.cdokumen = New System.Windows.Forms.ComboBox
        Me.cpengalaman = New System.Windows.Forms.ComboBox
        Me.cpendidikan = New System.Windows.Forms.ComboBox
        Me.cusia = New System.Windows.Forms.ComboBox
        Me.txtpendaftaran = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnsimpan = New System.Windows.Forms.Button
        Me.btnhapus = New System.Windows.Forms.Button
        Me.btntutup = New System.Windows.Forms.Button
        Me.lvpendaftaran = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lvkriteria = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tnama)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cinterview)
        Me.GroupBox2.Controls.Add(Me.cdokumen)
        Me.GroupBox2.Controls.Add(Me.cpengalaman)
        Me.GroupBox2.Controls.Add(Me.cpendidikan)
        Me.GroupBox2.Controls.Add(Me.cusia)
        Me.GroupBox2.Controls.Add(Me.txtpendaftaran)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(234, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 211)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Kriteria"
        '
        'tnama
        '
        Me.tnama.Enabled = False
        Me.tnama.Location = New System.Drawing.Point(131, 49)
        Me.tnama.Name = "tnama"
        Me.tnama.ReadOnly = True
        Me.tnama.Size = New System.Drawing.Size(121, 20)
        Me.tnama.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nama"
        '
        'cinterview
        '
        Me.cinterview.FormattingEnabled = True
        Me.cinterview.Items.AddRange(New Object() {"--PILIH--", "Sangat Baik", "Baik", "Cukup Baik", "Tidak Baik"})
        Me.cinterview.Location = New System.Drawing.Point(131, 183)
        Me.cinterview.Name = "cinterview"
        Me.cinterview.Size = New System.Drawing.Size(121, 21)
        Me.cinterview.TabIndex = 16
        '
        'cdokumen
        '
        Me.cdokumen.FormattingEnabled = True
        Me.cdokumen.Items.AddRange(New Object() {"--PILIH--", "Sangat Lengkap", "Lengkap", "Cukup Lengkap", "Tidak Lengkap"})
        Me.cdokumen.Location = New System.Drawing.Point(131, 156)
        Me.cdokumen.Name = "cdokumen"
        Me.cdokumen.Size = New System.Drawing.Size(121, 21)
        Me.cdokumen.TabIndex = 15
        '
        'cpengalaman
        '
        Me.cpengalaman.FormattingEnabled = True
        Me.cpengalaman.Items.AddRange(New Object() {"--PILIH--", "≥ 11 Tahun", "7 - 10 Tahun", "4 - 6 Tahun", "≤ 3 Tahun"})
        Me.cpengalaman.Location = New System.Drawing.Point(131, 129)
        Me.cpengalaman.Name = "cpengalaman"
        Me.cpengalaman.Size = New System.Drawing.Size(121, 21)
        Me.cpengalaman.TabIndex = 14
        '
        'cpendidikan
        '
        Me.cpendidikan.FormattingEnabled = True
        Me.cpendidikan.Items.AddRange(New Object() {"--PILIH--", "S1", "D3", "SMA / SEDERAJAT"})
        Me.cpendidikan.Location = New System.Drawing.Point(131, 102)
        Me.cpendidikan.Name = "cpendidikan"
        Me.cpendidikan.Size = New System.Drawing.Size(121, 21)
        Me.cpendidikan.TabIndex = 13
        '
        'cusia
        '
        Me.cusia.FormattingEnabled = True
        Me.cusia.Items.AddRange(New Object() {"--Pilih--", "35 - 45 Tahun", "29 - 34 Tahun", "23 - 28 Tahun", "≤ 22 Tahun"})
        Me.cusia.Location = New System.Drawing.Point(131, 75)
        Me.cusia.Name = "cusia"
        Me.cusia.Size = New System.Drawing.Size(121, 21)
        Me.cusia.TabIndex = 12
        '
        'txtpendaftaran
        '
        Me.txtpendaftaran.Enabled = False
        Me.txtpendaftaran.Location = New System.Drawing.Point(131, 23)
        Me.txtpendaftaran.Name = "txtpendaftaran"
        Me.txtpendaftaran.ReadOnly = True
        Me.txtpendaftaran.Size = New System.Drawing.Size(68, 20)
        Me.txtpendaftaran.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "No Pendaftaran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Interview"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Dokumen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Pengalaman Kerja"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Pendidikan Terakhir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Usia"
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(533, 77)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(88, 23)
        Me.btnsimpan.TabIndex = 2
        Me.btnsimpan.Text = "Simpan Data"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(532, 107)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(88, 23)
        Me.btnhapus.TabIndex = 4
        Me.btnhapus.Text = "Hapus Data"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btntutup
        '
        Me.btntutup.Location = New System.Drawing.Point(532, 140)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(88, 23)
        Me.btntutup.TabIndex = 5
        Me.btntutup.Text = "Tutup Aplikasi"
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'lvpendaftaran
        '
        Me.lvpendaftaran.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvpendaftaran.FullRowSelect = True
        Me.lvpendaftaran.GridLines = True
        Me.lvpendaftaran.Location = New System.Drawing.Point(12, 12)
        Me.lvpendaftaran.Name = "lvpendaftaran"
        Me.lvpendaftaran.Size = New System.Drawing.Size(216, 211)
        Me.lvpendaftaran.TabIndex = 6
        Me.lvpendaftaran.UseCompatibleStateImageBehavior = False
        Me.lvpendaftaran.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No. Pendaftaran"
        Me.ColumnHeader1.Width = 110
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 96
        '
        'lvkriteria
        '
        Me.lvkriteria.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader9, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvkriteria.FullRowSelect = True
        Me.lvkriteria.GridLines = True
        Me.lvkriteria.Location = New System.Drawing.Point(12, 229)
        Me.lvkriteria.Name = "lvkriteria"
        Me.lvkriteria.Size = New System.Drawing.Size(608, 201)
        Me.lvkriteria.TabIndex = 7
        Me.lvkriteria.UseCompatibleStateImageBehavior = False
        Me.lvkriteria.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "No. Pendaftaran"
        Me.ColumnHeader3.Width = 96
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Nama"
        Me.ColumnHeader9.Width = 101
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Usia"
        Me.ColumnHeader4.Width = 47
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Pendidikan Terakhir"
        Me.ColumnHeader5.Width = 118
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Pengalaman Kerja"
        Me.ColumnHeader6.Width = 106
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Dokumen"
        Me.ColumnHeader7.Width = 64
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Interview"
        Me.ColumnHeader8.Width = 66
        '
        'Data_Kriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(632, 442)
        Me.Controls.Add(Me.lvkriteria)
        Me.Controls.Add(Me.lvpendaftaran)
        Me.Controls.Add(Me.btntutup)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Data_Kriteria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_Kriteria"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents lvpendaftaran As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvkriteria As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtpendaftaran As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cinterview As System.Windows.Forms.ComboBox
    Friend WithEvents cdokumen As System.Windows.Forms.ComboBox
    Friend WithEvents cpengalaman As System.Windows.Forms.ComboBox
    Friend WithEvents cpendidikan As System.Windows.Forms.ComboBox
    Friend WithEvents cusia As System.Windows.Forms.ComboBox
    Friend WithEvents tnama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
End Class
