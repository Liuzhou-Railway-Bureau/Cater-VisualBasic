<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManagerInfo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Rb2 = New System.Windows.Forms.RadioButton()
        Me.Rb1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtPwd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvList = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.TxtId)
        Me.GroupBox1.Controls.Add(Me.BtnRemove)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Rb2)
        Me.GroupBox1.Controls.Add(Me.Rb1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.TxtPwd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(585, 49)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(301, 349)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "添加\修改"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.label6.Location = New System.Drawing.Point(27, 160)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(247, 15)
        Me.label6.TabIndex = 13
        Me.label6.Text = "这里只是提示，与实际密码位数无关"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(64, 36)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(225, 25)
        Me.TxtId.TabIndex = 12
        Me.TxtId.Text = "添加时无编号"
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(31, 312)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(224, 29)
        Me.BtnRemove.TabIndex = 4
        Me.BtnRemove.Text = "删除选中的店员"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(4, 281)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "提示：双击表格项可以在此处进行修改"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "编号："
        '
        'Rb2
        '
        Me.Rb2.AutoSize = True
        Me.Rb2.Checked = True
        Me.Rb2.Location = New System.Drawing.Point(151, 195)
        Me.Rb2.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb2.Name = "Rb2"
        Me.Rb2.Size = New System.Drawing.Size(58, 19)
        Me.Rb2.TabIndex = 10
        Me.Rb2.TabStop = True
        Me.Rb2.Text = "店员"
        Me.Rb2.UseVisualStyleBackColor = True
        '
        'Rb1
        '
        Me.Rb1.AutoSize = True
        Me.Rb1.Location = New System.Drawing.Point(64, 195)
        Me.Rb1.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb1.Name = "Rb1"
        Me.Rb1.Size = New System.Drawing.Size(58, 19)
        Me.Rb1.TabIndex = 9
        Me.Rb1.Text = "经理"
        Me.Rb1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 195)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "类型："
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(151, 238)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 29)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "取消"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(27, 238)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 29)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "添加"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtPwd
        '
        Me.TxtPwd.Location = New System.Drawing.Point(64, 128)
        Me.TxtPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPwd.Name = "TxtPwd"
        Me.TxtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPwd.Size = New System.Drawing.Size(225, 25)
        Me.TxtPwd.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 131)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "密码："
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(64, 82)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(225, 25)
        Me.TxtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "用户名："
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "MName"
        Me.Column2.HeaderText = "用户名"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
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
        'DgvList
        '
        Me.DgvList.AllowUserToAddRows = False
        Me.DgvList.AllowUserToDeleteRows = False
        Me.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvList.Location = New System.Drawing.Point(4, 22)
        Me.DgvList.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvList.Name = "DgvList"
        Me.DgvList.ReadOnly = True
        Me.DgvList.RowHeadersWidth = 51
        Me.DgvList.RowTemplate.Height = 23
        Me.DgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvList.Size = New System.Drawing.Size(511, 326)
        Me.DgvList.TabIndex = 0
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "MType"
        Me.Column3.HeaderText = "类型"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvList)
        Me.GroupBox2.Location = New System.Drawing.Point(58, 49)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(519, 352)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "列表"
        '
        'FormManagerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormManagerInfo"
        Me.Text = "店员管理"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents label6 As Label
    Private WithEvents TxtId As TextBox
    Private WithEvents BtnRemove As Button
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Rb2 As RadioButton
    Private WithEvents Rb1 As RadioButton
    Private WithEvents Label3 As Label
    Private WithEvents BtnCancel As Button
    Private WithEvents BtnSave As Button
    Private WithEvents TxtPwd As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents TxtName As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents Column1 As DataGridViewTextBoxColumn
    Private WithEvents DgvList As DataGridView
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents GroupBox2 As GroupBox
End Class
