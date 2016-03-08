Imports System.IO
Public Class frmThemmoikhachhang
    Dim arrKhachhang As New ArrayList
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMakhach.TextChanged, txtSdt.TextChanged, txtDiachi.TextChanged, txtTenkhach.TextChanged

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        arrKhachhang.Clear()
        If txtMakhach.Text = "" Then
            MessageBox.Show("Chưa nhập tên mã khách hàng. Vui lòng nhập mã khách hàng")
        End If
        If txtTenkhach.Text = "" Then
            MessageBox.Show("Chưa nhập tên khách hàng. Vui lòng nhập tên khách hàng")
        End If
        If txtDiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ. Vui lòng nhập địa chỉ")
        End If
        If txtSdt.Text = "" Then
            MessageBox.Show("Chưa nhập số điện thoại")
        End If
        If cbbThanhvien.Text = "" Then
            MessageBox.Show("Chưa chọn thành viên. Vui lòng chọn thành viên")
        End If
        Try
            If txtSdt.Text >= 0 And txtMakhach.Text <> "" And txtTenkhach.Text <> "" And txtDiachi.Text <> "" And txtSdt.Text <> "" And cbbThanhvien.Text <> "" Then
                Dim soDonghiencotronglistview As Integer = frmDanhmuckhachhang.lsvKhachhang.Items.Count

                Dim item As ListViewItem = New ListViewItem(soDonghiencotronglistview + 1)

                item.SubItems.Add(txtMakhach.Text)
                item.SubItems.Add(txtTenkhach.Text)
                item.SubItems.Add(txtDiachi.Text)
                item.SubItems.Add(txtSdt.Text)
                item.SubItems.Add(cbbThanhvien.Text)
                item.SubItems.Add(txtGhichu.Text)
                frmDanhmuckhachhang.lsvKhachhang.Items.Add(item)
                GhiVaoFileText()
                Docfilekhachhang()
            End If
        Catch ex As Exception
            MessageBox.Show("Số điện thoại chỉ nhập số không được nhập chữ")
        End Try
    End Sub

    Public Sub ThemKhachHangVaoListView(makhach As String, tenkhach As String, diachi As String, sdt As String, thanhvien As String, ghichu As String)

        Dim soTT = frmDanhmuckhachhang.lsvKhachhang.Items.Count + 1
        Dim item = New ListViewItem(soTT)
        item.SubItems.Add(makhach)
        item.SubItems.Add(tenkhach)
        item.SubItems.Add(diachi)
        item.SubItems.Add(sdt)
        item.SubItems.Add(thanhvien)
        item.SubItems.Add(ghichu)

        frmDanhmuckhachhang.lsvKhachhang.Items.Add(item)
    End Sub
    Public Sub GhiVaoFileText()
        Dim wirter As New StreamWriter("FileKhachHang.txt", True)

        wirter.WriteLine(txtMakhach.Text & "^" & txtTenkhach.Text & "^" & txtDiachi.Text & "^" & txtSdt.Text & "^" & cbbThanhvien.Text & "^" & txtGhichu.Text)

        wirter.Close()
    End Sub
    Public Sub Docfilekhachhang()
        frmDanhmuckhachhang.lsvKhachhang.Items.Clear()
        Dim reader As New StreamReader("FileKhachHang.txt")
        Do Until reader.EndOfStream
            Dim mangTT(5) As String
            Dim noiDungmotdong As String
            noiDungmotdong = reader.ReadLine()
            mangTT = Split(noiDungmotdong, "^")

            ThemKhachHangVaoListView(mangTT(0), mangTT(1), mangTT(2), mangTT(3), mangTT(4), mangTT(5))
        Loop
        reader.Close()
    End Sub

    Private Sub bltThoat_Click(sender As Object, e As EventArgs) Handles bltThoat.Click
        Close()
    End Sub
    Public Sub SuaKhachHang()
        arrKhachhang.Clear()
        Dim lstCount As Integer = frmDanhmuckhachhang.lsvKhachhang.SelectedIndices.Count
        If (lstCount = 1) Then
            Dim reader As New StreamReader("FileKhachHang.txt")
            Do Until reader.EndOfStream
                arrKhachhang.Add(reader.ReadLine())
            Loop
            arrKhachhang.RemoveAt(frmDanhmuckhachhang.lsvKhachhang.SelectedIndices(0))
            arrKhachhang.Insert(frmDanhmuckhachhang.lsvKhachhang.SelectedIndices(0), txtMakhach.Text & "^" & txtTenkhach.Text & "^" & txtDiachi.Text & "^" & txtSdt.Text & "^" & cbbThanhvien.Text & "^" & txtGhichu.Text)
            reader.Close()
            Dim writer As New StreamWriter("FileKhachHang.txt", False)
            For Each arr In arrKhachhang
                writer.WriteLine(arr)
            Next
            writer.Close()
            Docfilekhachhang()
        Else
            MessageBox.Show("Chỉ được sửa 1 dòng tại 1 thời điểm")
        End If
    End Sub

    Private Sub frmThemmoikhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMakhach.Text = "" Then
            MessageBox.Show("Chưa nhập tên mã khách hàng. Vui lòng nhập mã khách hàng")
        End If
        If txtTenkhach.Text = "" Then
            MessageBox.Show("Chưa nhập tên khách hàng. Vui lòng nhập tên khách hàng")
        End If
        If txtDiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ. Vui lòng nhập địa chỉ")
        End If
        If txtSdt.Text = "" Then
            MessageBox.Show("Chưa nhập số điện thoại")
        End If
        If cbbThanhvien.Text = "" Then
            MessageBox.Show("Chưa chọn thành viên. Vui lòng chọn thành viên")
        End If
        Try
            If txtSdt.Text >= 0 And txtMakhach.Text <> "" And txtTenkhach.Text <> "" And txtDiachi.Text <> "" And txtSdt.Text <> "" And cbbThanhvien.Text <> "" Then
                If (frmDanhmuckhachhang.lsvKhachhang.SelectedIndices.Count = 1) Then
                    Dim vitriDuocchon As Integer = frmDanhmuckhachhang.lsvKhachhang.SelectedIndices(0)
                    frmDanhmuckhachhang.lsvKhachhang.Items(vitriDuocchon).SubItems(1).Text = txtMakhach.Text
                    frmDanhmuckhachhang.lsvKhachhang.Items(vitriDuocchon).SubItems(2).Text = txtTenkhach.Text
                    frmDanhmuckhachhang.lsvKhachhang.Items(vitriDuocchon).SubItems(3).Text = txtDiachi.Text
                    frmDanhmuckhachhang.lsvKhachhang.Items(vitriDuocchon).SubItems(4).Text = txtSdt.Text
                    frmDanhmuckhachhang.lsvKhachhang.Items(vitriDuocchon).SubItems(5).Text = cbbThanhvien.Text
                    frmDanhmuckhachhang.lsvKhachhang.Items(vitriDuocchon).SubItems(6).Text = txtGhichu.Text
                    SuaKhachHang()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Số điện thoại chỉ nhập số không được nhập chữ")
        End Try
        Close()
    End Sub
End Class