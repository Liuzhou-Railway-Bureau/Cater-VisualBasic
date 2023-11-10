Imports _03.CaterDAL
Imports _04.CaterModel

Public Class MemberTypeInfoBll


    Private mtiDal As New MemberTypeInfoDal ' creates database access layer object

    ''' <summary>
    ''' gets undeleted member type list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <returns>member type list</returns>
    Public Function GetList(conn As String) As List(Of MemberTypeInfo)
        ' calls method to query member type list
        Return mtiDal.GetList(conn)
    End Function

    ''' <summary>
    ''' adds member type
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mti">member type to be added</param>
    ''' <returns>whether successfully added</returns>
    Public Function Add(conn As String, mti As MemberTypeInfo) As Boolean
        ' calls method to complete insert
        Return mtiDal.Insert(conn, mti) > 0
    End Function

    ''' <summary>
    ''' edits member type
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mti">member type to be edited</param>
    ''' <returns>whether successfully edited</returns>
    Public Function Edit(conn As String, mti As MemberTypeInfo) As Boolean
        ' calls method to complete update
        Return mtiDal.Update(conn, mti) > 0
    End Function

    ''' <summary>
    ''' removes member type according to member type id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">member type id</param>
    ''' <returns>whether successfully removed</returns>
    Public Function Remove(conn As String, ParamArray ids As Integer()) As Boolean
        ' calls method to complete delete
        Return mtiDal.Delete(conn, ids) > 0
    End Function
End Class
