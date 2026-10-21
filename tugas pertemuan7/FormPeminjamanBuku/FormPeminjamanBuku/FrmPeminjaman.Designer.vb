<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPeminjaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblJudul = New Label()
        lblKategori = New Label()
        lblNamaPeminjam = New Label()
        lblLamaPinjam = New Label()
        txtKodeBuku = New TextBox()
        txtJudul = New TextBox()
        cboKategori = New ComboBox()
        txtNamaPeminjam = New TextBox()
        txtLamaPinjam = New TextBox()
        btnPinjam = New Button()
        btnBersihkan = New Button()
        lstPeminjaman = New ListBox()
        btnEkspor = New Button()
        lblStatus = New Label()
        errPinjam = New ErrorProvider(components)
        CType(errPinjam, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(12, 9)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(435, 38)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Judul form ""Peminjaman Buku"""
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New Point(13, 70)
        lblKodeBuku.Margin = New Padding(4, 0, 4, 0)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(98, 25)
        lblKodeBuku.TabIndex = 10
        lblKodeBuku.Text = "Kode buku"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(12, 117)
        lblJudul.Margin = New Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(98, 25)
        lblJudul.TabIndex = 11
        lblJudul.Text = "Judul buku"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(13, 155)
        lblKategori.Margin = New Padding(4, 0, 4, 0)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(78, 25)
        lblKategori.TabIndex = 12
        lblKategori.Text = "Kategori"
        ' 
        ' lblNamaPeminjam
        ' 
        lblNamaPeminjam.AutoSize = True
        lblNamaPeminjam.Location = New Point(13, 205)
        lblNamaPeminjam.Margin = New Padding(4, 0, 4, 0)
        lblNamaPeminjam.Name = "lblNamaPeminjam"
        lblNamaPeminjam.Size = New Size(143, 25)
        lblNamaPeminjam.TabIndex = 13
        lblNamaPeminjam.Text = "Nama peminjam"
        ' 
        ' lblLamaPinjam
        ' 
        lblLamaPinjam.AutoSize = True
        lblLamaPinjam.Location = New Point(13, 255)
        lblLamaPinjam.Margin = New Padding(4, 0, 4, 0)
        lblLamaPinjam.Name = "lblLamaPinjam"
        lblLamaPinjam.Size = New Size(157, 25)
        lblLamaPinjam.TabIndex = 14
        lblLamaPinjam.Text = "Lama pinjam (hari)"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(177, 70)
        txtKodeBuku.Margin = New Padding(4, 5, 4, 5)
        txtKodeBuku.MaxLength = 6
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(270, 31)
        txtKodeBuku.TabIndex = 16
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(177, 111)
        txtJudul.Margin = New Padding(4, 5, 4, 5)
        txtJudul.MaxLength = 100
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(270, 31)
        txtJudul.TabIndex = 17
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New Point(177, 152)
        cboKategori.Margin = New Padding(4, 5, 4, 5)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(270, 33)
        cboKategori.TabIndex = 18
        ' 
        ' txtNamaPeminjam
        ' 
        txtNamaPeminjam.Location = New Point(177, 199)
        txtNamaPeminjam.Margin = New Padding(4, 5, 4, 5)
        txtNamaPeminjam.MaxLength = 100
        txtNamaPeminjam.Name = "txtNamaPeminjam"
        txtNamaPeminjam.Size = New Size(270, 31)
        txtNamaPeminjam.TabIndex = 19
        ' 
        ' txtLamaPinjam
        ' 
        txtLamaPinjam.Location = New Point(177, 255)
        txtLamaPinjam.Margin = New Padding(4, 5, 4, 5)
        txtLamaPinjam.MaxLength = 2
        txtLamaPinjam.Name = "txtLamaPinjam"
        txtLamaPinjam.Size = New Size(270, 31)
        txtLamaPinjam.TabIndex = 20
        ' 
        ' btnPinjam
        ' 
        btnPinjam.Location = New Point(143, 309)
        btnPinjam.Margin = New Padding(4, 5, 4, 5)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New Size(129, 50)
        btnPinjam.TabIndex = 21
        btnPinjam.Text = "Pinjam"
        btnPinjam.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(294, 309)
        btnBersihkan.Margin = New Padding(4, 5, 4, 5)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(129, 50)
        btnBersihkan.TabIndex = 22
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lstPeminjaman
        ' 
        lstPeminjaman.FormattingEnabled = True
        lstPeminjaman.HorizontalScrollbar = True
        lstPeminjaman.IntegralHeight = False
        lstPeminjaman.Location = New Point(466, 70)
        lstPeminjaman.Margin = New Padding(4, 5, 4, 5)
        lstPeminjaman.Name = "lstPeminjaman"
        lstPeminjaman.Size = New Size(560, 297)
        lstPeminjaman.TabIndex = 23
        ' 
        ' btnEkspor
        ' 
        btnEkspor.CausesValidation = False
        btnEkspor.Location = New Point(466, 377)
        btnEkspor.Margin = New Padding(4, 5, 4, 5)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(186, 50)
        btnEkspor.TabIndex = 24
        btnEkspor.Text = "Ekspor ke CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(33, 400)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(426, 38)
        lblStatus.TabIndex = 25
        lblStatus.Text = "Status dan jumlah peminjaman"
        ' 
        ' errPinjam
        ' 
        errPinjam.ContainerControl = Me
        ' 
        ' FrmPeminjaman
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1039, 450)
        Controls.Add(lblStatus)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudul)
        Controls.Add(lblKategori)
        Controls.Add(lblNamaPeminjam)
        Controls.Add(lblLamaPinjam)
        Controls.Add(txtKodeBuku)
        Controls.Add(txtJudul)
        Controls.Add(cboKategori)
        Controls.Add(txtNamaPeminjam)
        Controls.Add(txtLamaPinjam)
        Controls.Add(btnPinjam)
        Controls.Add(btnBersihkan)
        Controls.Add(lstPeminjaman)
        Controls.Add(btnEkspor)
        Controls.Add(lblJudulForm)
        Name = "FrmPeminjaman"
        Text = "Peminjaman Buku"
        CType(errPinjam, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblNamaPeminjam As Label
    Friend WithEvents lblLamaPinjam As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents txtNamaPeminjam As TextBox
    Friend WithEvents txtLamaPinjam As TextBox
    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lstPeminjaman As ListBox
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents errPinjam As ErrorProvider

End Class
