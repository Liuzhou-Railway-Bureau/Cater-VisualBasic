Imports System.Data.SQLite
Imports System.Text
Imports _04.CaterModel

Partial Public Class OrderInfoDal

    ''' <summary>
    ''' inserts order
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="tableId">table id</param>
    ''' <returns>latest order id</returns>
    Public Function Insert(conn As String, tableId As Integer) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "INSERT INTO OrderInfo(ODate,IsPay,TableId) VALUES(DATETIME('NOW','LOCALTIME'),0,@tableId);" +
            "UPDATE TableInfo SET TIsFree=0 WHERE TId=@id;" +
            "SELECT OId FROM OrderInfo ORDER BY OId DESC LIMIT 0,1;"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
            New SQLiteParameter("@tableId", tableId),
            New SQLiteParameter("@id", tableId)
        }
        ' inserts order
        Return CInt(SqliteHelper.ExecuteScalar(connStr, sqlText, parameters))
    End Function

    ''' <summary>
    ''' inserts or updates order detail
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <param name="dishId">dish id</param>
    ''' <returns>the number of rows affected</returns>
    Public Function InsertOrUpdate(conn As String, orderId As Integer, dishId As Integer) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT COUNT(*) FROM OrderDetailInfo WHERE OrderId=@orderId AND DishId=@dishId"
        ' constructs parameters
        Dim parameters As SQLiteParameter() = {
            New SQLiteParameter("@orderId", orderId),
            New SQLiteParameter("@dishId", dishId)
        }
        ' duplicated dish check
        Dim count As Integer = CInt(SqliteHelper.ExecuteScalar(connStr, sqlText, parameters))
        If count > 0 Then
#Region "If yes, count+1"
            sqlText = "UPDATE OrderDetailInfo SET Count=Count+1 WHERE OrderId=@orderId AND DishId=@dishId"
#End Region
        Else
#Region "otherwise inserts new record"
            sqlText = "INSERT INTO OrderDetailInfo(OrderId,DishId,Count) VALUES(@orderId,@dishId,1)"
