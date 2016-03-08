<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNguoidungvaphanquyen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNguoidungvaphanquyen))
        Me.grbNguoidung = New System.Windows.Forms.GroupBox()
        Me.lsvNguoidungvaphanquyen = New System.Windows.Forms.ListView()
        Me.clhStt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhTaikhoan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhMatkhau = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuThem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuXoa = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.clhQuyen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grbNguoidung.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbNguoidung
        '
        Me.grbNguoidung.Controls.Add(Me.lsvNguoidungvaphanquyen)
        Me.grbNguoidung.Controls.Add(Me.MenuStrip1)
        Me.grbNguoidung.Location = New System.Drawing.Point(0, 95)
        Me.grbNguoidung.Name = "grbNguoidung"
        Me.grbNguoidung.Size = New System.Drawing.Size(671, 361)
        Me.grbNguoidung.TabIndex = 0
        Me.grbNguoidung.TabStop = False
        Me.grbNguoidung.Text = "Người dùng"
        '
        'lsvNguoidungvaphanquyen
        '
        Me.lsvNguoidungvaphanquyen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhStt, Me.clhTaikhoan, Me.clhMatkhau, Me.clhQuyen})
        Me.lsvNguoidungvaphanquyen.FullRowSelect = True
        Me.lsvNguoidungvaphanquyen.GridLines = True
        Me.lsvNguoidungvaphanquyen.Location = New System.Drawing.Point(0, 43)
        Me.lsvNguoidungvaphanquyen.Name = "lsvNguoidungvaphanquyen"
        Me.lsvNguoidungvaphanquyen.Size = New System.Drawing.Size(665, 318)
        Me.lsvNguoidungvaphanquyen.TabIndex = 1
        Me.lsvNguoidungvaphanquyen.UseCompatibleStateImageBehavior = False
        Me.lsvNguoidungvaphanquyen.View = System.Windows.Forms.View.Details
        '
        'clhStt
        '
        Me.clhStt.Text = "STT"
        Me.clhStt.Width = 48
        '
        'clhTaikhoan
        '
        Me.clhTaikhoan.Text = "Tài khoản"
        Me.clhTaikhoan.Width = 172
        '
        'clhMatkhau
        '
        Me.clhMatkhau.Text = "Mật khẩu"
        Me.clhMatkhau.Width = 157
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuThem, Me.menuXoa})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(665, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuThem
        '
        Me.menuThem.Image = Global.WindowsApplication5.My.Resources.Resources.them
        Me.menuThem.Name = "menuThem"
        Me.menuThem.Size = New System.Drawing.Size(66, 20)
        Me.menuThem.Text = "Thêm"
        '
        'menuXoa
        '
        Me.menuXoa.Image = Global.WindowsApplication5.My.Resources.Resources.xoa
        Me.menuXoa.Name = "menuXoa"
        Me.menuXoa.Size = New System.Drawing.Size(55, 20)
        Me.menuXoa.Text = "Xóa"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.ád
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(668, 72)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'clhQuyen
        '
        Me.clhQuyen.Text = "1( Quyền quản trị ) 2 ( Quyền Nhân viên )"
        Me.clhQuyen.Width = 219
        '
        'frmNguoidungvaphanquyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(668, 457)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grbNguoidung)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNguoidungvaphanquyen"
        Me.Text = "Người dùng và phân quyền"
        Me.grbNguoidung.ResumeLayout(False)
        Me.grbNguoidung.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbNguoidung As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lsvNguoidungvaphanquyen As System.Windows.Forms.ListView
    Friend WithEvents clhStt As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhTaikhoan As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhMatkhau As System.Windows.Forms.ColumnHeader
    Friend WithEvents menuThem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuXoa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents clhQuyen As System.Windows.Forms.ColumnHeader
End Class
