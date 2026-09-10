<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        cmbRole = New ComboBox()
        lblRole = New Label()
        lblNama = New Label()
        lblNim = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        btnLogin = New Button()
        picImage = New PictureBox()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cmbRole.Location = New Point(280, 190)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(182, 33)
        cmbRole.TabIndex = 1
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(217, 193)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(43, 24)
        lblRole.TabIndex = 2
        lblRole.Text = "Role"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(217, 243)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(55, 24)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Font = New Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNim.Location = New Point(220, 287)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(40, 24)
        lblNim.TabIndex = 4
        lblNim.Text = "Nim"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(280, 243)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(182, 31)
        txtNama.TabIndex = 5
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(280, 287)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(182, 31)
        txtNim.TabIndex = 6
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(314, 344)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(295, 39)
        picImage.Name = "picImage"
        picImage.Size = New Size(150, 127)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 8
        picImage.TabStop = False
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(picImage)
        Controls.Add(btnLogin)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Controls.Add(lblRole)
        Controls.Add(cmbRole)
        Name = "FrmLogin"
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents picImage As PictureBox

End Class
