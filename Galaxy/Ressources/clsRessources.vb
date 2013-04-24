Public Class Ressources

    Public Sub New()
        Me.Metal = New Metal
        Me.Crystal = New Crystal
        Me.Lutinum = New Lutinum
    End Sub

    Private _Metal As Metal
    Public Property Metal() As Metal
        Get
            Return _Metal
        End Get
        Set(ByVal value As Metal)
            _Metal = value
        End Set
    End Property

    Private _Crystal As Crystal
    Public Property Crystal() As Crystal
        Get
            Return _Crystal
        End Get
        Set(ByVal value As Crystal)
            _Crystal = value
        End Set
    End Property

    Private _Lutinum As Lutinum
    Public Property Lutinum() As Lutinum
        Get
            Return _Lutinum
        End Get
        Set(ByVal value As Lutinum)
            _Lutinum = value
        End Set
    End Property

End Class

