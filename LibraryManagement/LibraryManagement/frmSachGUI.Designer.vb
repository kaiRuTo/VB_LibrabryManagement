<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSachGUI
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
        Me.labelConLai = New System.Windows.Forms.Label()
        Me.labelSoLuongSach = New System.Windows.Forms.Label()
        Me.textBoxTriGia = New System.Windows.Forms.TextBox()
        Me.labelTriGia = New System.Windows.Forms.Label()
        Me.labelNgayNhap = New System.Windows.Forms.Label()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.comboBoxNhaXuatBan = New System.Windows.Forms.ComboBox()
        Me.labelNhaXuatBan = New System.Windows.Forms.Label()
        Me.textBoxTacGia = New System.Windows.Forms.TextBox()
        Me.labelTenTacGia = New System.Windows.Forms.Label()
        Me.comboBoxLoaiSach = New System.Windows.Forms.ComboBox()
        Me.labelLoaiSach = New System.Windows.Forms.Label()
        Me.textBoxTenSach = New System.Windows.Forms.TextBox()
        Me.labelTenSach = New System.Windows.Forms.Label()
        Me.textBoxMaSach = New System.Windows.Forms.TextBox()
        Me.labelMaSach = New System.Windows.Forms.Label()
        Me.buttonThemSach = New System.Windows.Forms.Button()
        Me.comboBoxTacGia = New System.Windows.Forms.ComboBox()
        Me.nudSoLuongSach = New System.Windows.Forms.NumericUpDown()
        Me.nudSoLuongConLai = New System.Windows.Forms.NumericUpDown()
        Me.buttonThemVaThoat = New System.Windows.Forms.Button()
        Me.gbChiTietSach = New System.Windows.Forms.GroupBox()
        Me.buttonThoat = New System.Windows.Forms.Button()
        Me.labelNamXuanBan = New System.Windows.Forms.Label()
        Me.dtpNamXuatBan = New System.Windows.Forms.DateTimePicker()
        CType(Me.nudSoLuongSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSoLuongConLai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbChiTietSach.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelConLai
        '
        Me.labelConLai.AutoSize = True
        Me.labelConLai.Location = New System.Drawing.Point(69, 378)
        Me.labelConLai.Name = "labelConLai"
        Me.labelConLai.Size = New System.Drawing.Size(43, 13)
        Me.labelConLai.TabIndex = 35
        Me.labelConLai.Text = "Còn Lại"
        '
        'labelSoLuongSach
        '
        Me.labelSoLuongSach.AutoSize = True
        Me.labelSoLuongSach.Location = New System.Drawing.Point(69, 343)
        Me.labelSoLuongSach.Name = "labelSoLuongSach"
        Me.labelSoLuongSach.Size = New System.Drawing.Size(49, 13)
        Me.labelSoLuongSach.TabIndex = 33
        Me.labelSoLuongSach.Text = "Số lượng"
        '
        'textBoxTriGia
        '
        Me.textBoxTriGia.Location = New System.Drawing.Point(153, 306)
        Me.textBoxTriGia.Name = "textBoxTriGia"
        Me.textBoxTriGia.Size = New System.Drawing.Size(173, 20)
        Me.textBoxTriGia.TabIndex = 32
        '
        'labelTriGia
        '
        Me.labelTriGia.AutoSize = True
        Me.labelTriGia.Location = New System.Drawing.Point(69, 309)
        Me.labelTriGia.Name = "labelTriGia"
        Me.labelTriGia.Size = New System.Drawing.Size(36, 13)
        Me.labelTriGia.TabIndex = 31
        Me.labelTriGia.Text = "Trị giá"
        '
        'labelNgayNhap
        '
        Me.labelNgayNhap.AutoSize = True
        Me.labelNgayNhap.Location = New System.Drawing.Point(69, 277)
        Me.labelNgayNhap.Name = "labelNgayNhap"
        Me.labelNgayNhap.Size = New System.Drawing.Size(59, 13)
        Me.labelNgayNhap.TabIndex = 30
        Me.labelNgayNhap.Text = "Ngày nhập"
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.Location = New System.Drawing.Point(153, 271)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayNhap.TabIndex = 29
        '
        'comboBoxNhaXuatBan
        '
        Me.comboBoxNhaXuatBan.FormattingEnabled = True
        Me.comboBoxNhaXuatBan.Location = New System.Drawing.Point(153, 200)
        Me.comboBoxNhaXuatBan.Name = "comboBoxNhaXuatBan"
        Me.comboBoxNhaXuatBan.Size = New System.Drawing.Size(133, 21)
        Me.comboBoxNhaXuatBan.TabIndex = 28
        '
        'labelNhaXuatBan
        '
        Me.labelNhaXuatBan.AutoSize = True
        Me.labelNhaXuatBan.Location = New System.Drawing.Point(69, 203)
        Me.labelNhaXuatBan.Name = "labelNhaXuatBan"
        Me.labelNhaXuatBan.Size = New System.Drawing.Size(71, 13)
        Me.labelNhaXuatBan.TabIndex = 27
        Me.labelNhaXuatBan.Text = "Nhà xuất bản"
        '
        'textBoxTacGia
        '
        Me.textBoxTacGia.Location = New System.Drawing.Point(153, 129)
        Me.textBoxTacGia.Name = "textBoxTacGia"
        Me.textBoxTacGia.ReadOnly = True
        Me.textBoxTacGia.Size = New System.Drawing.Size(201, 20)
        Me.textBoxTacGia.TabIndex = 26
        '
        'labelTenTacGia
        '
        Me.labelTenTacGia.AutoSize = True
        Me.labelTenTacGia.Location = New System.Drawing.Point(69, 132)
        Me.labelTenTacGia.Name = "labelTenTacGia"
        Me.labelTenTacGia.Size = New System.Drawing.Size(61, 13)
        Me.labelTenTacGia.TabIndex = 25
        Me.labelTenTacGia.Text = "Tên tác giả"
        '
        'comboBoxLoaiSach
        '
        Me.comboBoxLoaiSach.FormattingEnabled = True
        Me.comboBoxLoaiSach.Location = New System.Drawing.Point(153, 93)
        Me.comboBoxLoaiSach.Name = "comboBoxLoaiSach"
        Me.comboBoxLoaiSach.Size = New System.Drawing.Size(133, 21)
        Me.comboBoxLoaiSach.TabIndex = 24
        '
        'labelLoaiSach
        '
        Me.labelLoaiSach.AutoSize = True
        Me.labelLoaiSach.Location = New System.Drawing.Point(69, 96)
        Me.labelLoaiSach.Name = "labelLoaiSach"
        Me.labelLoaiSach.Size = New System.Drawing.Size(53, 13)
        Me.labelLoaiSach.TabIndex = 23
        Me.labelLoaiSach.Text = "Loại sách"
        '
        'textBoxTenSach
        '
        Me.textBoxTenSach.Location = New System.Drawing.Point(153, 58)
        Me.textBoxTenSach.Name = "textBoxTenSach"
        Me.textBoxTenSach.Size = New System.Drawing.Size(174, 20)
        Me.textBoxTenSach.TabIndex = 22
        '
        'labelTenSach
        '
        Me.labelTenSach.AutoSize = True
        Me.labelTenSach.Location = New System.Drawing.Point(69, 61)
        Me.labelTenSach.Name = "labelTenSach"
        Me.labelTenSach.Size = New System.Drawing.Size(52, 13)
        Me.labelTenSach.TabIndex = 21
        Me.labelTenSach.Text = "Tên sách"
        '
        'textBoxMaSach
        '
        Me.textBoxMaSach.Location = New System.Drawing.Point(153, 23)
        Me.textBoxMaSach.Name = "textBoxMaSach"
        Me.textBoxMaSach.ReadOnly = True
        Me.textBoxMaSach.Size = New System.Drawing.Size(133, 20)
        Me.textBoxMaSach.TabIndex = 20
        '
        'labelMaSach
        '
        Me.labelMaSach.AutoSize = True
        Me.labelMaSach.Location = New System.Drawing.Point(69, 26)
        Me.labelMaSach.Name = "labelMaSach"
        Me.labelMaSach.Size = New System.Drawing.Size(48, 13)
        Me.labelMaSach.TabIndex = 19
        Me.labelMaSach.Text = "Mã sách"
        '
        'buttonThemSach
        '
        Me.buttonThemSach.Location = New System.Drawing.Point(415, 25)
        Me.buttonThemSach.Name = "buttonThemSach"
        Me.buttonThemSach.Size = New System.Drawing.Size(92, 32)
        Me.buttonThemSach.TabIndex = 37
        Me.buttonThemSach.Text = "Thêm"
        Me.buttonThemSach.UseVisualStyleBackColor = True
        '
        'comboBoxTacGia
        '
        Me.comboBoxTacGia.FormattingEnabled = True
        Me.comboBoxTacGia.Location = New System.Drawing.Point(153, 155)
        Me.comboBoxTacGia.Name = "comboBoxTacGia"
        Me.comboBoxTacGia.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxTacGia.TabIndex = 38
        '
        'nudSoLuongSach
        '
        Me.nudSoLuongSach.Location = New System.Drawing.Point(153, 341)
        Me.nudSoLuongSach.Name = "nudSoLuongSach"
        Me.nudSoLuongSach.Size = New System.Drawing.Size(120, 20)
        Me.nudSoLuongSach.TabIndex = 39
        '
        'nudSoLuongConLai
        '
        Me.nudSoLuongConLai.Location = New System.Drawing.Point(153, 376)
        Me.nudSoLuongConLai.Name = "nudSoLuongConLai"
        Me.nudSoLuongConLai.Size = New System.Drawing.Size(120, 20)
        Me.nudSoLuongConLai.TabIndex = 40
        '
        'buttonThemVaThoat
        '
        Me.buttonThemVaThoat.Location = New System.Drawing.Point(415, 64)
        Me.buttonThemVaThoat.Name = "buttonThemVaThoat"
        Me.buttonThemVaThoat.Size = New System.Drawing.Size(92, 32)
        Me.buttonThemVaThoat.TabIndex = 41
        Me.buttonThemVaThoat.Text = "Thêm và Thoát"
        Me.buttonThemVaThoat.UseVisualStyleBackColor = True
        '
        'gbChiTietSach
        '
        Me.gbChiTietSach.Controls.Add(Me.labelNamXuanBan)
        Me.gbChiTietSach.Controls.Add(Me.dtpNamXuatBan)
        Me.gbChiTietSach.Controls.Add(Me.labelMaSach)
        Me.gbChiTietSach.Controls.Add(Me.textBoxMaSach)
        Me.gbChiTietSach.Controls.Add(Me.nudSoLuongConLai)
        Me.gbChiTietSach.Controls.Add(Me.labelTenSach)
        Me.gbChiTietSach.Controls.Add(Me.nudSoLuongSach)
        Me.gbChiTietSach.Controls.Add(Me.textBoxTenSach)
        Me.gbChiTietSach.Controls.Add(Me.comboBoxTacGia)
        Me.gbChiTietSach.Controls.Add(Me.labelLoaiSach)
        Me.gbChiTietSach.Controls.Add(Me.comboBoxLoaiSach)
        Me.gbChiTietSach.Controls.Add(Me.labelConLai)
        Me.gbChiTietSach.Controls.Add(Me.labelTenTacGia)
        Me.gbChiTietSach.Controls.Add(Me.labelSoLuongSach)
        Me.gbChiTietSach.Controls.Add(Me.textBoxTacGia)
        Me.gbChiTietSach.Controls.Add(Me.textBoxTriGia)
        Me.gbChiTietSach.Controls.Add(Me.labelNhaXuatBan)
        Me.gbChiTietSach.Controls.Add(Me.labelTriGia)
        Me.gbChiTietSach.Controls.Add(Me.comboBoxNhaXuatBan)
        Me.gbChiTietSach.Controls.Add(Me.labelNgayNhap)
        Me.gbChiTietSach.Controls.Add(Me.dtpNgayNhap)
        Me.gbChiTietSach.Location = New System.Drawing.Point(22, 13)
        Me.gbChiTietSach.Name = "gbChiTietSach"
        Me.gbChiTietSach.Size = New System.Drawing.Size(369, 410)
        Me.gbChiTietSach.TabIndex = 42
        Me.gbChiTietSach.TabStop = False
        Me.gbChiTietSach.Text = "Chi tiết sách"
        '
        'buttonThoat
        '
        Me.buttonThoat.Location = New System.Drawing.Point(415, 103)
        Me.buttonThoat.Name = "buttonThoat"
        Me.buttonThoat.Size = New System.Drawing.Size(92, 32)
        Me.buttonThoat.TabIndex = 43
        Me.buttonThoat.Text = "Thoát"
        Me.buttonThoat.UseVisualStyleBackColor = True
        '
        'labelNamXuanBan
        '
        Me.labelNamXuanBan.AutoSize = True
        Me.labelNamXuanBan.Location = New System.Drawing.Point(69, 242)
        Me.labelNamXuanBan.Name = "labelNamXuanBan"
        Me.labelNamXuanBan.Size = New System.Drawing.Size(73, 13)
        Me.labelNamXuanBan.TabIndex = 42
        Me.labelNamXuanBan.Text = "Năm xuất bản"
        '
        'dtpNamXuatBan
        '
        Me.dtpNamXuatBan.Location = New System.Drawing.Point(153, 236)
        Me.dtpNamXuatBan.Name = "dtpNamXuatBan"
        Me.dtpNamXuatBan.Size = New System.Drawing.Size(200, 20)
        Me.dtpNamXuatBan.TabIndex = 41
        '
        'frmSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 449)
        Me.Controls.Add(Me.buttonThoat)
        Me.Controls.Add(Me.gbChiTietSach)
        Me.Controls.Add(Me.buttonThemVaThoat)
        Me.Controls.Add(Me.buttonThemSach)
        Me.Name = "frmSachGUI"
        Me.Text = "Thêm sách"
        CType(Me.nudSoLuongSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSoLuongConLai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbChiTietSach.ResumeLayout(False)
        Me.gbChiTietSach.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents labelConLai As Label
    Friend WithEvents labelSoLuongSach As Label
    Friend WithEvents textBoxTriGia As TextBox
    Friend WithEvents labelTriGia As Label
    Friend WithEvents labelNgayNhap As Label
    Friend WithEvents dtpNgayNhap As DateTimePicker
    Friend WithEvents comboBoxNhaXuatBan As ComboBox
    Friend WithEvents labelNhaXuatBan As Label
    Friend WithEvents textBoxTacGia As TextBox
    Friend WithEvents labelTenTacGia As Label
    Friend WithEvents comboBoxLoaiSach As ComboBox
    Friend WithEvents labelLoaiSach As Label
    Friend WithEvents textBoxTenSach As TextBox
    Friend WithEvents labelTenSach As Label
    Friend WithEvents textBoxMaSach As TextBox
    Friend WithEvents labelMaSach As Label
    Friend WithEvents buttonThemSach As Button
    Friend WithEvents comboBoxTacGia As ComboBox
    Friend WithEvents nudSoLuongSach As NumericUpDown
    Friend WithEvents nudSoLuongConLai As NumericUpDown
    Friend WithEvents buttonThemVaThoat As Button
    Friend WithEvents gbChiTietSach As GroupBox
    Friend WithEvents buttonThoat As Button
    Friend WithEvents labelNamXuanBan As Label
    Friend WithEvents dtpNamXuatBan As DateTimePicker
End Class
