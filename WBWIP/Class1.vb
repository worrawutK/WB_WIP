<Serializable()>
Public Class Class1

    Private _PKG As String
    Private _MCNo As String

    Function Getdata() As String
        Return PKG & "-" & MCNo
    End Function
    Public Sub New(PKG As String, MCNo As String)
        _PKG = PKG
        _MCNo = MCNo
    End Sub
    Public Property PKG As String
        Set(value As String)
            _PKG = value
        End Set
        Get
            Return _PKG
        End Get
    End Property

    Public Property MCNo As String
        Set(value As String)
            _MCNo = value
        End Set
        Get
            Return _MCNo
        End Get
    End Property

End Class
