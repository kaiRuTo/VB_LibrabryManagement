Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmQuyDinh
    Dim qdBus As QuyDinhBUS
    Dim quydinh As QuyDinhDTO

    Private Sub frmQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdBus = New QuyDinhBUS()
        Dim result = qdBus.selectQuyDinh(quydinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If

        txtTuoiToiThieu.Text = quydinh.TuoiToiThieu
        txtTuoiToiDa.Text = quydinh.TuoiToiDa
        txtKhoangNamXB.Text = quydinh.KhoangNamXuatBan
        txtSoLuongSachToiDa.Text = quydinh.SoLuongSachToiDa
        txtSoNgayMuongToiDa.Text = quydinh.SoNgayMuonToiDa

    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Try
            quydinh.TuoiToiThieu = Integer.Parse(txtTuoiToiThieu.Text)
            quydinh.TuoiToiDa = Integer.Parse(txtTuoiToiDa.Text)
            quydinh.KhoangNamXuatBan = Integer.Parse(txtKhoangNamXB.Text)
            quydinh.SoLuongSachToiDa = Integer.Parse(txtSoLuongSachToiDa.Text)
            quydinh.SoNgayMuonToiDa = Integer.Parse(txtSoNgayMuongToiDa.Text)

            Dim result = qdBus.update(quydinh)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            MessageBox.Show("Cập nhật Quy Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Class