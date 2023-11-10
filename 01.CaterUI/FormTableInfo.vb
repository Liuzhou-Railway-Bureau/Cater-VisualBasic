Imports _02.CaterBLL
Imports _04.CaterModel

Partial Public Class FormTableInfo

    Private tiBll As New TableInfoBll ' creates business logic layer object
    Private Shared _form As FormTableInfo = Nothing ' singleton
    Public Event TableUpdated As Action

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' form singleton
    ''' </summary>
    ''' <returns>singleton form</returns>
    Public Shared Function Create() As FormTableInfo
        If _form Is Nothing Then _form = New FormTableInfo
        Return _form
    End Function

    ''' <summary>
    ''' resets singleton _form
    ''' </summary>
    ''' <param name="sender">FormTableInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormTableInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' When form is being closed, Dispose() is called to release form by Close()
        _form = Nothing
    End Sub

    ''' <summary>
    ''' loads undeleted table list and hall list
    ''' </summary>
    ''' <param name="sender">FormTableInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormTableInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
        LoadSearchList()
    End Sub

    ''' <summary>
    ''' loads undeleted table list
    ''' </summary>
    Private Sub LoadList()
        ' creates a dictionary to save condition
        Dim dic As New Dictionary(Of String, String)
        If DdlHallSearch.SelectedIndex > 0 Then dic.Add("THallId", DdlHallSearch.SelectedValue.ToString())
        If DdlFreeSearch.SelectedIndex > 0 Then dic.Add("TIsFree", DdlFreeSearch.SelectedValue.ToString())

        ' forbids DgvList to auto generate columns
        DgvList.AutoGenerateColumns = False
        ' calls method and binds data
        DgvList.DataSource = tiBll.GetList("Cater", dic)
    End Sub

    ''' <summary>
    ''' loads search list
    ''' </summary>
    Private Sub LoadSearchList()
        ' gets hall list
        Dim hiBll As New HallInfoBll

#Region "DdlHallSearch"
        Dim listHallSearch As List(Of HallInfo) = hiBll.GetList("Cater")
        listHallSearch.Insert(0, New HallInfo() With {
            .HId = 0,
            .HTitle = "全部",
            .HIsDelete = False
        })
        ' binds data
        DdlHallSearch.DataSource = listHallSearch
        ' sets display hall
        DdlHallSearch.DisplayMember = "HTitle"
        ' sets actually-used value hall
        DdlHallSearch.ValueMember = "HId"
        ' <select><option value="id">title</option></select>
        ' unselects all by default
        DdlHallSearch.SelectedIndex = -1
#End Region

#Region "DdlFreeSearch"
        Dim listFreeSearch As New List(Of DdlFreeSearchModel) From {
            New DdlFreeSearchModel("-1", "全部"),
            New DdlFreeSearchModel("1", "空闲"),
            New DdlFreeSearchModel("0", "使用中")
        }
        ' binds data
        DdlFreeSearch.DataSource = listFreeSearch
        ' sets display table
        DdlFreeSearch.DisplayMember = "Title"
        ' sets actually-used value table
        DdlFreeSearch.ValueMember = "Id"
        ' <select><option value="id">title</option></select>
        ' unselects all by default
        DdlFreeSearch.SelectedIndex = -1
#End Region

#Region "DdlHallAdd"
        Dim listHallAdd As List(Of HallInfo) = hiBll.GetList("Cater")
        ' binds data
        DdlHallAdd.DataSource = listHallAdd
        ' sets display hall
        DdlHallAdd.DisplayMember = "HTitle"
        ' sets actually-used value hall
        DdlHallAdd.ValueMember = "HId"
        ' <select><option value="id">title</option></select>
        ' unselects all by default
        DdlHallAdd.SelectedIndex = -1
