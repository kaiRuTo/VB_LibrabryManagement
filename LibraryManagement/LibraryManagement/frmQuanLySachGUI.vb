Imports QLTV_DTO
Imports QLTV_BUS
Imports Utility

Public Class frmQuanLySachGUI

    Private sachBUS As SachBUS
    Private loaiSachBUS As LoaiSachBUS
    Private nhaxuatbanBUS As NhaXuatBanBUS


    Private Sub frmQuanLySachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sachBUS = New SachBUS()
        loaiSachBUS = New LoaiSachBUS()
        Dim result As Result

        'Lấy danh sách loại sách
        Dim listLoaiSach As List(Of LoaiSachDTO)
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

        'loadDgvQuanLySach()

    End Sub


End Class