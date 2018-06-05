Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmLoaiSachGUI
    Private lsBUS As LoaiSachBUS
    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
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

        If (lsBUS.isValidCount() = False) Then
            MessageBox.Show("Số loại sách vượt mức cho phép. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = lsBUS.insert(ls)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenLoai.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = lsBUS.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaLoai.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhapVanDong_Click(sender As Object, e As EventArgs) Handles btnNhapVanDong.Click
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
        If (lsBUS.isValidCount() = False) Then
            MessageBox.Show("Số loại sách vượt mức cho phép. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = lsBUS.insert(ls)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub


    Private Sub frmLoaiSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsBUS = New LoaiSachBUS()

        ' Get Next ID
        Dim nextID As String
        Dim result As Result
        result = lsBUS.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaLoai.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class