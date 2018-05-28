Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class LoaiDocGiaBUS
    Private ldgDAL As LoaiDocGiaDAL
    Public Sub New()
        ldgDAL = New LoaiDocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        ldgDAL = New LoaiDocGiaDAL(connectionString)
    End Sub

    Public Function isValidName(ldg As LoaiDocGiaDTO) As Boolean

        If (ldg.TenLoaiDocGia.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function isValidCount() As Boolean

        If (count() >= 2) Then
            Return False
        End If

        Return True

    End Function

    Public Function count() As Integer
        Return ldgDAL.selectCount()
    End Function
    Public Function insert(ldg As LoaiDocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldgDAL.insert(ldg)
    End Function
    Public Function update(lhs As LoaiDocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldgDAL.update(lhs)
    End Function
    Public Function delete(maLoai As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldgDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaiHS As List(Of LoaiDocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldgDAL.selectALL(listLoaiHS)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ldgDAL.getNextID(nextID)
    End Function
End Class
