Module mainprocess
    'Variable Declarations
    'Debug Variable
    Public debug As Boolean
    Public version As String

    'Carwash Variables
    Public carwash_bool() As Boolean = {False, False, False, False, False, False}

    'Carwash Datalist
    ' 0    1    2    3    4    5    6    7    8    9    10
    'start end lp  card. cart. clnt a.p. s.t. l.c. com. vac.
    'declare as (x)(y) where x is carwash descriptor and y carwash slot
    Public carwash_datalist(,) As String = {{"", "", "", "", "", "", "", "", "", ""}, {"", "", "", "", "", "", "", "", "", ""}, {"", "", "", "", "", "", "", "", "", ""}, {"", "", "", "", "", "", "", "", "", ""}, {"", "", "", "", "", "", "", "", "", ""}, {"", "", "", "", "", "", "", "", "", ""}}



    'Get Passwords and Usernames
    Public Function fetch_user() As String()
        Dim user_string() As String
        user_string = {"admin", "user"}
        fetch_user = user_string
    End Function
    Public Function fetch_pass() As String()
        Dim pass_string() As String
        pass_string = {"admin", "user"}
        fetch_pass = pass_string
    End Function

    'Automatic Off Add Screen On Add
    Public Function add_lock(form As String, sel_ind As Integer) As String
        If form = "carwash" And carwash_bool(sel_ind) = False Then
            form_c_service.gb_carwash.Enabled = True
        End If
        If form = "carwash" And carwash_bool(sel_ind) = True Then
            form_c_service.gb_carwash.Enabled = False
        End If
    End Function

    'Carwash Time Handler

    'Lock Application
    Public Function lock()
        form_login.Show()
        mainmenu.Close()
    End Function
    'Close Application
    Public Function close()
        Application.Exit()
    End Function
End Module
