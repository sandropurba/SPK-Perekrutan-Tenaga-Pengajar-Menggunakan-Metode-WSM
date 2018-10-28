<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Pelamar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtstatus = New System.Windows.Forms.ComboBox
        Me.txtjk = New System.Windows.Forms.ComboBox
        Me.txtagama = New System.Windows.Forms.ComboBox
        Me.label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txttanggal = New System.Windows.Forms.TextBox
        Me.txttempat = New System.Windows.Forms.TextBox
        Me.txthp = New System.Windows.Forms.TextBox
        Me.txtalamat = New System.Windows.Forms.TextBox
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.txtpendaftaran = New System.Windows.Forms.TextBox
        Me.btnsimpan = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnbersih = New System.Windows.Forms.Button
        Me.btnhapus = New System.Windows.Forms.Button
        Me.btntutup = New System.Windows.Forms.Button
        Me.lvpelamar = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtstatus)
        Me.GroupBox1.Controls.Add(Me.txtjk)
        Me.GroupBox1.Controls.Add(Me.txtagama)
        Me.GroupBox1.Controls.Add(Me.label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txttanggal)
        Me.GroupBox1.Controls.Add(Me.txttempat)
        Me.GroupBox1.Controls.Add(Me.txthp)
        Me.GroupBox1.Controls.Add(Me.txtalamat)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.txtpendaftaran)
        Me.GroupBox1.Location = New System.Drawing.Point(118, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 267)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Pelamar"
        '
        'txtstatus
        '
        Me.txtstatus.FormattingEnabled = True
        Me.txtstatus.Items.AddRange(New Object() {"--PILIH--", "Menikah", "Belum Menikah"})
        Me.txtstatus.Location = New System.Drawing.Point(134, 227)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(121, 21)
        Me.txtstatus.TabIndex = 11
        '
        'txtjk
        '
        Me.txtjk.FormattingEnabled = True
        Me.txtjk.Items.AddRange(New Object() {"--PILIH--", "Laki - Laki", "Perempuan"})
        Me.txtjk.Location = New System.Drawing.Point(134, 97)
        Me.txtjk.Name = "txtjk"
        Me.txtjk.Size = New System.Drawing.Size(121, 21)
        Me.txtjk.TabIndex = 9
        '
        'txtagama
        '
        Me.txtagama.FormattingEnabled = True
        Me.txtagama.Items.AddRange(New Object() {"--PILIH--", "Budha", "Hindu", "Islam", "Kristen", "Katolik"})
        Me.txtagama.Location = New System.Drawing.Point(134, 201)
        Me.txtagama.Name = "txtagama"
        Me.txtagama.Size = New System.Drawing.Size(121, 21)
        Me.txtagama.TabIndex = 10
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(20, 230)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(37, 13)
        Me.label9.TabIndex = 1
        Me.label9.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Agama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tempat Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "No Hp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. Pendaftaran"
        '
        'txttanggal
        '
        Me.txttanggal.Location = New System.Drawing.Point(134, 175)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(130, 20)
        Me.txttanggal.TabIndex = 6
        '
        'txttempat
        '
        Me.txttempat.Location = New System.Drawing.Point(134, 149)
        Me.txttempat.Name = "txttempat"
        Me.txttempat.Size = New System.Drawing.Size(158, 20)
        Me.txttempat.TabIndex = 5
        '
        'txthp
        '
        Me.txthp.Location = New System.Drawing.Point(134, 123)
        Me.txthp.Name = "txthp"
        Me.txthp.Size = New System.Drawing.Size(158, 20)
        Me.txthp.TabIndex = 4
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(134, 71)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(201, 20)
        Me.txtalamat.TabIndex = 2
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(134, 45)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(158, 20)
        Me.txtnama.TabIndex = 1
        '
        'txtpendaftaran
        '
        Me.txtpendaftaran.Location = New System.Drawing.Point(134, 19)
        Me.txtpendaftaran.Name = "txtpendaftaran"
        Me.txtpendaftaran.Size = New System.Drawing.Size(54, 20)
        Me.txtpendaftaran.TabIndex = 0
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(510, 112)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(96, 23)
        Me.btnsimpan.TabIndex = 1
        Me.btnsimpan.Text = "Simpan Data"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(510, 142)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(96, 23)
        Me.btnedit.TabIndex = 2
        Me.btnedit.Text = "Edit Data"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnbersih
        '
        Me.btnbersih.Location = New System.Drawing.Point(510, 172)
        Me.btnbersih.Name = "btnbersih"
        Me.btnbersih.Size = New System.Drawing.Size(96, 23)
        Me.btnbersih.TabIndex = 3
        Me.btnbersih.Text = "Bersihkan Data"
        Me.btnbersih.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(510, 201)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(96, 23)
        Me.btnhapus.TabIndex = 4
        Me.btnhapus.Text = "Hapus Data"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btntutup
        '
        Me.btntutup.Location = New System.Drawing.Point(510, 230)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(96, 23)
        Me.btntutup.TabIndex = 5
        Me.btntutup.Text = "Tutup Aplikasi"
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'lvpelamar
        '
        Me.lvpelamar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvpelamar.FullRowSelect = True
        Me.lvpelamar.GridLines = True
        Me.lvpelamar.Location = New System.Drawing.Point(11, 320)
        Me.lvpelamar.Name = "lvpelamar"
        Me.lvpelamar.Size = New System.Drawing.Size(693, 213)
        Me.lvpelamar.TabIndex = 7
        Me.lvpelamar.UseCompatibleStateImageBehavior = False
        Me.lvpelamar.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No. Pendaftaran"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Alamat"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Jenis Kelamin"
        Me.ColumnHeader4.Width = 89
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "No Hp"
        Me.ColumnHeader5.Width = 73
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tempat Lahir"
        Me.ColumnHeader6.Width = 99
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tanggal Lahir"
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Agama"
        Me.ColumnHeader8.Width = 61
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Status"
        Me.ColumnHeader9.Width = 93
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(237, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(205, 35)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "DATA PELAMAR"
        '
        'Data_Pelamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(716, 543)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lvpelamar)
        Me.Controls.Add(Me.btntutup)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnbersih)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Data_Pelamar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_Pelamar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents txttempat As System.Windows.Forms.TextBox
    Friend WithEvents txthp As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtpendaftaran As System.Windows.Forms.TextBox
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnbersih As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents lvpelamar As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtjk As System.Windows.Forms.ComboBox
    Friend WithEvents txtstatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtagama As System.Windows.Forms.ComboBox
End Class
