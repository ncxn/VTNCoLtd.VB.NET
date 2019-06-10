Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SQLite
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class DBHelper

    Private Shared Singleton As DBHelper
    Private ReadOnly connMYSQL As MySqlConnection = DBUtils.MYSQL()
    Private ReadOnly connMSSQL As SqlConnection = DBUtils.MSSQL()
    Private ReadOnly connSQLite As SQLiteConnection = DBUtils.SQLite()
    Private ReadOnly data As DataTable = New DataTable()
    Private cmd As MySqlCommand
    Private _sqlTran As MySqlTransaction
    Public Shared Function GetInstance() As DBHelper
        If (Singleton Is Nothing) Then
            Singleton = New DBHelper()
        End If
        Return Singleton
    End Function

    Private Sub Open()
        connMYSQL.Open()
    End Sub

    Private Sub Close()
        connMYSQL.Close()
    End Sub

    Public Sub BeginTransaction()
        connMYSQL.Open()
        _sqlTran = connMYSQL.BeginTransaction()
    End Sub

    Public Sub CommitTransaction()
        _sqlTran.Commit()
        connMYSQL.Close()
    End Sub

    Public Sub RollbackTransaction()
        _sqlTran.Rollback()
        connMYSQL.Close()
    End Sub

    Public Sub CreateNewSqlCommand()
        cmd = New MySqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .Connection = connMYSQL
        }
    End Sub

    Public Function GetDataTable(ByVal query As String, ByVal Optional parameter As Object() = Nothing) As DataTable
        connMYSQL.Open()
        Dim command As MySqlCommand = New MySqlCommand(query, connMYSQL)
        If parameter IsNot Nothing Then
            Dim listPara As String() = query.Split(" "c)
            Dim i As Integer = 0
            For Each item As String In listPara
                If item.Contains("@"c) Then
                    command.Parameters.AddWithValue(item, parameter(i))
                    i = i + 1
                End If
            Next
        End If
        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(command)
        adapter.Fill(data)
        connMYSQL.Close()
        Return data
    End Function

    Public Function ExecuteNonQuery(ByVal query As String, ByVal Optional parameter As Object() = Nothing) As Integer
        Dim data As Integer = 0

        Using conn As MySqlConnection = DBUtils.MYSQL()
            conn.Open()
            Dim command As MySqlCommand = New MySqlCommand(query, conn)

            If parameter IsNot Nothing Then
                Dim listPara As String() = query.Split(" "c)
                Dim i As Integer = 0

                For Each item As String In listPara

                    If item.Contains("@"c) Then
                        command.Parameters.AddWithValue(item, parameter(i))
                        i = i + 1
                    End If
                Next
            End If

            data = command.ExecuteNonQuery()
            conn.Close()
        End Using

        Return data
    End Function

    Public Function ExecuteScalar(ByVal query As String, ByVal Optional parameter As Object() = Nothing) As Object
        Dim data As Object = 0

        Using conn As MySqlConnection = DBUtils.MYSQL()
            conn.Open()
            Dim command As MySqlCommand = New MySqlCommand(query, conn)

            If parameter IsNot Nothing Then
                Dim listPara As String() = query.Split(" "c)
                Dim i As Integer = 0

                For Each item As String In listPara

                    If item.Contains("@"c) Then
                        command.Parameters.AddWithValue(item, parameter(i))
                        i = i + 1
                    End If
                Next
            End If

            data = command.ExecuteScalar()
            conn.Close()
        End Using

        Return data
    End Function
    Public Function ExecuteReader(ByVal query As String, ByVal Optional parameter As Object() = Nothing) As Object

        Dim data As MySqlDataReader
        Dim command As MySqlCommand = New MySqlCommand(query, connMYSQL)

        If parameter IsNot Nothing Then
            Dim listPara As String() = query.Split(" "c)
            Dim i As Integer = 0

            For Each item As String In listPara

                If item.Contains("@"c) Then
                    command.Parameters.AddWithValue(item, parameter(i))
                    i = i + 1
                End If
            Next
        End If

        connMYSQL.Open()
        data = command.ExecuteReader(CommandBehavior.CloseConnection)

        Return data

    End Function
End Class

