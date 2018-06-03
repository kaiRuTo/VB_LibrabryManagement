Imports QLTV_DTO
Imports QLTV_BUS
Imports Utility

Public Class frmQuanLySachGUI

    Private sachBUS As SachBUS
    Private tacGiaBUS As TacGiaBUS
    Private loaiSachBUS As LoaiSachBUS
    Private nhaxuatbanBUS As NhaXuatBanBUS


    Private Sub frmQuanLySachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sachBUS = New SachBUS()
        loaiSachBUS = New LoaiSachBUS()
        Dim result As Result

        'Lấy danh sách loại sách
        Dim listLoaiSach As New List(Of LoaiSachDTO)
        result = loaiSachBUS.selectAll(listLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        comboBoxLoaiSach.DataSource = New BindingSource(listLoaiSach, String.Empty)
        comboBoxLoaiSach.DisplayMember = "tenLoaiSach"
        comboBoxLoaiSach.ValueMember = "maLoaiSach"

        'Lấy danh sách nhà xuất bản
        Dim listNhaXuatBan As New List(Of NhaXuatBanDTO)
        result = nhaxuatbanBUS.selectAll(listNhaXuatBan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách nhà xuất bản không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        comboBoxNhaXuatBan.DataSource = New BindingSource(listNhaXuatBan, String.Empty)
        comboBoxNhaXuatBan.DisplayMember = "tenNhaXuatBan"
        comboBoxNhaXuatBan.ValueMember = "maNhaXuatBan"

        'Lấy danh sách tác giả
        Dim listTacGia As New List(Of TacGiaDTO)
        result = TacGiaBUS.selectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tác giả không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        comboBoxTacGia.DataSource = New BindingSource(listNhaXuatBan, String.Empty)
        comboBoxTacGia.DisplayMember = "tenTacGia"
        comboBoxTacGia.ValueMember = "maTacGia"

        Dim list_cbTimKiem As New List(Of String)
        list_cbTimKiem.Add("Mã sách")
        list_cbTimKiem.Add("Tên sách")
        list_cbTimKiem.Add("Loại sách")
        list_cbTimKiem.Add("Tên tác giả")
        list_cbTimKiem.Add("Nhà xuất bản")
        list_cbTimKiem.Add("Ngày nhập sách")
        list_cbTimKiem.Add("Trị giá")

        comboBoxTimKiem.DataSource = New BindingSource(list_cbTimKiem, String.Empty)

        'loadDgvQuanLySach()

    End Sub

    Private Sub buttonThemSach_Click(sender As Object, e As EventArgs) Handles buttonThemSach.Click
        Dim frmSach As frmSachGUI
        frmSach = New frmSachGUI()
        frmSach.ShowDialog()
        If (frmSach.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            'loadDgvQuanLySach()
        End If
    End Sub

    Private Sub buttonCapNhap_Click(sender As Object, e As EventArgs) Handles buttonCapNhap.Click
        'If (textBoxMaSach.Text = String.Empty) Then
        '    MessageBox.Show("Chưa chọn sách", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If
        'Try
        '    Dim sachDTO As SachDTO
        '    sachDTO = New SachDTO()

        '    Dim sachLoaded As SachDTO
        '    sachLoaded = New SachDTO()
        '    Dim tacGiaLoaded As String = ""

        '    sachBUS.load(textBoxMaSach.Text, sachLoaded)
        '    tacGiaBUS.loadTacGia(textBoxMaSach.Text, tacGiaLoaded)

        '    '1. Mapping data from GUI control
        '    sachDTO.maSach = textBoxMaSach.Text
        '    sachDTO.tenSach = textBoxTenSach.Text
        '    sachDTO.maLoaiSach = comboBoxLoaiSach.ValueMember
        '    sachDTO.maNhaXuatBan = comboBoxNhaXuatBan.ValueMember
        '    sachDTO.ngayNhap = dtpNgayNhap.Value
        '    sachDTO.triGia = textBoxTriGia.Text
        '    sachDTO.soLuongSach = nudSoLuongSach.Value
        '    sachDTO.soLuongConLai = nudSoLuongConLai.Value
        '    '2. Business .....
        '    Dim resultUpdateSach As New Result(True)
        '    Dim resultUpdateSachTacGia As New Result(True)
        '    If (sachBUS.isDifferent(sachLoaded, sachDTO)) Then
        '        resultUpdateSach = sachBUS.update(sachDTO)
        '    End If
        '    If (tacGiaBUS.isDifferent(tacGiaLoaded, comboBoxTacGia.ValueMember)) Then
        '        resultUpdateSachTacGia = tacGiaBUS.UpdateSach(textBoxMaSach.Text, comboBoxTacGia.ValueMember)
        '    End If

        '    Dim caseResult As Integer

        '    If (resultUpdateSach.FlagResult) Then
        '        If (resultUpdateSachTacGia.FlagResult) Then
        '            caseResult = 1
        '        Else
        '            caseResult = 2
        '        End If
        '    Else
        '        If (resultUpdateSachTacGia.FlagResult) Then
        '            caseResult = 3
        '        Else
        '            caseResult = 4
        '        End If
        '    End If

        '    Select Case caseResult
        '        Case 1
        '            MessageBox.Show("Cập nhập sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            Exit Select
        '        Case 2 'Thêm Sách thành công và thêm tác giả không thành công
        '            sachBUS.delete(textBoxMaSach.Text)
        '            MessageBox.Show("cập nhập sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Exit Select
        '        Case 3 'Thêm Sách không thành công và thêm tác giả thành công
        '            TacGiaBUS.deleteSach(textBoxMaSach.Text, comboBoxTacGia.ValueMember)
        '            MessageBox.Show("Cập nhập sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '            Exit Select
        '        Case Else
        '            MessageBox.Show("cập nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '            Exit Select
        '    End Select

        'Catch ex As Exception
        '    Console.WriteLine(ex.StackTrace)
        'End Try
    End Sub

    Private Sub buttonXoa_Click(sender As Object, e As EventArgs) Handles buttonXoa.Click
        If (textBoxMaSach.Text = String.Empty) Then
            MessageBox.Show("Chưa chọn sách", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Select Case MsgBox("Bạn có thực sự muốn xóa sách " + textBoxTenSach.Text + ", mã số: " + textBoxMaSach.Text, MsgBoxStyle.YesNo, "Information")
            Case MsgBoxResult.Yes
                Try
                    '1. Delete from DB
                    Dim result As Result
                    result = sachBUS.delete(textBoxMaSach.Text)
                    If (result.FlagResult = True) Then

                        ' Re-Load LoaiDocGia list
                        'loadDgvQuanLySach()

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
    End Sub

    Private Sub buttonRefresh_Click(sender As Object, e As EventArgs) Handles buttonRefresh.Click
        'loadDgvQuanLySach()
    End Sub

    Private Function loadDqvQuanLySach() As Boolean


        Return True
    End Function
End Class