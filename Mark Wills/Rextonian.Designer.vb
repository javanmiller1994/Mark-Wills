Partial Public Class Rextonian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rextonian))
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.but_Translate = New DevExpress.XtraEditors.SimpleButton()
        Me.label_English = New System.Windows.Forms.Label()
        Me.label_Rextonian = New System.Windows.Forms.Label()
        Me.but_Expand = New DevExpress.XtraEditors.SimpleButton()
        Me.label_Rules = New System.Windows.Forms.Label()
        Me.scroller = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.label_RulesExplained = New System.Windows.Forms.Label()
        Me.but_Clear = New DevExpress.XtraEditors.SimpleButton()
        Me.me_Rextonian = New DevExpress.XtraEditors.MemoEdit()
        Me.me_pronunciation = New DevExpress.XtraEditors.MemoEdit()
        Me.me_English = New DevExpress.XtraEditors.MemoEdit()
        Me.but_taller = New DevExpress.XtraEditors.SimpleButton()
        Me.me_Masonian = New DevExpress.XtraEditors.MemoEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.but_Copy = New DevExpress.XtraEditors.SimpleButton()
        Me.but_Add = New DevExpress.XtraEditors.SimpleButton()
        Me.scroller.SuspendLayout()
        CType(Me.me_Rextonian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.me_pronunciation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.me_English.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.me_Masonian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style"
        '
        'but_Translate
        '
        Me.but_Translate.AllowFocus = False
        Me.but_Translate.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.but_Translate.Appearance.Options.UseFont = True
        Me.but_Translate.Location = New System.Drawing.Point(12, 382)
        Me.but_Translate.Name = "but_Translate"
        Me.but_Translate.Size = New System.Drawing.Size(82, 30)
        Me.but_Translate.TabIndex = 1
        Me.but_Translate.Text = "Translate"
        '
        'label_English
        '
        Me.label_English.AutoSize = True
        Me.label_English.BackColor = System.Drawing.Color.Transparent
        Me.label_English.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label_English.Location = New System.Drawing.Point(9, 9)
        Me.label_English.Name = "label_English"
        Me.label_English.Size = New System.Drawing.Size(67, 19)
        Me.label_English.TabIndex = 2
        Me.label_English.Text = "English"
        '
        'label_Rextonian
        '
        Me.label_Rextonian.AutoSize = True
        Me.label_Rextonian.BackColor = System.Drawing.Color.Transparent
        Me.label_Rextonian.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label_Rextonian.Location = New System.Drawing.Point(256, 9)
        Me.label_Rextonian.Name = "label_Rextonian"
        Me.label_Rextonian.Size = New System.Drawing.Size(93, 19)
        Me.label_Rextonian.TabIndex = 2
        Me.label_Rextonian.Text = "Rextonian"
        '
        'but_Expand
        '
        Me.but_Expand.AllowFocus = False
        Me.but_Expand.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.but_Expand.Appearance.Options.UseFont = True
        Me.but_Expand.Location = New System.Drawing.Point(511, 209)
        Me.but_Expand.Name = "but_Expand"
        Me.but_Expand.Size = New System.Drawing.Size(24, 30)
        Me.but_Expand.TabIndex = 4
        Me.but_Expand.Text = "⯈"
        '
        'label_Rules
        '
        Me.label_Rules.AutoSize = True
        Me.label_Rules.BackColor = System.Drawing.Color.Transparent
        Me.label_Rules.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label_Rules.Location = New System.Drawing.Point(551, 9)
        Me.label_Rules.Name = "label_Rules"
        Me.label_Rules.Size = New System.Drawing.Size(54, 19)
        Me.label_Rules.TabIndex = 6
        Me.label_Rules.Text = "Rules"
        '
        'scroller
        '
        Me.scroller.AllowTouchScroll = True
        Me.scroller.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.scroller.Appearance.Options.UseBackColor = True
        Me.scroller.Controls.Add(Me.label_RulesExplained)
        Me.scroller.Location = New System.Drawing.Point(555, 48)
        Me.scroller.Name = "scroller"
        Me.scroller.Size = New System.Drawing.Size(314, 328)
        Me.scroller.TabIndex = 6
        '
        'label_RulesExplained
        '
        Me.label_RulesExplained.AutoSize = True
        Me.label_RulesExplained.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.label_RulesExplained.Location = New System.Drawing.Point(0, 0)
        Me.label_RulesExplained.MaximumSize = New System.Drawing.Size(300, 0)
        Me.label_RulesExplained.Name = "label_RulesExplained"
        Me.label_RulesExplained.Size = New System.Drawing.Size(300, 510)
        Me.label_RulesExplained.TabIndex = 8
        Me.label_RulesExplained.Text = resources.GetString("label_RulesExplained.Text")
        '
        'but_Clear
        '
        Me.but_Clear.AllowFocus = False
        Me.but_Clear.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.but_Clear.Appearance.Options.UseFont = True
        Me.but_Clear.Location = New System.Drawing.Point(172, 382)
        Me.but_Clear.Name = "but_Clear"
        Me.but_Clear.Size = New System.Drawing.Size(82, 30)
        Me.but_Clear.TabIndex = 5
        Me.but_Clear.Text = "Clear"
        '
        'me_Rextonian
        '
        Me.me_Rextonian.Location = New System.Drawing.Point(260, 48)
        Me.me_Rextonian.Name = "me_Rextonian"
        Me.me_Rextonian.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.me_Rextonian.Properties.Appearance.Options.UseFont = True
        Me.me_Rextonian.Properties.ReadOnly = True
        Me.me_Rextonian.Size = New System.Drawing.Size(242, 170)
        Me.me_Rextonian.TabIndex = 2
        '
        'me_pronunciation
        '
        Me.me_pronunciation.Location = New System.Drawing.Point(260, 224)
        Me.me_pronunciation.Name = "me_pronunciation"
        Me.me_pronunciation.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.me_pronunciation.Properties.Appearance.Options.UseFont = True
        Me.me_pronunciation.Properties.ReadOnly = True
        Me.me_pronunciation.Size = New System.Drawing.Size(242, 152)
        Me.me_pronunciation.TabIndex = 3
        '
        'me_English
        '
        Me.me_English.Location = New System.Drawing.Point(12, 48)
        Me.me_English.Name = "me_English"
        Me.me_English.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.me_English.Properties.Appearance.Options.UseFont = True
        Me.me_English.Size = New System.Drawing.Size(242, 328)
        Me.me_English.TabIndex = 0
        '
        'but_taller
        '
        Me.but_taller.AllowFocus = False
        Me.but_taller.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.but_taller.Appearance.Options.UseFont = True
        Me.but_taller.Location = New System.Drawing.Point(511, 382)
        Me.but_taller.Name = "but_taller"
        Me.but_taller.Size = New System.Drawing.Size(24, 30)
        Me.but_taller.TabIndex = 7
        Me.but_taller.Text = "⯆"
        '
        'me_Masonian
        '
        Me.me_Masonian.Location = New System.Drawing.Point(260, 474)
        Me.me_Masonian.Name = "me_Masonian"
        Me.me_Masonian.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.me_Masonian.Properties.Appearance.Options.UseFont = True
        Me.me_Masonian.Properties.ReadOnly = True
        Me.me_Masonian.Size = New System.Drawing.Size(242, 152)
        Me.me_Masonian.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(256, 450)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Masonian"
        '
        'but_Copy
        '
        Me.but_Copy.AllowFocus = False
        Me.but_Copy.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.but_Copy.Appearance.Options.UseFont = True
        Me.but_Copy.Location = New System.Drawing.Point(420, 9)
        Me.but_Copy.Name = "but_Copy"
        Me.but_Copy.Size = New System.Drawing.Size(82, 30)
        Me.but_Copy.TabIndex = 5
        Me.but_Copy.Text = "Copy"
        '
        'but_Add
        '
        Me.but_Add.AllowFocus = False
        Me.but_Add.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.but_Add.Appearance.Options.UseFont = True
        Me.but_Add.Location = New System.Drawing.Point(420, 382)
        Me.but_Add.Name = "but_Add"
        Me.but_Add.Size = New System.Drawing.Size(82, 30)
        Me.but_Add.TabIndex = 5
        Me.but_Add.Text = "Add"
        Me.but_Add.ToolTip = "Add word or phrase to dictionary"
        '
        'Rextonian
        '
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center
        Me.BackgroundImageStore = Global.Mark_Wills.My.Resources.Resources.The_Avians_Reality_faded
        Me.ClientSize = New System.Drawing.Size(544, 424)
        Me.Controls.Add(Me.me_Masonian)
        Me.Controls.Add(Me.but_taller)
        Me.Controls.Add(Me.me_English)
        Me.Controls.Add(Me.me_pronunciation)
        Me.Controls.Add(Me.me_Rextonian)
        Me.Controls.Add(Me.but_Copy)
        Me.Controls.Add(Me.but_Add)
        Me.Controls.Add(Me.but_Clear)
        Me.Controls.Add(Me.scroller)
        Me.Controls.Add(Me.label_Rules)
        Me.Controls.Add(Me.but_Expand)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label_Rextonian)
        Me.Controls.Add(Me.label_English)
        Me.Controls.Add(Me.but_Translate)
        Me.IconOptions.Icon = CType(resources.GetObject("Rextonian.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.Mark_Wills.My.Resources.Resources.Avian_Icon_sleek_51
        Me.MinimumSize = New System.Drawing.Size(554, 456)
        Me.Name = "Rextonian"
        Me.Text = "Translate to Rextonian"
        Me.scroller.ResumeLayout(False)
        Me.scroller.PerformLayout()
        CType(Me.me_Rextonian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.me_pronunciation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.me_English.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.me_Masonian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents but_Translate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents label_English As System.Windows.Forms.Label
    Friend WithEvents label_Rextonian As System.Windows.Forms.Label
    Friend WithEvents but_Expand As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents label_Rules As System.Windows.Forms.Label
    Friend WithEvents scroller As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents label_RulesExplained As System.Windows.Forms.Label
    Friend WithEvents but_Clear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents me_Rextonian As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents me_pronunciation As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents me_English As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents but_taller As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents me_Masonian As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents but_Copy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents but_Add As DevExpress.XtraEditors.SimpleButton

#End Region

End Class
