Public MustInherit Class Unit

#Region "Interne Deklarationen"

    ' Für die Berechnung von Zufallszahlen
    Private objRandom As New Random

#End Region

#Region "Öffentliche Eigenschaften"

    Private _intHull As Integer
    Public Property Hull() As Integer
        Get
            Return _intHull
        End Get
        Set(ByVal value As Integer)
            If value > Me.HullMax Then
                value = Me.HullMax
            End If

            If value <= 0 Then
                value = 0
                Me.Alive = False
            End If

            If value > 0 Then
                Me.Alive = True
            End If

            _intHull = value
        End Set
    End Property

    Private _intHullMax As Integer
    Public Property HullMax() As Integer
        Get
            Return _intHullMax
        End Get
        Set(ByVal value As Integer)
            _intHullMax = value

            If Me.Hull > value Then
                Me.Hull = value
            End If
        End Set
    End Property

    Private _intShield As Integer
    Public Property Shield() As Integer
        Get
            Return _intShield
        End Get
        Set(ByVal value As Integer)
            If value > Me.ShieldMax Then
                value = Me.ShieldMax
            End If
            _intShield = value
        End Set
    End Property

    Private _intShieldMax As Integer
    Public Property ShieldMax() As Integer
        Get
            Return _intShieldMax
        End Get
        Set(ByVal value As Integer)
            _intShieldMax = value

            If Me.Shield > value Then
                Me.Shield = value
            End If
        End Set
    End Property

    Private _intShieldRegeneration As Integer
    Public Property ShieldRegeneration() As Integer
        Get
            Return _intShieldRegeneration
        End Get
        Set(ByVal value As Integer)
            _intShieldRegeneration = value
        End Set
    End Property

    Private _intFirePower As Integer
    Public Property FirePower() As Integer
        Get
            Return _intFirePower
        End Get
        Set(ByVal value As Integer)
            _intFirePower = value
        End Set
    End Property

    Private _intFireRate As Integer
    Public Property FireRate() As Integer
        Get
            Return _intFireRate
        End Get
        Set(ByVal value As Integer)
            _intFireRate = value
        End Set
    End Property

    Private _intSpeed As Integer
    Public Property Speed() As Integer
        Get
            Return _intSpeed
        End Get
        Set(ByVal value As Integer)
            _intSpeed = value
        End Set
    End Property

    Private _strName As String
    Public Property Name() As String
        Get
            Return _strName
        End Get
        Set(ByVal value As String)
            _strName = value
        End Set
    End Property

    Private _bolAlive As Boolean = True
    Public Property Alive() As Boolean
        Get
            Return _bolAlive
        End Get
        Set(ByVal value As Boolean)
            If Me.Alive Then
                If value = False Then
                    Log(String.Format("{0} ist geschlagen.", Me.Name))
                End If
            End If
            _bolAlive = value
        End Set
    End Property

    Private _bolLoggingEnabled As Boolean = False
    Public Property LoggingEnabled() As Boolean
        Get
            Return _bolLoggingEnabled
        End Get
        Set(ByVal value As Boolean)
            _bolLoggingEnabled = value
        End Set
    End Property

#End Region

