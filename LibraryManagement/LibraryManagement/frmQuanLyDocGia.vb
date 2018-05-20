Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmQuanLyDocGia
    Private dgBus As DocGiaBUS
    Private ldgBus As LoaiDocGiaBUS
    Private Sub frmQuanLyDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgBus = New DocGiaBUS()
        ldgBus = New LoaiDocGiaBUS()

        ' Load LoaiDocGia list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbLoaiDG.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbLoaiDG.DisplayMember = "TenLoaiDocGia"
        cbLoaiDG.ValueMember = "MaLoaiDocGia"

        cbLoaiDGCapNhat.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbLoaiDGCapNhat.DisplayMember = "TenLoaiDocGia"
        cbLoaiDGCapNhat.ValueMember = "MaLoaiDocGia"
    End Sub

    Private Sub loadListDocGia()
        Dim listDocGia = New List(Of DocGiaDTO)
        Dim result As Result
        result = dgBus.selectAll(listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListdg.SuspendLayout()
        dgvListDG.Columns.Clear()
        dgvListDG.DataSource = Nothing

        dgvListDG.AutoGenerateColumns = False
        dgvListDG.AllowUserToAddRows = False
        dgvListDG.DataSource = listDocGia

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDocGia"
        clMa.HeaderText = "Mã Đọc Giả"
        clMa.DataPropertyName = "MaDocGia"
        dgvListDG.Columns.Add(clMa)

        Dim clLoaidg = New DataGridView()
        'clLoaidg.Name = "LoaiDG"
        'clLoaidg.HeaderText = "Tên Loại"
        'clLoaidg.DataPropertyName = "MaLoaiDocGia"
        'dgvListdg.Columns.Add(clLoaidg)

        Dim clHoTen = New DataGridViewTextBoxColumn()
        clHoTen.Name = "HoTen"
        clHoTen.HeaderText = "Họ Tên"
        clHoTen.DataPropertyName = "HoTen"
        dgvListDG.Columns.Add(clHoTen)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDG.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvListDG.Columns.Add(clEmail)

        Dim clNgayLap = New DataGridViewTextBoxColumn()
        clNgayLap.Name = "NgayLap"
        clNgayLap.HeaderText = "Ngày Lập Thẻ"
        clNgayLap.DataPropertyName = "NgayLapThe"
        dgvListDG.Columns.Add(clNgayLap)

        Dim clNgaySinh = New DataGridViewTextBoxColumn()
        clNgaySinh.Name = "NgaySinh"
        clNgaySinh.HeaderText = "Ngày Sinh"
        clNgaySinh.DataPropertyName = "NgaySinh"
        dgvListDG.Columns.Add(clNgaySinh)
        'dgvListdg.ResumeLayout()
    End Sub
    Private Sub loadListDocGia(maLoai As String)
        Dim listDocGia = New List(Of DocGiaDTO)
        Dim result As Result
        result = dgBus.selectALL_ByType(maLoai, listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đọc giả theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListdg.SuspendLayout()
        dgvListDG.Columns.Clear()
        dgvListDG.DataSource = Nothing

        dgvListDG.AutoGenerateColumns = False
        dgvListDG.AllowUserToAddRows = False
        dgvListDG.DataSource = listDocGia

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDocGia"
        clMa.HeaderText = "Mã Đọc Giả"
        clMa.DataPropertyName = "MaDocGia"
        dgvListDG.Columns.Add(clMa)

        Dim clLoaidg = New DataGridView()
        'clLoaidg.Name = "LoaiDG"
        'clLoaidg.HeaderText = "Tên Loại"
        'clLoaidg.DataPropertyName = "MaLoaiDocGia"
        'dgvListdg.Columns.Add(clLoaidg)

        Dim clHoTen = New DataGridViewTextBoxColumn()
        clHoTen.Name = "HoTen"
        clHoTen.HeaderText = "Họ Tên"
        clHoTen.DataPropertyName = "HoTen"
        dgvListDG.Columns.Add(clHoTen)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDG.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvListDG.Columns.Add(clEmail)

        Dim clNgayLap = New DataGridViewTextBoxColumn()
        clNgayLap.Name = "NgayLap"
        clNgayLap.HeaderText = "Ngày Lập Thẻ"
        clNgayLap.DataPropertyName = "NgayLapThe"
        dgvListDG.Columns.Add(clNgayLap)

        Dim clNgaySinh = New DataGridViewTextBoxColumn()
        clNgaySinh.Name = "NgaySinh"
        clNgaySinh.HeaderText = "Ngày Sinh"
        clNgaySinh.DataPropertyName = "NgaySinh"
        dgvListDG.Columns.Add(clNgaySinh)
        'dgvListdg.ResumeLayout()
    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListDG.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDG.RowCount) Then
            Try
                Dim docgia As DocGiaDTO
                docgia = New DocGiaDTO()

                '1. Mapping data from GUI control
                docgia.MaDocGia = txtMaSo.Text
                docgia.HoTen = txtHoTen.Text
                docgia.Email = txtEmail.Text
                docgia.NgayLapThe = dtpNgayLap.Value
                docgia.DiaChi = txtDiaChi.Text
                docgia.NgaySinh = dtpNgaySinh.Value
                docgia.MaLoaiDocGia = cbLoaiDGCapNhat.SelectedValue
                '2. Business .....
                If (dgBus.isValid(docgia) = False) Then
                    MessageBox.Show("Họ tên đọc giả không đúng.")
                    txtHoTen.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = dgBus.update(docgia)
                If (result.FlagResult = True) Then
                    ' Re-Load DocGia list
                    loadListDocGia(cbLoaiDG.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvListDG.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListDG.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDG.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa đọc giả có mã số: " + txtMaSo.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = dgBus.delete(txtMaSo.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiDocGia list
                            loadListDocGia(cbLoaiDG.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListDG.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListDG.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select


        End If
    End Sub

    Private Sub dgvListDG_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListDG.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListDG.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListDG.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDG.RowCount) Then
            Try
                Dim dg = CType(dgvListDG.Rows(currentRowIndex).DataBoundItem, DocGiaDTO)
                txtMaSo.Text = dg.MaDocGia
                txtHoTen.Text = dg.HoTen
                txtDiaChi.Text = dg.DiaChi
                dtpNgaySinh.Value = dg.NgaySinh
                dtpNgayLap.Value = dg.NgayLapThe
                txtEmail.Text = dg.Email
                cbLoaiDGCapNhat.SelectedIndex = cbLoaiDG.SelectedIndex
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub cbLoaiDG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLoaiDG.SelectedIndexChanged
        Try
            Dim maLoai = Convert.ToInt32(cbLoaiDG.SelectedValue)
            loadListDocGia(maLoai)

        Catch ex As Exception

        End Try
    End Sub
End Class