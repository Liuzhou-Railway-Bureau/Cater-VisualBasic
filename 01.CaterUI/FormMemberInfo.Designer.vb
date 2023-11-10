<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMemberInfo
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
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAddType = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.DdlType = New System.Windows.Forms.ComboBox()
        Me.TxtMoney = New System.Windows.Forms.TextBox()
        Me.TxtPhoneAdd = New System.Windows.Forms.TextBox()
        Me.BtnSearchAll = New System.Windows.Forms.Button()
        Me.TxtPhoneSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNameSearch = New System.Windows.Forms.TextBox()
        Me.TxtNameAdd = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "MMoney"
        Me.Column5.HeaderText = "账户余额"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(15, 360)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(204, 31)
        Me.BtnRemove.TabIndex = 19
        Me.BtnRemove.Text = "删除选中的行数据"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(12, 325)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "提示：双击表格项进行修改"
        '
        'BtnAddType
        '
        Me.BtnAddType.Location = New System.Drawing.Point(75, 151)
        Me.BtnAddType.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddType.Name = "BtnAddType"
        Me.BtnAddType.Size = New System.Drawing.Size(145, 31)
        Me.BtnAddType.TabIndex = 13
        Me.BtnAddType.Text = "类型管理"
        Me.BtnAddType.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(127, 280)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(93, 31)
        Me.BtnCancel.TabIndex = 12
        Me.BtnCancel.Text = "取消"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(15, 280)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(93, 31)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Text = "添加"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'DdlType
        '
        Me.DdlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DdlType.FormattingEnabled = True
        Me.DdlType.Location = New System.Drawing.Point(75, 118)
        Me.DdlType.Margin = New System.Windows.Forms.Padding(4)
        Me.DdlType.Name = "DdlType"
        Me.DdlType.Size = New System.Drawing.Size(144, 23)
        Me.DdlType.TabIndex = 10
        '
        'TxtMoney
        '
        Me.TxtMoney.Location = New System.Drawing.Point(75, 235)
        Me.TxtMoney.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMoney.Name = "TxtMoney"
        Me.TxtMoney.Size = New System.Drawing.Size(144, 25)
        Me.TxtMoney.TabIndex = 9
        '
        'TxtPhoneAdd
        '
        Me.TxtPhoneAdd.Location = New System.Drawing.Point(75, 196)
        Me.TxtPhoneAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPhoneAdd.Name = "TxtPhoneAdd"
        Me.TxtPhoneAdd.Size = New System.Drawing.Size(144, 25)
        Me.TxtPhoneAdd.TabIndex = 8
        '
        'BtnSearchAll
        '
        Me.BtnSearchAll.Location = New System.Drawing.Point(15, 95)
        Me.BtnSearchAll.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSearchAll.Name = "BtnSearchAll"
        Me.BtnSearchAll.Size = New System.Drawing.Size(204, 31)
        Me.BtnSearchAll.TabIndex = 5
        Me.BtnSearchAll.Text = "显示全部"
        Me.BtnSearchAll.UseVisualStyleBackColor = True
        '
        'TxtPhoneSearch
        '
        Me.TxtPhoneSearch.Location = New System.Drawing.Point(73, 52)
        Me.TxtPhoneSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPhoneSearch.Name = "TxtPhoneSearch"
        Me.TxtPhoneSearch.Size = New System.Drawing.Size(144, 25)
        Me.TxtPhoneSearch.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "手机号："
        '
        'TxtNameSearch
        '
        Me.TxtNameSearch.Location = New System.Drawing.Point(73, 19)
        Me.TxtNameSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNameSearch.Name = "TxtNameSearch"
        Me.TxtNameSearch.Size = New System.Drawing.Size(145, 25)
        Me.TxtNameSearch.TabIndex = 1
        '
        'TxtNameAdd
        '
        Me.TxtNameAdd.Location = New System.Drawing.Point(75, 74)
        Me.TxtNameAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNameAdd.Name = "TxtNameAdd"
        Me.TxtNameAdd.Size = New System.Drawing.Size(144, 25)
        Me.TxtNameAdd.TabIndex = 6
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(75, 32)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(144, 25)
        Me.TxtId.TabIndex = 5
        Me.TxtId.Text = "添加时无编号"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 245)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "余  额："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 201)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "手机号："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSearchAll)
        Me.GroupBox2.Controls.Add(Me.TxtPhoneSearch)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtNameSearch)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(752, 30)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(235, 138)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "搜索"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "姓  名："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "类  型："
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvList)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(739, 560)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "列表"
        '
        'DgvList
        '
        Me.DgvList.AllowUserToAddRows = False
        Me.DgvList.AllowUserToDeleteRows = False
        Me.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvList.Location = New System.Drawing.Point(4, 22)
        Me.DgvList.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvList.Name = "DgvList"
        Me.DgvList.ReadOnly = True
        Me.DgvList.RowHeadersWidth = 51
        Me.DgvList.RowTemplate.Height = 23
        Me.DgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvList.Size = New System.Drawing.Size(731, 534)
        Me.DgvList.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "MId"
        Me.Column1.HeaderText = "编号"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "MName"
        Me.Column2.HeaderText = "姓名"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "MTypeTitle"
        Me.Column3.HeaderText = "类型"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "MPhone"
        Me.Column4.HeaderText = "手机号"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 79)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "姓  名："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "编  号："
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnRemove)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.BtnAddType)
        Me.GroupBox3.Controls.Add(Me.BtnCancel)
        Me.GroupBox3.Controls.Add(Me.BtnSave)
        Me.GroupBox3.Controls.Add(Me.DdlType)
        Me.GroupBox3.Controls.Add(Me.TxtMoney)
        Me.GroupBox3.Controls.Add(Me.TxtPhoneAdd)
        Me.GroupBox3.Controls.Add(Me.TxtNameAdd)
        Me.GroupBox3.Controls.Add(Me.TxtId)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(752, 175)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(235, 415)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "添加\修改"
        '
        'FormMemberInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 621)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FormMemberInfo"
        Me.Text = "会员管理"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Column5 As DataGridViewTextBoxColumn
    Private WithEvents BtnRemove As Button
    Private WithEvents Label9 As Label
    Private WithEvents BtnAddType As Button
    Private WithEvents BtnCancel As Button
    Private WithEvents BtnSave As Button
    Private WithEvents DdlType As ComboBox
    Private WithEvents TxtMoney As TextBox
    Private WithEvents TxtPhoneAdd As TextBox
    Private WithEvents BtnSearchAll As Button
    Private WithEvents TxtPhoneSearch As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents TxtNameSearch As TextBox
    Private WithEvents TxtNameAdd As TextBox
    Private WithEvents TxtId As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents Label6 As Label
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents Label1 As Label
    Private WithEvents Label5 As Label
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents DgvList As DataGridView
    Private WithEvents Column1 As DataGridViewTextBoxColumn
    Private WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents Column4 As DataGridViewTextBoxColumn
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Private WithEvents GroupBox3 As GroupBox
End Class
