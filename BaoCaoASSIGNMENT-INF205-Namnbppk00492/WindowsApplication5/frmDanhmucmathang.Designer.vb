<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhmucmathang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDanhmucmathang))
        Me.grbMathang = New System.Windows.Forms.GroupBox()
        Me.cbbDonvi = New System.Windows.Forms.ComboBox()
        Me.cbbTinhtrang = New System.Windows.Forms.ComboBox()
        Me.lblTinhtrang = New System.Windows.Forms.Label()
        Me.lblDonvi = New System.Windows.Forms.Label()
        Me.cbbMaloaimon = New System.Windows.Forms.ComboBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.lblMaloaimon = New System.Windows.Forms.Label()
        Me.lblGia = New System.Windows.Forms.Label()
        Me.lblTenMon = New System.Windows.Forms.Label()
        Me.lblMaMon = New System.Windows.Forms.Label()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.txtTenmon = New System.Windows.Forms.TextBox()
        Me.txtMamon = New System.Windows.Forms.TextBox()
        Me.lsvMathang = New System.Windows.Forms.ListView()
        Me.clhSTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhMamon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhTenmon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhGia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhDonvi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cllTinhtrang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhMaloaimon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grbMathang.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbMathang
        '
        Me.grbMathang.BackColor = System.Drawing.SystemColors.HotTrack
        Me.grbMathang.Controls.Add(Me.cbbDonvi)
        Me.grbMathang.Controls.Add(Me.cbbTinhtrang)
        Me.grbMathang.Controls.Add(Me.lblTinhtrang)
        Me.grbMathang.Controls.Add(Me.lblDonvi)
        Me.grbMathang.Controls.Add(Me.cbbMaloaimon)
        Me.grbMathang.Controls.Add(Me.btnThoat)
        Me.grbMathang.Controls.Add(Me.btnXoa)
        Me.grbMathang.Controls.Add(Me.btnSua)
        Me.grbMathang.Controls.Add(Me.btnThem)
        Me.grbMathang.Controls.Add(Me.lblMaloaimon)
        Me.grbMathang.Controls.Add(Me.lblGia)
        Me.grbMathang.Controls.Add(Me.lblTenMon)
        Me.grbMathang.Controls.Add(Me.lblMaMon)
        Me.grbMathang.Controls.Add(Me.txtGia)
        Me.grbMathang.Controls.Add(Me.txtTenmon)
        Me.grbMathang.Controls.Add(Me.txtMamon)
        Me.grbMathang.Location = New System.Drawing.Point(12, 12)
        Me.grbMathang.Name = "grbMathang"
        Me.grbMathang.Size = New System.Drawing.Size(833, 232)
        Me.grbMathang.TabIndex = 0
        Me.grbMathang.TabStop = False
        Me.grbMathang.Text = "Mặt hàng"
        '
        'cbbDonvi
        '
        Me.cbbDonvi.FormattingEnabled = True
        Me.cbbDonvi.Items.AddRange(New Object() {"Ly", "Lon"})
        Me.cbbDonvi.Location = New System.Drawing.Point(120, 130)
        Me.cbbDonvi.Name = "cbbDonvi"
        Me.cbbDonvi.Size = New System.Drawing.Size(186, 21)
        Me.cbbDonvi.TabIndex = 2
        '
        'cbbTinhtrang
        '
        Me.cbbTinhtrang.FormattingEnabled = True
        Me.cbbTinhtrang.Items.AddRange(New Object() {"Còn hàng", "Hết hàng"})
        Me.cbbTinhtrang.Location = New System.Drawing.Point(434, 87)
        Me.cbbTinhtrang.Name = "cbbTinhtrang"
        Me.cbbTinhtrang.Size = New System.Drawing.Size(186, 21)
        Me.cbbTinhtrang.TabIndex = 4
        '
        'lblTinhtrang
        '
        Me.lblTinhtrang.AutoSize = True
        Me.lblTinhtrang.Location = New System.Drawing.Point(359, 90)
        Me.lblTinhtrang.Name = "lblTinhtrang"
        Me.lblTinhtrang.Size = New System.Drawing.Size(55, 13)
        Me.lblTinhtrang.TabIndex = 5
        Me.lblTinhtrang.Text = "Tình trạng"
        '
        'lblDonvi
        '
        Me.lblDonvi.AutoSize = True
        Me.lblDonvi.Location = New System.Drawing.Point(49, 134)
        Me.lblDonvi.Name = "lblDonvi"
        Me.lblDonvi.Size = New System.Drawing.Size(38, 13)
        Me.lblDonvi.TabIndex = 5
        Me.lblDonvi.Text = "Đơn vị"
        '
        'cbbMaloaimon
        '
        Me.cbbMaloaimon.FormattingEnabled = True
        Me.cbbMaloaimon.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbbMaloaimon.Location = New System.Drawing.Point(434, 131)
        Me.cbbMaloaimon.Name = "cbbMaloaimon"
        Me.cbbMaloaimon.Size = New System.Drawing.Size(186, 21)
        Me.cbbMaloaimon.TabIndex = 5
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Yellow
        Me.btnThoat.ForeColor = System.Drawing.Color.Red
        Me.btnThoat.Location = New System.Drawing.Point(680, 168)
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
        Me.btnXoa.Location = New System.Drawing.Point(680, 124)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.Yellow
        Me.btnSua.Location = New System.Drawing.Point(680, 80)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 7
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Yellow
        Me.btnThem.Location = New System.Drawing.Point(680, 38)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'lblMaloaimon
        '
        Me.lblMaloaimon.AutoSize = True
        Me.lblMaloaimon.Location = New System.Drawing.Point(359, 134)
        Me.lblMaloaimon.Name = "lblMaloaimon"
        Me.lblMaloaimon.Size = New System.Drawing.Size(69, 13)
        Me.lblMaloaimon.TabIndex = 1
        Me.lblMaloaimon.Text = "Mã Loại Món"
        '
        'lblGia
        '
        Me.lblGia.AutoSize = True
        Me.lblGia.Location = New System.Drawing.Point(359, 43)
        Me.lblGia.Name = "lblGia"
        Me.lblGia.Size = New System.Drawing.Size(23, 13)
        Me.lblGia.TabIndex = 1
        Me.lblGia.Text = "Giá"
        '
        'lblTenMon
        '
        Me.lblTenMon.AutoSize = True
        Me.lblTenMon.Location = New System.Drawing.Point(49, 94)
        Me.lblTenMon.Name = "lblTenMon"
        Me.lblTenMon.Size = New System.Drawing.Size(50, 13)
        Me.lblTenMon.TabIndex = 1
        Me.lblTenMon.Text = "Tên Món"
        '
        'lblMaMon
        '
        Me.lblMaMon.AutoSize = True
        Me.lblMaMon.Location = New System.Drawing.Point(49, 46)
        Me.lblMaMon.Name = "lblMaMon"
        Me.lblMaMon.Size = New System.Drawing.Size(46, 13)
        Me.lblMaMon.TabIndex = 1
        Me.lblMaMon.Text = "Mã Món"
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(434, 40)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(186, 20)
        Me.txtGia.TabIndex = 3
        '
        'txtTenmon
        '
        Me.txtTenmon.Location = New System.Drawing.Point(120, 87)
        Me.txtTenmon.Name = "txtTenmon"
        Me.txtTenmon.Size = New System.Drawing.Size(186, 20)
        Me.txtTenmon.TabIndex = 1
        '
        'txtMamon
        '
        Me.txtMamon.Location = New System.Drawing.Point(120, 43)
        Me.txtMamon.Name = "txtMamon"
        Me.txtMamon.Size = New System.Drawing.Size(186, 20)
        Me.txtMamon.TabIndex = 0
        '
        'lsvMathang
        '
        Me.lsvMathang.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lsvMathang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhSTT, Me.clhMamon, Me.clhTenmon, Me.clhGia, Me.clhDonvi, Me.cllTinhtrang, Me.clhMaloaimon})
        Me.lsvMathang.FullRowSelect = True
        Me.lsvMathang.GridLines = True
        Me.lsvMathang.Location = New System.Drawing.Point(12, 250)
        Me.lsvMathang.Name = "lsvMathang"
        Me.lsvMathang.Size = New System.Drawing.Size(833, 256)
        Me.lsvMathang.TabIndex = 3
        Me.lsvMathang.UseCompatibleStateImageBehavior = False
        Me.lsvMathang.View = System.Windows.Forms.View.Details
        '
        'clhSTT
        '
        Me.clhSTT.Text = "STT"
        '
        'clhMamon
        '
        Me.clhMamon.Text = "Mã Món"
        Me.clhMamon.Width = 82
        '
        'clhTenmon
        '
        Me.clhTenmon.Text = "Tên món"
        Me.clhTenmon.Width = 130
        '
        'clhGia
        '
        Me.clhGia.Text = "Giá"
        Me.clhGia.Width = 169
        '
        'clhDonvi
        '
        Me.clhDonvi.Text = "Đơn vị"
        Me.clhDonvi.Width = 115
        '
        'cllTinhtrang
        '
        Me.cllTinhtrang.Text = "Tình trạng"
        Me.cllTinhtrang.Width = 121
        '
        'clhMaloaimon
        '
        Me.clhMaloaimon.Text = "Mã loại món"
        Me.clhMaloaimon.Width = 149
        '
        'frmDanhmucmathang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 507)
        Me.Controls.Add(Me.grbMathang)
        Me.Controls.Add(Me.lsvMathang)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDanhmucmathang"
        Me.Text = "Mặt hàng"
        Me.grbMathang.ResumeLayout(False)
        Me.grbMathang.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbMathang As System.Windows.Forms.GroupBox
    Friend WithEvents lsvMathang As ListView
    Friend WithEvents clhMamon As ColumnHeader
    Friend WithEvents clhTenmon As ColumnHeader
    Friend WithEvents clhGia As ColumnHeader
    Friend WithEvents clhMaloaimon As ColumnHeader
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents lblMaloaimon As Label
    Friend WithEvents lblGia As Label
    Friend WithEvents lblTenMon As Label
    Friend WithEvents lblMaMon As Label
    Friend WithEvents txtGia As TextBox
    Friend WithEvents txtTenmon As TextBox
    Friend WithEvents txtMamon As TextBox
    Friend WithEvents clhSTT As ColumnHeader
    Friend WithEvents cbbMaloaimon As ComboBox
    Friend WithEvents lblTinhtrang As Label
    Friend WithEvents lblDonvi As Label
    Friend WithEvents cbbTinhtrang As ComboBox
    Friend WithEvents clhDonvi As ColumnHeader
    Friend WithEvents cllTinhtrang As ColumnHeader
    Friend WithEvents cbbDonvi As ComboBox
End Class
