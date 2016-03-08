<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoaisanpham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoaisanpham))
        Me.lblMaloaisanpham = New System.Windows.Forms.Label()
        Me.lblDonvitinh = New System.Windows.Forms.Label()
        Me.txtMaloaisanpham = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsvLoaisanpham = New System.Windows.Forms.ListView()
        Me.cllSTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhMaloaisanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhTenloaisanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtTenloaisanpham = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMaloaisanpham
        '
        Me.lblMaloaisanpham.AutoSize = True
        Me.lblMaloaisanpham.Location = New System.Drawing.Point(24, 55)
        Me.lblMaloaisanpham.Name = "lblMaloaisanpham"
        Me.lblMaloaisanpham.Size = New System.Drawing.Size(96, 13)
        Me.lblMaloaisanpham.TabIndex = 0
        Me.lblMaloaisanpham.Text = "Mã loại sản phẩm :"
        '
        'lblDonvitinh
        '
        Me.lblDonvitinh.AutoSize = True
        Me.lblDonvitinh.Location = New System.Drawing.Point(24, 116)
        Me.lblDonvitinh.Name = "lblDonvitinh"
        Me.lblDonvitinh.Size = New System.Drawing.Size(100, 13)
        Me.lblDonvitinh.TabIndex = 0
        Me.lblDonvitinh.Text = "Tên loại sản phẩm :"
        '
        'txtMaloaisanpham
        '
        Me.txtMaloaisanpham.Location = New System.Drawing.Point(126, 52)
        Me.txtMaloaisanpham.Name = "txtMaloaisanpham"
        Me.txtMaloaisanpham.Size = New System.Drawing.Size(171, 20)
        Me.txtMaloaisanpham.TabIndex = 0
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Yellow
        Me.btnThem.Location = New System.Drawing.Point(22, 174)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 29)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Red
        Me.btnXoa.Location = New System.Drawing.Point(222, 174)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 29)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.Red
        Me.btnSua.Location = New System.Drawing.Point(126, 174)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 29)
        Me.btnSua.TabIndex = 3
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.BlueViolet
        Me.GroupBox1.Controls.Add(Me.lsvLoaisanpham)
        Me.GroupBox1.Controls.Add(Me.btnThem)
        Me.GroupBox1.Controls.Add(Me.btnSua)
        Me.GroupBox1.Controls.Add(Me.lblMaloaisanpham)
        Me.GroupBox1.Controls.Add(Me.btnXoa)
        Me.GroupBox1.Controls.Add(Me.lblDonvitinh)
        Me.GroupBox1.Controls.Add(Me.txtTenloaisanpham)
        Me.GroupBox1.Controls.Add(Me.txtMaloaisanpham)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 234)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'lsvLoaisanpham
        '
        Me.lsvLoaisanpham.BackColor = System.Drawing.Color.LawnGreen
        Me.lsvLoaisanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cllSTT, Me.clhMaloaisanpham, Me.clhTenloaisanpham})
        Me.lsvLoaisanpham.FullRowSelect = True
        Me.lsvLoaisanpham.GridLines = True
        Me.lsvLoaisanpham.Location = New System.Drawing.Point(331, 52)
        Me.lsvLoaisanpham.Name = "lsvLoaisanpham"
        Me.lsvLoaisanpham.Size = New System.Drawing.Size(273, 171)
        Me.lsvLoaisanpham.TabIndex = 5
        Me.lsvLoaisanpham.UseCompatibleStateImageBehavior = False
        Me.lsvLoaisanpham.View = System.Windows.Forms.View.Details
        '
        'cllSTT
        '
        Me.cllSTT.Text = "STT"
        Me.cllSTT.Width = 48
        '
        'clhMaloaisanpham
        '
        Me.clhMaloaisanpham.Text = "Mã loại sản phẩm"
        Me.clhMaloaisanpham.Width = 113
        '
        'clhTenloaisanpham
        '
        Me.clhTenloaisanpham.Text = "Tên loại sản phẩm"
        Me.clhTenloaisanpham.Width = 107
        '
        'txtTenloaisanpham
        '
        Me.txtTenloaisanpham.Location = New System.Drawing.Point(126, 113)
        Me.txtTenloaisanpham.Name = "txtTenloaisanpham"
        Me.txtTenloaisanpham.Size = New System.Drawing.Size(171, 20)
        Me.txtTenloaisanpham.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "LOẠI SẢN PHẨM"
        '
        'frmLoaisanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(634, 285)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoaisanpham"
        Me.Text = "Loại sản phẩm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaloaisanpham As System.Windows.Forms.Label
    Friend WithEvents lblDonvitinh As System.Windows.Forms.Label
    Friend WithEvents txtMaloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTenloaisanpham As TextBox
    Friend WithEvents lsvLoaisanpham As ListView
    Friend WithEvents cllSTT As ColumnHeader
    Friend WithEvents clhMaloaisanpham As ColumnHeader
    Friend WithEvents clhTenloaisanpham As ColumnHeader
    Friend WithEvents Label1 As Label
End Class
