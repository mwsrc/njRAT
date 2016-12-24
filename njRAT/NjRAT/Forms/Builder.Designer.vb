<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Builder
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
        Me.host = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.port = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Idr = New System.Windows.Forms.CheckBox()
        Me.dir = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.exe = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VN = New System.Windows.Forms.TextBox()
        Me.bsod = New System.Windows.Forms.CheckBox()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.Isf = New System.Windows.Forms.CheckBox()
        Me.Isu = New System.Windows.Forms.CheckBox()
        Me.klen = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.klen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'host
        '
        Me.host.BackColor = System.Drawing.Color.Black
        Me.host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.host.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.host.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.host.Location = New System.Drawing.Point(4, 25)
        Me.host.Name = "host"
        Me.host.Size = New System.Drawing.Size(186, 20)
        Me.host.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Host"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Location = New System.Drawing.Point(193, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'port
        '
        Me.port.BackColor = System.Drawing.Color.Black
        Me.port.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.port.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.port.Location = New System.Drawing.Point(196, 25)
        Me.port.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(69, 20)
        Me.port.TabIndex = 3
        Me.port.Value = New Decimal(New Integer() {1177, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ExeName"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Idr)
        Me.GroupBox1.Controls.Add(Me.dir)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.exe)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Idr
        '
        Me.Idr.AutoSize = True
        Me.Idr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Idr.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Idr.Location = New System.Drawing.Point(196, 12)
        Me.Idr.Name = "Idr"
        Me.Idr.Size = New System.Drawing.Size(50, 17)
        Me.Idr.TabIndex = 14
        Me.Idr.Text = "Copy"
        Me.Idr.UseVisualStyleBackColor = True
        '
        'dir
        '
        Me.dir.BackColor = System.Drawing.Color.Black
        Me.dir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dir.Enabled = False
        Me.dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dir.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.dir.FormattingEnabled = True
        Me.dir.Items.AddRange(New Object() {"%TEMP%", "%AppData%", "%UserProfile%", "%AllUsersProfile%", "%WinDir%"})
        Me.dir.Location = New System.Drawing.Point(6, 73)
        Me.dir.Name = "dir"
        Me.dir.Size = New System.Drawing.Size(241, 22)
        Me.dir.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Location = New System.Drawing.Point(3, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Directory"
        '
        'exe
        '
        Me.exe.BackColor = System.Drawing.Color.Black
        Me.exe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.exe.Enabled = False
        Me.exe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exe.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.exe.Location = New System.Drawing.Point(6, 32)
        Me.exe.Name = "exe"
        Me.exe.Size = New System.Drawing.Size(241, 20)
        Me.exe.TabIndex = 5
        Me.exe.Text = "server.exe"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Location = New System.Drawing.Point(263, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 73)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Build"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBox1.Location = New System.Drawing.Point(271, 9)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(49, 18)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Icon"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(384, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Location = New System.Drawing.Point(7, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "VicTim Name"
        '
        'VN
        '
        Me.VN.BackColor = System.Drawing.Color.Black
        Me.VN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VN.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.VN.Location = New System.Drawing.Point(4, 65)
        Me.VN.Name = "VN"
        Me.VN.Size = New System.Drawing.Size(253, 20)
        Me.VN.TabIndex = 10
        Me.VN.Text = "HacKed"
        '
        'bsod
        '
        Me.bsod.AutoSize = True
        Me.bsod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bsod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsod.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.bsod.Location = New System.Drawing.Point(271, 28)
        Me.bsod.Name = "bsod"
        Me.bsod.Size = New System.Drawing.Size(155, 18)
        Me.bsod.TabIndex = 11
        Me.bsod.Text = "Protect Process [BSOD]"
        Me.bsod.UseVisualStyleBackColor = True
        '
        'T1
        '
        Me.T1.BackColor = System.Drawing.Color.Black
        Me.T1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.T1.Location = New System.Drawing.Point(104, 227)
        Me.T1.Multiline = True
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(100, 20)
        Me.T1.TabIndex = 12
        Me.T1.Visible = False
        '
        'Isf
        '
        Me.Isf.AutoSize = True
        Me.Isf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Isf.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Isf.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Isf.Location = New System.Drawing.Point(271, 48)
        Me.Isf.Name = "Isf"
        Me.Isf.Size = New System.Drawing.Size(113, 18)
        Me.Isf.TabIndex = 13
        Me.Isf.Text = "Copy To StartUp"
        Me.Isf.UseVisualStyleBackColor = True
        '
        'Isu
        '
        Me.Isu.AutoSize = True
        Me.Isu.Checked = True
        Me.Isu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Isu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Isu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Isu.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Isu.Location = New System.Drawing.Point(271, 68)
        Me.Isu.Name = "Isu"
        Me.Isu.Size = New System.Drawing.Size(106, 18)
        Me.Isu.TabIndex = 14
        Me.Isu.Text = "Registy StarUp"
        Me.Isu.UseVisualStyleBackColor = True
        '
        'klen
        '
        Me.klen.BackColor = System.Drawing.Color.Black
        Me.klen.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.klen.Location = New System.Drawing.Point(372, 86)
        Me.klen.Maximum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.klen.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.klen.Name = "klen"
        Me.klen.Size = New System.Drawing.Size(54, 20)
        Me.klen.TabIndex = 15
        Me.klen.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.Location = New System.Drawing.Point(268, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 14)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "KeyLogs Size KB"
        '
        'Builder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(430, 190)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.klen)
        Me.Controls.Add(Me.Isu)
        Me.Controls.Add(Me.Isf)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.bsod)
        Me.Controls.Add(Me.VN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.host)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Builder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Builder"
        CType(Me.port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.klen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents host As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents port As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents exe As System.Windows.Forms.TextBox
    Friend WithEvents dir As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VN As System.Windows.Forms.TextBox
    Friend WithEvents bsod As System.Windows.Forms.CheckBox
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Isf As System.Windows.Forms.CheckBox
    Friend WithEvents Idr As System.Windows.Forms.CheckBox
    Friend WithEvents Isu As System.Windows.Forms.CheckBox
    Friend WithEvents klen As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
