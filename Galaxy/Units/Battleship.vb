Public Class Battleship
    Inherits Unit

    Public Sub New()
        With Me
            .Name = "Schlachtschiff1"
            .HullMax = 600
            .ShieldMax = 900
            .Hull = 600
            .Shield = 900
            .ShieldRegeneration = 10
            .FirePower = 176
            .FireRate = 40
            .Speed = 100
            .Alive = True
            .LoggingEnabled = True
        End With
    End Sub

End Class
