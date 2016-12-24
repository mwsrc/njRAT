Imports Microsoft.VisualBasic.CompilerServices
Imports System

Public NotInheritable Class GClass5
    ' Methods
    Public Sub New(ByVal string_1 As String)
        Me.string_0 = string_1
    End Sub

    Public Function method_0() As Integer
        If ((Me.string_0 Is Nothing) Or (Me.string_0 = String.Empty)) Then
            Return GClass5.int_0
        End If
        Return (Convert.ToInt32(Me.string_0.Substring(4, 3)) - &H69)
    End Function

    Public Function method_1() As Boolean
        Return (Me.string_0.IndexOf("FREE") < 0)
    End Function

    Public Function method_2() As DateTime
        Dim num2 As Integer = (Me.string_0.Length - 10)
        Dim i As Integer = 0
        Do While (i <= num2)
            If Char.IsWhiteSpace(Me.string_0.Chars(i)) Then
                Dim s As String = Me.string_0.Substring((i + 1), 8)
                Try
                    Return DateTime.ParseExact(s, "yyyyMMdd", Nothing)
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Console.Write(exception.Message)
                    ProjectData.ClearProjectError()
                    Exit Do
                End Try
            End If
            i += 1
        Loop
        Return DateTime.Now
    End Function

    Public Function method_3() As String
        Return Me.string_0
    End Function


    ' Fields
    Public Shared int_0 As Integer = 1
    Public Shared int_1 As Integer = 7
    Public Shared int_10 As Integer = 11
    Public Shared int_11 As Integer = 12
    Public Shared int_12 As Integer = &H15
    Public Shared int_13 As Integer = &H16
    Public Shared int_14 As Integer = &H17
    Public Shared int_15 As Integer = &H18
    Public Shared int_16 As Integer = 30
    Public Shared int_17 As Integer = &H1F
    Public Shared int_18 As Integer = &H20
    Public Shared int_19 As Integer = &H21
    Public Shared int_2 As Integer = 3
    Public Shared int_3 As Integer = 6
    Public Shared int_4 As Integer = 2
    Public Shared int_5 As Integer = 5
    Public Shared int_6 As Integer = 4
    Public Shared int_7 As Integer = 8
    Public Shared int_8 As Integer = 9
    Public Shared int_9 As Integer = 10
    Private string_0 As String
End Class



