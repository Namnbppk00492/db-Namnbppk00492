Imports System.IO
Public Class frmThemmoinhacungcap
    Dim arrNhacungcap As New ArrayList
    Private Sub frmThemmoinhacungcap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub ThemNhaCungCapVaoListView(manhacungcap As String, diachi As String, sodienthoai As String, email As String)

        Dim soTT = frmDanhmucnhacungcap.lsvNhacungcap.Items.Count + 1
        Dim item = New ListViewItem(soTT)
        item.SubItems.Add(manhacungcap)
        item.SubItems.Add(diachi)
        item.SubItems.Add(sodienthoai)
        item.SubItems.Add(email)
        
        frmDanhmucnhacungcap.lsvNhacungcap.Items.Add(item)
    End Sub
    Public Sub GhiVaoFileText()
        Dim wirter As New StreamWriter("FileNhaCungCap.txt", True)
        wirter.WriteLine(txtManhacungcap.Text & "^" & txtDiachi.Text & "^" & txtSdt.Text & "^" & txtEmail.Text)
        wirter.Close()
    End Sub
    Public Sub Docfile()
        frmDanhmucnhacungcap.lsvNhacungcap.Items.Clear()
        Dim reader As New StreamReader("FileNhaCungCap.txt")
        Do Until reader.EndOfStream
            Dim mangTT(3) As String
            Dim noiDungmotdong As String
            noiDungmotdong = reader.ReadLine()
            mangTT = Split(noiDungmotdong, "^")
            ThemNhaCungCapVaoListView(mangTT(0), mangTT(1), mangTT(2), mangTT(3))
        Loop
        reader.Close()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        arrNhacungcap.Clear()
        If txtManhacungcap.Text = "" Then
            MessageBox.Show("Chưa nhập mã nhà cung cấp. Vui lòng nhập mã nhà cung cấp")
        End If
        If txtDiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ. Vui lòng nhập địa chỉ")
        End If
        If txtSdt.Text = "" Then
            MessageBox.Show("Chưa nhập số điện thoại. Vui lòng nhập số điện thoại")
        End If
        If txtEmail.Text = "" Then
            MessageBox.Show("Chưa nhập email vào. Vui lòng nhập email vào")
        End If
        Try
            If txtSdt.Text >= 0 And txtManhacungcap.Text <> "" And txtDiachi.Text <> "" And txtSdt.Text <> "" And txtEmail.Text <> "" Then
                Dim soDonghiencotronglistview As Integer = frmDanhmucnhacungcap.lsvNhacungcap.Items.Count

                Dim item As ListViewItem = New ListViewItem(soDonghiencotronglistview + 1)

                item.SubItems.Add(txtManhacungcap.Text)
                item.SubItems.Add(txtDiachi.Text)
                item.SubItems.Add(txtSdt.Text)
                item.SubItems.Add(txtEmail.Text)
                frmDanhmucnhacungcap.lsvNhacungcap.Items.Add(item)
                GhiVaoFileText()
                Docfile()
            End If
        Catch ex As Exception
            MessageBox.Show("Số điện thoại chỉ nhập số không nhập chữ")
        End Try
    End Sub
    Public Sub Suanhacungcap()
        arrNhacungcap.Clear()
        Dim lstCount As Integer = frmDanhmucnhacungcap.lsvNhacungcap.SelectedIndices.Count
        If (lstCount = 1) Then
            Dim reader As New StreamReader("FileNhaCungCap.txt")
            Do Until reader.EndOfStream
                arrNhacungcap.Add(reader.ReadLine())
            Loop
            arrNhacungcap.RemoveAt(frmDanhmucnhacungcap.lsvNhacungcap.SelectedIndices(0))
            arrNhacungcap.Insert(frmDanhmucnhacungcap.lsvNhacungcap.SelectedIndices(0), txtManhacungcap.Text & "^" & txtDiachi.Text & "^" & txtSdt.Text & "^" & txtEmail.Text)
            reader.Close()
            Dim writer As New StreamWriter("FileNhaCungCap.txt", False)
            For Each arr In arrNhacungcap
                writer.WriteLine(arr)
            Next
            writer.Close()
            Docfile()
        Else
            MessageBox.Show("Chỉ được sửa 1 dòng tại 1 thời điểm")
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtManhacungcap.Text = "" Then
            MessageBox.Show("Chưa nhập mã nhà cung cấp. Vui lòng nhập mã nhà cung cấp")
        End If
        If txtDiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ. Vui lòng nhập địa chỉ")
        End If
        If txtSdt.Text = "" Then
            MessageBox.Show("Chưa nhập số điện thoại. Vui lòng nhập số điện thoại")
        End If
        If txtEmail.Text = "" Then
            MessageBox.Show("Chưa nhập email vào. Vui lòng nhập email vào")
        End If
        Try
            If txtSdt.Text >= 0 And txtManhacungcap.Text <> "" And txtDiachi.Text <> "" And txtSdt.Text <> "" And txtEmail.Text <> "" Then
                If (frmDanhmucnhacungcap.lsvNhacungcap.SelectedIndices.Count = 1) Then
                    Dim vitriDuocchon As Integer = frmDanhmucnhacungcap.lsvNhacungcap.SelectedIndices(0)
                    frmDanhmucnhacungcap.lsvNhacungcap.Items(vitriDuocchon).SubItems(1).Text = txtManhacungcap.Text
                    frmDanhmucnhacungcap.lsvNhacungcap.Items(vitriDuocchon).SubItems(2).Text = txtDiachi.Text
                    frmDanhmucnhacungcap.lsvNhacungcap.Items(vitriDuocchon).SubItems(3).Text = txtSdt.Text
                    frmDanhmucnhacungcap.lsvNhacungcap.Items(vitriDuocchon).SubItems(4).Text = txtEmail.Text
                    Suanhacungcap()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Số điện thoại chỉ được nhập số không được nhập chữ")
        End Try
        Close()
    End Sub
End Class