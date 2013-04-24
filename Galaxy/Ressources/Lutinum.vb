Public Class Lutinum

    Private _lngAmount As Long
    Public Property Amount() As Long
        Get
            Return _lngAmount
        End Get
        Set(ByVal value As Long)
            _lngAmount = value
        End Set
    End Property

    Private _lngDegradationRate As Integer = 0
    Public Property DegradationRate() As Integer
        Get
            Return _lngDegradationRate
        End Get
        Set(ByVal value As Integer)
            _lngDegradationRate = value
        End Set
    End Property

    Private Sub New(ByVal pAmount As Long)
        Me.Amount = pAmount
    End Sub

    Public Sub New()
    End Sub

End Class
