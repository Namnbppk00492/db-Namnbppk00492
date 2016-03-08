Imports System.IO
Public Class frmPhieuchitien
    Dim arrPhieuchi As New ArrayList
    Private Sub frmPhieuchitien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub GhiVaoFileText()
        Dim wirter As New StreamWriter("FilePhieuChi.txt", True)
        wirter.WriteLine(txtSophieuchi.Text & "^" & cbbLoaiphieuchi.Text & "^" & txtLydochi.Text & "^" & txtNguoinhan.Text & "^" & txtDiachi.Text & "^" & txtSotien.Text & "^" & txtGhichu.Text)
        wirter.Close()
    End Sub

    Private Sub btnGhidulieu_Click(sender As Object, e As EventArgs) Handles btnGhidulieu.Click
        GhiVaoFileText()
    End Sub
End Class