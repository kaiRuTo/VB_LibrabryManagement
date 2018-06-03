<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySachGUI
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
        Me.comboBoxTimKiem = New System.Windows.Forms.ComboBox()
        Me.labelTimKiem = New System.Windows.Forms.Label()
        Me.textBoxTimKiem = New System.Windows.Forms.TextBox()
        Me.dgvQuanLySach = New System.Windows.Forms.DataGridView()
        Me.buttonThemSach = New System.Windows.Forms.Button()
        Me.groupBoxThongTinSach = New System.Windows.Forms.GroupBox()
        Me.labelConLai = New System.Windows.Forms.Label()
        Me.labelSoLuongSach = New System.Windows.Forms.Label()
        Me.textBoxTriGia = New System.Windows.Forms.TextBox()
        Me.labelTriGia = New System.Windows.Forms.Label()
        Me.labelNgayNhap = New System.Windows.Forms.Label()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.comboBoxNhaXuatBan = New System.Windows.Forms.ComboBox()
        Me.labelNhaXuatBan = New System.Windows.Forms.Label()
        Me.labelTenTacGia = New System.Windows.Forms.Label()
        Me.comboBoxLoaiSach = New System.Windows.Forms.ComboBox()
        Me.labelLoaiSach = New System.Windows.Forms.Label()
        Me.textBoxTenSach = New System.Windows.Forms.TextBox()
        Me.labelTenSach = New System.Windows.Forms.Label()
        Me.textBoxMaSach = New System.Windows.Forms.TextBox()
        Me.labelMaSach = New System.Windows.Forms.Label()
        Me.buttonRefresh = New System.Windows.Forms.Button()
        Me.buttonXoaHet = New System.Windows.Forms.Button()
        Me.buttonCapNhap = New System.Windows.Forms.Button()
        Me.buttonThoat = New System.Windows.Forms.Button()
        Me.buttonTroLai = New System.Windows.Forms.Button()
        Me.nudSoLuongConLai = New System.Windows.Forms.NumericUpDown()
        Me.nudSoLuongSach = New System.Windows.Forms.NumericUpDown()
        Me.buttonXoa = New System.Windows.Forms.Button()
        Me.comboBoxTacGia = New System.Windows.Forms.ComboBox()
        Me.labelNamXuanBan = New System.Windows.Forms.Label()
        Me.dtpNamXuatBan = New System.Windows.Forms.DateTimePicker()
        Me.buttonTimKiem = New System.Windows.Forms.Button()
        CType(Me.dgvQuanLySach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxThongTinSach.SuspendLayout()
        CType(Me.nudSoLuongConLai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSoLuongSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboBoxTimKiem
        '
        Me.comboBoxTimKiem.FormattingEnabled = True
        Me.comboBoxTimKiem.Location = New System.Drawing.Point(67, 30)
        Me.comboBoxTimKiem.Name = "comboBoxTimKiem"
        Me.comboBoxTimKiem.Size = New System.Drawing.Size(84, 21)
        Me.comboBoxTimKiem.TabIndex = 0
        '
        'labelTimKiem
        '
        Me.labelTimKiem.AutoSize = True
        Me.labelTimKiem.Location = New System.Drawing.Point(12, 33)
        Me.labelTimKiem.Name = "labelTimKiem"
        Me.labelTimKiem.Size = New System.Drawing.Size(49, 13)
        Me.labelTimKiem.TabIndex = 1
        Me.labelTimKiem.Text = "Tìm kiếm"
        '
        'textBoxTimKiem
        '
        Me.textBoxTimKiem.Location = New System.Drawing.Point(157, 30)
        Me.textBoxTimKiem.Name = "textBoxTimKiem"
        Me.textBoxTimKiem.Size = New System.Drawing.Size(294, 20)
        Me.textBoxTimKiem.TabIndex = 2
        '
        'dgvQuanLySach
        '
        Me.dgvQuanLySach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuanLySach.Location = New System.Drawing.Point(12, 57)
        Me.dgvQuanLySach.Name = "dgvQuanLySach"
        Me.dgvQuanLySach.Size = New System.Drawing.Size(520, 397)
        Me.dgvQuanLySach.TabIndex = 3
        '
        'buttonThemSach
        '
        Me.buttonThemSach.Location = New System.Drawing.Point(799, 28)
        Me.buttonThemSach.Name = "buttonThemSach"
        Me.buttonThemSach.Size = New System.Drawing.Size(75, 23)
        Me.buttonThemSach.TabIndex = 4
        Me.buttonThemSach.Text = "Thêm sách"
        Me.buttonThemSach.UseVisualStyleBackColor = True
        '
        'groupBoxThongTinSach
        '
        Me.groupBoxThongTinSach.Controls.Add(Me.labelNamXuanBan)
        Me.groupBoxThongTinSach.Controls.Add(Me.dtpNamXuatBan)
        Me.groupBoxThongTinSach.Controls.Add(Me.comboBoxTacGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.nudSoLuongConLai)
        Me.groupBoxThongTinSach.Controls.Add(Me.nudSoLuongSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelConLai)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelSoLuongSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxTriGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelTriGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelNgayNhap)
        Me.groupBoxThongTinSach.Controls.Add(Me.dtpNgayNhap)
        Me.groupBoxThongTinSach.Controls.Add(Me.comboBoxNhaXuatBan)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelNhaXuatBan)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelTenTacGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.comboBoxLoaiSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelLoaiSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxTenSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelTenSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxMaSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelMaSach)
        Me.groupBoxThongTinSach.Location = New System.Drawing.Point(560, 57)
        Me.groupBoxThongTinSach.Name = "groupBoxThongTinSach"
        Me.groupBoxThongTinSach.Size = New System.Drawing.Size(314, 397)
        Me.groupBoxThongTinSach.TabIndex = 5
        Me.groupBoxThongTinSach.TabStop = False
        Me.groupBoxThongTinSach.Text = "Thông tin sách"
        '
        'labelConLai
        '
        Me.labelConLai.AutoSize = True
        Me.labelConLai.Location = New System.Drawing.Point(17, 361)
        Me.labelConLai.Name = "labelConLai"
        Me.labelConLai.Size = New System.Drawing.Size(43, 13)
        Me.labelConLai.TabIndex = 17
        Me.labelConLai.Text = "Còn Lại"
        '
        'labelSoLuongSach
        '
        Me.labelSoLuongSach.AutoSize = True
        Me.labelSoLuongSach.Location = New System.Drawing.Point(17, 324)
        Me.labelSoLuongSach.Name = "labelSoLuongSach"
        Me.labelSoLuongSach.Size = New System.Drawing.Size(49, 13)
        Me.labelSoLuongSach.TabIndex = 15
        Me.labelSoLuongSach.Text = "Số lượng"
        '
        'textBoxTriGia
        '
        Me.textBoxTriGia.Location = New System.Drawing.Point(101, 280)
        Me.textBoxTriGia.Name = "textBoxTriGia"
        Me.textBoxTriGia.Size = New System.Drawing.Size(173, 20)
        Me.textBoxTriGia.TabIndex = 14
        '
        'labelTriGia
        '
        Me.labelTriGia.AutoSize = True
        Me.labelTriGia.Location = New System.Drawing.Point(17, 287)
        Me.labelTriGia.Name = "labelTriGia"
        Me.labelTriGia.Size = New System.Drawing.Size(36, 13)
        Me.labelTriGia.TabIndex = 13
        Me.labelTriGia.Text = "Trị giá"
        '
        'labelNgayNhap
        '
        Me.labelNgayNhap.AutoSize = True
        Me.labelNgayNhap.Location = New System.Drawing.Point(17, 250)
        Me.labelNgayNhap.Name = "labelNgayNhap"
        Me.labelNgayNhap.Size = New System.Drawing.Size(59, 13)
        Me.labelNgayNhap.TabIndex = 12
        Me.labelNgayNhap.Text = "Ngày nhập"
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.Location = New System.Drawing.Point(101, 244)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayNhap.TabIndex = 11
        '
        'comboBoxNhaXuatBan
        '
        Me.comboBoxNhaXuatBan.FormattingEnabled = True
        Me.comboBoxNhaXuatBan.Location = New System.Drawing.Point(101, 171)
        Me.comboBoxNhaXuatBan.Name = "comboBoxNhaXuatBan"
        Me.comboBoxNhaXuatBan.Size = New System.Drawing.Size(133, 21)
        Me.comboBoxNhaXuatBan.TabIndex = 10
        '
        'labelNhaXuatBan
        '
        Me.labelNhaXuatBan.AutoSize = True
        Me.labelNhaXuatBan.Location = New System.Drawing.Point(17, 176)
        Me.labelNhaXuatBan.Name = "labelNhaXuatBan"
        Me.labelNhaXuatBan.Size = New System.Drawing.Size(71, 13)
        Me.labelNhaXuatBan.TabIndex = 9
        Me.labelNhaXuatBan.Text = "Nhà xuất bản"
        '
        'labelTenTacGia
        '
        Me.labelTenTacGia.AutoSize = True
        Me.labelTenTacGia.Location = New System.Drawing.Point(17, 139)
        Me.labelTenTacGia.Name = "labelTenTacGia"
        Me.labelTenTacGia.Size = New System.Drawing.Size(61, 13)
        Me.labelTenTacGia.TabIndex = 7
        Me.labelTenTacGia.Text = "Tên tác giả"
        '
        'comboBoxLoaiSach
        '
        Me.comboBoxLoaiSach.FormattingEnabled = True
        Me.comboBoxLoaiSach.Location = New System.Drawing.Point(101, 97)
        Me.comboBoxLoaiSach.Name = "comboBoxLoaiSach"
        Me.comboBoxLoaiSach.Size = New System.Drawing.Size(133, 21)
        Me.comboBoxLoaiSach.TabIndex = 6
        '
        'labelLoaiSach
        '
        Me.labelLoaiSach.AutoSize = True
        Me.labelLoaiSach.Location = New System.Drawing.Point(17, 102)
        Me.labelLoaiSach.Name = "labelLoaiSach"
        Me.labelLoaiSach.Size = New System.Drawing.Size(53, 13)
        Me.labelLoaiSach.TabIndex = 4
        Me.labelLoaiSach.Text = "Loại sách"
        '
        'textBoxTenSach
        '
        Me.textBoxTenSach.Location = New System.Drawing.Point(101, 61)
        Me.textBoxTenSach.Name = "textBoxTenSach"
        Me.textBoxTenSach.Size = New System.Drawing.Size(174, 20)
        Me.textBoxTenSach.TabIndex = 3
        '
        'labelTenSach
        '
        Me.labelTenSach.AutoSize = True
        Me.labelTenSach.Location = New System.Drawing.Point(17, 65)
        Me.labelTenSach.Name = "labelTenSach"
        Me.labelTenSach.Size = New System.Drawing.Size(52, 13)
        Me.labelTenSach.TabIndex = 2
        Me.labelTenSach.Text = "Tên sách"
        '
        'textBoxMaSach
        '
        Me.textBoxMaSach.Location = New System.Drawing.Point(101, 25)
        Me.textBoxMaSach.Name = "textBoxMaSach"
        Me.textBoxMaSach.ReadOnly = True
        Me.textBoxMaSach.Size = New System.Drawing.Size(133, 20)
        Me.textBoxMaSach.TabIndex = 1
        '
        'labelMaSach
        '
        Me.labelMaSach.AutoSize = True
        Me.labelMaSach.Location = New System.Drawing.Point(17, 28)
        Me.labelMaSach.Name = "labelMaSach"
        Me.labelMaSach.Size = New System.Drawing.Size(48, 13)
        Me.labelMaSach.TabIndex = 0
        Me.labelMaSach.Text = "Mã sách"
        '
        'buttonRefresh
        '
        Me.buttonRefresh.Location = New System.Drawing.Point(223, 460)
        Me.buttonRefresh.Name = "buttonRefresh"
        Me.buttonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.buttonRefresh.TabIndex = 6
        Me.buttonRefresh.Text = "Refresh"
        Me.buttonRefresh.UseVisualStyleBackColor = True
        '
        'buttonXoaHet
        '
        Me.buttonXoaHet.Location = New System.Drawing.Point(457, 459)
        Me.buttonXoaHet.Name = "buttonXoaHet"
        Me.buttonXoaHet.Size = New System.Drawing.Size(75, 23)
        Me.buttonXoaHet.TabIndex = 7
        Me.buttonXoaHet.Text = "Xóa hết"
        Me.buttonXoaHet.UseVisualStyleBackColor = True
        '
        'buttonCapNhap
        '
        Me.buttonCapNhap.Location = New System.Drawing.Point(679, 460)
        Me.buttonCapNhap.Name = "buttonCapNhap"
        Me.buttonCapNhap.Size = New System.Drawing.Size(75, 23)
        Me.buttonCapNhap.TabIndex = 8
        Me.buttonCapNhap.Text = "Cập nhập"
        Me.buttonCapNhap.UseVisualStyleBackColor = True
        '
        'buttonThoat
        '
        Me.buttonThoat.Location = New System.Drawing.Point(798, 460)
        Me.buttonThoat.Name = "buttonThoat"
        Me.buttonThoat.Size = New System.Drawing.Size(75, 23)
        Me.buttonThoat.TabIndex = 9
        Me.buttonThoat.Text = "Thoát"
        Me.buttonThoat.UseVisualStyleBackColor = True
        '
        'buttonTroLai
        '
        Me.buttonTroLai.Location = New System.Drawing.Point(12, 460)
        Me.buttonTroLai.Name = "buttonTroLai"
        Me.buttonTroLai.Size = New System.Drawing.Size(75, 23)
        Me.buttonTroLai.TabIndex = 10
        Me.buttonTroLai.Text = "Trở lại"
        Me.buttonTroLai.UseVisualStyleBackColor = True
        '
        'nudSoLuongConLai
        '
        Me.nudSoLuongConLai.Location = New System.Drawing.Point(101, 352)
        Me.nudSoLuongConLai.Name = "nudSoLuongConLai"
        Me.nudSoLuongConLai.Size = New System.Drawing.Size(120, 20)
        Me.nudSoLuongConLai.TabIndex = 42
        '
        'nudSoLuongSach
        '
        Me.nudSoLuongSach.Location = New System.Drawing.Point(101, 316)
        Me.nudSoLuongSach.Name = "nudSoLuongSach"
        Me.nudSoLuongSach.Size = New System.Drawing.Size(120, 20)
        Me.nudSoLuongSach.TabIndex = 41
        '
        'buttonXoa
        '
        Me.buttonXoa.Location = New System.Drawing.Point(560, 459)
        Me.buttonXoa.Name = "buttonXoa"
        Me.buttonXoa.Size = New System.Drawing.Size(75, 23)
        Me.buttonXoa.TabIndex = 11
        Me.buttonXoa.Text = "Xóa"
        Me.buttonXoa.UseVisualStyleBackColor = True
        '
        'comboBoxTacGia
        '
        Me.comboBoxTacGia.FormattingEnabled = True
        Me.comboBoxTacGia.Location = New System.Drawing.Point(101, 134)
        Me.comboBoxTacGia.Name = "comboBoxTacGia"
        Me.comboBoxTacGia.Size = New System.Drawing.Size(135, 21)
        Me.comboBoxTacGia.TabIndex = 43
        '
        'labelNamXuanBan
        '
        Me.labelNamXuanBan.AutoSize = True
        Me.labelNamXuanBan.Location = New System.Drawing.Point(17, 213)
        Me.labelNamXuanBan.Name = "labelNamXuanBan"
        Me.labelNamXuanBan.Size = New System.Drawing.Size(73, 13)
        Me.labelNamXuanBan.TabIndex = 45
        Me.labelNamXuanBan.Text = "Năm xuất bản"
        '
        'dtpNamXuatBan
        '
        Me.dtpNamXuatBan.Location = New System.Drawing.Point(101, 208)
        Me.dtpNamXuatBan.Name = "dtpNamXuatBan"
        Me.dtpNamXuatBan.Size = New System.Drawing.Size(200, 20)
        Me.dtpNamXuatBan.TabIndex = 44
        '
        'buttonTimKiem
        '
        Me.buttonTimKiem.Location = New System.Drawing.Point(457, 28)
        Me.buttonTimKiem.Name = "buttonTimKiem"
        Me.buttonTimKiem.Size = New System.Drawing.Size(75, 23)
        Me.buttonTimKiem.TabIndex = 12
        Me.buttonTimKiem.Text = "Tìm Kiếm"
        Me.buttonTimKiem.UseVisualStyleBackColor = True
        '
        'frmQuanLySachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 506)
        Me.Controls.Add(Me.buttonTimKiem)
        Me.Controls.Add(Me.buttonXoa)
        Me.Controls.Add(Me.buttonTroLai)
        Me.Controls.Add(Me.buttonThoat)
        Me.Controls.Add(Me.buttonCapNhap)
        Me.Controls.Add(Me.buttonXoaHet)
        Me.Controls.Add(Me.buttonRefresh)
        Me.Controls.Add(Me.groupBoxThongTinSach)
        Me.Controls.Add(Me.buttonThemSach)
        Me.Controls.Add(Me.dgvQuanLySach)
        Me.Controls.Add(Me.textBoxTimKiem)
        Me.Controls.Add(Me.labelTimKiem)
        Me.Controls.Add(Me.comboBoxTimKiem)
        Me.Name = "frmQuanLySachGUI"
        Me.Text = "frmQuanLySachGUI"
        CType(Me.dgvQuanLySach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxThongTinSach.ResumeLayout(False)
        Me.groupBoxThongTinSach.PerformLayout()
        CType(Me.nudSoLuongConLai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSoLuongSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboBoxTimKiem As ComboBox
    Friend WithEvents labelTimKiem As Label
    Friend WithEvents textBoxTimKiem As TextBox
    Friend WithEvents dgvQuanLySach As DataGridView
    Friend WithEvents buttonThemSach As Button
    Friend WithEvents groupBoxThongTinSach As GroupBox
    Friend WithEvents labelMaSach As Label
    Friend WithEvents textBoxMaSach As TextBox
    Friend WithEvents textBoxTenSach As TextBox
    Friend WithEvents labelTenSach As Label
    Friend WithEvents comboBoxLoaiSach As ComboBox
    Friend WithEvents labelLoaiSach As Label
    Friend WithEvents labelTenTacGia As Label
    Friend WithEvents comboBoxNhaXuatBan As ComboBox
    Friend WithEvents labelNhaXuatBan As Label
    Friend WithEvents labelNgayNhap As Label
    Friend WithEvents dtpNgayNhap As DateTimePicker
    Friend WithEvents textBoxTriGia As TextBox
    Friend WithEvents labelTriGia As Label
    Friend WithEvents labelConLai As Label
    Friend WithEvents labelSoLuongSach As Label
    Friend WithEvents buttonRefresh As Button
    Friend WithEvents buttonXoaHet As Button
    Friend WithEvents buttonCapNhap As Button
    Friend WithEvents buttonThoat As Button
    Friend WithEvents buttonTroLai As Button
    Friend WithEvents nudSoLuongConLai As NumericUpDown
    Friend WithEvents nudSoLuongSach As NumericUpDown
    Friend WithEvents buttonXoa As Button
    Friend WithEvents comboBoxTacGia As ComboBox
    Friend WithEvents labelNamXuanBan As Label
    Friend WithEvents dtpNamXuatBan As DateTimePicker
    Friend WithEvents buttonTimKiem As Button
End Class
