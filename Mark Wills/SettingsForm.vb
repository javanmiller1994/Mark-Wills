Public Class SettingsForm 

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuspendDrawing()
        SetupLayout()
        ResumeDrawing()

        tb_l1b1.Text = My.Settings.l1b1
        tb_l1b2.Text = My.Settings.l1b2
        tb_l1b3.Text = My.Settings.l1b3
        tb_l1b4.Text = My.Settings.l1b4
        tb_l1b5.Text = My.Settings.l1b5
        tb_l1b6.Text = My.Settings.l1b6
        tb_l2b1.Text = My.Settings.l2b1
        tb_l2b2.Text = My.Settings.l2b2
        tb_l2b3.Text = My.Settings.l2b3
        tb_l2b4.Text = My.Settings.l2b4
        tb_l2b5.Text = My.Settings.l2b5
        tb_l2b6.Text = My.Settings.l2b6
        tb_l2b7.Text = My.Settings.l2b7
        tb_l3b1.Text = My.Settings.l3b1
        tb_l3b2.Text = My.Settings.l3b2
        tb_l3b3.Text = My.Settings.l3b3
        tb_l3b4.Text = My.Settings.l3b4
        tb_l3b5.Text = My.Settings.l3b5
        tb_l3b6.Text = My.Settings.l3b6
        tb_l3b7.Text = My.Settings.l3b7

    End Sub


    Private Sub SettingsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.l1b1 = tb_l1b1.Text
        My.Settings.l1b2 = tb_l1b2.Text
        My.Settings.l1b3 = tb_l1b3.Text
        My.Settings.l1b4 = tb_l1b4.Text
        My.Settings.l1b5 = tb_l1b5.Text
        My.Settings.l1b6 = tb_l1b6.Text
        My.Settings.l2b1 = tb_l2b1.Text
        My.Settings.l2b2 = tb_l2b2.Text
        My.Settings.l2b3 = tb_l2b3.Text
        My.Settings.l2b4 = tb_l2b4.Text
        My.Settings.l2b5 = tb_l2b5.Text
        My.Settings.l2b6 = tb_l2b6.Text
        My.Settings.l2b7 = tb_l2b7.Text
        My.Settings.l3b1 = tb_l3b1.Text
        My.Settings.l3b2 = tb_l3b2.Text
        My.Settings.l3b3 = tb_l3b3.Text
        My.Settings.l3b4 = tb_l3b4.Text
        My.Settings.l3b5 = tb_l3b5.Text
        My.Settings.l3b6 = tb_l3b6.Text
        My.Settings.l3b7 = tb_l3b7.Text

        My.Settings.Save()
        Form1.xfrom_Close()
    End Sub



    Public Sub SetupLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bedroom numbers are from left to right, top to bottom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bedroom 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Bedroom 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Bedroom 3:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 181)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Bedroom 4:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 216)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Bedroom 5:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 251)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Bedroom 6:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 44)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Level 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(333, 44)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Level 2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(333, 76)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Bedroom 1:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(333, 111)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Bedroom 2:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(333, 146)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Bedroom 3:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(333, 181)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 21)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Bedroom 4:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(333, 216)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 21)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Bedroom 5:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(333, 251)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 21)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Bedroom 6:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(333, 286)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 21)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Bedroom 7:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 301)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 21)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Level 2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(18, 333)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 21)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Bedroom 1:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 368)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 21)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Bedroom 2:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(18, 403)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 21)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Bedroom 3:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 438)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 21)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Bedroom 4:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(18, 473)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 21)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Bedroom 5:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(18, 508)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 21)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Bedroom 6:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(18, 543)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 21)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Bedroom 7:"
        '
        'tb_l1b1
        '
        Me.tb_l1b1.Location = New System.Drawing.Point(115, 73)
        Me.tb_l1b1.Name = "tb_l1b1"
        Me.tb_l1b1.Size = New System.Drawing.Size(181, 29)
        Me.tb_l1b1.TabIndex = 1
        '
        'tb_l1b2
        '
        Me.tb_l1b2.Location = New System.Drawing.Point(115, 108)
        Me.tb_l1b2.Name = "tb_l1b2"
        Me.tb_l1b2.Size = New System.Drawing.Size(181, 29)
        Me.tb_l1b2.TabIndex = 2
        '
        'tb_l1b3
        '
        Me.tb_l1b3.Location = New System.Drawing.Point(115, 143)
        Me.tb_l1b3.Name = "tb_l1b3"
        Me.tb_l1b3.Size = New System.Drawing.Size(181, 29)
        Me.tb_l1b3.TabIndex = 3
        '
        'tb_l1b4
        '
        Me.tb_l1b4.Location = New System.Drawing.Point(115, 178)
        Me.tb_l1b4.Name = "tb_l1b4"
        Me.tb_l1b4.Size = New System.Drawing.Size(181, 29)
        Me.tb_l1b4.TabIndex = 4
        '
        'tb_l1b5
        '
        Me.tb_l1b5.Location = New System.Drawing.Point(115, 213)
        Me.tb_l1b5.Name = "tb_l1b5"
        Me.tb_l1b5.Size = New System.Drawing.Size(181, 29)
        Me.tb_l1b5.TabIndex = 5
        '
        'tb_l1b6
        '
        Me.tb_l1b6.Location = New System.Drawing.Point(115, 248)
        Me.tb_l1b6.Name = "tb_l1b6"
        Me.tb_l1b6.Size = New System.Drawing.Size(181, 29)
        Me.tb_l1b6.TabIndex = 6
        '
        'tb_l2b1
        '
        Me.tb_l2b1.Location = New System.Drawing.Point(430, 73)
        Me.tb_l2b1.Name = "tb_l2b1"
        Me.tb_l2b1.Size = New System.Drawing.Size(181, 29)
        Me.tb_l2b1.TabIndex = 7
        '
        'tb_l2b2
        '
        Me.tb_l2b2.Location = New System.Drawing.Point(430, 108)
        Me.tb_l2b2.Name = "tb_l2b2"
        Me.tb_l2b2.Size = New System.Drawing.Size(181, 29)
        Me.tb_l2b2.TabIndex = 8
        '
        'tb_l2b3
        '
        Me.tb_l2b3.Location = New System.Drawing.Point(430, 143)
        Me.tb_l2b3.Name = "tb_l2b3"
        Me.tb_l2b3.Size = New System.Drawing.Size(181, 29)
        Me.tb_l2b3.TabIndex = 9
        '
        'tb_l2b4
        '
        Me.tb_l2b4.Location = New System.Drawing.Point(430, 178)
        Me.tb_l2b4.Name = "tb_l2b4"
        Me.tb_l2b4.Size = New System.Drawing.Size(181, 29)
        Me.tb_l2b4.TabIndex = 10
        '
        'tb_l2b5
        '
        Me.tb_l2b5.Location = New System.Drawing.Point(430, 213)
        Me.tb_l2b5.Name = "tb_l2b5"
        Me.tb_l2b5.Size = New System.Drawing.Size(181, 29)
        Me.tb_l2b5.TabIndex = 11
        '
        'tb_l2b6
        '
        Me.tb_l2b6.Location = New System.Drawing.Point(430, 248)
        Me.tb_l2b6.Name = "tb_l2b6"
        Me.tb_l2b6.Size = New System.Drawing.Size(181, 29)
        Me.tb_l2b6.TabIndex = 12
        '
        'tb_l3b1
        '
        Me.tb_l3b1.Location = New System.Drawing.Point(115, 330)
        Me.tb_l3b1.Name = "tb_l3b1"
        Me.tb_l3b1.Size = New System.Drawing.Size(181, 29)
        Me.tb_l3b1.TabIndex = 14
        '
        'tb_l3b2
        '
        Me.tb_l3b2.Location = New System.Drawing.Point(115, 365)
        Me.tb_l3b2.Name = "tb_l3b2"
        Me.tb_l3b2.Size = New System.Drawing.Size(181, 29)
        Me.tb_l3b2.TabIndex = 15
        '
        'tb_l3b3
        '
        Me.tb_l3b3.Location = New System.Drawing.Point(115, 400)
        Me.tb_l3b3.Name = "tb_l3b3"
        Me.tb_l3b3.Size = New System.Drawing.Size(181, 29)
        Me.tb_l3b3.TabIndex = 16
        '
        'tb_l3b4
        '
        Me.tb_l3b4.Location = New System.Drawing.Point(115, 435)
        Me.tb_l3b4.Name = "tb_l3b4"
        Me.tb_l3b4.Size = New System.Drawing.Size(181, 29)
        Me.tb_l3b4.TabIndex = 17
        '
        'tb_l3b5
        '
        Me.tb_l3b5.Location = New System.Drawing.Point(115, 470)
        Me.tb_l3b5.Name = "tb_l3b5"
        Me.tb_l3b5.Size = New System.Drawing.Size(181, 29)
        Me.tb_l3b5.TabIndex = 18
        '
        'tb_l3b6
        '
        Me.tb_l3b6.Location = New System.Drawing.Point(115, 505)
        Me.tb_l3b6.Name = "tb_l3b6"
        Me.tb_l3b6.Size = New System.Drawing.Size(181, 29)
        Me.tb_l3b6.TabIndex = 19
        '
        'tb_l2b7
        '
        Me.tb_l2b7.Location = New System.Drawing.Point(430, 283)
        Me.tb_l2b7.Name = "tb_l2b7"
        Me.tb_l2b7.Size = New System.Drawing.Size(181, 29)
        Me.tb_l2b7.TabIndex = 13
        '
        'tb_l3b7
        '
        Me.tb_l3b7.Location = New System.Drawing.Point(115, 540)
        Me.tb_l3b7.Name = "tb_l3b7"
        Me.tb_l3b7.Size = New System.Drawing.Size(181, 29)
        Me.tb_l3b7.TabIndex = 20
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style"
        '
        'but_ok
        '
        Me.but_ok.AllowFocus = False
        Me.but_ok.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_ok.Appearance.Options.UseFont = True
        Me.but_ok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.but_ok.Location = New System.Drawing.Point(528, 554)
        Me.but_ok.Name = "but_ok"
        Me.but_ok.Size = New System.Drawing.Size(83, 29)
        Me.but_ok.TabIndex = 21
        Me.but_ok.Text = "Okay"

    End Sub

End Class