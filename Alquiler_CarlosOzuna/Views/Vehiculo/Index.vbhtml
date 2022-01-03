
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Datos del Vehiculo y el Cliente</title>
</head>
<body>
    <div>
        <h2>Datos del vehiculo y el Cliente</h2>
        <form action="../Vehiculo/ConfirmarAlquiler" method="post">
            <table>
                <tr>
                    <td>Nro. de Chapa:</td>
                    <td>
                        <input type="text" name="nro_chapa" id="nro_chapa" />
                    </td>
                </tr>

                <tr>
                    <td>C.I. o RUC del cliente:</td>
                    <td>
                        <input type="text" name="doc_cliente" id="doc_cliente" />
                    </td>
                </tr>

                <tr>
                    <td>Nombre & Apellido:</td>
                    <td>
                        <input type="text" name="NombreApellido" id="NombreApellido" />
                    </td>
                </tr>

                <tr>
                    <td>Telefono:</td>
                    <td>
                        <input type="text" name="telefono" id="telefono" />
                    </td>
                </tr>

                <tr>
                    <td>Fecha del alquiler:</td>
                    <td>
                        <input type="date" name="fecha_alquiler" id="fecha_alquiler" />
                    </td>
                </tr>
                
                <tr>
                    <td>Cantidad de kilómetros Inicial:</td>
                    <td>
                        <input type="number" name="km_inicio" id="km_inicio" />
                    </td>
                </tr>

                <tr>
                    <td>Cantidad de kilómetros Final:</td>
                    <td>
                        <input type="number" name="km_fin" id="km_fin" />
                    </td>
                </tr>

                <tr>
                    <td>Fecha de devolucion:</td>
                    <td>
                        <input type="date" name="fecha_devolucion" id="fecha_devolucion" />
                    </td>
                </tr>

                <tr>
                    <td>Tipo de Vehiculo</td>
                    <td>
                        <select name="tipo_vehiculo" id="tipo_vehiculo">
                            <option value="Autobus">Autobus</option>
                            <option value="Tractor">Tractor</option>
                        </select>
                    </td>
                </tr>

            </table>
            
            <input type="submit" id="btn_confirmar" value="Confirmar" />
        
        </form>
    </div>
</body>
</html>
