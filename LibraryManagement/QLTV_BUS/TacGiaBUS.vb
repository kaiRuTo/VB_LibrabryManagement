Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class TacGiaBUS
    Private tgDAL As TacGiaDAL
    Public Sub New()
        tgDAL = New TacGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        tgDAL = New TacGiaDAL(connectionString)
    End Sub

    Public Function isValidName(tg As TacGiaDTO) As Boolean

        If (tg.TenTacGia.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function isValidCount() As Boolean

        If (count() >= 100) Then
            Return False
        End If

        Return True

    End Function

    Public Function count() As Integer
        Return tgDAL.selectCount()
    End Function
    Public Function insert(tg As TacGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tgDAL.insert(tg)
    End Function
    Public Function update(tg As TacGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tgDAL.update(tg)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tgDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoais As List(Of TacGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tgDAL.selectALL(listLoais)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return tgDAL.getNextID(nextID)
    End Function
End Class
