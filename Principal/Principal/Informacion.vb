Public Class Informacion
    ' Este método es el que llamamos desde el Form Principal
    Public Sub CargarDatosPelicula(peli As Pelicula)
        ' Asignamos los datos a los labels que has dibujado
        lblTitulo.Text = peli.Titulo.ToUpper()
        lblAnio.Text = "Estreno: " & peli.Anio.ToString()
        lblDuracion.Text = "Duración: " & peli.Duracion
        lblSala.Text = "Proyección en: " & peli.Sala

        ' Formato de moneda para el precio
        lblPrecio.Text = "Precio entrada: " & peli.Precio.ToString("C2")

        ' Texto de la sinopsis y la imagen
        txtSinopsis.Text = peli.Sinopsis
        pbImagenGrande.Image = peli.Poster
    End Sub

    ' Botón para volver (el azul de arriba a la derecha)
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Principal.Show() ' Regresamos a la cartelera
        Me.Close()      ' Cerramos esta ventana
    End Sub
End Class