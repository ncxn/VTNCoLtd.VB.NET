﻿Imports MySql.Data.MySqlClient

Namespace DAL
    Public Class DBHelper
        Dim DBUtils As New DBUtils
        Private Shared Singleton As DBHelper
        Private ReadOnly connMYSQL As MySqlConnection = DBUtils.GetInstance.MYSQL()
        'Private ReadOnly connMSSQL As SqlConnection = DBUtils.GetInstance.MSSQL()
        'Private ReadOnly connSQLite As SQLiteConnection = DBUtils.GetInstance.SQLite()
        Private transactionScope As MySqlTransaction

        ''' <summary>
        ''' Initialize singleton through lazy 
        ''' initialization to prevent unused 
        ''' singleton from taking up program 
        ''' memory
        ''' </summary>
        ''' <returns>single object instance</returns>
        Public Shared Function GetInstance() As DBHelper
            If Singleton Is Nothing Then
                Singleton = New DBHelper()
            End If
            Return Singleton
        End Function

        Public Sub OpenConnection()
            If connMYSQL.State = ConnectionState.Closed Then
                connMYSQL.Open()
            End If
        End Sub

        Public Sub CloseConnection()
            If connMYSQL.State = ConnectionState.Open Then
                connMYSQL.Close()
            End If
        End Sub

        Public Sub BeginTransaction()
            OpenConnection()
            transactionScope = connMYSQL.BeginTransaction()
        End Sub

        Public Sub CommitTransaction()
            transactionScope.Commit()
            CloseConnection()
        End Sub

        Public Sub RollbackTransaction()
            transactionScope.Rollback()
            CloseConnection()
        End Sub

        Private Function GetCommand(ByVal commandText As String, ByVal commandType As CommandType) As MySqlCommand
            Dim cmd = New MySqlCommand With {
                .CommandText = commandText,
                .CommandType = commandType,
                .Connection = connMYSQL
            }
            Return cmd
        End Function

        Private Function GetCommandWithTransaction(ByVal commandText As String, ByVal commandType As CommandType) As MySqlCommand
            Dim cmd = New MySqlCommand With {
                .CommandText = commandText,
                .CommandType = commandType,
                .Connection = connMYSQL,
                .Transaction = transactionScope
            }
            Return cmd
        End Function

        ''' <summary>
        ''' Create parameter
        ''' </summary>
        ''' <param name="name"></param>
        ''' <param name="value"></param>
        ''' <returns>Single parameter</returns>
        Private Function AddParameter(ByVal name As String, ByVal value As Object) As MySqlParameter
            Try
                Dim Parameter = New MySqlParameter With {
                    .ParameterName = name,
                    .Value = value,
                    .Direction = ParameterDirection.Input
                }
                Return Parameter
            Catch ex As Exception
                Throw New Exception("Invalid parameter")
            End Try
        End Function

        ''' <summary>
        ''' Create list parameter
        ''' </summary>
        ''' <param name="name"></param>
        ''' <param name="value"></param>
        ''' <returns>List(of parameter)</returns>
        Public Function GetParameter(ByVal name() As String, ByVal value() As Object) As List(Of MySqlParameter)
            Try
                Dim parameters = New List(Of MySqlParameter)

                For index = 0 To name.Count - 1
                    parameters.Add(AddParameter(name(index), value(index)))
                Next
                Return parameters
            Catch ex As Exception
                Throw New Exception("Invalid parameter")
            End Try
        End Function

        ''' <summary>
        ''' Get DataTable
        ''' </summary>
        ''' <param name="commandText"></param>
        ''' <param name="commandType"></param>
        ''' <param name="parameters"></param>
        ''' <returns>DataTable</returns>
        Public Function GetDataTable(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As List(Of MySqlParameter) = Nothing) As DataTable

            Dim dt As DataTable = New DataTable()
            Dim cmd As MySqlCommand = GetCommand(commandText, commandType)
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)

            If parameters IsNot Nothing Then
                cmd.Parameters.AddRange(parameters.ToArray())
            End If

            Try
                OpenConnection()
                adapter.Fill(dt)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                CloseConnection()
            End Try

            Return dt

        End Function

        ''' <summary>
        ''' Get DataSet
        ''' </summary>
        ''' <param name="commandText"></param>
        ''' <param name="commandType"></param>
        ''' <param name="parameters"></param>
        ''' <returns>DataSet</returns>
        Public Function GetDataSet(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As List(Of MySqlParameter) = Nothing) As DataSet

            Dim cmd As MySqlCommand = GetCommand(commandText, commandType)
            Dim ds = New DataSet()
            Dim dataAdaper = New MySqlDataAdapter(cmd)

            If parameters IsNot Nothing Then
                cmd.Parameters.AddRange(parameters.ToArray())
            End If

            Try
                OpenConnection()
                dataAdaper.Fill(ds)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                CloseConnection()
            End Try

            Return ds
        End Function

        ''' <summary>
        ''' Get DataReader: must close connection after reading data!
        ''' </summary>
        ''' <param name="commandText"></param>
        ''' <param name="commandType"></param>
        ''' <param name="parameters"></param>
        ''' <returns>DataReader</returns>
        Public Function GetDataReader(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As List(Of MySqlParameter) = Nothing) As MySqlDataReader

            Dim cmd As MySqlCommand = GetCommand(commandText, commandType)

            If parameters IsNot Nothing Then
                cmd.Parameters.AddRange(parameters.ToArray())
            End If

            OpenConnection()

            Return cmd.ExecuteReader(CommandBehavior.CloseConnection)

        End Function

        ''' <summary>
        ''' Get ScalarValue (First column of first row)
        ''' </summary>
        ''' <param name="commandText"></param>
        ''' <param name="commandType"></param>
        ''' <param name="parameters"></param>
        ''' <returns>First column of first row</returns>
        Public Function GetScalarValue(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As List(Of MySqlParameter) = Nothing) As Integer

            Dim cmd As MySqlCommand = GetCommand(commandText, commandType)

            If parameters IsNot Nothing Then
                cmd.Parameters.AddRange(parameters.ToArray())
            End If

            Try
                OpenConnection()
                Return cmd.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                CloseConnection()
            End Try

        End Function

        ''' <summary>
        ''' Execute query and returns number of row effected
        ''' </summary>
        ''' <param name="commandText"></param>
        ''' <param name="commandType"></param>
        ''' <param name="parameters"></param>
        ''' <returns>rows effected as Integer</returns>
        Public Function ExecuteNonQuery(ByVal commandText As String, ByVal commandType As CommandType, Optional ByVal parameters As List(Of MySqlParameter) = Nothing) As Integer

            Dim result As Integer = 0
            Dim cmd As MySqlCommand = GetCommand(commandText, commandType)

            If parameters IsNot Nothing Then
                cmd.Parameters.AddRange(parameters.ToArray())
            End If

            Try
                OpenConnection()
                result = cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                CloseConnection()
            End Try

            Return result

        End Function

        ''' <summary>
        ''' Execute Query With Transaction
        ''' </summary>
        ''' <param name="commandText"></param>
        ''' <param name="commandType"></param>
        ''' <param name="parameters"></param>
        ''' <returns>rows effected as Integer</returns>
        Public Function ExecuteNonQueryWithTransaction(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As List(Of MySqlParameter) = Nothing) As Integer

            Dim result As Integer = 0

            BeginTransaction()

            Dim cmd As MySqlCommand = GetCommandWithTransaction(commandText, commandType)

            If parameters IsNot Nothing Then
                cmd.Parameters.AddRange(parameters.ToArray())
            End If

            Try
                result = cmd.ExecuteNonQuery()
                CommitTransaction()
            Catch ex As Exception
                RollbackTransaction()
                Throw New Exception(ex.Message)
            Finally
                CloseConnection()
            End Try

            Return result

        End Function

        ''' <summary>
        ''' Execute Query commandType = commandType.text
        ''' ex: "Select * from tblUsers where userID = @userID and password = @password"
        ''' The argument must be an array of objects and there must be spaces between the elements.
        ''' ex: parameters = new object{"para1", "para2", "para3"}
        ''' </summary>
        ''' <param name="commandText"></param>
        ''' <param name="commandType"></param>
        ''' <param name="parameters"></param>
        ''' <returns>rows effected as Integer</returns>
        Public Function ExecuteNonQueryWithText(ByVal commandText As String, ByVal commandType As CommandType, Optional ByVal parameters As Object() = Nothing) As Integer
            OpenConnection()
            Dim result As Integer = 0

            Using cmd As MySqlCommand = GetCommand(commandText, commandType)
                If parameters IsNot Nothing Then
                    Dim listPara As String() = commandText.Split(" "c)
                    Dim i As Integer = 0

                    For Each item As String In listPara

                        If item.Contains("@"c) Then
                            cmd.Parameters.AddWithValue(item, parameters(i))
                            i = i + 1
                        End If
                    Next
                End If
                result = cmd.ExecuteNonQuery()
            End Using
            CloseConnection()
            Return result
        End Function

        ''' <summary>
        ''' Execute Query commandType = commandType.text
        ''' ex: "Select * from tblUsers where userID = @userID and password = @password"
        ''' The argument must be an array of objects and there must be spaces between the elements.
        ''' ex: parameters = new object{"para1", "para2", "para3"}
        ''' </summary>
        ''' <param name="commandText"></param>
        ''' <param name="commandType"></param>
        ''' <param name="parameters"></param>
        ''' <returns>first culumn of first row</returns>
        Public Function ExecuteScalar(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As Object() = Nothing) As Object
            OpenConnection()
            Dim Result As Object = 0

            Using cmd As MySqlCommand = GetCommand(commandText, commandType)
                If parameters IsNot Nothing Then
                    Dim listPara As String() = commandText.Split(" "c)
                    Dim i As Integer = 0

                    For Each item As String In listPara

                        If item.Contains("@"c) Then
                            cmd.Parameters.AddWithValue(item, parameters(i))
                            i = i + 1
                        End If
                    Next
                End If
                Result = cmd.ExecuteScalar()
            End Using
            OpenConnection()
            Return Result
        End Function

        ''' <summary>
        ''' Execute Query commandType = commandType.text
        ''' ex: "Select * from tblUsers where userID = @userID and password = @password"
        ''' The argument must be an array of objects and there must be spaces between the elements.
        ''' ex: parameters = new object{"para1", "para2", "para3"}
        ''' </summary>
        ''' <param name="commandText"></param>
        ''' <param name="commandType"></param>
        ''' <param name="parameters"></param>
        ''' <returns>first culumn of first row</returns>
        Public Function ExecuteReader(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As Object() = Nothing) As Object

            Dim Result As MySqlDataReader
            Dim cmd As MySqlCommand = GetCommand(commandText, commandType)

            If parameters IsNot Nothing Then
                Dim listPara As String() = commandText.Split(" "c)
                Dim i As Integer = 0

                For Each item As String In listPara

                    If item.Contains("@"c) Then
                        cmd.Parameters.AddWithValue(item, parameters(i))
                        i = i + 1
                    End If
                Next
            End If

            OpenConnection()
            Result = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            Return Result
        End Function
    End Class

End Namespace