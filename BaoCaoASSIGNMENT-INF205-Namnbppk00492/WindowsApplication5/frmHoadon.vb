Public Class frmHoadon
    Dim sqlConnect As New Class1
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub LoadSanpham()
        lsvHoadon.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * From HoaDon")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(lsvHoadon.Items.Count + 1)

            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))


            lsvHoadon.Items.Add(item)
        Next
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        If txtMahoadon.Text = "" Then
            MessageBox.Show("Chưa nhập mã sản phẩm.Yêu cầu nhập mã sản phẩm")
        End If
        If txtMakhachhang.Text = "" Then
            MessageBox.Show("Chưa nhập mã khách hàng.Yêu cầu nhập mã khách hàng")
        End If
        If txtTongtien.Text = "" Then
            MessageBox.Show("Chưa có thông tin tổng tiền.Yêu cầu nhập tổng tiền")
        End If
        If txtNgayhoadon.Text = "" Then
            MessageBox.Show("Chưa nhập ngày. Yêu cầu nhập ngày")
        End If
        Try
            If txtMahoadon.Text >= 0 And txtMakhachhang.Text >= 0 And txtTongtien.Text <> "" And txtNgayhoadon.Text <> "" Then
                Dim soDonghiencotronglistview As Integer = lsvHoadon.Items.Count

                Dim item As ListViewItem = New ListViewItem(soDonghiencotronglistview + 1)
                sqlConnect.ExecuteNoneQuery("Insert into HoaDon(MaHoaDon,MaKhachHang,NgayLap,TongTien) values( " + txtMahoadon.Text + "," + txtMakhachhang.Text + ",N'" + txtNgayhoadon.Text + "'," + txtTongtien.Text + ")")
                LoadSanpham()
            End If
        Catch ex As Exception
            MessageBox.Show("Tổng tiền chỉ nhập số tiền vào không được nhập chữ")
        End Try
    End Sub

    Private Sub frmHoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSanpham()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        If txtMahoadon.Text = "" Then
            MessageBox.Show("Chưa nhập mã sản phẩm.Yêu cầu nhập mã sản phẩm")
        End If
        If txtMakhachhang.Text = "" Then
            MessageBox.Show("Chưa nhập mã khách hàng.Yêu cầu nhập mã khách hàng")
        End If
        If txtTongtien.Text = "" Then
            MessageBox.Show("Chưa có thông tin tổng tiền.Yêu cầu nhập tổng tiền")
        End If
        If txtNgayhoadon.Text = "" Then
            MessageBox.Show("Chưa nhập ngày. Yêu cầu nhập ngày")
        End If
        Try
            If txtMahoadon.Text >= 0 And txtMakhachhang.Text >= 0 And txtTongtien.Text <> "" And txtNgayhoadon.Text <> "" Then
                If (lsvHoadon.SelectedIndices.Count = 1) Then
                    For i As Integer = lsvHoadon.SelectedIndices.Count - 1 To 0 Step -1
                        Dim vitricanxoa As Integer = lsvHoadon.SelectedIndices(i)
                        Dim maSPcanxoa As String = lsvHoadon.Items(vitricanxoa).SubItems(1).Text
                        sqlConnect.ExecuteNoneQuery("update HoaDon set MaKhachHang=" & txtMakhachhang.Text & ",NgayLap=N'" & txtNgayhoadon.Text & "',TongTien=" & txtTongtien.Text & " where MaHoaDon=" & txtMahoadon.Text & "")
                    Next
                    LoadSanpham()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Giá bán chỉ nhập số tiền vào không được nhập chữ")
        End Try
    End Sub

    Private Sub lsvHoadon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvHoadon.SelectedIndexChanged
        If lsvHoadon.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In lsvHoadon.SelectedItems
                txtMahoadon.Text = List.SubItems(1).Text
                txtMakhachhang.Text = List.SubItems(2).Text
                txtNgayhoadon.Text = List.SubItems(3).Text
                txtTongtien.Text = List.SubItems(4).Text
            Next
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ThongBao As DialogResult
        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            If ThongBao = Windows.Forms.DialogResult.Yes Then
                For i As Integer = lsvHoadon.SelectedIndices.Count - 1 To 0 Step -1
                    Dim vitricanxoa As Integer = lsvHoadon.SelectedIndices(i)
                    Dim maHDcanxoa As String = lsvHoadon.Items(vitricanxoa).SubItems(1).Text
                    sqlConnect.ExecuteNoneQuery("Delete from HoaDon where MaHoaDon = " + maHDcanxoa)
                Next
                LoadSanpham()
            End If
        End If
    End Sub

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