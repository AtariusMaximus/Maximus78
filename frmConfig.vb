Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmA7800Config
    Private Sub frmA7800Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtINIPath.Text = frmMain.txtA7800path.Text + "\a7800.ini"

        'My.Computer.FileSystem.WriteAllText(txtINIPath.Text, txta7800ini.Text, False)

        Try
            For Each s As String In System.IO.File.ReadAllLines(txtINIPath.Text)
                txta7800ini.AppendText(s + vbNewLine)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        txta7800ini.Clear()
        Try
            For Each s As String In System.IO.File.ReadAllLines(txtINIPath.Text)
                txta7800ini.AppendText(s + vbNewLine)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            My.Computer.FileSystem.WriteAllText(txtINIPath.Text, txta7800ini.Text, False)
        Catch
            MessageBox.Show("Error writing file")
        End Try

        MessageBox.Show("Text saved to " & txtINIPath.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txta7800ini.Clear()
    End Sub
End Class