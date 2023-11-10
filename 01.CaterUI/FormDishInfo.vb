Imports _02.CaterBLL
Imports _04.CaterModel
Imports _05.CaterCommon

Partial Public Class FormDishInfo

    Private diBll As New DishInfoBll ' creates business logic layer object
    Private Shared _form As FormDishInfo = Nothing ' singleton

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' form singleton
    ''' </summary>
    ''' <returns>singleton form</returns>
    Public Shared Function Create() As FormDishInfo
        If _form Is Nothing Then _form = New FormDishInfo
        Return _form
    End Function

    ''' <summary>
    ''' resets singleton _form
    ''' </summary>
    ''' <param name="sender">FormDishInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormDishInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' When form is being closed, Dispose() is called to release form by Close()
        _form = Nothing
    End Sub

    ''' <summary>
    ''' loads undeleted dish list and dish type list
    ''' </summary>
    ''' <param name="sender">FormDishInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormDishInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
        LoadTypeList()
    End Sub

    ''' <summary>
    ''' loads undeleted dish list
    ''' </summary>
    Private Sub LoadList()
        ' creates a dictionary to save condition
        Dim dic As New Dictionary(Of String, String)
        If Not String.IsNullOrEmpty(TxtTitleSearch.Text) Then dic.Add("DTitle", TxtTitleSearch.Text)
        If DdlTypeSearch.SelectedIndex > 0 Then dic.Add("DTypeId", DdlTypeSearch.SelectedValue.ToString())

        ' forbids DgvList to auto generate columns
        DgvList.AutoGenerateColumns = False
        ' calls method and binds data
        DgvList.DataSource = diBll.GetList("Cater", dic)
    End Sub

    ''' <summary>
    ''' loads dish type list
    ''' </summary>
    Private Sub LoadTypeList()
        ' gets dish type list
        Dim dtiBll As New DishTypeInfoBll

#Region "DdlTypeSearch"
        Dim listSearch As List(Of DishTypeInfo) = dtiBll.GetList("Cater")
        listSearch.Insert(0, New DishTypeInfo() With {
            .DId = 0,
            .DTitle = "全部",
            .DIsDelete = False
        })
        ' binds data
        DdlTypeSearch.DataSource = listSearch
        ' sets display dish
        DdlTypeSearch.DisplayMember = "DTitle"
        ' sets actually-used value dish
        DdlTypeSearch.ValueMember = "DId"
        ' <select><option value="id">title</option></select>
        ' unselects all by default
        DdlTypeSearch.SelectedIndex = -1
#End Region

#Region "DdlTypeAdd"
        Dim listAdd As List(Of DishTypeInfo) = dtiBll.GetList("Cater")
        ' binds data
        DdlTypeAdd.DataSource = listAdd
        ' sets display dish
        DdlTypeAdd.DisplayMember = "DTitle"
        ' sets actually-used value dish
        DdlTypeAdd.ValueMember = "DId"
        ' <select><option value="id">title</option></select>
        ' unselects all by default
        DdlTypeAdd.SelectedIndex = -1
