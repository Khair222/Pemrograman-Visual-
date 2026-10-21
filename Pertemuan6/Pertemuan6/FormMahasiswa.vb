Public Class FormMahasiswa
    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        dgvMahasiswa.AutoGenerateColumns = True
        dgvMahasiswa.DataSource = ModQuery.TampilkanData()
    End Sub

    Private Sub btnTambahkan_Click(sender As Object, e As EventArgs) Handles btnTambahkan.Click
        If ModQuery.TambahData(
        txtNim.Text,
        txtNama.Text,
        txtJurusan.Text
    ) Then
            MessageBox.Show("Data berhasil disimpan")
        End If
        txtJurusan.Clear()
        txtNama.Clear()
        txtNim.Clear()
    End Sub

End Class
