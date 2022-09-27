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
        txtNTSCRetailPath.Text = strFolder + "\Retail_v3_0\NTSC"
        txtPALRetailPath.Text = strFolder + "\Retail_v3_0\PAL"
        txtHomebrewPath.Text = strFolder + "\HHDP_20220627\Homebrews"
        txtHacksPath.Text = strFolder + "\HHDP_20220627\Hacks"
        txtDemosPath.Text = strFolder + "\HHDP_20220627\Demos"
        txtProtosPath.Text = strFolder + "\HHDP_20220627\Prototypes"
        txtUtilitiesPath.Text = strFolder + "\HHDP_20220627\Utilities"

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
        Me.CenterToScreen()

        txtRomPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 ROM Path")
        txtA7800path.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 A7800 Path")
        txtBoxArtPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Box Art Path")
        txtManualsPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Manuals Path")

        Me.WebBrowser1.Navigate("about:blank")
        Me.WebBrowser1.Document.Write(String.Empty)
        Me.WebBrowser1.DocumentText = My.Resources.setup

    End Sub

    Private Sub frmContinue_Click(sender As Object, e As EventArgs) Handles frmContinue.Click

        'Display the blank box art file to start with on the main form.
        Try
            frmMain.pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        Catch ex As Exception
        End Try

        'Save folder paths to the Regsitry
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 NTSC Retail ROM Subfolder", txtNTSCRetailPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 PAL Retail ROM Subfolder", txtPALRetailPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Homebrews ROM Subfolder", txtHomebrewPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Hacks ROM Subfolder", txtHacksPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Demos ROM Subfolder", txtDemosPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Prototypes ROM Subfolder", txtProtosPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Utilities ROM Subfolder", txtUtilitiesPath.Text)

        frmMain.txtNTSCRetailPath.Text = txtNTSCRetailPath.Text
        frmMain.txtPALRetailPath.Text = txtPALRetailPath.Text
        frmMain.txtHomebrewPath.Text = txtHomebrewPath.Text
        frmMain.txtHacksPath.Text = txtHacksPath.Text
        frmMain.txtDemosPath.Text = txtDemosPath.Text
        frmMain.txtProtosPath.Text = txtProtosPath.Text
        frmMain.txtUtilitiesPath.Text = txtUtilitiesPath.Text

        'Populate ROM Lists on the Main Form
        Try
            Dim a78filesMain = txtNTSCRetailPath.Text
            For Each file As String In System.IO.Directory.GetFiles(a78filesMain, "*.a78")
                frmMain.lstNTSCRetail.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
            Next
        Catch ex As Exception
        End Try

        Try
            Dim a78filesPAL = txtPALRetailPath.Text
            For Each filePAL As String In System.IO.Directory.GetFiles(a78filesPAL, "*.a78")
                frmMain.lstPALRetail.Items.Add(System.IO.Path.GetFileNameWithoutExtension(filePAL))
            Next
        Catch ex As Exception
        End Try

        Try
            Dim a78filesHomebrews = txtHomebrewPath.Text
            For Each fileHomebrews As String In System.IO.Directory.GetFiles(a78filesHomebrews, "*.a78")
                frmMain.lstHomebrews.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileHomebrews))
            Next
        Catch ex As Exception
        End Try

        Try
            Dim a78filesHacks = txtHacksPath.Text
            For Each fileHacks As String In System.IO.Directory.GetFiles(a78filesHacks, "*.a78")
                frmMain.lstHacks.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileHacks))
            Next
        Catch ex As Exception
        End Try

        Try
            Dim a78filesDemos = txtDemosPath.Text
            For Each fileDemos As String In System.IO.Directory.GetFiles(a78filesDemos, "*.a78")
                frmMain.lstDemos.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileDemos))
            Next
        Catch ex As Exception
        End Try

        Try
            Dim a78filesProtos = txtProtosPath.Text
            For Each fileProtos As String In System.IO.Directory.GetFiles(a78filesProtos, "*.a78")
                frmMain.lstProtos.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileProtos))
            Next
        Catch ex As Exception
        End Try

        Try
            Dim a78filesUtilities = txtUtilitiesPath.Text
            For Each fileUtilities As String In System.IO.Directory.GetFiles(a78filesUtilities, "*.a78")
                frmMain.lstUtilities.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileUtilities))
            Next
        Catch ex As Exception
        End Try

        frmMain.txtRootROMPath.Text = strFolder

        frmMain.Show()

        Me.Close()

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using dlg As New SaveFileDialog With {.AddExtension = True,
                                   .AutoUpgradeEnabled = True,
                                   .CreatePrompt = False,
                                   .OverwritePrompt = False,
                                   .CheckFileExists = False,
                                   .CheckPathExists = True,
                                   .FileName = "Choose NTSC Retail ROM Subdirectory",
                                   .Filter = "All files (*.*)|*.*",
                                   .FilterIndex = 1,
                                   .InitialDirectory = "C:\",
                                   .SupportMultiDottedExtensions = True,
                                   .Title = "Select NTSC Retail ROM Subdirectory",
                                   .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strFilename As String = dlg.FileName
                strManualsFolder = System.IO.Path.GetDirectoryName(strFilename)
            End If
        End Using

        txtNTSCRetailPath.Text = strManualsFolder
        frmMain.txtNTSCRetailPath.Text = strManualsFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 NTSC Retail ROM Subfolder", txtNTSCRetailPath.Text)
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Application.Exit()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Using dlg As New SaveFileDialog With {.AddExtension = True,
                           .AutoUpgradeEnabled = True,
                           .CreatePrompt = False,
                           .OverwritePrompt = False,
                           .CheckFileExists = False,
                           .CheckPathExists = True,
                           .FileName = "Choose PAL Retail ROM Subdirectory",
                           .Filter = "All files (*.*)|*.*",
                           .FilterIndex = 1,
                           .InitialDirectory = "C:\",
                           .SupportMultiDottedExtensions = True,
                           .Title = "Select PAL Retail ROM Subdirectory",
                           .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strFilename As String = dlg.FileName
                strManualsFolder = System.IO.Path.GetDirectoryName(strFilename)
            End If
        End Using

        txtPALRetailPath.Text = strManualsFolder
        frmMain.txtPALRetailPath.Text = strManualsFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 PAL Retail ROM Subfolder", txtPALRetailPath.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Using dlg As New SaveFileDialog With {.AddExtension = True,
                   .AutoUpgradeEnabled = True,
                   .CreatePrompt = False,
                   .OverwritePrompt = False,
                   .CheckFileExists = False,
                   .CheckPathExists = True,
                   .FileName = "Choose Homebrew ROM Subdirectory",
                   .Filter = "All files (*.*)|*.*",
                   .FilterIndex = 1,
                   .InitialDirectory = "C:\",
                   .SupportMultiDottedExtensions = True,
                   .Title = "Select Homebrew ROM Subdirectory",
                   .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strFilename As String = dlg.FileName
                strManualsFolder = System.IO.Path.GetDirectoryName(strFilename)
            End If
        End Using

        txtHomebrewPath.Text = strManualsFolder
        frmMain.txtHomebrewPath.Text = strManualsFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Homebrews ROM Subfolder", txtHomebrewPath.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Using dlg As New SaveFileDialog With {.AddExtension = True,
           .AutoUpgradeEnabled = True,
           .CreatePrompt = False,
           .OverwritePrompt = False,
           .CheckFileExists = False,
           .CheckPathExists = True,
           .FileName = "Choose Hacks ROM Subdirectory",
           .Filter = "All files (*.*)|*.*",
           .FilterIndex = 1,
           .InitialDirectory = "C:\",
           .SupportMultiDottedExtensions = True,
           .Title = "Select Hacks ROM Subdirectory",
           .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strFilename As String = dlg.FileName
                strManualsFolder = System.IO.Path.GetDirectoryName(strFilename)
            End If
        End Using

        txtHacksPath.Text = strManualsFolder
        frmMain.txtHacksPath.Text = strManualsFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Hacks ROM Subfolder", txtHacksPath.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Using dlg As New SaveFileDialog With {.AddExtension = True,
           .AutoUpgradeEnabled = True,
           .CreatePrompt = False,
           .OverwritePrompt = False,
           .CheckFileExists = False,
           .CheckPathExists = True,
           .FileName = "Choose Demos ROM Subdirectory",
           .Filter = "All files (*.*)|*.*",
           .FilterIndex = 1,
           .InitialDirectory = "C:\",
           .SupportMultiDottedExtensions = True,
           .Title = "Select Demos ROM Subdirectory",
           .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strFilename As String = dlg.FileName
                strManualsFolder = System.IO.Path.GetDirectoryName(strFilename)
            End If
        End Using

        txtDemosPath.Text = strManualsFolder
        frmMain.txtDemosPath.Text = strManualsFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Demos ROM Subfolder", txtDemosPath.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Using dlg As New SaveFileDialog With {.AddExtension = True,
           .AutoUpgradeEnabled = True,
           .CreatePrompt = False,
           .OverwritePrompt = False,
           .CheckFileExists = False,
           .CheckPathExists = True,
           .FileName = "Choose Protos ROM Subdirectory",
           .Filter = "All files (*.*)|*.*",
           .FilterIndex = 1,
           .InitialDirectory = "C:\",
           .SupportMultiDottedExtensions = True,
           .Title = "Select Protos ROM Subdirectory",
           .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strFilename As String = dlg.FileName
                strManualsFolder = System.IO.Path.GetDirectoryName(strFilename)
            End If
        End Using

        txtProtosPath.Text = strManualsFolder
        frmMain.txtProtosPath.Text = strManualsFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Protos ROM Subfolder", txtProtosPath.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Using dlg As New SaveFileDialog With {.AddExtension = True,
           .AutoUpgradeEnabled = True,
           .CreatePrompt = False,
           .OverwritePrompt = False,
           .CheckFileExists = False,
           .CheckPathExists = True,
           .FileName = "Choose Utilities ROM Subdirectory",
           .Filter = "All files (*.*)|*.*",
           .FilterIndex = 1,
           .InitialDirectory = "C:\",
           .SupportMultiDottedExtensions = True,
           .Title = "Select Utilities ROM Subdirectory",
           .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strFilename As String = dlg.FileName
                strManualsFolder = System.IO.Path.GetDirectoryName(strFilename)
            End If
        End Using

        txtUtilitiesPath.Text = strManualsFolder
        frmMain.txtUtilitiesPath.Text = strManualsFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Utilities ROM Subfolder", txtUtilitiesPath.Text)
    End Sub
End Class