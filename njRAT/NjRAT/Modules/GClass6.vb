Imports System

Public NotInheritable Class GClass6
    ' Methods
    Public Function method_0(ByVal gclass6_0 As GClass6) As Double
        Dim d As Double = Me.double_0
        Dim num6 As Double = Me.double_1
        Dim num5 As Double = gclass6_0.double_0
        Dim num7 As Double = gclass6_0.double_1
        d = (d * GClass6.double_4)
        num5 = (num5 * GClass6.double_4)
        Dim num As Double = (num5 - d)
        Dim num2 As Double = ((num7 - num6) * GClass6.double_4)
        Dim num8 As Double = (Math.Pow(Math.Sin((num / 2)), 2) + ((Math.Cos(d) * Math.Cos(num5)) * Math.Pow(Math.Sin((num2 / 2)), 2)))
        Return (GClass6.double_2 * Math.Atan2(Math.Sqrt(num8), Math.Sqrt((1 - num8))))
    End Function


    ' Fields
    Public double_0 As Double
    Public double_1 As Double
    Private Shared double_2 As Double = 12756.4
    Private Shared double_3 As Double = 3.14159265
    Private Shared double_4 As Double = (GClass6.double_3 / 180)
    Public int_0 As Integer
    Public int_1 As Integer
    Public int_2 As Integer
    Public string_0 As String
    Public string_1 As String
    Public string_2 As String
    Public string_3 As String
    Public string_4 As String
    Public string_5 As String
End Class


