Public Class Cruiser
    Inherits Unit

    Public Sub New()
        With Me
            .Name = "Imperialkreuzer"
            .HullMax = 1100
            .ShieldMax = 1500
            .Hull = 1100
            .Shield = 1500
            .ShieldRegeneration = 10
            .FirePower = 372
            .FireRate = 60
            .Speed = 80
            .Alive = True
            .LoggingEnabled = True
        End With
    End Sub

End Class
