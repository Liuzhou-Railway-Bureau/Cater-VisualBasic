Imports _03.CaterDAL
Imports _04.CaterModel

Public Class DishTypeInfoBll


    Private dtiDal As New DishTypeInfoDal ' creates database access layer object

    ''' <summary>
    ''' gets undeleted dish type list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <returns>dish type list</returns>
    Public Function GetList(conn As String) As List(Of DishTypeInfo)
        ' calls method to query dish type list
        Return dtiDal.GetList(conn)
    End Function

    ''' <summary>
    ''' adds dish type
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="dti">dish type to be added</param>
    ''' <returns>whether successfully added</returns>
    Public Function Add(conn As String, dti As DishTypeInfo) As Boolean
        ' calls method to complete insert
        Return dtiDal.Insert(conn, dti) > 0
    End Function

    ''' <summary>
    ''' edits dish type
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="dti">dish type to be edited</param>
    ''' <returns>whether successfully edited</returns>
    Public Function Edit(conn As String, dti As DishTypeInfo) As Boolean
        ' calls method to complete update
        Return dtiDal.Update(conn, dti) > 0
    End Function

    ''' <summary>
    ''' removes dish type according to dish type id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">dish type id</param>
    ''' <returns>whether successfully removed</returns>
    Public Function Remove(conn As String, ParamArray ids As Integer()) As Boolean
        ' calls method to complete delete
        Return dtiDal.Delete(conn, ids) > 0
    End Function
End Class
