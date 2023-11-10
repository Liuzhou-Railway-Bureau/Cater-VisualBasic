Imports _03.CaterDAL
Imports _04.CaterModel

Public Class DishInfoBll

    Private diDal As New DishInfoDal ' creates database access layer object

    ''' <summary>
    ''' gets undeleted dish list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="dic">find condition</param>
    ''' <returns>dish list</returns>
    Public Function GetList(conn As String, dic As Dictionary(Of String, String)) As List(Of DishInfo)
        ' calls method to query dish list
        Return diDal.GetList(conn, dic)
    End Function

    ''' <summary>
    ''' adds dish
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="di">dish to be added</param>
    ''' <returns>whether successfully added</returns>
    Public Function Add(conn As String, di As DishInfo) As Boolean
        ' calls method to complete insert
        Return diDal.Insert(conn, di) > 0
    End Function

    ''' <summary>
    ''' edits dish
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="di">dish to be edited</param>
    ''' <returns>whether successfully edited</returns>
    Public Function Edit(conn As String, di As DishInfo) As Boolean
        ' calls method to complete update
        Return diDal.Update(conn, di) > 0
    End Function

    ''' <summary>
    ''' removes dish according to dish id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">dish id</param>
    ''' <returns>whether successfully removed</returns>
    Public Function Remove(conn As String, ParamArray ids As Integer()) As Boolean
        ' calls method to complete delete
        Return diDal.Delete(conn, ids) > 0
    End Function
End Class
