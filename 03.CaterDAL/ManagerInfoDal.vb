Imports System.Data.SQLite
Imports System.Text
Imports _04.CaterModel
Imports _05.CaterCommon

Partial Public Class ManagerInfoDal

    ''' <summary>
    ''' gets user list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <returns>user list</returns>
    Public Function GetList(conn As String) As List(Of ManagerInfo)
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT * FROM ManagerInfo"
        ' queries table
        Dim dt As DataTable = SqliteHelper.ExecuteTable(connStr, sqlText, "ManagerInfo")
        ' saves data to list
        Dim list As New List(Of ManagerInfo)
        For Each dr As DataRow In dt.Rows
            list.Add(New ManagerInfo() With {
                .MId = Convert.ToInt32(dr("MId")),
                .MName = dr("MName").ToString(),
                .MPwd = dr("MPwd").ToString(),
                .MType = Convert.ToInt32(dr("MType"))
            })
        Next
        Return list
    End Function

    ''' <summary>
    ''' inserts user
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mi">user to be inserted</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Insert(conn As String, mi As ManagerInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "INSERT INTO ManagerInfo(MName,MPwd,MType) VALUES(@name,@pwd,@type)"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
            New SQLiteParameter("@name", mi.MName),
            New SQLiteParameter("@pwd", Md5Helper.Encrypt(mi.MPwd)),
            New SQLiteParameter("@type", mi.MType)
        }
        ' inserts user
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' updates user
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mi">user to be updated</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Update(conn As String, mi As ManagerInfo) As Integer
        ' constructs SQL statement
        Dim sqlText As String
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        If mi.MPwd.Equals("旧密码") Then
            sqlText = "UPDATE ManagerInfo SET MName=@name,MType=@type WHERE MId=@id"
        Else
            sqlText = "UPDATE ManagerInfo SET MName=@name,MPwd=@pwd,MType=@type WHERE MId=@id"
        End If
        ' constructs parameters
        Dim parameters As New List(Of SQLiteParameter)
        parameters.Add(New SQLiteParameter("@name", mi.MName))
        If Not mi.MPwd.Equals("旧密码") Then parameters.Add(New SQLiteParameter("@pwd", Md5Helper.Encrypt(mi.MPwd)))
        parameters.Add(New SQLiteParameter("@type", mi.MType))
        parameters.Add(New SQLiteParameter("@id", mi.MId))

        ' updates user
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters.ToArray())
    End Function

    ''' <summary>
    ''' deletes user according to user id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">user id</param>
    ''' <returns>the number of row affected</returns>
    Public Function Delete(conn As String, ParamArray ids As Integer()) As Integer
        ' constructs SQL statement and parameters
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sb As New StringBuilder
        Dim parameters As New List(Of SQLiteParameter)
        For i As Integer = 0 To ids.Length - 1
            sb.Append($"DELETE FROM ManagerInfo WHERE MId=@id{i};")
            parameters.Add(New SQLiteParameter($"@id{i}", ids(i)))
        Next
        ' deletes user
        Return SqliteHelper.ExecuteNonQuery(connStr, sb.ToString(), parameters.ToArray())
    End Function

    ''' <summary>
    ''' finds user by username
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="username">username</param>
    ''' <returns>found user or Nothing</returns>
    Public Function GetUserByName(conn As String, username As String) As ManagerInfo
        ' defines a mi
        Dim mi As ManagerInfo = Nothing
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT * FROM ManagerInfo WHERE MName=@username"
        ' constructs parameter
        Dim p As New SQLiteParameter("@username", username)
        ' queries table
        Dim dt As DataTable = SqliteHelper.ExecuteTable(connStr, sqlText, "ManagerInfo", p)

        ' checks if user has been found
        If dt.Rows.Count > 0 Then
            ' user exists
            mi = New ManagerInfo With {
                .MId = CInt(dt.Rows(0)("MId")),
                .MName = dt.Rows(0)("MName").ToString(),
                .MPwd = dt.Rows(0)("MPwd").ToString(),
                .MType = CInt(dt.Rows(0)("MType"))
            }
        End If

        Return mi
    End Function
End Class
