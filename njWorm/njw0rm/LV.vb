Public Class LV
    Inherits System.Windows.Forms.ListView
    Public Sub New()
        MyBase.New()
        Me.AllowDrop = False
        Me.Font = New Font("arial", 8, FontStyle.Bold)
        Me.Dock = DockStyle.Fill
        Me.FullRowSelect = True
        Me.View = Windows.Forms.View.Details

        Me.SetStyle((ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint), True)
        Me.SetStyle(ControlStyles.EnableNotifyMessage, True)

    End Sub
    Public Sub FX() ' fix columns
        Me.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub
    Protected Overrides Sub OnNotifyMessage(ByVal m As Message)
        Exit Sub
        If (m.Msg <> 20) Then
            MyBase.OnNotifyMessage(m)
        End If
    End Sub
#Region "Listview Sort"
    Private m_SortingColumn As ColumnHeader
    Public Sub cc(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles MyBase.ColumnClick
        SyncLock Me
            Try
                Dim new_sorting_column As ColumnHeader = sender.Columns(e.Column)
                Dim sort_order As System.Windows.Forms.SortOrder
                If m_SortingColumn Is Nothing Then
                    sort_order = SortOrder.Ascending
                Else
                    If new_sorting_column.Equals(m_SortingColumn) Then
                        If m_SortingColumn.Text.StartsWith("+") Then
                            sort_order = SortOrder.Descending
                        Else
                            sort_order = SortOrder.Ascending
                        End If
                    Else
                        sort_order = SortOrder.Ascending
                    End If
                    m_SortingColumn.Text = m_SortingColumn.Text.Substring(1)
                End If
                m_SortingColumn = new_sorting_column
                If sort_order = SortOrder.Ascending Then
                    m_SortingColumn.Text = "+" & m_SortingColumn.Text
                Else
                    m_SortingColumn.Text = "-" & m_SortingColumn.Text
                End If
                If sender Is Nothing Then Exit Sub
                sender.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
                sender.Sort()
                sender.ListViewItemSorter = Nothing
            Catch ex As Exception

            End Try
        End SyncLock


    End Sub
    Public Class clsListviewSorter ' Implements a comparer   
        Implements IComparer
        Private m_ColumnNumber As Integer
        Private m_SortOrder As SortOrder
        Public Sub New(ByVal column_number As Integer, ByVal sort_order As SortOrder)
            m_ColumnNumber = column_number
            m_SortOrder = sort_order
        End Sub
        ' Compare the items in the appropriate column  
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim item_x As ListViewItem = DirectCast(x, ListViewItem)
            Dim item_y As ListViewItem = DirectCast(y, ListViewItem)
            ' Get the sub-item values.  
            Dim string_x As String
            If item_x.SubItems.Count <= m_ColumnNumber Then
                string_x = ""
            Else
                string_x = item_x.SubItems(m_ColumnNumber).Text
            End If
            Dim string_y As String
            If item_y.SubItems.Count <= m_ColumnNumber Then
                string_y = ""
            Else
                string_y = item_y.SubItems(m_ColumnNumber).Text
            End If
            ' Compare them.  
            If m_SortOrder = SortOrder.Ascending Then
                If IsNumeric(string_x) And IsNumeric(string_y) Then
                    Return Val(string_x).CompareTo(Val(string_y))
                ElseIf IsDate(string_x) And IsDate(string_y) Then
                    Return DateTime.Parse(string_x).CompareTo(DateTime.Parse(string_y))
                Else
                    Return String.Compare(string_x, string_y)
                End If
            Else
                If IsNumeric(string_x) And IsNumeric(string_y) Then
                    Return Val(string_y).CompareTo(Val(string_x))
                ElseIf IsDate(string_x) And IsDate(string_y) Then
                    Return DateTime.Parse(string_y).CompareTo(DateTime.Parse(string_x))
                Else
                    Return String.Compare(string_y, string_x)
                End If
            End If
        End Function
    End Class
#End Region
End Class