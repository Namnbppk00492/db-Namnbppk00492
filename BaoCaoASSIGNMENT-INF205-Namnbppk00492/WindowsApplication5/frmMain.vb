Imports System.IO
Public Class frmMain
    Dim sqlConnect As New Class1

    Dim arrMathang As New ArrayList
    Dim kiemTradangnhap As Boolean = False
    Dim moban As Boolean = True
    Dim Dangxuatkhoihethong As Boolean = False
    Public tenNguoiDN As String
    Public quyenNguoidung As Integer
    Dim kiemTratimkiem As Boolean = False
    Dim chonMon As Boolean
    '1 : Quản trị viên
    '2 : Nhân viên
    Dim Dem As Integer
    Private Property kt As Boolean

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDangnhap.ShowDialog() 'Form Đăng nhập được hiện ra
        Docfile()
        txtdongia.Hide()
        qtmThanhtoan.Enabled = False
        qtmChuyenban.Enabled = False
        qtmGopban.Enabled = False
        qtmHuyhoadon.Enabled = False
        qtmThanhtoana2.Enabled = False
        qtmChuyenbana2.Enabled = False
        qtmGopbana2.Enabled = False
        qtmHuyhoadona2.Enabled = False
        qtmThanhtoana3.Enabled = False
        qtmChuyenbana3.Enabled = False
        qtmGopbana3.Enabled = False
        qtmHuyhoadona3.Enabled = False
        qtmThanhtoana4.Enabled = False
        qtmChuyenbana4.Enabled = False
        qtmGopbana4.Enabled = False
        qtmHuyhoadona4.Enabled = False
        qtmThanhtoana5.Enabled = False
        qtmChuyenbana5.Enabled = False
        qtmGopbana5.Enabled = False
        qtmHuyhoadona5.Enabled = False
        qtmThanhtoana6.Enabled = False
        qtmChuyenbana6.Enabled = False
        qtmGopbana6.Enabled = False
        qtmHuyhoadona6.Enabled = False
        qtmThanhtoana7.Enabled = False
        qtmChuyenbana7.Enabled = False
        qtmGopbana7.Enabled = False
        qtmHuyhoadona7.Enabled = False
        qtmThanhtoana8.Enabled = False
        qtmChuyenbana8.Enabled = False
        qtmGopbana8.Enabled = False
        qtmHuyhoadona8.Enabled = False

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub menuDangxuatkhoihethong_Click(sender As Object, e As EventArgs) Handles menuDangxuatkhoihethong.Click

        frmDangnhap.txtTaikhoan.Text = "" 'Khi đăng xuất không lưu các ký tự ở Texbox Tài khoản
        frmDangnhap.txtMatkhau.Text = "" 'Khi đăng xuất không lưu các ký tự ở Texbox Mật khẩu

        If menuDangxuatkhoihethong.Visible = False Then 'Nếu Đăng xuất khỏi hệ thống Thì người dùng sẽ không tương tác được với Menu Hoạt động
            MessageBox.Show("Hẹn gặp lại " & frmDangnhap.tenNguoiDN & "Tạm biệt !")
            Me.Hide()
            frmDangnhap.Show()
        End If


    End Sub

    Private Sub menuThoatkhoihethong_Click(sender As Object, e As EventArgs)
        frmDangnhap.ShowDialog() 'Form Đăng nhập được hiện ra
        menuDangxuatkhoihethong.Visible = True

        If frmDangnhap.txtTaikhoan.Text = "" Or frmDangnhap.txtMatkhau.Text = "" Then 'If Texbox tài khoản rỗng hoặc Texbox đăng nhập rỗng thì Ứng dụng Thoát
            Application.Exit()
        End If


    End Sub

    Private Sub ThoátKhỏiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuThoatkhoihethong.Click
        Dim rs As DialogResult 'Khai báo rs như Một nút người dùng nhấp chuột
        rs = MessageBox.Show("Bạn có muốn thoát khỏi hệ thống không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Thông báo Chọn Yes hoặc No
        If (rs = DialogResult.Yes) Then 'Nếu rs chọn Yes thì Chương trình sẽ đóng
            Close()
        End If
    End Sub

    Private Sub DanhMụcBànKhuVựcToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmDanhmucbankhuvuc.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblNgay_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked_1(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub lblGiamgia_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub menuDanhmuckhachhang_Click(sender As Object, e As EventArgs) Handles menuDanhmuckhachhang.Click
        frmDanhmuckhachhang.ShowDialog()
    End Sub

    Private Sub menuDanhmucdatban_Click(sender As Object, e As EventArgs) Handles menuDanhmucdatban.Click
        frmDanhmucmathang.ShowDialog()
    End Sub

    Private Sub menuDanhmucnhacungcap_Click(sender As Object, e As EventArgs) Handles menuDanhmucnhacungcap.Click
        frmDanhmucnhacungcap.ShowDialog()
    End Sub

    Private Sub menuNhanvien_Click(sender As Object, e As EventArgs) Handles menuNhanvien.Click
        frmNhanvien.ShowDialog()
    End Sub

    Private Sub menuTinhluong_Click(sender As Object, e As EventArgs) Handles menuTinhluong.Click
        frmTinhluong.ShowDialog()
    End Sub

    Private Sub menuNguoidungvaphanquyen_Click(sender As Object, e As EventArgs) Handles menuNguoidungvaphanquyen.Click
        frmNguoidungvaphanquyen.ShowDialog()
    End Sub

    Private Sub menuTaophieuthu_Click(sender As Object, e As EventArgs) Handles menuTaophieuthu.Click
        frmPhieuthutien.ShowDialog()
    End Sub

    Private Sub menuTaophieuchi_Click(sender As Object, e As EventArgs) Handles menuTaophieuchi.Click
        frmPhieuchitien.ShowDialog()
    End Sub

    Private Sub menuDanhmucphieuthuchi_Click(sender As Object, e As EventArgs) Handles menuDanhmucphieuthuchi.Click
        frmDanhmucPhieuthuchi.ShowDialog()
    End Sub

    Private Sub grbKhua_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub menuCalamviec_Click(sender As Object, e As EventArgs) Handles menuCalamviec.Click
        frmCalamviec.ShowDialog()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles tpeSudungdichvu.Click

    End Sub

    Private Sub ptbCafekhuvuca1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhuvuca1.MouseDoubleClick
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca1.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca1.Image = Hinh2

    End Sub

    Private Sub ptbCafekhuvuca1_Click(sender As Object, e As EventArgs) Handles ptbCafekhuvuca1.Click

        lblBan.Text = lblBana1.Text
        lblBan.Show()
        txtTongcong.Show()
        lsvLista1.Show()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Hide()

    End Sub

    Private Sub QwToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles qtmenuMoban.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca1.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca1.Image = Hinh2
        moban = True
        lblBan.Text = lblBana1.Text
        lblBan.Show()
        lsvLista1.Show()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Hide()
        qtmenuMoban.Enabled = False
        qtmThanhtoan.Enabled = True
        qtmChuyenban.Enabled = True
        qtmGopban.Enabled = True
        qtmHuyhoadon.Enabled = True

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub grbMenu_Enter(sender As Object, e As EventArgs) Handles grbMenu.Enter

    End Sub

    Private Sub menuKiemsoatoder_Click(sender As Object, e As EventArgs) Handles menuKiemsoatoder.Click
        frmKiemsoatoder.ShowDialog()
    End Sub

    Private Sub menuThongkedoanhthu_Click(sender As Object, e As EventArgs) Handles menuThongkedoanhthu.Click
        frmThongkedoanhthu.ShowDialog()
    End Sub

    Private Sub menuThongkedoanuong_Click(sender As Object, e As EventArgs) Handles menuThongkedoanuong.Click
        frmThongkedoanuong.ShowDialog()
    End Sub

    Private Sub qtmThanhtoan_Click(sender As Object, e As EventArgs) Handles qtmThanhtoan.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca1.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca1.Image = Hinh2
        Dim a As Integer
        Dim b As Integer = 0
        a = txtTienhang.Text
        b = txtPhidichvu1.Text
        txtTongcong.Text = a + b
        qtmenuMoban.Enabled = True
        qtmThanhtoan.Enabled = False
        qtmChuyenban.Enabled = False
        qtmGopban.Enabled = False
        qtmHuyhoadon.Enabled = False
        lsvLista1.Items.Clear()
    End Sub

    Private Sub ptbCafekhuvuca2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhuvuca2.MouseDoubleClick
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca2.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca2.Image = Hinh2
    End Sub

    Private Sub ptbCafekhuvuca2_Click(sender As Object, e As EventArgs) Handles ptbCafekhuvuca2.Click
        moban = False
        lblBan.Text = lblBana2.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Show()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Hide()
    End Sub

    Private Sub ptbCafekhuvuca2_MouseHover(sender As Object, e As EventArgs) Handles ptbCafekhuvuca2.MouseHover

    End Sub

    Private Sub ptbCafekhub1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhub1.MouseDoubleClick
        Dim Hinh3 As Bitmap = My.Resources.cocktail_2
        ptbCafekhub1.Image = Hinh3
        Dim Hinh4 As Bitmap = My.Resources.cocktail
        ptbCafekhub1.Image = Hinh4
    End Sub

    Private Sub ctmBana1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctmBana1.Opening

    End Sub

    Private Sub ptbCafekhuvuca3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhuvuca3.MouseDoubleClick
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca3.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca3.Image = Hinh2
    End Sub

    Private Sub ptbCafekhuvuca4_Click(sender As Object, e As EventArgs) Handles ptbCafekhuvuca4.Click
        moban = False
        lblBan.Text = lblBana4.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Show()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Hide()
    End Sub

    Private Sub ptbCafekhuvuca5_Click(sender As Object, e As EventArgs) Handles ptbCafekhuvuca5.Click
        moban = False
        lblBan.Text = lblBana5.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Show()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Hide()
    End Sub

    Private Sub ptbCafekhuvuca6_Click(sender As Object, e As EventArgs) Handles ptbCafekhuvuca6.Click
        moban = False
        lblBan.Text = lblBana6.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Show()
        lsvLista7.Hide()
        lsvLista8.Hide()
    End Sub

    Private Sub ptbCafekhuvuca7_Click(sender As Object, e As EventArgs) Handles ptbCafekhuvuca7.Click
        moban = False
        lblBan.Text = lblBana7.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Show()
        lsvLista8.Hide()
    End Sub

    Private Sub ptbCafekhuvuca8_Click(sender As Object, e As EventArgs) Handles ptbCafekhuvuca8.Click
        moban = False
        lblBan.Text = lblBana8.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Show()

    End Sub

    Private Sub ptbCafekhub1_Click(sender As Object, e As EventArgs) Handles ptbCafekhub1.Click

    End Sub

    Private Sub ptbCafekhub2_Click(sender As Object, e As EventArgs) Handles ptbCafekhub2.Click

    End Sub

    Private Sub ptbCafekhub3_Click(sender As Object, e As EventArgs) Handles ptbCafekhub3.Click

    End Sub

    Private Sub ptbCafekhub4_Click(sender As Object, e As EventArgs) Handles ptbCafekhub4.Click

    End Sub

    Private Sub ptbCafekhub5_Click(sender As Object, e As EventArgs) Handles ptbCafekhub5.Click

    End Sub

    Private Sub ptbCafekhub6_Click(sender As Object, e As EventArgs) Handles ptbCafekhub6.Click

    End Sub

    Private Sub ptbCafekhub7_Click(sender As Object, e As EventArgs) Handles ptbCafekhub7.Click

    End Sub

    Private Sub ptbCafekhub8_Click(sender As Object, e As EventArgs) Handles ptbCafekhub8.Click

    End Sub

    Private Sub ptbCafekhuvuca3_Click(sender As Object, e As EventArgs) Handles ptbCafekhuvuca3.Click
        moban = False
        lblBan.Text = lblBana3.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Show()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Hide()
    End Sub

    Private Sub ptbCafekhuvuca4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhuvuca4.MouseDoubleClick
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca4.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca4.Image = Hinh2
    End Sub

    Private Sub ptbCafekhuvuca5_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhuvuca5.MouseDoubleClick
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca5.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca5.Image = Hinh2
    End Sub

    Private Sub ptbCafekhuvuca6_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhuvuca6.MouseDoubleClick
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca6.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca6.Image = Hinh2
    End Sub

    Private Sub ptbCafekhuvuca7_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhuvuca7.MouseDoubleClick
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca7.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca7.Image = Hinh2
    End Sub

    Private Sub ptbCafekhuvuca8_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhuvuca8.MouseDoubleClick
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca8.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca8.Image = Hinh2
    End Sub

    Private Sub ptbCafekhub2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhub2.MouseDoubleClick
        Dim Hinh3 As Bitmap = My.Resources.cocktail_2
        ptbCafekhub2.Image = Hinh3
        Dim Hinh4 As Bitmap = My.Resources.cocktail
        ptbCafekhub2.Image = Hinh4
    End Sub

    Private Sub ptbCafekhub3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhub3.MouseDoubleClick
        Dim Hinh3 As Bitmap = My.Resources.cocktail_2
        ptbCafekhub3.Image = Hinh3
        Dim Hinh4 As Bitmap = My.Resources.cocktail
        ptbCafekhub3.Image = Hinh4
    End Sub

    Private Sub ptbCafekhub4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhub4.MouseDoubleClick
        Dim Hinh3 As Bitmap = My.Resources.cocktail_2
        ptbCafekhub4.Image = Hinh3
        Dim Hinh4 As Bitmap = My.Resources.cocktail
        ptbCafekhub4.Image = Hinh4
    End Sub

    Private Sub ptbCafekhub5_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhub5.MouseDoubleClick
        Dim Hinh3 As Bitmap = My.Resources.cocktail_2
        ptbCafekhub5.Image = Hinh3
        Dim Hinh4 As Bitmap = My.Resources.cocktail
        ptbCafekhub5.Image = Hinh4
    End Sub

    Private Sub ptbCafekhub6_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhub6.MouseDoubleClick
        Dim Hinh3 As Bitmap = My.Resources.cocktail_2
        ptbCafekhub6.Image = Hinh3
        Dim Hinh4 As Bitmap = My.Resources.cocktail
        ptbCafekhub6.Image = Hinh4
    End Sub

    Private Sub ptbCafekhub7_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhub7.MouseDoubleClick
        Dim Hinh3 As Bitmap = My.Resources.cocktail_2
        ptbCafekhub7.Image = Hinh3
        Dim Hinh4 As Bitmap = My.Resources.cocktail
        ptbCafekhub7.Image = Hinh4
    End Sub

    Private Sub ptbCafekhub8_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhub8.MouseDoubleClick
        Dim Hinh3 As Bitmap = My.Resources.cocktail_2
        ptbCafekhub8.Image = Hinh3
        Dim Hinh4 As Bitmap = My.Resources.cocktail
        ptbCafekhub8.Image = Hinh4
    End Sub

    Private Sub MởBànToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles qtmMobana2.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca2.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca2.Image = Hinh2
        moban = True
        lblBan.Text = lblBana2.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Show()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Hide()
        qtmMobana2.Enabled = False
        qtmThanhtoana2.Enabled = True
        qtmChuyenbana2.Enabled = True
        qtmGopbana2.Enabled = True
        qtmHuyhoadona2.Enabled = True

    End Sub

    Private Sub ThanhToánToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles qtmThanhtoana2.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca2.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca2.Image = Hinh2
        Dim a As Integer
        Dim b As Integer = 0
        a = txtTienhang.Text
        b = txtPhidichvu1.Text
        txtTongcong.Text = a + b
        qtmMobana2.Enabled = True
        qtmThanhtoana2.Enabled = False
        qtmChuyenbana2.Enabled = False
        qtmGopbana2.Enabled = False
        qtmHuyhoadona2.Enabled = False
        lsvLista2.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles qtmMobana3.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca3.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca3.Image = Hinh2
        moban = True
        lblBan.Text = lblBana3.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Show()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Hide()
        qtmMobana3.Enabled = False
        qtmThanhtoana3.Enabled = True
        qtmChuyenbana3.Enabled = True
        qtmGopbana3.Enabled = True
        qtmHuyhoadona3.Enabled = True

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles qtmThanhtoana3.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca3.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca3.Image = Hinh2
        Dim a As Integer
        Dim b As Integer = 0
        a = txtTienhang.Text
        b = txtPhidichvu1.Text
        txtTongcong.Text = a + b
        qtmMobana3.Enabled = True
        qtmThanhtoana3.Enabled = False
        qtmChuyenbana3.Enabled = False
        qtmGopbana3.Enabled = False
        qtmHuyhoadona3.Enabled = False
        lsvLista3.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles qtmMobana4.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca4.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca4.Image = Hinh2
        moban = True
        lblBan.Text = lblBana4.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Show()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Hide()
        qtmMobana4.Enabled = False
        qtmThanhtoana4.Enabled = True
        qtmChuyenbana4.Enabled = True
        qtmGopbana4.Enabled = True
        qtmHuyhoadona4.Enabled = True
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles qtmThanhtoana4.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca4.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca4.Image = Hinh2
        Dim a As Integer
        Dim b As Integer = 0
        a = txtTienhang.Text
        b = txtPhidichvu1.Text
        txtTongcong.Text = a + b
        qtmMobana4.Enabled = True
        qtmThanhtoana4.Enabled = False
        qtmChuyenbana4.Enabled = False
        qtmGopbana4.Enabled = False
        qtmHuyhoadona4.Enabled = False
        lsvLista4.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles qtmMobana5.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca5.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca5.Image = Hinh2
        moban = True
        lblBan.Text = lblBana5.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Show()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Hide()
        qtmMobana5.Enabled = False
        qtmThanhtoana5.Enabled = True
        qtmChuyenbana5.Enabled = True
        qtmGopbana5.Enabled = True
        qtmHuyhoadona5.Enabled = True

    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles qtmMobana6.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca6.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca6.Image = Hinh2
        moban = True
        lblBan.Text = lblBana6.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Show()
        lsvLista7.Hide()
        lsvLista8.Hide()
        qtmMobana6.Enabled = False
        qtmThanhtoana6.Enabled = True
        qtmChuyenbana6.Enabled = True
        qtmGopbana6.Enabled = True
        qtmHuyhoadona6.Enabled = True
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles qtmThanhtoana6.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca6.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca6.Image = Hinh2
        Dim a As Integer
        Dim b As Integer = 0
        a = txtTienhang.Text
        b = txtPhidichvu1.Text
        txtTongcong.Text = a + b
        qtmMobana6.Enabled = True
        qtmThanhtoana6.Enabled = False
        qtmChuyenbana6.Enabled = False
        qtmGopbana6.Enabled = False
        qtmHuyhoadona6.Enabled = False
        lsvLista6.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles qtmMobana7.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca7.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca7.Image = Hinh2
        moban = True
        lblBan.Text = lblBana7.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Show()
        lsvLista8.Hide()
        qtmMobana7.Enabled = False
        qtmThanhtoana7.Enabled = True
        qtmChuyenbana7.Enabled = True
        qtmGopbana7.Enabled = True
        qtmHuyhoadona7.Enabled = True

    End Sub

    Private Sub ctmBana7_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctmBana7.Opening

    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles qtmThanhtoana7.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca7.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca7.Image = Hinh2
        Dim a As Integer
        Dim b As Integer = 0
        a = txtTienhang.Text
        b = txtPhidichvu1.Text
        txtTongcong.Text = a + b
        qtmMobana7.Enabled = True
        qtmThanhtoana7.Enabled = False
        qtmChuyenbana7.Enabled = False
        qtmGopbana7.Enabled = False
        qtmHuyhoadona7.Enabled = False

        lsvLista7.Items.Clear()

    End Sub

    Private Sub ToolStripMenuItem26_Click(sender As Object, e As EventArgs) Handles qtmMobana8.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca8.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca8.Image = Hinh2
        moban = True
        lblBan.Text = lblBana8.Text
        lblBan.Show()
        lsvLista1.Hide()
        lsvLista2.Hide()
        lsvLista3.Hide()
        lsvLista4.Hide()
        lsvLista5.Hide()
        lsvLista6.Hide()
        lsvLista7.Hide()
        lsvLista8.Show()
        btnThem.Enabled = True
        qtmMobana8.Enabled = False
        qtmThanhtoana8.Enabled = True
        qtmChuyenbana8.Enabled = True
        qtmGopbana8.Enabled = True
        qtmHuyhoadona8.Enabled = True

    End Sub

    Private Sub ToolStripMenuItem27_Click(sender As Object, e As EventArgs) Handles qtmThanhtoana8.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca8.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca8.Image = Hinh2
        Dim a As Integer
        Dim b As Integer = 0
        a = txtTienhang.Text
        b = txtPhidichvu1.Text
        txtTongcong.Text = a + b
        qtmMobana8.Enabled = True
        qtmThanhtoana8.Enabled = False
        qtmChuyenbana8.Enabled = False
        qtmGopbana8.Enabled = False
        qtmHuyhoadona8.Enabled = False
        lsvLista8.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles qtmThanhtoana5.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca5.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca5.Image = Hinh2
        Dim a As Integer
        Dim b As Integer = 0
        a = txtTienhang.Text
        b = txtPhidichvu1.Text
        txtTongcong.Text = a + b
        qtmMobana5.Enabled = True
        qtmThanhtoana5.Enabled = False
        qtmChuyenbana5.Enabled = False
        qtmGopbana5.Enabled = False
        qtmHuyhoadona5.Enabled = False
        lsvLista5.Items.Clear()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvMain.SelectedIndexChanged

    End Sub
    Public Sub Docfile()
        frmDanhmucmathang.lsvMathang.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * From SanPham")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(frmDanhmucmathang.lsvMathang.Items.Count + 1)

            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            lsvMain.Items.Add(item)
        Next
    End Sub
    Public Sub ThemMatHangVaoListView(mathang As String, donvitinh As String, giaban As String)

        Dim soTT = lsvMain.Items.Count + 1
        Dim item = New ListViewItem(soTT)
        item.SubItems.Add(mathang)
        item.SubItems.Add(donvitinh)
        item.SubItems.Add(giaban)
        lsvMain.Items.Add(item)

    End Sub

    Private Sub lsvMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lsvMain.MouseDoubleClick
        Dim ptu As ListViewItem

        Dim so As Integer

        so = lsvLista1.Items.Count

        ptu = New ListViewItem(so + 1)

        ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(1).Text)

        ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(3).Text)

        lsvLista1.Items.Add(ptu)

    End Sub

    Private Sub lsvList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvLista1.SelectedIndexChanged

    End Sub

    Private Sub ptbCafekhuvuca1_MouseClick(sender As Object, e As MouseEventArgs) Handles ptbCafekhuvuca1.MouseClick

    End Sub

    Private Sub lblBan_Click(sender As Object, e As EventArgs) Handles lblBan.Click

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If lblBan.Text = lblBana1.Text Then
            Dim sl As Double
            Dim dongia As Double
            sl = (nudSoluong.Value)
            dongia = (lsvMain.SelectedItems(0).SubItems(3).Text)
            txtdongia.Text = sl * dongia
            Dim ptu As ListViewItem
            Dim so As Integer
            so = lsvLista1.Items.Count
            ptu = New ListViewItem(so + 1)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(1).Text)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(3).Text)
            ptu.SubItems.Add(nudSoluong.Value)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(2).Text)
            ptu.SubItems.Add(txtdongia.Text)
            lsvLista1.Items.Add(ptu)
            Dim TotalSum As Double = 0
            Dim TempNode As ListViewItem
            For Each TempNode In lsvLista1.Items
                TotalSum += CDbl(TempNode.SubItems.Item(5).Text)
            Next
            txtTienhang.Text = TotalSum
        ElseIf lblBan.Text = lblBana2.Text Then
            Dim sl As Double
            Dim dongia As Double
            sl = (nudSoluong.Value)
            dongia = (lsvMain.SelectedItems(0).SubItems(3).Text)
            txtdongia.Text = sl * dongia
            Dim ptu As ListViewItem
            Dim so As Integer
            so = lsvLista2.Items.Count
            ptu = New ListViewItem(so + 1)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(1).Text)
            ptu.SubItems.Add(nudSoluong.Value)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(3).Text)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(2).Text)
            ptu.SubItems.Add(txtdongia.Text)
            lsvLista2.Items.Add(ptu)
            Dim TotalSum As Double = 0
            Dim TempNode As ListViewItem
            For Each TempNode In lsvLista2.Items
                TotalSum += CDbl(TempNode.SubItems.Item(5).Text)
            Next
            txtTienhang.Text = TotalSum
        ElseIf lblBan.Text = lblBana3.Text Then
            Dim sl As Double
            Dim dongia As Double
            sl = (nudSoluong.Value)
            dongia = (lsvMain.SelectedItems(0).SubItems(3).Text)
            txtdongia.Text = sl * dongia
            Dim ptu As ListViewItem
            Dim so As Integer
            so = lsvLista3.Items.Count
            ptu = New ListViewItem(so + 1)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(1).Text)
            ptu.SubItems.Add(nudSoluong.Value)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(3).Text)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(2).Text)
            ptu.SubItems.Add(txtdongia.Text)
            lsvLista3.Items.Add(ptu)
            Dim TotalSum As Double = 0
            Dim TempNode As ListViewItem
            For Each TempNode In lsvLista3.Items
                TotalSum += CDbl(TempNode.SubItems.Item(5).Text)
            Next
            txtTienhang.Text = TotalSum
        ElseIf lblBan.Text = lblBana4.Text Then
            Dim sl As Double
            Dim dongia As Double
            sl = (nudSoluong.Value)
            dongia = (lsvMain.SelectedItems(0).SubItems(3).Text)
            txtdongia.Text = sl * dongia
            Dim ptu As ListViewItem
            Dim so As Integer
            so = lsvLista4.Items.Count
            ptu = New ListViewItem(so + 1)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(1).Text)
            ptu.SubItems.Add(nudSoluong.Value)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(3).Text)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(2).Text)
            ptu.SubItems.Add(txtdongia.Text)
            lsvLista4.Items.Add(ptu)
            Dim TotalSum As Double = 0
            Dim TempNode As ListViewItem
            For Each TempNode In lsvLista4.Items
                TotalSum += CDbl(TempNode.SubItems.Item(5).Text)
            Next
            txtTienhang.Text = TotalSum
        ElseIf lblBan.Text = lblBana5.Text Then
            Dim sl As Double
            Dim dongia As Double
            sl = (nudSoluong.Value)
            dongia = (lsvMain.SelectedItems(0).SubItems(3).Text)
            txtdongia.Text = sl * dongia
            Dim ptu As ListViewItem
            Dim so As Integer
            so = lsvLista5.Items.Count
            ptu = New ListViewItem(so + 1)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(1).Text)
            ptu.SubItems.Add(nudSoluong.Value)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(3).Text)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(2).Text)
            ptu.SubItems.Add(txtdongia.Text)
            lsvLista5.Items.Add(ptu)
            Dim TotalSum As Double = 0
            Dim TempNode As ListViewItem
            For Each TempNode In lsvLista5.Items
                TotalSum += CDbl(TempNode.SubItems.Item(5).Text)
            Next
            txtTienhang.Text = TotalSum
        ElseIf lblBan.Text = lblBana6.Text Then
            Dim sl As Double
            Dim dongia As Double
            sl = (nudSoluong.Value)
            dongia = (lsvMain.SelectedItems(0).SubItems(3).Text)
            txtdongia.Text = sl * dongia
            Dim ptu As ListViewItem
            Dim so As Integer
            so = lsvLista6.Items.Count
            ptu = New ListViewItem(so + 1)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(1).Text)
            ptu.SubItems.Add(nudSoluong.Value)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(3).Text)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(2).Text)
            ptu.SubItems.Add(txtdongia.Text)
            lsvLista6.Items.Add(ptu)
            Dim TotalSum As Double = 0
            Dim TempNode As ListViewItem
            For Each TempNode In lsvLista6.Items
                TotalSum += CDbl(TempNode.SubItems.Item(5).Text)
            Next
            txtTienhang.Text = TotalSum
        ElseIf lblBan.Text = lblBana7.Text Then
            Dim sl As Double
            Dim dongia As Double
            sl = (nudSoluong.Value)
            dongia = (lsvMain.SelectedItems(0).SubItems(3).Text)
            txtdongia.Text = sl * dongia
            Dim ptu As ListViewItem
            Dim so As Integer
            so = lsvLista7.Items.Count
            ptu = New ListViewItem(so + 1)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(1).Text)
            ptu.SubItems.Add(nudSoluong.Value)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(3).Text)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(2).Text)
            ptu.SubItems.Add(txtdongia.Text)
            lsvLista7.Items.Add(ptu)
            Dim TotalSum As Double = 0
            Dim TempNode As ListViewItem
            For Each TempNode In lsvLista7.Items
                TotalSum += CDbl(TempNode.SubItems.Item(5).Text)
            Next
            txtTienhang.Text = TotalSum
        ElseIf lblBan.Text = lblBana8.Text Then
            Dim sl As Double
            Dim dongia As Double
            sl = (nudSoluong.Value)
            dongia = (lsvMain.SelectedItems(0).SubItems(3).Text)
            txtdongia.Text = sl * dongia
            Dim ptu As ListViewItem
            Dim so As Integer
            so = lsvLista8.Items.Count
            ptu = New ListViewItem(so + 1)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(1).Text)
            ptu.SubItems.Add(nudSoluong.Value)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(3).Text)
            ptu.SubItems.Add(lsvMain.SelectedItems(0).SubItems(2).Text)
            ptu.SubItems.Add(txtdongia.Text)
            lsvLista8.Items.Add(ptu)
            Dim TotalSum As Double = 0
            Dim TempNode As ListViewItem
            For Each TempNode In lsvLista8.Items
                TotalSum += CDbl(TempNode.SubItems.Item(5).Text)
            Next
            txtTienhang.Text = TotalSum

        End If
    End Sub

    Private Sub lsvList_DragOver(sender As Object, e As DragEventArgs) Handles lsvLista1.DragOver

    End Sub

    Private Sub lsvLista2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvLista2.SelectedIndexChanged

    End Sub

    Private Sub lsvLista3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvLista3.SelectedIndexChanged

    End Sub

    Private Sub txtTienhang_TextChanged(sender As Object, e As EventArgs) Handles txtTienhang.TextChanged

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ThongBao As DialogResult
        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            For i As Integer = lsvLista1.SelectedIndices.Count - 1 To 0 Step -1
                lsvLista1.Items.RemoveAt(lsvLista1.SelectedIndices(i))
            Next
        End If
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            For i As Integer = lsvLista2.SelectedIndices.Count - 1 To 0 Step -1
                lsvLista2.Items.RemoveAt(lsvLista2.SelectedIndices(i))
            Next
        End If
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            For i As Integer = lsvLista3.SelectedIndices.Count - 1 To 0 Step -1
                lsvLista3.Items.RemoveAt(lsvLista3.SelectedIndices(i))
            Next
        End If
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            For i As Integer = lsvLista4.SelectedIndices.Count - 1 To 0 Step -1
                lsvLista4.Items.RemoveAt(lsvLista4.SelectedIndices(i))
            Next
        End If
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            For i As Integer = lsvLista5.SelectedIndices.Count - 1 To 0 Step -1
                lsvLista5.Items.RemoveAt(lsvLista5.SelectedIndices(i))
            Next
        End If
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            For i As Integer = lsvLista7.SelectedIndices.Count - 1 To 0 Step -1
                lsvLista7.Items.RemoveAt(lsvLista7.SelectedIndices(i))
            Next
        End If
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            For i As Integer = lsvLista8.SelectedIndices.Count - 1 To 0 Step -1
                lsvLista8.Items.RemoveAt(lsvLista8.SelectedIndices(i))
            Next
        End If
    End Sub

    Private Sub ctmBana2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctmBana2.Opening

    End Sub

    Private Sub mnsMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnsMenu.ItemClicked

    End Sub

    Private Sub lsvLista8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvLista8.SelectedIndexChanged

    End Sub

    Private Sub drpNgay_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnThanhtoan_Click(sender As Object, e As EventArgs) Handles btnThanhtoan.Click
        Dim a As Integer
        Dim b As Integer = 0
        a = txtTienhang.Text
        b = txtPhidichvu1.Text
        txtTongcong.Text = a + b
    End Sub

    Public Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtTimkiem.TextChanged
        Dim kiemTratimkiem As Boolean = False
        Dim reader As New StreamReader("FileSanPham.txt")
        lsvMain.Items.Clear()
        Do Until reader.EndOfStream
            Dim mangTT(8) As String
            Dim noiDungmotdong As String

            noiDungmotdong = reader.ReadLine()

            mangTT = Split(noiDungmotdong, "^")
            If (mangTT(0).ToLower.Contains(txtTimkiem.Text.ToLower) Or mangTT(1).ToLower.Contains(txtTimkiem.Text.ToLower)) Then
                ThemMatHangVaoListView(mangTT(0), mangTT(1), mangTT(2))
            End If
        Loop

    End Sub

    Private Sub txtTimkiem_MouseClick(sender As Object, e As MouseEventArgs) Handles txtTimkiem.MouseClick
        txtTimkiem.Text = ""
    End Sub

    Private Sub txtdongia_TextChanged(sender As Object, e As EventArgs) Handles txtdongia.TextChanged


        ' txtTienhang.Text = dongia + tong
        ' txtTongcong.Text = dongia + txtTienhang.Text

    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtTongcong_TextChanged(sender As Object, e As EventArgs) Handles txtTongcong.TextChanged

    End Sub

    Private Sub lsvLista6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvLista6.SelectedIndexChanged

    End Sub

    Private Sub btnInhoadon_Click(sender As Object, e As EventArgs) Handles btnInhoadon.Click

    End Sub

    Private Sub qtmHuyhoadon_Click(sender As Object, e As EventArgs) Handles qtmHuyhoadon.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca1.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca1.Image = Hinh2
        lsvLista1.Items.Clear()
        txtTienhang.Text = 0
        qtmenuMoban.Enabled = True
        qtmThanhtoan.Enabled = False
        qtmChuyenban.Enabled = False
        qtmGopban.Enabled = False
        qtmHuyhoadon.Enabled = False
    End Sub

    Private Sub qtmHuyhoadona2_Click(sender As Object, e As EventArgs) Handles qtmHuyhoadona2.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca1.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca1.Image = Hinh2
        lsvLista2.Items.Clear()
        txtTienhang.Text = 0
        qtmMobana2.Enabled = True
        qtmThanhtoana2.Enabled = False
        qtmChuyenbana2.Enabled = False
        qtmGopbana2.Enabled = False
        qtmHuyhoadona2.Enabled = False
    End Sub

    Private Sub qtmHuyhoadona3_Click(sender As Object, e As EventArgs) Handles qtmHuyhoadona3.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca1.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca1.Image = Hinh2
        lsvLista3.Items.Clear()
        txtTienhang.Text = 0
        qtmMobana3.Enabled = True
        qtmThanhtoana3.Enabled = False
        qtmChuyenbana3.Enabled = False
        qtmGopbana3.Enabled = False
        qtmHuyhoadona3.Enabled = False
    End Sub

    Private Sub qtmHuyhoadona4_Click(sender As Object, e As EventArgs) Handles qtmHuyhoadona4.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca1.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca1.Image = Hinh2
        lsvLista4.Items.Clear()
        txtTienhang.Text = 0
        qtmMobana4.Enabled = True
        qtmThanhtoana4.Enabled = False
        qtmChuyenbana4.Enabled = False
        qtmGopbana4.Enabled = False
        qtmHuyhoadona4.Enabled = False
    End Sub

    Private Sub qtmHuyhoadona5_Click(sender As Object, e As EventArgs) Handles qtmHuyhoadona5.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca1.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca1.Image = Hinh2
        lsvLista5.Items.Clear()
        txtTienhang.Text = 0
        qtmMobana5.Enabled = True
        qtmThanhtoana5.Enabled = False
        qtmChuyenbana5.Enabled = False
        qtmGopbana5.Enabled = False
        qtmHuyhoadona5.Enabled = False
    End Sub

    Private Sub qtmHuyhoadona6_Click(sender As Object, e As EventArgs) Handles qtmHuyhoadona6.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca1.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca1.Image = Hinh2
        lsvLista6.Items.Clear()
        txtTienhang.Text = 0
        qtmMobana6.Enabled = True
        qtmThanhtoana6.Enabled = False
        qtmChuyenbana6.Enabled = False
        qtmGopbana6.Enabled = False
        qtmHuyhoadona6.Enabled = False
    End Sub

    Private Sub qtmHuyhoadona7_Click(sender As Object, e As EventArgs) Handles qtmHuyhoadona7.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca1.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca1.Image = Hinh2
        lsvLista7.Items.Clear()
        txtTienhang.Text = 0
        qtmMobana7.Enabled = True
        qtmThanhtoana7.Enabled = False
        qtmChuyenbana7.Enabled = False
        qtmGopbana7.Enabled = False
        qtmHuyhoadona7.Enabled = False
    End Sub

    Private Sub qtmHuyhoadona8_Click(sender As Object, e As EventArgs) Handles qtmHuyhoadona8.Click
        Dim Hinh1 As Bitmap = My.Resources.coffee
        ptbCafekhuvuca1.Image = Hinh1
        Dim Hinh2 As Bitmap = My.Resources.coffee___2
        ptbCafekhuvuca1.Image = Hinh2
        lsvLista8.Items.Clear()
        txtTienhang.Text = 0
        qtmMobana8.Enabled = True
        qtmThanhtoana8.Enabled = False
        qtmChuyenbana8.Enabled = False
        qtmGopbana8.Enabled = False
        qtmHuyhoadona8.Enabled = False
    End Sub

    Private Sub menuHuongdansudung_Click(sender As Object, e As EventArgs) Handles menuHuongdansudung.Click
        frmHotro.ShowDialog()
    End Sub

    Private Sub menuCapnhatphienbanmoi_Click(sender As Object, e As EventArgs) Handles menuCapnhatphienbanmoi.Click
        MessageBox.Show("Hiện chưa có phiên bản mới")
    End Sub

    Private Sub menuBatdausudungphanmem_Click(sender As Object, e As EventArgs) Handles menuBatdausudungphanmem.Click
        frmHotro.ShowDialog()
    End Sub

    Private Sub menuMeovatkhisudungphanmem_Click(sender As Object, e As EventArgs) Handles menuMeovatkhisudungphanmem.Click
        frmHotro.ShowDialog()
    End Sub

    Private Sub grbMathang_Enter(sender As Object, e As EventArgs) Handles grbMathang.Enter

    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmHoadon.ShowDialog()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        frmChitiethoadon.ShowDialog()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub DanhMụcLoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub menuBaocaokhohang_Click(sender As Object, e As EventArgs) Handles menuBaocaokhohang.Click
        frmLoaisanpham.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        sqlConnect.ExecuteNoneQuery("select * from SanPham where TenSanPham like  '%" & txtTimkiem.Text & "%'")
    End Sub
End Class
