Public Class Scroller
    Inherits DevExpress.XtraEditors.XtraScrollableControl
    Dim Timer1 As New Timer

    Public Sub New()

        Me.AutoSize = False
        Me.Dock = DockStyle.Fill
        Me.AllowTouchScroll = True
        Me.AutoScroll = True
        Me.FireScrollEventOnMouseWheel = True
        Me.EnableScrollOnMouseWheel()
        Me.InvertTouchScroll = True
        Me.AlwaysScrollActiveControlIntoView = False
        Me.ScrollBarSmallChange = 20

    End Sub



    Public Sub EnableScrollOnMouseWheel()
        AddHandler Me.VisibleChanged, AddressOf OnVisibleChanged
    End Sub

    Private Sub OnVisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.Select()
        UnsubscribeFromMouseWheel(Me.Controls)
        SubscribeToMouseWheel(Me.Controls)
    End Sub

    Private Sub SubscribeToMouseWheel(ByVal controls As Control.ControlCollection)
        For Each ctrl As Control In controls
            AddHandler ctrl.MouseWheel, AddressOf OnMouseWheel
            SubscribeToMouseWheel(ctrl.Controls)
        Next ctrl
    End Sub

    Private Sub UnsubscribeFromMouseWheel(ByVal controls As Control.ControlCollection)
        For Each ctrl As Control In controls
            RemoveHandler ctrl.MouseWheel, AddressOf OnMouseWheel
            UnsubscribeFromMouseWheel(ctrl.Controls)
        Next ctrl
    End Sub

    Private Sub OnMouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs)
        Timer1.Stop()
        DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = True
        Dim scrollValue As Integer = Me.VerticalScroll.Value
        Dim largeChange As Integer = Me.VerticalScroll.LargeChange - 150
        If e.Delta < 0 Then
            Me.VerticalScroll.Value += largeChange 'Me.VerticalScroll.LargeChange
        Else
            If scrollValue < largeChange Then
                Me.VerticalScroll.Value = 0
            Else
                Me.VerticalScroll.Value -= largeChange
            End If
        End If


    End Sub

    Public Sub DisableScrollOnMouseWheel()
        RemoveHandler VisibleChanged, AddressOf OnVisibleChanged
        UnsubscribeFromMouseWheel(Me.Controls)
    End Sub



End Class

Public Class HeroScroller
    Inherits Scroller
    Public Sub New()

        Me.Dock = DockStyle.None
        Me.Location = New Point(229, 38)
        Me.Size = New Size(350, 380)
        '  scroller_avian.Location = New Point(35, 10)
        Me.BringToFront()
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right Or AnchorStyles.Left
    End Sub


End Class