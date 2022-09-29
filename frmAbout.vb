Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WebBrowser1.Navigate("about:blank")
        Me.WebBrowser1.Document.Write(String.Empty)
        Me.WebBrowser1.DocumentText = My.Resources.setup

        Me.WebBrowser2.Navigate("about:blank")
        Me.WebBrowser2.Document.Write(String.Empty)
        Me.WebBrowser2.DocumentText = My.Resources.gplv3

    End Sub
    Private Sub DisplayHtml()

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 NTSC Retail ROM Subfolder", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 PAL Retail ROM Subfolder", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Homebrews ROM Subfolder", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Hacks ROM Subfolder", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Demos ROM Subfolder", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Prototypes ROM Subfolder", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Utilities ROM Subfolder", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 A7800 Path", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Manuals Path", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Box Art Path", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 ROM Path", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Display Mode", "")
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 StatusBar", "")

    End Sub

    Private Sub btnFirstTime_Click(sender As Object, e As EventArgs) Handles btnFirstTime.Click
        frmSetup.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class