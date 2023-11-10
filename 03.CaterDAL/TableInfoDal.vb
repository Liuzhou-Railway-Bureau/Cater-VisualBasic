Imports System.Data.SQLite
Imports System.Text
Imports _04.CaterModel

Partial Public Class TableInfoDal

    ''' <summary>
    ''' gets undeleted table list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="dic">find condition</param>
    ''' <returns>table list</returns>
    Public Function GetList(conn As String, dic As Dictionary(Of String, String)) As List(Of TableInfo)
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT ti.*,hi.HTitle HallTitle FROM TableInfo ti JOIN HallInfo hi ON ti.THallId=hi.HId WHERE ti.TIsDelete=0 AND hi.HIsDelete=0"
        Dim list As New List(Of TableInfo)

        ' constructs parameters
        Dim parameters As New List(Of SQLiteParameter)

#Region "find condition"
        If dic.Count > 0 Then
            For Each item As KeyValuePair(Of String, String) In dic
                sqlText += $" AND ti.{item.Key}=@{item.Key}"
                parameters.Add(New SQLiteParameter($"@{item.Key}", item.Value))
            Next
        End If
#End Region

        ' reads data
        Dim reader As SQLiteDataReader = Nothing
        Try
            reader = SqliteHelper.ExecuteReader(connStr, sqlText, parameters.ToArray())
            Do While reader.Read()
                list.Add(New TableInfo() With {
                    .TId = CInt(reader("TId")),
                    .TTitle = CStr(reader("TTitle")),
                    .THallId = CInt(reader("THallId")),
                    .TIsFree = CBool(reader("TIsFree")),
                    .TIsDelete = CBool(reader("TIsDelete")),
                    .THallTitle = CStr(reader("HallTitle"))
                })
            Loop
        Catch

        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        Return list
    End Function

    ''' <summary>
    ''' inserts table
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ti">table to be inserted</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Insert(conn As String, ti As TableInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "INSERT INTO TableInfo(TTitle,THallId,TIsFree,TIsDelete) VALUES(@title,@hallId,@isFree,0)"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
             New SQLiteParameter("@title", ti.TTitle),
             New SQLiteParameter("@hallId", ti.THallId),
             New SQLiteParameter("@isFree", ti.TIsFree)
        }
        ' inserts table
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' updates table
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ti">table to be updated</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Update(conn As String, ti As TableInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "UPDATE TableInfo SET TTitle=@title,THallId=@hallId,TIsFree=@isFree WHERE TId=@id"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
             New SQLiteParameter("@title", ti.TTitle),
             New SQLiteParameter("@hallId", ti.THallId),
             New SQLiteParameter("@isFree", ti.TIsFree),
             New SQLiteParameter("@id", ti.TId)
        }
        ' updates table
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' deletes table according to table id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">table id</param>
    ''' <returns>the number of row affected</returns>
    Public Function Delete(conn As String, ParamArray ids As Integer()) As Integer
        ' constructs SQL statement and parameters
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sb As New StringBuilder
        Dim parameters As New List(Of SQLiteParameter)
        For i As Integer = 0 To ids.Length - 1
            sb.Append($"UPDATE TableInfo SET TIsDelete=1 WHERE TId=@id{i};")
            parameters.Add(New SQLiteParameter($"@id{i}", ids(i)))
        Next
        ' deletes table
        Return SqliteHelper.ExecuteNonQuery(connStr, sb.ToString(), parameters.ToArray())
    End Function
End Class
