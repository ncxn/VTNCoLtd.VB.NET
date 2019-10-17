Imports MySql.Data.MySqlClient
Imports VTNcoLtd.DAL
Imports VTNcoLtd.Helper
Imports VTNcoLtd.Model

Namespace BUS

    Public Enum User_status
        Exits = 0
        Active = 1
        Locked = 2
        NotExists = 3
        WrongPass = 4
    End Enum


    Public Class ClsUsers
        Private Shared Singleton As ClsUsers

        Public Shared Function GetInstance() As ClsUsers
            If Singleton Is Nothing Then
                Singleton = New ClsUsers()
            End If
            Return Singleton
        End Function

        Public Function GetDataTable() As DataTable
            Dim DataTable As DataTable = DBHelper.GetInstance.GetDataTable("procUsers_GetAll", CommandType.StoredProcedure)
            Return DataTable
        End Function

        Public Function GetList() As UserCollection
            Dim UserList As New UserCollection
            Dim Reader As MySqlDataReader = DBHelper.GetInstance.GetDataReader("procUsers_GetAll", CommandType.StoredProcedure)

            While Reader.Read()
                Dim objUser As New Users With {
                .User_name = Reader("user_name").ToString(),
                .User_first_name = Reader("user_first_name").ToString(),
                .User_last_name = Reader("user_last_name").ToString(),
                .User_email = Reader("user_email").ToString(),
                .User_status = CInt(Reader("user_status")),
                .User_created_at = CDate(Reader("user_created_at")),
                .User_updated_at = CDate(Reader("user_updated_at"))
            }
                UserList.Add(objUser)
            End While
            Reader.Close()

            Return UserList

        End Function

        'Public Function GetUserByID(user_id As Integer) As Users
        '    Dim ObjectUser As New Users
        '    Dim strProc As String = "procGetUserByID"
        '    Dim parameters As New List(Of MySqlParameter) From {
        '            New MySqlParameter("@p_user_id", user_id)
        '        }
        '    Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)
        '    If Reader.Read() Then
        '        With ObjectUser
        '            '.User_id = Reader("User_id").ToString()
        '            .User_name = Reader("User_name").ToString()
        '            .User_first_name = Reader("User_first_name").ToString()
        '            .User_last_name = Reader("User_last_name").ToString()
        '            .User_email = Reader("User_email").ToString()
        '            .User_password = Reader("User_password").ToString()
        '            .User_status = CInt(Reader("User_password"))
        '            .User_created_at = CDate(Reader("User_created_at"))
        '            .User_updated_at = CDate(Reader("User_updated_at"))
        '        End With
        '    End If
        '    Reader.Close()

        '    Return ObjectUser

        'End Function

        Public Function GetUserByUserName(user_name As String) As Users
            Dim ObjectUser As New Users
            Dim strProc As String = "procUsers_GetByUserName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_user_name", user_name)
        }

            Try
                Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)

                If Reader.Read() Then
                    With ObjectUser
                        '.User_id = Reader("User_id").ToString()
                        .User_name = Reader("User_name").ToString()
                        .User_first_name = Reader("User_first_name").ToString()
                        .User_last_name = Reader("User_last_name").ToString()
                        .User_email = Reader("User_email").ToString()
                        .User_password = Reader("User_password").ToString()
                        .User_status = CInt(Reader("User_status"))
                        .User_created_at = CDate(Reader("User_created_at"))
                        .User_updated_at = CDate(Reader("User_updated_at"))

                    End With
                End If

                Reader.Close()

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return ObjectUser

        End Function

        Public Function GetUserByUserNameOrEmail(user_name As String, user_email As String) As Users
            Dim ObjectUser As New Users
            Dim strProc As String = "procUsers_GetByUserOrEmail"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("p_user_name", user_name),
            New MySqlParameter("p_user_email", user_email)
        }
            Try
                Dim Reader As Object = DBHelper.GetInstance.GetDataReader(strProc, CommandType.StoredProcedure, parameters)

                If Reader.Read() Then
                    With ObjectUser
                        '.User_id = Reader("User_id").ToString()
                        .User_name = Reader("User_name").ToString()
                        .User_first_name = Reader("User_first_name").ToString()
                        .User_last_name = Reader("User_last_name").ToString()
                        .User_email = Reader("User_email").ToString()
                        .User_password = Reader("User_password").ToString()
                        .User_status = CInt(Reader("User_status"))
                        .User_created_at = CDate(Reader("User_created_at"))
                        .User_updated_at = CDate(Reader("User_updated_at"))

                    End With
                End If
                Reader.Close()

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return ObjectUser

        End Function

        Public Function Insert(Users As Users) As Boolean
            Dim strSQL = "procUsers_Insert"
            Dim result As Integer
            Dim paraName() As String = {"p_user_name", "p_user_first_name", "p_user_last_name", "p_user_email", "p_user_password", "p_user_status", "p_user_created_at", "p_user_updated_at"}
            Dim paraValue As Object = New Object() {Users.User_name, Users.User_first_name, Users.User_last_name, Users.User_email, Users.User_password, Users.User_status, Users.User_created_at, Users.User_updated_at}

            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0
        End Function

        Public Function Update(Users As Users) As Boolean
            Dim strSQL = "procUsers_Update"
            Dim result As Integer
            Dim paraName() As String = {"p_user_name", "p_user_first_name", "p_user_last_name", "p_user_email", "p_user_status", "p_user_created_at", "p_user_updated_at", "p_user_Id"}
            Dim paraValue As Object = New Object() {Users.User_name, Users.User_first_name, Users.User_last_name, Users.User_email, Users.User_status, Users.User_created_at, Users.User_updated_at, Users.User_id}

            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0
        End Function

        Public Function ChangePassWord(User_Name As String, OldPw As String, NewPw As String) As Boolean
            Dim strSQL = "procUsers_ChangePass"
            Dim paraName() As String = {"p_user_name", "p_old_password", "p_new_password"}
            Dim paraValue As Object = New Object() {User_Name, OldPw, NewPw}
            Dim result As Integer

            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0
        End Function

        Public Function UpdatePassWordByUserName(user_name As String, passWord As String) As Boolean
            Dim strSQL = "procUsers_Update_PassWord"
            Dim paraName() As String = {"p_user_name", "p_user_password"}
            Dim paraValue As Object = New Object() {user_name, passWord}
            Dim result As Integer

            Try
                Dim parameters = DBHelper.GetInstance.GetParameter(paraName, paraValue)
                result = DBHelper.GetInstance.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, parameters)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return result > 0
        End Function

        Public Function HasMatchUserAndPassWord(UserName As String, PassWord As String) As Boolean
            Dim objUser As Users = GetUserByUserName(UserName)
            If objUser.User_name IsNot Nothing Then
                If objUser.User_password = SecurityHelper.GetMD5(PassWord) Then
                    Return True
                End If
            End If
            Return False
        End Function

        Public Function CheckUser(ByRef status As User_status, Optional ByVal userName As String = Nothing, Optional ByVal User_email As String = Nothing) As Users

            Dim objUser As Users = GetUserByUserNameOrEmail(userName, User_email)

            If objUser.User_name IsNot Nothing Then
                If objUser.User_status = 1 Then
                    status = User_status.Active
                Else
                    status = User_status.Locked
                End If
            Else
                status = User_status.NotExists
            End If

            Return objUser
        End Function

        Public Function Login(ByVal userName As String, ByVal passWord As String, ByRef status As User_status) As Users

            Dim objUser As Users = GetUserByUserName(userName)

            If objUser.User_name IsNot Nothing Then
                If objUser.User_password = SecurityHelper.GetMD5(passWord) Then
                    If objUser.User_status = 1 Then
                        status = User_status.Active
                    Else
                        status = User_status.Locked
                    End If
                Else
                    status = User_status.WrongPass
                End If
            Else
                status = User_status.NotExists
            End If

            Return objUser

        End Function

    End Class

End Namespace