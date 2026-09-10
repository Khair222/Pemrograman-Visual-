Public Class FrmLogin
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.Text = "Manager" Then
            picImage.Image = Image.FromFile("Assets\maneger.jpg")
        ElseIf cmbRole.Text = "Staff" Then
            picImage.Image = Image.FromFile("Assets\staff.jpg")
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim role As String = cmbRole.Text
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNim.Text.Trim()

        If role = "Staff" And nama.ToLower() = "pepol" And nim = "24434" Then
            MessageBox.Show("Login berhasil")
            txtNama.Clear()
            txtNim.Clear()
            Me.Hide()
            FrmPajak.Show()

        ElseIf role = "Manager" And nama.ToLower() = "khair" And nim = "241712073" Then
            MessageBox.Show("Login berhasil")
            txtNama.Clear()
            txtNim.Clear()
            Me.Hide()
            FrmPajak.Show()

        Else
            MessageBox.Show("Wok masukkan Nama dan NIM dengan Benar cuy",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            txtNim.Focus()
        End If
    End Sub

    Private Sub lblNim_Click(sender As Object, e As EventArgs) Handles lblNim.Click

    End Sub
End Class
