Imports System.Data.SQLite
Imports System.Text
Imports _04.CaterModel

Partial Public Class MemberInfoDal

    ''' <summary>
    ''' gets undeleted member list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="dic">find condition</param>
    ''' <returns>member list</returns>
    Public Function GetList(conn As String, dic As Dictionary(Of String, String)) As List(Of MemberInfo)
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT mi.*,mti.MTitle TypeTitle,mti.MDiscount Discount FROM MemberInfo mi JOIN MemberTypeInfo mti ON mi.MTypeId=mti.MId WHERE mi.MIsDelete=0 AND mti.MIsDelete=0"
        Dim list As New List(Of MemberInfo)

#Region "find condition"
        If dic.Count > 0 Then
            For Each item As KeyValuePair(Of String, String) In dic
                sqlText += $" AND mi.{item.Key} LIKE '%{item.Value}%'"
            Next
        End If
#End Region

        ' reads data
        Dim reader As SQLiteDataReader = Nothing
        Try
            reader = SqliteHelper.ExecuteReader(connStr, sqlText)
            Do While reader.Read()
                list.Add(New MemberInfo() With {
                    .MId = CInt(reader("MId")),
                    .MTypeId = CInt(reader("MTypeId")),
                    .MName = CStr(reader("MName")),
                    .MPhone = CStr(reader("MPhone")),
                    .MMoney = CDec(reader("MMoney")),
                    .MIsDelete = CBool(reader("MIsDelete")),
                    .MTypeTitle = CStr(reader("TypeTitle")),
                    .MDiscount = CDec(reader("Discount"))
                })
            Loop
        Catch

        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        Return list
    End Function

    ''' <summary>
    ''' inserts member
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mi">member to be inserted</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Insert(conn As String, mi As MemberInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "INSERT INTO MemberInfo(MName,MTypeId,MPhone,MMoney,MIsDelete) VALUES(@name,@typeId,@phone,@money,0)"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
             New SQLiteParameter("@name", mi.MName),
             New SQLiteParameter("@typeId", mi.MTypeId),
             New SQLiteParameter("@phone", mi.MPhone),
             New SQLiteParameter("@money", mi.MMoney)
        }
        ' inserts member
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' updates member
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mi">member to be updated</param>
    ''' <returns>the number of rows affected</returns>
    Public Function Update(conn As String, mi As MemberInfo) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "UPDATE MemberInfo SET MName=@name,MTypeId=@typeId,MPhone=@phone,MMoney=@money WHERE MId=@id"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
             New SQLiteParameter("@name", mi.MName),
             New SQLiteParameter("@typeId", mi.MTypeId),
             New SQLiteParameter("@phone", mi.MPhone),
             New SQLiteParameter("@money", mi.MMoney),
             New SQLiteParameter("@id", mi.MId)
        }
        ' updates member
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' deletes member according to member id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">member id</param>
    ''' <returns>the number of row affected</returns>
    Public Function Delete(conn As String, ParamArray ids As Integer()) As Integer
        ' constructs SQL statement and parameters
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sb As New StringBuilder
        Dim parameters As New List(Of SQLiteParameter)
        For i As Integer = 0 To ids.Length - 1
            sb.Append($"UPDATE MemberInfo SET MIsDelete=1 WHERE MId=@id{i};")
            parameters.Add(New SQLiteParameter($"@id{i}", ids(i)))
        Next
        ' deletes member
        Return SqliteHelper.ExecuteNonQuery(connStr, sb.ToString(), parameters.ToArray())
    End Function
End Class
