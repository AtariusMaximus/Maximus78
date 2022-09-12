Imports System.IO
Imports System.Net.WebRequestMethods
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmSettings


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aPath As String = Application.StartupPath()
        'rompath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 ROM Path")
        'a7800path.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 A7800 Path")
        'boxartpath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Box Art Path")
        'manualspath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Manuals Path")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'My.Computer.Registry.CurrentUser.SetValue("Maximus78 ROM Path", strFolder)
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
