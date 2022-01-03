Public MustInherit Class Vehiculo
    Protected NroChapa As String
    Protected DocCliente As String
    Protected NombreApellido As String
    Protected Telefono As String
    Protected FechaAlquiler As Date
    Protected MontoAlquiler As Double
    Protected TipoVehiculo As String

    Public Property pTipoVehiculo As String
        Get
            Return Me.TipoVehiculo
        End Get
        Set(value As String)
            Me.TipoVehiculo = value
        End Set
    End Property

    Public Property pMontoAlquiler As Double
        Get
            Return Me.MontoAlquiler
        End Get
        Set(value As Double)
            Me.MontoAlquiler = value
        End Set
    End Property

    Public Property pFechaAlquiler As Date
        Get
            Return Me.FechaAlquiler
        End Get
        Set(value As Date)
            Me.FechaAlquiler = value
        End Set
    End Property

    Public Property pTelefono As String
        Get
            Return Me.Telefono
        End Get
        Set(value As String)
            Me.Telefono = value
        End Set
    End Property

    Public Property pNombreApellido As String
        Get
            Return Me.NombreApellido
        End Get
        Set(value As String)
            Me.NombreApellido = value
        End Set
    End Property

    Public Property pDocCliente As String
        Get
            Return Me.DocCliente
        End Get
        Set(value As String)
            Me.DocCliente = value
        End Set
    End Property

    Public Property pNroChapa As String
        Get
            Return Me.NroChapa
        End Get
        Set(value As String)
            Me.NroChapa = value
        End Set
    End Property

End Class

'Clases hijas
Public Class autobus
    Inherits Vehiculo
    Private CantKmInicio As Double
    Private CantKmFin As Double

    Public Property pCantKmFin As Double
        Get
            Return Me.CantKmFin
        End Get
        Set(value As Double)
            Me.CantKmFin = value
        End Set
    End Property

    Public Property pCantKmInicio As Double
        Get
            Return Me.CantKmInicio
        End Get
        Set(value As Double)
            Me.CantKmInicio = value
        End Set
    End Property
    'Metodo para calcular monto-alquiler de Autobus
    Public Function CalcularMontoAlquilerAutobus() As Decimal
        Dim vCantHorasAlquiler As Integer

        vCantHorasAlquiler = Me.pCantKmFin - Me.CantKmInicio
        Me.MontoAlquiler = vCantHorasAlquiler * 65000
        Return Me.MontoAlquiler

    End Function

End Class

Public Class Tractor
    Inherits Vehiculo
    Private fechaDevolucion As Date

    Public Property pfechaDevolucion As Date
        Get
            Return Me.fechaDevolucion
        End Get
        Set(value As Date)
            Me.fechaDevolucion = value
        End Set
    End Property
    'Metodo para calcular monto-alquiler de Tractor
    Public Function CalcularMontoAlquilerTractor() As Decimal
        Dim vCantDiasAlquiler As Integer

        vCantDiasAlquiler = DateDiff(DateInterval.Day, Me.FechaAlquiler, Me.fechaDevolucion)
        Me.MontoAlquiler = vCantDiasAlquiler * 120000
        Return Me.MontoAlquiler

    End Function

End Class

