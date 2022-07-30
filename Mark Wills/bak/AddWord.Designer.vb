<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddWord
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.but_Add = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_Rextonian = New DevExpress.XtraEditors.TextEdit()
        Me.tb_English = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tb_Rextonian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_English.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Translation of text:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Text to Translate:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.AllowFocus = False
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton1.Location = New System.Drawing.Point(112, 148)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(95, 35)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Cancel"
        '
        'but_Add
        '
        Me.but_Add.AllowFocus = False
        Me.but_Add.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.but_Add.Appearance.Options.UseFont = True
        Me.but_Add.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.but_Add.Location = New System.Drawing.Point(11, 148)
        Me.but_Add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.but_Add.Name = "but_Add"
        Me.but_Add.Size = New System.Drawing.Size(95, 35)
        Me.but_Add.TabIndex = 0
        Me.but_Add.Text = "Add"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Translation of text:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Text to Translate:"
        '
        'tb_Rextonian
        '
        Me.tb_Rextonian.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_Rextonian.Location = New System.Drawing.Point(15, 100)
        Me.tb_Rextonian.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_Rextonian.Name = "tb_Rextonian"
        Me.tb_Rextonian.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.tb_Rextonian.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tb_Rextonian.Properties.Appearance.Options.UseBackColor = True
        Me.tb_Rextonian.Properties.Appearance.Options.UseFont = True
        Me.tb_Rextonian.Size = New System.Drawing.Size(196, 28)
        Me.tb_Rextonian.TabIndex = 9
        '
        'tb_English
        '
        Me.tb_English.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_English.Location = New System.Drawing.Point(15, 30)
        Me.tb_English.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_English.Name = "tb_English"
        Me.tb_English.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.tb_English.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tb_English.Properties.Appearance.Options.UseBackColor = True
        Me.tb_English.Properties.Appearance.Options.UseFont = True
        Me.tb_English.Size = New System.Drawing.Size(196, 28)
        Me.tb_English.TabIndex = 8
        '
        'SimpleButton2
        '
        Me.SimpleButton2.AllowFocus = False
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(120, 149)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(95, 35)
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "Cancel"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.AllowFocus = False
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SimpleButton3.Location = New System.Drawing.Point(19, 149)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(95, 35)
        Me.SimpleButton3.TabIndex = 7
        Me.SimpleButton3.Text = "Add"
        '
        'AddWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 198)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_Rextonian)
        Me.Controls.Add(Me.tb_English)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton3)
        Me.IconOptions.ShowIcon = False
        Me.Name = "AddWord"
        Me.ShowInTaskbar = False
        Me.Text = "Add to Dictionary"
        CType(Me.tb_Rextonian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_English.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents but_Add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_Rextonian As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_English As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
