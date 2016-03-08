<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhmuckhachhang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDanhmuckhachhang))
        Me.grbKhachhang = New System.Windows.Forms.GroupBox()
        Me.cbbGioitinh = New System.Windows.Forms.ComboBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCMND = New System.Windows.Forms.TextBox()
        Me.txtTenkhachang = New System.Windows.Forms.TextBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtDienthoai = New System.Windows.Forms.TextBox()
        Me.txtMakhachang = New System.Windows.Forms.TextBox()
        Me.lsvKhachhang = New System.Windows.Forms.ListView()
        Me.clhStt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhMa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhTenkhach = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhCMND = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhGioitinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhDienthoai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhDiachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grbKhachhang.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbKhachhang
        '
        Me.grbKhachhang.BackColor = System.Drawing.SystemColors.HotTrack
        Me.grbKhachhang.Controls.Add(Me.cbbGioitinh)
        Me.grbKhachhang.Controls.Add(Me.btnThoat)
        Me.grbKhachhang.Controls.Add(Me.btnXoa)
        Me.grbKhachhang.Controls.Add(Me.btnSua)
        Me.grbKhachhang.Controls.Add(Me.btnThem)
        Me.grbKhachhang.Controls.Add(Me.Label3)
        Me.grbKhachhang.Controls.Add(Me.Label2)
        Me.grbKhachhang.Controls.Add(Me.Label6)
        Me.grbKhachhang.Controls.Add(Me.Label5)
        Me.grbKhachhang.Controls.Add(Me.Label4)
        Me.grbKhachhang.Controls.Add(Me.Label1)
        Me.grbKhachhang.Controls.Add(Me.txtCMND)
        Me.grbKhachhang.Controls.Add(Me.txtTenkhachang)
        Me.grbKhachhang.Controls.Add(Me.txtDiachi)
        Me.grbKhachhang.Controls.Add(Me.txtDienthoai)
        Me.grbKhachhang.Controls.Add(Me.txtMakhachang)
        Me.grbKhachhang.Location = New System.Drawing.Point(12, 24)
        Me.grbKhachhang.Name = "grbKhachhang"
        Me.grbKhachhang.Size = New System.Drawing.Size(860, 215)
        Me.grbKhachhang.TabIndex = 1
        Me.grbKhachhang.TabStop = False
        Me.grbKhachhang.Text = "Khách hàng"
        '
        'cbbGioitinh
        '
        Me.cbbGioitinh.FormattingEnabled = True
        Me.cbbGioitinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cbbGioitinh.Location = New System.Drawing.Point(455, 43)
        Me.cbbGioitinh.Name = "cbbGioitinh"
        Me.cbbGioitinh.Size = New System.Drawing.Size(161, 21)
        Me.cbbGioitinh.TabIndex = 3
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Yellow
        Me.btnThoat.ForeColor = System.Drawing.Color.Red
        Me.btnThoat.Location = New System.Drawing.Point(699, 173)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Yellow
        Me.btnXoa.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Location = New System.Drawing.Point(699, 129)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.Yellow
        Me.btnSua.Location = New System.Drawing.Point(699, 88)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 7
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Yellow
        Me.btnThem.ForeColor = System.Drawing.Color.Black
        Me.btnThem.Location = New System.Drawing.Point(699, 41)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CMND"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên khách hàng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(375, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Địa chỉ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(375, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Điện thoại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Giới tính"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã khách hàng"
        '
        'txtCMND
        '
        Me.txtCMND.Location = New System.Drawing.Point(139, 151)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(161, 20)
        Me.txtCMND.TabIndex = 2
        '
        'txtTenkhachang
        '
        Me.txtTenkhachang.Location = New System.Drawing.Point(139, 95)
        Me.txtTenkhachang.Name = "txtTenkhachang"
        Me.txtTenkhachang.Size = New System.Drawing.Size(161, 20)
        Me.txtTenkhachang.TabIndex = 1
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(455, 151)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(161, 20)
        Me.txtDiachi.TabIndex = 5
        '
        'txtDienthoai
        '
        Me.txtDienthoai.Location = New System.Drawing.Point(455, 95)
        Me.txtDienthoai.Name = "txtDienthoai"
        Me.txtDienthoai.Size = New System.Drawing.Size(161, 20)
        Me.txtDienthoai.TabIndex = 4
        '
        'txtMakhachang
        '
        Me.txtMakhachang.Location = New System.Drawing.Point(139, 48)
        Me.txtMakhachang.Name = "txtMakhachang"
        Me.txtMakhachang.Size = New System.Drawing.Size(161, 20)
        Me.txtMakhachang.TabIndex = 0
        '
        'lsvKhachhang
        '
        Me.lsvKhachhang.AllowColumnReorder = True
        Me.lsvKhachhang.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lsvKhachhang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhStt, Me.clhMa, Me.clhTenkhach, Me.clhCMND, Me.clhGioitinh, Me.clhDienthoai, Me.clhDiachi})
        Me.lsvKhachhang.FullRowSelect = True
        Me.lsvKhachhang.GridLines = True
        Me.lsvKhachhang.Location = New System.Drawing.Point(12, 255)
        Me.lsvKhachhang.Name = "lsvKhachhang"
        Me.lsvKhachhang.Size = New System.Drawing.Size(860, 193)
        Me.lsvKhachhang.TabIndex = 1
        Me.lsvKhachhang.UseCompatibleStateImageBehavior = False
        Me.lsvKhachhang.View = System.Windows.Forms.View.Details
        '
        'clhStt
        '
        Me.clhStt.Text = "STT"
        '
        'clhMa
        '
        Me.clhMa.Text = "Mã"
        Me.clhMa.Width = 106
        '
        'clhTenkhach
        '
        Me.clhTenkhach.Text = "Tên khách"
        Me.clhTenkhach.Width = 152
        '
        'clhCMND
        '
        Me.clhCMND.Text = "CMND"
        Me.clhCMND.Width = 125
        '
        'clhGioitinh
        '
        Me.clhGioitinh.Text = "Giới tính"
        Me.clhGioitinh.Width = 137
        '
        'clhDienthoai
        '
        Me.clhDienthoai.Text = "Điện thoại"
        Me.clhDienthoai.Width = 180
        '
        'clhDiachi
        '
        Me.clhDiachi.Text = "Địa chỉ"
        Me.clhDiachi.Width = 100
        '
        'frmDanhmuckhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(884, 460)
        Me.Controls.Add(Me.grbKhachhang)
        Me.Controls.Add(Me.lsvKhachhang)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDanhmuckhachhang"
        Me.Text = "Danh mục khách hàng"
        Me.grbKhachhang.ResumeLayout(False)
        Me.grbKhachhang.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbKhachhang As System.Windows.Forms.GroupBox
    Friend WithEvents lsvKhachhang As System.Windows.Forms.ListView
    Friend WithEvents clhStt As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhMa As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhTenkhach As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhCMND As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhGioitinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhDienthoai As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhDiachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCMND As TextBox
    Friend WithEvents txtTenkhachang As TextBox
    Friend WithEvents txtDiachi As TextBox
    Friend WithEvents txtDienthoai As TextBox
    Friend WithEvents txtMakhachang As TextBox
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents cbbGioitinh As ComboBox
End Class
