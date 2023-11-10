<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTableInfo
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
        Me.DdlHallSearch = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DdlFreeSearch = New System.Windows.Forms.ComboBox()
        Me.BtnSearchAll = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RbUnFree = New System.Windows.Forms.RadioButton()
        Me.RbFree = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAddHall = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.DdlHallAdd = New System.Windows.Forms.ComboBox()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DdlHallSearch
        '
        Me.DdlHallSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DdlHallSearch.FormattingEnabled = True
        Me.DdlHallSearch.Location = New System.Drawing.Point(75, 24)
        Me.DdlHallSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.DdlHallSearch.Name = "DdlHallSearch"
        Me.DdlHallSearch.Size = New System.Drawing.Size(148, 23)
        Me.DdlHallSearch.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DdlFreeSearch)
        Me.GroupBox2.Controls.Add(Me.DdlHallSearch)
        Me.GroupBox2.Controls.Add(Me.BtnSearchAll)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(685, 30)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(236, 156)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "搜索"
        '
        'DdlFreeSearch
        '
        Me.DdlFreeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DdlFreeSearch.FormattingEnabled = True
        Me.DdlFreeSearch.Location = New System.Drawing.Point(75, 72)
        Me.DdlFreeSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.DdlFreeSearch.Name = "DdlFreeSearch"
        Me.DdlFreeSearch.Size = New System.Drawing.Size(148, 23)
        Me.DdlFreeSearch.TabIndex = 9
        '
        'BtnSearchAll
        '
        Me.BtnSearchAll.Location = New System.Drawing.Point(12, 116)
        Me.BtnSearchAll.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSearchAll.Name = "BtnSearchAll"
        Me.BtnSearchAll.Size = New System.Drawing.Size(212, 31)
        Me.BtnSearchAll.TabIndex = 5
        Me.BtnSearchAll.Text = "显示全部"
        Me.BtnSearchAll.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "空  闲："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "厅  包："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Location = New System.Drawing.Point(53, 109)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 30)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "如果是包间则填写名称" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "如果是厅堂则填写号码"
        '
        'RbUnFree
        '
        Me.RbUnFree.AutoSize = True
        Me.RbUnFree.Location = New System.Drawing.Point(145, 236)
        Me.RbUnFree.Margin = New System.Windows.Forms.Padding(4)
        Me.RbUnFree.Name = "RbUnFree"
        Me.RbUnFree.Size = New System.Drawing.Size(73, 19)
        Me.RbUnFree.TabIndex = 21
        Me.RbUnFree.Text = "使用中"
        Me.RbUnFree.UseVisualStyleBackColor = True
        '
        'RbFree
        '
        Me.RbFree.AutoSize = True
        Me.RbFree.Checked = True
        Me.RbFree.Location = New System.Drawing.Point(75, 236)
        Me.RbFree.Margin = New System.Windows.Forms.Padding(4)
        Me.RbFree.Name = "RbFree"
        Me.RbFree.Size = New System.Drawing.Size(58, 19)
        Me.RbFree.TabIndex = 20
        Me.RbFree.TabStop = True
        Me.RbFree.Text = "空闲"
        Me.RbFree.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.RbUnFree)
        Me.GroupBox3.Controls.Add(Me.RbFree)
        Me.GroupBox3.Controls.Add(Me.BtnRemove)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.BtnAddHall)
        Me.GroupBox3.Controls.Add(Me.BtnCancel)
        Me.GroupBox3.Controls.Add(Me.BtnSave)
        Me.GroupBox3.Controls.Add(Me.DdlHallAdd)
        Me.GroupBox3.Controls.Add(Me.TxtTitle)
        Me.GroupBox3.Controls.Add(Me.TxtId)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(685, 194)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(236, 396)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "添加\修改"
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(15, 350)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(209, 31)
        Me.BtnRemove.TabIndex = 19
        Me.BtnRemove.Text = "删除选中的行数据"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(12, 322)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "提示：双击表格项进行修改"
        '
        'BtnAddHall
        '
        Me.BtnAddHall.Location = New System.Drawing.Point(75, 186)
        Me.BtnAddHall.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddHall.Name = "BtnAddHall"
        Me.BtnAddHall.Size = New System.Drawing.Size(149, 31)
        Me.BtnAddHall.TabIndex = 13
        Me.BtnAddHall.Text = "厅包管理"
        Me.BtnAddHall.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(131, 275)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(93, 31)
        Me.BtnCancel.TabIndex = 12
        Me.BtnCancel.Text = "取消"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(15, 275)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(93, 31)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Text = "添加"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'DdlHallAdd
        '
        Me.DdlHallAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DdlHallAdd.FormattingEnabled = True
        Me.DdlHallAdd.Location = New System.Drawing.Point(75, 152)
        Me.DdlHallAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.DdlHallAdd.Name = "DdlHallAdd"
        Me.DdlHallAdd.Size = New System.Drawing.Size(148, 23)
        Me.DdlHallAdd.TabIndex = 10
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(75, 74)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(148, 25)
        Me.TxtTitle.TabIndex = 6
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(75, 32)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(148, 25)
        Me.TxtId.TabIndex = 5
        Me.TxtId.Text = "添加时无编号"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 236)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "空  闲："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "厅  包："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 79)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "名  称："
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvList)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(605, 560)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "列表"
        '
        'DgvList
        '
        Me.DgvList.AllowUserToAddRows = False
        Me.DgvList.AllowUserToDeleteRows = False
        Me.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5})
        Me.DgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvList.Location = New System.Drawing.Point(4, 22)
        Me.DgvList.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvList.Name = "DgvList"
        Me.DgvList.ReadOnly = True
        Me.DgvList.RowHeadersWidth = 51
        Me.DgvList.RowTemplate.Height = 23
        Me.DgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvList.Size = New System.Drawing.Size(597, 534)
        Me.DgvList.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "TId"
        Me.Column1.HeaderText = "编号"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "TTitle"
        Me.Column2.HeaderText = "名称"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "THallTitle"
        Me.Column3.HeaderText = "厅包"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "TIsFree"
        Me.Column5.HeaderText = "状态"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'FormTableInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 621)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormTableInfo"
        Me.Text = "餐桌管理"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents DdlHallSearch As ComboBox
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents DdlFreeSearch As ComboBox
    Private WithEvents BtnSearchAll As Button
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Private WithEvents Label7 As Label
    Private WithEvents RbUnFree As RadioButton
    Private WithEvents RbFree As RadioButton
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents BtnRemove As Button
    Private WithEvents Label9 As Label
    Private WithEvents BtnAddHall As Button
    Private WithEvents BtnCancel As Button
    Private WithEvents BtnSave As Button
    Private WithEvents DdlHallAdd As ComboBox
    Private WithEvents TxtTitle As TextBox
    Private WithEvents TxtId As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents DgvList As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
