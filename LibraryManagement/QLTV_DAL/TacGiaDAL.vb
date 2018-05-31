Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> 988666cf67b8faffc6b2bf1a1817545712ec10f1
=======
>>>>>>> 342025a... them tg,nxb
Public Class TacGiaDAL
    Private connectionString As String

    Public Sub New()
<<<<<<< HEAD
<<<<<<< HEAD
        ' Read ConnectionString value from App.config file
=======
>>>>>>> 988666cf67b8faffc6b2bf1a1817545712ec10f1
=======
        ' Read ConnectionString value from App.config file
>>>>>>> 342025a... them tg,nxb
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 342025a... them tg,nxb
    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "Select TOP 1 [matacgia] "
        query &= "From [tblTacGia] "
        query &= "Order By [matacgia] DESC "

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
                            idOnDB = reader("matacgia")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getNextID() As Integer
        Dim id As Integer
        id = 1

        Dim query As String = String.Empty
        query &= "Select TOP 1 [matacgia] "
        query &= "From [tblTacGia] "
        query &= "Order By [matacgia] DESC "

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
                            idOnDB = reader("matacgia")
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

    Public Function insert(tg As TacGiaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTacGia] ([matacgia], [tentacgia])"
        query &= "VALUES (@matacgia,@tentacgia)"

        tg.MaTacGia = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matacgia", tg.MaTacGia)
                    .Parameters.AddWithValue("@tentacgia", tg.TenTacGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(tg As TacGiaDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblTacGia] SET"
        query &= " [tentacgia] = @tentacgia "
        query &= "WHERE "
        query &= " [matacgia] = @matacgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matacgia", tg.MaTacGia)
                    .Parameters.AddWithValue("@tentacgia", tg.TenTacGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listtacgia As List(Of TacGiaDTO)) As Result

<<<<<<< HEAD
=======
    Public Function selectAll(ByRef listTacGia As List(Of TacGiaDTO)) As Result
>>>>>>> 988666cf67b8faffc6b2bf1a1817545712ec10f1
=======
>>>>>>> 342025a... them tg,nxb
        Dim query As String = String.Empty
        query &= " SELECT [matacgia], [tentacgia]"
        query &= " FROM [tblTacGia]"


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
<<<<<<< HEAD
<<<<<<< HEAD
                        listtacgia.Clear()
                        While reader.Read()
                            listtacgia.Add(New TacGiaDTO(reader("matacgia"), reader("tentacgia")))
=======
                        listTacGia.Clear()
                        While reader.Read()
                            listTacGia.Add(New TacGiaDTO(reader("matacgia"), reader("tentacgia")))
>>>>>>> 988666cf67b8faffc6b2bf1a1817545712ec10f1
=======
                        listtacgia.Clear()
                        While reader.Read()
                            listtacgia.Add(New TacGiaDTO(reader("matacgia"), reader("tentacgia")))
>>>>>>> 342025a... them tg,nxb
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 342025a... them tg,nxb
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(MaTacGia As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblTacGia]  "
        query &= " WHERE "
        query &= " [matacgia] = @matacgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matacgia", MaTacGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectCount() As Integer
        Dim query As String = String.Empty
        query &= " SELECT COUNT([matacgia]) "
        query &= " FROM [tblTacGia] "

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

<<<<<<< HEAD
=======

                    Return New Result(False, "Lấy tất cả tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
>>>>>>> 988666cf67b8faffc6b2bf1a1817545712ec10f1
=======
>>>>>>> 342025a... them tg,nxb
    End Function
End Class
