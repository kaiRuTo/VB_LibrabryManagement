Public Class NhaXuatBanDTO
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 342025a... them tg,nxb
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
<<<<<<< HEAD
=======
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
>>>>>>> 988666cf67b8faffc6b2bf1a1817545712ec10f1
=======
>>>>>>> 342025a... them tg,nxb
        End Set
    End Property
End Class
