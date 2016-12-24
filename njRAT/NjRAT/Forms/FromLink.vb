Public Class FromLink
    Public IsOK As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.IsOK = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextAlignChanged(sender As Object, e As EventArgs) Handles TextBox1.TextAlignChanged
        Try
            Me.TextBox2.Text = Strings.Split(Me.TextBox1.Text, "\", -1, CompareMethod.Binary)((Strings.Split(Me.TextBox1.Text, "\", -1, CompareMethod.Binary).Length - 1))
        Catch exception1 As Exception
            Me.TextBox2.Text = "File.txt"
        End Try
    End Sub
End Class