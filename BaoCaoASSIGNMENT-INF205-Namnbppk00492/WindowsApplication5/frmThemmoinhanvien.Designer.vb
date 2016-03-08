<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemmoinhanvien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemmoinhanvien))
        Me.lblNhanvien = New System.Windows.Forms.Label()
        Me.lblLuongca = New System.Windows.Forms.Label()
        Me.txtNhanvien = New System.Windows.Forms.TextBox()
        Me.txtLuongca = New System.Windows.Forms.TextBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.cbbCalamviec = New System.Windows.Forms.ComboBox()
        Me.lblCalamviec = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNhanvien
        '
        Me.lblNhanvien.AutoSize = True
        Me.lblNhanvien.Location = New System.Drawing.Point(12, 41)
        Me.lblNhanvien.Name = "lblNhanvien"
        Me.lblNhanvien.Size = New System.Drawing.Size(62, 13)
        Me.lblNhanvien.TabIndex = 0
        Me.lblNhanvien.Text = "Nhân viên :"
        '
        'lblLuongca
        '
        Me.lblLuongca.AutoSize = True
        Me.lblLuongca.Location = New System.Drawing.Point(12, 81)
        Me.lblLuongca.Name = "lblLuongca"
        Me.lblLuongca.Size = New System.Drawing.Size(58, 13)
        Me.lblLuongca.TabIndex = 0
        Me.lblLuongca.Text = "Lương ca :"
        '
        'txtNhanvien
        '
        Me.txtNhanvien.Location = New System.Drawing.Point(94, 38)
        Me.txtNhanvien.Name = "txtNhanvien"
        Me.txtNhanvien.Size = New System.Drawing.Size(178, 20)
        Me.txtNhanvien.TabIndex = 1
        '
        'txtLuongca
        '
        Me.txtLuongca.Location = New System.Drawing.Point(94, 78)
        Me.txtLuongca.Name = "txtLuongca"
        Me.txtLuongca.Size = New System.Drawing.Size(178, 20)
        Me.txtLuongca.TabIndex = 1
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(197, 175)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 2
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(82, 175)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'cbbCalamviec
        '
        Me.cbbCalamviec.FormattingEnabled = True
        Me.cbbCalamviec.Items.AddRange(New Object() {"Ca sáng", "Ca trưa", "Ca tối"})
        Me.cbbCalamviec.Location = New System.Drawing.Point(94, 116)
        Me.cbbCalamviec.Name = "cbbCalamviec"
        Me.cbbCalamviec.Size = New System.Drawing.Size(178, 21)
        Me.cbbCalamviec.TabIndex = 3
        '
        'lblCalamviec
        '
        Me.lblCalamviec.AutoSize = True
        Me.lblCalamviec.Location = New System.Drawing.Point(12, 119)
        Me.lblCalamviec.Name = "lblCalamviec"
        Me.lblCalamviec.Size = New System.Drawing.Size(68, 13)
        Me.lblCalamviec.TabIndex = 0
        Me.lblCalamviec.Text = "Ca làm việc :"
        '
        'frmThemmoinhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(302, 229)
        Me.Controls.Add(Me.cbbCalamviec)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.txtLuongca)
        Me.Controls.Add(Me.txtNhanvien)
        Me.Controls.Add(Me.lblCalamviec)
        Me.Controls.Add(Me.lblLuongca)
        Me.Controls.Add(Me.lblNhanvien)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThemmoinhanvien"
        Me.Text = "Nhân viên"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNhanvien As System.Windows.Forms.Label
    Friend WithEvents lblLuongca As System.Windows.Forms.Label
    Friend WithEvents txtNhanvien As System.Windows.Forms.TextBox
    Friend WithEvents txtLuongca As System.Windows.Forms.TextBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents cbbCalamviec As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalamviec As System.Windows.Forms.Label
End Class
