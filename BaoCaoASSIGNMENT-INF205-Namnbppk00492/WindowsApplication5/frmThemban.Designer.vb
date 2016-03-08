<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemban
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemban))
        Me.lblTenban = New System.Windows.Forms.Label()
        Me.lblKhuvuc = New System.Windows.Forms.Label()
        Me.lblGhichu = New System.Windows.Forms.Label()
        Me.txtTenban = New System.Windows.Forms.TextBox()
        Me.cbbKhuvuc = New System.Windows.Forms.ComboBox()
        Me.txtGhichu = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTenban
        '
        Me.lblTenban.AutoSize = True
        Me.lblTenban.Location = New System.Drawing.Point(12, 77)
        Me.lblTenban.Name = "lblTenban"
        Me.lblTenban.Size = New System.Drawing.Size(53, 13)
        Me.lblTenban.TabIndex = 0
        Me.lblTenban.Text = "Tên bàn :"
        '
        'lblKhuvuc
        '
        Me.lblKhuvuc.AutoSize = True
        Me.lblKhuvuc.Location = New System.Drawing.Point(12, 123)
        Me.lblKhuvuc.Name = "lblKhuvuc"
        Me.lblKhuvuc.Size = New System.Drawing.Size(53, 13)
        Me.lblKhuvuc.TabIndex = 0
        Me.lblKhuvuc.Text = "Khu vực :"
        '
        'lblGhichu
        '
        Me.lblGhichu.AutoSize = True
        Me.lblGhichu.Location = New System.Drawing.Point(12, 171)
        Me.lblGhichu.Name = "lblGhichu"
        Me.lblGhichu.Size = New System.Drawing.Size(50, 13)
        Me.lblGhichu.TabIndex = 0
        Me.lblGhichu.Text = "Ghi chú :"
        '
        'txtTenban
        '
        Me.txtTenban.Location = New System.Drawing.Point(90, 74)
        Me.txtTenban.Name = "txtTenban"
        Me.txtTenban.Size = New System.Drawing.Size(241, 20)
        Me.txtTenban.TabIndex = 1
        '
        'cbbKhuvuc
        '
        Me.cbbKhuvuc.FormattingEnabled = True
        Me.cbbKhuvuc.Location = New System.Drawing.Point(90, 120)
        Me.cbbKhuvuc.Name = "cbbKhuvuc"
        Me.cbbKhuvuc.Size = New System.Drawing.Size(241, 21)
        Me.cbbKhuvuc.TabIndex = 2
        '
        'txtGhichu
        '
        Me.txtGhichu.Location = New System.Drawing.Point(90, 168)
        Me.txtGhichu.Name = "txtGhichu"
        Me.txtGhichu.Size = New System.Drawing.Size(241, 20)
        Me.txtGhichu.TabIndex = 3
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(117, 215)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(239, 215)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.thong_tin_chi_tiet
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 50)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmThemban
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(355, 262)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtGhichu)
        Me.Controls.Add(Me.cbbKhuvuc)
        Me.Controls.Add(Me.txtTenban)
        Me.Controls.Add(Me.lblGhichu)
        Me.Controls.Add(Me.lblKhuvuc)
        Me.Controls.Add(Me.lblTenban)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThemban"
        Me.Text = "Thông tin bàn"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTenban As System.Windows.Forms.Label
    Friend WithEvents lblKhuvuc As System.Windows.Forms.Label
    Friend WithEvents lblGhichu As System.Windows.Forms.Label
    Friend WithEvents txtTenban As System.Windows.Forms.TextBox
    Friend WithEvents cbbKhuvuc As System.Windows.Forms.ComboBox
    Friend WithEvents txtGhichu As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
