Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class DocGiaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMSDG(ByRef nextMsdg As String) As Result 'ex: 18222229

        nextMsdg = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextMsdg = x + "000000"

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
                            msOnDB = reader("madocgia")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then
                        If (msOnDB.Length >= 8) Then
                            Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                            Dim iCurrentYear = Integer.Parse(currentYear)
                            Dim currentYearOnDB = msOnDB.Substring(0, 2)
                            Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                            Dim year = iCurrentYear
                            If (year < icurrentYearOnDB) Then
                                year = icurrentYearOnDB
                            End If
                            nextMsdg = year.ToString()
                            Dim v = msOnDB.Substring(2)
                            Dim convertDecimal = Convert.ToDecimal(v)
                            convertDecimal = convertDecimal + 1
                            Dim tmp = convertDecimal.ToString()
                            tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                            nextMsdg = nextMsdg + tmp
                            System.Console.WriteLine(nextMsdg)
                        End If
                    End If


                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số đọc giả kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(dg As DocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblDocGia] ([madocgia], [maloaidocgia],[hoten] ,[diachi], [ngaysinh],[email],[ngaylapthe])"
        query &= "VALUES (@madocgia,@maloaidocgia,@hoten,@diachi,@ngaysinh,@email,@ngaylapthe)"

        'get MSdg
        Dim nextMsdg = "1"
        buildMSDG(nextMsdg)
        dg.MaDocGia = nextMsdg

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madocgia", dg.MaDocGia)
                    .Parameters.AddWithValue("@maloaidocgia", dg.MaLoaiDocGia)
                    .Parameters.AddWithValue("@hoten", dg.HoTen)
                    .Parameters.AddWithValue("@diachi", dg.DiaChi)
                    .Parameters.AddWithValue("@ngaysinh", dg.NgaySinh)
                    .Parameters.AddWithValue("@email", dg.Email)
                    .Parameters.AddWithValue("@ngaylapthe", dg.NgayLapThe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listDocGia As List(Of DocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [madocgia], [maloaidocgia], [hoten], [diachi], [ngaysinh],[email],[ngaylapthe]"
        query &= "FROM [tblDocGia]"


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
                        listDocGia.Clear()
                        While reader.Read()
                            listDocGia.Add(New DocGiaDTO(reader("madocgia"), reader("hoten"), reader("maloaidocgia"), reader("diachi"), reader("email"), reader("ngaysinh"), reader("ngaylapthe")))

                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByType(maLoai As Integer, ByRef listDocGia As List(Of DocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [madocgia], [maloaidocgia], [hoten], [diachi], [ngaysinh],[email],[ngaylapthe] "
        query &= "FROM [tblDocGia] "
        query &= "WHERE [maloaidocgia] = @maloaidocgia "

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
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDocGia.Clear()
                        While reader.Read()
                            listDocGia.Add(New DocGiaDTO(reader("madocgia"), reader("hoten"), reader("maloaidocgia"), reader("diachi"), reader("email"), reader("ngaysinh"), reader("ngaylapthe")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả đọc giả theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(dg As DocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblDocGia] SET"
        query &= " [maloaidocgia] = @maloaidocgia "
        query &= " ,[hoten] = @hoten "
        query &= " ,[diachi] = @diachi "
        query &= " ,[ngaysinh] = @ngaysinh "
        query &= " ,[email] = @email "
        query &= " ,[ngaylapthe] = @ngaylapthe "
        query &= " WHERE "
        query &= " [madocgia] = @madocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", dg.MaLoaiDocGia)
                    .Parameters.AddWithValue("@hoten", dg.HoTen)
                    .Parameters.AddWithValue("@diachi", dg.DiaChi)
                    .Parameters.AddWithValue("@ngaysinh", dg.NgaySinh)
                    .Parameters.AddWithValue("@madocgia", dg.MaDocGia)
                    .Parameters.AddWithValue("@email", dg.Email)
                    .Parameters.AddWithValue("@ngaylapthe", dg.NgayLapThe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maDocGia As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblDocGia] "
        query &= " WHERE "
        query &= " [madocgia] = @madocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madocgia", maDocGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
