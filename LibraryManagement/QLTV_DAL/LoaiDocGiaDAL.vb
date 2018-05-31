Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class LoaiDocGiaDAL
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
        query &= "Select TOP 1 [maloaidocgia] "
        query &= "From [tblLoaiDocGia] "
        query &= "Order By [maloaidocgia] DESC "

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
                            idOnDB = reader("maloaidocgia")
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

    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "Select TOP 1 [maloaidocgia] "
        query &= "From [tblLoaiDocGia] "
        query &= "Order By [maloaidocgia] DESC "

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
                            idOnDB = reader("maloaidocgia")
                        End While
                        nextID = idOnDB + 1
                    Else
                        nextID = 1
                    End If

                    ' new ID = current ID + 1
                    ' nextID = idOnDB + 1

                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Loại đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert_LoaiDocGia(ldg As LoaiDocGiaDTO) As Integer
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia])"
        query &= "VALUES (@maloaidocgia,@tenloaidocgia)"

        ldg.MaLoaiDocGia = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", ldg.MaLoaiDocGia)
                    .Parameters.AddWithValue("@tenloaidocgia", ldg.TenLoaiDocGia)
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

    Public Function insert(ldg As LoaiDocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia])"
        query &= "VALUES (@maloaidocgia,@tenloaidocgia)"

        ldg.MaLoaiDocGia = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", ldg.MaLoaiDocGia)
                    .Parameters.AddWithValue("@tenloaidocgia", ldg.TenLoaiDocGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Loại đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update_LoaiDocGia(ldg As LoaiDocGiaDTO) As Integer
        Dim query As String = String.Empty
        query &= " UPDATE [tblLoaiDocGia] SET"
        query &= " [tenloaidocgia] = @tenloaidocgia "
        query &= "WHERE "
        query &= " [maloaidocgia] = @maloaidocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", ldg.MaLoaiDocGia)
                    .Parameters.AddWithValue("@tenloaidocgia", ldg.TenLoaiDocGia)
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

    Public Function update(ldg As LoaiDocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblLoaiDocGia] SET"
        query &= " [tenloaidocgia] = @tenloaidocgia "
        query &= "WHERE "
        query &= " [maloaidocgia] = @maloaidocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", ldg.MaLoaiDocGia)
                    .Parameters.AddWithValue("@tenloaidocgia", ldg.TenLoaiDocGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Loại đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_LoaiDocGia() As List(Of LoaiDocGiaDTO)

        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim query As String = String.Empty
        query &= " SELECT [maloaidocgia], [tenloaidocgia]"
        query &= " FROM [tblLoaiDocGia]"


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
                            listLoaiDocGia.Add(New LoaiDocGiaDTO(reader("maloaidocgia"), reader("tenloaidocgia")))
                        End While
                    End If

                Catch
                    conn.Close()
                    Return Nothing  ' that bai!!!
                End Try
            End Using
        End Using
        Return listLoaiDocGia ' thanh cong
    End Function

    Public Function selectALL(ByRef listLoaiDocGia As List(Of LoaiDocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maloaidocgia], [tenloaidocgia]"
        query &= " FROM [tblLoaiDocGia]"


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
                        listLoaiDocGia.Clear()
                        While reader.Read()
                            listLoaiDocGia.Add(New LoaiDocGiaDTO(reader("maloaidocgia"), reader("tenloaidocgia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete_LoaiDocGia(maLoai As Integer) As Integer

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblLoaiDocGia]  "
        query &= " WHERE "
        query &= " [maloaidocgia] = @maloaidocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", maLoai)
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

    Public Function delete(maLoai As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblLoaiDocGia]  "
        query &= " WHERE "
        query &= " [maloaidocgia] = @maloaidocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", maLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa loại đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectCount() As Integer
        Dim query As String = String.Empty
        query &= " SELECT COUNT([maloaidocgia]) "
        query &= " FROM [tblLoaiDocGia] "

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

