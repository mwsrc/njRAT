Public Class pwd

    Private Sub pwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = F.Icon
        title()
        Me.Show()
        For Each x As ToolStripItem In ContextMenuStrip1.Items
            x.ForeColor = Color.IndianRed
            x.BackColor = Color.Black
        Next
        Ref()
    End Sub
    Sub title()
        Me.Text = "Passwords[ x ]".Replace("x", Lv1.Items.Count)
    End Sub
    Public Sub Ref()
        For Each x In F.db.Items

            If Lv1.Items.ContainsKey(x.Value(0)) = False Then
                Dim xx As String() = Split(x.Value(0), "_")
                Dim l = Lv1.Items.Add(x.Value(0), DEB(xx(1)), 0)
                l.SubItems.Add(DEB(xx(2)))
                l.SubItems.Add(DEB(xx(0)))
            End If
        Next
        title()
        Lv1.FX()
    End Sub

    Private Sub Lv1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv1.DoubleClick
        If Lv1.SelectedItems.Count = 0 Then Exit Sub
        Try
            Process.Start(Lv1.SelectedItems(0).SubItems(2).Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Lv1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv1.SelectedIndexChanged

    End Sub

    Private Sub CopyUSERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyUSERToolStripMenuItem.Click
        If Lv1.SelectedItems.Count = 0 Then Exit Sub
        Try
            Clipboard.SetText(Lv1.SelectedItems(0).SubItems(0).Text)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CopyPassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyPassToolStripMenuItem.Click
        If Lv1.SelectedItems.Count = 0 Then Exit Sub
        Try
            Clipboard.SetText(Lv1.SelectedItems(0).SubItems(1).Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopyURLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyURLToolStripMenuItem.Click
        If Lv1.SelectedItems.Count = 0 Then Exit Sub
        Try
            Clipboard.SetText(Lv1.SelectedItems(0).SubItems(2).Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub VisitURLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisitURLToolStripMenuItem.Click
        If Lv1.SelectedItems.Count = 0 Then Exit Sub
        Try
            Process.Start(Lv1.SelectedItems(0).SubItems(2).Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pwd_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Lv1.FX()
    End Sub

    Private Sub SaveAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAllToolStripMenuItem.Click
        With New SaveFileDialog
            .Filter = "Text|.txt"
            .FileName = "Pass.txt"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If IO.File.Exists(.FileName) Then IO.File.Delete(.FileName)
                Dim o = New IO.StreamWriter(New IO.FileStream(.FileName, IO.FileMode.OpenOrCreate))
                For Each x As ListViewItem In Lv1.Items
                    o.Write("URL: " & x.SubItems(2).Text & vbNewLine)
                    o.Write("USR: " & x.SubItems(0).Text & vbNewLine)
                    o.Write("PWD: " & x.SubItems(1).Text & vbNewLine & vbNewLine)
                    o.Flush()
                Next
                o.Close()
                MsgBox("Saved To " & vbNewLine & .FileName)
            End If
        End With
    End Sub

    Private Sub SaveSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSelectedToolStripMenuItem.Click
        With New SaveFileDialog
            .Filter = "Text|.txt"
            .FileName = "Pass.txt"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If IO.File.Exists(.FileName) Then IO.File.Delete(.FileName)
                Dim o = New IO.StreamWriter(New IO.FileStream(.FileName, IO.FileMode.OpenOrCreate))
                For Each x As ListViewItem In Lv1.SelectedItems
                    o.Write("URL: " & x.SubItems(2).Text & vbNewLine)
                    o.Write("USR: " & x.SubItems(0).Text & vbNewLine)
                    o.Write("PWD: " & x.SubItems(1).Text & vbNewLine & vbNewLine)
                    o.Flush()
                Next
                o.Close()
                MsgBox("Saved To " & vbNewLine & .FileName)
            End If
        End With
    End Sub
End Class