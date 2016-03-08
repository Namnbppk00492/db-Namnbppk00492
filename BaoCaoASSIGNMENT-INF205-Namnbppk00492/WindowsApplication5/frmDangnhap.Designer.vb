<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangnhap))
        Me.lblTaikhoan = New System.Windows.Forms.Label()
        Me.lblMatkhau = New System.Windows.Forms.Label()
        Me.txtTaikhoan = New System.Windows.Forms.TextBox()
        Me.txtMatkhau = New System.Windows.Forms.TextBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.ckbGhinhomatkhau = New System.Windows.Forms.CheckBox()
        Me.ckbTudongdangnhap = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDangnhap = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTaikhoan
        '
        Me.lblTaikhoan.AutoSize = True
        Me.lblTaikhoan.BackColor = System.Drawing.Color.Transparent
        Me.lblTaikhoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaikhoan.Location = New System.Drawing.Point(137, 98)
        Me.lblTaikhoan.Name = "lblTaikhoan"
        Me.lblTaikhoan.Size = New System.Drawing.Size(73, 13)
        Me.lblTaikhoan.TabIndex = 0
        Me.lblTaikhoan.Text = "Tài Khoản :"
        '
        'lblMatkhau
        '
        Me.lblMatkhau.AutoSize = True
        Me.lblMatkhau.BackColor = System.Drawing.Color.Transparent
        Me.lblMatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatkhau.Location = New System.Drawing.Point(141, 132)
        Me.lblMatkhau.Name = "lblMatkhau"
        Me.lblMatkhau.Size = New System.Drawing.Size(68, 13)
        Me.lblMatkhau.TabIndex = 0
        Me.lblMatkhau.Text = "Mật khẩu :"
        '
        'txtTaikhoan
        '
        Me.txtTaikhoan.Location = New System.Drawing.Point(220, 95)
        Me.txtTaikhoan.Name = "txtTaikhoan"
        Me.txtTaikhoan.Size = New System.Drawing.Size(172, 20)
        Me.txtTaikhoan.TabIndex = 1
        '
        'txtMatkhau
        '
        Me.txtMatkhau.Location = New System.Drawing.Point(220, 129)
        Me.txtMatkhau.Name = "txtMatkhau"
        Me.txtMatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatkhau.Size = New System.Drawing.Size(172, 20)
        Me.txtMatkhau.TabIndex = 2
        Me.txtMatkhau.UseSystemPasswordChar = True
        '
        'btnThoat
        '
        Me.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnThoat.Location = New System.Drawing.Point(317, 208)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'ckbGhinhomatkhau
        '
        Me.ckbGhinhomatkhau.AutoSize = True
        Me.ckbGhinhomatkhau.BackColor = System.Drawing.Color.Transparent
        Me.ckbGhinhomatkhau.Location = New System.Drawing.Point(220, 155)
        Me.ckbGhinhomatkhau.Name = "ckbGhinhomatkhau"
        Me.ckbGhinhomatkhau.Size = New System.Drawing.Size(110, 17)
        Me.ckbGhinhomatkhau.TabIndex = 3
        Me.ckbGhinhomatkhau.Text = "Ghi nhớ mật khẩu"
        Me.ckbGhinhomatkhau.UseVisualStyleBackColor = False
        '
        'ckbTudongdangnhap
        '
        Me.ckbTudongdangnhap.AutoSize = True
        Me.ckbTudongdangnhap.BackColor = System.Drawing.Color.Transparent
        Me.ckbTudongdangnhap.Location = New System.Drawing.Point(220, 178)
        Me.ckbTudongdangnhap.Name = "ckbTudongdangnhap"
        Me.ckbTudongdangnhap.Size = New System.Drawing.Size(122, 17)
        Me.ckbTudongdangnhap.TabIndex = 4
        Me.ckbTudongdangnhap.Text = "Tự động đăng nhập"
        Me.ckbTudongdangnhap.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.Bìa
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 77)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnDangnhap
        '
        Me.btnDangnhap.Location = New System.Drawing.Point(220, 208)
        Me.btnDangnhap.Name = "btnDangnhap"
        Me.btnDangnhap.Size = New System.Drawing.Size(75, 23)
        Me.btnDangnhap.TabIndex = 8
        Me.btnDangnhap.Text = "Đăng nhập"
        Me.btnDangnhap.UseVisualStyleBackColor = True
        '
        'frmDangnhap
        '
        Me.AcceptButton = Me.btnDangnhap
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = Global.WindowsApplication5.My.Resources.Resources.LoginBG
        Me.CancelButton = Me.btnThoat
        Me.ClientSize = New System.Drawing.Size(412, 253)
        Me.Controls.Add(Me.btnDangnhap)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ckbTudongdangnhap)
        Me.Controls.Add(Me.ckbGhinhomatkhau)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.txtMatkhau)
        Me.Controls.Add(Me.txtTaikhoan)
        Me.Controls.Add(Me.lblMatkhau)
        Me.Controls.Add(Me.lblTaikhoan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDangnhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTaikhoan As System.Windows.Forms.Label
    Friend WithEvents lblMatkhau As System.Windows.Forms.Label
    Friend WithEvents txtTaikhoan As System.Windows.Forms.TextBox
    Friend WithEvents txtMatkhau As System.Windows.Forms.TextBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents ckbGhinhomatkhau As System.Windows.Forms.CheckBox
    Friend WithEvents ckbTudongdangnhap As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDangnhap As System.Windows.Forms.Button
End Class
