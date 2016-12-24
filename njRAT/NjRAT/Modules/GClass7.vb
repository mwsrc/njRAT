Imports System
Imports System.Runtime.InteropServices

Public NotInheritable Class GClass7
    ' Methods
    <DllImport("User32.dll")> _
    Private Shared Function GetLastInputInfo(ByRef gstruct0_0 As GStruct0) As Boolean
    End Function

    Public Shared Function smethod_0() As UInt32
        Dim struct2 As GStruct0
        struct2 = New GStruct0 With { _
            .uint_0 = Convert.ToUInt32(Marshal.SizeOf(struct2)) _
        }
        GClass7.GetLastInputInfo(struct2)
        Return (Convert.ToUInt32(Environment.TickCount) - struct2.uint_1)
    End Function


    ' Nested Types
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure GStruct0
        Public uint_0 As UInt32
        Public uint_1 As UInt32
    End Structure
End Class