Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class Creditos
    Private _urlPerfil As String = ""

    Private Async Sub Creditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await ObtenerDatosGithub("MarkelNC0908")
    End Sub

    Private Async Function ObtenerDatosGithub(usuario As String) As Task
        Dim urlApi As String = $"https://api.github.com/users/{usuario}"

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("User-Agent", "AppCine")

            Try
                Dim response As String = Await client.GetStringAsync(urlApi)
                Dim json As JObject = JObject.Parse(response)
                LBLNombreGitHub.Text = "Perfil: " & json("login").ToString()
                LBLRepoPublico.Text = "Repositorios Publicos: " & json("public_repos").ToString()
                _urlPerfil = json("html_url").ToString()
                pbGitHub.Load(json("avatar_url").ToString())

            Catch ex As Exception
                MessageBox.Show("Error al obtener datos de GitHub: " & ex.Message)
            End Try
        End Using
    End Function
    Private Sub pbGithub_Click(sender As Object, e As EventArgs) Handles pbGitHub.Click
        If Not String.IsNullOrEmpty(_urlPerfil) Then
            Process.Start(New ProcessStartInfo(_urlPerfil) With {.UseShellExecute = True})
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles BTNVolver.Click
        Me.Close()
    End Sub
End Class