'Option Strict On
Imports System.Runtime.InteropServices
Imports System.ComponentModel


Partial Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Initialize"

    Shared Sub New()
        ' DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.ResizeRedraw, True)
        DoubleBuffered = True

        'DrawTitleBarButton()
      
    End Sub


#End Region

#Region " Declarations"

    Dim FloorLevel As Integer = 1
    ' Dim IsPicPreview As Boolean = False


    Private _IsPicPreview As Boolean

    Public Property IsPicPreview() As Boolean
        Get
            Return Me._IsPicPreview
        End Get
        Set(ByVal value As Boolean)
            If Me._IsPicPreview <> value Then
                Me._IsPicPreview = value

                'The value of the property has changed so raise the event.
                Me.OnFlagChanged(EventArgs.Empty)
            End If
        End Set
    End Property

    Public Event FlagChanged As EventHandler

    Protected Overridable Sub OnFlagChanged(ByVal e As EventArgs)
        RaiseEvent FlagChanged(Me, e)
        If IsPicPreview Then
            ToolTip1.SetToolTip(but_back, "Go Back")
            but_Forward.Enabled = False
        Else
            ToolTip1.SetToolTip(but_back, "Decrease Floor Level")
            but_Forward.Enabled = True
        End If
    End Sub

#End Region


#Region " Are you sure?"

    Private Sub ViewSpoilerWarning_Click(sender As Object, e As EventArgs) Handles label_LockApp.Click
        panel_Spoilers.BringToFront()
    End Sub



    Private Sub but_Yes_Click(sender As Object, e As EventArgs) Handles but_Yes.Click
        panel_MainScreen.BringToFront()
    End Sub

    Private Sub but_No_Click(sender As Object, e As EventArgs) Handles but_No.Click
        Application.Exit()
    End Sub

#End Region

#Region " Load"

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TopMostCBform.cb_TopMost.ForeColor = Color.FromArgb(224, 224, 224)
        TopMostCBform.BackColor = Color.FromArgb(79, 79, 79)

        LockFormvb.but_Lock.ForeColor = Color.FromArgb(224, 224, 224)
        LockFormvb.BackColor = Color.FromArgb(79, 79, 79)
    End Sub
    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        TopMostCBform.cb_TopMost.ForeColor = Color.Gray
        TopMostCBform.BackColor = Color.FromArgb(84, 84, 84)

        LockFormvb.but_Lock.ForeColor = Color.Gray
        LockFormvb.BackColor = Color.FromArgb(84, 84, 84)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_Spoilers.BringToFront()
        Me.Location = My.Settings.location

        SetParents()



        RefreshFloorLevel()

        RefreshLabels()
        GetHeroesInfo()

        DrawItems()



    End Sub

    Public Sub SetParents()
        panel_NavBar.Parent = panel_Mansion
        panel_NavBar.Dock = DockStyle.Top
        panel_Floor1.Parent = panel_Mansion
        panel_Floor2.Parent = panel_Mansion

        panel_Floor3.Parent = panel_Mansion
        panel_HeroesBar.Parent = panel_Heroes
        panel_HeroesBar.Dock = DockStyle.Top
        panel_Avian.Dock = DockStyle.Fill
        panel_Avian.Parent = panel_Heroes
        panel_Psych.Dock = DockStyle.Fill
        panel_Psych.Parent = panel_Heroes
        panel_Angel.Dock = DockStyle.Fill
        panel_Angel.Parent = panel_Heroes
        panel_Vortex.Dock = DockStyle.Fill
        panel_Vortex.Parent = panel_Heroes
        panel_Shift.Dock = DockStyle.Fill
        panel_Shift.Parent = panel_Heroes
        panel_Swift.Dock = DockStyle.Fill
        panel_Swift.Parent = panel_Heroes
        panel_Whirlwind.Dock = DockStyle.Fill
        panel_Whirlwind.Parent = panel_Heroes
        panel_Tyke.Dock = DockStyle.Fill
        panel_Tyke.Parent = panel_Heroes
        panel_Bolt.Dock = DockStyle.Fill
        panel_Bolt.Parent = panel_Heroes
        panel_bottombar.Parent = panel_Mansion

        label_Fullbath_1.Parent = pic_Floor1
        label_Kitchen_1.Parent = pic_Floor1
        label_Foyer.Parent = pic_Floor1
        label_l1b1.Parent = pic_Floor1
        Label_l1b2.Parent = pic_Floor1
        Label_l1b3.Parent = pic_Floor1
        Label_l1b4.Parent = pic_Floor1
        Label_l1b5.Parent = pic_Floor1
        Label_l1b6.Parent = pic_Floor1

        Label8.Parent = pic_Floor2
        Label15.Parent = pic_Floor2
        Label10.Parent = pic_Floor2
        label_l2E.Parent = pic_Floor2
        Label6.Parent = pic_Floor2
        Label16.Parent = pic_Floor2
        Label17.Parent = pic_Floor2
        Label_l2b1.Parent = pic_Floor2
        Label_l2b2.Parent = pic_Floor2
        Label_l2b3.Parent = pic_Floor2
        Label_l2b4.Parent = pic_Floor2
        Label_l2b5.Parent = pic_Floor2
        Label_l2b6.Parent = pic_Floor2
        Label_l2b7.Parent = pic_Floor2

        Label25.Parent = pic_Floor3
        Label24.Parent = pic_Floor3
        label_l3E1.Parent = pic_Floor3
        label_l3E2.Parent = pic_Floor3
        Label30.Parent = pic_Floor3
        Label22.Parent = pic_Floor3
        Label_l3b1.Parent = pic_Floor3
        Label_l3b2.Parent = pic_Floor3
        Label_l3b3.Parent = pic_Floor3
        Label_l3b4.Parent = pic_Floor3
        Label_l3b5.Parent = pic_Floor3
        Label_l3b6.Parent = pic_Floor3
        Label_l3b7.Parent = pic_Floor3

    End Sub


#End Region


