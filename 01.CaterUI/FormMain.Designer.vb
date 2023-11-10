<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuManagerInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMemberInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDishInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTableInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TcHallInfo = New System.Windows.Forms.TabControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global._01.CaterUI.My.Resources.Resources.menuBg
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuManagerInfo, Me.MenuMemberInfo, Me.MenuDishInfo, Me.MenuTableInfo, Me.MenuOrder, Me.MenuQuit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 72)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuManagerInfo
        '
        Me.MenuManagerInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuManagerInfo.Image = Global._01.CaterUI.My.Resources.Resources.menuManager
        Me.MenuManagerInfo.Name = "MenuManagerInfo"
        Me.MenuManagerInfo.Size = New System.Drawing.Size(78, 68)
        Me.MenuManagerInfo.Text = "ToolStripMenuItem1"
        '
        'MenuMemberInfo
        '
        Me.MenuMemberInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuMemberInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuMemberInfo.Image = Global._01.CaterUI.My.Resources.Resources.menuMember
        Me.MenuMemberInfo.Name = "MenuMemberInfo"
        Me.MenuMemberInfo.Size = New System.Drawing.Size(78, 68)
        Me.MenuMemberInfo.Text = "ToolStripMenuItem2"
        '
        'MenuDishInfo
        '
        Me.MenuDishInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuDishInfo.Image = Global._01.CaterUI.My.Resources.Resources.menuDish
        Me.MenuDishInfo.Name = "MenuDishInfo"
        Me.MenuDishInfo.Size = New System.Drawing.Size(78, 68)
        Me.MenuDishInfo.Text = "ToolStripMenuItem3"
        '
        'MenuTableInfo
        '
        Me.MenuTableInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuTableInfo.Image = Global._01.CaterUI.My.Resources.Resources.menuTable
        Me.MenuTableInfo.Name = "MenuTableInfo"
        Me.MenuTableInfo.Size = New System.Drawing.Size(78, 68)
        Me.MenuTableInfo.Text = "ToolStripMenuItem4"
        '
        'MenuOrder
        '
        Me.MenuOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuOrder.Image = Global._01.CaterUI.My.Resources.Resources.menuOrder
        Me.MenuOrder.Name = "MenuOrder"
        Me.MenuOrder.Size = New System.Drawing.Size(78, 68)
        Me.MenuOrder.Text = "ToolStripMenuItem5"
        '
        'MenuQuit
        '
        Me.MenuQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuQuit.Image = Global._01.CaterUI.My.Resources.Resources.menuQuit
        Me.MenuQuit.Name = "MenuQuit"
        Me.MenuQuit.Size = New System.Drawing.Size(78, 68)
        Me.MenuQuit.Text = "ToolStripMenuItem6"
        '
        'TcHallInfo
        '
        Me.TcHallInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcHallInfo.Location = New System.Drawing.Point(0, 72)
        Me.TcHallInfo.Name = "TcHallInfo"
        Me.TcHallInfo.SelectedIndex = 0
        Me.TcHallInfo.Size = New System.Drawing.Size(800, 378)
        Me.TcHallInfo.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "desk1.png")
        Me.ImageList1.Images.SetKeyName(1, "desk2.png")
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TcHallInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormMain"
        Me.Text = "餐饮管理"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents MenuStrip1 As MenuStrip
    Private WithEvents MenuManagerInfo As ToolStripMenuItem
    Private WithEvents MenuMemberInfo As ToolStripMenuItem
    Private WithEvents MenuDishInfo As ToolStripMenuItem
    Private WithEvents MenuTableInfo As ToolStripMenuItem
    Private WithEvents MenuOrder As ToolStripMenuItem
    Private WithEvents MenuQuit As ToolStripMenuItem
    Private WithEvents TcHallInfo As TabControl
    Friend WithEvents ImageList1 As ImageList
End Class
