Imports QLTV_DTO
Imports QLTV_BUS
Imports Utility

Public Class frmSachGUI

    Private sachBUS As SachBUS
    Private tacGiaBUS As TacGiaBUS
    Private loaiSachBUS As LoaiSachBUS
    Private nhaxuatbanBUS As NhaXuatBanBUS
    Private added As Boolean
    Private sachDTO As SachDTO

    Private Function autoLoadMaSach()
        Dim nextMS = "1"
        Dim Result As Result = sachBUS.BuildMS(nextMS)
        If (Result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã sach không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
            Me.Close()
        End If
        textBoxMaSach.Text = nextMS
    End Function

    Private Sub frmSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        added = False

        sachBUS = New SachBUS()
        loaiSachBUS = New LoaiSachBUS()
        tacGiaBUS = New TacGiaBUS()
        nhaxuatbanBUS = New NhaXuatBanBUS()

        Dim result As Result

        dtpNgayNhap.Value = DateTime.Now

        'Lấy danh sách loại sách
        Dim listLoaiSach As New List(Of LoaiSachDTO)
        result = LoaiSachBUS.selectAll(listLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        comboBoxLoaiSach.DataSource = New BindingSource(listLoaiSach, String.Empty)
        comboBoxLoaiSach.DisplayMember = "tenLoai"
        comboBoxLoaiSach.ValueMember = "maLoai"

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
        result = tacGiaBUS.selectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tác giả không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        comboBoxTacGia.DataSource = New BindingSource(listTacGia, String.Empty)
        comboBoxTacGia.DisplayMember = "tenTacGia"
        comboBoxTacGia.ValueMember = "maTacGia"

        autoLoadMaSach()

    End Sub

    Private Sub buttonThemSach_Click(sender As Object, e As EventArgs) Handles buttonThemSach.Click
        sachDTO = New SachDTO()

        sachDTO.maSach = textBoxMaSach.Text
        sachDTO.tenSach = textBoxTenSach.Text
        sachDTO.maLoaiSach = comboBoxLoaiSach.SelectedValue
        sachDTO.maNhaXuatBan = comboBoxNhaXuatBan.SelectedValue
        sachDTO.namXuatBan = dtpNamXuatBan.Value
        sachDTO.ngayNhap = dtpNgayNhap.Value
        sachDTO.triGia = Integer.Parse(textBoxTriGia.Text)
        sachDTO.soLuongSach = nudSoLuongSach.Value
        sachDTO.soLuongConLai = nudSoLuongConLai.Value

        Dim resultInsertSach As New Result()
        resultInsertSach = sachBUS.insert(sachDTO)
        Dim resultInsertSachTacGia As New Result()
        resultInsertSachTacGia = tacGiaBUS.insertSach(textBoxMaSach.Text, comboBoxTacGia.SelectedValue)
        Dim caseResult As Integer

        If (resultInsertSach.FlagResult) Then
            If (resultInsertSachTacGia.FlagResult) Then
                caseResult = 1
            Else
                caseResult = 2
            End If
        Else
            If (resultInsertSachTacGia.FlagResult) Then
                caseResult = 3
            Else
                caseResult = 4
            End If
        End If

        Select Case caseResult
            Case 1
                MessageBox.Show("Thêm Sach thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                autoLoadMaSach()
                textBoxTenSach.Text = String.Empty
                textBoxTriGia.Text = String.Empty
                nudSoLuongSach.Value = 0
                nudSoLuongConLai.Value = 0
                added = True
                Exit Select
            Case 2 'Thêm Sách thành công và thêm tác giả không thành công
                sachBUS.delete(textBoxMaSach.Text)
                MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Select
            Case 3 'Thêm Sách không thành công và thêm tác giả thành công
                tacGiaBUS.deleteSach(textBoxMaSach.Text, comboBoxTacGia.ValueMember)
                MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Select
            Case Else
                MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Select
        End Select

        DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub

    Private Sub buttonThemVaThoat_Click(sender As Object, e As EventArgs) Handles buttonThemVaThoat.Click
        sachDTO = New SachDTO()

        sachDTO.maSach = textBoxMaSach.Text
        sachDTO.tenSach = textBoxTenSach.Text
        sachDTO.maLoaiSach = comboBoxLoaiSach.SelectedValue
        sachDTO.maNhaXuatBan = comboBoxNhaXuatBan.SelectedValue
        sachDTO.namXuatBan = dtpNamXuatBan.Value
        sachDTO.ngayNhap = dtpNgayNhap.Value
        sachDTO.triGia = Integer.Parse(textBoxTriGia.Text)
        sachDTO.soLuongSach = nudSoLuongSach.Value
        sachDTO.soLuongConLai = nudSoLuongConLai.Value

        Dim resultInsertSach As New Result()
        resultInsertSach = sachBUS.insert(sachDTO)
        Dim resultInsertSachTacGia As New Result()
        resultInsertSachTacGia = tacGiaBUS.insertSach(textBoxMaSach.Text, comboBoxTacGia.SelectedValue)
        Dim caseResult As Integer

        If (resultInsertSach.FlagResult) Then
            If (resultInsertSachTacGia.FlagResult) Then
                caseResult = 1
            Else
                caseResult = 2
            End If
        Else
            If (resultInsertSachTacGia.FlagResult) Then
                caseResult = 3
            Else
                caseResult = 4
            End If
        End If

        Select Case caseResult
            Case 1
                MessageBox.Show("Thêm Đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                added = True
                Exit Select
            Case 2 'Thêm Sách thành công và thêm tác giả không thành công
                sachBUS.delete(textBoxMaSach.Text)
                MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Select
            Case 3 'Thêm Sách không thành công và thêm tác giả thành công
                tacGiaBUS.deleteSach(textBoxMaSach.Text, comboBoxTacGia.ValueMember)
                MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Select
            Case Else
                MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Select
        End Select
        buttonThoat.PerformClick()
    End Sub

    Private Sub buttonThoat_Click(sender As Object, e As EventArgs) Handles buttonThoat.Click
        If (added) Then
            DialogResult = System.Windows.Forms.DialogResult.OK
        End If

        Me.Close()
    End Sub
End Class