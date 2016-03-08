Imports System.IO
Public Class frmNhanvien
    Dim arrNhanvien As New ArrayList
    Private Sub ThêmMớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmMớiToolStripMenuItem.Click
        frmThemmoinhanvien.ShowDialog()
    End Sub

    Private Sub frmNhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmThemmoinhanvien.Docfile()
    End Sub
    Private Sub XoaNhanVien()
        arrNhanvien.Clear()
        Dim lstCount As Integer = lsvNhanvien.SelectedIndices.Count
        If (lstCount <= 0) Then
            MessageBox.Show("Chưa chọn dòng để xóa")
        Else
            Dim reader As New StreamReader("FileNhanVien.txt")
            Do Until reader.EndOfStream
                arrNhanvien.Add(reader.ReadLine())
            Loop
            For i As Integer = lstCount - 1 To 0 Step -1
                arrNhanvien.RemoveAt(lsvNhanvien.SelectedIndices(i))
            Next
            reader.Close()
            Dim writer As New StreamWriter("FileNhanVien.txt", False)
            For Each arr In arrNhanvien
                writer.WriteLine(arr)
            Next
            writer.Close()
            frmThemmoinhanvien.Docfile()
        End If
    End Sub
    Public Sub XoaNhaCungCapTrongListview()
        Dim ThongBao As DialogResult

        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            For i As Integer = lsvNhanvien.SelectedIndices.Count - 1 To 0 Step -1
                lsvNhanvien.Items.RemoveAt(lsvNhanvien.SelectedIndices(i))
            Next
        End If
    End Sub

    Private Sub XóaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XóaToolStripMenuItem.Click
        Dim ThongBao As DialogResult
        ThongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ThongBao = Windows.Forms.DialogResult.Yes Then
            If ThongBao = Windows.Forms.DialogResult.Yes Then
                XoaNhanVien()
            End If
        End If
    End Sub
End Class