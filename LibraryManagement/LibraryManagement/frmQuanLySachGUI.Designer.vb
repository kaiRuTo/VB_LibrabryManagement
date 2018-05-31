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
        Me.textBoxSoLuongConLai = New System.Windows.Forms.TextBox()
        Me.labelConLai = New System.Windows.Forms.Label()
        Me.textBoxSoLuongSach = New System.Windows.Forms.TextBox()
        Me.labelSoLuongSach = New System.Windows.Forms.Label()
        Me.textBoxTriGia = New System.Windows.Forms.TextBox()
        Me.labelTriGia = New System.Windows.Forms.Label()
        Me.labelNgayNhap = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.comboBoxNhaXuatBan = New System.Windows.Forms.ComboBox()
        Me.labelNhaXuatBan = New System.Windows.Forms.Label()
        Me.textBoxTenTacGia = New System.Windows.Forms.TextBox()
        Me.labelTenTacGia = New System.Windows.Forms.Label()
        Me.comboBoxLoaiSach = New System.Windows.Forms.ComboBox()
        Me.labelLoaiSach = New System.Windows.Forms.Label()
        Me.textBoxTenSach = New System.Windows.Forms.TextBox()
        Me.labelTenSach = New System.Windows.Forms.Label()
        Me.textBoxMaSach = New System.Windows.Forms.TextBox()
        Me.labelMaSach = New System.Windows.Forms.Label()
        CType(Me.dgvQuanLySach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxThongTinSach.SuspendLayout()
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
        Me.textBoxTimKiem.Size = New System.Drawing.Size(375, 20)
        Me.textBoxTimKiem.TabIndex = 2
        '
        'dgvQuanLySach
        '
        Me.dgvQuanLySach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuanLySach.Location = New System.Drawing.Point(12, 57)
        Me.dgvQuanLySach.Name = "dgvQuanLySach"
        Me.dgvQuanLySach.Size = New System.Drawing.Size(520, 375)
        Me.dgvQuanLySach.TabIndex = 3
        '
        'buttonThemSach
        '
        Me.buttonThemSach.Location = New System.Drawing.Point(799, 23)
        Me.buttonThemSach.Name = "buttonThemSach"
        Me.buttonThemSach.Size = New System.Drawing.Size(75, 23)
        Me.buttonThemSach.TabIndex = 4
        Me.buttonThemSach.Text = "Thêm sách"
        Me.buttonThemSach.UseVisualStyleBackColor = True
        '
        'groupBoxThongTinSach
        '
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxSoLuongConLai)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelConLai)
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxSoLuongSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelSoLuongSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxTriGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelTriGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelNgayNhap)
        Me.groupBoxThongTinSach.Controls.Add(Me.DateTimePicker1)
        Me.groupBoxThongTinSach.Controls.Add(Me.comboBoxNhaXuatBan)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelNhaXuatBan)
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxTenTacGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelTenTacGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.comboBoxLoaiSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelLoaiSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxTenSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelTenSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxMaSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelMaSach)
        Me.groupBoxThongTinSach.Location = New System.Drawing.Point(560, 57)
        Me.groupBoxThongTinSach.Name = "groupBoxThongTinSach"
        Me.groupBoxThongTinSach.Size = New System.Drawing.Size(314, 375)
        Me.groupBoxThongTinSach.TabIndex = 5
        Me.groupBoxThongTinSach.TabStop = False
        Me.groupBoxThongTinSach.Text = "Thông tin sách"
        '
        'textBoxSoLuongConLai
        '
        Me.textBoxSoLuongConLai.Location = New System.Drawing.Point(91, 323)
        Me.textBoxSoLuongConLai.Name = "textBoxSoLuongConLai"
        Me.textBoxSoLuongConLai.Size = New System.Drawing.Size(173, 20)
        Me.textBoxSoLuongConLai.TabIndex = 18
        '
        'labelConLai
        '
        Me.labelConLai.AutoSize = True
        Me.labelConLai.Location = New System.Drawing.Point(15, 324)
        Me.labelConLai.Name = "labelConLai"
        Me.labelConLai.Size = New System.Drawing.Size(43, 13)
        Me.labelConLai.TabIndex = 17
        Me.labelConLai.Text = "Còn Lại"
        '
        'textBoxSoLuongSach
        '
        Me.textBoxSoLuongSach.Location = New System.Drawing.Point(92, 286)
        Me.textBoxSoLuongSach.Name = "textBoxSoLuongSach"
        Me.textBoxSoLuongSach.Size = New System.Drawing.Size(173, 20)
        Me.textBoxSoLuongSach.TabIndex = 16
        '
        'labelSoLuongSach
        '
        Me.labelSoLuongSach.AutoSize = True
        Me.labelSoLuongSach.Location = New System.Drawing.Point(16, 287)
        Me.labelSoLuongSach.Name = "labelSoLuongSach"
        Me.labelSoLuongSach.Size = New System.Drawing.Size(49, 13)
        Me.labelSoLuongSach.TabIndex = 15
        Me.labelSoLuongSach.Text = "Số lượng"
        '
        'textBoxTriGia
        '
        Me.textBoxTriGia.Location = New System.Drawing.Point(93, 249)
        Me.textBoxTriGia.Name = "textBoxTriGia"
        Me.textBoxTriGia.Size = New System.Drawing.Size(173, 20)
        Me.textBoxTriGia.TabIndex = 14
        '
        'labelTriGia
        '
        Me.labelTriGia.AutoSize = True
        Me.labelTriGia.Location = New System.Drawing.Point(17, 250)
        Me.labelTriGia.Name = "labelTriGia"
        Me.labelTriGia.Size = New System.Drawing.Size(36, 13)
        Me.labelTriGia.TabIndex = 13
        Me.labelTriGia.Text = "Trị giá"
        '
        'labelNgayNhap
        '
        Me.labelNgayNhap.AutoSize = True
        Me.labelNgayNhap.Location = New System.Drawing.Point(16, 213)
        Me.labelNgayNhap.Name = "labelNgayNhap"
        Me.labelNgayNhap.Size = New System.Drawing.Size(59, 13)
        Me.labelNgayNhap.TabIndex = 12
        Me.labelNgayNhap.Text = "Ngày nhập"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 212)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'comboBoxNhaXuatBan
        '
        Me.comboBoxNhaXuatBan.FormattingEnabled = True
        Me.comboBoxNhaXuatBan.Location = New System.Drawing.Point(92, 174)
        Me.comboBoxNhaXuatBan.Name = "comboBoxNhaXuatBan"
        Me.comboBoxNhaXuatBan.Size = New System.Drawing.Size(133, 21)
        Me.comboBoxNhaXuatBan.TabIndex = 10
        '
        'labelNhaXuatBan
        '
        Me.labelNhaXuatBan.AutoSize = True
        Me.labelNhaXuatBan.Location = New System.Drawing.Point(16, 176)
        Me.labelNhaXuatBan.Name = "labelNhaXuatBan"
        Me.labelNhaXuatBan.Size = New System.Drawing.Size(71, 13)
        Me.labelNhaXuatBan.TabIndex = 9
        Me.labelNhaXuatBan.Text = "Nhà xuất bản"
        '
        'textBoxTenTacGia
        '
        Me.textBoxTenTacGia.Location = New System.Drawing.Point(93, 137)
        Me.textBoxTenTacGia.Name = "textBoxTenTacGia"
        Me.textBoxTenTacGia.Size = New System.Drawing.Size(174, 20)
        Me.textBoxTenTacGia.TabIndex = 8
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
        Me.comboBoxLoaiSach.Location = New System.Drawing.Point(92, 99)
        Me.comboBoxLoaiSach.Name = "comboBoxLoaiSach"
        Me.comboBoxLoaiSach.Size = New System.Drawing.Size(133, 21)
        Me.comboBoxLoaiSach.TabIndex = 6
        '
        'labelLoaiSach
        '
        Me.labelLoaiSach.AutoSize = True
        Me.labelLoaiSach.Location = New System.Drawing.Point(16, 102)
        Me.labelLoaiSach.Name = "labelLoaiSach"
        Me.labelLoaiSach.Size = New System.Drawing.Size(53, 13)
        Me.labelLoaiSach.TabIndex = 4
        Me.labelLoaiSach.Text = "Loại sách"
        '
        'textBoxTenSach
        '
        Me.textBoxTenSach.Location = New System.Drawing.Point(92, 62)
        Me.textBoxTenSach.Name = "textBoxTenSach"
        Me.textBoxTenSach.Size = New System.Drawing.Size(174, 20)
        Me.textBoxTenSach.TabIndex = 3
        '
        'labelTenSach
        '
        Me.labelTenSach.AutoSize = True
        Me.labelTenSach.Location = New System.Drawing.Point(16, 65)
        Me.labelTenSach.Name = "labelTenSach"
        Me.labelTenSach.Size = New System.Drawing.Size(52, 13)
        Me.labelTenSach.TabIndex = 2
        Me.labelTenSach.Text = "Tên sách"
        '
        'textBoxMaSach
        '
        Me.textBoxMaSach.Location = New System.Drawing.Point(92, 25)
        Me.textBoxMaSach.Name = "textBoxMaSach"
        Me.textBoxMaSach.ReadOnly = True
        Me.textBoxMaSach.Size = New System.Drawing.Size(133, 20)
        Me.textBoxMaSach.TabIndex = 1
        '
        'labelMaSach
        '
        Me.labelMaSach.AutoSize = True
        Me.labelMaSach.Location = New System.Drawing.Point(16, 28)
        Me.labelMaSach.Name = "labelMaSach"
        Me.labelMaSach.Size = New System.Drawing.Size(48, 13)
        Me.labelMaSach.TabIndex = 0
        Me.labelMaSach.Text = "Mã sách"
        '
        'frmQuanLySachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 485)
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
    Friend WithEvents textBoxTenTacGia As TextBox
    Friend WithEvents labelTenTacGia As Label
    Friend WithEvents comboBoxNhaXuatBan As ComboBox
    Friend WithEvents labelNhaXuatBan As Label
    Friend WithEvents labelNgayNhap As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents textBoxTriGia As TextBox
    Friend WithEvents labelTriGia As Label
    Friend WithEvents textBoxSoLuongConLai As TextBox
    Friend WithEvents labelConLai As Label
    Friend WithEvents textBoxSoLuongSach As TextBox
    Friend WithEvents labelSoLuongSach As Label
End Class
