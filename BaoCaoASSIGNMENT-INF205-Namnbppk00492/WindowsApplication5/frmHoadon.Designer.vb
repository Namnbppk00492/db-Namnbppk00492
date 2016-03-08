<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoadon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtMahoadon = New System.Windows.Forms.TextBox()
        Me.txtMakhachhang = New System.Windows.Forms.TextBox()
        Me.txtNgayhoadon = New System.Windows.Forms.TextBox()
        Me.txtTongtien = New System.Windows.Forms.TextBox()
        Me.lblMahoadon = New System.Windows.Forms.Label()
        Me.lblMakhachhang = New System.Windows.Forms.Label()
        Me.lblNgayhoadon = New System.Windows.Forms.Label()
        Me.lblTongtien = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.lsvHoadon = New System.Windows.Forms.ListView()
        Me.cllSTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhMahoadon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cllMankhachhang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cllNgayhoadon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cllTongtien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMahoadon
        '
        Me.txtMahoadon.Location = New System.Drawing.Point(125, 32)
        Me.txtMahoadon.Name = "txtMahoadon"
        Me.txtMahoadon.Size = New System.Drawing.Size(170, 20)
        Me.txtMahoadon.TabIndex = 1
        '
        'txtMakhachhang
        '
        Me.txtMakhachhang.Location = New System.Drawing.Point(125, 93)
        Me.txtMakhachhang.Name = "txtMakhachhang"
        Me.txtMakhachhang.Size = New System.Drawing.Size(170, 20)
        Me.txtMakhachhang.TabIndex = 2
        '
        'txtNgayhoadon
        '
        Me.txtNgayhoadon.Location = New System.Drawing.Point(456, 29)
        Me.txtNgayhoadon.Name = "txtNgayhoadon"
        Me.txtNgayhoadon.Size = New System.Drawing.Size(170, 20)
        Me.txtNgayhoadon.TabIndex = 3
        '
        'txtTongtien
        '
        Me.txtTongtien.Location = New System.Drawing.Point(456, 96)
        Me.txtTongtien.Name = "txtTongtien"
        Me.txtTongtien.Size = New System.Drawing.Size(170, 20)
        Me.txtTongtien.TabIndex = 4
        '
        'lblMahoadon
        '
        Me.lblMahoadon.AutoSize = True
        Me.lblMahoadon.Location = New System.Drawing.Point(27, 35)
        Me.lblMahoadon.Name = "lblMahoadon"
        Me.lblMahoadon.Size = New System.Drawing.Size(65, 13)
        Me.lblMahoadon.TabIndex = 1
        Me.lblMahoadon.Text = "Mã hóa đơn"
        '
        'lblMakhachhang
        '
        Me.lblMakhachhang.AutoSize = True
        Me.lblMakhachhang.Location = New System.Drawing.Point(27, 96)
        Me.lblMakhachhang.Name = "lblMakhachhang"
        Me.lblMakhachhang.Size = New System.Drawing.Size(82, 13)
        Me.lblMakhachhang.TabIndex = 2
        Me.lblMakhachhang.Text = "Mã khách hàng"
        '
        'lblNgayhoadon
        '
        Me.lblNgayhoadon.AutoSize = True
        Me.lblNgayhoadon.Location = New System.Drawing.Point(357, 32)
        Me.lblNgayhoadon.Name = "lblNgayhoadon"
        Me.lblNgayhoadon.Size = New System.Drawing.Size(75, 13)
        Me.lblNgayhoadon.TabIndex = 2
        Me.lblNgayhoadon.Text = "Ngày hóa đơn"
        '
        'lblTongtien
        '
        Me.lblTongtien.AutoSize = True
        Me.lblTongtien.Location = New System.Drawing.Point(357, 100)
        Me.lblTongtien.Name = "lblTongtien"
        Me.lblTongtien.Size = New System.Drawing.Size(52, 13)
        Me.lblTongtien.TabIndex = 2
        Me.lblTongtien.Text = "Tổng tiền"
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Yellow
        Me.btnThem.Location = New System.Drawing.Point(104, 190)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.Yellow
        Me.btnSua.Location = New System.Drawing.Point(237, 190)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 5
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Red
        Me.btnXoa.Location = New System.Drawing.Point(357, 190)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 5
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Red
        Me.btnThoat.Location = New System.Drawing.Point(486, 190)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 5
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'lsvHoadon
        '
        Me.lsvHoadon.BackColor = System.Drawing.Color.DarkOrange
        Me.lsvHoadon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cllSTT, Me.clhMahoadon, Me.cllMankhachhang, Me.cllNgayhoadon, Me.cllTongtien})
        Me.lsvHoadon.FullRowSelect = True
        Me.lsvHoadon.GridLines = True
        Me.lsvHoadon.Location = New System.Drawing.Point(12, 233)
        Me.lsvHoadon.Name = "lsvHoadon"
        Me.lsvHoadon.Size = New System.Drawing.Size(670, 180)
        Me.lsvHoadon.TabIndex = 4
        Me.lsvHoadon.UseCompatibleStateImageBehavior = False
        Me.lsvHoadon.View = System.Windows.Forms.View.Details
        '
        'cllSTT
        '
        Me.cllSTT.Text = "STT"
        Me.cllSTT.Width = 53
        '
        'clhMahoadon
        '
        Me.clhMahoadon.Text = "Mã hóa đơn"
        Me.clhMahoadon.Width = 122
        '
        'cllMankhachhang
        '
        Me.cllMankhachhang.Text = "Mã khách hàng"
        Me.cllMankhachhang.Width = 114
        '
        'cllNgayhoadon
        '
        Me.cllNgayhoadon.Text = "Ngày hóa đơn"
        Me.cllNgayhoadon.Width = 182
        '
        'cllTongtien
        '
        Me.cllTongtien.Text = "Tổng tiền"
        Me.cllTongtien.Width = 201
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Controls.Add(Me.txtMakhachhang)
        Me.GroupBox1.Controls.Add(Me.txtMahoadon)
        Me.GroupBox1.Controls.Add(Me.lblMahoadon)
        Me.GroupBox1.Controls.Add(Me.lblMakhachhang)
        Me.GroupBox1.Controls.Add(Me.txtNgayhoadon)
        Me.GroupBox1.Controls.Add(Me.txtTongtien)
        Me.GroupBox1.Controls.Add(Me.lblTongtien)
        Me.GroupBox1.Controls.Add(Me.lblNgayhoadon)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 163)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'frmHoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(694, 425)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lsvHoadon)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Name = "frmHoadon"
        Me.Text = "Hóa đơn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtMahoadon As TextBox
    Friend WithEvents txtMakhachhang As TextBox
    Friend WithEvents txtNgayhoadon As TextBox
    Friend WithEvents txtTongtien As TextBox
    Friend WithEvents lblMahoadon As Label
    Friend WithEvents lblMakhachhang As Label
    Friend WithEvents lblNgayhoadon As Label
    Friend WithEvents lblTongtien As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents lsvHoadon As ListView
    Friend WithEvents cllSTT As ColumnHeader
    Friend WithEvents clhMahoadon As ColumnHeader
    Friend WithEvents cllMankhachhang As ColumnHeader
    Friend WithEvents cllNgayhoadon As ColumnHeader
    Friend WithEvents cllTongtien As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
End Class
