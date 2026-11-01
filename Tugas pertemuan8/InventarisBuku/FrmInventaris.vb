Option Strict On

Public Class FrmInventaris
    ' Tabel inventaris buku yang disimpan di memori (tanpa database)
    Private tabelBuku As DataTable

    ' ==================== DATA AWAL ====================

    ' Membuat DataTable tabelBuku lengkap dengan kolom dan 10 buku awal.
    Private Function BuatTabelBuku() As DataTable
        Dim tabel As New DataTable("Buku")
        ' Kolom: nama dan tipe data
        tabel.Columns.Add("KodeBuku", GetType(String))
        tabel.Columns.Add("Judul", GetType(String))
        tabel.Columns.Add("Penulis", GetType(String))
        tabel.Columns.Add("Kategori", GetType(String))
        tabel.Columns.Add("Tahun", GetType(Integer))
        tabel.Columns.Add("Stok", GetType(Integer))
        ' Baris: urutan nilai mengikuti urutan kolom
        tabel.Rows.Add("BK0001", "Laskar Pelangi", "Andrea Hirata", "Fiksi", 2005, 8)
        tabel.Rows.Add("BK0002", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", 1980, 0)
        tabel.Rows.Add("BK0003", "Atomic Habits", "James Clear", "Nonfiksi", 2018, 5)
        tabel.Rows.Add("BK0004", "Sapiens", "Yuval Noah Harari", "Nonfiksi", 2011, 3)
        tabel.Rows.Add("BK0005", "Filosofi Teras", "Henry Manampiring", "Nonfiksi", 2018, 6)
        tabel.Rows.Add("BK0006", "Kamus Besar Bahasa Indonesia", "Tim Penyusun", "Referensi", 2016, 2)
        tabel.Rows.Add("BK0007", "Ensiklopedia Sains", "Tim Redaksi", "Referensi", 2012, 0)
        tabel.Rows.Add("BK0008", "Atlas Dunia", "Tim Kartografi", "Referensi", 2020, 4)
        tabel.Rows.Add("BK0009", "National Geographic Indonesia", "Redaksi NatGeo", "Majalah", 2024, 7)
        tabel.Rows.Add("BK0010", "Tempo Edisi Khusus", "Redaksi Tempo", "Majalah", 2023, 0)
        Return tabel
    End Function

    ' Mengisi grid lewat BindingSource, merapikan kolom, lalu mengatur nilai awal pilihan.
    Private Sub FrmInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabelBuku = BuatTabelBuku()
        bsBuku.DataSource = tabelBuku                   ' DataTable -> BindingSource
        dgvBuku.DataSource = bsBuku                     ' BindingSource -> DataGridView
        AturKolom()
        cboKategori.SelectedIndex = -1                  ' kategori buku baru belum dipilih
        cboFilterKategori.SelectedIndex = 0             ' Semua
        cboUrut.SelectedIndex = 0                       ' Urutan awal
        PerbaruiRingkasan()
    End Sub

    ' Merapikan kolom. Dipanggil setelah DataSource diisi karena kolom dibuat otomatis.
    Private Sub AturKolom()
        dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"
        dgvBuku.Columns("Judul").FillWeight = 200
        dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.Columns("Stok").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' ==================== TAMBAH BUKU ====================

    ' Menambah buku baru ke tabelBuku jika semua isian valid.
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Return

        Dim kode As String = txtKodeBuku.Text
        ' Nilai sudah lolos validasi, jadi Integer.Parse aman dipakai
        tabelBuku.Rows.Add(kode, txtJudul.Text.Trim(), txtPenulis.Text.Trim(), cboKategori.Text,
                           Integer.Parse(txtTahun.Text.Trim()), Integer.Parse(txtStok.Text.Trim()))

        ' Grid terhubung lewat BindingSource, jadi baris baru langsung tampil
        PerbaruiRingkasan()
        PilihBaris(kode)
        BersihkanInput()
    End Sub

    ' Mengosongkan semua isian dan penanda kesalahan.
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanInput()
    End Sub

    ' Memeriksa semua isian dan menampilkan kesalahan lewat errBuku.
    ' Mengembalikan True jika semuanya valid.
    Private Function ValidasiInput() As Boolean
        errBuku.Clear()
        Dim valid As Boolean = True
        Dim tahun As Integer
        Dim stok As Integer

        ' Kode buku: "BK" + 4 digit, dan belum dipakai buku lain
        If Not FormatKodeBenar(txtKodeBuku.Text) Then
            errBuku.SetError(txtKodeBuku, "Kode buku harus berformat BK + 4 digit, contoh BK0012.")
            valid = False
        ElseIf KodeSudahAda(txtKodeBuku.Text) Then
            errBuku.SetError(txtKodeBuku, "Kode buku sudah terdaftar.")
            valid = False
        End If

        ' Judul dan penulis wajib diisi
        If Kosong(txtJudul.Text) Then
            errBuku.SetError(txtJudul, "Judul wajib diisi.")
            valid = False
        End If
        If Kosong(txtPenulis.Text) Then
            errBuku.SetError(txtPenulis, "Penulis wajib diisi.")
            valid = False
        End If

        ' Kategori wajib dipilih
        If cboKategori.SelectedIndex = -1 Then
            errBuku.SetError(cboKategori, "Pilih kategori terlebih dahulu.")
            valid = False
        End If

        ' Tahun: bilangan bulat 1900 sampai tahun ini
        If Not Integer.TryParse(txtTahun.Text.Trim(), tahun) OrElse
            tahun < 1900 OrElse tahun > Date.Today.Year Then
            errBuku.SetError(txtTahun, "Tahun harus bilangan bulat antara 1900 dan " &
                             Date.Today.Year.ToString() & ".")
            valid = False
        End If

        ' Stok: bilangan bulat 0 atau lebih
        If Not Integer.TryParse(txtStok.Text.Trim(), stok) OrElse stok < 0 Then
            errBuku.SetError(txtStok, "Stok harus bilangan bulat 0 atau lebih.")
            valid = False
        End If

        Return valid
    End Function

    ' True jika kode terdiri dari "BK" diikuti tepat 4 digit.
    Private Function FormatKodeBenar(kode As String) As Boolean
        Return kode.Length = 6 AndAlso kode.StartsWith("BK") AndAlso SemuaDigit(kode.Substring(2), 4)
    End Function

    ' True jika kode sudah ada di tabelBuku (diperiksa dengan perulangan pada Rows).
    Private Function KodeSudahAda(kode As String) As Boolean
        For Each baris As DataRow In tabelBuku.Rows
            If baris("KodeBuku").ToString() = kode Then
                Return True
            End If
        Next
        Return False
    End Function

    ' Mengosongkan isian, menghapus penanda kesalahan, lalu fokus ke kode buku.
    Private Sub BersihkanInput()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        cboKategori.SelectedIndex = -1
        txtTahun.Clear()
        txtStok.Clear()
        errBuku.Clear()
        txtKodeBuku.Focus()
    End Sub

    ' Memilih baris buku berkode tertentu di grid (jika sedang tampil).
    Private Sub PilihBaris(kode As String)
        For Each baris As DataGridViewRow In dgvBuku.Rows
            If baris.Cells("KodeBuku").Value.ToString() = kode Then
                dgvBuku.CurrentCell = baris.Cells("KodeBuku")
                Exit For
            End If
        Next
    End Sub

    ' ==================== PENCARIAN, FILTER, URUTAN ====================

    ' Pencarian berjalan saat mengetik.
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TerapkanFilter()
    End Sub

    ' Mengubah filter kategori.
    Private Sub cboFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterKategori.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    ' Mengaktifkan atau mematikan syarat stok habis.
    Private Sub chkStokHabis_CheckedChanged(sender As Object, e As EventArgs) Handles chkStokHabis.CheckedChanged
        TerapkanFilter()
    End Sub

    ' Mengubah urutan tampilan buku.
    Private Sub cboUrut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUrut.SelectedIndexChanged
        TerapkanUrutan()
    End Sub

    ' Menyusun syarat teks, kategori, dan stok habis dalam satu ekspresi Filter.
    ' Mengembalikan teks kosong jika tidak ada syarat yang aktif.
    Private Function BuatFilter() As String
        Dim ekspresi As String = ""

        ' Syarat 1: kata pencarian pada judul atau penulis
        Dim kata As String = AmankanTeksFilter(txtCari.Text.Trim())
        If kata <> "" Then
            ekspresi = "(Judul LIKE '%" & kata & "%' OR Penulis LIKE '%" & kata & "%')"
        End If

        ' Syarat 2: kategori (indeks 0 = Semua, tidak ada syarat)
        If cboFilterKategori.SelectedIndex > 0 Then
            If ekspresi <> "" Then ekspresi &= " AND "
            ekspresi &= "Kategori = '" & AmankanTeksFilter(cboFilterKategori.Text) & "'"
        End If

        ' Syarat 3: hanya buku dengan stok habis
        If chkStokHabis.Checked Then
            If ekspresi <> "" Then ekspresi &= " AND "
            ekspresi &= "Stok = 0"
        End If

        Return ekspresi
    End Function

    ' Memasang filter gabungan ke bsBuku lalu memperbarui ringkasan.
    Private Sub TerapkanFilter()
        Dim ekspresi As String = BuatFilter()
        If ekspresi = "" Then
            bsBuku.RemoveFilter()                       ' tampilkan semua buku
        Else
            bsBuku.Filter = ekspresi
        End If
        PerbaruiRingkasan()
    End Sub

    ' Mengatur bsBuku.Sort sesuai pilihan cboUrut.
    Private Sub TerapkanUrutan()
        Select Case cboUrut.SelectedIndex
            Case 1
                bsBuku.Sort = "Judul ASC"
            Case 2
                bsBuku.Sort = "Tahun DESC"
            Case 3
                bsBuku.Sort = "Stok DESC"
            Case Else
                bsBuku.RemoveSort()                     ' urutan awal
        End Select
    End Sub

    ' ==================== RINGKASAN ====================

    ' Memperbarui lblJumlah dan lblTotalStok dari baris yang sedang tampil di grid.
    Private Sub PerbaruiRingkasan()
        Dim totalStok As Integer = 0
        For Each baris As DataGridViewRow In dgvBuku.Rows
            totalStok += CInt(baris.Cells("Stok").Value)
        Next
        lblJumlah.Text = "Menampilkan " & dgvBuku.Rows.Count.ToString() & " dari " &
                         tabelBuku.Rows.Count.ToString() & " buku"
        lblTotalStok.Text = "Total stok yang tampil: " & totalStok.ToString()
    End Sub

End Class
