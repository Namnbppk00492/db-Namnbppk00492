Public Class frmChitiethoadon
    Dim sqlConnect As New Class1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        If txtMachitiethd.Text = "" Then
            MessageBox.Show("Chưa nhập mã hóa đơn.Yêu cầu nhập mã chi tiết hóa đơn")
        End If
        If txtMahoadon.Text = "" Then
            MessageBox.Show("Chưa nhập mã hóa đơn.Yêu cầu nhập mã hóa đơn")
        End If
        If txtMasanpham.Text = "" Then
            MessageBox.Show("Chưa nhập mã sản phẩm.Yêu cầu nhập mã sản phẩm")
        End If
        If txtSoluong.Text = "" Then
            MessageBox.Show("Chưa nhập số lượng. Yêu cầu nhập số lượng")
        End If
        If txtThanhtien.Text = "" Then
            MessageBox.Show("Chưa nhập tiền. Yêu cầu tiền")
        End If
        Try
            If txtThanhtien.Text >= 0 And txtMachitiethd.Text >= 0 And txtMahoadon.Text >= 0 And txtMasanpham.Text >= 0 And txtSoluong.Text >= 0 Then
                If (lsvCThoadon.SelectedIndices.Count = 1) Then
                    For i As Integer = lsvCThoadon.SelectedIndices.Count - 1 To 0 Step -1
                        Dim vitricanxoa As Integer = lsvCThoadon.SelectedIndices(i)
                        Dim maSPcanxoa As String = lsvCThoadon.Items(vitricanxoa).SubItems(1).Text
                        sqlConnect.ExecuteNoneQuery("update ChiTietHoaDon set MaHoaDon=" & txtMahoadon.Text & ", MaSanPham=" & txtMasanpham.Text & ",SoLuong=" & txtSoluong.Text & ",ThanhTien=" & txtThanhtien.Text & "  where MaCTHD=" & txtMachitiethd.Text & "")
                    Next
                    LoadSanpham()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Thành tiền chỉ nhập số tiền vào không được nhập chữ")
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvCThoadon.SelectedIndexChanged
        If lsvCThoadon.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In lsvCThoadon.SelectedItems
                txtMachitiethd.Text = List.SubItems(1).Text
                txtMahoadon.Text = List.SubItems(2).Text
                txtMasanpham.Text = List.SubItems(3).Text
                txtSoluong.Text = List.SubItems(4).Text
                txtThanhtien.Text = List.SubItems(5).Text

            Next
        End If
    End Sub

    Private Sub frmChitiethoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSanpham()
    End Sub
    Private Sub LoadSanpham()
        lsvCThoadon.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * From ChiTietHoaDon")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(lsvCThoadon.Items.Count + 1)

            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            item.SubItems.Add(dt.Rows(i).ItemArray(4))


            lsvCThoadon.Items.Add(item)
        Next
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        If txtMachitiethd.Text = "" Then
            MessageBox.Show("Chưa nhập mã hóa đơn.Yêu cầu nhập mã chi tiết hóa đơn")
        End If
        If txtMahoadon.Text = "" Then
            MessageBox.Show("Chưa nhập mã hóa đơn.Yêu cầu nhập mã hóa đơn")
        End If
        If txtMasanpham.Text = "" Then
            MessageBox.Show("Chưa nhập mã sản phẩm.Yêu cầu nhập mã sản phẩm")
        End If
        If txtSoluong.Text = "" Then
            MessageBox.Show("Chưa nhập số lượng. Yêu cầu nhập số lượng")
        End If
        If txtThanhtien.Text = "" Then
            MessageBox.Show("Chưa nhập tiền. Yêu cầu tiền")
        End If
        Try
            If txtThanhtien.Text >= 0 And txtMachitiethd.Text >= 0 And txtMahoadon.Text >= 0 And txtMasanpham.Text >= 0 And txtSoluong.Text >= 0 Then
                Dim soDonghiencotronglistview As Integer = lsvCThoadon.Items.Count
                Dim item As ListViewItem = New ListViewItem(soDonghiencotronglistview + 1)
                sqlConnect.ExecuteNoneQuery("Insert into ChiTietHoaDon(MaCTHD,MaHoaDon,MaSanPham,SoLuong,ThanhTien) values( " + txtMachitiethd.Text + "," + txtMahoadon.Text + "," + txtMasanpham.Text + "," + txtSoluong.Text + "," + txtThanhtien.Text + ")")
                LoadSanpham()
            End If
        Catch ex As Exception
            MessageBox.Show("Giá bán chỉ nhập số tiền vào không được nhập chữ")
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ThongBao As DialogResult
        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            If ThongBao = Windows.Forms.DialogResult.Yes Then
                For i As Integer = lsvCThoadon.SelectedIndices.Count - 1 To 0 Step -1
                    Dim vitricanxoa As Integer = lsvCThoadon.SelectedIndices(i)
                    Dim maCTHDcanxoa As String = lsvCThoadon.Items(vitricanxoa).SubItems(1).Text
                    sqlConnect.ExecuteNoneQuery("Delete from ChiTietHoaDon where MaCTHD = " + maCTHDcanxoa)
                Next
                LoadSanpham()
            End If
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub

    Private Sub frmChitiethoadon_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MsgBox("Bạn Chắc Chắn Muốn Thoát Chương Trình ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Thông Báo") = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class