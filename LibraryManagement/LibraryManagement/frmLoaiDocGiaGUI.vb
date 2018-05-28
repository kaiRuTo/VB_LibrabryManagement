Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmLoaiDocGiaGUI
    Private ldgBUS As LoaiDocGiaBUS
    Private Sub frmLoaiDocGiaGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldgBUS = New LoaiDocGiaBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = ldgBUS.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaLoai.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim ldg As LoaiDocGiaDTO
        ldg = New LoaiDocGiaDTO()

        '1. Mapping data from GUI control
        ldg.MaLoaiDocGia = txtMaLoai.Text
        ldg.TenLoaiDocGia = txtTenLoai.Text

        '2. Business .....
        If (ldgBUS.isValidName(ldg) = False) Then
            MessageBox.Show("Tên Loại đọc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoai.Focus()
            Return
        End If

        If (ldgBUS.isValidCount() = False) Then
            MessageBox.Show("Số loại đọc giả vượt mức cho phép. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = ldgBUS.insert(ldg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenLoai.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = ldgBUS.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaLoai.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhapVanDong_Click(sender As Object, e As EventArgs) Handles btnNhapVanDong.Click
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
        If (ldgBUS.isValidCount() = False) Then
            MessageBox.Show("Số loại đọc giả vượt mức cho phép. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = ldgBUS.insert(ldg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class