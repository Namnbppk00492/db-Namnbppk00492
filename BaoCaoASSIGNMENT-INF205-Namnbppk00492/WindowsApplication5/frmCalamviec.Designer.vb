<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalamviec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalamviec))
        Me.lblCalamviec = New System.Windows.Forms.Label()
        Me.cbbCalamviec = New System.Windows.Forms.ComboBox()
        Me.lsvCalamviec = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGhi = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.clhStt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhNhanvien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhCa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCalamviec
        '
        Me.lblCalamviec.AutoSize = True
        Me.lblCalamviec.Location = New System.Drawing.Point(12, 66)
        Me.lblCalamviec.Name = "lblCalamviec"
        Me.lblCalamviec.Size = New System.Drawing.Size(68, 13)
        Me.lblCalamviec.TabIndex = 0
        Me.lblCalamviec.Text = "Ca làm việc :"
        '
        'cbbCalamviec
        '
        Me.cbbCalamviec.FormattingEnabled = True
        Me.cbbCalamviec.Items.AddRange(New Object() {"Ca sáng", "Ca trưa", "Ca tối"})
        Me.cbbCalamviec.Location = New System.Drawing.Point(95, 63)
        Me.cbbCalamviec.Name = "cbbCalamviec"
        Me.cbbCalamviec.Size = New System.Drawing.Size(155, 21)
        Me.cbbCalamviec.TabIndex = 1
        '
        'lsvCalamviec
        '
        Me.lsvCalamviec.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhStt, Me.clhNhanvien, Me.clhCa})
        Me.lsvCalamviec.FullRowSelect = True
        Me.lsvCalamviec.Location = New System.Drawing.Point(0, 90)
        Me.lsvCalamviec.Name = "lsvCalamviec"
        Me.lsvCalamviec.Size = New System.Drawing.Size(370, 252)
        Me.lsvCalamviec.TabIndex = 2
        Me.lsvCalamviec.UseCompatibleStateImageBehavior = False
        Me.lsvCalamviec.View = System.Windows.Forms.View.Details
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.calamviec
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 57)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnGhi
        '
        Me.btnGhi.Location = New System.Drawing.Point(85, 366)
        Me.btnGhi.Name = "btnGhi"
        Me.btnGhi.Size = New System.Drawing.Size(75, 23)
        Me.btnGhi.TabIndex = 4
        Me.btnGhi.Text = "Ghi"
        Me.btnGhi.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(221, 366)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'clhStt
        '
        Me.clhStt.Text = "STT"
        '
        'clhNhanvien
        '
        Me.clhNhanvien.Text = "Nhân viên"
        Me.clhNhanvien.Width = 208
        '
        'clhCa
        '
        Me.clhCa.Text = "Ca"
        Me.clhCa.Width = 97
        '
        'frmCalamviec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(370, 401)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnGhi)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lsvCalamviec)
        Me.Controls.Add(Me.cbbCalamviec)
        Me.Controls.Add(Me.lblCalamviec)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCalamviec"
        Me.Text = "Ca làm việc"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCalamviec As System.Windows.Forms.Label
    Friend WithEvents cbbCalamviec As System.Windows.Forms.ComboBox
    Friend WithEvents lsvCalamviec As System.Windows.Forms.ListView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGhi As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents clhStt As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhNhanvien As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhCa As System.Windows.Forms.ColumnHeader
End Class
