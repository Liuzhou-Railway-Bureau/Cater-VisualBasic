Imports System.Security.Policy
Imports _03.CaterDAL
Imports _04.CaterModel

Public Class OrderInfoBll

    Private oiDal As New OrderInfoDal ' creates database access layer object

    ''' <summary>
    ''' places order
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="tableId">table id</param>
    ''' <returns>order id</returns>
    Public Function PlaceOrder(conn As String, tableId As Integer) As Integer
        ' calls method to complete insert
        Return oiDal.Insert(conn, tableId)
    End Function

    ''' <summary>
    ''' orders dish
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <param name="dishId">dish id</param>
    ''' <returns>whether successfully ordered</returns>
    Public Function OrderDish(conn As String, orderId As Integer, dishId As Integer) As Boolean
        ' calls method to complete insert
        Return oiDal.InsertOrUpdate(conn, orderId, dishId) > 0
    End Function

    ''' <summary>
    ''' gets order detail list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <returns>order detail list</returns>
    Public Function GetDetailList(conn As String, orderId As Integer) As List(Of OrderDetailInfo)
        ' calls method to query order detail list
        Return oiDal.GetDetailList(conn, orderId)
    End Function

    ''' <summary>
    ''' gets order id by table id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="tableId">table id</param>
    ''' <returns>order id</returns>
    Public Function GetOrderId(conn As String, tableId As Integer) As Integer
        ' calls method to query order id
        Return oiDal.GetOrderIdByTableId(conn, tableId)
    End Function

    ''' <summary>
    ''' gets table id by order id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <returns>table id</returns>
    Public Function GetTableId(conn As String, orderId As Integer) As Integer
        ' calls method to query table id
        Return oiDal.GetTableIdByOrderId(conn, orderId)
    End Function

    ''' <summary>
    ''' sets count
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <param name="count">dish count</param>
    ''' <returns>whether successfully set</returns>
    Public Function SetCount(conn As String, orderId As Integer, count As Integer) As Boolean
        ' calls method to complete update
        Return oiDal.UpdateCountByOId(conn, orderId, count) > 0
    End Function

    ''' <summary>
    ''' gets total price
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <returns>total price</returns>
    Public Function GetTotalPrice(conn As String, orderId As Integer) As Decimal
        ' calls method to query total price
        Return oiDal.GetTotalPriceByOrderId(conn, orderId)
    End Function

    ''' <summary>
    ''' places order
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <param name="money">payable account</param>
    ''' <returns>whether successfully placed</returns>
    Public Function PlaceOrder(conn As String, orderId As Integer, money As Decimal) As Boolean
        ' calls method to complete update
        Return oiDal.UpdateOrderMoney(conn, orderId, money) > 0
    End Function

    ''' <summary>
    ''' removes detail according to detail id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">order detail id</param>
    ''' <returns>whether successfully removed</returns>
    Public Function RemoveDetail(conn As String, ParamArray ids As Integer()) As Boolean
        ' calls method to complete delete
        Return oiDal.DeleteDetailById(conn, ids) > 0
    End Function

    ''' <summary>
    ''' pays for bill as member
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="isUseBalance">whether to use member balance</param>
    ''' <param name="payMoney">money for payment</param>
    ''' <param name="memberId">member id</param>
    ''' <param name="orderId">order id</param>
    ''' <param name="discount">member discount</param>
    ''' <returns>whether successfully paid</returns>
    Public Function PayForBill(conn As String, isUseBalance As Boolean, payMoney As Decimal, memberId As Integer, orderId As Integer, discount As Decimal) As Boolean
        ' calls method to complete updates
        Return oiDal.UpdateTables(conn, isUseBalance, payMoney, memberId, orderId, discount) > 0
    End Function

    ''' <summary>
    ''' pays for bill as not member
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="orderId">order id</param>
    ''' <returns>whether successfully paid</returns>
    Public Function PayForBill(conn As String, orderId As Integer) As Boolean
        ' calls method to complete updates
        Return oiDal.UpdateTables(conn, orderId) > 0
    End Function
End Class
