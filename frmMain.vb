Imports System.CodeDom
Imports System.Net

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Get Current Registry Settings for Directory Paths
        txtRomPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 ROM Path")
        txtA7800path.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 A7800 Path")
        txtBoxArtPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Box Art Path")
        txtManualsPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Manuals Path")

        'Set them all to C:\ if the entries don't exist or are blank
        'Afterwards, if they are all C:\ we will launch the first time setup dialog

        'If Box Then Art Path isn't set yet, just set it to C:\
        If txtBoxArtPath.Text = "" Then
            strBoxArtFolder = "C:\"
            My.Computer.Registry.CurrentUser.SetValue("Maximus78 Box Art Path", "C:\")
        End If

        'If manuals Path isn't set yet, just set it to C:\
        If txtManualsPath.Text = "" Then
            strManualsFolder = "C:\"
            txtManualsPath.Text = "C:\"
            My.Computer.Registry.CurrentUser.SetValue("Maximus78 Manuals Path", "C:\")
        End If

        'If A7800 Path isn't set yet, just set it to C:\
        If txtA7800path.Text = "" Then
            strA7800Folder = "C:\"
            txtA7800path.Text = "C:\"
            My.Computer.Registry.CurrentUser.SetValue("Maximus78 A7800 Path", "C:\")
        End If

        'If ROM Path isn't set yet, just set it to C:\
        If txtRomPath.Text = "" Then
            strFolder = "C:\"
            txtRomPath.Text = "C:\"
            My.Computer.Registry.CurrentUser.SetValue("Maximus78 ROM Path", "C:\")
        End If

        'If all Paths are set to C:\, show setup dialog
        'If txtBoxArtPath.Text = "C:\" And txtA7800path.Text = "C:\" And txtBoxArtPath.Text = "C:\" And txtManualsPath.Text = "C:\" Then
        'frmSetup.ShowDialog()
        'End If

        ' Get Subfolder Paths from Registry
        txtNTSCRetailPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 NTSC Retail ROM Subfolder")
        txtPALRetailPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 PAL Retail ROM Subfolder")
        txtHomebrewPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Homebrews ROM Subfolder")
        txtHacksPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Hacks ROM Subfolder")
        txtDemosPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Demos ROM Subfolder")
        txtProtosPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Prototypes ROM Subfolder")
        txtUtilitiesPath.Text = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Utilities ROM Subfolder")

        'If the A7800 path is not set to C:\ and the ROM utilities path is blank, assume first time setup and show setup dialog
        If txtA7800path.Text = "C:\" Or txtUtilitiesPath.Text = "" Then
            frmSetup.ShowDialog()
        End If

        strFolder = My.Computer.Registry.CurrentUser.GetValue("Maximus78 ROM Path")
        strA7800Folder = My.Computer.Registry.CurrentUser.GetValue("Maximus78 A7800 Path")
        strBoxArtFolder = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Box Art Path")
        strManualsFolder = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Manuals Path")

        strStatusBar = My.Computer.Registry.CurrentUser.GetValue("Maximus78 StatusBar")
        strWindowMode = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Display Mode")

        strArguments = "a7800"
        strAddArguments = "-cart"
        NTSCToolStripMenuItem.Checked = True
        PALToolStripMenuItem.Checked = False


        '-----------------------------------------------------------------------------
        'Check Registry entry for Status Bar
        If strStatusBar = "On" Then
            StatusStrip1.Visible = True
            statusON.Checked = True
            statusOFF.Checked = False
            If Me.Height = 355 Then
                StatusStrip1.Visible = False
                statusON.Checked = False
                statusOFF.Checked = True
            End If
            If strWindowMode = "Med" Then
                StatusStrip1.Visible = False
                statusON.Checked = False
                statusOFF.Checked = True
            End If
        End If
        If strStatusBar = "Off" Then
            StatusStrip1.Visible = False
            statusON.Checked = False
            statusOFF.Checked = True
        End If
        If strStatusBar = "" Then
            StatusStrip1.Visible = False
            statusON.Checked = False
            statusOFF.Checked = True
        End If
        If strWindowMode = "Med" Then
            StatusStrip1.Visible = False
            statusON.Checked = False
            statusOFF.Checked = True
        End If
        If strWindowMode = "Small" Then
            StatusStrip1.Visible = False
            statusON.Checked = False
            statusOFF.Checked = True
        End If
        '-----------------------------------------------------------------------------

        '-----------------------------------------------------------------------------
        'Check Registry for Window Mode
        If strWindowMode = "" Then
            Me.Width = 1366
            Me.Height = 748
            lstNTSCRetail.Height = 660
            lstPALRetail.Height = 660
            lstHomebrews.Height = 660
            lstHacks.Height = 660
            lstDemos.Height = 660
            lstProtos.Height = 660
            lstUtilities.Height = 660
            displayFULL.Checked = True
            displayMED.Checked = False
            displaySMALL.Checked = False
        End If
        If strWindowMode = "Full" Then
            Me.Width = 1366
            Me.Height = 748
            lstNTSCRetail.Height = 660
            lstPALRetail.Height = 660
            lstHomebrews.Height = 660
            lstHacks.Height = 660
            lstDemos.Height = 660
            lstProtos.Height = 660
            lstUtilities.Height = 660
            displayFULL.Checked = True
            displayMED.Checked = False
            displaySMALL.Checked = False
        End If
        If strWindowMode = "Med" Then
            Me.Width = 876
            Me.Height = 732
            lstNTSCRetail.Height = 660
            lstPALRetail.Height = 660
            lstHomebrews.Height = 660
            lstHacks.Height = 660
            lstDemos.Height = 660
            lstProtos.Height = 660
            lstUtilities.Height = 660
            displayFULL.Checked = False
            displayMED.Checked = True
            displaySMALL.Checked = False
        End If
        If strWindowMode = "Small" Then
            Me.Width = 474
            Me.Height = 355
            lstNTSCRetail.Height = 260
            lstPALRetail.Height = 260
            lstHomebrews.Height = 260
            lstHacks.Height = 260
            lstDemos.Height = 260
            lstProtos.Height = 260
            lstUtilities.Height = 260
            TabControlRoms.Height = 284
            'Turn off status bar if you choose the smallest window
            'statusTVType.Visible = False
            'statusPalette.Visible = False
            'statusXM.Visible = False
            'statusHSC.Visible = False
            'statusDev.Visible = False
            'statusDebug.Visible = False
            'statusVideo.Visible = False
            statusON.Checked = False
            statusOFF.Checked = True
            displayFULL.Checked = False
            displayMED.Checked = False
            displaySMALL.Checked = True
        End If
        '-----------------------------------------------------------------------------

        'If the registry entry For the NTSC path isn't already set, this code will display a warning msg.
        Try
            Dim a78filesMain = txtNTSCRetailPath.Text
            For Each file As String In System.IO.Directory.GetFiles(a78filesMain, "*.a78")
                lstNTSCRetail.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        'If the registry entry For the PAL path isn't already set, this code will display a warning msg.
        Try
            Dim a78filesPAL = txtPALRetailPath.Text
            For Each filePAL As String In System.IO.Directory.GetFiles(a78filesPAL, "*.a78")
                lstPALRetail.Items.Add(System.IO.Path.GetFileNameWithoutExtension(filePAL))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        'If the registry entry For the Homebrews path isn't already set, this code will display a warning msg.
        Try
            Dim a78filesHomebrews = txtHomebrewPath.Text
            For Each fileHomebrews As String In System.IO.Directory.GetFiles(a78filesHomebrews, "*.a78")
                lstHomebrews.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileHomebrews))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        'If the registry entry For the Hacks path isn't already set, this code will display a warning msg.
        Try
            Dim a78filesHacks = txtHacksPath.Text
            For Each fileHacks As String In System.IO.Directory.GetFiles(a78filesHacks, "*.a78")
                lstHacks.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileHacks))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        'If the registry entry For the Demos path isn't already set, this code will display a warning msg.
        Try
            Dim a78filesDemos = txtDemosPath.Text
            For Each fileDemos As String In System.IO.Directory.GetFiles(a78filesDemos, "*.a78")
                lstDemos.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileDemos))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        'If the registry entry For the Prototypes path isn't already set, this code will display a warning msg.
        Try
            Dim a78filesProtos = txtProtosPath.Text
            For Each fileProtos As String In System.IO.Directory.GetFiles(a78filesProtos, "*.a78")
                lstProtos.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileProtos))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        'If the registry entry For the Utilities path isn't already set, this code will display a warning msg.
        Try
            Dim a78filesUtilities = txtUtilitiesPath.Text
            For Each fileUtilities As String In System.IO.Directory.GetFiles(a78filesUtilities, "*.a78")
                lstUtilities.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileUtilities))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        txtRootROMPath.Text = strFolder
        'txtNTSCRetailPath.Text = strFolder + "\Retail_v3_0\NTSC"
        'txtPALRetailPath.Text = strFolder + "\Retail_v3_0\PAL"
        'txtHomebrewPath.Text = strFolder + "\HHDP_20220627\Homebrews"
        'txtHacksPath.Text = strFolder + "\HHDP_20220627\Hacks"
        'txtDemosPath.Text = strFolder + "\HHDP_20220627\Demos"
        'txtProtosPath.Text = strFolder + "\HHDP_20220627\Prototypes"
        'txtUtilitiesPath.Text = strFolder + "\HHDP_20220627\Utilities"



        Try
            pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        Catch ex As Exception
        End Try


    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'frmSettings.Show()
    End Sub

    Private Sub lstNTSCRetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNTSCRetail.SelectedIndexChanged

        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        strFolder = txtNTSCRetailPath.Text
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtNTSCRetailPath.Text + "\" + lstNTSCRetail.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        'If System.Windows.Forms.ListBox.SelectedItem = Nothing Then
        '  Exit Sub
        'End If

        'System.NullReferenceException 'Object reference not set to an instance of an object.'
        'System.Windows.Forms.ListBox.SelectedItem.get returned Nothing.

        If lstNTSCRetail.SelectedItem.ToString = "Ace of Aces (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ace of Aces (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ace of Aces (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ace of Aces (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ace of Aces (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Alien Brigade (NTSC) (Joystick) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alien Brigade (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alien Brigade (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alien_Brigade.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien_Brigade.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Alien Brigade (NTSC) (Lightgun) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alien Brigade (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alien Brigade (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alien_Brigade.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien_Brigade.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Asteroids (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Ballblazer (NTSC) (Atari-Lucasfilm) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ballblazer (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ballblazer (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ballblazer.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ballblazer.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Barnyard Blaster (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Barnyard Blaster (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Barnyard Blaster (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Barnyard_Blaster.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Barnyard_Blaster.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Basketbrawl (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Basketbrawl (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Basketbrawl (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Basketbrawl.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Basketbrawl.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Centipede (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Choplifter (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Choplifter! (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Choplifter! (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Choplifter.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Choplifter.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Commando (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Commando (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Commando (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Commando.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Commando.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Crack'ed (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crack'ed (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crack'ed (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crack'ed.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crack'ed.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Crossbow (NTSC) (Joystick) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Crossbow (NTSC) (Lightgun) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Dark Chambers (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dark Chambers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dark Chambers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dark_Chambers.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dark_Chambers.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Desert Falcon (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Desert Falcon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Desert Falcon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Desert_Falcon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Desert_Falcon.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Dig Dug (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dig Dug (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dig Dug (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dig_Dug.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dig_Dug.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Donkey Kong (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey_Kong.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey_Kong.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Donkey Kong (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey_Kong.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey_Kong.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Donkey Kong Jr (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong Junior (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong Junior (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey_Kong_Jr.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey_Kong_Jr.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Double Dragon (AB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double_Dragon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double_Dragon.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Double Dragon (OB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double_Dragon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double_Dragon.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "F-18 Hornet (NTSC) (Absolute) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\F-18 Hornet (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\F-18 Hornet (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\F-18_Hornet.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\F-18_Hornet.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Fatal Run (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fatal Run (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fatal Run (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fatal_Run.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fatal_Run.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Fight Night (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fight Night (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fight Night (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fight_Night.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fight_Night.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Food Fight (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Food Fight (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Food Fight (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Food_Fight.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Food_Fight.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Galaga (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Hat Trick (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hat Trick (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hat Trick (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hat_Trick.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hat_Trick.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Ikari Warriors (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ikari Warriors (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ikari Warriors (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ikari_Warriors.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ikari_Warriors.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Impossible Mission (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible_Mission.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible_Mission.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Jinks (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jinks (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jinks (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jinks.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jinks.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Joust (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "KC Munchkin (20140408)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\K.C. Munchkin (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\K.C. Munchkin (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\KC_Munchkin.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\KC_Munchkin.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "KC Munchkin (Alt Movement) (20170409)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\K.C. Munchkin (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\K.C. Munchkin (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\KC_Munchkin.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\KC_Munchkin.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Karateka (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Karateka (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Karateka (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Karateka.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Karateka.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Klax (19xx)(Atari)(NTSC)(Prototype)(Fixed)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Klax (USA) (Proto).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Klax (USA) (Proto).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Klax.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Klax.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Kung-Fu Master (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu_Master.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu_Master.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Mario Bros (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros. (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros. (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario_Bros.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario_Bros.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Mat Mania Challenge (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mat Mania Challenge (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mat Mania Challenge (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mat_Mania_Challenge.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mat_Mania_Challenge.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Mean 18 Ultimate Golf (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mean 18 Ultimate Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mean 18 Ultimate Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mean_18.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mean_18.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Meltdown (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meltdown (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meltdown (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meltdown.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meltdown.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Midnight Mutants (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Midnight Mutants (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Midnight Mutants (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Midnight_Mutants.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Midnight_Mutants.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Motor Psycho (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Motor Psycho (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Motor Psycho (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Motor_Psycho.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Motor_Psycho.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Ms Pac-Man (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms_Pac-Man.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Ninja Golf (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ninja Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ninja Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ninja_Golf.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ninja_Golf.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "One-on-One Basketball (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\One-on-One Basketball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\One-on-One Basketball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\One-on-One_Basketball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\One-on-One_Basketball.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Pete Rose Baseball (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pete Rose Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pete Rose Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pete_Rose_Baseball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pete_Rose_Baseball.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Planet Smashers (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Planet Smashers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Planet Smashers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Planet_Smashers.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Planet_Smashers.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Pole Position II (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Position II (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Position II (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole_Position_II.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole_Position_II.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Rampage (AB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rampage (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rampage (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rampage.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rampage.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Rampage (OB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rampage (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rampage (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rampage.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rampage.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "RealSports Baseball (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RealSports Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RealSports Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\RealSports_Baseball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\RealSports_Baseball.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Robotron 2084 (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robotron - 2084 (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robotron - 2084 (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robotron_2084.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robotron_2084.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Scrapyard Dog (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard_Dog.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard_Dog.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Sentinel (NTSC) (Finished Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sentinel (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sentinel (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sentinel.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sentinel.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Sentinel (PAL) (Atari) (1991)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sentinel (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sentinel (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sentinel.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sentinel.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Summer Games (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Summer Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Summer Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Summer_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Summer_Games.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Super Huey UH-IX (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Huey UH-IX (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Huey UH-IX (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Huey_UH-IX.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Huey_UH-IX.htm"))
            End If
        End If


        If lstNTSCRetail.SelectedItem.ToString = "Super Skateboardin' (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Skateboardin' (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Skateboardin' (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Skateboardin.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Skateboardin.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Tank Command (NTSC) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tank Command (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tank Command (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tank_Command.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tank_Command.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "TiME Salvo (20160910)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Time Salvo (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Time Salvo (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\TiME_Salvo.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\TiME_Salvo.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Title Match Pro Wrestling (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Title Match Pro Wrestling (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Title Match Pro Wrestling (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Title_Match_Pro_Wrestling.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Title_Match_Pro_Wrestling.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Tomcat - The F-14 Fighter Simulator (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tomcat - The F-14 Fighter Simulator (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tomcat - The F-14 Fighter Simulator (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\F-14_Tomcat.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\F-14_Tomcat.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Touchdown Football (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Touchdown Football (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Touchdown Football (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Touchdown_Football.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Touchdown_Football.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Tower Toppler (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tower Toppler (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tower Toppler (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tower_Toppler.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tower_Toppler.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Water Ski (NTSC) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Water Ski (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Water Ski (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Water_Ski.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Water_Ski.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Winter Games (Alternate) (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Winter_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter_Games.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Winter Games (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Winter_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter_Games.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Xenophobe (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xenophobe (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xenophobe (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xenophobe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xenophobe.htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Xevious (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xevious (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xevious (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xevious.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xevious.htm"))
            End If
        End If

    End Sub

    Public Sub btnSelectDirectory_Click(sender As Object, e As EventArgs)

        'Try<o:p>

        'Statements that might produce a runtime error<o:p>

        'Catch<o:p>

        'Statements to run if runtime errors occur<o:p>

        'Finally<o:p>

        'Optional statements to run whether an error occur or not<o:p>

        'End Try

        'While lstNTSCRetail.Items.Count > 0
        'lstNTSCRetail.Items.RemoveAt(lstNTSCRetail.Items.Count - 1)
        'End While

        'For Each LBEntry In lstNTSCRetail.Items
        'lstNTSCRetail.Items.Remove(LBEntry)
        'Next

        lstNTSCRetail.Items.Clear()
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

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
        'MsgBox(strFolder)
        MsgBox(strFolder, 64, "ROM Directory Path Selected")
        txtRomPath.Text = strFolder
        Dim a78filesMain = strFolder
        For Each file As String In System.IO.Directory.GetFiles(a78filesMain, "*.a78")
            lstNTSCRetail.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

        'Save Game Folder to INI file

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 ROM Path", strFolder)


    End Sub
    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
    Private Sub lstNTSCRetail_Format(sender As Object, e As ListControlConvertEventArgs) Handles lstNTSCRetail.Format

    End Sub


    Private Sub SetGameROMPathToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetGameROMPathToolStripMenuItem.Click
        lstNTSCRetail.Items.Clear()
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

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
        'MsgBox(strFolder)
        MsgBox(strFolder, 64, "ROM Directory Path Selected")
        txtRomPath.Text = strFolder
        Dim a78filesMain = strFolder
        For Each file As String In System.IO.Directory.GetFiles(a78filesMain, "*.a78")
            lstNTSCRetail.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

        'Save Game Folder to INI file

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 ROM Path", strFolder)


    End Sub

    Private Sub SetGameBoxArtPathToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetGameBoxArtPathToolStripMenuItem.Click
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
        MsgBox(strBoxArtFolder, 64, "A7800 Box Art Path Selected")
        txtBoxArtPath.Text = strBoxArtFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Box Art Path", strBoxArtFolder)
    End Sub

    Private Sub SetA7800EmulatorPathToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetA7800EmulatorPathToolStripMenuItem.Click
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
        MsgBox(strA7800Folder, 64, "A7800 Emulator Directory Path Selected")
        txtA7800path.Text = strA7800Folder
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 A7800 Path", strA7800Folder)
    End Sub

    Private Sub SetManualsScreenshotPathToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetManualsScreenshotPathToolStripMenuItem.Click
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
        MsgBox(strManualsFolder, 64, "A7800 Manuals Path Selected")
        txtManualsPath.Text = strManualsFolder

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Manuals Path", strManualsFolder)
    End Sub
    Private Sub StartSelectedGameToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles StartSelectedGameToolStripMenuItem.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        Dim ProcessProperties2 As New ProcessStartInfo
        ProcessProperties2.WorkingDirectory = strA7800Folder + "\"
        ProcessProperties2.FileName = strA7800Folder + "\" + "a7800.exe"
        ProcessProperties2.Arguments = " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        ProcessProperties2.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties2)
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Private Sub xmON_Click(sender As Object, e As EventArgs) Handles xmON.Click

        'Update Status Bar
        stripXM.Text = "XM Support: On  "
        stripHSC.Text = "HSC Support: Off  "

        strAddArguments = "-cart1 xm -cart2"
        xmON.Checked = True
        xmOFF.Checked = False
        hscON.Checked = False
        hscOFF.Checked = True
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstNTSCRetail.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub xmOFF_Click(sender As Object, e As EventArgs) Handles xmOFF.Click

        'Update Status Bar
        stripXM.Text = "XM Support: Off  "

        strAddArguments = "-cart"
        xmOFF.Checked = True
        xmON.Checked = False
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstNTSCRetail.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub hscON_Click(sender As Object, e As EventArgs) Handles hscON.Click

        'Update Status Bar
        stripXM.Text = "XM Support: Off  "
        stripHSC.Text = "HSC Support: On  "

        strAddArguments = "-cart1 hiscore -cart2"
        hscON.Checked = True
        hscOFF.Checked = False
        xmON.Checked = False
        xmOFF.Checked = True
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstNTSCRetail.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub hscOFF_Click(sender As Object, e As EventArgs) Handles hscOFF.Click

        'Update Status Bar
        stripHSC.Text = "HSC Support: Off  "

        strAddArguments = "-cart"
        hscOFF.Checked = True
        hscON.Checked = False
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstNTSCRetail.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub Atari7800ProSystemOwnersManualToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Atari7800ProSystemOwnersManualToolStripMenuItem.Click
        strWindowMode = "Full"
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Display Mode", strWindowMode)

        Me.Width = 1366
        Me.Height = 732
        lstNTSCRetail.Height = 660

        displayFULL.Checked = True
        displayMED.Checked = False
        displaySMALL.Checked = False
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\7800_Owners_Manual.htm"))
    End Sub

    Private Sub A7800UsersGuideToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles A7800UsersGuideToolStripMenuItem.Click
        strWindowMode = "Full"
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Display Mode", strWindowMode)

        Me.Width = 1366
        Me.Height = 732
        lstNTSCRetail.Height = 660

        displayFULL.Checked = True
        displayMED.Checked = False
        displaySMALL.Checked = False
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\A7800_Manual.htm"))
    End Sub

    Private Sub EditA7800ConfigurationFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditA7800ConfigurationFileToolStripMenuItem.Click
        frmA7800Config.Show()
    End Sub

    Private Sub NTSCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NTSCToolStripMenuItem.Click

        'TV Type
        'Changing Resets Developer Mode to OFF and resets Palette to WARM

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        'Update Status Bar
        stripTVType.Text = "TV Type: NTSC  "
        stripPalette.Text = "Palette: Warm  "
        stripDebug.Text = "Debug Mode: Off  "
        stripDev.Text = "Dev Mode: On  "

        'Reset Palette back to default 'WARM'
        paletteWARM.Checked = True
        paletteCOOL.Checked = False
        paletteHOT.Checked = False

        'Reset Debug back to 'OFF'
        debugON.Checked = False
        debugOFF.Checked = True

        'MsgBox("NTSC selected: Palette set to Warm and Debug turned off")

        strArguments = "a7800"
        NTSCToolStripMenuItem.Checked = True
        PALToolStripMenuItem.Checked = False
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub PALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PALToolStripMenuItem.Click

        'TV Type
        'Changing Resets Developer Mode to OFF and resets Palette to WARM

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        'Update Status Bar
        stripTVType.Text = "TV Type: PAL  "
        stripPalette.Text = "Palette: Warm  "
        stripDebug.Text = "Debug Mode: Off  "
        stripDev.Text = "Dev Mode: Off  "

        'Reset Palette back to default 'WARM'
        paletteWARM.Checked = True
        paletteCOOL.Checked = False
        paletteHOT.Checked = False

        'Reset Debug back to default 'OFF'
        debugON.Checked = False
        debugOFF.Checked = True

        'MsgBox("PAL selected: Palette set to Warm and Debug turned off")

        strArguments = "a7800p"
        NTSCToolStripMenuItem.Checked = False
        PALToolStripMenuItem.Checked = True
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub paletteWARM_Click(sender As Object, e As EventArgs) Handles paletteWARM.Click

        'Set WARM Palette

        'Update Status Bar
        stripTVType.Text = "TV Type: PAL  "
        stripPalette.Text = "Palette: Warm  "
        stripDev.Text = "Dev Mode: Off  "

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        If NTSCToolStripMenuItem.Checked = True Then
            strArguments = "a7800"
            stripTVType.Text = "TV Type: NTSC  "
        End If

        If PALToolStripMenuItem.Checked = True Then
            strArguments = "a7800p"
            stripTVType.Text = "TV Type: PAL  "
        End If

        'Reset Dev back to default 'OFF'
        devON.Checked = False
        devOFF.Checked = True

        'Update Palette Selection on Menu Strip
        paletteWARM.Checked = True
        paletteCOOL.Checked = False
        paletteHOT.Checked = False

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

    End Sub

    Private Sub paletteCOOL_Click(sender As Object, e As EventArgs) Handles paletteCOOL.Click

        'Set COOL Palette

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        If NTSCToolStripMenuItem.Checked = True Then
            strArguments = "a7800u1"
            stripTVType.Text = "TV Type: NTSC  "
        End If

        If PALToolStripMenuItem.Checked = True Then
            strArguments = "a7800pu1"
            stripTVType.Text = "TV Type: PAL  "
        End If

        'Reset Dev back to default 'OFF'
        devON.Checked = False
        devOFF.Checked = True

        'Update Palette Selection on Menu Strip
        paletteWARM.Checked = False
        paletteCOOL.Checked = True
        paletteHOT.Checked = False

        'Update Status Bar
        stripPalette.Text = "Palette: Cool  "
        stripDev.Text = "Dev Mode: Off  "

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

    End Sub

    Private Sub paletteHOT_Click(sender As Object, e As EventArgs) Handles paletteHOT.Click

        'Set HOT Palette

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        If NTSCToolStripMenuItem.Checked = True Then
            strArguments = "a7800u2"
            stripTVType.Text = "TV Type: NTSC  "
        End If

        If PALToolStripMenuItem.Checked = True Then
            strArguments = "a7800pu2"
            stripTVType.Text = "TV Type: PAL  "
        End If

        'Reset Dev back to default 'OFF'
        devON.Checked = False
        devOFF.Checked = True

        'Update Palette Selection on Menu Strip
        paletteWARM.Checked = False
        paletteCOOL.Checked = False
        paletteHOT.Checked = True

        'Update Status Bar
        stripPalette.Text = "Palette: Hot  "
        stripDev.Text = "Dev Mode: Off  "

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

    End Sub

    Private Sub OnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles devON.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        If NTSCToolStripMenuItem.Checked = True Then
            strArguments = "a7800dev"
        End If

        If PALToolStripMenuItem.Checked = True Then
            strArguments = "a7800pdev"
        End If

        'Update Status Bar
        'Turning On Dev mode sets palette to Warm
        stripPalette.Text = "Palette: Warm  "

        'Update Status Bar
        stripDev.Text = "Dev Mode: On  "

        'MsgBox("Debug Mode Enabled: Palette set to Warm")

        paletteWARM.Checked = True
        paletteCOOL.Checked = False
        paletteHOT.Checked = False

        devOFF.Checked = False
        devON.Checked = True

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

    End Sub

    Private Sub OffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles devOFF.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        If NTSCToolStripMenuItem.Checked = True Then
            strArguments = "a7800"
        End If

        If PALToolStripMenuItem.Checked = True Then
            strArguments = "a7800p"
        End If

        'Update Status Bar
        'Turning off Dev mode sets palette to Warm
        stripPalette.Text = "Palette: Warm  "

        'Update Status Bar
        stripDev.Text = "Dev Mode: Off  "

        'MsgBox("Debug Mode Enabled: Palette set to Warm")

        paletteWARM.Checked = True
        paletteCOOL.Checked = False
        paletteHOT.Checked = False

        devOFF.Checked = True
        devON.Checked = False

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

    End Sub

    Private Sub debugON_Click(sender As Object, e As EventArgs) Handles debugON.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        'Update Status Bar
        stripDebug.Text = "Debug Mode: On  "

        strDebug = "-debug"
        debugON.Checked = True
        debugOFF.Checked = False
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub debugOFF_Click(sender As Object, e As EventArgs) Handles debugOFF.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        'Update Status Bar
        stripDebug.Text = "Debug Mode: Off  "

        strDebug = ""
        debugON.Checked = False
        debugOFF.Checked = True
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub mnuLoadGame_Click_1(sender As Object, e As EventArgs) Handles mnuLoadGame.Click

        'Load Game Directly

        Using dlg As New OpenFileDialog With {.AddExtension = True,
                                              .AutoUpgradeEnabled = True,
                                              .CheckFileExists = False,
                                              .CheckPathExists = True,
                                              .Filter = "All files (*.*)|*.*",
                                              .FilterIndex = 1,
                                              .InitialDirectory = "C:\",
                                              .SupportMultiDottedExtensions = True,
                                              .Title = "Select Atari 7800 Game ROM",
                                              .ValidateNames = True}
            If dlg.ShowDialog = DialogResult.OK Then
                Dim strLaunchGame As String = dlg.FileName
                strFolder = System.IO.Path.GetDirectoryName(dlg.FileName.ToString)
                strFileName = System.IO.Path.GetFileName(strLaunchGame)
                'MsgBox(strFileName)
            End If
        End Using


        Dim ProcessProperties2 As New ProcessStartInfo
        ProcessProperties2.WorkingDirectory = strA7800Folder + "\"
        ProcessProperties2.FileName = strA7800Folder + "\" + "a7800.exe"
        ProcessProperties2.Arguments = " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        ProcessProperties2.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties2)

        'Choosing file does not update the strFolder folder path
        'Look at OpenFileDialog Option

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        'MsgBox(txtPath.Text)
    End Sub

    Private Sub FileToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        'Add Recent ROMS to List?
    End Sub

    Private Sub statusON_Click_1(sender As Object, e As EventArgs) Handles statusON.Click

        strStatusBar = "On"
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 StatusBar", strStatusBar)

        StatusStrip1.Visible = True

        statusON.Checked = True
        statusOFF.Checked = False

        If Me.Height = 355 Or Me.Height = 732 Then
            StatusStrip1.Visible = False
            statusON.Checked = False
            statusOFF.Checked = True
            strStatusBar = "Off"
            MsgBox("Status Bar Unavailable in this Display Mode")
        End If

    End Sub

    Private Sub statusOFF_Click(sender As Object, e As EventArgs) Handles statusOFF.Click

        strStatusBar = "Off"
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 StatusBar", strStatusBar)

        StatusStrip1.Visible = False

        'statusTVType.Visible = False
        'statusPalette.Visible = False
        'statusXM.Visible = False
        'statusHSC.Visible = False
        'statusDev.Visible = False
        'statusDebug.Visible = False
        'statusVideo.Visible = False
        statusON.Checked = False
        statusOFF.Checked = True

    End Sub

    Private Sub displayFULL_Click(sender As Object, e As EventArgs) Handles displayFULL.Click

        strWindowMode = "Full"
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Display Mode", strWindowMode)

        Me.Width = 1366
        Me.Height = 748

        lstNTSCRetail.Height = 660
        lstPALRetail.Height = 660
        lstHomebrews.Height = 660
        lstHacks.Height = 660
        lstDemos.Height = 660
        lstProtos.Height = 660
        lstUtilities.Height = 660
        TabControlRoms.Height = 663

        displayFULL.Checked = True
        displayMED.Checked = False
        displaySMALL.Checked = False
    End Sub

    Private Sub displayMED_Click(sender As Object, e As EventArgs) Handles displayMED.Click

        'Turn off Status Strip when mode is set to medium
        'It won't all fit.
        StatusStrip1.Visible = False
        statusON.Checked = False
        statusOFF.Checked = True

        strWindowMode = "Med"
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Display Mode", strWindowMode)

        Me.Width = 873
        Me.Height = 732

        lstNTSCRetail.Height = 660
        lstPALRetail.Height = 660
        lstHomebrews.Height = 660
        lstHacks.Height = 660
        lstDemos.Height = 660
        lstProtos.Height = 660
        lstUtilities.Height = 660
        TabControlRoms.Height = 663

        displayFULL.Checked = False
        displayMED.Checked = True
        displaySMALL.Checked = False
    End Sub

    Private Sub displaySMALL_Click(sender As Object, e As EventArgs) Handles displaySMALL.Click

        strWindowMode = "Small"

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Display Mode", strWindowMode)

        Me.Width = 474
        Me.Height = 355

        lstNTSCRetail.Height = 260
        lstPALRetail.Height = 260
        lstHomebrews.Height = 260
        lstHacks.Height = 260
        lstDemos.Height = 260
        lstProtos.Height = 260
        lstUtilities.Height = 260
        TabControlRoms.Height = 284

        'Turn off status bar if you choose the smallest window
        ' It won't all fit.
        StatusStrip1.Visible = False
        statusON.Checked = False
        statusOFF.Checked = True

        displayFULL.Checked = False
        displayMED.Checked = False
        displaySMALL.Checked = True
    End Sub

    Private Sub videoBasic_Click(sender As Object, e As EventArgs) Handles videoBasic.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strVideo = "-video bgfx -bgfx_screen_chains none"
        stripVideo.Text = "Video Output: Basic  "

        videoBasic.Checked = True
        videoCRT.Checked = False
        videoCRTDeluxe.Checked = False
        videoSuperEagle.Checked = False
        videoHLSL.Checked = False
        videoHQ2x.Checked = False
        videoHQ4x.Checked = False
        videoCompatibility.Checked = False

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch


    End Sub

    Private Sub videoCRT_Click(sender As Object, e As EventArgs) Handles videoCRT.Click


        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strVideo = "-video bgfx -bgfx_screen_chains crt-geom"
        stripVideo.Text = "Video Output: CRT  "

        videoBasic.Checked = False
        videoCRT.Checked = True
        videoCRTDeluxe.Checked = False
        videoSuperEagle.Checked = False
        videoHLSL.Checked = False
        videoHQ2x.Checked = False
        videoHQ4x.Checked = False
        videoCompatibility.Checked = False

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub videoCRTDeluxe_Click(sender As Object, e As EventArgs) Handles videoCRTDeluxe.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strVideo = "-video bgfx -bgfx_screen_chains crt-geom-deluxe"
        stripVideo.Text = "Video Output: CRT Deluxe  "

        videoBasic.Checked = False
        videoCRT.Checked = False
        videoCRTDeluxe.Checked = True
        videoSuperEagle.Checked = False
        videoHLSL.Checked = False
        videoHQ2x.Checked = False
        videoHQ4x.Checked = False
        videoCompatibility.Checked = False

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub videoSuperEagle_Click(sender As Object, e As EventArgs) Handles videoSuperEagle.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strVideo = "-video bgfx -bgfx_screen_chains super-eagle"
        stripVideo.Text = "Video Output: Super Eagle  "

        videoBasic.Checked = False
        videoCRT.Checked = False
        videoCRTDeluxe.Checked = False
        videoSuperEagle.Checked = True
        videoHLSL.Checked = False
        videoHQ2x.Checked = False
        videoHQ4x.Checked = False
        videoCompatibility.Checked = False

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub videoHLSL_Click(sender As Object, e As EventArgs) Handles videoHLSL.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strVideo = "-video bgfx -bgfx_screen_chains hlsl"
        stripVideo.Text = "Video Output: HLSL  "

        videoBasic.Checked = False
        videoCRT.Checked = False
        videoCRTDeluxe.Checked = False
        videoSuperEagle.Checked = False
        videoHLSL.Checked = True
        videoHQ2x.Checked = False
        videoHQ4x.Checked = False
        videoCompatibility.Checked = False

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub videoHQ2x_Click(sender As Object, e As EventArgs) Handles videoHQ2x.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strVideo = "-video bgfx -bgfx_screen_chains hq2x"
        stripVideo.Text = "Video Output: HQ2x  "

        videoBasic.Checked = False
        videoCRT.Checked = False
        videoCRTDeluxe.Checked = False
        videoSuperEagle.Checked = False
        videoHLSL.Checked = False
        videoHQ2x.Checked = True
        videoHQ4x.Checked = False
        videoCompatibility.Checked = False

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub videoHQ4x_Click(sender As Object, e As EventArgs) Handles videoHQ4x.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strVideo = "-video bgfx -bgfx_screen_chains hq4x"
        stripVideo.Text = "Video Output: HQ4x  "

        videoBasic.Checked = False
        videoCRT.Checked = False
        videoCRTDeluxe.Checked = False
        videoSuperEagle.Checked = False
        videoHLSL.Checked = False
        videoHQ2x.Checked = False
        videoHQ4x.Checked = True
        videoCompatibility.Checked = False

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub videoCompatibility_Click(sender As Object, e As EventArgs) Handles videoCompatibility.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strVideo = "-video d3d"
        stripVideo.Text = "Video Ouput: Compatibility  "

        videoBasic.Checked = False
        videoCRT.Checked = False
        videoCRTDeluxe.Checked = False
        videoSuperEagle.Checked = False
        videoHLSL.Checked = False
        videoHQ2x.Checked = False
        videoHQ4x.Checked = False
        videoCompatibility.Checked = True

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub lstPALRetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPALRetail.SelectedIndexChanged
        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        strFolder = txtPALRetailPath.Text
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtPALRetailPath.Text + "\" + lstPALRetail.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        'Retail PAL

        If lstPALRetail.SelectedItem.ToString = "Ace of Aces (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ace of Aces (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ace of Aces (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ace_of_Aces.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ace_of_Aces.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Alien Brigade (PAL) (Joystick) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alien Brigade (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alien Brigade (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alien_Brigade.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien_Brigade.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Alien Brigade (PAL) (Lightgun) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alien Brigade (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alien Brigade (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alien_Brigade.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien_Brigade.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Asteroids (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Ballblazer (PAL) (Atari-Lucasfilm) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ballblazer (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ballblazer (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ballblazer.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ballblazer.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Barnyard Blaster (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Barnyard Blaster (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Barnyard Blaster (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Barnyard_Blaster.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Barnyard_Blaster.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Basketbrawl (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Basketbrawl (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Basketbrawl (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Basketbrawl.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Basketbrawl.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Centipede (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Choplifter (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Choplifter! (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Choplifter! (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Choplifter.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Choplifter.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Commando (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Commando (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Commando (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Commando.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Commando.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Crack'ed (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crack'ed (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crack'ed (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crack'ed.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crack'ed.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Crossbow (PAL) (Joystick) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Crossbow (PAL) (Lightgun) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Dark Chambers (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dark Chambers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dark Chambers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dark_Chambers.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dark_Chambers.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Desert Falcon (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Desert Falcon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Desert Falcon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Desert_Falcon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Desert_Falcon.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Dig Dug (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dig Dug (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dig Dug (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dig_Dug.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dig_Dug.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Donkey Kong Jr (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong Junior (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong Junior (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey_Kong_Jr.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey_Kong_Jr.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Double Dragon (AB) (PAL) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double_Dragon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double_Dragon.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Double Dragon (OB) (PAL) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double_Dragon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double_Dragon.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "F-18 Hornet (PAL) (Absolute) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\F-18 Hornet (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\F-18 Hornet (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\F-18_Hornet.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\F-18_Hornet.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Fatal Run (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fatal Run (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fatal Run (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fatal_Run.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fatal_Run.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Fight Night (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fight Night (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fight Night (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fight_Night.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fight_Night.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Food Fight (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Food Fight (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Food Fight (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Food_Fight.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Food_Fight.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Galaga (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Hat Trick (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hat Trick (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hat Trick (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hat_Trick.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hat_Trick.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Ikari Warriors (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ikari Warriors (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ikari Warriors (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ikari_Warriors.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ikari_Warriors.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Impossible Mission (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible_Mission.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible_Mission.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Jinks (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jinks (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jinks (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jinks.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jinks.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Joust (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Karateka (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Karateka (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Karateka (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Karateka.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Karateka.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Kung-Fu Master (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu_Master.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu_Master.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Mario Bros (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros. (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros. (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario_Bros.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario_Bros.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Mat Mania Challenge (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mat Mania Challenge (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mat Mania Challenge (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mat_Mania_Challenge.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mat_Mania_Challenge.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Mean 18 Ultimate Golf (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mean 18 Ultimate Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mean 18 Ultimate Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mean_18.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mean_18.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Meltdown (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meltdown (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meltdown (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meltdown.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meltdown.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Midnight Mutants (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Midnight Mutants (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Midnight Mutants (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Midnight_Mutants.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Midnight_Mutants.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Motor Psycho (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Motor Psycho (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Motor Psycho (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Motor_Psycho.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Motor_Psycho.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Ms Pac-Man (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms_Pac-Man.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Ninja Golf (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ninja Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ninja Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ninja_Golf.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ninja_Golf.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "One-on-One Basketball (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\One-on-One Basketball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\One-on-One Basketball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\One-on-One_Basketball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\One-on-One_Basketball.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Pete Rose Baseball (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pete Rose Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pete Rose Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pete_Rose_Baseball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pete_Rose_Baseball.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Planet Smashers (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Planet Smashers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Planet Smashers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Planet_Smashers.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Planet_Smashers.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Pole Position II (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Position II (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Position II (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole_Position_II.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole_Position_II.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "RealSports Baseball (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RealSports Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RealSports Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\RealSports_Baseball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\RealSports_Baseball.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Robotron 2084 (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robotron - 2084 (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robotron - 2084 (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robotron_2084.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robotron_2084.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Scrapyard Dog (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard_Dog.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard_Dog.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Summer Games (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Summer Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Summer Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Summer_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Summer_Games.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Super Huey UH-IX (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Huey UH-IX (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Huey UH-IX (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Huey_UH-IX.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Huey_UH-IX.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Super Skateboardin' (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Skateboardin' (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Skateboardin' (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Skateboardin.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Skateboardin.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Tank Command (PAL) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tank Command (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tank Command (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tank_Command.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tank_Command.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Title Match Pro Wrestling (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Title Match Pro Wrestling (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Title Match Pro Wrestling (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Title_Match_Pro_Wrestling.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Title_Match_Pro_Wrestling.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Tomcat - The F-14 Fighter Simulator (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tomcat - The F-14 Fighter Simulator (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tomcat - The F-14 Fighter Simulator (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\F-14_Tomcat.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\F-14_Tomcat.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Touchdown Football (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Touchdown Football (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Touchdown Football (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Touchdown_Football.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Touchdown_Football.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Tower Toppler (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tower Toppler (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tower Toppler (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tower_Toppler.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tower_Toppler.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Water Ski (PAL) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Water Ski (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Water Ski (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Water_Ski.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Water_Ski.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Winter Games (Alternate) (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Winter_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter_Games.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Winter Games (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Winter_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter_Games.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Xenophobe (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xenophobe (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xenophobe (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xenophobe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xenophobe.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Xevious (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xevious (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xevious (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xevious.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xevious.htm"))
            End If
        End If

        ' Box Art Does Not Yet Exist
        ' 9-10-2022 HTM files are not yet complete

        If lstPALRetail.SelectedItem.ToString = "7iX (20220305)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\7iX.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\7iX.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\7iX.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\7iX.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "2048 (RC1a) (20211113)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\2048.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\2048.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\2048.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\2048.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "7800 XMAS - Santa vs The Nightmares (20201219u1)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\7800 XMAS.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\7800_XMAS.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\7800_XMAS.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\7800_XMAS.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "A Roach In Space - Part II - Electric Bugaloo (20201119)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\A Roach In Space - Part II - Electric Bugaloo.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\A Roach In Space - Part II - Electric Bugaloo.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\A_Roach_In_Space_Part_II.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\A_Roach_In_Space_Part_II.htm"))
            End If
        End If
    End Sub

    Private Sub lstHomebrews_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHomebrews.SelectedIndexChanged
        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        strFolder = txtHomebrewPath.Text
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtHomebrewPath.Text + "\" + lstHomebrews.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        'Homebrews

        If lstHomebrews.SelectedItem.ToString = "Armor Attack II (20130416)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Armor Attack II (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Armor Attack II (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Armor_Attack_II.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Armor_Attack_II.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Asteroids Deluxe (NTSC) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids Deluxe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids Deluxe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids_Deluxe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids_Deluxe.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Asteroids Deluxe (PAL) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids Deluxe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids Deluxe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids_Deluxe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids_Deluxe.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Astro Blaster (20140201)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Astro Blaster (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Astro Blaster (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Astro_Blaster.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Astro_Blaster.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Astro Fighter (20150726)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Astro Fighter (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Astro Fighter (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Astro_Fighter.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Astro_Fighter.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Astro Fighter (20150726)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Astro Fighter (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Astro Fighter (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Astro_Fighter.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Astro_Fighter.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Beef Drop (Final AtariAge)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Beef Drop (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Beef Drop (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Beef_Drop.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Beef_Drop.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "BonQ (Final AtariAge)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\bonQ (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\bonQ (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\BonQ.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\BonQ.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Crazy Brix (Joystick) (20160427)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Brix (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Brix (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy_Brix.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy_Brix.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Crazy Brix (Paddle) (20160427)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Brix (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Brix (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy_Brix.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy_Brix.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Crazy Otto (NTSC) (20100612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Otto (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Otto (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy_Otto.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy_Otto.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Crazy Otto (PAL) (20100612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Otto (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Otto (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy_Otto.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy_Otto.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Bentley Bear's Crystal Quest (20151220)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crystal Quest featuring Bentley Bear (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crystal Quest featuring Bentley Bear (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bentley_Bear's_Crystal_Quest.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bentley_Bear's_Crystal_Quest.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Dungeon Stalker (20151022)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dungeon Stalker (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dungeon Stalker (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dungeon_Stalker.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dungeon_Stalker.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "FailSafe (NTSC) (20100227)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\FailSafe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\FailSafe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\FailSafe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\FailSafe.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "FailSafe (PAL) (20100227)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\FailSafe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\FailSafe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\FailSafe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\FailSafe.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Frenzy (w-Berzerk) (20211025)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Frenzy (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Frenzy (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Frenzy.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Frenzy.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Froggie (NTSC) (Final Release) (20180920)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Froggie (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Froggie (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Froggie.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Froggie.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Froggie (PAL) (Final Release) (20180920)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Froggie (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Froggie (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Froggie.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Froggie.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Jr Pac-Man (NTSC) (20120924)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr. Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr. Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jr_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jr_Pac-Man.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Jr Pac-Man (PAL) (20120924)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr. Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr. Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jr_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jr_Pac-Man.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Meteor Shower (NTSC) (20120218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meteor Shower (USA) (Unl) [Blue].jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meteor Shower (USA) (Unl) [Blue].jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meteor_Shower.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meteor_Shower.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Meteor Shower (PAL) (20120218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meteor Shower (USA) (Unl) [Blue].jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meteor Shower (USA) (Unl) [Blue].jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meteor_Shower.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meteor_Shower.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Moon Cresta (NTSC) (20111113)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Moon Cresta (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Moon Cresta (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Moon_Cresta.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Moon_Cresta.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Moon Cresta (PAL) (20111113)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Moon Cresta (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Moon Cresta (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Moon_Cresta.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Moon_Cresta.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Ms Pac-Man 320 (NTSC) (20110808)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms_Pac-Man_320.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms_Pac-Man_320.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Ms Pac-Man 320 (PAL) (20110808)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms_Pac-Man_320.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms_Pac-Man_320.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Pac-Man 320 (NTSC) (20110810)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man_320.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man_320.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man 320 (PAL) (20110810)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms_Pac-Man_320.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms_Pac-Man_320.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man Collection - 40th Anniversary Edition (20210420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man_Collection.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man_Collection.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man Collection - 40th Anniversary Edition (Short Mazes) (20220530)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man_Collection.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man_Collection.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man Collection (20120119)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man_Collection.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man_Collection.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man Collection (New Monsters) (20150531)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man_Collection.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man_Collection.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Rip-Off (NTSC) (20120502)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rip-Off (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rip-Off (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rip-Off.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rip-Off.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Santa Simon (Valid Signature) (20170511)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Santa Simon (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Santa Simon (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Santa_Simon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Santa_Simon.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Scramble (20161202)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scramble (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scramble (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scramble.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scramble.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Space Duel (NTSC) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Duel (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Duel (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space_Duel.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space_Duel.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Space Duel (PAL) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Duel (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Duel (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space_Duel.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space_Duel.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Space Invaders (NTSC) (20080801)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Invaders (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Invaders (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space_Invaders.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space_Invaders.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Space Invaders (PAL) (20080801)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Invaders (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Invaders (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space_Invaders.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space_Invaders.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Joystick) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Joystick) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Paddle) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Paddle) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Joystick) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Joystick) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Paddle) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Paddle) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Super Pac-Man (NTSC) (20081010)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Pac-Man.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Pac-Man (PAL) (20081010)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Pac-Man.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Wasp! (Standard Edition) (20090923)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Wasp! (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Wasp! (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Wasp.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Wasp.htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Worm! (v1_16F) (20100307)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Worm! (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Worm! (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Worm.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Worm.htm"))
            End If
        End If
    End Sub

    Private Sub lstHacks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHacks.SelectedIndexChanged
        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtHacksPath.Text + "\" + lstHacks.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch


        If lstHacks.SelectedItem.ToString = "Pac Pollux (Hack) (20060305)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Pollux (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Pollux (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac_Pollux.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac_Pollux.htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Super Cobra (Hack) (20120503)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Cobra (USA) (Hack).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Cobra (USA) (Hack).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Cobra.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Cobra.htm"))
            End If
        End If
    End Sub

    Private Sub lstDemos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDemos.SelectedIndexChanged
        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtDemosPath.Text + "\" + lstDemos.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

    End Sub

    Private Sub lstProtos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProtos.SelectedIndexChanged
        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtProtosPath.Text + "\" + lstProtos.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        If lstProtos.SelectedItem.ToString = "Plutos (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Plutos (USA) (Proto).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Plutos (USA) (Proto).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Plutos.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Plutos.htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Sirius (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sirius (USA) (Proto).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sirius (USA) (Proto).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sirius.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sirius.htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "AtariLab - Light Module (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\AtariLab - Light Module (Prototype).png") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\AtariLab - Light Module (Prototype).png")
            End If
            If System.IO.File.Exists(strManualsFolder & "\AtariLab - Light Module.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\AtariLab - Light Module.htm"))
            End If
        End If


        If lstProtos.SelectedItem.ToString = "AtariLab - Temperature Module (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\AtariLab - Temperature (Prototype).png") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\AtariLab - Temperature (Prototype).png")
            End If
            If System.IO.File.Exists(strManualsFolder & "\AtariLab - Temperature Module.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\AtariLab - Temperature Module.htm"))
            End If
        End If

    End Sub

    Private Sub lstUtilities_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUtilities.SelectedIndexChanged
        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtUtilitiesPath.Text + "\" + lstUtilities.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

    End Sub


    Private Sub lstNTSCRetail_DoubleClick(sender As Object, e As EventArgs) Handles lstNTSCRetail.DoubleClick
        Dim ProcessProperties2 As New ProcessStartInfo
        ProcessProperties2.WorkingDirectory = strA7800Folder + "\"
        ProcessProperties2.FileName = strA7800Folder + "\" + "a7800.exe"
        ProcessProperties2.Arguments = " " + strArguments + " " + strAddArguments + " """ + txtNTSCRetailPath.Text + "\" + lstNTSCRetail.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        ProcessProperties2.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties2)
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtNTSCRetailPath.Text + "\" + lstNTSCRetail.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub lstPALRetail_DoubleClick(sender As Object, e As EventArgs) Handles lstPALRetail.DoubleClick
        Dim ProcessProperties2 As New ProcessStartInfo
        ProcessProperties2.WorkingDirectory = strA7800Folder + "\"
        ProcessProperties2.FileName = strA7800Folder + "\" + "a7800.exe"
        ProcessProperties2.Arguments = " " + strArguments + " " + strAddArguments + " """ + txtPALRetailPath.Text + "\" + lstPALRetail.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        ProcessProperties2.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties2)
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtPALRetailPath.Text + "\" + lstPALRetail.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub lstHomebrews_DoubleClick(sender As Object, e As EventArgs) Handles lstHomebrews.DoubleClick
        Dim ProcessProperties2 As New ProcessStartInfo
        ProcessProperties2.WorkingDirectory = strA7800Folder + "\"
        ProcessProperties2.FileName = strA7800Folder + "\" + "a7800.exe"
        ProcessProperties2.Arguments = " " + strArguments + " " + strAddArguments + " """ + txtHomebrewPath.Text + "\" + lstHomebrews.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        ProcessProperties2.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties2)
        strFolder = txtHomebrewPath.Text
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtHomebrewPath.Text + "\" + lstHomebrews.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

    End Sub

    Private Sub lstHacks_DoubleClick(sender As Object, e As EventArgs) Handles lstHacks.DoubleClick
        Dim ProcessProperties2 As New ProcessStartInfo
        ProcessProperties2.WorkingDirectory = strA7800Folder + "\"
        ProcessProperties2.FileName = strA7800Folder + "\" + "a7800.exe"
        ProcessProperties2.Arguments = " " + strArguments + " " + strAddArguments + " """ + txtHacksPath.Text + "\" + lstHacks.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        ProcessProperties2.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties2)
        strFolder = txtHacksPath.Text
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtHacksPath.Text + "\" + lstHacks.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub lstDemos_DoubleClick(sender As Object, e As EventArgs) Handles lstDemos.DoubleClick
        Dim ProcessProperties2 As New ProcessStartInfo
        ProcessProperties2.WorkingDirectory = strA7800Folder + "\"
        ProcessProperties2.FileName = strA7800Folder + "\" + "a7800.exe"
        ProcessProperties2.Arguments = " " + strArguments + " " + strAddArguments + " """ + txtDemosPath.Text + "\" + lstDemos.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        ProcessProperties2.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties2)
        strFolder = txtDemosPath.Text
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtDemosPath.Text + "\" + lstDemos.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub lstProtos_DoubleClick(sender As Object, e As EventArgs) Handles lstProtos.DoubleClick
        Dim ProcessProperties2 As New ProcessStartInfo
        ProcessProperties2.WorkingDirectory = strA7800Folder + "\"
        ProcessProperties2.FileName = strA7800Folder + "\" + "a7800.exe"
        ProcessProperties2.Arguments = " " + strArguments + " " + strAddArguments + " """ + txtProtosPath.Text + "\" + lstProtos.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        ProcessProperties2.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties2)
        strFolder = txtProtosPath.Text
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtProtosPath.Text + "\" + lstProtos.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub lstUtilities_DoubleClick(sender As Object, e As EventArgs) Handles lstUtilities.DoubleClick
        Dim ProcessProperties2 As New ProcessStartInfo
        ProcessProperties2.WorkingDirectory = strA7800Folder + "\"
        ProcessProperties2.FileName = strA7800Folder + "\" + "a7800.exe"
        ProcessProperties2.Arguments = " " + strArguments + " " + strAddArguments + " """ + txtUtilitiesPath.Text + "\" + lstUtilities.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        ProcessProperties2.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties2)
        strFolder = txtUtilitiesPath.Text
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtUtilitiesPath.Text + "\" + lstUtilities.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
    End Sub

    Private Sub btnSaveROMPaths_Click(sender As Object, e As EventArgs) Handles btnSaveROMPaths.Click

        'Save all paths entered in the ROM Paths tab to the registry, overwrites all existing values.
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 NTSC Retail ROM Subfolder", txtNTSCRetailPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 PAL Retail ROM Subfolder", txtPALRetailPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Homebrews ROM Subfolder", txtHomebrewPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Hacks ROM Subfolder", txtHacksPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Demos ROM Subfolder", txtDemosPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Prototypes ROM Subfolder", txtProtosPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Utilities ROM Subfolder", txtUtilitiesPath.Text)


        'Clear all ROM Lists, then refresh with new paths being saved.

        lstNTSCRetail.Items.Clear()
        lstPALRetail.Items.Clear()
        lstHomebrews.Items.Clear()
        lstHacks.Items.Clear()
        lstDemos.Items.Clear()
        lstProtos.Items.Clear()
        lstUtilities.Items.Clear()

        Try
            Dim a78filesMain = txtNTSCRetailPath.Text
            For Each file As String In System.IO.Directory.GetFiles(a78filesMain, "*.a78")
                lstNTSCRetail.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        Try
            Dim a78filesPAL = txtPALRetailPath.Text
            For Each filePAL As String In System.IO.Directory.GetFiles(a78filesPAL, "*.a78")
                lstPALRetail.Items.Add(System.IO.Path.GetFileNameWithoutExtension(filePAL))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        Try
            Dim a78filesHomebrews = txtHomebrewPath.Text
            For Each fileHomebrews As String In System.IO.Directory.GetFiles(a78filesHomebrews, "*.a78")
                lstHomebrews.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileHomebrews))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        Try
            Dim a78filesHacks = txtHacksPath.Text
            For Each fileHacks As String In System.IO.Directory.GetFiles(a78filesHacks, "*.a78")
                lstHacks.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileHacks))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        Try
            Dim a78filesDemos = txtDemosPath.Text
            For Each fileDemos As String In System.IO.Directory.GetFiles(a78filesDemos, "*.a78")
                lstDemos.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileDemos))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        Try
            Dim a78filesProtos = txtProtosPath.Text
            For Each fileProtos As String In System.IO.Directory.GetFiles(a78filesProtos, "*.a78")
                lstProtos.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileProtos))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        Try
            Dim a78filesUtilities = txtUtilitiesPath.Text
            For Each fileUtilities As String In System.IO.Directory.GetFiles(a78filesUtilities, "*.a78")
                lstUtilities.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileUtilities))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        txtRootROMPath.Text = strFolder
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim a78filesHacks = txtHacksPath.Text
            For Each fileHacks As String In System.IO.Directory.GetFiles(a78filesHacks, "*.a78")
                lstHacks.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileHacks))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try
    End Sub

    Private Sub stretchON_Click(sender As Object, e As EventArgs) Handles stretchON.Click
        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strStretch = " -nokeepaspect"
        stripStretch.Text = "Screen Stretch: On  "
        'statusTripleBuffer.Text = "Video: CRT" 'There is no status bar item for this yet.

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        stretchON.Checked = True
        stretchOFF.Checked = False
    End Sub

    Private Sub stretchOFF_Click(sender As Object, e As EventArgs) Handles stretchOFF.Click
        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strStretch = ""
        stripStretch.Text = "Screen Stretch: Off  "
        'statusTripleBuffer.Text = "Video: CRT" 'There is no status bar item for this yet.

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        stretchON.Checked = False
        stretchOFF.Checked = True
    End Sub

    Private Sub fullscreenOFF_Click(sender As Object, e As EventArgs) Handles fullscreenOFF.Click
        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strA7800WindowMode = ""
        stripWindow.Text = "Window Mode: Windowed  "
        'statusTripleBuffer.Text = "Video: CRT" 'There is no status bar item for this yet.

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        fullscreenOFF.Checked = True
        fullScreenON.Checked = False
    End Sub

    Private Sub fullScreenON_Click(sender As Object, e As EventArgs) Handles fullScreenON.Click
        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strA7800WindowMode = " -nowindow"
        stripWindow.Text = "Window Mode: Full Screen  "
        'statusTripleBuffer.Text = "Video: CRT" 'There is no status bar item for this yet.

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        fullScreenON.Checked = True
        fullscreenOFF.Checked = False
    End Sub
    Private Sub xmON_Click(sender As Object, e As EventArgs) Handles xmON.Click

    Private Sub NTSCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NTSCToolStripMenuItem.Click
        strArguments = "a7800"
        NTSCToolStripMenuItem.Checked = True
        PALToolStripMenuItem.Checked = False
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
    End Sub

    Private Sub vsyncOFF_Click(sender As Object, e As EventArgs) Handles vsyncOFF.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strVsync = ""
        stripVsync.Text = "Vsync Wait: Off  "
        'statusTripleBuffer.Text = "Video: CRT" 'There is no status bar item for this yet.

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        vsyncOFF.Checked = True
        vsyncON.Checked = False
    End Sub

    Private Sub triplebufferON_Click(sender As Object, e As EventArgs) Handles triplebufferON.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strTripleBuffer = " -triplebuffer"
        stripTripleBuffer.Text = "Triple Buffer: On  "
        'statusTripleBuffer.Text = "Video: CRT" 'There is no status bar item for this yet.

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        triplebufferON.Checked = True
        triplebufferOFF.Checked = False
    End Sub

    Private Sub triplebufferOFF_Click(sender As Object, e As EventArgs) Handles triplebufferOFF.Click

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = lstNTSCRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = lstPALRetail.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = lstHomebrews.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = lstHacks.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = lstProtos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = lstDemos.Text + ".a78"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = lstUtilities.Text + ".a78"
        End If

        strTripleBuffer = ""
        stripTripleBuffer.Text = "Triple Buffer: Off  "
        'statusTripleBuffer.Text = "Video: CRT" 'There is no status bar item for this yet.

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        triplebufferOFF.Checked = True
        triplebufferON.Checked = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Update A7800 Directory Paths to registry from ROM Paths Tab.
        'Changes reflected on appliction restart.
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Box Art Path", txtBoxArtPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 Manuals Path", txtManualsPath.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 A7800 Path", txtA7800path.Text)
        My.Computer.Registry.CurrentUser.SetValue("Maximus78 ROM Path", txtRomPath.Text)
    End Sub

    Private Sub Atari7800ProSystemOwnersManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Atari7800ProSystemOwnersManualToolStripMenuItem.Click
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\7800_Owners_Manual.htm"))
    End Sub

    Private Sub A7800UsersGuideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles A7800UsersGuideToolStripMenuItem.Click
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\A7800_Manual.htm"))
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        txtHTMLEditor.Clear()

        If TabControlRoms.SelectedTab.Name = "tabNTSC" Then
            strFileName = "\" + lstNTSCRetail.Text + ".htm"
        End If
        If TabControlRoms.SelectedTab.Name = "tabPAL" Then
            strFileName = strManualsFolder + " " + lstPALRetail.Text + ".htm"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = strManualsFolder + " " + lstHomebrews.Text + ".htm"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = strManualsFolder + " " + lstHacks.Text + ".htm"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = strManualsFolder + " " + lstProtos.Text + ".htm"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = strManualsFolder + " " + lstDemos.Text + ".htm"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = strManualsFolder + " " + lstUtilities.Text + ".htm"
        End If

        txtEditorFile.Text = strManualsFolder + strFileName


        Try
            For Each s As String In System.IO.File.ReadAllLines(txtEditorFile.Text)
                txtHTMLEditor.AppendText(s + vbNewLine)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveHTML_Click(sender As Object, e As EventArgs) Handles btnSaveHTML.Click

        Try
            'My.Computer.FileSystem.WriteAllText(txtINIPath.Text, txta7800ini.Text, False)
        Catch
            MessageBox.Show("Error writing file")
        End Try

        MessageBox.Show("Text (not actually) saved to " & txtEditorFile.Text)


    End Sub
End Class