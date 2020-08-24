Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim num1, num2, respuesta As Double

        num1 = txtnum1.Text
        num2 = txtnum2.Text

        If optSumar.Checked Then
            lblrespuesta.Text = num1 + num2
        End If

        If optRestar.Checked Then
            lblrespuesta.Text = num1 - num2
        End If

        If optMultiplicar.Checked Then
            lblrespuesta.Text = num1 * num2
        End If

        If optDividir.Checked Then
            lblrespuesta.Text = num1 / num2
        End If

        If optPorcentaje.Checked Then
            lblrespuesta.Text = num1 * num2 / 100
        End If

        If optExponenciacion.Checked Then
            lblrespuesta.Text = num1 ^ num2
        End If

        If optModulo.Checked Then
            lblrespuesta.Text = num1 Mod num2
        End If
    End Sub
End Class
