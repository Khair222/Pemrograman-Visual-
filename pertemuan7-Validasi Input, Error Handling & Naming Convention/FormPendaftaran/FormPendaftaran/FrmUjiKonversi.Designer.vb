<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUjiKonversi
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
        lblJudul = New Label()
        lblPetunjuk = New Label()
        lblInput = New Label()
        btnCInt = New Button()
        btnVal = New Button()
        btnTryParse = New Button()
        btnTryCatch = New Button()
        btnCatchBertingkat = New Button()
        txtInput = New TextBox()
        lblHasil = New Label()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(12, 21)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(253, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Uji Konversi Input"
        ' 
        ' lblPetunjuk
        ' 
        lblPetunjuk.Location = New Point(12, 59)
        lblPetunjuk.Name = "lblPetunjuk"
        lblPetunjuk.Size = New Size(448, 58)
        lblPetunjuk.TabIndex = 1
        lblPetunjuk.Text = "Ketik sebuah nilai lalu coba setiap tombol. " & vbCrLf & "Coba: 25, abc, 12abc, 3,5, 99999999999, atau kosong."
        ' 
        ' lblInput
        ' 
        lblInput.AutoSize = True
        lblInput.Location = New Point(12, 126)
        lblInput.Name = "lblInput"
        lblInput.Size = New Size(58, 25)
        lblInput.TabIndex = 2
        lblInput.Text = "Input:"
        ' 
        ' btnCInt
        ' 
        btnCInt.Location = New Point(17, 163)
        btnCInt.Name = "btnCInt"
        btnCInt.Size = New Size(150, 53)
        btnCInt.TabIndex = 3
        btnCInt.Text = "CInt (tanpa Try)"
        btnCInt.UseVisualStyleBackColor = True
        ' 
        ' btnVal
        ' 
        btnVal.Location = New Point(191, 163)
        btnVal.Name = "btnVal"
        btnVal.Size = New Size(112, 53)
        btnVal.TabIndex = 4
        btnVal.Text = "Val"
        btnVal.UseVisualStyleBackColor = True
        ' 
        ' btnTryParse
        ' 
        btnTryParse.Location = New Point(332, 163)
        btnTryParse.Name = "btnTryParse"
        btnTryParse.Size = New Size(112, 53)
        btnTryParse.TabIndex = 5
        btnTryParse.Text = "TryParse"
        btnTryParse.UseVisualStyleBackColor = True
        ' 
        ' btnTryCatch
        ' 
        btnTryCatch.Location = New Point(463, 166)
        btnTryCatch.Name = "btnTryCatch"
        btnTryCatch.Size = New Size(161, 50)
        btnTryCatch.TabIndex = 6
        btnTryCatch.Text = "Try...Catch"
        btnTryCatch.UseVisualStyleBackColor = True
        ' 
        ' btnCatchBertingkat
        ' 
        btnCatchBertingkat.Location = New Point(656, 163)
        btnCatchBertingkat.Name = "btnCatchBertingkat"
        btnCatchBertingkat.Size = New Size(112, 53)
        btnCatchBertingkat.TabIndex = 7
        btnCatchBertingkat.Text = "Catch Bertingkat"
        btnCatchBertingkat.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(76, 126)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(692, 31)
        txtInput.TabIndex = 8
        ' 
        ' lblHasil
        ' 
        lblHasil.BorderStyle = BorderStyle.FixedSingle
        lblHasil.Location = New Point(17, 252)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(751, 169)
        lblHasil.TabIndex = 9
        lblHasil.Text = "Hasil akan tampil di sini."
        ' 
        ' FrmUjiKonversi
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblHasil)
        Controls.Add(txtInput)
        Controls.Add(btnCatchBertingkat)
        Controls.Add(btnTryCatch)
        Controls.Add(btnTryParse)
        Controls.Add(btnVal)
        Controls.Add(btnCInt)
        Controls.Add(lblInput)
        Controls.Add(lblPetunjuk)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmUjiKonversi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmUjiKonversi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblPetunjuk As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents btnCInt As Button
    Friend WithEvents btnVal As Button
    Friend WithEvents btnTryParse As Button
    Friend WithEvents btnTryCatch As Button
    Friend WithEvents btnCatchBertingkat As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblHasil As Label
End Class
