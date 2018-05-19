Public Class LoaiDocGiaDTO
    Private iMaLoaiDocGia As Integer
    Private strTenLoaiDocGia As String
    Public Sub New()
    End Sub

    Public Sub New(iMaLoaiDocGia As Integer, strTenLoaiDocGia As String)
        Me.iMaLoaiDocGia = iMaLoaiDocGia
        Me.strTenLoaiDocGia = strTenLoaiDocGia
    End Sub

    Public Property MaLoaiDocGia As Integer
        Get
            Return iMaLoaiDocGia
        End Get
        Set(value As Integer)
            iMaLoaiDocGia = value
        End Set
    End Property

    Public Property TenLoaiDocGia As String
        Get
            Return strTenLoaiDocGia
        End Get
        Set(value As String)
            strTenLoaiDocGia = value
        End Set
    End Property
End Class
