Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public NotInheritable Class L1
    Inherits DataGridView
    ' Methods
    Public Sub New()
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        Me.RowHeadersVisible = False
        Me.DoubleBuffered = True
        Me.ShowCellErrors = True
        Me.ShowEditingIcon = True
        Me.ShowRowErrors = True
        Me.Font = New Font("arial", 8.0!, FontStyle.Bold)
        Me.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        Me.SetStyle((ControlStyles.OptimizedDoubleBuffer Or (ControlStyles.EnableNotifyMessage Or (ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint))), True)
    End Sub

    Public Function method_0(ByVal int_0 As Integer) As DataGridViewRow
        Return DirectCast(Me.collection_0.Item((int_0 + 1)), DataGridViewRow)
    End Function

    Public Function method_1(ByVal string_0 As String) As DataGridViewRow
        Return DirectCast(Me.collection_0.Item(string_0), DataGridViewRow)
    End Function

    Public Sub method_10(ByVal int_0 As Integer)
        If Me.InvokeRequired Then
            Dim collection As Collection = Me.collection_0
            SyncLock collection
                Me.Invoke(New Delegate4(AddressOf Me.method_10), New Object() {int_0})
                Return
            End SyncLock
        End If
        Me.Rows.RemoveAt(int_0)
    End Sub

    Public Sub method_11(ByVal string_0 As String, ByVal genum0_0 As GEnum0, ByVal dataGridViewAutoSizeColumnMode_0 As DataGridViewAutoSizeColumnMode)
        Dim collection As Collection = Me.collection_0
        SyncLock collection
            Dim column2 As DataGridViewImageColumn
            Dim dataGridViewColumn As DataGridViewColumn = Nothing
            Select Case genum0_0
                Case GEnum0.Text
                    dataGridViewColumn = New DataGridViewTextBoxColumn
                    Exit Select
                Case GEnum0.Link
                    dataGridViewColumn = New DataGridViewLinkColumn
                    Exit Select
                Case GEnum0.Image
                    column2 = New DataGridViewImageColumn With { _
                        .ImageLayout = DataGridViewImageCellLayout.Zoom _
                    }
                    dataGridViewColumn = column2
                    Exit Select
                Case GEnum0.StretchImage
                    column2 = New DataGridViewImageColumn With { _
                        .ImageLayout = DataGridViewImageCellLayout.Stretch _
                    }
                    dataGridViewColumn = column2
                    Exit Select
            End Select
            dataGridViewColumn.AutoSizeMode = dataGridViewAutoSizeColumnMode_0
            dataGridViewColumn.Tag = genum0_0
            dataGridViewColumn.HeaderText = string_0
            Me.Columns.Add(dataGridViewColumn)
        End SyncLock
    End Sub

    Public Function method_2(ByVal string_0 As String) As Boolean
        Return Me.collection_0.Contains(string_0)
    End Function

    Public Function method_3() As DataGridViewRow()
        Dim list As New List(Of DataGridViewRow)
        If (Me.RowCount = 0) Then
            Return list.ToArray
        End If
        Try
            Dim num As Integer = (Me.FirstDisplayedScrollingRowIndex + Me.DisplayedRowCount(False))
            Dim i As Integer = Me.FirstDisplayedScrollingRowIndex
            Do While (i <= num)
                If (i > (Me.RowCount - 1)) Then
                    GoTo Label_0075
                End If
                Try
                    list.Add(Me.Rows.Item(i))
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    ProjectData.ClearProjectError()
                    GoTo Label_0075
                End Try
                i += 1
            Loop
        Catch exception2 As Exception
            ProjectData.SetProjectError(exception2)
            ProjectData.ClearProjectError()
        End Try
