<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class laporan
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
        Me.lvlaporan = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnkeluar = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lvlaporan
        '
        Me.lvlaporan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvlaporan.FullRowSelect = True
        Me.lvlaporan.GridLines = True
        Me.lvlaporan.Location = New System.Drawing.Point(12, 56)
        Me.lvlaporan.Name = "lvlaporan"
        Me.lvlaporan.Size = New System.Drawing.Size(742, 263)
        Me.lvlaporan.TabIndex = 1
        Me.lvlaporan.UseCompatibleStateImageBehavior = False
        Me.lvlaporan.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No. Pendaftaran"
        Me.ColumnHeader1.Width = 97
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Usia"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Pendidikan Terakhir"
        Me.ColumnHeader4.Width = 118
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Pengalaman Kerja"
        Me.ColumnHeader5.Width = 107
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Dokumen"
        Me.ColumnHeader6.Width = 67
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Interview"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Total Nilai"
        Me.ColumnHeader8.Width = 72
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Keterangan"
        Me.ColumnHeader9.Width = 73
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(580, 325)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(84, 32)
        Me.btnprint.TabIndex = 3
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(670, 325)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(84, 32)
        Me.btnkeluar.TabIndex = 4
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(240, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(325, 35)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "LAPORAN PERHITUNGAN"
        '
        'laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(764, 369)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.lvlaporan)
        Me.Name = "laporan"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvlaporan As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
