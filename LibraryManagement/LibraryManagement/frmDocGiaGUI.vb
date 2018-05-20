Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmDocGiaGUI
    Private dgBus As DocGiaBUS
    Private ldgBus As LoaiDocGiaBUS
    Private Sub frmDocGiaGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgBus = New DocGiaBUS()
        ldgBus = New LoaiDocGiaBUS()
        dtpNgayLapThe.Value = DateTime.Now

        ' Load Loaidocgia list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbLoaiDG.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbLoaiDG.DisplayMember = "TenLoaiDocGia"
        cbLoaiDG.ValueMember = "MaLoaiDocGia"

        'set MSSH auto
        Dim nextMsdg = "1"
        result = dgBus.buildMSdg(nextMsdg)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaSo.Text = nextMsdg
    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()

        '1. Mapping data from GUI control
        docgia.MaDocGia = Convert.ToInt32(txtMaSo.Text)
        docgia.HoTen = txtHoTen.Text
        docgia.DiaChi = txtDiaChi.Text
        docgia.NgaySinh = dtpNgaySinh.Value
        docgia.Email = txtEmail.Text
        docgia.NgayLapThe = dtpNgayLapThe.Value
        docgia.MaLoaiDocGia = Convert.ToInt32(cbLoaiDG.SelectedValue)

        '2. Business .....
        If (dgBus.isValid(docgia) = False) Then
            MessageBox.Show("Đọc giả không hợp lệ. Trống")
            txtHoTen.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMsdg = "1"
            result = dgBus.buildMSdg(nextMsdg)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMaSo.Text = nextMsdg
            txtDiaChi.Text = String.Empty
            txtHoTen.Text = String.Empty
            txtEmail.Text = String.Empty

        Else
            MessageBox.Show("Thêm Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnNhapVaDong.Click
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()

        '1. Mapping data from GUI control
        docgia.MaDocGia = Convert.ToInt32(txtMaSo.Text)
        docgia.HoTen = txtHoTen.Text
        docgia.DiaChi = txtDiaChi.Text
        docgia.NgaySinh = dtpNgaySinh.Value
        docgia.Email = txtEmail.Text
        docgia.NgayLapThe = dtpNgayLapThe.Value
        docgia.MaLoaiDocGia = Convert.ToInt32(cbLoaiDG.SelectedValue)

        '2. Business .....
        If (dgBus.isValid(docgia) = False) Then
            MessageBox.Show("Đọc giả không hợp lệ. Trống")
            txtHoTen.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

End Class