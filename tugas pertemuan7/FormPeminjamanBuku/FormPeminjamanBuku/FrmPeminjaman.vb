Option Strict On

Imports System.IO
Imports System.ComponentModel

Public Class FrmPeminjaman
    ' Menyimpan daftar kode buku yang sedang dipinjam untuk mencegah duplikasi
    Private ReadOnly bukuDipinjam As New List(Of String)

    ' Lokasi file ekspor CSV di folder Documents pengguna
    Private ReadOnly lokasiEkspor As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "peminjaman.csv")

    ' Memeriksa semua isian secara terpusat dan mengembalikan True jika semuanya valid
    Private Function ValidasiInput() As Boolean
        errPinjam.Clear()
        Dim valid As Boolean = True

        ' 1. Validasi Kode Buku
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        If Not ModulValidasi.KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, "Kode buku harus diawali 'BK' diikuti 4 digit angka (contoh: BK0012).")
            valid = False
        ElseIf bukuDipinjam.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
            valid = False
        End If

        ' 2. Validasi Judul Buku
        If String.IsNullOrWhiteSpace(txtJudul.Text) Then
            errPinjam.SetError(txtJudul, "Judul buku wajib diisi.")
            valid = False
        End If

        ' 3. Validasi Kategori
        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori, "Pilih salah satu kategori.")
            valid = False
        End If

        ' 4. Validasi Nama Peminjam (minimal 3 karakter tanpa spasi awal/akhir)
        If txtNamaPeminjam.Text.Trim().Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama peminjam minimal 3 karakter.")
            valid = False
        End If

        ' 5. Validasi Lama Pinjam (bilangan bulat 1 - 14)
        Dim lama As Integer
        If Not Integer.TryParse(txtLamaPinjam.Text, lama) OrElse lama < 1 OrElse lama > 14 Then
            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus angka 1 sampai 14.")
            valid = False
        End If

        Return valid
    End Function

    ' Tantangan Tambahan: Validasi saat fokus berpindah dari kotak teks kode buku
    Private Sub txtKodeBuku_Validating(sender As Object, e As CancelEventArgs) Handles txtKodeBuku.Validating
        If String.IsNullOrWhiteSpace(txtKodeBuku.Text) Then Return ' Kosong dicek nanti saat tombol Pinjam diklik

        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        If ModulValidasi.KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, "")
        Else
            errPinjam.SetError(txtKodeBuku, "Format salah. Harus diawali 'BK' diikuti 4 digit angka.")
        End If
    End Sub

    ' Mengeksekusi pencatatan data peminjaman jika validasi lolos
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If Not ValidasiInput() Then
            Return
        End If

        ' Mengambil data dari kontrol form
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        Dim judul As String = txtJudul.Text.Trim()
        Dim kategori As String = cboKategori.Text
        Dim peminjam As String = txtNamaPeminjam.Text.Trim()
        Dim lama As Integer = Integer.Parse(txtLamaPinjam.Text)

        ' Menghitung tanggal kembali
        Dim tglKembali As String = Date.Today.AddDays(lama).ToString("dd/MM/yyyy")

        ' Menggabungkan data menjadi satu baris teks
        Dim baris As String = $"{kode} | {judul} | {kategori} | {peminjam} | {lama} hari | kembali {tglKembali}"

        ' Memasukkan data ke ListBox dan List internal
        lstPeminjaman.Items.Add(baris)
        bukuDipinjam.Add(kode)

        ' Memperbarui label status dan mengosongkan form
        lblStatus.Text = "Jumlah peminjaman: " & lstPeminjaman.Items.Count.ToString()
        BersihkanForm()
    End Sub

    ' Mengosongkan form ketika tombol Bersihkan diklik
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub

    ' Subrutin untuk mereset seluruh kontrol input ke kondisi kosong
    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()
        errPinjam.Clear()
        txtKodeBuku.Focus()
    End Sub

    ' Menyimpan isi daftar peminjaman ke dalam file CSV di folder Documents
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Daftar peminjaman masih kosong. Tidak ada data yang bisa diekspor.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim penulis As StreamWriter = Nothing
        Try
            penulis = New StreamWriter(lokasiEkspor)

            ' Menulis baris pertama (judul kolom)
            penulis.WriteLine("Kode Buku;Judul;Kategori;Nama Peminjam;Lama Pinjam;Tanggal Kembali")

            ' Menulis setiap data peminjaman, mengganti pembatas "|" dengan ";"
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
                penulis.Close() ' Pastikan file selalu ditutup
            End If
        End Try
    End Sub

    Private Sub FrmPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class