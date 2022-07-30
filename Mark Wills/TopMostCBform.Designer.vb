<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopMostCBform
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
        Me.cb_TopMost = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cb_TopMost
        '
        Me.cb_TopMost.AutoSize = True
        Me.cb_TopMost.BackColor = System.Drawing.Color.Transparent
        Me.cb_TopMost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_TopMost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_TopMost.Location = New System.Drawing.Point(0, 0)
        Me.cb_TopMost.Name = "cb_TopMost"
        Me.cb_TopMost.Size = New System.Drawing.Size(80, 17)
        Me.cb_TopMost.TabIndex = 1
        Me.cb_TopMost.Text = "Pin to top"
        Me.cb_TopMost.UseVisualStyleBackColor = False
        '
        'TopMostCBform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(84, 17)
        Me.Controls.Add(Me.cb_TopMost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TopMostCBform"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "TopMostCBform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_TopMost As System.Windows.Forms.CheckBox
End Class
