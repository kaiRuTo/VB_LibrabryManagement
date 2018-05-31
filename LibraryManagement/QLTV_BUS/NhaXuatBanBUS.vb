<<<<<<< HEAD
﻿Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class NhaXuatBanBUS
    Private nxbDAL As NhaXuatBanDAL
    Public Sub New()
        nxbDAL = New NhaXuatBanDAL()
    End Sub
    Public Sub New(connectionString As String)
        nxbDAL = New NhaXuatBanDAL(connectionString)
    End Sub

    Public Function isValidName(nxb As NhaXuatBanDTO) As Boolean

        If (nxb.TenNhaXuatBan.Length < 1) Then
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
        Return nxbDAL.selectCount()
    End Function
    Public Function insert(nxb As NhaXuatBanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nxbDAL.insert(nxb)
    End Function
    Public Function update(nxb As NhaXuatBanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nxbDAL.update(nxb)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nxbDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listNXB As List(Of NhaXuatBanDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nxbDAL.selectALL(listNXB)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return nxbDAL.getNextID(nextID)
    End Function
=======
﻿Imports QLTV_DTO
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

>>>>>>> 988666cf67b8faffc6b2bf1a1817545712ec10f1
End Class
