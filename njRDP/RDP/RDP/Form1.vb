Public Class Form1
    Public WithEvents S As New SocketServer
    Public Yy As String = "\nJ\."

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        S.Start(8989)
    End Sub
#Region "Server Events"
    Sub Disconnect(ByVal sock As Integer) Handles S.DisConnected
        Me.Text = "nJ-RDP ,Clients{x}".Replace("x", S.Online.Count)
        Try
            L1.Items(sock.ToString).Remove()
        Catch ex As Exception
        End Try
    End Sub
    Sub Connected(ByVal sock As Integer) Handles S.Connected
        Me.Text = "nJ-RDP ,Clients{x}".Replace("x", S.Online.Count)
        S.Send(sock, "~") ' i ask him to send me PC name
    End Sub
    Delegate Sub _Data(ByVal sock As Integer, ByVal B As Byte())
    Sub Data(ByVal sock As Integer, ByVal B As Byte()) Handles S.Data
        Dim T As String = BS(B)
        Dim A As String() = Split(T, Yy)
        Try
            Select Case A(0)
                Case "~" ' Client Sent me PC name
                    Dim L = L1.Items.Add(sock.ToString, A(1), 0)
                    L.SubItems.Add(S.IP(sock))
                    L.ToolTipText = sock
                Case "!" ' i recive size of client screen
                    ' lets start Cap form and start capture desktop
                    If My.Application.OpenForms("!" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim cap As New Cap
                    cap.F = Me
                    cap.Sock = sock
                    cap.Name = "!" & sock
                    cap.Sz = New Size(A(1), A(2))
                    cap.Show()
                Case "@" ' i recive image  
                    Dim F As Cap = My.Application.OpenForms("!" & sock)
                    If F IsNot Nothing Then
                        If A(1).Length = 1 Then
                            F.Text = "Size: " & siz(B.Length) & " ,No Changes"
                            If F.Button1.Text = "Stop" Then
                                S.Send(sock, "@" & Yy & F.C1.SelectedIndex & Yy & F.C2.Text & Yy & F.C.Value)
                            End If
                            Exit Sub
                        End If
                        Dim BB As Byte() = fx(B, "@" & Yy)(1)
                        F.PktToImage(BB)
                    End If

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
    Private Sub RemoteDesktopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoteDesktopToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "!")
        Next
    End Sub

    Private Sub L1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L1.SelectedIndexChanged

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "close")
        Next
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Coded by: njq8" & vbNewLine & "Moded By:???")
    End Sub
End Class
