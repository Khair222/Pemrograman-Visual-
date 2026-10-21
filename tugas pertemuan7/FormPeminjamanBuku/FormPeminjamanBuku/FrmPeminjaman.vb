Option Strict On

Imports System.IO
Imports System.ComponentModel

Public Class FrmPeminjaman

    Private ReadOnly bukuDipinjam As New List(Of String)


    Private ReadOnly lokasiEkspor As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "peminjaman.csv")


    Private Function ValidasiInput() As Boolean
        errPinjam.Clear()
        Dim valid As Boolean = True


        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        If Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, "Kode buku harus diawali 'BK' diikuti 4 digit angka (contoh: BK0012).")
            valid = False
        ElseIf bukuDipinjam.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
            valid = False
        End If


        If String.IsNullOrWhiteSpace(txtJudul.Text) Then
            errPinjam.SetError(txtJudul, "Judul buku wajib diisi.")
            valid = False
        End If


        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori, "Pilih salah satu kategori.")
            valid = False
        End If


        If txtNamaPeminjam.Text.Trim().Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama peminjam minimal 3 karakter.")
            valid = False
        End If


        Dim lama As Integer
        If Not Integer.TryParse(txtLamaPinjam.Text, lama) OrElse lama < 1 OrElse lama > 14 Then
            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus angka 1 sampai 14.")
            valid = False
        End If

        Return valid
    End Function


    Private Sub txtKodeBuku_Validating(sender As Object, e As CancelEventArgs) Handles txtKodeBuku.Validating
        If String.IsNullOrWhiteSpace(txtKodeBuku.Text) Then Return

        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        If KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, "")
        Else
            errPinjam.SetError(txtKodeBuku, "Format salah. Harus diawali 'BK' diikuti 4 digit angka.")
        End If
    End Sub


    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If Not ValidasiInput() Then
            Return
        End If


        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        Dim judul As String = txtJudul.Text.Trim()
        Dim kategori As String = cboKategori.Text
        Dim peminjam As String = txtNamaPeminjam.Text.Trim()
        Dim lama As Integer = Integer.Parse(txtLamaPinjam.Text)


        Dim tglKembali As String = Date.Today.AddDays(lama).ToString("dd/MM/yyyy")


        Dim baris As String = $"{kode} | {judul} | {kategori} | {peminjam} | {lama} hari | kembali {tglKembali}"


        lstPeminjaman.Items.Add(baris)
        bukuDipinjam.Add(kode)


        lblStatus.Text = "Jumlah peminjaman: " & lstPeminjaman.Items.Count.ToString()
        BersihkanForm()
    End Sub


    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub


    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()
        errPinjam.Clear()
        txtKodeBuku.Focus()
    End Sub


    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Daftar peminjaman masih kosong. Tidak ada data yang bisa diekspor.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim penulis As StreamWriter = Nothing
        Try
            penulis = New StreamWriter(lokasiEkspor)


            penulis.WriteLine("Kode Buku;Judul;Kategori;Nama Peminjam;Lama Pinjam;Tanggal Kembali")


            For Each item As Object In lstPeminjaman.Items
                Dim barisCsv As String = item.ToString().Replace(" | ", ";")
                penulis.WriteLine(barisCsv)
            Next

            MessageBox.Show("Data berhasil diekspor ke " & lokasiEkspor, "Ekspor Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As IOException
            MessageBox.Show("File tidak bisa ditulis karena sedang dibuka oleh program lain (misalnya Excel)." & vbCrLf & "Silakan tutup file tersebut lalu coba lagi.", "Ekspor Gagal (IOException)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Tidak ada izin untuk menulis file di lokasi Documents." & vbCrLf & "Pastikan Anda memiliki hak akses (Administrator) ke folder tersebut.", "Ekspor Gagal (Unauthorized Access)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If penulis IsNot Nothing Then
                penulis.Close()
            End If
        End Try
    End Sub
End Class