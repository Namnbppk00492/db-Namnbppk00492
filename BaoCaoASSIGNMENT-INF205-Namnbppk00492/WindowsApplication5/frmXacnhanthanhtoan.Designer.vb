<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXacnhanthanhtoan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBan = New System.Windows.Forms.Label()
        Me.lblTongtien = New System.Windows.Forms.Label()
        Me.lblKhachdua = New System.Windows.Forms.Label()
        Me.lblTralai = New System.Windows.Forms.Label()
        Me.txtTongtien = New System.Windows.Forms.TextBox()
        Me.txtKhachdua = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnDongvainbill = New System.Windows.Forms.Button()
        Me.btnDongbillkhongin = New System.Windows.Forms.Button()
        Me.txtHuy = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bạn có muốn thanh toán không ?"
        '
        'lblBan
        '
        Me.lblBan.AutoSize = True
        Me.lblBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBan.ForeColor = System.Drawing.Color.Maroon
        Me.lblBan.Location = New System.Drawing.Point(131, 78)
        Me.lblBan.Name = "lblBan"
        Me.lblBan.Size = New System.Drawing.Size(41, 20)
        Me.lblBan.TabIndex = 1
        Me.lblBan.Text = "Bàn"
        '
        'lblTongtien
        '
        Me.lblTongtien.AutoSize = True
        Me.lblTongtien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTongtien.ForeColor = System.Drawing.Color.Maroon
        Me.lblTongtien.Location = New System.Drawing.Point(131, 124)
        Me.lblTongtien.Name = "lblTongtien"
        Me.lblTongtien.Size = New System.Drawing.Size(94, 20)
        Me.lblTongtien.TabIndex = 1
        Me.lblTongtien.Text = "Tổng tiền :"
        '
        'lblKhachdua
        '
        Me.lblKhachdua.AutoSize = True
        Me.lblKhachdua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKhachdua.ForeColor = System.Drawing.Color.Maroon
        Me.lblKhachdua.Location = New System.Drawing.Point(131, 174)
        Me.lblKhachdua.Name = "lblKhachdua"
        Me.lblKhachdua.Size = New System.Drawing.Size(104, 20)
        Me.lblKhachdua.TabIndex = 1
        Me.lblKhachdua.Text = "Khách đưa :"
        '
        'lblTralai
        '
        Me.lblTralai.AutoSize = True
        Me.lblTralai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTralai.ForeColor = System.Drawing.Color.Maroon
        Me.lblTralai.Location = New System.Drawing.Point(131, 223)
        Me.lblTralai.Name = "lblTralai"
        Me.lblTralai.Size = New System.Drawing.Size(68, 20)
        Me.lblTralai.TabIndex = 1
        Me.lblTralai.Text = "Trả lại :"
        '
        'txtTongtien
        '
        Me.txtTongtien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTongtien.Location = New System.Drawing.Point(299, 118)
        Me.txtTongtien.Name = "txtTongtien"
        Me.txtTongtien.ReadOnly = True
        Me.txtTongtien.Size = New System.Drawing.Size(248, 26)
        Me.txtTongtien.TabIndex = 2
        Me.txtTongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKhachdua
        '
        Me.txtKhachdua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKhachdua.Location = New System.Drawing.Point(299, 168)
        Me.txtKhachdua.Name = "txtKhachdua"
        Me.txtKhachdua.Size = New System.Drawing.Size(248, 26)
        Me.txtKhachdua.TabIndex = 2
        Me.txtKhachdua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(299, 217)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(248, 26)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDongvainbill
        '
        Me.btnDongvainbill.Location = New System.Drawing.Point(422, 249)
        Me.btnDongvainbill.Name = "btnDongvainbill"
        Me.btnDongvainbill.Size = New System.Drawing.Size(125, 23)
        Me.btnDongvainbill.TabIndex = 3
        Me.btnDongvainbill.Text = "Đóng bill và in"
        Me.btnDongvainbill.UseVisualStyleBackColor = True
        '
        'btnDongbillkhongin
        '
        Me.btnDongbillkhongin.Location = New System.Drawing.Point(422, 278)
        Me.btnDongbillkhongin.Name = "btnDongbillkhongin"
        Me.btnDongbillkhongin.Size = New System.Drawing.Size(125, 23)
        Me.btnDongbillkhongin.TabIndex = 3
        Me.btnDongbillkhongin.Text = "Đóng bill không in"
        Me.btnDongbillkhongin.UseVisualStyleBackColor = True
        '
        'txtHuy
        '
        Me.txtHuy.Location = New System.Drawing.Point(422, 317)
        Me.txtHuy.Name = "txtHuy"
        Me.txtHuy.Size = New System.Drawing.Size(125, 23)
        Me.txtHuy.TabIndex = 3
        Me.txtHuy.Text = "Hủy bỏ"
        Me.txtHuy.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(377, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "- Bạn chọn ""Đóng bill và in"" để xác nhận thanh toán, in hóa đơn và đóng bàn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(364, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "- Bạn chọn ""Đóng bill không in"" để xác nhận thanh toán, không in hóa đơn" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " và đón" & _
    "g bàn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "- Bạn chọn ""Hủy bỏ"" để thoát khỏi cửa sổ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.coffee
        Me.PictureBox1.Location = New System.Drawing.Point(32, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 68)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmXacnhanthanhtoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(559, 343)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHuy)
        Me.Controls.Add(Me.btnDongbillkhongin)
        Me.Controls.Add(Me.btnDongvainbill)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtKhachdua)
        Me.Controls.Add(Me.txtTongtien)
        Me.Controls.Add(Me.lblTralai)
        Me.Controls.Add(Me.lblKhachdua)
        Me.Controls.Add(Me.lblTongtien)
        Me.Controls.Add(Me.lblBan)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmXacnhanthanhtoan"
        Me.Text = "Xác nhận thanh toán"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBan As System.Windows.Forms.Label
    Friend WithEvents lblTongtien As System.Windows.Forms.Label
    Friend WithEvents lblKhachdua As System.Windows.Forms.Label
    Friend WithEvents lblTralai As System.Windows.Forms.Label
    Friend WithEvents txtTongtien As System.Windows.Forms.TextBox
    Friend WithEvents txtKhachdua As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnDongvainbill As System.Windows.Forms.Button
    Friend WithEvents btnDongbillkhongin As System.Windows.Forms.Button
    Friend WithEvents txtHuy As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
