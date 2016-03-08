Imports System.IO
Public Class frmThemmoinhanvien
    Dim arrNhanvien As New ArrayList
    Private Sub frmThemmoinhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbbAnh_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Public Sub ThemMoiNhanVienVaoListView(nhanvien As String, luongca As String, calamviec As String)

        Dim soTT = frmNhanvien.lsvNhanvien.Items.Count + 1
        Dim item = New ListViewItem(soTT)
        item.SubItems.Add(nhanvien)
        item.SubItems.Add(luongca)
        item.SubItems.Add(calamviec)
        frmNhanvien.lsvNhanvien.Items.Add(item)

    End Sub
    Public Sub GhiVaoFileText()
        Dim wirter As New StreamWriter("FileNhanVien.txt", True)

        wirter.WriteLine(txtNhanvien.Text & "^" & txtLuongca.Text & "^" & cbbCalamviec.Text)

        wirter.Close()
    End Sub
    Public Sub Docfile()
        frmNhanvien.lsvNhanvien.Items.Clear()

        Dim reader As New StreamReader("FileNhanVien.txt")

        Do Until reader.EndOfStream
            Dim mangTT(2) As String
            Dim noiDungmotdong As String

            noiDungmotdong = reader.ReadLine()

            mangTT = Split(noiDungmotdong, "^")

            ThemMoiNhanVienVaoListView(mangTT(0), mangTT(1), mangTT(2))

        Loop
        reader.Close()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        arrNhanvien.Clear()
        If txtNhanvien.Text = "" Then
            MessageBox.Show("Chưa nhập tên nhân viên. Vui lòng nhập tên")
        End If
        If txtLuongca.Text = "" Then
            MessageBox.Show("Chưa nhập lương. Vui lòng nhập lương")
        End If
        If cbbCalamviec.Text = "" Then
            MessageBox.Show("Chưa chọn ca làm việc. Vui lòng chọn ca làm việc")
        End If
        Try
            If txtLuongca.Text >= 0 And txtNhanvien.Text <> "" And cbbCalamviec.Text <> "" Then
                Dim soDonghiencotronglistview As Integer = frmNhanvien.lsvNhanvien.Items.Count

                Dim item As ListViewItem = New ListViewItem(soDonghiencotronglistview + 1)

                item.SubItems.Add(txtNhanvien.Text)
                item.SubItems.Add(txtLuongca.Text)
                item.SubItems.Add(cbbCalamviec.Text)
                frmNhanvien.lsvNhanvien.Items.Add(item)
                GhiVaoFileText()
                Docfile()
            End If
        Catch ex As Exception
            MessageBox.Show("Lương chỉ nhập số không nhập chữ")
        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub
End Class