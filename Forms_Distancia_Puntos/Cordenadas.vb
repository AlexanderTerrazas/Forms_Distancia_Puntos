Public Class Cordenadas
    Private _xa As Double
    Private _ya As Double
    Private _xb As Double
    Private _yb As Double

    Public Property Xa As Double
        Get
            Return _xa
        End Get
        Set(value As Double)
            _xa = value
        End Set
    End Property

    Public Property Ya As Double
        Get
            Return _ya
        End Get
        Set(value As Double)
            _ya = value
        End Set
    End Property

    Public Property Xb As Double
        Get
            Return _xb
        End Get
        Set(value As Double)
            _xb = value
        End Set
    End Property

    Public Property Yb As Double
        Get
            Return _yb
        End Get
        Set(value As Double)
            _yb = value
        End Set
    End Property
End Class
