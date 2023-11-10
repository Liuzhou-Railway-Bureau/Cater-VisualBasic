Imports _02.CaterBLL
Imports _04.CaterModel

Partial Public Class FormOrderDish

    Private oiBll As New OrderInfoBll ' creates business logic layer object
    Private Shared _form As FormOrderDish = Nothing ' singleton

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' form singleton
    ''' </summary>
    ''' <returns>singleton form</returns>
    Public Shared Function Create() As FormOrderDish
        If _form Is Nothing Then _form = New FormOrderDish
        Return _form
    End Function

    ''' <summary>
    ''' resets singleton _form
    ''' </summary>
    ''' <param name="sender">FormOrderDish</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormOrderDish_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' When form is being closed, Dispose() is called to release form by Close()
        _form = Nothing
    End Sub

    ''' <summary>
    ''' loads undeleted dish list and dish type list
    ''' </summary>
    ''' <param name="sender">FormOrderDish</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormOrderDish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDishList()
        LoadDishTypeList()
        LoadDetailList()
    End Sub

    ''' <summary>
    ''' loads undeleted dish list
    ''' </summary>
    Private Sub LoadDishList()
        ' creates DishInfoBll
        Dim diBll As New DishInfoBll
        ' creates a dictionary to save condition
        Dim dic As New Dictionary(Of String, String)
        If Not String.IsNullOrEmpty(TxtTitle.Text) Then dic.Add("DChar", TxtTitle.Text)
        If DdlType.SelectedIndex > 0 Then dic.Add("DTypeId", DdlType.SelectedValue.ToString())

        ' forbids DgvAllDish to auto generate columns
        DgvAllDish.AutoGenerateColumns = False
        ' calls method and binds data
        DgvAllDish.DataSource = diBll.GetList("Cater", dic)
    End Sub

    ''' <summary>
    ''' loads dish type list
    ''' </summary>
    Private Sub LoadDishTypeList()
        ' gets dish type list
        Dim dtiBll As New DishTypeInfoBll
        Dim list As List(Of DishTypeInfo) = dtiBll.GetList("Cater")
        list.Insert(0, New DishTypeInfo() With {
            .DId = 0,
            .DTitle = "全部",
            .DIsDelete = False
        })
        ' binds data
        DdlType.DataSource = list
        ' sets display dish
        DdlType.DisplayMember = "DTitle"
        ' sets actually-used value dish
        DdlType.ValueMember = "DId"
        ' <select><option value="id">title</option></select>
        ' unselects all by default
        DdlType.SelectedIndex = -1
    End Sub

    ''' <summary>
    ''' loads order detail list
    ''' </summary>
    Private Sub LoadDetailList()
        ' gets order id
        Dim orderId As Integer = CInt(Me.Tag)

        ' forbids DgvOrderDetail to auto generate columns
        DgvOrderDetail.AutoGenerateColumns = False
        ' calls method and binds data
        DgvOrderDetail.DataSource = oiBll.GetDetailList("Cater", orderId)

        ' calculates total price
        GetSum()
    End Sub

    ''' <summary>
    ''' gets total price
    ''' </summary>
    Private Sub GetSum()
        ' gets order id
        Dim orderId As Integer = CInt(Me.Tag)
        ' gets total price
        Dim sum As Decimal = oiBll.GetTotalPrice("Cater", orderId)
        If sum > 0 Then LblMoney.Text = CStr(sum)
    End Sub

    ''' <summary>
    ''' finds by title
    ''' </summary>
    ''' <param name="sender">TxtTitle</param>
    ''' <param name="e">data for executing event</param>
    Private Sub TxtTitle_TextChanged(sender As Object, e As EventArgs) Handles TxtTitle.TextChanged
        LoadDishList()
    End Sub

    ''' <summary>
    ''' finds by type
    ''' </summary>
    ''' <param name="sender">DdlType</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DdlType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DdlType.SelectedIndexChanged
        LoadDishList()
    End Sub

    ''' <summary>
    ''' orders dish
    ''' </summary>
    ''' <param name="sender">DgvAllDish</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DgvAllDish_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAllDish.CellDoubleClick
        ' gets order id and dish id
        Dim orderId As Integer = CInt(Me.Tag)
        Dim dishId As Integer = CInt(DgvAllDish.Rows(e.RowIndex).Cells(0).Value)
        ' orders dish
        If oiBll.OrderDish("Cater", orderId, dishId) Then
            ' if succeeds, loads order detail list
            LoadDetailList()
        Else
            ' otherwise pops up message
            MessageBox.Show("点菜失败，请重试！")
        End If
    End Sub

    ''' <summary>
    ''' updates dish count
    ''' </summary>
    ''' <param name="sender">DgvOrderDetail</param>
    ''' <param name="e">data for executing event</param>
    Private Sub DgvOrderDetail_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvOrderDetail.CellEndEdit
        If e.ColumnIndex = 2 Then
            ' gets updated row
            Dim row As DataGridViewRow = DgvOrderDetail.Rows(e.RowIndex)
            ' gets order id and dish count
            Dim orderId As Integer = CInt(row.Cells(0).Value)
            Dim count As Integer = CInt(row.Cells(2).Value)
            ' updates dish count
            If oiBll.SetCount("Cater", orderId, count) Then
                ' if succeeds, calculates total price
                GetSum()
            Else
                ' if fails, pops up message
                MessageBox.Show("点菜失败，请重试！")
            End If
        End If
    End Sub

    ''' <summary>
    ''' places order
    ''' </summary>
    ''' <param name="sender">BtnOrder</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        ' gets order id and total price
        Dim orderId As Integer = CInt(Me.Tag)
        Dim sum As Decimal = CDec(LblMoney.Text)
        ' places order
        If oiBll.PlaceOrder("Cater", orderId, sum) Then
            ' if succeeds, prompts OK
            MessageBox.Show("下单成功")
        Else
            ' otherwise prompts failure
            MessageBox.Show("点菜失败，请重试！")
        End If
    End Sub

    ''' <summary>
    ''' removes detail
    ''' </summary>
    ''' <param name="sender">btnRemove</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        ' gets selected rows
        Dim rows As DataGridViewSelectedRowCollection = DgvOrderDetail.SelectedRows

        If rows.Count > 0 Then
            ' asks whether to remove
            Dim result As DialogResult = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.YesNoCancel)

            If result = DialogResult.Yes Then
                ' gets detail id
                Dim ids As Integer() = New Integer(rows.Count - 1) {}
                For i As Integer = 0 To rows.Count - 1
                    ids(i) = CInt(rows(i).Cells(0).Value)
                Next

                ' removes detail according to detail id
                If oiBll.RemoveDetail("Cater", ids) Then
                    LoadDetailList()
                Else
                    MessageBox.Show("删除失败，请稍后重试！")
                End If
            End If
        Else
            MessageBox.Show("请先选择要删除的行！")
        End If
    End Sub
End Class