#Region " Home Screen"


    Dim WasTop As Boolean = False
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles but_translate.Click
        Dim xform As New Rextonian
        AddHandler xform.FormClosed, AddressOf xfrom_Close
        If topmostcbform.cb_topmost.Checked Then
            WasTop = True
        Else
            WasTop = False
        End If
        topmostcbform.cb_topmost.Checked = False
        xform.ShowDialog()

        xform.BringToFront()
    End Sub
    Public Sub xfrom_Close()
        If WasTop Then
            topmostcbform.cb_topmost.Checked = True
        Else
            topmostcbform.cb_topmost.Checked = False
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.location = Me.Location
        My.Settings.pintotop = topmostcbform.cb_topmost.Checked
        My.Settings.Save()
    End Sub

    Private Sub but_Mansion_Click(sender As Object, e As EventArgs) Handles but_Mansion.Click
        panel_Mansion.Visible = True
        panel_Mansion.BringToFront()
    End Sub

    Private Sub but_HomeScreen_Click(sender As Object, e As EventArgs) Handles but_HomeScreen.Click, but_HomeScreen2.Click, but_HomeScreen3.Click
        panel_MainScreen.BringToFront()
    End Sub

    Private Sub pic_Map_Click(sender As Object, e As EventArgs) Handles pic_Map.Click
        panel_Map.Visible = True
        panel_Map.BringToFront()
    End Sub


#End Region


#Region " Mansion"

#Region " Floor Levels"


    Public Sub RefreshFloorLevel()

        Select Case FloorLevel
            Case 1
                panel_Floor1.BringToFront()
                label_floor1.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                label_Floor2.Font = New Font("Segoe UI", 12, FontStyle.Regular)
                label_Floor3.Font = New Font("Segoe UI", 12, FontStyle.Regular)
                pic_Preview.Parent = panel_Floor1
                pic_Preview.SendToBack()
            Case 2
                panel_Floor2.BringToFront()
                label_floor1.Font = New Font("Segoe UI", 12, FontStyle.Regular)
                label_Floor2.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                label_Floor3.Font = New Font("Segoe UI", 12, FontStyle.Regular)
                pic_Preview.Parent = panel_Floor2
                pic_Preview.SendToBack()
            Case 3
                panel_Floor3.BringToFront()
                label_floor1.Font = New Font("Segoe UI", 12, FontStyle.Regular)
                label_Floor2.Font = New Font("Segoe UI", 12, FontStyle.Regular)
                label_Floor3.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                pic_Preview.Parent = panel_Floor3
                pic_Preview.SendToBack()
        End Select

    End Sub



    Private Sub but_back_Click(sender As Object, e As EventArgs) Handles but_back.Click
        If IsPicPreview = True Then

            IsPicPreview = False
        Else
            Select Case FloorLevel
                Case 1
                    FloorLevel = 1
                Case 2
                    FloorLevel = 1
                Case 3
                    FloorLevel = 2
            End Select

        End If
        RefreshFloorLevel()

    End Sub

    Private Sub but_Forward_Click(sender As Object, e As EventArgs) Handles but_Forward.Click
        If IsPicPreview = True Then

            Return
        End If

        Select Case FloorLevel
            Case 1
                FloorLevel = 2
            Case 2
                FloorLevel = 3
            Case 3
                FloorLevel = 3
        End Select
        RefreshFloorLevel()
    End Sub

    Private Sub label_floor1_Click(sender As Object, e As EventArgs) Handles label_floor1.Click
        IsPicPreview = False
        FloorLevel = 1
        RefreshFloorLevel()
    End Sub

    Private Sub label_Floor2_Click(sender As Object, e As EventArgs) Handles label_Floor2.Click
        IsPicPreview = False
        FloorLevel = 2
        RefreshFloorLevel()
    End Sub

    Private Sub label_Floor3_Click(sender As Object, e As EventArgs) Handles label_Floor3.Click
        IsPicPreview = False
        FloorLevel = 3
        RefreshFloorLevel()
    End Sub


#End Region

#Region " Labels"


#Region " Text"

    Public Sub RefreshLabels()
        label_l1b1.Text = "Bedroom" & Environment.NewLine & My.Settings.l1b1
        Label_l1b2.Text = "Bedroom" & Environment.NewLine & My.Settings.l1b2
        Label_l1b3.Text = "Bedroom" & Environment.NewLine & My.Settings.l1b3
        Label_l1b4.Text = "Bedroom" & Environment.NewLine & My.Settings.l1b4
        Label_l1b5.Text = "Bedroom" & Environment.NewLine & My.Settings.l1b5
        Label_l1b6.Text = "Bedroom" & Environment.NewLine & My.Settings.l1b6
        Label_l2b1.Text = "Bedroom" & Environment.NewLine & My.Settings.l2b1
        Label_l2b2.Text = "Bedroom" & Environment.NewLine & My.Settings.l2b2
        Label_l2b3.Text = "Bedroom" & Environment.NewLine & My.Settings.l2b3
        Label_l2b4.Text = "Bedroom" & Environment.NewLine & My.Settings.l2b4
        Label_l2b5.Text = "Bedroom" & Environment.NewLine & My.Settings.l2b5
        Label_l2b6.Text = "Bedroom" & Environment.NewLine & My.Settings.l2b6
        Label_l2b7.Text = "Bedroom" & Environment.NewLine & My.Settings.l2b7
        Label_l3b1.Text = "Bedroom" & Environment.NewLine & My.Settings.l3b1
        Label_l3b2.Text = "Bedroom" & Environment.NewLine & My.Settings.l3b2
        Label_l3b3.Text = "Bedroom" & Environment.NewLine & My.Settings.l3b3
        Label_l3b4.Text = "Bedroom" & Environment.NewLine & My.Settings.l3b4
        Label_l3b5.Text = "Bedroom" & Environment.NewLine & My.Settings.l3b5
        Label_l3b6.Text = "Bedroom" & Environment.NewLine & My.Settings.l3b6
        Label_l3b7.Text = "Bedroom" & Environment.NewLine & My.Settings.l3b7

    End Sub


#End Region

