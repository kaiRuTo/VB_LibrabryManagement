Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class LoaiSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextID() As Integer
        Dim id As Integer
        id = 1

        Dim query As String = String.Empty
        query &= "Select TOP 1 [maloaisach] "
        query &= "From [tblLoaiSach] "
        query &= "Order By [maloaisach] DESC "

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
                            idOnDB = reader("maloaisach")
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
    Public Function getNextID(ByRef nextID As String) As Result

        Dim query As String = String.Empty
        query &= "Select TOP 1 [maloaisach] "
        query &= "From [tblLoaiSach] "
        query &= "Order By [maloaisach] DESC "

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
                    Dim idOnDB As String
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("maloaisach")
                        End While
                    Else
                        nextID = "LS1"
                        Return New Result(True)
                    End If
                    ' new ID = current ID + 1
                    'nextID = idOnDB + 1
                    idOnDB = (Integer.Parse(idOnDB.Remove(0, 2)) + 1).ToString()
                    nextID = "LS" + idOnDB
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = "LS1"
                    Return New Result(False, "Lấy ID kế tiếp của loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert_Loaisach(ldg As LoaiSachDTO) As Integer
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLoaisach] ([maloaisach], [tenloaisach])"
        query &= "VALUES (@maloaisach,@tenloaisach)"

        ldg.MaLoai = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaisach", ldg.MaLoai)
                    .Parameters.AddWithValue("@tenloaisach", ldg.TenLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch
                    conn.Close()
                    Return 1 ' them that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function
    Public Function insert(ldg As LoaiSachDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLoaisach] ([maloaisach], [tenloaisach])"
        query &= "VALUES (@maloaisach,@tenloaisach)"

        ldg.MaLoai = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaisach", ldg.MaLoai)
                    .Parameters.AddWithValue("@tenloaisach", ldg.TenLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update_Loaisach(ldg As LoaiSachDTO) As Integer
        Dim query As String = String.Empty
        query &= " UPDATE [tblLoaisach] SET"
        query &= " [tenloaisach] = @tenloaisach "
        query &= "WHERE "
        query &= " [maloaisach] = @maloaisach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaisach", ldg.MaLoai)
                    .Parameters.AddWithValue("@tenloaisach", ldg.TenLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return 1 ' them that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function
    Public Function update(ldg As LoaiSachDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblLoaisach] SET"
        query &= " [tenloaisach] = @tenloaisach "
        query &= "WHERE "
        query &= " [maloaisach] = @maloaisach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaisach", ldg.MaLoai)
                    .Parameters.AddWithValue("@tenloaisach", ldg.TenLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_Loaisach() As List(Of LoaiSachDTO)

        Dim listLoaisach = New List(Of LoaiSachDTO)
        Dim query As String = String.Empty
        query &= " SELECT [maloaisach], [tenloaisach]"
        query &= " FROM [tblLoaisach]"


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
                        While reader.Read()
                            listLoaisach.Add(New LoaiSachDTO(reader("maloaisach"), reader("tenloaisach")))
                        End While
                    End If

                Catch
                    conn.Close()
                    Return Nothing  ' that bai!!!
                End Try
            End Using
        End Using
        Return listLoaisach ' thanh cong
    End Function
    Public Function selectALL(ByRef listLoaisach As List(Of LoaiSachDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maloaisach], [tenloaisach]"
        query &= " FROM [tblLoaisach]"


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
                        listLoaisach.Clear()
                        While reader.Read()
                            listLoaisach.Add(New LoaiSachDTO(reader("maloaisach"), reader("tenloaisach")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete_Loaisach(maLoai As Integer) As Integer

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblLoaisach]  "
        query &= " WHERE "
        query &= " [maloaisach] = @maloaisach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaisach", maLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return 1 ' them that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function
    Public Function delete(maLoai As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblLoaisach]  "
        query &= " WHERE "
        query &= " [maloaisach] = @maloaisach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaisach", maLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectCount() As Integer
        Dim query As String = String.Empty
        query &= " SELECT COUNT([maloaisach]) "
        query &= " FROM [tblLoaisach] "

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
                    Return 3 ' them that bai!!!
                End Try
            End Using
        End Using
        Return count ' thanh cong

    End Function
End Class

