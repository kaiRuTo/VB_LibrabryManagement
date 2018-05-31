Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class QuyDinhDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectQuyDinh(ByRef quydinh As QuyDinhDTO) As Result
        Dim query As String = String.Empty
        query &= "SELECT [tuoitoithieu],[tuoitoida],[khoangnamxuatban],[soluongsachtoida],[songaymuontoida] "
        query &= "FROM [tblThamSo] "

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
                            quydinh = New QuyDinhDTO(reader("tuoitoithieu"), reader("tuoitoida"), reader("khoangnamxuatban"), reader("soluongsachtoida"), reader("songaymuontoida"))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả quy dinh theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(qd As QuyDinhDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblThamSo] SET"
        query &= " [tuoitoithieu] = @tuoitoithieu "
        query &= " ,[tuoitoida] = @tuoitoida "
        query &= " ,[khoangnamxuatban] = @khoangnamxuatban "
        query &= " ,[soluongsachtoida] = @soluongsachtoida "
        query &= " ,[songaymuontoida] = @songaymuontoida "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tuoitoithieu", qd.TuoiToiThieu)
                    .Parameters.AddWithValue("@tuoitoida", qd.TuoiToiDa)
                    .Parameters.AddWithValue("@khoangnamxuatban", qd.KhoangNamXuatBan)
                    .Parameters.AddWithValue("@soluongsachtoida", qd.SoLuongSachToiDa)
                    .Parameters.AddWithValue("@songaymuontoida", qd.SoNgayMuonToiDa)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Quy Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
