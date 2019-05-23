Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SQLite


Public Class DBrun
    Private Sub New()
    End Sub

    Private Shared Singleton As DBrun
    Private ReadOnly connMYSQL As MySqlConnection = DBUtils.MYSQL()
    Private ReadOnly connMSSQL As SqlConnection = DBUtils.MSSQL()
    Private ReadOnly connSQLite As SQLiteConnection = DBUtils.SQLite()
    Private data As DataTable = New DataTable()
    Public Shared Function getInstance() As DBrun
        If (Singleton Is Nothing) Then
            Singleton = New DBrun()
        End If
        Return Singleton
    End Function
    Public Function GetDataTable(ByVal query As String, ByVal Optional parameter As Object() = Nothing) As DataTable
        connMYSQL.Open()
        Dim command As MySqlCommand = New MySqlCommand(query, connMYSQL)
        If parameter IsNot Nothing Then
            Dim listPara As String() = query.Split(" "c)
            Dim i As Integer = 0
            For Each item As String In listPara
                If item.Contains("@"c) Then
                    command.Parameters.AddWithValue(item, parameter(i))
                    i += 1
                End If
            Next
        End If
        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(command)
        adapter.Fill(data)
        connMYSQL.Close()
        Return data
    End Function
    Public Function GetDataTable(ByVal query As String, ByVal name As String(), ByVal value As Object(), ByVal parameter As Integer) As DataTable
        Dim data As DataTable = New DataTable()

        Using conn As MySqlConnection = DBUtils.MYSQL()
            conn.Open()
            Dim command As MySqlCommand = New MySqlCommand(query, conn)

            For i = 0 To parameter - 1
                command.Parameters.AddWithValue(name(i), value(i))
            Next

            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(command)
            adapter.Fill(data)
            conn.Close()
        End Using

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
                        i += 1
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
                        i += 1
                    End If
                Next
            End If

            data = command.ExecuteScalar()
            conn.Close()
        End Using

        Return data
    End Function
End Class

