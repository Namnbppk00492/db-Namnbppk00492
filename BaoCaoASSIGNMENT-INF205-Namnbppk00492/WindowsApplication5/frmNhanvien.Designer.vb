<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanvien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhanvien))
        Me.grbNhanvien = New System.Windows.Forms.GroupBox()
        Me.lsvNhanvien = New System.Windows.Forms.ListView()
        Me.clhSTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhNhanvien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhLuong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ThêmMớiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XóaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.clhCalamviec = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grbNhanvien.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbNhanvien
        '
        Me.grbNhanvien.Controls.Add(Me.lsvNhanvien)
        Me.grbNhanvien.Controls.Add(Me.MenuStrip1)
        Me.grbNhanvien.Location = New System.Drawing.Point(1, 68)
        Me.grbNhanvien.Name = "grbNhanvien"
        Me.grbNhanvien.Size = New System.Drawing.Size(355, 350)
        Me.grbNhanvien.TabIndex = 0
        Me.grbNhanvien.TabStop = False
        '
        'lsvNhanvien
        '
        Me.lsvNhanvien.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhSTT, Me.clhNhanvien, Me.clhLuong, Me.clhCalamviec})
        Me.lsvNhanvien.FullRowSelect = True
        Me.lsvNhanvien.Location = New System.Drawing.Point(3, 43)
        Me.lsvNhanvien.Name = "lsvNhanvien"
        Me.lsvNhanvien.Size = New System.Drawing.Size(349, 307)
        Me.lsvNhanvien.TabIndex = 1
        Me.lsvNhanvien.UseCompatibleStateImageBehavior = False
        Me.lsvNhanvien.View = System.Windows.Forms.View.Details
        '
        'clhSTT
        '
        Me.clhSTT.Text = "STT"
        Me.clhSTT.Width = 38
        '
        'clhNhanvien
        '
        Me.clhNhanvien.Text = "Nhân viên"
        Me.clhNhanvien.Width = 132
        '
        'clhLuong
        '
        Me.clhLuong.Text = "Lương"
        Me.clhLuong.Width = 87
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmMớiToolStripMenuItem, Me.XóaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(349, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ThêmMớiToolStripMenuItem
        '
        Me.ThêmMớiToolStripMenuItem.Image = Global.WindowsApplication5.My.Resources.Resources.them
        Me.ThêmMớiToolStripMenuItem.Name = "ThêmMớiToolStripMenuItem"
        Me.ThêmMớiToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ThêmMớiToolStripMenuItem.Text = "Thêm mới"
        '
        'XóaToolStripMenuItem
        '
        Me.XóaToolStripMenuItem.Image = Global.WindowsApplication5.My.Resources.Resources.xoa
        Me.XóaToolStripMenuItem.Name = "XóaToolStripMenuItem"
        Me.XóaToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.XóaToolStripMenuItem.Text = "Xóa"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.quan_ly_nhan_vien
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 71)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'clhCalamviec
        '
        Me.clhCalamviec.Text = "Ca làm viêc"
        Me.clhCalamviec.Width = 86
        '
        'frmNhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(356, 417)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grbNhanvien)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNhanvien"
        Me.Text = "Nhân viên"
        Me.grbNhanvien.ResumeLayout(False)
        Me.grbNhanvien.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbNhanvien As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ThêmMớiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XóaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lsvNhanvien As System.Windows.Forms.ListView
    Friend WithEvents clhSTT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhNhanvien As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhLuong As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhCalamviec As System.Windows.Forms.ColumnHeader
End Class
