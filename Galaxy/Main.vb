﻿Imports Helper1064.Console

Module Main

    Sub Main()

        Dim objAttacker As New Destroyer
        Dim objDefender As New Battleship

        'objAttacker.SingleAttack(objDefender)
        'objAttacker.Fight(objDefender)

        Dim objGoodFleet As New Fleet("TRO")
        Dim objBadFleet As New Fleet("CKL")

        objGoodFleet.Label = "Kampfgeschwader TRO"
        objBadFleet.Label = "Terrorgruppe CKL nenn mich noch einmal CKL"

        For intI = 0 To 50 Step 1
            objGoodFleet.Ships.Add(New Destroyer)
            objGoodFleet.Ships.Add(New Cruiser)
            objBadFleet.Ships.Add(New Battleship)
        Next

        Console.ReadLine()

    End Sub

End Module
