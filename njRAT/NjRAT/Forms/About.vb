Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class About

    Private Sub About_Load(sender As Object, e As EventArgs) Handles Me.Load
        RichTextBox1.Text = My.Resources.RichTextBox1
    End Sub
End Class