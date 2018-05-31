<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocGiaGUI
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
        Me.btnNhapVaDong = New System.Windows.Forms.Button()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbLoaiDG = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.txtMaSo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpNgayLapThe = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNhapVaDong
        '
        Me.btnNhapVaDong.Location = New System.Drawing.Point(178, 385)
        Me.btnNhapVaDong.Name = "btnNhapVaDong"
        Me.btnNhapVaDong.Size = New System.Drawing.Size(112, 23)
        Me.btnNhapVaDong.TabIndex = 23
        Me.btnNhapVaDong.Text = "Nhập và Đóng"
        Me.btnNhapVaDong.UseVisualStyleBackColor = True
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(68, 385)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(75, 23)
        Me.btnNhap.TabIndex = 22
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Loại ĐG:"
        '
        'cbLoaiDG
        '
        Me.cbLoaiDG.FormattingEnabled = True
        Me.cbLoaiDG.Location = New System.Drawing.Point(92, 334)
        Me.cbLoaiDG.Name = "cbLoaiDG"
        Me.cbLoaiDG.Size = New System.Drawing.Size(162, 21)
        Me.cbLoaiDG.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Ngày Sinh:"
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaySinh.Location = New System.Drawing.Point(92, 240)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgaySinh.TabIndex = 18
        Me.dtpNgaySinh.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'txtMaSo
        '
        Me.txtMaSo.Location = New System.Drawing.Point(92, 34)
        Me.txtMaSo.Name = "txtMaSo"
        Me.txtMaSo.ReadOnly = True
        Me.txtMaSo.Size = New System.Drawing.Size(162, 20)
        Me.txtMaSo.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Mã Số:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(92, 128)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(200, 59)
        Me.txtDiaChi.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Địa Chỉ:"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(92, 81)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(162, 20)
        Me.txtHoTen.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Họ Tên:"
        '
        'dtpNgayLapThe
        '
        Me.dtpNgayLapThe.Enabled = False
        Me.dtpNgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(92, 287)
        Me.dtpNgayLapThe.Name = "dtpNgayLapThe"
        Me.dtpNgayLapThe.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayLapThe.TabIndex = 18
        Me.dtpNgayLapThe.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Ngày Lập:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(92, 193)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 15
        '
        'frmDocGiaGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 458)
        Me.Controls.Add(Me.btnNhapVaDong)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbLoaiDG)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpNgayLapThe)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.txtMaSo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmDocGiaGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập Đọc Giả"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNhapVaDong As Button
    Friend WithEvents btnNhap As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbLoaiDG As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents txtMaSo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpNgayLapThe As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
End Class
