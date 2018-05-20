Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class DocGiaBUS
    Private dgDAL As DocGiaDAL
    Public Sub New()
        dgDAL = New DocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New DocGiaDAL(connectionString)
    End Sub
    Public Function isValid(dg As DocGiaDTO) As Boolean

        If (dg.HoTen.Length < 1) Then
            Return False
        End If

        If (dg.DiaChi.Length < 1) Then
            Return False
        End If

        If (dg.Email.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function insert(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.insert(dg)
    End Function
    Public Function update(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.update(dg)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaidg As List(Of DocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL(listLoaidg)
    End Function
    Public Function selectALL_ByType(maLoai As Integer, ByRef listHocSinh As List(Of DocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL_ByType(maLoai, listHocSinh)
    End Function
    Public Function buildMSdg(ByRef nextMsdg As Integer) As Result
        Return dgDAL.buildMSDG(nextMsdg)
    End Function

End Class
