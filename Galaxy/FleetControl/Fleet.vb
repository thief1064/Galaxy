Public Class Fleet

    Public Sub New(ByVal pOwner As String)
        Me.Owner = pOwner
    End Sub

    Private _strOwner As String
    Public Property Owner() As String
        Get
            Return _strOwner
        End Get
        Set(ByVal value As String)
            _strOwner = value
        End Set
    End Property

    Private _strLabel As String
    Public Property Label() As String
        Get
            Return _strLabel
        End Get
        Set(ByVal value As String)
            _strLabel = value
        End Set
    End Property

    Private _lstShips As New List(Of Unit)
    Public Property Ships() As List(Of Unit)
        Get
            Return _lstShips
        End Get
        Set(ByVal value As List(Of Unit))
            _lstShips = value
        End Set
    End Property

    Public Function GetNumberOfFighters() As Integer
        Dim intResult As Integer = 0

        For Each objCurrent As Unit In Me.Ships
            If objCurrent.GetType Is GetType(Fighter) Then
                intResult += 1
            End If
        Next

        Return intResult
    End Function

    Public Function GetNumberOfPredators() As Integer
        Dim intResult As Integer = 0

        For Each objCurrent As Unit In Me.Ships
            If objCurrent.GetType Is GetType(Predator) Then
                intResult += 1
            End If
        Next

        Return intResult
    End Function

    Public Function GetNumberOfDestoyers() As Integer
        Dim intResult As Integer = 0

        For Each objCurrent As Unit In Me.Ships
            If objCurrent.GetType Is GetType(Destroyer) Then
                intResult += 1
            End If
        Next

        Return intResult
    End Function

    Public Function GetNumberOfBattleships() As Integer
        Dim intResult As Integer = 0

        For Each objCurrent As Unit In Me.Ships
            If objCurrent.GetType Is GetType(Battleship) Then
                intResult += 1
            End If
        Next

        Return intResult
    End Function

    Public Function GetNumberOfCruisers() As Integer
        Dim intResult As Integer = 0

        For Each objCurrent As Unit In Me.Ships
            If objCurrent.GetType Is GetType(Cruiser) Then
                intResult += 1
            End If
        Next

        Return intResult
    End Function

    Public Function GetNumberOfMotherships() As Integer
        Dim intResult As Integer = 0

        For Each objCurrent As Unit In Me.Ships
            If objCurrent.GetType Is GetType(Mothership) Then
                intResult += 1
            End If
        Next

        Return intResult
    End Function

    Public Function GetNumberOfDrones() As Integer
        Dim intResult As Integer = 0

        For Each objCurrent As Unit In Me.Ships
            If objCurrent.GetType Is GetType(Drone) Then
                intResult += 1
            End If
        Next

        Return intResult
    End Function

    Public Function GetTotalNumberOfShips() As Integer
        Return Me.Ships.Count
    End Function

    Public Function GetNumberOfDestroyedShips() As Integer
        Dim intResult As Integer = 0

        For Each objCurrent As Unit In Me.Ships
            If Not objCurrent.Alive Then
                intResult += 1
            End If
        Next

        Return intResult
    End Function

    Public Function GetNumberOfUndamagedShips() As Integer
        Dim intResult As Integer = 0

        For Each objCurrent As Unit In Me.Ships
            If objCurrent.Hull = objCurrent.HullMax Then
                intResult += 1
            End If
        Next

        Return intResult
    End Function

    Public Sub RemoveDestroyedShips()
        For intI = 0 To Me.Ships.Count
            If Not Me.Ships.Item(intI).Alive Then
                Me.Ships.RemoveAt(intI)
            End If
        Next
    End Sub

    Public ReadOnly Property Hull() As Long
        Get
            Dim lngValue As Long = 0

            For Each objCurrent As Unit In Me.Ships
                lngValue += objCurrent.Hull
            Next

            Return lngValue
        End Get
    End Property

    Public ReadOnly Property HullMax() As Long
        Get
            Dim lngValue As Long = 0

            For Each objCurrent As Unit In Me.Ships
                lngValue += objCurrent.HullMax
            Next

            Return lngValue
        End Get
    End Property

    Public ReadOnly Property HullPercent() As Double
        Get
            Return Me.Hull / Me.HullMax * 100
        End Get
    End Property

    Public ReadOnly Property Shield() As Long
        Get
            Dim lngValue As Long = 0

            For Each objCurrent As Unit In Me.Ships
                lngValue += objCurrent.Shield
            Next

            Return lngValue
        End Get
    End Property

    Public ReadOnly Property ShieldMax() As Long
        Get
            Dim lngValue As Long = 0

            For Each objCurrent As Unit In Me.Ships
                lngValue += objCurrent.ShieldMax
            Next

            Return lngValue
        End Get
    End Property

    Public ReadOnly Property ShieldPercent() As Double
        Get
            Return Me.Shield / Me.ShieldMax * 100
        End Get
    End Property

    Public ReadOnly Property FirePower() As Long
        Get
            Dim lngValue As Long = 0

            For Each objCurrent As Unit In Me.Ships
                lngValue += objCurrent.FirePower
            Next

            Return lngValue
        End Get
    End Property

    Public ReadOnly Property FirePowerAverage() As Integer
        Get
            Return CInt(Me.FirePower / Me.GetTotalNumberOfShips)
        End Get
    End Property

    Public ReadOnly Property FireRate() As Long
        Get
            Dim lngValue As Long = 0

            For Each objCurrent As Unit In Me.Ships
                lngValue += objCurrent.FireRate
            Next

            Return lngValue
        End Get
    End Property

    Public ReadOnly Property FireRateAverage() As Integer
        Get
            Return CInt(Me.FireRate / Me.GetTotalNumberOfShips)
        End Get
    End Property


    Public Sub Fight(ByVal pTarget As Fleet)
        ' TODO:
        ' "Gleichmäßiges" Aufteilen des Schadens auf die gesamte Flotte des Gegners.
        ' Dabei wird der durchschnittliche Schaden pro Schiff berechnet und die Liste Schiff für 
        ' Schiff durchgegangen und der Schaden zugefügt
        ' Ggf. kann hier so etwas wie Angriffs- und Abwehrhaltung eingebaut werden, so dass stärkere Schiffe
        ' z.B. zuerst Angegriffen werden oder einen höheren Anteil am Schaden erhalten und umgekehrt.


    End Sub

End Class
