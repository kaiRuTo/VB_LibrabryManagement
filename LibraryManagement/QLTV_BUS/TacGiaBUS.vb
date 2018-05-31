Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
<<<<<<< HEAD
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
=======

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

>>>>>>> 988666cf67b8faffc6b2bf1a1817545712ec10f1
End Class
