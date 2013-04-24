Imports Galaxy

Public Class Test

    Dim objSpieler As Player

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        objSpieler = New Player("Chris")
        Timer.Start()

        btnStart.Enabled = False
        btnCrystalMine.Enabled = True
        btnMetalMine.Enabled = True
        btnLutinumMine.Enabled = True
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
        lblMetal.Text = objSpieler.Ressources.Metal.Amount
        lblLutinum.Text = objSpieler.Ressources.Lutinum.Amount
        lblCrystal.Text = objSpieler.Ressources.Crystal.Amount
        Application.DoEvents()
    End Sub

    Private Sub btnMetalMine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMetalMine.Click
        objSpieler.BuildMine(Player.MineType.MetalMine)
        lblMetalMineLevel.Text = objSpieler.MetalMine.Level

        btnMetalMine.Enabled = False
        btnUpgradeMetalMine.Enabled = True
    End Sub

    Private Sub btnUpgradeMine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpgradeMetalMine.Click
        objSpieler.UpgradeMine(Player.MineType.MetalMine)
        lblMetalMineLevel.Text = objSpieler.MetalMine.Level
    End Sub

    Private Sub btnCrystalMine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrystalMine.Click
        objSpieler.BuildMine(Player.MineType.CrystalMine)
        lblCrystalMineLevel.Text = objSpieler.CrystalMine.Level

        btnCrystalMine.Enabled = False
        btnUpgradeCrystalMine.Enabled = True
    End Sub

    Private Sub btnUpgradeCrystalMine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpgradeCrystalMine.Click
        objSpieler.UpgradeMine(Player.MineType.CrystalMine)
        lblCrystalMineLevel.Text = objSpieler.CrystalMine.Level
    End Sub

    Private Sub btnLutinumMine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLutinumMine.Click
        objSpieler.BuildMine(Player.MineType.LutinumMine)
        lblLutinumMineLevel.Text = objSpieler.LutinumMine.Level

        btnLutinumMine.Enabled = False
        btnUpgradeLutinumMine.Enabled = True
    End Sub

    Private Sub btnUpgradeLutinumMine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpgradeLutinumMine.Click
        objSpieler.UpgradeMine(Player.MineType.LutinumMine)
        lblLutinumMineLevel.Text = objSpieler.LutinumMine.Level
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnCrystalMine.Enabled = False
        btnUpgradeCrystalMine.Enabled = False
        btnMetalMine.Enabled = False
        btnUpgradeMetalMine.Enabled = False
        btnLutinumMine.Enabled = False
        btnUpgradeLutinumMine.Enabled = False
    End Sub
End Class
