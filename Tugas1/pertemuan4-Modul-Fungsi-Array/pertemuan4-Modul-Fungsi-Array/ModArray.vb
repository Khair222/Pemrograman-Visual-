Module ModArray
    Public Sub TampilkanPesan(nama As String)
        MessageBox.Show("hallo " & nama)
    End Sub


    Function Hitung(panjang As Integer, lebar As Integer) As Integer
        If panjang > 50 Then
            Return panjang * lebar
        Else
            Return 2 * panjang + 2 * lebar
        End If
    End Function

    Public nilai() As Integer = {50, 60, 70, 80, 90, 100}
    Public nilai2D(,) As Integer = {
        {55, 50, 60},
        {65, 67, 69},
        {78, 85, 99}
        }
End Module
