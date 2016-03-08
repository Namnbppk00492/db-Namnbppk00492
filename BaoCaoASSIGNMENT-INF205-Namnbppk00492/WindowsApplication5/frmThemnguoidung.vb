Imports System.IO
Public Class frmThemnguoidung
    Dim arrTaikhoan As New ArrayList
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTaikhoan.Click, lblMatkhau.Click

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        arrTaikhoan.Clear()
        If txtTaikhoan.Text = "" Then
            MessageBox.Show("Chưa nhập tên tài khoản. Vui lòng nhập tên tài khoản")
        End If
        If txtMatkhau.Text = "" Then
            MessageBox.Show("Chưa nhập mật khẩu. Vui lòng nhập mật khẩu")
        End If
        If cbbNhomnguoidung.Text = "" Then
            MessageBox.Show("Chưa chọn quyền đăng nhập. Vui lòng chọn quyền đăng nhập")
        End If
        Try
            If txtTaikhoan.Text <> "" And txtMatkhau.Text <> "" And cbbNhomnguoidung.Text < 3 And cbbNhomnguoidung.Text > 0 Then
                Dim soDonghiencotronglistview As Integer = frmNguoidungvaphanquyen.lsvNguoidungvaphanquyen.Items.Count

                Dim item As ListViewItem = New ListViewItem(soDonghiencotronglistview + 1)
                item.SubItems.Add(txtTaikhoan.Text)
                item.SubItems.Add(txtMatkhau.Text)
                item.SubItems.Add(cbbNhomnguoidung.Text)
                GhiVaoFileText()
                Docfile()
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đầy đủ thông tin để tạo tài khoản")
        End Try
    End Sub
    Public Sub GhiVaoFileText()
        Dim wirter As New StreamWriter("FileDangNhap.txt", True)

        wirter.WriteLine(txtTaikhoan.Text & "^" & txtMatkhau.Text & "^" & cbbNhomnguoidung.Text)

        wirter.Close()
    End Sub
    Public Sub Docfile()
        frmNguoidungvaphanquyen.lsvNguoidungvaphanquyen.Items.Clear()

        Dim reader As New StreamReader("FileDangNhap.txt")

        Do Until reader.EndOfStream
            Dim mangTT(2) As String
            Dim noiDungmotdong As String

            noiDungmotdong = reader.ReadLine()

            mangTT = Split(noiDungmotdong, "^")

            ThemTaiKhoanVaoListView(mangTT(0), mangTT(1), mangTT(2))

        Loop
        reader.Close()
    End Sub
    Public Sub ThemTaiKhoanVaoListView(taikhoan As String, matkhau As String, quyen As String)

        Dim soTT = frmNguoidungvaphanquyen.lsvNguoidungvaphanquyen.Items.Count + 1
        Dim item = New ListViewItem(soTT)

        item.SubItems.Add(taikhoan)
        item.SubItems.Add(matkhau)
        item.SubItems.Add(quyen)
        frmNguoidungvaphanquyen.lsvNguoidungvaphanquyen.Items.Add(item)

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub
End Class