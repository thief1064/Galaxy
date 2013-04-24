Public Class Ressources

    Public Sub New()
        Me.Metal = New Metal
        Me.Crystal = New Crystal
        Me.Lutinum = New Lutinum
    End Sub

    Private _objMetal As Metal
    Public Property Metal() As Metal
        Get
            Return _objMetal
        End Get
        Set(ByVal value As Metal)
            _objMetal = value
        End Set
    End Property

    Private _objCrystal As Crystal
    Public Property Crystal() As Crystal
        Get
            Return _objCrystal
        End Get
        Set(ByVal value As Crystal)
            _objCrystal = value
        End Set
    End Property

    Private _objLutinum As Lutinum
    Public Property Lutinum() As Lutinum
        Get
            Return _objLutinum
        End Get
        Set(ByVal value As Lutinum)
            _objLutinum = value
        End Set
    End Property

End Class

