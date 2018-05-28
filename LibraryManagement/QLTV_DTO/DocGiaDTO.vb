Public Class DocGiaDTO
    Private strMaDocGia As String
    Private strHoTen As String
    Private iMaLoaiDocGia As Integer
    Private strDiaChi As String
    Private strEmail As String
    Private dateNgaySinh As DateTime
    Private dateNgayLapThe As DateTime
    Public Sub New()
    End Sub

    Public Sub New(iMaDocGia As String, strHoTen As String, iMaLoaiDocGia As Integer, strDiaChi As String, strEmail As String, dateNgaySinh As Date, dateNgayLapThe As Date)
        Me.strMaDocGia = iMaDocGia
        Me.strHoTen = strHoTen
        Me.iMaLoaiDocGia = iMaLoaiDocGia
        Me.strDiaChi = strDiaChi
        Me.strEmail = strEmail
        Me.dateNgaySinh = dateNgaySinh
        Me.dateNgayLapThe = dateNgayLapThe
    End Sub

    Public Property MaDocGia As String
        Get
            Return strMaDocGia
        End Get
        Set(value As String)
            strMaDocGia = value
        End Set
    End Property

    Public Property HoTen As String
        Get
            Return strHoTen
        End Get
        Set(value As String)
            strHoTen = value
        End Set
    End Property

    Public Property MaLoaiDocGia As Integer
        Get
            Return iMaLoaiDocGia
        End Get
        Set(value As Integer)
            iMaLoaiDocGia = value
        End Set
    End Property

    Public Property DiaChi As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property

    Public Property NgaySinh As Date
        Get
            Return dateNgaySinh
        End Get
        Set(value As Date)
            dateNgaySinh = value
        End Set
    End Property

    Public Property NgayLapThe As Date
        Get
            Return dateNgayLapThe
        End Get
        Set(value As Date)
            dateNgayLapThe = value
        End Set
    End Property
End Class
