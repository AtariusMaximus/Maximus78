Public Class frmDifficulty
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub frmDifficulty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = True

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class