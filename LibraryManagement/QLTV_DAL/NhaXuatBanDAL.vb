Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class NhaXuatBanDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function SelectAll(listNhaXuatBan As List(Of NhaXuatBanDTO)) As Result
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
                        listNhaXuatBan.Clear()
                        While reader.Read()
                            listNhaXuatBan.Add(New NhaXuatBanDTO(reader("manhaxuatban"), reader("tennhaxuatban")))
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
End Class
