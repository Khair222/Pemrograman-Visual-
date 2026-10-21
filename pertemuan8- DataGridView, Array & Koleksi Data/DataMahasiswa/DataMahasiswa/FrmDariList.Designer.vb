<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDariList
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
        components = New ComponentModel.Container()
        lblJudul = New Label()
        lblNim = New Label()
        lblNama = New Label()
        lblJurusan = New Label()
        lblAngkatan = New Label()
        lblIpk = New Label()
        lblJumlah = New Label()
        txtNim = New TextBox()
        txtIpk = New TextBox()
        txtAngkatan = New TextBox()
        txtNama = New TextBox()
        cboJurusan = New ComboBox()
        dgvMahasiswa = New DataGridView()
        btnTambah = New Button()
        bsMahasiswa = New BindingSource(components)
        errInput = New ErrorProvider(components)
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(0, -2)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(492, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "List(Of Mahasiswa) + BindingSource"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(26, 60)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(46, 25)
        lblNim.TabIndex = 1
        lblNim.Text = "NIM"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(26, 97)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(26, 134)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(77, 25)
        lblJurusan.TabIndex = 3
        lblJurusan.Text = "Jurursan"
        ' 
        ' lblAngkatan
        ' 
        lblAngkatan.AutoSize = True
        lblAngkatan.Location = New Point(26, 172)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New Size(88, 25)
        lblAngkatan.TabIndex = 4
        lblAngkatan.Text = "Angkatan"
        ' 
        ' lblIpk
        ' 
        lblIpk.AutoSize = True
        lblIpk.Location = New Point(26, 218)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New Size(37, 25)
        lblIpk.TabIndex = 5
        lblIpk.Text = "IPK"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(26, 327)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(126, 25)
        lblJumlah.TabIndex = 6
        lblJumlah.Text = "Jumlah data: 0"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(133, 60)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(208, 31)
        txtNim.TabIndex = 7
        ' 
        ' txtIpk
        ' 
        txtIpk.Location = New Point(133, 212)
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(208, 31)
        txtIpk.TabIndex = 8
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Location = New Point(133, 169)
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(208, 31)
        txtAngkatan.TabIndex = 9
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(133, 97)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(208, 31)
        txtNama.TabIndex = 10
        ' 
        ' cboJurusan
        ' 
        cboJurusan.FormattingEnabled = True
        cboJurusan.Items.AddRange(New Object() {" Teknik Informatika", " Sistem Informasi", "Manajemen Informatika", "Teknik Komputer "})
        cboJurusan.Location = New Point(133, 131)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New Size(208, 33)
        cboJurusan.TabIndex = 11
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(366, 48)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(360, 225)
        dgvMahasiswa.TabIndex = 12
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(131, 259)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 13
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' FrmDariList
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(738, 414)
        Controls.Add(btnTambah)
        Controls.Add(dgvMahasiswa)
        Controls.Add(cboJurusan)
        Controls.Add(txtNama)
        Controls.Add(txtAngkatan)
        Controls.Add(txtIpk)
        Controls.Add(txtNim)
        Controls.Add(lblJumlah)
        Controls.Add(lblIpk)
        Controls.Add(lblAngkatan)
        Controls.Add(lblJurusan)
        Controls.Add(lblNama)
        Controls.Add(lblNim)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Binding List(Of Mahasiswa)"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblJumlah As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents txtAngkatan As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cboJurusan As ComboBox
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents btnTambah As Button
    Friend WithEvents bsMahasiswa As BindingSource
    Friend WithEvents errInput As ErrorProvider
End Class
