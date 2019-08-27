Imports ApiTop10

Public Class Exportacao
    Private _computador As String
    Private _data As Date
    Private _cnpjemitente As String
    Private _cnpjdestino As String
    Private _grupos As List(Of Grupo)
    Private _produtos As List(Of Produto)

    Public Property Computador As String
        Get
            Return _computador
        End Get
        Set(value As String)
            _computador = value
        End Set
    End Property

    Public Property Data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property

    Public Property Cnpjemitente As String
        Get
            Return _cnpjemitente
        End Get
        Set(value As String)
            _cnpjemitente = value
        End Set
    End Property

    Public Property Cnpjdestino As String
        Get
            Return _cnpjdestino
        End Get
        Set(value As String)
            _cnpjdestino = value
        End Set
    End Property

    Public Property Grupos As List(Of Grupo)
        Get
            Return _grupos
        End Get
        Set(value As List(Of Grupo))
            _grupos = value
        End Set
    End Property

    Public Property Produtos As List(Of Produto)
        Get
            Return _produtos
        End Get
        Set(value As List(Of Produto))
            _produtos = value
        End Set
    End Property
End Class
