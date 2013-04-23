Public Class Drone
    Inherits Unit

    Public Sub New()
        With Me
            .Name = "Terrordrohne"
            .HullMax = 18
            .ShieldMax = 0
            .Hull = 18
            .Shield = 0
            .ShieldRegeneration = 10
            .FirePower = 180
            .FireRate = 10
            .Speed = 180
            .Alive = True
            .LoggingEnabled = True
        End With
    End Sub

End Class
