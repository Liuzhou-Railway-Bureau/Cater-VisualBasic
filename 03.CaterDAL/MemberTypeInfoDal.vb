Imports System.Data.SQLite
Imports System.Text
Imports _04.CaterModel

Partial Public Class MemberTypeInfoDal

    ''' <summary>
    ''' gets undeleted member type list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <returns>member type list</returns>
    Public Function GetList(conn As String) As List(Of MemberTypeInfo)
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT * FROM MemberTypeInfo WHERE MIsDelete=0"
        Dim list As New List(Of MemberTypeInfo)
        ' reads data
        Dim reader As SQLiteDataReader = Nothing
        Try
            reader = SqliteHelper.ExecuteReader(connStr, sqlText)
            Do While reader.Read()
                list.Add(New MemberTypeInfo() With {
                    .MId = CInt(reader("MId")),
                    .MTitle = CStr(reader("MTitle")),
                    .MDiscount = CDec(reader("MDiscount")),
                    .MIsDelete = CBool(reader("MIsDelete"))
                })
            Loop
        Catch

        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        Return list
    End Function

    ''' <summary>
    ''' inserts member type
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mti">member type to be inserted</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Insert(conn As String, mti As MemberTypeInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "INSERT INTO MemberTypeInfo(MTitle,MDiscount,MIsDelete) VALUES(@title,@discount,0)"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
            New SQLiteParameter("@title", mti.MTitle),
            New SQLiteParameter("@discount", mti.MDiscount)
        }
        ' inserts member type
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' updates member type
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mti">member type to be updated</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Update(conn As String, mti As MemberTypeInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "UPDATE MemberTypeInfo SET MTitle=@title,MDiscount=@discount WHERE MId=@id"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
             New SQLiteParameter("@title", mti.MTitle),
             New SQLiteParameter("@discount", mti.MDiscount),
             New SQLiteParameter("@id", mti.MId)
        }
        ' updates member type
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' deletes member type according to member type id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">member type id</param>
    ''' <returns>the number of row affected</returns>
    Public Function Delete(conn As String, ParamArray ids As Integer()) As Integer
        ' constructs SQL statement and parameters
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sb As New StringBuilder
        Dim parameters As New List(Of SQLiteParameter)
        For i As Integer = 0 To ids.Length - 1
            sb.Append($"UPDATE MemberTypeInfo SET MIsDelete=1 WHERE MId=@id{i};")
            parameters.Add(New SQLiteParameter($"@id{i}", ids(i)))
        Next
        ' deletes member type
        Return SqliteHelper.ExecuteNonQuery(connStr, sb.ToString(), parameters.ToArray())
    End Function
End Class
