<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmartHomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SmartHomeForm))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dishLbl = New System.Windows.Forms.Label()
        Me.EmergencyLbl = New System.Windows.Forms.Label()
        Me.hallLightLbl = New System.Windows.Forms.Label()
        Me.bathLightLbl = New System.Windows.Forms.Label()
        Me.hallCamLbl = New System.Windows.Forms.Label()
        Me.bedAlarmLbl = New System.Windows.Forms.Label()
        Me.bedlight2Lbl = New System.Windows.Forms.Label()
        Me.bedlight1Lbl = New System.Windows.Forms.Label()
        Me.alarmSofaLbl = New System.Windows.Forms.Label()
        Me.outLightLbl = New System.Windows.Forms.Label()
        Me.sofaCamLbl = New System.Windows.Forms.Label()
        Me.sofaLightLbl = New System.Windows.Forms.Label()
        Me.kitchenLightLbl = New System.Windows.Forms.Label()
        Me.diningLightLbl = New System.Windows.Forms.Label()
        Me.balconyLockLbl = New System.Windows.Forms.Label()
        Me.fridgeLbl = New System.Windows.Forms.Label()
        Me.OvenLbl = New System.Windows.Forms.Label()
        Me.tvLbl = New System.Windows.Forms.Label()
        Me.washLbl = New System.Windows.Forms.Label()
        Me.frontLockLbl = New System.Windows.Forms.Label()
        Me.airKitchenLbl = New System.Windows.Forms.Label()
        Me.Emergency = New System.Windows.Forms.Button()
        Me.PopUpWindowPanel = New System.Windows.Forms.Panel()
        Me.EmergencyReverse = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ReverseAlarmBtn = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.favConfWindow = New System.Windows.Forms.Panel()
        Me.favConfOKbtn = New System.Windows.Forms.Button()
        Me.favoriteconflbl = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.addFavoriteWindow = New System.Windows.Forms.Panel()
        Me.cancelAddFavBtn = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.FavNameTextbox = New System.Windows.Forms.TextBox()
        Me.saveFavBtn = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.EmergencyConfirmationWindow = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.EmergencyWindow = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.emergencyWindowTitle = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.settingsWindow = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.settingsCancelBtn = New System.Windows.Forms.Button()
        Me.settingsSaveBtn = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.fridgeWindow = New System.Windows.Forms.Panel()
        Me.freezerCombobox = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.fridgeOffBtn = New System.Windows.Forms.Button()
        Me.fridgeCancelBtn = New System.Windows.Forms.Button()
        Me.fridgeSaveBtn = New System.Windows.Forms.Button()
        Me.fridgeCombobox = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.SmokeAlarmWindow = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.AlarmWindow = New System.Windows.Forms.Panel()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.ovenWindow = New System.Windows.Forms.Panel()
        Me.ovenOffBtn = New System.Windows.Forms.Button()
        Me.ovenCancelBtn = New System.Windows.Forms.Button()
        Me.ovenSaveBtn = New System.Windows.Forms.Button()
        Me.ovenCombobox = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.washWindow = New System.Windows.Forms.Panel()
        Me.washOffBtn = New System.Windows.Forms.Button()
        Me.washCancelBtn = New System.Windows.Forms.Button()
        Me.WashSaveBtn = New System.Windows.Forms.Button()
        Me.washTimeLbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.washCombobox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dishWindow = New System.Windows.Forms.Panel()
        Me.dishOffBtn = New System.Windows.Forms.Button()
        Me.dishCancelBtn = New System.Windows.Forms.Button()
        Me.dishSaveBtn = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dishCombobox = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.airWindow = New System.Windows.Forms.Panel()
        Me.airOffBtn = New System.Windows.Forms.Button()
        Me.airCancelBtn = New System.Windows.Forms.Button()
        Me.airSaveBtn = New System.Windows.Forms.Button()
        Me.temperatureCombobox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tvWindow = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tvCancelBtn = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tvOffBtn = New System.Windows.Forms.Button()
        Me.tvSaveBtn = New System.Windows.Forms.Button()
        Me.TVComboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.volumeBar = New System.Windows.Forms.TrackBar()
        Me.lightBath = New System.Windows.Forms.PictureBox()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.Settings = New System.Windows.Forms.PictureBox()
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.FavoriteIcon = New System.Windows.Forms.PictureBox()
        Me.favoritesLbl = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.lightSofa = New System.Windows.Forms.PictureBox()
        Me.camSofa = New System.Windows.Forms.PictureBox()
        Me.balconyLock = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.homePanel = New System.Windows.Forms.Panel()
        Me.homeLbl = New System.Windows.Forms.Label()
        Me.homePic = New System.Windows.Forms.PictureBox()
        Me.awayPanel = New System.Windows.Forms.Panel()
        Me.awayLbl = New System.Windows.Forms.Label()
        Me.awayPic = New System.Windows.Forms.PictureBox()
        Me.tvModePanel = New System.Windows.Forms.Panel()
        Me.tvModePic = New System.Windows.Forms.PictureBox()
        Me.tvModeLbl = New System.Windows.Forms.Label()
        Me.sleepModePanel = New System.Windows.Forms.Panel()
        Me.sleepModePic = New System.Windows.Forms.PictureBox()
        Me.sleepModeLbl = New System.Windows.Forms.Label()
        Me.favoritePanel = New System.Windows.Forms.Panel()
        Me.favPanelPic = New System.Windows.Forms.PictureBox()
        Me.favPanelText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kitchenAir = New System.Windows.Forms.PictureBox()
        Me.tv = New System.Windows.Forms.PictureBox()
        Me.outdoorLight = New System.Windows.Forms.PictureBox()
        Me.LightHall = New System.Windows.Forms.PictureBox()
        Me.lightBed2 = New System.Windows.Forms.PictureBox()
        Me.LightBed1 = New System.Windows.Forms.PictureBox()
        Me.lightKitchen = New System.Windows.Forms.PictureBox()
        Me.diningLight = New System.Windows.Forms.PictureBox()
        Me.dishwasher = New System.Windows.Forms.PictureBox()
        Me.fireAlarmBed = New System.Windows.Forms.PictureBox()
        Me.fireAlarmSofa = New System.Windows.Forms.PictureBox()
        Me.washingMachine = New System.Windows.Forms.PictureBox()
        Me.oven = New System.Windows.Forms.PictureBox()
        Me.fridge = New System.Windows.Forms.PictureBox()
        Me.CamHall = New System.Windows.Forms.PictureBox()
        Me.LockFrontDoor = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StartWindow = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.HelpOKBtn = New System.Windows.Forms.Button()
        Me.HelpPanel = New System.Windows.Forms.Panel()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.PopUpWindowPanel.SuspendLayout()
        Me.EmergencyReverse.SuspendLayout()
        Me.favConfWindow.SuspendLayout()
        Me.addFavoriteWindow.SuspendLayout()
        Me.EmergencyConfirmationWindow.SuspendLayout()
        Me.EmergencyWindow.SuspendLayout()
        Me.settingsWindow.SuspendLayout()
        Me.fridgeWindow.SuspendLayout()
        Me.SmokeAlarmWindow.SuspendLayout()
        Me.AlarmWindow.SuspendLayout()
        Me.ovenWindow.SuspendLayout()
        Me.washWindow.SuspendLayout()
        Me.dishWindow.SuspendLayout()
        Me.airWindow.SuspendLayout()
        Me.tvWindow.SuspendLayout()
        CType(Me.volumeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightBath, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomPanel.SuspendLayout()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FavoriteIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightSofa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.camSofa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.balconyLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.homePanel.SuspendLayout()
        CType(Me.homePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.awayPanel.SuspendLayout()
        CType(Me.awayPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tvModePanel.SuspendLayout()
        CType(Me.tvModePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sleepModePanel.SuspendLayout()
        CType(Me.sleepModePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.favoritePanel.SuspendLayout()
        CType(Me.favPanelPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kitchenAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.outdoorLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LightHall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightBed2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LightBed1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightKitchen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diningLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dishwasher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fireAlarmBed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fireAlarmSofa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.washingMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fridge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CamHall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LockFrontDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StartWindow.SuspendLayout()
        Me.HelpPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.brushed_metal_background_1514
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.HelpButton)
        Me.Panel2.Controls.Add(Me.Emergency)
        Me.Panel2.Controls.Add(Me.PopUpWindowPanel)
        Me.Panel2.Controls.Add(Me.dishLbl)
        Me.Panel2.Controls.Add(Me.lightBath)
        Me.Panel2.Controls.Add(Me.BottomPanel)
        Me.Panel2.Controls.Add(Me.EmergencyLbl)
        Me.Panel2.Controls.Add(Me.hallLightLbl)
        Me.Panel2.Controls.Add(Me.bathLightLbl)
        Me.Panel2.Controls.Add(Me.hallCamLbl)
        Me.Panel2.Controls.Add(Me.bedAlarmLbl)
        Me.Panel2.Controls.Add(Me.bedlight2Lbl)
        Me.Panel2.Controls.Add(Me.bedlight1Lbl)
        Me.Panel2.Controls.Add(Me.alarmSofaLbl)
        Me.Panel2.Controls.Add(Me.outLightLbl)
        Me.Panel2.Controls.Add(Me.sofaCamLbl)
        Me.Panel2.Controls.Add(Me.sofaLightLbl)
        Me.Panel2.Controls.Add(Me.kitchenLightLbl)
        Me.Panel2.Controls.Add(Me.diningLightLbl)
        Me.Panel2.Controls.Add(Me.lightSofa)
        Me.Panel2.Controls.Add(Me.balconyLockLbl)
        Me.Panel2.Controls.Add(Me.camSofa)
        Me.Panel2.Controls.Add(Me.fridgeLbl)
        Me.Panel2.Controls.Add(Me.balconyLock)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.OvenLbl)
        Me.Panel2.Controls.Add(Me.tvLbl)
        Me.Panel2.Controls.Add(Me.washLbl)
        Me.Panel2.Controls.Add(Me.frontLockLbl)
        Me.Panel2.Controls.Add(Me.airKitchenLbl)
        Me.Panel2.Controls.Add(Me.kitchenAir)
        Me.Panel2.Controls.Add(Me.tv)
        Me.Panel2.Controls.Add(Me.outdoorLight)
        Me.Panel2.Controls.Add(Me.LightHall)
        Me.Panel2.Controls.Add(Me.lightBed2)
        Me.Panel2.Controls.Add(Me.LightBed1)
        Me.Panel2.Controls.Add(Me.lightKitchen)
        Me.Panel2.Controls.Add(Me.diningLight)
        Me.Panel2.Controls.Add(Me.dishwasher)
        Me.Panel2.Controls.Add(Me.fireAlarmBed)
        Me.Panel2.Controls.Add(Me.fireAlarmSofa)
        Me.Panel2.Controls.Add(Me.washingMachine)
        Me.Panel2.Controls.Add(Me.oven)
        Me.Panel2.Controls.Add(Me.fridge)
        Me.Panel2.Controls.Add(Me.CamHall)
        Me.Panel2.Controls.Add(Me.LockFrontDoor)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 562)
        Me.Panel2.TabIndex = 1
        '
        'dishLbl
        '
        Me.dishLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dishLbl.AutoSize = True
        Me.dishLbl.BackColor = System.Drawing.Color.Black
        Me.dishLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dishLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.dishLbl.ForeColor = System.Drawing.Color.White
        Me.dishLbl.Location = New System.Drawing.Point(471, 181)
        Me.dishLbl.Name = "dishLbl"
        Me.dishLbl.Size = New System.Drawing.Size(96, 48)
        Me.dishLbl.TabIndex = 48
        Me.dishLbl.Text = "Eco" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1h 2min left"
        Me.dishLbl.Visible = False
        '
        'EmergencyLbl
        '
        Me.EmergencyLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmergencyLbl.AutoSize = True
        Me.EmergencyLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmergencyLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmergencyLbl.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold)
        Me.EmergencyLbl.ForeColor = System.Drawing.Color.White
        Me.EmergencyLbl.Location = New System.Drawing.Point(187, 276)
        Me.EmergencyLbl.Name = "EmergencyLbl"
        Me.EmergencyLbl.Size = New System.Drawing.Size(438, 40)
        Me.EmergencyLbl.TabIndex = 49
        Me.EmergencyLbl.Text = "EMERGENCY MODE ACTIVATED"
        Me.EmergencyLbl.Visible = False
        '
        'hallLightLbl
        '
        Me.hallLightLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.hallLightLbl.AutoSize = True
        Me.hallLightLbl.BackColor = System.Drawing.Color.Black
        Me.hallLightLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.hallLightLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.hallLightLbl.ForeColor = System.Drawing.Color.White
        Me.hallLightLbl.Location = New System.Drawing.Point(627, 277)
        Me.hallLightLbl.Name = "hallLightLbl"
        Me.hallLightLbl.Size = New System.Drawing.Size(41, 25)
        Me.hallLightLbl.TabIndex = 63
        Me.hallLightLbl.Text = "OFF"
        Me.hallLightLbl.Visible = False
        '
        'bathLightLbl
        '
        Me.bathLightLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bathLightLbl.AutoSize = True
        Me.bathLightLbl.BackColor = System.Drawing.Color.Black
        Me.bathLightLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bathLightLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.bathLightLbl.ForeColor = System.Drawing.Color.White
        Me.bathLightLbl.Location = New System.Drawing.Point(550, 203)
        Me.bathLightLbl.Name = "bathLightLbl"
        Me.bathLightLbl.Size = New System.Drawing.Size(41, 25)
        Me.bathLightLbl.TabIndex = 62
        Me.bathLightLbl.Text = "OFF"
        Me.bathLightLbl.Visible = False
        '
        'hallCamLbl
        '
        Me.hallCamLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.hallCamLbl.AutoSize = True
        Me.hallCamLbl.BackColor = System.Drawing.Color.Black
        Me.hallCamLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.hallCamLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.hallCamLbl.ForeColor = System.Drawing.Color.White
        Me.hallCamLbl.Location = New System.Drawing.Point(532, 261)
        Me.hallCamLbl.Name = "hallCamLbl"
        Me.hallCamLbl.Size = New System.Drawing.Size(41, 25)
        Me.hallCamLbl.TabIndex = 61
        Me.hallCamLbl.Text = "OFF"
        Me.hallCamLbl.Visible = False
        '
        'bedAlarmLbl
        '
        Me.bedAlarmLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bedAlarmLbl.AutoSize = True
        Me.bedAlarmLbl.BackColor = System.Drawing.Color.Black
        Me.bedAlarmLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bedAlarmLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.bedAlarmLbl.ForeColor = System.Drawing.Color.White
        Me.bedAlarmLbl.Location = New System.Drawing.Point(681, 346)
        Me.bedAlarmLbl.Name = "bedAlarmLbl"
        Me.bedAlarmLbl.Size = New System.Drawing.Size(41, 25)
        Me.bedAlarmLbl.TabIndex = 60
        Me.bedAlarmLbl.Text = "OFF"
        Me.bedAlarmLbl.Visible = False
        '
        'bedlight2Lbl
        '
        Me.bedlight2Lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bedlight2Lbl.AutoSize = True
        Me.bedlight2Lbl.BackColor = System.Drawing.Color.Black
        Me.bedlight2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bedlight2Lbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.bedlight2Lbl.ForeColor = System.Drawing.Color.White
        Me.bedlight2Lbl.Location = New System.Drawing.Point(688, 441)
        Me.bedlight2Lbl.Name = "bedlight2Lbl"
        Me.bedlight2Lbl.Size = New System.Drawing.Size(41, 25)
        Me.bedlight2Lbl.TabIndex = 59
        Me.bedlight2Lbl.Text = "OFF"
        Me.bedlight2Lbl.Visible = False
        '
        'bedlight1Lbl
        '
        Me.bedlight1Lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bedlight1Lbl.AutoSize = True
        Me.bedlight1Lbl.BackColor = System.Drawing.Color.Black
        Me.bedlight1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bedlight1Lbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.bedlight1Lbl.ForeColor = System.Drawing.Color.White
        Me.bedlight1Lbl.Location = New System.Drawing.Point(550, 442)
        Me.bedlight1Lbl.Name = "bedlight1Lbl"
        Me.bedlight1Lbl.Size = New System.Drawing.Size(41, 25)
        Me.bedlight1Lbl.TabIndex = 58
        Me.bedlight1Lbl.Text = "OFF"
        Me.bedlight1Lbl.Visible = False
        '
        'alarmSofaLbl
        '
        Me.alarmSofaLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.alarmSofaLbl.AutoSize = True
        Me.alarmSofaLbl.BackColor = System.Drawing.Color.Black
        Me.alarmSofaLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.alarmSofaLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.alarmSofaLbl.ForeColor = System.Drawing.Color.White
        Me.alarmSofaLbl.Location = New System.Drawing.Point(404, 310)
        Me.alarmSofaLbl.Name = "alarmSofaLbl"
        Me.alarmSofaLbl.Size = New System.Drawing.Size(41, 25)
        Me.alarmSofaLbl.TabIndex = 57
        Me.alarmSofaLbl.Text = "OFF"
        Me.alarmSofaLbl.Visible = False
        '
        'outLightLbl
        '
        Me.outLightLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.outLightLbl.AutoSize = True
        Me.outLightLbl.BackColor = System.Drawing.Color.Black
        Me.outLightLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outLightLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.outLightLbl.ForeColor = System.Drawing.Color.White
        Me.outLightLbl.Location = New System.Drawing.Point(175, 246)
        Me.outLightLbl.Name = "outLightLbl"
        Me.outLightLbl.Size = New System.Drawing.Size(41, 25)
        Me.outLightLbl.TabIndex = 56
        Me.outLightLbl.Text = "OFF"
        Me.outLightLbl.Visible = False
        '
        'sofaCamLbl
        '
        Me.sofaCamLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sofaCamLbl.AutoSize = True
        Me.sofaCamLbl.BackColor = System.Drawing.Color.Black
        Me.sofaCamLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sofaCamLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.sofaCamLbl.ForeColor = System.Drawing.Color.White
        Me.sofaCamLbl.Location = New System.Drawing.Point(237, 442)
        Me.sofaCamLbl.Name = "sofaCamLbl"
        Me.sofaCamLbl.Size = New System.Drawing.Size(41, 25)
        Me.sofaCamLbl.TabIndex = 55
        Me.sofaCamLbl.Text = "OFF"
        Me.sofaCamLbl.Visible = False
        '
        'sofaLightLbl
        '
        Me.sofaLightLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sofaLightLbl.AutoSize = True
        Me.sofaLightLbl.BackColor = System.Drawing.Color.Black
        Me.sofaLightLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sofaLightLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.sofaLightLbl.ForeColor = System.Drawing.Color.White
        Me.sofaLightLbl.Location = New System.Drawing.Point(349, 381)
        Me.sofaLightLbl.Name = "sofaLightLbl"
        Me.sofaLightLbl.Size = New System.Drawing.Size(41, 25)
        Me.sofaLightLbl.TabIndex = 54
        Me.sofaLightLbl.Text = "OFF"
        Me.sofaLightLbl.Visible = False
        '
        'kitchenLightLbl
        '
        Me.kitchenLightLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.kitchenLightLbl.AutoSize = True
        Me.kitchenLightLbl.BackColor = System.Drawing.Color.Black
        Me.kitchenLightLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.kitchenLightLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.kitchenLightLbl.ForeColor = System.Drawing.Color.White
        Me.kitchenLightLbl.Location = New System.Drawing.Point(395, 230)
        Me.kitchenLightLbl.Name = "kitchenLightLbl"
        Me.kitchenLightLbl.Size = New System.Drawing.Size(41, 25)
        Me.kitchenLightLbl.TabIndex = 53
        Me.kitchenLightLbl.Text = "OFF"
        Me.kitchenLightLbl.Visible = False
        '
        'diningLightLbl
        '
        Me.diningLightLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.diningLightLbl.AutoSize = True
        Me.diningLightLbl.BackColor = System.Drawing.Color.Black
        Me.diningLightLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.diningLightLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.diningLightLbl.ForeColor = System.Drawing.Color.White
        Me.diningLightLbl.Location = New System.Drawing.Point(278, 184)
        Me.diningLightLbl.Name = "diningLightLbl"
        Me.diningLightLbl.Size = New System.Drawing.Size(41, 25)
        Me.diningLightLbl.TabIndex = 52
        Me.diningLightLbl.Text = "OFF"
        Me.diningLightLbl.Visible = False
        '
        'balconyLockLbl
        '
        Me.balconyLockLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.balconyLockLbl.AutoSize = True
        Me.balconyLockLbl.BackColor = System.Drawing.Color.Black
        Me.balconyLockLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.balconyLockLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.balconyLockLbl.ForeColor = System.Drawing.Color.White
        Me.balconyLockLbl.Location = New System.Drawing.Point(201, 343)
        Me.balconyLockLbl.Name = "balconyLockLbl"
        Me.balconyLockLbl.Size = New System.Drawing.Size(81, 25)
        Me.balconyLockLbl.TabIndex = 44
        Me.balconyLockLbl.Text = "Unlocked"
        Me.balconyLockLbl.Visible = False
        '
        'fridgeLbl
        '
        Me.fridgeLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fridgeLbl.AutoSize = True
        Me.fridgeLbl.BackColor = System.Drawing.Color.Black
        Me.fridgeLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fridgeLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.fridgeLbl.ForeColor = System.Drawing.Color.White
        Me.fridgeLbl.Location = New System.Drawing.Point(373, 106)
        Me.fridgeLbl.Name = "fridgeLbl"
        Me.fridgeLbl.Size = New System.Drawing.Size(109, 48)
        Me.fridgeLbl.TabIndex = 49
        Me.fridgeLbl.Text = "Fridge: +7 C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Freezer: -5 C"
        Me.fridgeLbl.Visible = False
        '
        'OvenLbl
        '
        Me.OvenLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OvenLbl.AutoSize = True
        Me.OvenLbl.BackColor = System.Drawing.Color.Black
        Me.OvenLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.OvenLbl.ForeColor = System.Drawing.Color.White
        Me.OvenLbl.Location = New System.Drawing.Point(433, 106)
        Me.OvenLbl.Name = "OvenLbl"
        Me.OvenLbl.Size = New System.Drawing.Size(53, 23)
        Me.OvenLbl.TabIndex = 47
        Me.OvenLbl.Text = "225 C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.OvenLbl.Visible = False
        '
        'tvLbl
        '
        Me.tvLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tvLbl.AutoSize = True
        Me.tvLbl.BackColor = System.Drawing.Color.Black
        Me.tvLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tvLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.tvLbl.ForeColor = System.Drawing.Color.White
        Me.tvLbl.Location = New System.Drawing.Point(480, 381)
        Me.tvLbl.Name = "tvLbl"
        Me.tvLbl.Size = New System.Drawing.Size(96, 48)
        Me.tvLbl.TabIndex = 46
        Me.tvLbl.Text = "40 C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1h 2min left"
        Me.tvLbl.Visible = False
        '
        'washLbl
        '
        Me.washLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.washLbl.AutoSize = True
        Me.washLbl.BackColor = System.Drawing.Color.Black
        Me.washLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.washLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.washLbl.ForeColor = System.Drawing.Color.White
        Me.washLbl.Location = New System.Drawing.Point(594, 106)
        Me.washLbl.Name = "washLbl"
        Me.washLbl.Size = New System.Drawing.Size(96, 48)
        Me.washLbl.TabIndex = 45
        Me.washLbl.Text = "40 C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1h 2min left"
        Me.washLbl.Visible = False
        '
        'frontLockLbl
        '
        Me.frontLockLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.frontLockLbl.AutoSize = True
        Me.frontLockLbl.BackColor = System.Drawing.Color.Black
        Me.frontLockLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.frontLockLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.frontLockLbl.ForeColor = System.Drawing.Color.White
        Me.frontLockLbl.Location = New System.Drawing.Point(688, 278)
        Me.frontLockLbl.Name = "frontLockLbl"
        Me.frontLockLbl.Size = New System.Drawing.Size(81, 25)
        Me.frontLockLbl.TabIndex = 43
        Me.frontLockLbl.Text = "Unlocked"
        Me.frontLockLbl.Visible = False
        '
        'airKitchenLbl
        '
        Me.airKitchenLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.airKitchenLbl.AutoSize = True
        Me.airKitchenLbl.BackColor = System.Drawing.Color.Black
        Me.airKitchenLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.airKitchenLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.airKitchenLbl.ForeColor = System.Drawing.Color.White
        Me.airKitchenLbl.Location = New System.Drawing.Point(644, 209)
        Me.airKitchenLbl.Name = "airKitchenLbl"
        Me.airKitchenLbl.Size = New System.Drawing.Size(46, 25)
        Me.airKitchenLbl.TabIndex = 35
        Me.airKitchenLbl.Text = "23 C"
        Me.airKitchenLbl.Visible = False
        '
        'Emergency
        '
        Me.Emergency.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Emergency.BackgroundImage = CType(resources.GetObject("Emergency.BackgroundImage"), System.Drawing.Image)
        Me.Emergency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Emergency.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Emergency.ForeColor = System.Drawing.Color.White
        Me.Emergency.Location = New System.Drawing.Point(23, 100)
        Me.Emergency.Name = "Emergency"
        Me.Emergency.Size = New System.Drawing.Size(135, 54)
        Me.Emergency.TabIndex = 51
        Me.Emergency.Text = "EMERGENCY"
        Me.Emergency.UseVisualStyleBackColor = False
        '
        'PopUpWindowPanel
        '
        Me.PopUpWindowPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PopUpWindowPanel.BackColor = System.Drawing.Color.Transparent
        Me.PopUpWindowPanel.BackgroundImage = CType(resources.GetObject("PopUpWindowPanel.BackgroundImage"), System.Drawing.Image)
        Me.PopUpWindowPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PopUpWindowPanel.Controls.Add(Me.settingsWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.favConfWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.tvWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.airWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.dishWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.washWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.ovenWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.AlarmWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.SmokeAlarmWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.fridgeWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.EmergencyWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.EmergencyConfirmationWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.addFavoriteWindow)
        Me.PopUpWindowPanel.Controls.Add(Me.EmergencyReverse)
        Me.PopUpWindowPanel.Location = New System.Drawing.Point(181, 165)
        Me.PopUpWindowPanel.Name = "PopUpWindowPanel"
        Me.PopUpWindowPanel.Size = New System.Drawing.Size(451, 258)
        Me.PopUpWindowPanel.TabIndex = 50
        Me.PopUpWindowPanel.Visible = False
        '
        'EmergencyReverse
        '
        Me.EmergencyReverse.BackColor = System.Drawing.Color.Transparent
        Me.EmergencyReverse.Controls.Add(Me.Button8)
        Me.EmergencyReverse.Controls.Add(Me.TextBox4)
        Me.EmergencyReverse.Controls.Add(Me.ReverseAlarmBtn)
        Me.EmergencyReverse.Controls.Add(Me.Label37)
        Me.EmergencyReverse.Controls.Add(Me.Label38)
        Me.EmergencyReverse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmergencyReverse.Location = New System.Drawing.Point(0, 0)
        Me.EmergencyReverse.Name = "EmergencyReverse"
        Me.EmergencyReverse.Size = New System.Drawing.Size(447, 254)
        Me.EmergencyReverse.TabIndex = 50
        Me.EmergencyReverse.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Button8.Location = New System.Drawing.Point(393, 11)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(36, 35)
        Me.Button8.TabIndex = 50
        Me.Button8.Text = "X"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(117, 102)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox4.Size = New System.Drawing.Size(220, 29)
        Me.TextBox4.TabIndex = 49
        '
        'ReverseAlarmBtn
        '
        Me.ReverseAlarmBtn.BackColor = System.Drawing.Color.OliveDrab
        Me.ReverseAlarmBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.ReverseAlarmBtn.Location = New System.Drawing.Point(152, 157)
        Me.ReverseAlarmBtn.Name = "ReverseAlarmBtn"
        Me.ReverseAlarmBtn.Size = New System.Drawing.Size(159, 35)
        Me.ReverseAlarmBtn.TabIndex = 48
        Me.ReverseAlarmBtn.Text = "Reverse Alarm"
        Me.ReverseAlarmBtn.UseVisualStyleBackColor = False
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(87, 18)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(274, 30)
        Me.Label37.TabIndex = 47
        Me.Label37.Text = "Reverse Emergency Alarm"
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(84, 60)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(284, 23)
        Me.Label38.TabIndex = 34
        Me.Label38.Text = "Reverse alarm by entering password:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'favConfWindow
        '
        Me.favConfWindow.BackColor = System.Drawing.Color.Transparent
        Me.favConfWindow.Controls.Add(Me.favConfOKbtn)
        Me.favConfWindow.Controls.Add(Me.favoriteconflbl)
        Me.favConfWindow.Controls.Add(Me.Label41)
        Me.favConfWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.favConfWindow.Location = New System.Drawing.Point(0, 0)
        Me.favConfWindow.Name = "favConfWindow"
        Me.favConfWindow.Size = New System.Drawing.Size(447, 254)
        Me.favConfWindow.TabIndex = 51
        Me.favConfWindow.Visible = False
        '
        'favConfOKbtn
        '
        Me.favConfOKbtn.BackColor = System.Drawing.Color.OliveDrab
        Me.favConfOKbtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.favConfOKbtn.Location = New System.Drawing.Point(182, 168)
        Me.favConfOKbtn.Name = "favConfOKbtn"
        Me.favConfOKbtn.Size = New System.Drawing.Size(101, 35)
        Me.favConfOKbtn.TabIndex = 48
        Me.favConfOKbtn.Text = "Ok"
        Me.favConfOKbtn.UseVisualStyleBackColor = False
        '
        'favoriteconflbl
        '
        Me.favoriteconflbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.favoriteconflbl.AutoSize = True
        Me.favoriteconflbl.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.favoriteconflbl.ForeColor = System.Drawing.Color.Black
        Me.favoriteconflbl.Location = New System.Drawing.Point(147, 39)
        Me.favoriteconflbl.Name = "favoriteconflbl"
        Me.favoriteconflbl.Size = New System.Drawing.Size(176, 30)
        Me.favoriteconflbl.TabIndex = 47
        Me.favoriteconflbl.Text = "Favourite added"
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(80, 87)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(301, 69)
        Me.Label41.TabIndex = 34
        Me.Label41.Text = "     Current state added to favourites." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Favourites are added to the navigation " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         bar on the top of the screen."
        '
        'addFavoriteWindow
        '
        Me.addFavoriteWindow.BackColor = System.Drawing.Color.Transparent
        Me.addFavoriteWindow.Controls.Add(Me.cancelAddFavBtn)
        Me.addFavoriteWindow.Controls.Add(Me.Label43)
        Me.addFavoriteWindow.Controls.Add(Me.FavNameTextbox)
        Me.addFavoriteWindow.Controls.Add(Me.saveFavBtn)
        Me.addFavoriteWindow.Controls.Add(Me.Label39)
        Me.addFavoriteWindow.Controls.Add(Me.Label42)
        Me.addFavoriteWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addFavoriteWindow.Location = New System.Drawing.Point(0, 0)
        Me.addFavoriteWindow.Name = "addFavoriteWindow"
        Me.addFavoriteWindow.Size = New System.Drawing.Size(447, 254)
        Me.addFavoriteWindow.TabIndex = 52
        Me.addFavoriteWindow.Visible = False
        '
        'cancelAddFavBtn
        '
        Me.cancelAddFavBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancelAddFavBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!, System.Drawing.FontStyle.Bold)
        Me.cancelAddFavBtn.Location = New System.Drawing.Point(402, 13)
        Me.cancelAddFavBtn.Name = "cancelAddFavBtn"
        Me.cancelAddFavBtn.Size = New System.Drawing.Size(36, 35)
        Me.cancelAddFavBtn.TabIndex = 51
        Me.cancelAddFavBtn.Text = "X"
        Me.cancelAddFavBtn.UseVisualStyleBackColor = False
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(54, 120)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(142, 46)
        Me.Label43.TabIndex = 50
        Me.Label43.Text = "Favourite name " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(e.g. watching TV)"
        '
        'FavNameTextbox
        '
        Me.FavNameTextbox.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FavNameTextbox.Location = New System.Drawing.Point(205, 127)
        Me.FavNameTextbox.Name = "FavNameTextbox"
        Me.FavNameTextbox.Size = New System.Drawing.Size(184, 29)
        Me.FavNameTextbox.TabIndex = 49
        '
        'saveFavBtn
        '
        Me.saveFavBtn.BackColor = System.Drawing.Color.OliveDrab
        Me.saveFavBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.saveFavBtn.Location = New System.Drawing.Point(185, 189)
        Me.saveFavBtn.Name = "saveFavBtn"
        Me.saveFavBtn.Size = New System.Drawing.Size(101, 35)
        Me.saveFavBtn.TabIndex = 48
        Me.saveFavBtn.Text = "Save"
        Me.saveFavBtn.UseVisualStyleBackColor = False
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(169, 32)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(153, 30)
        Me.Label39.TabIndex = 47
        Me.Label39.Text = "Add Favourite"
        '
        'Label42
        '
        Me.Label42.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(61, 77)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(332, 23)
        Me.Label42.TabIndex = 34
        Me.Label42.Text = "Add current state of the house to favourites"
        '
        'EmergencyConfirmationWindow
        '
        Me.EmergencyConfirmationWindow.BackColor = System.Drawing.Color.Transparent
        Me.EmergencyConfirmationWindow.Controls.Add(Me.Button6)
        Me.EmergencyConfirmationWindow.Controls.Add(Me.Label30)
        Me.EmergencyConfirmationWindow.Controls.Add(Me.Label36)
        Me.EmergencyConfirmationWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmergencyConfirmationWindow.Location = New System.Drawing.Point(0, 0)
        Me.EmergencyConfirmationWindow.Name = "EmergencyConfirmationWindow"
        Me.EmergencyConfirmationWindow.Size = New System.Drawing.Size(447, 254)
        Me.EmergencyConfirmationWindow.TabIndex = 49
        Me.EmergencyConfirmationWindow.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.OliveDrab
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.Button6.Location = New System.Drawing.Point(179, 169)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(101, 35)
        Me.Button6.TabIndex = 48
        Me.Button6.Text = "Ok"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(165, 37)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(149, 30)
        Me.Label30.TabIndex = 47
        Me.Label30.Text = "Help alarmed"
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(113, 100)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(223, 46)
        Me.Label36.TabIndex = 34
        Me.Label36.Text = "Alarm sent to the authorities." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Wait help in a safe place."
        '
        'EmergencyWindow
        '
        Me.EmergencyWindow.BackColor = System.Drawing.Color.Transparent
        Me.EmergencyWindow.Controls.Add(Me.Button3)
        Me.EmergencyWindow.Controls.Add(Me.emergencyWindowTitle)
        Me.EmergencyWindow.Controls.Add(Me.Button5)
        Me.EmergencyWindow.Controls.Add(Me.Label40)
        Me.EmergencyWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmergencyWindow.Location = New System.Drawing.Point(0, 0)
        Me.EmergencyWindow.Name = "EmergencyWindow"
        Me.EmergencyWindow.Size = New System.Drawing.Size(447, 254)
        Me.EmergencyWindow.TabIndex = 48
        Me.EmergencyWindow.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.OliveDrab
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.Button3.Location = New System.Drawing.Point(94, 146)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 35)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "Yes"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'emergencyWindowTitle
        '
        Me.emergencyWindowTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.emergencyWindowTitle.AutoSize = True
        Me.emergencyWindowTitle.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.emergencyWindowTitle.ForeColor = System.Drawing.Color.Black
        Me.emergencyWindowTitle.Location = New System.Drawing.Point(172, 26)
        Me.emergencyWindowTitle.Name = "emergencyWindowTitle"
        Me.emergencyWindowTitle.Size = New System.Drawing.Size(126, 30)
        Me.emergencyWindowTitle.TabIndex = 47
        Me.emergencyWindowTitle.Text = "Alarm Help"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkRed
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.Button5.Location = New System.Drawing.Point(256, 146)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 35)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "No"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(7, 70)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(440, 46)
        Me.Label40.TabIndex = 34
        Me.Label40.Text = "       Are you sure you want to alarm the authorities?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Current state of the hous" &
    "e will be delivered automatically. "
        '
        'settingsWindow
        '
        Me.settingsWindow.BackColor = System.Drawing.Color.Transparent
        Me.settingsWindow.Controls.Add(Me.Label29)
        Me.settingsWindow.Controls.Add(Me.TextBox3)
        Me.settingsWindow.Controls.Add(Me.Label28)
        Me.settingsWindow.Controls.Add(Me.TextBox2)
        Me.settingsWindow.Controls.Add(Me.Label27)
        Me.settingsWindow.Controls.Add(Me.TextBox1)
        Me.settingsWindow.Controls.Add(Me.Label26)
        Me.settingsWindow.Controls.Add(Me.ComboBox1)
        Me.settingsWindow.Controls.Add(Me.Label20)
        Me.settingsWindow.Controls.Add(Me.settingsCancelBtn)
        Me.settingsWindow.Controls.Add(Me.settingsSaveBtn)
        Me.settingsWindow.Controls.Add(Me.ComboBox2)
        Me.settingsWindow.Controls.Add(Me.Label25)
        Me.settingsWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settingsWindow.Location = New System.Drawing.Point(0, 0)
        Me.settingsWindow.Name = "settingsWindow"
        Me.settingsWindow.Size = New System.Drawing.Size(447, 254)
        Me.settingsWindow.TabIndex = 47
        Me.settingsWindow.Visible = False
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(12, 177)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(207, 23)
        Me.Label29.TabIndex = 53
        Me.Label29.Text = "Confirm with old Password"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(229, 178)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(161, 29)
        Me.TextBox3.TabIndex = 52
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(80, 143)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(127, 23)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "Password Again"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(229, 143)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(161, 29)
        Me.TextBox2.TabIndex = 50
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(70, 110)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(141, 23)
        Me.Label27.TabIndex = 49
        Me.Label27.Text = "Change Password"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(229, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(161, 29)
        Me.TextBox1.TabIndex = 48
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(191, 2)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(95, 30)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "Settings"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Celsius", "Fahrenheit"})
        Me.ComboBox1.Location = New System.Drawing.Point(229, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 29)
        Me.ComboBox1.TabIndex = 46
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(74, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(137, 23)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Temperature Unit"
        '
        'settingsCancelBtn
        '
        Me.settingsCancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.settingsCancelBtn.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.settingsCancelBtn.Location = New System.Drawing.Point(402, 10)
        Me.settingsCancelBtn.Name = "settingsCancelBtn"
        Me.settingsCancelBtn.Size = New System.Drawing.Size(36, 35)
        Me.settingsCancelBtn.TabIndex = 41
        Me.settingsCancelBtn.Text = "X"
        Me.settingsCancelBtn.UseVisualStyleBackColor = False
        '
        'settingsSaveBtn
        '
        Me.settingsSaveBtn.BackColor = System.Drawing.Color.OliveDrab
        Me.settingsSaveBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.settingsSaveBtn.Location = New System.Drawing.Point(188, 213)
        Me.settingsSaveBtn.Name = "settingsSaveBtn"
        Me.settingsSaveBtn.Size = New System.Drawing.Size(101, 35)
        Me.settingsSaveBtn.TabIndex = 40
        Me.settingsSaveBtn.Text = "Save"
        Me.settingsSaveBtn.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"English", "svenska", "suomi"})
        Me.ComboBox2.Location = New System.Drawing.Point(229, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(161, 29)
        Me.ComboBox2.TabIndex = 37
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(128, 39)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(83, 23)
        Me.Label25.TabIndex = 34
        Me.Label25.Text = "Language"
        '
        'fridgeWindow
        '
        Me.fridgeWindow.BackColor = System.Drawing.Color.Transparent
        Me.fridgeWindow.Controls.Add(Me.Label4)
        Me.fridgeWindow.Controls.Add(Me.freezerCombobox)
        Me.fridgeWindow.Controls.Add(Me.Label24)
        Me.fridgeWindow.Controls.Add(Me.fridgeOffBtn)
        Me.fridgeWindow.Controls.Add(Me.fridgeCancelBtn)
        Me.fridgeWindow.Controls.Add(Me.fridgeSaveBtn)
        Me.fridgeWindow.Controls.Add(Me.fridgeCombobox)
        Me.fridgeWindow.Controls.Add(Me.Label21)
        Me.fridgeWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fridgeWindow.Location = New System.Drawing.Point(0, 0)
        Me.fridgeWindow.Name = "fridgeWindow"
        Me.fridgeWindow.Size = New System.Drawing.Size(447, 254)
        Me.fridgeWindow.TabIndex = 45
        Me.fridgeWindow.Visible = False
        '
        'freezerCombobox
        '
        Me.freezerCombobox.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.freezerCombobox.FormattingEnabled = True
        Me.freezerCombobox.Items.AddRange(New Object() {"0 C", "-1 C", "-2 C", "-3 C", "-4 C", "-5 C", "-6 C", "-7 C", "-8 C", "-9 C", "-10 C", "-11 C", "-12 C"})
        Me.freezerCombobox.Location = New System.Drawing.Point(301, 110)
        Me.freezerCombobox.Name = "freezerCombobox"
        Me.freezerCombobox.Size = New System.Drawing.Size(91, 29)
        Me.freezerCombobox.TabIndex = 46
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(58, 107)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(202, 30)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Freezer Temperature"
        '
        'fridgeOffBtn
        '
        Me.fridgeOffBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fridgeOffBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.fridgeOffBtn.Location = New System.Drawing.Point(123, 179)
        Me.fridgeOffBtn.Name = "fridgeOffBtn"
        Me.fridgeOffBtn.Size = New System.Drawing.Size(102, 35)
        Me.fridgeOffBtn.TabIndex = 42
        Me.fridgeOffBtn.Text = "Turn Off"
        Me.fridgeOffBtn.UseVisualStyleBackColor = False
        '
        'fridgeCancelBtn
        '
        Me.fridgeCancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fridgeCancelBtn.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.fridgeCancelBtn.Location = New System.Drawing.Point(398, 13)
        Me.fridgeCancelBtn.Name = "fridgeCancelBtn"
        Me.fridgeCancelBtn.Size = New System.Drawing.Size(36, 35)
        Me.fridgeCancelBtn.TabIndex = 41
        Me.fridgeCancelBtn.Text = "X"
        Me.fridgeCancelBtn.UseVisualStyleBackColor = False
        '
        'fridgeSaveBtn
        '
        Me.fridgeSaveBtn.BackColor = System.Drawing.Color.OliveDrab
        Me.fridgeSaveBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.fridgeSaveBtn.Location = New System.Drawing.Point(246, 179)
        Me.fridgeSaveBtn.Name = "fridgeSaveBtn"
        Me.fridgeSaveBtn.Size = New System.Drawing.Size(101, 35)
        Me.fridgeSaveBtn.TabIndex = 40
        Me.fridgeSaveBtn.Text = "Save"
        Me.fridgeSaveBtn.UseVisualStyleBackColor = False
        '
        'fridgeCombobox
        '
        Me.fridgeCombobox.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.fridgeCombobox.FormattingEnabled = True
        Me.fridgeCombobox.Items.AddRange(New Object() {"0 C", "1 C", "2 C", "3 C", "4 C", "5 C", "6 C", "7 C", "8 C", "9 C", "10 C", "11 C", "12 C"})
        Me.fridgeCombobox.Location = New System.Drawing.Point(302, 64)
        Me.fridgeCombobox.Name = "fridgeCombobox"
        Me.fridgeCombobox.Size = New System.Drawing.Size(91, 29)
        Me.fridgeCombobox.TabIndex = 37
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(64, 63)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(192, 30)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Fridge Temperature"
        '
        'SmokeAlarmWindow
        '
        Me.SmokeAlarmWindow.BackColor = System.Drawing.Color.Transparent
        Me.SmokeAlarmWindow.Controls.Add(Me.Button12)
        Me.SmokeAlarmWindow.Controls.Add(Me.Button11)
        Me.SmokeAlarmWindow.Controls.Add(Me.Label44)
        Me.SmokeAlarmWindow.Controls.Add(Me.Label45)
        Me.SmokeAlarmWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SmokeAlarmWindow.Location = New System.Drawing.Point(0, 0)
        Me.SmokeAlarmWindow.Name = "SmokeAlarmWindow"
        Me.SmokeAlarmWindow.Size = New System.Drawing.Size(447, 254)
        Me.SmokeAlarmWindow.TabIndex = 53
        Me.SmokeAlarmWindow.Visible = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button12.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.Button12.Location = New System.Drawing.Point(242, 169)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(129, 35)
        Me.Button12.TabIndex = 49
        Me.Button12.Text = "Ignore"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.OliveDrab
        Me.Button11.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.Button11.Location = New System.Drawing.Point(76, 169)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(127, 35)
        Me.Button11.TabIndex = 48
        Me.Button11.Text = "Alarm Help"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(136, 36)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(176, 30)
        Me.Label44.TabIndex = 47
        Me.Label44.Text = "Smoke detected"
        '
        'Label45
        '
        Me.Label45.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(20, 91)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(426, 23)
        Me.Label45.TabIndex = 34
        Me.Label45.Text = "Smoke was detected by the smoke detector in bedroom"
        '
        'AlarmWindow
        '
        Me.AlarmWindow.BackColor = System.Drawing.Color.Transparent
        Me.AlarmWindow.Controls.Add(Me.Button13)
        Me.AlarmWindow.Controls.Add(Me.Label46)
        Me.AlarmWindow.Controls.Add(Me.Label47)
        Me.AlarmWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlarmWindow.Location = New System.Drawing.Point(0, 0)
        Me.AlarmWindow.Name = "AlarmWindow"
        Me.AlarmWindow.Size = New System.Drawing.Size(447, 254)
        Me.AlarmWindow.TabIndex = 54
        Me.AlarmWindow.Visible = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.OliveDrab
        Me.Button13.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.Button13.Location = New System.Drawing.Point(181, 176)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(101, 35)
        Me.Button13.TabIndex = 48
        Me.Button13.Text = "Ok"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Label46
        '
        Me.Label46.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(161, 32)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(149, 30)
        Me.Label46.TabIndex = 47
        Me.Label46.Text = "Help alarmed"
        '
        'Label47
        '
        Me.Label47.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(115, 96)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(223, 46)
        Me.Label47.TabIndex = 34
        Me.Label47.Text = "Alarm sent to the authorities." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Wait help in a safe place."
        '
        'ovenWindow
        '
        Me.ovenWindow.BackColor = System.Drawing.Color.Transparent
        Me.ovenWindow.Controls.Add(Me.ovenOffBtn)
        Me.ovenWindow.Controls.Add(Me.ovenCancelBtn)
        Me.ovenWindow.Controls.Add(Me.ovenSaveBtn)
        Me.ovenWindow.Controls.Add(Me.ovenCombobox)
        Me.ovenWindow.Controls.Add(Me.Label22)
        Me.ovenWindow.Controls.Add(Me.Label23)
        Me.ovenWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ovenWindow.Location = New System.Drawing.Point(0, 0)
        Me.ovenWindow.Name = "ovenWindow"
        Me.ovenWindow.Size = New System.Drawing.Size(447, 254)
        Me.ovenWindow.TabIndex = 43
        Me.ovenWindow.Visible = False
        '
        'ovenOffBtn
        '
        Me.ovenOffBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ovenOffBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.ovenOffBtn.Location = New System.Drawing.Point(108, 155)
        Me.ovenOffBtn.Name = "ovenOffBtn"
        Me.ovenOffBtn.Size = New System.Drawing.Size(102, 35)
        Me.ovenOffBtn.TabIndex = 42
        Me.ovenOffBtn.Text = "Turn Off"
        Me.ovenOffBtn.UseVisualStyleBackColor = False
        '
        'ovenCancelBtn
        '
        Me.ovenCancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ovenCancelBtn.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.ovenCancelBtn.Location = New System.Drawing.Point(397, 13)
        Me.ovenCancelBtn.Name = "ovenCancelBtn"
        Me.ovenCancelBtn.Size = New System.Drawing.Size(36, 35)
        Me.ovenCancelBtn.TabIndex = 41
        Me.ovenCancelBtn.Text = "X"
        Me.ovenCancelBtn.UseVisualStyleBackColor = False
        '
        'ovenSaveBtn
        '
        Me.ovenSaveBtn.BackColor = System.Drawing.Color.OliveDrab
        Me.ovenSaveBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.ovenSaveBtn.Location = New System.Drawing.Point(251, 155)
        Me.ovenSaveBtn.Name = "ovenSaveBtn"
        Me.ovenSaveBtn.Size = New System.Drawing.Size(101, 35)
        Me.ovenSaveBtn.TabIndex = 40
        Me.ovenSaveBtn.Text = "Save"
        Me.ovenSaveBtn.UseVisualStyleBackColor = False
        '
        'ovenCombobox
        '
        Me.ovenCombobox.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ovenCombobox.FormattingEnabled = True
        Me.ovenCombobox.Items.AddRange(New Object() {"150 C ", "175 C", "200 C", "225 C", "250 C", "275 C"})
        Me.ovenCombobox.Location = New System.Drawing.Point(249, 78)
        Me.ovenCombobox.Name = "ovenCombobox"
        Me.ovenCombobox.Size = New System.Drawing.Size(91, 36)
        Me.ovenCombobox.TabIndex = 37
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(99, 78)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(129, 30)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Temperature"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(198, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 30)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "Oven"
        '
        'washWindow
        '
        Me.washWindow.BackColor = System.Drawing.Color.Transparent
        Me.washWindow.Controls.Add(Me.washOffBtn)
        Me.washWindow.Controls.Add(Me.washCancelBtn)
        Me.washWindow.Controls.Add(Me.WashSaveBtn)
        Me.washWindow.Controls.Add(Me.washTimeLbl)
        Me.washWindow.Controls.Add(Me.Label10)
        Me.washWindow.Controls.Add(Me.washCombobox)
        Me.washWindow.Controls.Add(Me.Label9)
        Me.washWindow.Controls.Add(Me.Label8)
        Me.washWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.washWindow.Location = New System.Drawing.Point(0, 0)
        Me.washWindow.Name = "washWindow"
        Me.washWindow.Size = New System.Drawing.Size(447, 254)
        Me.washWindow.TabIndex = 34
        Me.washWindow.Visible = False
        '
        'washOffBtn
        '
        Me.washOffBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.washOffBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.washOffBtn.Location = New System.Drawing.Point(123, 155)
        Me.washOffBtn.Name = "washOffBtn"
        Me.washOffBtn.Size = New System.Drawing.Size(102, 35)
        Me.washOffBtn.TabIndex = 42
        Me.washOffBtn.Text = "Turn Off"
        Me.washOffBtn.UseVisualStyleBackColor = False
        '
        'washCancelBtn
        '
        Me.washCancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.washCancelBtn.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.washCancelBtn.Location = New System.Drawing.Point(395, 15)
        Me.washCancelBtn.Name = "washCancelBtn"
        Me.washCancelBtn.Size = New System.Drawing.Size(36, 35)
        Me.washCancelBtn.TabIndex = 41
        Me.washCancelBtn.Text = "X"
        Me.washCancelBtn.UseVisualStyleBackColor = False
        '
        'WashSaveBtn
        '
        Me.WashSaveBtn.BackColor = System.Drawing.Color.OliveDrab
        Me.WashSaveBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.WashSaveBtn.Location = New System.Drawing.Point(252, 155)
        Me.WashSaveBtn.Name = "WashSaveBtn"
        Me.WashSaveBtn.Size = New System.Drawing.Size(101, 35)
        Me.WashSaveBtn.TabIndex = 40
        Me.WashSaveBtn.Text = "Save"
        Me.WashSaveBtn.UseVisualStyleBackColor = False
        '
        'washTimeLbl
        '
        Me.washTimeLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.washTimeLbl.AutoSize = True
        Me.washTimeLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.washTimeLbl.ForeColor = System.Drawing.Color.Black
        Me.washTimeLbl.Location = New System.Drawing.Point(238, 104)
        Me.washTimeLbl.Name = "washTimeLbl"
        Me.washTimeLbl.Size = New System.Drawing.Size(96, 30)
        Me.washTimeLbl.TabIndex = 39
        Me.washTimeLbl.Text = "2h 10min"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(149, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 30)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Time"
        '
        'washCombobox
        '
        Me.washCombobox.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.washCombobox.FormattingEnabled = True
        Me.washCombobox.Items.AddRange(New Object() {"40 C", "60 C", "70 C"})
        Me.washCombobox.Location = New System.Drawing.Point(250, 70)
        Me.washCombobox.Name = "washCombobox"
        Me.washCombobox.Size = New System.Drawing.Size(91, 29)
        Me.washCombobox.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(44, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 30)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Washing Machine"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(149, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 30)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Washing Machine"
        '
        'dishWindow
        '
        Me.dishWindow.BackColor = System.Drawing.Color.Transparent
        Me.dishWindow.Controls.Add(Me.dishOffBtn)
        Me.dishWindow.Controls.Add(Me.dishCancelBtn)
        Me.dishWindow.Controls.Add(Me.dishSaveBtn)
        Me.dishWindow.Controls.Add(Me.Label16)
        Me.dishWindow.Controls.Add(Me.Label17)
        Me.dishWindow.Controls.Add(Me.dishCombobox)
        Me.dishWindow.Controls.Add(Me.Label18)
        Me.dishWindow.Controls.Add(Me.Label19)
        Me.dishWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dishWindow.ForeColor = System.Drawing.Color.Black
        Me.dishWindow.Location = New System.Drawing.Point(0, 0)
        Me.dishWindow.Name = "dishWindow"
        Me.dishWindow.Size = New System.Drawing.Size(447, 254)
        Me.dishWindow.TabIndex = 43
        Me.dishWindow.Visible = False
        '
        'dishOffBtn
        '
        Me.dishOffBtn.BackColor = System.Drawing.Color.DarkRed
        Me.dishOffBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.dishOffBtn.Location = New System.Drawing.Point(122, 172)
        Me.dishOffBtn.Name = "dishOffBtn"
        Me.dishOffBtn.Size = New System.Drawing.Size(102, 35)
        Me.dishOffBtn.TabIndex = 42
        Me.dishOffBtn.Text = "Turn Off"
        Me.dishOffBtn.UseVisualStyleBackColor = False
        '
        'dishCancelBtn
        '
        Me.dishCancelBtn.BackColor = System.Drawing.Color.DarkRed
        Me.dishCancelBtn.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.dishCancelBtn.Location = New System.Drawing.Point(397, 12)
        Me.dishCancelBtn.Name = "dishCancelBtn"
        Me.dishCancelBtn.Size = New System.Drawing.Size(36, 35)
        Me.dishCancelBtn.TabIndex = 41
        Me.dishCancelBtn.Text = "X"
        Me.dishCancelBtn.UseVisualStyleBackColor = False
        '
        'dishSaveBtn
        '
        Me.dishSaveBtn.BackColor = System.Drawing.Color.OliveDrab
        Me.dishSaveBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.dishSaveBtn.Location = New System.Drawing.Point(251, 172)
        Me.dishSaveBtn.Name = "dishSaveBtn"
        Me.dishSaveBtn.Size = New System.Drawing.Size(101, 35)
        Me.dishSaveBtn.TabIndex = 40
        Me.dishSaveBtn.Text = "Save"
        Me.dishSaveBtn.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(237, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 30)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "1h 45min"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(148, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 30)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Time"
        '
        'dishCombobox
        '
        Me.dishCombobox.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dishCombobox.FormattingEnabled = True
        Me.dishCombobox.Items.AddRange(New Object() {"Fast", "Basic", "Eco", "Super"})
        Me.dishCombobox.Location = New System.Drawing.Point(249, 87)
        Me.dishCombobox.Name = "dishCombobox"
        Me.dishCombobox.Size = New System.Drawing.Size(91, 29)
        Me.dishCombobox.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(51, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(182, 30)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Select programme"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(174, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 30)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Dishwasher"
        '
        'airWindow
        '
        Me.airWindow.BackColor = System.Drawing.Color.Transparent
        Me.airWindow.Controls.Add(Me.airOffBtn)
        Me.airWindow.Controls.Add(Me.airCancelBtn)
        Me.airWindow.Controls.Add(Me.airSaveBtn)
        Me.airWindow.Controls.Add(Me.temperatureCombobox)
        Me.airWindow.Controls.Add(Me.Label13)
        Me.airWindow.Controls.Add(Me.Label14)
        Me.airWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.airWindow.Location = New System.Drawing.Point(0, 0)
        Me.airWindow.Name = "airWindow"
        Me.airWindow.Size = New System.Drawing.Size(447, 254)
        Me.airWindow.TabIndex = 42
        Me.airWindow.Visible = False
        '
        'airOffBtn
        '
        Me.airOffBtn.BackColor = System.Drawing.Color.DarkRed
        Me.airOffBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.airOffBtn.Location = New System.Drawing.Point(114, 163)
        Me.airOffBtn.Name = "airOffBtn"
        Me.airOffBtn.Size = New System.Drawing.Size(108, 35)
        Me.airOffBtn.TabIndex = 42
        Me.airOffBtn.Text = "Turn Off"
        Me.airOffBtn.UseVisualStyleBackColor = False
        '
        'airCancelBtn
        '
        Me.airCancelBtn.BackColor = System.Drawing.Color.DarkRed
        Me.airCancelBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!, System.Drawing.FontStyle.Bold)
        Me.airCancelBtn.Location = New System.Drawing.Point(401, 15)
        Me.airCancelBtn.Name = "airCancelBtn"
        Me.airCancelBtn.Size = New System.Drawing.Size(33, 35)
        Me.airCancelBtn.TabIndex = 41
        Me.airCancelBtn.Text = "X"
        Me.airCancelBtn.UseVisualStyleBackColor = False
        '
        'airSaveBtn
        '
        Me.airSaveBtn.BackColor = System.Drawing.Color.OliveDrab
        Me.airSaveBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.airSaveBtn.Location = New System.Drawing.Point(250, 163)
        Me.airSaveBtn.Name = "airSaveBtn"
        Me.airSaveBtn.Size = New System.Drawing.Size(101, 35)
        Me.airSaveBtn.TabIndex = 40
        Me.airSaveBtn.Text = "Save"
        Me.airSaveBtn.UseVisualStyleBackColor = False
        '
        'temperatureCombobox
        '
        Me.temperatureCombobox.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temperatureCombobox.FormattingEnabled = True
        Me.temperatureCombobox.Items.AddRange(New Object() {"15 C", "16 C", "17 C", "18C", "19 C", "20 C", "21 C", "22 C", "23 C", "24 C", "25 C", "26 C", "27 C"})
        Me.temperatureCombobox.Location = New System.Drawing.Point(261, 102)
        Me.temperatureCombobox.Name = "temperatureCombobox"
        Me.temperatureCombobox.Size = New System.Drawing.Size(81, 29)
        Me.temperatureCombobox.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(68, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 30)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Set Temperature"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(148, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(179, 30)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Air Conditioning"
        '
        'tvWindow
        '
        Me.tvWindow.BackColor = System.Drawing.Color.Transparent
        Me.tvWindow.Controls.Add(Me.Label2)
        Me.tvWindow.Controls.Add(Me.tvCancelBtn)
        Me.tvWindow.Controls.Add(Me.Label15)
        Me.tvWindow.Controls.Add(Me.tvOffBtn)
        Me.tvWindow.Controls.Add(Me.tvSaveBtn)
        Me.tvWindow.Controls.Add(Me.TVComboBox)
        Me.tvWindow.Controls.Add(Me.Label11)
        Me.tvWindow.Controls.Add(Me.Label12)
        Me.tvWindow.Controls.Add(Me.volumeBar)
        Me.tvWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvWindow.Location = New System.Drawing.Point(0, 0)
        Me.tvWindow.Name = "tvWindow"
        Me.tvWindow.Size = New System.Drawing.Size(447, 254)
        Me.tvWindow.TabIndex = 43
        Me.tvWindow.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 10.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(373, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "100%"
        '
        'tvCancelBtn
        '
        Me.tvCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tvCancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tvCancelBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvCancelBtn.Location = New System.Drawing.Point(398, 12)
        Me.tvCancelBtn.Name = "tvCancelBtn"
        Me.tvCancelBtn.Size = New System.Drawing.Size(37, 34)
        Me.tvCancelBtn.TabIndex = 44
        Me.tvCancelBtn.Text = "X"
        Me.tvCancelBtn.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(69, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 30)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Volume"
        '
        'tvOffBtn
        '
        Me.tvOffBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tvOffBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tvOffBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.tvOffBtn.Location = New System.Drawing.Point(113, 177)
        Me.tvOffBtn.Name = "tvOffBtn"
        Me.tvOffBtn.Size = New System.Drawing.Size(101, 35)
        Me.tvOffBtn.TabIndex = 41
        Me.tvOffBtn.Text = "Turn Off"
        Me.tvOffBtn.UseVisualStyleBackColor = False
        '
        'tvSaveBtn
        '
        Me.tvSaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tvSaveBtn.BackColor = System.Drawing.Color.OliveDrab
        Me.tvSaveBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.tvSaveBtn.Location = New System.Drawing.Point(244, 177)
        Me.tvSaveBtn.Name = "tvSaveBtn"
        Me.tvSaveBtn.Size = New System.Drawing.Size(101, 35)
        Me.tvSaveBtn.TabIndex = 40
        Me.tvSaveBtn.Text = "Save"
        Me.tvSaveBtn.UseVisualStyleBackColor = False
        '
        'TVComboBox
        '
        Me.TVComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TVComboBox.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TVComboBox.FormattingEnabled = True
        Me.TVComboBox.Items.AddRange(New Object() {"YLE 1", "YLE 2", "MTV3", "Nelonen", "SVT", "SubTV", "AVA", "Hero"})
        Me.TVComboBox.Location = New System.Drawing.Point(177, 69)
        Me.TVComboBox.Name = "TVComboBox"
        Me.TVComboBox.Size = New System.Drawing.Size(180, 29)
        Me.TVComboBox.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(69, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 30)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Channel"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(211, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 30)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "TV"
        '
        'volumeBar
        '
        Me.volumeBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.volumeBar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.volumeBar.Location = New System.Drawing.Point(165, 112)
        Me.volumeBar.Name = "volumeBar"
        Me.volumeBar.Size = New System.Drawing.Size(209, 45)
        Me.volumeBar.TabIndex = 42
        Me.volumeBar.Value = 10
        '
        'lightBath
        '
        Me.lightBath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lightBath.BackColor = System.Drawing.Color.Black
        Me.lightBath.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light3
        Me.lightBath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.lightBath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lightBath.Location = New System.Drawing.Point(499, 203)
        Me.lightBath.MinimumSize = New System.Drawing.Size(40, 40)
        Me.lightBath.Name = "lightBath"
        Me.lightBath.Size = New System.Drawing.Size(50, 50)
        Me.lightBath.TabIndex = 18
        Me.lightBath.TabStop = False
        '
        'BottomPanel
        '
        Me.BottomPanel.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.steel
        Me.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BottomPanel.Controls.Add(Me.Settings)
        Me.BottomPanel.Controls.Add(Me.SettingsLabel)
        Me.BottomPanel.Controls.Add(Me.FavoriteIcon)
        Me.BottomPanel.Controls.Add(Me.favoritesLbl)
        Me.BottomPanel.Controls.Add(Me.Button9)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 505)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(784, 57)
        Me.BottomPanel.TabIndex = 65
        '
        'Settings
        '
        Me.Settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Settings.BackColor = System.Drawing.Color.White
        Me.Settings.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.settings1
        Me.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Settings.Location = New System.Drawing.Point(21, 8)
        Me.Settings.MinimumSize = New System.Drawing.Size(40, 40)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(41, 40)
        Me.Settings.TabIndex = 30
        Me.Settings.TabStop = False
        '
        'SettingsLabel
        '
        Me.SettingsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SettingsLabel.AutoSize = True
        Me.SettingsLabel.BackColor = System.Drawing.Color.Transparent
        Me.SettingsLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.SettingsLabel.Location = New System.Drawing.Point(69, 11)
        Me.SettingsLabel.Name = "SettingsLabel"
        Me.SettingsLabel.Size = New System.Drawing.Size(87, 30)
        Me.SettingsLabel.TabIndex = 31
        Me.SettingsLabel.Text = "Settings"
        '
        'FavoriteIcon
        '
        Me.FavoriteIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FavoriteIcon.BackColor = System.Drawing.Color.Transparent
        Me.FavoriteIcon.BackgroundImage = CType(resources.GetObject("FavoriteIcon.BackgroundImage"), System.Drawing.Image)
        Me.FavoriteIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FavoriteIcon.Location = New System.Drawing.Point(583, 7)
        Me.FavoriteIcon.MinimumSize = New System.Drawing.Size(40, 40)
        Me.FavoriteIcon.Name = "FavoriteIcon"
        Me.FavoriteIcon.Size = New System.Drawing.Size(40, 40)
        Me.FavoriteIcon.TabIndex = 32
        Me.FavoriteIcon.TabStop = False
        '
        'favoritesLbl
        '
        Me.favoritesLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.favoritesLbl.AutoSize = True
        Me.favoritesLbl.BackColor = System.Drawing.Color.Transparent
        Me.favoritesLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!)
        Me.favoritesLbl.Location = New System.Drawing.Point(622, 11)
        Me.favoritesLbl.Name = "favoritesLbl"
        Me.favoritesLbl.Size = New System.Drawing.Size(149, 30)
        Me.favoritesLbl.TabIndex = 33
        Me.favoritesLbl.Text = "Add Favourites"
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button9.BackColor = System.Drawing.Color.DimGray
        Me.Button9.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(316, 5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(146, 41)
        Me.Button9.TabIndex = 64
        Me.Button9.Text = "Alarm Test"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'lightSofa
        '
        Me.lightSofa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lightSofa.BackColor = System.Drawing.Color.Black
        Me.lightSofa.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light3
        Me.lightSofa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lightSofa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lightSofa.Location = New System.Drawing.Point(300, 381)
        Me.lightSofa.MinimumSize = New System.Drawing.Size(40, 40)
        Me.lightSofa.Name = "lightSofa"
        Me.lightSofa.Size = New System.Drawing.Size(50, 50)
        Me.lightSofa.TabIndex = 14
        Me.lightSofa.TabStop = False
        '
        'camSofa
        '
        Me.camSofa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.camSofa.BackColor = System.Drawing.Color.Black
        Me.camSofa.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.cam2
        Me.camSofa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.camSofa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.camSofa.Location = New System.Drawing.Point(187, 439)
        Me.camSofa.MinimumSize = New System.Drawing.Size(40, 40)
        Me.camSofa.Name = "camSofa"
        Me.camSofa.Size = New System.Drawing.Size(50, 50)
        Me.camSofa.TabIndex = 5
        Me.camSofa.TabStop = False
        '
        'balconyLock
        '
        Me.balconyLock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.balconyLock.BackColor = System.Drawing.Color.Black
        Me.balconyLock.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.lock2
        Me.balconyLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.balconyLock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.balconyLock.Location = New System.Drawing.Point(153, 342)
        Me.balconyLock.MinimumSize = New System.Drawing.Size(40, 40)
        Me.balconyLock.Name = "balconyLock"
        Me.balconyLock.Size = New System.Drawing.Size(50, 50)
        Me.balconyLock.TabIndex = 3
        Me.balconyLock.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.steel
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 79)
        Me.Panel3.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.homePanel)
        Me.Panel1.Controls.Add(Me.awayPanel)
        Me.Panel1.Controls.Add(Me.tvModePanel)
        Me.Panel1.Controls.Add(Me.sleepModePanel)
        Me.Panel1.Controls.Add(Me.favoritePanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(281, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 75)
        Me.Panel1.TabIndex = 2
        '
        'homePanel
        '
        Me.homePanel.BackColor = System.Drawing.Color.Transparent
        Me.homePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.homePanel.Controls.Add(Me.homeLbl)
        Me.homePanel.Controls.Add(Me.homePic)
        Me.homePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.homePanel.Location = New System.Drawing.Point(-2, 0)
        Me.homePanel.Name = "homePanel"
        Me.homePanel.Size = New System.Drawing.Size(100, 75)
        Me.homePanel.TabIndex = 14
        '
        'homeLbl
        '
        Me.homeLbl.BackColor = System.Drawing.Color.Transparent
        Me.homeLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.homeLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!, System.Drawing.FontStyle.Bold)
        Me.homeLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.homeLbl.Location = New System.Drawing.Point(0, 0)
        Me.homeLbl.Name = "homeLbl"
        Me.homeLbl.Size = New System.Drawing.Size(96, 23)
        Me.homeLbl.TabIndex = 50
        Me.homeLbl.Text = "AT HOME"
        Me.homeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'homePic
        '
        Me.homePic.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.home
        Me.homePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.homePic.Location = New System.Drawing.Point(20, 24)
        Me.homePic.Name = "homePic"
        Me.homePic.Size = New System.Drawing.Size(58, 50)
        Me.homePic.TabIndex = 51
        Me.homePic.TabStop = False
        '
        'awayPanel
        '
        Me.awayPanel.BackColor = System.Drawing.Color.Transparent
        Me.awayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.awayPanel.Controls.Add(Me.awayLbl)
        Me.awayPanel.Controls.Add(Me.awayPic)
        Me.awayPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.awayPanel.Location = New System.Drawing.Point(98, 0)
        Me.awayPanel.Name = "awayPanel"
        Me.awayPanel.Size = New System.Drawing.Size(100, 75)
        Me.awayPanel.TabIndex = 13
        '
        'awayLbl
        '
        Me.awayLbl.BackColor = System.Drawing.Color.Transparent
        Me.awayLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.awayLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!, System.Drawing.FontStyle.Bold)
        Me.awayLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.awayLbl.Location = New System.Drawing.Point(0, 0)
        Me.awayLbl.Name = "awayLbl"
        Me.awayLbl.Size = New System.Drawing.Size(96, 23)
        Me.awayLbl.TabIndex = 50
        Me.awayLbl.Text = "AWAY"
        Me.awayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'awayPic
        '
        Me.awayPic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.awayPic.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.away2
        Me.awayPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.awayPic.Location = New System.Drawing.Point(20, 23)
        Me.awayPic.Name = "awayPic"
        Me.awayPic.Size = New System.Drawing.Size(58, 50)
        Me.awayPic.TabIndex = 52
        Me.awayPic.TabStop = False
        '
        'tvModePanel
        '
        Me.tvModePanel.BackColor = System.Drawing.Color.Transparent
        Me.tvModePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tvModePanel.Controls.Add(Me.tvModePic)
        Me.tvModePanel.Controls.Add(Me.tvModeLbl)
        Me.tvModePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.tvModePanel.Location = New System.Drawing.Point(198, 0)
        Me.tvModePanel.Name = "tvModePanel"
        Me.tvModePanel.Size = New System.Drawing.Size(100, 75)
        Me.tvModePanel.TabIndex = 12
        '
        'tvModePic
        '
        Me.tvModePic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tvModePic.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.tvmode
        Me.tvModePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tvModePic.Location = New System.Drawing.Point(25, 25)
        Me.tvModePic.Name = "tvModePic"
        Me.tvModePic.Size = New System.Drawing.Size(43, 43)
        Me.tvModePic.TabIndex = 53
        Me.tvModePic.TabStop = False
        '
        'tvModeLbl
        '
        Me.tvModeLbl.AutoEllipsis = True
        Me.tvModeLbl.BackColor = System.Drawing.Color.Transparent
        Me.tvModeLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!, System.Drawing.FontStyle.Bold)
        Me.tvModeLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tvModeLbl.Location = New System.Drawing.Point(2, 2)
        Me.tvModeLbl.Name = "tvModeLbl"
        Me.tvModeLbl.Size = New System.Drawing.Size(98, 23)
        Me.tvModeLbl.TabIndex = 51
        Me.tvModeLbl.Text = "WATCH TV"
        Me.tvModeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sleepModePanel
        '
        Me.sleepModePanel.BackColor = System.Drawing.Color.Transparent
        Me.sleepModePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sleepModePanel.Controls.Add(Me.sleepModePic)
        Me.sleepModePanel.Controls.Add(Me.sleepModeLbl)
        Me.sleepModePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.sleepModePanel.Location = New System.Drawing.Point(298, 0)
        Me.sleepModePanel.Name = "sleepModePanel"
        Me.sleepModePanel.Size = New System.Drawing.Size(100, 75)
        Me.sleepModePanel.TabIndex = 11
        '
        'sleepModePic
        '
        Me.sleepModePic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sleepModePic.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.night
        Me.sleepModePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.sleepModePic.Location = New System.Drawing.Point(24, 26)
        Me.sleepModePic.Name = "sleepModePic"
        Me.sleepModePic.Size = New System.Drawing.Size(48, 48)
        Me.sleepModePic.TabIndex = 54
        Me.sleepModePic.TabStop = False
        '
        'sleepModeLbl
        '
        Me.sleepModeLbl.BackColor = System.Drawing.Color.Transparent
        Me.sleepModeLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.sleepModeLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!, System.Drawing.FontStyle.Bold)
        Me.sleepModeLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.sleepModeLbl.Location = New System.Drawing.Point(0, 0)
        Me.sleepModeLbl.Name = "sleepModeLbl"
        Me.sleepModeLbl.Size = New System.Drawing.Size(96, 23)
        Me.sleepModeLbl.TabIndex = 52
        Me.sleepModeLbl.Text = "SLEEP"
        Me.sleepModeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'favoritePanel
        '
        Me.favoritePanel.BackColor = System.Drawing.Color.Transparent
        Me.favoritePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.favoritePanel.Controls.Add(Me.favPanelPic)
        Me.favoritePanel.Controls.Add(Me.favPanelText)
        Me.favoritePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.favoritePanel.Location = New System.Drawing.Point(398, 0)
        Me.favoritePanel.Name = "favoritePanel"
        Me.favoritePanel.Size = New System.Drawing.Size(101, 75)
        Me.favoritePanel.TabIndex = 15
        Me.favoritePanel.Visible = False
        '
        'favPanelPic
        '
        Me.favPanelPic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.favPanelPic.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.favorites_icon_png_10
        Me.favPanelPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.favPanelPic.Location = New System.Drawing.Point(29, 24)
        Me.favPanelPic.Name = "favPanelPic"
        Me.favPanelPic.Size = New System.Drawing.Size(40, 44)
        Me.favPanelPic.TabIndex = 54
        Me.favPanelPic.TabStop = False
        '
        'favPanelText
        '
        Me.favPanelText.AutoEllipsis = True
        Me.favPanelText.BackColor = System.Drawing.Color.Transparent
        Me.favPanelText.Dock = System.Windows.Forms.DockStyle.Top
        Me.favPanelText.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!, System.Drawing.FontStyle.Bold)
        Me.favPanelText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.favPanelText.Location = New System.Drawing.Point(0, 0)
        Me.favPanelText.Name = "favPanelText"
        Me.favPanelText.Size = New System.Drawing.Size(97, 23)
        Me.favPanelText.TabIndex = 52
        Me.favPanelText.Text = "SLEEP"
        Me.favPanelText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMART HOME"
        '
        'kitchenAir
        '
        Me.kitchenAir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.kitchenAir.BackColor = System.Drawing.Color.Black
        Me.kitchenAir.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.air2
        Me.kitchenAir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.kitchenAir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.kitchenAir.Location = New System.Drawing.Point(595, 209)
        Me.kitchenAir.MinimumSize = New System.Drawing.Size(40, 40)
        Me.kitchenAir.Name = "kitchenAir"
        Me.kitchenAir.Size = New System.Drawing.Size(50, 50)
        Me.kitchenAir.TabIndex = 21
        Me.kitchenAir.TabStop = False
        '
        'tv
        '
        Me.tv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tv.BackColor = System.Drawing.Color.Black
        Me.tv.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.TV1
        Me.tv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tv.Location = New System.Drawing.Point(430, 381)
        Me.tv.MinimumSize = New System.Drawing.Size(40, 40)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(50, 50)
        Me.tv.TabIndex = 20
        Me.tv.TabStop = False
        '
        'outdoorLight
        '
        Me.outdoorLight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.outdoorLight.BackColor = System.Drawing.Color.Black
        Me.outdoorLight.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light3
        Me.outdoorLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.outdoorLight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outdoorLight.Location = New System.Drawing.Point(125, 245)
        Me.outdoorLight.MinimumSize = New System.Drawing.Size(40, 40)
        Me.outdoorLight.Name = "outdoorLight"
        Me.outdoorLight.Size = New System.Drawing.Size(50, 50)
        Me.outdoorLight.TabIndex = 19
        Me.outdoorLight.TabStop = False
        '
        'LightHall
        '
        Me.LightHall.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LightHall.BackColor = System.Drawing.Color.Black
        Me.LightHall.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light3
        Me.LightHall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LightHall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LightHall.Location = New System.Drawing.Point(577, 277)
        Me.LightHall.MinimumSize = New System.Drawing.Size(40, 40)
        Me.LightHall.Name = "LightHall"
        Me.LightHall.Size = New System.Drawing.Size(50, 50)
        Me.LightHall.TabIndex = 17
        Me.LightHall.TabStop = False
        '
        'lightBed2
        '
        Me.lightBed2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lightBed2.BackColor = System.Drawing.Color.Black
        Me.lightBed2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light3
        Me.lightBed2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lightBed2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lightBed2.Location = New System.Drawing.Point(638, 438)
        Me.lightBed2.MinimumSize = New System.Drawing.Size(40, 40)
        Me.lightBed2.Name = "lightBed2"
        Me.lightBed2.Size = New System.Drawing.Size(50, 50)
        Me.lightBed2.TabIndex = 16
        Me.lightBed2.TabStop = False
        '
        'LightBed1
        '
        Me.LightBed1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LightBed1.BackColor = System.Drawing.Color.Black
        Me.LightBed1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light3
        Me.LightBed1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LightBed1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LightBed1.Location = New System.Drawing.Point(499, 438)
        Me.LightBed1.MinimumSize = New System.Drawing.Size(40, 40)
        Me.LightBed1.Name = "LightBed1"
        Me.LightBed1.Size = New System.Drawing.Size(50, 50)
        Me.LightBed1.TabIndex = 15
        Me.LightBed1.TabStop = False
        '
        'lightKitchen
        '
        Me.lightKitchen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lightKitchen.BackColor = System.Drawing.Color.Black
        Me.lightKitchen.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light3
        Me.lightKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.lightKitchen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lightKitchen.Location = New System.Drawing.Point(346, 229)
        Me.lightKitchen.MinimumSize = New System.Drawing.Size(40, 40)
        Me.lightKitchen.Name = "lightKitchen"
        Me.lightKitchen.Size = New System.Drawing.Size(50, 50)
        Me.lightKitchen.TabIndex = 13
        Me.lightKitchen.TabStop = False
        '
        'diningLight
        '
        Me.diningLight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.diningLight.BackColor = System.Drawing.Color.Black
        Me.diningLight.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light3
        Me.diningLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.diningLight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.diningLight.Location = New System.Drawing.Point(229, 183)
        Me.diningLight.MinimumSize = New System.Drawing.Size(40, 40)
        Me.diningLight.Name = "diningLight"
        Me.diningLight.Size = New System.Drawing.Size(50, 50)
        Me.diningLight.TabIndex = 12
        Me.diningLight.TabStop = False
        '
        'dishwasher
        '
        Me.dishwasher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dishwasher.BackColor = System.Drawing.Color.Black
        Me.dishwasher.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.dish2
        Me.dishwasher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dishwasher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dishwasher.Location = New System.Drawing.Point(419, 181)
        Me.dishwasher.MinimumSize = New System.Drawing.Size(40, 40)
        Me.dishwasher.Name = "dishwasher"
        Me.dishwasher.Size = New System.Drawing.Size(50, 50)
        Me.dishwasher.TabIndex = 11
        Me.dishwasher.TabStop = False
        '
        'fireAlarmBed
        '
        Me.fireAlarmBed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fireAlarmBed.BackColor = System.Drawing.Color.Black
        Me.fireAlarmBed.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.alarm1
        Me.fireAlarmBed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fireAlarmBed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fireAlarmBed.Location = New System.Drawing.Point(631, 346)
        Me.fireAlarmBed.MinimumSize = New System.Drawing.Size(40, 40)
        Me.fireAlarmBed.Name = "fireAlarmBed"
        Me.fireAlarmBed.Size = New System.Drawing.Size(50, 50)
        Me.fireAlarmBed.TabIndex = 10
        Me.fireAlarmBed.TabStop = False
        '
        'fireAlarmSofa
        '
        Me.fireAlarmSofa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fireAlarmSofa.BackColor = System.Drawing.Color.Black
        Me.fireAlarmSofa.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.alarm1
        Me.fireAlarmSofa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fireAlarmSofa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fireAlarmSofa.Location = New System.Drawing.Point(354, 309)
        Me.fireAlarmSofa.MinimumSize = New System.Drawing.Size(40, 40)
        Me.fireAlarmSofa.Name = "fireAlarmSofa"
        Me.fireAlarmSofa.Size = New System.Drawing.Size(50, 50)
        Me.fireAlarmSofa.TabIndex = 9
        Me.fireAlarmSofa.TabStop = False
        '
        'washingMachine
        '
        Me.washingMachine.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.washingMachine.BackColor = System.Drawing.Color.Black
        Me.washingMachine.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.wash
        Me.washingMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.washingMachine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.washingMachine.Location = New System.Drawing.Point(543, 105)
        Me.washingMachine.MinimumSize = New System.Drawing.Size(40, 40)
        Me.washingMachine.Name = "washingMachine"
        Me.washingMachine.Size = New System.Drawing.Size(50, 50)
        Me.washingMachine.TabIndex = 8
        Me.washingMachine.TabStop = False
        '
        'oven
        '
        Me.oven.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.oven.BackColor = System.Drawing.Color.Black
        Me.oven.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.oven11
        Me.oven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.oven.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.oven.Location = New System.Drawing.Point(382, 105)
        Me.oven.MinimumSize = New System.Drawing.Size(40, 40)
        Me.oven.Name = "oven"
        Me.oven.Size = New System.Drawing.Size(50, 50)
        Me.oven.TabIndex = 7
        Me.oven.TabStop = False
        '
        'fridge
        '
        Me.fridge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fridge.BackColor = System.Drawing.Color.Black
        Me.fridge.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fridge2
        Me.fridge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.fridge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fridge.Location = New System.Drawing.Point(326, 105)
        Me.fridge.MinimumSize = New System.Drawing.Size(40, 40)
        Me.fridge.Name = "fridge"
        Me.fridge.Size = New System.Drawing.Size(50, 50)
        Me.fridge.TabIndex = 6
        Me.fridge.TabStop = False
        '
        'CamHall
        '
        Me.CamHall.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CamHall.BackColor = System.Drawing.Color.Black
        Me.CamHall.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.cam2
        Me.CamHall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CamHall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CamHall.Location = New System.Drawing.Point(481, 260)
        Me.CamHall.MinimumSize = New System.Drawing.Size(40, 40)
        Me.CamHall.Name = "CamHall"
        Me.CamHall.Size = New System.Drawing.Size(50, 50)
        Me.CamHall.TabIndex = 4
        Me.CamHall.TabStop = False
        '
        'LockFrontDoor
        '
        Me.LockFrontDoor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LockFrontDoor.BackColor = System.Drawing.Color.Black
        Me.LockFrontDoor.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.lock2
        Me.LockFrontDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LockFrontDoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LockFrontDoor.Location = New System.Drawing.Point(638, 277)
        Me.LockFrontDoor.MinimumSize = New System.Drawing.Size(40, 40)
        Me.LockFrontDoor.Name = "LockFrontDoor"
        Me.LockFrontDoor.Size = New System.Drawing.Size(50, 50)
        Me.LockFrontDoor.TabIndex = 2
        Me.LockFrontDoor.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.floorplan1trans
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-12, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(816, 507)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'StartWindow
        '
        Me.StartWindow.BackColor = System.Drawing.Color.Transparent
        Me.StartWindow.BackgroundImage = CType(resources.GetObject("StartWindow.BackgroundImage"), System.Drawing.Image)
        Me.StartWindow.Controls.Add(Me.HelpPanel)
        Me.StartWindow.Controls.Add(Me.Label3)
        Me.StartWindow.Controls.Add(Me.TextBox8)
        Me.StartWindow.Controls.Add(Me.Label31)
        Me.StartWindow.Controls.Add(Me.TextBox5)
        Me.StartWindow.Controls.Add(Me.Label32)
        Me.StartWindow.Controls.Add(Me.TextBox6)
        Me.StartWindow.Controls.Add(Me.Label33)
        Me.StartWindow.Controls.Add(Me.ComboBox3)
        Me.StartWindow.Controls.Add(Me.Label34)
        Me.StartWindow.Controls.Add(Me.Button4)
        Me.StartWindow.Controls.Add(Me.ComboBox4)
        Me.StartWindow.Controls.Add(Me.Label35)
        Me.StartWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartWindow.Location = New System.Drawing.Point(0, 0)
        Me.StartWindow.Name = "StartWindow"
        Me.StartWindow.Size = New System.Drawing.Size(784, 562)
        Me.StartWindow.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(191, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Password Again"
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox8.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(355, 338)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox8.Size = New System.Drawing.Size(161, 29)
        Me.TextBox8.TabIndex = 52
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(205, 305)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(107, 23)
        Me.Label31.TabIndex = 51
        Me.Label31.Text = "Set Password"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(355, 300)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox5.Size = New System.Drawing.Size(161, 29)
        Me.TextBox5.TabIndex = 50
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(191, 268)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(128, 23)
        Me.Label32.TabIndex = 49
        Me.Label32.Text = "Activation Code"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(355, 262)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(161, 29)
        Me.TextBox6.TabIndex = 48
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(219, 68)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(315, 30)
        Me.Label33.TabIndex = 47
        Me.Label33.Text = "Welcome to SmartHome 2000"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Celsius", "Fahrenheit"})
        Me.ComboBox3.Location = New System.Drawing.Point(355, 199)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(161, 29)
        Me.ComboBox3.TabIndex = 46
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(185, 205)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(137, 23)
        Me.Label34.TabIndex = 43
        Me.Label34.Text = "Temperature Unit"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.BackColor = System.Drawing.Color.OliveDrab
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.25!)
        Me.Button4.Location = New System.Drawing.Point(318, 411)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 39)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"English", "svenska", "suomi"})
        Me.ComboBox4.Location = New System.Drawing.Point(355, 161)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(161, 29)
        Me.ComboBox4.TabIndex = 37
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(235, 161)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(83, 23)
        Me.Label35.TabIndex = 34
        Me.Label35.Text = "Language"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(131, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 30)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Fridge and Freezer"
        '
        'HelpButton
        '
        Me.HelpButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpButton.BackColor = System.Drawing.Color.DimGray
        Me.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HelpButton.Font = New System.Drawing.Font("Segoe UI Semilight", 25.75!, System.Drawing.FontStyle.Bold)
        Me.HelpButton.ForeColor = System.Drawing.Color.White
        Me.HelpButton.Location = New System.Drawing.Point(709, 100)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(60, 54)
        Me.HelpButton.TabIndex = 66
        Me.HelpButton.Text = "?"
        Me.HelpButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(181, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 23)
        Me.Label5.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(239, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 23)
        Me.Label7.TabIndex = 49
        '
        'Label49
        '
        Me.Label49.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label49.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(35, 87)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(717, 373)
        Me.Label49.TabIndex = 43
        Me.Label49.Text = resources.GetString("Label49.Text")
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HelpOKBtn
        '
        Me.HelpOKBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HelpOKBtn.BackColor = System.Drawing.Color.OliveDrab
        Me.HelpOKBtn.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.HelpOKBtn.Location = New System.Drawing.Point(332, 484)
        Me.HelpOKBtn.Name = "HelpOKBtn"
        Me.HelpOKBtn.Size = New System.Drawing.Size(113, 35)
        Me.HelpOKBtn.TabIndex = 41
        Me.HelpOKBtn.Text = "OK"
        Me.HelpOKBtn.UseVisualStyleBackColor = False
        '
        'HelpPanel
        '
        Me.HelpPanel.BackColor = System.Drawing.Color.Transparent
        Me.HelpPanel.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.brushed_metal_background_1514
        Me.HelpPanel.Controls.Add(Me.Label49)
        Me.HelpPanel.Controls.Add(Me.HelpOKBtn)
        Me.HelpPanel.Controls.Add(Me.Label7)
        Me.HelpPanel.Controls.Add(Me.Label5)
        Me.HelpPanel.Controls.Add(Me.Label53)
        Me.HelpPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpPanel.Location = New System.Drawing.Point(0, 0)
        Me.HelpPanel.Name = "HelpPanel"
        Me.HelpPanel.Size = New System.Drawing.Size(784, 562)
        Me.HelpPanel.TabIndex = 53
        Me.HelpPanel.Visible = False
        '
        'Label53
        '
        Me.Label53.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(240, 39)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(310, 30)
        Me.Label53.TabIndex = 47
        Me.Label53.Text = "How to use SmartHome 2000"
        '
        'SmartHomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.StartWindow)
        Me.Controls.Add(Me.Panel2)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "SmartHomeForm"
        Me.Text = "SmartHome 2000"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PopUpWindowPanel.ResumeLayout(False)
        Me.EmergencyReverse.ResumeLayout(False)
        Me.EmergencyReverse.PerformLayout()
        Me.favConfWindow.ResumeLayout(False)
        Me.favConfWindow.PerformLayout()
        Me.addFavoriteWindow.ResumeLayout(False)
        Me.addFavoriteWindow.PerformLayout()
        Me.EmergencyConfirmationWindow.ResumeLayout(False)
        Me.EmergencyConfirmationWindow.PerformLayout()
        Me.EmergencyWindow.ResumeLayout(False)
        Me.EmergencyWindow.PerformLayout()
        Me.settingsWindow.ResumeLayout(False)
        Me.settingsWindow.PerformLayout()
        Me.fridgeWindow.ResumeLayout(False)
        Me.fridgeWindow.PerformLayout()
        Me.SmokeAlarmWindow.ResumeLayout(False)
        Me.SmokeAlarmWindow.PerformLayout()
        Me.AlarmWindow.ResumeLayout(False)
        Me.AlarmWindow.PerformLayout()
        Me.ovenWindow.ResumeLayout(False)
        Me.ovenWindow.PerformLayout()
        Me.washWindow.ResumeLayout(False)
        Me.washWindow.PerformLayout()
        Me.dishWindow.ResumeLayout(False)
        Me.dishWindow.PerformLayout()
        Me.airWindow.ResumeLayout(False)
        Me.airWindow.PerformLayout()
        Me.tvWindow.ResumeLayout(False)
        Me.tvWindow.PerformLayout()
        CType(Me.volumeBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightBath, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomPanel.PerformLayout()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FavoriteIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightSofa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.camSofa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.balconyLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.homePanel.ResumeLayout(False)
        CType(Me.homePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.awayPanel.ResumeLayout(False)
        CType(Me.awayPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tvModePanel.ResumeLayout(False)
        CType(Me.tvModePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sleepModePanel.ResumeLayout(False)
        CType(Me.sleepModePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.favoritePanel.ResumeLayout(False)
        CType(Me.favPanelPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kitchenAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.outdoorLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LightHall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightBed2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LightBed1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightKitchen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diningLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dishwasher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fireAlarmBed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fireAlarmSofa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.washingMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fridge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CamHall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LockFrontDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StartWindow.ResumeLayout(False)
        Me.StartWindow.PerformLayout()
        Me.HelpPanel.ResumeLayout(False)
        Me.HelpPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LockFrontDoor As PictureBox
    Friend WithEvents CamHall As PictureBox
    Friend WithEvents balconyLock As PictureBox
    Friend WithEvents fridge As PictureBox
    Friend WithEvents camSofa As PictureBox
    Friend WithEvents oven As PictureBox
    Friend WithEvents washingMachine As PictureBox
    Friend WithEvents fireAlarmSofa As PictureBox
    Friend WithEvents dishwasher As PictureBox
    Friend WithEvents fireAlarmBed As PictureBox
    Friend WithEvents diningLight As PictureBox
    Friend WithEvents outdoorLight As PictureBox
    Friend WithEvents lightBath As PictureBox
    Friend WithEvents LightHall As PictureBox
    Friend WithEvents lightBed2 As PictureBox
    Friend WithEvents LightBed1 As PictureBox
    Friend WithEvents lightSofa As PictureBox
    Friend WithEvents lightKitchen As PictureBox
    Friend WithEvents tv As PictureBox
    Friend WithEvents kitchenAir As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Settings As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents favoritesLbl As Label
    Friend WithEvents FavoriteIcon As PictureBox
    Friend WithEvents SettingsLabel As Label
    Friend WithEvents washWindow As Panel
    Friend WithEvents washCancelBtn As Button
    Friend WithEvents WashSaveBtn As Button
    Friend WithEvents washTimeLbl As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents washCombobox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents airKitchenLbl As Label
    Friend WithEvents airWindow As Panel
    Friend WithEvents airCancelBtn As Button
    Friend WithEvents airSaveBtn As Button
    Friend WithEvents temperatureCombobox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents balconyLockLbl As Label
    Friend WithEvents frontLockLbl As Label
    Friend WithEvents dishLbl As Label
    Friend WithEvents OvenLbl As Label
    Friend WithEvents tvLbl As Label
    Friend WithEvents washLbl As Label
    Friend WithEvents tvWindow As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents tvOffBtn As Button
    Friend WithEvents tvSaveBtn As Button
    Friend WithEvents TVComboBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents volumeBar As TrackBar
    Friend WithEvents tvCancelBtn As Button
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents washOffBtn As Button
    Friend WithEvents airOffBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PopUpWindowPanel As Panel
    Friend WithEvents fridgeLbl As Label
    Friend WithEvents dishWindow As Panel
    Friend WithEvents dishOffBtn As Button
    Friend WithEvents dishCancelBtn As Button
    Friend WithEvents dishSaveBtn As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dishCombobox As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ovenWindow As Panel
    Friend WithEvents ovenOffBtn As Button
    Friend WithEvents ovenCancelBtn As Button
    Friend WithEvents ovenSaveBtn As Button
    Friend WithEvents ovenCombobox As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents fridgeWindow As Panel
    Friend WithEvents freezerCombobox As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents fridgeOffBtn As Button
    Friend WithEvents fridgeCancelBtn As Button
    Friend WithEvents fridgeSaveBtn As Button
    Friend WithEvents fridgeCombobox As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents settingsWindow As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents settingsCancelBtn As Button
    Friend WithEvents settingsSaveBtn As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents StartWindow As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label35 As Label
    Friend WithEvents bathLightLbl As Label
    Friend WithEvents hallCamLbl As Label
    Friend WithEvents bedAlarmLbl As Label
    Friend WithEvents bedlight2Lbl As Label
    Friend WithEvents bedlight1Lbl As Label
    Friend WithEvents alarmSofaLbl As Label
    Friend WithEvents outLightLbl As Label
    Friend WithEvents sofaCamLbl As Label
    Friend WithEvents sofaLightLbl As Label
    Friend WithEvents kitchenLightLbl As Label
    Friend WithEvents diningLightLbl As Label
    Friend WithEvents Emergency As Button
    Friend WithEvents hallLightLbl As Label
    Friend WithEvents EmergencyWindow As Panel
    Friend WithEvents emergencyWindowTitle As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label40 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents EmergencyConfirmationWindow As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents EmergencyLbl As Label
    Friend WithEvents EmergencyReverse As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ReverseAlarmBtn As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents addFavoriteWindow As Panel
    Friend WithEvents cancelAddFavBtn As Button
    Friend WithEvents Label43 As Label
    Friend WithEvents FavNameTextbox As TextBox
    Friend WithEvents saveFavBtn As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents favConfWindow As Panel
    Friend WithEvents favConfOKbtn As Button
    Friend WithEvents favoriteconflbl As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents SmokeAlarmWindow As Panel
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents AlarmWindow As Panel
    Friend WithEvents Button13 As Button
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents homePanel As Panel
    Friend WithEvents homeLbl As Label
    Friend WithEvents homePic As PictureBox
    Friend WithEvents awayPanel As Panel
    Friend WithEvents awayPic As PictureBox
    Friend WithEvents awayLbl As Label
    Friend WithEvents tvModePanel As Panel
    Friend WithEvents tvModeLbl As Label
    Friend WithEvents sleepModePanel As Panel
    Friend WithEvents sleepModeLbl As Label
    Friend WithEvents tvModePic As PictureBox
    Friend WithEvents sleepModePic As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents favoritePanel As Panel
    Friend WithEvents favPanelPic As PictureBox
    Friend WithEvents favPanelText As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HelpButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents HelpOKBtn As Button
    Friend WithEvents HelpPanel As Panel
    Friend WithEvents Label53 As Label
End Class
