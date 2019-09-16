Public Class ControleCodigo
    Private _codigo As Long

    Public Property codigo As Long
        Get
            Return _codigo
        End Get
        Set(value As Long)
            _codigo = value
        End Set
    End Property
End Class
