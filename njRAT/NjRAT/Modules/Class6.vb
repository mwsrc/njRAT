Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.IO.Compression
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Friend NotInheritable Class Class6
    <DllImport("msvcrt.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function memcpy(ByVal intptr_0 As IntPtr, ByVal intptr_1 As IntPtr, ByVal int_0 As Integer) As IntPtr
    End Function

    Public Shared Function smethod_0(ByVal int_0 As Integer, ByVal int_1 As Integer) As String
        If (int_1 = 0) Then
            Return "%00.0"
        End If
        Dim num As Double = (((Double.Parse(Conversions.ToString(int_0)) / Double.Parse(Conversions.ToString(int_1))) * 100) / 100)
        Return num.ToString("%00.0").Replace("100.0", "100")
    End Function

    Public Shared Function smethod_1(ByVal int_0 As Integer, ByVal int_1 As Integer) As Integer
        If (int_1 = 0) Then
            Return 0
        End If
        Return CInt(Math.Round(CDbl(((CDbl(int_0) / CDbl(int_1)) * 100))))
    End Function

    Public Shared Function smethod_10(ByVal string_0 As String) As Form
        Return My.Application.OpenForms.Item(string_0)
    End Function

    Public Shared Function smethod_11(ByRef string_0 As String) As Byte()
        Return Encoding.Default.GetBytes(string_0)
    End Function

    Public Shared Function smethod_12(ByRef byte_0 As Byte()) As String
        Return Encoding.Default.GetString(byte_0)
    End Function

    Public Shared Function smethod_13() As String
        Return My.Computer.Clock.LocalTime.ToString("[hh:mm:ss]")
    End Function

    Public Shared Function smethod_14(ByRef string_0 As String) As String
        Return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0))
    End Function

    Public Shared Function smethod_15(ByVal int_0 As Integer, ByVal int_1 As Integer, ByVal bool_0 As Boolean) As Integer
        Class6.long_0 = CLng(Math.Round(CDbl((Class6.long_0 + 333.33))))
        Dim random As New Random(CInt(Class6.long_0))
        Return random.Next(int_0, (int_1 + 1))
    End Function

    Public Shared Function smethod_16(ByVal string_0 As String) As String
        Dim num As Integer = 0
        Do While True
            Try
                Dim bytes As Byte() = Convert.FromBase64String(string_0)
                Return Encoding.UTF8.GetString(bytes)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                num += 1
                If (num = 3) Then
                    ProjectData.ClearProjectError()
                    Return Nothing
                End If
                string_0 = (string_0 & "=")
                ProjectData.ClearProjectError()
            End Try
        Loop
    End Function

    Public Shared Function smethod_17(ByVal long_1 As Long) As String
        If (long_1.ToString.Length < 4) Then
            Return (Conversions.ToString(long_1) & " Bytes")
        End If
        Dim str As String = String.Empty
        Dim num As Double = (CDbl(long_1) / 1024)
        If (num < 1024) Then
            str = "KB"
        Else
            num = (num / 1024)
            If (num < 1024) Then
                str = "MB"
            Else
                num = (num / 1024)
                str = "GB"
            End If
        End If
        Return (num.ToString(".0") & " " & str)
    End Function

    Public Shared Function smethod_2(ByVal string_0 As String, ByVal string_1 As String) As String
        Dim str As String
        Try
            str = Conversions.ToString(My.Computer.Registry.CurrentUser.OpenSubKey(("Software\" & Class7.string_0)).GetValue(string_0, string_1))
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            str = string_1
            ProjectData.ClearProjectError()
        End Try
        Return str
    End Function

    Public Shared Sub smethod_3(ByVal string_0 As String, ByVal string_1 As String)
        If (string_1 Is Nothing) Then
            string_1 = String.Empty
        End If
        Try
            My.Computer.Registry.CurrentUser.CreateSubKey(("Software\" & Class7.string_0)).SetValue(string_0, string_1)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Shared Function smethod_4(ByVal string_0 As String) As String
        Return Class6.smethod_5(Class6.smethod_11(string_0))
    End Function

    Public Shared Function smethod_5(ByVal byte_0 As Byte()) As String
        byte_0 = New MD5CryptoServiceProvider().ComputeHash(byte_0)
        Dim str As String = String.Empty
        Dim num2 As Byte
        For Each num2 In byte_0
            str = (str & num2.ToString("x2"))
        Next
        Return str
    End Function

    Public Shared Function smethod_6(ByVal int_0 As Integer) As String
        Dim random As New Random
        Dim str As String = String.Empty
        Dim str2 As String = "abcdefghijklmnopqrstuvwxyz"
        Dim num As Integer = int_0
        Dim i As Integer = 1
        Do While (i <= num)
            str = (str & Conversions.ToString(str2.Chars(random.Next(0, str2.Length))))
            i += 1
        Loop
        Return str
    End Function

    Public Shared Function smethod_7(ByVal string_0 As String, ByVal treeNodeCollection_0 As TreeNodeCollection) As TreeNode
        If string_0.EndsWith("\") Then
            string_0 = string_0.Remove((string_0.Length - 1), 1)
        End If
        Dim node As TreeNode = Nothing
        Dim str As String
        For Each str In Strings.Split(string_0, "\", -1, CompareMethod.Binary)
            node = treeNodeCollection_0.Item(str)
            treeNodeCollection_0 = node.Nodes
        Next
        Return node
    End Function

    Public Shared Function smethod_8(ByVal byte_0 As Byte(), ByRef bool_0 As Boolean) As Byte()
        If bool_0 Then
            Dim stream As New MemoryStream
            Dim stream2 As New GZipStream(stream, CompressionMode.Compress, True)
            stream2.Write(byte_0, 0, byte_0.Length)
            stream2.Dispose()
            stream.Position = 0
            Dim buffer As Byte() = New Byte((CInt(stream.Length) + 1) - 1) {}
            stream.Read(buffer, 0, buffer.Length)
            stream.Dispose()
            Return buffer
        End If
        Dim stream3 As New MemoryStream(byte_0)
        Dim stream4 As New GZipStream(stream3, CompressionMode.Decompress)
        Dim buffer2 As Byte() = New Byte(4 - 1) {}
        stream3.Position = (stream3.Length - 5)
        stream3.Read(buffer2, 0, 4)
        Dim count As Integer = BitConverter.ToInt32(buffer2, 0)
        stream3.Position = 0
        Dim array As Byte() = New Byte(((count - 1) + 1) - 1) {}
        stream4.Read(array, 0, count)
        stream4.Dispose()
        stream3.Dispose()
        Return array
    End Function

    Public Shared Function smethod_9(ByVal byte_0 As Byte(), ByVal string_0 As String) As Array
        Dim list As New List(Of Byte())
        Dim count As Integer = -1
        count = Array.IndexOf(Of Byte)(byte_0, CByte(Strings.Asc(string_0.Chars(0))))
        Do While True
            If Not ((count > -1) And ((count + string_0.Length) <= byte_0.Length)) Then
                Exit Do
            End If
            Dim buffer As Byte() = New Byte(((string_0.Length - 1) + 1) - 1) {}
            Dim index As Integer = 0
            Dim num3 As Integer = ((count + string_0.Length) - 1)
            Dim i As Integer = count
            Do While (i <= num3)
                buffer(index) = byte_0(i)
                index += 1
                i += 1
            Loop
            If (Class6.smethod_12(buffer) = string_0) Then
                Dim stream As New MemoryStream
                stream.Write(byte_0, 0, count)
                list.Add(stream.ToArray)
                stream.Dispose()
                stream = New MemoryStream
                stream.Write(byte_0, (count + string_0.Length), (byte_0.Length - (count + string_0.Length)))
                list.Add(stream.ToArray)
                stream.Dispose()
                Exit Do
            End If
            count = Array.IndexOf(Of Byte)(byte_0, CByte(Strings.Asc(string_0.Chars(0))), (count + 1))
        Loop
        If (list.Count = 0) Then
            list.Add(byte_0)
        End If
        Return list.ToArray
    End Function


    ' Fields
    Public Shared long_0 As Long = 0
End Class



