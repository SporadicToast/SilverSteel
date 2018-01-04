Public Class form_c_service
    Private Sub btn_set_Click(sender As Object, e As EventArgs) Handles btn_set.Click
        'If carwash_bool(cb_cw.SelectedIndex()) = False Then
        'Carwash Datalist
        ' 0    1    2    3    4    5    6    7    8    9    10
        'start end lp  card. cart. clnt a.p. s.t. l.c. com. vac.
        'declare as (x)(y) where x is carwash descriptor and y carwash slot

        'End If
        add_lock("carwash", cb_cw.SelectedIndex())



    End Sub

    Private Sub cb_cw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_cw.SelectedIndexChanged
        If carwash_bool(cb_cw.SelectedIndex()) = False Then
            'Allow Edit
            gb_carwash.Enabled = True
            add_lock("carwash", cb_cw.SelectedIndex())
        Else
            gb_carwash.Enabled = False
            add_lock("carwash", cb_cw.SelectedIndex())
        End If
    End Sub

    Private Sub form_c_service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_cw.SelectedIndex() = 0
    End Sub

    Private Sub tb_c_ap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_c_ap.KeyPress, tb_c_vac.KeyPress, tb_c_lc.KeyPress, tb_c_com.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_now_Click(sender As Object, e As EventArgs) Handles btn_now.Click
        tp_ts.Value = DateTime.Now()
    End Sub
End Class