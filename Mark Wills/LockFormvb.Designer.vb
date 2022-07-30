<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LockFormvb
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.but_Lock = New System.Windows.Forms.PictureBox()
        CType(Me.but_Lock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'but_Lock
        '
        Me.but_Lock.BackColor = System.Drawing.Color.Transparent
        Me.but_Lock.BackgroundImage = Global.Mark_Wills.My.Resources.Resources.icons8_lock_52
        Me.but_Lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Lock.Location = New System.Drawing.Point(0, 0)
        Me.but_Lock.Name = "but_Lock"
        Me.but_Lock.Size = New System.Drawing.Size(15, 15)
        Me.but_Lock.TabIndex = 0
        Me.but_Lock.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_Lock, "Lock App")
        '
        'LockFormvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(15, 15)
        Me.Controls.Add(Me.but_Lock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LockFormvb"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "LockFormvb"
        Me.ToolTip1.SetToolTip(Me, "Lock App")
        CType(Me.but_Lock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents but_Lock As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
