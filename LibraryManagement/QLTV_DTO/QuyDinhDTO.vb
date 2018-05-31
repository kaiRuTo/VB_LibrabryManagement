Public Class QuyDinhDTO
    Private iTuoiToiThieu As Integer
    Private iTuoiToiDa As Integer
    Private iKhoangNamXuatBan As Integer
    Private iSoLuongSachToiDa As Integer
    Private iSoNgayMuonToiDa As Integer
    Public Sub New()

    End Sub

    Public Sub New(iTuoiToiThieu As Integer, iTuoiToiDa As Integer, iKhoangNamXuatBan As Integer, iSoLuongSachToiDa As Integer, iSoNgayMuonToiDa As Integer)
        Me.iTuoiToiThieu = iTuoiToiThieu
        Me.iTuoiToiDa = iTuoiToiDa
        Me.iKhoangNamXuatBan = iKhoangNamXuatBan
        Me.iSoLuongSachToiDa = iSoLuongSachToiDa
        Me.iSoNgayMuonToiDa = iSoNgayMuonToiDa
    End Sub

    Public Property TuoiToiThieu As Integer
        Get
            Return iTuoiToiThieu
        End Get
        Set(value As Integer)
            iTuoiToiThieu = value
        End Set
    End Property

    Public Property TuoiToiDa As Integer
        Get
            Return iTuoiToiDa
        End Get
        Set(value As Integer)
            iTuoiToiDa = value
        End Set
    End Property

    Public Property KhoangNamXuatBan As Integer
        Get
            Return iKhoangNamXuatBan
        End Get
        Set(value As Integer)
            iKhoangNamXuatBan = value
        End Set
    End Property

    Public Property SoLuongSachToiDa As Integer
        Get
            Return iSoLuongSachToiDa
        End Get
        Set(value As Integer)
            iSoLuongSachToiDa = value
        End Set
    End Property

    Public Property SoNgayMuonToiDa As Integer
        Get
            Return iSoNgayMuonToiDa
        End Get
        Set(value As Integer)
            iSoNgayMuonToiDa = value
        End Set
    End Property
End Class
