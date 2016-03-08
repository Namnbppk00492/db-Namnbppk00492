<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongkedoanuong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongkedoanuong))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbInbaocao = New System.Windows.Forms.ToolStripButton()
        Me.lblTu = New System.Windows.Forms.Label()
        Me.lblDen = New System.Windows.Forms.Label()
        Me.dtpTu = New System.Windows.Forms.DateTimePicker()
        Me.dtpDen = New System.Windows.Forms.DateTimePicker()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.clhStt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhMathang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhSoluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhDVT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhGiaban = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhTienban = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhGianhap = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhTiennhap = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhLai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhDoanhthu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhNhomhang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbInbaocao})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(919, 25)
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
        'lblTu
        '
        Me.lblTu.AutoSize = True
        Me.lblTu.Location = New System.Drawing.Point(21, 39)
        Me.lblTu.Name = "lblTu"
        Me.lblTu.Size = New System.Drawing.Size(26, 13)
        Me.lblTu.TabIndex = 1
        Me.lblTu.Text = "Từ :"
        '
        'lblDen
        '
        Me.lblDen.AutoSize = True
        Me.lblDen.Location = New System.Drawing.Point(184, 39)
        Me.lblDen.Name = "lblDen"
        Me.lblDen.Size = New System.Drawing.Size(33, 13)
        Me.lblDen.TabIndex = 1
        Me.lblDen.Text = "Đến :"
        '
        'dtpTu
        '
        Me.dtpTu.CustomFormat = "dd/MM/yyyy"
        Me.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTu.Location = New System.Drawing.Point(53, 33)
        Me.dtpTu.Name = "dtpTu"
        Me.dtpTu.Size = New System.Drawing.Size(94, 20)
        Me.dtpTu.TabIndex = 2
        '
        'dtpDen
        '
        Me.dtpDen.CustomFormat = "dd/MM/yyyy"
        Me.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDen.Location = New System.Drawing.Point(223, 33)
        Me.dtpDen.Name = "dtpDen"
        Me.dtpDen.Size = New System.Drawing.Size(94, 20)
        Me.dtpDen.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhStt, Me.clhMathang, Me.clhSoluong, Me.clhDVT, Me.clhGiaban, Me.clhTienban, Me.clhGianhap, Me.clhTiennhap, Me.clhLai, Me.clhDoanhthu, Me.clhNhomhang})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 72)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(919, 479)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'clhStt
        '
        Me.clhStt.Text = "STT"
        Me.clhStt.Width = 35
        '
        'clhMathang
        '
        Me.clhMathang.Text = "Mặt hàng"
        Me.clhMathang.Width = 98
        '
        'clhSoluong
        '
        Me.clhSoluong.Text = "SL"
        Me.clhSoluong.Width = 39
        '
        'clhDVT
        '
        Me.clhDVT.Text = "ĐVT"
        Me.clhDVT.Width = 38
        '
        'clhGiaban
        '
        Me.clhGiaban.Text = "Giá bán"
        Me.clhGiaban.Width = 93
        '
        'clhTienban
        '
        Me.clhTienban.Text = "Tiền bán"
        Me.clhTienban.Width = 81
        '
        'clhGianhap
        '
        Me.clhGianhap.Text = "Giá nhập"
        Me.clhGianhap.Width = 93
        '
        'clhTiennhap
        '
        Me.clhTiennhap.Text = "Tiền nhập"
        Me.clhTiennhap.Width = 117
        '
        'clhLai
        '
        Me.clhLai.Text = "Lãi"
        Me.clhLai.Width = 101
        '
        'clhDoanhthu
        '
        Me.clhDoanhthu.Text = "% Doanh thu"
        Me.clhDoanhthu.Width = 109
        '
        'clhNhomhang
        '
        Me.clhNhomhang.Text = "Nhóm hàng"
        Me.clhNhomhang.Width = 127
        '
        'frmThongkedoanuong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(919, 551)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.dtpDen)
        Me.Controls.Add(Me.dtpTu)
        Me.Controls.Add(Me.lblDen)
        Me.Controls.Add(Me.lblTu)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThongkedoanuong"
        Me.Text = "Thống kê đồ ăn,uống"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbInbaocao As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTu As System.Windows.Forms.Label
    Friend WithEvents lblDen As System.Windows.Forms.Label
    Friend WithEvents dtpTu As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDen As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents clhStt As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhMathang As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhSoluong As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhDVT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhGiaban As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhTienban As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhGianhap As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhTiennhap As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhLai As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhDoanhthu As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhNhomhang As System.Windows.Forms.ColumnHeader
End Class
