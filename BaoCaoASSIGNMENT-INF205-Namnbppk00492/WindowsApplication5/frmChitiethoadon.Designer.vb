<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChitiethoadon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtMachitiethd = New System.Windows.Forms.TextBox()
        Me.txtMahoadon = New System.Windows.Forms.TextBox()
        Me.txtMasanpham = New System.Windows.Forms.TextBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.txtThanhtien = New System.Windows.Forms.TextBox()
        Me.lblMachitiethd = New System.Windows.Forms.Label()
        Me.lblMahoadon = New System.Windows.Forms.Label()
        Me.lblMasanpham = New System.Windows.Forms.Label()
        Me.lblSoluong = New System.Windows.Forms.Label()
        Me.lblThanhtien = New System.Windows.Forms.Label()
        Me.lsvCThoadon = New System.Windows.Forms.ListView()
        Me.clhSTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhMaCTHD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhMahoadon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhMasanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhSoluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhThanhtien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMachitiethd
        '
        Me.txtMachitiethd.Location = New System.Drawing.Point(95, 26)
        Me.txtMachitiethd.Name = "txtMachitiethd"
        Me.txtMachitiethd.Size = New System.Drawing.Size(173, 20)
        Me.txtMachitiethd.TabIndex = 0
        '
        'txtMahoadon
        '
        Me.txtMahoadon.Location = New System.Drawing.Point(95, 71)
        Me.txtMahoadon.Name = "txtMahoadon"
        Me.txtMahoadon.Size = New System.Drawing.Size(173, 20)
        Me.txtMahoadon.TabIndex = 1
        '
        'txtMasanpham
        '
        Me.txtMasanpham.Location = New System.Drawing.Point(95, 132)
        Me.txtMasanpham.Name = "txtMasanpham"
        Me.txtMasanpham.Size = New System.Drawing.Size(173, 20)
        Me.txtMasanpham.TabIndex = 2
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(95, 192)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(173, 20)
        Me.txtSoluong.TabIndex = 3
        '
        'txtThanhtien
        '
        Me.txtThanhtien.Location = New System.Drawing.Point(95, 249)
        Me.txtThanhtien.Name = "txtThanhtien"
        Me.txtThanhtien.Size = New System.Drawing.Size(173, 20)
        Me.txtThanhtien.TabIndex = 4
        '
        'lblMachitiethd
        '
        Me.lblMachitiethd.AutoSize = True
        Me.lblMachitiethd.Location = New System.Drawing.Point(6, 29)
        Me.lblMachitiethd.Name = "lblMachitiethd"
        Me.lblMachitiethd.Size = New System.Drawing.Size(75, 13)
        Me.lblMachitiethd.TabIndex = 1
        Me.lblMachitiethd.Text = "Mã chi tiết HĐ"
        '
        'lblMahoadon
        '
        Me.lblMahoadon.AutoSize = True
        Me.lblMahoadon.Location = New System.Drawing.Point(6, 74)
        Me.lblMahoadon.Name = "lblMahoadon"
        Me.lblMahoadon.Size = New System.Drawing.Size(65, 13)
        Me.lblMahoadon.TabIndex = 1
        Me.lblMahoadon.Text = "Mã hóa đơn"
        '
        'lblMasanpham
        '
        Me.lblMasanpham.AutoSize = True
        Me.lblMasanpham.Location = New System.Drawing.Point(6, 135)
        Me.lblMasanpham.Name = "lblMasanpham"
        Me.lblMasanpham.Size = New System.Drawing.Size(71, 13)
        Me.lblMasanpham.TabIndex = 1
        Me.lblMasanpham.Text = "Mã sản phẩm"
        '
        'lblSoluong
        '
        Me.lblSoluong.AutoSize = True
        Me.lblSoluong.Location = New System.Drawing.Point(6, 195)
        Me.lblSoluong.Name = "lblSoluong"
        Me.lblSoluong.Size = New System.Drawing.Size(49, 13)
        Me.lblSoluong.TabIndex = 1
        Me.lblSoluong.Text = "Số lượng"
        '
        'lblThanhtien
        '
        Me.lblThanhtien.AutoSize = True
        Me.lblThanhtien.Location = New System.Drawing.Point(6, 252)
        Me.lblThanhtien.Name = "lblThanhtien"
        Me.lblThanhtien.Size = New System.Drawing.Size(58, 13)
        Me.lblThanhtien.TabIndex = 1
        Me.lblThanhtien.Text = "Thành tiền"
        '
        'lsvCThoadon
        '
        Me.lsvCThoadon.BackColor = System.Drawing.Color.DarkOrange
        Me.lsvCThoadon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhSTT, Me.clhMaCTHD, Me.clhMahoadon, Me.clhMasanpham, Me.clhSoluong, Me.clhThanhtien})
        Me.lsvCThoadon.FullRowSelect = True
        Me.lsvCThoadon.GridLines = True
        Me.lsvCThoadon.Location = New System.Drawing.Point(301, 19)
        Me.lsvCThoadon.Name = "lsvCThoadon"
        Me.lsvCThoadon.Size = New System.Drawing.Size(460, 250)
        Me.lsvCThoadon.TabIndex = 5
        Me.lsvCThoadon.UseCompatibleStateImageBehavior = False
        Me.lsvCThoadon.View = System.Windows.Forms.View.Details
        '
        'clhSTT
        '
        Me.clhSTT.Text = "STT"
        Me.clhSTT.Width = 37
        '
        'clhMaCTHD
        '
        Me.clhMaCTHD.Text = "Mã CT hóa đơn"
        Me.clhMaCTHD.Width = 105
        '
        'clhMahoadon
        '
        Me.clhMahoadon.Text = "Mã hóa đơn"
        Me.clhMahoadon.Width = 74
        '
        'clhMasanpham
        '
        Me.clhMasanpham.Text = "Mã sản phẩm"
        Me.clhMasanpham.Width = 79
        '
        'clhSoluong
        '
        Me.clhSoluong.Text = "Số lượng"
        Me.clhSoluong.Width = 63
        '
        'clhThanhtien
        '
        Me.clhThanhtien.Text = "Thành tiền"
        Me.clhThanhtien.Width = 98
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.OrangeRed
        Me.btnThem.Location = New System.Drawing.Point(30, 19)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 0
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSua.Location = New System.Drawing.Point(113, 19)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 1
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.OrangeRed
        Me.btnXoa.ForeColor = System.Drawing.Color.Yellow
        Me.btnXoa.Location = New System.Drawing.Point(204, 19)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.OrangeRed
        Me.btnThoat.ForeColor = System.Drawing.Color.Yellow
        Me.btnThoat.Location = New System.Drawing.Point(285, 19)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Controls.Add(Me.lsvCThoadon)
        Me.GroupBox1.Controls.Add(Me.txtThanhtien)
        Me.GroupBox1.Controls.Add(Me.txtMachitiethd)
        Me.GroupBox1.Controls.Add(Me.txtMahoadon)
        Me.GroupBox1.Controls.Add(Me.txtMasanpham)
        Me.GroupBox1.Controls.Add(Me.lblThanhtien)
        Me.GroupBox1.Controls.Add(Me.lblSoluong)
        Me.GroupBox1.Controls.Add(Me.txtSoluong)
        Me.GroupBox1.Controls.Add(Me.lblMasanpham)
        Me.GroupBox1.Controls.Add(Me.lblMachitiethd)
        Me.GroupBox1.Controls.Add(Me.lblMahoadon)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 290)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chi tiết hóa đơn"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.btnThem)
        Me.GroupBox2.Controls.Add(Me.btnThoat)
        Me.GroupBox2.Controls.Add(Me.btnSua)
        Me.GroupBox2.Controls.Add(Me.btnXoa)
        Me.GroupBox2.Location = New System.Drawing.Point(212, 322)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 58)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'frmChitiethoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(791, 392)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "frmChitiethoadon"
        Me.Text = "Chi tiết hóa đơn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtMachitiethd As TextBox
    Friend WithEvents txtMahoadon As TextBox
    Friend WithEvents txtMasanpham As TextBox
    Friend WithEvents txtSoluong As TextBox
    Friend WithEvents txtThanhtien As TextBox
    Friend WithEvents lblMachitiethd As Label
    Friend WithEvents lblMahoadon As Label
    Friend WithEvents lblMasanpham As Label
    Friend WithEvents lblSoluong As Label
    Friend WithEvents lblThanhtien As Label
    Friend WithEvents lsvCThoadon As ListView
    Friend WithEvents clhSTT As ColumnHeader
    Friend WithEvents clhMaCTHD As ColumnHeader
    Friend WithEvents clhMahoadon As ColumnHeader
    Friend WithEvents clhMasanpham As ColumnHeader
    Friend WithEvents clhSoluong As ColumnHeader
    Friend WithEvents clhThanhtien As ColumnHeader
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
