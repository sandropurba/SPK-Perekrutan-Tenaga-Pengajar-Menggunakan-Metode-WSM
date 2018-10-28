<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proses_Pembuatan_Nilai
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
        Me.lvdata = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.lvperangkingan = New System.Windows.Forms.ListView
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.btnproses = New System.Windows.Forms.Button
        Me.btnkeluar = New System.Windows.Forms.Button
        Me.lvbobot = New System.Windows.Forms.ListView
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lvdata
        '
        Me.lvdata.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvdata.FullRowSelect = True
        Me.lvdata.GridLines = True
        Me.lvdata.Location = New System.Drawing.Point(28, 12)
        Me.lvdata.Name = "lvdata"
        Me.lvdata.Size = New System.Drawing.Size(695, 186)
        Me.lvdata.TabIndex = 0
        Me.lvdata.UseCompatibleStateImageBehavior = False
        Me.lvdata.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No pendaftaran"
        Me.ColumnHeader1.Width = 93
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Usia"
        Me.ColumnHeader3.Width = 71
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Pendidikan Terakhir"
        Me.ColumnHeader4.Width = 111
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Pengalaman kerja"
        Me.ColumnHeader5.Width = 101
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Dokumen"
        Me.ColumnHeader6.Width = 82
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Interview"
        Me.ColumnHeader7.Width = 87
        '
        'lvperangkingan
        '
        Me.lvperangkingan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.lvperangkingan.FullRowSelect = True
        Me.lvperangkingan.GridLines = True
        Me.lvperangkingan.Location = New System.Drawing.Point(28, 204)
        Me.lvperangkingan.Name = "lvperangkingan"
        Me.lvperangkingan.Size = New System.Drawing.Size(759, 190)
        Me.lvperangkingan.TabIndex = 1
        Me.lvperangkingan.UseCompatibleStateImageBehavior = False
        Me.lvperangkingan.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "No Pendaftaran"
        Me.ColumnHeader8.Width = 94
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Nama"
        Me.ColumnHeader9.Width = 68
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Usia"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Pendidikan terakhir"
        Me.ColumnHeader11.Width = 112
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Pengalaman Kerja"
        Me.ColumnHeader12.Width = 106
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Dokumen"
        Me.ColumnHeader13.Width = 78
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Interview"
        Me.ColumnHeader14.Width = 74
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Total"
        Me.ColumnHeader15.Width = 67
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Keterangan"
        Me.ColumnHeader16.Width = 86
        '
        'btnproses
        '
        Me.btnproses.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproses.Location = New System.Drawing.Point(842, 217)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(259, 50)
        Me.btnproses.TabIndex = 2
        Me.btnproses.Text = "Proses"
        Me.btnproses.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(842, 332)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(259, 53)
        Me.btnkeluar.TabIndex = 3
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'lvbobot
        '
        Me.lvbobot.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21})
        Me.lvbobot.FullRowSelect = True
        Me.lvbobot.GridLines = True
        Me.lvbobot.Location = New System.Drawing.Point(729, 12)
        Me.lvbobot.Name = "lvbobot"
        Me.lvbobot.Size = New System.Drawing.Size(431, 186)
        Me.lvbobot.TabIndex = 4
        Me.lvbobot.UseCompatibleStateImageBehavior = False
        Me.lvbobot.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Usia"
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Pendidikan Terakhir"
        Me.ColumnHeader18.Width = 114
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Pengalaman kerja"
        Me.ColumnHeader19.Width = 106
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Dokumen"
        Me.ColumnHeader20.Width = 73
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Interview"
        Me.ColumnHeader21.Width = 71
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(842, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 53)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Proses_Pembuatan_Nilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1172, 404)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lvbobot)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnproses)
        Me.Controls.Add(Me.lvperangkingan)
        Me.Controls.Add(Me.lvdata)
        Me.Name = "Proses_Pembuatan_Nilai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Keputusan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvdata As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvperangkingan As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnproses As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents lvbobot As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
