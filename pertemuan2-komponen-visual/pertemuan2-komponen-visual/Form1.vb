Public Class Form1
    Private Sub TextNama_TextChanged(sender As Object, e As EventArgs) Handles TxtNama.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblNim.Click

    End Sub

    Private Sub BtnTampilkan_Click(sender As Object, e As EventArgs) Handles BtnTampilkan.Click
        MessageBox.Show("Hallo Selamat datang!" & vbCrLf &
                        "Nama : " & TxtNama.Text & vbCrLf &
                        "NIM : " & TxtNIM.Text & vbCrLf &
                        "KOM : " & TxtKOM.Text
        )
    End Sub

    Private Sub ProfilMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        TxtNama.Clear()
        TxtNIM.Clear()
        TxtKOM.Clear()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub LabelNama_Click(sender As Object, e As EventArgs) Handles LblNama.Click

    End Sub

    Private Sub LblKOM_Click(sender As Object, e As EventArgs) Handles LblKom.Click

    End Sub
End Class
