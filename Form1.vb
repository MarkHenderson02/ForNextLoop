Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        Dim pesan As String
        pesan = MsgBox("Yakin mau keluar?", vbYesNo, "Konfirmasi")
        If pesan = vbYes Then
        End If
        End
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim teks As String
        Dim jumlah As Integer
        teks = txtTeks.Text
        jumlah = Val(txtJumlah.Text)

        If teks <> "" And jumlah > 0 Then
            lbLoop.Items.Clear()
            For i = 1 To jumlah
                lbLoop.Items.Add(teks)
            Next i
        Else
            MsgBox("Isian teks dan ulang harus diisi!")
        End If
    End Sub

    Private Sub btnEraser_Click(sender As Object, e As EventArgs) Handles btnEraser.Click
        txtTeks.Text = ""
        txtJumlah.Text = ""
        lbLoop.Items.Clear()
    End Sub
End Class
