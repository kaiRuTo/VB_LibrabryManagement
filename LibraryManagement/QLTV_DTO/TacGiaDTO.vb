Public Class TacGiaDTO
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 342025a... them tg,nxb
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
<<<<<<< HEAD
=======
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
>>>>>>> 988666cf67b8faffc6b2bf1a1817545712ec10f1
=======
>>>>>>> 342025a... them tg,nxb
        Get
            Return strTenTacGia
        End Get
        Set(value As String)
            strTenTacGia = value
        End Set
    End Property
End Class
