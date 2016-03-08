<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongkedoanhthu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongkedoanhthu))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbInbaocao = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lsvThongkedoanhthu = New System.Windows.Forms.ListView()
        Me.lblTu = New System.Windows.Forms.Label()
        Me.dtpTu = New System.Windows.Forms.DateTimePicker()
        Me.lblDen = New System.Windows.Forms.Label()
        Me.dtpDen = New System.Windows.Forms.DateTimePicker()
        Me.clhStt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhNgay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhSo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhTienhang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhGiamgia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhDichvu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhTongtien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhBatdau = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhKetthuc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhNhanvien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhThungan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbInbaocao, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(897, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbInbaocao
        '
        Me.tsbInbaocao.Image = Global.WindowsApplication5.My.Resources.Resources.máy_in
        Me.tsbInbaocao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInbaocao.Name = "tsbInbaocao"
        Me.tsbInbaocao.Size = New System.Drawing.Size(82, 22)
        Me.tsbInbaocao.Text = "In báo cáo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lsvThongkedoanhthu
        '
        Me.lsvThongkedoanhthu.AllowColumnReorder = True
        Me.lsvThongkedoanhthu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhStt, Me.clhNgay, Me.clhSo, Me.clhTienhang, Me.clhGiamgia, Me.clhDichvu, Me.clhTongtien, Me.clhBatdau, Me.clhKetthuc, Me.clhNhanvien, Me.clhThungan})
        Me.lsvThongkedoanhthu.FullRowSelect = True
        Me.lsvThongkedoanhthu.GridLines = True
        Me.lsvThongkedoanhthu.Location = New System.Drawing.Point(0, 81)
        Me.lsvThongkedoanhthu.Name = "lsvThongkedoanhthu"
        Me.lsvThongkedoanhthu.Size = New System.Drawing.Size(897, 407)
        Me.lsvThongkedoanhthu.TabIndex = 1
        Me.lsvThongkedoanhthu.UseCompatibleStateImageBehavior = False
        Me.lsvThongkedoanhthu.View = System.Windows.Forms.View.Details
        '
        'lblTu
        '
        Me.lblTu.AutoSize = True
        Me.lblTu.Location = New System.Drawing.Point(12, 45)
        Me.lblTu.Name = "lblTu"
        Me.lblTu.Size = New System.Drawing.Size(26, 13)
        Me.lblTu.TabIndex = 2
        Me.lblTu.Text = "Từ :"
        '
        'dtpTu
        '
        Me.dtpTu.CustomFormat = "dd/MM/yyyy"
        Me.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTu.Location = New System.Drawing.Point(55, 39)
        Me.dtpTu.Name = "dtpTu"
        Me.dtpTu.Size = New System.Drawing.Size(97, 20)
        Me.dtpTu.TabIndex = 3
        '
        'lblDen
        '
        Me.lblDen.AutoSize = True
        Me.lblDen.Location = New System.Drawing.Point(221, 45)
        Me.lblDen.Name = "lblDen"
        Me.lblDen.Size = New System.Drawing.Size(33, 13)
        Me.lblDen.TabIndex = 2
        Me.lblDen.Text = "Đến :"
        '
        'dtpDen
        '
        Me.dtpDen.CustomFormat = "dd/MM/yyyy"
        Me.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDen.Location = New System.Drawing.Point(270, 39)
        Me.dtpDen.Name = "dtpDen"
        Me.dtpDen.Size = New System.Drawing.Size(97, 20)
        Me.dtpDen.TabIndex = 3
        '
        'clhStt
        '
        Me.clhStt.Text = "STT"
        Me.clhStt.Width = 41
        '
        'clhNgay
        '
        Me.clhNgay.Text = "Ngày"
        '
        'clhSo
        '
        Me.clhSo.Text = "Số"
        '
        'clhTienhang
        '
        Me.clhTienhang.Text = "Tiền hàng"
        Me.clhTienhang.Width = 91
        '
        'clhGiamgia
        '
        Me.clhGiamgia.Text = "Giảm giá"
        Me.clhGiamgia.Width = 82
        '
        'clhDichvu
        '
        Me.clhDichvu.Text = "Dịch vụ"
        Me.clhDichvu.Width = 83
        '
        'clhTongtien
        '
        Me.clhTongtien.Text = "Tổng tiền"
        Me.clhTongtien.Width = 87
        '
        'clhBatdau
        '
        Me.clhBatdau.Text = "Bắt đầu"
        Me.clhBatdau.Width = 82
        '
        'clhKetthuc
        '
        Me.clhKetthuc.Text = "Kết thúc"
        Me.clhKetthuc.Width = 89
        '
        'clhNhanvien
        '
        Me.clhNhanvien.Text = "Nhân viên"
        Me.clhNhanvien.Width = 121
        '
        'clhThungan
        '
        Me.clhThungan.Text = "Thu ngân"
        Me.clhThungan.Width = 144
        '
        'frmThongkedoanhthu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(897, 488)
        Me.Controls.Add(Me.dtpDen)
        Me.Controls.Add(Me.dtpTu)
        Me.Controls.Add(Me.lblDen)
        Me.Controls.Add(Me.lblTu)
        Me.Controls.Add(Me.lsvThongkedoanhthu)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThongkedoanhthu"
        Me.Text = "Thống kê doanh thu"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbInbaocao As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lsvThongkedoanhthu As System.Windows.Forms.ListView
    Friend WithEvents clhStt As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhNgay As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhSo As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhTienhang As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhGiamgia As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhDichvu As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhTongtien As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhBatdau As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhKetthuc As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhNhanvien As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhThungan As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTu As System.Windows.Forms.Label
    Friend WithEvents dtpTu As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDen As System.Windows.Forms.Label
    Friend WithEvents dtpDen As System.Windows.Forms.DateTimePicker
End Class
