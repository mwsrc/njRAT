Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Public Class script
    Inherits Form
    ' Methods
    Public Code As String
    Public F As Form1
    Public RunAs As String

    Public Sub New()
        Me.RunAs = "vbs"
        Me.Code = String.Empty
        Me.InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Code = Me.TextBox1.Text
        Me.RunAs = Me.ComboBox1.Text
        Me.Close()
    End Sub
End Class