#Region "Öffentliche Methoden"

    Public Sub Fight(ByVal pTarget As Unit)
        Dim intRound As Integer = 0

        Log(String.Format("{0} greift {1} bis zum bitteren Ende an.", Me.Name, pTarget.Name))

        ' Kampf bis zum bitteren Ende durchführen
        Do
            Log(String.Format("Runde {0}", intRound))
            ' Rundenzähler
            intRound += 1

            ' Einzelnen Anriff durchführen (Gegenangriff folgt direkt)
            Call SingleAttack(pTarget)
        Loop While Me.Alive And pTarget.Alive

        If Me.Alive Then
            Log(String.Format("{0} hat die Schlacht gewonnen.", Me.Name))
        Else
            Log(String.Format("{0} hat die Schlacht verloren.", Me.Name))
        End If
    End Sub

    Public Sub SingleAttack(ByRef pTarget As Unit)
        If Not pTarget.Alive Then Throw New Exception("Ziel ist bereits besiegt.")

        ' Scchalter für die Angriffsreihenfolge (Erster Angriff)
        Dim bolFirstStrike As Boolean
        Dim intNumberOfStrikes As Integer
        Dim objAttacker As Unit = Nothing
        Dim objDefender As Unit = Nothing

        ' Angriffsreihenfolge berechnen
        If pTarget.FireRate > Me.FireRate Then
            ' Gegner ist schneller
            bolFirstStrike = False
        ElseIf pTarget.FireRate = Me.FireRate Then
            ' Gleich schnell
            ' Zufall entscheiden lassen
            If objRandom.Next(0, 1) = 0 Then
                bolFirstStrike = True
            Else
                bolFirstStrike = False
            End If
        Else
            ' Gegner ist langsamer
            bolFirstStrike = True
        End If

        Log(String.Format("{0} eröffnet zuerst das Feuer auf {1}.", Me.Name, pTarget.Name))

        ' Anzahl Angriffe berechnen
        If pTarget.FireRate >= (Me.FireRate * 2) Then
            ' Der Gegner ist deutlich schneller
            ' Faktor berechnen
            Dim dblFactor As Double = pTarget.FireRate / Me.FireRate

            ' Zahlenwert auf ganze Anngriffe abrunden
            intNumberOfStrikes = CInt(Int(dblFactor))
        ElseIf Me.FireRate >= (pTarget.FireRate * 2) Then
            ' Der Gegner ist deutlich langsamer
            ' Faktor berechnen
            Dim dblFactor As Double = Me.FireRate / pTarget.FireRate

            ' Zahlenwert auf ganze Anngriffe abrunden
            intNumberOfStrikes = CInt(Int(dblFactor))
        Else
            ' Ungefähr gleiche schnell
            intNumberOfStrikes = 1
        End If

        If bolFirstStrike Then
            objAttacker = Me
            objDefender = pTarget
        Else
            objAttacker = pTarget
            objDefender = Me
        End If

        ' Angriffe des Angreifers durchführen
        For intI As Integer = 1 To intNumberOfStrikes Step 1
            Call CalcDamage(objAttacker, objDefender)
        Next

        ' Sofern der Verteidiger den Angriff überstanden hat, folgt ein Gegenschlag
        If objDefender.Alive Then
            ' Gegenschlag des Verteidigers durchführen
            ' -> immer nur 1 Gegenangriff, da die Anzahl der Angriffe  des Angreifers je nach
            '    Muliplikator der Feuerrate beider Kontrahenten abhängt

            ' Angreifer und Verteidiger bei der Berechnung des Schadens vertauschen
            Call CalcDamage(objDefender, objAttacker)
        End If

        ' Schilde regenerieren lassen
        Call Me.RegenerateShields()
        Call pTarget.RegenerateShields()
    End Sub

    Public Sub RegenerateShields()
        ' Schutzschilde werden regeneriert, sofern noch nicht besiegt...
        If Me.Alive Then
            ' ...und eine Regeneration dieser überhaupt nötig ist
            If Me.Shield < Me.ShieldMax Then
                Me.Shield += Me.ShieldRegeneration
                Log(String.Format("Der Schutzschild von {0} regeneriert sich auf {1}%.", Me.Name, CInt((Me.Shield / Me.ShieldMax) * 100)))
            End If
        End If
    End Sub

#End Region

#Region "Private Methoden / Helfer"

    Private Sub CalcDamage(ByRef pAttacker As Unit, ByRef pDefender As Unit)
        Dim intDamage As Integer = pAttacker.FirePower

        Log(String.Format("{0} feuert mit einer Stärke von {1} auf {2}.", pAttacker.Name, intDamage, pDefender.Name))

        If pDefender.Shield >= intDamage Then
            ' Schutzschild absorbiert den Schaden
            pDefender.Shield -= intDamage

            Log(String.Format("Der Schild von {0} absorbiert den Schaden vollständig.", pDefender.Name))
        Else
            ' Schutzschild absorbiert den Schaden gar nicht oder nur unvollständig
            Dim intDifference As Integer = intDamage - pDefender.Shield

            Log(String.Format("Der Schild von {0} absorbiert einen Teil des Schadens und erleidet {1} Schaden.", pDefender.Name, intDifference))

            ' Schild wird durchdrungen und der Restschaden weitergeleitet
            pDefender.Shield = 0
            pDefender.Hull -= intDifference
        End If
    End Sub

    Private Sub Log(ByVal pText As String, Optional ByVal pColor As ConsoleColor = ConsoleColor.White)
        If Me.LoggingEnabled Then
            Helper1064.Console.WriteLine(pText, pColor)
        End If
    End Sub

#End Region

End Class