#Region " Clicks"

    Private Sub Bathroom_Master_Click(sender As Object, e As EventArgs) Handles label_Fullbath_1.Click
        IsPicPreview = True
        pic_Preview.BackgroundImage = My.Resources.Bathroom_master
        pic_Preview.BringToFront()


    End Sub

    Private Sub Bathrooms_Click(sender As Object, e As EventArgs) Handles Label8.Click, Label15.Click, Label25.Click, Label24.Click
        IsPicPreview = True
        pic_Preview.BackgroundImage = My.Resources.Bathroom_half
        pic_Preview.BringToFront()

    End Sub


    Private Sub Bedrooms_Click(sender As Object, e As EventArgs) Handles Label_l1b3.Click, Label_l1b4.Click, Label_l1b5.Click, Label_l1b6.Click, Label_l1b2.Click, label_l1b1.Click, _
        Label_l2b4.Click, Label_l2b2.Click, Label_l2b5.Click, Label_l2b1.Click, Label_l2b7.Click, Label_l2b6.Click, Label_l2b3.Click, Label_l3b7.Click, Label_l3b1.Click, _
        Label_l3b6.Click, Label_l3b3.Click, Label_l3b4.Click, Label_l3b5.Click, Label_l3b2.Click

        IsPicPreview = True
        ''  MsgBox(sender.name)
        If sender.name = "label_l1b1" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_2
        ElseIf sender.name = "Label_l1b3" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_4
        ElseIf sender.name = "Label_l1b4" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_4
        ElseIf sender.name = "Label_l1b5" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_4
        ElseIf sender.name = "Label_l1b6" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_4
        ElseIf sender.name = "Label_l2b2" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_4
        ElseIf sender.name = "Label_l2b3" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_3
        ElseIf sender.name = "Label_l2b4" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_4
        ElseIf sender.name = "Label_l2b5" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_small
        ElseIf sender.name = "Label_l2b6" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_4
        ElseIf sender.name = "Label_l2b7" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_4
        ElseIf sender.name = "Label_l3b1" Then
            pic_Preview.BackgroundImage = My.Resources.bedroom3_corner
        ElseIf sender.name = "Label_l3b2" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_4
        ElseIf sender.name = "Label_l3b3" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_4
        ElseIf sender.name = "Label_l3b4" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_3
        ElseIf sender.name = "Label_l3b5" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_Small2
        ElseIf sender.name = "Label_l3b6" Then
            pic_Preview.BackgroundImage = My.Resources.Bedroom_4
        ElseIf sender.name = "Label_l3b7" Then
            pic_Preview.BackgroundImage = My.Resources.bedroom3_bottom_corner


        Else
            pic_Preview.BackgroundImage = My.Resources.Bedroom_1
        End If
        pic_Preview.BringToFront()
        but_Forward.Enabled = False

    End Sub


    Private Sub DiningRoom_Kitchen_Click(sender As Object, e As EventArgs) Handles label_Kitchen_1.Click
        IsPicPreview = True
        pic_Preview.BackgroundImage = My.Resources.Dining_Room_kitchen2
        pic_Preview.BringToFront()
        but_Forward.Enabled = False

    End Sub


    Private Sub DiningRoom_Click(sender As Object, e As EventArgs) Handles Label17.Click
        IsPicPreview = True
        pic_Preview.BackgroundImage = My.Resources.Dining_Room_single
        pic_Preview.BringToFront()
        but_Forward.Enabled = False

    End Sub

    Private Sub CommonRoom_Click(sender As Object, e As EventArgs) Handles Label10.Click
        IsPicPreview = True
        pic_Preview.BackgroundImage = My.Resources.Common_Room
        pic_Preview.BringToFront()
        but_Forward.Enabled = False

    End Sub


    Private Sub Entertainment_Click(sender As Object, e As EventArgs) Handles label_l2E.Click, label_l3E1.Click, label_l3E2.Click
        IsPicPreview = True
        If sender.name = "label_l2E" Then
            pic_Preview.BackgroundImage = My.Resources.Entertainment_Room2
        ElseIf sender.name = "label_l3E1" Then
            pic_Preview.BackgroundImage = My.Resources.Entertainment_Room2
        Else
            pic_Preview.BackgroundImage = My.Resources.Entertainment_Room
        End If

        pic_Preview.BringToFront()
        but_Forward.Enabled = False

    End Sub

    Private Sub label_Mansion_Click(sender As Object, e As EventArgs) Handles label_Mansion.Click
        IsPicPreview = True
        pic_Preview.BackgroundImage = My.Resources.The_Mansion_Real
        pic_Preview.BringToFront()
        but_Forward.Enabled = False

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click, Label6.Click
        IsPicPreview = True
        pic_Preview.BackgroundImage = My.Resources.large_spare

        pic_Preview.BringToFront()
        but_Forward.Enabled = False

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        IsPicPreview = True
        pic_Preview.BackgroundImage = My.Resources.spare2

        pic_Preview.BringToFront()
        but_Forward.Enabled = False
    End Sub


    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        IsPicPreview = True
        pic_Preview.BackgroundImage = My.Resources.small_spare

        pic_Preview.BringToFront()
        but_Forward.Enabled = False

    End Sub


    Private Sub label_Foyer_Click(sender As Object, e As EventArgs) Handles label_Foyer.Click
        IsPicPreview = True
        pic_Preview.BackgroundImage = My.Resources.foyer1

        pic_Preview.BringToFront()
        but_Forward.Enabled = False

    End Sub

#End Region


#End Region

