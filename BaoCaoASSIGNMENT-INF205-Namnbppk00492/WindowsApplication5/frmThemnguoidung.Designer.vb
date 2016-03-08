<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemnguoidung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemnguoidung))
        Me.lblNhanvien = New System.Windows.Forms.Label()
        Me.lblCalamviec = New System.Windows.Forms.Label()
        Me.lblNhomnguoidung = New System.Windows.Forms.Label()
        Me.grbDangnhaphethong = New System.Windows.Forms.GroupBox()
        Me.lblMatkhau = New System.Windows.Forms.Label()
        Me.lblTaikhoan = New System.Windows.Forms.Label()
        Me.txtMatkhau = New System.Windows.Forms.TextBox()
        Me.txtTaikhoan = New System.Windows.Forms.TextBox()
        Me.cbbNhanvien = New System.Windows.Forms.ComboBox()
        Me.cbbCalamviec = New System.Windows.Forms.ComboBox()
        Me.cbbNhomnguoidung = New System.Windows.Forms.ComboBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grbDangnhaphethong.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNhanvien
        '
        Me.lblNhanvien.AutoSize = True
        Me.lblNhanvien.Location = New System.Drawing.Point(12, 73)
        Me.lblNhanvien.Name = "lblNhanvien"
        Me.lblNhanvien.Size = New System.Drawing.Size(62, 13)
        Me.lblNhanvien.TabIndex = 0
        Me.lblNhanvien.Text = "Nhân viên :"
        '
        'lblCalamviec
        '
        Me.lblCalamviec.AutoSize = True
        Me.lblCalamviec.Location = New System.Drawing.Point(12, 109)
        Me.lblCalamviec.Name = "lblCalamviec"
        Me.lblCalamviec.Size = New System.Drawing.Size(68, 13)
        Me.lblCalamviec.TabIndex = 0
        Me.lblCalamviec.Text = "Ca làm việc :"
        '
        'lblNhomnguoidung
        '
        Me.lblNhomnguoidung.AutoSize = True
        Me.lblNhomnguoidung.Location = New System.Drawing.Point(12, 144)
        Me.lblNhomnguoidung.Name = "lblNhomnguoidung"
        Me.lblNhomnguoidung.Size = New System.Drawing.Size(97, 13)
        Me.lblNhomnguoidung.TabIndex = 0
        Me.lblNhomnguoidung.Text = "Nhóm người dùng :"
        '
        'grbDangnhaphethong
        '
        Me.grbDangnhaphethong.BackColor = System.Drawing.Color.Snow
        Me.grbDangnhaphethong.Controls.Add(Me.lblMatkhau)
        Me.grbDangnhaphethong.Controls.Add(Me.lblTaikhoan)
        Me.grbDangnhaphethong.Controls.Add(Me.txtMatkhau)
        Me.grbDangnhaphethong.Controls.Add(Me.txtTaikhoan)
        Me.grbDangnhaphethong.Location = New System.Drawing.Point(12, 183)
        Me.grbDangnhaphethong.Name = "grbDangnhaphethong"
        Me.grbDangnhaphethong.Size = New System.Drawing.Size(308, 100)
        Me.grbDangnhaphethong.TabIndex = 1
        Me.grbDangnhaphethong.TabStop = False
        Me.grbDangnhaphethong.Text = "Đăng nhập hệ thống"
        '
        'lblMatkhau
        '
        Me.lblMatkhau.AutoSize = True
        Me.lblMatkhau.Location = New System.Drawing.Point(22, 67)
        Me.lblMatkhau.Name = "lblMatkhau"
        Me.lblMatkhau.Size = New System.Drawing.Size(58, 13)
        Me.lblMatkhau.TabIndex = 1
        Me.lblMatkhau.Text = "Mật khẩu :"
        '
        'lblTaikhoan
        '
        Me.lblTaikhoan.AutoSize = True
        Me.lblTaikhoan.Location = New System.Drawing.Point(22, 35)
        Me.lblTaikhoan.Name = "lblTaikhoan"
        Me.lblTaikhoan.Size = New System.Drawing.Size(61, 13)
        Me.lblTaikhoan.TabIndex = 1
        Me.lblTaikhoan.Text = "Tài khoản :"
        '
        'txtMatkhau
        '
        Me.txtMatkhau.Location = New System.Drawing.Point(119, 64)
        Me.txtMatkhau.Name = "txtMatkhau"
        Me.txtMatkhau.Size = New System.Drawing.Size(163, 20)
        Me.txtMatkhau.TabIndex = 0
        '
        'txtTaikhoan
        '
        Me.txtTaikhoan.Location = New System.Drawing.Point(119, 28)
        Me.txtTaikhoan.Name = "txtTaikhoan"
        Me.txtTaikhoan.Size = New System.Drawing.Size(163, 20)
        Me.txtTaikhoan.TabIndex = 0
        '
        'cbbNhanvien
        '
        Me.cbbNhanvien.FormattingEnabled = True
        Me.cbbNhanvien.Items.AddRange(New Object() {"Thu Ngân"})
        Me.cbbNhanvien.Location = New System.Drawing.Point(131, 70)
        Me.cbbNhanvien.Name = "cbbNhanvien"
        Me.cbbNhanvien.Size = New System.Drawing.Size(189, 21)
        Me.cbbNhanvien.TabIndex = 2
        '
        'cbbCalamviec
        '
        Me.cbbCalamviec.FormattingEnabled = True
        Me.cbbCalamviec.Location = New System.Drawing.Point(131, 106)
        Me.cbbCalamviec.Name = "cbbCalamviec"
        Me.cbbCalamviec.Size = New System.Drawing.Size(189, 21)
        Me.cbbCalamviec.TabIndex = 2
        '
        'cbbNhomnguoidung
        '
        Me.cbbNhomnguoidung.FormattingEnabled = True
        Me.cbbNhomnguoidung.Items.AddRange(New Object() {"1", "2"})
        Me.cbbNhomnguoidung.Location = New System.Drawing.Point(131, 141)
        Me.cbbNhomnguoidung.Name = "cbbNhomnguoidung"
        Me.cbbNhomnguoidung.Size = New System.Drawing.Size(189, 21)
        Me.cbbNhomnguoidung.TabIndex = 2
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(60, 322)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(182, 322)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 2
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.thong_tin_nguoi_dung
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 64)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmThemnguoidung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(332, 375)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.cbbNhomnguoidung)
        Me.Controls.Add(Me.cbbCalamviec)
        Me.Controls.Add(Me.cbbNhanvien)
        Me.Controls.Add(Me.grbDangnhaphethong)
        Me.Controls.Add(Me.lblNhomnguoidung)
        Me.Controls.Add(Me.lblCalamviec)
        Me.Controls.Add(Me.lblNhanvien)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThemnguoidung"
        Me.Text = "Thông tin người dùng"
        Me.grbDangnhaphethong.ResumeLayout(False)
        Me.grbDangnhaphethong.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNhanvien As System.Windows.Forms.Label
    Friend WithEvents lblCalamviec As System.Windows.Forms.Label
    Friend WithEvents lblNhomnguoidung As System.Windows.Forms.Label
    Friend WithEvents grbDangnhaphethong As System.Windows.Forms.GroupBox
    Friend WithEvents lblTaikhoan As System.Windows.Forms.Label
    Friend WithEvents txtMatkhau As System.Windows.Forms.TextBox
    Friend WithEvents txtTaikhoan As System.Windows.Forms.TextBox
    Friend WithEvents cbbNhanvien As System.Windows.Forms.ComboBox
    Friend WithEvents cbbCalamviec As System.Windows.Forms.ComboBox
    Friend WithEvents cbbNhomnguoidung As System.Windows.Forms.ComboBox
    Friend WithEvents lblMatkhau As System.Windows.Forms.Label
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
