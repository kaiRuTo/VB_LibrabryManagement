<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTacGia
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
        Me.btnNhapVanDong = New System.Windows.Forms.Button()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.txtMaTacGia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenTacGia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNhapVanDong
        '
        Me.btnNhapVanDong.Location = New System.Drawing.Point(197, 213)
        Me.btnNhapVanDong.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNhapVanDong.Name = "btnNhapVanDong"
        Me.btnNhapVanDong.Size = New System.Drawing.Size(129, 28)
        Me.btnNhapVanDong.TabIndex = 34
        Me.btnNhapVanDong.Text = "Nhập và Đóng"
        Me.btnNhapVanDong.UseVisualStyleBackColor = True
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(77, 213)
        Me.btnNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(100, 28)
        Me.btnNhap.TabIndex = 33
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'txtMaTacGia
        '
        Me.txtMaTacGia.Location = New System.Drawing.Point(123, 87)
        Me.txtMaTacGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaTacGia.Name = "txtMaTacGia"
        Me.txtMaTacGia.ReadOnly = True
        Me.txtMaTacGia.Size = New System.Drawing.Size(195, 22)
        Me.txtMaTacGia.TabIndex = 32
        Me.txtMaTacGia.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Mã Tác Giả:"
        '
        'txtTenTacGia
        '
        Me.txtTenTacGia.Location = New System.Drawing.Point(123, 140)
        Me.txtTenTacGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenTacGia.Name = "txtTenTacGia"
        Me.txtTenTacGia.Size = New System.Drawing.Size(195, 22)
        Me.txtTenTacGia.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 145)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tên Tác Giả:"
        '
        'frmTacGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 339)
        Me.Controls.Add(Me.btnNhapVanDong)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.txtMaTacGia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenTacGia)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTacGia"
        Me.Text = "frmTacGia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNhapVanDong As Button
    Friend WithEvents btnNhap As Button
    Friend WithEvents txtMaTacGia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenTacGia As TextBox
    Friend WithEvents Label1 As Label
End Class
