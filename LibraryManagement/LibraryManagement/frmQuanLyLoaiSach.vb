Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmQuanLyLoaiSach
    Private lsBUS As LoaiSachBUS
    Private Sub frmQuanLyLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsBUS = New LoaiSachBUS()
        loadlistLoaiSach()
    End Sub
    Private Sub loadlistLoaiSach()
        ' Load LoaiHocSinh list
        Dim listLoaiSach = New List(Of LoaiSachDTO)
        Dim result As Result
        result = lsBUS.selectAll(listLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachLoaiSach.Columns.Clear()
        dgvDanhSachLoaiSach.DataSource = Nothing

        dgvDanhSachLoaiSach.AutoGenerateColumns = False
        dgvDanhSachLoaiSach.AllowUserToAddRows = False
        dgvDanhSachLoaiSach.DataSource = listLoaiSach

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "MaLoaiSach"
        clMaLoai.HeaderText = "Mã Loại"
        clMaLoai.DataPropertyName = "MaLoai"
        dgvDanhSachLoaiSach.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TenLoai"
        clTenLoai.HeaderText = "Tên Loại"
        clTenLoai.DataPropertyName = "TenLoai"
        dgvDanhSachLoaiSach.Columns.Add(clTenLoai)

    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiSach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiSach.RowCount) Then
            Try
                Dim ls As LoaiSachDTO
                ls = New LoaiSachDTO()

                '1. Mapping data from GUI control
                ls.MaLoai = txtMaLoai.Text
                ls.TenLoai = txtTenLoai.Text

                '2. Business .....
                If (lsBUS.isValidName(ls) = False) Then
                    MessageBox.Show("Tên Loại sách không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoai.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = lsBUS.update(ls)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadlistLoaiSach()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachLoaiSach.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiSach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiSach.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa loại sách có mã: " + txtMaLoai.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = lsBUS.delete(Convert.ToInt32(txtMaLoai.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadlistLoaiSach()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachLoaiSach.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachLoaiSach.Rows(currentRowIndex).Selected = True
                            End If
                            MessageBox.Show("Xóa Loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dgvDanhSachLoaiSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachLoaiSach.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiSach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiSach.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiSach.RowCount) Then
            Try
                Dim ls = CType(dgvDanhSachLoaiSach.Rows(currentRowIndex).DataBoundItem, LoaiSachDTO)
                txtMaLoai.Text = ls.MaLoai
                txtTenLoai.Text = ls.TenLoai
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class