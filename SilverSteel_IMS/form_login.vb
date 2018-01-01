Public Class form_login
    Dim auth_success As Boolean
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        'Exit Application
        mainprocess.close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Check if Bypass Login is enabled
        If cb_debug_bypass.Checked = False Then
            'Check username
            If fetch_user.Contains(tb_user.Text) Then
                'Check password
                If fetch_pass.Contains(tb_pass.Text) Then
                    'Check credentials
                    If Array.IndexOf(fetch_user, tb_user.Text) = Array.IndexOf(fetch_pass, tb_pass.Text) Then
                        auth_success = True
                    Else
                        auth_success = False
                    End If
                Else
                    auth_success = False
                End If
            Else
                auth_success = False
            End If
        Else
            auth_success = True
        End If

        If auth_success = True Then
            'Success prompt
            MsgBox("Successfully logged in.")
            mainmenu.Show()
            If cb_debug_window.Checked Then
                mainprocess.debug = True
                form_debug.Show()
            Else
                mainprocess.debug = False
            End If
            Me.Close()
        Else
            'Fail prompt
            MsgBox("Credentials failed!")
        End If
    End Sub

    'Login

    'Exit Application


End Class
