Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class QuyDinhBUS
    Private qdDAL As QuyDinhDAL
    Public Sub New()
        qdDAL = New QuyDinhDAL()
    End Sub
    Public Sub New(connectionString As String)
        qdDAL = New QuyDinhDAL(connectionString)
    End Sub

    Public Function selectQuyDinh(ByRef quydinh As QuyDinhDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return qdDAL.selectQuyDinh(quydinh)
    End Function
    Public Function update(qd As QuyDinhDTO) As Result
        Return qdDAL.update(qd)
    End Function
End Class
