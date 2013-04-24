Public Class LutinumMine

    Public Sub New()
    End Sub

    Private _intLevel As Integer = 1
    Public Property Level() As Integer
        Get
            Return _intLevel
        End Get
        Set(ByVal value As Integer)
            _intLevel = value
        End Set
    End Property

    Sub Upgrade()
        Me.Level += 1
    End Sub

End Class
