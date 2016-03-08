Imports System.IO

Public Class frmDangnhap
    Dim sai As Integer = 3
    Dim kiemTradangnhap As Boolean = False 'Khai báo Kiểm tra đăng nhập bằng Sai
    Public tenNguoiDN As String 'Tên Người đăng nhập với kiểu dữ liệu String dùng để lưu trữ chuỗi các ký tự
    Public quyenNguoidung As String 'Quyền người dùng với kiểu dữ liệu Integer là kiểu dữ liệu để lưu trữ các số nguyên 
    '1 : Quản trị viên
    '3 : Nhân viên
    Private Sub txtTaikhoan_TextChanged(sender As Object, e As EventArgs) Handles txtTaikhoan.TextChanged

    End Sub
    Private Sub frmDangnhap_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If kiemTradangnhap = False Then
            If MsgBox("Bạn Chắc Chắn Muốn Thoát Chương Trình ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Thông Báo") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If
            Application.Exit()
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit() 'Ứng dúng sẽ thoát 
    End Sub

    Private Sub frmDangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtMatkhau_TextChanged(sender As Object, e As EventArgs) Handles txtMatkhau.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        Dim reader As New StreamReader("FileDangNhap.txt")
        If txtTaikhoan.Text = "" Or txtMatkhau.Text = "" Then
            MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu. Vui lòng nhập vào")
        End If
        If sai > 0 Then
            Do Until reader.EndOfStream
                Dim mangTT(3) As String
                mangTT = Split(reader.ReadLine(), "^")
                If (txtTaikhoan.Text = mangTT(0) And txtMatkhau.Text = mangTT(1)) Then
                    kiemTradangnhap = True
                    tenNguoiDN = mangTT(0)
                    quyenNguoidung = mangTT(2)
                    Close()
                    If kiemTradangnhap = True Then
                        frmMain.menuDangxuatkhoihethong.Visible = True
                        frmMain.Show()
                    End If
                End If
            Loop
            reader.Close()
            If kiemTradangnhap = False Then
                sai = sai - 1
                MessageBox.Show("Bạn nhập sai rồi .Bạn còn " & sai & " lần !", "Thông báo")
            End If
        Else
            MessageBox.Show("Mời Bạn Truy Cập Lại !", "Thông báo")
            End
        End If
        If quyenNguoidung = 1 Then
            frmMain.menuHoatdong.Enabled = True
            frmMain.menuKhohang.Enabled = True
            frmMain.menuQuy.Enabled = True
            frmMain.menuNhansu.Enabled = True
            frmMain.menuQuantri.Enabled = True
        End If
        If quyenNguoidung = 2 Then
            frmMain.menuHoatdong.Enabled = False
            frmMain.menuKhohang.Enabled = False
            frmMain.menuQuy.Enabled = False
            frmMain.menuNhansu.Enabled = False
            frmMain.menuQuantri.Enabled = False
        End If
    End Sub

    Private Sub ckbGhinhomatkhau_CheckedChanged(sender As Object, e As EventArgs) Handles ckbGhinhomatkhau.CheckedChanged

    End Sub
End Class