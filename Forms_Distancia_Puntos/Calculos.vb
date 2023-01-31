Public Class Calculos
    Inherits Cordenadas
    Public Function Distancia() As Double
        Dim resultado As Double
        resultado = ((Math.Pow(Xb - Xa, 2)) + (Math.Pow(Yb - Ya, 2)))
        resultado = (Math.Sqrt(resultado))
        Return resultado
    End Function
End Class
