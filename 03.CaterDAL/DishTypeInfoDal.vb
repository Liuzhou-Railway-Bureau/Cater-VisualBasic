Imports System.Data.SQLite
Imports System.Text
Imports _04.CaterModel

Partial Public Class DishTypeInfoDal

    ''' <summary>
    ''' gets undeleted dish type list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <returns>dish type list</returns>
    Public Function GetList(conn As String) As List(Of DishTypeInfo)
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT * FROM DishTypeInfo WHERE DIsDelete=0"
        Dim list As New List(Of DishTypeInfo)
        ' reads data
        Dim reader As SQLiteDataReader = Nothing
        Try
            reader = SqliteHelper.ExecuteReader(connStr, sqlText)
            Do While reader.Read()
                list.Add(New DishTypeInfo() With {
                    .DId = CInt(reader("DId")),
                    .DTitle = CStr(reader("DTitle")),
                    .DIsDelete = CBool(reader("DIsDelete"))
                })
            Loop
        Catch

        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        Return list
    End Function

    ''' <summary>
    ''' inserts dish type
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="dti">dish type to be inserted</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Insert(conn As String, dti As DishTypeInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "INSERT INTO DishTypeInfo(DTitle,DIsDelete) VALUES(@title,0)"
        ' constructs parameter
        Dim parameter As New SQLiteParameter("@title", dti.DTitle)
        ' inserts dish type
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameter)
    End Function

    ''' <summary>
    ''' updates dish type
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="dti">dish type to be updated</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Update(conn As String, dti As DishTypeInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "UPDATE DishTypeInfo SET DTitle=@title WHERE DId=@id"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
             New SQLiteParameter("@title", dti.DTitle),
             New SQLiteParameter("@id", dti.DId)
        }
        ' updates dish type
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' deletes dish type according to dish type id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">dish type id</param>
    ''' <returns>the number of row affected</returns>
    Public Function Delete(conn As String, ParamArray ids As Integer()) As Integer
        ' constructs SQL statement and parameters
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sb As New StringBuilder
        Dim parameters As New List(Of SQLiteParameter)
        For i As Integer = 0 To ids.Length - 1
            sb.Append($"UPDATE DishTypeInfo SET DIsDelete=1 WHERE DId=@id{i};")
            parameters.Add(New SQLiteParameter($"@id{i}", ids(i)))
        Next
        ' deletes dish type
        Return SqliteHelper.ExecuteNonQuery(connStr, sb.ToString(), parameters.ToArray())
    End Function
End Class
