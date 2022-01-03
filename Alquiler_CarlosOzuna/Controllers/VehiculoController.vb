Imports System.Web.Mvc

Namespace Controllers
    Public Class VehiculoController
        Inherits Controller

        ' GET: Vehiculo
        Function Index() As ActionResult
            Return View()
        End Function

        Function ConfirmarAlquiler(form As FormCollection) As ActionResult
            Return View(CalcularMontoAlquiler(form))
        End Function

        Function CalcularMontoAlquiler(form As FormCollection) As Object
            Select Case form("tipo_vehiculo")
                Case "Autobus"
                    Dim vAutobus As New autobus
                    With vAutobus
                        .pNroChapa = form("nro_chapa")
                        .pDocCliente = form("doc_cliente")
                        .pNombreApellido = form("NombreApellido")
                        .pTelefono = form("telefono")
                        .pFechaAlquiler = form("fecha_alquiler")
                        .pMontoAlquiler = form("monto_alquiler")
                        .pTipoVehiculo = form("tipo_vehiculo")
                        'Adicional para autobus
                        .pCantKmInicio = form("km_inicio")
                        .pCantKmFin = form("km_fin")
                    End With
                    vAutobus.CalcularMontoAlquilerAutobus()
                    Return vAutobus

                Case "Tractor"
                    Dim vTractor As New Tractor
                    With vTractor
                        .pNroChapa = form("nro_chapa")
                        .pDocCliente = form("doc_cliente")
                        .pNombreApellido = form("NombreApellido")
                        .pTelefono = form("telefono")
                        .pFechaAlquiler = form("fecha_alquiler")
                        .pMontoAlquiler = form("monto_alquiler")
                        .pTipoVehiculo = form("tipo_vehiculo")
                        'Adicional para tractor
                        .pfechaDevolucion = form("fecha_devolucion")
                    End With
                    vTractor.CalcularMontoAlquilerTractor()
                    Return vTractor
            End Select
        End Function


    End Class
End Namespace