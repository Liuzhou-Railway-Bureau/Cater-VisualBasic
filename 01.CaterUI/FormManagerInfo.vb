Imports _02.CaterBLL
Imports _04.CaterModel

Partial Public Class FormManagerInfo

    Private miBll As New ManagerInfoBll ' creates business logic layer object
    Private Shared _form As FormManagerInfo = Nothing ' singleton

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' form singleton
    ''' </summary>
    ''' <returns>singleton form</returns>
    Public Shared Function Create() As FormManagerInfo
        If _form Is Nothing Then _form = New FormManagerInfo
        Return _form
    End Function

    ''' <summary>
    ''' loads user list
    ''' </summary>
    ''' <param name="sender">FormManagerInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormManagerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    ''' <summary>
    ''' loads user list
    ''' </summary>
    Private Sub LoadList()
        ' forbids DgvList to auto generate columns
        DgvList.AutoGenerateColumns = False
        ' calls method and binds data
        DgvList.DataSource = miBll.GetList("Cater")
    End Sub

    ''' <summary>
    ''' adds user
    ''' </summary>
    ''' <param name="sender">BtnSave</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
#Region "validation"
        If String.IsNullOrEmpty(TxtName.Text) Then
            MessageBox.Show("请输入用户名")
            TxtName.Focus()
            Return
        End If
        If String.IsNullOrEmpty(TxtPwd.Text) Then
            MessageBox.Show("请输入密码")
            TxtPwd.Focus()
            Return
        End If
#End Region

        ' collects user info
        Dim mi As New ManagerInfo With {
            .MName = TxtName.Text,
            .MPwd = TxtPwd.Text,
            .MType = If(Rb1.Checked, 1, 0)
        }

        If TxtId.Text.Equals("添加时无编号") Then
#Region "add"
            ' calls method to add user
            If miBll.Add("Cater", mi) Then
                ' if succeeds, reloads user list
                LoadList()
            Else
                ' otherwise pops up message
                MessageBox.Show("添加失败，请稍后重试！")
            End If
#End Region
        Else
#Region "edit"
            mi.MId = CInt(TxtId.Text)

            ' calls method to edit user
            If miBll.Edit("Cater", mi) Then
                ' if succeeds, reloads user list
                LoadList()
            Else
                ' otherwise pops up message
                MessageBox.Show("修改失败，请稍后重试！")
            End If
#End Region
        End If

        ' restores text boxes
        Restore()
    End Sub

    ''' <summary>
    ''' resets text boxes
    ''' </summary>
    Private Sub Restore()
        TxtId.Text = "添加时无编号"
        TxtName.Clear()
        TxtPwd.Clear()
        Rb2.Checked = True
        BtnSave.Text = "添加"
    End Sub

    ''' <summary>
    ''' formats Type
    ''' </summary>
    ''' <param name="sender">DgvList</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DgvList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvList.CellFormatting
        If e.ColumnIndex = 2 Then e.Value = If(Convert.ToInt32(e.Value) = 1, "经理", "店员")
    End Sub

    ''' <summary>
    ''' edits user
    ''' </summary>
    ''' <param name="sender">DgvList</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvList.CellDoubleClick
        ' According to what was double clicked, finds row and columns to assign to text boxes
        Dim row As DataGridViewRow = DgvList.Rows(e.RowIndex)
        TxtId.Text = row.Cells(0).Value.ToString()
        TxtName.Text = row.Cells(1).Value.ToString()
        If row.Cells(2).Value.ToString.Equals("1") Then
            Rb1.Checked = True
            Rb2.Checked = False
        Else
            Rb2.Checked = True
            Rb1.Checked = False
        End If
        TxtPwd.Text = "旧密码"
        BtnSave.Text = "修改"
    End Sub

    ''' <summary>
    ''' cancels currently editing user
    ''' </summary>
    ''' <param name="sender">BtnCancel</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Restore()
    End Sub

    ''' <summary>
    ''' removes user according to user id
    ''' </summary>
    ''' <param name="sender">BtnRemove</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        ' gets selected rows
        Dim rows As DataGridViewSelectedRowCollection = DgvList.SelectedRows

        If rows.Count > 0 Then
            ' asks whether to remove
            Dim result As DialogResult = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.YesNoCancel)

            If result = DialogResult.Yes Then
                ' gets user id
                Dim ids As Integer() = New Integer(rows.Count - 1) {}
                For i As Integer = 0 To rows.Count - 1
                    ids(i) = CInt(rows(i).Cells(0).Value)
                Next

                ' removes user according to user id
                If miBll.Remove("Cater", ids) Then
                    LoadList()
                Else
                    MessageBox.Show("删除失败，请稍后重试！")
                End If
            End If
        Else
            MessageBox.Show("请先选择要删除的行！")
        End If
    End Sub

    ''' <summary>
    ''' resets singleton _form
    ''' </summary>
    ''' <param name="sender">FormManagerInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormManagerInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' When form is being closed, Dispose() is called to release form by Close()
        _form = Nothing
    End Sub
End Class
