Public Class Ciudad
    'Attributes
    Private _idCiudad As Integer
    Private _nombre As String
    Private _estado As Boolean

    'Properties
    Public Property IdCiudad As Integer
        Get
            Return _idCiudad
        End Get
        Set(value As Integer)
            _idCiudad = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

    'Empty constructor
    Public Sub New()

    End Sub
    'Constructor
    Public Sub New(idCiudad As Integer, nombre As String, estado As Boolean)
        Me.IdCiudad = idCiudad
        Me.Nombre = nombre
        Me.Estado = estado
    End Sub
End Class
