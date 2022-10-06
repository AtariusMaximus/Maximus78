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
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 NTSC Retail ROM Subfolder", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 PAL Retail ROM Subfolder", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Homebrews ROM Subfolder", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Hacks ROM Subfolder", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Demos ROM Subfolder", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Prototypes ROM Subfolder", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Utilities ROM Subfolder", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 A7800 Path", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Manuals Path", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Box Art Path", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 ROM Path", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Display Mode", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 StatusBar", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Option Debug Mode", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Option Developer Mode", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Option HSC", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Option XM", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Option TripleBuffer", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Option Vsync Wait", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Window Option Full Screen", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Window Option Stretch", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Option Warm Palette", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Option Cool Palette", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Option Hot Palette", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Box Video Option Compatibility", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Box Video Option Basic", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Box Video Option CRT", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Box Video Option CRT Deluxe", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Box Video Option Super Eagle", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Box Video Option HLSL", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Box Video Option HQ2x", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Box Video Option HQ2x", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Maximus78", "Maximus78 Box Video Option HQ4x", "")
    End Sub

    Private Sub btnFirstTime_Click(sender As Object, e As EventArgs) Handles btnFirstTime.Click
        frmSetup.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnClearHS_Click(sender As Object, e As EventArgs) Handles btnClearHS.Click
        frmMain.txtScore1.Text = ""
        frmMain.txtScore2.Text = ""
        frmMain.txtScore3.Text = ""
        frmMain.txtScore4.Text = ""
        frmMain.txtScore5.Text = ""
        frmMain.txtScore6.Text = ""
        frmMain.txtScore7.Text = ""
        frmMain.txtScore8.Text = ""
        frmMain.txtScore9.Text = ""
        frmMain.txtScore10.Text = ""
        frmMain.txtScore11.Text = ""
        frmMain.txtScore12.Text = ""
        frmMain.txtScore13.Text = ""
        frmMain.txtScore14.Text = ""
        frmMain.txtScore15.Text = ""
        frmMain.txtScore16.Text = ""
        frmMain.txtScore17.Text = ""
        frmMain.txtScore18.Text = ""
        frmMain.txtScore19.Text = ""
        frmMain.txtScore20.Text = ""
        frmMain.txtScore21.Text = ""
        frmMain.txtScore22.Text = ""
        frmMain.txtScore23.Text = ""
        frmMain.txtScore24.Text = ""
        frmMain.txtScore25.Text = ""
        frmMain.txtScore26.Text = ""
        frmMain.txtScore27.Text = ""
        frmMain.txtPlayer1.Text = ""
        frmMain.txtPlayer2.Text = ""
        frmMain.txtPlayer3.Text = ""
        frmMain.txtPlayer4.Text = ""
        frmMain.txtPlayer5.Text = ""
        frmMain.txtPlayer6.Text = ""
        frmMain.txtPlayer7.Text = ""
        frmMain.txtPlayer8.Text = ""
        frmMain.txtPlayer9.Text = ""
        frmMain.txtPlayer10.Text = ""
        frmMain.txtPlayer11.Text = ""
        frmMain.txtPlayer12.Text = ""
        frmMain.txtPlayer13.Text = ""
        frmMain.txtPlayer14.Text = ""
        frmMain.txtPlayer15.Text = ""
        frmMain.txtPlayer16.Text = ""
        frmMain.txtPlayer17.Text = ""
        frmMain.txtPlayer18.Text = ""
        frmMain.txtPlayer19.Text = ""
        frmMain.txtPlayer20.Text = ""
        frmMain.txtPlayer21.Text = ""
        frmMain.txtPlayer22.Text = ""
        frmMain.txtPlayer23.Text = ""
        frmMain.txtPlayer24.Text = ""
        frmMain.txtPlayer25.Text = ""
        frmMain.txtPlayer26.Text = ""
        frmMain.txtPlayer27.Text = ""
        frmMain.txtDate1.Text = ""
        frmMain.txtDate2.Text = ""
        frmMain.txtDate3.Text = ""
        frmMain.txtDate4.Text = ""
        frmMain.txtDate5.Text = ""
        frmMain.txtDate6.Text = ""
        frmMain.txtDate7.Text = ""
        frmMain.txtDate8.Text = ""
        frmMain.txtDate9.Text = ""
        frmMain.txtDate10.Text = ""
        frmMain.txtDate11.Text = ""
        frmMain.txtDate12.Text = ""
        frmMain.txtDate13.Text = ""
        frmMain.txtDate14.Text = ""
        frmMain.txtDate15.Text = ""
        frmMain.txtDate16.Text = ""
        frmMain.txtDate17.Text = ""
        frmMain.txtDate18.Text = ""
        frmMain.txtDate19.Text = ""
        frmMain.txtDate20.Text = ""
        frmMain.txtDate21.Text = ""
        frmMain.txtDate22.Text = ""
        frmMain.txtDate23.Text = ""
        frmMain.txtDate24.Text = ""
        frmMain.txtDate25.Text = ""
        frmMain.txtDate26.Text = ""
        frmMain.txtDate27.Text = ""
        frmMain.txtInitials1.Text = ""
        frmMain.txtInitials2.Text = ""
        frmMain.txtInitials3.Text = ""
        frmMain.txtInitials4.Text = ""
        frmMain.txtInitials5.Text = ""
        frmMain.txtInitials6.Text = ""
        frmMain.txtInitials7.Text = ""
        frmMain.txtInitials8.Text = ""
        frmMain.txtInitials9.Text = ""
        frmMain.txtInitials10.Text = ""
        frmMain.txtInitials11.Text = ""
        frmMain.txtInitials12.Text = ""
        frmMain.txtInitials13.Text = ""
        frmMain.txtInitials14.Text = ""
        frmMain.txtInitials15.Text = ""
        frmMain.txtInitials16.Text = ""
        frmMain.txtInitials17.Text = ""
        frmMain.txtInitials18.Text = ""
        frmMain.txtInitials19.Text = ""
        frmMain.txtInitials20.Text = ""
        frmMain.txtInitials21.Text = ""
        frmMain.txtInitials22.Text = ""
        frmMain.txtInitials23.Text = ""
        frmMain.txtInitials24.Text = ""
        frmMain.txtInitials25.Text = ""
        frmMain.txtInitials26.Text = ""
        frmMain.txtInitials27.Text = ""
    End Sub
End Class