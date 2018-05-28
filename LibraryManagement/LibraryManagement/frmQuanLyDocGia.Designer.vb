<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyDocGia
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
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbLoaiDGCapNhat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.txtMaSo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvListDG = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbLoaiDG = New System.Windows.Forms.ComboBox()
        Me.dtpNgayLap = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnTaiLai = New System.Windows.Forms.Button()
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(886, 516)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(132, 28)
        Me.btnXoa.TabIndex = 39
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(728, 516)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(121, 28)
        Me.btnCapNhat.TabIndex = 38
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 354)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Loại DG:"
        '
        'cbLoaiDGCapNhat
        '
        Me.cbLoaiDGCapNhat.FormattingEnabled = True
        Me.cbLoaiDGCapNhat.Location = New System.Drawing.Point(132, 351)
        Me.cbLoaiDGCapNhat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbLoaiDGCapNhat.Name = "cbLoaiDGCapNhat"
        Me.cbLoaiDGCapNhat.Size = New System.Drawing.Size(233, 24)
        Me.cbLoaiDGCapNhat.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 264)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Ngày Sinh:"
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaySinh.Location = New System.Drawing.Point(132, 259)
        Me.dtpNgaySinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(265, 22)
        Me.dtpNgaySinh.TabIndex = 34
        Me.dtpNgaySinh.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'txtMaSo
        '
        Me.txtMaSo.Location = New System.Drawing.Point(133, 22)
        Me.txtMaSo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaSo.Name = "txtMaSo"
        Me.txtMaSo.ReadOnly = True
        Me.txtMaSo.Size = New System.Drawing.Size(215, 22)
        Me.txtMaSo.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Mã Số:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(133, 115)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(295, 73)
        Me.txtDiaChi.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Địa Chỉ:"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(133, 68)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(295, 22)
        Me.txtHoTen.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 77)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Họ Tên:"
        '
        'dgvListDG
        '
        Me.dgvListDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDG.Location = New System.Drawing.Point(15, 110)
        Me.dgvListDG.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvListDG.MultiSelect = False
        Me.dgvListDG.Name = "dgvListDG"
        Me.dgvListDG.ReadOnly = True
        Me.dgvListDG.RowHeadersVisible = False
        Me.dgvListDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListDG.Size = New System.Drawing.Size(538, 387)
        Me.dgvListDG.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Loại DG:"
        '
        'cbLoaiDG
        '
        Me.cbLoaiDG.FormattingEnabled = True
        Me.cbLoaiDG.Location = New System.Drawing.Point(121, 60)
        Me.cbLoaiDG.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbLoaiDG.Name = "cbLoaiDG"
        Me.cbLoaiDG.Size = New System.Drawing.Size(233, 24)
        Me.cbLoaiDG.TabIndex = 25
        '
        'dtpNgayLap
        '
        Me.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayLap.Location = New System.Drawing.Point(132, 294)
        Me.dtpNgayLap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(265, 22)
        Me.dtpNgayLap.TabIndex = 34
        Me.dtpNgayLap.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 294)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Ngày Lập:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 218)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(133, 209)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(295, 22)
        Me.txtEmail.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaSo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtHoTen)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbLoaiDGCapNhat)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.dtpNgayLap)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpNgaySinh)
        Me.GroupBox1.Location = New System.Drawing.Point(617, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 387)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin đọc giả"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(951, 63)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(121, 28)
        Me.btnThem.TabIndex = 38
        Me.btnThem.Text = "Thêm đọc giả"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnTaiLai
        '
        Me.btnTaiLai.Location = New System.Drawing.Point(192, 516)
        Me.btnTaiLai.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(162, 28)
        Me.btnTaiLai.TabIndex = 38
        Me.btnTaiLai.Text = "Tải lại danh sách"
        Me.btnTaiLai.UseVisualStyleBackColor = True
        '
        'frmQuanLyDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1120, 574)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnTaiLai)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.dgvListDG)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbLoaiDG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmQuanLyDocGia"
        Me.Text = "frmQuanLyDocGia"
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbLoaiDGCapNhat As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents txtMaSo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvListDG As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents cbLoaiDG As ComboBox
    Friend WithEvents dtpNgayLap As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnTaiLai As Button
End Class
