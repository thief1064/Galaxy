Public Class Fighter
    Inherits Unit

    Public Sub New()
        With Me
            .Name = "Fighter X300"
            .HullMax = 40
            .ShieldMax = 100
            .Hull = 40
            .Shield = 100
            .ShieldRegeneration = 10
            .FirePower = 100
            .FireRate = 10
            .Speed = 100
            .Alive = True
            .LoggingEnabled = True
        End With
    End Sub

End Class
