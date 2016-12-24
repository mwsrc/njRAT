Imports System.Data

Public Class njdb
    ' njdb v2.0 bY njq8
    Private WithEvents W As DataTable
    Public ReadOnly Path As String = ""
    Sub New(ByVal PathToDb As String)

        Path = PathToDb
        If IO.File.Exists(Path) Then
            Try
                Dim r As New Data.DataSet
                r.ReadXml(Path)
                W = r.Tables(0)
                r.Dispose()
                Exit Sub
            Catch ex As Exception
            End Try
        End If
        W = New Data.DataTable("njdb")
    End Sub
    Public Sub Dispose()
        W.Dispose()
        W = Nothing
    End Sub
    Public Sub Save()
        W.WriteXml(Path)
    End Sub
    Public Sub AddColumn(ByVal Name As String, ByVal Unique As Boolean)
        For Each x In Columns()
            If x.ToLower = Name.ToLower Then
                Exit Sub
            End If
        Next
        W.Columns.Add(Name).Unique = Unique
        Save()
    End Sub
    Public Sub DeleteColumn(ByVal Name As String)
        W.Columns.Remove(Name)
        Save()
    End Sub
    Public Sub DeleteColumn(ByVal Index As Integer)
        W.Columns.RemoveAt(Index)
        Save()
    End Sub
    Public Sub RemoveItem(ByVal index As Integer)
        W.Rows.RemoveAt(index)
        Save()
    End Sub
    Public Function Columns() As String()
        Dim q As New List(Of String)
        For Each x As DataColumn In W.Columns
            q.Add(x.ColumnName)
        Next
        Return q.ToArray
    End Function
    Public Function Columns(ByVal index As Integer) As String
        Return W.Columns(index).ColumnName
    End Function
    Public Function Items(ByVal index As Integer) As dbItem
        Return New dbItem(W.Rows(index), Me)
    End Function

    Public Function FindItem(ByVal ColmIndex As Integer, ByVal Value As String) As dbItem()
        Try
            Dim q As New List(Of dbItem)
            For Each x As Data.DataRow In _
            W.Select(Columns(ColmIndex) & " Like '" & Value & "'")
                q.Add(New dbItem(x, Me))
            Next
            Return q.ToArray
        Catch ex As Exception
            Return New dbItem() {}
        End Try
    End Function
    Public Sub ClearItems()
        W.Rows.Clear()
        Save()
    End Sub
    Public Function AddItem(ByVal ParamArray Values As String()) As dbItem
        If FindItem(0, Values(0)).Length = 0 Then
            Dim d = New dbItem(W.Rows.Add(Values), Me)
            Save()
            Return d
        Else
            Return FindItem(0, Values(0))(0)
        End If
    End Function
    Public Function Count() As Integer
        Return W.Rows.Count
    End Function
    Public Function Items() As dbItem()
        Dim q As New List(Of dbItem)
        SyncLock W.Rows
            For Each x As Data.DataRow In W.Rows
                q.Add(New dbItem(x, Me))
            Next
        End SyncLock
        Return q.ToArray
    End Function
    Public Class dbItem
        Private db As njdb
        Private rw As Data.DataRow
        Sub New(ByVal rw As Data.DataRow, ByVal db As njdb)
            Me.rw = rw
            Me.db = db
        End Sub
        Public Property Value(ByVal index As Integer) As String
            Get
                Return rw.Item(index)
            End Get
            Set(ByVal value As String)
                rw.Item(index) = value
                db.Save()
            End Set
        End Property
        Public Sub Remove()
            db.W.Rows.Remove(rw)
            db.Save()
        End Sub
        Public Property Value(ByVal ColmName As String) As String
            Get
                Return rw.Item(ColmName)
            End Get
            Set(ByVal value As String)
                rw.Item(ColmName) = value
                db.Save()
            End Set
        End Property
        Public Property Values() As Object()
            Get
                Return rw.ItemArray
            End Get
            Set(ByVal value As Object())
                rw.ItemArray = value
                db.Save()
            End Set
        End Property
    End Class
End Class