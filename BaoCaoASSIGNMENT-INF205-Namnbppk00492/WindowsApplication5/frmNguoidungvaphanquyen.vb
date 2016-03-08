Imports System.IO
Public Class frmNguoidungvaphanquyen
    Dim arrTaikhoan As New ArrayList
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvNguoidungvaphanquyen.SelectedIndexChanged
        If (lsvNguoidungvaphanquyen.SelectedIndices.Count > 0) Then
            Dim vitriDuocchon As Integer = lsvNguoidungvaphanquyen.SelectedIndices(0)
            frmThemnguoidung.txtTaikhoan.Text = lsvNguoidungvaphanquyen.Items(vitriDuocchon).SubItems(1).Text
            frmThemnguoidung.txtMatkhau.Text = lsvNguoidungvaphanquyen.Items(vitriDuocchon).SubItems(2).Text
            frmThemnguoidung.cbbNhomnguoidung.Text = lsvNguoidungvaphanquyen.Items(vitriDuocchon).SubItems(3).Text
        End If
    End Sub

    Private Sub menuThem_Click(sender As Object, e As EventArgs) Handles menuThem.Click
        frmThemnguoidung.ShowDialog()
    End Sub

    Private Sub frmNguoidungvaphanquyen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmThemnguoidung.Docfile()
    End Sub
    Private Sub XoaTaiKhoan()
        arrTaikhoan.Clear()

        Dim lstCount As Integer = lsvNguoidungvaphanquyen.SelectedIndices.Count

        If (lstCount <= 0) Then
            MessageBox.Show("Chưa chọn dòng để xóa")
        Else
            Dim reader As New StreamReader("FileDangNhap.txt")
            Do Until reader.EndOfStream
                arrTaikhoan.Add(reader.ReadLine())
            Loop
            For i As Integer = lstCount - 1 To 0 Step -1
                arrTaikhoan.RemoveAt(lsvNguoidungvaphanquyen.SelectedIndices(i))
            Next
            reader.Close()

            Dim writer As New StreamWriter("FileDangNhap.txt", False)
            For Each arr In arrTaikhoan
                writer.WriteLine(arr)
            Next
            writer.Close()
            frmThemnguoidung.Docfile()
        End If
    End Sub

    Private Sub menuXoa_Click(sender As Object, e As EventArgs) Handles menuXoa.Click
        Dim ThongBao As DialogResult
        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            If ThongBao = Windows.Forms.DialogResult.Yes Then
                XoaTaiKhoan()
            End If
        End If
    End Sub
End Class