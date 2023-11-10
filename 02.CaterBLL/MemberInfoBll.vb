Imports _03.CaterDAL
Imports _04.CaterModel

Public Class MemberInfoBll

    Private miDal As New MemberInfoDal ' creates database access layer object

    ''' <summary>
    ''' gets undeleted member list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="dic">find condition</param>
    ''' <returns>member list</returns>
    Public Function GetList(conn As String, dic As Dictionary(Of String, String)) As List(Of MemberInfo)
        ' calls method to query member list
        Return miDal.GetList(conn, dic)
    End Function

    ''' <summary>
    ''' adds member
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mi">member to be added</param>
    ''' <returns>whether successfully added</returns>
    Public Function Add(conn As String, mi As MemberInfo) As Boolean
        ' calls method to complete insert
        Return miDal.Insert(conn, mi) > 0
    End Function

    ''' <summary>
    ''' edits member
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mi">member to be edited</param>
    ''' <returns>whether successfully edited</returns>
    Public Function Edit(conn As String, mi As MemberInfo) As Boolean
        ' calls method to complete update
        Return miDal.Update(conn, mi) > 0
    End Function

    ''' <summary>
    ''' removes member according to member id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">member id</param>
    ''' <returns>whether successfully removed</returns>
    Public Function Remove(conn As String, ParamArray ids As Integer()) As Boolean
        ' calls method to complete delete
        Return miDal.Delete(conn, ids) > 0
    End Function
End Class
