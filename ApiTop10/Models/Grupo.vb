Public Class Grupo
    Private _códgrupo As String
    Private _descricao As String
    Private _subst As Double
    Private _descobal As Single
    Private _lucro As Single
    Private _revenda As Single
    Private _comissão As Single
    Private _entraresultado As Boolean
    Private _comissaoservico As Boolean
    Private _custooperacional As Single
    Private _naomovimentaestoque As Boolean
    Private _idexportacao As Long

    Public Property códgrupo As String
        Get
            Return _códgrupo
        End Get
        Set(value As String)
            _códgrupo = value
        End Set
    End Property

    Public Property descricao As String
        Get
            Return _descricao
        End Get
        Set(value As String)
            _descricao = value
        End Set
    End Property

    Public Property subst As Double
        Get
            Return _subst
        End Get
        Set(value As Double)
            _subst = value
        End Set
    End Property

    Public Property descobal As Single
        Get
            Return _descobal
        End Get
        Set(value As Single)
            _descobal = value
        End Set
    End Property

    Public Property lucro As Single
        Get
            Return _lucro
        End Get
        Set(value As Single)
            _lucro = value
        End Set
    End Property

    Public Property revenda As Single
        Get
            Return _revenda
        End Get
        Set(value As Single)
            _revenda = value
        End Set
    End Property

    Public Property comissão As Single
        Get
            Return _comissão
        End Get
        Set(value As Single)
            _comissão = value
        End Set
    End Property

    Public Property entraresultado As Boolean
        Get
            Return _entraresultado
        End Get
        Set(value As Boolean)
            _entraresultado = value
        End Set
    End Property

    Public Property comissaoservico As Boolean
        Get
            Return _comissaoservico
        End Get
        Set(value As Boolean)
            _comissaoservico = value
        End Set
    End Property

    Public Property custooperacional As Single
        Get
            Return _custooperacional
        End Get
        Set(value As Single)
            _custooperacional = value
        End Set
    End Property

    Public Property naomovimentaestoque As Boolean
        Get
            Return _naomovimentaestoque
        End Get
        Set(value As Boolean)
            _naomovimentaestoque = value
        End Set
    End Property

    Public Property idexportacao As Long
        Get
            Return _idexportacao
        End Get
        Set(value As Long)
            _idexportacao = value
        End Set
    End Property
End Class
