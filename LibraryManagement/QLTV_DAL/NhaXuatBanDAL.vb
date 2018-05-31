Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class NhaXuatBanDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "Select TOP 1 [manhaxuatban] "
        query &= "From [tblNhaXuatBan] "
        query &= "Order By [manhaxuatban] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("manhaxuatban")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getNextID() As Integer
        Dim id As Integer
        id = 1

        Dim query As String = String.Empty
        query &= "Select TOP 1 [manhaxuatban] "
        query &= "From [tblNhaXuatBan] "
        query &= "Order By [manhaxuatban] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("manhaxuatban")
                        End While
                    End If
                    ' new ID = current ID + 1
                    id = idOnDB + 1
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return id ' thanh cong
    End Function

    Public Function insert(tg As NhaXuatBanDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblNhaXuatBan] ([manhaxuatban], [tennhaxuatban])"
        query &= "VALUES (@manhaxuatban,@tennhaxuatban)"

        tg.MaNhaXuatBan = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhaxuatban", tg.MaNhaXuatBan)
                    .Parameters.AddWithValue("@tennhaxuatban", tg.TenNhaXuatBan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(tg As NhaXuatBanDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblNhaXuatBan] SET"
        query &= " [tennhaxuatban] = @tennhaxuatban "
        query &= "WHERE "
        query &= " [manhaxuatban] = @manhaxuatban "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhaxuatban", tg.MaNhaXuatBan)
                    .Parameters.AddWithValue("@tennhaxuatban", tg.TenNhaXuatBan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listnhaxuatban As List(Of NhaXuatBanDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [manhaxuatban], [tennhaxuatban]"
        query &= " FROM [tblNhaXuatBan]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listnhaxuatban.Clear()
                        While reader.Read()
                            listnhaxuatban.Add(New NhaXuatBanDTO(reader("manhaxuatban"), reader("tennhaxuatban")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(Manhaxuatban As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblNhaXuatBan]  "
        query &= " WHERE "
        query &= " [manhaxuatban] = @manhaxuatban "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhaxuatban", Manhaxuatban)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectCount() As Integer
        Dim query As String = String.Empty
        query &= " SELECT COUNT([manhaxuatban]) "
        query &= " FROM [tblnhaxuatban] "

        Dim count As Integer
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    count = comm.ExecuteScalar()

                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return 100 ' them that bai!!!
                End Try
            End Using
        End Using
        Return count ' thanh cong

    End Function
End Class
