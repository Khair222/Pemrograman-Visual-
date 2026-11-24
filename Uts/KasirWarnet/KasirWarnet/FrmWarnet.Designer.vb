<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWarnet
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
        lblLayanan = New Label()
        cboLayanan = New ComboBox()
        btnTambah = New Button()
        btnBaru = New Button()
        lblJam = New Label()
        txtJumlah = New TextBox()
        dgvPesanan = New DataGridView()
        lblTotal = New Label()
        bsPesanan = New BindingSource(components)
        errInput = New ErrorProvider(components)
        lblTotall = New Label()
        CType(dgvPesanan, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsPesanan, ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblJudul.Location = New Point(34, 27)
        lblJudul.Margin = New Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(185, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Kasir Warnet"
        ' 
        ' lblLayanan
        ' 
        lblLayanan.AutoSize = True
        lblLayanan.Location = New Point(34, 110)
        lblLayanan.Margin = New Padding(4, 0, 4, 0)
        lblLayanan.Name = "lblLayanan"
        lblLayanan.Size = New Size(76, 25)
        lblLayanan.TabIndex = 1
        lblLayanan.Text = "Layanan"
        ' 
        ' cboLayanan
        ' 
        cboLayanan.DropDownStyle = ComboBoxStyle.DropDownList
        cboLayanan.FormattingEnabled = True
        cboLayanan.Location = New Point(186, 103)
        cboLayanan.Margin = New Padding(4, 5, 4, 5)
        cboLayanan.Name = "cboLayanan"
        cboLayanan.Size = New Size(284, 33)
        cboLayanan.TabIndex = 2
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(529, 100)
        btnTambah.Margin = New Padding(4, 5, 4, 5)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(143, 45)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBaru
        ' 
        btnBaru.CausesValidation = False
        btnBaru.Location = New Point(686, 100)
        btnBaru.Margin = New Padding(4, 5, 4, 5)
        btnBaru.Name = "btnBaru"
        btnBaru.Size = New Size(186, 45)
        btnBaru.TabIndex = 5
        btnBaru.Text = "Transaksi Baru"
        btnBaru.UseVisualStyleBackColor = True
        ' 
        ' lblJam
        ' 
        lblJam.AutoSize = True
        lblJam.Location = New Point(34, 170)
        lblJam.Margin = New Padding(4, 0, 4, 0)
        lblJam.Name = "lblJam"
        lblJam.Size = New Size(101, 25)
        lblJam.TabIndex = 6
        lblJam.Text = "Jumlah jam"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(186, 163)
        txtJumlah.Margin = New Padding(4, 5, 4, 5)
        txtJumlah.MaxLength = 3
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(284, 31)
        txtJumlah.TabIndex = 3
        ' 
        ' dgvPesanan
        ' 
        dgvPesanan.AllowUserToAddRows = False
        dgvPesanan.AllowUserToDeleteRows = False
        dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPesanan.Location = New Point(34, 233)
        dgvPesanan.Margin = New Padding(4, 5, 4, 5)
        dgvPesanan.MultiSelect = False
        dgvPesanan.Name = "dgvPesanan"
        dgvPesanan.ReadOnly = True
        dgvPesanan.RowHeadersVisible = False
        dgvPesanan.RowHeadersWidth = 62
        dgvPesanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPesanan.Size = New Size(837, 417)
        dgvPesanan.TabIndex = 7
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotal.Location = New Point(671, 683)
        lblTotal.Margin = New Padding(4, 0, 4, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(66, 32)
        lblTotal.TabIndex = 9
        lblTotal.Text = "Rp 0"
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' lblTotall
        ' 
        lblTotall.AutoSize = True
        lblTotall.Location = New Point(540, 690)
        lblTotall.Name = "lblTotall"
        lblTotall.Size = New Size(97, 25)
        lblTotall.TabIndex = 10
        lblTotall.Text = "Total Bayar"
        ' 
        ' FrmWarnet
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 767)
        Controls.Add(lblTotall)
        Controls.Add(lblTotal)
        Controls.Add(dgvPesanan)
        Controls.Add(txtJumlah)
        Controls.Add(lblJam)
        Controls.Add(btnBaru)
        Controls.Add(btnTambah)
        Controls.Add(cboLayanan)
        Controls.Add(lblLayanan)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "FrmWarnet"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kasir Warnet"
        CType(dgvPesanan, ComponentModel.ISupportInitialize).EndInit()
        CType(bsPesanan, ComponentModel.ISupportInitialize).EndInit()
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblLayanan As Label
    Friend WithEvents cboLayanan As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBaru As Button
    Friend WithEvents lblJam As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents dgvPesanan As DataGridView
    Friend WithEvents lblTotalBayar As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents bsPesanan As BindingSource
    Friend WithEvents errInput As ErrorProvider

    Private Sub cboPaket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLayanan.SelectedIndexChanged

    End Sub

    Friend WithEvents lblTotall As Label
End Class
