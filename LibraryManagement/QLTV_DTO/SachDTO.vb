Public Class SachDTO
    Private strMaSach As String
    Private strTenSach As String
    Private strMaLoaiSach As String
    Private strMaNhaXuatBan As String
    Private strNamXuatBan As String
    Private dtNgayNhap As DateTime
    Private intTriGia As Integer
    Private intSoLuongSach As Integer
    Private intSoLuongConLai As Integer

    Public Property maSach As String
        Get
            Return strMaSach
        End Get
        Set(value As String)
            strMaSach = value
        End Set
    End Property

    Public Property tenSach As String
        Get
            Return strTenSach
        End Get
        Set(value As String)
            strTenSach = value
        End Set
    End Property

    Public Property maLoaiSach As String
        Get
            Return strMaLoaiSach
        End Get
        Set(value As String)
            strMaLoaiSach = value
        End Set
    End Property

    Public Property maNhaXuatBan As String
        Get
            Return strMaNhaXuatBan
        End Get
        Set(value As String)
            strMaNhaXuatBan = value
        End Set
    End Property

    Public Property namXuatBan As String
        Get
            Return strNamXuatBan
        End Get
        Set(value As String)
            strNamXuatBan = value
        End Set
    End Property

    Public Property ngayNhap As Date
        Get
            Return dtNgayNhap
        End Get
        Set(value As Date)
            dtNgayNhap = value
        End Set
    End Property

    Public Property triGia As Integer
        Get
            Return intTriGia
        End Get
        Set(value As Integer)
            intTriGia = value
        End Set
    End Property

    Public Property soLuongSach As Integer
        Get
            Return intSoLuongSach
        End Get
        Set(value As Integer)
            intSoLuongSach = value
        End Set
    End Property

    Public Property soLuongConLai As Integer
        Get
            Return intSoLuongConLai
        End Get
        Set(value As Integer)
            intSoLuongConLai = value
        End Set
    End Property
End Class
