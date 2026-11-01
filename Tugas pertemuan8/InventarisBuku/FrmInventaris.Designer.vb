<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventaris
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblJudulForm = New Label()
        lblKodeBuku = New Label()
        txtKodeBuku = New TextBox()
        lblJudul = New Label()
        txtJudul = New TextBox()
        lblPenulis = New Label()
        txtPenulis = New TextBox()
        lblKategori = New Label()
        cboKategori = New ComboBox()
        lblTahun = New Label()
        txtTahun = New TextBox()
        lblStok = New Label()
        txtStok = New TextBox()
        btnTambah = New Button()
        btnBersihkan = New Button()
        lblCari = New Label()
        txtCari = New TextBox()
        lblFilterKategori = New Label()
        cboFilterKategori = New ComboBox()
        chkStokHabis = New CheckBox()
        lblUrut = New Label()
        cboUrut = New ComboBox()
        dgvBuku = New DataGridView()
        lblJumlah = New Label()
        lblTotalStok = New Label()
        bsBuku = New BindingSource(components)
        errBuku = New ErrorProvider(components)
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(errBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblJudulForm.Location = New Point(34, 27)
        lblJudulForm.Margin = New Padding(4, 0, 4, 0)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(408, 38)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Inventaris Buku Perpustakaan"
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New Point(34, 117)
        lblKodeBuku.Margin = New Padding(4, 0, 4, 0)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(173, 25)
        lblKodeBuku.TabIndex = 1
        lblKodeBuku.Text = "Kode buku (BK0001)"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.CharacterCasing = CharacterCasing.Upper
        txtKodeBuku.Location = New Point(34, 153)
        txtKodeBuku.Margin = New Padding(4, 5, 4, 5)
        txtKodeBuku.MaxLength = 6
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(231, 31)
        txtKodeBuku.TabIndex = 2
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(34, 220)
        lblJudul.Margin = New Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(98, 25)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Judul buku"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(34, 257)
        txtJudul.Margin = New Padding(4, 5, 4, 5)
        txtJudul.MaxLength = 100
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(231, 31)
        txtJudul.TabIndex = 4
        ' 
        ' lblPenulis
        ' 
        lblPenulis.AutoSize = True
        lblPenulis.Location = New Point(34, 323)
        lblPenulis.Margin = New Padding(4, 0, 4, 0)
        lblPenulis.Name = "lblPenulis"
        lblPenulis.Size = New Size(66, 25)
        lblPenulis.TabIndex = 5
        lblPenulis.Text = "Penulis"
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(34, 360)
        txtPenulis.Margin = New Padding(4, 5, 4, 5)
        txtPenulis.MaxLength = 100
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(231, 31)
        txtPenulis.TabIndex = 6
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(34, 427)
        lblKategori.Margin = New Padding(4, 0, 4, 0)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(78, 25)
        lblKategori.TabIndex = 7
        lblKategori.Text = "Kategori"
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New Point(34, 463)
        cboKategori.Margin = New Padding(4, 5, 4, 5)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(231, 33)
        cboKategori.TabIndex = 8
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Location = New Point(34, 530)
        lblTahun.Margin = New Padding(4, 0, 4, 0)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(105, 25)
        lblTahun.TabIndex = 9
        lblTahun.Text = "Tahun terbit"
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(34, 567)
        txtTahun.Margin = New Padding(4, 5, 4, 5)
        txtTahun.MaxLength = 4
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(231, 31)
        txtTahun.TabIndex = 10
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Location = New Point(34, 633)
        lblStok.Margin = New Padding(4, 0, 4, 0)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(47, 25)
        lblStok.TabIndex = 11
        lblStok.Text = "Stok"
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(34, 670)
        txtStok.Margin = New Padding(4, 5, 4, 5)
        txtStok.MaxLength = 6
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(370, 31)
        txtStok.TabIndex = 12
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(34, 750)
        btnTambah.Margin = New Padding(4, 5, 4, 5)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(179, 57)
        btnTambah.TabIndex = 13
        btnTambah.Text = "Tambah Buku"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(227, 750)
        btnBersihkan.Margin = New Padding(4, 5, 4, 5)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(179, 57)
        btnBersihkan.TabIndex = 14
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Location = New Point(456, 131)
        lblCari.Margin = New Padding(4, 0, 4, 0)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(149, 25)
        lblCari.TabIndex = 15
        lblCari.Text = "Cari judul/penulis"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(456, 167)
        txtCari.Margin = New Padding(4, 5, 4, 5)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(617, 31)
        txtCari.TabIndex = 16
        ' 
        ' lblFilterKategori
        ' 
        lblFilterKategori.AutoSize = True
        lblFilterKategori.Location = New Point(456, 234)
        lblFilterKategori.Margin = New Padding(4, 0, 4, 0)
        lblFilterKategori.Name = "lblFilterKategori"
        lblFilterKategori.Size = New Size(120, 25)
        lblFilterKategori.TabIndex = 17
        lblFilterKategori.Text = "Filter kategori"
        ' 
        ' cboFilterKategori
        ' 
        cboFilterKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterKategori.FormattingEnabled = True
        cboFilterKategori.Items.AddRange(New Object() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboFilterKategori.Location = New Point(456, 271)
        cboFilterKategori.Margin = New Padding(4, 5, 4, 5)
        cboFilterKategori.Name = "cboFilterKategori"
        cboFilterKategori.Size = New Size(314, 33)
        cboFilterKategori.TabIndex = 18
        ' 
        ' chkStokHabis
        ' 
        chkStokHabis.AutoSize = True
        chkStokHabis.Location = New Point(778, 274)
        chkStokHabis.Margin = New Padding(4, 5, 4, 5)
        chkStokHabis.Name = "chkStokHabis"
        chkStokHabis.Size = New Size(174, 29)
        chkStokHabis.TabIndex = 19
        chkStokHabis.Text = "Hanya stok habis"
        chkStokHabis.UseVisualStyleBackColor = True
        ' 
        ' lblUrut
        ' 
        lblUrut.AutoSize = True
        lblUrut.Location = New Point(946, 234)
        lblUrut.Margin = New Padding(4, 0, 4, 0)
        lblUrut.Name = "lblUrut"
        lblUrut.Size = New Size(119, 25)
        lblUrut.TabIndex = 20
        lblUrut.Text = "Urutkan buku"
        ' 
        ' cboUrut
        ' 
        cboUrut.DropDownStyle = ComboBoxStyle.DropDownList
        cboUrut.FormattingEnabled = True
        cboUrut.Items.AddRange(New Object() {"Urutan awal", "Judul A-Z", "Tahun terbaru", "Stok terbanyak"})
        cboUrut.Location = New Point(946, 272)
        cboUrut.Margin = New Padding(4, 5, 4, 5)
        cboUrut.Name = "cboUrut"
        cboUrut.Size = New Size(163, 33)
        cboUrut.TabIndex = 21
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AllowUserToDeleteRows = False
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(457, 333)
        dgvBuku.Margin = New Padding(4, 5, 4, 5)
        dgvBuku.MultiSelect = False
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersVisible = False
        dgvBuku.RowHeadersWidth = 62
        dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBuku.Size = New Size(652, 481)
        dgvBuku.TabIndex = 22
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(457, 884)
        lblJumlah.Margin = New Padding(4, 0, 4, 0)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(229, 25)
        lblJumlah.TabIndex = 23
        lblJumlah.Text = "Menampilkan 0 dari 0 buku"
        ' 
        ' lblTotalStok
        ' 
        lblTotalStok.AutoSize = True
        lblTotalStok.Location = New Point(457, 842)
        lblTotalStok.Margin = New Padding(4, 0, 4, 0)
        lblTotalStok.Name = "lblTotalStok"
        lblTotalStok.Size = New Size(206, 25)
        lblTotalStok.TabIndex = 24
        lblTotalStok.Text = "Total stok yang tampil: 0"
        ' 
        ' errBuku
        ' 
        errBuku.ContainerControl = Me
        ' 
        ' FrmInventaris
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1144, 944)
        Controls.Add(lblTotalStok)
        Controls.Add(lblJumlah)
        Controls.Add(dgvBuku)
        Controls.Add(cboUrut)
        Controls.Add(lblUrut)
        Controls.Add(chkStokHabis)
        Controls.Add(cboFilterKategori)
        Controls.Add(lblFilterKategori)
        Controls.Add(txtCari)
        Controls.Add(lblCari)
        Controls.Add(btnBersihkan)
        Controls.Add(btnTambah)
        Controls.Add(txtStok)
        Controls.Add(lblStok)
        Controls.Add(txtTahun)
        Controls.Add(lblTahun)
        Controls.Add(cboKategori)
        Controls.Add(lblKategori)
        Controls.Add(txtPenulis)
        Controls.Add(lblPenulis)
        Controls.Add(txtJudul)
        Controls.Add(lblJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudulForm)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "FrmInventaris"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventaris Buku Perpustakaan"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(errBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lblPenulis As Label
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents lblKategori As Label
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents lblTahun As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents lblStok As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents lblFilterKategori As Label
    Friend WithEvents cboFilterKategori As ComboBox
    Friend WithEvents chkStokHabis As CheckBox
    Friend WithEvents lblUrut As Label
    Friend WithEvents cboUrut As ComboBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTotalStok As Label
    Friend WithEvents bsBuku As BindingSource
    Friend WithEvents errBuku As ErrorProvider

End Class
