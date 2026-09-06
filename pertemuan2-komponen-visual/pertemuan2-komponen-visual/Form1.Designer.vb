<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        LblNama = New Label()
        TxtNama = New TextBox()
        LblNim = New Label()
        TxtNIM = New TextBox()
        LblKom = New Label()
        TxtKOM = New TextBox()
        BtnTampilkan = New Button()
        BtnHapus = New Button()
        BtnKeluar = New Button()
        SuspendLayout()
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.Location = New Point(156, 47)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(68, 25)
        LblNama.TabIndex = 0
        LblNama.Text = "Nama :"
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(234, 41)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(150, 31)
        TxtNama.TabIndex = 1
        ' 
        ' LblNim
        ' 
        LblNim.AutoSize = True
        LblNim.Location = New Point(156, 88)
        LblNim.Name = "LblNim"
        LblNim.Size = New Size(54, 25)
        LblNim.TabIndex = 2
        LblNim.Text = "Nim :"
        ' 
        ' TxtNIM
        ' 
        TxtNIM.Location = New Point(234, 81)
        TxtNIM.Name = "TxtNIM"
        TxtNIM.Size = New Size(150, 31)
        TxtNIM.TabIndex = 3
        ' 
        ' LblKom
        ' 
        LblKom.AutoSize = True
        LblKom.Location = New Point(155, 126)
        LblKom.Name = "LblKom"
        LblKom.Size = New Size(58, 25)
        LblKom.TabIndex = 4
        LblKom.Text = "Kom :"
        ' 
        ' TxtKOM
        ' 
        TxtKOM.Location = New Point(233, 119)
        TxtKOM.Name = "TxtKOM"
        TxtKOM.Size = New Size(150, 31)
        TxtKOM.TabIndex = 5
        ' 
        ' BtnTampilkan
        ' 
        BtnTampilkan.Location = New Point(154, 185)
        BtnTampilkan.Name = "BtnTampilkan"
        BtnTampilkan.Size = New Size(112, 34)
        BtnTampilkan.TabIndex = 6
        BtnTampilkan.Text = "Tampilkan"
        BtnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Location = New Point(287, 185)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(112, 34)
        BtnHapus.TabIndex = 7
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(154, 249)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(112, 34)
        BtnKeluar.TabIndex = 8
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(522, 450)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnHapus)
        Controls.Add(BtnTampilkan)
        Controls.Add(TxtKOM)
        Controls.Add(LblKom)
        Controls.Add(TxtNIM)
        Controls.Add(LblNim)
        Controls.Add(TxtNama)
        Controls.Add(LblNama)
        Name = "Form1"
        Text = "Profil Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblNama As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents LblNim As Label
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents LblKom As Label
    Friend WithEvents TxtKOM As TextBox
    Friend WithEvents BtnTampilkan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnKeluar As Button

End Class
