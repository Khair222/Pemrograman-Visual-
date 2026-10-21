<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPendaftaran
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
        lblJudul = New Label()
        lblNim = New Label()
        lblNama = New Label()
        lblJurusan = New Label()
        lblAngkatan = New Label()
        lblIpk = New Label()
        lblDaftar = New Label()
        lblStatus = New Label()
        txtNim = New TextBox()
        txtNama = New TextBox()
        txtAngkatan = New TextBox()
        txtIpk = New TextBox()
        cboJurusan = New ComboBox()
        btnSimpan = New Button()
        btnBersihkan = New Button()
        btnEkspor = New Button()
        lstMahasiswa = New ListBox()
        errInput = New ErrorProvider(components)
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(12, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(329, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Pendaftaran Mahasiswa"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(25, 47)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(46, 25)
        lblNim.TabIndex = 1
        lblNim.Text = "NIM"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(25, 83)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(25, 125)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(71, 25)
        lblJurusan.TabIndex = 3
        lblJurusan.Text = "Jurusan"
        ' 
        ' lblAngkatan
        ' 
        lblAngkatan.AutoSize = True
        lblAngkatan.Location = New Point(25, 171)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New Size(88, 25)
        lblAngkatan.TabIndex = 4
        lblAngkatan.Text = "Angkatan"
        ' 
        ' lblIpk
        ' 
        lblIpk.AutoSize = True
        lblIpk.Location = New Point(34, 219)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New Size(37, 25)
        lblIpk.TabIndex = 5
        lblIpk.Text = "IPK"
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Location = New Point(443, 20)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(133, 25)
        lblDaftar.TabIndex = 6
        lblDaftar.Text = "Data tersimpan"
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(34, 377)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(660, 28)
        lblStatus.TabIndex = 7
        lblStatus.Text = "siap."
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(175, 50)
        txtNim.MaxLength = 9
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(235, 31)
        txtNim.TabIndex = 8
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(175, 87)
        txtNama.MaxLength = 100
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(235, 31)
        txtNama.TabIndex = 9
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Location = New Point(175, 165)
        txtAngkatan.MaxLength = 4
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(235, 31)
        txtAngkatan.TabIndex = 10
        ' 
        ' txtIpk
        ' 
        txtIpk.Location = New Point(175, 213)
        txtIpk.MaxLength = 4
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(235, 31)
        txtIpk.TabIndex = 11
        ' 
        ' cboJurusan
        ' 
        cboJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        cboJurusan.FormattingEnabled = True
        cboJurusan.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi", "Manajemen Informatika", "Teknik Komputer"})
        cboJurusan.Location = New Point(175, 126)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New Size(235, 33)
        cboJurusan.TabIndex = 12
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(161, 272)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(298, 272)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(112, 34)
        btnBersihkan.TabIndex = 14
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnEkspor
        ' 
        btnEkspor.CausesValidation = False
        btnEkspor.Location = New Point(443, 302)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(112, 34)
        btnEkspor.TabIndex = 15
        btnEkspor.Text = "Ekspor ke CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lstMahasiswa
        ' 
        lstMahasiswa.FormattingEnabled = True
        lstMahasiswa.HorizontalScrollbar = True
        lstMahasiswa.IntegralHeight = False
        lstMahasiswa.Location = New Point(443, 67)
        lstMahasiswa.Name = "lstMahasiswa"
        lstMahasiswa.Size = New Size(283, 229)
        lstMahasiswa.TabIndex = 16
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' FrmPendaftaran
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(758, 414)
        Controls.Add(lstMahasiswa)
        Controls.Add(btnEkspor)
        Controls.Add(btnBersihkan)
        Controls.Add(btnSimpan)
        Controls.Add(cboJurusan)
        Controls.Add(txtIpk)
        Controls.Add(txtAngkatan)
        Controls.Add(txtNama)
        Controls.Add(txtNim)
        Controls.Add(lblStatus)
        Controls.Add(lblDaftar)
        Controls.Add(lblIpk)
        Controls.Add(lblAngkatan)
        Controls.Add(lblJurusan)
        Controls.Add(lblNama)
        Controls.Add(lblNim)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        Name = "FrmPendaftaran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pendaftaran Mahasiswa"
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents lblAngkatan As Label
    Friend WithEvents lblIpk As Label
    Friend WithEvents lblDaftar As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAngkatan As TextBox
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents cboJurusan As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lstMahasiswa As ListBox
    Friend WithEvents errInput As ErrorProvider
    Friend WithEvents txtNim As TextBox
End Class
