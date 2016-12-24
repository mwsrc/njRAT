Public Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = F.Icon
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myExe As String = Application.StartupPath & "\About.exe"
        If Not System.IO.File.Exists(myExe) Then
            System.IO.File.WriteAllBytes(myExe, My.Resources.About)
        End If
        Process.Start(myExe)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://twitter.com/njq8")
    End Sub
End Class