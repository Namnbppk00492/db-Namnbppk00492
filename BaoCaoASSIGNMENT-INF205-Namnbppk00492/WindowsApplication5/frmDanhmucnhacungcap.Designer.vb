<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhmucnhacungcap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDanhmucnhacungcap))
        Me.grbNhacungcap = New System.Windows.Forms.GroupBox()
        Me.lsvNhacungcap = New System.Windows.Forms.ListView()
        Me.clhSTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhManhacungcap = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhDiachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhSdd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuThemmoi = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuXoa = New System.Windows.Forms.ToolStripMenuItem()
        Me.grbNhacungcap.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbNhacungcap
        '
        Me.grbNhacungcap.BackColor = System.Drawing.Color.LightBlue
        Me.grbNhacungcap.Controls.Add(Me.lsvNhacungcap)
        Me.grbNhacungcap.Controls.Add(Me.MenuStrip1)
        Me.grbNhacungcap.Location = New System.Drawing.Point(0, 0)
        Me.grbNhacungcap.Name = "grbNhacungcap"
        Me.grbNhacungcap.Size = New System.Drawing.Size(852, 502)
        Me.grbNhacungcap.TabIndex = 0
        Me.grbNhacungcap.TabStop = False
        Me.grbNhacungcap.Text = "Nhà cung cấp"
        '
        'lsvNhacungcap
        '
        Me.lsvNhacungcap.AllowColumnReorder = True
        Me.lsvNhacungcap.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhSTT, Me.clhManhacungcap, Me.clhDiachi, Me.clhSdd, Me.clhEmail})
        Me.lsvNhacungcap.FullRowSelect = True
        Me.lsvNhacungcap.GridLines = True
        Me.lsvNhacungcap.Location = New System.Drawing.Point(3, 43)
        Me.lsvNhacungcap.Name = "lsvNhacungcap"
        Me.lsvNhacungcap.Size = New System.Drawing.Size(849, 459)
        Me.lsvNhacungcap.TabIndex = 1
        Me.lsvNhacungcap.UseCompatibleStateImageBehavior = False
        Me.lsvNhacungcap.View = System.Windows.Forms.View.Details
        '
        'clhSTT
        '
        Me.clhSTT.Text = "STT"
        '
        'clhManhacungcap
        '
        Me.clhManhacungcap.Text = "Mã nhà cung cấp"
        Me.clhManhacungcap.Width = 149
        '
        'clhDiachi
        '
        Me.clhDiachi.Text = "Địa chỉ"
        Me.clhDiachi.Width = 277
        '
        'clhSdd
        '
        Me.clhSdd.Text = "Số điện thoại"
        Me.clhSdd.Width = 151
        '
        'clhEmail
        '
        Me.clhEmail.Text = "Email"
        Me.clhEmail.Width = 320
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuThemmoi, Me.menuXoa})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(846, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuThemmoi
        '
        Me.menuThemmoi.Image = Global.WindowsApplication5.My.Resources.Resources.them
        Me.menuThemmoi.Name = "menuThemmoi"
        Me.menuThemmoi.Size = New System.Drawing.Size(90, 20)
        Me.menuThemmoi.Text = "Thêm mới"
        '
        'menuXoa
        '
        Me.menuXoa.Image = Global.WindowsApplication5.My.Resources.Resources.xoa
        Me.menuXoa.Name = "menuXoa"
        Me.menuXoa.Size = New System.Drawing.Size(55, 20)
        Me.menuXoa.Text = "Xóa"
        '
        'frmDanhmucnhacungcap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 505)
        Me.Controls.Add(Me.grbNhacungcap)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDanhmucnhacungcap"
        Me.Text = "Nhà cung cấp"
        Me.grbNhacungcap.ResumeLayout(False)
        Me.grbNhacungcap.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbNhacungcap As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lsvNhacungcap As System.Windows.Forms.ListView
    Friend WithEvents clhSTT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhManhacungcap As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhDiachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhSdd As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents menuThemmoi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuXoa As System.Windows.Forms.ToolStripMenuItem
End Class
