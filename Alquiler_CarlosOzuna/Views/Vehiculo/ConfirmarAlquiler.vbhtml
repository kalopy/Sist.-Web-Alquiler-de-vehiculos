
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>ConfirmarAlquiler</title>
</head>
<body>
    <div>
        <h2>Datos de la Facturacion</h2>

        <table>

            <tr>
                <td>Nombre & Apellido:</td>
                <td>@Model.pNombreApellido</td>
            </tr>

            <tr>
                <td>Documento del cliente o RUC: </td>
                <td>@Model.pDocCliente</td>
            </tr>

            <tr>
                <td>Nro. de chapa:</td>
                <td>@Model.pNroChapa</td>
            </tr>

            <tr>
                <td>Tipo de Vehiculo:</td>
                <td>@Model.pTipoVehiculo</td>
            </tr>

            <tr>
                <td>Monto Facturado:</td>
                <td>@Model.pMontoAlquiler</td>
            </tr>

           </table>
    </div>
</body>
</html>
