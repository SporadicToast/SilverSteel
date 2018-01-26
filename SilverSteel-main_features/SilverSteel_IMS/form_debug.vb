Public Class form_debug
    Private Sub btn_debug_login_Click(sender As Object, e As EventArgs) Handles btn_debug_login.Click
        form_login.Show()
    End Sub

    Private Sub btn_debug_menu_Click(sender As Object, e As EventArgs) Handles btn_debug_menu.Click
        DATEandTIMEmainmenuIMS.Show()
    End Sub

    Private Sub btn_debug_var_Click(sender As Object, e As EventArgs) Handles btn_debug_var.Click
        If debug = True Then
            lbl_debugvar.Text = "FALSE"
            debug = False
        Else
            lbl_debugvar.Text = "TRUE"
            debug = True
        End If
    End Sub
End Class