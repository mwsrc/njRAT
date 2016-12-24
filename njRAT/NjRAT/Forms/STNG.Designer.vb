<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STNG
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
        Me.ShowAlert = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LOGLOGIN = New System.Windows.Forms.CheckBox()
        Me.LOGCONNECTIONS = New System.Windows.Forms.CheckBox()
        Me.LOGLERR = New System.Windows.Forms.CheckBox()
        Me.LOGRERR = New System.Windows.Forms.CheckBox()
        Me.LOGMSGS = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SCI = New System.Windows.Forms.ComboBox()
        Me.SCAUT = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CAMI = New System.Windows.Forms.ComboBox()
        Me.CAMAUT = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MICI = New System.Windows.Forms.ComboBox()
        Me.MICAUT = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.scrI = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShowAlert)
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(124, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(117, 31)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OnLogin"
        '
        'ShowAlert
        '
        Me.ShowAlert.AutoSize = True
        Me.ShowAlert.Location = New System.Drawing.Point(6, 11)
        Me.ShowAlert.Name = "ShowAlert"
        Me.ShowAlert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowAlert.Size = New System.Drawing.Size(78, 17)
        Me.ShowAlert.TabIndex = 0
        Me.ShowAlert.Text = "Show Alert"
        Me.ShowAlert.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LOGLOGIN)
        Me.GroupBox2.Controls.Add(Me.LOGCONNECTIONS)
        Me.GroupBox2.Controls.Add(Me.LOGLERR)
        Me.GroupBox2.Controls.Add(Me.LOGRERR)
        Me.GroupBox2.Controls.Add(Me.LOGMSGS)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(124, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(117, 101)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Logs"
        '
        'LOGLOGIN
        '
        Me.LOGLOGIN.AutoSize = True
        Me.LOGLOGIN.Location = New System.Drawing.Point(5, 14)
        Me.LOGLOGIN.Name = "LOGLOGIN"
        Me.LOGLOGIN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LOGLOGIN.Size = New System.Drawing.Size(73, 17)
        Me.LOGLOGIN.TabIndex = 5
        Me.LOGLOGIN.Text = "Login/Out"
        Me.LOGLOGIN.UseVisualStyleBackColor = True
        '
        'LOGCONNECTIONS
        '
        Me.LOGCONNECTIONS.AutoSize = True
        Me.LOGCONNECTIONS.Location = New System.Drawing.Point(5, 30)
        Me.LOGCONNECTIONS.Name = "LOGCONNECTIONS"
        Me.LOGCONNECTIONS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LOGCONNECTIONS.Size = New System.Drawing.Size(85, 17)
        Me.LOGCONNECTIONS.TabIndex = 4
        Me.LOGCONNECTIONS.Text = "Connections"
        Me.LOGCONNECTIONS.UseVisualStyleBackColor = True
        '
        'LOGLERR
        '
        Me.LOGLERR.AutoSize = True
        Me.LOGLERR.Location = New System.Drawing.Point(5, 46)
        Me.LOGLERR.Name = "LOGLERR"
        Me.LOGLERR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LOGLERR.Size = New System.Drawing.Size(90, 17)
        Me.LOGLERR.TabIndex = 3
        Me.LOGLERR.Text = "Listner Errors"
        Me.LOGLERR.UseVisualStyleBackColor = True
        '
        'LOGRERR
        '
        Me.LOGRERR.AutoSize = True
        Me.LOGRERR.Location = New System.Drawing.Point(5, 63)
        Me.LOGRERR.Name = "LOGRERR"
        Me.LOGRERR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LOGRERR.Size = New System.Drawing.Size(95, 17)
        Me.LOGRERR.TabIndex = 2
        Me.LOGRERR.Text = "Remote Errors"
        Me.LOGRERR.UseVisualStyleBackColor = True
        '
        'LOGMSGS
        '
        Me.LOGMSGS.AutoSize = True
        Me.LOGMSGS.Location = New System.Drawing.Point(5, 80)
        Me.LOGMSGS.Name = "LOGMSGS"
        Me.LOGMSGS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LOGMSGS.Size = New System.Drawing.Size(73, 17)
        Me.LOGMSGS.TabIndex = 1
        Me.LOGMSGS.Text = "Messages"
        Me.LOGMSGS.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.SCI)
        Me.GroupBox3.Controls.Add(Me.SCAUT)
        Me.GroupBox3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox3.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(115, 64)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Remote Desktop"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Size"
        '
        'SCI
        '
        Me.SCI.BackColor = System.Drawing.Color.Black
        Me.SCI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SCI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SCI.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.SCI.FormattingEnabled = True
        Me.SCI.Items.AddRange(New Object() {"%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55", "%50"})
        Me.SCI.Location = New System.Drawing.Point(38, 36)
        Me.SCI.Name = "SCI"
        Me.SCI.Size = New System.Drawing.Size(71, 21)
        Me.SCI.TabIndex = 2
        '
        'SCAUT
        '
        Me.SCAUT.AutoSize = True
        Me.SCAUT.Location = New System.Drawing.Point(6, 19)
        Me.SCAUT.Name = "SCAUT"
        Me.SCAUT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SCAUT.Size = New System.Drawing.Size(73, 17)
        Me.SCAUT.TabIndex = 1
        Me.SCAUT.Text = "AutoStart"
        Me.SCAUT.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.CAMI)
        Me.GroupBox4.Controls.Add(Me.CAMAUT)
        Me.GroupBox4.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox4.Location = New System.Drawing.Point(3, 68)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(115, 64)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Remote Cam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Size"
        '
        'CAMI
        '
        Me.CAMI.BackColor = System.Drawing.Color.Black
        Me.CAMI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CAMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CAMI.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.CAMI.FormattingEnabled = True
        Me.CAMI.Items.AddRange(New Object() {"%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55", "%50"})
        Me.CAMI.Location = New System.Drawing.Point(38, 36)
        Me.CAMI.Name = "CAMI"
        Me.CAMI.Size = New System.Drawing.Size(71, 21)
        Me.CAMI.TabIndex = 2
        '
        'CAMAUT
        '
        Me.CAMAUT.AutoSize = True
        Me.CAMAUT.Location = New System.Drawing.Point(6, 19)
        Me.CAMAUT.Name = "CAMAUT"
        Me.CAMAUT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CAMAUT.Size = New System.Drawing.Size(73, 17)
        Me.CAMAUT.TabIndex = 1
        Me.CAMAUT.Text = "AutoStart"
        Me.CAMAUT.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.MICI)
        Me.GroupBox5.Controls.Add(Me.MICAUT)
        Me.GroupBox5.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox5.Location = New System.Drawing.Point(3, 137)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(115, 64)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Remote MIC"
        '
        'MICI
        '
        Me.MICI.BackColor = System.Drawing.Color.Black
        Me.MICI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MICI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MICI.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.MICI.FormattingEnabled = True
        Me.MICI.Items.AddRange(New Object() {"4 kb 8bit", "6 kb 8bit", "8 kb 8bit", "8 kb 16bit", "12 kb 16bit", "16 kb 16bit", "20 kb 16bit", "24 kb 16bit"})
        Me.MICI.Location = New System.Drawing.Point(6, 36)
        Me.MICI.Name = "MICI"
        Me.MICI.Size = New System.Drawing.Size(103, 21)
        Me.MICI.TabIndex = 2
        '
        'MICAUT
        '
        Me.MICAUT.AutoSize = True
        Me.MICAUT.Location = New System.Drawing.Point(6, 19)
        Me.MICAUT.Name = "MICAUT"
        Me.MICAUT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MICAUT.Size = New System.Drawing.Size(73, 17)
        Me.MICAUT.TabIndex = 1
        Me.MICAUT.Text = "AutoStart"
        Me.MICAUT.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.scrI)
        Me.GroupBox6.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox6.Location = New System.Drawing.Point(124, 138)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox6.Size = New System.Drawing.Size(117, 64)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Screen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Refresh Speed"
        '
        'scrI
        '
        Me.scrI.BackColor = System.Drawing.Color.Black
        Me.scrI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.scrI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scrI.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.scrI.FormattingEnabled = True
        Me.scrI.Items.AddRange(New Object() {"Ultra", "Fast", "Good", "Slow", "Slower"})
        Me.scrI.Location = New System.Drawing.Point(6, 36)
        Me.scrI.Name = "scrI"
        Me.scrI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.scrI.Size = New System.Drawing.Size(105, 21)
        Me.scrI.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Location = New System.Drawing.Point(3, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(238, 25)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'STNG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(244, 231)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "STNG"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ShowAlert As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LOGMSGS As System.Windows.Forms.CheckBox
    Friend WithEvents LOGRERR As System.Windows.Forms.CheckBox
    Friend WithEvents LOGCONNECTIONS As System.Windows.Forms.CheckBox
    Friend WithEvents LOGLERR As System.Windows.Forms.CheckBox
    Friend WithEvents LOGLOGIN As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SCAUT As System.Windows.Forms.CheckBox
    Friend WithEvents SCI As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CAMI As System.Windows.Forms.ComboBox
    Friend WithEvents CAMAUT As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents MICI As System.Windows.Forms.ComboBox
    Friend WithEvents MICAUT As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents scrI As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
