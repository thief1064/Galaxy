Imports System.Windows.Forms


Public Class Player

    ' Timer zum steuern des Ressourcenabbaus
    Private WithEvents objTimer As New Timer()

#Region "Konstruktor"

    Public Sub New()
        Me.Ressources = New Ressources
        objTimer.Interval = 1000
        objTimer.Start()
    End Sub

    Public Sub New(ByVal pName As String)
        Me.Name = pName
        Me.Ressources = New Ressources
        objTimer.Interval = 1000
        objTimer.Start()
    End Sub

#End Region

#Region "Properties"

    Private _MetalMine As MetalMine
    Public Property MetalMine() As MetalMine
        Get
            Return _MetalMine
        End Get
        Set(ByVal value As MetalMine)
            _MetalMine = value
        End Set
    End Property


    Private _CrystalMine As CrystalMine
    Public Property CrystalMine() As CrystalMine
        Get
            Return _CrystalMine
        End Get
        Set(ByVal value As CrystalMine)
            _CrystalMine = value
        End Set
    End Property

    Private _LutinumMine As LutinumMine
    Public Property LutinumMine() As LutinumMine
        Get
            Return _LutinumMine
        End Get
        Set(ByVal value As LutinumMine)
            _LutinumMine = value
        End Set
    End Property

    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Private _Ressources As Ressources
    Public Property Ressources() As Ressources
        Get
            Return _Ressources
        End Get
        Set(ByVal value As Ressources)
            _Ressources = value
        End Set
    End Property

    Enum MineType
        MetalMine
        CrystalMine
        LutinumMine
    End Enum

#End Region

#Region "Methoden"

    Sub BuildMine(ByVal pMineType As MineType)
        Select Case pMineType
            Case MineType.MetalMine
                Me.MetalMine = New MetalMine
                Me.Ressources.Metal.MiningSpeed = (Me.MetalMine.Level * 10)
            Case MineType.CrystalMine
                Me.CrystalMine = New CrystalMine(Me.Ressources)
                Me.Ressources.Crystal.MiningSpeed = (Me.CrystalMine.Level * 7)
            Case MineType.LutinumMine
                Me.LutinumMine = New LutinumMine
                Me.Ressources.Lutinum.MiningSpeed = (Me.LutinumMine.Level * 5)
        End Select
    End Sub

    Sub UpgradeMine(ByVal pMineType As MineType)
        Select Case pMineType
            Case MineType.MetalMine
                Me.MetalMine.Upgrade()
                Me.Ressources.Metal.MiningSpeed = (Me.MetalMine.Level * 10)
            Case MineType.CrystalMine
                Me.CrystalMine.Upgrade()
                Me.Ressources.Crystal.MiningSpeed = (Me.CrystalMine.Level * 7)
            Case MineType.LutinumMine
                Me.LutinumMine.Upgrade()
                Me.Ressources.Lutinum.MiningSpeed = (Me.LutinumMine.Level * 5)
        End Select
    End Sub

#End Region

#Region "Events"

    Private Sub objTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles objTimer.Tick
        Me.Ressources.Metal.Amount += Me.Ressources.Metal.MiningSpeed
        Me.Ressources.Crystal.Amount += Me.Ressources.Crystal.MiningSpeed
        Me.Ressources.Lutinum.Amount += Me.Ressources.Lutinum.MiningSpeed
    End Sub

#End Region

  

 
End Class
