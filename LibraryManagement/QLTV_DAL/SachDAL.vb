Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class SachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMS(ByRef nextMS As String) As Result 'ex: S18222229

        nextMS = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextMS = "S" + x + "000000"

        Dim query As String = String.Empty
        query &= "Select TOP 1 [madocgia]  "
        query &= "From [tblDocGia]  "
        query &= "Order By [madocgia] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("masach")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then
                        If (msOnDB.Length >= 9) Then
                            Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                            Dim iCurrentYear = Integer.Parse(currentYear)
                            Dim currentYearOnDB = msOnDB.Substring(0, 2)
                            Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                            Dim year = iCurrentYear
                            If (year < icurrentYearOnDB) Then
                                year = icurrentYearOnDB
                            End If
                            nextMS = "S" + year.ToString()
                            msOnDB = msOnDB.Remove(0, 1)
                            Dim v = msOnDB.Substring(2)
                            Dim convertDecimal = Convert.ToDecimal(v)
                            convertDecimal = convertDecimal + 1
                            Dim tmp = convertDecimal.ToString()
                            tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                            nextMS = nextMS + tmp
                            System.Console.WriteLine(nextMS)
                        End If
                    End If


                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã sách kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(s As SachDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblSach] ([masach], [tensach],[maloaisach] ,[manhaxuatban], [ngaynhap],[trigia],[soluongsach], [soluongconlai])"
        query &= "VALUES (@masach, @tensach, @maloaisach, @namxuatban, @ngaynhap, @trigia, @soluongsach, @soluongconlai)"

        'get MSdg
        Dim nextMS = "1"
        buildMS(nextMS)
        s.maSach = nextMS

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", s.maSach)
                    .Parameters.AddWithValue("@tensach", s.tenSach)
                    .Parameters.AddWithValue("@maloaisach", s.maLoaiSach)
                    .Parameters.AddWithValue("@manhaxuatban", s.maNhaXuatBan)
                    .Parameters.AddWithValue("@namxuatban", s.namXuatBan)
                    .Parameters.AddWithValue("@ngaynhap", s.ngayNhap)
                    .Parameters.AddWithValue("@trigia", s.triGia)
                    .Parameters.AddWithValue("@soluongsach", s.soLuongSach)
                    .Parameters.AddWithValue("@soluongconlai", s.soLuongConLai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
