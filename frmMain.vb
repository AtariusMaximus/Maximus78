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
            Me.Width = 863
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

        'Update Game Info HTML Editor
        txtHTMLEditor.Clear()
        strFileName = "\" + lstNTSCRetail.Text + ".htm"
        txtEditorFile.Text = strManualsFolder + strFileName
        Try
            For Each s As String In System.IO.File.ReadAllLines(txtEditorFile.Text)
                txtHTMLEditor.AppendText(s + vbNewLine)
            Next
        Catch ex As Exception
        End Try

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
            If System.IO.File.Exists(strManualsFolder & "\Alien Brigade (NTSC) (Joystick) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien Brigade (NTSC) (Joystick) (Atari) (1990).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Alien Brigade (NTSC) (Lightgun) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alien Brigade (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alien Brigade (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alien Brigade (NTSC) (Lightgun) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien Brigade (NTSC) (Lightgun) (Atari) (1990).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Asteroids (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Ballblazer (NTSC) (Atari-Lucasfilm) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ballblazer (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ballblazer (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ballblazer (NTSC) (Atari-Lucasfilm) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ballblazer (NTSC) (Atari-Lucasfilm) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Barnyard Blaster (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Barnyard Blaster (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Barnyard Blaster (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Barnyard Blaster (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Barnyard Blaster (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Basketbrawl (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Basketbrawl (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Basketbrawl (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Basketbrawl (NTSC) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Basketbrawl (NTSC) (Atari) (1990).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Centipede (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Choplifter (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Choplifter! (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Choplifter! (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Choplifter (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Choplifter (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Choplifter (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Choplifter (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Commando (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Choplifter (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Choplifter (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Crack'ed (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crack'ed (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crack'ed (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crack'ed (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crack'ed (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Crossbow (NTSC) (Joystick) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow (NTSC) (Joystick) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow (NTSC) (Joystick) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Crossbow (NTSC) (Lightgun) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow (NTSC) (Lightgun) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow (NTSC) (Lightgun) (Atari) (1988).htm"))
            End If
        End If


        If lstNTSCRetail.SelectedItem.ToString = "Commando (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Commando (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Commando (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Commando (NTSC) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Commando (NTSC) (Atari) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Dark Chambers (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dark Chambers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dark Chambers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dark Chambers (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dark Chambers (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Desert Falcon (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Desert Falcon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Desert Falcon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Desert Falcon (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Desert Falcon (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Dig Dug (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dig Dug (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dig Dug (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dig Dug (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dig Dug (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Donkey Kong (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey Kong (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey Kong (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Donkey Kong (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey Kong (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey Kong (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Donkey Kong Jr (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong Junior (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong Junior (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey Kong Jr (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey Kong Jr (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Double Dragon (AB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double Dragon (AB) (NTSC) (Activision) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double Dragon (AB) (NTSC) (Activision) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Double Dragon (OB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double Dragon (OB) (NTSC) (Activision) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double Dragon (OB) (NTSC) (Activision) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "F-18 Hornet (NTSC) (Absolute) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\F-18 Hornet (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\F-18 Hornet (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\F-18 Hornet (NTSC) (Absolute) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\F-18 Hornet (NTSC) (Absolute) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Fatal Run (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fatal Run (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fatal Run (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fatal Run (NTSC) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fatal Run (NTSC) (Atari) (1990).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Fight Night (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fight Night (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fight Night (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fight Night (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fight Night (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Food Fight (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Food Fight (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Food Fight (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Food Fight (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Food Fight (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Galaga (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Hat Trick (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hat Trick (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hat Trick (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hat Trick (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hat Trick (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Ikari Warriors (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ikari Warriors (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ikari Warriors (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ikari Warriors (NTSC) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ikari Warriors (NTSC) (Atari) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Impossible Mission (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible Mission (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible Mission (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Jinks (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jinks (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jinks (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jinks (NTSC) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jinks (NTSC) (Atari) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Joust (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "KC Munchkin (20140408)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\K.C. Munchkin (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\K.C. Munchkin (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\KC Munchkin (20140408).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\KC Munchkin (20140408).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "KC Munchkin (Alt Movement) (20170409)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\K.C. Munchkin (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\K.C. Munchkin (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\KC Munchkin (Alt Movement) (20170409).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\KC Munchkin (Alt Movement) (20170409).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Karateka (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Karateka (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Karateka (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Karateka (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Karateka (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Klax (19xx)(Atari)(NTSC)(Prototype)(Fixed)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Klax (USA) (Proto).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Klax (USA) (Proto).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Klax (19xx)(Atari)(NTSC)(Prototype)(Fixed).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Klax (19xx)(Atari)(NTSC)(Prototype)(Fixed).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Kung-Fu Master (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master (NTSC) (Absolute) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master (NTSC) (Absolute) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Mario Bros (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros. (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros. (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Mat Mania Challenge (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mat Mania Challenge (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mat Mania Challenge (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mat Mania Challenge (NTSC) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mat Mania Challenge (NTSC) (Atari) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Mean 18 Ultimate Golf (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mean 18 Ultimate Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mean 18 Ultimate Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mean 18 Ultimate Golf (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mean 18 Ultimate Golf (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Meltdown (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meltdown (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meltdown (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meltdown (NTSC) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meltdown (NTSC) (Atari) (1990).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Midnight Mutants (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Midnight Mutants (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Midnight Mutants (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Midnight Mutants (NTSC) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Midnight Mutants (NTSC) (Atari) (1990).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Motor Psycho (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Motor Psycho (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Motor Psycho (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Motor Psycho (NTSC) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Motor Psycho (NTSC) (Atari) (1990).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Ms Pac-Man (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Ninja Golf (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ninja Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ninja Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ninja Golf (NTSC) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ninja Golf (NTSC) (Atari) (1990).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "One-on-One Basketball (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\One-on-One Basketball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\One-on-One Basketball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\One-on-One Basketball (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\One-on-One Basketball (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Pete Rose Baseball (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pete Rose Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pete Rose Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pete Rose Baseball (NTSC) (Absolute) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pete Rose Baseball (NTSC) (Absolute) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Planet Smashers (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Planet Smashers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Planet Smashers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Planet Smashers (NTSC) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Planet Smashers (NTSC) (Atari) (1990).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Pole Position II (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Position II (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Position II (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole Position II (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole Position II (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Rampage (AB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rampage (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rampage (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rampage (AB) (NTSC) (Activision) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rampage (AB) (NTSC) (Activision) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Rampage (OB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rampage (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rampage (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rampage (OB) (NTSC) (Activision) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rampage (OB) (NTSC) (Activision) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "RealSports Baseball (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RealSports Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RealSports Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\RealSports Baseball (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\RealSports Baseball (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Robotron 2084 (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robotron - 2084 (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robotron - 2084 (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robotron 2084 (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robotron 2084 (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Scrapyard Dog (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard Dog (NTSC) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard Dog (NTSC) (Atari) (1990).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Sentinel (NTSC) (Finished Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sentinel (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sentinel (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sentinel (NTSC) (Finished Prototype).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sentinel (NTSC) (Finished Prototype).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Sentinel (PAL) (Atari) (1991)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sentinel (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sentinel (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sentinel (PAL) (Atari) (1991).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sentinel (PAL) (Atari) (1991).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Summer Games (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Summer Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Summer Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Summer Games (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Summer Games (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Super Huey UH-IX (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Huey UH-IX (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Huey UH-IX (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Huey UH-IX (NTSC) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Huey UH-IX (NTSC) (Atari) (1989).htm"))
            End If
        End If


        If lstNTSCRetail.SelectedItem.ToString = "Super Skateboardin' (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Skateboardin' (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Skateboardin' (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Skateboardin' (NTSC) (Absolute) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Skateboardin' (NTSC) (Absolute) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Tank Command (NTSC) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tank Command (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tank Command (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tank Command (NTSC) (Froggo) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tank Command (NTSC) (Froggo) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "TiME Salvo (20160910)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Time Salvo (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Time Salvo (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\TiME Salvo (20160910).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\TiME Salvo (20160910).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Title Match Pro Wrestling (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Title Match Pro Wrestling (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Title Match Pro Wrestling (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Title Match Pro Wrestling (NTSC) (Absolute) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Title Match Pro Wrestling (NTSC) (Absolute) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Tomcat - The F-14 Fighter Simulator (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tomcat - The F-14 Fighter Simulator (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tomcat - The F-14 Fighter Simulator (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tomcat - The F-14 Fighter Simulator (NTSC) (Absolute) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tomcat - The F-14 Fighter Simulator (NTSC) (Absolute) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Touchdown Football (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Touchdown Football (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Touchdown Football (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Touchdown Football (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Touchdown Football (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Tower Toppler (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tower Toppler (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tower Toppler (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tower Toppler (NTSC) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tower Toppler (NTSC) (Atari) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Water Ski (NTSC) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Water Ski (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Water Ski (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Water Ski (NTSC) (Froggo) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Water Ski (NTSC) (Froggo) (1988).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Winter Games (Alternate) (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Winter Games (Alternate) (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter Games (Alternate) (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Winter Games (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Winter Games (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter Games (NTSC) (Atari) (1987).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Xenophobe (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xenophobe (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xenophobe (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xenophobe (NTSC) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xenophobe (NTSC) (Atari) (1989).htm"))
            End If
        End If

        If lstNTSCRetail.SelectedItem.ToString = "Xevious (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xevious (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xevious (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xevious (NTSC) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xevious (NTSC) (Atari) (1987).htm"))
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

        'Me.Width = 873
        Me.Width = 863
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

        'Update Game Info HTML Editor
        txtHTMLEditor.Clear()
        strFileName = "\" + lstPALRetail.Text + ".htm"
        txtEditorFile.Text = strManualsFolder + strFileName
        Try
            For Each s As String In System.IO.File.ReadAllLines(txtEditorFile.Text)
                txtHTMLEditor.AppendText(s + vbNewLine)
            Next
        Catch ex As Exception
        End Try

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
            If System.IO.File.Exists(strManualsFolder & "\Ace of Aces (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ace of Aces (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Alien Brigade (PAL) (Joystick) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alien Brigade (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alien Brigade (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alien Brigade (PAL) (Joystick) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien Brigade (PAL) (Joystick) (Atari) (1990).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Alien Brigade (PAL) (Lightgun) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alien Brigade (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alien Brigade (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alien Brigade (PAL) (Lightgun) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien Brigade (PAL) (Lightgun) (Atari) (1990).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Asteroids (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Ballblazer (PAL) (Atari-Lucasfilm) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ballblazer (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ballblazer (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ballblazer (PAL) (Atari-Lucasfilm) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ballblazer (PAL) (Atari-Lucasfilm) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Barnyard Blaster (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Barnyard Blaster (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Barnyard Blaster (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Barnyard Blaster (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Barnyard Blaster (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Basketbrawl (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Basketbrawl (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Basketbrawl (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Basketbrawl (PAL) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Basketbrawl (PAL) (Atari) (1990).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Centipede (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Choplifter (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Choplifter! (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Choplifter! (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Choplifter (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Choplifter (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Commando (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Commando (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Commando (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Commando (PAL) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Commando (PAL) (Atari) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Crack'ed (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crack'ed (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crack'ed (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crack'ed (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crack'ed (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Crossbow (PAL) (Joystick) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow (PAL) (Joystick) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow (PAL) (Joystick) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Crossbow (PAL) (Lightgun) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow (PAL) (Lightgun) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow (PAL) (Lightgun) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Dark Chambers (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dark Chambers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dark Chambers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dark Chambers (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dark Chambers (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Desert Falcon (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Desert Falcon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Desert Falcon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Desert Falcon (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Desert Falcon (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Dig Dug (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dig Dug (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dig Dug (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dig Dug (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dig Dug (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Donkey Kong (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey Kong (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey Kong (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Donkey Kong Jr (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong Junior (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong Junior (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey Kong Jr (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey Kong Jr (PAL) (Atari) (1988).htm"))
            End If
        End If
        If lstPALRetail.SelectedItem.ToString = "Double Dragon (AB) (PAL) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double Dragon (AB) (PAL) (Activision) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double Dragon (AB) (PAL) (Activision) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Double Dragon (OB) (PAL) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double Dragon (OB) (PAL) (Activision) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double Dragon (OB) (PAL) (Activision) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "F-18 Hornet (PAL) (Absolute) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\F-18 Hornet (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\F-18 Hornet (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\F-18 Hornet (PAL) (Absolute) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\F-18 Hornet (PAL) (Absolute) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Fatal Run (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fatal Run (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fatal Run (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fatal Run (PAL) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fatal Run (PAL) (Atari) (1990).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Fight Night (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fight Night (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fight Night (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fight Night (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fight Night (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Food Fight (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Food Fight (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Food Fight (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Food Fight (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Food Fight (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Galaga (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Hat Trick (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hat Trick (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hat Trick (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hat Trick (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hat Trick (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Ikari Warriors (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ikari Warriors (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ikari Warriors (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ikari Warriors (PAL) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ikari Warriors (PAL) (Atari) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Impossible Mission (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible Mission (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible Mission (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Jinks (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jinks (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jinks (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jinks (PAL) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jinks (PAL) (Atari) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Joust (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Karateka (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Karateka (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Karateka (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Karateka (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Karateka (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Kung-Fu Master (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master (PAL) (Absolute) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master (PAL) (Absolute) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Mario Bros (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros. (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros. (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Mat Mania Challenge (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mat Mania Challenge (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mat Mania Challenge (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mat Mania Challenge (PAL) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mat Mania Challenge (PAL) (Atari) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Mean 18 Ultimate Golf (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mean 18 Ultimate Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mean 18 Ultimate Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mean 18 Ultimate Golf (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mean 18 Ultimate Golf (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Meltdown (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meltdown (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meltdown (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meltdown (PAL) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meltdown (PAL) (Atari) (1990)htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Midnight Mutants (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Midnight Mutants (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Midnight Mutants (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Midnight Mutants (PAL) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Midnight Mutants (PAL) (Atari) (1990).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Motor Psycho (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Motor Psycho (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Motor Psycho (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Motor Psycho (PAL) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Motor Psycho (PAL) (Atari) (1990).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Ms Pac-Man (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Ninja Golf (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ninja Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ninja Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ninja Golf (PAL) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ninja Golf (PAL) (Atari) (1990).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "One-on-One Basketball (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\One-on-One Basketball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\One-on-One Basketball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\One-on-One Basketball (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\One-on-One Basketball (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Pete Rose Baseball (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pete Rose Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pete Rose Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pete Rose Baseball (PAL) (Absolute) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pete Rose Baseball (PAL) (Absolute) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Planet Smashers (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Planet Smashers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Planet Smashers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Planet Smashers (PAL) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Planet Smashers (PAL) (Atari) (1990).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Pole Position II (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Position II (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Position II (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole Position II (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole Position II (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "RealSports Baseball (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RealSports Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RealSports Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\RealSports Baseball (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\RealSports Baseball (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Baseball (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RealSports Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RealSports Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Baseball (PAL) (Absolute) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Baseball (PAL) (Absolute) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Sentinel (PAL) (Atari) (1991)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sentinel (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sentinel (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sentinel (PAL) (Atari) (1991).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sentinel (PAL) (Atari) (1991).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Robotron 2084 (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robotron - 2084 (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robotron - 2084 (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robotron 2084 (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robotron 2084 (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Scrapyard Dog (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard Dog (PAL) (Atari) (1990).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard Dog (PAL) (Atari) (1990).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Summer Games (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Summer Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Summer Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Summer Games (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Summer Games (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Super Huey UH-IX (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Huey UH-IX (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Huey UH-IX (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Huey UH-IX (PAL) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Huey UH-IX (PAL) (Atari) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Super Skateboardin' (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Skateboardin' (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Skateboardin' (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Skateboardin' (PAL) (Absolute) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Skateboardin' (PAL) (Absolute) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Tank Command (PAL) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tank Command (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tank Command (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tank Command (PAL) (Froggo) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tank_Command.htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Title Match Pro Wrestling (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Title Match Pro Wrestling (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Title Match Pro Wrestling (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Title Match Pro Wrestling (PAL) (Absolute) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Title Match Pro Wrestling (PAL) (Absolute) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Tomcat - The F-14 Fighter Simulator (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tomcat - The F-14 Fighter Simulator (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tomcat - The F-14 Fighter Simulator (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tomcat - The F-14 Fighter Simulator (PAL) (Absolute) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tomcat - The F-14 Fighter Simulator (PAL) (Absolute) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Touchdown Football (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Touchdown Football (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Touchdown Football (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Touchdown Football (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Touchdown Football (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Tower Toppler (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tower Toppler (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tower Toppler (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tower Toppler (PAL) (Atari) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tower Toppler (PAL) (Atari) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Water Ski (PAL) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Water Ski (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Water Ski (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Water Ski (PAL) (Froggo) (1988).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Water Ski (PAL) (Froggo) (1988).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Winter Games (Alternate) (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Winter Games (Alternate) (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter Games (Alternate) (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Winter Games (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\WWinter Games (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter Games (PAL) (Atari) (1987).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Xenophobe (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xenophobe (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xenophobe (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xenophobe (PAL) (Atari) (1989).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xenophobe (PAL) (Atari) (1989).htm"))
            End If
        End If

        If lstPALRetail.SelectedItem.ToString = "Xevious (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xevious (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xevious (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xevious (PAL) (Atari) (1987).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xevious (PAL) (Atari) (1987).htm"))
            End If
        End If
    End Sub



    Private Sub lstHomebrews_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHomebrews.SelectedIndexChanged

        'Update Game Info HTML Editor
        txtHTMLEditor.Clear()
        strFileName = "\" + lstHomebrews.Text + ".htm"
        txtEditorFile.Text = strManualsFolder + strFileName
        Try
            For Each s As String In System.IO.File.ReadAllLines(txtEditorFile.Text)
                txtHTMLEditor.AppendText(s + vbNewLine)
            Next
        Catch ex As Exception
        End Try

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
            If System.IO.File.Exists(strManualsFolder & "\Armor Attack II (20130416).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Armor Attack II (20130416).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Asteroids Deluxe (NTSC) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids Deluxe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids Deluxe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids Deluxe (NTSC) (20071014).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids Deluxe (NTSC) (20071014).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Asteroids Deluxe (PAL) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids Deluxe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids Deluxe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids Deluxe (PAL) (20071014).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids Deluxe (PAL) (20071014).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Astro Blaster (20140201)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Astro Blaster (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Astro Blaster (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Astro Blaster (20140201).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Astro Blaster (20140201).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Astro Fighter (20150726)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Astro Fighter (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Astro Fighter (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Astro Fighter (20150726).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Astro Fighter (20150726).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Astro Fighter (20150726)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Astro Fighter (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Astro Fighter (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Astro Fighter (20150726).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Astro Fighter (20150726).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Beef Drop (Final AtariAge)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Beef Drop (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Beef Drop (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Beef Drop (Final AtariAge).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Beef Drop (Final AtariAge).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "BonQ (Final AtariAge)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\bonQ (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\bonQ (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\BonQ (Final AtariAge).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\BonQ (Final AtariAge).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Crazy Brix (Joystick) (20160427)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Brix (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Brix (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy Brix (Joystick) (20160427).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy Brix (Joystick) (20160427).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Crazy Brix (Paddle) (20160427)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Brix (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Brix (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy Brix (Paddle) (20160427).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy Brix (Paddle) (20160427).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Crazy Otto (NTSC) (20100612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Otto (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Otto (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy Otto (NTSC) (20100612).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy Otto (NTSC) (20100612).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Crazy Otto (PAL) (20100612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Otto (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Otto (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy Otto (PAL) (20100612).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy Otto (PAL) (20100612).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Bentley Bear's Crystal Quest (20151220)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crystal Quest featuring Bentley Bear (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crystal Quest featuring Bentley Bear (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bentley Bear's Crystal Quest (20151220).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bentley Bear's Crystal Quest (20151220).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Dungeon Stalker (20151022)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dungeon Stalker (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dungeon Stalker (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dungeon Stalker (20151022).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dungeon Stalker (20151022).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "FailSafe (NTSC) (20100227)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\FailSafe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\FailSafe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\FailSafe (NTSC) (20100227).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\FailSafe (NTSC) (20100227).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "FailSafe (PAL) (20100227)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\FailSafe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\FailSafe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\FailSafe (PAL) (20100227).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\FailSafe (PAL) (20100227).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Frenzy (w-Berzerk) (20211025)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Frenzy (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Frenzy (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Frenzy (w-Berzerk) (20211025).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Frenzy (w-Berzerk) (20211025).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Froggie (NTSC) (Final Release) (20180920)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Froggie (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Froggie (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Froggie (NTSC) (Final Release) (20180920).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Froggie (NTSC) (Final Release) (20180920).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Froggie (PAL) (Final Release) (20180920)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Froggie (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Froggie (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Froggie (PAL) (Final Release) (20180920).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Froggie (PAL) (Final Release) (20180920).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Froggie (PAL) (Final Release) (20180920)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr. Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr. Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Froggie (PAL) (Final Release) (20180920).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Froggie (PAL) (Final Release) (20180920).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Jr Pac-Man (PAL) (20120924)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr. Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr. Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jr Pac-Man (PAL) (20120924).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jr Pac-Man (PAL) (20120924).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Jr Pac-Man (NTSC) (20120924)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr. Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr. Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jr Pac-Man (NTSC) (20120924).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jr Pac-Man (NTSC) (20120924).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Meteor Shower (NTSC) (20120218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meteor Shower (USA) (Unl) [Blue].jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meteor Shower (USA) (Unl) [Blue].jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meteor Shower (NTSC) (20120218).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meteor Shower (NTSC) (20120218).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Meteor Shower (PAL) (20120218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meteor Shower (USA) (Unl) [Blue].jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meteor Shower (USA) (Unl) [Blue].jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meteor Shower (PAL) (20120218).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meteor Shower (PAL) (20120218).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Moon Cresta (NTSC) (20111113)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Moon Cresta (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Moon Cresta (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Moon Cresta (NTSC) (20111113).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Moon Cresta (NTSC) (20111113).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Moon Cresta (PAL) (20111113)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Moon Cresta (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Moon Cresta (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Moon Cresta (PAL) (20111113).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Moon Cresta (PAL) (20111113).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Ms Pac-Man 320 (NTSC) (20110808)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man 320 (NTSC) (20110808).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man 320 (NTSC) (20110808).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Ms Pac-Man 320 (PAL) (20110808)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man 320 (PAL) (20110808).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man 320 (PAL) (20110808).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Pac-Man 320 (NTSC) (20110810)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man 320 (NTSC) (20110810).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man 320 (NTSC) (20110810).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man 320 (PAL) (20110810)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man 320 (PAL) (20110810).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man 320 (PAL) (20110810).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man Collection - 40th Anniversary Edition (20210420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Collection - 40th Anniversary Edition (20210420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Collection - 40th Anniversary Edition (20210420).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man Collection - 40th Anniversary Edition (Short Mazes) (20220530)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Collection - 40th Anniversary Edition (Short Mazes) (20220530).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Collection - 40th Anniversary Edition (Short Mazes) (20220530).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man Collection (20120119)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Collection (20120119).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Collection (20120119).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man Collection (New Monsters) (20150531)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Collection (New Monsters) (20150531).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Collection (New Monsters) (20150531).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Rip-Off (NTSC) (20120502)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rip-Off (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rip-Off (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rip-Off (NTSC) (20120502).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rip-Off (NTSC) (20120502).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Santa Simon (Valid Signature) (20170511)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Santa Simon (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Santa Simon (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Santa Simon (Valid Signature) (20170511).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Santa Simon (Valid Signature) (20170511).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Scramble (20161202)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scramble (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scramble (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scramble (20161202).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scramble (20161202).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Space Duel (NTSC) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Duel (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Duel (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space Duel (NTSC) (20071014).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space Duel (NTSC) (20071014).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Space Duel (PAL) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Duel (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Duel (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space Duel (PAL) (20071014).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space Duel (PAL) (20071014).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Space Invaders (NTSC) (20080801)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Invaders (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Invaders (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space Invaders (NTSC) (20080801).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space Invaders (NTSC) (20080801).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Space Invaders (PAL) (20080801)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Invaders (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Invaders (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space Invaders (PAL) (20080801).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space Invaders (PAL) (20080801).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Joystick) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Circus Atari Age (NTSC) (Joystick) (POKEY 0450) (20170611).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Circus Atari Age (NTSC) (Joystick) (POKEY 0450) (20170611).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Joystick) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Circus Atari Age (NTSC) (Joystick) (POKEY 4000) (20170611).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Circus Atari Age (NTSC) (Joystick) (POKEY 4000) (20170611).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Paddle) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Circus Atari Age (NTSC) (Paddle) (POKEY 0450) (20170611).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Circus Atari Age (NTSC) (Paddle) (POKEY 0450) (20170611).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Paddle) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Circus Atari Age (NTSC) (Paddle) (POKEY 4000) (20170611).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Circus Atari Age (NTSC) (Paddle) (POKEY 4000) (20170611).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Joystick) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Circus Atari Age (PAL) (Joystick) (POKEY 0450) (20170611).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Circus Atari Age (PAL) (Joystick) (POKEY 0450) (20170611).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Joystick) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Circus Atari Age (PAL) (Joystick) (POKEY 4000) (20170611).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Circus Atari Age (PAL) (Joystick) (POKEY 4000) (20170611).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Paddle) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Circus Atari Age (PAL) (Paddle) (POKEY 0450) (20170611).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Circus Atari Age (PAL) (Paddle) (POKEY 0450) (20170611).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Paddle) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Circus Atari Age (PAL) (Paddle) (POKEY 4000) (20170611).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Circus Atari Age (PAL) (Paddle) (POKEY 4000) (20170611).htm"))
            End If
        End If


        If lstHomebrews.SelectedItem.ToString = "Super Pac-Man (NTSC) (20081010)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Pac-Man (NTSC) (20081010).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Pac-Man (NTSC) (20081010).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Pac-Man (PAL) (20081010)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Pac-Man (PAL) (20081010).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Pac-Man (PAL) (20081010).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Wasp! (Standard Edition) (20090923)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Wasp! (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Wasp! (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Wasp! (Standard Edition) (20090923).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Wasp! (Standard Edition) (20090923).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Worm! (v1_16F) (20100307)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Worm! (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Worm! (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Worm! (v1_16F) (20100307).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Worm! (v1_16F) (20100307).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "7iX (20220305)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\7iX (20220305).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\7iX (20220305).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\7iX (20220305).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\7iX (20220305).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "2048 (RC1a) (20211113)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\2048 (RC1a) (20211113).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\2048 (RC1a) (20211113).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\2048 (RC1a) (20211113).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\2048 (RC1a) (20211113).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "7800 XMAS - Santa vs The Nightmares (20201219u1)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\7800 XMAS - Santa vs The Nightmares (20201219u1).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\7800 XMAS - Santa vs The Nightmares (20201219u1).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\7800 XMAS - Santa vs The Nightmares (20201219u1).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\7800 XMAS - Santa vs The Nightmares (20201219u1).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "A Roach In Space - Part II - Electric Bugaloo (20201119)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\A Roach In Space - Part II - Electric Bugaloo (20201119).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\A Roach In Space - Part II - Electric Bugaloo (20201119).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\A Roach In Space - Part II - Electric Bugaloo (20201119).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\A Roach In Space - Part II - Electric Bugaloo (20201119).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Alpha Race (20150920)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alpha Race (20150920).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alpha Race (20150920).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alpha Race (20150920).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alpha Race (20150920).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Apple Snaffle (v1_30F) (20100803)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Apple Snaffle (v1_30F) (20100803).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Apple Snaffle (v1_30F) (20100803).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Apple Snaffle (v1_30F) (20100803).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Apple Snaffle (v1_30F) (20100803).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Arkanoid (ChunkyPixel Games) (Demo) (20210103)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Arkanoid (ChunkyPixel Games) (Demo) (20210103).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Arkanoid (ChunkyPixel Games) (Demo) (20210103).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Arkanoid (ChunkyPixel Games) (Demo) (20210103).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Arkanoid (ChunkyPixel Games) (Demo) (20210103).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Arkanoid (Propane13) (20110911)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Arkanoid (Propane13) (20110911).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Arkanoid (Propane13) (20110911).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Arkanoid (Propane13) (20110911).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Arkanoid (Propane13) (20110911).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Atlas (20111023)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Atlas (20111023).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Atlas (20111023).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Atlas (20111023).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Atlas (20111023).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Baby Pac-Man (RC13) (20190208)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Baby Pac-Man (RC13) (20190208).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Baby Pac-Man (RC13) (20190208).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Baby Pac-Man (RC13) (20190208).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Baby Pac-Man (RC13) (20190208).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Bernie and the Cubic Conundrum (Alpha 10) (20211225)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bernie and the Cubic Conundrum (Alpha 10) (20211225).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bernie and the Cubic Conundrum (Alpha 10) (20211225).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bernie and the Cubic Conundrum (Alpha 10) (20211225).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bernie and the Cubic Conundrum (Alpha 10) (20211225).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Binary Land (20210208)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Binary Land (20210208).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Binary Land (20210208).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Binary Land (20210208).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Binary Land (20210208).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "BlocDrop (20130310)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\BlocDrop (20130310).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\BlocDrop (20130310).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\BlocDrop (20130310).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\BlocDrop (20130310).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Bomber Hero (20210114)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bomber Hero (20210114).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bomber Hero (20210114).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bomber Hero (20210114).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bomber Hero (20210114).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Boom (v1_5) (20150526)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Boom (v1_5) (20150526).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Boom (v1_5) (20150526).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Boom (v1_5) (20150526).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Boom (v1_5) (20150526).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Bullet Festival (20150831)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bullet Festival (20150831).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bullet Festival (20150831).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bullet Festival (20150831).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bullet Festival (20150831).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Cannon in D - D for Defense (Demo 03) (20220130)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Cannon in D - D for Defense (Demo 03) (20220130).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Cannon in D - D for Defense (Demo 03) (20220130).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Cannon in D - D for Defense (Demo 03) (20220130).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Cannon in D - D for Defense (Demo 03) (20220130).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Captain Comic (20200926)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Captain Comic (20200926).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Captain Comic (20200926).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Captain Comic (20200926).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Captain Comic (20200926).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Chase (20201231)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Chase (20201231).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Chase (20201231).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Chase (20201231).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Chase (20201231).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Chicago Basement (20160914)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Chicago Basement (20160914).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Chicago Basement (20160914).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Chicago Basement (20160914).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Chicago Basement (20160914).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Chicago Basement (20160914)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Chicago Basement (20160914).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Chicago Basement (20160914).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Chicago Basement (20160914).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Chicago Basement (20160914).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Clean Sweep (20160208)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Clean Sweep (20160208).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Clean Sweep (20160208).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Clean Sweep (20160208).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Clean Sweep (20160208).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Conversion - batari Basic Demo (20210409)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Conversion - batari Basic Demo (20210409).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Conversion - batari Basic Demo (20210409).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Conversion - batari Basic Demo (20210409).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Conversion - batari Basic Demo (20210409).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Cosmic Cabbie (20121229)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Cosmic Cabbie (20121229).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Cosmic Cabbie (20121229).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Cosmic Cabbie (20121229).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Cosmic Cabbie (20121229).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Court Pooper (Demo) (20220617)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Court Pooper (Demo) (20220617).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Court Pooper (Demo) (20220617).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Court Pooper (Demo) (20220617).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Court Pooper (Demo) (20220617).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Crazy Tank (20180310)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Tank (20180310).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Tank (20180310).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy Tank (20180310).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy Tank (20180310).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Cyb Ur (RC1) (20190526)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Cyb Ur (RC1) (20190526).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Cyb Ur (RC1) (20190526).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Cyb Ur (RC1) (20190526).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Cyb Ur (RC1) (20190526).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Danger Zone (RC-4C) (NTSC Demo) (20201231)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Danger Zone (RC-4C) (NTSC Demo) (20201231).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Danger Zone (RC-4C) (NTSC Demo) (20201231).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Danger Zone (RC-4C) (NTSC Demo) (20201231).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Danger Zone (RC-4C) (NTSC Demo) (20201231).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Death Merchant (1.0) (20170805)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Death Merchant (1.0) (20170805).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Death Merchant (1.0) (20170805).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Death Merchant (1.0) (20170805).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Death Merchant (1.0) (20170805).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Defender (20220128)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Defender (20220128).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Defender (20220128).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Defender (20220128).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Defender (20220128).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Donkey Kong PK-XM (NTSC) (Demo) (v1.2) (20130905)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong PK-XM (NTSC) (Demo) (v1.2) (20130905).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong PK-XM (NTSC) (Demo) (v1.2) (20130905).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey Kong PK-XM (NTSC) (Demo) (v1.2) (20130905).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey Kong PK-XM (NTSC) (Demo) (v1.2) (20130905).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Donkey Kong PK-XM (PAL) (Demo) (v1.2) (20130905)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong PK-XM (PAL) (Demo) (v1.2) (20130905).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong PK-XM (PAL) (Demo) (v1.2) (20130905).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey Kong PK-XM (PAL) (Demo) (v1.2) (20130905).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey Kong PK-XM (PAL) (Demo) (v1.2) (20130905).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Dragon's Cache (20210207)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dragon's Cache (20210207).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dragon's Cache (20210207).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dragon's Cache (20210207).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dragon's Cache (20210207).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Dragon's Descent (20210731)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dragon's Descent (20210731).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dragon's Descent (20210731).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dragon's Descent (20210731).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dragon's Descent (20210731).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Dragon's Havoc (20220220)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dragon's Havoc (20220220).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dragon's Havoc (20220220).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dragon's Havoc (20220220).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dragon's Havoc (20220220).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Draker Quest (Beta 4) (20150727)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Draker Quest (Beta 4) (20150727).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Draker Quest (Beta 4) (20150727).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Draker Quest (Beta 4) (20150727).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Draker Quest (Beta 4) (20150727).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Draker Quest II (20170619)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Draker Quest II (20170619).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Draker Quest II (20170619).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Draker Quest II (20170619).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Draker Quest II (20170619).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "E X O (RC Demo A) (20211225)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\E X O (RC Demo A) (20211225).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\E X O (RC Demo A) (20211225).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\E X O (RC Demo A) (20211225).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\E X O (RC Demo A) (20211225).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "ET Book Cart (Demo) (20150524)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\ET Book Cart (Demo) (20150524).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\ET Book Cart (Demo) (20150524).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\ET Book Cart (Demo) (20150524).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\ET Book Cart (Demo) (20150524).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Fat Axl (20160613)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fat Axl (20160613).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fat Axl (20160613).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fat Axl (20160613).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fat Axl (20160613).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Flappy Bird (Beta) (20141221)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Flappy Bird (Beta) (20141221).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Flappy Bird (Beta) (20141221).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Flappy Bird (Beta) (20141221).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Flappy Bird (Beta) (20141221).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Frogus (20190804)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Frogus (20190804).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Frogus (20190804).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Frogus (20190804).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Frogus (20190804).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Galaxian (20211118u1)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian (20211118u1).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian (20211118u1).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian (20211118u1).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian (20211118u1).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Get Lost! (20210407)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Get Lost! (20210407).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Get Lost! (20210407).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Get Lost! (20210407).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Get Lost! (20210407).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Ghosts'n Goblins (20211205u1)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ghosts'n Goblins (20211205u1).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ghosts'n Goblins (20211205u1).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ghosts'n Goblins (20211205u1).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ghosts'n Goblins (20211205u1).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Gorf (20091213)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Gorf (20091213).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Gorf (20091213).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Gorf (20091213).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Gorf (20091213).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "GoSub (20200506)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\GoSub (20200506).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\GoSub (20200506).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\GoSub (20200506).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\GoSub (20200506).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Graze Suit Alpha (20170910)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Graze Suit Alpha (20170910).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Graze Suit Alpha (20170910).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Graze Suit Alpha (20170910).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Graze Suit Alpha (20170910).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Halloween Last Stand (20201102)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Halloween Last Stand (20201102).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Halloween Last Stand (20201102).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Halloween Last Stand (20201102).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Halloween Last Stand (20201102).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Harry's Hen House (1_07F) (20100117)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Harry's Hen House (1_07F) (20100117).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Harry's Hen House (1_07F) (20100117).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Harry's Hen House (1_07F) (20100117).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Harry's Hen House (1_07F) (20100117).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Heartlight (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Heartlight (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Heartlight (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Heartlight (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Heartlight (20210118).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Hearty Manslapper (20161129)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hearty Manslapper (20161129).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hearty Manslapper (20161129).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hearty Manslapper (20161129).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hearty Manslapper (20161129).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Heofonfir (Test) (20210116)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Heofonfir (Test) (20210116).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Heofonfir (Test) (20210116).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Heofonfir (Test) (20210116).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Heofonfir (Test) (20210116).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "High Card Draw (20220303)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\High Card Draw (20220303).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\High Card Draw (20220303).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\High Card Draw (20220303).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\High Card Draw (20220303).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Hollywood Brawler (20160811)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hollywood Brawler (20160811).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hollywood Brawler (20160811).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hollywood Brawler (20160811).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hollywood Brawler (20160811).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Iron Grip - Destroyer Of Worlds (20210518)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Iron Grip - Destroyer Of Worlds (20210518).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Iron Grip - Destroyer Of Worlds (20210518).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Iron Grip - Destroyer Of Worlds (20210518).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Iron Grip - Destroyer Of Worlds (20210518).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Keystone Kapers (Demo 1b) (20211107)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Keystone Kapers (Demo 1b) (20211107).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Keystone Kapers (Demo 1b) (20211107).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Keystone Kapers (Demo 1b) (20211107).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Keystone Kapers (Demo 1b) (20211107).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Knight Guy - Quest For Something (20210423)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Knight Guy - Quest For Something (20210423).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Knight Guy - Quest For Something (20210423).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Knight Guy - Quest For Something (20210423).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Knight Guy - Quest For Something (20210423).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Knight Guy On Board - 30 Squares Of Fate (20210116)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Knight Guy On Board - 30 Squares Of Fate (20210116).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Knight Guy On Board - 30 Squares Of Fate (20210116).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Knight Guy On Board - 30 Squares Of Fate (20210116).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Knight Guy On Board - 30 Squares Of Fate (20210116).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Krull (v06) (20220319)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Krull (v06) (20220319).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Krull (v06) (20220319).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Krull (v06) (20220319).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Krull (v06) (20220319).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "LadyLady (20200810)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\LadyLady (20200810).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\LadyLady (20200810).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\LadyLady (20200810).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\LadyLady (20200810).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Legend of Silverpeak (20180101)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Legend of Silverpeak (20180101).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Legend of Silverpeak (20180101).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Legend of Silverpeak (20180101).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Legend of Silverpeak (20180101).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Lemmings Squidginator (20200330)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Lemmings Squidginator (20200330).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Lemmings Squidginator (20200330).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Lemmings Squidginator (20200330).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Lemmings Squidginator (20200330).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Merlain 7800 (20191102)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Merlain 7800 (20191102).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Merlain 7800 (20191102).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Merlain 7800 (20191102).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Merlain 7800 (20191102).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Meteor Shower (NTSC) (20120218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meteor Shower (NTSC) (20120218).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meteor Shower (NTSC) (20120218).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meteor Shower (NTSC) (20120218).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meteor Shower (NTSC) (20120218).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Meteor Shower (PAL) (20120218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meteor Shower (PAL) (20120218).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meteor Shower (PAL) (20120218).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meteor Shower (PAL) (20120218).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meteor Shower (PAL) (20120218).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Millie And Molly (Demo) (20201206)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Millie And Molly (Demo) (20201206).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Millie And Molly (Demo) (20201206).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Millie And Molly (Demo) (20201206).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Millie And Molly (Demo) (20201206).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Monster Maze (20220306)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Monster Maze (20220306).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Monster Maze (20220306).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Monster Maze (20220306).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Monster Maze (20220306).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Morf (20220314)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Morf (20220314).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Morf (20220314).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Morf (20220314).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Morf (20220314).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Ms Pac-Man Twin (20160208)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man Twin (20160208).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man Twin (20160208).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man Twin (20160208).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man Twin (20160208).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Ninjish Guy - Perilous Island (20211107)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ninjish Guy - Perilous Island (20211107).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ninjish Guy - Perilous Island (20211107).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ninjish Guy - Perilous Island (20211107).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ninjish Guy - Perilous Island (20211107).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Number Crusher (20210523u1)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Number Crusher (20210523u1).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Number Crusher (20210523u1).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Number Crusher (20210523u1).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Number Crusher (20210523u1).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "OOZY THE GOO - Gaiden (Demo 3) (20220625)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\OOZY THE GOO - Gaiden (Demo 3) (20220625).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\OOZY THE GOO - Gaiden (Demo 3) (20220625).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\OOZY THE GOO - Gaiden (Demo 3) (20220625).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\OOZY THE GOO - Gaiden (Demo 3) (20220625).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Orion Assault (vA02) (20220522)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Orion Assault (vA02) (20220522).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Orion Assault (vA02) (20220522).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Orion Assault (vA02) (20220522).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Orion Assault (vA02) (20220522).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man 320 (NTSC) (20110810)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man 320 (NTSC) (20110810).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man 320 (NTSC) (20110810).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man 320 (NTSC) (20110810).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man 320 (NTSC) (20110810).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pac-Man 320 (PAL) (20110810)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man 320 (PAL) (20110810).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man 320 (PAL) (20110810).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man 320 (PAL) (20110810).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man 320 (PAL) (20110810).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Panda Racer (20151224)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Panda Racer (20151224).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Panda Racer (20151224).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Panda Racer (20151224).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Panda Racer (20151224).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Penta (Demo) (20211113AM)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Penta (Demo) (20211113AM).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Penta (Demo) (20211113AM).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Penta (Demo) (20211113AM).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Penta (Demo) (20211113AM).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pineapple (20220619)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pineapple (20220619).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pineapple (20220619).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pineapple (20220619).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pineapple (20220619).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Pirate Cove (20220415)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pirate Cove (20220415).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pirate Cove (20220415).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pirate Cove (20220415).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pirate Cove (20220415).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Plink (20201213)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Plink (20201213).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Plink (20201213).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Plink (20201213).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Plink (20201213).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Plumb Luck (20170702)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Plumb Luck (20170702).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Plumb Luck (20170702).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Plumb Luck (20170702).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Plumb Luck (20170702).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Plumb Luck DX (20220327)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Plumb Luck DX (20220327).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Plumb Luck DX (20220327).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Plumb Luck DX (20220327).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Plumb Luck DX (20220327).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Poetiru (20150901)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Poetiru (20150901).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Poetiru (20150901).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Poetiru (20150901).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Poetiru (20150901).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Popeye (RC 3_5 Demo) (20210303)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Popeye (RC 3_5 Demo) (20210303).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Popeye (RC 3_5 Demo) (20210303).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Popeye (RC 3_5 Demo) (20210303).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Popeye (RC 3_5 Demo) (20210303).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Portal (PAL) (20210331)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Portal (PAL) (20210331).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Portal (PAL) (20210331).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Portal (PAL) (20210331).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Portal (PAL) (20210331).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Realm Of No, The (Book Cart) (20161224)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Realm Of No, The (Book Cart) (20161224).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Realm Of No, The (Book Cart) (20161224).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Realm Of No, The (Book Cart) (20161224).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Realm Of No, The (Book Cart) (20161224).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "ReZolve (20141207)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\ReZolve (20141207).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\ReZolve (20141207).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\ReZolve (20141207).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\ReZolve (20141207).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Rider of the Night (20190711)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rider of the Night (20190711).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rider of the Night (20190711).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rider of the Night (20190711).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rider of the Night (20190711).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Robbo (20160513)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robbo (20160513).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robbo (20160513).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robbo (20160513).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robbo (20160513).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Robot Finds Kitten (224 Lines) (20220331)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robot Finds Kitten (224 Lines) (20220331).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robot Finds Kitten (224 Lines) (20220331).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robot Finds Kitten (224 Lines) (20220331).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robot Finds Kitten (224 Lines) (20220331).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Robot Finds Kitten (20050619)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robot Finds Kitten (20050619).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robot Finds Kitten (20050619).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robot Finds Kitten (20050619).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robot Finds Kitten (20050619).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Robots Rumble (20220217)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robots Rumble (20220217).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robots Rumble (20220217).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robots Rumble (20220217).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robots Rumble (20220217).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Roof Pooper (20161006)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Roof Pooper (20161006).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Roof Pooper (20161006).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Roof Pooper (20161006).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Roof Pooper (20161006).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Serpentine (20161029)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Serpentine (20161029).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Serpentine (20161029).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Serpentine (20161029).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Serpentine (20161029).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Shoot the UFO 2015 (20150328)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Shoot the UFO 2015 (20150328).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Shoot the UFO 2015 (20150328).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Shoot the UFO 2015 (20150328).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Shoot the UFO 2015 (20150328).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Sick Pickles (20171202)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sick Pickles (20171202).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sick Pickles (20171202).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sick Pickles (20171202).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sick Pickles (20171202).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Sky Scraper 2115 (6f) (20171019)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sky Scraper 2115 (6f) (20171019).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sky Scraper 2115 (6f) (20171019).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sky Scraper 2115 (6f) (20171019).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sky Scraper 2115 (6f) (20171019).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Slide Boy in Maze Land (RC1) (20210515)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Slide Boy in Maze Land (RC1) (20210515).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Slide Boy in Maze Land (RC1) (20210515).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Slide Boy in Maze Land (RC1) (20210515).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Slide Boy in Maze Land (RC1) (20210515).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Smasteroids (20140712)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Smasteroids (20140712).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Smasteroids (20140712).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Smasteroids (20140712).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Smasteroids (20140712).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Soccer 2 (20140614)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Soccer 2 (20140614).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Soccer 2 (20140614).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Soccer 2 (20140614).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Soccer 2 (20140614).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Space Junk (1b) (20170927)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Junk (1b) (20170927).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Junk (1b) (20170927).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space Junk (1b) (20170927).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space Junk (1b) (20170927).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Space Peril (NTSC) (v8) (20210907)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Peril (NTSC) (v8) (20210907).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Peril (NTSC) (v8) (20210907).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space Peril (NTSC) (v8) (20210907).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space Peril (NTSC) (v8) (20210907).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Space Peril (PAL) (v8) (20210907)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Peril (PAL) (v8) (20210907).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Peril (PAL) (v8) (20210907).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space Peril (PAL) (v8) (20210907).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space Peril (PAL) (v8) (20210907).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Spire Of The Ancients (NTSC) (20201223)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Spire Of The Ancients (NTSC) (20201223).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Spire Of The Ancients (NTSC) (20201223).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Spire Of The Ancients (NTSC) (20201223).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Spire Of The Ancients (NTSC) (20201223).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Spire Of The Ancients (PAL) (20201223)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Spire Of The Ancients (PAL) (20201223).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Spire Of The Ancients (PAL) (20201223).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Spire Of The Ancients (PAL) (20201223).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Spire Of The Ancients (PAL) (20201223).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Pac-Man (NTSC) (20081010)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Pac-Man (NTSC) (20081010).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Pac-Man (NTSC) (20081010).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Pac-Man (NTSC) (20081010).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Pac-Man (NTSC) (20081010).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Super Pac-Man (PAL) (20081010)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Pac-Man (PAL) (20081010).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Pac-Man (PAL) (20081010).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Pac-Man (PAL) (20081010).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Pac-Man (PAL) (20081010).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Tempest (BBC X-Port 1) (v1_00F) (20100324)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tempest (BBC X-Port 1) (v1_00F) (20100324).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tempest (BBC X-Port 1) (v1_00F) (20100324).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tempest (BBC X-Port 1) (v1_00F) (20100324).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tempest (BBC X-Port 1) (v1_00F) (20100324).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "The Big Burrito (20170823)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\The Big Burrito (20170823).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\The Big Burrito (20170823).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\The Big Burrito (20170823).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\The Big Burrito (20170823).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Touchdown Challenge (20140610)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Touchdown Challenge (20140610).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Touchdown Challenge (20140610).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Touchdown Challenge (20140610).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Touchdown Challenge (20140610).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Tubes (20050809)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tubes (20050809).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tubes (20050809).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tubes (20050809).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tubes (20050809).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "UFO! (20091213)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\UFO! (20091213).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\UFO! (20091213).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\UFO! (20091213).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\UFO! (20091213).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "UniWarS (RC4) (20210114)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\UniWarS (RC4) (20210114).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\UniWarS (RC4) (20210114).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\UniWarS (RC4) (20210114).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\UniWarS (RC4) (20210114).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "V Blank - Chapter 1 - Into The Void (20210326u1)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\V Blank - Chapter 1 - Into The Void (20210326u1).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\V Blank - Chapter 1 - Into The Void (20210326u1).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\V Blank - Chapter 1 - Into The Void (20210326u1).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\V Blank - Chapter 1 - Into The Void (20210326u1).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "WarBirds (20091213)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\WarBirds (20091213).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\WarBirds (20091213).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\WarBirds (20091213).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\WarBirds (20091213).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "Wizard's Dungeon (20211111)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Wizard's Dungeon (20211111).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Wizard's Dungeon (20211111).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Wizard's Dungeon (20211111).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Wizard's Dungeon (20211111).htm"))
            End If
        End If

        If lstHomebrews.SelectedItem.ToString = "WORDLE (20220308)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\WORDLE (20220308).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\WORDLE (20220308).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\WORDLE (20220308).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\WORDLE (20220308).htm"))
            End If
        End If

    End Sub

    Private Sub lstHacks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHacks.SelectedIndexChanged

        'Update Game Info HTML Editor
        txtHTMLEditor.Clear()
        strFileName = "\" + lstHacks.Text + ".htm"
        txtEditorFile.Text = strManualsFolder + strFileName
        Try
            For Each s As String In System.IO.File.ReadAllLines(txtEditorFile.Text)
                txtHTMLEditor.AppendText(s + vbNewLine)
            Next
        Catch ex As Exception
        End Try

        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtHacksPath.Text + "\" + lstHacks.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch


        If lstHacks.SelectedItem.ToString = "Pac Pollux (Hack) (20060305)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Pollux (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Pollux (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac Pollux (Hack) (20060305).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac Pollux (Hack) (20060305).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Super Cobra (Hack) (20120503)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Cobra (USA) (Hack).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Cobra (USA) (Hack).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Cobra (Hack) (20120503).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Cobra (Hack) (20120503).htm"))
            End If
        End If


        If lstHacks.SelectedItem.ToString = "2600 Maze Pac-Man (Hack) (20171231)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\2600 Maze Pac-Man (Hack) (20171231).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\2600 Maze Pac-Man (Hack) (20171231).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\2600 Maze Pac-Man (Hack) (20171231).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\2600 Maze Pac-Man (Hack) (20171231).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Asterix (Hack) (20110401)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asterix (Hack) (20110401).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asterix (Hack) (20110401).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asterix (Hack) (20110401).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asterix (Hack) (20110401).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Asterix Quest (Hack) (20161224)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asterix Quest (Hack) (20161224).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asterix Quest (Hack) (20161224).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asterix Quest (Hack) (20161224).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asterix Quest (Hack) (20161224).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Asteroids (Vector Edition Hack) (20050724)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids (Vector Edition Hack) (20050724).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids (Vector Edition Hack) (20050724).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids (Vector Edition Hack) (20050724).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids (Vector Edition Hack) (20050724).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Asteroids Deluxe (Blue Hack) (20200405)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids Deluxe (Blue Hack) (20200405).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids Deluxe (Blue Hack) (20200405).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids Deluxe (Blue Hack) (20200405).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids Deluxe (Blue Hack) (20200405).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Asteroids Deluxe (Blue Hack) (P2 Pink) (20200405)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids Deluxe (Blue Hack) (P2 Pink) (20200405).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids Deluxe (Blue Hack) (P2 Pink) (20200405).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids Deluxe (Blue Hack) (P2 Pink) (20200405).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids Deluxe (Blue Hack) (P2 Pink) (20200405).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Asteroids, 3D (NTSC) (Hack) (20131104)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids, 3D (NTSC) (Hack) (20131104).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids, 3D (NTSC) (Hack) (20131104).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids, 3D (NTSC) (Hack) (20131104).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids, 3D (NTSC) (Hack) (20131104).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Baby Pac-Man (Ferrell's Hack) (20180610)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Baby Pac-Man (Ferrell's Hack) (20180610).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Baby Pac-Man (Ferrell's Hack) (20180610).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Baby Pac-Man (Ferrell's Hack) (20180610).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Baby Pac-Man (Ferrell's Hack) (20180610).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Baby Pac-Man (Jayzn's Hack) (20130210)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Baby Pac-Man (Jayzn's Hack) (20130210).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Baby Pac-Man (Jayzn's Hack) (20130210).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Baby Pac-Man (Jayzn's Hack) (20130210).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Baby Pac-Man (Jayzn's Hack) (20130210).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Baby Pac-Man (Jayzn's Hack) (Fast) (Invincible)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Baby Pac-Man (Jayzn's Hack) (Fast) (Invincible).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Baby Pac-Man (Jayzn's Hack) (Fast) (Invincible).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Baby Pac-Man (Jayzn's Hack) (Fast) (Invincible).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Baby Pac-Man (Jayzn's Hack) (Fast) (Invincible).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Baby Pac-Man (Jayzn's Hack) (Invincible)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Baby Pac-Man (Jayzn's Hack) (Invincible).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Baby Pac-Man (Jayzn's Hack) (Invincible).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Baby Pac-Man (Jayzn's Hack) (Invincible).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Baby Pac-Man (Jayzn's Hack) (Invincible).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Baby Pac-Man (Justin's Hack) (20130510)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Baby Pac-Man (Justin's Hack) (20130510).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Baby Pac-Man (Justin's Hack) (20130510).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Baby Pac-Man (Justin's Hack) (20130510).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Baby Pac-Man (Justin's Hack) (20130510).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Baby Pac-Man (Uki) (Hack) (20130422)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Baby Pac-Man (Uki) (Hack) (20130422).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Baby Pac-Man (Uki) (Hack) (20130422).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Baby Pac-Man (Uki) (Hack) (20130422).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Baby Pac-Man (Uki) (Hack) (20130422).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Beef Drop (New Levels) (Hack) (20061225)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Beef Drop (New Levels) (Hack) (20061225).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Beef Drop (New Levels) (Hack) (20061225).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Beef Drop (New Levels) (Hack) (20061225).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Beef Drop (New Levels) (Hack) (20061225).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Bentley Bear's Crystal Quest (Wonder Hack) (20170820)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bentley Bear's Crystal Quest (Wonder Hack) (20170820).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bentley Bear's Crystal Quest (Wonder Hack) (20170820).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bentley Bear's Crystal Quest (Wonder Hack) (20170820).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bentley Bear's Crystal Quest (Wonder Hack) (20170820).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Bleach Pac-Man (Hack) (20160917)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bleach Pac-Man (Hack) (20160917).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bleach Pac-Man (Hack) (20160917).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bleach Pac-Man (Hack) (20160917).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bleach Pac-Man (Hack) (20160917).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Blinky (Hack) (20200305)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Blinky (Hack) (20200305).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blinky (Hack) (20200305).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Blinky (Hack) (20200305).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Blinky (Hack) (20200305).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "BonQ (Final AtariAge) (No POKEY Init Hack) (20210403)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\BonQ (Final AtariAge) (No POKEY Init Hack) (20210403).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\BonQ (Final AtariAge) (No POKEY Init Hack) (20210403).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\BonQ (Final AtariAge) (No POKEY Init Hack) (20210403).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\BonQ (Final AtariAge) (No POKEY Init Hack) (20210403).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Caterpiller (Hack) (20090828)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Caterpiller (Hack) (20090828).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Caterpiller (Hack) (20090828).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Caterpiller (Hack) (20090828).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Caterpiller (Hack) (20090828).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede (Tball) (Hack) (20050630)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede (Tball) (Hack) (20050630).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede (Tball) (Hack) (20050630).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede (Tball) (Hack) (20050630).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede (Tball) (Hack) (20050630).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede Arcade Bezel (Hack) (20200831)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede Arcade Bezel (Hack) (20200831).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede Arcade Bezel (Hack) (20200831).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede Arcade Bezel (Hack) (20200831).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede Arcade Bezel (Hack) (20200831).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede Arcade Bezel (Trak-Ball) (Hack) (v3) (20200831)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede Arcade Bezel (Trak-Ball) (Hack) (v3) (20200831).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede Arcade Bezel (Trak-Ball) (Hack) (v3) (20200831).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede Arcade Bezel (Trak-Ball) (Hack) (v3) (20200831).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede Arcade Bezel (Trak-Ball) (Hack) (v3) (20200831).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede Dark Bezel (Trak-Ball) (Hack) (v3) (20200831)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede Dark Bezel (Trak-Ball) (Hack) (v3) (20200831).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede Dark Bezel (Trak-Ball) (Hack) (v3) (20200831).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede Dark Bezel (Trak-Ball) (Hack) (v3) (20200831).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede Dark Bezel (Trak-Ball) (Hack) (v3) (20200831).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede Frameless (Hack) (20150604)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede Frameless (Hack) (20150604).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede Frameless (Hack) (20150604).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede Frameless (Hack) (20150604).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede Frameless (Hack) (20150604).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede Frameless (Trak-Ball) (Hack) (v3) (20200831)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede Frameless (Trak-Ball) (Hack) (v3) (20200831).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede Frameless (Trak-Ball) (Hack) (v3) (20200831).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede Frameless (Trak-Ball) (Hack) (v3) (20200831).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede Frameless (Trak-Ball) (Hack) (v3) (20200831).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede PMI (NTSC) (Hack) (20150927)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede PMI (NTSC) (Hack) (20150927).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede PMI (NTSC) (Hack) (20150927).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede PMI (NTSC) (Hack) (20150927).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede PMI (NTSC) (Hack) (20150927).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede PMI (PAL) (Hack) (20150927)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede PMI (PAL) (Hack) (20150927).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede PMI (PAL) (Hack) (20150927).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede PMI (PAL) (Hack) (20150927).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede PMI (PAL) (Hack) (20150927).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede PMI (TBall) (20150927)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede PMI (TBall) (20150927).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede PMI (TBall) (20150927).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede PMI (TBall) (20150927).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede PMI (TBall) (20150927).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede REV (NTSC) (Hack) (20151003)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede REV (NTSC) (Hack) (20151003).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede REV (NTSC) (Hack) (20151003).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede REV (NTSC) (Hack) (20151003).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede REV (NTSC) (Hack) (20151003).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede REV (PAL) (Hack) (20151003)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede REV (PAL) (Hack) (20151003).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede REV (PAL) (Hack) (20151003).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede REV (PAL) (Hack) (20151003).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede REV (PAL) (Hack) (20151003).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede REV (TBall) (Hack) (20151003)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede REV (TBall) (Hack) (20151003).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede REV (TBall) (Hack) (20151003).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede REV (TBall) (Hack) (20151003).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede REV (TBall) (Hack) (20151003).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede+ (NTSC) (Hack) (20130108)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede+ (NTSC) (Hack) (20130108).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede+ (NTSC) (Hack) (20130108).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede+ (NTSC) (Hack) (20130108).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede+ (NTSC) (Hack) (20130108).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Centipede+ (TBall) (NTSC) (Hack) (20130108)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede+ (TBall) (NTSC) (Hack) (20130108).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede+ (TBall) (NTSC) (Hack) (20130108).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede+ (TBall) (NTSC) (Hack) (20130108).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede+ (TBall) (NTSC) (Hack) (20130108).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "ChampPac SJB (Hack) (20130420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\ChampPac SJB (Hack) (20130420).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\ChampPac SJB (Hack) (20130420).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\ChampPac SJB (Hack) (20130420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\ChampPac SJB (Hack) (20130420).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Choplifter (HUD) (Hack) (20130921)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Choplifter (HUD) (Hack) (20130921).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Choplifter (HUD) (Hack) (20130921).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Choplifter (HUD) (Hack) (20130921).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Choplifter (HUD) (Hack) (20130921).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Choplifter (Wings) (Hack) (20130921)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Choplifter (Wings) (Hack) (20130921).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Choplifter (Wings) (Hack) (20130921).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Choplifter (Wings) (Hack) (20130921).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Choplifter (Wings) (Hack) (20130921).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Christmas Jr Pac-Man (C64 Mazes) (Hack) (20091224)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Christmas Jr Pac-Man (C64 Mazes) (Hack) (20091224).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Christmas Jr Pac-Man (C64 Mazes) (Hack) (20091224).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Christmas Jr Pac-Man (C64 Mazes) (Hack) (20091224).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Christmas Jr Pac-Man (C64 Mazes) (Hack) (20091224).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Christmas Jr Pac-Man (New Mazes) (Hack) (20091223)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Christmas Jr Pac-Man (New Mazes) (Hack) (20091223).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Christmas Jr Pac-Man (New Mazes) (Hack) (20091223).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Christmas Jr Pac-Man (New Mazes) (Hack) (20091223).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Christmas Jr Pac-Man (New Mazes) (Hack) (20091223).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Christmas Jr Pac-Man (Old Mazes) (Hack) (20091223)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Christmas Jr Pac-Man (Old Mazes) (Hack) (20091223).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Christmas Jr Pac-Man (Old Mazes) (Hack) (20091223).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Christmas Jr Pac-Man (Old Mazes) (Hack) (20091223).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Christmas Jr Pac-Man (Old Mazes) (Hack) (20091223).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Christmas Pac-Man (Hack) (20171225)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Christmas Pac-Man (Hack) (20171225).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Christmas Pac-Man (Hack) (20171225).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Christmas Pac-Man (Hack) (20171225).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Christmas Pac-Man (Hack) (20171225).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Christmas Pac-Man 2 (Hack) (20181225)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Christmas Pac-Man 2 (Hack) (20181225).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Christmas Pac-Man 2 (Hack) (20181225).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Christmas Pac-Man 2 (Hack) (20181225).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Christmas Pac-Man 2 (Hack) (20181225).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Christmas Pac-Man Plus (Hack) (20191225)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Christmas Pac-Man Plus (Hack) (20191225).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Christmas Pac-Man Plus (Hack) (20191225).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Christmas Pac-Man Plus (Hack) (20191225).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Christmas Pac-Man Plus (Hack) (20191225).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Christmas Salvo (Hack) (20201201)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Christmas Salvo (Hack) (20201201).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Christmas Salvo (Hack) (20201201).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Christmas Salvo (Hack) (20201201).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Christmas Salvo (Hack) (20201201).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Clean Sweep (De Lucia's Hack) (20130502)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Clean Sweep (De Lucia's Hack) (20130502).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Clean Sweep (De Lucia's Hack) (20130502).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Clean Sweep (De Lucia's Hack) (20130502).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Clean Sweep (De Lucia's Hack) (20130502).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Clean Sweep (Ferrell's Hack) (20151204)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Clean Sweep (Ferrell's Hack) (20151204).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Clean Sweep (Ferrell's Hack) (20151204).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Clean Sweep (Ferrell's Hack) (20151204).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Clean Sweep (Ferrell's Hack) (20151204).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Clean Sweep (Vectrex Edition) (Hack) (20151204)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Clean Sweep (Vectrex Edition) (Hack) (20151204).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Clean Sweep (Vectrex Edition) (Hack) (20151204).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Clean Sweep (Vectrex Edition) (Hack) (20151204).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Clean Sweep (Vectrex Edition) (Hack) (20151204).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Clobberman (Hack) (20181210)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Clobberman (Hack) (20181210).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Clobberman (Hack) (20181210).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Clobberman (Hack) (20181210).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Clobberman (Hack) (20181210).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Clobberman (Invincible) (Hack) (20181210)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Clobberman (Invincible) (Hack) (20181210).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Clobberman (Invincible) (Hack) (20181210).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Clobberman (Invincible) (Hack) (20181210).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Clobberman (Invincible) (Hack) (20181210).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Coronavirus Pac-Man (Hack) (20200710).a78" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Coronavirus Pac-Man (Hack) (20200710).a78.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Coronavirus Pac-Man (Hack) (20200710).a78.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Coronavirus Pac-Man (Hack) (20200710).a78.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Coronavirus Pac-Man (Hack) (20200710).a78.htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Cosmic Cruncher (Hack) (20141220)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Cosmic Cruncher (Hack) (20141220).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Cosmic Cruncher (Hack) (20141220).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Cosmic Cruncher (Hack) (20141220).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Cosmic Cruncher (Hack) (20141220).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Damaged Pac (Hack) (20130422)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Damaged Pac (Hack) (20130422).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Damaged Pac (Hack) (20130422).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Damaged Pac (Hack) (20130422).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Damaged Pac (Hack) (20130422).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Desert Falcon (HSC Support) (Hack) (20040616)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Desert Falcon (HSC Support) (Hack) (20040616).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Desert Falcon (HSC Support) (Hack) (20040616).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Desert Falcon (HSC Support) (Hack) (20040616).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Desert Falcon (HSC Support) (Hack) (20040616).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Desert Falcon X (NTSC) (20130805)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Desert Falcon X (NTSC) (20130805).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Desert Falcon X (NTSC) (20130805).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Desert Falcon X (NTSC) (20130805).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Desert Falcon X (NTSC) (20130805).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Desert Falcon X (PAL) (20130805)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Desert Falcon X (PAL) (20130805).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Desert Falcon X (PAL) (20130805).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Desert Falcon X (PAL) (20130805).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Desert Falcon X (PAL) (20130805).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Dig Dog (NTSC) (Harp) (Hack) (20130103)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dig Dog (NTSC) (Harp) (Hack) (20130103).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dig Dog (NTSC) (Harp) (Hack) (20130103).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dig Dog (NTSC) (Harp) (Hack) (20130103).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dig Dog (NTSC) (Harp) (Hack) (20130103).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Dig Dog (NTSC) (No Harp) (Hack) (20130103)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dig Dog (NTSC) (No Harp) (Hack) (20130103).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dig Dog (NTSC) (No Harp) (Hack) (20130103).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dig Dog (NTSC) (No Harp) (Hack) (20130103).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dig Dog (NTSC) (No Harp) (Hack) (20130103).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Dig Dog (PAL) (Harp) (Hack) (20130103)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dig Dog (PAL) (Harp) (Hack) (20130103).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dig Dog (PAL) (Harp) (Hack) (20130103).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dig Dog (PAL) (Harp) (Hack) (20130103).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dig Dog (PAL) (Harp) (Hack) (20130103).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Dig Dog (PAL) (No Harp) (Hack) (20130103)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dig Dog (PAL) (No Harp) (Hack) (20130103).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dig Dog (PAL) (No Harp) (Hack) (20130103).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dig Dog (PAL) (No Harp) (Hack) (20130103).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dig Dog (PAL) (No Harp) (Hack) (20130103).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Donkey Kong (NES Title Music)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong (NES Title Music).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong (NES Title Music).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey Kong (NES Title Music).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey Kong (NES Title Music).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Donkey Kong Jr (Graphics Hack) (20140927)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong Jr (Graphics Hack) (20140927).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong Jr (Graphics Hack) (20140927).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey Kong Jr (Graphics Hack) (20140927).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey Kong Jr (Graphics Hack) (20140927).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Double Dragon (AB) (Graphics Hack) (RC7b) (20170616)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (AB) (Graphics Hack) (RC7b) (20170616).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (AB) (Graphics Hack) (RC7b) (20170616).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double Dragon (AB) (Graphics Hack) (RC7b) (20170616).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double Dragon (AB) (Graphics Hack) (RC7b) (20170616).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Double Dragon (Sprite Test 2) (Hack) (20140922)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (Sprite Test 2) (Hack) (20140922).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (Sprite Test 2) (Hack) (20140922).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double Dragon (Sprite Test 2) (Hack) (20140922).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double Dragon (Sprite Test 2) (Hack) (20140922).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Dual Pac-Man (Hack) (20050902)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dual Pac-Man (Hack) (20050902).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dual Pac-Man (Hack) (20050902).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dual Pac-Man (Hack) (20050902).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dual Pac-Man (Hack) (20050902).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "FASTeroids (NTSC) (Hack) (20131202)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\FASTeroids (NTSC) (Hack) (20131202).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\FASTeroids (NTSC) (Hack) (20131202).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\FASTeroids (NTSC) (Hack) (20131202).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\FASTeroids (NTSC) (Hack) (20131202).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Fatal Run (Graphics Hack) (RC1) (20140927)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fatal Run (Graphics Hack) (RC1) (20140927).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fatal Run (Graphics Hack) (RC1) (20140927).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fatal Run (Graphics Hack) (RC1) (20140927).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fatal Run (Graphics Hack) (RC1) (20140927).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Field Hockey (Hack) (20140122)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Field Hockey (Hack) (20140122).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Field Hockey (Hack) (20140122).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Field Hockey (Hack) (20140122).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Field Hockey (Hack) (20140122).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Field Hockey (Hack) (20140122)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Field Hockey (Hack) (20140122).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Field Hockey (Hack) (20140122).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Field Hockey (Hack) (20140122).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Field Hockey (Hack) (20140122).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Food Fight X (NTSC) (Hack) (20160724)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Food Fight X (NTSC) (Hack) (20160724).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Food Fight X (NTSC) (Hack) (20160724).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Food Fight X (NTSC) (Hack) (20160724).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Food Fight X (NTSC) (Hack) (20160724).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Food Fight X (PAL) (Hack) (20130318)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Food Fight X (PAL) (Hack) (20130318).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Food Fight X (PAL) (Hack) (20130318).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Food Fight X (PAL) (Hack) (20130318).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Food Fight X (PAL) (Hack) (20130318).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Fuzzipede (NTSC) (Hack) (20150919).a78" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fuzzipede (NTSC) (Hack) (20150919).a78.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fuzzipede (NTSC) (Hack) (20150919).a78.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fuzzipede (NTSC) (Hack) (20150919).a78.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fuzzipede (NTSC) (Hack) (20150919).a78.htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Galaga (Graphics Hack) (20130320)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga (Graphics Hack) (20130320).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga (Graphics Hack) (20130320).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga (Graphics Hack) (20130320).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga (Graphics Hack) (20130320).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Galaga Dual Hero (Type 1 Hack)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga Dual Hero (Type 1 Hack).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga Dual Hero (Type 1 Hack).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga Dual Hero (Type 1 Hack).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga Dual Hero (Type 1 Hack).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Galaga Dual Hero (Type 2 Hack)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga Dual Hero (Type 2 Hack).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga Dual Hero (Type 2 Hack).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga Dual Hero (Type 2 Hack).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga Dual Hero (Type 2 Hack).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Galaga-14 (NTSC) (Hack) (20130121)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga-14 (NTSC) (Hack) (20130121).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga-14 (NTSC) (Hack) (20130121).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga-14 (NTSC) (Hack) (20130121).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga-14 (NTSC) (Hack) (20130121).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Galaga-14 (PAL) (Hack) (20130121)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga-14 (PAL) (Hack) (20130121).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga-14 (PAL) (Hack) (20130121).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga-14 (PAL) (Hack) (20130121).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga-14 (PAL) (Hack) (20130121).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Galaxians (Hack) (20181207)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxians (Hack) (20181207).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxians (Hack) (20181207).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxians (Hack) (20181207).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxians (Hack) (20181207).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Game Maker Pac-Man (Hack) (20150809)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Game Maker Pac-Man (Hack) (20150809).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Game Maker Pac-Man (Hack) (20150809).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Game Maker Pac-Man (Hack) (20150809).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Game Maker Pac-Man (Hack) (20150809).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ghosts Revenge (Hack) (20130501)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ghosts Revenge (Hack) (20130501).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ghosts Revenge (Hack) (20130501).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ghosts Revenge (Hack) (20130501).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ghosts Revenge (Hack) (20130501).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Gobbler (Hack) (20130501)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Gobbler (Hack) (20130501).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Gobbler (Hack) (20130501).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Gobbler (Hack) (20130501).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Gobbler (Hack) (20130501).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Griffey The Dog (Fast) (Hack) (20100924)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Griffey The Dog (Fast) (Hack) (20100924).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Griffey The Dog (Fast) (Hack) (20100924).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Griffey The Dog (Fast) (Hack) (20100924).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Griffey The Dog (Fast) (Hack) (20100924).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Griffey The Dog (Hack) (20100924)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Griffey The Dog (Hack) (20100924).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Griffey The Dog (Hack) (20100924).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Griffey The Dog (Hack) (20100924).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Griffey The Dog (Hack) (20100924).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Griffey The Dog (Halloween Edition) (Hack) (20101104)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Griffey The Dog (Halloween Edition) (Hack) (20101104).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Griffey The Dog (Halloween Edition) (Hack) (20101104).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Griffey The Dog (Halloween Edition) (Hack) (20101104).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Griffey The Dog (Halloween Edition) (Hack) (20101104).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Handyman (Hack) (20181115)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Handyman (Hack) (20181115).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Handyman (Hack) (20181115).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Handyman (Hack) (20181115).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Handyman (Hack) (20181115).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Handyman (Invincible) (Hack) (20181115)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Handyman (Invincible) (Hack) (20181115).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Handyman (Invincible) (Hack) (20181115).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Handyman (Invincible) (Hack) (20181115).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Handyman (Invincible) (Hack) (20181115).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Hangly-Man (Hack) (20050531)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hangly-Man (Hack) (20050531).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hangly-Man (Hack) (20050531).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hangly-Man (Hack) (20050531).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hangly-Man (Hack) (20050531).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Hockey (Hack) (20140122)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hockey (Hack) (20140122).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hockey (Hack) (20140122).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hockey (Hack) (20140122).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hockey (Hack) (20140122).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Humantron 2084 (NTSC) (Hack) (20130425)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Humantron 2084 (NTSC) (Hack) (20130425).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Humantron 2084 (NTSC) (Hack) (20130425).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Humantron 2084 (NTSC) (Hack) (20130425).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Humantron 2084 (NTSC) (Hack) (20130425).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "i_Cat (NTSC) (Harp) (Hack) (20130124)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\i_Cat (NTSC) (Harp) (Hack) (20130124).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\i_Cat (NTSC) (Harp) (Hack) (20130124).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\i_Cat (NTSC) (Harp) (Hack) (20130124).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\i_Cat (NTSC) (Harp) (Hack) (20130124).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "i_Cat (NTSC) (No Harp) (Hack) (20130124)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\i_Cat (NTSC) (No Harp) (Hack) (20130124).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\i_Cat (NTSC) (No Harp) (Hack) (20130124).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\i_Cat (NTSC) (No Harp) (Hack) (20130124).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\i_Cat (NTSC) (No Harp) (Hack) (20130124).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "i_Cat (PAL) (Harp) (Hack) (20130124)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\i_Cat (PAL) (Harp) (Hack) (20130124).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\i_Cat (PAL) (Harp) (Hack) (20130124).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\i_Cat (PAL) (Harp) (Hack) (20130124).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\i_Cat (PAL) (Harp) (Hack) (20130124).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "i_Cat (PAL) (No Harp) (Hack) (20130124)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\i_Cat (PAL) (No Harp) (Hack) (20130124).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\i_Cat (PAL) (No Harp) (Hack) (20130124).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\i_Cat (PAL) (No Harp) (Hack) (20130124).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\i_Cat (PAL) (No Harp) (Hack) (20130124).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Impossible Mission (Blue Graphics Hack) (20160905)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (Blue Graphics Hack) (20160905).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (Blue Graphics Hack) (20160905).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible Mission (Blue Graphics Hack) (20160905).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible Mission (Blue Graphics Hack) (20160905).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Impossible Mission (C64 Graphics Hack) (20160905)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (C64 Graphics Hack) (20160905).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (C64 Graphics Hack) (20160905).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible Mission (C64 Graphics Hack) (20160905).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible Mission (C64 Graphics Hack) (20160905).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Impossible Mission (Green Graphics Hack) (20160905)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (Green Graphics Hack) (20160905).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (Green Graphics Hack) (20160905).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible Mission (Green Graphics Hack) (20160905).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible Mission (Green Graphics Hack) (20160905).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Impossible Mission (New Graphics - C64 Hack) (20190529)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (New Graphics - C64 Hack) (20190529).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (New Graphics - C64 Hack) (20190529).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible Mission (New Graphics - C64 Hack) (20190529).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible Mission (New Graphics - C64 Hack) (20190529).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Impossible Mission (Red Graphics Hack) (20160905)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (Red Graphics Hack) (20160905).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (Red Graphics Hack) (20160905).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible Mission (Red Graphics Hack) (20160905).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible Mission (Red Graphics Hack) (20160905).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Inky (Hack) (20150530)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Inky (Hack) (20150530).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Inky (Hack) (20150530).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Inky (Hack) (20150530).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Inky (Hack) (20150530).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Invader of Space (Hack) (20190128)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Invader of Space (Hack) (20190128).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Invader of Space (Hack) (20190128).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Invader of Space (Hack) (20190128).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Invader of Space (Hack) (20190128).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Invincivaders (NTSC) (Hack) (20121231)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Invincivaders (NTSC) (Hack) (20121231).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Invincivaders (NTSC) (Hack) (20121231).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Invincivaders (NTSC) (Hack) (20121231).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Invincivaders (NTSC) (Hack) (20121231).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Invincivaders (PAL) (Hack) (20121231)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Invincivaders (PAL) (Hack) (20121231).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Invincivaders (PAL) (Hack) (20121231).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Invincivaders (PAL) (Hack) (20121231).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Invincivaders (PAL) (Hack) (20121231).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Invisible Maze Pac-Man (Hack) (20170407)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Invisible Maze Pac-Man (Hack) (20170407).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Invisible Maze Pac-Man (Hack) (20170407).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Invisible Maze Pac-Man (Hack) (20170407).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Invisible Maze Pac-Man (Hack) (20170407).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Invisible Pac-Man (Graphics Hack) (20110509)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Invisible Pac-Man (Graphics Hack) (20110509).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Invisible Pac-Man (Graphics Hack) (20110509).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Invisible Pac-Man (Graphics Hack) (20110509).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Invisible Pac-Man (Graphics Hack) (20110509).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Java Ms Pac-Man (Hack) (20130420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Java Ms Pac-Man (Hack) (20130420).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Java Ms Pac-Man (Hack) (20130420).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Java Ms Pac-Man (Hack) (20130420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Java Ms Pac-Man (Hack) (20130420).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Jawbreaker (Hack) (20120426)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jawbreaker (Hack) (20120426).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jawbreaker (Hack) (20120426).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jawbreaker (Hack) (20120426).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jawbreaker (Hack) (20120426).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Joust (Broke Hack 2) (20180920)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (Broke Hack 2) (20180920).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (Broke Hack 2) (20180920).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust (Broke Hack 2) (20180920).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust (Broke Hack 2) (20180920).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Joust (Broken Hack) (20180811)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (Broken Hack) (20180811).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (Broken Hack) (20180811).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust (Broken Hack) (20180811).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust (Broken Hack) (20180811).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Joust (Deviled Egg Hack - Joustween) (20181031)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (Deviled Egg Hack - Joustween) (20181031).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (Deviled Egg Hack - Joustween) (20181031).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust (Deviled Egg Hack - Joustween) (20181031).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust (Deviled Egg Hack - Joustween) (20181031).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Joust (Eggs Easy Over Hack) (20181029)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (Eggs Easy Over Hack) (20181029).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (Eggs Easy Over Hack) (20181029).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust (Eggs Easy Over Hack) (20181029).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust (Eggs Easy Over Hack) (20181029).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Joust (GT-R Hack) (20190924)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (GT-R Hack) (20190924).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (GT-R Hack) (20190924).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust (GT-R Hack) (20190924).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust (GT-R Hack) (20190924).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Joust (Lava Hack) (20181219)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (Lava Hack) (20181219).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (Lava Hack) (20181219).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust (Lava Hack) (20181219).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust (Lava Hack) (20181219).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Joust X (NTSC) (Hack) (20130320)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust X (NTSC) (Hack) (20130320).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust X (NTSC) (Hack) (20130320).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust X (NTSC) (Hack) (20130320).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust X (NTSC) (Hack) (20130320).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Joust X (PAL) (Hack) (20130320)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust X (PAL) (Hack) (20130320).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust X (PAL) (Hack) (20130320).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust X (PAL) (Hack) (20130320).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust X (PAL) (Hack) (20130320).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Joyman (Hack) (20150807)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joyman (Hack) (20150807).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joyman (Hack) (20150807).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joyman (Hack) (20150807).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joyman (Hack) (20150807).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Jr Ms Pac (Hack) (20090705)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr Ms Pac (Hack) (20090705).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr Ms Pac (Hack) (20090705).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jr Ms Pac (Hack) (20090705).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jr Ms Pac (Hack) (20090705).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Jr Ms Pac-Man (Inv_Fast) (NTSC) (Hack) (20130128)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr Ms Pac-Man (Inv_Fast) (NTSC) (Hack) (20130128).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr Ms Pac-Man (Inv_Fast) (NTSC) (Hack) (20130128).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jr Ms Pac-Man (Inv_Fast) (NTSC) (Hack) (20130128).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jr Ms Pac-Man (Inv_Fast) (NTSC) (Hack) (20130128).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Jr Pac 2 (Hack) (20120325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr Pac 2 (Hack) (20120325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr Pac 2 (Hack) (20120325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jr Pac 2 (Hack) (20120325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jr Pac 2 (Hack) (20120325).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Jr Pac-Man (St Pats Hack) (20100317)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr Pac-Man (St Pats Hack) (20100317).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr Pac-Man (St Pats Hack) (20100317).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jr Pac-Man (St Pats Hack) (20100317).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jr Pac-Man (St Pats Hack) (20100317).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Jr Pac-Man C64 (Hack) (20170407)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr Pac-Man C64 (Hack) (20170407).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr Pac-Man C64 (Hack) (20170407).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jr Pac-Man C64 (Hack) (20170407).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jr Pac-Man C64 (Hack) (20170407).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Kessel Attack (Hack) (20080904)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kessel Attack (Hack) (20080904).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kessel Attack (Hack) (20080904).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kessel Attack (Hack) (20080904).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kessel Attack (Hack) (20080904).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Kung-Fu Master (Graphics Hack) (RC2) (20160905)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master (Graphics Hack) (RC2) (20160905).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master (Graphics Hack) (RC2) (20160905).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master (Graphics Hack) (RC2) (20160905).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master (Graphics Hack) (RC2) (20160905).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Le Siti (NTSC) (Hack) (20150919)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Le Siti (NTSC) (Hack) (20150919).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Le Siti (NTSC) (Hack) (20150919).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Le Siti (NTSC) (Hack) (20150919).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Le Siti (NTSC) (Hack) (20150919).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Le Siti (PAL) (Hack) (20150919)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Le Siti (PAL) (Hack) (20150919).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Le Siti (PAL) (Hack) (20150919).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Le Siti (PAL) (Hack) (20150919).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Le Siti (PAL) (Hack) (20150919).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Mario Bros (Mario Right Hack) (v11)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros (Mario Right Hack) (v11).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros (Mario Right Hack) (v11).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros (Mario Right Hack) (v11).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros (Mario Right Hack) (v11).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Mario Bros (Sprite Hack v4) (20160306)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros (Sprite Hack v4) (20160306).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros (Sprite Hack v4) (20160306).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros (Sprite Hack v4) (20160306).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros (Sprite Hack v4) (20160306).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Mario Bros 98 (NTSC) (Hack) (20131217)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros 98 (NTSC) (Hack) (20131217).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros 98 (NTSC) (Hack) (20131217).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros 98 (NTSC) (Hack) (20131217).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros 98 (NTSC) (Hack) (20131217).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Mario Bros 256 (NTSC) (Hack) (20131217)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros 256 (NTSC) (Hack) (20131217).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros 256 (NTSC) (Hack) (20131217).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros 256 (NTSC) (Hack) (20131217).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros 256 (NTSC) (Hack) (20131217).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Mastersoft Munch (Hack) (20130420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mastersoft Munch (Hack) (20130420).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mastersoft Munch (Hack) (20130420).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mastersoft Munch (Hack) (20130420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mastersoft Munch (Hack) (20130420).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Meteor Bath (RC2) (NTSC) (Hack) (20131213)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meteor Bath (RC2) (NTSC) (Hack) (20131213).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meteor Bath (RC2) (NTSC) (Hack) (20131213).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meteor Bath (RC2) (NTSC) (Hack) (20131213).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meteor Bath (RC2) (NTSC) (Hack) (20131213).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Midnight Mutants (Colorburst Signal Fix) (Hack) (NTSC) (20210607)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Midnight Mutants (Colorburst Signal Fix) (Hack) (NTSC) (20210607).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Midnight Mutants (Colorburst Signal Fix) (Hack) (NTSC) (20210607).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Midnight Mutants (Colorburst Signal Fix) (Hack) (NTSC) (20210607).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Midnight Mutants (Colorburst Signal Fix) (Hack) (NTSC) (20210607).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Millipede (NTSC) (Hack) (20150405)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Millipede (NTSC) (Hack) (20150405).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Millipede (NTSC) (Hack) (20150405).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Millipede (NTSC) (Hack) (20150405).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Millipede (NTSC) (Hack) (20150405).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Millipede (TBall) (NTSC) (Hack) (20150405)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Millipede (TBall) (NTSC) (Hack) (20150405).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Millipede (TBall) (NTSC) (Hack) (20150405).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Millipede (TBall) (NTSC) (Hack) (20150405).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Millipede (TBall) (NTSC) (Hack) (20150405).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Minipede (NTSC) (Hack) (20150808)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Minipede (NTSC) (Hack) (20150808).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Minipede (NTSC) (Hack) (20150808).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Minipede (NTSC) (Hack) (20150808).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Minipede (NTSC) (Hack) (20150808).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Minipede (PAL) (Hack) (20150808)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Minipede (PAL) (Hack) (20150808).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Minipede (PAL) (Hack) (20150808).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Minipede (PAL) (Hack) (20150808).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Minipede (PAL) (Hack) (20150808).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Minipede (TBall) (Hack) (20150808)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Minipede (TBall) (Hack) (20150808).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Minipede (TBall) (Hack) (20150808).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Minipede (TBall) (Hack) (20150808).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Minipede (TBall) (Hack) (20150808).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Moon Crest B (NTSC) (Hack) (20131125)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Moon Crest B (NTSC) (Hack) (20131125).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Moon Crest B (NTSC) (Hack) (20131125).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Moon Crest B (NTSC) (Hack) (20131125).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Moon Crest B (NTSC) (Hack) (20131125).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Moon Crest B (PAL) (Hack) (20131125)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Moon Crest B (PAL) (Hack) (20131125).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Moon Crest B (PAL) (Hack) (20131125).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Moon Crest B (PAL) (Hack) (20131125).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Moon Crest B (PAL) (Hack) (20131125).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "More Beef Drop (Hack) (20060901)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\More Beef Drop (Hack) (20060901).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\More Beef Drop (Hack) (20060901).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\More Beef Drop (Hack) (20060901).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\More Beef Drop (Hack) (20060901).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Mr Pac NES (Hack) (20130427)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mr Pac NES (Hack) (20130427).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mr Pac NES (Hack) (20130427).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mr Pac NES (Hack) (20130427).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mr Pac NES (Hack) (20130427).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Fruit-Man (Hack) (20130422)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Fruit-Man (Hack) (20130422).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Fruit-Man (Hack) (20130422).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Fruit-Man (Hack) (20130422).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Fruit-Man (Hack) (20130422).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Attack (Hack) (20050531)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Attack (Hack) (20050531).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Attack (Hack) (20050531).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Attack (Hack) (20050531).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Attack (Hack) (20050531).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (Fast Hack) (20060304)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (Fast Hack) (20060304).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (Fast Hack) (20060304).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (Fast Hack) (20060304).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (Fast Hack) (20060304).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (Ferrell's Hack) (20170407)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (Ferrell's Hack) (20170407).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (Ferrell's Hack) (20170407).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (Ferrell's Hack) (20170407).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (Ferrell's Hack) (20170407).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (Graphics Hack) (20150220)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (Graphics Hack) (20150220).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (Graphics Hack) (20150220).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (Graphics Hack) (20150220).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (Graphics Hack) (20150220).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (Intellivision Hack) (20210110)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (Intellivision Hack) (20210110).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (Intellivision Hack) (20210110).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (Intellivision Hack) (20210110).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (Intellivision Hack) (20210110).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (Inv) (NTSC) (Hack) (20130128)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (Inv) (NTSC) (Hack) (20130128).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (Inv) (NTSC) (Hack) (20130128).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (Inv) (NTSC) (Hack) (20130128).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (Inv) (NTSC) (Hack) (20130128).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (Inv) (PAL) (Hack) (20130128)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (Inv) (PAL) (Hack) (20130128).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (Inv) (PAL) (Hack) (20130128).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (Inv) (PAL) (Hack) (20130128).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (Inv) (PAL) (Hack) (20130128).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (Inv_Fast) (NTSC) (Hack) (20130128)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (Inv_Fast) (NTSC) (Hack) (20130128).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (Inv_Fast) (NTSC) (Hack) (20130128).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (Inv_Fast) (NTSC) (Hack) (20130128).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (Inv_Fast) (NTSC) (Hack) (20130128).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (Inv_Fast) (PAL) (Hack) (20130128)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (Inv_Fast) (PAL) (Hack) (20130128).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (Inv_Fast) (PAL) (Hack) (20130128).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (Inv_Fast) (PAL) (Hack) (20130128).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (Inv_Fast) (PAL) (Hack) (20130128).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (Pac-Man Maze) (Hack) (20170407)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (Pac-Man Maze) (Hack) (20170407).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (Pac-Man Maze) (Hack) (20170407).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (Pac-Man Maze) (Hack) (20170407).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (Pac-Man Maze) (Hack) (20170407).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (PacManPlus' Hack) (20090501)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (PacManPlus' Hack) (20090501).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (PacManPlus' Hack) (20090501).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (PacManPlus' Hack) (20090501).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (PacManPlus' Hack) (20090501).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (Purple Ghost Hack) (20131226)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (Purple Ghost Hack) (20131226).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (Purple Ghost Hack) (20131226).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (Purple Ghost Hack) (20131226).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (Purple Ghost Hack) (20131226).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man (St Pats Hack) (20100317)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (St Pats Hack) (20100317).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (St Pats Hack) (20100317).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (St Pats Hack) (20100317).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (St Pats Hack) (20100317).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man 320 (Inv_Fast) (NTSC) (Hack) (20130128)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man 320 (Inv_Fast) (NTSC) (Hack) (20130128).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man 320 (Inv_Fast) (NTSC) (Hack) (20130128).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man 320 (Inv_Fast) (NTSC) (Hack) (20130128).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man 320 (Inv_Fast) (NTSC) (Hack) (20130128).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man 320 (Invincible) (NTSC) (Hack) (20130128)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man 320 (Invincible) (NTSC) (Hack) (20130128).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man 320 (Invincible) (NTSC) (Hack) (20130128).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man 320 (Invincible) (NTSC) (Hack) (20130128).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man 320 (Invincible) (NTSC) (Hack) (20130128).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man After Dark (v4) (Hack) (20150904)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man After Dark (v4) (Hack) (20150904).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man After Dark (v4) (Hack) (20150904).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man After Dark (v4) (Hack) (20150904).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man After Dark (v4) (Hack) (20150904).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man After Dark Xtreme (Hack) (20150906)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man After Dark Xtreme (Hack) (20150906).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man After Dark Xtreme (Hack) (20150906).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man After Dark Xtreme (Hack) (20150906).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man After Dark Xtreme (Hack) (20150906).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man Mini Mazes (Hack) (20120325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man Mini Mazes (Hack) (20120325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man Mini Mazes (Hack) (20120325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man Mini Mazes (Hack) (20120325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man Mini Mazes (Hack) (20120325).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man VCS (Hack) (20150901)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man VCS (Hack) (20150901).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man VCS (Hack) (20150901).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man VCS (Hack) (20150901).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man VCS (Hack) (20150901).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man Vector (Small dots) (Hack) (20150905)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man Vector (Small dots) (Hack) (20150905).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man Vector (Small dots) (Hack) (20150905).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man Vector (Small dots) (Hack) (20150905).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man Vector (Small dots) (Hack) (20150905).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ms Pac-Man Vector (Standard dots) (Hack) (20150905)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man Vector (Standard dots) (Hack) (20150905).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man Vector (Standard dots) (Hack) (20150905).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man Vector (Standard dots) (Hack) (20150905).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man Vector (Standard dots) (Hack) (20150905).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Munch Man 64 (Hack) (20160206)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Munch Man 64 (Hack) (20160206).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Munch Man 64 (Hack) (20160206).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Munch Man 64 (Hack) (20160206).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Munch Man 64 (Hack) (20160206).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Munchkin (Hack) (20130629)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Munchkin (Hack) (20130629).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Munchkin (Hack) (20130629).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Munchkin (Hack) (20130629).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Munchkin (Hack) (20130629).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Munchman Texas (Hack) (20130507)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Munchman Texas (Hack) (20130507).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Munchman Texas (Hack) (20130507).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Munchman Texas (Hack) (20130507).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Munchman Texas (Hack) (20130507).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Munchman Texas (Multi-level) (Hack) (20130507)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Munchman Texas (Multi-level) (Hack) (20130507).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Munchman Texas (Multi-level) (Hack) (20130507).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Munchman Texas (Multi-level) (Hack) (20130507).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Munchman Texas (Multi-level) (Hack) (20130507).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Num-Munch (Hack) (20181213)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Num-Munch (Hack) (20181213).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Num-Munch (Hack) (20181213).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Num-Munch (Hack) (20181213).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Num-Munch (Hack) (20181213).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Num-Munch (Invincible) (Hack) (20181213)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Num-Munch (Invincible) (Hack) (20181213).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Num-Munch (Invincible) (Hack) (20181213).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Num-Munch (Invincible) (Hack) (20181213).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Num-Munch (Invincible) (Hack) (20181213).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "One-on-One Basketball - Title Fix Hack (NTSC) (20201229)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\One-on-One Basketball - Title Fix Hack (NTSC) (20201229).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\One-on-One Basketball - Title Fix Hack (NTSC) (20201229).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\One-on-One Basketball - Title Fix Hack (NTSC) (20201229).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\One-on-One Basketball - Title Fix Hack (NTSC) (20201229).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac Jason (Hack) (20121101)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac Jason (Hack) (20121101).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac Jason (Hack) (20121101).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac Jason (Hack) (20121101).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac Jason (Hack) (20121101).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac Jr (De Lucia's Hack) (20130422)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac Jr (De Lucia's Hack) (20130422).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac Jr (De Lucia's Hack) (20130422).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac Jr (De Lucia's Hack) (20130422).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac Jr (De Lucia's Hack) (20130422).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac Nestor (Hack) (20060920)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac Nestor (Hack) (20060920).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac Nestor (Hack) (20060920).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac Nestor (Hack) (20060920).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac Nestor (Hack) (20060920).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pacaroids (NTSC) (Hack) (20140208)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pacaroids (NTSC) (Hack) (20140208).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pacaroids (NTSC) (Hack) (20140208).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pacaroids (NTSC) (Hack) (20140208).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pacaroids (NTSC) (Hack) (20140208).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pacaroids (PAL) (Hack) (20140208)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pacaroids (PAL) (Hack) (20140208).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pacaroids (PAL) (Hack) (20140208).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pacaroids (PAL) (Hack) (20140208).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pacaroids (PAL) (Hack) (20140208).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Boy (Hack) (20130625)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Boy (Hack) (20130625).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Boy (Hack) (20130625).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Boy (Hack) (20130625).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Boy (Hack) (20130625).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "PacIIINES (Hack) (20130502)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\PacIIINES (Hack) (20130502).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\PacIIINES (Hack) (20130502).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\PacIIINES (Hack) (20130502).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\PacIIINES (Hack) (20130502).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Jr (Ferrell's Hack) (20170407)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Jr (Ferrell's Hack) (20170407).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Jr (Ferrell's Hack) (20170407).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Jr (Ferrell's Hack) (20170407).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Jr (Ferrell's Hack) (20170407).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pacland (Gambler172) (Hack) (20200416)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pacland (Gambler172) (Hack) (20200416).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pacland (Gambler172) (Hack) (20200416).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pacland (Gambler172) (Hack) (20200416).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pacland (Gambler172) (Hack) (20200416).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pacland (JRH) (Hack) (20200331)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pacland (JRH) (Hack) (20200331).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pacland (JRH) (Hack) (20200331).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pacland (JRH) (Hack) (20200331).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pacland (JRH) (Hack) (20200331).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Maine (Hack) (20130420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Maine (Hack) (20130420).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Maine (Hack) (20130420).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Maine (Hack) (20130420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Maine (Hack) (20130420).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man (Atari 2600 Homage Hack) (20100812)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man (Atari 2600 Homage Hack) (20100812).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man (Atari 2600 Homage Hack) (20100812).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man (Atari 2600 Homage Hack) (20100812).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man (Atari 2600 Homage Hack) (20100812).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man (Fast Hack) (20060526)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man (Fast Hack) (20060526).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man (Fast Hack) (20060526).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man (Fast Hack) (20060526).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man (Fast Hack) (20060526).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man (Ferrell's Hack) (20170407)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man (Ferrell's Hack) (20170407).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man (Ferrell's Hack) (20170407).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man (Ferrell's Hack) (20170407).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man (Ferrell's Hack) (20170407).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man (Intellivision Maze) (De Lucia's Hack) (20130422)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man (Intellivision Maze) (De Lucia's Hack) (20130422).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man (Intellivision Maze) (De Lucia's Hack) (20130422).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man (Intellivision Maze) (De Lucia's Hack) (20130422).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man (Intellivision Maze) (De Lucia's Hack) (20130422).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man (Intellivision Maze) (Ferrell's Hack) (20120406)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man (Intellivision Maze) (Ferrell's Hack) (20120406).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man (Intellivision Maze) (Ferrell's Hack) (20120406).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man (Intellivision Maze) (Ferrell's Hack) (20120406).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man (Intellivision Maze) (Ferrell's Hack) (20120406).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man (PacManPlus' Hack) (20050530)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man (PacManPlus' Hack) (20050530).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man (PacManPlus' Hack) (20050530).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man (PacManPlus' Hack) (20050530).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man (PacManPlus' Hack) (20050530).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man (St Pats Hack) (20100317)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man (St Pats Hack) (20100317).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man (St Pats Hack) (20100317).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man (St Pats Hack) (20100317).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man (St Pats Hack) (20100317).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man (Vic-20 Maze) (Hack) (20130422)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man (Vic-20 Maze) (Hack) (20130422).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man (Vic-20 Maze) (Hack) (20130422).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man (Vic-20 Maze) (Hack) (20130422).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man (Vic-20 Maze) (Hack) (20130422).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man 26 (Hack) (20180217)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man 26 (Hack) (20180217).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man 26 (Hack) (20180217).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man 26 (Hack) (20180217).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man 26 (Hack) (20180217).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Arrangement (Hack) (20170326)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Arrangement (Hack) (20170326).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Arrangement (Hack) (20170326).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Arrangement (Hack) (20170326).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Arrangement (Hack) (20170326).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Christmas 2018 (Hack)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Christmas 2018 (Hack).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Christmas 2018 (Hack).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\.htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Christmas 2018 (Invincible) (Hack)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Christmas 2018 (Invincible) (Hack).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Christmas 2018 (Invincible) (Hack).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Christmas 2018 (Invincible) (Hack).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Christmas 2018 (Invincible) (Hack).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Collection (Encore Hack) (20200716)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (Encore Hack) (20200716).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (Encore Hack) (20200716).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Collection (Encore Hack) (20200716).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Collection (Encore Hack) (20200716).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Collection (Encore Hack) (Alt) (20200716)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (Encore Hack) (Alt) (20200716).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (Encore Hack) (Alt) (20200716).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Collection (Encore Hack) (Alt) (20200716).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Collection (Encore Hack) (Alt) (20200716).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Collection 2 (Hack) (20120411)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection 2 (Hack) (20120411).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection 2 (Hack) (20120411).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Collection 2 (Hack) (20120411).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Collection 2 (Hack) (20120411).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Collection Remake (Hack) (20091223)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection Remake (Hack) (20091223).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection Remake (Hack) (20091223).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Collection Remake (Hack) (20091223).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Collection Remake (Hack) (20091223).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Collector's Edition (Hack) (20200603)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collector's Edition (Hack) (20200603).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collector's Edition (Hack) (20200603).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Collector's Edition (Hack) (20200603).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Collector's Edition (Hack) (20200603).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man G (Hack) (20130427)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man G (Hack) (20130427).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man G (Hack) (20130427).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man G (Hack) (20130427).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man G (Hack) (20130427).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man G2 (Hack) (20130427)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man G2 (Hack) (20130427).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man G2 (Hack) (20130427).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man G2 (Hack) (20130427).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man G2 (Hack) (20130427).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Handheld (Hack) (20130420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Handheld (Hack) (20130420).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Handheld (Hack) (20130420).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Handheld (Hack) (20130420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Handheld (Hack) (20130420).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man III (Hack) (20170404)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man III (Hack) (20170404).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man III (Hack) (20170404).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man III (Hack) (20170404).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man III (Hack) (20170404).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Pirahna (Inv) (NTSC) (Hack) (20130128)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Pirahna (Inv) (NTSC) (Hack) (20130128).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Pirahna (Inv) (NTSC) (Hack) (20130128).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Pirahna (Inv) (NTSC) (Hack) (20130128).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Pirahna (Inv) (NTSC) (Hack) (20130128).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Plus (Ferrell's Hack) (20170405)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Plus (Ferrell's Hack) (20170405).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Plus (Ferrell's Hack) (20170405).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Plus (Ferrell's Hack) (20170405).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Plus (Ferrell's Hack) (20170405).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Plus (PacManPlus' Hack) (20050602)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Plus (PacManPlus' Hack) (20050602).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Plus (PacManPlus' Hack) (20050602).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Plus (PacManPlus' Hack) (20050602).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Plus (PacManPlus' Hack) (20050602).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Re-Arrangement (Hack) (20181204)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Re-Arrangement (Hack) (20181204).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Re-Arrangement (Hack) (20181204).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Re-Arrangement (Hack) (20181204).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Re-Arrangement (Hack) (20181204).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Re-Arrangement (Invincible) (Hack) (20181204)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Re-Arrangement (Invincible) (Hack) (20181204).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Re-Arrangement (Invincible) (Hack) (20181204).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Re-Arrangement (Invincible) (Hack) (20181204).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Re-Arrangement (Invincible) (Hack) (20181204).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Remix (Hack) (20120419)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Remix (Hack) (20120419).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Remix (Hack) (20120419).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Remix (Hack) (20120419).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Remix (Hack) (20120419).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Vs (De Lucia Hack) (20130430)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Vs (De Lucia Hack) (20130430).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Vs (De Lucia Hack) (20130430).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Vs (De Lucia Hack) (20130430).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Vs (De Lucia Hack) (20130430).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man VS (Ferrell's Hack) (20170730)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man VS (Ferrell's Hack) (20170730).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man VS (Ferrell's Hack) (20170730).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man VS (Ferrell's Hack) (20170730).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man VS (Ferrell's Hack) (20170730).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Man Wide (Hack) (20130625)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Wide (Hack) (20130625).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Wide (Hack) (20130625).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man Wide (Hack) (20130625).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man Wide (Hack) (20130625).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Munch Jr (Blue Azure's Hack) (20181210)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Munch Jr (Blue Azure's Hack) (20181210).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Munch Jr (Blue Azure's Hack) (20181210).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Munch Jr (Blue Azure's Hack) (20181210).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Munch Jr (Blue Azure's Hack) (20181210).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Munch Jr (Ferrell's Hack) (20180704)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Munch Jr (Ferrell's Hack) (20180704).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Munch Jr (Ferrell's Hack) (20180704).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Munch Jr (Ferrell's Hack) (20180704).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Munch Jr (Ferrell's Hack) (20180704).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Munch Jr (Inv) (Blue Azure's Hack) (20181210)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Munch Jr (Inv) (Blue Azure's Hack) (20181210).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Munch Jr (Inv) (Blue Azure's Hack) (20181210).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Munch Jr (Inv) (Blue Azure's Hack) (20181210).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Munch Jr (Inv) (Blue Azure's Hack) (20181210).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Prototype (Hack) (20130408)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Prototype (Hack) (20130408).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Prototype (Hack) (20130408).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Prototype (Hack) (20130408).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Prototype (Hack) (20130408).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pactron 1984 (Hack) (20150124)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pactron 1984 (Hack) (20150124).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pactron 1984 (Hack) (20150124).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pactron 1984 (Hack) (20150124).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pactron 1984 (Hack) (20150124).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pactron 1984 Extreme (Hack) (20150124)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pactron 1984 Extreme (Hack) (20150124).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pactron 1984 Extreme (Hack) (20150124).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pactron 1984 Extreme (Hack) (20150124).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pactron 1984 Extreme (Hack) (20150124).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pac-Who (Hack) (20130501)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Who (Hack) (20130501).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Who (Hack) (20130501).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Who (Hack) (20130501).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Who (Hack) (20130501).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Papa Smurf in Pacland (Hack) (20090830)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Papa Smurf in Pacland (Hack) (20090830).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Papa Smurf in Pacland (Hack) (20090830).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Papa Smurf in Pacland (Hack) (20090830).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Papa Smurf in Pacland (Hack) (20090830).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Papa Smurf in Pacland II (Hack) (20090915)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Papa Smurf in Pacland II (Hack) (20090915).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Papa Smurf in Pacland II (Hack) (20090915).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Papa Smurf in Pacland II (Hack) (20090915).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Papa Smurf in Pacland II (Hack) (20090915).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "PC-Man (Hack) (20130420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\PC-Man (Hack) (20130420).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\PC-Man (Hack) (20130420).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\PC-Man (Hack) (20130420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\PC-Man (Hack) (20130420).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pedes2Go (Inv) (NTSC) (Hack) (20151101)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pedes2Go (Inv) (NTSC) (Hack) (20151101).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pedes2Go (Inv) (NTSC) (Hack) (20151101).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pedes2Go (Inv) (NTSC) (Hack) (20151101).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pedes2Go (Inv) (NTSC) (Hack) (20151101).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pedes2Go (Inv) (PAL) (Hack) (20151101)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pedes2Go (Inv) (PAL) (Hack) (20151101).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pedes2Go (Inv) (PAL) (Hack) (20151101).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pedes2Go (Inv) (PAL) (Hack) (20151101).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pedes2Go (Inv) (PAL) (Hack) (20151101).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pedes2Go (Inv) (TBall) (Hack) (20151101)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pedes2Go (Inv) (TBall) (Hack) (20151101).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pedes2Go (Inv) (TBall) (Hack) (20151101).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pedes2Go (Inv) (TBall) (Hack) (20151101).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pedes2Go (Inv) (TBall) (Hack) (20151101).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pedes2Go (NTSC) (Hack) (20151101)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pedes2Go (NTSC) (Hack) (20151101).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pedes2Go (NTSC) (Hack) (20151101).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pedes2Go (NTSC) (Hack) (20151101).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pedes2Go (NTSC) (Hack) (20151101).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pesco (3 Ghosts) (Hack) (20130510)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pesco (3 Ghosts) (Hack) (20130510).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pesco (3 Ghosts) (Hack) (20130510).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pesco (3 Ghosts) (Hack) (20130510).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pesco (3 Ghosts) (Hack) (20130510).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pesco 7800 (Hack) (20130422)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pesco 7800 (Hack) (20130422).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pesco 7800 (Hack) (20130422).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pesco 7800 (Hack) (20130422).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pesco 7800 (Hack) (20130422).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Piranha (Hack) (20090828)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Piranha (Hack) (20090828).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Piranha (Hack) (20090828).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Piranha (Hack) (20090828).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Piranha (Hack) (20090828).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Piranha 2 (Hack) (20180211)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Piranha 2 (Hack) (20180211).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Piranha 2 (Hack) (20180211).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Piranha 2 (Hack) (20180211).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Piranha 2 (Hack) (20180211).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Piranha 2 (Invincible) (Hack) (20180211)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Piranha 2 (Invincible) (Hack) (20180211).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Piranha 2 (Invincible) (Hack) (20180211).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Piranha 2 (Invincible) (Hack) (20180211).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Piranha 2 (Invincible) (Hack) (20180211).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Plutos (XM Required) (20200627)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Plutos (XM Required) (20200627).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Plutos (XM Required) (20200627).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Plutos (XM Required) (20200627).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Plutos (XM Required) (20200627).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pokey Kong (Early Version) (Hack) (20101029)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pokey Kong (Early Version) (Hack) (20101029).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pokey Kong (Early Version) (Hack) (20101029).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pokey Kong (Early Version) (Hack) (20101029).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pokey Kong (Early Version) (Hack) (20101029).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pole Position 3 (Inv) (NTSC) (Hack) (20151106)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Position 3 (Inv) (NTSC) (Hack) (20151106).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Position 3 (Inv) (NTSC) (Hack) (20151106).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole Position 3 (Inv) (NTSC) (Hack) (20151106).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole Position 3 (Inv) (NTSC) (Hack) (20151106).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pole Position 3 (Inv) (PAL) (20151106)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Position 3 (Inv) (PAL) (20151106).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Position 3 (Inv) (PAL) (20151106).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole Position 3 (Inv) (PAL) (20151106).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole Position 3 (Inv) (PAL) (20151106).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pole Position 3 (NTSC) (Hack) (20151106)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Position 3 (NTSC) (Hack) (20151106).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Position 3 (NTSC) (Hack) (20151106).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole Position 3 (NTSC) (Hack) (20151106).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole Position 3 (NTSC) (Hack) (20151106).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pole Position 3 (PAL) (Hack) (20151106)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Position 3 (PAL) (Hack) (20151106).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Position 3 (PAL) (Hack) (20151106).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole Position 3 (PAL) (Hack) (20151106).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole Position 3 (PAL) (Hack) (20151106).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Pole Postion II (Graphics Hack) (20140412)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Postion II (Graphics Hack) (20140412).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Postion II (Graphics Hack) (20140412).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole Postion II (Graphics Hack) (20140412).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole Postion II (Graphics Hack) (20140412).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Portable Ms Pac (Hack) (20130501)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Portable Ms Pac (Hack) (20130501).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Portable Ms Pac (Hack) (20130501).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Portable Ms Pac (Hack) (20130501).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Portable Ms Pac (Hack) (20130501).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Possible Mission (Hack) (20050130)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Possible Mission (Hack) (20050130).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Possible Mission (Hack) (20050130).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Possible Mission (Hack) (20050130).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Possible Mission (Hack) (20050130).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Q-bert (Unlimited Lives) (Hack) (20060531)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Q-bert (Unlimited Lives) (Hack) (20060531).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Q-bert (Unlimited Lives) (Hack) (20060531).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Q-bert (Unlimited Lives) (Hack) (20060531).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Q-bert (Unlimited Lives) (Hack) (20060531).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "RealSports Baseball (NTSC) (Overdump 78SG Hack) (20210124)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RealSports Baseball (NTSC) (Overdump 78SG Hack) (20210124).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RealSports Baseball (NTSC) (Overdump 78SG Hack) (20210124).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\RealSports Baseball (NTSC) (Overdump 78SG Hack) (20210124).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\RealSports Baseball (NTSC) (Overdump 78SG Hack) (20210124).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Robotron 2084 (PAL Hack) (20210428)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robotron 2084 (PAL Hack) (20210428).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robotron 2084 (PAL Hack) (20210428).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robotron 2084 (PAL Hack) (20210428).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robotron 2084 (PAL Hack) (20210428).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Robotron X (NTSC) (Hack) (20130114)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robotron X (NTSC) (Hack) (20130114).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robotron X (NTSC) (Hack) (20130114).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robotron X (NTSC) (Hack) (20130114).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robotron X (NTSC) (Hack) (20130114).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Rowdytron (NTSC) (Hack) (20130207)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rowdytron (NTSC) (Hack) (20130207).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rowdytron (NTSC) (Hack) (20130207).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rowdytron (NTSC) (Hack) (20130207).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rowdytron (NTSC) (Hack) (20130207).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Scrapyard Dog (Graphics and Infinite Lives Hack) (20200612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (Graphics and Infinite Lives Hack) (20200612).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (Graphics and Infinite Lives Hack) (20200612).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard Dog (Graphics and Infinite Lives Hack) (20200612).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard Dog (Graphics and Infinite Lives Hack) (20200612).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Scrapyard Dog (Graphics Hack) (20200612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (Graphics Hack) (20200612).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (Graphics Hack) (20200612).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard Dog (Graphics Hack) (20200612).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard Dog (Graphics Hack) (20200612).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Scrapyard Dog (Graphics Hack) (Green Title) (20200612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (Graphics Hack) (Green Title) (20200612).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (Graphics Hack) (Green Title) (20200612).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard Dog (Graphics Hack) (Green Title) (20200612).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard Dog (Graphics Hack) (Green Title) (20200612).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Scrapyard Dog (Scraps Hack and Infinite Lives Hack) (RC5) (20200612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (Scraps Hack and Infinite Lives Hack) (RC5) (20200612).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (Scraps Hack and Infinite Lives Hack) (RC5) (20200612).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard Dog (Scraps Hack and Infinite Lives Hack) (RC5) (20200612).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard Dog (Scraps Hack and Infinite Lives Hack) (RC5) (20200612).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Scrapyard Dog (Scraps Hack) (RC5) (20200612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (Scraps Hack) (RC5) (20200612).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (Scraps Hack) (RC5) (20200612).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard Dog (Scraps Hack) (RC5) (20200612).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard Dog (Scraps Hack) (RC5) (20200612).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Scrapyard Dog (Unlimited Lives Hack) (20160826)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (Unlimited Lives Hack) (20160826).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (Unlimited Lives Hack) (20160826).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard Dog (Unlimited Lives Hack) (20160826).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard Dog (Unlimited Lives Hack) (20160826).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Shark Attack (Hack) (20130420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Shark Attack (Hack) (20130420).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Shark Attack (Hack) (20130420).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Shark Attack (Hack) (20130420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Shark Attack (Hack) (20130420).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Shatneroids (Hack) (20160114)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Shatneroids (Hack) (20160114).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Shatneroids (Hack) (20160114).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Shatneroids (Hack) (20160114).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Shatneroids (Hack) (20160114).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Sirius (XM Required) (20200627)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sirius (XM Required) (20200627).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sirius (XM Required) (20200627).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sirius (XM Required) (20200627).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sirius (XM Required) (20200627).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Slick Pickles (Hack) (20180929)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Slick Pickles (Hack) (20180929).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Slick Pickles (Hack) (20180929).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Slick Pickles (Hack) (20180929).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Slick Pickles (Hack) (20180929).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Slime Time (Hack) (20170221)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Slime Time (Hack) (20170221).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Slime Time (Hack) (20170221).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Slime Time (Hack) (20170221).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Slime Time (Hack) (20170221).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Slime Time 2 (Hack) (20180217)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Slime Time 2 (Hack) (20180217).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Slime Time 2 (Hack) (20180217).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Slime Time 2 (Hack) (20180217).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Slime Time 2 (Hack) (20180217).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Slime Time 2 (Invincible) (Hack) (20181116)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Slime Time 2 (Invincible) (Hack) (20181116).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Slime Time 2 (Invincible) (Hack) (20181116).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Slime Time 2 (Invincible) (Hack) (20181116).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Slime Time 2 (Invincible) (Hack) (20181116).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Slinkipede (NTSC) (Hack) (20181210)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Slinkipede (NTSC) (Hack) (20181210).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Slinkipede (NTSC) (Hack) (20181210).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Slinkipede (NTSC) (Hack) (20181210).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Slinkipede (NTSC) (Hack) (20181210).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Slinkipede (PAL) (Hack) (20151206)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Slinkipede (PAL) (Hack) (20151206).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Slinkipede (PAL) (Hack) (20151206).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Slinkipede (PAL) (Hack) (20151206).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Slinkipede (PAL) (Hack) (20151206).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Slinkipede (TBall) (Hack) (20181210)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Slinkipede (TBall) (Hack) (20181210).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Slinkipede (TBall) (Hack) (20181210).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Slinkipede (TBall) (Hack) (20181210).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Slinkipede (TBall) (Hack) (20181210).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Snapper (Hack) (20130420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Snapper (Hack) (20130420).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Snapper (Hack) (20130420).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Snapper (Hack) (20130420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Snapper (Hack) (20130420).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Snow Day Jr Pac-Man (Hack) (20090725)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Snow Day Jr Pac-Man (Hack) (20090725).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Snow Day Jr Pac-Man (Hack) (20090725).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Snow Day Jr Pac-Man (Hack) (20090725).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Snow Day Jr Pac-Man (Hack) (20090725).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Space Junk (NTSC) (Hack) (20131209)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Junk (NTSC) (Hack) (20131209).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Junk (NTSC) (Hack) (20131209).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space Junk (NTSC) (Hack) (20131209).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space Junk (NTSC) (Hack) (20131209).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Space Pong (NTSC) (Hack) (20131130)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Pong (NTSC) (Hack) (20131130).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Pong (NTSC) (Hack) (20131130).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space Pong (NTSC) (Hack) (20131130).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space Pong (NTSC) (Hack) (20131130).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Specman (Hack) (20130420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Specman (Hack) (20130420).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Specman (Hack) (20130420).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Specman (Hack) (20130420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Specman (Hack) (20130420).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Star Wars 7800 (Hack) (20070927)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Star Wars 7800 (Hack) (20070927).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Star Wars 7800 (Hack) (20070927).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Star Wars 7800 (Hack) (20070927).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Star Wars 7800 (Hack) (20070927).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Star Wars X (NTSC) (Hack) (20130304)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Star Wars X (NTSC) (Hack) (20130304).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Star Wars X (NTSC) (Hack) (20130304).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Star Wars X (NTSC) (Hack) (20130304).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Star Wars X (NTSC) (Hack) (20130304).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Tank Command - Midnight Run (Hack) (20141225)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tank Command - Midnight Run (Hack) (20141225).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tank Command - Midnight Run (Hack) (20141225).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tank Command - Midnight Run (Hack) (20141225).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tank Command - Midnight Run (Hack) (20141225).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Tank Command (Color+Sprite+Title) (128K) (Hack) (20141225)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tank Command (Color+Sprite+Title) (128K) (Hack) (20141225).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tank Command (Color+Sprite+Title) (128K) (Hack) (20141225).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tank Command (Color+Sprite+Title) (128K) (Hack) (20141225).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tank Command (Color+Sprite+Title) (128K) (Hack) (20141225).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Tank Command (NTSC) (Overdump 78SG Hack) (20210124)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tank Command (NTSC) (Overdump 78SG Hack) (20210124).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tank Command (NTSC) (Overdump 78SG Hack) (20210124).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tank Command (NTSC) (Overdump 78SG Hack) (20210124).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tank Command (NTSC) (Overdump 78SG Hack) (20210124).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Titanman (Hack) (20130420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Titanman (Hack) (20130420).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Titanman (Hack) (20130420).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Titanman (Hack) (20130420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Titanman (Hack) (20130420).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Tower Toppler (NTSC) (Overdump 78SG Hack) (20210124)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tower Toppler (NTSC) (Overdump 78SG Hack) (20210124).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tower Toppler (NTSC) (Overdump 78SG Hack) (20210124).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tower Toppler (NTSC) (Overdump 78SG Hack) (20210124).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tower Toppler (NTSC) (Overdump 78SG Hack) (20210124).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Trix Brix (No Level 13) (NTSC) (Joystick) (Hack) (20131118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Trix Brix (No Level 13) (NTSC) (Joystick) (Hack) (20131118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Trix Brix (No Level 13) (NTSC) (Joystick) (Hack) (20131118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Trix Brix (No Level 13) (NTSC) (Joystick) (Hack) (20131118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Trix Brix (No Level 13) (NTSC) (Joystick) (Hack) (20131118).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Trix Brix (No Level 13) (NTSC) (Paddle) (Hack) (20131118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Trix Brix (No Level 13) (NTSC) (Paddle) (Hack) (20131118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Trix Brix (No Level 13) (NTSC) (Paddle) (Hack) (20131118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Trix Brix (No Level 13) (NTSC) (Paddle) (Hack) (20131118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Trix Brix (No Level 13) (NTSC) (Paddle) (Hack) (20131118).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Trix Brix (NTSC) (Joystick) (Hack) (20131118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Trix Brix (NTSC) (Joystick) (Hack) (20131118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Trix Brix (NTSC) (Joystick) (Hack) (20131118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Trix Brix (NTSC) (Joystick) (Hack) (20131118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Trix Brix (NTSC) (Joystick) (Hack) (20131118).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Trix Brix (NTSC) (Paddle) (Hack) (20131118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Trix Brix (NTSC) (Paddle) (Hack) (20131118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Trix Brix (NTSC) (Paddle) (Hack) (20131118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Trix Brix (NTSC) (Paddle) (Hack) (20131118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Trix Brix (NTSC) (Paddle) (Hack) (20131118).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Turbo Maze Man (Hack) (20160617)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Turbo Maze Man (Hack) (20160617).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Turbo Maze Man (Hack) (20160617).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Turbo Maze Man (Hack) (20160617).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Turbo Maze Man (Hack) (20160617).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "UFO! Genesys (Hack) (20181118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\UFO! Genesys (Hack) (20181118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\UFO! Genesys (Hack) (20181118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\UFO! Genesys (Hack) (20181118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\UFO! Genesys (Hack) (20181118).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ultra Pac-Man (Fast Hack) (20060526)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ultra Pac-Man (Fast Hack) (20060526).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\.Ultra Pac-Man (Fast Hack) (20060526)jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ultra Pac-Man (Fast Hack) (20060526).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ultra Pac-Man (Fast Hack) (20060526).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ultra Pac-Man (Fast Unlimited Lives Hack) (20060526)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ultra Pac-Man (Fast Unlimited Lives Hack) (20060526).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ultra Pac-Man (Fast Unlimited Lives Hack) (20060526).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ultra Pac-Man (Fast Unlimited Lives Hack) (20060526).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ultra Pac-Man (Fast Unlimited Lives Hack) (20060526).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ultra Pac-Man (Ferrell's Hack) (20170405)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ultra Pac-Man (Ferrell's Hack) (20170405).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ultra Pac-Man (Ferrell's Hack) (20170405).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ultra Pac-Man (Ferrell's Hack) (20170405).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ultra Pac-Man (Ferrell's Hack) (20170405).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Ultra Pac-Man (PacManPlus' Hack) (20050619)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ultra Pac-Man (PacManPlus' Hack) (20050619).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ultra Pac-Man (PacManPlus' Hack) (20050619).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ultra Pac-Man (PacManPlus' Hack) (20050619).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ultra Pac-Man (PacManPlus' Hack) (20050619).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Upside Down Ms Pac-Man (Hack) (20090718)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Upside Down Ms Pac-Man (Hack) (20090718).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Upside Down Ms Pac-Man (Hack) (20090718).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Upside Down Ms Pac-Man (Hack) (20090718).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Upside Down Ms Pac-Man (Hack) (20090718).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Upside Down Pac-Man (Hack) (20090718)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Upside Down Pac-Man (Hack) (20090718).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Upside Down Pac-Man (Hack) (20090718).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Upside Down Pac-Man (Hack) (20090718).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Upside Down Pac-Man (Hack) (20090718).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Vector Ms Pac-Man (Hack) (20120325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Vector Ms Pac-Man (Hack) (20120325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Vector Ms Pac-Man (Hack) (20120325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Vector Ms Pac-Man (Hack) (20120325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Vector Ms Pac-Man (Hack) (20120325).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Waka Waka (Hack) (20130503)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Waka Waka (Hack) (20130503).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Waka Waka (Hack) (20130503).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Waka Waka (Hack) (20130503).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Waka Waka (Hack) (20130503).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Water Ski (NTSC) (Overdump 78SG Hack) (20210124)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Water Ski (NTSC) (Overdump 78SG Hack) (20210124).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Water Ski (NTSC) (Overdump 78SG Hack) (20210124).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Water Ski (NTSC) (Overdump 78SG Hack) (20210124).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Water Ski (NTSC) (Overdump 78SG Hack) (20210124).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Water Ski (Title+Color+Realign) (128k) (Hack) (20130224)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Water Ski (Title+Color+Realign) (128k) (Hack) (20130224).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Water Ski (Title+Color+Realign) (128k) (Hack) (20130224).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Water Ski (Title+Color+Realign) (128k) (Hack) (20130224).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Water Ski (Title+Color+Realign) (128k) (Hack) (20130224).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Water Ski (Title+Color+Realign) (Trained) (128k) (Hack) (20130224)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Water Ski (Title+Color+Realign) (Trained) (128k) (Hack) (20130224).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Water Ski (Title+Color+Realign) (Trained) (128k) (Hack) (20130224).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Water Ski (Title+Color+Realign) (Trained) (128k) (Hack) (20130224).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Water Ski (Title+Color+Realign) (Trained) (128k) (Hack) (20130224).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "World Cup (Hack) (20140614)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\World Cup (Hack) (20140614).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\World Cup (Hack) (20140614).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\World Cup (Hack) (20140614).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\World Cup (Hack) (20140614).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "WWE Title Match (Alt Colors) (Hack) (20121010)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\WWE Title Match (Alt Colors) (Hack) (20121010).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\WWE Title Match (Alt Colors) (Hack) (20121010).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\WWE Title Match (Alt Colors) (Hack) (20121010).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\WWE Title Match (Alt Colors) (Hack) (20121010).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "WWE Title Match (Hack) (20121010)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\WWE Title Match (Hack) (20121010).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\WWE Title Match (Hack) (20121010).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\WWE Title Match (Hack) (20121010).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\WWE Title Match (Hack) (20121010).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Xevious (Title and Color Hack) (20130319)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xevious (Title and Color Hack) (20130319).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xevious (Title and Color Hack) (20130319).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xevious (Title and Color Hack) (20130319).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xevious (Title and Color Hack) (20130319).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Xevious X (NTSC) (Hack) (20130304)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xevious X (NTSC) (Hack) (20130304).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xevious X (NTSC) (Hack) (20130304).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xevious X (NTSC) (Hack) (20130304).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xevious X (NTSC) (Hack) (20130304).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Xevious X (PAL) (Hack) (20130304)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xevious X (PAL) (Hack) (20130304).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xevious X (PAL) (Hack) (20130304).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xevious X (PAL) (Hack) (20130304).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xevious X (PAL) (Hack) (20130304).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "Xmas Time (Hack) (20061225)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xmas Time (Hack) (20061225).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xmas Time (Hack) (20061225).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xmas Time (Hack) (20061225).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xmas Time (Hack) (20061225).htm"))
            End If
        End If

        If lstHacks.SelectedItem.ToString = "YPS Quest (Hack) (20140712)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\YPS Quest (Hack) (20140712).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\YPS Quest (Hack) (20140712).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\YPS Quest (Hack) (20140712).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\YPS Quest (Hack) (20140712).htm"))
            End If
        End If

    End Sub

    Private Sub lstDemos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDemos.SelectedIndexChanged

        'Update Game Info HTML Editor
        txtHTMLEditor.Clear()
        strFileName = "\" + lstDemos.Text + ".htm"
        txtEditorFile.Text = strManualsFolder + strFileName
        Try
            For Each s As String In System.IO.File.ReadAllLines(txtEditorFile.Text)
                txtHTMLEditor.AppendText(s + vbNewLine)
            Next
        Catch ex As Exception
        End Try


        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtDemosPath.Text + "\" + lstDemos.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch



        If lstDemos.SelectedItem.ToString = "1E78 Demo (PAL) (20190420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\1E78 Demo (PAL) (20190420).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\1E78 Demo (PAL) (20190420).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\1E78 Demo (PAL) (20190420).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\1E78 Demo (PAL) (20190420).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "3D Test Demo 1 (PAL) (20180102)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\3D Test Demo 1 (PAL) (20180102).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\3D Test Demo 1 (PAL) (20180102).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\3D Test Demo 1 (PAL) (20180102).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\3D Test Demo 1 (PAL) (20180102).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "3D Worldrunner Theme Melody (450) (20190903)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\3D Worldrunner Theme Melody (450) (20190903).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\3D Worldrunner Theme Melody (450) (20190903).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\3D Worldrunner Theme Melody (450) (20190903).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\3D Worldrunner Theme Melody (450) (20190903).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "3D Worldrunner Theme Melody (4000) (20190903)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\3D Worldrunner Theme Melody (4000) (20190903).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\3D Worldrunner Theme Melody (4000) (20190903).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\3D Worldrunner Theme Melody (4000) (20190903).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\3D Worldrunner Theme Melody (4000) (20190903).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "10 Print Maze Demo (20170826)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\10 Print Maze Demo (20170826).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\10 Print Maze Demo (20170826).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\10 Print Maze Demo (20170826).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\10 Print Maze Demo (20170826).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "7800 Kernel Demo (20041101)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\7800 Kernel Demo (20041101).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\7800 Kernel Demo (20041101).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\7800 Kernel Demo (20041101).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\7800 Kernel Demo (20041101).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "7800 Non-Interactive Title Screen (20210320)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\7800 Non-Interactive Title Screen (20210320).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\7800 Non-Interactive Title Screen (20210320).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\7800 Non-Interactive Title Screen (20210320).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\7800 Non-Interactive Title Screen (20210320).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "A Warm Welcome (POKEY Music Demo) (20130612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\A Warm Welcome (POKEY Music Demo) (20130612).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\A Warm Welcome (POKEY Music Demo) (20130612).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\A Warm Welcome (POKEY Music Demo) (20130612).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\A Warm Welcome (POKEY Music Demo) (20130612).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Acidjazzed (Dual POKEY 440 450 Demo) (20210117)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Acidjazzed (Dual POKEY 440 450 Demo) (20210117).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Acidjazzed (Dual POKEY 440 450 Demo) (20210117).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Acidjazzed (Dual POKEY 440 450 Demo) (20210117).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Acidjazzed (Dual POKEY 440 450 Demo) (20210117).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Adventure Map Demo (20141230)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Adventure Map Demo (20141230).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Adventure Map Demo (20141230).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Adventure Map Demo (20141230).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Adventure Map Demo (20141230).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Adventure Map Demo (20141230)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Adventure Map Demo (20141230).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Adventure Map Demo (20141230).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Adventure Map Demo (20141230).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Adventure Map Demo (20141230).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Adventurer (Sample) (20140301)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Adventurer (Sample) (20140301).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Adventurer (Sample) (20140301).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Adventurer (Sample) (20140301).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Adventurer (Sample) (20140301).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Adventurer Scroll Demo (20150307)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Adventurer Scroll Demo (20150307).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Adventurer Scroll Demo (20150307).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Adventurer Scroll Demo (20150307).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Adventurer Scroll Demo (20150307).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Adventurer Scroll Demo (v2) (20150312)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Adventurer Scroll Demo (v2) (20150312).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Adventurer Scroll Demo (v2) (20150312).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Adventurer Scroll Demo (v2) (20150312).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Adventurer Scroll Demo (v2) (20150312).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Aim (Demo) (20150731)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Aim (Demo) (20150731).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Aim (Demo) (20150731).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Aim (Demo) (20150731).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Aim (Demo) (20150731).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Al Capone (YM2151 Demo) (20211201)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Al Capone (YM2151 Demo) (20211201).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Al Capone (YM2151 Demo) (20211201).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Al Capone (YM2151 Demo) (20211201).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Al Capone (YM2151 Demo) (20211201).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Allura (Picture Demo) (20170126)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Allura (Picture Demo) (20170126).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Allura (Picture Demo) (20170126).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Allura (Picture Demo) (20170126).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Allura (Picture Demo) (20170126).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Altered Beast - Title and Sprite Demo (20220222)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Altered Beast - Title and Sprite Demo (20220222).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Altered Beast - Title and Sprite Demo (20220222).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Altered Beast - Title and Sprite Demo (20220222).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Altered Beast - Title and Sprite Demo (20220222).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Animated Moving Demo 24 (20171127)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Animated Moving Demo 24 (20171127).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Animated Moving Demo 24 (20171127).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Animated Moving Demo 24 (20171127).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Animated Moving Demo 24 (20171127).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Animated Moving Demo 32 (20171127)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Animated Moving Demo 32 (20171127).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Animated Moving Demo 32 (20171127).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Animated Moving Demo 32 (20171127).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Animated Moving Demo 32 (20171127).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Arkanoid (Level Start Music Demo)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Arkanoid (Level Start Music Demo).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Arkanoid (Level Start Music Demo).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Arkanoid (Level Start Music Demo).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Arkanoid (Level Start Music Demo).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Arkanoid (Title Music Demo)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Arkanoid (Title Music Demo).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Arkanoid (Title Music Demo).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Arkanoid (Title Music Demo).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Arkanoid (Title Music Demo).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Arkanoid 2 DOH Theme Music (450) (20200831)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Arkanoid 2 DOH Theme Music (450) (20200831).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Arkanoid 2 DOH Theme Music (450) (20200831).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Arkanoid 2 DOH Theme Music (450) (20200831).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Arkanoid 2 DOH Theme Music (450) (20200831).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Arkanoid 2 DOH Theme Music (4000) (20200831)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Arkanoid 2 DOH Theme Music (4000) (20200831).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Arkanoid 2 DOH Theme Music (4000) (20200831).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Arkanoid 2 DOH Theme Music (4000) (20200831).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Arkanoid 2 DOH Theme Music (4000) (20200831).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Arkanoid 2 Intro Music (450) (20200830)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Arkanoid 2 Intro Music (450) (20200830).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Arkanoid 2 Intro Music (450) (20200830).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Arkanoid 2 Intro Music (450) (20200830).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Arkanoid 2 Intro Music (450) (20200830).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Arkanoid 2 Intro Music (4000) (20200830)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Arkanoid 2 Intro Music (4000) (20200830).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Arkanoid 2 Intro Music (4000) (20200830).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Arkanoid 2 Intro Music (4000) (20200830).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Arkanoid 2 Intro Music (4000) (20200830).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Arkanoid 2 Level Start Sound Demo (450) (20200831)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Arkanoid 2 Level Start Sound Demo (450) (20200831).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Arkanoid 2 Level Start Sound Demo (450) (20200831).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Arkanoid 2 Level Start Sound Demo (450) (20200831).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Arkanoid 2 Level Start Sound Demo (450) (20200831).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Arkanoid 2 Level Start Sound Demo (4000) (20200831)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Arkanoid 2 Level Start Sound Demo (4000) (20200831).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Arkanoid 2 Level Start Sound Demo (4000) (20200831).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Arkanoid 2 Level Start Sound Demo (4000) (20200831).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Arkanoid 2 Level Start Sound Demo (4000) (20200831).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Arkanoid Background 3 Colors Demo (20190714)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Arkanoid Background 3 Colors Demo (20190714).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Arkanoid Background 3 Colors Demo (20190714).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Arkanoid Background 3 Colors Demo (20190714).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Arkanoid Background 3 Colors Demo (20190714).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Art Of Scrolling Without Scrolling, The (Demo) (20200603)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Art Of Scrolling Without Scrolling, The (Demo) (20200603).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Art Of Scrolling Without Scrolling, The (Demo) (20200603).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Art Of Scrolling Without Scrolling, The (Demo) (20200603).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Art Of Scrolling Without Scrolling, The (Demo) (20200603).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Asuka Sky (Picture Demo) (20170126)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asuka Sky (Picture Demo) (20170126).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asuka Sky (Picture Demo) (20170126).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asuka Sky (Picture Demo) (20170126).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asuka Sky (Picture Demo) (20170126).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Asuka Surf (Picture Demo) (20170126)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asuka Surf (Picture Demo) (20170126).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asuka Surf (Picture Demo) (20170126).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asuka Surf (Picture Demo) (20170126).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asuka Surf (Picture Demo) (20170126).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Atari 7800 ProSystem Memo Pad (20210401)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Atari 7800 ProSystem Memo Pad (20210401).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Atari 7800 ProSystem Memo Pad (20210401).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Atari 7800 ProSystem Memo Pad (20210401).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Atari 7800 ProSystem Memo Pad (20210401).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Atari Fuji Logo Demo (20220222)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Atari Fuji Logo Demo (20220222).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Atari Fuji Logo Demo (20220222).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Atari Fuji Logo Demo (20220222).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Atari Fuji Logo Demo (20220222).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "AtariAge Jingle (4000) (20190708)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\AtariAge Jingle (4000) (20190708).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\AtariAge Jingle (4000) (20190708).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\AtariAge Jingle (4000) (20190708).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\AtariAge Jingle (4000) (20190708).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "AtariAge Jingle (v2) (4000) (20190708)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\AtariAge Jingle (v2) (4000) (20190708).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\AtariAge Jingle (v2) (4000) (20190708).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\AtariAge Jingle (v2) (4000) (20190708).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\AtariAge Jingle (v2) (4000) (20190708).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bankset Test - 2x32K Pokey4000" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bankset Test - 2x32K Pokey4000.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bankset Test - 2x32K Pokey4000.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bankset Test - 2x32K Pokey4000.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bankset Test - 2x32K Pokey4000.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bankset Test - 2x32K RAM Pokey800" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bankset Test - 2x32K RAM Pokey800.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bankset Test - 2x32K RAM Pokey800.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bankset Test - 2x32K RAM Pokey800.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bankset Test - 2x32K RAM Pokey800.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bankset Test - 2x32K" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bankset Test - 2x32K.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bankset Test - 2x32K.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bankset Test - 2x32K.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bankset Test - 2x32K.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bankset Test - 2x48K Pokey4000" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bankset Test - 2x48K Pokey4000.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bankset Test - 2x48K Pokey4000.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bankset Test - 2x48K Pokey4000.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bankset Test - 2x48K Pokey4000.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bankset Test - 2x48K" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bankset Test - 2x48K.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bankset Test - 2x48K.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bankset Test - 2x48K.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bankset Test - 2x48K.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bankset Test - 2x52K Pokey4000" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bankset Test - 2x52K Pokey4000.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bankset Test - 2x52K Pokey4000.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bankset Test - 2x52K Pokey4000.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bankset Test - 2x52K Pokey4000.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bankset Test - 2x52K" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bankset Test - 2x52K.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bankset Test - 2x52K.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bankset Test - 2x52K.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bankset Test - 2x52K.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bankset Test - 2x128K RAM Pokey800" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bankset Test - 2x128K RAM Pokey800.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bankset Test - 2x128K RAM Pokey800.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bankset Test - 2x128K RAM Pokey800.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bankset Test - 2x128K RAM Pokey800.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bankset Test - 2x128K RAM" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bankset Test - 2x128K RAM.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bankset Test - 2x128K RAM.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bankset Test - 2x128K RAM.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bankset Test - 2x128K RAM.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bankset Test - 2x128K" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bankset Test - 2x128K.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bankset Test - 2x128K.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bankset Test - 2x128K.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bankset Test - 2x128K.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Batari Basic Demo Conversion (20210409)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Batari Basic Demo Conversion (20210409).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Batari Basic Demo Conversion (20210409).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Batari Basic Demo Conversion (20210409).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Batari Basic Demo Conversion (20210409).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Batman (Picture Demo) (20170126)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Batman (Picture Demo) (20170126).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Batman (Picture Demo) (20170126).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Batman (Picture Demo) (20170126).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Batman (Picture Demo) (20170126).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Battlezone (NTSC) (20160208)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Battlezone (NTSC) (20160208).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Battlezone (NTSC) (20160208).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Battlezone (NTSC) (20160208).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Battlezone (NTSC) (20160208).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "" Then
            If System.IO.File.Exists(strBoxArtFolder & "\.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Battlezone (PAL) (20160208)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Battlezone (PAL) (20160208).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Battlezone (PAL) (20160208).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Battlezone (PAL) (20160208).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Battlezone (PAL) (20160208).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Beach Adventure (20220531)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Beach Adventure (20220531).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Beach Adventure (20220531).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Beach Adventure (20220531).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Beach Adventure (20220531).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bear Arms (Alpha) (20140523)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bear Arms (Alpha) (20140523).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bear Arms (Alpha) (20140523).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bear Arms (Alpha) (20140523).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bear Arms (Alpha) (20140523).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bee Moved (Covox Music Demo) (31440Hz) (PAL) (20210410)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bee Moved (Covox Music Demo) (31440Hz) (PAL) (20210410).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bee Moved (Covox Music Demo) (31440Hz) (PAL) (20210410).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bee Moved (Covox Music Demo) (31440Hz) (PAL) (20210410).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bee Moved (Covox Music Demo) (31440Hz) (PAL) (20210410).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bee Moved (Covox Music Demo) (94320Hz) (PAL) (20210411)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bee Moved (Covox Music Demo) (94320Hz) (PAL) (20210411).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bee Moved (Covox Music Demo) (94320Hz) (PAL) (20210411).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bee Moved (Covox Music Demo) (94320Hz) (PAL) (20210411).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bee Moved (Covox Music Demo) (94320Hz) (PAL) (20210411).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bionic Commando - The Forest (YM2151 Demo) (PAL) (20211031)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bionic Commando - The Forest (YM2151 Demo) (PAL) (20211031).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bionic Commando - The Forest (YM2151 Demo) (PAL) (20211031).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bionic Commando - The Forest (YM2151 Demo) (PAL) (20211031).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bionic Commando - The Forest (YM2151 Demo) (PAL) (20211031).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bitmap Template Demo (V2) (20220123)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bitmap Template Demo (V2) (20220123).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bitmap Template Demo (V2) (20220123).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bitmap Template Demo (V2) (20220123).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bitmap Template Demo (V2) (20220123).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Black Lamp Music Demo (4000) (20210318)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Black Lamp Music Demo (4000) (20210318).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Black Lamp Music Demo (4000) (20210318).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Black Lamp Music Demo (4000) (20210318).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Black Lamp Music Demo (4000) (20210318).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Blocky Clouds Scroll Demo (20030507)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Blocky Clouds Scroll Demo (20030507).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blocky Clouds Scroll Demo (20030507).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Blocky Clouds Scroll Demo (20030507).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Blocky Clouds Scroll Demo (20030507).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bloodfighter (Covox Music Demo) (PAL) (20210404)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bloodfighter (Covox Music Demo) (PAL) (20210404).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bloodfighter (Covox Music Demo) (PAL) (20210404).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bloodfighter (Covox Music Demo) (PAL) (20210404).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bloodfighter (Covox Music Demo) (PAL) (20210404).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bomb Jack Sound Demo (POKEY 450) (20210201)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bomb Jack Sound Demo (POKEY 450) (20210201).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bomb Jack Sound Demo (POKEY 450) (20210201).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bomb Jack Sound Demo (POKEY 450) (20210201).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bomb Jack Sound Demo (POKEY 450) (20210201).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bouncing Balls (Demo) (20070330)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bouncing Balls (Demo) (20070330).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bouncing Balls (Demo) (20070330).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bouncing Balls (Demo) (20070330).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bouncing Balls (Demo) (20070330).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bubble Bobble Theme (Bass Only Demo) (4000) (20190903)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bubble Bobble Theme (Bass Only Demo) (4000) (20190903).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bubble Bobble Theme (Bass Only Demo) (4000) (20190903).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bubble Bobble Theme (Bass Only Demo) (4000) (20190903).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bubble Bobble Theme (Bass Only Demo) (4000) (20190903).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bubble Bobble Theme Sound Demo (450) (20190819)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bubble Bobble Theme Sound Demo (450) (20190819).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bubble Bobble Theme Sound Demo (450) (20190819).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bubble Bobble Theme Sound Demo (450) (20190819).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bubble Bobble Theme Sound Demo (450) (20190819).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Bubble Bobble Theme Sound Demo (4000) (20190724)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Bubble Bobble Theme Sound Demo (4000) (20190724).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Bubble Bobble Theme Sound Demo (4000) (20190724).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bubble Bobble Theme Sound Demo (4000) (20190724).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bubble Bobble Theme Sound Demo (4000) (20190724).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Buttons (Picture Demo) (20170126)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Buttons (Picture Demo) (20170126).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Buttons (Picture Demo) (20170126).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Buttons (Picture Demo) (20170126).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Buttons (Picture Demo) (20170126).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Byzex (Dual POKEY 440 450 Demo) (20210120)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Byzex (Dual POKEY 440 450 Demo) (20210120).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Byzex (Dual POKEY 440 450 Demo) (20210120).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Byzex (Dual POKEY 440 450 Demo) (20210120).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Byzex (Dual POKEY 440 450 Demo) (20210120).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Call Of Duty Black Ops - Cold War (AtariVox Demo) (20210112)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Call Of Duty Black Ops - Cold War (AtariVox Demo) (20210112).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Call Of Duty Black Ops - Cold War (AtariVox Demo) (20210112).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Call Of Duty Black Ops - Cold War (AtariVox Demo) (20210112).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Call Of Duty Black Ops - Cold War (AtariVox Demo) (20210112).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Camouflage - The Great Commandment (Music Demo) (4000) (NTSC) (20210314)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Camouflage - The Great Commandment (Music Demo) (4000) (NTSC) (20210314).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Camouflage - The Great Commandment (Music Demo) (4000) (NTSC) (20210314).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Camouflage - The Great Commandment (Music Demo) (4000) (NTSC) (20210314).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Camouflage - The Great Commandment (Music Demo) (4000) (NTSC) (20210314).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Camouflage - The Great Commandment (Music Demo) (4000) (PAL) (20210314)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Camouflage - The Great Commandment (Music Demo) (4000) (PAL) (20210314).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Camouflage - The Great Commandment (Music Demo) (4000) (PAL) (20210314).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Camouflage - The Great Commandment (Music Demo) (4000) (PAL) (20210314).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Camouflage - The Great Commandment (Music Demo) (4000) (PAL) (20210314).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Capcom Vs SNK (Picture Demo) (20170121)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Capcom Vs SNK (Picture Demo) (20170121).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Capcom Vs SNK (Picture Demo) (20170121).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Capcom Vs SNK (Picture Demo) (20170121).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Capcom Vs SNK (Picture Demo) (20170121).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Cheetahmen, The (YM2151 Demo) (20211201)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Cheetahmen, The (YM2151 Demo) (20211201).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Cheetahmen, The (YM2151 Demo) (20211201).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Cheetahmen, The (YM2151 Demo) (20211201).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Cheetahmen, The (YM2151 Demo) (20211201).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Cloak and Dagger - Title Screen Demo (Original Logo) (20220509)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Cloak and Dagger - Title Screen Demo (Original Logo) (20220509).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Cloak and Dagger - Title Screen Demo (Original Logo) (20220509).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Cloak and Dagger - Title Screen Demo (Original Logo) (20220509).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Cloak and Dagger - Title Screen Demo (Original Logo) (20220509).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Cloak and Dagger - Title Screen Demo (Smooth Logo) (20220509)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Cloak and Dagger - Title Screen Demo (Smooth Logo) (20220509).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Cloak and Dagger - Title Screen Demo (Smooth Logo) (20220509).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Cloak and Dagger - Title Screen Demo (Smooth Logo) (20220509).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Cloak and Dagger - Title Screen Demo (Smooth Logo) (20220509).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Color Demo 1 (20181222)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Color Demo 1 (20181222).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Color Demo 1 (20181222).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Color Demo 1 (20181222).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Color Demo 1 (20181222).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Color Gradients WSYNC (Demo) (20220221)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Color Gradients WSYNC (Demo) (20220221).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Color Gradients WSYNC (Demo) (20220221).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Color Gradients WSYNC (Demo) (20220221).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Color Gradients WSYNC (Demo) (20220221).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Color Gradients WSYNC Fullscreen (Demo) (20220221)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Color Gradients WSYNC Fullscreen (Demo) (20220221).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Color Gradients WSYNC Fullscreen (Demo) (20220221).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Color Gradients WSYNC Fullscreen (Demo) (20220221).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Color Gradients WSYNC Fullscreen (Demo) (20220221).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Color Gradients WSYNC Fullscreen (Demo) (20220221)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Color Gradients WSYNC Fullscreen (Demo) (20220221).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Color Gradients WSYNC Fullscreen (Demo) (20220221).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Color Gradients WSYNC Fullscreen (Demo) (20220221).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Color Gradients WSYNC Fullscreen (Demo) (20220221).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Cybernoid II (Music Demo) (POKEY 450) (20210116)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Cybernoid II (Music Demo) (POKEY 450) (20210116).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Cybernoid II (Music Demo) (POKEY 450) (20210116).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Cybernoid II (Music Demo) (POKEY 450) (20210116).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Cybernoid II (Music Demo) (POKEY 450) (20210116).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Cybernoid II (Music Demo) (POKEY 4000) (20210116)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Cybernoid II (Music Demo) (POKEY 4000) (20210116).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Cybernoid II (Music Demo) (POKEY 4000) (20210116).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Cybernoid II (Music Demo) (POKEY 4000) (20210116).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Cybernoid II (Music Demo) (POKEY 4000) (20210116).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "" Then
            If System.IO.File.Exists(strBoxArtFolder & "\.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Dark Tower (Demo) (20130506)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dark Tower (Demo) (20130506).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dark Tower (Demo) (20130506).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dark Tower (Demo) (20130506).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dark Tower (Demo) (20130506).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Deep Purple - Smoke On The Water (Music Demo) (450) (20200317)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Deep Purple - Smoke On The Water (Music Demo) (450) (20200317).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Deep Purple - Smoke On The Water (Music Demo) (450) (20200317).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Deep Purple - Smoke On The Water (Music Demo) (450) (20200317).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Deep Purple - Smoke On The Water (Music Demo) (450) (20200317).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Deep Purple - Smoke On The Water (Music Demo) (4000) (20200317)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Deep Purple - Smoke On The Water (Music Demo) (4000) (20200317).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Deep Purple - Smoke On The Water (Music Demo) (4000) (20200317).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Deep Purple - Smoke On The Water (Music Demo) (4000) (20200317).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Deep Purple - Smoke On The Water (Music Demo) (4000) (20200317).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Demo X (v1_01F) (20100423)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Demo X (v1_01F) (20100423).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Demo X (v1_01F) (20100423).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Demo X (v1_01F) (20100423).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Demo X (v1_01F) (20100423).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Dig Dug II (20211219)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dig Dug II (20211219).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dig Dug II (20211219).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dig Dug II (20211219).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dig Dug II (20211219).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Doodle Chaos Engine (20200622)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Doodle Chaos Engine (20200622).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Doodle Chaos Engine (20200622).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Doodle Chaos Engine (20200622).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Doodle Chaos Engine (20200622).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Double Buffer Demo (20170415)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Buffer Demo (20170415).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Buffer Demo (20170415).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double Buffer Demo (20170415).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double Buffer Demo (20170415).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Double Dragon (Graphics Demo) (20170121)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (Graphics Demo) (20170121).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (Graphics Demo) (20170121).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double Dragon (Graphics Demo) (20170121).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double Dragon (Graphics Demo) (20170121).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Double Dragon (Title Picture Demo) (20170121)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (Title Picture Demo) (20170121).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (Title Picture Demo) (20170121).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double Dragon (Title Picture Demo) (20170121).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double Dragon (Title Picture Demo) (20170121).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Double Dragon (Walking Demo) (20170130)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (Walking Demo) (20170130).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (Walking Demo) (20170130).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double Dragon (Walking Demo) (20170130).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double Dragon (Walking Demo) (20170130).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Dragonfly (Graphics Demo) (Test 2) (20210331)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dragonfly (Graphics Demo) (Test 2) (20210331).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dragonfly (Graphics Demo) (Test 2) (20210331).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dragonfly (Graphics Demo) (Test 2) (20210331).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dragonfly (Graphics Demo) (Test 2) (20210331).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "E X O Band - Area 1 Prison (20210303)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\E X O Band - Area 1 Prison (20210303).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\E X O Band - Area 1 Prison (20210303).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\E X O Band - Area 1 Prison (20210303).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\E X O Band - Area 1 Prison (20210303).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Elysium (Covox Music Demo) (7720Hz) (PAL) (20210411)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Elysium (Covox Music Demo) (7720Hz) (PAL) (20210411).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Elysium (Covox Music Demo) (7720Hz) (PAL) (20210411).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Elysium (Covox Music Demo) (7720Hz) (PAL) (20210411).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Elysium (Covox Music Demo) (7720Hz) (PAL) (20210411).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Endless Runner (Demo 1) (20210814)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Endless Runner (Demo 1) (20210814).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Endless Runner (Demo 1) (20210814).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Endless Runner (Demo 1) (20210814).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Endless Runner (Demo 1) (20210814).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Endless Runner (Demo 2) (20210814)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Endless Runner (Demo 2) (20210814).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Endless Runner (Demo 2) (20210814).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Endless Runner (Demo 2) (20210814).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Endless Runner (Demo 2) (20210814).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Enterprise (Picture Demo) (20170126)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Enterprise (Picture Demo) (20170126).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Enterprise (Picture Demo) (20170126).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Enterprise (Picture Demo) (20170126).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Enterprise (Picture Demo) (20170126).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Falling (Demo) (20091107)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Falling (Demo) (20091107).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Falling (Demo) (20091107).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Falling (Demo) (20091107).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Falling (Demo) (20091107).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Fantasy Zone - Dreaming Tomorrow (YM2151 Demo) (PAL) (20211031)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fantasy Zone - Dreaming Tomorrow (YM2151 Demo) (PAL) (20211031).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fantasy Zone - Dreaming Tomorrow (YM2151 Demo) (PAL) (20211031).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fantasy Zone - Dreaming Tomorrow (YM2151 Demo) (PAL) (20211031).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fantasy Zone - Dreaming Tomorrow (YM2151 Demo) (PAL) (20211031).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Flimbo's Quest Sound Demo (POKEY 450) (20210201)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Flimbo's Quest Sound Demo (POKEY 450) (20210201).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Flimbo's Quest Sound Demo (POKEY 450) (20210201).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Flimbo's Quest Sound Demo (POKEY 450) (20210201).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Flimbo's Quest Sound Demo (POKEY 450) (20210201).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Frankie Goes To Hollywood - Relax (Music Demo) (20150311)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Frankie Goes To Hollywood - Relax (Music Demo) (20150311).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Frankie Goes To Hollywood - Relax (Music Demo) (20150311).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Frankie Goes To Hollywood - Relax (Music Demo) (20150311).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Frankie Goes To Hollywood - Relax (Music Demo) (20150311).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Frogger (Demo) (20091107)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Frogger (Demo) (20091107).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Frogger (Demo) (20091107).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Frogger (Demo) (20091107).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Frogger (Demo) (20091107).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "G2F Slideshow (Demo) (v1_00F) (20100206)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\G2F Slideshow (Demo) (v1_00F) (20100206).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\G2F Slideshow (Demo) (v1_00F) (20100206).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\G2F Slideshow (Demo) (v1_00F) (20100206).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\G2F Slideshow (Demo) (v1_00F) (20100206).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Alien Death 1 Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Alien Death 1 Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Alien Death 1 Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Alien Death 1 Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Alien Death 1 Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Alien Death 1 Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Alien Death 1 Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Alien Death 1 Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Alien Death 1 Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Alien Death 1 Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Alien Death 1 Sound 16bit (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Alien Death 1 Sound 16bit (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Alien Death 1 Sound 16bit (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Alien Death 1 Sound 16bit (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Alien Death 1 Sound 16bit (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Alien Death 1 Sound 16bit (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Alien Death 1 Sound 16bit (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Alien Death 1 Sound 16bit (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Alien Death 1 Sound 16bit (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Alien Death 1 Sound 16bit (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Alien Death 2 Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Alien Death 2 Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Alien Death 2 Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Alien Death 2 Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Alien Death 2 Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Alien Death 2 Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Alien Death 2 Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Alien Death 2 Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Alien Death 2 Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Alien Death 2 Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Alien Death 2 Sound 16bit (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Alien Death 2 Sound 16bit (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Alien Death 2 Sound 16bit (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Alien Death 2 Sound 16bit (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Alien Death 2 Sound 16bit (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Alien Death 2 Sound 16bit (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Alien Death 2 Sound 16bit (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Alien Death 2 Sound 16bit (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Alien Death 2 Sound 16bit (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Alien Death 2 Sound 16bit (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Alien Death 2a Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Alien Death 2a Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Alien Death 2a Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Alien Death 2a Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Alien Death 2a Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Alien Death 2a Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Alien Death 2a Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Alien Death 2a Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Alien Death 2a Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Alien Death 2a Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Coin Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Coin Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Coin Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Coin Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Coin Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Coin Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Coin Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Coin Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Coin Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Coin Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Endswoop Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Endswoop Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Endswoop Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Endswoop Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Endswoop Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Endswoop Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Endswoop Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Endswoop Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Endswoop Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Endswoop Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Explosion Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Explosion Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Explosion Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Explosion Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Explosion Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Explosion Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Explosion Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Explosion Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Explosion Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Explosion Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Extra Life Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Extra Life Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Extra Life Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Extra Life Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Extra Life Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Extra Life Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Extra Life Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Extra Life Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Extra Life Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Extra Life Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 1a Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 1a Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 1a Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 1a Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 1a Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 1a Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 1a Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 1a Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 1a Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 1a Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 2a Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 2a Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 2a Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 2a Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 2a Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 2a Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 2a Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 2a Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 2a Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 2a Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 3a Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 3a Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 3a Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 3a Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 3a Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 3a Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 3a Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 3a Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 3a Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 3a Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 4a Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 4a Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 4a Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 4a Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 4a Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 4a Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 4a Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 4a Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 4a Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 4a Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 5a Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 5a Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 5a Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 5a Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 5a Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 5a Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 5a Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 5a Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 5a Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 5a Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 6a Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 6a Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 6a Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 6a Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 6a Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Hum 6a Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Hum 6a Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Hum 6a Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Hum 6a Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Hum 6a Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Shot Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Shot Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Shot Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Shot Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Shot Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Shot Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Shot Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Shot Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Shot Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Shot Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Start Sound (POKEY 450) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Start Sound (POKEY 450) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Start Sound (POKEY 450) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Start Sound (POKEY 450) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Start Sound (POKEY 450) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Start Sound (POKEY 4000) (20210118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Start Sound (POKEY 4000) (20210118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Start Sound (POKEY 4000) (20210118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Start Sound (POKEY 4000) (20210118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Start Sound (POKEY 4000) (20210118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Swoop Sound (POKEY 450) (20210119)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Swoop Sound (POKEY 450) (20210119).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Swoop Sound (POKEY 450) (20210119).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Swoop Sound (POKEY 450) (20210119).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Swoop Sound (POKEY 450) (20210119).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Galaxian Swoop Sound (POKEY 4000) (20210119)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaxian Swoop Sound (POKEY 4000) (20210119).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaxian Swoop Sound (POKEY 4000) (20210119).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaxian Swoop Sound (POKEY 4000) (20210119).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaxian Swoop Sound (POKEY 4000) (20210119).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Gary Denise Music Demo (POKEY 450) (20210123)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Gary Denise Music Demo (POKEY 450) (20210123).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Gary Denise Music Demo (POKEY 450) (20210123).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Gary Denise Music Demo (POKEY 450) (20210123).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Gary Denise Music Demo (POKEY 450) (20210123).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Ghosts'n Goblins (320B PlotMapFile Title Demo) (20170821)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ghosts'n Goblins (320B PlotMapFile Title Demo) (20170821).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ghosts'n Goblins (320B PlotMapFile Title Demo) (20170821).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ghosts'n Goblins (320B PlotMapFile Title Demo) (20170821).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ghosts'n Goblins (320B PlotMapFile Title Demo) (20170821).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "GODS Title Demo (20200809)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\GODS Title Demo (20200809).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\GODS Title Demo (20200809).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\GODS Title Demo (20200809).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\GODS Title Demo (20200809).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Good Dino (Multicolor 160B Plus Mode Demo) (20210221)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Good Dino (Multicolor 160B Plus Mode Demo) (20210221).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Good Dino (Multicolor 160B Plus Mode Demo) (20210221).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Good Dino (Multicolor 160B Plus Mode Demo) (20210221).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Good Dino (Multicolor 160B Plus Mode Demo) (20210221).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Graphics Demo 1 (20181222)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Graphics Demo 1 (20181222).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Graphics Demo 1 (20181222).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Graphics Demo 1 (20181222).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Graphics Demo 1 (20181222).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Gravity Demo (v1.78b) (20210811)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Gravity Demo (v1.78b) (20210811).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Gravity Demo (v1.78b) (20210811).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Gravity Demo (v1.78b) (20210811).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Gravity Demo (v1.78b) (20210811).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Gridrunner Engine Demo (20210625)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Gridrunner Engine Demo (20210625).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Gridrunner Engine Demo (20210625).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Gridrunner Engine Demo (20210625).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Gridrunner Engine Demo (20210625).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Hallo (POKEY Music Demo) (20130612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hallo (POKEY Music Demo) (20130612).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hallo (POKEY Music Demo) (20130612).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hallo (POKEY Music Demo) (20130612).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hallo (POKEY Music Demo) (20130612).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Happy Halloween (Demo) (20071031)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Happy Halloween (Demo) (20071031).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Happy Halloween (Demo) (20071031).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Happy Halloween (Demo) (20071031).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Happy Halloween (Demo) (20071031).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Happy Halloween (No Year) (Demo) (20120812)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Happy Halloween (No Year) (Demo) (20120812).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Happy Halloween (No Year) (Demo) (20120812).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Happy Halloween (No Year) (Demo) (20120812).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Happy Halloween (No Year) (Demo) (20120812).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Hello World (Demo) (20091107)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hello World (Demo) (20091107).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hello World (Demo) (20091107).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hello World (Demo) (20091107).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hello World (Demo) (20091107).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Hello World (MADS Version) (20210416)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hello World (MADS Version) (20210416).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hello World (MADS Version) (20210416).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hello World (MADS Version) (20210416).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hello World (MADS Version) (20210416).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Heofonfir (Title Screen Demo) (20210327)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Heofonfir (Title Screen Demo) (20210327).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Heofonfir (Title Screen Demo) (20210327).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Heofonfir (Title Screen Demo) (20210327).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Heofonfir (Title Screen Demo) (20210327).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Heofonfir (Vertical Shooter Demo) (20220609)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Heofonfir (Vertical Shooter Demo) (20220609).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Heofonfir (Vertical Shooter Demo) (20220609).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Heofonfir (Vertical Shooter Demo) (20220609).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Heofonfir (Vertical Shooter Demo) (20220609).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Horizontal Shooting Demo (20210630)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Horizontal Shooting Demo (20210630).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Horizontal Shooting Demo (20210630).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Horizontal Shooting Demo (20210630).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Horizontal Shooting Demo (20210630).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "HunterS (Picture Demo) (20170121)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\HunterS (Picture Demo) (20170121).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\HunterS (Picture Demo) (20170121).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\HunterS (Picture Demo) (20170121).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\HunterS (Picture Demo) (20170121).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Ice Climber (320B PMF Demo Screen) (20170823)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ice Climber (320B PMF Demo Screen) (20170823).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ice Climber (320B PMF Demo Screen) (20170823).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ice Climber (320B PMF Demo Screen) (20170823).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ice Climber (320B PMF Demo Screen) (20170823).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Ikari Warriors Title Demo (20200809)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ikari Warriors Title Demo (20200809).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ikari Warriors Title Demo (20200809).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ikari Warriors Title Demo (20200809).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ikari Warriors Title Demo (20200809).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "INXS (320B PlotMapFile Title Demo) (20170821)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\INXS (320B PlotMapFile Title Demo) (20170821).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\INXS (320B PlotMapFile Title Demo) (20170821).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\INXS (320B PlotMapFile Title Demo) (20170821).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\INXS (320B PlotMapFile Title Demo) (20170821).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "It's Conner Time (20220626)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\It's Conner Time (20220626).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\It's Conner Time (20220626).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\It's Conner Time (20220626).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\It's Conner Time (20220626).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Journey to the West (20190303)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Journey to the West (20190303).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Journey to the West (20190303).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Journey to the West (20190303).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Journey to the West (20190303).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Kid Icarus (Screen Image) (20190220)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kid Icarus (Screen Image) (20190220).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kid Icarus (Screen Image) (20190220).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kid Icarus (Screen Image) (20190220).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kid Icarus (Screen Image) (20190220).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Kung-Fu Master - End Stage Sound Demo (450) (20200729)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master - End Stage Sound Demo (450) (20200729).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master - End Stage Sound Demo (450) (20200729).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master - End Stage Sound Demo (450) (20200729).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master - End Stage Sound Demo (450) (20200729).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Kung-Fu Master - End Stage Sound Demo (4000) (20200729)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master - End Stage Sound Demo (4000) (20200729).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master - End Stage Sound Demo (4000) (20200729).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master - End Stage Sound Demo (4000) (20200729).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master - End Stage Sound Demo (4000) (20200729).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Kung-Fu Master - Game Complete Sound Demo (450) (20200729)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master - Game Complete Sound Demo (450) (20200729).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master - Game Complete Sound Demo (450) (20200729).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master - Game Complete Sound Demo (450) (20200729).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master - Game Complete Sound Demo (450) (20200729).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Kung-Fu Master - Game Complete Sound Demo (4000) (20200729)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master - Game Complete Sound Demo (4000) (20200729).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master - Game Complete Sound Demo (4000) (20200729).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master - Game Complete Sound Demo (4000) (20200729).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master - Game Complete Sound Demo (4000) (20200729).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Kung-Fu Master - Game Over Sound Demo (450) (20200702)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master - Game Over Sound Demo (450) (20200702).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master - Game Over Sound Demo (450) (20200702).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master - Game Over Sound Demo (450) (20200702).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master - Game Over Sound Demo (450) (20200702).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Kung-Fu Master - Game Over Sound Demo (4000) (20200702)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master - Game Over Sound Demo (4000) (20200702).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master - Game Over Sound Demo (4000) (20200702).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master - Game Over Sound Demo (4000) (20200702).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master - Game Over Sound Demo (4000) (20200702).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Kung-Fu Master - Intro Sound Demo (450) (20200702)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master - Intro Sound Demo (450) (20200702).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master - Intro Sound Demo (450) (20200702).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master - Intro Sound Demo (450) (20200702).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master - Intro Sound Demo (450) (20200702).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Kung-Fu Master - Intro Sound Demo (4000) (20200702)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master - Intro Sound Demo (4000) (20200702).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master - Intro Sound Demo (4000) (20200702).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master - Intro Sound Demo (4000) (20200702).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master - Intro Sound Demo (4000) (20200702).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Kung-Fu Master - Main Theme Sound Demo (450) (20200731)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master - Main Theme Sound Demo (450) (20200731).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master - Main Theme Sound Demo (450) (20200731).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master - Main Theme Sound Demo (450) (20200731).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master - Main Theme Sound Demo (450) (20200731).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Kung-Fu Master - Main Theme Sound Demo (4000) (20200731)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master - Main Theme Sound Demo (4000) (20200731).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master - Main Theme Sound Demo (4000) (20200731).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu Master - Main Theme Sound Demo (4000) (20200731).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu Master - Main Theme Sound Demo (4000) (20200731).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Lattice Blaster (20210923)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Lattice Blaster (20210923).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Lattice Blaster (20210923).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Lattice Blaster (20210923).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Lattice Blaster (20210923).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Lava Demo (20201004)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Lava Demo (20201004).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Lava Demo (20201004).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Lava Demo (20201004).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Lava Demo (20201004).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Lenny Kravitz - Fly Away (NTSC) (YM2151) (20211109)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Lenny Kravitz - Fly Away (NTSC) (YM2151) (20211109).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Lenny Kravitz - Fly Away (NTSC) (YM2151) (20211109).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Lenny Kravitz - Fly Away (NTSC) (YM2151) (20211109).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Lenny Kravitz - Fly Away (NTSC) (YM2151) (20211109).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Lenny Kravitz - Fly Away (PAL) (YM2151) (20211109)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Lenny Kravitz - Fly Away (PAL) (YM2151) (20211109).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Lenny Kravitz - Fly Away (PAL) (YM2151) (20211109).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Lenny Kravitz - Fly Away (PAL) (YM2151) (20211109).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Lenny Kravitz - Fly Away (PAL) (YM2151) (20211109).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "LSD Lizard (Multicolor 160B Plus Mode Demo) (20210215)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\LSD Lizard (Multicolor 160B Plus Mode Demo) (20210215).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\LSD Lizard (Multicolor 160B Plus Mode Demo) (20210215).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\LSD Lizard (Multicolor 160B Plus Mode Demo) (20210215).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\LSD Lizard (Multicolor 160B Plus Mode Demo) (20210215).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Lucelia Movement Demo (20210820)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Lucelia Movement Demo (20210820).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Lucelia Movement Demo (20210820).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Lucelia Movement Demo (20210820).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Lucelia Movement Demo (20210820).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mappy - Death (Sound Demo) (20140416)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mappy - Death (Sound Demo) (20140416).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mappy - Death (Sound Demo) (20140416).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mappy - Death (Sound Demo) (20140416).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mappy - Death (Sound Demo) (20140416).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mappy - Game Over (Sound Demo) (20140416)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mappy - Game Over (Sound Demo) (20140416).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mappy - Game Over (Sound Demo) (20140416).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mappy - Game Over (Sound Demo) (20140416).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mappy - Game Over (Sound Demo) (20140416).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mappy - Melody (Sound Demo) (20160412)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mappy - Melody (Sound Demo) (20160412).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mappy - Melody (Sound Demo) (20160412).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mappy - Melody (Sound Demo) (20160412).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mappy - Melody (Sound Demo) (20160412).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Maria Bug (20210401)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Maria Bug (20210401).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Maria Bug (20210401).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Maria Bug (20210401).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Maria Bug (20210401).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Coin Bonus (4000) (20210326)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Coin Bonus (4000) (20210326).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Coin Bonus (4000) (20210326).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Coin Bonus (4000) (20210326).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Coin Bonus (4000) (20210326).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Coin Count (450) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Coin Count (450) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Coin Count (450) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Coin Count (450) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Coin Count (450) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Coin Drop (4000) (20210312)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Coin Drop (4000) (20210312).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Coin Drop (4000) (20210312).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Coin Drop (4000) (20210312).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Coin Drop (4000) (20210312).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Coin Grab (450) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Coin Grab (450) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Coin Grab (450) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Coin Grab (450) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Coin Grab (450) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Coin Timer (450) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Coin Timer (450) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Coin Timer (450) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Coin Timer (450) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Coin Timer (450) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Crab Drop (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Crab Drop (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Crab Drop (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Crab Drop (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Crab Drop (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Death (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Death (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Death (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Death (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Death (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Extra Life (4000) (20210312)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Extra Life (4000) (20210312).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Extra Life (4000) (20210312).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Extra Life (4000) (20210312).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Extra Life (4000) (20210312).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Fireball (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Fireball (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Fireball (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Fireball (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Fireball (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Fireball (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Fireball (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Fireball (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Fireball (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Fireball (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Fireball Vanish (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Fireball Vanish (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Fireball Vanish (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Fireball Vanish (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Fireball Vanish (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Flip Enemy (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Flip Enemy (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Flip Enemy (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Flip Enemy (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Flip Enemy (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Fly Drop (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Fly Drop (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Fly Drop (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Fly Drop (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Fly Drop (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Game Over (4000) (20210322)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Game Over (4000) (20210322).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Game Over (4000) (20210322).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Game Over (4000) (20210322).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Game Over (4000) (20210322).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Hit Enemy (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Hit Enemy (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Hit Enemy (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Hit Enemy (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Hit Enemy (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Ice Freeze (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Ice Freeze (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Ice Freeze (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Ice Freeze (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Ice Freeze (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Icicle Drop (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Icicle Drop (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Icicle Drop (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Jump (4000) (20210312).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Jump (4000) (20210312).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Kick (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Kick (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Kick (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Kick (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Kick (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Kick Final (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Kick Final (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Kick Final (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Kick Final (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Kick Final (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Level Start (4000) (20210322)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Level Start (4000) (20210322).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Level Start (4000) (20210322).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Level Start (4000) (20210322).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Level Start (4000) (20210322).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Life Restart (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Life Restart (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Life Restart (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Life Restart (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Life Restart (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - POW Block (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - POW Block (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - POW Block (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - POW Block (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - POW Block (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Second Intermission (4000) (20210322)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Second Intermission (4000) (20210322).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Second Intermission (4000) (20210322).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Second Intermission (4000) (20210322).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Second Intermission (4000) (20210322).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Shell Creeper Intro (4000) (20210322)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Shell Creeper Intro (4000) (20210322).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Shell Creeper Intro (4000) (20210322).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Shell Creeper Intro (4000) (20210322).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Shell Creeper Intro (4000) (20210322).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Slipice Emerge (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Slipice Emerge (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Slipice Emerge (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Slipice Emerge (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Slipice Emerge (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Splash (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Splash (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Splash (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Splash (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Splash (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Stop (4000) (20210312)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Stop (4000) (20210312).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Stop (4000) (20210312).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Stop (4000) (20210312).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Stop (4000) (20210312).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Title (4000) (20210322)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Title (4000) (20210322).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Title (4000) (20210322).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Title (4000) (20210322).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Title (4000) (20210322).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Turtle Drop (4000) (20210325)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Turtle Drop (4000) (20210325).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Turtle Drop (4000) (20210325).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Turtle Drop (4000) (20210325).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Turtle Drop (4000) (20210325).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Walk 1 (4000) (20210312)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Walk 1 (4000) (20210312).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Walk 1 (4000) (20210312).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Walk 1 (4000) (20210312).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Walk 1 (4000) (20210312).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros - Walk 2 (4000) (20210312)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros - Walk 2 (4000) (20210312).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros - Walk 2 (4000) (20210312).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros - Walk 2 (4000) (20210312).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros - Walk 2 (4000) (20210312).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mario Bros (Ice Stress Test) (20210315)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros (Ice Stress Test) (20210315).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros (Ice Stress Test) (20210315).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario Bros (Ice Stress Test) (20210315).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario Bros (Ice Stress Test) (20210315).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mayhem in Monsterland (Scroll Demo) (20210117)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mayhem in Monsterland (Scroll Demo) (20210117).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mayhem in Monsterland (Scroll Demo) (20210117).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mayhem in Monsterland (Scroll Demo) (20210117).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mayhem in Monsterland (Scroll Demo) (20210117).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Maze Generator (20170831)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Maze Generator (20170831).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Maze Generator (20170831).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Maze Generator (20170831).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Maze Generator (20170831).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mega Man 2 (Start Level Music Demo) (450) (20190819)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mega Man 2 (Start Level Music Demo) (450) (20190819).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mega Man 2 (Start Level Music Demo) (450) (20190819).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mega Man 2 (Start Level Music Demo) (450) (20190819).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mega Man 2 (Start Level Music Demo) (450) (20190819).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mega Man 2 (Start Level Music Demo) (4000) (20190730)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mega Man 2 (Start Level Music Demo) (4000) (20190730).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mega Man 2 (Start Level Music Demo) (4000) (20190730).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mega Man 2 (Start Level Music Demo) (4000) (20190730).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mega Man 2 (Start Level Music Demo) (4000) (20190730).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Merry Christmas 2012 e-card (v1_10F) (20121227)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Merry Christmas 2012 e-card (v1_10F) (20121227).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Merry Christmas 2012 e-card (v1_10F) (20121227).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Merry Christmas 2012 e-card (v1_10F) (20121227).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Merry Christmas 2012 e-card (v1_10F) (20121227).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Metroid Brinstar Theme (Bass and Percussion) (4000) (20201123)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Metroid Brinstar Theme (Bass and Percussion) (4000) (20201123).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Metroid Brinstar Theme (Bass and Percussion) (4000) (20201123).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Metroid Brinstar Theme (Bass and Percussion) (4000) (20201123).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Metroid Brinstar Theme (Bass and Percussion) (4000) (20201123).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Metroid Brinstar Theme (Lead and Harmony) (4000) (20201123)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Metroid Brinstar Theme (Lead and Harmony) (4000) (20201123).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Metroid Brinstar Theme (Lead and Harmony) (4000) (20201123).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Metroid Brinstar Theme (Lead and Harmony) (4000) (20201123).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Metroid Brinstar Theme (Lead and Harmony) (4000) (20201123).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Metroid Krayt Lair (Bass Lead) (450) (20201129)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Metroid Krayt Lair (Bass Lead) (450) (20201129).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Metroid Krayt Lair (Bass Lead) (450) (20201129).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Metroid Krayt Lair (Bass Lead) (450) (20201129).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Metroid Krayt Lair (Bass Lead) (450) (20201129).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Metroid Krayt Lair (Bass Lead) (4000) (20201129)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Metroid Krayt Lair (Bass Lead) (4000) (20201129).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Metroid Krayt Lair (Bass Lead) (4000) (20201129).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Metroid Krayt Lair (Bass Lead) (4000) (20201129).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Metroid Krayt Lair (Bass Lead) (4000) (20201129).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Metroid Krayt Lair (Filtered Lead) (450) (20201129)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Metroid Krayt Lair (Filtered Lead) (450) (20201129).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Metroid Krayt Lair (Filtered Lead) (450) (20201129).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Metroid Krayt Lair (Filtered Lead) (450) (20201129).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Metroid Krayt Lair (Filtered Lead) (450) (20201129).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Metroid Krayt Lair (Filtered Lead) (4000) (20201129)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Metroid Krayt Lair (Filtered Lead) (4000) (20201129).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Metroid Krayt Lair (Filtered Lead) (4000) (20201129).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Metroid Krayt Lair (Filtered Lead) (4000) (20201129).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Metroid Krayt Lair (Filtered Lead) (4000) (20201129).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Millipede (Snapshot) (20171101)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Millipede (Snapshot) (20171101).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Millipede (Snapshot) (20171101).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Millipede (Snapshot) (20171101).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Millipede (Snapshot) (20171101).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mister Purple Pants (Demo) (20091107)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mister Purple Pants (Demo) (20091107).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mister Purple Pants (Demo) (20091107).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mister Purple Pants (Demo) (20091107).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mister Purple Pants (Demo) (20091107).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Moon Patrol Background (Scroll Demo) (20080920)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Moon Patrol Background (Scroll Demo) (20080920).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Moon Patrol Background (Scroll Demo) (20080920).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Moon Patrol Background (Scroll Demo) (20080920).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Moon Patrol Background (Scroll Demo) (20080920).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Mr Do (20210824)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mr Do (20210824).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mr Do (20210824).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mr Do (20210824).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mr Do (20210824).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Multicolor RPG (Test) (20210130)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Multicolor RPG (Test) (20210130).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Multicolor RPG (Test) (20210130).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Multicolor RPG (Test) (20210130).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Multicolor RPG (Test) (20210130).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Multi-Lock On (20140311)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Multi-Lock On (20140311).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Multi-Lock On (20140311).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Multi-Lock On (20140311).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Multi-Lock On (20140311).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Multi-Sprite (Sample) (20140318)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Multi-Sprite (Sample) (20140318).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Multi-Sprite (Sample) (20140318).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Multi-Sprite (Sample) (20140318).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Multi-Sprite (Sample) (20140318).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Multisprite Generator (20220522)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Multisprite Generator (20220522).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Multisprite Generator (20220522).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Multisprite Generator (20220522).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Multisprite Generator (20220522).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Neverending Story, The (Full) (YM2151 Demo) (20211130)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Neverending Story, The (Full) (YM2151 Demo) (20211130).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Neverending Story, The (Full) (YM2151 Demo) (20211130).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Neverending Story, The (Full) (YM2151 Demo) (20211130).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Neverending Story, The (Full) (YM2151 Demo) (20211130).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Neverending Story, The (Short Music Demo) (YM2151) (20211129)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Neverending Story, The (Short Music Demo) (YM2151) (20211129).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Neverending Story, The (Short Music Demo) (YM2151) (20211129).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Neverending Story, The (Short Music Demo) (YM2151) (20211129).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Neverending Story, The (Short Music Demo) (YM2151) (20211129).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Nyan Cat! (20111230)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Nyan Cat! (20111230).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Nyan Cat! (20111230).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Nyan Cat! (20111230).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Nyan Cat! (20111230).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Occlude Sprite Demo (20200219)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Occlude Sprite Demo (20200219).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Occlude Sprite Demo (20200219).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Occlude Sprite Demo (20200219).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Occlude Sprite Demo (20200219).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Omega Race Ship (Demo) (20150927)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Omega Race Ship (Demo) (20150927).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Omega Race Ship (Demo) (20150927).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Omega Race Ship (Demo) (20150927).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Omega Race Ship (Demo) (20150927).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "One Hundred And One (Sprite Demo) (20200408)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\One Hundred And One (Sprite Demo) (20200408).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\One Hundred And One (Sprite Demo) (20200408).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\One Hundred And One (Sprite Demo) (20200408).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\One Hundred And One (Sprite Demo) (20200408).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "One Zak And His Kracken (Multicolor 160B Plus Mode Demo) (20210214)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\One Zak And His Kracken (Multicolor 160B Plus Mode Demo) (20210214).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\One Zak And His Kracken (Multicolor 160B Plus Mode Demo) (20210214).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\One Zak And His Kracken (Multicolor 160B Plus Mode Demo) (20210214).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\One Zak And His Kracken (Multicolor 160B Plus Mode Demo) (20210214).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Opmeridian (YM2151 Demo) (20211201)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Opmeridian (YM2151 Demo) (20211201).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Opmeridian (YM2151 Demo) (20211201).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Opmeridian (YM2151 Demo) (20211201).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Opmeridian (YM2151 Demo) (20211201).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Outer Rim (320B Demo) (20180510)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Outer Rim (320B Demo) (20180510).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Outer Rim (320B Demo) (20180510).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Outer Rim (320B Demo) (20180510).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Outer Rim (320B Demo) (20180510).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "OutRun - Last Wave (No Waves) (YM2151 Demo) (PAL) 20211106" Then
            If System.IO.File.Exists(strBoxArtFolder & "\OutRun - Last Wave (No Waves) (YM2151 Demo) (PAL) 20211106.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\OutRun - Last Wave (No Waves) (YM2151 Demo) (PAL) 20211106.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\OutRun - Last Wave (No Waves) (YM2151 Demo) (PAL) 20211106.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\OutRun - Last Wave (No Waves) (YM2151 Demo) (PAL) 20211106.htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "OutRun (Dual POKEY 440 450 Demo) (20221017)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\OutRun (Dual POKEY 440 450 Demo) (20221017).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\OutRun (Dual POKEY 440 450 Demo) (20221017).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\OutRun (Dual POKEY 440 450 Demo) (20221017).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\OutRun (Dual POKEY 440 450 Demo) (20221017).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "OutRun 2 (Dual POKEY 440 450 Demo) (20210117)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\OutRun 2 (Dual POKEY 440 450 Demo) (20210117).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\OutRun 2 (Dual POKEY 440 450 Demo) (20210117).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\OutRun 2 (Dual POKEY 440 450 Demo) (20210117).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\OutRun 2 (Dual POKEY 440 450 Demo) (20210117).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "OutRun 3 (Dual POKEY 440 450 Demo) (20210117)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\OutRun 3 (Dual POKEY 440 450 Demo) (20210117).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\OutRun 3 (Dual POKEY 440 450 Demo) (20210117).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\OutRun 3 (Dual POKEY 440 450 Demo) (20210117).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\OutRun 3 (Dual POKEY 440 450 Demo) (20210117).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Break Time Tune (450) (20191011)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Break Time Tune (450) (20191011).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Break Time Tune (450) (20191011).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Break Time Tune (450) (20191011).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Break Time Tune (450) (20191011).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Break Time Tune (4000) (20191011)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Break Time Tune (4000) (20191011).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Break Time Tune (4000) (20191011).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Break Time Tune (4000) (20191011).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Break Time Tune (4000) (20191011).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Castle Theme (450) (20191023)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Castle Theme (450) (20191023).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Castle Theme (450) (20191023).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Castle Theme (450) (20191023).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Castle Theme (450) (20191023).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Castle Theme (4000) (20191023)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Castle Theme (4000) (20191023).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Castle Theme (4000) (20191023).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Castle Theme (4000) (20191023).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Castle Theme (4000) (20191023).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Death Tune (450) (20191005)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Death Tune (450) (20191005).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Death Tune (450) (20191005).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Death Tune (450) (20191005).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Death Tune (450) (20191005).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Death Tune (4000) (20191005)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Death Tune (4000) (20191005).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Death Tune (4000) (20191005).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Death Tune (4000) (20191005).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Death Tune (4000) (20191005).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Fairyland Melody (450) (20191005)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Fairyland Melody (450) (20191005).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Fairyland Melody (450) (20191005).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Fairyland Melody (450) (20191005).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Fairyland Melody (450) (20191005).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Fairyland Melody (4000) (20191005)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Fairyland Melody (4000) (20191005).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Fairyland Melody (4000) (20191005).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Fairyland Melody (4000) (20191005).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Fairyland Melody (4000) (20191005).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Intro Melody (450) (20191005)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Intro Melody (450) (20191005).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Intro Melody (450) (20191005).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Intro Melody (450) (20191005).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Intro Melody (450) (20191005).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Intro Melody (4000) (20191005)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Intro Melody (4000) (20191005).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Intro Melody (4000) (20191005).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Intro Melody (4000) (20191005).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Intro Melody (4000) (20191005).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Main Theme Music (450) (20191004)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Main Theme Music (450) (20191004).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Main Theme Music (450) (20191004).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Main Theme Music (450) (20191004).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Main Theme Music (450) (20191004).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Land Main Theme Music (4000) (20191004)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Land Main Theme Music (4000) (20191004).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Land Main Theme Music (4000) (20191004).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Land Main Theme Music (4000) (20191004).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Land Main Theme Music (4000) (20191004).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Pac-Man (YM Sound Test) (v14) (20140825)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man (YM Sound Test) (v14) (20140825).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man (YM Sound Test) (v14) (20140825).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man (YM Sound Test) (v14) (20140825).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man (YM Sound Test) (v14) (20140825).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Palette Test - Pseudo 3D Flying Effect (20220219)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Palette Test - Pseudo 3D Flying Effect (20220219).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Palette Test - Pseudo 3D Flying Effect (20220219).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Palette Test - Pseudo 3D Flying Effect (20220219).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Palette Test - Pseudo 3D Flying Effect (20220219).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Parallax Scroll Demo 160B Mode (20210131)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Parallax Scroll Demo 160B Mode (20210131).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Parallax Scroll Demo 160B Mode (20210131).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Parallax Scroll Demo 160B Mode (20210131).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Parallax Scroll Demo 160B Mode (20210131).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Plasma Demo (20200818)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Plasma Demo (20200818).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Plasma Demo (20200818).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Plasma Demo (20200818).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Plasma Demo (20200818).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Plasma Demo (X-Only) (20200819)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Plasma Demo (X-Only) (20200819).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Plasma Demo (X-Only) (20200819).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Plasma Demo (X-Only) (20200819).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Plasma Demo (X-Only) (20200819).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Plasma Demo (Y-Only) (20200819)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Plasma Demo (Y-Only) (20200819).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Plasma Demo (Y-Only) (20200819).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Plasma Demo (Y-Only) (20200819).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Plasma Demo (Y-Only) (20200819).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Platformer Demo (v01_78b) (20210318)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Platformer Demo (v01_78b) (20210318).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Platformer Demo (v01_78b) (20210318).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Platformer Demo (v01_78b) (20210318).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Platformer Demo (v01_78b) (20210318).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Plumber Buddies (Rough Demo) (20210314)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Plumber Buddies (Rough Demo) (20210314).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Plumber Buddies (Rough Demo) (20210314).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Plumber Buddies (Rough Demo) (20210314).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Plumber Buddies (Rough Demo) (20210314).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Popcorn (Dual POKEY 440 450 Demo) (20210117)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Popcorn (Dual POKEY 440 450 Demo) (20210117).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Popcorn (Dual POKEY 440 450 Demo) (20210117).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Popcorn (Dual POKEY 440 450 Demo) (20210117).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Popcorn (Dual POKEY 440 450 Demo) (20210117).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Price Randomization Test (20170811)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Price Randomization Test (20170811).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Price Randomization Test (20170811).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Price Randomization Test (20170811).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Price Randomization Test (20170811).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Prince Of Persia Title Music (450) (20200407)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Prince Of Persia Title Music (450) (20200407).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Prince Of Persia Title Music (450) (20200407).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Prince Of Persia Title Music (450) (20200407).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Prince Of Persia Title Music (450) (20200407).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Prince Of Persia Title Music (4000) (20200407)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Prince Of Persia Title Music (4000) (20200407).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Prince Of Persia Title Music (4000) (20200407).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Prince Of Persia Title Music (4000) (20200407).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Prince Of Persia Title Music (4000) (20200407).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Punch-Out!! (Demo) (20141218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Punch-Out!! (Demo) (20141218).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Punch-Out!! (Demo) (20141218).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Punch-Out!! (Demo) (20141218).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Punch-Out!! (Demo) (20141218).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Qix Sound Demo (v2) (TIATracker Player) (20200410)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Qix Sound Demo (v2) (TIATracker Player) (20200410).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Qix Sound Demo (v2) (TIATracker Player) (20200410).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Qix Sound Demo (v2) (TIATracker Player) (20200410).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Qix Sound Demo (v2) (TIATracker Player) (20200410).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Raindrops (QuadTari Demo) (v2) (20210304)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Raindrops (QuadTari Demo) (v2) (20210304).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Raindrops (QuadTari Demo) (v2) (20210304).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Raindrops (QuadTari Demo) (v2) (20210304).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Raindrops (QuadTari Demo) (v2) (20210304).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Ray Future 2203 (YM2151 Demo) (20211130)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ray Future 2203 (YM2151 Demo) (20211130).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ray Future 2203 (YM2151 Demo) (20211130).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ray Future 2203 (YM2151 Demo) (20211130).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ray Future 2203 (YM2151 Demo) (20211130).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Ray Future 2203 (YM2151 Demo) (PAL) (20211202)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ray Future 2203 (YM2151 Demo) (PAL) (20211202).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ray Future 2203 (YM2151 Demo) (PAL) (20211202).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ray Future 2203 (YM2151 Demo) (PAL) (20211202).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ray Future 2203 (YM2151 Demo) (PAL) (20211202).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "RMT POKEY Player Test (Demo) (20030326)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RMT POKEY Player Test (Demo) (20030326).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RMT POKEY Player Test (Demo) (20030326).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\RMT POKEY Player Test (Demo) (20030326).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\RMT POKEY Player Test (Demo) (20030326).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Rolling Thunder (Intro Melody) (450) (20190914)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rolling Thunder (Intro Melody) (450) (20190914).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rolling Thunder (Intro Melody) (450) (20190914).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rolling Thunder (Intro Melody) (450) (20190914).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rolling Thunder (Intro Melody) (450) (20190914).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "RPG Player and Map Tiles (Demo) (20190518)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RPG Player and Map Tiles (Demo) (20190518).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RPG Player and Map Tiles (Demo) (20190518).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\RPG Player and Map Tiles (Demo) (20190518).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\RPG Player and Map Tiles (Demo) (20190518).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "RPG Tile Demo (20170930)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RPG Tile Demo (20170930).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RPG Tile Demo (20170930).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\RPG Tile Demo (20170930).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\RPG Tile Demo (20170930).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "SD Tunnel (Demo) (20211019)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\SD Tunnel (Demo) (20211019).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\SD Tunnel (Demo) (20211019).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\SD Tunnel (Demo) (20211019).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\SD Tunnel (Demo) (20211019).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Senso 7800 DX (20011118)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Senso 7800 DX (20011118).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Senso 7800 DX (20011118).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Senso 7800 DX (20011118).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Senso 7800 DX (20011118).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Sexy Six (Music Demo) (NTSC) (YM2151) (20211109)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sexy Six (Music Demo) (NTSC) (YM2151) (20211109).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sexy Six (Music Demo) (NTSC) (YM2151) (20211109).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sexy Six (Music Demo) (NTSC) (YM2151) (20211109).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sexy Six (Music Demo) (NTSC) (YM2151) (20211109).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Sexy Six (Music Demo) (PAL) (YM2151) (20211109)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sexy Six (Music Demo) (PAL) (YM2151) (20211109).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sexy Six (Music Demo) (PAL) (YM2151) (20211109).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sexy Six (Music Demo) (PAL) (YM2151) (20211109).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sexy Six (Music Demo) (PAL) (YM2151) (20211109).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Sexy Six (YM2151 & Covox Demo) (PAL) (20211128)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sexy Six (YM2151 & Covox Demo) (PAL) (20211128).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sexy Six (YM2151 & Covox Demo) (PAL) (20211128).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sexy Six (YM2151 & Covox Demo) (PAL) (20211128).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sexy Six (YM2151 & Covox Demo) (PAL) (20211128).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Shadow Of The Beast - Title Sceen Demo (20201210)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Shadow Of The Beast - Title Sceen Demo (20201210).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Shadow Of The Beast - Title Sceen Demo (20201210).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Shadow Of The Beast - Title Sceen Demo (20201210).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Shadow Of The Beast - Title Sceen Demo (20201210).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Shadow Of The Beast (Tech Demo) (20220523)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Shadow Of The Beast (Tech Demo) (20220523).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Shadow Of The Beast (Tech Demo) (20220523).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Shadow Of The Beast (Tech Demo) (20220523).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Shadow Of The Beast (Tech Demo) (20220523).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Shantae Tiles (PlotMap) (20160626)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Shantae Tiles (PlotMap) (20160626).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Shantae Tiles (PlotMap) (20160626).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Shantae Tiles (PlotMap) (20160626).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Shantae Tiles (PlotMap) (20160626).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Silent Colony (YM2151 Demo) (20211130)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Silent Colony (YM2151 Demo) (20211130).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Silent Colony (YM2151 Demo) (20211130).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Silent Colony (YM2151 Demo) (20211130).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Silent Colony (YM2151 Demo) (20211130).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Silent Colony (YM2151 Demo) (PAL) (20211130)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Silent Colony (YM2151 Demo) (PAL) (20211130).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Silent Colony (YM2151 Demo) (PAL) (20211130).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Silent Colony (YM2151 Demo) (PAL) (20211130).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Silent Colony (YM2151 Demo) (PAL) (20211130).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Simple (Sample) (20140301)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Simple (Sample) (20140301).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Simple (Sample) (20140301).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Simple (Sample) (20140301).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Simple (Sample) (20140301).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Slots (20141221)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Slots (20141221).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Slots (20141221).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Slots (20141221).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Slots (20141221).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "SMB 2 Screen (PlotMap) (20171003)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\SMB 2 Screen (PlotMap) (20171003).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\SMB 2 Screen (PlotMap) (20171003).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\SMB 2 Screen (PlotMap) (20171003).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\SMB 2 Screen (PlotMap) (20171003).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "SMB Screen (PlotMap) (20160626)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\SMB Screen (PlotMap) (20160626).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\SMB Screen (PlotMap) (20160626).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\SMB Screen (PlotMap) (20160626).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\SMB Screen (PlotMap) (20160626).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Soft Cell - Tainted Love (Music Demo) (20140311)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Soft Cell - Tainted Love (Music Demo) (20140311).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Soft Cell - Tainted Love (Music Demo) (20140311).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Soft Cell - Tainted Love (Music Demo) (20140311).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Soft Cell - Tainted Love (Music Demo) (20140311).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Space Manbow (Music Demo) (YM2151) (20211129)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Manbow (Music Demo) (YM2151) (20211129).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Manbow (Music Demo) (YM2151) (20211129).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space Manbow (Music Demo) (YM2151) (20211129).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space Manbow (Music Demo) (YM2151) (20211129).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Space Physics Sample (20200215)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Physics Sample (20200215).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Physics Sample (20200215).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space Physics Sample (20200215).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space Physics Sample (20200215).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Split Mode (Demo) (20150107)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Split Mode (Demo) (20150107).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Split Mode (Demo) (20150107).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Split Mode (Demo) (20150107).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Split Mode (Demo) (20150107).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Sprite Decompression (20220610)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sprite Decompression (20220610).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sprite Decompression (20220610).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sprite Decompression (20220610).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sprite Decompression (20220610).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Sprite Demo (20040117)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sprite Demo (20040117).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sprite Demo (20040117).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sprite Demo (20040117).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sprite Demo (20040117).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Sprite Demo 2 (20040117)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sprite Demo 2 (20040117).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sprite Demo 2 (20040117).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sprite Demo 2 (20040117).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sprite Demo 2 (20040117).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Sprite Engine Test (20210319)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sprite Engine Test (20210319).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sprite Engine Test (20210319).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sprite Engine Test (20210319).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sprite Engine Test (20210319).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Sprite Engine Test 2 (20210320)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sprite Engine Test 2 (20210320).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sprite Engine Test 2 (20210320).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sprite Engine Test 2 (20210320).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sprite Engine Test 2 (20210320).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Steam Ponny (Multicolor 160B Plus Mode Demo) (20210221)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Steam Ponny (Multicolor 160B Plus Mode Demo) (20210221).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Steam Ponny (Multicolor 160B Plus Mode Demo) (20210221).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Steam Ponny (Multicolor 160B Plus Mode Demo) (20210221).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Steam Ponny (Multicolor 160B Plus Mode Demo) (20210221).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Stickerbrush Symphony Music Demo (450) (20200326)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Stickerbrush Symphony Music Demo (450) (20200326).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Stickerbrush Symphony Music Demo (450) (20200326).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Stickerbrush Symphony Music Demo (450) (20200326).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Stickerbrush Symphony Music Demo (450) (20200326).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Stickerbrush Symphony Music Demo (4000) (20200326)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Stickerbrush Symphony Music Demo (4000) (20200326).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Stickerbrush Symphony Music Demo (4000) (20200326).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Stickerbrush Symphony Music Demo (4000) (20200326).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Stickerbrush Symphony Music Demo (4000) (20200326).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Stickerbrush Symphony Music Demo (4000) (20200326)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Stickerbrush Symphony Music Demo (4000) (20200326).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Stickerbrush Symphony Music Demo (4000) (20200326).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Stickerbrush Symphony Music Demo (4000) (20200326).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Stickerbrush Symphony Music Demo (4000) (20200326).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Stickerbush Huffmunch (Music Demo) (YM2151) (PAL) (20211129)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Stickerbush Huffmunch (Music Demo) (YM2151) (PAL) (20211129).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Stickerbush Huffmunch (Music Demo) (YM2151) (PAL) (20211129).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Stickerbush Huffmunch (Music Demo) (YM2151) (PAL) (20211129).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Stickerbush Huffmunch (Music Demo) (YM2151) (PAL) (20211129).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Stickerbush Symphony (Music Demo) (YM2151) (PAL) (20211129)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Stickerbush Symphony (Music Demo) (YM2151) (PAL) (20211129).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Stickerbush Symphony (Music Demo) (YM2151) (PAL) (20211129).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Stickerbush Symphony (Music Demo) (YM2151) (PAL) (20211129).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Stickerbush Symphony (Music Demo) (YM2151) (PAL) (20211129).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Stickerbush Symphony (Music Demo) (YM2151) (PAL) (20211129)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Stickerbush Symphony (Music Demo) (YM2151) (PAL) (20211129).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Stickerbush Symphony (Music Demo) (YM2151) (PAL) (20211129).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Stickerbush Symphony (Music Demo) (YM2151) (PAL) (20211129).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Stickerbush Symphony (Music Demo) (YM2151) (PAL) (20211129).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Stranger Things Main Theme Music (450) (20191023)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Stranger Things Main Theme Music (450) (20191023).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Stranger Things Main Theme Music (450) (20191023).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Stranger Things Main Theme Music (450) (20191023).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Stranger Things Main Theme Music (450) (20191023).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Stranger Things Main Theme Music (4000) (20191023)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Stranger Things Main Theme Music (4000) (20191023).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Stranger Things Main Theme Music (4000) (20191023).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Stranger Things Main Theme Music (4000) (20191023).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Stranger Things Main Theme Music (4000) (20191023).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Stranger Things Upside Down Theme Music (450) (20191023)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Stranger Things Upside Down Theme Music (450) (20191023).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Stranger Things Upside Down Theme Music (450) (20191023).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Stranger Things Upside Down Theme Music (450) (20191023).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Stranger Things Upside Down Theme Music (450) (20191023).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Stranger Things Upside Down Theme Music (4000) (20191023)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Stranger Things Upside Down Theme Music (4000) (20191023).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Stranger Things Upside Down Theme Music (4000) (20191023).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Stranger Things Upside Down Theme Music (4000) (20191023).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Stranger Things Upside Down Theme Music (4000) (20191023).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Styverson (Picture Demo) (20170126)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Styverson (Picture Demo) (20170126).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Styverson (Picture Demo) (20170126).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Styverson (Picture Demo) (20170126).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Styverson (Picture Demo) (20170126).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Super IRG Flipping Images Demo (20171120)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super IRG Flipping Images Demo (20171120).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super IRG Flipping Images Demo (20171120).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super IRG Flipping Images Demo (20171120).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super IRG Flipping Images Demo (20171120).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Super Mario World Opening Melody (450) (20190815)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Mario World Opening Melody (450) (20190815).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Mario World Opening Melody (450) (20190815).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Mario World Opening Melody (450) (20190815).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Mario World Opening Melody (450) (20190815).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Super Mario World Opening Melody (4000) (20190815)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Mario World Opening Melody (4000) (20190815).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Mario World Opening Melody (4000) (20190815).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Mario World Opening Melody (4000) (20190815).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Mario World Opening Melody (4000) (20190815).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Super Mario World Overworld Theme (450) (20190917)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Mario World Overworld Theme (450) (20190917).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Mario World Overworld Theme (450) (20190917).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Mario World Overworld Theme (450) (20190917).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Mario World Overworld Theme (450) (20190917).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Super Mario World Overworld Theme (4000) (20190917)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Mario World Overworld Theme (4000) (20190917).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Mario World Overworld Theme (4000) (20190917).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super Mario World Overworld Theme (4000) (20190917).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super Mario World Overworld Theme (4000) (20190917).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Suspiciously Shifty Demo (20190830)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Suspiciously Shifty Demo (20190830).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Suspiciously Shifty Demo (20190830).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Suspiciously Shifty Demo (20190830).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Suspiciously Shifty Demo (20190830).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Text Incrementer Demo (20210310)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Text Incrementer Demo (20210310).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Text Incrementer Demo (20210310).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Text Incrementer Demo (20210310).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Text Incrementer Demo (20210310).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Thermostat Music Demo (POKEY 450) (20210123)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Thermostat Music Demo (POKEY 450) (20210123).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Thermostat Music Demo (POKEY 450) (20210123).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Thermostat Music Demo (POKEY 450) (20210123).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Thermostat Music Demo (POKEY 450) (20210123).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "TIA Music Demo dbAS (20190106)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\TIA Music Demo dbAS (20190106).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\TIA Music Demo dbAS (20190106).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\TIA Music Demo dbAS (20190106).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\TIA Music Demo dbAS (20190106).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Toki (Single Screen Background Demo) (20190304)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Toki (Single Screen Background Demo) (20190304).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Toki (Single Screen Background Demo) (20190304).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Toki (Single Screen Background Demo) (20190304).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Toki (Single Screen Background Demo) (20190304).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Top Gun - Danger Zone Demo (450) (20200612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Top Gun - Danger Zone Demo (450) (20200612).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Top Gun - Danger Zone Demo (450) (20200612).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Top Gun - Danger Zone Demo (450) (20200612).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Top Gun - Danger Zone Demo (450) (20200612).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Top Gun - Danger Zone Demo (4000) (20200612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Top Gun - Danger Zone Demo (4000) (20200612).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Top Gun - Danger Zone Demo (4000) (20200612).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Top Gun - Danger Zone Demo (4000) (20200612).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Top Gun - Danger Zone Demo (4000) (20200612).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Track & Field (Demo) (20210814)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Track & Field (Demo) (20210814).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Track & Field (Demo) (20210814).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Track & Field (Demo) (20210814).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Track & Field (Demo) (20210814).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Truchet Tiling (Demo) (20170827)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Truchet Tiling (Demo) (20170827).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Truchet Tiling (Demo) (20170827).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Truchet Tiling (Demo) (20170827).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Truchet Tiling (Demo) (20170827).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Turrican II Circular Scroll Test (20211213)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Turrican II Circular Scroll Test (20211213).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Turrican II Circular Scroll Test (20211213).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Turrican II Circular Scroll Test (20211213).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Turrican II Circular Scroll Test (20211213).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Two Modes (Demo) (20220221)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Two Modes (Demo) (20220221).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Two Modes (Demo) (20220221).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Two Modes (Demo) (20220221).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Two Modes (Demo) (20220221).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "UN Squadron - Cave (YM2151 Demo) (NTSC) (20211107)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\UN Squadron - Cave (YM2151 Demo) (NTSC) (20211107).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\UN Squadron - Cave (YM2151 Demo) (NTSC) (20211107).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\UN Squadron - Cave (YM2151 Demo) (NTSC) (20211107).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\UN Squadron - Cave (YM2151 Demo) (NTSC) (20211107).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "UN Squadron - Cave (YM2151 Demo) (PAL) (20211031u1)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\UN Squadron - Cave (YM2151 Demo) (PAL) (20211031u1).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\UN Squadron - Cave (YM2151 Demo) (PAL) (20211031u1).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\UN Squadron - Cave (YM2151 Demo) (PAL) (20211031u1).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\UN Squadron - Cave (YM2151 Demo) (PAL) (20211031u1).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Under The Hood (Demo) (20200530)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Under The Hood (Demo) (20200530).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Under The Hood (Demo) (20200530).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Under The Hood (Demo) (20200530).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Under The Hood (Demo) (20200530).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Untum Intro (PAL) (20181228)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Untum Intro (PAL) (20181228).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Untum Intro (PAL) (20181228).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Untum Intro (PAL) (20181228).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Untum Intro (PAL) (20181228).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "VGM Player - Ground (YM2151) (20220218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\VGM Player - Ground (YM2151) (20220218).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\VGM Player - Ground (YM2151) (20220218).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\VGM Player - Ground (YM2151) (20220218).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\VGM Player - Ground (YM2151) (20220218).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Visage - Mind Of A Toy (20140104)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Visage - Mind Of A Toy (20140104).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Visage - Mind Of A Toy (20140104).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Visage - Mind Of A Toy (20140104).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Visage - Mind Of A Toy (20140104).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Walker - Tech Demo (20210321)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Walker - Tech Demo (20210321).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Walker - Tech Demo (20210321).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Walker - Tech Demo (20210321).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Walker - Tech Demo (20210321).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Waterfall (Demo) (20211019)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Waterfall (Demo) (20211019).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Waterfall (Demo) (20211019).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Waterfall (Demo) (20211019).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Waterfall (Demo) (20211019).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "We Robots (Demo) (20210225)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\We Robots (Demo) (20210225).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\We Robots (Demo) (20210225).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\We Robots (Demo) (20210225).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\We Robots (Demo) (20210225).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "White Lamp (Dual POKEY 440 450 Demo) (20210120)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\White Lamp (Dual POKEY 440 450 Demo) (20210120).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\White Lamp (Dual POKEY 440 450 Demo) (20210120).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\White Lamp (Dual POKEY 440 450 Demo) (20210120).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\White Lamp (Dual POKEY 440 450 Demo) (20210120).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Wizzy (20220317)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Wizzy (20220317).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Wizzy (20220317).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Wizzy (20220317).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Wizzy (20220317).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Wonder Boy III - Side-Crawler's Dance (YM2151 Demo) (PAL) (20211031)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Wonder Boy III - Side-Crawler's Dance (YM2151 Demo) (PAL) (20211031).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Wonder Boy III - Side-Crawler's Dance (YM2151 Demo) (PAL) (20211031).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Wonder Boy III - Side-Crawler's Dance (YM2151 Demo) (PAL) (20211031).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Wonder Boy III - Side-Crawler's Dance (YM2151 Demo) (PAL) (20211031).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Wonderland (Multicolor 160B Plus Mode Demo) (20210220)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Wonderland (Multicolor 160B Plus Mode Demo) (20210220).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Wonderland (Multicolor 160B Plus Mode Demo) (20210220).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Wonderland (Multicolor 160B Plus Mode Demo) (20210220).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Wonderland (Multicolor 160B Plus Mode Demo) (20210220).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Wond'ring Aloud (Covox Demo) (Main Loop) (20210327)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Wond'ring Aloud (Covox Demo) (Main Loop) (20210327).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Wond'ring Aloud (Covox Demo) (Main Loop) (20210327).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Wond'ring Aloud (Covox Demo) (Main Loop) (20210327).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Wond'ring Aloud (Covox Demo) (Main Loop) (20210327).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Wond'ring Aloud (Covox Demo) (Via IRQ) (20210329)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Wond'ring Aloud (Covox Demo) (Via IRQ) (20210329).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Wond'ring Aloud (Covox Demo) (Via IRQ) (20210329).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Wond'ring Aloud (Covox Demo) (Via IRQ) (20210329).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Wond'ring Aloud (Covox Demo) (Via IRQ) (20210329).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Wormy Demo (320B Mode) (20070415)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Wormy Demo (320B Mode) (20070415).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Wormy Demo (320B Mode) (20070415).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Wormy Demo (320B Mode) (20070415).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Wormy Demo (320B Mode) (20070415).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "XMYM Tracker - Ghosts'n Goblins Stages 1 and 2 (20220224)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\XMYM Tracker - Ghosts'n Goblins Stages 1 and 2 (20220224).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\XMYM Tracker - Ghosts'n Goblins Stages 1 and 2 (20220224).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\XMYM Tracker - Ghosts'n Goblins Stages 1 and 2 (20220224).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\XMYM Tracker - Ghosts'n Goblins Stages 1 and 2 (20220224).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "XMYM Tracker - Side-Crawler's Dance (20200223)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\XMYM Tracker - Side-Crawler's Dance (20200223).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\XMYM Tracker - Side-Crawler's Dance (20200223).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\XMYM Tracker - Side-Crawler's Dance (20200223).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\XMYM Tracker - Side-Crawler's Dance (20200223).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "XMYM Tracker - Zanac (20200221)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\XMYM Tracker - Zanac (20200221).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\XMYM Tracker - Zanac (20200221).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\XMYM Tracker - Zanac (20200221).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\XMYM Tracker - Zanac (20200221).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Ye Olde Inn (Music Demo) (YM2151) (20211129)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ye Olde Inn (Music Demo) (YM2151) (20211129).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ye Olde Inn (Music Demo) (YM2151) (20211129).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ye Olde Inn (Music Demo) (YM2151) (20211129).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ye Olde Inn (Music Demo) (YM2151) (20211129).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Yoomp (Demo) (NTSC) (20211218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Yoomp (Demo) (NTSC) (20211218).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Yoomp (Demo) (NTSC) (20211218).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Yoomp (Demo) (NTSC) (20211218).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Yoomp (Demo) (NTSC) (20211218).htm"))
            End If
        End If


        If lstDemos.SelectedItem.ToString = "Yoomp (Demo) (PAL) (20211218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Yoomp (Demo) (PAL) (20211218).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Yoomp (Demo) (PAL) (20211218).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Yoomp (Demo) (PAL) (20211218).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Yoomp (Demo) (PAL) (20211218).htm"))
            End If
        End If


        If lstDemos.SelectedItem.ToString = "Yoomp Multiplayer (Demo) (PAL) (20211219)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Yoomp Multiplayer (Demo) (PAL) (20211219).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Yoomp Multiplayer (Demo) (PAL) (20211219).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Yoomp Multiplayer (Demo) (PAL) (20211219).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Yoomp Multiplayer (Demo) (PAL) (20211219).htm"))
            End If
        End If


        If lstDemos.SelectedItem.ToString = "Zanac Area 1 and 2 Demo Music (v1) (450) (20190915)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Zanac Area 1 and 2 Demo Music (v1) (450) (20190915).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Zanac Area 1 and 2 Demo Music (v1) (450) (20190915).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Zanac Area 1 and 2 Demo Music (v1) (450) (20190915).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Zanac Area 1 and 2 Demo Music (v1) (450) (20190915).htm"))
            End If
        End If


        If lstDemos.SelectedItem.ToString = "Zanac Area 1 and 2 Demo Music (v1) (4000) (20190915)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Zanac Area 1 and 2 Demo Music (v1) (4000) (20190915).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Zanac Area 1 and 2 Demo Music (v1) (4000) (20190915).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Zanac Area 1 and 2 Demo Music (v1) (4000) (20190915).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Zanac Area 1 and 2 Demo Music (v1) (4000) (20190915).htm"))
            End If
        End If


        If lstDemos.SelectedItem.ToString = "Zanac Area 1 and 2 Demo Music (v2) (450) (20190915)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Zanac Area 1 and 2 Demo Music (v2) (450) (20190915).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Zanac Area 1 and 2 Demo Music (v2) (450) (20190915).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Zanac Area 1 and 2 Demo Music (v2) (450) (20190915).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Zanac Area 1 and 2 Demo Music (v2) (450) (20190915).htm"))
            End If
        End If


        If lstDemos.SelectedItem.ToString = "Zanac Theme Music Demo (450) (20200805)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Zanac Theme Music Demo (450) (20200805).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Zanac Theme Music Demo (450) (20200805).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Zanac Theme Music Demo (450) (20200805).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Zanac Theme Music Demo (450) (20200805).htm"))
            End If
        End If


        If lstDemos.SelectedItem.ToString = "Zanac Theme Music Demo (4000) (20200805)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Zanac Theme Music Demo (4000) (20200805).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Zanac Theme Music Demo (4000) (20200805).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Zanac Theme Music Demo (4000) (20200805).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Zanac Theme Music Demo (4000) (20200805).htm"))
            End If
        End If


        If lstDemos.SelectedItem.ToString = "Zanaz Area 1 and 2 Demo Music (v2) (4000) (20190915)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Zanaz Area 1 and 2 Demo Music (v2) (4000) (20190915).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Zanaz Area 1 and 2 Demo Music (v2) (4000) (20190915).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Zanaz Area 1 and 2 Demo Music (v2) (4000) (20190915).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Zanaz Area 1 and 2 Demo Music (v2) (4000) (20190915).htm"))
            End If
        End If

        If lstDemos.SelectedItem.ToString = "Zelda-like (Demo) (20091107)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Zelda-like (Demo) (20091107).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Zelda-like (Demo) (20091107).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Zelda-like (Demo) (20091107).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Zelda-like (Demo) (20091107).htm"))
            End If
        End If


    End Sub

    Private Sub lstProtos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProtos.SelectedIndexChanged

        'Update Game Info HTML Editor
        txtHTMLEditor.Clear()
        strFileName = "\" + lstProtos.Text + ".htm"
        txtEditorFile.Text = strManualsFolder + strFileName
        Try
            For Each s As String In System.IO.File.ReadAllLines(txtEditorFile.Text)
                txtHTMLEditor.AppendText(s + vbNewLine)
            Next
        Catch ex As Exception
        End Try

        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtProtosPath.Text + "\" + lstProtos.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch
        If lstProtos.SelectedItem.ToString = "Plutos (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Plutos (USA) (Proto).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Plutos (USA) (Proto).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Plutos (Prototype).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Plutos (Prototype).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Sirius (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sirius (USA) (Proto).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sirius (USA) (Proto).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sirius (Prototype).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sirius (Prototype).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "AtariLab - Light Module (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\AtariLab - Light Module (Prototype).png") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\AtariLab - Light Module (Prototype).png")
            End If
            If System.IO.File.Exists(strManualsFolder & "\AtariLab - Light Module (Prototype).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\AtariLab - Light Module (Prototype).htm"))
            End If
        End If


        If lstProtos.SelectedItem.ToString = "AtariLab - Temperature Module (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\AtariLab - Temperature (Prototype).png") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\AtariLab - Temperature (Prototype).png")
            End If
            If System.IO.File.Exists(strManualsFolder & "\AtariLab - Temperature Module (Prototype).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\AtariLab - Temperature Module (Prototype).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Klax (19xx)(Atari)(NTSC)(Prototype)(Fixed)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Klax (USA) (Proto).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Klax (USA) (Proto).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Klax (19xx)(Atari)(NTSC)(Prototype)(Fixed).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Klax (19xx)(Atari)(NTSC)(Prototype)(Fixed).htm"))
            End If
        End If


        If lstProtos.SelectedItem.ToString = "Sentinel (NTSC) (Finished Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sentinel (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sentinel (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sentinel (NTSC) (Finished Prototype).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sentinel (NTSC) (Finished Prototype).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Sentinel (PAL) (Atari) (1991)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sentinel (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sentinel (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sentinel (PAL) (Atari) (1991).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sentinel (PAL) (Atari) (1991).htm"))
            End If
        End If



        If lstProtos.SelectedItem.ToString = "Desert Falcon (Prototype) (NTSC)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Desert Falcon (Prototype) (NTSC).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Desert Falcon (Prototype) (NTSC).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Desert Falcon (Prototype) (NTSC).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Desert Falcon (Prototype) (NTSC).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "GATO (198x) (Atari) (Prototype) (Alt 1)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\GATO (198x) (Atari) (Prototype) (Alt 1).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\GATO (198x) (Atari) (Prototype) (Alt 1).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\GATO (198x) (Atari) (Prototype) (Alt 1).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\GATO (198x) (Atari) (Prototype) (Alt 1).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "GATO (198x) (Atari) (Prototype) (Alt 2)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\GATO (198x) (Atari) (Prototype) (Alt 2).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\GATO (198x) (Atari) (Prototype) (Alt 2).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\GATO (198x) (Atari) (Prototype) (Alt 2).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\GATO (198x) (Atari) (Prototype) (Alt 2).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Missing In Action (TNT Games) (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Missing In Action (TNT Games) (Prototype).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Missing In Action (TNT Games) (Prototype).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Missing In Action (TNT Games) (Prototype).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Missing In Action (TNT Games) (Prototype).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Pit Fighter (1992) (Atari) (Prototype) (Alt 1)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pit Fighter (1992) (Atari) (Prototype) (Alt 1).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pit Fighter (1992) (Atari) (Prototype) (Alt 1).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pit Fighter (1992) (Atari) (Prototype) (Alt 1).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pit Fighter (1992) (Atari) (Prototype) (Alt 1).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Pit Fighter (1992) (Atari) (Prototype) (Alt 2)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pit Fighter (1992) (Atari) (Prototype) (Alt 2).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pit Fighter (1992) (Atari) (Prototype) (Alt 2).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pit Fighter (1992) (Atari) (Prototype) (Alt 2).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pit Fighter (1992) (Atari) (Prototype) (Alt 2).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Pit Fighter (1992) (Atari) (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pit Fighter (1992) (Atari) (Prototype).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pit Fighter (1992) (Atari) (Prototype).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pit Fighter (1992) (Atari) (Prototype).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pit Fighter (1992) (Atari) (Prototype).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Rescue On Fractalus (Prototype) (Correct Header)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rescue On Fractalus (Prototype) (Correct Header).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rescue On Fractalus (Prototype) (Correct Header).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rescue On Fractalus (Prototype) (Correct Header).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rescue On Fractalus (Prototype) (Correct Header).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Rescue On Fractalus (Prototype) (Correct Header)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rescue On Fractalus (Prototype) (Correct Header).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rescue On Fractalus (Prototype) (Correct Header).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rescue On Fractalus (Prototype) (Correct Header).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rescue On Fractalus (Prototype) (Correct Header).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Rescue On Fractalus (Prototype) (Correct Header)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rescue On Fractalus (Prototype) (Correct Header).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rescue On Fractalus (Prototype) (Correct Header).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rescue On Fractalus (Prototype) (Correct Header).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rescue On Fractalus (Prototype) (Correct Header).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Impossible Mission (Prototype) (NTSC) (8-11-89)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (Prototype) (NTSC) (8-11-89).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (Prototype) (NTSC) (8-11-89).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible Mission (Prototype) (NTSC) (8-11-89).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible Mission (Prototype) (NTSC) (8-11-89).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Galaga (Prototype) (NTSC) (Rev 1) (1984)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga (Prototype) (NTSC) (Rev 1) (1984).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga (Prototype) (NTSC) (Rev 1) (1984).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga (Prototype) (NTSC) (Rev 1) (1984).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga (Prototype) (NTSC) (Rev 1) (1984).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Pole Position II (Prototype) (NTSC) (Rev 1) (1984)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Position II (Prototype) (NTSC) (Rev 1) (1984).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Position II (Prototype) (NTSC) (Rev 1) (1984).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole Position II (Prototype) (NTSC) (Rev 1) (1984).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole Position II (Prototype) (NTSC) (Rev 1) (1984).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Ms Pac-Man (Prototype) (NTSC) (Rev 1) (1984)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms Pac-Man (Prototype) (NTSC) (Rev 1) (1984).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms Pac-Man (Prototype) (NTSC) (Rev 1) (1984).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms Pac-Man (Prototype) (NTSC) (Rev 1) (1984).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms Pac-Man (Prototype) (NTSC) (Rev 1) (1984).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Rampart (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rampart (Prototype).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rampart (Prototype).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rampart (Prototype).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rampart (Prototype).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Robotron 2084 (Prototype) (NTSC) (Rev 1) (1984)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robotron 2084 (Prototype) (NTSC) (Rev 1) (1984).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robotron 2084 (Prototype) (NTSC) (Rev 1) (1984).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robotron 2084 (Prototype) (NTSC) (Rev 1) (1984).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robotron 2084 (Prototype) (NTSC) (Rev 1) (1984).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Star Typer (6-02-84) (Bad Dump) (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Star Typer (6-02-84) (Bad Dump) (Prototype).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Star Typer (6-02-84) (Bad Dump) (Prototype).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Star Typer (6-02-84) (Bad Dump) (Prototype).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Star Typer (6-02-84) (Bad Dump) (Prototype).htm"))
            End If
        End If

        If lstProtos.SelectedItem.ToString = "Star Typer (6-28-84) (Bad Dump) (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Star Typer (6-28-84) (Bad Dump) (Prototype).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Star Typer (6-28-84) (Bad Dump) (Prototype).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Star Typer (6-28-84) (Bad Dump) (Prototype).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Star Typer (6-28-84) (Bad Dump) (Prototype).htm"))
            End If
        End If

    End Sub

    Private Sub lstUtilities_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUtilities.SelectedIndexChanged

        'Update Game Info HTML Editor
        txtHTMLEditor.Clear()
        strFileName = "\" + lstUtilities.Text + ".htm"
        txtEditorFile.Text = strManualsFolder + strFileName
        Try
            For Each s As String In System.IO.File.ReadAllLines(txtEditorFile.Text)
                txtHTMLEditor.AppendText(s + vbNewLine)
            Next
        Catch ex As Exception
        End Try

        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + txtUtilitiesPath.Text + "\" + lstUtilities.Text + ".a78""" + " " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        If lstUtilities.SelectedItem.ToString = "24bit Value Comparison (20170811)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\24bit Value Comparison (20170811).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\24bit Value Comparison (20170811).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\24bit Value Comparison (20170811).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\24bit Value Comparison (20170811).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "320D Font Test (20190705)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\320D Font Test (20190705).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\320D Font Test (20190705).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\320D Font Test (20190705).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\320D Font Test (20190705).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "320D Font Test 2 (20190705)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\320D Font Test 2 (20190705).png") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\320D Font Test 2 (20190705).png")
            End If
            If System.IO.File.Exists(strManualsFolder & "\320D Font Test 2 (20190705).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\320D Font Test 2 (20190705).htm"))
            End If
        End If


        If lstUtilities.SelectedItem.ToString = "320D Interlace Test (20190704)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\320D Interlace Test (20190704).png") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\320D Interlace Test (20190704).png")
            End If
            If System.IO.File.Exists(strManualsFolder & "\320D Interlace Test (20190704).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\320D Interlace Test (20190704).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "7800 Test (NTSC) (20140406)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\7800 Test (NTSC) (20140406).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\7800 Test (NTSC) (20140406).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\7800 Test (NTSC) (20140406).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\7800 Test (NTSC) (20140406).htm"))
            End If
        End If


        If lstUtilities.SelectedItem.ToString = "7800 Test (PAL) (20140406)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\7800 Test (PAL) (20140406).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\7800 Test (PAL) (20140406).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\7800 Test (PAL) (20140406).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\7800 Test (PAL) (20140406).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "7800 Utility Cart (20161210)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\7800 Utility Cart (20161210).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\7800 Utility Cart (20161210).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\7800 Utility Cart (20161210).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\7800 Utility Cart (20161210).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "AtariVox Speech Test (20151021)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\AtariVox Speech Test (20151021).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\AtariVox Speech Test (20151021).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\AtariVox Speech Test (20151021).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\AtariVox Speech Test (20151021).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "AtariVox Test (20180915)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\AtariVox Test (20180915).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\AtariVox Test (20180915).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\AtariVox Test (20180915).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\AtariVox Test (20180915).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Color (Demo) (20091107)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Color (Demo) (20091107).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Color (Demo) (20091107).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Color (Demo) (20091107).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Color (Demo) (20091107).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Color Bars Selector Demo (1984)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Color Bars Selector Demo (1984).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Color Bars Selector Demo (1984).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Color Bars Selector Demo (1984).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Color Bars Selector Demo (1984).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Color Grid (20030527)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Color Grid (20030527).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Color Grid (20030527).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Color Grid (20030527).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Color Grid (20030527).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Colour Picker (v1_00F)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Colour Picker (v1_00F).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Colour Picker (v1_00F).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Colour Picker (v1_00F).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Colour Picker (v1_00F).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Detect Emulator (NTSC) (20220626)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Detect Emulator (NTSC) (20220626).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Detect Emulator (NTSC) (20220626).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Detect Emulator (NTSC) (20220626).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Detect Emulator (NTSC) (20220626).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Detect Emulator (PAL) (20220626)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Detect Emulator (PAL) (20220626).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Detect Emulator (PAL) (20220626).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Detect Emulator (PAL) (20220626).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Detect Emulator (PAL) (20220626).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Diagnostic Test Cartridge (19xx) (Atari)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Diagnostic Test Cartridge (19xx) (Atari).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Diagnostic Test Cartridge (19xx) (Atari).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Diagnostic Test Cartridge (19xx) (Atari).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Diagnostic Test Cartridge (19xx) (Atari).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Font Check (20201202)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Font Check (20201202).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Font Check (20201202).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Font Check (20201202).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Font Check (20201202).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Graphics Modes Test (20100914)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Graphics Modes Test (20100914).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Graphics Modes Test (20100914).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Graphics Modes Test (20100914).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Graphics Modes Test (20100914).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Keypad Controller Test (20180623)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Keypad Controller Test (20180623).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Keypad Controller Test (20180623).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Keypad Controller Test (20180623).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Keypad Controller Test (20180623).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Keypad Delay Test (20180914)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Keypad Delay Test (20180914).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Keypad Delay Test (20180914).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Keypad Delay Test (20180914).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Keypad Delay Test (20180914).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Mouse Control Demo" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mouse Control Demo.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mouse Control Demo.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mouse Control Demo.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mouse Control Demo.htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Paddle Test (DLI Sampling) (20050510)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Paddle Test (DLI Sampling) (20050510).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Paddle Test (DLI Sampling) (20050510).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Paddle Test (DLI Sampling) (20050510).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Paddle Test (DLI Sampling) (20050510).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Palette Tool Test 160B (20190714)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Palette Tool Test 160B (20190714).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Palette Tool Test 160B (20190714).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Palette Tool Test 160B (20190714).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Palette Tool Test 160B (20190714).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "POKEY (Sample) (20140301)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\POKEY (Sample) (20140301).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\POKEY (Sample) (20140301).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\POKEY (Sample) (20140301).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\POKEY (Sample) (20140301).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "POKEY Player (450) (20201214)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\POKEY Player (450) (20201214).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\POKEY Player (450) (20201214).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\POKEY Player (450) (20201214).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\POKEY Player (450) (20201214).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "POKEY Test (450) (20200506)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\POKEY Test (450) (20200506).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\POKEY Test (450) (20200506).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\POKEY Test (450) (20200506).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\POKEY Test (450) (20200506).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "POKEY Tester (450) (20220605)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\POKEY Tester (450) (20220605).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\POKEY Tester (450) (20220605).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\POKEY Tester (450) (20220605).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\POKEY Tester (450) (20220605).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "POKEY Tester (Reset Version) (450) (20220606)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\POKEY Tester (Reset Version) (450) (20220606).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\POKEY Tester (Reset Version) (450) (20220606).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\POKEY Tester (Reset Version) (450) (20220606).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\POKEY Tester (Reset Version) (450) (20220606).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Prickle (POKEY Utility) (v09) (20150811)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Prickle (POKEY Utility) (v09) (20150811).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Prickle (POKEY Utility) (v09) (20150811).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Prickle (POKEY Utility) (v09) (20150811).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Prickle (POKEY Utility) (v09) (20150811).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Proline Charge Check (20210227)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Proline Charge Check (20210227).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Proline Charge Check (20210227).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Proline Charge Check (20210227).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Proline Charge Check (20210227).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "RIOT DMA Test (20200816)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RIOT DMA Test (20200816).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RIOT DMA Test (20200816).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\RIOT DMA Test (20200816).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\RIOT DMA Test (20200816).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "" Then
            If System.IO.File.Exists(strBoxArtFolder & "\.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\.htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Rotational Controls Demo" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rotational Controls Demo.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rotational Controls Demo.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rotational Controls Demo.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rotational Controls Demo.htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Save Dev Test (20201206)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Save Dev Test (20201206).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Save Dev Test (20201206).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Save Dev Test (20201206).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Save Dev Test (20201206).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "" Then
            If System.IO.File.Exists(strBoxArtFolder & "\.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\.htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "SaveKey Test (20190214)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\SaveKey Test (20190214).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\SaveKey Test (20190214).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\SaveKey Test (20190214).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\SaveKey Test (20190214).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "SaveKey Test (20190214)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\SaveKey Test (20190214).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\SaveKey Test (20190214).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\SaveKey Test (20190214).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\SaveKey Test (20190214).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Screen Safe (20210312)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Screen Safe (20210312).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Screen Safe (20210312).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Screen Safe (20210312).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Screen Safe (20210312).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Sound Test - TIA SFX Library (20220414)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sound Test - TIA SFX Library (20220414).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sound Test - TIA SFX Library (20220414).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sound Test - TIA SFX Library (20220414).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sound Test - TIA SFX Library (20220414).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Sprite DMA Test (20171208)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sprite DMA Test (20171208).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sprite DMA Test (20171208).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sprite DMA Test (20171208).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sprite DMA Test (20171208).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Sprite Hole DMA (20171208)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sprite Hole DMA (20171208).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sprite Hole DMA (20171208).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sprite Hole DMA (20171208).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sprite Hole DMA (20171208).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Sprite Test - 8 Pixels Zone (160A Mode)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sprite Test - 8 Pixels Zone (160A Mode).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sprite Test - 8 Pixels Zone (160A Mode).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sprite Test - 8 Pixels Zone (160A Mode).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sprite Test - 8 Pixels Zone (160A Mode).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Sprite Test - 8 Pixels Zone (320A Mode)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sprite Test - 8 Pixels Zone (320A Mode).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sprite Test - 8 Pixels Zone (320A Mode).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sprite Test - 8 Pixels Zone (320A Mode).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sprite Test - 8 Pixels Zone (320A Mode).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Sprite Test - 16 Pixels Zone (160A Mode)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sprite Test - 16 Pixels Zone (160A Mode).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sprite Test - 16 Pixels Zone (160A Mode).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sprite Test - 16 Pixels Zone (160A Mode).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sprite Test - 16 Pixels Zone (160A Mode).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Sprite Test - 16 Pixels Zone (320A Mode)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sprite Test - 16 Pixels Zone (320A Mode).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sprite Test - 16 Pixels Zone (320A Mode).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sprite Test - 16 Pixels Zone (320A Mode).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sprite Test - 16 Pixels Zone (320A Mode).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Tinymon 7800 (Memory Tool) (20151218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tinymon 7800 (Memory Tool) (20151218).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tinymon 7800 (Memory Tool) (20151218).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tinymon 7800 (Memory Tool) (20151218).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tinymon 7800 (Memory Tool) (20151218).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Trakball Test (DLI Sampling) (20050510)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Trakball Test (DLI Sampling) (20050510).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Trakball Test (DLI Sampling) (20050510).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Trakball Test (DLI Sampling) (20050510).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Trakball Test (DLI Sampling) (20050510).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "Voxolotl - AtariVox Voice Tracker (20200514)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Voxolotl - AtariVox Voice Tracker (20200514).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Voxolotl - AtariVox Voice Tracker (20200514).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Voxolotl - AtariVox Voice Tracker (20200514).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Voxolotl - AtariVox Voice Tracker (20200514).htm"))
            End If
        End If

        If lstUtilities.SelectedItem.ToString = "WSYNC Demo (20210314)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\WSYNC Demo (20210314).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\WSYNC Demo (20210314).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\WSYNC Demo (20210314).htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\WSYNC Demo (20210314).htm"))
            End If
        End If

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
            strFileName = "\" + lstPALRetail.Text + ".htm"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHomebrews" Then
            strFileName = "\" + lstHomebrews.Text + ".htm"
        End If
        If TabControlRoms.SelectedTab.Name = "tabHacks" Then
            strFileName = "\" + lstHacks.Text + ".htm"
        End If
        If TabControlRoms.SelectedTab.Name = "tabProtos" Then
            strFileName = "\" + lstProtos.Text + ".htm"
        End If
        If TabControlRoms.SelectedTab.Name = "tabDemos" Then
            strFileName = "\" + lstDemos.Text + ".htm"
        End If
        If TabControlRoms.SelectedTab.Name = "tabUtilities" Then
            strFileName = "\" + lstUtilities.Text + ".htm"
        End If
        'strFileName = "\" + lstUtilities.Text + ".htm"
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
            My.Computer.FileSystem.WriteAllText(txtEditorFile.Text, txtHTMLEditor.Text, False)
        Catch
            MessageBox.Show("Error writing file")
        End Try

        MessageBox.Show("Text saved to " & txtEditorFile.Text)


    End Sub

    Private Sub vsyncON_Click(sender As Object, e As EventArgs) Handles vsyncON.Click
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

        strVsync = " -waitvsync"
        stripVsync.Text = "Vsync Wait: On  "
        'statusTripleBuffer.Text = "Video: CRT" 'There is no status bar item for this yet.

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + strFileName + """ " + strDebug + " " + strVideo + strTripleBuffer + strVsync + strA7800WindowMode + strStretch

        vsyncOFF.Checked = True
        vsyncON.Checked = False
    End Sub
End Class