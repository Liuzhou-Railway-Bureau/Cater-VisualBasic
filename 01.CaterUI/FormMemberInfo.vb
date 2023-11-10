Imports _02.CaterBLL
Imports _04.CaterModel

Partial Public Class FormMemberInfo

    Private miBll As New MemberInfoBll ' creates business logic layer object
    Private Shared _form As FormMemberInfo = Nothing ' singleton

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' form singleton
    ''' </summary>
    ''' <returns>singleton form</returns>
    Public Shared Function Create() As FormMemberInfo
        If _form Is Nothing Then _form = New FormMemberInfo
        Return _form
    End Function

    ''' <summary>
    ''' resets singleton _form
    ''' </summary>
    ''' <param name="sender">FormMemberInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormMemberInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' When form is being closed, Dispose() is called to release form by Close()
        _form = Nothing
    End Sub

    ''' <summary>
    ''' loads undeleted member list and member type list
    ''' </summary>
    ''' <param name="sender">FormMemberInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormMemberInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
        LoadTypeList()
    End Sub

    ''' <summary>
    ''' loads undeleted member list
    ''' </summary>
    Private Sub LoadList()
        ' creates a dictionary to save condition
        Dim dic As New Dictionary(Of String, String)
        If Not String.IsNullOrEmpty(TxtNameSearch.Text) Then dic.Add("MName", TxtNameSearch.Text)
        If Not String.IsNullOrEmpty(TxtPhoneSearch.Text) Then dic.Add("MPhone", TxtPhoneSearch.Text)

        ' forbids DgvList to auto generate columns
        DgvList.AutoGenerateColumns = False
        ' calls method and binds data
        DgvList.DataSource = miBll.GetList("Cater", dic)
    End Sub

    ''' <summary>
    ''' loads member type list
    ''' </summary>
    Private Sub LoadTypeList()
        ' gets member type list
        Dim mtiBll As New MemberTypeInfoBll
        Dim list As List(Of MemberTypeInfo) = mtiBll.GetList("Cater")
        ' binds data
        DdlType.DataSource = list
        ' sets display member
        DdlType.DisplayMember = "MTitle"
        ' sets actually-used value member
        DdlType.ValueMember = "MId"
        ' <select><option value="id">title</option></select>
        ' unselects all by default
        DdlType.SelectedIndex = -1
    End Sub

    ''' <summary>
    ''' finds by name
    ''' </summary>
    ''' <param name="sender">TxtNameSearch</param>
    ''' <param name="e">data for executing event</param>
    Private Sub TxtNameSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtNameSearch.TextChanged
        LoadList()
    End Sub

    ''' <summary>
    ''' finds by phone
    ''' </summary>
    ''' <param name="sender">TxtPhoneSearch</param>
    ''' <param name="e">data for executing event</param>
    Private Sub TxtPhoneSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtPhoneSearch.TextChanged
        LoadList()
    End Sub

    ''' <summary>
    ''' shows all members
    ''' </summary>
    ''' <param name="sender">BtnSearchAll</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnSearchAll_Click(sender As Object, e As EventArgs) Handles BtnSearchAll.Click
        TxtNameSearch.Clear()
        TxtPhoneSearch.Clear()
        LoadList()
    End Sub

    ''' <summary>
    ''' adds member
    ''' </summary>
    ''' <param name="sender">BtnSave</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
#Region "validation"
        If String.IsNullOrEmpty(TxtNameAdd.Text) Then
            MessageBox.Show("请输入姓名")
            TxtNameAdd.Focus()
            Return
        End If
        If String.IsNullOrEmpty(TxtPhoneAdd.Text) Then
            MessageBox.Show("请输入手机号")
            TxtPhoneAdd.Focus()
            Return
        End If
        If String.IsNullOrEmpty(TxtMoney.Text) Then
            MessageBox.Show("请输入余额")
            TxtMoney.Focus()
            Return
        End If
#End Region

        ' collects member info
        Dim mi As New MemberInfo With {
            .MName = TxtNameAdd.Text,
            .MTypeId = CInt(DdlType.SelectedValue),
            .MPhone = TxtPhoneAdd.Text,
            .MMoney = CDec(TxtMoney.Text),
            .MIsDelete = False
        }

        If TxtId.Text.Equals("添加时无编号") Then
#Region "add"
            ' calls method to add member
            If miBll.Add("Cater", mi) Then
                ' if succeeds, reloads member list
                LoadList()
            Else
                ' otherwise pops up message
                MessageBox.Show("添加失败，请稍后重试！")
            End If
#End Region
        Else
#Region "edit"
            mi.MId = CInt(TxtId.Text)

            ' calls method to edit member
            If miBll.Edit("Cater", mi) Then
                ' if succeeds, reloads member list
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
        TxtNameAdd.Clear()
        DdlType.SelectedIndex = -1
        TxtPhoneAdd.Clear()
        TxtMoney.Clear()
        BtnSave.Text = "添加"
    End Sub

    ''' <summary>
    ''' cancels currently editing member
    ''' </summary>
    ''' <param name="sender">BtnCancel</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Restore()
    End Sub

    ''' <summary>
    ''' edits member
    ''' </summary>
    ''' <param name="sender">DgvList</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvList.CellDoubleClick
        ' According to what was double clicked, finds row and columns to assign to text boxes
        Dim row As DataGridViewRow = DgvList.Rows(e.RowIndex)
        TxtId.Text = row.Cells(0).Value.ToString()
        TxtNameAdd.Text = row.Cells(1).Value.ToString()
        DdlType.Text = row.Cells(2).Value.ToString()
        TxtPhoneAdd.Text = row.Cells(3).Value.ToString()
        TxtMoney.Text = row.Cells(4).Value.ToString()
        BtnSave.Text = "修改"
    End Sub

    ''' <summary>
    ''' removes member according to member id
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
                ' gets member id
                Dim ids As Integer() = New Integer(rows.Count - 1) {}
                For i As Integer = 0 To rows.Count - 1
                    ids(i) = CInt(rows(i).Cells(0).Value)
                Next

                ' removes member according to member id
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
    ''' manages member type
    ''' </summary>
    ''' <param name="sender">BtnAddType</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnAddType_Click(sender As Object, e As EventArgs) Handles BtnAddType.Click
        Dim fMemberType As FormMemberTypeInfo = FormMemberTypeInfo.Create()
        Dim result As DialogResult = fMemberType.ShowDialog()
        If result = DialogResult.OK Then
            LoadTypeList()
            LoadList()
        End If
    End Sub
End Class