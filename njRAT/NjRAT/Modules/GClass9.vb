Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

<DesignerGenerated> _
Public NotInheritable Class GClass9
    Inherits ListView
    ' Methods
    Public Sub New()
        AddHandler MyBase.ParentChanged, New EventHandler(AddressOf Me.GClass9_ParentChanged)
        AddHandler MyBase.MouseMove, New MouseEventHandler(AddressOf Me.GClass9_MouseMove)
        AddHandler MyBase.MouseUp, New MouseEventHandler(AddressOf Me.GClass9_MouseUp)
        AddHandler MyBase.ColumnClick, New ColumnClickEventHandler(AddressOf Me.GClass9_ColumnClick)
        AddHandler MyBase.KeyDown, New KeyEventHandler(AddressOf Me.GClass9_KeyDown)
        AddHandler MyBase.MouseDown, New MouseEventHandler(AddressOf Me.GClass9_MouseDown)
        Me.listViewItem_0 = Nothing
        Me.point_0 = Point.Empty
        Me.point_1 = Point.Empty
        Me.AllowDrop = False
        Me.Font = New Font("arial", 8.0!, FontStyle.Bold)
        Me.Dock = DockStyle.Fill
        Me.FullRowSelect = True
        Me.View = View.Details
        Me.OwnerDraw = True
        Me.SetStyle(ControlStyles.UserPaint, False)
        Me.DoubleBuffered = True
        Me.SetStyle((ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint), True)
        Me.SetStyle(ControlStyles.EnableNotifyMessage, True)
    End Sub

    <CompilerGenerated, DebuggerStepThrough> _
    Private Sub lam__3(ByVal sender As Object, ByVal e As EventArgs)
        Me.method_1()
    End Sub

    <DebuggerStepThrough, CompilerGenerated> _
    Private Sub lam__4(ByVal sender As Object, ByVal e As EventArgs)
        Me.method_1()
    End Sub

    <DebuggerNonUserCode> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If (disposing AndAlso (Not Me.icontainer_0 Is Nothing)) Then
                Me.icontainer_0.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Public Sub GClass9_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs)
        Dim class2 As GClass9 = Me
        SyncLock class2
            If (e.Column <> -1) Then
                Try
                    Dim ascending As SortOrder
                    Dim header As ColumnHeader = DirectCast(NewLateBinding.LateGet(sender, Nothing, "Columns", New Object() {e.Column}, Nothing, Nothing, Nothing), ColumnHeader)
                    If (Me.columnHeader_0 Is Nothing) Then
                        ascending = SortOrder.Ascending
                        header.Tag = "+"
                    ElseIf header.Equals(Me.columnHeader_0) Then
                        If Operators.ConditionalCompareObjectEqual(Me.columnHeader_0.Tag, "+", False) Then
                            ascending = SortOrder.Descending
                            Me.columnHeader_0.Tag = "-"
                        Else
                            Me.columnHeader_0.Tag = "+"
                            ascending = SortOrder.Ascending
                        End If
                    Else
                        ascending = SortOrder.Ascending
                    End If
                    Me.columnHeader_0 = header
                    If (Me.columnHeader_0.Tag Is Nothing) Then
                        Me.columnHeader_0.Tag = "+"
                    End If
                    If (Not sender Is Nothing) Then
                        NewLateBinding.LateSet(sender, Nothing, "ListViewItemSorter", New Object() {New GClass10(e.Column, ascending)}, Nothing, Nothing)
                        NewLateBinding.LateCall(sender, Nothing, "Sort", New Object(0 - 1) {}, Nothing, Nothing, Nothing, True)
                        NewLateBinding.LateSet(sender, Nothing, "ListViewItemSorter", New Object() {Nothing}, Nothing, Nothing)
                    End If
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    ProjectData.ClearProjectError()
                End Try
            End If
        End SyncLock
    End Sub

    Private Sub GClass9_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If (e.KeyCode = Keys.Space) Then
            Me.method_3()
        End If
        If ((e.KeyCode = Keys.A) And e.Control) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Items.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Selected = True
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub GClass9_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        If (e.Button = MouseButtons.Left) Then
            Me.listViewItem_0 = Me.GetItemAt(e.X, e.Y)
            Me.point_0 = e.Location
        End If
    End Sub

    Private Sub GClass9_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        Me.point_1 = e.Location
        If (Me.point_0 <> Point.Empty) Then
            If ((Not Me.listViewItem_0 Is Nothing) AndAlso (Me.listViewItem_0.Index = -1)) Then
                Me.listViewItem_0 = Nothing
            End If
            If (((e.Button = MouseButtons.Left) And (Not Me.listViewItem_0 Is Nothing)) AndAlso (Not Me.listViewItem_0 Is Nothing)) Then
                Dim itemAt As ListViewItem = Me.GetItemAt(e.X, e.Y)
                If (Not itemAt Is Nothing) Then
                    Dim enumerator2 As IEnumerator
                    If (itemAt.Index > Me.listViewItem_0.Index) Then
                        Dim enumerator As IEnumerator
                        Dim num3 As Integer = itemAt.Index
                        Dim j As Integer = Me.listViewItem_0.Index
                        Do While (j <= num3)
                            If Not Me.SelectedIndices.Contains(j) Then
                                Me.SelectedIndices.Add(j)
                            End If
                            j += 1
                        Loop
                        Try
                            enumerator = Me.SelectedIndices.GetEnumerator
                            Do While enumerator.MoveNext
                                Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
                                If Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(objectValue, Me.listViewItem_0.Index, False), Operators.CompareObjectGreater(objectValue, itemAt.Index, False))) Then
                                    Me.SelectedIndices.Remove(Conversions.ToInteger(objectValue))
                                End If
                            Loop
                            Return
                        Finally
                            If TypeOf enumerator Is IDisposable Then
                                TryCast(enumerator, IDisposable).Dispose()
                            End If
                        End Try
                    End If
                    Dim index As Integer = Me.listViewItem_0.Index
                    Dim i As Integer = itemAt.Index
                    Do While (i <= index)
                        If Not Me.SelectedIndices.Contains(i) Then
                            Me.SelectedIndices.Add(i)
                        End If
                        i += 1
                    Loop
                    Try
                        enumerator2 = Me.SelectedIndices.GetEnumerator
                        Do While enumerator2.MoveNext
                            Dim left As Object = RuntimeHelpers.GetObjectValue(enumerator2.Current)
                            If Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(left, itemAt.Index, False), Operators.CompareObjectGreater(left, Me.listViewItem_0.Index, False))) Then
                                Me.SelectedIndices.Remove(Conversions.ToInteger(left))
                            End If
                        Loop
                    Finally
                        If TypeOf enumerator2 Is IDisposable Then
                            TryCast(enumerator2, IDisposable).Dispose()
                        End If
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub GClass9_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Me.listViewItem_0 = Nothing
        Me.point_0 = Point.Empty
    End Sub

    Private Sub GClass9_ParentChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If (Not Me.Parent Is Nothing) Then
                RemoveHandler Me.Parent.Resize, New EventHandler(AddressOf Me.lam__3)
            End If
            AddHandler Me.Parent.Resize, New EventHandler(AddressOf Me.lam__4)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    <DebuggerStepThrough> _
    Private Sub method_0()
        Me.icontainer_0 = New Container
    End Sub

    Public Sub method_1()
        Me.method_3()
    End Sub

    Public Function method_2() As ListViewItem()
        Dim itemArray As ListViewItem()
        Dim class2 As GClass9 = Me
        SyncLock class2
            Dim list As New List(Of ListViewItem)
            If (Me.Items.Count = 0) Then
                Return list.ToArray
            End If
            Try
                Dim topItem As ListViewItem = Me.TopItem
                list.Add(topItem)
                Dim num As Integer = (Me.Items.Count - 1)
                Dim i As Integer = (topItem.Index + 1)
                Do While (i <= num)
                    Try
                        topItem = Me.Items.Item(i)
                        If Me.Bounds.IntersectsWith(Me.Items.Item(i).Bounds) Then
                            list.Add(topItem)
                        Else
                            GoTo Label_00B7
                        End If
                    Catch exception1 As Exception
                        ProjectData.SetProjectError(exception1)
                        ProjectData.ClearProjectError()
                        GoTo Label_00B7
                    End Try
                    i += 1
                Loop
            Catch exception2 As Exception
                ProjectData.SetProjectError(exception2)
                ProjectData.ClearProjectError()
            End Try
