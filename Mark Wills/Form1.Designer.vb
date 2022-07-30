Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.panel_NavBar = New System.Windows.Forms.Panel()
        Me.but_HomeScreen = New System.Windows.Forms.PictureBox()
        Me.but_Settings = New System.Windows.Forms.PictureBox()
        Me.label_Mansion = New System.Windows.Forms.Label()
        Me.but_Forward = New System.Windows.Forms.PictureBox()
        Me.but_back = New System.Windows.Forms.PictureBox()
        Me.label_Fullbath_1 = New System.Windows.Forms.Label()
        Me.label_Kitchen_1 = New System.Windows.Forms.Label()
        Me.label_l1b1 = New System.Windows.Forms.Label()
        Me.Label_l1b2 = New System.Windows.Forms.Label()
        Me.Label_l1b6 = New System.Windows.Forms.Label()
        Me.Label_l1b5 = New System.Windows.Forms.Label()
        Me.Label_l1b4 = New System.Windows.Forms.Label()
        Me.Label_l1b3 = New System.Windows.Forms.Label()
        Me.label_Foyer = New System.Windows.Forms.Label()
        Me.panel_Floor1 = New System.Windows.Forms.Panel()
        Me.pic_Floor1 = New System.Windows.Forms.PictureBox()
        Me.panel_Floor2 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_l2b2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_l2b5 = New System.Windows.Forms.Label()
        Me.Label_l2b4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label_l2b3 = New System.Windows.Forms.Label()
        Me.label_l2E = New System.Windows.Forms.Label()
        Me.Label_l2b6 = New System.Windows.Forms.Label()
        Me.Label_l2b1 = New System.Windows.Forms.Label()
        Me.Label_l2b7 = New System.Windows.Forms.Label()
        Me.pic_Floor2 = New System.Windows.Forms.PictureBox()
        Me.panel_Floor3 = New System.Windows.Forms.Panel()
        Me.label_l3E2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label_l3b2 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label_l3b5 = New System.Windows.Forms.Label()
        Me.Label_l3b4 = New System.Windows.Forms.Label()
        Me.label_l3E1 = New System.Windows.Forms.Label()
        Me.Label_l3b3 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label_l3b6 = New System.Windows.Forms.Label()
        Me.Label_l3b1 = New System.Windows.Forms.Label()
        Me.Label_l3b7 = New System.Windows.Forms.Label()
        Me.pic_Floor3 = New System.Windows.Forms.PictureBox()
        Me.panel_bottombar = New System.Windows.Forms.Panel()
        Me.but_Load = New System.Windows.Forms.PictureBox()
        Me.but_Save = New System.Windows.Forms.PictureBox()
        Me.label_Floor3 = New System.Windows.Forms.Label()
        Me.label_Floor2 = New System.Windows.Forms.Label()
        Me.label_floor1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.but_Mansion = New System.Windows.Forms.PictureBox()
        Me.pic_Map = New System.Windows.Forms.PictureBox()
        Me.but_translate = New System.Windows.Forms.PictureBox()
        Me.but_Map = New System.Windows.Forms.PictureBox()
        Me.but_Universe = New System.Windows.Forms.PictureBox()
        Me.but_HomeScreen2 = New System.Windows.Forms.PictureBox()
        Me.but_MapForward = New System.Windows.Forms.PictureBox()
        Me.but_MapBack = New System.Windows.Forms.PictureBox()
        Me.but_HomeScreen3 = New System.Windows.Forms.PictureBox()
        Me.but_ForwardHeroes = New System.Windows.Forms.PictureBox()
        Me.but_backHeroes = New System.Windows.Forms.PictureBox()
        Me.panel_Mansion = New System.Windows.Forms.Panel()
        Me.panel_MainScreen = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.label_themansion = New Mark_Wills.RichLabel()
        Me.label_map = New Mark_Wills.RichLabel()
        Me.label_rextonian = New Mark_Wills.RichLabel()
        Me.RichLabel1 = New Mark_Wills.RichLabel()
        Me.pic_Heroes = New System.Windows.Forms.PictureBox()
        Me.label_LockApp = New Mark_Wills.RichLabel()
        Me.label_TheHeroes = New Mark_Wills.RichLabel()
        Me.panel_Map = New System.Windows.Forms.Panel()
        Me.browser_Map = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_Spoilers = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.label_Warning = New Mark_Wills.RichLabel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.but_Yes = New DevExpress.XtraEditors.SimpleButton()
        Me.but_No = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_Heroes = New System.Windows.Forms.Panel()
        Me.layout_Heroes = New System.Windows.Forms.TableLayoutPanel()
        Me.RichLabel12 = New Mark_Wills.RichLabel()
        Me.pic_AngelIcon = New System.Windows.Forms.PictureBox()
        Me.pic_PsychIcon = New System.Windows.Forms.PictureBox()
        Me.pic_AvianIcon = New System.Windows.Forms.PictureBox()
        Me.RichLabel6 = New Mark_Wills.RichLabel()
        Me.RichLabel11 = New Mark_Wills.RichLabel()
        Me.RichLabel7 = New Mark_Wills.RichLabel()
        Me.RichLabel9 = New Mark_Wills.RichLabel()
        Me.RichLabel8 = New Mark_Wills.RichLabel()
        Me.pic_ShiftIcon = New System.Windows.Forms.PictureBox()
        Me.pic_SwiftIcon = New System.Windows.Forms.PictureBox()
        Me.pic_WhirlwindIcon = New System.Windows.Forms.PictureBox()
        Me.RichLabel10 = New Mark_Wills.RichLabel()
        Me.RichLabel13 = New Mark_Wills.RichLabel()
        Me.RichLabel14 = New Mark_Wills.RichLabel()
        Me.pic_VortexIcon = New System.Windows.Forms.PictureBox()
        Me.pic_TykeIcon = New System.Windows.Forms.PictureBox()
        Me.pic_BoltIcon = New System.Windows.Forms.PictureBox()
        Me.panel_HeroesBar = New System.Windows.Forms.Panel()
        Me.panel_Avian = New System.Windows.Forms.Panel()
        Me.label_Avian = New Mark_Wills.RichLabel()
        Me.RichLabel16 = New Mark_Wills.RichLabel()
        Me.pic_Avian = New System.Windows.Forms.PictureBox()
        Me.panel_Psych = New System.Windows.Forms.Panel()
        Me.panel_Angel = New System.Windows.Forms.Panel()
        Me.RichLabel20 = New Mark_Wills.RichLabel()
        Me.RichLabel21 = New Mark_Wills.RichLabel()
        Me.pic_Angel = New System.Windows.Forms.PictureBox()
        Me.panel_Vortex = New System.Windows.Forms.Panel()
        Me.RichLabel22 = New Mark_Wills.RichLabel()
        Me.RichLabel23 = New Mark_Wills.RichLabel()
        Me.pic_Vortex = New System.Windows.Forms.PictureBox()
        Me.panel_Whirlwind = New System.Windows.Forms.Panel()
        Me.RichLabel24 = New Mark_Wills.RichLabel()
        Me.RichLabel25 = New Mark_Wills.RichLabel()
        Me.pic_Whirlwind = New System.Windows.Forms.PictureBox()
        Me.panel_Swift = New System.Windows.Forms.Panel()
        Me.RichLabel26 = New Mark_Wills.RichLabel()
        Me.RichLabel27 = New Mark_Wills.RichLabel()
        Me.pic_Swift = New System.Windows.Forms.PictureBox()
        Me.panel_Shift = New System.Windows.Forms.Panel()
        Me.RichLabel28 = New Mark_Wills.RichLabel()
        Me.RichLabel29 = New Mark_Wills.RichLabel()
        Me.pic_Shift = New System.Windows.Forms.PictureBox()
        Me.panel_Tyke = New System.Windows.Forms.Panel()
        Me.RichLabel30 = New Mark_Wills.RichLabel()
        Me.RichLabel31 = New Mark_Wills.RichLabel()
        Me.pic_Tyke = New System.Windows.Forms.PictureBox()
        Me.panel_Bolt = New System.Windows.Forms.Panel()
        Me.RichLabel32 = New Mark_Wills.RichLabel()
        Me.RichLabel33 = New Mark_Wills.RichLabel()
        Me.pic_Bolt = New System.Windows.Forms.PictureBox()
        Me.RichLabel18 = New Mark_Wills.RichLabel()
        Me.RichLabel19 = New Mark_Wills.RichLabel()
        Me.pic_Psych = New System.Windows.Forms.PictureBox()
        Me.pic_Preview = New System.Windows.Forms.PictureBox()
        Me.panel_NavBar.SuspendLayout()
        CType(Me.but_HomeScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_Forward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Floor1.SuspendLayout()
        CType(Me.pic_Floor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Floor2.SuspendLayout()
        CType(Me.pic_Floor2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Floor3.SuspendLayout()
        CType(Me.pic_Floor3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_bottombar.SuspendLayout()
        CType(Me.but_Load, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_Mansion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Map, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_translate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_Map, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_Universe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_HomeScreen2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_MapForward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_MapBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_HomeScreen3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_ForwardHeroes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_backHeroes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_MainScreen.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pic_Heroes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Map.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panel_Spoilers.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.panel_Heroes.SuspendLayout()
        Me.layout_Heroes.SuspendLayout()
        CType(Me.pic_AngelIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_PsychIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_AvianIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_ShiftIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_SwiftIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_WhirlwindIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_VortexIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_TykeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_BoltIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_HeroesBar.SuspendLayout()
        Me.panel_Avian.SuspendLayout()
        CType(Me.pic_Avian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Psych.SuspendLayout()
        Me.panel_Angel.SuspendLayout()
        CType(Me.pic_Angel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Vortex.SuspendLayout()
        CType(Me.pic_Vortex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Whirlwind.SuspendLayout()
        CType(Me.pic_Whirlwind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Swift.SuspendLayout()
        CType(Me.pic_Swift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Shift.SuspendLayout()
        CType(Me.pic_Shift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Tyke.SuspendLayout()
        CType(Me.pic_Tyke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Bolt.SuspendLayout()
        CType(Me.pic_Bolt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Psych, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style"
        '
        'panel_NavBar
        '
        Me.panel_NavBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.panel_NavBar.Controls.Add(Me.but_HomeScreen)
        Me.panel_NavBar.Controls.Add(Me.but_Settings)
        Me.panel_NavBar.Controls.Add(Me.label_Mansion)
        Me.panel_NavBar.Controls.Add(Me.but_Forward)
        Me.panel_NavBar.Controls.Add(Me.but_back)
        Me.panel_NavBar.Location = New System.Drawing.Point(0, 0)
        Me.panel_NavBar.Name = "panel_NavBar"
        Me.panel_NavBar.Size = New System.Drawing.Size(582, 44)
        Me.panel_NavBar.TabIndex = 1
        '
        'but_HomeScreen
        '
        Me.but_HomeScreen.BackColor = System.Drawing.Color.Transparent
        Me.but_HomeScreen.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.icons8_home_512_small
        Me.but_HomeScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_HomeScreen.Location = New System.Drawing.Point(12, 9)
        Me.but_HomeScreen.Name = "but_HomeScreen"
        Me.but_HomeScreen.Size = New System.Drawing.Size(25, 25)
        Me.but_HomeScreen.TabIndex = 4
        Me.but_HomeScreen.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_HomeScreen, "Back to Main Screen")
        '
        'but_Settings
        '
        Me.but_Settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Settings.BackColor = System.Drawing.Color.Transparent
        Me.but_Settings.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.settings_96px
        Me.but_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Settings.Location = New System.Drawing.Point(545, 9)
        Me.but_Settings.Name = "but_Settings"
        Me.but_Settings.Size = New System.Drawing.Size(25, 25)
        Me.but_Settings.TabIndex = 3
        Me.but_Settings.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_Settings, "Settings")
        '
        'label_Mansion
        '
        Me.label_Mansion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_Mansion.AutoSize = True
        Me.label_Mansion.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Mansion.ForeColor = System.Drawing.Color.Silver
        Me.label_Mansion.Location = New System.Drawing.Point(228, 10)
        Me.label_Mansion.Name = "label_Mansion"
        Me.label_Mansion.Size = New System.Drawing.Size(126, 25)
        Me.label_Mansion.TabIndex = 2
        Me.label_Mansion.Text = "The Mansion"
        '
        'but_Forward
        '
        Me.but_Forward.BackColor = System.Drawing.Color.Transparent
        Me.but_Forward.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.SwitchForward
        Me.but_Forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Forward.Location = New System.Drawing.Point(74, 9)
        Me.but_Forward.Name = "but_Forward"
        Me.but_Forward.Size = New System.Drawing.Size(25, 25)
        Me.but_Forward.TabIndex = 1
        Me.but_Forward.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_Forward, "Increase Floor Level")
        '
        'but_back
        '
        Me.but_back.BackColor = System.Drawing.Color.Transparent
        Me.but_back.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.SwitchBack
        Me.but_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_back.Location = New System.Drawing.Point(43, 9)
        Me.but_back.Name = "but_back"
        Me.but_back.Size = New System.Drawing.Size(25, 25)
        Me.but_back.TabIndex = 0
        Me.but_back.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_back, "Decrease Floor Level")
        '
        'label_Fullbath_1
        '
        Me.label_Fullbath_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_Fullbath_1.AutoSize = True
        Me.label_Fullbath_1.BackColor = System.Drawing.Color.Transparent
        Me.label_Fullbath_1.Location = New System.Drawing.Point(50, 63)
        Me.label_Fullbath_1.Name = "label_Fullbath_1"
        Me.label_Fullbath_1.Size = New System.Drawing.Size(70, 21)
        Me.label_Fullbath_1.TabIndex = 2
        Me.label_Fullbath_1.Text = "Full Bath"
        Me.label_Fullbath_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_Kitchen_1
        '
        Me.label_Kitchen_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_Kitchen_1.AutoSize = True
        Me.label_Kitchen_1.BackColor = System.Drawing.Color.Transparent
        Me.label_Kitchen_1.Location = New System.Drawing.Point(159, 63)
        Me.label_Kitchen_1.Name = "label_Kitchen_1"
        Me.label_Kitchen_1.Size = New System.Drawing.Size(174, 21)
        Me.label_Kitchen_1.TabIndex = 2
        Me.label_Kitchen_1.Text = "Dining Room && Kitchen"
        Me.label_Kitchen_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_l1b1
        '
        Me.label_l1b1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_l1b1.AutoSize = True
        Me.label_l1b1.BackColor = System.Drawing.Color.Transparent
        Me.label_l1b1.Location = New System.Drawing.Point(376, 63)
        Me.label_l1b1.Name = "label_l1b1"
        Me.label_l1b1.Size = New System.Drawing.Size(74, 21)
        Me.label_l1b1.TabIndex = 2
        Me.label_l1b1.Text = "Bedroom"
        Me.label_l1b1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l1b2
        '
        Me.Label_l1b2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l1b2.AutoSize = True
        Me.Label_l1b2.BackColor = System.Drawing.Color.Transparent
        Me.Label_l1b2.Location = New System.Drawing.Point(459, 63)
        Me.Label_l1b2.Name = "Label_l1b2"
        Me.Label_l1b2.Size = New System.Drawing.Size(74, 21)
        Me.Label_l1b2.TabIndex = 2
        Me.Label_l1b2.Text = "Bedroom"
        Me.Label_l1b2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l1b6
        '
        Me.Label_l1b6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l1b6.AutoSize = True
        Me.Label_l1b6.BackColor = System.Drawing.Color.Transparent
        Me.Label_l1b6.Location = New System.Drawing.Point(459, 246)
        Me.Label_l1b6.Name = "Label_l1b6"
        Me.Label_l1b6.Size = New System.Drawing.Size(74, 21)
        Me.Label_l1b6.TabIndex = 2
        Me.Label_l1b6.Text = "Bedroom"
        Me.Label_l1b6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l1b5
        '
        Me.Label_l1b5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l1b5.AutoSize = True
        Me.Label_l1b5.BackColor = System.Drawing.Color.Transparent
        Me.Label_l1b5.Location = New System.Drawing.Point(376, 246)
        Me.Label_l1b5.Name = "Label_l1b5"
        Me.Label_l1b5.Size = New System.Drawing.Size(74, 21)
        Me.Label_l1b5.TabIndex = 2
        Me.Label_l1b5.Text = "Bedroom"
        Me.Label_l1b5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l1b4
        '
        Me.Label_l1b4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l1b4.AutoSize = True
        Me.Label_l1b4.BackColor = System.Drawing.Color.Transparent
        Me.Label_l1b4.Location = New System.Drawing.Point(132, 246)
        Me.Label_l1b4.Name = "Label_l1b4"
        Me.Label_l1b4.Size = New System.Drawing.Size(74, 21)
        Me.Label_l1b4.TabIndex = 2
        Me.Label_l1b4.Text = "Bedroom"
        Me.Label_l1b4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l1b3
        '
        Me.Label_l1b3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l1b3.AutoSize = True
        Me.Label_l1b3.BackColor = System.Drawing.Color.Transparent
        Me.Label_l1b3.Location = New System.Drawing.Point(48, 246)
        Me.Label_l1b3.Name = "Label_l1b3"
        Me.Label_l1b3.Size = New System.Drawing.Size(74, 21)
        Me.Label_l1b3.TabIndex = 2
        Me.Label_l1b3.Text = "Bedroom"
        Me.Label_l1b3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_Foyer
        '
        Me.label_Foyer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_Foyer.AutoSize = True
        Me.label_Foyer.BackColor = System.Drawing.Color.Transparent
        Me.label_Foyer.Location = New System.Drawing.Point(263, 246)
        Me.label_Foyer.Name = "label_Foyer"
        Me.label_Foyer.Size = New System.Drawing.Size(49, 21)
        Me.label_Foyer.TabIndex = 2
        Me.label_Foyer.Text = "Foyer"
        Me.label_Foyer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_Floor1
        '
        Me.panel_Floor1.Controls.Add(Me.Label_l1b2)
        Me.panel_Floor1.Controls.Add(Me.Label_l1b3)
        Me.panel_Floor1.Controls.Add(Me.label_Fullbath_1)
        Me.panel_Floor1.Controls.Add(Me.label_Foyer)
        Me.panel_Floor1.Controls.Add(Me.label_Kitchen_1)
        Me.panel_Floor1.Controls.Add(Me.Label_l1b4)
        Me.panel_Floor1.Controls.Add(Me.label_l1b1)
        Me.panel_Floor1.Controls.Add(Me.Label_l1b5)
        Me.panel_Floor1.Controls.Add(Me.Label_l1b6)
        Me.panel_Floor1.Controls.Add(Me.pic_Floor1)
        Me.panel_Floor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Floor1.Location = New System.Drawing.Point(0, 0)
        Me.panel_Floor1.Name = "panel_Floor1"
        Me.panel_Floor1.Size = New System.Drawing.Size(582, 388)
        Me.panel_Floor1.TabIndex = 3
        '
        'pic_Floor1
        '
        Me.pic_Floor1.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.The_Mansion_Floor_1_base
        Me.pic_Floor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Floor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_Floor1.Location = New System.Drawing.Point(0, 0)
        Me.pic_Floor1.Name = "pic_Floor1"
        Me.pic_Floor1.Size = New System.Drawing.Size(582, 388)
        Me.pic_Floor1.TabIndex = 0
        Me.pic_Floor1.TabStop = False
        '
        'panel_Floor2
        '
        Me.panel_Floor2.Controls.Add(Me.Label17)
        Me.panel_Floor2.Controls.Add(Me.Label16)
        Me.panel_Floor2.Controls.Add(Me.Label6)
        Me.panel_Floor2.Controls.Add(Me.Label_l2b2)
        Me.panel_Floor2.Controls.Add(Me.Label15)
        Me.panel_Floor2.Controls.Add(Me.Label8)
        Me.panel_Floor2.Controls.Add(Me.Label_l2b5)
        Me.panel_Floor2.Controls.Add(Me.Label_l2b4)
        Me.panel_Floor2.Controls.Add(Me.Label10)
        Me.panel_Floor2.Controls.Add(Me.Label_l2b3)
        Me.panel_Floor2.Controls.Add(Me.label_l2E)
        Me.panel_Floor2.Controls.Add(Me.Label_l2b6)
        Me.panel_Floor2.Controls.Add(Me.Label_l2b1)
        Me.panel_Floor2.Controls.Add(Me.Label_l2b7)
        Me.panel_Floor2.Controls.Add(Me.pic_Floor2)
        Me.panel_Floor2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Floor2.Location = New System.Drawing.Point(0, 0)
        Me.panel_Floor2.Name = "panel_Floor2"
        Me.panel_Floor2.Size = New System.Drawing.Size(582, 388)
        Me.panel_Floor2.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(386, 110)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 42)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Dining" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Room"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(388, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 21)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Spare"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(303, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 42)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Large" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spare"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l2b2
        '
        Me.Label_l2b2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l2b2.AutoSize = True
        Me.Label_l2b2.BackColor = System.Drawing.Color.Transparent
        Me.Label_l2b2.Location = New System.Drawing.Point(48, 246)
        Me.Label_l2b2.Name = "Label_l2b2"
        Me.Label_l2b2.Size = New System.Drawing.Size(74, 21)
        Me.Label_l2b2.TabIndex = 2
        Me.Label_l2b2.Text = "Bedroom"
        Me.Label_l2b2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(54, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 42)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Full" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bath"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(54, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 42)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Full" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bath"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l2b5
        '
        Me.Label_l2b5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l2b5.AutoSize = True
        Me.Label_l2b5.BackColor = System.Drawing.Color.Transparent
        Me.Label_l2b5.Location = New System.Drawing.Point(292, 246)
        Me.Label_l2b5.Name = "Label_l2b5"
        Me.Label_l2b5.Size = New System.Drawing.Size(48, 42)
        Me.Label_l2b5.TabIndex = 2
        Me.Label_l2b5.Text = "Bed-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "room"
        Me.Label_l2b5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l2b4
        '
        Me.Label_l2b4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l2b4.AutoSize = True
        Me.Label_l2b4.BackColor = System.Drawing.Color.Transparent
        Me.Label_l2b4.Location = New System.Drawing.Point(214, 246)
        Me.Label_l2b4.Name = "Label_l2b4"
        Me.Label_l2b4.Size = New System.Drawing.Size(74, 21)
        Me.Label_l2b4.TabIndex = 2
        Me.Label_l2b4.Text = "Bedroom"
        Me.Label_l2b4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(129, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 42)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Common" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Room"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l2b3
        '
        Me.Label_l2b3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l2b3.AutoSize = True
        Me.Label_l2b3.BackColor = System.Drawing.Color.Transparent
        Me.Label_l2b3.Location = New System.Drawing.Point(132, 246)
        Me.Label_l2b3.Name = "Label_l2b3"
        Me.Label_l2b3.Size = New System.Drawing.Size(74, 21)
        Me.Label_l2b3.TabIndex = 2
        Me.Label_l2b3.Text = "Bedroom"
        Me.Label_l2b3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_l2E
        '
        Me.label_l2E.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_l2E.AutoSize = True
        Me.label_l2E.BackColor = System.Drawing.Color.Transparent
        Me.label_l2E.Location = New System.Drawing.Point(210, 69)
        Me.label_l2E.Name = "label_l2E"
        Me.label_l2E.Size = New System.Drawing.Size(72, 42)
        Me.label_l2E.TabIndex = 2
        Me.label_l2E.Text = "Enter-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tainment"
        Me.label_l2E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l2b6
        '
        Me.Label_l2b6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l2b6.AutoSize = True
        Me.Label_l2b6.BackColor = System.Drawing.Color.Transparent
        Me.Label_l2b6.Location = New System.Drawing.Point(379, 246)
        Me.Label_l2b6.Name = "Label_l2b6"
        Me.Label_l2b6.Size = New System.Drawing.Size(74, 21)
        Me.Label_l2b6.TabIndex = 2
        Me.Label_l2b6.Text = "Bedroom"
        Me.Label_l2b6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l2b1
        '
        Me.Label_l2b1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l2b1.AutoSize = True
        Me.Label_l2b1.BackColor = System.Drawing.Color.Transparent
        Me.Label_l2b1.Location = New System.Drawing.Point(459, 71)
        Me.Label_l2b1.Name = "Label_l2b1"
        Me.Label_l2b1.Size = New System.Drawing.Size(74, 21)
        Me.Label_l2b1.TabIndex = 2
        Me.Label_l2b1.Text = "Bedroom"
        Me.Label_l2b1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l2b7
        '
        Me.Label_l2b7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l2b7.AutoSize = True
        Me.Label_l2b7.BackColor = System.Drawing.Color.Transparent
        Me.Label_l2b7.Location = New System.Drawing.Point(459, 246)
        Me.Label_l2b7.Name = "Label_l2b7"
        Me.Label_l2b7.Size = New System.Drawing.Size(74, 21)
        Me.Label_l2b7.TabIndex = 2
        Me.Label_l2b7.Text = "Bedroom"
        Me.Label_l2b7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_Floor2
        '
        Me.pic_Floor2.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.The_Mansion_Floor_2_base
        Me.pic_Floor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Floor2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_Floor2.Location = New System.Drawing.Point(0, 0)
        Me.pic_Floor2.Name = "pic_Floor2"
        Me.pic_Floor2.Size = New System.Drawing.Size(582, 388)
        Me.pic_Floor2.TabIndex = 0
        Me.pic_Floor2.TabStop = False
        '
        'panel_Floor3
        '
        Me.panel_Floor3.Controls.Add(Me.label_l3E2)
        Me.panel_Floor3.Controls.Add(Me.Label22)
        Me.panel_Floor3.Controls.Add(Me.Label_l3b2)
        Me.panel_Floor3.Controls.Add(Me.Label24)
        Me.panel_Floor3.Controls.Add(Me.Label25)
        Me.panel_Floor3.Controls.Add(Me.Label_l3b5)
        Me.panel_Floor3.Controls.Add(Me.Label_l3b4)
        Me.panel_Floor3.Controls.Add(Me.label_l3E1)
        Me.panel_Floor3.Controls.Add(Me.Label_l3b3)
        Me.panel_Floor3.Controls.Add(Me.Label30)
        Me.panel_Floor3.Controls.Add(Me.Label_l3b6)
        Me.panel_Floor3.Controls.Add(Me.Label_l3b1)
        Me.panel_Floor3.Controls.Add(Me.Label_l3b7)
        Me.panel_Floor3.Controls.Add(Me.pic_Floor3)
        Me.panel_Floor3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Floor3.Location = New System.Drawing.Point(0, 0)
        Me.panel_Floor3.Name = "panel_Floor3"
        Me.panel_Floor3.Size = New System.Drawing.Size(582, 388)
        Me.panel_Floor3.TabIndex = 5
        '
        'label_l3E2
        '
        Me.label_l3E2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_l3E2.AutoSize = True
        Me.label_l3E2.BackColor = System.Drawing.Color.Transparent
        Me.label_l3E2.Location = New System.Drawing.Point(376, 69)
        Me.label_l3E2.Name = "label_l3E2"
        Me.label_l3E2.Size = New System.Drawing.Size(72, 42)
        Me.label_l3E2.TabIndex = 2
        Me.label_l3E2.Text = "Enter-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tainment"
        Me.label_l3E2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(303, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 42)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Spare" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Room"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l3b2
        '
        Me.Label_l3b2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l3b2.AutoSize = True
        Me.Label_l3b2.BackColor = System.Drawing.Color.Transparent
        Me.Label_l3b2.Location = New System.Drawing.Point(48, 246)
        Me.Label_l3b2.Name = "Label_l3b2"
        Me.Label_l3b2.Size = New System.Drawing.Size(74, 21)
        Me.Label_l3b2.TabIndex = 2
        Me.Label_l3b2.Text = "Bedroom"
        Me.Label_l3b2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(54, 110)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 42)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Full" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bath"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(54, 50)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 42)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Full" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bath"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l3b5
        '
        Me.Label_l3b5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l3b5.AutoSize = True
        Me.Label_l3b5.BackColor = System.Drawing.Color.Transparent
        Me.Label_l3b5.Location = New System.Drawing.Point(292, 246)
        Me.Label_l3b5.Name = "Label_l3b5"
        Me.Label_l3b5.Size = New System.Drawing.Size(48, 42)
        Me.Label_l3b5.TabIndex = 2
        Me.Label_l3b5.Text = "Bed-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "room"
        Me.Label_l3b5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l3b4
        '
        Me.Label_l3b4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l3b4.AutoSize = True
        Me.Label_l3b4.BackColor = System.Drawing.Color.Transparent
        Me.Label_l3b4.Location = New System.Drawing.Point(214, 246)
        Me.Label_l3b4.Name = "Label_l3b4"
        Me.Label_l3b4.Size = New System.Drawing.Size(74, 21)
        Me.Label_l3b4.TabIndex = 2
        Me.Label_l3b4.Text = "Bedroom"
        Me.Label_l3b4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_l3E1
        '
        Me.label_l3E1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_l3E1.AutoSize = True
        Me.label_l3E1.BackColor = System.Drawing.Color.Transparent
        Me.label_l3E1.Location = New System.Drawing.Point(129, 69)
        Me.label_l3E1.Name = "label_l3E1"
        Me.label_l3E1.Size = New System.Drawing.Size(72, 42)
        Me.label_l3E1.TabIndex = 2
        Me.label_l3E1.Text = "Enter-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tainment"
        Me.label_l3E1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l3b3
        '
        Me.Label_l3b3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l3b3.AutoSize = True
        Me.Label_l3b3.BackColor = System.Drawing.Color.Transparent
        Me.Label_l3b3.Location = New System.Drawing.Point(132, 246)
        Me.Label_l3b3.Name = "Label_l3b3"
        Me.Label_l3b3.Size = New System.Drawing.Size(74, 21)
        Me.Label_l3b3.TabIndex = 2
        Me.Label_l3b3.Text = "Bedroom"
        Me.Label_l3b3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(222, 69)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 42)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Large" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spare"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l3b6
        '
        Me.Label_l3b6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l3b6.AutoSize = True
        Me.Label_l3b6.BackColor = System.Drawing.Color.Transparent
        Me.Label_l3b6.Location = New System.Drawing.Point(380, 246)
        Me.Label_l3b6.Name = "Label_l3b6"
        Me.Label_l3b6.Size = New System.Drawing.Size(74, 21)
        Me.Label_l3b6.TabIndex = 2
        Me.Label_l3b6.Text = "Bedroom"
        Me.Label_l3b6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l3b1
        '
        Me.Label_l3b1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l3b1.AutoSize = True
        Me.Label_l3b1.BackColor = System.Drawing.Color.Transparent
        Me.Label_l3b1.Location = New System.Drawing.Point(459, 71)
        Me.Label_l3b1.Name = "Label_l3b1"
        Me.Label_l3b1.Size = New System.Drawing.Size(74, 21)
        Me.Label_l3b1.TabIndex = 2
        Me.Label_l3b1.Text = "Bedroom"
        Me.Label_l3b1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_l3b7
        '
        Me.Label_l3b7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_l3b7.AutoSize = True
        Me.Label_l3b7.BackColor = System.Drawing.Color.Transparent
        Me.Label_l3b7.Location = New System.Drawing.Point(459, 246)
        Me.Label_l3b7.Name = "Label_l3b7"
        Me.Label_l3b7.Size = New System.Drawing.Size(74, 21)
        Me.Label_l3b7.TabIndex = 2
        Me.Label_l3b7.Text = "Bedroom"
        Me.Label_l3b7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_Floor3
        '
        Me.pic_Floor3.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.The_Mansion_Floor_3_base
        Me.pic_Floor3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Floor3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_Floor3.Location = New System.Drawing.Point(0, 0)
        Me.pic_Floor3.Name = "pic_Floor3"
        Me.pic_Floor3.Size = New System.Drawing.Size(582, 388)
        Me.pic_Floor3.TabIndex = 0
        Me.pic_Floor3.TabStop = False
        '
        'panel_bottombar
        '
        Me.panel_bottombar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.panel_bottombar.Controls.Add(Me.but_Load)
        Me.panel_bottombar.Controls.Add(Me.but_Save)
        Me.panel_bottombar.Controls.Add(Me.label_Floor3)
        Me.panel_bottombar.Controls.Add(Me.label_Floor2)
        Me.panel_bottombar.Controls.Add(Me.label_floor1)
        Me.panel_bottombar.Controls.Add(Me.Label21)
        Me.panel_bottombar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottombar.Location = New System.Drawing.Point(0, 388)
        Me.panel_bottombar.Name = "panel_bottombar"
        Me.panel_bottombar.Size = New System.Drawing.Size(582, 33)
        Me.panel_bottombar.TabIndex = 6
        '
        'but_Load
        '
        Me.but_Load.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Load.BackColor = System.Drawing.Color.Transparent
        Me.but_Load.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.icons8_download_96
        Me.but_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Load.Location = New System.Drawing.Point(545, 5)
        Me.but_Load.Name = "but_Load"
        Me.but_Load.Size = New System.Drawing.Size(25, 25)
        Me.but_Load.TabIndex = 2
        Me.but_Load.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_Load, "Load Settings according to book")
        '
        'but_Save
        '
        Me.but_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Save.BackColor = System.Drawing.Color.Transparent
        Me.but_Save.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.icons8_save_96
        Me.but_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Save.Location = New System.Drawing.Point(514, 5)
        Me.but_Save.Name = "but_Save"
        Me.but_Save.Size = New System.Drawing.Size(25, 25)
        Me.but_Save.TabIndex = 2
        Me.but_Save.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_Save, "Save Settings according to Book")
        '
        'label_Floor3
        '
        Me.label_Floor3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label_Floor3.AutoSize = True
        Me.label_Floor3.ForeColor = System.Drawing.Color.Silver
        Me.label_Floor3.Location = New System.Drawing.Point(156, 5)
        Me.label_Floor3.Name = "label_Floor3"
        Me.label_Floor3.Size = New System.Drawing.Size(19, 21)
        Me.label_Floor3.TabIndex = 1
        Me.label_Floor3.Text = "3"
        '
        'label_Floor2
        '
        Me.label_Floor2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label_Floor2.AutoSize = True
        Me.label_Floor2.ForeColor = System.Drawing.Color.Silver
        Me.label_Floor2.Location = New System.Drawing.Point(119, 5)
        Me.label_Floor2.Name = "label_Floor2"
        Me.label_Floor2.Size = New System.Drawing.Size(19, 21)
        Me.label_Floor2.TabIndex = 1
        Me.label_Floor2.Text = "2"
        '
        'label_floor1
        '
        Me.label_floor1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label_floor1.AutoSize = True
        Me.label_floor1.ForeColor = System.Drawing.Color.Silver
        Me.label_floor1.Location = New System.Drawing.Point(82, 5)
        Me.label_floor1.Name = "label_floor1"
        Me.label_floor1.Size = New System.Drawing.Size(19, 21)
        Me.label_floor1.TabIndex = 1
        Me.label_floor1.Text = "1"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Silver
        Me.Label21.Location = New System.Drawing.Point(12, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 21)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Floors:  "
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolTip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        '
        'but_Mansion
        '
        Me.but_Mansion.BackColor = System.Drawing.Color.Transparent
        Me.but_Mansion.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.icons8_home_512
        Me.but_Mansion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Mansion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.but_Mansion.Location = New System.Drawing.Point(3, 53)
        Me.but_Mansion.Name = "but_Mansion"
        Me.but_Mansion.Size = New System.Drawing.Size(167, 117)
        Me.but_Mansion.TabIndex = 5
        Me.but_Mansion.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_Mansion, "The Mansion")
        '
        'pic_Map
        '
        Me.pic_Map.BackColor = System.Drawing.Color.Transparent
        Me.pic_Map.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.icons8_world_map_96
        Me.pic_Map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Map.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_Map.Location = New System.Drawing.Point(176, 53)
        Me.pic_Map.Name = "pic_Map"
        Me.pic_Map.Size = New System.Drawing.Size(167, 117)
        Me.pic_Map.TabIndex = 9
        Me.pic_Map.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pic_Map, "The Mansion")
        '
        'but_translate
        '
        Me.but_translate.BackColor = System.Drawing.Color.Transparent
        Me.but_translate.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Avian_Icon_sleek_4
        Me.but_translate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_translate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.but_translate.Location = New System.Drawing.Point(349, 53)
        Me.but_translate.Name = "but_translate"
        Me.but_translate.Size = New System.Drawing.Size(168, 117)
        Me.but_translate.TabIndex = 3
        Me.but_translate.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_translate, "Translate Languages")
        '
        'but_Map
        '
        Me.but_Map.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Map.BackColor = System.Drawing.Color.Transparent
        Me.but_Map.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.icons8_world_map_96
        Me.but_Map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Map.Location = New System.Drawing.Point(514, 9)
        Me.but_Map.Name = "but_Map"
        Me.but_Map.Size = New System.Drawing.Size(25, 25)
        Me.but_Map.TabIndex = 5
        Me.but_Map.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_Map, "View the Mark Wills' World")
        '
        'but_Universe
        '
        Me.but_Universe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Universe.BackColor = System.Drawing.Color.Transparent
        Me.but_Universe.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.icons8_galaxy_80
        Me.but_Universe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Universe.Location = New System.Drawing.Point(545, 9)
        Me.but_Universe.Name = "but_Universe"
        Me.but_Universe.Size = New System.Drawing.Size(25, 25)
        Me.but_Universe.TabIndex = 5
        Me.but_Universe.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_Universe, "                 View the Universe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(For best results, maximize window)")
        '
        'but_HomeScreen2
        '
        Me.but_HomeScreen2.BackColor = System.Drawing.Color.Transparent
        Me.but_HomeScreen2.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.icons8_home_512_small
        Me.but_HomeScreen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_HomeScreen2.Location = New System.Drawing.Point(12, 9)
        Me.but_HomeScreen2.Name = "but_HomeScreen2"
        Me.but_HomeScreen2.Size = New System.Drawing.Size(25, 25)
        Me.but_HomeScreen2.TabIndex = 4
        Me.but_HomeScreen2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_HomeScreen2, "Back to Main Screen")
        '
        'but_MapForward
        '
        Me.but_MapForward.BackColor = System.Drawing.Color.Transparent
        Me.but_MapForward.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.SwitchForward
        Me.but_MapForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_MapForward.Location = New System.Drawing.Point(74, 9)
        Me.but_MapForward.Name = "but_MapForward"
        Me.but_MapForward.Size = New System.Drawing.Size(25, 25)
        Me.but_MapForward.TabIndex = 1
        Me.but_MapForward.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_MapForward, "Go Forward")
        '
        'but_MapBack
        '
        Me.but_MapBack.BackColor = System.Drawing.Color.Transparent
        Me.but_MapBack.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.SwitchBack
        Me.but_MapBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_MapBack.Location = New System.Drawing.Point(43, 9)
        Me.but_MapBack.Name = "but_MapBack"
        Me.but_MapBack.Size = New System.Drawing.Size(25, 25)
        Me.but_MapBack.TabIndex = 0
        Me.but_MapBack.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_MapBack, "Go Back")
        '
        'but_HomeScreen3
        '
        Me.but_HomeScreen3.BackColor = System.Drawing.Color.Transparent
        Me.but_HomeScreen3.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.icons8_home_512_small
        Me.but_HomeScreen3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_HomeScreen3.Location = New System.Drawing.Point(12, 9)
        Me.but_HomeScreen3.Name = "but_HomeScreen3"
        Me.but_HomeScreen3.Size = New System.Drawing.Size(25, 25)
        Me.but_HomeScreen3.TabIndex = 7
        Me.but_HomeScreen3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_HomeScreen3, "Back to Main Screen")
        '
        'but_ForwardHeroes
        '
        Me.but_ForwardHeroes.BackColor = System.Drawing.Color.Transparent
        Me.but_ForwardHeroes.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.SwitchForward
        Me.but_ForwardHeroes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_ForwardHeroes.Location = New System.Drawing.Point(74, 9)
        Me.but_ForwardHeroes.Name = "but_ForwardHeroes"
        Me.but_ForwardHeroes.Size = New System.Drawing.Size(25, 25)
        Me.but_ForwardHeroes.TabIndex = 6
        Me.but_ForwardHeroes.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_ForwardHeroes, "Increase Floor Level")
        Me.but_ForwardHeroes.Visible = False
        '
        'but_backHeroes
        '
        Me.but_backHeroes.BackColor = System.Drawing.Color.Transparent
        Me.but_backHeroes.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.SwitchBack
        Me.but_backHeroes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_backHeroes.Location = New System.Drawing.Point(43, 9)
        Me.but_backHeroes.Name = "but_backHeroes"
        Me.but_backHeroes.Size = New System.Drawing.Size(25, 25)
        Me.but_backHeroes.TabIndex = 5
        Me.but_backHeroes.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_backHeroes, "Back")
        '
        'panel_Mansion
        '
        Me.panel_Mansion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Mansion.Location = New System.Drawing.Point(0, 0)
        Me.panel_Mansion.Name = "panel_Mansion"
        Me.panel_Mansion.Size = New System.Drawing.Size(582, 388)
        Me.panel_Mansion.TabIndex = 8
        Me.panel_Mansion.Visible = False
        '
        'panel_MainScreen
        '
        Me.panel_MainScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.panel_MainScreen.Controls.Add(Me.TableLayoutPanel1)
        Me.panel_MainScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_MainScreen.Location = New System.Drawing.Point(0, 0)
        Me.panel_MainScreen.Name = "panel_MainScreen"
        Me.panel_MainScreen.Size = New System.Drawing.Size(582, 388)
        Me.panel_MainScreen.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33224!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33554!))
        Me.TableLayoutPanel1.Controls.Add(Me.label_themansion, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.but_Mansion, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pic_Map, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.but_translate, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.label_map, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.label_rextonian, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.RichLabel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pic_Heroes, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.label_LockApp, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.label_TheHeroes, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(33, 23)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(520, 347)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'label_themansion
        '
        Me.label_themansion.AutoSize = True
        Me.label_themansion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_themansion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_themansion.Location = New System.Drawing.Point(3, 173)
        Me.label_themansion.Name = "label_themansion"
        Me.label_themansion.Size = New System.Drawing.Size(167, 25)
        Me.label_themansion.TabIndex = 7
        Me.label_themansion.Text = "The Mansion"
        Me.label_themansion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_map
        '
        Me.label_map.AutoSize = True
        Me.label_map.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_map.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_map.Location = New System.Drawing.Point(176, 173)
        Me.label_map.Name = "label_map"
        Me.label_map.Size = New System.Drawing.Size(167, 25)
        Me.label_map.TabIndex = 10
        Me.label_map.Text = "Map"
        Me.label_map.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_rextonian
        '
        Me.label_rextonian.AutoSize = True
        Me.label_rextonian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_rextonian.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_rextonian.Location = New System.Drawing.Point(349, 173)
        Me.label_rextonian.Name = "label_rextonian"
        Me.label_rextonian.Size = New System.Drawing.Size(168, 25)
        Me.label_rextonian.TabIndex = 8
        Me.label_rextonian.Text = "Rextonian Language"
        Me.label_rextonian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichLabel1
        '
        Me.RichLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichLabel1.AutoSize = True
        Me.RichLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel1.Location = New System.Drawing.Point(176, 0)
        Me.RichLabel1.MinimumSize = New System.Drawing.Size(179, 0)
        Me.RichLabel1.Name = "RichLabel1"
        Me.RichLabel1.Size = New System.Drawing.Size(179, 42)
        Me.RichLabel1.TabIndex = 6
        Me.RichLabel1.Text = "Select a Property" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the Book"
        Me.RichLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_Heroes
        '
        Me.pic_Heroes.BackColor = System.Drawing.Color.Transparent
        Me.pic_Heroes.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.The_Avians_Logo_Sleek_4
        Me.pic_Heroes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Heroes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_Heroes.Location = New System.Drawing.Point(176, 201)
        Me.pic_Heroes.Name = "pic_Heroes"
        Me.pic_Heroes.Size = New System.Drawing.Size(167, 117)
        Me.pic_Heroes.TabIndex = 3
        Me.pic_Heroes.TabStop = False
        '
        'label_LockApp
        '
        Me.label_LockApp.AutoSize = True
        Me.label_LockApp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_LockApp.Location = New System.Drawing.Point(349, 321)
        Me.label_LockApp.Name = "label_LockApp"
        Me.label_LockApp.Size = New System.Drawing.Size(164, 21)
        Me.label_LockApp.TabIndex = 11
        Me.label_LockApp.Text = "Click here to Lock App"
        Me.label_LockApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.label_LockApp.Visible = False
        '
        'label_TheHeroes
        '
        Me.label_TheHeroes.AutoSize = True
        Me.label_TheHeroes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_TheHeroes.Location = New System.Drawing.Point(176, 321)
        Me.label_TheHeroes.Name = "label_TheHeroes"
        Me.label_TheHeroes.Size = New System.Drawing.Size(167, 26)
        Me.label_TheHeroes.TabIndex = 12
        Me.label_TheHeroes.Text = "The Heroes"
        Me.label_TheHeroes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_Map
        '
        Me.panel_Map.Controls.Add(Me.browser_Map)
        Me.panel_Map.Controls.Add(Me.Panel1)
        Me.panel_Map.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Map.Location = New System.Drawing.Point(0, 0)
        Me.panel_Map.Name = "panel_Map"
        Me.panel_Map.Size = New System.Drawing.Size(582, 388)
        Me.panel_Map.TabIndex = 10
        '
        'browser_Map
        '
        Me.browser_Map.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browser_Map.Location = New System.Drawing.Point(0, 44)
        Me.browser_Map.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser_Map.Name = "browser_Map"
        Me.browser_Map.Size = New System.Drawing.Size(582, 344)
        Me.browser_Map.TabIndex = 3
        Me.browser_Map.Url = New System.Uri("https://www.google.com/maps/d/u/0/viewer?mid=1z_4E2EWtTXXiVaarwltixSJgzGpaLbct&ll" &
        "=47.39375488285062%2C-44.61404730000001&z=4", System.UriKind.Absolute)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel1.Controls.Add(Me.but_Map)
        Me.Panel1.Controls.Add(Me.but_Universe)
        Me.Panel1.Controls.Add(Me.but_HomeScreen2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.but_MapForward)
        Me.Panel1.Controls.Add(Me.but_MapBack)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(582, 44)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(261, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Maps"
        '
        'panel_Spoilers
        '
        Me.panel_Spoilers.Controls.Add(Me.TableLayoutPanel3)
        Me.panel_Spoilers.Controls.Add(Me.TableLayoutPanel2)
        Me.panel_Spoilers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Spoilers.Location = New System.Drawing.Point(0, 0)
        Me.panel_Spoilers.Name = "panel_Spoilers"
        Me.panel_Spoilers.Size = New System.Drawing.Size(582, 388)
        Me.panel_Spoilers.TabIndex = 11
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.label_Warning, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(582, 308)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'label_Warning
        '
        Me.label_Warning.AutoSize = True
        Me.label_Warning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_Warning.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Warning.Location = New System.Drawing.Point(23, 0)
        Me.label_Warning.Name = "label_Warning"
        Me.label_Warning.Size = New System.Drawing.Size(536, 308)
        Me.label_Warning.TabIndex = 0
        Me.label_Warning.Text = "WARNING!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This app contains spoilers to the book series:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Adventures of Mark " &
    "Wills" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do you want to continue?"
        Me.label_Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.but_Yes, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.but_No, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 308)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(582, 80)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'but_Yes
        '
        Me.but_Yes.AllowFocus = False
        Me.but_Yes.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_Yes.Appearance.Options.UseFont = True
        Me.but_Yes.Location = New System.Drawing.Point(203, 3)
        Me.but_Yes.Name = "but_Yes"
        Me.but_Yes.Size = New System.Drawing.Size(85, 47)
        Me.but_Yes.TabIndex = 1
        Me.but_Yes.Text = "Yes"
        '
        'but_No
        '
        Me.but_No.AllowFocus = False
        Me.but_No.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_No.Appearance.Options.UseFont = True
        Me.but_No.Location = New System.Drawing.Point(294, 3)
        Me.but_No.Name = "but_No"
        Me.but_No.Size = New System.Drawing.Size(85, 47)
        Me.but_No.TabIndex = 1
        Me.but_No.Text = "No"
        '
        'panel_Heroes
        '
        Me.panel_Heroes.Controls.Add(Me.layout_Heroes)
        Me.panel_Heroes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Heroes.Location = New System.Drawing.Point(0, 0)
        Me.panel_Heroes.Name = "panel_Heroes"
        Me.panel_Heroes.Size = New System.Drawing.Size(582, 421)
        Me.panel_Heroes.TabIndex = 12
        '
        'layout_Heroes
        '
        Me.layout_Heroes.ColumnCount = 3
        Me.layout_Heroes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.layout_Heroes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.layout_Heroes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.layout_Heroes.Controls.Add(Me.RichLabel12, 2, 1)
        Me.layout_Heroes.Controls.Add(Me.pic_AngelIcon, 2, 0)
        Me.layout_Heroes.Controls.Add(Me.pic_PsychIcon, 1, 0)
        Me.layout_Heroes.Controls.Add(Me.pic_AvianIcon, 0, 0)
        Me.layout_Heroes.Controls.Add(Me.RichLabel6, 0, 1)
        Me.layout_Heroes.Controls.Add(Me.RichLabel11, 1, 1)
        Me.layout_Heroes.Controls.Add(Me.RichLabel7, 1, 3)
        Me.layout_Heroes.Controls.Add(Me.RichLabel9, 0, 5)
        Me.layout_Heroes.Controls.Add(Me.RichLabel8, 2, 3)
        Me.layout_Heroes.Controls.Add(Me.pic_ShiftIcon, 0, 4)
        Me.layout_Heroes.Controls.Add(Me.pic_SwiftIcon, 2, 2)
        Me.layout_Heroes.Controls.Add(Me.pic_WhirlwindIcon, 1, 2)
        Me.layout_Heroes.Controls.Add(Me.RichLabel10, 0, 3)
        Me.layout_Heroes.Controls.Add(Me.RichLabel13, 2, 5)
        Me.layout_Heroes.Controls.Add(Me.RichLabel14, 1, 5)
        Me.layout_Heroes.Controls.Add(Me.pic_VortexIcon, 0, 2)
        Me.layout_Heroes.Controls.Add(Me.pic_TykeIcon, 1, 4)
        Me.layout_Heroes.Controls.Add(Me.pic_BoltIcon, 2, 4)
        Me.layout_Heroes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layout_Heroes.Location = New System.Drawing.Point(0, 0)
        Me.layout_Heroes.Name = "layout_Heroes"
        Me.layout_Heroes.RowCount = 6
        Me.layout_Heroes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.layout_Heroes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.layout_Heroes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.layout_Heroes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.layout_Heroes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.layout_Heroes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.layout_Heroes.Size = New System.Drawing.Size(582, 421)
        Me.layout_Heroes.TabIndex = 0
        '
        'RichLabel12
        '
        Me.RichLabel12.AutoSize = True
        Me.RichLabel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichLabel12.Location = New System.Drawing.Point(391, 117)
        Me.RichLabel12.Name = "RichLabel12"
        Me.RichLabel12.Size = New System.Drawing.Size(188, 23)
        Me.RichLabel12.TabIndex = 10
        Me.RichLabel12.Text = "Angel"
        Me.RichLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_AngelIcon
        '
        Me.pic_AngelIcon.BackColor = System.Drawing.Color.Transparent
        Me.pic_AngelIcon.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Angel_Icon_4
        Me.pic_AngelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_AngelIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_AngelIcon.Location = New System.Drawing.Point(391, 3)
        Me.pic_AngelIcon.Name = "pic_AngelIcon"
        Me.pic_AngelIcon.Size = New System.Drawing.Size(188, 111)
        Me.pic_AngelIcon.TabIndex = 3
        Me.pic_AngelIcon.TabStop = False
        '
        'pic_PsychIcon
        '
        Me.pic_PsychIcon.BackColor = System.Drawing.Color.Transparent
        Me.pic_PsychIcon.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Abstract_P_Symbol_2
        Me.pic_PsychIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_PsychIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_PsychIcon.Location = New System.Drawing.Point(197, 3)
        Me.pic_PsychIcon.Name = "pic_PsychIcon"
        Me.pic_PsychIcon.Size = New System.Drawing.Size(188, 111)
        Me.pic_PsychIcon.TabIndex = 2
        Me.pic_PsychIcon.TabStop = False
        '
        'pic_AvianIcon
        '
        Me.pic_AvianIcon.BackColor = System.Drawing.Color.Transparent
        Me.pic_AvianIcon.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Avian_Icon_sleek_5
        Me.pic_AvianIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_AvianIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_AvianIcon.Location = New System.Drawing.Point(3, 3)
        Me.pic_AvianIcon.Name = "pic_AvianIcon"
        Me.pic_AvianIcon.Size = New System.Drawing.Size(188, 111)
        Me.pic_AvianIcon.TabIndex = 0
        Me.pic_AvianIcon.TabStop = False
        '
        'RichLabel6
        '
        Me.RichLabel6.AutoSize = True
        Me.RichLabel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichLabel6.Location = New System.Drawing.Point(3, 117)
        Me.RichLabel6.Name = "RichLabel6"
        Me.RichLabel6.Size = New System.Drawing.Size(188, 23)
        Me.RichLabel6.TabIndex = 1
        Me.RichLabel6.Text = "Avian"
        Me.RichLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichLabel11
        '
        Me.RichLabel11.AutoSize = True
        Me.RichLabel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichLabel11.Location = New System.Drawing.Point(197, 117)
        Me.RichLabel11.Name = "RichLabel11"
        Me.RichLabel11.Size = New System.Drawing.Size(188, 23)
        Me.RichLabel11.TabIndex = 9
        Me.RichLabel11.Text = "Psych"
        Me.RichLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichLabel7
        '
        Me.RichLabel7.AutoSize = True
        Me.RichLabel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichLabel7.Location = New System.Drawing.Point(197, 257)
        Me.RichLabel7.Name = "RichLabel7"
        Me.RichLabel7.Size = New System.Drawing.Size(188, 23)
        Me.RichLabel7.TabIndex = 5
        Me.RichLabel7.Text = "Whirlwind"
        Me.RichLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichLabel9
        '
        Me.RichLabel9.AutoSize = True
        Me.RichLabel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichLabel9.Location = New System.Drawing.Point(3, 397)
        Me.RichLabel9.Name = "RichLabel9"
        Me.RichLabel9.Size = New System.Drawing.Size(188, 24)
        Me.RichLabel9.TabIndex = 7
        Me.RichLabel9.Text = "Shift"
        Me.RichLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichLabel8
        '
        Me.RichLabel8.AutoSize = True
        Me.RichLabel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichLabel8.Location = New System.Drawing.Point(391, 257)
        Me.RichLabel8.Name = "RichLabel8"
        Me.RichLabel8.Size = New System.Drawing.Size(188, 23)
        Me.RichLabel8.TabIndex = 6
        Me.RichLabel8.Text = "Swift"
        Me.RichLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_ShiftIcon
        '
        Me.pic_ShiftIcon.BackColor = System.Drawing.Color.Transparent
        Me.pic_ShiftIcon.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Shift_5
        Me.pic_ShiftIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_ShiftIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_ShiftIcon.Location = New System.Drawing.Point(3, 283)
        Me.pic_ShiftIcon.Name = "pic_ShiftIcon"
        Me.pic_ShiftIcon.Size = New System.Drawing.Size(188, 111)
        Me.pic_ShiftIcon.TabIndex = 12
        Me.pic_ShiftIcon.TabStop = False
        '
        'pic_SwiftIcon
        '
        Me.pic_SwiftIcon.BackColor = System.Drawing.Color.Transparent
        Me.pic_SwiftIcon.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Swift_Icon_4
        Me.pic_SwiftIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_SwiftIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_SwiftIcon.Location = New System.Drawing.Point(391, 143)
        Me.pic_SwiftIcon.Name = "pic_SwiftIcon"
        Me.pic_SwiftIcon.Size = New System.Drawing.Size(188, 111)
        Me.pic_SwiftIcon.TabIndex = 12
        Me.pic_SwiftIcon.TabStop = False
        '
        'pic_WhirlwindIcon
        '
        Me.pic_WhirlwindIcon.BackColor = System.Drawing.Color.Transparent
        Me.pic_WhirlwindIcon.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Whirlwind_Icon_4
        Me.pic_WhirlwindIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_WhirlwindIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_WhirlwindIcon.Location = New System.Drawing.Point(197, 143)
        Me.pic_WhirlwindIcon.Name = "pic_WhirlwindIcon"
        Me.pic_WhirlwindIcon.Size = New System.Drawing.Size(188, 111)
        Me.pic_WhirlwindIcon.TabIndex = 12
        Me.pic_WhirlwindIcon.TabStop = False
        '
        'RichLabel10
        '
        Me.RichLabel10.AutoSize = True
        Me.RichLabel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichLabel10.Location = New System.Drawing.Point(3, 257)
        Me.RichLabel10.Name = "RichLabel10"
        Me.RichLabel10.Size = New System.Drawing.Size(188, 23)
        Me.RichLabel10.TabIndex = 5
        Me.RichLabel10.Text = "Vortex"
        Me.RichLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichLabel13
        '
        Me.RichLabel13.AutoSize = True
        Me.RichLabel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichLabel13.Location = New System.Drawing.Point(391, 397)
        Me.RichLabel13.Name = "RichLabel13"
        Me.RichLabel13.Size = New System.Drawing.Size(188, 24)
        Me.RichLabel13.TabIndex = 5
        Me.RichLabel13.Text = "Bolt"
        Me.RichLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichLabel14
        '
        Me.RichLabel14.AutoSize = True
        Me.RichLabel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichLabel14.Location = New System.Drawing.Point(197, 397)
        Me.RichLabel14.Name = "RichLabel14"
        Me.RichLabel14.Size = New System.Drawing.Size(188, 24)
        Me.RichLabel14.TabIndex = 5
        Me.RichLabel14.Text = "Tyke"
        Me.RichLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_VortexIcon
        '
        Me.pic_VortexIcon.BackColor = System.Drawing.Color.Transparent
        Me.pic_VortexIcon.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Vortex_4
        Me.pic_VortexIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_VortexIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_VortexIcon.Location = New System.Drawing.Point(3, 143)
        Me.pic_VortexIcon.Name = "pic_VortexIcon"
        Me.pic_VortexIcon.Size = New System.Drawing.Size(188, 111)
        Me.pic_VortexIcon.TabIndex = 12
        Me.pic_VortexIcon.TabStop = False
        '
        'pic_TykeIcon
        '
        Me.pic_TykeIcon.BackColor = System.Drawing.Color.Transparent
        Me.pic_TykeIcon.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Tyke_4
        Me.pic_TykeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_TykeIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_TykeIcon.Location = New System.Drawing.Point(197, 283)
        Me.pic_TykeIcon.Name = "pic_TykeIcon"
        Me.pic_TykeIcon.Size = New System.Drawing.Size(188, 111)
        Me.pic_TykeIcon.TabIndex = 12
        Me.pic_TykeIcon.TabStop = False
        '
        'pic_BoltIcon
        '
        Me.pic_BoltIcon.BackColor = System.Drawing.Color.Transparent
        Me.pic_BoltIcon.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Bolt_Icon_2
        Me.pic_BoltIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_BoltIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_BoltIcon.Location = New System.Drawing.Point(391, 283)
        Me.pic_BoltIcon.Name = "pic_BoltIcon"
        Me.pic_BoltIcon.Size = New System.Drawing.Size(188, 111)
        Me.pic_BoltIcon.TabIndex = 12
        Me.pic_BoltIcon.TabStop = False
        '
        'panel_HeroesBar
        '
        Me.panel_HeroesBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.panel_HeroesBar.Controls.Add(Me.but_HomeScreen3)
        Me.panel_HeroesBar.Controls.Add(Me.but_ForwardHeroes)
        Me.panel_HeroesBar.Controls.Add(Me.but_backHeroes)
        Me.panel_HeroesBar.Location = New System.Drawing.Point(389, 0)
        Me.panel_HeroesBar.Name = "panel_HeroesBar"
        Me.panel_HeroesBar.Size = New System.Drawing.Size(200, 44)
        Me.panel_HeroesBar.TabIndex = 13
        '
        'panel_Avian
        '
        Me.panel_Avian.Controls.Add(Me.label_Avian)
        Me.panel_Avian.Controls.Add(Me.RichLabel16)
        Me.panel_Avian.Controls.Add(Me.pic_Avian)
        Me.panel_Avian.Controls.Add(Me.panel_Psych)
        Me.panel_Avian.Location = New System.Drawing.Point(70, 44)
        Me.panel_Avian.Name = "panel_Avian"
        Me.panel_Avian.Size = New System.Drawing.Size(480, 344)
        Me.panel_Avian.TabIndex = 14
        '
        'label_Avian
        '
        Me.label_Avian.AutoSize = True
        Me.label_Avian.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Avian.Location = New System.Drawing.Point(228, 42)
        Me.label_Avian.Name = "label_Avian"
        Me.label_Avian.Size = New System.Drawing.Size(230, 273)
        Me.label_Avian.TabIndex = 2
        Me.label_Avian.Text = resources.GetString("label_Avian.Text")
        '
        'RichLabel16
        '
        Me.RichLabel16.AutoSize = True
        Me.RichLabel16.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel16.Location = New System.Drawing.Point(228, 13)
        Me.RichLabel16.Name = "RichLabel16"
        Me.RichLabel16.Size = New System.Drawing.Size(62, 25)
        Me.RichLabel16.TabIndex = 1
        Me.RichLabel16.Text = "Avian"
        '
        'pic_Avian
        '
        Me.pic_Avian.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Avian_10
        Me.pic_Avian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Avian.Location = New System.Drawing.Point(12, 13)
        Me.pic_Avian.Name = "pic_Avian"
        Me.pic_Avian.Size = New System.Drawing.Size(185, 325)
        Me.pic_Avian.TabIndex = 0
        Me.pic_Avian.TabStop = False
        '
        'panel_Psych
        '
        Me.panel_Psych.Controls.Add(Me.panel_Angel)
        Me.panel_Psych.Controls.Add(Me.RichLabel18)
        Me.panel_Psych.Controls.Add(Me.RichLabel19)
        Me.panel_Psych.Controls.Add(Me.pic_Psych)
        Me.panel_Psych.Location = New System.Drawing.Point(8, 8)
        Me.panel_Psych.Name = "panel_Psych"
        Me.panel_Psych.Size = New System.Drawing.Size(480, 344)
        Me.panel_Psych.TabIndex = 15
        '
        'panel_Angel
        '
        Me.panel_Angel.Controls.Add(Me.RichLabel20)
        Me.panel_Angel.Controls.Add(Me.RichLabel21)
        Me.panel_Angel.Controls.Add(Me.pic_Angel)
        Me.panel_Angel.Controls.Add(Me.panel_Vortex)
        Me.panel_Angel.Location = New System.Drawing.Point(8, 8)
        Me.panel_Angel.Name = "panel_Angel"
        Me.panel_Angel.Size = New System.Drawing.Size(480, 344)
        Me.panel_Angel.TabIndex = 16
        '
        'RichLabel20
        '
        Me.RichLabel20.AutoSize = True
        Me.RichLabel20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel20.Location = New System.Drawing.Point(228, 42)
        Me.RichLabel20.Name = "RichLabel20"
        Me.RichLabel20.Size = New System.Drawing.Size(195, 84)
        Me.RichLabel20.TabIndex = 2
        Me.RichLabel20.Text = "Rachel Joy Stanbury | Wills" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Powers:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enhanced Physical Traits" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wings"
        '
        'RichLabel21
        '
        Me.RichLabel21.AutoSize = True
        Me.RichLabel21.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel21.Location = New System.Drawing.Point(228, 13)
        Me.RichLabel21.Name = "RichLabel21"
        Me.RichLabel21.Size = New System.Drawing.Size(64, 25)
        Me.RichLabel21.TabIndex = 1
        Me.RichLabel21.Text = "Angel"
        '
        'pic_Angel
        '
        Me.pic_Angel.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Angel_8
        Me.pic_Angel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Angel.Location = New System.Drawing.Point(12, 13)
        Me.pic_Angel.Name = "pic_Angel"
        Me.pic_Angel.Size = New System.Drawing.Size(185, 325)
        Me.pic_Angel.TabIndex = 0
        Me.pic_Angel.TabStop = False
        '
        'panel_Vortex
        '
        Me.panel_Vortex.Controls.Add(Me.RichLabel22)
        Me.panel_Vortex.Controls.Add(Me.RichLabel23)
        Me.panel_Vortex.Controls.Add(Me.pic_Vortex)
        Me.panel_Vortex.Controls.Add(Me.panel_Whirlwind)
        Me.panel_Vortex.Location = New System.Drawing.Point(8, 8)
        Me.panel_Vortex.Name = "panel_Vortex"
        Me.panel_Vortex.Size = New System.Drawing.Size(480, 344)
        Me.panel_Vortex.TabIndex = 17
        '
        'RichLabel22
        '
        Me.RichLabel22.AutoSize = True
        Me.RichLabel22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel22.Location = New System.Drawing.Point(228, 42)
        Me.RichLabel22.Name = "RichLabel22"
        Me.RichLabel22.Size = New System.Drawing.Size(185, 126)
        Me.RichLabel22.TabIndex = 2
        Me.RichLabel22.Text = "Nick Glenden" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Powers:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Juxtakinesis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Power/object Replication," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vasokinesis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Flig" &
    "hted"
        '
        'RichLabel23
        '
        Me.RichLabel23.AutoSize = True
        Me.RichLabel23.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel23.Location = New System.Drawing.Point(228, 13)
        Me.RichLabel23.Name = "RichLabel23"
        Me.RichLabel23.Size = New System.Drawing.Size(73, 25)
        Me.RichLabel23.TabIndex = 1
        Me.RichLabel23.Text = "Vortex"
        '
        'pic_Vortex
        '
        Me.pic_Vortex.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Vortex_7
        Me.pic_Vortex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Vortex.Location = New System.Drawing.Point(12, 13)
        Me.pic_Vortex.Name = "pic_Vortex"
        Me.pic_Vortex.Size = New System.Drawing.Size(185, 325)
        Me.pic_Vortex.TabIndex = 0
        Me.pic_Vortex.TabStop = False
        '
        'panel_Whirlwind
        '
        Me.panel_Whirlwind.Controls.Add(Me.RichLabel24)
        Me.panel_Whirlwind.Controls.Add(Me.RichLabel25)
        Me.panel_Whirlwind.Controls.Add(Me.pic_Whirlwind)
        Me.panel_Whirlwind.Controls.Add(Me.panel_Swift)
        Me.panel_Whirlwind.Location = New System.Drawing.Point(8, 8)
        Me.panel_Whirlwind.Name = "panel_Whirlwind"
        Me.panel_Whirlwind.Size = New System.Drawing.Size(480, 344)
        Me.panel_Whirlwind.TabIndex = 18
        '
        'RichLabel24
        '
        Me.RichLabel24.AutoSize = True
        Me.RichLabel24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel24.Location = New System.Drawing.Point(228, 42)
        Me.RichLabel24.Name = "RichLabel24"
        Me.RichLabel24.Size = New System.Drawing.Size(141, 105)
        Me.RichLabel24.TabIndex = 2
        Me.RichLabel24.Text = "Alex Rush (Russell)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Powers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Super Speed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Flighted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pyrokinesis"
        '
        'RichLabel25
        '
        Me.RichLabel25.AutoSize = True
        Me.RichLabel25.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel25.Location = New System.Drawing.Point(228, 13)
        Me.RichLabel25.Name = "RichLabel25"
        Me.RichLabel25.Size = New System.Drawing.Size(104, 25)
        Me.RichLabel25.TabIndex = 1
        Me.RichLabel25.Text = "Whirlwind"
        '
        'pic_Whirlwind
        '
        Me.pic_Whirlwind.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.whirlwind_11
        Me.pic_Whirlwind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Whirlwind.Location = New System.Drawing.Point(12, 13)
        Me.pic_Whirlwind.Name = "pic_Whirlwind"
        Me.pic_Whirlwind.Size = New System.Drawing.Size(185, 325)
        Me.pic_Whirlwind.TabIndex = 0
        Me.pic_Whirlwind.TabStop = False
        '
        'panel_Swift
        '
        Me.panel_Swift.Controls.Add(Me.RichLabel26)
        Me.panel_Swift.Controls.Add(Me.RichLabel27)
        Me.panel_Swift.Controls.Add(Me.pic_Swift)
        Me.panel_Swift.Controls.Add(Me.panel_Shift)
        Me.panel_Swift.Location = New System.Drawing.Point(8, 8)
        Me.panel_Swift.Name = "panel_Swift"
        Me.panel_Swift.Size = New System.Drawing.Size(480, 344)
        Me.panel_Swift.TabIndex = 19
        '
        'RichLabel26
        '
        Me.RichLabel26.AutoSize = True
        Me.RichLabel26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel26.Location = New System.Drawing.Point(228, 42)
        Me.RichLabel26.Name = "RichLabel26"
        Me.RichLabel26.Size = New System.Drawing.Size(264, 147)
        Me.RichLabel26.TabIndex = 2
        Me.RichLabel26.Text = "Grace McGovern" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Powers:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Flighted (winds from inside of arms.)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Arm Strength" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tel" &
    "epathy with Mara" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Agility" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "High-Speed-Vision" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RichLabel27
        '
        Me.RichLabel27.AutoSize = True
        Me.RichLabel27.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel27.Location = New System.Drawing.Point(228, 13)
        Me.RichLabel27.Name = "RichLabel27"
        Me.RichLabel27.Size = New System.Drawing.Size(57, 25)
        Me.RichLabel27.TabIndex = 1
        Me.RichLabel27.Text = "Swift"
        '
        'pic_Swift
        '
        Me.pic_Swift.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Swift_4
        Me.pic_Swift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Swift.Location = New System.Drawing.Point(12, 13)
        Me.pic_Swift.Name = "pic_Swift"
        Me.pic_Swift.Size = New System.Drawing.Size(185, 325)
        Me.pic_Swift.TabIndex = 0
        Me.pic_Swift.TabStop = False
        '
        'panel_Shift
        '
        Me.panel_Shift.Controls.Add(Me.RichLabel28)
        Me.panel_Shift.Controls.Add(Me.RichLabel29)
        Me.panel_Shift.Controls.Add(Me.pic_Shift)
        Me.panel_Shift.Controls.Add(Me.panel_Tyke)
        Me.panel_Shift.Location = New System.Drawing.Point(8, 8)
        Me.panel_Shift.Name = "panel_Shift"
        Me.panel_Shift.Size = New System.Drawing.Size(480, 344)
        Me.panel_Shift.TabIndex = 20
        '
        'RichLabel28
        '
        Me.RichLabel28.AutoSize = True
        Me.RichLabel28.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel28.Location = New System.Drawing.Point(228, 42)
        Me.RichLabel28.Name = "RichLabel28"
        Me.RichLabel28.Size = New System.Drawing.Size(264, 126)
        Me.RichLabel28.TabIndex = 2
        Me.RichLabel28.Text = "Mara Lorenzo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Powers:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Flighted (winds from inside of arms.)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Arm Strength" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Telep" &
    "athy with Grace" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Animal Communication & Mimicry"
        '
        'RichLabel29
        '
        Me.RichLabel29.AutoSize = True
        Me.RichLabel29.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel29.Location = New System.Drawing.Point(228, 13)
        Me.RichLabel29.Name = "RichLabel29"
        Me.RichLabel29.Size = New System.Drawing.Size(53, 25)
        Me.RichLabel29.TabIndex = 1
        Me.RichLabel29.Text = "Shift"
        '
        'pic_Shift
        '
        Me.pic_Shift.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Shift_4
        Me.pic_Shift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Shift.Location = New System.Drawing.Point(12, 13)
        Me.pic_Shift.Name = "pic_Shift"
        Me.pic_Shift.Size = New System.Drawing.Size(185, 325)
        Me.pic_Shift.TabIndex = 0
        Me.pic_Shift.TabStop = False
        '
        'panel_Tyke
        '
        Me.panel_Tyke.Controls.Add(Me.RichLabel30)
        Me.panel_Tyke.Controls.Add(Me.RichLabel31)
        Me.panel_Tyke.Controls.Add(Me.pic_Tyke)
        Me.panel_Tyke.Controls.Add(Me.panel_Bolt)
        Me.panel_Tyke.Location = New System.Drawing.Point(8, 8)
        Me.panel_Tyke.Name = "panel_Tyke"
        Me.panel_Tyke.Size = New System.Drawing.Size(480, 344)
        Me.panel_Tyke.TabIndex = 21
        '
        'RichLabel30
        '
        Me.RichLabel30.AutoSize = True
        Me.RichLabel30.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel30.Location = New System.Drawing.Point(228, 42)
        Me.RichLabel30.Name = "RichLabel30"
        Me.RichLabel30.Size = New System.Drawing.Size(490, 84)
        Me.RichLabel30.TabIndex = 2
        Me.RichLabel30.Text = "Brandon Zane" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Powers:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Werewolf Transformation (lupus-human hybrid (wolf-human hy" &
    "brid))" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Strength"
        '
        'RichLabel31
        '
        Me.RichLabel31.AutoSize = True
        Me.RichLabel31.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel31.Location = New System.Drawing.Point(228, 13)
        Me.RichLabel31.Name = "RichLabel31"
        Me.RichLabel31.Size = New System.Drawing.Size(53, 25)
        Me.RichLabel31.TabIndex = 1
        Me.RichLabel31.Text = "Tyke"
        '
        'pic_Tyke
        '
        Me.pic_Tyke.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Tyke_11
        Me.pic_Tyke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Tyke.Location = New System.Drawing.Point(12, 13)
        Me.pic_Tyke.Name = "pic_Tyke"
        Me.pic_Tyke.Size = New System.Drawing.Size(185, 325)
        Me.pic_Tyke.TabIndex = 0
        Me.pic_Tyke.TabStop = False
        '
        'panel_Bolt
        '
        Me.panel_Bolt.Controls.Add(Me.RichLabel32)
        Me.panel_Bolt.Controls.Add(Me.RichLabel33)
        Me.panel_Bolt.Controls.Add(Me.pic_Bolt)
        Me.panel_Bolt.Location = New System.Drawing.Point(8, 8)
        Me.panel_Bolt.Name = "panel_Bolt"
        Me.panel_Bolt.Size = New System.Drawing.Size(480, 344)
        Me.panel_Bolt.TabIndex = 22
        '
        'RichLabel32
        '
        Me.RichLabel32.AutoSize = True
        Me.RichLabel32.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel32.Location = New System.Drawing.Point(228, 42)
        Me.RichLabel32.Name = "RichLabel32"
        Me.RichLabel32.Size = New System.Drawing.Size(622, 336)
        Me.RichLabel32.TabIndex = 2
        Me.RichLabel32.Text = resources.GetString("RichLabel32.Text")
        '
        'RichLabel33
        '
        Me.RichLabel33.AutoSize = True
        Me.RichLabel33.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel33.Location = New System.Drawing.Point(228, 13)
        Me.RichLabel33.Name = "RichLabel33"
        Me.RichLabel33.Size = New System.Drawing.Size(48, 25)
        Me.RichLabel33.TabIndex = 1
        Me.RichLabel33.Text = "Bolt"
        '
        'pic_Bolt
        '
        Me.pic_Bolt.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Bolt_8
        Me.pic_Bolt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Bolt.Location = New System.Drawing.Point(12, 13)
        Me.pic_Bolt.Name = "pic_Bolt"
        Me.pic_Bolt.Size = New System.Drawing.Size(185, 325)
        Me.pic_Bolt.TabIndex = 0
        Me.pic_Bolt.TabStop = False
        '
        'RichLabel18
        '
        Me.RichLabel18.AutoSize = True
        Me.RichLabel18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel18.Location = New System.Drawing.Point(228, 42)
        Me.RichLabel18.Name = "RichLabel18"
        Me.RichLabel18.Size = New System.Drawing.Size(161, 168)
        Me.RichLabel18.TabIndex = 2
        Me.RichLabel18.Text = "Bruce Clay Anderson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Powers:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Telekinesis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Telekinetic force fields" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Flighted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Te" &
    "lepathy" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RichLabel19
        '
        Me.RichLabel19.AutoSize = True
        Me.RichLabel19.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel19.Location = New System.Drawing.Point(228, 13)
        Me.RichLabel19.Name = "RichLabel19"
        Me.RichLabel19.Size = New System.Drawing.Size(62, 25)
        Me.RichLabel19.TabIndex = 1
        Me.RichLabel19.Text = "Psych"
        '
        'pic_Psych
        '
        Me.pic_Psych.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Psych_6
        Me.pic_Psych.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Psych.Location = New System.Drawing.Point(12, 13)
        Me.pic_Psych.Name = "pic_Psych"
        Me.pic_Psych.Size = New System.Drawing.Size(185, 325)
        Me.pic_Psych.TabIndex = 0
        Me.pic_Psych.TabStop = False
        '
        'pic_Preview
        '
        Me.pic_Preview.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Bathroom_master
        Me.pic_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Preview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_Preview.Location = New System.Drawing.Point(0, 0)
        Me.pic_Preview.Name = "pic_Preview"
        Me.pic_Preview.Size = New System.Drawing.Size(582, 421)
        Me.pic_Preview.TabIndex = 7
        Me.pic_Preview.TabStop = False
        '
        'Form1
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.ClientSize = New System.Drawing.Size(582, 421)
        Me.Controls.Add(Me.panel_MainScreen)
        Me.Controls.Add(Me.panel_Spoilers)
        Me.Controls.Add(Me.panel_NavBar)
        Me.Controls.Add(Me.panel_Mansion)
        Me.Controls.Add(Me.panel_Map)
        Me.Controls.Add(Me.panel_Floor1)
        Me.Controls.Add(Me.panel_Floor3)
        Me.Controls.Add(Me.panel_Floor2)
        Me.Controls.Add(Me.panel_bottombar)
        Me.Controls.Add(Me.pic_Preview)
        Me.Controls.Add(Me.panel_HeroesBar)
        Me.Controls.Add(Me.panel_Avian)
        Me.Controls.Add(Me.panel_Heroes)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Image = Global.Mark_Wills.My.Resources.Resources._Mark_Wills_Books_sleek
        Me.MinimumSize = New System.Drawing.Size(592, 453)
        Me.Name = "Form1"
        Me.Text = "Mark Wills"
        Me.panel_NavBar.ResumeLayout(False)
        Me.panel_NavBar.PerformLayout()
        CType(Me.but_HomeScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_Settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_Forward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Floor1.ResumeLayout(False)
        Me.panel_Floor1.PerformLayout()
        CType(Me.pic_Floor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Floor2.ResumeLayout(False)
        Me.panel_Floor2.PerformLayout()
        CType(Me.pic_Floor2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Floor3.ResumeLayout(False)
        Me.panel_Floor3.PerformLayout()
        CType(Me.pic_Floor3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_bottombar.ResumeLayout(False)
        Me.panel_bottombar.PerformLayout()
        CType(Me.but_Load, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_Mansion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Map, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_translate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_Map, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_Universe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_HomeScreen2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_MapForward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_MapBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_HomeScreen3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_ForwardHeroes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_backHeroes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_MainScreen.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.pic_Heroes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Map.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel_Spoilers.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.panel_Heroes.ResumeLayout(False)
        Me.layout_Heroes.ResumeLayout(False)
        Me.layout_Heroes.PerformLayout()
        CType(Me.pic_AngelIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_PsychIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_AvianIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_ShiftIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_SwiftIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_WhirlwindIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_VortexIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_TykeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_BoltIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_HeroesBar.ResumeLayout(False)
        Me.panel_Avian.ResumeLayout(False)
        Me.panel_Avian.PerformLayout()
        CType(Me.pic_Avian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Psych.ResumeLayout(False)
        Me.panel_Psych.PerformLayout()
        Me.panel_Angel.ResumeLayout(False)
        Me.panel_Angel.PerformLayout()
        CType(Me.pic_Angel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Vortex.ResumeLayout(False)
        Me.panel_Vortex.PerformLayout()
        CType(Me.pic_Vortex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Whirlwind.ResumeLayout(False)
        Me.panel_Whirlwind.PerformLayout()
        CType(Me.pic_Whirlwind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Swift.ResumeLayout(False)
        Me.panel_Swift.PerformLayout()
        CType(Me.pic_Swift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Shift.ResumeLayout(False)
        Me.panel_Shift.PerformLayout()
        CType(Me.pic_Shift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Tyke.ResumeLayout(False)
        Me.panel_Tyke.PerformLayout()
        CType(Me.pic_Tyke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Bolt.ResumeLayout(False)
        Me.panel_Bolt.PerformLayout()
        CType(Me.pic_Bolt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Psych, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents pic_Floor1 As System.Windows.Forms.PictureBox
    Friend WithEvents panel_NavBar As System.Windows.Forms.Panel
    Friend WithEvents but_back As System.Windows.Forms.PictureBox
    Friend WithEvents but_Forward As System.Windows.Forms.PictureBox
    Friend WithEvents label_Fullbath_1 As System.Windows.Forms.Label
    Friend WithEvents label_Kitchen_1 As System.Windows.Forms.Label
    Friend WithEvents label_l1b1 As System.Windows.Forms.Label
    Friend WithEvents Label_l1b2 As System.Windows.Forms.Label
    Friend WithEvents Label_l1b6 As System.Windows.Forms.Label
    Friend WithEvents Label_l1b5 As System.Windows.Forms.Label
    Friend WithEvents Label_l1b4 As System.Windows.Forms.Label
    Friend WithEvents Label_l1b3 As System.Windows.Forms.Label
    Friend WithEvents label_Foyer As System.Windows.Forms.Label
    Friend WithEvents panel_Floor1 As System.Windows.Forms.Panel
    Friend WithEvents label_Mansion As System.Windows.Forms.Label
    Friend WithEvents panel_Floor2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label_l2b2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label_l2b4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label_l2b3 As System.Windows.Forms.Label
    Friend WithEvents label_l2E As System.Windows.Forms.Label
    Friend WithEvents Label_l2b6 As System.Windows.Forms.Label
    Friend WithEvents Label_l2b7 As System.Windows.Forms.Label
    Friend WithEvents pic_Floor2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label_l2b5 As System.Windows.Forms.Label
    Friend WithEvents Label_l2b1 As System.Windows.Forms.Label
    Friend WithEvents panel_Floor3 As System.Windows.Forms.Panel
    Friend WithEvents label_l3E2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label_l3b2 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label_l3b5 As System.Windows.Forms.Label
    Friend WithEvents Label_l3b4 As System.Windows.Forms.Label
    Friend WithEvents label_l3E1 As System.Windows.Forms.Label
    Friend WithEvents Label_l3b3 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label_l3b6 As System.Windows.Forms.Label
    Friend WithEvents Label_l3b1 As System.Windows.Forms.Label
    Friend WithEvents Label_l3b7 As System.Windows.Forms.Label
    Friend WithEvents pic_Floor3 As System.Windows.Forms.PictureBox
    Friend WithEvents panel_bottombar As System.Windows.Forms.Panel
    Friend WithEvents label_Floor3 As System.Windows.Forms.Label
    Friend WithEvents label_Floor2 As System.Windows.Forms.Label
    Friend WithEvents label_floor1 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pic_Preview As System.Windows.Forms.PictureBox
    Friend WithEvents but_Settings As System.Windows.Forms.PictureBox
    Friend WithEvents but_Save As System.Windows.Forms.PictureBox
    Friend WithEvents but_Load As System.Windows.Forms.PictureBox
    Friend WithEvents but_translate As System.Windows.Forms.PictureBox
    Friend WithEvents panel_Mansion As System.Windows.Forms.Panel
    Friend WithEvents panel_MainScreen As System.Windows.Forms.Panel
    Friend WithEvents but_Mansion As System.Windows.Forms.PictureBox
    Friend WithEvents RichLabel1 As Mark_Wills.RichLabel
    Friend WithEvents label_rextonian As Mark_Wills.RichLabel
    Friend WithEvents label_themansion As Mark_Wills.RichLabel
    Friend WithEvents but_HomeScreen As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Map As System.Windows.Forms.PictureBox
    Friend WithEvents label_map As Mark_Wills.RichLabel
    Friend WithEvents panel_Map As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents but_HomeScreen2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents but_MapForward As System.Windows.Forms.PictureBox
    Friend WithEvents but_MapBack As System.Windows.Forms.PictureBox
    Friend WithEvents browser_Map As System.Windows.Forms.WebBrowser
    Friend WithEvents but_Map As System.Windows.Forms.PictureBox
    Friend WithEvents but_Universe As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panel_Spoilers As System.Windows.Forms.Panel
    Friend WithEvents but_No As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents but_Yes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents label_Warning As Mark_Wills.RichLabel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents label_LockApp As Mark_Wills.RichLabel
    Friend WithEvents panel_Heroes As System.Windows.Forms.Panel
    Friend WithEvents layout_Heroes As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pic_AvianIcon As System.Windows.Forms.PictureBox
    Friend WithEvents pic_AngelIcon As System.Windows.Forms.PictureBox
    Friend WithEvents pic_PsychIcon As System.Windows.Forms.PictureBox
    Friend WithEvents RichLabel6 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel12 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel9 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel8 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel7 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel11 As Mark_Wills.RichLabel
    Friend WithEvents pic_WhirlwindIcon As System.Windows.Forms.PictureBox
    Friend WithEvents pic_SwiftIcon As System.Windows.Forms.PictureBox
    Friend WithEvents pic_ShiftIcon As System.Windows.Forms.PictureBox
    Friend WithEvents RichLabel10 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel13 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel14 As Mark_Wills.RichLabel
    Friend WithEvents pic_VortexIcon As System.Windows.Forms.PictureBox
    Friend WithEvents pic_TykeIcon As System.Windows.Forms.PictureBox
    Friend WithEvents pic_BoltIcon As System.Windows.Forms.PictureBox
    Friend WithEvents panel_HeroesBar As System.Windows.Forms.Panel
    Friend WithEvents but_HomeScreen3 As System.Windows.Forms.PictureBox
    Friend WithEvents but_ForwardHeroes As System.Windows.Forms.PictureBox
    Friend WithEvents but_backHeroes As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Heroes As System.Windows.Forms.PictureBox
    Friend WithEvents label_TheHeroes As Mark_Wills.RichLabel
    Friend WithEvents panel_Avian As System.Windows.Forms.Panel
    Friend WithEvents pic_Avian As System.Windows.Forms.PictureBox
    Friend WithEvents label_Avian As Mark_Wills.RichLabel
    Friend WithEvents RichLabel16 As Mark_Wills.RichLabel
    Friend WithEvents panel_Psych As System.Windows.Forms.Panel
    Friend WithEvents panel_Angel As System.Windows.Forms.Panel
    Friend WithEvents RichLabel20 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel21 As Mark_Wills.RichLabel
    Friend WithEvents pic_Angel As System.Windows.Forms.PictureBox
    Friend WithEvents RichLabel18 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel19 As Mark_Wills.RichLabel
    Friend WithEvents pic_Psych As System.Windows.Forms.PictureBox
    Friend WithEvents panel_Vortex As System.Windows.Forms.Panel
    Friend WithEvents RichLabel22 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel23 As Mark_Wills.RichLabel
    Friend WithEvents pic_Vortex As System.Windows.Forms.PictureBox
    Friend WithEvents panel_Whirlwind As System.Windows.Forms.Panel
    Friend WithEvents RichLabel24 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel25 As Mark_Wills.RichLabel
    Friend WithEvents pic_Whirlwind As System.Windows.Forms.PictureBox
    Friend WithEvents panel_Swift As System.Windows.Forms.Panel
    Friend WithEvents RichLabel26 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel27 As Mark_Wills.RichLabel
    Friend WithEvents pic_Swift As System.Windows.Forms.PictureBox
    Friend WithEvents panel_Shift As System.Windows.Forms.Panel
    Friend WithEvents RichLabel28 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel29 As Mark_Wills.RichLabel
    Friend WithEvents pic_Shift As System.Windows.Forms.PictureBox
    Friend WithEvents panel_Tyke As System.Windows.Forms.Panel
    Friend WithEvents RichLabel30 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel31 As Mark_Wills.RichLabel
    Friend WithEvents pic_Tyke As System.Windows.Forms.PictureBox
    Friend WithEvents panel_Bolt As System.Windows.Forms.Panel
    Friend WithEvents RichLabel32 As Mark_Wills.RichLabel
    Friend WithEvents RichLabel33 As Mark_Wills.RichLabel
    Friend WithEvents pic_Bolt As System.Windows.Forms.PictureBox

#End Region

End Class
