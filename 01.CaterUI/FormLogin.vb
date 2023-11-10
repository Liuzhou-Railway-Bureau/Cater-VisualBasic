Imports _02.CaterBLL
Imports _04.CaterModel

Partial Public Class FormLogin

    Private miBll As New ManagerInfoBll 'creates business logic layer object

    ''' <summary>
    ''' closes form
    ''' </summary>
    ''' <param name="sender">BtnClose</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' logs in system
    ''' </summary>
    ''' <param name="sender">BtnLogin</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' collects user info
        Dim username As String = TxtName.Text
        Dim password As String = TxtPassword.Text
        Dim type As Integer

        ' calls method to log in
        Dim state As LoginState = miBll.Login("Cater", username, password, type)

        Select Case state
            Case LoginState.OK
                Dim fMain As New FormMain With {
                    .Tag = type ' passes employee type
                 }
                fMain.Show()
                Me.Hide()
            Case LoginState.PasswordError
                MessageBox.Show("密码错误")
            Case LoginState.NameError
                MessageBox.Show("用户名错误")
        End Select
    End Sub
End Class