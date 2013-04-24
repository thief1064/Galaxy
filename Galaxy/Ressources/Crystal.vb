Public Class Crystal

    Private _lngAmount As Long
    Public Property Amount() As Long
        Get
            Return _lngAmount
        End Get
        Set(ByVal value As Long)
            _lngAmount = value
        End Set
    End Property

    Private _intDegradationRate As Integer = 0
    Public Property DegradationRate() As Integer
        Get
            Return _intDegradationRate
        End Get
        Set(ByVal value As Integer)
            _intDegradationRate = value
        End Set
    End Property

    Private Sub New(ByVal pAmount As Long)
        Me.Amount = pAmount
    End Sub

    Public Sub New()
    End Sub

End Class
