<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderPay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOrderPay = New System.Windows.Forms.Button()
        Me.LblPayMoney = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblPayMoneyDiscount = New System.Windows.Forms.Label()
        Me.GbMember = New System.Windows.Forms.GroupBox()
        Me.CbkMoney = New System.Windows.Forms.CheckBox()
        Me.LblDiscount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblTypeTitle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblMoney = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbkMember = New System.Windows.Forms.CheckBox()
        Me.GbMember.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(420, 296)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "应收金额："
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(392, 335)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(127, 29)
        Me.BtnCancel.TabIndex = 28
        Me.BtnCancel.Text = "暂不结账"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOrderPay
        '
        Me.BtnOrderPay.Location = New System.Drawing.Point(241, 335)
        Me.BtnOrderPay.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOrderPay.Name = "BtnOrderPay"
        Me.BtnOrderPay.Size = New System.Drawing.Size(127, 29)
        Me.BtnOrderPay.TabIndex = 27
        Me.BtnOrderPay.Text = "确认结账"
        Me.BtnOrderPay.UseVisualStyleBackColor = True
        '
        'LblPayMoney
        '
        Me.LblPayMoney.AutoSize = True
        Me.LblPayMoney.Location = New System.Drawing.Point(334, 296)
        Me.LblPayMoney.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPayMoney.Name = "LblPayMoney"
        Me.LblPayMoney.Size = New System.Drawing.Size(15, 15)
        Me.LblPayMoney.TabIndex = 26
        Me.LblPayMoney.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(238, 296)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "消费金额："
        '
        'LblPayMoneyDiscount
        '
        Me.LblPayMoneyDiscount.AutoSize = True
        Me.LblPayMoneyDiscount.Location = New System.Drawing.Point(516, 296)
        Me.LblPayMoneyDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPayMoneyDiscount.Name = "LblPayMoneyDiscount"
        Me.LblPayMoneyDiscount.Size = New System.Drawing.Size(15, 15)
        Me.LblPayMoneyDiscount.TabIndex = 30
        Me.LblPayMoneyDiscount.Text = "0"
        '
        'GbMember
        '
        Me.GbMember.Controls.Add(Me.CbkMoney)
        Me.GbMember.Controls.Add(Me.LblDiscount)
        Me.GbMember.Controls.Add(Me.Label6)
        Me.GbMember.Controls.Add(Me.LblTypeTitle)
        Me.GbMember.Controls.Add(Me.Label4)
        Me.GbMember.Controls.Add(Me.LblMoney)
        Me.GbMember.Controls.Add(Me.Label3)
        Me.GbMember.Controls.Add(Me.TxtPhone)
        Me.GbMember.Controls.Add(Me.Label2)
        Me.GbMember.Controls.Add(Me.TxtId)
        Me.GbMember.Controls.Add(Me.Label1)
        Me.GbMember.Location = New System.Drawing.Point(229, 115)
        Me.GbMember.Margin = New System.Windows.Forms.Padding(4)
        Me.GbMember.Name = "GbMember"
        Me.GbMember.Padding = New System.Windows.Forms.Padding(4)
        Me.GbMember.Size = New System.Drawing.Size(343, 166)
        Me.GbMember.TabIndex = 25
        Me.GbMember.TabStop = False
        Me.GbMember.Text = "会员信息"
        '
        'CbkMoney
        '
        Me.CbkMoney.AutoSize = True
        Me.CbkMoney.Location = New System.Drawing.Point(193, 105)
        Me.CbkMoney.Margin = New System.Windows.Forms.Padding(4)
        Me.CbkMoney.Name = "CbkMoney"
        Me.CbkMoney.Size = New System.Drawing.Size(89, 19)
        Me.CbkMoney.TabIndex = 10
        Me.CbkMoney.Text = "使用余额"
        Me.CbkMoney.UseVisualStyleBackColor = True
        '
        'LblDiscount
        '
        Me.LblDiscount.AutoSize = True
        Me.LblDiscount.Location = New System.Drawing.Point(273, 136)
        Me.LblDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDiscount.Name = "LblDiscount"
        Me.LblDiscount.Size = New System.Drawing.Size(15, 15)
        Me.LblDiscount.TabIndex = 9
        Me.LblDiscount.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(191, 136)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "折    扣："
        '
        'LblTypeTitle
        '
        Me.LblTypeTitle.AutoSize = True
        Me.LblTypeTitle.Location = New System.Drawing.Point(92, 136)
        Me.LblTypeTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTypeTitle.Name = "LblTypeTitle"
        Me.LblTypeTitle.Size = New System.Drawing.Size(67, 15)
        Me.LblTypeTitle.TabIndex = 7
        Me.LblTypeTitle.Text = "普通会员"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "会员等级："
        '
        'LblMoney
        '
        Me.LblMoney.AutoSize = True
        Me.LblMoney.Location = New System.Drawing.Point(92, 106)
        Me.LblMoney.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMoney.Name = "LblMoney"
        Me.LblMoney.Size = New System.Drawing.Size(15, 15)
        Me.LblMoney.TabIndex = 5
        Me.LblMoney.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "账户余额："
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(92, 65)
        Me.TxtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(233, 25)
        Me.TxtPhone.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "手 机 号："
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(92, 24)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(233, 25)
        Me.TxtId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "会员编号："
        '
        'CbkMember
        '
        Me.CbkMember.AutoSize = True
        Me.CbkMember.Location = New System.Drawing.Point(230, 87)
        Me.CbkMember.Margin = New System.Windows.Forms.Padding(4)
        Me.CbkMember.Name = "CbkMember"
        Me.CbkMember.Size = New System.Drawing.Size(74, 19)
        Me.CbkMember.TabIndex = 24
        Me.CbkMember.Text = "是会员"
        Me.CbkMember.UseVisualStyleBackColor = True
        '
        'FormOrderPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOrderPay)
        Me.Controls.Add(Me.LblPayMoney)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblPayMoneyDiscount)
        Me.Controls.Add(Me.GbMember)
        Me.Controls.Add(Me.CbkMember)
        Me.Name = "FormOrderPay"
        Me.Text = "FormOrderPay"
        Me.GbMember.ResumeLayout(False)
        Me.GbMember.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label8 As Label
    Private WithEvents BtnCancel As Button
    Private WithEvents BtnOrderPay As Button
    Private WithEvents LblPayMoney As Label
    Private WithEvents Label7 As Label
    Private WithEvents LblPayMoneyDiscount As Label
    Private WithEvents GbMember As GroupBox
    Private WithEvents CbkMoney As CheckBox
    Private WithEvents LblDiscount As Label
    Private WithEvents Label6 As Label
    Private WithEvents LblTypeTitle As Label
    Private WithEvents Label4 As Label
    Private WithEvents LblMoney As Label
    Private WithEvents Label3 As Label
    Private WithEvents TxtPhone As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents TxtId As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents CbkMember As CheckBox
End Class
