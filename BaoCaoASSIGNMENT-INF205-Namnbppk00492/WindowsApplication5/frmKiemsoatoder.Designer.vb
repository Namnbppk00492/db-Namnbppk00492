<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKiemsoatoder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKiemsoatoder))
        Me.dtpTu = New System.Windows.Forms.DateTimePicker()
        Me.dtpDen = New System.Windows.Forms.DateTimePicker()
        Me.lblTu = New System.Windows.Forms.Label()
        Me.lblDen = New System.Windows.Forms.Label()
        Me.lsvKiemsoatorder = New System.Windows.Forms.ListView()
        Me.clhStt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhNgay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhSobill = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhSoorder = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhNhanvien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhThungan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhBatdau = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhKetthuc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhTongcong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvOrderloi = New System.Windows.Forms.ListView()
        Me.clhSttorderloi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhOrderloi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvOrdertontai = New System.Windows.Forms.ListView()
        Me.clhSttodertontai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhOdertontai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'dtpTu
        '
        Me.dtpTu.CustomFormat = "dd/MM/yyyy"
        Me.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTu.Location = New System.Drawing.Point(58, 12)
        Me.dtpTu.Name = "dtpTu"
        Me.dtpTu.Size = New System.Drawing.Size(96, 20)
        Me.dtpTu.TabIndex = 0
        '
        'dtpDen
        '
        Me.dtpDen.CustomFormat = "dd/MM/yyyy"
        Me.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDen.Location = New System.Drawing.Point(214, 12)
        Me.dtpDen.Name = "dtpDen"
        Me.dtpDen.Size = New System.Drawing.Size(96, 20)
        Me.dtpDen.TabIndex = 0
        '
        'lblTu
        '
        Me.lblTu.AutoSize = True
        Me.lblTu.Location = New System.Drawing.Point(26, 19)
        Me.lblTu.Name = "lblTu"
        Me.lblTu.Size = New System.Drawing.Size(26, 13)
        Me.lblTu.TabIndex = 1
        Me.lblTu.Text = "Từ :"
        '
        'lblDen
        '
        Me.lblDen.AutoSize = True
        Me.lblDen.Location = New System.Drawing.Point(175, 18)
        Me.lblDen.Name = "lblDen"
        Me.lblDen.Size = New System.Drawing.Size(33, 13)
        Me.lblDen.TabIndex = 1
        Me.lblDen.Text = "Đến :"
        '
        'lsvKiemsoatorder
        '
        Me.lsvKiemsoatorder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhStt, Me.clhNgay, Me.clhSobill, Me.clhSoorder, Me.clhNhanvien, Me.clhThungan, Me.clhBatdau, Me.clhKetthuc, Me.clhTongcong})
        Me.lsvKiemsoatorder.FullRowSelect = True
        Me.lsvKiemsoatorder.GridLines = True
        Me.lsvKiemsoatorder.Location = New System.Drawing.Point(2, 49)
        Me.lsvKiemsoatorder.Name = "lsvKiemsoatorder"
        Me.lsvKiemsoatorder.Size = New System.Drawing.Size(735, 486)
        Me.lsvKiemsoatorder.TabIndex = 2
        Me.lsvKiemsoatorder.UseCompatibleStateImageBehavior = False
        Me.lsvKiemsoatorder.View = System.Windows.Forms.View.Details
        '
        'clhStt
        '
        Me.clhStt.Text = "STT"
        '
        'clhNgay
        '
        Me.clhNgay.Text = "Ngày"
        '
        'clhSobill
        '
        Me.clhSobill.Text = "Số bill"
        Me.clhSobill.Width = 75
        '
        'clhSoorder
        '
        Me.clhSoorder.Text = "Số order"
        '
        'clhNhanvien
        '
        Me.clhNhanvien.Text = "Nhân viên"
        Me.clhNhanvien.Width = 141
        '
        'clhThungan
        '
        Me.clhThungan.Text = "Thu ngân"
        Me.clhThungan.Width = 123
        '
        'clhBatdau
        '
        Me.clhBatdau.Text = "Bắt đầu"
        Me.clhBatdau.Width = 74
        '
        'clhKetthuc
        '
        Me.clhKetthuc.Text = "Kêt thúc"
        Me.clhKetthuc.Width = 77
        '
        'clhTongcong
        '
        Me.clhTongcong.Text = "Tổng cộng"
        Me.clhTongcong.Width = 92
        '
        'lsvOrderloi
        '
        Me.lsvOrderloi.AllowColumnReorder = True
        Me.lsvOrderloi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhSttorderloi, Me.clhOrderloi})
        Me.lsvOrderloi.FullRowSelect = True
        Me.lsvOrderloi.GridLines = True
        Me.lsvOrderloi.Location = New System.Drawing.Point(743, 296)
        Me.lsvOrderloi.Name = "lsvOrderloi"
        Me.lsvOrderloi.Size = New System.Drawing.Size(300, 239)
        Me.lsvOrderloi.TabIndex = 3
        Me.lsvOrderloi.UseCompatibleStateImageBehavior = False
        Me.lsvOrderloi.View = System.Windows.Forms.View.Details
        '
        'clhSttorderloi
        '
        Me.clhSttorderloi.Text = "STT"
        '
        'clhOrderloi
        '
        Me.clhOrderloi.Text = "Order lỗi"
        Me.clhOrderloi.Width = 235
        '
        'lsvOrdertontai
        '
        Me.lsvOrdertontai.AllowColumnReorder = True
        Me.lsvOrdertontai.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhSttodertontai, Me.clhOdertontai})
        Me.lsvOrdertontai.FullRowSelect = True
        Me.lsvOrdertontai.GridLines = True
        Me.lsvOrdertontai.Location = New System.Drawing.Point(743, 49)
        Me.lsvOrdertontai.Name = "lsvOrdertontai"
        Me.lsvOrdertontai.Size = New System.Drawing.Size(300, 241)
        Me.lsvOrdertontai.TabIndex = 3
        Me.lsvOrdertontai.UseCompatibleStateImageBehavior = False
        Me.lsvOrdertontai.View = System.Windows.Forms.View.Details
        '
        'clhSttodertontai
        '
        Me.clhSttodertontai.Text = "STT"
        Me.clhSttodertontai.Width = 40
        '
        'clhOdertontai
        '
        Me.clhOdertontai.Text = "Order tồn tại"
        Me.clhOdertontai.Width = 256
        '
        'frmKiemsoatoder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1044, 537)
        Me.Controls.Add(Me.lsvOrdertontai)
        Me.Controls.Add(Me.lsvOrderloi)
        Me.Controls.Add(Me.lsvKiemsoatorder)
        Me.Controls.Add(Me.lblDen)
        Me.Controls.Add(Me.lblTu)
        Me.Controls.Add(Me.dtpDen)
        Me.Controls.Add(Me.dtpTu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKiemsoatoder"
        Me.Text = "Kiểm soát oder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpTu As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDen As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTu As System.Windows.Forms.Label
    Friend WithEvents lblDen As System.Windows.Forms.Label
    Friend WithEvents lsvKiemsoatorder As System.Windows.Forms.ListView
    Friend WithEvents lsvOrderloi As System.Windows.Forms.ListView
    Friend WithEvents lsvOrdertontai As System.Windows.Forms.ListView
    Friend WithEvents clhStt As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhNgay As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhSobill As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhSoorder As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhNhanvien As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhThungan As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhBatdau As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhKetthuc As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhTongcong As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhSttorderloi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhOrderloi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhSttodertontai As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhOdertontai As System.Windows.Forms.ColumnHeader
End Class
