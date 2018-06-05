<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyLoaiSach
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
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachLoaiSach = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDanhSachLoaiSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(338, 385)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 37
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(218, 385)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 36
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(218, 281)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(133, 20)
        Me.txtMaLoai.TabIndex = 35
        Me.txtMaLoai.Text = "1"
        Me.txtMaLoai.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Mã Loại:"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(218, 328)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(222, 20)
        Me.txtTenLoai.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Tên Loại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Danh sách Loại Sách:"
        '
        'dgvDanhSachLoaiSach
        '
        Me.dgvDanhSachLoaiSach.AllowUserToAddRows = False
        Me.dgvDanhSachLoaiSach.AllowUserToDeleteRows = False
        Me.dgvDanhSachLoaiSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachLoaiSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachLoaiSach.Location = New System.Drawing.Point(104, 32)
        Me.dgvDanhSachLoaiSach.MultiSelect = False
        Me.dgvDanhSachLoaiSach.Name = "dgvDanhSachLoaiSach"
        Me.dgvDanhSachLoaiSach.ReadOnly = True
        Me.dgvDanhSachLoaiSach.RowHeadersVisible = False
        Me.dgvDanhSachLoaiSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachLoaiSach.Size = New System.Drawing.Size(386, 150)
        Me.dgvDanhSachLoaiSach.TabIndex = 30
        '
        'frmQuanLyLoaiSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 424)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachLoaiSach)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmQuanLyLoaiSach"
        Me.Text = "frmQuanLyLoaiSach"
        CType(Me.dgvDanhSachLoaiSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachLoaiSach As DataGridView
End Class
