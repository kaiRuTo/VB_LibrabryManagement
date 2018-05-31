Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility


Public Class SachBUS
    Private sachDAL As SachDAL
    Public Sub New()
        sachDAL = New SachDAL()
    End Sub
    Public Sub New(connectionString As String)
        sachDAL = New SachDAL(connectionString)
    End Sub

    Public Function BuildMS(ByRef nextMS As String) As Result

        Return sachDAL.buildMS(nextMS)
    End Function
End Class
