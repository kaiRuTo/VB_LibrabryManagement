Public Class NhaXuatBanDTO
    Private strMaNhaXuatBan As String
    Private strNhaXuatBan As String

    Public Sub New(strmNxb As String, strNxb As String)
        Me.strMaNhaXuatBan = strmNxb
        Me.strNhaXuatBan = strNxb
    End Sub

    Public Property maNhaXuatBan As String
        Get
            Return strMaNhaXuatBan
        End Get
        Set(value As String)
            strMaNhaXuatBan = value
        End Set
    End Property

    Public Property nhaXuatBan As String
        Get
            Return strNhaXuatBan
        End Get
        Set(value As String)
            strNhaXuatBan = value
        End Set
    End Property
End Class
