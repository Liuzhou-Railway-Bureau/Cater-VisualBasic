<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDishInfo
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
        Me.DgvList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAddType = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.DdlTypeAdd = New System.Windows.Forms.ComboBox()
        Me.TxtChar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DdlTypeSearch = New System.Windows.Forms.ComboBox()
        Me.BtnSearchAll = New System.Windows.Forms.Button()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.TxtTitleSearch = New System.Windows.Forms.TextBox()
        Me.TxtTitleAdd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Column1.DataPropertyName = "Did"
        Me.Column1.HeaderText = "编号"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "DTitle"
        Me.Column2.HeaderText = "名称"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "DTypeTitle"
        Me.Column3.HeaderText = "分类"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "DPrice"
        Me.Column4.HeaderText = "价格"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "DChar"
        Me.Column5.HeaderText = "拼音"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(15, 355)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(223, 29)
        Me.BtnRemove.TabIndex = 16
        Me.BtnRemove.Text = "删除选中的行数据"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(9, 330)
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
        Me.BtnAddType.Size = New System.Drawing.Size(163, 29)
        Me.BtnAddType.TabIndex = 13
        Me.BtnAddType.Text = "分类管理"
        Me.BtnAddType.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(137, 285)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 29)
        Me.BtnCancel.TabIndex = 12
        Me.BtnCancel.Text = "取消"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(12, 285)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(96, 29)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Text = "添加"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'DdlTypeAdd
        '
        Me.DdlTypeAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DdlTypeAdd.FormattingEnabled = True
        Me.DdlTypeAdd.Location = New System.Drawing.Point(75, 118)
        Me.DdlTypeAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.DdlTypeAdd.Name = "DdlTypeAdd"
        Me.DdlTypeAdd.Size = New System.Drawing.Size(161, 23)
        Me.DdlTypeAdd.TabIndex = 10
        '
        'TxtChar
        '
        Me.TxtChar.Location = New System.Drawing.Point(75, 235)
        Me.TxtChar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtChar.Name = "TxtChar"
        Me.TxtChar.Size = New System.Drawing.Size(161, 25)
        Me.TxtChar.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvList)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(739, 560)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "列表"
        '
        'DdlTypeSearch
        '
        Me.DdlTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DdlTypeSearch.FormattingEnabled = True
        Me.DdlTypeSearch.Location = New System.Drawing.Point(75, 74)
        Me.DdlTypeSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.DdlTypeSearch.Name = "DdlTypeSearch"
        Me.DdlTypeSearch.Size = New System.Drawing.Size(161, 23)
        Me.DdlTypeSearch.TabIndex = 8
        '
        'BtnSearchAll
        '
        Me.BtnSearchAll.Location = New System.Drawing.Point(15, 120)
        Me.BtnSearchAll.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSearchAll.Name = "BtnSearchAll"
        Me.BtnSearchAll.Size = New System.Drawing.Size(223, 29)
        Me.BtnSearchAll.TabIndex = 5
        Me.BtnSearchAll.Text = "显示全部"
        Me.BtnSearchAll.UseVisualStyleBackColor = True
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(75, 196)
        Me.TxtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(161, 25)
        Me.TxtPrice.TabIndex = 8
        '
        'TxtTitleSearch
        '
        Me.TxtTitleSearch.Location = New System.Drawing.Point(73, 25)
        Me.TxtTitleSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTitleSearch.Name = "TxtTitleSearch"
        Me.TxtTitleSearch.Size = New System.Drawing.Size(163, 25)
        Me.TxtTitleSearch.TabIndex = 1
        '
        'TxtTitleAdd
        '
        Me.TxtTitleAdd.Location = New System.Drawing.Point(75, 74)
        Me.TxtTitleAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTitleAdd.Name = "TxtTitleAdd"
        Me.TxtTitleAdd.Size = New System.Drawing.Size(161, 25)
        Me.TxtTitleAdd.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "分  类："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DdlTypeSearch)
        Me.GroupBox2.Controls.Add(Me.BtnSearchAll)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtTitleSearch)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(744, 30)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(252, 156)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "搜索"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "名  称："
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(75, 32)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(161, 25)
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
        Me.Label7.Text = "拼  音："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "分  类："
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnRemove)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.BtnAddType)
        Me.GroupBox3.Controls.Add(Me.BtnCancel)
        Me.GroupBox3.Controls.Add(Me.BtnSave)
        Me.GroupBox3.Controls.Add(Me.DdlTypeAdd)
        Me.GroupBox3.Controls.Add(Me.TxtChar)
        Me.GroupBox3.Controls.Add(Me.TxtPrice)
        Me.GroupBox3.Controls.Add(Me.TxtTitleAdd)
        Me.GroupBox3.Controls.Add(Me.TxtId)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(744, 194)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(252, 396)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "添加\修改"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 201)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "价  格："
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
        'FormDishInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 621)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FormDishInfo"
        Me.Text = "菜品管理"
        CType(Me.DgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents DgvList As DataGridView
    Private WithEvents Column1 As DataGridViewTextBoxColumn
    Private WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents Column4 As DataGridViewTextBoxColumn
    Private WithEvents Column5 As DataGridViewTextBoxColumn
    Private WithEvents BtnRemove As Button
    Private WithEvents Label9 As Label
    Private WithEvents BtnAddType As Button
    Private WithEvents BtnCancel As Button
    Private WithEvents BtnSave As Button
    Private WithEvents DdlTypeAdd As ComboBox
    Private WithEvents TxtChar As TextBox
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents DdlTypeSearch As ComboBox
    Private WithEvents BtnSearchAll As Button
    Private WithEvents TxtPrice As TextBox
    Private WithEvents TxtTitleSearch As TextBox
    Private WithEvents TxtTitleAdd As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents Label1 As Label
    Private WithEvents TxtId As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents Label5 As Label
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents Label6 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
End Class
