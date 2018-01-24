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
        If carwash_bool(0) = True Then
            pnl_c1.BackColor = Color.Green
            lbl_c1_plateno.Text = mainprocess.carwash_datalist(0, 2)
            lbl_c1_countup.Text = (DateTime.Now() - DateTime.Parse(mainprocess.carwash_datalist(0, 0))).ToString
            lbl_c1_st.Text = mainprocess.carwash_datalist(0, 0)
            lbl_c1_s.Text = mainprocess.carwash_datalist(0, 7)
            lbl_c1_ct.Text = mainprocess.carwash_datalist(0, 4)
            lbl_c1_ap.Text = mainprocess.carwash_datalist(0, 6)
            lbl_c1_vac.Text = mainprocess.carwash_datalist(0, 10)
            lbl_c1_cd.Text = mainprocess.carwash_datalist(0, 3)
        End If
        If carwash_bool(1) = True Then
            pnl_c2.BackColor = Color.Green
            lbl_c2_plateno.Text = mainprocess.carwash_datalist(1, 2)
            lbl_c2_countup.Text = (DateTime.Now() - DateTime.Parse(mainprocess.carwash_datalist(1, 0))).ToString
            lbl_c2_st.Text = mainprocess.carwash_datalist(1, 0)
            lbl_c2_s.Text = mainprocess.carwash_datalist(1, 7)
            lbl_c2_ct.Text = mainprocess.carwash_datalist(1, 4)
            lbl_c2_ap.Text = mainprocess.carwash_datalist(1, 6)
            lbl_c2_vac.Text = mainprocess.carwash_datalist(1, 10)
            lbl_c2_cd.Text = mainprocess.carwash_datalist(1, 3)
        End If
        If carwash_bool(2) = True Then
            pnl_c3.BackColor = Color.Green
            lbl_c3_plateno.Text = mainprocess.carwash_datalist(2, 2)
            lbl_c3_countup.Text = (DateTime.Now() - DateTime.Parse(mainprocess.carwash_datalist(2, 0))).ToString
            lbl_c3_st.Text = mainprocess.carwash_datalist(2, 0)
            lbl_c3_s.Text = mainprocess.carwash_datalist(2, 7)
            lbl_c3_ct.Text = mainprocess.carwash_datalist(2, 4)
            lbl_c3_ap.Text = mainprocess.carwash_datalist(2, 6)
            lbl_c3_vac.Text = mainprocess.carwash_datalist(2, 10)
            lbl_c3_cd.Text = mainprocess.carwash_datalist(2, 3)
        End If
        If carwash_bool(3) = True Then
            pnl_c4.BackColor = Color.Green
            lbl_c4_plateno.Text = mainprocess.carwash_datalist(3, 2)
            lbl_c4_countup.Text = (DateTime.Now() - DateTime.Parse(mainprocess.carwash_datalist(3, 0))).ToString
            lbl_c4_st.Text = mainprocess.carwash_datalist(3, 0)
            lbl_c4_s.Text = mainprocess.carwash_datalist(3, 7)
            lbl_c4_ct.Text = mainprocess.carwash_datalist(3, 4)
            lbl_c4_ap.Text = mainprocess.carwash_datalist(3, 6)
            lbl_c4_vac.Text = mainprocess.carwash_datalist(3, 10)
            lbl_c4_cd.Text = mainprocess.carwash_datalist(3, 3)
        End If
        If carwash_bool(4) = True Then
            pnl_c5.BackColor = Color.Green
            lbl_c5_plateno.Text = mainprocess.carwash_datalist(4, 2)
            lbl_c5_countup.Text = (DateTime.Now() - DateTime.Parse(mainprocess.carwash_datalist(4, 0))).ToString
            lbl_c5_st.Text = mainprocess.carwash_datalist(4, 0)
            lbl_c5_s.Text = mainprocess.carwash_datalist(4, 7)
            lbl_c5_ct.Text = mainprocess.carwash_datalist(4, 4)
            lbl_c5_ap.Text = mainprocess.carwash_datalist(4, 6)
            lbl_c5_vac.Text = mainprocess.carwash_datalist(4, 10)
            lbl_c5_cd.Text = mainprocess.carwash_datalist(4, 3)
        End If
        If carwash_bool(5) = True Then
            pnl_c6.BackColor = Color.Green
            lbl_c6_plateno.Text = mainprocess.carwash_datalist(1, 2)
            lbl_c6_countup.Text = (DateTime.Now() - DateTime.Parse(mainprocess.carwash_datalist(5, 0))).ToString
            lbl_c6_st.Text = mainprocess.carwash_datalist(1, 0)
            lbl_c6_s.Text = mainprocess.carwash_datalist(1, 7)
            lbl_c6_ct.Text = mainprocess.carwash_datalist(1, 4)
            lbl_c6_ap.Text = mainprocess.carwash_datalist(1, 6)
            lbl_c6_vac.Text = mainprocess.carwash_datalist(1, 10)
            lbl_c6_cd.Text = mainprocess.carwash_datalist(1, 3)
        End If
    End Sub


    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_connection()
    End Sub
End Class