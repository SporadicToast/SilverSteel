Public Class form_c_service
    Private Sub btn_set_Click(sender As Object, e As EventArgs) Handles btn_set.Click
        carwash_bool(cb_cw.SelectedIndex()) = True
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
End Class