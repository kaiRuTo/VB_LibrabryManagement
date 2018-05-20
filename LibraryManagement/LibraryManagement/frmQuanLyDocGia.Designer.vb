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
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(601, 711)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(132, 28)
        Me.btnXoa.TabIndex = 39
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(437, 711)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(100, 28)
        Me.btnCapNhat.TabIndex = 38
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 656)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Loại DG:"
        '
        'cbLoaiDGCapNhat
        '
        Me.cbLoaiDGCapNhat.FormattingEnabled = True
        Me.cbLoaiDGCapNhat.Location = New System.Drawing.Point(437, 653)
        Me.cbLoaiDGCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLoaiDGCapNhat.Name = "cbLoaiDGCapNhat"
        Me.cbLoaiDGCapNhat.Size = New System.Drawing.Size(233, 24)
        Me.cbLoaiDGCapNhat.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(330, 566)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Ngày Sinh:"
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaySinh.Location = New System.Drawing.Point(437, 561)
        Me.dtpNgaySinh.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(265, 22)
        Me.dtpNgaySinh.TabIndex = 34
        Me.dtpNgaySinh.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'txtMaSo
        '
        Me.txtMaSo.Location = New System.Drawing.Point(437, 379)
        Me.txtMaSo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaSo.Name = "txtMaSo"
        Me.txtMaSo.ReadOnly = True
        Me.txtMaSo.Size = New System.Drawing.Size(215, 22)
        Me.txtMaSo.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 387)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Mã Số:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(437, 472)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(295, 22)
        Me.txtDiaChi.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 481)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Địa Chỉ:"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(437, 425)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(295, 22)
        Me.txtHoTen.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 434)
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
        Me.dgvListDG.Location = New System.Drawing.Point(103, 110)
        Me.dgvListDG.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListDG.MultiSelect = False
        Me.dgvListDG.Name = "dgvListDG"
        Me.dgvListDG.ReadOnly = True
        Me.dgvListDG.RowHeadersVisible = False
        Me.dgvListDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListDG.Size = New System.Drawing.Size(917, 234)
        Me.dgvListDG.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 44)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Loại DG:"
        '
        'cbLoaiDG
        '
        Me.cbLoaiDG.FormattingEnabled = True
        Me.cbLoaiDG.Location = New System.Drawing.Point(392, 41)
        Me.cbLoaiDG.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLoaiDG.Name = "cbLoaiDG"
        Me.cbLoaiDG.Size = New System.Drawing.Size(233, 24)
        Me.cbLoaiDG.TabIndex = 25
        '
        'dtpNgayLap
        '
        Me.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayLap.Location = New System.Drawing.Point(437, 596)
        Me.dtpNgayLap.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(265, 22)
        Me.dtpNgayLap.TabIndex = 34
        Me.dtpNgayLap.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(330, 596)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Ngày Lập:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(329, 520)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(438, 511)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(295, 22)
        Me.txtEmail.TabIndex = 31
        '
        'frmQuanLyDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 770)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbLoaiDGCapNhat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpNgayLap)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.txtMaSo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvListDG)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbLoaiDG)
        Me.Name = "frmQuanLyDocGia"
        Me.Text = "frmQuanLyDocGia"
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
