Imports _02.CaterBLL
Imports _04.CaterModel

Partial Public Class FormMain

    Private oiBll As New OrderInfoBll ' creates business logic layer object
    Private orderId As Integer = -1

    ''' <summary>
    ''' exits program
    ''' </summary>
    ''' <param name="sender">FormMain</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit() ' exits instead of just closing
    End Sub

    ''' <summary>
    ''' exits program
    ''' </summary>
    ''' <param name="sender">MenuQuit</param>
    ''' <param name="e">data for executing event</param>
    Private Sub MenuQuit_Click(sender As Object, e As EventArgs) Handles MenuQuit.Click
        Application.Exit() ' exits instead of just closing
    End Sub

    ''' <summary>
    ''' manages privilege
    ''' </summary>
    ''' <param name="sender">FormMain</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim type As Integer = CInt(Me.Tag)

        If type = 0 Then MenuManagerInfo.Visible = False ' doesn't display manager for clerk

        ' loads all halls
        LoadHallInfo()
    End Sub

    ''' <summary>
    ''' loads hall info
    ''' </summary>
    Private Sub LoadHallInfo()
        ' clears tab pages
        TcHallInfo.TabPages.Clear()
        ' gets all halls
        Dim hiBll As New HallInfoBll
        Dim tiBll As New TableInfoBll
        Dim hallList As List(Of HallInfo) = hiBll.GetList("Cater")
        ' adds info to tab pages
        For Each hi As HallInfo In hallList
            ' creates tab page according to hall
            Dim tp As New TabPage(hi.HTitle)
            ' gets all tables
            Dim dic As New Dictionary(Of String, String)
            dic.Add("THallId", hi.HId.ToString())
            Dim tableList As List(Of TableInfo) = tiBll.GetList("Cater", dic)
            ' dynamically creates list view and adds it to tab page
            Dim lvTableInfo As New ListView
            lvTableInfo.LargeImageList = ImageList1 ' List view uses ImageList1
            lvTableInfo.Dock = DockStyle.Fill
            AddHandler lvTableInfo.DoubleClick, AddressOf lvTableInfo_DoubleClick ' registers double click event
            tp.Controls.Add(lvTableInfo)
            For Each ti As TableInfo In tableList
                Dim lvi As New ListViewItem(ti.TTitle, If(ti.TIsFree, 0, 1))
                lvi.Tag = ti.TId
                lvTableInfo.Items.Add(lvi)
            Next
            ' adds tab page to container
            TcHallInfo.TabPages.Add(tp)
        Next
    End Sub

    ''' <summary>
    ''' places order
    ''' </summary>
    ''' <param name="sender">lvTableInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub lvTableInfo_DoubleClick(sender As Object, e As EventArgs)
        Dim lv As ListView = TryCast(sender, ListView)
        Dim lvi As ListViewItem = lv.SelectedItems(0)
        Dim tableId As Integer = CInt(lvi.Tag)

        If lvi.ImageIndex = 0 Then
#Region "If free, places order"
            ' places order
            orderId = oiBll.PlaceOrder("Cater", tableId)
            ' refreshes icon
            lv.SelectedItems(0).ImageIndex = 1
#End Region
        Else
#Region "If in use, gets table's order id"
            orderId = oiBll.GetOrderId("Cater", tableId)
#End Region
        End If

        Dim fOrder As FormOrderDish = FormOrderDish.Create()
        fOrder.Tag = orderId
        fOrder.ShowDialog()
    End Sub

    ''' <summary>
    ''' shows manager info form
    ''' </summary>
    ''' <param name="sender">MenuManagerInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub MenuManagerInfo_Click(sender As Object, e As EventArgs) Handles MenuManagerInfo.Click
        Dim fManager As FormManagerInfo = FormManagerInfo.Create()
        fManager.Show()
        fManager.Focus()
    End Sub

    ''' <summary>
    ''' shows member info form
    ''' </summary>
    ''' <param name="sender">MenuMemberInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub MenuMemberInfo_Click(sender As Object, e As EventArgs) Handles MenuMemberInfo.Click
        Dim fMember As FormMemberInfo = FormMemberInfo.Create()
        fMember.Show()
        fMember.Focus()
    End Sub

    ''' <summary>
    ''' shows dish info form
    ''' </summary>
    ''' <param name="sender">MenuDishInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub MenuDishInfo_Click(sender As Object, e As EventArgs) Handles MenuDishInfo.Click
        Dim fDish As FormDishInfo = FormDishInfo.Create()
        fDish.Show()
        fDish.Focus()
    End Sub

    ''' <summary>
    ''' shows table info form
    ''' </summary>
    ''' <param name="sender">MenuTableInfo</param>
    ''' <param name="e">data for executing event</param>
    Private Sub MenuTableInfo_Click(sender As Object, e As EventArgs) Handles MenuTableInfo.Click
        Dim fTable As FormTableInfo = FormTableInfo.Create()
        AddHandler fTable.TableUpdated, AddressOf LoadHallInfo
        fTable.Show()
        fTable.Focus()
    End Sub

    ''' <summary>
    ''' shows order pay form
    ''' </summary>
    ''' <param name="sender">MenuOrder</param>
    ''' <param name="e">data for executing event</param>
    Private Sub MenuOrder_Click(sender As Object, e As EventArgs) Handles MenuOrder.Click
        Dim lv As ListView = TryCast(TcHallInfo.SelectedTab.Controls(0), ListView)
        Dim lvTable As ListViewItem = lv.SelectedItems(0)
        If lvTable.ImageIndex = 1 Then
            Dim tableId As Integer = CInt(lvTable.Tag)
            orderId = oiBll.GetOrderId("Cater", tableId)
            Dim fPay As FormOrderPay = FormOrderPay.Create()
            fPay.Tag = orderId
            AddHandler fPay.Refresh, AddressOf LoadHallInfo
            fPay.ShowDialog()
            fPay.Focus()
        Else
            MessageBox.Show("餐桌未被使用，无法结账！")
        End If
    End Sub
End Class