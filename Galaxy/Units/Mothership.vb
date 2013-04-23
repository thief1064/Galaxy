Public Class Mothership
    Inherits Unit

    Public Sub New()
        With Me
            .Name = "Mutterschiff"
            .HullMax = 50000
            .ShieldMax = 50000
            .Hull = 50000
            .Shield = 50000
            .ShieldRegeneration = 10
            .FirePower = 18000
            .FireRate = 1000
            .Speed = 50
            .Alive = True
            .LoggingEnabled = True
        End With
    End Sub
End Class
