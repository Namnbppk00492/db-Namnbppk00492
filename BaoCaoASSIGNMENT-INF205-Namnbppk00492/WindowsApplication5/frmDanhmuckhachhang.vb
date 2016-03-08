Imports System.IO
Public Class frmDanhmuckhachhang
    Dim arrKhachhang As New ArrayList
    Dim sqlConnect As New Class1
    Private Sub menuThemmoi_Click(sender As Object, e As EventArgs)
        frmThemmoikhachhang.ShowDialog()
    End Sub

    Private Sub menuChinhsua_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lsvKhachhang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvKhachhang.SelectedIndexChanged
        If lsvKhachhang.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In lsvKhachhang.SelectedItems
                txtMakhachang.Text = List.SubItems(1).Text
                txtTenkhachang.Text = List.SubItems(2).Text
                txtCMND.Text = List.SubItems(3).Text
                cbbGioitinh.Text = List.SubItems(4).Text
                txtDienthoai.Text = List.SubItems(5).Text
                txtDiachi.Text = List.SubItems(6).Text
            Next
        End If
    End Sub

    Private Sub frmDanhmuckhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSanpham()
    End Sub
    Private Sub LoadSanpham()
        lsvKhachhang.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * From KhachHang")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(lsvKhachhang.Items.Count + 1)

            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            item.SubItems.Add(dt.Rows(i).ItemArray(4))
            item.SubItems.Add(dt.Rows(i).ItemArray(5))


            lsvKhachhang.Items.Add(item)
        Next
    End Sub
    Public Sub XoaSPTrongListview()
        Dim ThongBao As DialogResult

        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            For i As Integer = lsvKhachhang.SelectedIndices.Count - 1 To 0 Step -1
                lsvKhachhang.Items.RemoveAt(lsvKhachhang.SelectedIndices(i))
            Next
        End If
    End Sub

    Private Sub menuXoa_Click(sender As Object, e As EventArgs)
        Dim ThongBao As DialogResult
        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            If ThongBao = Windows.Forms.DialogResult.Yes Then

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        arrKhachhang.Clear()
        If txtMakhachang.Text = "" Then
            MessageBox.Show("Chưa nhập tên mã khách hàng. Vui lòng nhập mã khách hàng")
        End If
        If txtTenkhachang.Text = "" Then
            MessageBox.Show("Chưa nhập tên khách hàng. Vui lòng nhập tên khách hàng")
        End If
        If txtCMND.Text = "" Then
            MessageBox.Show("Chưa nhập số chứng minh nhân dân. Vui lòng nhập địa chỉ")
        End If
        If cbbGioitinh.Text = "" Then
            MessageBox.Show("Chưa chọn giới tính")
        End If
        If txtDienthoai.Text = "" Then
            MessageBox.Show("Chưa nhập số điện thoại. Vui lòng nhập số điện thoại")
        End If
        If txtDiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ. Vui lòng nhập địa chỉ")
        End If
        Try
            If txtDienthoai.Text >= 0 And txtMakhachang.Text >= "" And txtTenkhachang.Text <> "" And txtDiachi.Text <> "" And txtDienthoai.Text <> "" And cbbGioitinh.Text <> "" Then
                Dim soDonghiencotronglistview As Integer = lsvKhachhang.Items.Count

                Dim item As ListViewItem = New ListViewItem(soDonghiencotronglistview + 1)
                sqlConnect.ExecuteNoneQuery("Insert into KhachHang(MaKhachHang,TenKhachHang,CMND,GioiTinh,DienThoai,DiaChi) values( " + txtMakhachang.Text + ",N'" + txtTenkhachang.Text + "'," + txtCMND.Text + ",N'" + cbbGioitinh.Text + "'," + txtDienthoai.Text + ",N'" + txtDiachi.Text + "')")
                LoadSanpham()
            End If
        Catch ex As Exception
            MessageBox.Show("Số điện thoại chỉ nhập số không được nhập chữ")
        End Try
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        If txtMakhachang.Text = "" Then
            MessageBox.Show("Chưa nhập tên mã khách hàng. Vui lòng nhập mã khách hàng")
        End If
        If txtTenkhachang.Text = "" Then
            MessageBox.Show("Chưa nhập tên khách hàng. Vui lòng nhập tên khách hàng")
        End If
        If txtDiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ. Vui lòng nhập địa chỉ")
        End If
        If txtDienthoai.Text = "" Then
            MessageBox.Show("Chưa nhập số điện thoại")
        End If
        If cbbGioitinh.Text = "" Then
            MessageBox.Show("Chưa chọn giới tính. Vui lòng chọn giới tính")
        End If
        Try
            If txtDienthoai.Text >= 0 And txtMakhachang.Text <> "" And txtTenkhachang.Text <> "" And txtDiachi.Text <> "" And txtDienthoai.Text <> "" And cbbGioitinh.Text <> "" Then
                If (lsvKhachhang.SelectedIndices.Count = 1) Then
                    For i As Integer = lsvKhachhang.SelectedIndices.Count - 1 To 0 Step -1
                        Dim vitricanxoa As Integer = lsvKhachhang.SelectedIndices(i)
                        Dim maSPcanxoa As String = lsvKhachhang.Items(vitricanxoa).SubItems(1).Text
                        sqlConnect.ExecuteNoneQuery("update KhachHang set TenKhachHang=N'" & txtTenkhachang.Text & "', CMND=" & txtCMND.Text & ",GioiTinh=N'" & cbbGioitinh.Text & "',DienThoai=" & txtDienthoai.Text & ",DiaChi=N'" & txtDiachi.Text & "' where MaKhachHang=" & txtMakhachang.Text & "")
                    Next
                    LoadSanpham()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Số điện thoại chỉ nhập số không được nhập chữ")
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ThongBao As DialogResult
        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            If ThongBao = Windows.Forms.DialogResult.Yes Then
                For i As Integer = lsvKhachhang.SelectedIndices.Count - 1 To 0 Step -1
                    Dim vitricanxoa As Integer = lsvKhachhang.SelectedIndices(i)
                    Dim maKHcanxoa As String = lsvKhachhang.Items(vitricanxoa).SubItems(1).Text
                    sqlConnect.ExecuteNoneQuery("Delete from KhachHang where MaKhachHang = " + maKHcanxoa)
                Next
                LoadSanpham()
            End If
        End If
    End Sub
    Dim kiemTradangnhap As Boolean = False
    Private Sub frmDanhmuckhachhang_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn Chắc Chắn Muốn Thoát Chương Trình ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Thông Báo") = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub
End Class