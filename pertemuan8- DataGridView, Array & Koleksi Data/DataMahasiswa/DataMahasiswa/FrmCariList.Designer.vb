<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCariList
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
        lblCari = New Label()
        lblJumlah = New Label()
        txtCari = New TextBox()
        dgvMahasiswa = New DataGridView()
        bsMahasiswa = New BindingSource(components)
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(0, -3)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(412, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Mencari di List(Of Mahasiswa)"
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Location = New Point(12, 61)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(136, 25)
        lblCari.TabIndex = 1
        lblCari.Text = "Cari nama/NIM:"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(24, 328)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(174, 25)
        lblJumlah.TabIndex = 2
        lblJumlah.Text = "Menampilkan 0 data"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(142, 58)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(383, 31)
        txtCari.TabIndex = 3
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(24, 98)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(647, 225)
        dgvMahasiswa.TabIndex = 4
        ' 
        ' FrmCariList
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(698, 374)
        Controls.Add(dgvMahasiswa)
        Controls.Add(txtCari)
        Controls.Add(lblJumlah)
        Controls.Add(lblCari)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmCariList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pencarian dengan Perulangan"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblCari As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents bsMahasiswa As BindingSource
End Class
