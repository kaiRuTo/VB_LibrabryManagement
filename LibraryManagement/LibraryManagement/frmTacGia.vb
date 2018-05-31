Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmTacGia
    Private tgBUS As TacGiaBUS
    Private Sub frmTacGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tgBUS = New TacGiaBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = tgBUS.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaTacGia.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub


    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim tg As TacGiaDTO
        tg = New TacGiaDTO()

        '1. Mapping data from GUI control
        tg.MaTacGia = Convert.ToInt32(txtMaTacGia.Text)
        tg.TenTacGia = txtTenTacGia.Text

        '2. Business .....
        If (tgBUS.isValidName(tg) = False) Then
            MessageBox.Show("Tên tác giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenTacGia.Focus()
            Return
        End If

        If (tgBUS.isValidCount() = False) Then
            MessageBox.Show("Số tác giả vượt mức cho phép. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenTacGia.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = tgBUS.insert(tg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm tác giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenTacGia.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = tgBUS.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaTacGia.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhapVanDong_Click(sender As Object, e As EventArgs) Handles btnNhapVanDong.Click
        Dim tg As TacGiaDTO
        tg = New TacGiaDTO()

        '1. Mapping data from GUI control
        tg.MaTacGia = Convert.ToInt32(txtMaTacGia.Text)
        tg.TenTacGia = txtTenTacGia.Text

        '2. Business .....
        If (tgBUS.isValidName(tg) = False) Then
            MessageBox.Show("Tên tác giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenTacGia.Focus()
            Return
        End If
        If (tgBUS.isValidCount() = False) Then
            MessageBox.Show("Số tác giả vượt mức cho phép. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenTacGia.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = tgBUS.insert(tg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm tác giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class