#End Region
    End Sub

    ''' <summary>
    ''' finds by hall
    ''' </summary>
    ''' <param name="sender">DdlHallSearch</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DdlHallSearch_TextChanged(sender As Object, e As EventArgs) Handles DdlHallSearch.TextChanged
        LoadList()
    End Sub

    ''' <summary>
    ''' finds by isFree
    ''' </summary>
    ''' <param name="sender">DdlFreeSearch</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DdlFreeSearch_TextChanged(sender As Object, e As EventArgs) Handles DdlFreeSearch.TextChanged
        LoadList()
    End Sub

    ''' <summary>
    ''' shows all tablees
    ''' </summary>
    ''' <param name="sender">BtnSearchAll</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnSearchAll_Click(sender As Object, e As EventArgs) Handles BtnSearchAll.Click
        DdlHallSearch.SelectedIndex = -1
        DdlFreeSearch.SelectedIndex = -1
        LoadList()
    End Sub

    ''' <summary>
    ''' adds table
    ''' </summary>
    ''' <param name="sender">BtnSave</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
#Region "validation"
        If String.IsNullOrEmpty(TxtTitle.Text) Then
            MessageBox.Show("请输入名称")
            TxtTitle.Focus()
            Return
        End If
        If DdlHallAdd.SelectedIndex < 0 Then
            MessageBox.Show("请选择厅包")
            DdlHallAdd.Focus()
            Return
        End If
#End Region

        ' collects table info
        Dim ti As New TableInfo With {
             .TTitle = TxtTitle.Text,
             .THallId = CInt(DdlHallAdd.SelectedValue),
             .TIsFree = If(RbFree.Checked, True, False),
             .TIsDelete = False
        }

        If TxtId.Text.Equals("添加时无编号") Then
#Region "add"
            ' calls method to add table
            If tiBll.Add("Cater", ti) Then
                ' if succeeds, reloads table list
                LoadList()
                RaiseEvent TableUpdated()
            Else
                ' otherwise pops up message
                MessageBox.Show("添加失败，请稍后重试！")
            End If
#End Region
        Else
#Region "edit"
            ti.TId = CInt(TxtId.Text)

            ' calls method to edit table
            If tiBll.Edit("Cater", ti) Then
                ' if succeeds, reloads table list
                LoadList()
                RaiseEvent TableUpdated()
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
        TxtTitle.Clear()
        DdlHallAdd.SelectedIndex = -1
        RbFree.Checked = True
        BtnSave.Text = "添加"
    End Sub

    ''' <summary>
    ''' cancels currently editing table
    ''' </summary>
    ''' <param name="sender">BtnCancel</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Restore()
    End Sub

    ''' <summary>
    ''' formats IsFree
    ''' </summary>
    ''' <param name="sender">DgvList</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DgvList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvList.CellFormatting
        If e.ColumnIndex = 3 Then e.Value = If(CBool(e.Value), "空闲", "使用中")
    End Sub

    ''' <summary>
    ''' edits table
    ''' </summary>
    ''' <param name="sender">DgvList</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvList.CellDoubleClick
        ' According to what was double clicked, finds row and columns to assign to text boxes
        Dim row As DataGridViewRow = DgvList.Rows(e.RowIndex)
        TxtId.Text = row.Cells(0).Value.ToString()
        TxtTitle.Text = row.Cells(1).Value.ToString()
        DdlHallAdd.Text = row.Cells(2).Value.ToString()
        If CBool(row.Cells(3).Value) Then
            RbFree.Checked = True
            RbUnFree.Checked = False
        Else
            RbUnFree.Checked = True
            RbFree.Checked = False
        End If
        BtnSave.Text = "修改"
    End Sub

    ''' <summary>
    ''' removes table according to table id
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
                ' gets table id
                Dim ids As Integer() = New Integer(rows.Count - 1) {}
                For i As Integer = 0 To rows.Count - 1
                    ids(i) = CInt(rows(i).Cells(0).Value)
                Next

                ' removes table according to table id
                If tiBll.Remove("Cater", ids) Then
                    LoadList()
                    RaiseEvent TableUpdated()
                Else
                    MessageBox.Show("删除失败，请稍后重试！")
                End If
            End If
        Else
            MessageBox.Show("请先选择要删除的行！")
        End If
    End Sub

    ''' <summary>
    ''' manages hall
    ''' </summary>
    ''' <param name="sender">BtnAddHall</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnAddHall_Click(sender As Object, e As EventArgs) Handles BtnAddHall.Click
        Dim fHall As FormHallInfo = FormHallInfo.Create()
        AddHandler fHall.HallUpdated, AddressOf LoadList
        AddHandler fHall.HallUpdated, AddressOf LoadSearchList
        fHall.ShowDialog()
    End Sub
End Class