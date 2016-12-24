Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices

Public NotInheritable Class GClass3
    ' Methods
    Public Sub New(ByVal string_3 As String)
        Me.New(string_3, GClass3.int_20)
    End Sub

    Public Sub New(ByVal string_3 As String, ByVal int_26 As Integer)
        Me.fileStream_0 = Nothing
        Me.gclass5_0 = Nothing
        Me.object_0 = RuntimeHelpers.GetObjectValue(New Object)
        Me.byte_0 = Convert.ToByte(GClass5.int_0)
        Me.int_3 = 0
        Try
            Dim expression As Object = Me.object_0
            ObjectFlowControl.CheckForSyncLockOnValueType(expression)
            SyncLock expression
                Me.fileStream_0 = New FileStream(string_3, FileMode.Open, FileAccess.Read)
            End SyncLock
            Me.int_2 = int_26
            Me.method_0()
        Catch exception1 As SystemException
            ProjectData.SetProjectError(exception1)
            Dim exception As SystemException = exception1
            Console.Write(("cannot open file " & string_3 & ChrW(10)))
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub method_0()
        Dim array As Byte() = New Byte(3 - 1) {}
        Dim buffer As Byte() = New Byte(((GClass3.int_9 - 1) + 1) - 1) {}
        Me.byte_0 = CByte(GClass5.int_0)
        Me.int_1 = GClass3.int_10
        Dim expression As Object = Me.object_0
        ObjectFlowControl.CheckForSyncLockOnValueType(expression)
        SyncLock expression
            Me.fileStream_0.Seek(-3, SeekOrigin.End)
            Dim num4 As Integer = (GClass3.int_6 - 1)
            Dim i As Integer = 0
            Do While (i <= num4)
                Me.fileStream_0.Read(array, 0, 3)
                If (((array(0) = &HFF) AndAlso (array(1) = &HFF)) AndAlso (array(2) = &HFF)) Then
                    Me.byte_0 = Convert.ToByte(Me.fileStream_0.ReadByte)
                    If (Me.byte_0 >= &H6A) Then
                        Me.byte_0 = CByte((Me.byte_0 - &H69))
                    End If
                    If (Me.byte_0 = GClass5.int_1) Then
                        Me.int_0 = New Integer() {GClass3.int_15}
                        Me.int_1 = GClass3.int_10
                    ElseIf (Me.byte_0 = GClass5.int_2) Then
                        Me.int_0 = New Integer() {GClass3.int_16}
                        Me.int_1 = GClass3.int_10
                    ElseIf (((((Me.byte_0 = GClass5.int_3) OrElse (Me.byte_0 = GClass5.int_4)) OrElse ((Me.byte_0 = GClass5.int_5) OrElse (Me.byte_0 = GClass5.int_14))) OrElse (((Me.byte_0 = GClass5.int_6) OrElse (Me.byte_0 = GClass5.int_13)) OrElse ((Me.byte_0 = GClass5.int_8) OrElse (Me.byte_0 = GClass5.int_12)))) OrElse (((Me.byte_0 = GClass5.int_18) OrElse (Me.byte_0 = GClass5.int_19)) OrElse ((Me.byte_0 = GClass5.int_17) OrElse (Me.byte_0 = GClass5.int_16)))) Then
                        Me.int_0 = New Integer() {0}
                        If ((((Me.byte_0 = GClass5.int_3) OrElse (Me.byte_0 = GClass5.int_4)) OrElse ((Me.byte_0 = GClass5.int_12) OrElse (Me.byte_0 = GClass5.int_18))) OrElse (((Me.byte_0 = GClass5.int_19) OrElse (Me.byte_0 = GClass5.int_17)) OrElse ((Me.byte_0 = GClass5.int_16) OrElse (Me.byte_0 = GClass5.int_8)))) Then
                            Me.int_1 = GClass3.int_10
                        Else
                            Me.int_1 = GClass3.int_11
                        End If
                        Me.fileStream_0.Read(buffer, 0, GClass3.int_9)
                        Dim num5 As Integer = (GClass3.int_9 - 1)
                        Dim j As Integer = 0
                        Do While (j <= num5)
                            Dim index As Integer = 0
                            Me.int_0(index) = (Me.int_0(index) + (GClass3.smethod_2(buffer(j)) << (j * 8)))
                            j += 1
                        Loop
                    End If
                    Exit Do
                End If
                Me.fileStream_0.Seek(-4, SeekOrigin.Current)
                i += 1
            Loop
            If (((Me.byte_0 = GClass5.int_0) OrElse (Me.byte_0 = GClass5.int_11)) OrElse ((Me.byte_0 = GClass5.int_7) OrElse (Me.byte_0 = GClass5.int_9))) Then
                Me.int_0 = New Integer() {GClass3.int_4}
                Me.int_1 = GClass3.int_10
            End If
            If ((Me.int_2 And GClass3.int_21) = 1) Then
                Dim length As Integer = CInt(Me.fileStream_0.Length)
                Me.byte_1 = New Byte(((length - 1) + 1) - 1) {}
                Me.fileStream_0.Seek(0, SeekOrigin.Begin)
                Me.fileStream_0.Read(Me.byte_1, 0, length)
            End If
        End SyncLock
    End Sub

    Public Sub method_1()
        Try
            Dim expression As Object = Me.object_0
            ObjectFlowControl.CheckForSyncLockOnValueType(expression)
            SyncLock expression
                Me.fileStream_0.Close()
            End SyncLock
            Me.fileStream_0 = Nothing
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Function method_10() As GClass5
        If (Not Me.gclass5_0 Is Nothing) Then
            Return Me.gclass5_0
        End If
        Try
            Dim expression As Object = Me.object_0
            ObjectFlowControl.CheckForSyncLockOnValueType(expression)
            SyncLock expression
                Dim flag As Boolean = False
                Dim array As Byte() = New Byte(3 - 1) {}
                Me.fileStream_0.Seek(-3, SeekOrigin.End)
                Dim num4 As Integer = (GClass3.int_6 - 1)
                Dim i As Integer = 0
                Do While (i <= num4)
                    Me.fileStream_0.Read(array, 0, 3)
                    If (((array(0) = &HFF) AndAlso (array(1) = &HFF)) AndAlso (array(2) = &HFF)) Then
                        flag = True
                        Exit Do
                    End If
                    Me.fileStream_0.Seek(-4, SeekOrigin.Current)
                    i += 1
                Loop
                If flag Then
                    Me.fileStream_0.Seek(-6, SeekOrigin.Current)
                Else
                    Me.fileStream_0.Seek(-3, SeekOrigin.End)
                End If
                Dim num5 As Integer = (GClass3.int_7 - 1)
                Dim j As Integer = 0
                Do While (j <= num5)
                    Me.fileStream_0.Read(array, 0, 3)
                    If (((array(0) = 0) AndAlso (array(1) = 0)) AndAlso (array(2) = 0)) Then
                        Dim buffer2 As Byte() = New Byte(((j - 1) + 1) - 1) {}
                        Dim chArray As Char() = New Char(((j - 1) + 1) - 1) {}
                        Me.fileStream_0.Read(buffer2, 0, j)
                        Dim num6 As Integer = (j - 1)
                        Dim k As Integer = 0
                        Do While (k <= num6)
                            chArray(k) = Convert.ToChar(buffer2(k))
                            k += 1
                        Loop
                        Me.gclass5_0 = New GClass5(New String(chArray))
                        Return Me.gclass5_0
                    End If
                    Me.fileStream_0.Seek(-4, SeekOrigin.Current)
                    j += 1
                Loop
            End SyncLock
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Console.Write(exception.Message)
            ProjectData.ClearProjectError()
        End Try
        Return New GClass5(String.Empty)
    End Function

    Public Function method_11(ByVal ipaddress_0 As IPAddress) As GClass6
        Return Me.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress_0.GetAddressBytes)))
    End Function

    Public Function method_12(ByVal string_3 As String) As GClass6
        Dim address As IPAddress
        Try
            address = IPAddress.Parse(string_3)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Console.Write(exception.Message)
            ProjectData.ClearProjectError()
            Return Nothing
        End Try
        Return Me.method_12(Conversions.ToString(GClass3.smethod_1(address.GetAddressBytes)))
    End Function

    Public Function method_13(ByVal ipaddress_0 As IPAddress) As String
        Return Me.method_17(GClass3.smethod_1(ipaddress_0.GetAddressBytes))
    End Function

    Public Function method_14(ByVal string_3 As String) As String
        Dim address As IPAddress
        Try
            address = IPAddress.Parse(string_3)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Console.Write(exception.Message)
            ProjectData.ClearProjectError()
            Return Nothing
        End Try
        Return Me.method_16(address)
    End Function

    Public Function method_15(ByVal string_3 As String) As String
        Dim address As IPAddress
        Try
            address = IPAddress.Parse(string_3)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Console.Write(exception.Message)
            ProjectData.ClearProjectError()
            Return Nothing
        End Try
        Return Me.method_17(GClass3.smethod_1(address.GetAddressBytes))
    End Function

    <MethodImpl(MethodImplOptions.Synchronized)> _
    Public Function method_16(ByVal ipaddress_0 As IPAddress) As String
        Dim str As String
        Dim index As Integer = 0
        Dim destinationArray As Byte() = New Byte(((GClass3.int_13 - 1) + 1) - 1) {}
        Dim chArray As Char() = New Char(((GClass3.int_13 - 1) + 1) - 1) {}
        Try
            Dim num2 As Integer = Me.method_18(ipaddress_0)
            If (num2 = Me.int_0(0)) Then
                Return Nothing
            End If
            Dim sourceIndex As Integer = (num2 + (((2 * Me.int_1) - 1) * Me.int_0(0)))
            If ((Me.int_2 And GClass3.int_21) = 1) Then
                Array.Copy(Me.byte_1, sourceIndex, destinationArray, 0, Math.Min((Me.byte_1.Length - sourceIndex), GClass3.int_13))
            Else
                Dim expression As Object = Me.object_0
                ObjectFlowControl.CheckForSyncLockOnValueType(expression)
                SyncLock expression
                    Me.fileStream_0.Seek(CLng(sourceIndex), SeekOrigin.Begin)
                    Me.fileStream_0.Read(destinationArray, 0, GClass3.int_13)
                End SyncLock
            End If
            Do While (destinationArray(index) <> 0)
                chArray(index) = Convert.ToChar(destinationArray(index))
                index += 1
            Loop
            chArray(index) = ChrW(0)
            str = New String(chArray, 0, index)
        Catch exception1 As IOException
            ProjectData.SetProjectError(exception1)
            Dim exception As IOException = exception1
            Console.Write("IO Exception")
            str = Nothing
            ProjectData.ClearProjectError()
        End Try
        Return str
    End Function

    <MethodImpl(MethodImplOptions.Synchronized)> _
    Public Function method_17(ByVal long_0 As Long) As String
        Dim str As String
        Dim index As Integer = 0
        Dim destinationArray As Byte() = New Byte(((GClass3.int_13 - 1) + 1) - 1) {}
        Dim chArray As Char() = New Char(((GClass3.int_13 - 1) + 1) - 1) {}
        Try
            Dim num2 As Integer = Me.method_19(long_0)
            If (num2 = Me.int_0(0)) Then
                Return Nothing
            End If
            Dim sourceIndex As Integer = (num2 + (((2 * Me.int_1) - 1) * Me.int_0(0)))
            If ((Me.int_2 And GClass3.int_21) = 1) Then
                Array.Copy(Me.byte_1, sourceIndex, destinationArray, 0, Math.Min((Me.byte_1.Length - sourceIndex), GClass3.int_13))
            Else
                Dim expression As Object = Me.object_0
                ObjectFlowControl.CheckForSyncLockOnValueType(expression)
                SyncLock expression
                    Me.fileStream_0.Seek(CLng(sourceIndex), SeekOrigin.Begin)
                    Me.fileStream_0.Read(destinationArray, 0, GClass3.int_13)
                End SyncLock
            End If
            Do While (destinationArray(index) <> 0)
                chArray(index) = Convert.ToChar(destinationArray(index))
                index += 1
            Loop
            chArray(index) = ChrW(0)
            str = New String(chArray, 0, index)
        Catch exception1 As IOException
            ProjectData.SetProjectError(exception1)
            Dim exception As IOException = exception1
            Console.Write("IO Exception")
            str = Nothing
            ProjectData.ClearProjectError()
        End Try
        Return str
    End Function

    <MethodImpl(MethodImplOptions.Synchronized)> _
    Private Function method_18(ByVal ipaddress_0 As IPAddress) As Integer
        Dim addressBytes As Byte() = ipaddress_0.GetAddressBytes
        Dim array As Byte() = New Byte((((2 * GClass3.int_12) - 1) + 1) - 1) {}
        Dim numArray As Integer() = New Integer(2 - 1) {}
        Dim num As Integer = 0
        Dim num5 As Integer = &H7F
        Do
            Try
                If ((Me.int_2 And GClass3.int_21) = 1) Then
                    Dim num11 As Integer = ((2 * GClass3.int_12) - 1)
                    Dim i As Integer = 0
                    Do While (i <= num11)
                        array(i) = Me.byte_1((i + ((2 * Me.int_1) * num)))
                        i += 1
                    Loop
                Else
                    Dim expression As Object = Me.object_0
                    ObjectFlowControl.CheckForSyncLockOnValueType(expression)
                    SyncLock expression
                        Me.fileStream_0.Seek(CLng(((2 * Me.int_1) * num)), SeekOrigin.Begin)
                        Me.fileStream_0.Read(array, 0, (2 * GClass3.int_12))
                    End SyncLock
                End If
            Catch exception1 As IOException
                ProjectData.SetProjectError(exception1)
                Dim exception As IOException = exception1
                Console.Write("IO Exception")
                ProjectData.ClearProjectError()
            End Try
            Dim index As Integer = 0
            Do
                numArray(index) = 0
                Dim num12 As Integer = (Me.int_1 - 1)
                Dim j As Integer = 0
                Do While (j <= num12)
                    Dim num10 As Integer = array(((index * Me.int_1) + j))
                    If (num10 < 0) Then
                        num10 = (num10 + &H100)
                    End If
                    Dim num13 As Integer = index
                    numArray(num13) = (numArray(num13) + (num10 << (j * 8)))
                    j += 1
                Loop
                index += 1
            Loop While (index <= 1)
            Dim num4 As Integer = (&H7F - num5)
            Dim num6 As Integer = (num4 >> 3)
            Dim num3 As Integer = (CInt(1) << ((num4 And 7) Xor 7))
            If ((addressBytes(num6) And num3) > 0) Then
                If (numArray(1) >= Me.int_0(0)) Then
                    Return numArray(1)
                End If
                num = numArray(1)
            Else
                If (numArray(0) >= Me.int_0(0)) Then
                    Return numArray(0)
                End If
                num = numArray(0)
            End If
            num5 = (num5 + -1)
        Loop While (num5 >= 0)
        Console.Write(("Error Seeking country while Seeking " & Convert.ToString(ipaddress_0)))
        Return 0
    End Function

    <MethodImpl(MethodImplOptions.Synchronized)> _
    Private Function method_19(ByVal long_0 As Long) As Integer
        Dim array As Byte() = New Byte((((2 * GClass3.int_12) - 1) + 1) - 1) {}
        Dim numArray As Integer() = New Integer(2 - 1) {}
        Dim num As Integer = 0
        Dim num3 As Integer = &H1F
        Do
            Try
                If ((Me.int_2 And GClass3.int_21) = 1) Then
                    Dim num8 As Integer = ((2 * GClass3.int_12) - 1)
                    Dim i As Integer = 0
                    Do While (i <= num8)
                        array(i) = Me.byte_1((i + ((2 * Me.int_1) * num)))
                        i += 1
                    Loop
                Else
                    Dim expression As Object = Me.object_0
                    ObjectFlowControl.CheckForSyncLockOnValueType(expression)
                    SyncLock expression
                        Me.fileStream_0.Seek(CLng(((2 * Me.int_1) * num)), SeekOrigin.Begin)
                        Me.fileStream_0.Read(array, 0, (2 * GClass3.int_12))
                    End SyncLock
                End If
            Catch exception1 As IOException
                ProjectData.SetProjectError(exception1)
                Dim exception As IOException = exception1
                Console.Write("IO Exception")
                ProjectData.ClearProjectError()
            End Try
            Dim index As Integer = 0
            Do
                numArray(index) = 0
                Dim num9 As Integer = (Me.int_1 - 1)
                Dim j As Integer = 0
                Do While (j <= num9)
                    Dim num7 As Integer = array(((index * Me.int_1) + j))
                    If (num7 < 0) Then
                        num7 = (num7 + &H100)
                    End If
                    Dim num10 As Integer = index
                    numArray(num10) = (numArray(num10) + (num7 << (j * 8)))
                    j += 1
                Loop
                index += 1
            Loop While (index <= 1)
            If ((long_0 And (CInt(1) << num3)) > 0) Then
                If (numArray(1) >= Me.int_0(0)) Then
                    Return numArray(1)
                End If
                num = numArray(1)
            Else
                If (numArray(0) >= Me.int_0(0)) Then
                    Return numArray(0)
                End If
                num = numArray(0)
            End If
            num3 = (num3 + -1)
        Loop While (num3 >= 0)
        Console.Write(("Error Seeking country while Seeking " & Conversions.ToString(long_0)))
        Return 0
    End Function

    Public Function method_2(ByVal ipaddress_0 As IPAddress) As GClass4
        Return Me.method_6(GClass3.smethod_1(ipaddress_0.GetAddressBytes))
    End Function

    Public Function method_3(ByVal string_3 As String) As GClass4
        Dim address As IPAddress
        Try
            address = IPAddress.Parse(string_3)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Console.Write(exception.Message)
            Dim class2 As GClass4 = GClass3.gclass4_0
            ProjectData.ClearProjectError()
            Return class2
        End Try
        Return Me.method_5(address)
    End Function

    Public Function method_4(ByVal string_3 As String) As GClass4
        Dim address As IPAddress
        Try
            address = IPAddress.Parse(string_3)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Console.Write(exception.Message)
            Dim class2 As GClass4 = GClass3.gclass4_0
            ProjectData.ClearProjectError()
            Return class2
        End Try
        Return Me.method_6(GClass3.smethod_1(address.GetAddressBytes))
    End Function

    Public Function method_5(ByVal ipaddress_0 As IPAddress) As GClass4
        If (Me.fileStream_0 Is Nothing) Then
            Throw New Exception("Database has been closed.")
        End If
        If ((Me.byte_0 = GClass5.int_4) Or (Me.byte_0 = GClass5.int_3)) Then
            Dim class3 As GClass6 = Me.method_11(ipaddress_0)
            If (class3 Is Nothing) Then
                Return GClass3.gclass4_0
            End If
            Return New GClass4(class3.string_0, class3.string_1)
        End If
        Dim index As Integer = (Me.method_18(ipaddress_0) - GClass3.int_4)
        If (index = 0) Then
            Return GClass3.gclass4_0
        End If
        Return New GClass4(GClass3.string_1(index), GClass3.string_2(index))
    End Function

    Public Function method_6(ByVal long_0 As Long) As GClass4
        If (Me.fileStream_0 Is Nothing) Then
            Throw New Exception("Database has been closed.")
        End If
        If ((Me.byte_0 = GClass5.int_4) Or (Me.byte_0 = GClass5.int_3)) Then
            Dim class3 As GClass6 = Me.method_12(Conversions.ToString(long_0))
            If (class3 Is Nothing) Then
                Return GClass3.gclass4_0
            End If
            Return New GClass4(class3.string_0, class3.string_1)
        End If
        Dim index As Integer = (Me.method_19(long_0) - GClass3.int_4)
        If (index = 0) Then
            Return GClass3.gclass4_0
        End If
        Return New GClass4(GClass3.string_1(index), GClass3.string_2(index))
    End Function

    Public Function method_7(ByVal string_3 As String) As Integer
        Dim address As IPAddress
        Try
            address = IPAddress.Parse(string_3)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Console.Write(exception.Message)
            ProjectData.ClearProjectError()
            Return 0
        End Try
        Return Me.method_9(GClass3.smethod_1(address.GetAddressBytes))
    End Function

    Public Function method_8(ByVal ipaddress_0 As IPAddress) As Integer
        Return Me.method_9(GClass3.smethod_1(ipaddress_0.GetAddressBytes))
    End Function

    Public Function method_9(ByVal long_0 As Long) As Integer
        If (Me.fileStream_0 Is Nothing) Then
            Throw New Exception("Database has been closed.")
        End If
        Return (Me.method_19(long_0) - Me.int_0(0))
    End Function

    Private Shared Function smethod_0(ByVal long_0 As Long) As Long
        Return ((((((long_0 >> 0) And &HFF) << &H18) Or (((long_0 >> 8) And &HFF) << &H10)) Or (((long_0 >> &H10) And &HFF) << 8)) Or (((long_0 >> &H18) And &HFF) << 0))
    End Function

    Private Shared Function smethod_1(ByVal byte_2 As Byte()) As Long
        Dim num2 As Long = 0
        Dim index As Integer = 0
        Do
            Dim num4 As Long = byte_2(index)
            If (num4 < 0) Then
                num4 = (num4 + &H100)
            End If
            num2 = (num2 + (num4 << ((3 - index) * 8)))
            index += 1
        Loop While (index <= 3)
        Return num2
    End Function

    Private Shared Function smethod_2(ByVal byte_2 As Byte) As Integer
        Return (byte_2 And &HFF)
    End Function

    Private Shared Function smethod_3(Of T)(ByRef gparam_0 As T, ByVal gparam_1 As T) As T
        gparam_0 = gparam_1
        Return gparam_1
    End Function


    ' Fields
    Private byte_0 As Byte
    Private byte_1 As Byte()
    Private fileStream_0 As FileStream
    Private Shared gclass4_0 As GClass4 = New GClass4("--", "N/A")
    Private gclass5_0 As GClass5
    Private int_0 As Integer()
    Private int_1 As Integer
    Private Shared int_10 As Integer = 3
    Private Shared int_11 As Integer = 4
    Private Shared int_12 As Integer = 4
    Private Shared int_13 As Integer = &H3E8
    Private Shared int_14 As Integer = 360
    Private Shared int_15 As Integer = &HFED260
    Private Shared int_16 As Integer = &HF42400
    Private Shared int_17 As Integer = 1
    Private Shared int_18 As Integer = &H2A5
    Private Shared int_19 As Integer = &H549
    Private int_2 As Integer
    Public Shared int_20 As Integer = 0
    Public Shared int_21 As Integer = 1
    Public Shared int_22 As Integer = 0
    Public Shared int_23 As Integer = 1
    Public Shared int_24 As Integer = 2
    Public Shared int_25 As Integer = 3
    Private int_3 As Integer
    Private Shared int_4 As Integer = &HFFFF00
    Private Shared int_5 As Integer = &HFED260
    Private Shared int_6 As Integer = 20
    Private Shared int_7 As Integer = 100
    Private Shared int_8 As Integer = 100
    Private Shared int_9 As Integer = 3
    Private object_0 As Object
    Private string_0 As String
    Public Shared string_1 As String() = New String() {"--", "AP", "EU", "AD", "AE", "AF", "AG", "AI", "AL", "AM", "CW", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN", "BO", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "SX", "GA", "GB", "GD", "GE", "GF", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IN", "IO", "IQ", "IR", "IS", "IT", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TM", "TN", "TO", "TL", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "RS", "ZA", "ZM", "ME", "ZW", "A1", "A2", "O1", "AX", "GG", "IM", "JE", "BL", "MF", "BQ", "SS", "O1"}
    Private Shared string_2 As String() = New String() {"N/A", "Asia/Pacific Region", "Europe", "Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia", "Curacao", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Azerbaijan", "Bosnia and Herzegovina", "Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Bermuda", "Brunei Darussalam", "Bolivia", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos (Keeling) Islands", "Congo, The Democratic Republic of the", "Central African Republic", "Congo", "Switzerland", "Cote D'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia", "Costa Rica", "Cuba", "Cape Verde", "Christmas Island", "Cyprus", "Czech Republic", "Germany", "Djibouti", "Denmark", "Dominica", "Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland", "Fiji", "Falkland Islands (Malvinas)", "Micronesia, Federated States of", "Faroe Islands", "France", "Sint Maarten (Dutch part)", "Gabon", "United Kingdom", "Grenada", "Georgia", "French Guiana", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands", "Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary", "Indonesia", "Ireland", "Israel", "India", "British Indian Ocean Territory", "Iraq", "Iran, Islamic Republic of", "Iceland", "Italy", "Jamaica", "Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts and Nevis", "Korea, Democratic People's Republic of", "Korea, Republic of", "Kuwait", "Cayman Islands", "Kazakhstan", "Lao People's Democratic Republic", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho", "Lithuania", "Luxembourg", "Latvia", "Libya", "Morocco", "Monaco", "Moldova, Republic of", "Madagascar", "Marshall Islands", "Macedonia", "Mali", "Myanmar", "Mongolia", "Macau", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius", "Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria", "Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru", "French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn Islands", "Puerto Rico", "Palestinian Territory", "Portugal", "Palau", "Paraguay", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles", "Sudan", "Sweden", "Singapore", "Saint Helena", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal", "Somalia", "Suriname", "Sao Tome and Principe", "El Salvador", "Syrian Arab Republic", "Swaziland", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo", "Thailand", "Tajikistan", "Tokelau", "Turkmenistan", "Tunisia", "Tonga", "Timor-Leste", "Turkey", "Trinidad and Tobago", "Tuvalu", "Taiwan", "Tanzania, United Republic of", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States", "Uruguay", "Uzbekistan", "Holy See (Vatican City State)", "Saint Vincent and the Grenadines", "Venezuela", "Virgin Islands, British", "Virgin Islands, U.S.", "Vietnam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "Serbia", "South Africa", "Zambia", "Montenegro", "Zimbabwe", "Anonymous Proxy", "Satellite Provider", "Other", "Aland Islands", "Guernsey", "Isle of Man", "Jersey", "Saint Barthelemy", "Saint Martin", "Bonaire, Saint Eustatius and Saba", "South Sudan", "Other"}
End Class



