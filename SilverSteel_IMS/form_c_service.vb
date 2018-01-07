Public Class form_c_service
    Dim current_index As Integer
    Dim n As Integer
    Private Sub btn_set_Click(sender As Object, e As EventArgs) Handles btn_set.Click
        current_index = cb_cw.SelectedIndex()
        If carwash_bool(current_index) = False Then
            'Carwash Datalist
            ' 0    1    2    3    4    5    6    7    8    9    10
            'start end lp  card. cart. clnt a.p. s.t. l.c. com. vac.
            'declare as (x)(y) where x is carwash descriptor and y carwash slot
            carwash_datalist(current_index, 0) = tp_ts.Value.ToLongTimeString
            carwash_datalist(current_index, 1) = "" 'End Time
            carwash_datalist(current_index, 2) = tb_plateno.Text
            carwash_datalist(current_index, 3) = tb_c_cd.Text
            carwash_datalist(current_index, 4) = cb_c_ct.Text
            carwash_datalist(current_index, 5) = "" 'Clean Time
            carwash_datalist(current_index, 6) = tb_c_ap.Text
            carwash_datalist(current_index, 7) = cb_c_st.Text
            carwash_datalist(current_index, 8) = tb_c_lc.Text
            carwash_datalist(current_index, 9) = tb_c_com.Text
            carwash_datalist(current_index, 10) = tb_c_vac.Text
            carwash_bool(current_index) = True
        End If
        add_lock("carwash", cb_cw.SelectedIndex())




    End Sub

    Private Sub cb_cw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_cw.SelectedIndexChanged
        load_Values()
        If carwash_bool(cb_cw.SelectedIndex()) = False Then
            'Allow Edit
            gb_carwash.Enabled = True
            tp_ts.Value = DateTime.Now()
            add_lock("carwash", cb_cw.SelectedIndex())
        Else
            gb_carwash.Enabled = False
            add_lock("carwash", cb_cw.SelectedIndex())
        End If
    End Sub

    Private Sub form_c_service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_cw.SelectedIndex() = 0
        load_Values()
    End Sub

    Private Sub tb_c_ap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_c_ap.KeyPress, tb_c_lc.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_now_Click(sender As Object, e As EventArgs) Handles btn_now.Click
        tp_ts.Value = DateTime.Now()
    End Sub

    Function load_Values() As String
        current_index = cb_cw.SelectedIndex()
        'Carwash Datalist
        ' 0    1    2    3    4    5    6    7    8    9    10
        'start end lp  card. cart. clnt a.p. s.t. l.c. com. vac.
        'declare as (x)(y) where x is carwash descriptor and y carwash slot
        Try
            tp_ts.Value = DateTime.Parse(carwash_datalist(current_index, 0))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("No datetime on current index.")
        End Try
        tb_plateno.Text = carwash_datalist(current_index, 2)
        tb_c_cd.Text = carwash_datalist(current_index, 3)
        cb_c_ct.Text = carwash_datalist(current_index, 4)
        tb_c_ap.Text = carwash_datalist(current_index, 6)
        cb_c_st.Text = carwash_datalist(current_index, 7)
        tb_c_lc.Text = carwash_datalist(current_index, 8)
        tb_c_com.Text = carwash_datalist(current_index, 9)
        tb_c_vac.Text = carwash_datalist(current_index, 10)
    End Function


End Class