#Region " Mansion Settings"







    Private Sub but_Settings_Click(sender As Object, e As EventArgs) Handles but_Settings.Click
        If TopMostCBform.cb_TopMost.Checked Then
            WasTop = True
        Else
            WasTop = False
        End If
        TopMostCBform.cb_TopMost.Checked = False
        Dim xform As New SettingsForm
        If xform.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshLabels()

        End If

    End Sub


    Public Shared Sub BackupSettings()
        Dim SettingsFile As String = _
         System.Configuration.ConfigurationManager.OpenExeConfiguration( _
             System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath()

        Dim sDialog As New SaveFileDialog()
        sDialog.DefaultExt = ".config"
        sDialog.Filter = "Mark Wills Book Configuration|*.config"
        sDialog.Title = "Backup Mark Wills Book Configuration"

        If sDialog.ShowDialog() = DialogResult.OK Then
            My.Settings.Save()
            IO.File.Copy(SettingsFile, sDialog.FileName, True)
            My.Settings.Save()

            '   MyMsgBox.Show("Please make separate backups for your playlists! These will not be backed up.", "Backup Your Playlists!", True)


        End If

    End Sub
    Public Shared Sub RestoreSettings()
        Dim SettingsFile As String = _
    System.Configuration.ConfigurationManager.OpenExeConfiguration( _
        System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath()

        Dim sDialog As New OpenFileDialog()
        sDialog.DefaultExt = ".config"
        sDialog.Filter = "Mark Wills Book Configuration|*.config"
        sDialog.Title = "Restore Mark Wills Book Configuration"

        If sDialog.ShowDialog() = DialogResult.OK Then
            Dim result As Integer = MyFullMsgBox.Show("This will close the app and the settings will be restored upon manual restart.", _
                                                                  "Are you sure you want to restore settings?", True, MyFullMsgBox.CustomButtons.YesNo)
            If result = DialogResult.Yes Then
                IO.File.Copy(sDialog.FileName, SettingsFile, True)
                Process.GetCurrentProcess.Kill()
            End If

        End If

    End Sub

    Private Sub but_Save_Click(sender As Object, e As EventArgs) Handles but_Save.Click
        BackupSettings()
    End Sub

    Private Sub but_Load_Click(sender As Object, e As EventArgs) Handles but_Load.Click
        RestoreSettings()
    End Sub



#End Region


#End Region

#Region " Map"
    Dim page As String

    Private Sub but_Map_Click(sender As Object, e As EventArgs) Handles but_Map.Click
        panel_Map.BringToFront()
        browser_Map.Navigate("https://www.google.com/maps/d/u/0/viewer?mid=1z_4E2EWtTXXiVaarwltixSJgzGpaLbct&ll=47.39375488285067%2C-44.614047300000024&z=4")
    End Sub
    Private Sub but_Universe_Click(sender As Object, e As EventArgs) Handles but_Universe.Click
        panel_Map.BringToFront()

        browser_Map.Navigate("file:///" & Application.StartupPath & "/HTML/Universe-Overview.html")
        page = "Universe"
    End Sub

    Private Sub browser_Map_NewWindow(sender As Object, e As CancelEventArgs) Handles browser_Map.NewWindow
        e.Cancel = True
        browser_Map.Navigate(browser_Map.StatusText)
    End Sub




    Private Sub but_MapBack_Click(sender As Object, e As EventArgs) Handles but_MapBack.Click
        browser_Map.GoBack()
    End Sub

    Private Sub but_MapForward_Click(sender As Object, e As EventArgs) Handles but_MapForward.Click
        browser_Map.GoForward()
    End Sub


#End Region

#Region " Heroes"

    Public Sub GetHeroesInfo()
        label_Avian.Text = IO.File.ReadAllText(Application.StartupPath & "\avian.txt").Replace(Chr(9), "     ")
        Dim scroller_avian As New HeroScroller
        panel_Avian.Controls.Add(scroller_avian)
        label_Avian.TextAlign = ContentAlignment.TopLeft
        scroller_avian.Parent = label_Avian.Parent
        scroller_avian.Controls.Add(label_Avian)
        label_Avian.Location = New Point(0, 0)

        RichLabel18.Text = IO.File.ReadAllText(Application.StartupPath & "\psych.txt").Replace(Chr(9), "     ")
        Dim scroller_psych As New HeroScroller
        RichLabel18.Controls.Add(scroller_psych)
        RichLabel18.TextAlign = ContentAlignment.TopLeft
        scroller_psych.Parent = RichLabel18.Parent
        scroller_psych.Controls.Add(RichLabel18)
        RichLabel18.Location = New Point(0, 0)

        RichLabel20.Text = IO.File.ReadAllText(Application.StartupPath & "\angel.txt").Replace(Chr(9), "     ")
        Dim scroller_angel As New HeroScroller
        panel_Angel.Controls.Add(scroller_angel)
        RichLabel20.TextAlign = ContentAlignment.TopLeft
        scroller_angel.Parent = RichLabel20.Parent
        scroller_angel.Controls.Add(RichLabel20)
        RichLabel20.Location = New Point(0, 0)

        RichLabel22.Text = IO.File.ReadAllText(Application.StartupPath & "\vortex.txt").Replace(Chr(9), "     ")
        Dim scroller_vortex As New HeroScroller
        panel_Vortex.Controls.Add(scroller_vortex)
        RichLabel22.TextAlign = ContentAlignment.TopLeft
        scroller_vortex.Parent = RichLabel22.Parent
        scroller_vortex.Controls.Add(RichLabel22)
        RichLabel22.Location = New Point(0, 0)

        RichLabel24.Text = IO.File.ReadAllText(Application.StartupPath & "\whirlwind.txt").Replace(Chr(9), "     ")
        Dim scroller_whirlwind As New HeroScroller
        panel_Whirlwind.Controls.Add(scroller_whirlwind)
        RichLabel24.TextAlign = ContentAlignment.TopLeft
        scroller_whirlwind.Parent = RichLabel24.Parent
        scroller_whirlwind.Controls.Add(RichLabel24)
        RichLabel24.Location = New Point(0, 0)

        RichLabel26.Text = IO.File.ReadAllText(Application.StartupPath & "\swift.txt").Replace(Chr(9), "     ")
        Dim scroller_swift As New HeroScroller
        panel_Swift.Controls.Add(scroller_swift)
        RichLabel26.TextAlign = ContentAlignment.TopLeft
        scroller_swift.Parent = RichLabel26.Parent
        scroller_swift.Controls.Add(RichLabel26)
        RichLabel26.Location = New Point(0, 0)

        RichLabel28.Text = IO.File.ReadAllText(Application.StartupPath & "\shift.txt").Replace(Chr(9), "     ")
        Dim scroller_shift As New HeroScroller
        panel_Shift.Controls.Add(scroller_shift)
        RichLabel28.TextAlign = ContentAlignment.TopLeft
        scroller_shift.Parent = RichLabel28.Parent
        scroller_shift.Controls.Add(RichLabel28)
        RichLabel28.Location = New Point(0, 0)

        RichLabel30.Text = IO.File.ReadAllText(Application.StartupPath & "\tyke.txt").Replace(Chr(9), "     ")
        Dim scroller_tyke As New HeroScroller
        panel_Tyke.Controls.Add(scroller_tyke)
        RichLabel30.TextAlign = ContentAlignment.TopLeft
        scroller_tyke.Parent = RichLabel30.Parent
        scroller_tyke.Controls.Add(RichLabel30)
        RichLabel30.Location = New Point(0, 0)

        RichLabel32.Text = IO.File.ReadAllText(Application.StartupPath & "\bolt.txt").Replace(Chr(9), "     ")
        Dim scroller_bolt As New HeroScroller
        panel_Bolt.Controls.Add(scroller_bolt)
        RichLabel32.TextAlign = ContentAlignment.TopLeft
        scroller_bolt.Parent = RichLabel32.Parent
        scroller_bolt.Controls.Add(RichLabel32)
        RichLabel32.Location = New Point(0, 0)


    End Sub


    ' Nav buttons
    Private Sub but_backHeroes_Click(sender As Object, e As EventArgs) Handles but_backHeroes.Click
        panel_Heroes.BringToFront()
        panel_Avian.SendToBack()
        panel_Psych.SendToBack()
        panel_Angel.SendToBack()
        panel_Vortex.SendToBack()
        panel_Whirlwind.SendToBack()
        panel_Swift.SendToBack()
        panel_Shift.SendToBack()
        panel_Tyke.SendToBack()
        panel_Bolt.SendToBack()
    End Sub
    Private Sub but_ForwardHeroes_Click(sender As Object, e As EventArgs) Handles but_ForwardHeroes.Click

    End Sub


    Private Sub pic_Heroes_Click(sender As Object, e As EventArgs) Handles pic_Heroes.Click
        panel_Heroes.BringToFront()

        Return
        Dim xpanel As New Heroes_Avian
        xpanel.Dock = DockStyle.Fill
        panel_Heroes.Controls.Add(xpanel)
        xpanel.BringToFront()
    End Sub
    Private Sub pic_AvianIcon_Click(sender As Object, e As EventArgs) Handles pic_AvianIcon.Click
        panel_Avian.BringToFront()
    End Sub
    Private Sub pic_PsychIcon_Click(sender As Object, e As EventArgs) Handles pic_PsychIcon.Click
        panel_Psych.BringToFront()

    End Sub

    Private Sub pic_AngelIcon_Click(sender As Object, e As EventArgs) Handles pic_AngelIcon.Click
        panel_Angel.BringToFront()

    End Sub

    Private Sub pic_VortexIcon_Click(sender As Object, e As EventArgs) Handles pic_VortexIcon.Click
        panel_Vortex.BringToFront()


    End Sub

    Private Sub pic_WhirlwindIcon_Click(sender As Object, e As EventArgs) Handles pic_WhirlwindIcon.Click
        panel_Whirlwind.BringToFront()

    End Sub

    Private Sub pic_SwiftIcon_Click(sender As Object, e As EventArgs) Handles pic_SwiftIcon.Click
        panel_Swift.BringToFront()

    End Sub

    Private Sub pic_ShiftIcon_Click(sender As Object, e As EventArgs) Handles pic_ShiftIcon.Click
        panel_Shift.BringToFront()

    End Sub

    Private Sub pic_TykeIcon_Click(sender As Object, e As EventArgs) Handles pic_TykeIcon.Click
        panel_Tyke.BringToFront()

    End Sub

    Private Sub pic_BoltIcon_Click(sender As Object, e As EventArgs) Handles pic_BoltIcon.Click
        panel_Bolt.BringToFront()

    End Sub



#Region " Zoom in on Picture"


    Dim CurrentImage As Image
    Public Sub Zoom()
        If topmostcbform.cb_topmost.Checked Then
            WasTop = True
        Else
            WasTop = False
        End If
        Dim pictureform As New Form
        pictureform.Name = "pictureform"
        topmostcbform.cb_topmost.Checked = False
        AddHandler pictureform.FormClosed, AddressOf xfrom_Close
        pictureform.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        AddHandler pictureform.KeyUp, AddressOf pictureform_keyup
        AddHandler pictureform.Click, AddressOf pictureform_keyup
        pictureform.FormBorderStyle = FormBorderStyle.None
        pictureform.BackgroundImage = CurrentImage
        pictureform.BackgroundImageLayout = ImageLayout.Zoom
        pictureform.BackColor = Color.FromArgb(90, 90, 90)
        pictureform.ShowInTaskbar = False
        pictureform.Show()
        pictureform.Location = Me.Location
        pictureform.WindowState = FormWindowState.Maximized
    End Sub
    Public Sub pictureform_keyup()
        Dim pictureform As Form
        For Each f As Form In Application.OpenForms
            If f.Name = "pictureform" Then
                pictureform = f
            End If
        Next
        pictureform.WindowState = FormWindowState.Normal
        pictureform.Close()
    End Sub

    Private Sub pic_Avian_Click(sender As Object, e As EventArgs) Handles pic_Avian.Click, pic_Psych.Click, pic_Angel.Click, pic_Vortex.Click, pic_Whirlwind.Click, _
        pic_Swift.Click, pic_Shift.Click, pic_Tyke.Click, pic_Bolt.Click
        CurrentImage = sender.backgroundimage
        Zoom()
    End Sub


#End Region

#End Region


#Region " Graphics"

    Private Sub label_Fullbath_1_MouseEnter(sender As Object, e As EventArgs) Handles label_Fullbath_1.MouseEnter, Label8.MouseEnter, _
        Label15.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label_l1b3.MouseEnter, Label_l1b4.MouseEnter, Label_l1b5.MouseEnter, Label_l1b6.MouseEnter, Label_l1b2.MouseEnter, label_l1b1.MouseEnter, _
        Label_l2b4.MouseEnter, Label_l2b2.MouseEnter, Label_l2b5.MouseEnter, Label_l2b1.MouseEnter, Label_l2b7.MouseEnter, Label_l2b6.MouseEnter, Label_l2b3.MouseEnter, Label16.MouseEnter, Label_l3b7.MouseEnter, Label_l3b1.MouseEnter, _
        Label_l3b6.MouseEnter, Label_l3b3.MouseEnter, Label_l3b4.MouseEnter, Label_l3b5.MouseEnter, Label_l3b2.MouseEnter, Label22.MouseEnter, label_Kitchen_1.MouseEnter, Label17.MouseEnter, _
        Label10.MouseEnter, label_l2E.MouseEnter, label_l3E1.MouseEnter, label_l3E2.MouseEnter, label_Mansion.MouseEnter, Label6.MouseEnter, Label30.MouseEnter, label_Foyer.MouseEnter

        If sender.name = "label_Mansion" Then
            label_Mansion.ForeColor = Color.White
        Else
            sender.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        End If

    End Sub

    Private Sub label_Fullbath_1_MouseLeave(sender As Object, e As EventArgs) Handles label_Fullbath_1.MouseLeave, Label8.MouseLeave, _
        Label15.MouseLeave, Label25.MouseLeave, Label24.MouseLeave, Label_l1b3.MouseLeave, Label_l1b4.MouseLeave, Label_l1b5.MouseLeave, Label_l1b6.MouseLeave, Label_l1b2.MouseLeave, label_l1b1.MouseLeave, _
        Label_l2b4.MouseLeave, Label_l2b2.MouseLeave, Label_l2b5.MouseLeave, Label_l2b1.MouseLeave, Label_l2b7.MouseLeave, Label_l2b6.MouseLeave, Label_l2b3.MouseLeave, Label16.MouseLeave, Label_l3b7.MouseLeave, Label_l3b1.MouseLeave, _
        Label_l3b6.MouseLeave, Label_l3b3.MouseLeave, Label_l3b4.MouseLeave, Label_l3b5.MouseLeave, Label_l3b2.MouseLeave, Label22.MouseLeave, label_Kitchen_1.MouseLeave, Label17.MouseLeave, _
        Label10.MouseLeave, label_l2E.MouseLeave, label_l3E1.MouseLeave, label_l3E2.MouseLeave, label_Mansion.MouseLeave, Label6.MouseLeave, Label30.MouseLeave, label_Foyer.MouseLeave


        If sender.name = "label_Mansion" Then
            label_Mansion.ForeColor = Color.Silver
        Else
            sender.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        End If

    End Sub

    Private Sub label_floor1_MouseEnter(sender As Object, e As EventArgs) Handles label_floor1.MouseEnter, label_Floor2.MouseEnter, label_Floor3.MouseEnter
        sender.ForeColor = Color.White
    End Sub

    Private Sub label_floor1_MouseLeave(sender As Object, e As EventArgs) Handles label_floor1.MouseLeave, label_Floor2.MouseLeave, label_Floor3.MouseLeave
        sender.ForeColor = Color.Silver
    End Sub


    Dim backhover As Boolean = False
    Private Sub but_back_MouseEnter(sender As Object, e As EventArgs) Handles but_back.MouseEnter
        but_back.BackgroundImage = My.Resources.SwitchBack_Hover
        backhover = True
    End Sub

    Private Sub but_back_MouseLeave(sender As Object, e As EventArgs) Handles but_back.MouseLeave
        but_back.BackgroundImage = My.Resources.SwitchBack
        backhover = False
    End Sub

    Private Sub but_back_MouseUp(sender As Object, e As MouseEventArgs) Handles but_back.MouseUp
        If backhover Then
            but_back.BackgroundImage = My.Resources.SwitchBack_Hover
        Else
            but_back.BackgroundImage = My.Resources.SwitchBack
        End If
    End Sub

    Private Sub but_back_MouseDown(sender As Object, e As MouseEventArgs) Handles but_back.MouseDown
        but_back.BackgroundImage = My.Resources.SwitchBack_Press
    End Sub




    Dim forwardhover As Boolean = False
    Private Sub but_forward_MouseEnter(sender As Object, e As EventArgs) Handles but_Forward.MouseEnter
        but_Forward.BackgroundImage = My.Resources.SwitchForward_Hover
        forwardhover = True
    End Sub

    Private Sub but_forward_MouseLeave(sender As Object, e As EventArgs) Handles but_Forward.MouseLeave
        but_Forward.BackgroundImage = My.Resources.SwitchForward
        forwardhover = False
    End Sub

    Private Sub but_forward_MouseUp(sender As Object, e As MouseEventArgs) Handles but_Forward.MouseUp
        If forwardhover Then
            but_Forward.BackgroundImage = My.Resources.SwitchForward_Hover
        Else
            but_Forward.BackgroundImage = My.Resources.SwitchForward
        End If
    End Sub

    Private Sub but_forward_MouseDown(sender As Object, e As MouseEventArgs) Handles but_Forward.MouseDown
        but_Forward.BackgroundImage = My.Resources.SwitchForward_Press
    End Sub




    Dim settingshover As Boolean = False
    Private Sub but_settings_MouseEnter(sender As Object, e As EventArgs) Handles but_Settings.MouseEnter
        but_Settings.BackColor = Color.FromArgb(120, 120, 120)
        settingshover = True
    End Sub

    Private Sub but_settings_MouseLeave(sender As Object, e As EventArgs) Handles but_Settings.MouseLeave
        but_Settings.BackColor = Color.Transparent
        settingshover = False
    End Sub

    Private Sub but_settings_MouseUp(sender As Object, e As MouseEventArgs) Handles but_Settings.MouseUp
        If settingshover Then
            but_Settings.BackColor = Color.FromArgb(120, 120, 120)
        Else
            but_Settings.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub but_settings_MouseDown(sender As Object, e As MouseEventArgs) Handles but_Settings.MouseDown
        but_Settings.BackColor = Color.FromArgb(65, 65, 65)
    End Sub


    Dim savehover As Boolean = False
    Private Sub but_save_MouseEnter(sender As Object, e As EventArgs) Handles but_Save.MouseEnter
        but_Save.BackColor = Color.FromArgb(120, 120, 120)
        savehover = True
    End Sub

    Private Sub but_save_MouseLeave(sender As Object, e As EventArgs) Handles but_Save.MouseLeave
        but_Save.BackColor = Color.Transparent
        savehover = False
    End Sub

    Private Sub but_save_MouseUp(sender As Object, e As MouseEventArgs) Handles but_Save.MouseUp
        If savehover Then
            but_Save.BackColor = Color.FromArgb(120, 120, 120)
        Else
            but_Save.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub but_save_MouseDown(sender As Object, e As MouseEventArgs) Handles but_Save.MouseDown
        but_Save.BackColor = Color.FromArgb(65, 65, 65)
    End Sub




    Dim loadhover As Boolean = False
    Private Sub but_load_MouseEnter(sender As Object, e As EventArgs) Handles but_Load.MouseEnter
        but_Load.BackColor = Color.FromArgb(120, 120, 120)
        loadhover = True
    End Sub

    Private Sub but_load_MouseLeave(sender As Object, e As EventArgs) Handles but_Load.MouseLeave
        but_Load.BackColor = Color.Transparent
        loadhover = False
    End Sub

    Private Sub but_load_MouseUp(sender As Object, e As MouseEventArgs) Handles but_Load.MouseUp
        If loadhover Then
            but_Load.BackColor = Color.FromArgb(120, 120, 120)
        Else
            but_Load.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub but_load_MouseDown(sender As Object, e As MouseEventArgs) Handles but_Load.MouseDown
        but_Load.BackColor = Color.FromArgb(65, 65, 65)
    End Sub

    Dim translatehover As Boolean = False
    Private Sub but_translate_MouseEnter(sender As Object, e As EventArgs) Handles but_translate.MouseEnter, pic_Heroes.MouseEnter
        sender.BackColor = Color.FromArgb(120, 120, 120)
        translatehover = True
    End Sub

    Private Sub but_translate_MouseLeave(sender As Object, e As EventArgs) Handles but_translate.MouseLeave, pic_Heroes.MouseLeave
        sender.BackColor = Color.Transparent
        translatehover = False
    End Sub

    Private Sub but_translate_MouseUp(sender As Object, e As MouseEventArgs) Handles but_translate.MouseUp, pic_Heroes.MouseUp
        If translatehover Then
            sender.BackColor = Color.FromArgb(120, 120, 120)
        Else
            sender.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub but_translate_MouseDown(sender As Object, e As MouseEventArgs) Handles but_translate.MouseDown, pic_Heroes.MouseDown
        sender.BackColor = Color.FromArgb(65, 65, 65)
    End Sub



    Dim mansionhover As Boolean = False
    Private Sub but_mansion_MouseEnter(sender As Object, e As EventArgs) Handles but_Mansion.MouseEnter
        but_Mansion.BackColor = Color.FromArgb(120, 120, 120)
        mansionhover = True
    End Sub

    Private Sub but_mansion_MouseLeave(sender As Object, e As EventArgs) Handles but_Mansion.MouseLeave
        but_Mansion.BackColor = Color.Transparent
        mansionhover = False
    End Sub

    Private Sub but_mansion_MouseUp(sender As Object, e As MouseEventArgs) Handles but_Mansion.MouseUp
        If mansionhover Then
            but_Mansion.BackColor = Color.FromArgb(120, 120, 120)
        Else
            but_Mansion.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub but_mansion_MouseDown(sender As Object, e As MouseEventArgs) Handles but_Mansion.MouseDown
        but_Mansion.BackColor = Color.FromArgb(65, 65, 65)
    End Sub


    Dim maphover As Boolean = False
    Private Sub pic_map_MouseEnter(sender As Object, e As EventArgs) Handles pic_Map.MouseEnter
        pic_Map.BackColor = Color.FromArgb(120, 120, 120)
        maphover = True
    End Sub

    Private Sub pic_map_MouseLeave(sender As Object, e As EventArgs) Handles pic_Map.MouseLeave
        pic_Map.BackColor = Color.Transparent
        maphover = False
    End Sub

    Private Sub pic_map_MouseUp(sender As Object, e As MouseEventArgs) Handles pic_Map.MouseUp
        If maphover Then
            pic_Map.BackColor = Color.FromArgb(120, 120, 120)
        Else
            pic_Map.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub pic_map_MouseDown(sender As Object, e As MouseEventArgs) Handles pic_Map.MouseDown
        pic_Map.BackColor = Color.FromArgb(65, 65, 65)
    End Sub

    Dim butmaphover As Boolean = False
    Private Sub but_map_MouseEnter(sender As Object, e As EventArgs) Handles but_Map.MouseEnter
        but_Map.BackColor = Color.FromArgb(120, 120, 120)
        maphover = True
    End Sub

    Private Sub but_map_MouseLeave(sender As Object, e As EventArgs) Handles but_Map.MouseLeave
        but_Map.BackColor = Color.Transparent
        maphover = False
    End Sub

    Private Sub but_map_MouseUp(sender As Object, e As MouseEventArgs) Handles but_Map.MouseUp
        If maphover Then
            but_Map.BackColor = Color.FromArgb(120, 120, 120)
        Else
            but_Map.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub but_map_MouseDown(sender As Object, e As MouseEventArgs) Handles but_Map.MouseDown
        but_Map.BackColor = Color.FromArgb(65, 65, 65)
    End Sub


    Dim butuniversehover As Boolean = False
    Private Sub but_universe_MouseEnter(sender As Object, e As EventArgs) Handles but_Universe.MouseEnter
        but_Universe.BackColor = Color.FromArgb(120, 120, 120)
        maphover = True
    End Sub

    Private Sub but_universe_MouseLeave(sender As Object, e As EventArgs) Handles but_Universe.MouseLeave
        but_Universe.BackColor = Color.Transparent
        maphover = False
    End Sub

    Private Sub but_universe_MouseUp(sender As Object, e As MouseEventArgs) Handles but_Universe.MouseUp
        If maphover Then
            but_Universe.BackColor = Color.FromArgb(120, 120, 120)
        Else
            but_Universe.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub but_universe_MouseDown(sender As Object, e As MouseEventArgs) Handles but_Universe.MouseDown
        but_Universe.BackColor = Color.FromArgb(65, 65, 65)
    End Sub

    Dim homescreenhover As Boolean = False
    Private Sub but_homescreen_MouseEnter(sender As Object, e As EventArgs) Handles but_HomeScreen.MouseEnter
        but_HomeScreen.BackColor = Color.FromArgb(120, 120, 120)
        homescreenhover = True
    End Sub

    Private Sub but_homescreen_MouseLeave(sender As Object, e As EventArgs) Handles but_HomeScreen.MouseLeave
        but_HomeScreen.BackColor = Color.Transparent
        homescreenhover = False
    End Sub

    Private Sub but_homescreen_MouseUp(sender As Object, e As MouseEventArgs) Handles but_HomeScreen.MouseUp
        If homescreenhover Then
            but_HomeScreen.BackColor = Color.FromArgb(120, 120, 120)
        Else
            but_HomeScreen.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub but_homescreen_MouseDown(sender As Object, e As MouseEventArgs) Handles but_HomeScreen.MouseDown
        but_HomeScreen.BackColor = Color.FromArgb(65, 65, 65)
    End Sub



    Dim heroiconshover As Boolean = False
    Private Sub pic_BoltIcon_MouseEnter(sender As Object, e As EventArgs) Handles pic_WhirlwindIcon.MouseEnter, pic_VortexIcon.MouseEnter, pic_TykeIcon.MouseEnter, _
        pic_SwiftIcon.MouseEnter, pic_ShiftIcon.MouseEnter, pic_PsychIcon.MouseEnter, pic_BoltIcon.MouseEnter, pic_AvianIcon.MouseEnter, pic_AngelIcon.MouseEnter, but_HomeScreen3.MouseEnter, but_backHeroes.MouseEnter
        sender.BackColor = Color.FromArgb(120, 120, 120)
        heroiconshover = True
    End Sub

    Private Sub pic_BoltIcon_MouseLeave(sender As Object, e As EventArgs) Handles pic_WhirlwindIcon.MouseLeave, pic_VortexIcon.MouseLeave, pic_TykeIcon.MouseLeave, _
        pic_SwiftIcon.MouseLeave, pic_ShiftIcon.MouseLeave, pic_PsychIcon.MouseLeave, pic_BoltIcon.MouseLeave, pic_AvianIcon.MouseLeave, pic_AngelIcon.MouseLeave, but_HomeScreen3.MouseLeave, but_backHeroes.MouseLeave
        sender.BackColor = Color.Transparent
        heroiconshover = False
    End Sub

    Private Sub pic_BoltIcon_MouseDown(sender As Object, e As MouseEventArgs) Handles pic_WhirlwindIcon.MouseDown, pic_VortexIcon.MouseDown, pic_TykeIcon.MouseDown, _
        pic_SwiftIcon.MouseDown, pic_ShiftIcon.MouseDown, pic_PsychIcon.MouseDown, pic_BoltIcon.MouseDown, pic_AvianIcon.MouseDown, pic_AngelIcon.MouseDown, but_HomeScreen3.MouseDown, but_backHeroes.MouseDown
        sender.BackColor = Color.FromArgb(65, 65, 65)
    End Sub

    Private Sub pic_BoltIcon_MouseUp(sender As Object, e As MouseEventArgs) Handles pic_WhirlwindIcon.MouseUp, pic_VortexIcon.MouseUp, pic_TykeIcon.MouseUp, _
        pic_SwiftIcon.MouseUp, pic_ShiftIcon.MouseUp, pic_PsychIcon.MouseUp, pic_BoltIcon.MouseUp, pic_AvianIcon.MouseUp, pic_AngelIcon.MouseUp, but_HomeScreen3.MouseUp, but_backHeroes.MouseUp
        If heroiconshover Then
            sender.BackColor = Color.FromArgb(120, 120, 120)
        Else
            sender.BackColor = Color.Transparent
        End If
    End Sub




    Dim homescreen2hover As Boolean = False
    Private Sub but_homescreen2_MouseEnter(sender As Object, e As EventArgs) Handles but_HomeScreen2.MouseEnter
        but_HomeScreen2.BackColor = Color.FromArgb(120, 120, 120)
        homescreen2hover = True
    End Sub

    Private Sub but_homescreen2_MouseLeave(sender As Object, e As EventArgs) Handles but_HomeScreen2.MouseLeave
        but_HomeScreen2.BackColor = Color.Transparent
        homescreen2hover = False
    End Sub

    Private Sub but_homescreen2_MouseUp(sender As Object, e As MouseEventArgs) Handles but_HomeScreen2.MouseUp
        If homescreen2hover Then
            but_HomeScreen2.BackColor = Color.FromArgb(120, 120, 120)
        Else
            but_HomeScreen2.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub but_homescreen2_MouseDown(sender As Object, e As MouseEventArgs) Handles but_HomeScreen2.MouseDown
        but_HomeScreen2.BackColor = Color.FromArgb(65, 65, 65)
    End Sub

    Dim mapbackhover As Boolean = False
    Private Sub but_MapBack_MouseEnter(sender As Object, e As EventArgs) Handles but_MapBack.MouseEnter
        but_MapBack.BackgroundImage = My.Resources.SwitchBack_Hover
        mapbackhover = True
    End Sub

    Private Sub but_MapBack_MouseLeave(sender As Object, e As EventArgs) Handles but_MapBack.MouseLeave
        but_MapBack.BackgroundImage = My.Resources.SwitchBack
        mapbackhover = False
    End Sub

    Private Sub but_MapBack_MouseUp(sender As Object, e As MouseEventArgs) Handles but_MapBack.MouseUp
        If mapbackhover Then
            but_MapBack.BackgroundImage = My.Resources.SwitchBack_Hover
        Else
            but_MapBack.BackgroundImage = My.Resources.SwitchBack
        End If
    End Sub

    Private Sub but_MapBack_MouseDown(sender As Object, e As MouseEventArgs) Handles but_MapBack.MouseDown
        but_MapBack.BackgroundImage = My.Resources.SwitchBack_Press
    End Sub




    Dim mapforwardhover As Boolean = False
    Private Sub but_MapForward_MouseEnter(sender As Object, e As EventArgs) Handles but_MapForward.MouseEnter
        but_MapForward.BackgroundImage = My.Resources.SwitchForward_Hover
        mapforwardhover = True
    End Sub

    Private Sub but_MapForward_MouseLeave(sender As Object, e As EventArgs) Handles but_MapForward.MouseLeave
        but_MapForward.BackgroundImage = My.Resources.SwitchForward
        mapforwardhover = False
    End Sub

    Private Sub but_MapForward_MouseUp(sender As Object, e As MouseEventArgs) Handles but_MapForward.MouseUp
        If mapforwardhover Then
            but_MapForward.BackgroundImage = My.Resources.SwitchForward_Hover
        Else
            but_MapForward.BackgroundImage = My.Resources.SwitchForward
        End If
    End Sub

    Private Sub but_MapForward_MouseDown(sender As Object, e As MouseEventArgs) Handles but_MapForward.MouseDown
        but_MapForward.BackgroundImage = My.Resources.SwitchForward_Press
    End Sub



#End Region

    Public Sub DrawItems()
        DrawLockButton()
        DrawCheckBox()

    End Sub
    Dim xformTop As New Form()
    Public Sub DrawCheckBox()
        xformTop = TopMostCBform
        Me.AddOwnedForm(xformTop)
        xformTop.Show()
        'xformTop.Location = New Point(Me.Location.X + 410, Me.Location.Y + 5)
        If Me.WindowState = FormWindowState.Normal Then
            xformTop.Location = New Point(Me.Location.X + Me.Width - 183, Me.Location.Y + 5)
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            xformTop.Location = New Point(Me.Location.X + Me.Width - 189, Me.Location.Y + 15)
        End If

        xformTop.Size = New Size(84, 17)

    End Sub
    Dim xformLock As New Form()
    Public Sub DrawLockButton()
        xformLock = LockFormvb
        Me.AddOwnedForm(xformLock)
        xformLock.Show()
        'xformTop.Location = New Point(Me.Location.X + 410, Me.Location.Y + 5)
        If Me.WindowState = FormWindowState.Normal Then
            xformLock.Location = New Point(Me.Location.X + Me.Width - 183 - 25, Me.Location.Y + 5)
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            xformLock.Location = New Point(Me.Location.X + Me.Width - 189 - 25, Me.Location.Y + 15)
        End If
        xformLock.Size = New Size(15, 15)
    End Sub
    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles Me.Move
        '  xformTop.Location = New Point(Me.Location.X + 400, Me.Location.Y + 5)
        If Me.WindowState = FormWindowState.Normal Then
            xformTop.Location = New Point(Me.Location.X + Me.Width - 183, Me.Location.Y + 5)
            xformLock.Location = New Point(Me.Location.X + Me.Width - 183 - 25, Me.Location.Y + 5)
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            xformTop.Location = New Point(Me.Location.X + Me.Width - 189, Me.Location.Y + 15)
            xformLock.Location = New Point(Me.Location.X + Me.Width - 189 - 25, Me.Location.Y + 15)
        End If
    End Sub


  
End Class
