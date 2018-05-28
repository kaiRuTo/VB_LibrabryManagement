Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class frmQuanLyLoaiDocGia
    Private ldgBUS As LoaiDocGiaBUS
    Private Sub frmQuanLyLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldgBUS = New LoaiDocGiaBUS()
        loadlistLoaiDocGia()
    End Sub
    Private Sub loadlistLoaiDocGia()
        ' Load LoaiHocSinh list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBUS.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachLoaiDG.Columns.Clear()
        dgvDanhSachLoaiDG.DataSource = Nothing

        dgvDanhSachLoaiDG.AutoGenerateColumns = False
        dgvDanhSachLoaiDG.AllowUserToAddRows = False
        dgvDanhSachLoaiDG.DataSource = listLoaiDocGia

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "MaLoaiDocGia"
        clMaLoai.HeaderText = "Mã Loại"
        clMaLoai.DataPropertyName = "MaLoaiDocGia"
        dgvDanhSachLoaiDG.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TenLoai"
        clTenLoai.HeaderText = "Tên Loại"
        clTenLoai.DataPropertyName = "TenLoaiDocGia"
        dgvDanhSachLoaiDG.Columns.Add(clTenLoai)

    End Sub

    Private Sub dgvDanhSachLoaiDG_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachLoaiDG.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDG.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiDG.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDG.RowCount) Then
            Try
                Dim ldg = CType(dgvDanhSachLoaiDG.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                txtMaLoai.Text = ldg.MaLoaiDocGia
                txtTenLoai.Text = ldg.TenLoaiDocGia
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDG.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDG.RowCount) Then
            Try
                Dim ldg As LoaiDocGiaDTO
                ldg = New LoaiDocGiaDTO()

                '1. Mapping data from GUI control
                ldg.MaLoaiDocGia = Convert.ToInt32(txtMaLoai.Text)
                ldg.TenLoaiDocGia = txtTenLoai.Text

                '2. Business .....
                If (ldgBUS.isValidName(ldg) = False) Then
                    MessageBox.Show("Tên Loại đọc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoai.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = ldgBUS.update(ldg)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadlistLoaiDocGia()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachLoaiDG.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Loại đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDG.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDG.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa loại đọc giả có mã: " + txtMaLoai.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = ldgBUS.delete(txtMaLoai.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadlistLoaiDocGia()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachLoaiDG.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachLoaiDG.Rows(currentRowIndex).Selected = True
                            End If
                            MessageBox.Show("Xóa Loại đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As frmLoaiDocGiaGUI = New frmLoaiDocGiaGUI()
        frm.MdiParent = frmMain
        frm.Show()
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        loadlistLoaiDocGia()
    End Sub
End Class