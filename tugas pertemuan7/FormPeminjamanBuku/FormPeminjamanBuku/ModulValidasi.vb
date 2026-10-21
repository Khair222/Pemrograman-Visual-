Option Strict On


Public Module ModulValidasi


    Public Function SemuaDigit(teks As String, panjang As Integer) As Boolean
        If teks.Length <> panjang Then Return False
        For Each karakter As Char In teks
            If Not Char.IsDigit(karakter) Then Return False
        Next
        Return True
    End Function


    Public Function KodeBukuValid(kode As String) As Boolean
        If String.IsNullOrWhiteSpace(kode) Then Return False

        kode = kode.ToUpper()
        If kode.Length = 6 AndAlso kode.StartsWith("BK") Then

            Return SemuaDigit(kode.Substring(2), 4)
        End If
        Return False
    End Function

End Module