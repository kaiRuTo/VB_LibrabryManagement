Public Class NhaXuatBanDTO
    Private iMaNhaXuatBan As Integer
    Private strTenNhaXuatBan As String

    Public Sub New()

    End Sub

    Public Sub New(iMaNhaXuatBan As Integer, strTenNhaXuatBan As String)
        Me.iMaNhaXuatBan = iMaNhaXuatBan
        Me.strTenNhaXuatBan = strTenNhaXuatBan
    End Sub

    Public Property MaNhaXuatBan As Integer
        Get
            Return iMaNhaXuatBan
        End Get
        Set(value As Integer)
            iMaNhaXuatBan = value
        End Set
    End Property

    Public Property TenNhaXuatBan As String
        Get
            Return strTenNhaXuatBan
        End Get
        Set(value As String)
            strTenNhaXuatBan = value
        End Set
    End Property
End Class
