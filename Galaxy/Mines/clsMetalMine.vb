Public Class MetalMine

    Public Sub New()
    End Sub

    Private _Level As Integer = 1
    Public Property Level() As Integer
        Get
            Return _Level
        End Get
        Set(ByVal value As Integer)
            _Level = value
        End Set
    End Property

    Sub Upgrade()
        Me.Level += 1
    End Sub

End Class
