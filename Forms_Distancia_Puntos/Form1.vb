Public Class Form1
    Private Sub Btn_Calcular_Click(sender As Object, e As EventArgs) Handles Btn_Calcular.Click
        Dim cordenadas As New Calculos()
        cordenadas.Xa = Txt_XA.Text
        cordenadas.Ya = Txt_YA.Text
        cordenadas.Xb = Txt_XB.Text
        cordenadas.Yb = Txt_YB.Text

        Txt_Resultado.Text = cordenadas.Distancia()
    End Sub
End Class
