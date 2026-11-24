<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDemoApi
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
        pnlTimer = New Panel()
        Label4 = New Label()
        lblTahap = New Label()
        lblSisa = New Label()
        lblKeterangan = New Label()
        lblJudul = New Label()
        lblSubjudul = New Label()
        lblDurasi = New Label()
        chkTeratas = New CheckBox()
        btnUlangi = New Button()
        btnMulai = New Button()
        btnRingkas = New Button()
        chkBunyi = New CheckBox()
        nudMenit = New NumericUpDown()
        nudDetik = New NumericUpDown()
        lblMenit = New Label()
        lblDetik = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        pnlTimer.SuspendLayout()
        CType(nudMenit, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudDetik, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlTimer
        ' 
        pnlTimer.BackColor = SystemColors.ActiveCaptionText
        pnlTimer.Controls.Add(Label4)
        pnlTimer.Controls.Add(lblTahap)
        pnlTimer.Controls.Add(lblSisa)
        pnlTimer.Controls.Add(lblKeterangan)
        pnlTimer.Location = New Point(21, 107)
        pnlTimer.Name = "pnlTimer"
        pnlTimer.Size = New Size(676, 341)
        pnlTimer.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(227, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(224, 96)
        Label4.TabIndex = 7
        Label4.Text = "05:00"
        ' 
        ' lblTahap
        ' 
        lblTahap.AutoSize = True
        lblTahap.ForeColor = SystemColors.ButtonHighlight
        lblTahap.Location = New Point(271, 42)
        lblTahap.Name = "lblTahap"
        lblTahap.Size = New Size(131, 25)
        lblTahap.TabIndex = 5
        lblTahap.Text = "Siap presentasi"
        ' 
        ' lblSisa
        ' 
        lblSisa.AutoSize = True
        lblSisa.Location = New Point(271, 174)
        lblSisa.Name = "lblSisa"
        lblSisa.Size = New Size(0, 25)
        lblSisa.TabIndex = 3
        ' 
        ' lblKeterangan
        ' 
        lblKeterangan.AutoSize = True
        lblKeterangan.ForeColor = SystemColors.ButtonHighlight
        lblKeterangan.Location = New Point(181, 274)
        lblKeterangan.Name = "lblKeterangan"
        lblKeterangan.Size = New Size(311, 25)
        lblKeterangan.TabIndex = 6
        lblKeterangan.Text = "Atur durasi lalu mulai ketika anda siap"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(21, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(227, 38)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Asisten Presensi"
        ' 
        ' lblSubjudul
        ' 
        lblSubjudul.AutoSize = True
        lblSubjudul.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubjudul.Location = New Point(22, 56)
        lblSubjudul.Name = "lblSubjudul"
        lblSubjudul.Size = New Size(489, 32)
        lblSubjudul.TabIndex = 2
        lblSubjudul.Text = "Jaga Durasi tanpa meninggalkan slide anda"
        ' 
        ' lblDurasi
        ' 
        lblDurasi.AutoSize = True
        lblDurasi.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDurasi.Location = New Point(22, 609)
        lblDurasi.Name = "lblDurasi"
        lblDurasi.Size = New Size(212, 32)
        lblDurasi.TabIndex = 4
        lblDurasi.Text = "Durasi Presentasi"
        ' 
        ' chkTeratas
        ' 
        chkTeratas.AutoSize = True
        chkTeratas.Location = New Point(50, 526)
        chkTeratas.Name = "chkTeratas"
        chkTeratas.Size = New Size(226, 29)
        chkTeratas.TabIndex = 7
        chkTeratas.Text = "tetap diatas aplikasi lain"
        chkTeratas.UseVisualStyleBackColor = True
        ' 
        ' btnUlangi
        ' 
        btnUlangi.Location = New Point(502, 465)
        btnUlangi.Name = "btnUlangi"
        btnUlangi.Size = New Size(195, 46)
        btnUlangi.TabIndex = 8
        btnUlangi.Text = "Ulangi"
        btnUlangi.UseVisualStyleBackColor = True
        ' 
        ' btnMulai
        ' 
        btnMulai.BackColor = SystemColors.MenuHighlight
        btnMulai.ForeColor = SystemColors.ControlLightLight
        btnMulai.Location = New Point(21, 465)
        btnMulai.Name = "btnMulai"
        btnMulai.Size = New Size(458, 46)
        btnMulai.TabIndex = 9
        btnMulai.Text = "Mulai"
        btnMulai.UseVisualStyleBackColor = False
        ' 
        ' btnRingkas
        ' 
        btnRingkas.Location = New Point(502, 537)
        btnRingkas.Name = "btnRingkas"
        btnRingkas.Size = New Size(195, 39)
        btnRingkas.TabIndex = 10
        btnRingkas.Text = "Mode ringkas"
        btnRingkas.UseVisualStyleBackColor = True
        ' 
        ' chkBunyi
        ' 
        chkBunyi.AutoSize = True
        chkBunyi.Location = New Point(454, 658)
        chkBunyi.Name = "chkBunyi"
        chkBunyi.Size = New Size(174, 29)
        chkBunyi.TabIndex = 11
        chkBunyi.Text = "Bunyi saat selesai"
        chkBunyi.UseVisualStyleBackColor = True
        ' 
        ' nudMenit
        ' 
        nudMenit.Location = New Point(108, 656)
        nudMenit.Name = "nudMenit"
        nudMenit.Size = New Size(108, 31)
        nudMenit.TabIndex = 12
        ' 
        ' nudDetik
        ' 
        nudDetik.Location = New Point(307, 656)
        nudDetik.Name = "nudDetik"
        nudDetik.Size = New Size(124, 31)
        nudDetik.TabIndex = 13
        ' 
        ' lblMenit
        ' 
        lblMenit.AutoSize = True
        lblMenit.Location = New Point(33, 657)
        lblMenit.Name = "lblMenit"
        lblMenit.Size = New Size(57, 25)
        lblMenit.TabIndex = 14
        lblMenit.Text = "Menit"
        ' 
        ' lblDetik
        ' 
        lblDetik.AutoSize = True
        lblDetik.Location = New Point(248, 657)
        lblDetik.Name = "lblDetik"
        lblDetik.Size = New Size(53, 25)
        lblDetik.TabIndex = 15
        lblDetik.Text = "Detik"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 707)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 25)
        Label1.TabIndex = 16
        Label1.Text = "ctrl+alt+f5 mulai/jeda"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 750)
        Label2.Name = "Label2"
        Label2.Size = New Size(434, 25)
        Label2.TabIndex = 17
        Label2.Text = "ctrl + alt + f10 Ulangi.Tombol tetap dapat digunakan "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 793)
        Label3.Name = "Label3"
        Label3.Size = New Size(528, 25)
        Label3.TabIndex = 18
        Label3.Text = "Timer siap aktifkan tetap diatas agar terlihat saat berganti aplikasi"
        ' 
        ' FrmDemoApi
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(735, 844)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblDetik)
        Controls.Add(lblMenit)
        Controls.Add(nudDetik)
        Controls.Add(nudMenit)
        Controls.Add(chkBunyi)
        Controls.Add(btnRingkas)
        Controls.Add(btnMulai)
        Controls.Add(btnUlangi)
        Controls.Add(chkTeratas)
        Controls.Add(lblDurasi)
        Controls.Add(lblSubjudul)
        Controls.Add(lblJudul)
        Controls.Add(pnlTimer)
        Name = "FrmDemoApi"
        Text = "Asisten Presentasi | Pertemuan 11"
        pnlTimer.ResumeLayout(False)
        pnlTimer.PerformLayout()
        CType(nudMenit, ComponentModel.ISupportInitialize).EndInit()
        CType(nudDetik, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlTimer As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblSubjudul As Label
    Friend WithEvents lblSisa As Label
    Friend WithEvents lblDurasi As Label
    Friend WithEvents lblTahap As Label
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents chkTeratas As CheckBox
    Friend WithEvents btnUlangi As Button
    Friend WithEvents btnMulai As Button
    Friend WithEvents btnRingkas As Button
    Friend WithEvents chkBunyi As CheckBox
    Friend WithEvents nudMenit As NumericUpDown
    Friend WithEvents nudDetik As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMenit As Label
    Friend WithEvents lblDetik As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