#End Region
        End If
        ' inserts or updates order
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' updates count by order id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <param name="count">dish count</param>
    ''' <returns>the number of rows affected</returns>
    Public Function UpdateCountByOId(conn As String, orderId As Integer, count As Integer) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "UPDATE OrderDetailInfo SET Count=@count WHERE OId=@id"
        ' constructs SQL parameters
        Dim parameters As SQLiteParameter() = {
            New SQLiteParameter("@count", count),
            New SQLiteParameter("@id", orderId)
        }
        ' updates count
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' updates order
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <param name="money">payable account</param>
    ''' <returns>the number of rows affected</returns>
    Public Function UpdateOrderMoney(conn As String, orderId As Integer, money As Decimal) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "UPDATE OrderInfo SET OMoney=@money WHERE OId=@id"
        ' constructs SQL parameters
        Dim parameters As SQLiteParameter() = {
            New SQLiteParameter("@money", money),
            New SQLiteParameter("@id", orderId)
        }
        ' updates order
        Return SqliteHelper.ExecuteNonQuery(connStr, sqlText, parameters)
    End Function

    ''' <summary>
    ''' updates multiple tables
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="isUseBalance">whether to use member balance</param>
    ''' <param name="payMoney">money for payment</param>
    ''' <param name="memberId">member id</param>
    ''' <param name="orderId">order id</param>
    ''' <param name="discount">member discount</param>
    ''' <returns>the number of rows affected</returns>
    Public Function UpdateTables(conn As String, isUseBalance As Boolean, payMoney As Decimal, memberId As Integer, orderId As Integer, discount As Decimal) As Integer
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sb As New StringBuilder
        Dim parameters As New List(Of SQLiteParameter)
#Region "pays as member"
        If isUseBalance Then
#Region "uses member balance"

#Region "deducts money"
            sb.Append("UPDATE MemberInfo SET MMoney=MMoney-@pay WHERE MId=@memberId;")
            parameters.Add(New SQLiteParameter("@pay", payMoney))
            parameters.Add(New SQLiteParameter("@memberId", memberId))
#End Region

#Region "updates order"
            sb.Append("UPDATE OrderInfo SET IsPay=1,MemberId=@memberId,Discount=@discount WHERE OId=@orderId;")
            parameters.Add(New SQLiteParameter("@discount", discount))
            parameters.Add(New SQLiteParameter("@orderId", orderId))
#End Region

#Region "updates table"
            sb.Append("UPDATE TableInfo SET TIsFree=1 WHERE TId=(SELECT TableId FROM OrderInfo WHERE OId=@orderId);")
#End Region

#End Region
        Else
#Region "doesn't use member balance"

#Region "updates order"
            sb.Append("UPDATE OrderInfo SET IsPay=1,MemberId=@memberId WHERE OId=@orderId;")
            parameters.Add(New SQLiteParameter("@memberId", memberId))
            parameters.Add(New SQLiteParameter("@orderId", orderId))
#End Region

#Region "updates table"
            sb.Append("UPDATE TableInfo SET TIsFree=1 WHERE TId=(SELECT TableId FROM OrderInfo WHERE OId=@orderId);")
#End Region

#End Region
        End If
#End Region
        Return SqliteHelper.ExecuteTransaction(connStr, sb.ToString(), parameters.ToArray())
    End Function

    ''' <summary>
    ''' updates multiple tables
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <returns>the number of rows affected</returns>
    Public Function UpdateTables(conn As String, orderId As Integer) As Integer
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sb As New StringBuilder
        Dim parameters As New List(Of SQLiteParameter)
#Region "pays as not member"

#Region "updates order"
        sb.Append("UPDATE OrderInfo SET IsPay=1 WHERE OId=@orderId;")
        parameters.Add(New SQLiteParameter("@orderId", orderId))
#End Region

#Region "updates table"
        sb.Append("UPDATE TableInfo SET TIsFree=1 WHERE TId=(SELECT TableId FROM OrderInfo WHERE OId=@orderId);")
#End Region

#End Region
        Return SqliteHelper.ExecuteNonQuery(connStr, sb.ToString(), parameters.ToArray())
    End Function

    ''' <summary>
    ''' deletes detail according to detail id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">order detail id</param>
    ''' <returns>the number of rows affected</returns>
    Public Function DeleteDetailById(conn As String, ParamArray ids As Integer()) As Integer
        ' constructs SQL statement and parameters
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sb As New StringBuilder
        Dim parameters As New List(Of SQLiteParameter)
        For i As Integer = 0 To ids.Length - 1
            sb.Append($"DELETE FROM OrderDetailInfo WHERE OId=@id{i};")
            parameters.Add(New SQLiteParameter($"@id{i}", ids(i)))
        Next
        ' deletes detail
        Return SqliteHelper.ExecuteNonQuery(connStr, sb.ToString(), parameters.ToArray())
    End Function

    ''' <summary>
    ''' gets order detail list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <returns>order detail list</returns>
    Public Function GetDetailList(conn As String, orderId As Integer) As List(Of OrderDetailInfo)
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT odi.*,di.DTitle Title,di.DPrice Price FROM OrderDetailInfo odi JOIN DishInfo di ON odi.DishId=di.DId WHERE di.DIsDelete=0 AND odi.OrderId=@orderId"
        ' constructs SQL parameter
        Dim parameter As New SQLiteParameter("@orderId", orderId)
        ' reads data
        Dim reader As SQLiteDataReader = Nothing
        Dim list As New List(Of OrderDetailInfo)
        Try
            reader = SqliteHelper.ExecuteReader(connStr, sqlText, parameter)
            Do While reader.Read()
                list.Add(New OrderDetailInfo() With {
                    .OId = CInt(reader("OId")),
                    .OrderId = CInt(reader("OrderId")),
                    .DishId = CInt(reader("DishId")),
                    .Count = CInt(reader("Count")),
                    .DTitle = CStr(reader("Title")),
                    .DPrice = CStr(reader("Price"))
                })
            Loop
        Catch

        Finally
            If reader IsNot Nothing Then reader.Close()
        End Try
        Return list
    End Function

    ''' <summary>
    ''' gets order id by table id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="tableId">table id</param>
    ''' <returns>order id</returns>
    Public Function GetOrderIdByTableId(conn As String, tableId As Integer) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT OId FROM OrderInfo WHERE TableId=@tableId AND IsPay=0"
        ' constructs SQL parameter
        Dim parameter As New SQLiteParameter("@tableId", tableId)
        ' returns order id
        Return CInt(SqliteHelper.ExecuteScalar(connStr, sqlText, parameter))
    End Function

    ''' <summary>
    ''' gets table id by order id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <returns>table id</returns>
    Public Function GetTableIdByOrderId(conn As String, orderId As Integer) As Integer
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT TableId FROM OrderInfo WHERE OId=@orderId AND IsPay=0"
        ' constructs SQL parameter
        Dim parameter As New SQLiteParameter("@orderId", orderId)
        ' returns table id
        Return CInt(SqliteHelper.ExecuteScalar(connStr, sqlText, parameter))
    End Function

    ''' <summary>
    ''' gets total price by order id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <returns>total price</returns>
    Public Function GetTotalPriceByOrderId(conn As String, orderId As Integer) As Decimal
        ' constructs SQL statement
        Dim connStr As String = SqliteHelper.GetConnectionString(conn)
        Dim sqlText As String = "SELECT SUM(di.DPrice*odi.Count) FROM OrderDetailInfo odi JOIN DishInfo di ON odi.DishId=di.DId WHERE odi.OrderId=@orderId"
        ' constructs SQL parameter
        Dim parameter As New SQLiteParameter("@orderId", orderId)
        ' returns total price
        Dim obj As Object = SqliteHelper.ExecuteScalar(connStr, sqlText, parameter)
        Return If(obj Is DBNull.Value, 0, CDec(obj))
    End Function
End Class
