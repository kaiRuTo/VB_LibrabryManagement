Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class TacGiaBUS
    Private tacGiaDAL As TacGiaDAL
    Public Sub New()
        tacGiaDAL = New TacGiaDAL()
    End Sub

    Public Sub New(connectString As String)
        tacGiaDAL = New TacGiaDAL(connectString)
    End Sub

    Public Function selectAll(ByRef listTacGia As List(Of TacGiaDTO)) As Result

        Return tacGiaDAL.selectAll(listTacGia)
    End Function

    Public Function insertSach(ms As String, mtg As String) As Result

        Return tacGiaDAL.insertSach(ms, mtg)
    End Function

    Public Function deleteSach(ms As String, mtg As String) As Result

        Return tacGiaDAL.deleteSach(ms, mtg)
    End Function

    Public Function loadTacGia(ms As String, ByRef mtg As String) As Result

        Return tacGiaDAL.loadTacGia(ms, mtg)
    End Function

End Class
