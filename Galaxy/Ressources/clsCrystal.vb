Public Class Crystal
    Private _Amount As Long = 1000
    Public Property Amount() As Long
        Get
            Return _Amount
        End Get
        Set(ByVal value As Long)
            _Amount = value
        End Set
    End Property

    Private _MiningSpeed As Integer = 0
    Public Property MiningSpeed() As Integer
        Get
            Return _MiningSpeed
        End Get
        Set(ByVal value As Integer)
            _MiningSpeed = value
        End Set
    End Property

    Private Sub New(ByVal pAmount As Long)
        Me.Amount = pAmount
    End Sub

    Public Sub New()
    End Sub
End Class
