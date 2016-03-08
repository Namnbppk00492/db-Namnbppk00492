<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuthutien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuthutien))
        Me.lblSophieuthu = New System.Windows.Forms.Label()
        Me.lblLoaiphieuthu = New System.Windows.Forms.Label()
        Me.lblLydothu = New System.Windows.Forms.Label()
        Me.lblNguoinoptien = New System.Windows.Forms.Label()
        Me.lblDiachi = New System.Windows.Forms.Label()
        Me.lblSotien = New System.Windows.Forms.Label()
        Me.lblGhichu = New System.Windows.Forms.Label()
        Me.txtSophieuthu = New System.Windows.Forms.TextBox()
        Me.lblNgay = New System.Windows.Forms.Label()
        Me.dtpNgay = New System.Windows.Forms.DateTimePicker()
        Me.cbbLoaiphieuthu = New System.Windows.Forms.ComboBox()
        Me.txtLydothu = New System.Windows.Forms.TextBox()
        Me.txtNguoinoptien = New System.Windows.Forms.TextBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtSotien = New System.Windows.Forms.TextBox()
        Me.txtGhichu = New System.Windows.Forms.TextBox()
        Me.btnGhidulieu = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnIndulieu = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSophieuthu
        '
        Me.lblSophieuthu.AutoSize = True
        Me.lblSophieuthu.Location = New System.Drawing.Point(12, 65)
        Me.lblSophieuthu.Name = "lblSophieuthu"
        Me.lblSophieuthu.Size = New System.Drawing.Size(73, 13)
        Me.lblSophieuthu.TabIndex = 0
        Me.lblSophieuthu.Text = "Số phiếu thu :"
        '
        'lblLoaiphieuthu
        '
        Me.lblLoaiphieuthu.AutoSize = True
        Me.lblLoaiphieuthu.Location = New System.Drawing.Point(12, 104)
        Me.lblLoaiphieuthu.Name = "lblLoaiphieuthu"
        Me.lblLoaiphieuthu.Size = New System.Drawing.Size(80, 13)
        Me.lblLoaiphieuthu.TabIndex = 0
        Me.lblLoaiphieuthu.Text = "Loại phiếu thu :"
        '
        'lblLydothu
        '
        Me.lblLydothu.AutoSize = True
        Me.lblLydothu.Location = New System.Drawing.Point(12, 144)
        Me.lblLydothu.Name = "lblLydothu"
        Me.lblLydothu.Size = New System.Drawing.Size(57, 13)
        Me.lblLydothu.TabIndex = 0
        Me.lblLydothu.Text = "Lý do thu :"
        '
        'lblNguoinoptien
        '
        Me.lblNguoinoptien.AutoSize = True
        Me.lblNguoinoptien.Location = New System.Drawing.Point(12, 187)
        Me.lblNguoinoptien.Name = "lblNguoinoptien"
        Me.lblNguoinoptien.Size = New System.Drawing.Size(82, 13)
        Me.lblNguoinoptien.TabIndex = 0
        Me.lblNguoinoptien.Text = "Người nộp tiền :"
        '
        'lblDiachi
        '
        Me.lblDiachi.AutoSize = True
        Me.lblDiachi.Location = New System.Drawing.Point(12, 231)
        Me.lblDiachi.Name = "lblDiachi"
        Me.lblDiachi.Size = New System.Drawing.Size(46, 13)
        Me.lblDiachi.TabIndex = 0
        Me.lblDiachi.Text = "Địa chỉ :"
        '
        'lblSotien
        '
        Me.lblSotien.AutoSize = True
        Me.lblSotien.Location = New System.Drawing.Point(12, 276)
        Me.lblSotien.Name = "lblSotien"
        Me.lblSotien.Size = New System.Drawing.Size(46, 13)
        Me.lblSotien.TabIndex = 0
        Me.lblSotien.Text = "Số tiền :"
        '
        'lblGhichu
        '
        Me.lblGhichu.AutoSize = True
        Me.lblGhichu.Location = New System.Drawing.Point(12, 321)
        Me.lblGhichu.Name = "lblGhichu"
        Me.lblGhichu.Size = New System.Drawing.Size(50, 13)
        Me.lblGhichu.TabIndex = 0
        Me.lblGhichu.Text = "Ghi chú :"
        '
        'txtSophieuthu
        '
        Me.txtSophieuthu.Location = New System.Drawing.Point(135, 62)
        Me.txtSophieuthu.Name = "txtSophieuthu"
        Me.txtSophieuthu.Size = New System.Drawing.Size(145, 20)
        Me.txtSophieuthu.TabIndex = 1
        '
        'lblNgay
        '
        Me.lblNgay.AutoSize = True
        Me.lblNgay.Location = New System.Drawing.Point(354, 65)
        Me.lblNgay.Name = "lblNgay"
        Me.lblNgay.Size = New System.Drawing.Size(38, 13)
        Me.lblNgay.TabIndex = 0
        Me.lblNgay.Text = "Ngày :"
        '
        'dtpNgay
        '
        Me.dtpNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgay.Location = New System.Drawing.Point(411, 62)
        Me.dtpNgay.Name = "dtpNgay"
        Me.dtpNgay.Size = New System.Drawing.Size(104, 20)
        Me.dtpNgay.TabIndex = 2
        '
        'cbbLoaiphieuthu
        '
        Me.cbbLoaiphieuthu.FormattingEnabled = True
        Me.cbbLoaiphieuthu.Location = New System.Drawing.Point(135, 101)
        Me.cbbLoaiphieuthu.Name = "cbbLoaiphieuthu"
        Me.cbbLoaiphieuthu.Size = New System.Drawing.Size(380, 21)
        Me.cbbLoaiphieuthu.TabIndex = 3
        '
        'txtLydothu
        '
        Me.txtLydothu.Location = New System.Drawing.Point(135, 144)
        Me.txtLydothu.Name = "txtLydothu"
        Me.txtLydothu.Size = New System.Drawing.Size(380, 20)
        Me.txtLydothu.TabIndex = 1
        '
        'txtNguoinoptien
        '
        Me.txtNguoinoptien.Location = New System.Drawing.Point(135, 180)
        Me.txtNguoinoptien.Name = "txtNguoinoptien"
        Me.txtNguoinoptien.Size = New System.Drawing.Size(380, 20)
        Me.txtNguoinoptien.TabIndex = 1
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(135, 224)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(380, 20)
        Me.txtDiachi.TabIndex = 1
        '
        'txtSotien
        '
        Me.txtSotien.Location = New System.Drawing.Point(135, 269)
        Me.txtSotien.Name = "txtSotien"
        Me.txtSotien.Size = New System.Drawing.Size(152, 20)
        Me.txtSotien.TabIndex = 1
        '
        'txtGhichu
        '
        Me.txtGhichu.Location = New System.Drawing.Point(135, 314)
        Me.txtGhichu.Name = "txtGhichu"
        Me.txtGhichu.Size = New System.Drawing.Size(380, 20)
        Me.txtGhichu.TabIndex = 1
        '
        'btnGhidulieu
        '
        Me.btnGhidulieu.Location = New System.Drawing.Point(293, 355)
        Me.btnGhidulieu.Name = "btnGhidulieu"
        Me.btnGhidulieu.Size = New System.Drawing.Size(99, 27)
        Me.btnGhidulieu.TabIndex = 4
        Me.btnGhidulieu.Text = "Ghi dữ liệu"
        Me.btnGhidulieu.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(426, 355)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(89, 27)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnIndulieu
        '
        Me.btnIndulieu.Image = Global.WindowsApplication5.My.Resources.Resources.máy_in
        Me.btnIndulieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIndulieu.Location = New System.Drawing.Point(159, 355)
        Me.btnIndulieu.Name = "btnIndulieu"
        Me.btnIndulieu.Size = New System.Drawing.Size(90, 27)
        Me.btnIndulieu.TabIndex = 4
        Me.btnIndulieu.Text = "In dữ liệu"
        Me.btnIndulieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIndulieu.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.phieuthutien
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(547, 50)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmPhieuthutien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(547, 415)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnGhidulieu)
        Me.Controls.Add(Me.btnIndulieu)
        Me.Controls.Add(Me.cbbLoaiphieuthu)
        Me.Controls.Add(Me.dtpNgay)
        Me.Controls.Add(Me.txtGhichu)
        Me.Controls.Add(Me.txtSotien)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txtNguoinoptien)
        Me.Controls.Add(Me.txtLydothu)
        Me.Controls.Add(Me.txtSophieuthu)
        Me.Controls.Add(Me.lblGhichu)
        Me.Controls.Add(Me.lblSotien)
        Me.Controls.Add(Me.lblDiachi)
        Me.Controls.Add(Me.lblNguoinoptien)
        Me.Controls.Add(Me.lblLydothu)
        Me.Controls.Add(Me.lblLoaiphieuthu)
        Me.Controls.Add(Me.lblNgay)
        Me.Controls.Add(Me.lblSophieuthu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPhieuthutien"
        Me.Text = "Phiếu thu tiền"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSophieuthu As System.Windows.Forms.Label
    Friend WithEvents lblLoaiphieuthu As System.Windows.Forms.Label
    Friend WithEvents lblLydothu As System.Windows.Forms.Label
    Friend WithEvents lblNguoinoptien As System.Windows.Forms.Label
    Friend WithEvents lblDiachi As System.Windows.Forms.Label
    Friend WithEvents lblSotien As System.Windows.Forms.Label
    Friend WithEvents lblGhichu As System.Windows.Forms.Label
    Friend WithEvents txtSophieuthu As System.Windows.Forms.TextBox
    Friend WithEvents lblNgay As System.Windows.Forms.Label
    Friend WithEvents dtpNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbbLoaiphieuthu As System.Windows.Forms.ComboBox
    Friend WithEvents txtLydothu As System.Windows.Forms.TextBox
    Friend WithEvents txtNguoinoptien As System.Windows.Forms.TextBox
    Friend WithEvents txtDiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtSotien As System.Windows.Forms.TextBox
    Friend WithEvents txtGhichu As System.Windows.Forms.TextBox
    Friend WithEvents btnIndulieu As System.Windows.Forms.Button
    Friend WithEvents btnGhidulieu As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
