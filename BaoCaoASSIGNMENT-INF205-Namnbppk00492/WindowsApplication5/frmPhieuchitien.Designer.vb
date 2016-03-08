<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuchitien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuchitien))
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnGhidulieu = New System.Windows.Forms.Button()
        Me.cbbLoaiphieuchi = New System.Windows.Forms.ComboBox()
        Me.dtpNgay = New System.Windows.Forms.DateTimePicker()
        Me.txtGhichu = New System.Windows.Forms.TextBox()
        Me.txtSotien = New System.Windows.Forms.TextBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtNguoinhan = New System.Windows.Forms.TextBox()
        Me.txtLydochi = New System.Windows.Forms.TextBox()
        Me.txtSophieuchi = New System.Windows.Forms.TextBox()
        Me.lblGhichu = New System.Windows.Forms.Label()
        Me.lblSotien = New System.Windows.Forms.Label()
        Me.lblDiachi = New System.Windows.Forms.Label()
        Me.lblNguoinoptien = New System.Windows.Forms.Label()
        Me.lblLydochi = New System.Windows.Forms.Label()
        Me.lblLoaiphieuchi = New System.Windows.Forms.Label()
        Me.lblNgay = New System.Windows.Forms.Label()
        Me.lblSophieuchi = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnIndulieu = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(428, 359)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(89, 27)
        Me.btnThoat.TabIndex = 23
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnGhidulieu
        '
        Me.btnGhidulieu.Location = New System.Drawing.Point(295, 359)
        Me.btnGhidulieu.Name = "btnGhidulieu"
        Me.btnGhidulieu.Size = New System.Drawing.Size(99, 27)
        Me.btnGhidulieu.TabIndex = 22
        Me.btnGhidulieu.Text = "Ghi dữ liệu"
        Me.btnGhidulieu.UseVisualStyleBackColor = True
        '
        'cbbLoaiphieuchi
        '
        Me.cbbLoaiphieuchi.FormattingEnabled = True
        Me.cbbLoaiphieuchi.Location = New System.Drawing.Point(137, 105)
        Me.cbbLoaiphieuchi.Name = "cbbLoaiphieuchi"
        Me.cbbLoaiphieuchi.Size = New System.Drawing.Size(380, 21)
        Me.cbbLoaiphieuchi.TabIndex = 20
        '
        'dtpNgay
        '
        Me.dtpNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgay.Location = New System.Drawing.Point(413, 66)
        Me.dtpNgay.Name = "dtpNgay"
        Me.dtpNgay.Size = New System.Drawing.Size(104, 20)
        Me.dtpNgay.TabIndex = 19
        '
        'txtGhichu
        '
        Me.txtGhichu.Location = New System.Drawing.Point(137, 318)
        Me.txtGhichu.Name = "txtGhichu"
        Me.txtGhichu.Size = New System.Drawing.Size(380, 20)
        Me.txtGhichu.TabIndex = 17
        '
        'txtSotien
        '
        Me.txtSotien.Location = New System.Drawing.Point(137, 273)
        Me.txtSotien.Name = "txtSotien"
        Me.txtSotien.Size = New System.Drawing.Size(152, 20)
        Me.txtSotien.TabIndex = 16
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(137, 228)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(380, 20)
        Me.txtDiachi.TabIndex = 15
        '
        'txtNguoinhan
        '
        Me.txtNguoinhan.Location = New System.Drawing.Point(137, 184)
        Me.txtNguoinhan.Name = "txtNguoinhan"
        Me.txtNguoinhan.Size = New System.Drawing.Size(380, 20)
        Me.txtNguoinhan.TabIndex = 18
        '
        'txtLydochi
        '
        Me.txtLydochi.Location = New System.Drawing.Point(137, 148)
        Me.txtLydochi.Name = "txtLydochi"
        Me.txtLydochi.Size = New System.Drawing.Size(380, 20)
        Me.txtLydochi.TabIndex = 14
        '
        'txtSophieuchi
        '
        Me.txtSophieuchi.Location = New System.Drawing.Point(137, 66)
        Me.txtSophieuchi.Name = "txtSophieuchi"
        Me.txtSophieuchi.Size = New System.Drawing.Size(145, 20)
        Me.txtSophieuchi.TabIndex = 13
        '
        'lblGhichu
        '
        Me.lblGhichu.AutoSize = True
        Me.lblGhichu.Location = New System.Drawing.Point(14, 325)
        Me.lblGhichu.Name = "lblGhichu"
        Me.lblGhichu.Size = New System.Drawing.Size(50, 13)
        Me.lblGhichu.TabIndex = 11
        Me.lblGhichu.Text = "Ghi chú :"
        '
        'lblSotien
        '
        Me.lblSotien.AutoSize = True
        Me.lblSotien.Location = New System.Drawing.Point(14, 280)
        Me.lblSotien.Name = "lblSotien"
        Me.lblSotien.Size = New System.Drawing.Size(46, 13)
        Me.lblSotien.TabIndex = 10
        Me.lblSotien.Text = "Số tiền :"
        '
        'lblDiachi
        '
        Me.lblDiachi.AutoSize = True
        Me.lblDiachi.Location = New System.Drawing.Point(14, 235)
        Me.lblDiachi.Name = "lblDiachi"
        Me.lblDiachi.Size = New System.Drawing.Size(46, 13)
        Me.lblDiachi.TabIndex = 9
        Me.lblDiachi.Text = "Địa chỉ :"
        '
        'lblNguoinoptien
        '
        Me.lblNguoinoptien.AutoSize = True
        Me.lblNguoinoptien.Location = New System.Drawing.Point(14, 191)
        Me.lblNguoinoptien.Name = "lblNguoinoptien"
        Me.lblNguoinoptien.Size = New System.Drawing.Size(68, 13)
        Me.lblNguoinoptien.TabIndex = 8
        Me.lblNguoinoptien.Text = "Người nhận :"
        '
        'lblLydochi
        '
        Me.lblLydochi.AutoSize = True
        Me.lblLydochi.Location = New System.Drawing.Point(14, 155)
        Me.lblLydochi.Name = "lblLydochi"
        Me.lblLydochi.Size = New System.Drawing.Size(56, 13)
        Me.lblLydochi.TabIndex = 7
        Me.lblLydochi.Text = "Lý do chi :"
        '
        'lblLoaiphieuchi
        '
        Me.lblLoaiphieuchi.AutoSize = True
        Me.lblLoaiphieuchi.Location = New System.Drawing.Point(14, 113)
        Me.lblLoaiphieuchi.Name = "lblLoaiphieuchi"
        Me.lblLoaiphieuchi.Size = New System.Drawing.Size(79, 13)
        Me.lblLoaiphieuchi.TabIndex = 6
        Me.lblLoaiphieuchi.Text = "Loại phiếu chi :"
        '
        'lblNgay
        '
        Me.lblNgay.AutoSize = True
        Me.lblNgay.Location = New System.Drawing.Point(356, 69)
        Me.lblNgay.Name = "lblNgay"
        Me.lblNgay.Size = New System.Drawing.Size(38, 13)
        Me.lblNgay.TabIndex = 12
        Me.lblNgay.Text = "Ngày :"
        '
        'lblSophieuchi
        '
        Me.lblSophieuchi.AutoSize = True
        Me.lblSophieuchi.Location = New System.Drawing.Point(14, 69)
        Me.lblSophieuchi.Name = "lblSophieuchi"
        Me.lblSophieuchi.Size = New System.Drawing.Size(72, 13)
        Me.lblSophieuchi.TabIndex = 5
        Me.lblSophieuchi.Text = "Số phiếu chi :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.phieuchi_tien2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(547, 50)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'btnIndulieu
        '
        Me.btnIndulieu.Image = Global.WindowsApplication5.My.Resources.Resources.máy_in
        Me.btnIndulieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIndulieu.Location = New System.Drawing.Point(161, 359)
        Me.btnIndulieu.Name = "btnIndulieu"
        Me.btnIndulieu.Size = New System.Drawing.Size(90, 27)
        Me.btnIndulieu.TabIndex = 21
        Me.btnIndulieu.Text = "In dữ liệu"
        Me.btnIndulieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIndulieu.UseVisualStyleBackColor = True
        '
        'frmPhieuchitien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(548, 414)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnGhidulieu)
        Me.Controls.Add(Me.btnIndulieu)
        Me.Controls.Add(Me.cbbLoaiphieuchi)
        Me.Controls.Add(Me.dtpNgay)
        Me.Controls.Add(Me.txtGhichu)
        Me.Controls.Add(Me.txtSotien)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txtNguoinhan)
        Me.Controls.Add(Me.txtLydochi)
        Me.Controls.Add(Me.txtSophieuchi)
        Me.Controls.Add(Me.lblGhichu)
        Me.Controls.Add(Me.lblSotien)
        Me.Controls.Add(Me.lblDiachi)
        Me.Controls.Add(Me.lblNguoinoptien)
        Me.Controls.Add(Me.lblLydochi)
        Me.Controls.Add(Me.lblLoaiphieuchi)
        Me.Controls.Add(Me.lblNgay)
        Me.Controls.Add(Me.lblSophieuchi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPhieuchitien"
        Me.Text = "Phiếu chi tiền"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnGhidulieu As System.Windows.Forms.Button
    Friend WithEvents btnIndulieu As System.Windows.Forms.Button
    Friend WithEvents cbbLoaiphieuchi As System.Windows.Forms.ComboBox
    Friend WithEvents dtpNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtGhichu As System.Windows.Forms.TextBox
    Friend WithEvents txtSotien As System.Windows.Forms.TextBox
    Friend WithEvents txtDiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtNguoinhan As System.Windows.Forms.TextBox
    Friend WithEvents txtLydochi As System.Windows.Forms.TextBox
    Friend WithEvents txtSophieuchi As System.Windows.Forms.TextBox
    Friend WithEvents lblGhichu As System.Windows.Forms.Label
    Friend WithEvents lblSotien As System.Windows.Forms.Label
    Friend WithEvents lblDiachi As System.Windows.Forms.Label
    Friend WithEvents lblNguoinoptien As System.Windows.Forms.Label
    Friend WithEvents lblLydochi As System.Windows.Forms.Label
    Friend WithEvents lblLoaiphieuchi As System.Windows.Forms.Label
    Friend WithEvents lblNgay As System.Windows.Forms.Label
    Friend WithEvents lblSophieuchi As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
