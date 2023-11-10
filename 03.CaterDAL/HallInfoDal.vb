Imports System.Data.SQLite
Imports System.Text
Imports _04.CaterModel

Partial Public Class HallInfoDal

    ''' <summary>
    ''' gets undeleted hall list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <returns>hall list</returns>
    Public Function GetList(conn As String) As List(Of HallInfo)
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT * FROM HallInfo WHERE HIsDelete=0"
        Dim list As New List(Of HallInfo)
        ' reads data
        Dim reader As SQLiteDataReader = Nothing
        Try
            reader = SqliteHelper.ExecuteReader(connStr, sqlText)
            Do While reader.Read()
                list.Add(New HallInfo() With {
                    .HId = CInt(reader("HId")),
                    .HTitle = CStr(reader("HTitle")),
                    .HIsDelete = CBool(reader("HIsDelete"))
                })
            Loop
        Catch

        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        Return list
    End Function

    ''' <summary>
    ''' inserts hall
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="hi">hall to be inserted</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Insert(conn As String, hi As HallInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "INSERT INTO HallInfo(HTitle,HIsDelete) VALUES(@title,0)"
        ' constructs parameter
        Dim parameter As New SQLiteParameter("@title", hi.HTitle)
        ' inserts hall
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameter)
    End Function

    ''' <summary>
    ''' updates hall
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="hi">hall to be updated</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Update(conn As String, hi As HallInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "UPDATE HallInfo SET HTitle=@title WHERE HId=@id"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
             New SQLiteParameter("@title", hi.HTitle),
             New SQLiteParameter("@id", hi.HId)
        }
        ' updates hall
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' deletes hall according to hall id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">hall id</param>
    ''' <returns>the number of row affected</returns>
    Public Function Delete(conn As String, ParamArray ids As Integer()) As Integer
        ' constructs SQL statement and parameters
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sb As New StringBuilder
        Dim parameters As New List(Of SQLiteParameter)
        For i As Integer = 0 To ids.Length - 1
            sb.Append($"UPDATE HallInfo SET HIsDelete=1 WHERE HId=@id{i};")
            parameters.Add(New SQLiteParameter($"@id{i}", ids(i)))
        Next
        ' deletes hall
        Return SqliteHelper.ExecuteNonQuery(connStr, sb.ToString(), parameters.ToArray())
    End Function
End Class
