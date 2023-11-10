Imports System.Data.SQLite
Imports System.Text
Imports _04.CaterModel

Partial Public Class DishInfoDal

    ''' <summary>
    ''' gets undeleted dish list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="dic">find condition</param>
    ''' <returns>dish list</returns>
    Public Function GetList(conn As String, dic As Dictionary(Of String, String)) As List(Of DishInfo)
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT di.*,dti.DTitle TypeTitle FROM DishInfo di JOIN DishTypeInfo dti ON di.DTypeId=dti.DId WHERE di.DIsDelete=0 AND dti.DIsDelete=0"
        Dim list As New List(Of DishInfo)

#Region "find condition"
        If dic.Count > 0 Then
            For Each item As KeyValuePair(Of String, String) In dic
                sqlText += $" AND di.{item.Key} LIKE '%{item.Value}%'"
            Next
        End If
#End Region

        ' reads data
        Dim reader As SQLiteDataReader = Nothing
        Try
            reader = SqliteHelper.ExecuteReader(connStr, sqlText)
            Do While reader.Read()
                list.Add(New DishInfo() With {
                    .DId = CInt(reader("DId")),
                    .DTitle = CStr(reader("DTitle")),
                    .DTypeId = CInt(reader("DTypeId")),
                    .DPrice = CInt(reader("DPrice")),
                    .DChar = reader("DChar").ToString(),
                    .DIsDelete = CBool(reader("DIsDelete")),
                    .DTypeTitle = reader("TypeTitle").ToString()
                })
            Loop
        Catch

        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        Return list
    End Function

    ''' <summary>
    ''' inserts dish
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="di">dish to be inserted</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Insert(conn As String, di As DishInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "INSERT INTO DishInfo(DTitle,DTypeId,DPrice,DChar,DIsDelete) VALUES(@title,@typeId,@price,@char,0)"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
             New SQLiteParameter("@title", di.DTitle),
             New SQLiteParameter("@typeId", di.DTypeId),
             New SQLiteParameter("@price", di.DPrice),
             New SQLiteParameter("@char", di.DChar)
        }
        ' inserts dish
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' updates dish
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="di">dish to be updated</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Update(conn As String, di As DishInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "UPDATE DishInfo SET DTitle=@title,DTypeId=@typeId,DPrice=@price,DChar=@char WHERE DId=@id"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
             New SQLiteParameter("@title", di.DTitle),
             New SQLiteParameter("@typeId", di.DTypeId),
             New SQLiteParameter("@price", di.DPrice),
             New SQLiteParameter("@char", di.DChar),
             New SQLiteParameter("@id", di.DId)
        }
        ' updates dish
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' deletes dish according to dish id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">dish id</param>
    ''' <returns>the number of row affected</returns>
    Public Function Delete(conn As String, ParamArray ids As Integer()) As Integer
        ' constructs SQL statement and parameters
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sb As New StringBuilder
        Dim parameters As New List(Of SQLiteParameter)
        For i As Integer = 0 To ids.Length - 1
            sb.Append($"UPDATE DishInfo SET DIsDelete=1 WHERE DId=@id{i};")
            parameters.Add(New SQLiteParameter($"@id{i}", ids(i)))
        Next
        ' deletes dish
        Return SqliteHelper.ExecuteNonQuery(connStr, sb.ToString(), parameters.ToArray())
    End Function
End Class
