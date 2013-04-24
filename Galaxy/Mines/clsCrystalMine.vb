Public Class CrystalMine

    Public Sub New(ByVal pResources As Ressources)
        If Not pResources.Metal.Amount >= 500 AndAlso Not pResources.Lutinum.Amount >= 500 AndAlso pResources.Crystal.Amount >= 500 Then
            Throw New Exception("Es sind nicht genügend Ressources zur Verfügung um eine Kristallmine zu errichten!")
        Else
            pResources.Metal.Amount = pResources.Metal.Amount - 500
            pResources.Metal.Amount = pResources.Metal.Amount - 500
        End If
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
