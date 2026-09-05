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
        LabelNama = New Label()
        TxtNama = New TextBox()
        LabelNIM = New Label()
        TxtNIM = New TextBox()
        LabelKOM = New Label()
        TxtKOM = New TextBox()
        BtnTampilkan = New Button()
        BtnHapus = New Button()
        BtnKeluar = New Button()
        SuspendLayout()
        ' 
        ' LabelNama
        ' 
        LabelNama.AutoSize = True
        LabelNama.Location = New Point(51, 45)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(68, 25)
        LabelNama.TabIndex = 0
        LabelNama.Text = "Nama :"
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(129, 39)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(150, 31)
        TxtNama.TabIndex = 1
        ' 
        ' LabelNIM
        ' 
        LabelNIM.AutoSize = True
        LabelNIM.Location = New Point(51, 86)
        LabelNIM.Name = "LabelNIM"
        LabelNIM.Size = New Size(55, 25)
        LabelNIM.TabIndex = 2
        LabelNIM.Text = "NIM :"
        ' 
        ' TxtNIM
        ' 
        TxtNIM.Location = New Point(129, 79)
        TxtNIM.Name = "TxtNIM"
        TxtNIM.Size = New Size(150, 31)
        TxtNIM.TabIndex = 3
        ' 
        ' LabelKOM
        ' 
        LabelKOM.AutoSize = True
        LabelKOM.Location = New Point(50, 124)
        LabelKOM.Name = "LabelKOM"
        LabelKOM.Size = New Size(60, 25)
        LabelKOM.TabIndex = 4
        LabelKOM.Text = "KOM :"
        ' 
        ' TxtKOM
        ' 
        TxtKOM.Location = New Point(128, 117)
        TxtKOM.Name = "TxtKOM"
        TxtKOM.Size = New Size(150, 31)
        TxtKOM.TabIndex = 5
        ' 
        ' BtnTampilkan
        ' 
        BtnTampilkan.Location = New Point(128, 185)
        BtnTampilkan.Name = "BtnTampilkan"
        BtnTampilkan.Size = New Size(112, 34)
        BtnTampilkan.TabIndex = 6
        BtnTampilkan.Text = "Tampilkan"
        BtnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Location = New Point(260, 185)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(112, 34)
        BtnHapus.TabIndex = 7
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(129, 249)
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
        Controls.Add(LabelKOM)
        Controls.Add(TxtNIM)
        Controls.Add(LabelNIM)
        Controls.Add(TxtNama)
        Controls.Add(LabelNama)
        Name = "Form1"
        Text = "Profil Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelNama As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents LabelNIM As Label
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents LabelKOM As Label
    Friend WithEvents TxtKOM As TextBox
    Friend WithEvents BtnTampilkan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnKeluar As Button

End Class
