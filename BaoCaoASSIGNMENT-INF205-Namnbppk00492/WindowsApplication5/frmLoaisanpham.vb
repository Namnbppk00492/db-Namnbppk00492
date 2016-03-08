Imports System.IO
Public Class frmLoaisanpham
    Dim arrMathang As New ArrayList
    Dim sqlConnect As New Class1
    Private Sub frmThemmoimathang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSanpham()
    End Sub
    Private Sub LoadSanpham()
        lsvLoaisanpham.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * From LoaiSanPham")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(lsvLoaisanpham.Items.Count + 1)

            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))


            lsvLoaisanpham.Items.Add(item)
        Next
    End Sub
    Public Sub ThemMatHangVaoListView(mathang As String, donvitinh As String, giaban As String, giaban2 As String, giaban3 As String, giaban4 As String, nhomhang As String, gianhap As String)


    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        arrMathang.Clear()
        If txtMaloaisanpham.Text = "" Then
            MessageBox.Show("Chưa nhập mã loại sản phẩm.Yêu cầu nhập mã loại sản phẩm")
        End If
        If txtTenloaisanpham.Text = "" Then
            MessageBox.Show("Chưa nhập tên loại sản phẩm.Yêu cầu tên loại sản phẩm")
        End If
        Try
            If txtMaloaisanpham.Text >= 0 And txtTenloaisanpham.Text <> "" Then
                Dim soDonghiencotronglistview As Integer = frmDanhmucmathang.lsvMathang.Items.Count

                Dim item As ListViewItem = New ListViewItem(soDonghiencotronglistview + 1)
                sqlConnect.ExecuteNoneQuery("Insert into LoaiSanPham(MaLoaiSanPham,TenLoaiSanPham) values( " + txtMaloaisanpham.Text + ",N'" + txtTenloaisanpham.Text + "')")
                LoadSanpham()
            End If
        Catch ex As Exception
            MessageBox.Show("Mã loại sản phẩm chỉ được nhập số không được nhập chữ")
        End Try
    End Sub


    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaloaisanpham.Text = "" Then
            MessageBox.Show("Chưa nhập tên mặt hàng.Yêu cầu nhập tên mặt hàng")
        End If
        If txtTenloaisanpham.Text = "" Then
            MessageBox.Show("Chưa chọn đơn vị tính.Yêu cầu chọn đơn vị tính")
        End If
        Try
            If txtMaloaisanpham.Text >= 0 And txtTenloaisanpham.Text <> "" Then
                For i As Integer = lsvLoaisanpham.SelectedIndices.Count - 1 To 0 Step -1
                    Dim vitricanxoa As Integer = lsvLoaisanpham.SelectedIndices(i)
                    Dim maSPcanxoa As String = lsvLoaisanpham.Items(vitricanxoa).SubItems(1).Text
                    sqlConnect.ExecuteNoneQuery("update LoaiSanPham set TenLoaiSanPham=N'" & txtTenloaisanpham.Text & "' where MaLoaiSanPham=" & txtMaloaisanpham.Text & "")
                Next
                LoadSanpham()
            End If
        Catch ex As Exception
            MessageBox.Show("Mã loại sản phẩm chỉ được nhập số không được nhập chữ")
        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ThongBao As DialogResult
        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            If ThongBao = Windows.Forms.DialogResult.Yes Then
                For i As Integer = lsvLoaisanpham.SelectedIndices.Count - 1 To 0 Step -1
                    Dim vitricanxoa As Integer = lsvLoaisanpham.SelectedIndices(i)
                    Dim maLSPcanxoa As String = lsvLoaisanpham.Items(vitricanxoa).SubItems(1).Text
                    sqlConnect.ExecuteNoneQuery("Delete from LoaiSanPham where MaLoaiSanPham = " + maLSPcanxoa)
                Next
                LoadSanpham()
            End If
        End If
    End Sub

    Private Sub lblMathang_Click(sender As Object, e As EventArgs) Handles lblMaloaisanpham.Click

    End Sub

    Private Sub txtMathang_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbbDonvitinh_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblDonvitinh_Click(sender As Object, e As EventArgs) Handles lblDonvitinh.Click

    End Sub

    Private Sub lblGiaban_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtGiaban_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblGiaban2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtGiaban2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtGiaban4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblGiaban4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbbNhomhang_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblGiaban3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtGiaban3_TextChanged(sender As Object, e As EventArgs) Handles txtMaloaisanpham.TextChanged, txtTenloaisanpham.TextChanged

    End Sub

    Private Sub lblGianhap_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtGianhap_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblNhomhang_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lsvLoaisanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvLoaisanpham.SelectedIndexChanged
        If lsvLoaisanpham.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In lsvLoaisanpham.SelectedItems
                txtMaloaisanpham.Text = List.SubItems(1).Text
                txtTenloaisanpham.Text = List.SubItems(2).Text
            Next
        End If
    End Sub
End Class