Imports System.IO
Public Class frmDanhmucmathang
    Dim arrMathang As New ArrayList
    Dim sqlConnect As New Class1
    Private Sub ThêmMớiToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub frmDanhmucmathang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSanpham()
    End Sub

    Private Sub menuSua_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lsvMathang_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub LoadSanpham()
        lsvMathang.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * From SanPham")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(lsvMathang.Items.Count + 1)

            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            item.SubItems.Add(dt.Rows(i).ItemArray(4))
            item.SubItems.Add(dt.Rows(i).ItemArray(5))


            lsvMathang.Items.Add(item)
        Next
    End Sub

    Public Sub XoaSPTrongListview()
        Dim ThongBao As DialogResult

        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            For i As Integer = lsvMathang.SelectedIndices.Count - 1 To 0 Step -1
                lsvMathang.Items.RemoveAt(lsvMathang.SelectedIndices(i))
            Next
        End If
    End Sub

    Private Sub grbMathang_Enter(sender As Object, e As EventArgs) Handles grbMathang.Enter

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ThongBao As DialogResult
        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            If ThongBao = Windows.Forms.DialogResult.Yes Then
                For i As Integer = lsvMathang.SelectedIndices.Count - 1 To 0 Step -1
                    Dim vitricanxoa As Integer = lsvMathang.SelectedIndices(i)
                    Dim maSPcanxoa As String = lsvMathang.Items(vitricanxoa).SubItems(1).Text
                    sqlConnect.ExecuteNoneQuery("Delete from SanPham where MaSanPham = " + maSPcanxoa)
                Next
                LoadSanpham()
            End If
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        arrMathang.Clear()
        If txtMamon.Text = "" Then
            MessageBox.Show("Chưa nhập mã sản phẩm.Yêu cầu nhập mã sản phẩm")
        End If
        If txtTenmon.Text = "" Then
            MessageBox.Show("Chưa nhập tên món.Yêu cầu nhập tên món")
        End If
        If txtGia.Text = "" Then
            MessageBox.Show("Chưa có thông tin giá bán.Yêu cầu nhập giá bán")
        End If
        If cbbDonvi.Text = "" Then
            MessageBox.Show("Chưa lựa chọn đơn vị")
        End If
        If cbbTinhtrang.Text = "" Then
            MessageBox.Show("Chưa có thông tin tình trạng. Yêu cầu nhập tình trạng sản phẩm")
        End If
        If cbbMaloaimon.Text = "" Then
            MessageBox.Show("Chưa chọn mã loại món. Yêu cầu chọn mã loại món")
        End If
        Try
            If txtGia.Text >= 0 And txtTenmon.Text <> "" And cbbDonvi.Text <> "" And cbbMaloaimon.Text <> "" And txtMamon.Text >= 0 And txtMamon.Text <> "" Then
                Dim soDonghiencotronglistview As Integer = lsvMathang.Items.Count

                Dim item As ListViewItem = New ListViewItem(soDonghiencotronglistview + 1)
                sqlConnect.ExecuteNoneQuery("Insert into SanPham(MaSanPham,TenSanPham,Gia,DonVi,TinhTrang,MaLoaiSanPham) values( " + txtMamon.Text + ",N'" + txtTenmon.Text + "'," + txtGia.Text + ",N'" + cbbDonvi.Text + "',N'" + cbbTinhtrang.Text + "'," + cbbMaloaimon.Text + ")")
                LoadSanpham()
            End If
        Catch ex As Exception
            MessageBox.Show("Giá bán chỉ nhập số tiền vào không được nhập chữ")
        End Try
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        If txtMamon.Text = "" Then
            MessageBox.Show("Chưa nhập tên mã sản phẩm.Yêu cầu nhập mã sản phẩm")
        End If
        If cbbDonvi.Text = "" Then
            MessageBox.Show("Chưa chọn đơn vị tính.Yêu cầu chọn đơn vị tính")
        End If
        If txtGia.Text = "" Then
            MessageBox.Show("Chưa có thông tin giá bán.Yêu cầu nhập giá bán")
        End If
        If cbbMaloaimon.Text = "" Then
            MessageBox.Show("Chưa lựa chọn nhóm hàng")
        End If
        If cbbTinhtrang.Text = "" Then
            MessageBox.Show("Chưa có thông tin tình trạng. Yêu cầu tình trạng")
        End If
        Try
            If txtGia.Text >= 0 And txtMamon.Text >= 0 And txtTenmon.Text <> "" And cbbDonvi.Text <> "" And cbbMaloaimon.Text <> "" And cbbTinhtrang.Text <> "" Then
                If (lsvMathang.SelectedIndices.Count = 1) Then
                    For i As Integer = lsvMathang.SelectedIndices.Count - 1 To 0 Step -1
                        Dim vitricanxoa As Integer = lsvMathang.SelectedIndices(i)
                        Dim maSPcanxoa As String = lsvMathang.Items(vitricanxoa).SubItems(1).Text
                        sqlConnect.ExecuteNoneQuery("update SanPham set TenSanPham=N'" & txtTenmon.Text & "', Gia=" & txtGia.Text & ",DonVi=N'" & cbbDonvi.Text & "',TinhTrang=N'" & cbbTinhtrang.Text & "'  where MaSanPham=" & txtMamon.Text & "")
                    Next
                    LoadSanpham()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Giá bán chỉ nhập số tiền vào không được nhập chữ")
        End Try
    End Sub

    Private Sub lsvMathang_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lsvMathang.SelectedIndexChanged
        If lsvMathang.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In lsvMathang.SelectedItems
                txtMamon.Text = List.SubItems(1).Text
                txtTenmon.Text = List.SubItems(2).Text
                txtGia.Text = List.SubItems(3).Text
                cbbDonvi.Text = List.SubItems(4).Text
                cbbTinhtrang.Text = List.SubItems(5).Text
                cbbMaloaimon.Text = List.SubItems(6).Text
            Next
        End If
    End Sub

    Private Sub lblGia_Click(sender As Object, e As EventArgs) Handles lblGia.Click

    End Sub

    Private Sub txtTenmon_TextChanged(sender As Object, e As EventArgs) Handles txtTenmon.TextChanged

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