Imports System.Data.SqlClient
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Principal
    Private cartelera As New List(Of Pelicula)
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosDesdeBD()
    End Sub

    Private Sub CargarDatosDesdeBD()
        Dim cadena As String = "Server=localhost; Database=CINE; Uid=root; Pwd=;"
        Using conexion As New MySqlConnection(cadena)
            Dim consulta As String = "SELECT * FROM PELICULA"
            Dim comando As New MySqlCommand(consulta, conexion)

            Try
                conexion.Open()
                Dim lector As MySqlDataReader = comando.ExecuteReader()
                cartelera.Clear()

                While lector.Read()
                    Dim p As New Pelicula With {
                        .Titulo = lector("Titulo").ToString(),
                        .Anio = Convert.ToInt32(lector("Anio")),
                        .Duracion = lector("Duracion").ToString(),
                        .Sinopsis = lector("Sinopsis").ToString(),
                        .Precio = Convert.ToDouble(lector("Precio")),
                        .ButacasDisponibles = Convert.ToInt32(lector("Cantidad_entradas_disponibles")),
                        .Sala = lector("Sala").ToString()
                    }
                    Try
                        Using tClient As New WebClient()
                            Dim imageData As Byte() = tClient.DownloadData(lector("URL_imagen").ToString())
                            Using ms As New IO.MemoryStream(imageData)
                                p.Poster = Image.FromStream(ms)
                            End Using
                        End Using
                    Catch ex As Exception
                    End Try
                    cartelera.Add(p)
                End While
                lector.Close()
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
            End Try
        End Using
        ActualizarInterfaz()
    End Sub


    Private Sub ActualizarInterfaz()
        Try
            If cartelera.Count >= 1 Then
                PictureBox1.Image = cartelera(0).Poster
                LBLTitulo1.Text = cartelera(0).Titulo.ToUpper()
                LBLSala1.Text = cartelera(0).Sala
            End If

            If cartelera.Count >= 2 Then
                PictureBox2.Image = cartelera(1).Poster
                LBLTitulo2.Text = cartelera(1).Titulo.ToUpper()
                LBLSala2.Text = cartelera(1).Sala
            End If

            If cartelera.Count >= 3 Then
                PictureBox3.Image = cartelera(2).Poster
                LBLTitulo3.Text = cartelera(2).Titulo.ToUpper()
                LBLSala3.Text = cartelera(2).Sala
            End If

            If cartelera.Count >= 4 Then
                PictureBox4.Image = cartelera(3).Poster
                LBLTitulo4.Text = cartelera(3).Titulo.ToUpper()
                LBLSala4.Text = cartelera(3).Sala
            End If

            If cartelera.Count >= 5 Then
                PictureBox5.Image = cartelera(4).Poster
                LBLTitulo5.Text = cartelera(4).Titulo.ToUpper()
                LBLSala5.Text = cartelera(4).Sala
            End If

        Catch ex As Exception
            Console.WriteLine("Error al asignar textos: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If cartelera.Count >= 1 Then
            MostrarDetalle(cartelera(0))
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If cartelera.Count >= 2 Then
            MostrarDetalle(cartelera(1))
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If cartelera.Count >= 3 Then
            MostrarDetalle(cartelera(2))
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If cartelera.Count >= 4 Then MostrarDetalle(cartelera(3))
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If cartelera.Count >= 5 Then MostrarDetalle(cartelera(4))
    End Sub
    Private Sub MostrarDetalle(peli As Pelicula)
        Dim ventanaInfo As New Informacion()
        ventanaInfo.CargarDatosPelicula(peli)
        ventanaInfo.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCreditos_Click(sender As Object, e As EventArgs) Handles BtnCreditos.Click
        Creditos.ShowDialog()
    End Sub

    Private Sub BTNSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Deseas salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If respuesta = DialogResult.Yes Then Application.Exit()
    End Sub
End Class