Label_0075:
        Return list.ToArray
    End Function

    Public Sub method_4()
        Dim collection As Collection = Me.collection_0
        SyncLock collection
            Me.Rows.Clear()
            Me.collection_0.Clear()
        End SyncLock
    End Sub

    Public Function method_5(ByVal object_0 As Object()) As DataGridViewRow
        If Me.InvokeRequired Then
            Dim collection As Collection = Me.collection_0
            SyncLock collection
                Return DirectCast(Me.Invoke(New Delegate1(AddressOf Me.method_5), object_0), DataGridViewRow)
            End SyncLock
        End If
        Dim item As New DataGridViewRow
        Dim num As Integer = (Me.ColumnCount - 1)
        Dim i As Integer = 0
        Do While (i <= num)
            Dim cell3 As DataGridViewImageCell
            Select Case Conversions.ToInteger(Me.Columns.Item(i).Tag)
                Case 0
                    Dim dataGridViewCell As New DataGridViewTextBoxCell With { _
                        .Value = RuntimeHelpers.GetObjectValue(object_0(i)) _
                    }
                    item.Cells.Add(dataGridViewCell)
                    Exit Select
                Case 1
                    Dim cell2 As New DataGridViewLinkCell With { _
                        .Value = RuntimeHelpers.GetObjectValue(object_0(i)) _
                    }
                    item.Cells.Add(cell2)
                    Exit Select
                Case 2
                    cell3 = New DataGridViewImageCell With { _
                        .Value = RuntimeHelpers.GetObjectValue(object_0(i)), _
                        .ImageLayout = DataGridViewImageCellLayout.Normal _
                    }
                    item.Cells.Add(cell3)
                    Exit Select
                Case 3
                    cell3 = New DataGridViewImageCell With { _
                        .Value = RuntimeHelpers.GetObjectValue(object_0(i)), _
                        .ImageLayout = DataGridViewImageCellLayout.Stretch _
                    }
                    item.Cells.Add(cell3)
                    Exit Select
            End Select
            i += 1
        Loop
        item.Resizable = DataGridViewTriState.False
        Me.collection_0.Add(item, Nothing, Nothing, Nothing)
        Me.Rows.Add(item)
        Return item
    End Function

    Public Function method_6() As Integer
        Return Me.RowTemplate.Height
    End Function

    Public Sub method_7(ByVal int_0 As Integer)
        Me.RowTemplate.Height = int_0
    End Sub

    Public Function method_8(ByVal string_0 As String, ByVal object_0 As Object()) As DataGridViewRow
        If Me.InvokeRequired Then
            Dim collection As Collection = Me.collection_0
            SyncLock collection
                Return DirectCast(Me.Invoke(New Delegate2(AddressOf Me.method_8), New Object() {string_0, object_0}), DataGridViewRow)
            End SyncLock
        End If
        Dim item As New DataGridViewRow With { _
            .Height = Me.method_6 _
        }
        Dim num As Integer = (Me.ColumnCount - 1)
        Dim i As Integer = 0
        Do While (i <= num)
            Dim cell3 As DataGridViewImageCell
            Select Case Conversions.ToInteger(Me.Columns.Item(i).Tag)
                Case 0
                    Dim dataGridViewCell As New DataGridViewTextBoxCell With { _
                        .Value = RuntimeHelpers.GetObjectValue(object_0(i)) _
                    }
                    item.Cells.Add(dataGridViewCell)
                    Exit Select
                Case 1
                    Dim cell2 As New DataGridViewLinkCell With { _
                        .Value = RuntimeHelpers.GetObjectValue(object_0(i)) _
                    }
                    item.Cells.Add(cell2)
                    Exit Select
                Case 2
                    cell3 = New DataGridViewImageCell With { _
                        .Value = RuntimeHelpers.GetObjectValue(object_0(i)), _
                        .ImageLayout = DataGridViewImageCellLayout.Zoom _
                    }
                    item.Cells.Add(cell3)
                    Exit Select
                Case 3
                    cell3 = New DataGridViewImageCell With { _
                        .Value = RuntimeHelpers.GetObjectValue(object_0(i)), _
                        .ImageLayout = DataGridViewImageCellLayout.Stretch _
                    }
                    item.Cells.Add(cell3)
                    Exit Select
            End Select
            i += 1
        Loop
        item.Resizable = DataGridViewTriState.False
        Me.collection_0.Add(item, string_0, Nothing, Nothing)
        Me.Rows.Add(item)
        Return item
    End Function

    Public Sub method_9(ByVal dataGridViewRow_0 As DataGridViewRow)
        If Me.InvokeRequired Then
            Dim collection As Collection = Me.collection_0
            SyncLock collection
                Me.Invoke(New Delegate3(AddressOf Me.method_9), New Object() {dataGridViewRow_0})
                Return
            End SyncLock
        End If
        Me.Rows.Remove(dataGridViewRow_0)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal mouseEventArgs_0 As MouseEventArgs)
        If (mouseEventArgs_0.Button = MouseButtons.Right) Then
            Try
                Dim info As HitTestInfo = Me.HitTest(mouseEventArgs_0.X, mouseEventArgs_0.Y)
                If (info.RowIndex <> -1) Then
                    Dim row As DataGridViewRow = Me.Rows.Item(info.RowIndex)
                    If Not row.Selected Then
                        Me.ClearSelection()
                        row.Selected = True
                    End If
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
        End If
        MyBase.OnMouseUp(mouseEventArgs_0)
    End Sub

    Protected Overrides Sub OnMouseWheel(ByVal mouseEventArgs_0 As MouseEventArgs)
        MyBase.OnMouseWheel(mouseEventArgs_0)
        Try
            Select Case mouseEventArgs_0.Delta
                Case 120
                    Me.FirstDisplayedScrollingRowIndex = Math.Max(0, (Me.FirstDisplayedScrollingRowIndex - SystemInformation.MouseWheelScrollLines))
                    Return
                Case -120
                    Me.FirstDisplayedScrollingRowIndex = (Me.FirstDisplayedScrollingRowIndex + SystemInformation.MouseWheelScrollLines)
                    Exit Select
            End Select
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Protected Overrides Sub OnRowPostPaint(ByVal dataGridViewRowPostPaintEventArgs_0 As DataGridViewRowPostPaintEventArgs)
        Try
            Dim row As DataGridViewRow = Me.Rows.Item(dataGridViewRowPostPaintEventArgs_0.RowIndex)
            If (row.Height <> Me.method_6) Then
                row.Height = Me.method_6
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        MyBase.OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0)
    End Sub


    ' Fields
    Private collection_0 As Collection = New Collection

    ' Nested Types
    Private Delegate Function Delegate1(ByVal object_0 As Object()) As DataGridViewRow

    Private Delegate Function Delegate2(ByVal string_0 As String, ByVal object_0 As Object()) As DataGridViewRow

    Private Delegate Sub Delegate3(ByVal dataGridViewRow_0 As DataGridViewRow)

    Private Delegate Sub Delegate4(ByVal int_0 As Integer)

    Public Enum GEnum0
        ' Fields
        Image = 2
        Link = 1
        StretchImage = 3
        [Text] = 0
    End Enum
End Class



