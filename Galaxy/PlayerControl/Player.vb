Imports System.Windows.Forms

Public Class Player

    ' Timer zum Steuern des Ressourcenabbaus
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

#Region "Eigenschaften"

    Enum MineType
        MetalMine
        CrystalMine
        LutinumMine
        test123
    End Enum

    Private _objMetalMine As MetalMine
    Public Property MetalMine() As MetalMine
        Get
            Return _objMetalMine
        End Get
        Set(ByVal value As MetalMine)
            _objMetalMine = value
        End Set
    End Property

    Private _objCrystalMine As CrystalMine
    Public Property CrystalMine() As CrystalMine
        Get
            Return _objCrystalMine
        End Get
        Set(ByVal value As CrystalMine)
            _objCrystalMine = value
        End Set
    End Property

    Private _objLutinumMine As LutinumMine
    Public Property LutinumMine() As LutinumMine
        Get
            Return _objLutinumMine
        End Get
        Set(ByVal value As LutinumMine)
            _objLutinumMine = value
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

    Private _objRessources As Ressources
    Public Property Ressources() As Ressources
        Get
            Return _objRessources
        End Get
        Set(ByVal value As Ressources)
            _objRessources = value
        End Set
    End Property

#End Region

#Region "Methoden"

    Public Sub BuildMine(ByVal pMineType As MineType)
        Select Case pMineType
            Case MineType.MetalMine
                Me.MetalMine = New MetalMine
                Me.Ressources.Metal.DegradationRate = (Me.MetalMine.Level * 10)
            Case MineType.CrystalMine
                Me.CrystalMine = New CrystalMine(Me.Ressources)
                Me.Ressources.Crystal.DegradationRate = (Me.CrystalMine.Level * 7)
            Case MineType.LutinumMine
                Me.LutinumMine = New LutinumMine
                Me.Ressources.Lutinum.DegradationRate = (Me.LutinumMine.Level * 5)
        End Select
    End Sub

    Public Sub UpgradeMine(ByVal pMineType As MineType)
        Select Case pMineType
            Case MineType.MetalMine
                Me.MetalMine.Upgrade()
                Me.Ressources.Metal.DegradationRate = (Me.MetalMine.Level * 10)
            Case MineType.CrystalMine
                Me.CrystalMine.Upgrade()
                Me.Ressources.Crystal.DegradationRate = (Me.CrystalMine.Level * 7)
            Case MineType.LutinumMine
                Me.LutinumMine.Upgrade()
                Me.Ressources.Lutinum.DegradationRate = (Me.LutinumMine.Level * 5)
        End Select
    End Sub

#End Region

#Region "Events"

    Private Sub objTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles objTimer.Tick
        Me.Ressources.Metal.Amount += Me.Ressources.Metal.DegradationRate
        Me.Ressources.Crystal.Amount += Me.Ressources.Crystal.DegradationRate
        Me.Ressources.Lutinum.Amount += Me.Ressources.Lutinum.DegradationRate
    End Sub

#End Region

End Class
