Public Class TopMostCBform

    Private Sub cb_TopMost_CheckedChanged(sender As Object, e As EventArgs) Handles cb_TopMost.CheckedChanged
        Select Case cb_TopMost.Checked
            Case True
                Form1.TopMost = True
            Case False
                Form1.TopMost = False
        End Select
    End Sub

    Private Sub TopMostCBform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_TopMost.Checked = My.Settings.pintotop
    End Sub

End Class