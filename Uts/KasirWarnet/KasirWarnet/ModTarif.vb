Option Strict On

Public Module ModTarif

    Public DaftarPaket() As String = {"Internet Biasa", "Paket Game", "Paket VIP", "Paket Malam"}


    Public Function HargaPerJam(paket As String) As Decimal
        Select Case paket
            Case "Internet Biasa"
                Return 4000D
            Case "Paket Game"
                Return 5000D
            Case "Paket VIP"
                Return 8000D
            Case "Paket Malam"
                Return 3000D
            Case Else
                Return 0D
        End Select
    End Function
End Module