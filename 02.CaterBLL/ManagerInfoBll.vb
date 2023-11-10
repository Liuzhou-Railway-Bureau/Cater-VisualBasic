Imports _03.CaterDAL
Imports _04.CaterModel
Imports _05.CaterCommon

Public Class ManagerInfoBll


    Private miDal As New ManagerInfoDal ' creates database access layer object

    ''' <summary>
    ''' gets user list
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <returns>user list</returns>
    Public Function GetList(conn As String) As List(Of ManagerInfo)
        ' calls method to query user list
        Return miDal.GetList(conn)
    End Function

    ''' <summary>
    ''' adds user
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mi">user to be added</param>
    ''' <returns>whether successfully added</returns>
    Public Function Add(conn As String, mi As ManagerInfo) As Boolean
        ' calls method to complete insert
        Return miDal.Insert(conn, mi) > 0
    End Function

    ''' <summary>
    ''' edits user
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="mi">user to be edited</param>
    ''' <returns>whether successfully edited</returns>
    Public Function Edit(conn As String, mi As ManagerInfo) As Boolean
        ' calls method to complete update
        Return miDal.Update(conn, mi) > 0
    End Function

    ''' <summary>
    ''' removes user according to user id
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="ids">user id</param>
    ''' <returns>whether successfully removed</returns>
    Public Function Remove(conn As String, ParamArray ids As Integer()) As Boolean
        ' calls method to complete delete
        Return miDal.Delete(conn, ids) > 0
    End Function

    ''' <summary>
    ''' logs in system
    ''' </summary>
    ''' <param name="conn">connection name</param>
    ''' <param name="username">username</param>
    ''' <param name="password">password</param>
    ''' <param name="type">employee type</param>
    ''' <returns>login state</returns>
    Public Function Login(conn As String, username As String, password As String, ByRef Optional type As Integer = -1) As LoginState
        ' calls method to query user by username
        Dim mi As ManagerInfo = miDal.GetUserByName(conn, username)
        ' judges login state
        Dim state As LoginState
        If mi Is Nothing Then
            state = LoginState.NameError
        Else
            If mi.MPwd.Equals(Md5Helper.Encrypt(password)) Then
                state = LoginState.OK
                type = mi.MType
            Else
                state = LoginState.PasswordError
            End If
        End If
        Return state
    End Function
End Class
