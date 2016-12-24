Public Class FURL

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown, Me.KeyDown
        If e.KeyCode = Keys.Enter Then Button1_Click(sender, e)
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            TextBox2.Text = Split(TextBox1.Text, ".")(Split(TextBox1.Text, ".").Length - 1)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub FURL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public IsOK As Boolean = False
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length > 0 And TextBox2.TextLength > 0 Then
            If TextBox1.Text.ToLower.StartsWith("http") = False Then
                TextBox1.Text &= "http://"
            End If
            IsOK = True
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class