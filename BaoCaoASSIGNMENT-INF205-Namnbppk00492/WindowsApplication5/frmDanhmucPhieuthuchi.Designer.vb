<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhmucPhieuthuchi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDanhmucPhieuthuchi))
        Me.grbPhieuthu = New System.Windows.Forms.GroupBox()
        Me.lsvPhieuthu = New System.Windows.Forms.ListView()
        Me.clhStt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhNgay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhSophieu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhNguoinop = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhLydothu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhSotien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhDiengiai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuThem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuXoa = New System.Windows.Forms.ToolStripMenuItem()
        Me.grbPhieuchi = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.clhSttphieuchi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cllNgayphieuchi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhSophieuchi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhNguoinhan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhLydochi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhSotienchi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhDiengiaichi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.menuThemphieuchi = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuXoaphieuchi = New System.Windows.Forms.ToolStripMenuItem()
        Me.grbPhieuthu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.grbPhieuchi.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbPhieuthu
        '
        Me.grbPhieuthu.BackColor = System.Drawing.Color.LightBlue
        Me.grbPhieuthu.Controls.Add(Me.lsvPhieuthu)
        Me.grbPhieuthu.Controls.Add(Me.MenuStrip1)
        Me.grbPhieuthu.Location = New System.Drawing.Point(1, 0)
        Me.grbPhieuthu.Name = "grbPhieuthu"
        Me.grbPhieuthu.Size = New System.Drawing.Size(451, 497)
        Me.grbPhieuthu.TabIndex = 0
        Me.grbPhieuthu.TabStop = False
        Me.grbPhieuthu.Text = "Phiếu thu"
        '
        'lsvPhieuthu
        '
        Me.lsvPhieuthu.AllowColumnReorder = True
        Me.lsvPhieuthu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhStt, Me.clhNgay, Me.clhSophieu, Me.clhNguoinop, Me.clhLydothu, Me.clhSotien, Me.clhDiengiai})
        Me.lsvPhieuthu.FullRowSelect = True
        Me.lsvPhieuthu.GridLines = True
        Me.lsvPhieuthu.Location = New System.Drawing.Point(3, 43)
        Me.lsvPhieuthu.Name = "lsvPhieuthu"
        Me.lsvPhieuthu.Size = New System.Drawing.Size(442, 454)
        Me.lsvPhieuthu.TabIndex = 1
        Me.lsvPhieuthu.UseCompatibleStateImageBehavior = False
        Me.lsvPhieuthu.View = System.Windows.Forms.View.Details
        '
        'clhStt
        '
        Me.clhStt.Text = "STT"
        Me.clhStt.Width = 38
        '
        'clhNgay
        '
        Me.clhNgay.Text = "Ngày"
        Me.clhNgay.Width = 65
        '
        'clhSophieu
        '
        Me.clhSophieu.Text = "Số phiếu"
        Me.clhSophieu.Width = 88
        '
        'clhNguoinop
        '
        Me.clhNguoinop.Text = "Người nộp"
        Me.clhNguoinop.Width = 90
        '
        'clhLydothu
        '
        Me.clhLydothu.Text = "Lý do thu"
        Me.clhLydothu.Width = 78
        '
        'clhSotien
        '
        Me.clhSotien.Text = "Số tiền"
        Me.clhSotien.Width = 93
        '
        'clhDiengiai
        '
        Me.clhDiengiai.Text = "Diễn giải"
        Me.clhDiengiai.Width = 92
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuThem, Me.menuXoa})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(445, 24)
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
        'grbPhieuchi
        '
        Me.grbPhieuchi.BackColor = System.Drawing.Color.LightBlue
        Me.grbPhieuchi.Controls.Add(Me.ListView1)
        Me.grbPhieuchi.Controls.Add(Me.MenuStrip2)
        Me.grbPhieuchi.Location = New System.Drawing.Point(458, 0)
        Me.grbPhieuchi.Name = "grbPhieuchi"
        Me.grbPhieuchi.Size = New System.Drawing.Size(438, 497)
        Me.grbPhieuchi.TabIndex = 0
        Me.grbPhieuchi.TabStop = False
        Me.grbPhieuchi.Text = "Phiếu chi"
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhSttphieuchi, Me.cllNgayphieuchi, Me.clhSophieuchi, Me.clhNguoinhan, Me.clhLydochi, Me.clhSotienchi, Me.clhDiengiaichi})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(3, 43)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(432, 454)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'clhSttphieuchi
        '
        Me.clhSttphieuchi.Text = "STT"
        Me.clhSttphieuchi.Width = 40
        '
        'cllNgayphieuchi
        '
        Me.cllNgayphieuchi.Text = "Ngày"
        Me.cllNgayphieuchi.Width = 80
        '
        'clhSophieuchi
        '
        Me.clhSophieuchi.Text = "Số phiếu"
        Me.clhSophieuchi.Width = 113
        '
        'clhNguoinhan
        '
        Me.clhNguoinhan.Text = "Người nhận"
        Me.clhNguoinhan.Width = 108
        '
        'clhLydochi
        '
        Me.clhLydochi.Text = "Lý do chi"
        Me.clhLydochi.Width = 115
        '
        'clhSotienchi
        '
        Me.clhSotienchi.Text = "Số tiền"
        Me.clhSotienchi.Width = 102
        '
        'clhDiengiaichi
        '
        Me.clhDiengiaichi.Text = "Diễn giải"
        Me.clhDiengiaichi.Width = 118
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuThemphieuchi, Me.menuXoaphieuchi})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(432, 24)
        Me.MenuStrip2.TabIndex = 0
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'menuThemphieuchi
        '
        Me.menuThemphieuchi.Image = Global.WindowsApplication5.My.Resources.Resources.them
        Me.menuThemphieuchi.Name = "menuThemphieuchi"
        Me.menuThemphieuchi.Size = New System.Drawing.Size(66, 20)
        Me.menuThemphieuchi.Text = "Thêm"
        '
        'menuXoaphieuchi
        '
        Me.menuXoaphieuchi.Image = Global.WindowsApplication5.My.Resources.Resources.xoa
        Me.menuXoaphieuchi.Name = "menuXoaphieuchi"
        Me.menuXoaphieuchi.Size = New System.Drawing.Size(55, 20)
        Me.menuXoaphieuchi.Text = "Xóa"
        '
        'frmDanhmucPhieuthuchi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 498)
        Me.Controls.Add(Me.grbPhieuchi)
        Me.Controls.Add(Me.grbPhieuthu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDanhmucPhieuthuchi"
        Me.Text = "Danh mục phiếu thu, chi"
        Me.grbPhieuthu.ResumeLayout(False)
        Me.grbPhieuthu.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grbPhieuchi.ResumeLayout(False)
        Me.grbPhieuchi.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbPhieuthu As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents grbPhieuchi As System.Windows.Forms.GroupBox
    Friend WithEvents lsvPhieuthu As System.Windows.Forms.ListView
    Friend WithEvents clhStt As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhNgay As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhSophieu As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhNguoinop As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhLydothu As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhSotien As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhDiengiai As System.Windows.Forms.ColumnHeader
    Friend WithEvents menuThem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuXoa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents clhSttphieuchi As System.Windows.Forms.ColumnHeader
    Friend WithEvents cllNgayphieuchi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhSophieuchi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhNguoinhan As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhLydochi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhSotienchi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhDiengiaichi As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuThemphieuchi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuXoaphieuchi As System.Windows.Forms.ToolStripMenuItem
End Class
