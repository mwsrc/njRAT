<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.T1 = New System.Windows.Forms.RichTextBox()
        Me.vmethod_8 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.T2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(405, 29)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Location = New System.Drawing.Point(324, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'T2
        '
        Me.T2.BackColor = System.Drawing.Color.Black
        Me.T2.ForeColor = System.Drawing.Color.Lime
        Me.T2.Location = New System.Drawing.Point(0, 0)
        Me.T2.Multiline = True
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(324, 29)
        Me.T2.TabIndex = 0
        '
        'T1
        '
        Me.T1.BackColor = System.Drawing.Color.Black
        Me.T1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.T1.ForeColor = System.Drawing.Color.Lime
        Me.T1.Location = New System.Drawing.Point(0, 0)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(405, 152)
        Me.T1.TabIndex = 1
        Me.T1.Text = ""
        '
        'vmethod_8
        '
        '
        'Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(405, 181)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Chat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents T1 As System.Windows.Forms.RichTextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents vmethod_8 As System.Windows.Forms.Timer
End Class
