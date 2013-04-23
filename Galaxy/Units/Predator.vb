Public Class Predator
    Inherits Unit

    Public Sub New()
        With Me
            .Name = "Predator X850"
            .HullMax = 90
            .ShieldMax = 260
            .Hull = 90
            .Shield = 260
            .ShieldRegeneration = 10
            .FirePower = 240
            .FireRate = 10
            .Speed = 100
            .Alive = True
            .LoggingEnabled = True
        End With
    End Sub

End Class
