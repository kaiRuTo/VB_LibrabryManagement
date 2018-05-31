Imports QLTV_DTO
Imports QLTV_DAL
Imports Utility

Public Class NhaXuatBanBUS

    Private nhaXuatBanDAL As NhaXuatBanDAL
    Public Sub New()
        nhaXuatBanDAL = New NhaXuatBanDAL()
    End Sub
    Public Sub New(connectionString As String)
        nhaXuatBanDAL = New NhaXuatBanDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef listNhaXuatBan As List(Of NhaXuatBanDTO)) As Result

        Return nhaXuatBanDAL.selectAll(listNhaXuatBan)
    End Function

End Class
