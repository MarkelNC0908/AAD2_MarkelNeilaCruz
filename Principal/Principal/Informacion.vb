Public Class Informacion

    Private PeliActual As Pelicula
    Public Sub CargarDatosPelicula(peli As Pelicula)
        PeliActual = peli
        lblTitulo.Text = peli.Titulo.ToUpper()
        lblAnio.Text = "Estreno: " & peli.Anio.ToString()
        lblDuracion.Text = "Duración: " & peli.Duracion
        lblSala.Text = "Proyección en: " & peli.Sala
        lblPrecio.Text = "Precio entrada: " & peli.Precio.ToString("C2")
        txtSinopsis.Text = peli.Sinopsis
        pbImagenGrande.Image = peli.Poster
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub BtnComprar_Click(sender As Object, e As EventArgs) Handles BtnComprar.Click
        Dim PantallaVenta As New VentaEntradas()
        PantallaVenta.PrepararVenta(PeliActual)
        PantallaVenta.ShowDialog()
    End Sub
End Class