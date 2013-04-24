<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblMetal = New System.Windows.Forms.Label()
        Me.lblLutinum = New System.Windows.Forms.Label()
        Me.lblCrystal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnMetalMine = New System.Windows.Forms.Button()
        Me.btnUpgradeMetalMine = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMetalMineLevel = New System.Windows.Forms.Label()
        Me.btnCrystalMine = New System.Windows.Forms.Button()
        Me.btnUpgradeCrystalMine = New System.Windows.Forms.Button()
        Me.btnLutinumMine = New System.Windows.Forms.Button()
        Me.btnUpgradeLutinumMine = New System.Windows.Forms.Button()
        Me.lblCrystalMineLevel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLutinumMineLevel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Timer
        '
        '
        'lblMetal
        '
        Me.lblMetal.AutoSize = True
        Me.lblMetal.Location = New System.Drawing.Point(72, 130)
        Me.lblMetal.Name = "lblMetal"
        Me.lblMetal.Size = New System.Drawing.Size(39, 13)
        Me.lblMetal.TabIndex = 1
        Me.lblMetal.Text = "Label1"
        '
        'lblLutinum
        '
        Me.lblLutinum.AutoSize = True
        Me.lblLutinum.Location = New System.Drawing.Point(72, 162)
        Me.lblLutinum.Name = "lblLutinum"
        Me.lblLutinum.Size = New System.Drawing.Size(39, 13)
        Me.lblLutinum.TabIndex = 2
        Me.lblLutinum.Text = "Label2"
        '
        'lblCrystal
        '
        Me.lblCrystal.AutoSize = True
        Me.lblCrystal.Location = New System.Drawing.Point(72, 196)
        Me.lblCrystal.Name = "lblCrystal"
        Me.lblCrystal.Size = New System.Drawing.Size(39, 13)
        Me.lblCrystal.TabIndex = 3
        Me.lblCrystal.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Metall"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Lutinum"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Kristall"
        '
        'btnMetalMine
        '
        Me.btnMetalMine.Location = New System.Drawing.Point(138, 40)
        Me.btnMetalMine.Name = "btnMetalMine"
        Me.btnMetalMine.Size = New System.Drawing.Size(134, 23)
        Me.btnMetalMine.TabIndex = 7
        Me.btnMetalMine.Text = "Metallmine errichten"
        Me.btnMetalMine.UseVisualStyleBackColor = True
        '
        'btnUpgradeMetalMine
        '
        Me.btnUpgradeMetalMine.Location = New System.Drawing.Point(138, 86)
        Me.btnUpgradeMetalMine.Name = "btnUpgradeMetalMine"
        Me.btnUpgradeMetalMine.Size = New System.Drawing.Size(134, 23)
        Me.btnUpgradeMetalMine.TabIndex = 8
        Me.btnUpgradeMetalMine.Text = "Metallmine ausbauen"
        Me.btnUpgradeMetalMine.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(135, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Level der Metallmine:"
        '
        'lblMetalMineLevel
        '
        Me.lblMetalMineLevel.AutoSize = True
        Me.lblMetalMineLevel.Location = New System.Drawing.Point(248, 66)
        Me.lblMetalMineLevel.Name = "lblMetalMineLevel"
        Me.lblMetalMineLevel.Size = New System.Drawing.Size(0, 13)
        Me.lblMetalMineLevel.TabIndex = 10
        '
        'btnCrystalMine
        '
        Me.btnCrystalMine.Location = New System.Drawing.Point(299, 40)
        Me.btnCrystalMine.Name = "btnCrystalMine"
        Me.btnCrystalMine.Size = New System.Drawing.Size(134, 23)
        Me.btnCrystalMine.TabIndex = 11
        Me.btnCrystalMine.Text = "Kirstallmine errichten"
        Me.btnCrystalMine.UseVisualStyleBackColor = True
        '
        'btnUpgradeCrystalMine
        '
        Me.btnUpgradeCrystalMine.Location = New System.Drawing.Point(299, 86)
        Me.btnUpgradeCrystalMine.Name = "btnUpgradeCrystalMine"
        Me.btnUpgradeCrystalMine.Size = New System.Drawing.Size(134, 23)
        Me.btnUpgradeCrystalMine.TabIndex = 12
        Me.btnUpgradeCrystalMine.Text = "Kirstallmine ausbauen"
        Me.btnUpgradeCrystalMine.UseVisualStyleBackColor = True
        '
        'btnLutinumMine
        '
        Me.btnLutinumMine.Location = New System.Drawing.Point(457, 40)
        Me.btnLutinumMine.Name = "btnLutinumMine"
        Me.btnLutinumMine.Size = New System.Drawing.Size(134, 23)
        Me.btnLutinumMine.TabIndex = 13
        Me.btnLutinumMine.Text = "Lutinummine errichten"
        Me.btnLutinumMine.UseVisualStyleBackColor = True
        '
        'btnUpgradeLutinumMine
        '
        Me.btnUpgradeLutinumMine.Location = New System.Drawing.Point(457, 86)
        Me.btnUpgradeLutinumMine.Name = "btnUpgradeLutinumMine"
        Me.btnUpgradeLutinumMine.Size = New System.Drawing.Size(134, 23)
        Me.btnUpgradeLutinumMine.TabIndex = 14
        Me.btnUpgradeLutinumMine.Text = "Lutinummine ausbauen"
        Me.btnUpgradeLutinumMine.UseVisualStyleBackColor = True
        '
        'lblCrystalMineLevel
        '
        Me.lblCrystalMineLevel.AutoSize = True
        Me.lblCrystalMineLevel.Location = New System.Drawing.Point(412, 70)
        Me.lblCrystalMineLevel.Name = "lblCrystalMineLevel"
        Me.lblCrystalMineLevel.Size = New System.Drawing.Size(0, 13)
        Me.lblCrystalMineLevel.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Level der Kristallmine:"
        '
        'lblLutinumMineLevel
        '
        Me.lblLutinumMineLevel.AutoSize = True
        Me.lblLutinumMineLevel.Location = New System.Drawing.Point(572, 70)
        Me.lblLutinumMineLevel.Name = "lblLutinumMineLevel"
        Me.lblLutinumMineLevel.Size = New System.Drawing.Size(0, 13)
        Me.lblLutinumMineLevel.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(454, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Level der Lutinummine:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 234)
        Me.Controls.Add(Me.lblLutinumMineLevel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCrystalMineLevel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUpgradeLutinumMine)
        Me.Controls.Add(Me.btnLutinumMine)
        Me.Controls.Add(Me.btnUpgradeCrystalMine)
        Me.Controls.Add(Me.btnCrystalMine)
        Me.Controls.Add(Me.lblMetalMineLevel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnUpgradeMetalMine)
        Me.Controls.Add(Me.btnMetalMine)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCrystal)
        Me.Controls.Add(Me.lblLutinum)
        Me.Controls.Add(Me.lblMetal)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents lblMetal As System.Windows.Forms.Label
    Friend WithEvents lblLutinum As System.Windows.Forms.Label
    Friend WithEvents lblCrystal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnMetalMine As System.Windows.Forms.Button
    Friend WithEvents btnUpgradeMetalMine As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMetalMineLevel As System.Windows.Forms.Label
    Friend WithEvents btnCrystalMine As System.Windows.Forms.Button
    Friend WithEvents btnUpgradeCrystalMine As System.Windows.Forms.Button
    Friend WithEvents btnLutinumMine As System.Windows.Forms.Button
    Friend WithEvents btnUpgradeLutinumMine As System.Windows.Forms.Button
    Friend WithEvents lblCrystalMineLevel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLutinumMineLevel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
