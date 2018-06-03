Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class TacGiaDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectAll(ByRef listTacGia As List(Of TacGiaDTO)) As Result
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
                        listTacGia.Clear()
                        While reader.Read()
                            listTacGia.Add(New TacGiaDTO(reader("matacgia"), reader("tentacgia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()

                    Return New Result(False, "Lấy tất cả tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insertSach(ms As String, mtg As String) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblCTSach] ([masach], [matacgia])"
        query &= "VALUES (@masach,@matacgia)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", ms)
                    .Parameters.AddWithValue("@matacgia", mtg)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm tác giả sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function deleteSach(ms As String, mtg As String) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblCTSach] "
        query &= " WHERE "
        query &= " [masach] = @masach, [matacgia] = @matacgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", ms)
                    .Parameters.AddWithValue("@matacgia", mtg)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa sách của tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function loadTacGia(ms As String, ByRef mtg As String) As Result
        Dim query As String = String.Empty
        query &= " SELECT matacgia FROM [tblCTSach] "
        query &= " WHERE [masach] = @masach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", ms)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            mtg = reader("matacgia")
                        End While
                    End If
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "load tác giả sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
