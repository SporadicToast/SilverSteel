Public Class mainmenu
    Private Sub LockScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockScreenToolStripMenuItem.Click
        lock()
    End Sub

    Private Sub CarwashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarwashToolStripMenuItem.Click
        form_c_service.Show()
    End Sub

    Private Sub NewServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewServiceToolStripMenuItem.Click
        form_c_service.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Carwash Datalist
        ' 0    1    2    3    4    5    6    7    8    9    10
        'start end lp  card. cart. clnt a.p. s.t. l.c. com. vac.
        'declare as (x)(y) where x is carwash descriptor and y carwash slot
        lbl_c1_plateno.Text = mainprocess.carwash_datalist(0, 0)
    End Sub
End Class