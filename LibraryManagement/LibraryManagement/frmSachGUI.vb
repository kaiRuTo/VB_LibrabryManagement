Imports QLTV_DTO
Imports QLTV_BUS
Imports Utility

Public Class frmSachGUI

    Private sachBUS As SachBUS
    Private tacGiaBUS As TacGiaBUS
    Private loaiSachBUS As LoaiSachBUS
    Private nhaxuatbanBUS As NhaXuatBanBUS

    Private Sub frmSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sachBUS = New SachBUS()
        loaiSachBUS = New LoaiSachBUS()
        tacGiaBUS = New TacGiaBUS()
        nhaxuatbanBUS = New NhaXuatBanBUS()
        Dim result As Result
        dtpNgayNhap.Value = DateTime.Now

        'Lấy danh sách loại sách
        Dim listLoaiSach As List(Of LoaiSachDTO)
        result = LoaiSachBUS.selectAll(listLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        comboBoxLoaiSach.DataSource = New BindingSource(listLoaiSach, String.Empty)
        comboBoxLoaiSach.DisplayMember = "tenLoaiSach"
        comboBoxLoaiSach.ValueMember = "maLoaiSach"

        'Lấy danh sách nhà xuất bản
        Dim listNhaXuatBan As List(Of NhaXuatBanDTO)
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
        Dim listTacGia As List(Of TacGiaDTO)
        result = tacGiaBUS.selectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tác giả không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        comboBoxTacGia.DataSource = New BindingSource(listNhaXuatBan, String.Empty)
        comboBoxTacGia.DisplayMember = "tenTacGia"
        comboBoxTacGia.ValueMember = "maTacGia"

        Dim nextMS = "1"
        result = sachBUS.buildMS(nextMS)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã sach không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        textBoxMaSach.Text = nextMS

    End Sub
End Class