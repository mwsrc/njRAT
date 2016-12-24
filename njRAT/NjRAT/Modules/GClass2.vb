Imports System
Imports System.Runtime.InteropServices
Imports System.Security

<SuppressUnmanagedCodeSecurity> _
Public NotInheritable Class GClass2
    ' Methods
    <DllImport("kernel32")> _
    Public Shared Function BeginUpdateResource(ByVal string_0 As String, <MarshalAs(UnmanagedType.Bool)> ByVal bool_0 As Boolean) As IntPtr
    End Function

    <DllImport("kernel32")> _
    Public Shared Function EndUpdateResource(ByVal intptr_0 As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByVal bool_0 As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("kernel32")> _
    Public Shared Function UpdateResource(ByVal intptr_0 As IntPtr, ByVal intptr_1 As IntPtr, ByVal intptr_2 As IntPtr, ByVal short_0 As Short, <MarshalAs(UnmanagedType.LPArray, SizeParamIndex:=5, SizeConst:=0)> ByVal byte_0 As Byte(), ByVal int_0 As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

End Class