Label_00B7:
            itemArray = list.ToArray
        End SyncLock
        Return itemArray
    End Function

    Public Sub method_3()
        Try
            If (Me.Columns.Count <> 0) Then
                If (Me.Items.Count = 0) Then
                    Me.Columns.Item((Me.Columns.Count - 1)).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                Else
                    Dim num As Integer = (Me.Columns.Count - 1)
                    Dim i As Integer = 0
                    Do While (i <= num)
                        Me.Columns.Item(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                        i += 1
                    Loop
                End If
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Protected Overrides Sub OnDrawColumnHeader(ByVal drawListViewColumnHeaderEventArgs_0 As DrawListViewColumnHeaderEventArgs)
        Try
            Dim format As New StringFormat With { _
                .FormatFlags = StringFormatFlags.NoWrap, _
                .Trimming = StringTrimming.EllipsisCharacter, _
                .Alignment = StringAlignment.Near, _
                .LineAlignment = StringAlignment.Near _
            }
            Dim rect As New Rectangle(drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.Width, drawListViewColumnHeaderEventArgs_0.Bounds.Height)
            drawListViewColumnHeaderEventArgs_0.Graphics.FillRectangle(New Pen(ControlPaint.Light(Me.BackColor, 0.1!)).Brush, rect)
            drawListViewColumnHeaderEventArgs_0.Graphics.DrawString(drawListViewColumnHeaderEventArgs_0.Header.Text, Me.Font, New Pen(Me.ForeColor).Brush, drawListViewColumnHeaderEventArgs_0.Bounds, format)
            drawListViewColumnHeaderEventArgs_0.Graphics.DrawLine(New Pen(Me.ForeColor), drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.X, (drawListViewColumnHeaderEventArgs_0.Bounds.Y + drawListViewColumnHeaderEventArgs_0.Bounds.Height))
            drawListViewColumnHeaderEventArgs_0.DrawDefault = False
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        MyBase.OnDrawColumnHeader(drawListViewColumnHeaderEventArgs_0)
    End Sub

    Protected Overrides Sub OnDrawItem(ByVal drawListViewItemEventArgs_0 As DrawListViewItemEventArgs)
        drawListViewItemEventArgs_0.DrawDefault = True
        MyBase.OnDrawItem(drawListViewItemEventArgs_0)
    End Sub

    Protected Overrides Sub OnDrawSubItem(ByVal drawListViewSubItemEventArgs_0 As DrawListViewSubItemEventArgs)
        drawListViewSubItemEventArgs_0.DrawDefault = True
        MyBase.OnDrawSubItem(drawListViewSubItemEventArgs_0)
    End Sub

    Protected Overrides Sub OnNotifyMessage(ByVal message_0 As Message)
        If (message_0.Msg <> 20) Then
            MyBase.OnNotifyMessage(message_0)
        End If
    End Sub


    ' Fields
    Public columnHeader_0 As ColumnHeader
    Private icontainer_0 As IContainer
    Private listViewItem_0 As ListViewItem
    Private point_0 As Point
    Private point_1 As Point

    ' Nested Types
    Public NotInheritable Class GClass10
        Implements IComparer

        ' Methods
        Public Sub New(ByVal int_1 As Integer, ByVal sortOrder_1 As SortOrder)
            Me.int_0 = int_1
            Me.sortOrder_0 = sortOrder_1
        End Sub

        Public Function [Compare](ByVal object_0 As Object, ByVal object_1 As Object) As Integer
            Dim text As String
            Dim str2 As String
            Dim item As ListViewItem = DirectCast(object_0, ListViewItem)
            Dim item2 As ListViewItem = DirectCast(object_1, ListViewItem)
            If (item.SubItems.Count <= Me.int_0) Then
                [text] = String.Empty
            Else
                [text] = item.SubItems.Item(Me.int_0).Text
            End If
            If (item2.SubItems.Count <= Me.int_0) Then
                str2 = String.Empty
            Else
                str2 = item2.SubItems.Item(Me.int_0).Text
            End If
            If (Me.sortOrder_0 = SortOrder.Ascending) Then
                If (Versioned.IsNumeric([text]) And Versioned.IsNumeric(str2)) Then
                    Return Conversion.Val([text]).CompareTo(Conversion.Val(str2))
                End If
                If (Information.IsDate([text]) And Information.IsDate(str2)) Then
                    Return DateTime.Parse([text]).CompareTo(DateTime.Parse(str2))
                End If
                Return String.Compare([text], str2)
            End If
            If (Versioned.IsNumeric([text]) And Versioned.IsNumeric(str2)) Then
                Return Conversion.Val(str2).CompareTo(Conversion.Val([text]))
            End If
            If (Information.IsDate([text]) And Information.IsDate(str2)) Then
                Return DateTime.Parse(str2).CompareTo(DateTime.Parse([text]))
            End If
            Return String.Compare(str2, [text])
        End Function


        ' Fields
        Private int_0 As Integer
        Private sortOrder_0 As SortOrder

        Public Function Compare1(x As Object, y As Object) As Integer Implements IComparer.Compare

        End Function
    End Class
End Class



