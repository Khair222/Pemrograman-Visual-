Option Strict On

' Module untuk menyimpan fungsi validasi agar rapi dan bisa dipakai ulang
Public Module ModulValidasi

    ' Memeriksa apakah sebuah teks memiliki panjang tertentu dan semuanya adalah digit angka
    Public Function SemuaDigit(teks As String, panjang As Integer) As Boolean
        If teks.Length <> panjang Then Return False
        For Each karakter As Char In teks
            If Not Char.IsDigit(karakter) Then Return False
        Next
        Return True
    End Function

    ' Tantangan Tambahan: Fungsi untuk memeriksa format kode buku (BK + 4 digit angka)
    Public Function KodeBukuValid(kode As String) As Boolean
        If String.IsNullOrWhiteSpace(kode) Then Return False

        kode = kode.ToUpper()
        If kode.Length = 6 AndAlso kode.StartsWith("BK") Then
            ' Memeriksa 4 karakter terakhir menggunakan fungsi SemuaDigit
            Return SemuaDigit(kode.Substring(2), 4)
        End If
        Return False
    End Function

End Module