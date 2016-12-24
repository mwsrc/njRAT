Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public NotInheritable Class Pp1
       Inherits PictureBox
    ' Methods
    Public Sub New()
        Me.font = New Font("arial", 8.0!, FontStyle.Bold)
        Me.Lines = New List(Of Object())
        Dim timer As New Timer With {.Interval = 50, .Enabled = False}
        Me.T = timer
        Me.SizeMode = PictureBoxSizeMode.Normal
    End Sub


    <DebuggerStepThrough, CompilerGenerated> _
    Private Sub ksh__4(ByVal a0 As Object, ByVal a1 As EventArgs)
        Try
            Me.wrk()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub wrk()
        Try
            Me.T.Enabled = False
            Dim pp2 As Pp1 = Me
            SyncLock pp2
                Dim image As New Bitmap(Me.Width, Me.Height)
                Me.G = Graphics.FromImage(image)
                Me.G.Clear(Color.Black)
                Dim y As Integer = 3
                Dim height As Integer = TextRenderer.MeasureText("test", Me.font).Height
                Dim white As Color = Color.White
                Dim i As Integer = (Me.Lines.Count - 1)
                Do While (i >= 0)
                    Dim x As Integer = 3
                    Dim objArray As Object() = Me.Lines.Item(i)
                    Dim num6 As Integer = (objArray.Length - 1)
                    Dim j As Integer = 0
                    Do While (j <= num6)
                        Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray(j))))
                        Dim str As String = objectValue.GetType.ToString
                        If (str = GetType(Bitmap).ToString) Then
                            Dim bitmap2 As Bitmap = DirectCast(objectValue, Bitmap)
                            If (bitmap2.Height > height) Then
                                Dim ptr As IntPtr
                                bitmap2 = DirectCast(bitmap2.GetThumbnailImage(height, height, Nothing, ptr), Bitmap)
                            End If
                            Me.G.DrawImage(bitmap2, x, y)
                            x = (x + (bitmap2.Width + 3))
                        ElseIf (str = GetType(String).ToString) Then
                            Dim text As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(objectValue))
                            Dim size As Size = TextRenderer.MeasureText([text], Me.font)
                            Me.G.DrawString([text], Me.font, New Pen(white).Brush, CSng(x), CSng(y))
                            If ((size.Height - height) > 0) Then
                                y = (y + (size.Height - height))
                                x = 3
                            Else
                                x = (x + (size.Width + 3))
                            End If
                        ElseIf (str = GetType(Color).ToString) Then
                            white = DirectCast(objectValue, Color)
                        End If
                        j += 1
                    Loop
                    y = (y + height)
                    i = (i + -1)
                Loop
                Me.G.Dispose()
                Me.Image = image
            End SyncLock
            Me.T.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Public Sub WRT(ByVal ParamArray A As Object())
        Dim pp2 As Pp1 = Me
        SyncLock pp2
            Me.Lines.Add(A)
            If (Me.Lines.Count = 100) Then
                Me.Lines.RemoveAt(0)
            End If
        End SyncLock
    End Sub


    ' Properties
    Public Property T As Timer
        Get
            Return Me._T
        End Get
        <MethodImpl(MethodImplOptions.Synchronized)> _
        Set(ByVal WithEventsValue As Timer)
            Dim handler As EventHandler = New EventHandler(AddressOf Me.ksh__4)
            If (Not Me._T Is Nothing) Then
                RemoveHandler Me._T.Tick, handler
            End If
            Me._T = WithEventsValue
            If (Not Me._T Is Nothing) Then
                AddHandler Me._T.Tick, handler
            End If
        End Set
    End Property


    ' Fields
    Private _T As Timer
    Public font As Font
    Public G As Graphics
    Public Lines As List(Of Object())
End Class



