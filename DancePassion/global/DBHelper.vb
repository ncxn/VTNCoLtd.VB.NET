Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SQLite
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices

Public Class DBHelper

    Private Shared Singleton As DBHelper
    Private ReadOnly connMYSQL As MySqlConnection = DBUtils.MYSQL()
    Private ReadOnly connMSSQL As SqlConnection = DBUtils.MSSQL()
    Private ReadOnly connSQLite As SQLiteConnection = DBUtils.SQLite()
    Private ReadOnly dt As DataTable = New DataTable()
    Private ReadOnly ds As DataSet = New DataSet()
    'Private cmd As MySqlCommand
    Private transactionScope As MySqlTransaction
    Public Shared Function GetInstance() As DBHelper
        If (Singleton Is Nothing) Then
            Singleton = New DBHelper()
        End If
        Return Singleton
    End Function

    Private Sub OpenConnection()
        connMYSQL.Open()
    End Sub

    Private Sub CloseConnection()
        connMYSQL.Close()
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

    Public Function GetDataTable(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As MySqlParameter() = Nothing) As DataTable
        OpenConnection()

        Using cmd As MySqlCommand = GetCommand(commandText, commandType)

            If parameters IsNot Nothing Then
                For Each parameter In parameters
                    cmd.Parameters.Add(parameter)
                Next
            End If

            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
            Return dt

        End Using

        CloseConnection()
    End Function

    Public Function GetDataSet(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As MySqlParameter() = Nothing) As DataSet
        OpenConnection()

        Using cmd As MySqlCommand = GetCommand(commandText, commandType)

            If parameters IsNot Nothing Then

                For Each parameter In parameters
                    cmd.Parameters.Add(parameter)
                Next
            End If

            Dim ds = New DataSet()
            Dim dataAdaper = New MySqlDataAdapter(cmd)
            dataAdaper.Fill(ds)
            Return ds

        End Using

        CloseConnection()

    End Function

    Public Function GetDataReader(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As MySqlParameter() = Nothing) As MySqlDataReader
        OpenConnection()

        Dim cmd As MySqlCommand = GetCommand(commandText, commandType)

        If parameters IsNot Nothing Then
            For Each parameter In parameters
                cmd.Parameters.Add(parameter)
            Next
        End If

        Return cmd.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

    Public Function GetScalarValue(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As MySqlParameter() = Nothing) As Object
        OpenConnection()

        Using cmd As MySqlCommand = GetCommand(commandText, commandType)
            If parameters IsNot Nothing Then
                For Each parameter In parameters
                    cmd.Parameters.Add(parameter)
                Next
            End If

            Return cmd.ExecuteScalar()
        End Using

        CloseConnection()
    End Function

    Public Function ExecuteNonQuery(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As MySqlParameter() = Nothing) As Integer

        Dim cmd As MySqlCommand = GetCommand(commandText, commandType)
        If parameters IsNot Nothing Then
            For Each parameter In parameters
                cmd.Parameters.Add(parameter)
            Next
        End If

        OpenConnection()
        Return cmd.ExecuteNonQuery()
        CloseConnection()
    End Function

    Public Function ExecuteNonQuerytWithTransaction(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As MySqlParameter() = Nothing) As Integer
        Dim result As Integer = 0
        BeginTransaction()

        Dim cmd As MySqlCommand = GetCommandWithTransaction(commandText, commandType)

        If parameters IsNot Nothing Then
            For Each parameter In parameters
                cmd.Parameters.Add(parameter)
            Next
        End If

        Try
            result = cmd.ExecuteNonQuery()
            CommitTransaction()
        Catch ex As Exception
            RollbackTransaction()
            result = 0
        End Try

        Return Result
    End Function

    Public Function ExecuteNonQuery(ByVal commandText As String, ByVal commandType As CommandType, ByVal Optional parameters As Object() = Nothing) As Integer
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