Imports _02.CaterBLL
Imports _04.CaterModel

Partial Public Class FormMemberTypeInfo

    Private mtiBll As New MemberTypeInfoBll ' creates business logic layer object
    Private Shared _form As FormMemberTypeInfo = Nothing ' singleton
    Private result As DialogResult = DialogResult.Cancel

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' form singleton
    ''' </summary>
    ''' <returns>singleton form</returns>
    Public Shared Function Create() As FormMemberTypeInfo
        If _form Is Nothing Then _form = New FormMemberTypeInfo
        Return _form
    End Function

    ''' <summary>
    ''' resets singleton _form
    ''' </summary>
    ''' <param name="sender">FormMemberTypeInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormMemberTypeInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' When form is being closed, Dispose() is called to release form by Close()
        _form = Nothing
        Me.DialogResult = result
    End Sub

    ''' <summary>
    ''' loads undeleted member type list
    ''' </summary>
    ''' <param name="sender">FormMemberTypeInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormMemberTypeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    ''' <summary>
    ''' loads undeleted member type list
    ''' </summary>
    Private Sub LoadList()
        ' forbids DgvList to auto generate columns
        DgvList.AutoGenerateColumns = False
        ' calls method and binds data
        DgvList.DataSource = mtiBll.GetList("Cater")
    End Sub

    ''' <summary>
    ''' adds member type
    ''' </summary>
    ''' <param name="sender">BtnSave</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
#Region "validation"
        If String.IsNullOrEmpty(TxtTitle.Text) Then
            MessageBox.Show("请输入标题")
            TxtTitle.Focus()
            Return
        End If
        If String.IsNullOrEmpty(TxtDiscount.Text) Then
            MessageBox.Show("请输入折扣")
            TxtDiscount.Focus()
            Return
        End If
#End Region

        ' collects member type info
        Dim mti As New MemberTypeInfo With {
            .MTitle = TxtTitle.Text,
            .MDiscount = CDec(TxtDiscount.Text),
            .MIsDelete = False
        }

        If TxtId.Text.Equals("添加时无编号") Then
#Region "add"
            ' calls method to add member type
            If mtiBll.Add("Cater", mti) Then
                ' if succeeds, reloads member type list
                LoadList()
            Else
                ' otherwise pops up message
                MessageBox.Show("添加失败，请稍后重试！")
            End If
#End Region
        Else
#Region "edit"
            mti.MId = CInt(TxtId.Text)

            ' calls method to edit member type
            If mtiBll.Edit("Cater", mti) Then
                ' if succeeds, reloads member type list
                LoadList()
            Else
                ' otherwise pops up message
                MessageBox.Show("修改失败，请稍后重试！")
            End If
#End Region
        End If

        result = DialogResult.OK

        ' restores text boxes
        Restore()
    End Sub

    ''' <summary>
    ''' resets text boxes
    ''' </summary>
    Private Sub Restore()
        TxtId.Text = "添加时无编号"
        TxtTitle.Clear()
        TxtDiscount.Clear()
        BtnSave.Text = "添加"
    End Sub

    ''' <summary>
    ''' cancels currently editing member type
    ''' </summary>
    ''' <param name="sender">BtnCancel</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Restore()
    End Sub

    ''' <summary>
    ''' edits member type
    ''' </summary>
    ''' <param name="sender">DgvList</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvList.CellDoubleClick
        ' According to what was double clicked, finds row and columns to assign to text boxes
        Dim row As DataGridViewRow = DgvList.Rows(e.RowIndex)
        TxtId.Text = row.Cells(0).Value.ToString()
        TxtTitle.Text = row.Cells(1).Value.ToString()
        TxtDiscount.Text = row.Cells(2).Value.ToString()
        BtnSave.Text = "修改"
    End Sub

    ''' <summary>
    ''' removes member type according to member type id
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
                ' gets member type id
                Dim ids As Integer() = New Integer(rows.Count - 1) {}
                For i As Integer = 0 To rows.Count - 1
                    ids(i) = CInt(rows(i).Cells(0).Value)
                Next

                ' removes member type according to member type id
                If mtiBll.Remove("Cater", ids) Then
                    LoadList()
                Else
                    MessageBox.Show("删除失败，请稍后重试！")
                End If
            End If
        Else
            MessageBox.Show("请先选择要删除的行！")
        End If

        result = DialogResult.OK
    End Sub
End Class