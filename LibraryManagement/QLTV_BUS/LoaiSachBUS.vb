Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class LoaiSachBUS
    Private lsDAL As LoaiSachDAL
    Public Sub New()
        lsDAL = New LoaiSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        lsDAL = New LoaiSachDAL(connectionString)
    End Sub

    Public Function isValidName(ls As LoaiSachDTO) As Boolean

        If (ls.TenLoai.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function isValidCount() As Boolean

        If (count() >= 3) Then
            Return False
        End If

        Return True

    End Function

    Public Function count() As Integer
        Return lsDAL.selectCount()
    End Function
    Public Function insert(ls As LoaiSachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.insert(ls)
    End Function
    Public Function update(ls As LoaiSachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.update(ls)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoais As List(Of LoaiSachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lsDAL.selectALL(listLoais)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lsDAL.getNextID(nextID)
    End Function
End Class


