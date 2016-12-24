Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Public Class notf
    Inherits Form
    ' Methods
    Public Sub New()
        AddHandler MyBase.Load, New EventHandler(AddressOf Me.notf_Load)
        Me.bool_0 = True
        Me.Items = New List(Of GClass15)
        Me.InitializeComponent()
    End Sub

    Public Sub AddItem(ByVal img As Bitmap, ByVal [Text] As String)
        Dim items As List(Of GClass15) = Me.Items
        SyncLock items
            If (Me.Items.Count > 50) Then
                Me.Items.RemoveAt(0)
            End If
            Dim item As New GClass15 With { _
                .bitmap_0 = DirectCast(img.Clone, Bitmap), _
                .string_0 = [Text] _
            }
            Me.Items.Add(item)
        End SyncLock
    End Sub
    Public Sub back()
        Me.bool_0 = True
        Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Left = ((workingArea.Width - Me.Width) - 5)
        Me.Top = ((workingArea.Height - Me.Height) - 5)
    End Sub

    Public Sub go()
        Me.bool_0 = False
        Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Left = workingArea.Width
        Me.Top = workingArea.Height
    End Sub

    Private Sub p_Click(sender As Object, e As EventArgs) Handles p.Click
        Dim items As List(Of GClass15) = Me.Items
        SyncLock items
            Me.Items.Clear()
        End SyncLock
    End Sub

    Private Sub notf_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.p.BackColor = Color.Pink
        Me.TransparencyKey = Color.Pink
        Me.back()
        Control.CheckForIllegalCrossThreadCalls = False
        Dim dz As New Thread(New ThreadStart(AddressOf Me.wrk))
        dz.Start()
    End Sub
    Public Sub wrk()
        Do While True
            Thread.Sleep(50)
            If (Me.Items.Count = 0) Then
                Me.go()
            Else
                Try
                    Dim image As New Bitmap(Me.p.Width, Me.p.Height)
                    Dim graphics As Graphics = Graphics.FromImage(image)
                    graphics.Clear(Me.p.BackColor)
                    Dim items As List(Of GClass15) = Me.Items
                    SyncLock items
                        Dim class2 As GClass15
                        For Each class2 In Me.Items
                            Dim class4 As GClass15
                            If (class2.int_0 <= 2) Then
                                class2.int_0 = 2
                                class4 = class2
                                class4.int_1 += 1
                            Else
                                Dim count As Integer = Me.Items.Count
                                If (count > 30) Then
                                    class2.int_0 = 2
                                ElseIf (count > 20) Then
                                    class4 = class2
                                    class4.int_0 = (class4.int_0 + -20)
                                ElseIf (count > 10) Then
                                    class4 = class2
                                    class4.int_0 = (class4.int_0 + -10)
                                Else
                                    class4 = class2
                                    class4.int_0 = (class4.int_0 + -2)
                                End If
                                If (class2.int_0 < 2) Then
                                    class2.int_0 = 2
                                End If
                            End If
                            Dim size As Size = TextRenderer.MeasureText(class2.string_0, Me.Font)
                            size.Width = image.Width
                            size.Height = (size.Height + 5)
                            Dim rect As New Rectangle(0, (class2.int_0 - 2), Me.Width, size.Height)
                            graphics.FillRectangle(Brushes.Black, rect)
                            rect = New Rectangle(0, (class2.int_0 - 2), Me.Width, size.Height)
                            ControlPaint.DrawLockedFrame(graphics, rect, False)
                            Dim arguments As Object() = New Object(2 - 1) {}
                            arguments(0) = RuntimeHelpers.GetObjectValue(class2.bitmap_0.Clone)
                            Dim point As New Point(5, (class2.int_0 - 2))
                            arguments(1) = point
                            NewLateBinding.LateCall(graphics, Nothing, "DrawImage", arguments, Nothing, Nothing, Nothing, True)
                            graphics.DrawString(class2.string_0, Me.Font, Brushes.LightSteelBlue, 5.0!, CSng(class2.int_0))
                            If (class2.int_0 > (Me.Height - 50)) Then
                                Exit For
                            End If
                        Next
Label_0232:
                        Dim class3 As GClass15
                        For Each class3 In Me.Items
                            If (class3.int_1 = 40) Then
                                Me.Items.Remove(class3)
                                GoTo Label_0232
                            End If
                        Next
                        If ((Me.Items.Count = 0) And Me.bool_0) Then
                            Me.go()
                        End If
                        If ((Me.Items.Count > 0) And Not Me.bool_0) Then
                            Me.back()
                        End If
                    End SyncLock
                    graphics.Flush(FlushIntention.Sync)
                    graphics.Dispose()
                    Me.p.Image = image
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    ProjectData.ClearProjectError()
                End Try
            End If
        Loop
    End Sub


    ' Fields
    Private bool_0 As Boolean
    Public Items As List(Of GClass15)

    ' Nested Types
    Public NotInheritable Class GClass15
        ' Fields
        Public bitmap_0 As Bitmap
        Public int_0 As Integer = My.Forms.notf.Height
        Public int_1 As Integer = 0
        Public string_0 As String
    End Class
End Class
