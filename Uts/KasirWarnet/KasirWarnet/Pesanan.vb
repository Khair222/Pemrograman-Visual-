Public Class Pesanan
    Public Property Paket As String
    Public Property Jam As Integer
    Public Property Harga As Decimal
    Public Property Diskon As Decimal
    Public Property Subtotal As Decimal

    Public Sub New(paket As String, jam As Integer, harga As Decimal, diskon As Decimal, subtotal As Decimal)
        Me.Paket = paket
        Me.Jam = jam
        Me.Harga = harga
        Me.Diskon = diskon
        Me.Subtotal = subtotal
    End Sub
End Class