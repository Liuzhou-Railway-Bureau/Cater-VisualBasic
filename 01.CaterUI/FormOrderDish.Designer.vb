<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderDish
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblMoney = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.DgvOrderDetail = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvAllDish = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DdlType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvOrderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvAllDish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblMoney)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BtnOrder)
        Me.GroupBox2.Controls.Add(Me.BtnRemove)
        Me.GroupBox2.Controls.Add(Me.DgvOrderDetail)
        Me.GroupBox2.Location = New System.Drawing.Point(745, -1)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(617, 602)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "已点菜品"
        '
        'LblMoney
        '
        Me.LblMoney.AutoSize = True
        Me.LblMoney.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblMoney.Location = New System.Drawing.Point(119, 26)
        Me.LblMoney.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMoney.Name = "LblMoney"
        Me.LblMoney.Size = New System.Drawing.Size(15, 15)
        Me.LblMoney.TabIndex = 7
        Me.LblMoney.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "消费总计：￥"
        '
        'BtnOrder
        '
        Me.BtnOrder.Location = New System.Drawing.Point(491, 16)
        Me.BtnOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(113, 29)
        Me.BtnOrder.TabIndex = 5
        Me.BtnOrder.Text = "下单"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(339, 16)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(144, 29)
        Me.BtnRemove.TabIndex = 4
        Me.BtnRemove.Text = "删除选中项"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'DgvOrderDetail
        '
        Me.DgvOrderDetail.AllowUserToAddRows = False
        Me.DgvOrderDetail.AllowUserToDeleteRows = False
        Me.DgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOrderDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7, Me.Column9})
        Me.DgvOrderDetail.Location = New System.Drawing.Point(8, 51)
        Me.DgvOrderDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvOrderDetail.Name = "DgvOrderDetail"
        Me.DgvOrderDetail.RowHeadersWidth = 51
        Me.DgvOrderDetail.RowTemplate.Height = 23
        Me.DgvOrderDetail.Size = New System.Drawing.Size(596, 544)
        Me.DgvOrderDetail.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "OId"
        Me.Column5.HeaderText = "编号"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "DTitle"
        Me.Column6.HeaderText = "名称"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Count"
        Me.Column7.HeaderText = "数量"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "DPrice"
        Me.Column9.HeaderText = "价格"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 125
        '
        'DgvAllDish
        '
        Me.DgvAllDish.AllowUserToAddRows = False
        Me.DgvAllDish.AllowUserToDeleteRows = False
        Me.DgvAllDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAllDish.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column8, Me.Column3, Me.Column4})
        Me.DgvAllDish.Location = New System.Drawing.Point(8, 51)
        Me.DgvAllDish.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvAllDish.MultiSelect = False
        Me.DgvAllDish.Name = "DgvAllDish"
        Me.DgvAllDish.ReadOnly = True
        Me.DgvAllDish.RowHeadersWidth = 51
        Me.DgvAllDish.RowTemplate.Height = 23
        Me.DgvAllDish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAllDish.Size = New System.Drawing.Size(731, 544)
        Me.DgvAllDish.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "DId"
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
        'Column8
        '
        Me.Column8.DataPropertyName = "DPrice"
        Me.Column8.HeaderText = "价格"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
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
        Me.Column4.DataPropertyName = "DChar"
        Me.Column4.HeaderText = "首字母"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'DdlType
        '
        Me.DdlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DdlType.FormattingEnabled = True
        Me.DdlType.Location = New System.Drawing.Point(504, 20)
        Me.DdlType.Margin = New System.Windows.Forms.Padding(4)
        Me.DdlType.Name = "DdlType"
        Me.DdlType.Size = New System.Drawing.Size(233, 23)
        Me.DdlType.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "菜品分类："
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(108, 18)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(276, 25)
        Me.TxtTitle.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvAllDish)
        Me.GroupBox1.Controls.Add(Me.DdlType)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtTitle)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-14, -1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(751, 602)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "菜单"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "菜名首字母："
        '
        'FormOrderDish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 601)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormOrderDish"
        Me.Text = "点菜"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvOrderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvAllDish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents LblMoney As Label
    Private WithEvents Label3 As Label
    Private WithEvents BtnOrder As Button
    Private WithEvents BtnRemove As Button
    Private WithEvents DgvOrderDetail As DataGridView
    Private WithEvents Column5 As DataGridViewTextBoxColumn
    Private WithEvents Column6 As DataGridViewTextBoxColumn
    Private WithEvents Column7 As DataGridViewTextBoxColumn
    Private WithEvents Column9 As DataGridViewTextBoxColumn
    Private WithEvents DgvAllDish As DataGridView
    Private WithEvents Column1 As DataGridViewTextBoxColumn
    Private WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents Column8 As DataGridViewTextBoxColumn
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents Column4 As DataGridViewTextBoxColumn
    Private WithEvents DdlType As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents TxtTitle As TextBox
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents Label1 As Label
End Class
