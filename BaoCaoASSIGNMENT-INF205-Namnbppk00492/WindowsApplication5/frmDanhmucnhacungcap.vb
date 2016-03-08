Imports System.IO
Public Class frmDanhmucnhacungcap
    Dim arrNhacungcap As New ArrayList
    Private Sub menuThemmoi_Click(sender As Object, e As EventArgs) Handles menuThemmoi.Click
        frmThemmoinhacungcap.ShowDialog()
    End Sub

    Private Sub frmDanhmucnhacungcap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmThemmoinhacungcap.Docfile()
    End Sub
    Private Sub XoaNhaCungCap()
        arrNhacungcap.Clear()
        Dim lstCount As Integer = lsvNhacungcap.SelectedIndices.Count
        If (lstCount <= 0) Then
            MessageBox.Show("Chưa chọn dòng để xóa")
        Else
            Dim reader As New StreamReader("FileNhaCungCap.txt")
            Do Until reader.EndOfStream
                arrNhacungcap.Add(reader.ReadLine())
            Loop
            For i As Integer = lstCount - 1 To 0 Step -1
                arrNhacungcap.RemoveAt(lsvNhacungcap.SelectedIndices(i))
            Next
            reader.Close()
            Dim writer As New StreamWriter("FileNhaCungCap.txt", False)
            For Each arr In arrNhacungcap
                writer.WriteLine(arr)
            Next
            writer.Close()
            frmThemmoinhacungcap.Docfile()
        End If
    End Sub
    Public Sub XoaNhaCungCapTrongListview()
        Dim ThongBao As DialogResult

        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            For i As Integer = lsvNhacungcap.SelectedIndices.Count - 1 To 0 Step -1
                lsvNhacungcap.Items.RemoveAt(lsvNhacungcap.SelectedIndices(i))
            Next
        End If
    End Sub

    Private Sub menuXoa_Click(sender As Object, e As EventArgs) Handles menuXoa.Click
        Dim ThongBao As DialogResult
        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            If ThongBao = Windows.Forms.DialogResult.Yes Then
                XoaNhaCungCap()
            End If
        End If
    End Sub

    Private Sub lsvNhacungcap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvNhacungcap.SelectedIndexChanged
        If (lsvNhacungcap.SelectedIndices.Count > 0) Then
            Dim vitriDuocchon As Integer = lsvNhacungcap.SelectedIndices(0)
            frmThemmoinhacungcap.txtManhacungcap.Text = lsvNhacungcap.Items(vitriDuocchon).SubItems(1).Text
            frmThemmoinhacungcap.txtDiachi.Text = lsvNhacungcap.Items(vitriDuocchon).SubItems(2).Text
            frmThemmoinhacungcap.txtSdt.Text = lsvNhacungcap.Items(vitriDuocchon).SubItems(3).Text
            frmThemmoinhacungcap.txtEmail.Text = lsvNhacungcap.Items(vitriDuocchon).SubItems(4).Text
            
        End If
    End Sub
End Class