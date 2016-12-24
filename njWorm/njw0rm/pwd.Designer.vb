<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pwd
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyUSERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyPassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lv1 = New njw0rm.LV()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyUSERToolStripMenuItem, Me.CopyPassToolStripMenuItem, Me.CopyURLToolStripMenuItem, Me.VisitURLToolStripMenuItem, Me.SaveAllToolStripMenuItem, Me.SaveSelectedToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(121, 136)
        '
        'CopyUSERToolStripMenuItem
        '
        Me.CopyUSERToolStripMenuItem.Name = "CopyUSERToolStripMenuItem"
        Me.CopyUSERToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.CopyUSERToolStripMenuItem.Text = "Copy USER"
        '
        'CopyPassToolStripMenuItem
        '
        Me.CopyPassToolStripMenuItem.Name = "CopyPassToolStripMenuItem"
        Me.CopyPassToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.CopyPassToolStripMenuItem.Text = "Copy Pass"
        '
        'CopyURLToolStripMenuItem
        '
        Me.CopyURLToolStripMenuItem.Name = "CopyURLToolStripMenuItem"
        Me.CopyURLToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.CopyURLToolStripMenuItem.Text = "Copy URL"
        '
        'VisitURLToolStripMenuItem
        '
        Me.VisitURLToolStripMenuItem.Name = "VisitURLToolStripMenuItem"
        Me.VisitURLToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.VisitURLToolStripMenuItem.Text = "Visit URL"
        '
        'SaveAllToolStripMenuItem
        '
        Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
        Me.SaveAllToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.SaveAllToolStripMenuItem.Text = "Save All"
        '
        'SaveSelectedToolStripMenuItem
        '
        Me.SaveSelectedToolStripMenuItem.Name = "SaveSelectedToolStripMenuItem"
        Me.SaveSelectedToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.SaveSelectedToolStripMenuItem.Text = "Save Selected"
        '
        'Lv1
        '
        Me.Lv1.BackColor = System.Drawing.Color.Black
        Me.Lv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.Lv1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Lv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lv1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Lv1.ForeColor = System.Drawing.Color.IndianRed
        Me.Lv1.FullRowSelect = True
        Me.Lv1.Location = New System.Drawing.Point(0, 0)
        Me.Lv1.Name = "Lv1"
        Me.Lv1.Size = New System.Drawing.Size(647, 319)
        Me.Lv1.TabIndex = 1
        Me.Lv1.UseCompatibleStateImageBehavior = False
        Me.Lv1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "USER"
        Me.ColumnHeader1.Width = 101
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Password"
        Me.ColumnHeader2.Width = 88
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "URL"
        Me.ColumnHeader3.Width = 62
        '
        'pwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 319)
        Me.Controls.Add(Me.Lv1)
        Me.Name = "pwd"
        Me.Text = "password"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lv1 As njw0rm.LV
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyUSERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyPassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyURLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitURLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
