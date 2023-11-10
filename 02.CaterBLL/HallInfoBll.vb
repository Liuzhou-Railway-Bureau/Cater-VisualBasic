Imports _03.CaterDAL
Imports _04.CaterModel

Public Class HallInfoBll


    Private hiDal As New HallInfoDal ' creates database access layer object

    ''' <summary>
    ''' gets undeleted hall list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <returns>hall list</returns>
    Public Function GetList(conn As String) As List(Of HallInfo)
        ' calls method to query hall list
        Return hiDal.GetList(conn)
    End Function

    ''' <summary>
    ''' adds hall
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="hi">hall to be added</param>
    ''' <returns>whether successfully added</returns>
    Public Function Add(conn As String, hi As HallInfo) As Boolean
        ' calls method to complete insert
        Return hiDal.Insert(conn, hi) > 0
    End Function

    ''' <summary>
    ''' edits hall
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="hi">hall to be edited</param>
    ''' <returns>whether successfully edited</returns>
    Public Function Edit(conn As String, hi As HallInfo) As Boolean
        ' calls method to complete update
        Return hiDal.Update(conn, hi) > 0
    End Function

    ''' <summary>
    ''' removes hall according to hall id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">hall id</param>
    ''' <returns>whether successfully removed</returns>
    Public Function Remove(conn As String, ParamArray ids As Integer()) As Boolean
        ' calls method to complete delete
        Return hiDal.Delete(conn, ids) > 0
    End Function
End Class
