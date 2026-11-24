Option Strict On

Public Class FrmWarnet

    Private listSesi As New List(Of Pesanan)

    Private Sub FrmWarnet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLayanan.Items.Clear()
        For Each paket In ModTarif.DaftarPaket
            cboLayanan.Items.Add(paket)
        Next

        bsPesanan.DataSource = listSesi
        dgvPesanan.DataSource = bsPesanan

        dgvPesanan.Columns("Harga").HeaderText = "Harga Satuan"

        dgvPesanan.Columns("Harga").DefaultCellStyle.Format = "N0"
        dgvPesanan.Columns("Harga").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvPesanan.Columns("Diskon").DefaultCellStyle.Format = "N0"
        dgvPesanan.Columns("Diskon").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvPesanan.Columns("Subtotal").DefaultCellStyle.Format = "N0"
        dgvPesanan.Columns("Subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvPesanan.ReadOnly = True
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            errInput.Clear()

            Dim adaError As Boolean = False
            Dim paketPilihan As String = ""
            Dim jamInput As Integer = 0

            If cboLayanan.SelectedIndex = -1 Then
                errInput.SetError(cboLayanan, "Silakan pilih paket terlebih dahulu!")
                adaError = True
            Else
                paketPilihan = cboLayanan.SelectedItem.ToString()
            End If

            If Not Integer.TryParse(txtJumlah.Text, jamInput) OrElse jamInput < 1 OrElse jamInput > 12 Then
                errInput.SetError(txtJumlah, "Jam harus berupa angka 1 - 12!")
                adaError = True
            End If

            If adaError Then
                Exit Sub
            End If

            Dim sesiAda As Pesanan = Nothing
            For Each s In listSesi
                If s.Paket = paketPilihan Then
                    sesiAda = s
                    Exit For
                End If
            Next

            If sesiAda IsNot Nothing Then
                Dim totalJamGabungan As Integer = sesiAda.Jam + jamInput

                If totalJamGabungan > 12 Then
                    errInput.SetError(txtJumlah, "Total gabungan jam melebihi batas maksimal (12 jam)!")
                    Exit Sub
                End If

                Dim harga As Decimal = ModTarif.HargaPerJam(paketPilihan)
                Dim kotor As Decimal = harga * totalJamGabungan
                Dim diskon As Decimal = 0

                If totalJamGabungan >= 5 Then
                    diskon = CDec(kotor * 0.1D)
                End If

                sesiAda.Jam = totalJamGabungan
                sesiAda.Diskon = diskon
                sesiAda.Subtotal = kotor - diskon
                bsPesanan.ResetBindings(False)
            Else
                Dim harga As Decimal = ModTarif.HargaPerJam(paketPilihan)
                Dim kotor As Decimal = harga * jamInput
                Dim diskon As Decimal = 0

                If jamInput >= 5 Then
                    diskon = CDec(kotor * 0.1D)
                End If

                Dim subtotal As Decimal = kotor - diskon

                Dim sesiBaru As New Pesanan(paketPilihan, jamInput, harga, diskon, subtotal)
                bsPesanan.Add(sesiBaru)
            End If

            Dim totalSemua As Decimal = 0
            For Each s In listSesi
                totalSemua += s.Subtotal
            Next
            lblTotal.Text = "Rp " & totalSemua.ToString("N0").Replace(",", ".")

            cboLayanan.SelectedIndex = -1
            txtJumlah.Clear()
            errInput.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        Dim jawaban As DialogResult = MessageBox.Show(
            "Hapus semua pesanan dan mulai transaksi baru?", "Transaksi Baru",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If jawaban = DialogResult.Yes Then
            listSesi.Clear()
            bsPesanan.ResetBindings(False)
            lblTotal.Text = "Rp 0"
            errInput.Clear()
            cboLayanan.SelectedIndex = -1
            txtJumlah.Clear()
        End If
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged

    End Sub
End Class