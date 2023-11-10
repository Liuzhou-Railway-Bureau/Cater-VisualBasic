Imports _02.CaterBLL
Imports _04.CaterModel

Partial Public Class FormDishTypeInfo

    Private dtiBll As New DishTypeInfoBll ' creates business logic layer object
    Private Shared _form As FormDishTypeInfo = Nothing ' singleton
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
    Public Shared Function Create() As FormDishTypeInfo
        If _form Is Nothing Then _form = New FormDishTypeInfo
        Return _form
    End Function

    ''' <summary>
    ''' resets singleton _form
    ''' </summary>
    ''' <param name="sender">FormDishTypeInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormDishTypeInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' When form is being closed, Dispose() is called to release form by Close()
        _form = Nothing
        Me.DialogResult = result
    End Sub

    ''' <summary>
    ''' loads undeleted dish type list
    ''' </summary>
    ''' <param name="sender">FormDishTypeInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormDishTypeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    ''' <summary>
    ''' loads undeleted dish type list
    ''' </summary>
    Private Sub LoadList()
        ' forbids DgvList to auto generate columns
        DgvList.AutoGenerateColumns = False
        ' calls method and binds data
        DgvList.DataSource = dtiBll.GetList("Cater")
    End Sub

    ''' <summary>
    ''' adds dish type
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
#End Region

        ' collects dish type info
        Dim dti As New DishTypeInfo With {
            .DTitle = TxtTitle.Text,
            .DIsDelete = False
        }

        If TxtId.Text.Equals("添加时无编号") Then
#Region "add"
            ' calls method to add dish type
            If dtiBll.Add("Cater", dti) Then
                ' if succeeds, reloads dish type list
                LoadList()
            Else
                ' otherwise pops up message
                MessageBox.Show("添加失败，请稍后重试！")
            End If
#End Region
        Else
#Region "edit"
            dti.DId = CInt(TxtId.Text)

            ' calls method to edit dish type
            If dtiBll.Edit("Cater", dti) Then
                ' if succeeds, reloads dish type list
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
        BtnSave.Text = "添加"
    End Sub

    ''' <summary>
    ''' cancels currently editing dish type
    ''' </summary>
    ''' <param name="sender">BtnCancel</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Restore()
    End Sub

    ''' <summary>
    ''' edits dish type
    ''' </summary>
    ''' <param name="sender">DgvList</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvList.CellDoubleClick
        ' According to what was double clicked, finds row and columns to assign to text boxes
        Dim row As DataGridViewRow = DgvList.Rows(e.RowIndex)
        TxtId.Text = row.Cells(0).Value.ToString()
        TxtTitle.Text = row.Cells(1).Value.ToString()
        BtnSave.Text = "修改"
    End Sub

    ''' <summary>
    ''' removes dish type according to dish type id
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
                ' gets dish type id
                Dim ids As Integer() = New Integer(rows.Count - 1) {}
                For i As Integer = 0 To rows.Count - 1
                    ids(i) = CInt(rows(i).Cells(0).Value)
                Next

                ' removes dish type according to dish type id
                If dtiBll.Remove("Cater", ids) Then
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