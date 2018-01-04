Public Class mainmenu
    Private Sub LockScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockScreenToolStripMenuItem.Click
        lock()
    End Sub

    Private Sub CarwashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarwashToolStripMenuItem.Click
        form_c_service.Show()
    End Sub
End Class