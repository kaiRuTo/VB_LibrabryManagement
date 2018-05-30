Public Class TacGiaDTO
    Private strMaTacGia As String
    Private strTenTacGia As String

    Public Sub New(strmTG As String, strtTG As String)
        Me.strMaTacGia = strmTG
        Me.strTenTacGia = strtTG
    End Sub


    Public Property maTacGia As String
        Get
            Return strMaTacGia
        End Get
        Set(value As String)
            strMaTacGia = value
        End Set
    End Property

    Public Property tenTacGia As String
        Get
            Return strTenTacGia
        End Get
        Set(value As String)
            strTenTacGia = value
        End Set
    End Property
End Class
