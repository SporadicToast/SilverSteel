Module mainprocess
    'Variable Declarations
    'Debug Variable
    Public debug As Boolean
    Public version As String
    'Close Function

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
