Public Class LockFormvb

    Private Sub but_Lock_Click(sender As Object, e As EventArgs) Handles but_Lock.Click
        Form1.panel_Spoilers.BringToFront()
    End Sub


    Dim lockhover As Boolean = False
    Private Sub but_lock_MouseEnter(sender As Object, e As EventArgs) Handles but_Lock.MouseEnter
        sender.BackColor = Color.FromArgb(120, 120, 120)
        lockhover = True
    End Sub

    Private Sub but_lock_MouseLeave(sender As Object, e As EventArgs) Handles but_Lock.MouseLeave
        sender.BackColor = Color.Transparent
        lockhover = False
    End Sub

    Private Sub but_lock_MouseUp(sender As Object, e As MouseEventArgs) Handles but_Lock.MouseUp
        If lockhover Then
            sender.BackColor = Color.FromArgb(120, 120, 120)
        Else
            sender.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub but_lock_MouseDown(sender As Object, e As MouseEventArgs) Handles but_Lock.MouseDown
        sender.BackColor = Color.FromArgb(65, 65, 65)
    End Sub



End Class