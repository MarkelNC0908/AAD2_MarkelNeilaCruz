Public Class Principal

    ' Película 1: Inception
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim peli As New Pelicula With {
            .Titulo = "INCEPTION",
            .Sala = "Sala 1",
            .Anio = 2010,
            .Duracion = "148 min",
            .Precio = 8.5,
            .Sinopsis = "Dom Cobb es un experto en el arte de extraer valiosos secretos del mundo de los sueños.",
            .Poster = PictureBox1.Image
        }
        MostrarDetalle(peli)
    End Sub

    ' Película 2: Dune
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim peli As New Pelicula With {
            .Titulo = "DUNE",
            .Sala = "Sala 2",
            .Anio = 2024,
            .Duracion = "166 min",
            .Precio = 9.0,
            .Sinopsis = "Paul Atreides viaja al planeta más peligroso del universo para asegurar el futuro de su familia.",
            .Poster = PictureBox2.Image
        }
        MostrarDetalle(peli)
    End Sub

    ' Película 3: La Forma del Agua
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim peli As New Pelicula With {
            .Titulo = "LA FORMA DEL AGUA",
            .Sala = "Sala 3",
            .Anio = 2017,
            .Duracion = "123 min",
            .Precio = 9.0,
            .Sinopsis = "En un laboratorio de alta seguridad, una limpiadora solitaria entabla una relación con una criatura anfibia.",
            .Poster = PictureBox3.Image
        }
        MostrarDetalle(peli)
    End Sub

    ' Película 4: Kill Bill (Corregido el Handle)
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim peli As New Pelicula With {
            .Titulo = "KILL BILL",
            .Sala = "Sala 4",
            .Anio = 2003,
            .Duracion = "111 min",
            .Precio = 9.0,
            .Sinopsis = "Tras despertar de un coma, una asesina profesional busca venganza contra su antiguo jefe.",
            .Poster = PictureBox4.Image
        }
        MostrarDetalle(peli)
    End Sub

    ' Película 5: Zootrópolis 2 (Corregido el Handle)
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim peli As New Pelicula With {
            .Titulo = "ZOOTRÓPOLIS 2",
            .Sala = "Sala 5",
            .Anio = 2025,
            .Duracion = "170 min",
            .Precio = 9.0,
            .Sinopsis = "Judy Hopps y Nick Wilde regresan en una nueva aventura por la metrópolis animal.",
            .Poster = PictureBox5.Image
        }
        MostrarDetalle(peli)
    End Sub

    ' Película 6: Frankenweenie (Corregido el Handle)
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim peli As New Pelicula With {
            .Titulo = "FRANKENWEENIE",
            .Sala = "Sala 6",
            .Anio = 2012,
            .Duracion = "87 min",
            .Precio = 9.0,
            .Sinopsis = "Un niño realiza un experimento científico para traer de vuelta a la vida a su amado perro Sparky.",
            .Poster = PictureBox6.Image
        }
        MostrarDetalle(peli)
    End Sub

    ' Método para enviar los datos a la pantalla de Información
    Private Sub MostrarDetalle(peli As Pelicula)
        ' Creamos la instancia del formulario
        Dim ventanaInfo As New Informacion()

        ' Llamamos al método de carga que debe estar en la clase Informacion
        ventanaInfo.CargarDatosPelicula(peli)

        ' Mostramos la ventana y ocultamos la actual
        ventanaInfo.Show()
        Me.Hide()
    End Sub

    ' Botón Salir
    Private Sub BTNSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Deseas salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If respuesta = DialogResult.Yes Then
            MessageBox.Show("Gracias por usar la aplicación", "Adiós", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub
End Class