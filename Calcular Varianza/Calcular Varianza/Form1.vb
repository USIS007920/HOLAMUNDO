Public Class Form1
    Dim objEstadistica As New estadistica

    Public Sub btnMediaAritmetica_Click(sender As Object, e As EventArgs) Handles btnMediaAritmetica.Click
        lblRespuestaMedia.Text = objEstadistica.calcularMedia(txtserie.Text.Split(","))
        lblRepuestaMedia.Text = objEstadistica.calcularVarianza(txtserie.Text.Split(","))
        lblRespuestaDesvTipica.Text = objEstadistica.calcularDesvTipica(txtserie.Text.Split(","))
    End Sub


End Class
