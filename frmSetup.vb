Public Class frmSetup

    Dim strFolder As String = ""
    Dim strA7800Folder As String = ""
    Dim strBoxArtFolder As String = ""
    Dim strManualsFolder As String = ""
    Dim strArguments As String = ""
    Dim strAddArguments As String = ""
    Dim strDebug As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGameROMpath.Click

        Using dlg As New SaveFileDialog With {.AddExtension = True,
                                              .AutoUpgradeEnabled = True,
                                              .CreatePrompt = False,
                                              .OverwritePrompt = False,
                                              .CheckFileExists = False,
                                              .CheckPathExists = True,
                                              .FileName = "Choose ROM Folder",
                                              .Filter = "All files (*.*)|*.*",
                                              .FilterIndex = 1,
                                              .InitialDirectory = "C:\",
                                              .SupportMultiDottedExtensions = True,
                                              .Title = "Select Atari 7800 ROM Folder",
                                              .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strFilename As String = dlg.FileName
                strFolder = System.IO.Path.GetDirectoryName(strFilename)
            End If
        End Using

        txtRomPath.Text = strFolder
        frmMain.txtRomPath.Text = strFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 ROM Path", strFolder)

    End Sub

    Private Sub btnBoxArtPath_Click(sender As Object, e As EventArgs) Handles btnBoxArtPath.Click

        Using dlg As New SaveFileDialog With {.AddExtension = True,
                                            .AutoUpgradeEnabled = True,
                                            .CreatePrompt = False,
                                            .OverwritePrompt = False,
                                            .CheckFileExists = False,
                                            .CheckPathExists = True,
                                            .FileName = "Choose Box Art Directory",
                                            .Filter = "All files (*.*)|*.*",
                                            .FilterIndex = 1,
                                            .InitialDirectory = "C:\",
                                            .SupportMultiDottedExtensions = True,
                                            .Title = "Select Box Art Directory",
                                            .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strFilename As String = dlg.FileName
                strBoxArtFolder = System.IO.Path.GetDirectoryName(strFilename)
            End If
        End Using

        txtBoxArtPath.Text = strBoxArtFolder
        frmMain.txtBoxArtPath.Text = strBoxArtFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Box Art Path", strBoxArtFolder)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Using dlg As New SaveFileDialog With {.AddExtension = True,
                                           .AutoUpgradeEnabled = True,
                                           .CreatePrompt = False,
                                           .OverwritePrompt = False,
                                           .CheckFileExists = False,
                                           .CheckPathExists = True,
                                           .FileName = "Choose Manuals Directory",
                                           .Filter = "All files (*.*)|*.*",
                                           .FilterIndex = 1,
                                           .InitialDirectory = "C:\",
                                           .SupportMultiDottedExtensions = True,
                                           .Title = "Select Manuals Directory",
                                           .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strFilename As String = dlg.FileName
                strManualsFolder = System.IO.Path.GetDirectoryName(strFilename)
            End If
        End Using

        txtManualsPath.Text = strManualsFolder
        frmMain.txtManualsPath.Text = strManualsFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Manuals Path", strManualsFolder)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using dlg As New SaveFileDialog With {.AddExtension = True,
                                            .AutoUpgradeEnabled = True,
                                            .CreatePrompt = False,
                                            .OverwritePrompt = False,
                                            .CheckFileExists = False,
                                            .CheckPathExists = True,
                                            .FileName = "Choose A7800 Directory",
                                            .Filter = "All files (*.*)|*.*",
                                            .FilterIndex = 1,
                                            .InitialDirectory = "C:\",
                                            .SupportMultiDottedExtensions = True,
                                            .Title = "Select A7800 Directory",
                                            .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strFilename As String = dlg.FileName
                strA7800Folder = System.IO.Path.GetDirectoryName(strFilename)
            End If
        End Using

        txtA7800path.Text = strA7800Folder
        frmMain.txtA7800path.Text = strA7800Folder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 A7800 Path", strA7800Folder)
    End Sub
    Public Sub frmSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtRomPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 ROM Path")
        txtA7800path.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 A7800 Path")
        txtBoxArtPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Box Art Path")
        txtManualsPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Manuals Path")

        Me.WebBrowser1.Navigate("about:blank")
        Me.WebBrowser1.Document.Write(String.Empty)
        Me.WebBrowser1.DocumentText = My.Resources.setup

    End Sub

    Private Sub frmContinue_Click(sender As Object, e As EventArgs) Handles frmContinue.Click
        frmMain.Show()

        Me.Close()

    End Sub
End Class