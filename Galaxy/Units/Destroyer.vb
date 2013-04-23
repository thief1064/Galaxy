Public Class Destroyer
    Inherits Unit

    Public Sub New()
        With Me
            .Name = "Zerstörer"
            .HullMax = 260
            .ShieldMax = 300
            .Hull = 260
            .Shield = 300
            .ShieldRegeneration = 10
            .FirePower = 65
            .FireRate = 20
            .Speed = 150
            .Alive = True
            .LoggingEnabled = True
        End With
    End Sub

End Class
