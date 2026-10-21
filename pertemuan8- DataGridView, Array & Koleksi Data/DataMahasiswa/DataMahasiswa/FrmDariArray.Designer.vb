<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDariArray
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
        lblJudul = New Label()
        btnTampilkan = New Button()
        btnKosongkan = New Button()
        lblJumlah = New Label()
        dgvMahasiswa = New DataGridView()
        colNim = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colJurusan = New DataGridViewTextBoxColumn()
        colAngkatan = New DataGridViewTextBoxColumn()
        colIpk = New DataGridViewTextBoxColumn()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(-2, -4)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(357, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Data dari Array 2 Dimensi"
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(12, 287)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 34)
        btnTampilkan.TabIndex = 1
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnKosongkan
        ' 
        btnKosongkan.Location = New Point(152, 287)
        btnKosongkan.Name = "btnKosongkan"
        btnKosongkan.Size = New Size(112, 34)
        btnKosongkan.TabIndex = 2
        btnKosongkan.Text = "Kosongkan"
        btnKosongkan.UseVisualStyleBackColor = True
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(349, 296)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(126, 25)
        lblJumlah.TabIndex = 3
        lblJumlah.Text = "Jumlah data: 0"
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Columns.AddRange(New DataGridViewColumn() {colNim, colNama, colJurusan, colAngkatan, colIpk})
        dgvMahasiswa.Location = New Point(12, 37)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(674, 234)
        dgvMahasiswa.TabIndex = 4
        ' 
        ' colNim
        ' 
        colNim.HeaderText = "NIM"
        colNim.MinimumWidth = 8
        colNim.Name = "colNim"
        colNim.ReadOnly = True
        ' 
        ' colNama
        ' 
        colNama.HeaderText = "Nama"
        colNama.MinimumWidth = 8
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        ' 
        ' colJurusan
        ' 
        colJurusan.HeaderText = "Jurusan"
        colJurusan.MinimumWidth = 8
        colJurusan.Name = "colJurusan"
        colJurusan.ReadOnly = True
        ' 
        ' colAngkatan
        ' 
        colAngkatan.HeaderText = "Angkatan"
        colAngkatan.MinimumWidth = 8
        colAngkatan.Name = "colAngkatan"
        colAngkatan.ReadOnly = True
        ' 
        ' colIpk
        ' 
        colIpk.HeaderText = "colIpk"
        colIpk.MinimumWidth = 8
        colIpk.Name = "colIpk"
        colIpk.ReadOnly = True
        ' 
        ' FrmDariArray
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(698, 344)
        Controls.Add(dgvMahasiswa)
        Controls.Add(lblJumlah)
        Controls.Add(btnKosongkan)
        Controls.Add(btnTampilkan)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariArray"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataGridView dari Array"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnKosongkan As Button
    Friend WithEvents lblJumlah As Label
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents colNim As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colJurusan As DataGridViewTextBoxColumn
    Friend WithEvents colAngkatan As DataGridViewTextBoxColumn
    Friend WithEvents colIpk As DataGridViewTextBoxColumn
End Class
