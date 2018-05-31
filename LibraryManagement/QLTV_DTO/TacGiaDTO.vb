Public Class TacGiaDTO
    Private iMaTacGia As Integer
    Private strTenTacGia As String

    Public Sub New()

    End Sub
    Public Sub New(iMaTacGia As Integer, strTenTacGia As String)
        Me.iMaTacGia = iMaTacGia
        Me.strTenTacGia = strTenTacGia
    End Sub

    Public Property MaTacGia As Integer
        Get
            Return iMaTacGia
        End Get
        Set(value As Integer)
            iMaTacGia = value
        End Set
    End Property

    Public Property TenTacGia As String
        Get
            Return strTenTacGia
        End Get
        Set(value As String)
            strTenTacGia = value
        End Set
    End Property
End Class
