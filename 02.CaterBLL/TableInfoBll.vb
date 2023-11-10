Imports _03.CaterDAL
Imports _04.CaterModel

Public Class TableInfoBll

    Private tiDal As New TableInfoDal ' creates database access layer object

    ''' <summary>
    ''' gets undeleted table list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="dic">find condition</param>
    ''' <returns>table list</returns>
    Public Function GetList(conn As String, dic As Dictionary(Of String, String)) As List(Of TableInfo)
        ' calls method to query table list
        Return tiDal.GetList(conn, dic)
    End Function

    ''' <summary>
    ''' adds table
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ti">table to be added</param>
    ''' <returns>whether successfully added</returns>
    Public Function Add(conn As String, ti As TableInfo) As Boolean
        ' calls method to complete insert
        Return tiDal.Insert(conn, ti) > 0
    End Function

    ''' <summary>
    ''' edits table
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ti">table to be edited</param>
    ''' <returns>whether successfully edited</returns>
    Public Function Edit(conn As String, ti As TableInfo) As Boolean
        ' calls method to complete update
        Return tiDal.Update(conn, ti) > 0
    End Function

    ''' <summary>
    ''' removes table according to table id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">table id</param>
    ''' <returns>whether successfully removed</returns>
    Public Function Remove(conn As String, ParamArray ids As Integer()) As Boolean
        ' calls method to complete delete
        Return tiDal.Delete(conn, ids) > 0
    End Function
End Class
