<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notf
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
        Me.p = New System.Windows.Forms.PictureBox()
        CType(Me.p, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p
        '
        Me.p.Cursor = System.Windows.Forms.Cursors.Hand
        Me.p.Dock = System.Windows.Forms.DockStyle.Fill
        Me.p.Location = New System.Drawing.Point(0, 0)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(267, 109)
        Me.p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p.TabIndex = 0
        Me.p.TabStop = False
        '
        'notf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(267, 109)
        Me.Controls.Add(Me.p)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "notf"
        Me.Opacity = 0.8R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "notf"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.p, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents p As System.Windows.Forms.PictureBox
End Class
