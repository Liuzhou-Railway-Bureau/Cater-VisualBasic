Imports _02.CaterBLL
Imports _04.CaterModel

Partial Public Class FormOrderPay

    Private oiBll As New OrderInfoBll
    Private Shared _form As FormOrderPay = Nothing ' singleton
    Public Shadows Event Refresh As Action
    Private orderId As Integer = -1

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' form singleton
    ''' </summary>
    ''' <returns>singleton form</returns>
    Public Shared Function Create() As FormOrderPay
        If _form Is Nothing Then _form = New FormOrderPay
        Return _form
    End Function

    ''' <summary>
    ''' resets singleton _form
    ''' </summary>
    ''' <param name="sender">FormOrderPay</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormOrderPay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' When form is being closed, Dispose() is called to release form by Close()
        _form = Nothing
    End Sub

    ''' <summary>
    ''' shows total money
    ''' </summary>
    ''' <param name="sender">FormOrderPay</param>
    ''' <param name="e">data for executing event</param>
    Private Sub FormOrderPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GbMember.Enabled = False
        ' gets order id
        orderId = CInt(Me.Tag)
        ' gets total money
        GetMoney()
    End Sub

    ''' <summary>
    ''' gets total money
    ''' </summary>
    Private Sub GetMoney()
        Dim sum As Decimal = oiBll.GetTotalPrice("Cater", orderId)
        LblPayMoney.Text = CStr(sum)
        LblPayMoneyDiscount.Text = LblPayMoney.Text
    End Sub

    ''' <summary>
    ''' enables or disables GbMember
    ''' </summary>
    ''' <param name="sender">CbkMember</param>
    ''' <param name="e">data for executing event</param>
    Private Sub CbkMember_CheckedChanged(sender As Object, e As EventArgs) Handles CbkMember.CheckedChanged
        GbMember.Enabled = CbkMember.Checked
    End Sub

    ''' <summary>
    ''' loads undeleted member
    ''' </summary>
    Private Sub LoadMember()
        ' queries member according to member ID or phone number
        Dim dic As New Dictionary(Of String, String)
        If Not String.IsNullOrEmpty(TxtId.Text) Then dic.Add("MId", TxtId.Text)
        If Not String.IsNullOrEmpty(TxtPhone.Text) Then dic.Add("MPhone", TxtPhone.Text)

        Dim miBll As New MemberInfoBll
        Dim list As List(Of MemberInfo) = miBll.GetList("Cater", dic)
        If list.Count > 0 Then
#Region "found"
            ' shows member info
            Dim mi As MemberInfo
            mi = list(0)
            LblMoney.Text = CStr(mi.MMoney)
            LblTypeTitle.Text = mi.MTypeTitle
            LblDiscount.Text = CStr(mi.MDiscount)
            LblPayMoneyDiscount.Text = CStr(CDec(LblPayMoney.Text) * CDec(LblDiscount.Text))
#End Region
        Else
#Region "not found"
            ' pops up message
            MessageBox.Show("会员信息有误！")
#End Region
        End If
    End Sub

    ''' <summary>
    ''' finds by id
    ''' </summary>
    ''' <param name="sender">TxtId</param>
    ''' <param name="e">data for executing event</param>
    Private Sub TxtId_Leave(sender As Object, e As EventArgs) Handles TxtId.Leave
        LoadMember()
    End Sub

    ''' <summary>
    ''' finds by phone
    ''' </summary>
    ''' <param name="sender">TxtPhone</param>
    ''' <param name="e">data for executing event</param>
    Private Sub TxtPhone_Leave(sender As Object, e As EventArgs) Handles TxtPhone.Leave
        LoadMember()
    End Sub

    ''' <summary>
    ''' pays for bill
    ''' </summary>
    ''' <param name="sender">BtnOrderPay</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnOrderPay_Click(sender As Object, e As EventArgs) Handles BtnOrderPay.Click
        If CbkMember.Checked Then
#Region "is member"
            If CbkMoney.Checked Then
#Region "uses member balance"
                If CDec(LblMoney.Text) >= CDec(LblPayMoneyDiscount.Text) Then Pay(True) Else MessageBox.Show("账户余额不足，无法结账！")
#End Region
            Else
#Region "doesn't use member balance"
                Pay(True)
#End Region
            End If
#End Region
        Else
#Region "is not member"
            Pay(False)
#End Region
        End If
    End Sub

    ''' <summary>
    ''' pays for bill
    ''' </summary>
    ''' <param name="isMember">whether pays as member</param>
    Private Sub Pay(isMember As Boolean)
        If isMember Then
#Region "pays as member"
            If oiBll.PayForBill("Cater", CbkMoney.Checked, CDec(LblPayMoneyDiscount.Text),
CInt(TxtId.Text), orderId, CDec(LblDiscount.Text)) Then
                ' if succeeds, prompts OK and closes form
                MessageBox.Show("结账完成")
                RaiseEvent Refresh()
                Me.Close()
            Else
                ' otherwise prompts failure
                MessageBox.Show("结账失败，请重试！")
            End If
#End Region
        Else
#Region "pays as not member"
            If oiBll.PayForBill("Cater", orderId) Then
                ' if succeeds, prompts OK and closes form
                MessageBox.Show("结账完成")
                RaiseEvent Refresh()
                Me.Close()
            Else
                ' otherwise prompts failure
                MessageBox.Show("结账失败，请重试！")
            End If
#End Region
        End If
    End Sub

    ''' <summary>
    ''' cancels payment
    ''' </summary>
    ''' <param name="sender">BtnCancel</param>
    ''' <param name="e">data for executing event</param>
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ' closes form
        Me.Close()
    End Sub
End Class