#End Region
    End Sub

    ''' <summary>
    ''' finds by title
    ''' </summary>
    ''' <param name="sender">TxtTitleSearch</param>
    ''' <param name="e">data for executing event</param>
    Private Sub TxtTitleSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtTitleSearch.TextChanged
        LoadList()
    End Sub

    ''' <summary>
    ''' finds by type
    ''' </summary>
    ''' <param name="sender">DdlTypeSearch</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DdlTypeSearch_TextChanged(sender As Object, e As EventArgs) Handles DdlTypeSearch.TextChanged
        LoadList()
    End Sub

    ''' <summary>
    ''' shows all dishes
    ''' </summary>
    ''' <param name="sender">BtnSearchAll</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnSearchAll_Click(sender As Object, e As EventArgs) Handles BtnSearchAll.Click
        TxtTitleSearch.Clear()
        DdlTypeSearch.SelectedIndex = -1
        LoadList()
    End Sub

    ''' <summary>
    ''' adds dish
    ''' </summary>
    ''' <param name="sender">BtnSave</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
#Region "validation"
        If String.IsNullOrEmpty(TxtTitleAdd.Text) Then
            MessageBox.Show("请输入名称")
            TxtTitleAdd.Focus()
            Return
        End If
        If DdlTypeAdd.SelectedIndex < 0 Then
            MessageBox.Show("请选择分类")
            DdlTypeAdd.Focus()
            Return
        End If
        If String.IsNullOrEmpty(TxtPrice.Text) Then
            MessageBox.Show("请输入价格")
            TxtPrice.Focus()
            Return
        End If
        If String.IsNullOrEmpty(TxtChar.Text) Then
            MessageBox.Show("请输入拼音")
            TxtChar.Focus()
            Return
        End If
#End Region

        ' collects dish info
        Dim di As New DishInfo With {
            .DTitle = TxtTitleAdd.Text,
            .DTypeId = CInt(DdlTypeAdd.SelectedValue),
            .DPrice = CDec(TxtPrice.Text),
            .DChar = TxtChar.Text,
            .DIsDelete = False
        }

        If TxtId.Text.Equals("添加时无编号") Then
#Region "add"
            ' calls method to add dish
            If diBll.Add("Cater", di) Then
                ' if succeeds, reloads dish list
                LoadList()
            Else
                ' otherwise pops up message
                MessageBox.Show("添加失败，请稍后重试！")
            End If
#End Region
        Else
#Region "edit"
            di.DId = CInt(TxtId.Text)

            ' calls method to edit dish
            If diBll.Edit("Cater", di) Then
                ' if succeeds, reloads dish list
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
    ''' gets each char's first Pinyin letter
    ''' </summary>
    ''' <param name="sender">TxtTitleAdd</param>
    ''' <param name="e">data for executing event</param>
    Private Sub TxtTitleAdd_Leave(sender As Object, e As EventArgs) Handles TxtTitleAdd.Leave
        TxtChar.Text = PinyinHelper.GetPinyin(TxtTitleAdd.Text)
    End Sub

    ''' <summary>
    ''' resets text boxes
    ''' </summary>
    Private Sub Restore()
        TxtId.Text = "添加时无编号"
        TxtTitleAdd.Clear()
        DdlTypeAdd.SelectedIndex = -1
        TxtPrice.Clear()
        TxtChar.Clear()
        BtnSave.Text = "添加"
    End Sub

    ''' <summary>
    ''' cancels currently editing dish
    ''' </summary>
    ''' <param name="sender">BtnCancel</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Restore()
    End Sub

    ''' <summary>
    ''' edits dish
    ''' </summary>
    ''' <param name="sender">DgvList</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvList.CellDoubleClick
        ' According to what was double clicked, finds row and columns to assign to text boxes
        Dim row As DataGridViewRow = DgvList.Rows(e.RowIndex)
        TxtId.Text = row.Cells(0).Value.ToString()
        TxtTitleAdd.Text = row.Cells(1).Value.ToString()
        DdlTypeAdd.Text = row.Cells(2).Value.ToString()
        TxtPrice.Text = row.Cells(3).Value.ToString()
        TxtChar.Text = row.Cells(4).Value.ToString()
        BtnSave.Text = "修改"
    End Sub

    ''' <summary>
    ''' removes dish according to dish id
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
                ' gets dish id
                Dim ids As Integer() = New Integer(rows.Count - 1) {}
                For i As Integer = 0 To rows.Count - 1
                    ids(i) = CInt(rows(i).Cells(0).Value)
                Next

                ' removes dish according to dish id
                If diBll.Remove("Cater", ids) Then
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
    ''' manages dish type
    ''' </summary>
    ''' <param name="sender">BtnAddType</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnAddType_Click(sender As Object, e As EventArgs) Handles BtnAddType.Click
        Dim fDishType As FormDishTypeInfo = FormDishTypeInfo.Create()
        Dim result As DialogResult = fDishType.ShowDialog()
        If result = DialogResult.OK Then
            LoadTypeList()
            LoadList()
        End If
    End Sub
End Class