<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Heroes_Avian
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RichLabel16 = New Mark_Wills.RichLabel()
        Me.pic_Avian = New System.Windows.Forms.PictureBox()
        CType(Me.pic_Avian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichLabel16
        '
        Me.RichLabel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.RichLabel16.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RichLabel16.Location = New System.Drawing.Point(199, 0)
        Me.RichLabel16.Name = "RichLabel16"
        Me.RichLabel16.Size = New System.Drawing.Size(615, 35)
        Me.RichLabel16.TabIndex = 1
        Me.RichLabel16.Text = "Avian"
        Me.RichLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_Avian
        '
        Me.pic_Avian.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.Avian_10
        Me.pic_Avian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Avian.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic_Avian.Location = New System.Drawing.Point(0, 0)
        Me.pic_Avian.Name = "pic_Avian"
        Me.pic_Avian.Size = New System.Drawing.Size(199, 462)
        Me.pic_Avian.TabIndex = 0
        Me.pic_Avian.TabStop = False
        '
        'Heroes_Avian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Controls.Add(Me.RichLabel16)
        Me.Controls.Add(Me.pic_Avian)
        Me.Name = "Heroes_Avian"
        Me.Size = New System.Drawing.Size(814, 462)
        CType(Me.pic_Avian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichLabel16 As RichLabel
    Friend WithEvents pic_Avian As PictureBox
End Class
