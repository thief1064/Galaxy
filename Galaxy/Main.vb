Imports Helper1064.Console

Module Main

    Sub Main()

        Dim objAttacker As New Destroyer
        Dim objDefender As New Battleship

        'objAttacker.SingleAttack(objDefender)
        'objAttacker.Fight(objDefender)

        Dim objGoodFleet As New Fleet("TRO")
        Dim objBadFleet As New Fleet("CKL")


        objGoodFleet.Label = "Kampfgeschwader TRO"
        objBadFleet.Label = "Terrorgruppe CKL"

        For intI = 0 To 30 Step 1
            objGoodFleet.Ships.Add(New Destroyer)
            objBadFleet.Ships.Add(New Battleship)
        Next

        Console.ReadLine()

    End Sub

End Module
