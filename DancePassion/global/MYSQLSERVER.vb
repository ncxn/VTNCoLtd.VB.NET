Imports MySql.Data.MySqlClient
Public Class MYSQLSERVER
    Public Property Server As String = "173.254.231.108"
    Public Property UserName As String = "root"
    Public Property Password As String = "mmttmhh"
    Public Property Database As String = "dp"

    Public Function connstr() As String
        connstr = CType("server=" & Server & ";" & "userid=" & UserName & ";" & "password=" & Password & ";" & "database=" & Database, String)
        Return connstr
    End Function
    Public Function Get_Row(sql As String) As ArrayList
        Dim Result As New ArrayList
        Dim conn As New MySqlConnection(connstr)

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(sql, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim dict As New Dictionary(Of String, Object)
                For count As Integer = 0 To (reader.FieldCount - 1)
                    dict.Add(reader.GetName(count), reader(count))
                Next
                Result.Add(dict)
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("không thể kết nối với dữ liệu: " & ex.Message & Err.Number)
        Finally
            conn.Close()
        End Try
        GC.Collect()
        Return Result
    End Function
    Public Function Get_Value(sql As String) As String
        Dim conn As New MySqlConnection(connstr)
        Dim Result As String
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(sql, conn)
            Result = CType(cmd.ExecuteScalar(), String)
            conn.Close()
        Catch ex As Exception
            Console.WriteLine("MySQL retrieve value: " & ex.Message & Err.Number)
            Result = Nothing
        Finally
            conn.Dispose()
            conn = Nothing
        End Try
        GC.Collect()
        Return Result
    End Function
    Public Function Get_tb(sql As String) As DataTable

        Dim conn As New MySqlConnection(connstr)
        Dim dt As New DataTable

        Try
            conn.Open()
            Dim da As New MySqlDataAdapter(sql, conn)
            da.Fill(dt)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Không thể kết nối với dữ liệu: " & ex.Message & Err.Number)
        Finally
            conn.Dispose()
            conn = Nothing
            dt = Nothing
        End Try

        GC.Collect()
        Return dt

    End Function
    Public Function Insert_Row(sql As String) As Boolean

        Insert_Row = False

        Dim conn As New MySqlConnection(connstr)


        Try
            conn.Open()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            Insert_Row = True
        Catch ex As MySqlException
            Console.WriteLine("Không thể thêm dữ liệu: " & ex.Message & Err.Number)
            Insert_Row = False
        Finally
            conn.Dispose()
            conn = Nothing
        End Try
        GC.Collect()
    End Function
    Public Function Delete_Row(sql As String) As Boolean

        Dim conn As New MySqlConnection(connstr)

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            Delete_Row = True
        Catch ex As MySqlException
            Console.WriteLine("Không thể xóa: " & ex.Message & Err.Number)
            Delete_Row = False
        Finally
            conn.Dispose()
            conn = Nothing
        End Try
        GC.Collect()
    End Function
End Class
