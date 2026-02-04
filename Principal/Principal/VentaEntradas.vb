Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net
Public Class VentaEntradas
    Private _precioUnidad As Double
    Private peliActual As Pelicula
    Private cadenaConexion As String = "Server=localhost; Database=CINE; Uid=root; Pwd=;"

    Public Sub PrepararVenta(peli As Pelicula)
        peliActual = peli
        lblTituloSeleccionado.Text = peli.Titulo.ToUpper()
        lblDisponibles.Text = "Entradas restantes en sala: " & peli.ButacasDisponibles
        _precioUnidad = peli.Precio
        ActualizarTotal()
    End Sub

    Private Sub NumEntradas_ValueChanged(sender As Object, e As EventArgs) Handles NumEntradas.ValueChanged
        If NumEntradas.Value > 10 Then
            MessageBox.Show("No está permitido comprar más de 10 entradas por persona.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            NumEntradas.Value = 10
        End If

        ActualizarTotal()
    End Sub

    Private Sub ActualizarTotal()
        Dim total As Double = NumEntradas.Value * _precioUnidad
        lblNumEntradas.Text = "Total a pagar: " & total.ToString("C2")
    End Sub

    Private Sub GenerarInforme()
        Dim linea As String = $"{peliActual.Titulo} - {peliActual.Sala} - Total: {(NumEntradas.Value * _precioUnidad).ToString("C2")} - Cantidad: {NumEntradas.Value}"
        Try
            Using sw As New StreamWriter("peliculas.txt", True)
                sw.WriteLine(linea)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al escribir en el archivo: " & ex.Message)
        End Try
    End Sub
    Private Sub ActualizarAforoBD(cantidadVendida As Integer)
        Dim consulta As String = "UPDATE PELICULA SET Cantidad_entradas_disponibles = Cantidad_entradas_disponibles - @cant WHERE Titulo = @tit"

        Using conexion As New MySqlConnection(cadenaConexion)
            Dim comando As New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@cant", cantidadVendida)
            comando.Parameters.AddWithValue("@tit", peliActual.Titulo)

            Try
                conexion.Open()
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la base de datos: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub BtnComprar_Click(sender As Object, e As EventArgs) Handles BtnComprar.Click
        If NumEntradas.Value = 0 Then
            MessageBox.Show("Por favor, seleccione antes el número de entradas.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If NumEntradas.Value > peliActual.ButacasDisponibles Then
            MessageBox.Show("Lo sentimos, no hay suficiente espacio. Solo quedan " & peliActual.ButacasDisponibles & " entradas disponibles.", "Aforo insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            peliActual.ButacasDisponibles -= NumEntradas.Value
            ActualizarAforoBD(NumEntradas.Value)
            GenerarInforme()
            MessageBox.Show("¡Compra realizada con éxito!" & vbCrLf &
                            "Película: " & peliActual.Titulo & vbCrLf &
                            "Total: " & (NumEntradas.Value * _precioUnidad).ToString("C2"),
                            "Venta Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Principal.Show()

        End If
    End Sub

    Private Sub BTNSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        Me.Close()
    End Sub
End Class