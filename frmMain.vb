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
        If txtBoxArtPath.Text = "C:\" And txtA7800path.Text = "C:\" And txtBoxArtPath.Text = "C:\" And txtManualsPath.Text = "C:\" Then
            frmSetup.ShowDialog()
        End If

        strFolder = My.Computer.Registry.CurrentUser.GetValue("Maximus78 ROM Path")
        strA7800Folder = My.Computer.Registry.CurrentUser.GetValue("Maximus78 A7800 Path")
        strBoxArtFolder = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Box Art Path")
        strManualsFolder = My.Computer.Registry.CurrentUser.GetValue("Maximus78 Manuals Path")
        strArguments = "a7800"
        strAddArguments = "-cart"
        NTSCToolStripMenuItem.Checked = True
        PALToolStripMenuItem.Checked = False

        'If the Then registry entry For the path isn't already set, this code will display a warning msg.
        Try
            Dim a78filesMain = strFolder
            For Each file As String In System.IO.Directory.GetFiles(a78filesMain, "*.a78")
                lstAllGames.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
            Next
        Catch ex As Exception
            'MsgBox("ROM Path has not been set", 64, "Maximus78 Notification")
        End Try

        Try
            pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        Catch ex As Exception
        End Try


    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'frmSettings.Show()
    End Sub

    Private Sub lstAllGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAllGames.SelectedIndexChanged

        'Set Defaults if they're not found
        pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Blank.jpg")
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\blank.htm"))

        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug

        'If System.Windows.Forms.ListBox.SelectedItem = Nothing Then
        '  Exit Sub
        'End If

        'System.NullReferenceException 'Object reference not set to an instance of an object.'
        'System.Windows.Forms.ListBox.SelectedItem.get returned Nothing.

        If lstAllGames.SelectedItem.ToString = "Ace of Aces (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ace of Aces (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ace of Aces (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ace_Of_Aces.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ace_Of_Aces.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Alien Brigade (NTSC) (Joystick) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alien Brigade (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alien Brigade (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alien_Brigade.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien_Brigade.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Alien Brigade (NTSC) (Lightgun) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alien Brigade (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alien Brigade (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alien_Brigade.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien_Brigade.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Armor Attack II (20130416)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Armor Attack II (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Armor Attack II (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Armor_Attack_II.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Armor_Attack_II.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Asteroids Deluxe (NTSC) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids Deluxe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids Deluxe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids_Deluxe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids_Deluxe.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Asteroids Deluxe (PAL) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids Deluxe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids Deluxe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids_Deluxe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids_Deluxe.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Astro Blaster (20140201)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Astro Blaster (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Astro Blaster (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Astro_Blaster.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Astro_Blaster.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Astro Fighter (20150726)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Astro Fighter (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Astro Fighter (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Astro_Fighter.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Astro_Fighter.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Astro Fighter (20150726)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Astro Fighter (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Astro Fighter (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Astro_Fighter.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Astro_Fighter.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Asteroids (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Ballblazer (NTSC) (Atari-Lucasfilm) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ballblazer (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ballblazer (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ballblazer.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ballblazer.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Barnyard Blaster (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Barnyard Blaster (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Barnyard Blaster (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Barnyard_Blaster.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Barnyard_Blaster.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Beef Drop (Final AtariAge)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Beef Drop (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Beef Drop (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Beef_Drop.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Beef_Drop.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Basketbrawl (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Basketbrawl (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Basketbrawl (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Basketbrawl.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Basketbrawl.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "BonQ (Final AtariAge)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\bonQ (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\bonQ (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\BonQ.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\BonQ.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Centipede (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Choplifter (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Choplifter! (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Choplifter! (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Choplifter.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Choplifter.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Commando (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Commando (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Commando (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Commando.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Commando.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Crack'ed (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crack'ed (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crack'ed (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crack'ed.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crack'ed.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Crazy Brix (Joystick) (20160427)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Brix (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Brix (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy_Brix.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy_Brix.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Crazy Brix (Paddle) (20160427)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Brix (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Brix (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy_Brix.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy_Brix.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Crazy Otto (NTSC) (20100612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Otto (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Otto (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy_Otto.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy_Otto.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Crazy Otto (PAL) (20100612)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crazy Otto (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crazy Otto (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crazy_Otto.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crazy_Otto.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Crossbow (NTSC) (Joystick) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Crossbow (NTSC) (Lightgun) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Bentley Bear's Crystal Quest (20151220)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crystal Quest featuring Bentley Bear (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crystal Quest featuring Bentley Bear (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Bentley_Bear's_Crystal_Quest.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Bentley_Bear's_Crystal_Quest.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Dark Chambers (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dark Chambers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dark Chambers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dark_Chambers.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dark_Chambers.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Desert Falcon (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Desert Falcon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Desert Falcon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Desert_Falcon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Desert_Falcon.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Dig Dug (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dig Dug (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dig Dug (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dig_Dug.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dig_Dug.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Donkey Kong (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey_Kong.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey_Kong.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Donkey Kong (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey_Kong.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey_Kong.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Donkey Kong Jr (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong Junior (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong Junior (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey_Kong_Jr.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey_Kong_Jr.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Double Dragon (AB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double_Dragon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double_Dragon.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Double Dragon (OB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double_Dragon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double_Dragon.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Dungeon Stalker (20151022)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dungeon Stalker (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dungeon Stalker (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dungeon_Stalker.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dungeon_Stalker.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "F-18 Hornet (NTSC) (Absolute) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\F-18 Hornet (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\F-18 Hornet (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\F-18_Hornet.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\F-18_Hornet.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "FailSafe (NTSC) (20100227)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\FailSafe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\FailSafe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\FailSafe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\FailSafe.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "FailSafe (PAL) (20100227)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\FailSafe (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\FailSafe (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\FailSafe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\FailSafe.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Fatal Run (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fatal Run (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fatal Run (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fatal_Run.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fatal_Run.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Fight Night (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fight Night (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fight Night (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fight_Night.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fight_Night.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Food Fight (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Food Fight (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Food Fight (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Food_Fight.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Food_Fight.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Frenzy (w-Berzerk) (20211025)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Frenzy (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Frenzy (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Frenzy.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Frenzy.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Froggie (NTSC) (Final Release) (20180920)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Froggie (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Froggie (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Froggie.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Froggie.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Froggie (PAL) (Final Release) (20180920)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Froggie (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Froggie (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Froggie.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Froggie.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Galaga (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Hat Trick (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hat Trick (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hat Trick (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hat_Trick.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hat_Trick.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Ikari Warriors (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ikari Warriors (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ikari Warriors (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ikari_Warriors.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ikari_Warriors.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Impossible Mission (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible_Mission.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible_Mission.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Jinks (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jinks (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jinks (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jinks.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jinks.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Joust (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Jr Pac-Man (NTSC) (20120924)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr. Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr. Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jr_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jr_Pac-Man.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Jr Pac-Man (PAL) (20120924)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jr. Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jr. Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jr_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jr_Pac-Man.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "KC Munchkin (20140408)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\K.C. Munchkin (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\K.C. Munchkin (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\KC_Munchkin.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\KC_Munchkin.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "KC Munchkin (Alt Movement) (20170409)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\K.C. Munchkin (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\K.C. Munchkin (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\KC_Munchkin.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\KC_Munchkin.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Karateka (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Karateka (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Karateka (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Karateka.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Karateka.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Klax (19xx)(Atari)(NTSC)(Prototype)(Fixed)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Klax (USA) (Proto).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Klax (USA) (Proto).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Klax.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Klax.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Kung-Fu Master (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu_Master.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu_Master.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Mario Bros (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros. (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros. (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario_Bros.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario_Bros.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Mat Mania Challenge (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mat Mania Challenge (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mat Mania Challenge (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mat_Mania_Challenge.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mat_Mania_Challenge.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Mean 18 Ultimate Golf (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mean 18 Ultimate Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mean 18 Ultimate Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mean_18.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mean_18.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Meltdown (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meltdown (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meltdown (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meltdown.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meltdown.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Meteor Shower (NTSC) (20120218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meteor Shower (USA) (Unl) [Blue].jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meteor Shower (USA) (Unl) [Blue].jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meteor_Shower.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meteor_Shower.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Meteor Shower (PAL) (20120218)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meteor Shower (USA) (Unl) [Blue].jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meteor Shower (USA) (Unl) [Blue].jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meteor_Shower.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meteor_Shower.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Midnight Mutants (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Midnight Mutants (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Midnight Mutants (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Midnight_Mutants.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Midnight_Mutants.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Moon Cresta (NTSC) (20111113)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Moon Cresta (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Moon Cresta (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Moon_Cresta.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Moon_Cresta.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Moon Cresta (PAL) (20111113)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Moon Cresta (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Moon Cresta (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Moon_Cresta.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Moon_Cresta.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Motor Psycho (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Motor Psycho (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Motor Psycho (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Motor_Psycho.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Motor_Psycho.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Ms Pac-Man (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms_Pac-Man.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Ms Pac-Man 320 (NTSC) (20110808)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms_Pac-Man_320.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms_Pac-Man_320.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Ms Pac-Man 320 (PAL) (20110808)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms_Pac-Man_320.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms_Pac-Man_320.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Ninja Golf (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ninja Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ninja Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ninja_Golf.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ninja_Golf.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "One-on-One Basketball (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\One-on-One Basketball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\One-on-One Basketball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\One-on-One_Basketball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\One-on-One_Basketball.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Pac-Man 320 (NTSC) (20110810)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man_320.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man_320.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Pac-Man 320 (PAL) (20110810)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man 320 (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man 320 (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms_Pac-Man_320.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms_Pac-Man_320.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Pac-Man Collection - 40th Anniversary Edition (20210420)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man_Collection.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man_Collection.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Pac-Man Collection - 40th Anniversary Edition (Short Mazes) (20220530)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man_Collection.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man_Collection.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Pac-Man Collection (20120119)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man_Collection.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man_Collection.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Pac-Man Collection (New Monsters) (20150531)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Man Collection (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Man Collection (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac-Man_Collection.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac-Man_Collection.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Pac Pollux (Hack) (20060305)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pac-Pollux (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pac-Pollux (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pac_Pollux.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pac_Pollux.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Pete Rose Baseball (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pete Rose Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pete Rose Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pete_Rose_Baseball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pete_Rose_Baseball.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Planet Smashers (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Planet Smashers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Planet Smashers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Planet_Smashers.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Planet_Smashers.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Plutos (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Plutos (USA) (Proto).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Plutos (USA) (Proto).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Plutos.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Plutos.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Pole Position II (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Position II (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Position II (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole_Position_II.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole_Position_II.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Rampage (AB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rampage (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rampage (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rampage.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rampage.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Rampage (OB) (NTSC) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rampage (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rampage (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rampage.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rampage.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "RealSports Baseball (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RealSports Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RealSports Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\RealSports_Baseball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\RealSports_Baseball.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Rip-Off (NTSC) (20120502)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Rip-Off (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Rip-Off (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Rip-Off.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Rip-Off.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Robotron 2084 (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robotron - 2084 (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robotron - 2084 (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robotron_2084.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robotron_2084.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Santa Simon (Valid Signature) (20170511)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Santa Simon (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Santa Simon (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Santa_Simon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Santa_Simon.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Scramble (20161202)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scramble (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scramble (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scramble.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scramble.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Scrapyard Dog (NTSC) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard_Dog.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard_Dog.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Sentinel (NTSC) (Finished Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sentinel (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sentinel (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sentinel.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sentinel.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Sentinel (PAL) (Atari) (1991)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sentinel (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sentinel (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sentinel.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sentinel.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Sirius (Prototype)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Sirius (USA) (Proto).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Sirius (USA) (Proto).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Sirius.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Sirius.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Space Duel (NTSC) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Duel (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Duel (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space_Duel.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space_Duel.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Space Duel (PAL) (20071014)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Duel (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Duel (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space_Duel.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space_Duel.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Space Invaders (NTSC) (20080801)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Invaders (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Invaders (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space_Invaders.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space_Invaders.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Space Invaders (PAL) (20080801)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Space Invaders (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Space Invaders (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Space_Invaders.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Space_Invaders.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Summer Games (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Summer Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Summer Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Summer_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Summer_Games.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Joystick) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Joystick) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Paddle) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Circus Atari Age (NTSC) (Paddle) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Joystick) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Joystick) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Paddle) (POKEY 0450) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Circus Atari Age (PAL) (Paddle) (POKEY 4000) (20170611)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Circus (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Circus (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Circus_Atari_Age.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Circus_Atari_Age.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Cobra (Hack) (20120503)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Cobra (USA) (Hack).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Cobra (USA) (Hack).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Cobra.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Cobra.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Huey UH-IX (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Huey UH-IX (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Huey UH-IX (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Huey_UH-IX.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Huey_UH-IX.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Pac-Man (NTSC) (20081010)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Pac-Man.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Pac-Man (PAL) (20081010)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Pac-Man (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Pac-Man (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Pac-Man.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Skateboardin' (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Skateboardin' (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Skateboardin' (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Skateboardin.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Skateboardin.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Tank Command (NTSC) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tank Command (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tank Command (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tank_Command.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tank_Command.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "TiME Salvo (20160910)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Time Salvo (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Time Salvo (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\TiME_Salvo.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\TiME_Salvo.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Title Match Pro Wrestling (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Title Match Pro Wrestling (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Title Match Pro Wrestling (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Title_Match_Pro_Wrestling.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Title_Match_Pro_Wrestling.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Tomcat - The F-14 Fighter Simulator (NTSC) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tomcat - The F-14 Fighter Simulator (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tomcat - The F-14 Fighter Simulator (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\F-14_Tomcat.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\F-14_Tomcat.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Touchdown Football (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Touchdown Football (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Touchdown Football (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Touchdown_Football.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Touchdown_Football.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Tower Toppler (NTSC) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tower Toppler (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tower Toppler (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tower_Toppler.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tower_Toppler.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Wasp! (Standard Edition) (20090923)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Wasp! (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Wasp! (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Wasp.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Wasp.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Water Ski (NTSC) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Water Ski (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Water Ski (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Water_Ski.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Water_Ski.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Winter Games (Alternate) (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Winter_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter_Games.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Winter Games (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Winter_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter_Games.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Worm! (v1_16F) (20100307)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Worm! (USA) (Unl).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Worm! (USA) (Unl).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Worm.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Worm.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Xenophobe (NTSC) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xenophobe (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xenophobe (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xenophobe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xenophobe.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Xevious (NTSC) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xevious (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xevious (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xevious.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xevious.htm"))
            End If
        End If

        'Retail PAL

        If lstAllGames.SelectedItem.ToString = "Ace of Aces (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ace of Aces (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ace of Aces (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ace_of_Aces.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ace_of_Aces.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Alien Brigade (PAL) (Joystick) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alien Brigade (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alien Brigade (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alien_Brigade.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien_Brigade.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Alien Brigade (PAL) (Lightgun) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Alien Brigade (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Alien Brigade (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Alien_Brigade.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Alien_Brigade.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Asteroids (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Asteroids (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Asteroids (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Asteroids.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Asteroids.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Ballblazer (PAL) (Atari-Lucasfilm) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ballblazer (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ballblazer (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ballblazer.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ballblazer.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Barnyard Blaster (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Barnyard Blaster (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Barnyard Blaster (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Barnyard_Blaster.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Barnyard_Blaster.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Basketbrawl (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Basketbrawl (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Basketbrawl (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Basketbrawl.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Basketbrawl.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Centipede (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Centipede (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Centipede (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Centipede.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Centipede.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Choplifter (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Choplifter! (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Choplifter! (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Choplifter.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Choplifter.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Commando (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Commando (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Commando (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Commando.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Commando.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Crack'ed (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crack'ed (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crack'ed (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crack'ed.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crack'ed.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Crossbow (PAL) (Joystick) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Crossbow (PAL) (Lightgun) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Crossbow (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Crossbow (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Crossbow.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Crossbow.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Dark Chambers (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dark Chambers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dark Chambers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dark_Chambers.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dark_Chambers.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Desert Falcon (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Desert Falcon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Desert Falcon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Desert_Falcon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Desert_Falcon.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Dig Dug (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Dig Dug (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Dig Dug (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Dig_Dug.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Dig_Dug.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Donkey Kong Jr (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Donkey Kong Junior (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Donkey Kong Junior (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Donkey_Kong_Jr.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Donkey_Kong_Jr.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Double Dragon (AB) (PAL) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double_Dragon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double_Dragon.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Double Dragon (OB) (PAL) (Activision) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Double Dragon (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Double Dragon (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Double_Dragon.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Double_Dragon.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "F-18 Hornet (PAL) (Absolute) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\F-18 Hornet (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\F-18 Hornet (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\F-18_Hornet.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\F-18_Hornet.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Fatal Run (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fatal Run (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fatal Run (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fatal_Run.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fatal_Run.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Fight Night (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Fight Night (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Fight Night (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Fight_Night.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Fight_Night.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Food Fight (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Food Fight (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Food Fight (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Food_Fight.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Food_Fight.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Galaga (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Galaga (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Galaga (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Galaga.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Galaga.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Hat Trick (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Hat Trick (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Hat Trick (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Hat_Trick.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Hat_Trick.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Ikari Warriors (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ikari Warriors (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ikari Warriors (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ikari_Warriors.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ikari_Warriors.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Impossible Mission (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Impossible Mission (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Impossible Mission (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Impossible_Mission.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Impossible_Mission.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Jinks (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Jinks (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Jinks (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Jinks.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Jinks.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Joust (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Joust (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Joust (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Joust.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Joust.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Karateka (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Karateka (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Karateka (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Karateka.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Karateka.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Kung-Fu Master (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Kung-Fu Master (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Kung-Fu Master (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Kung-Fu_Master.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Kung-Fu_Master.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Mario Bros (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mario Bros. (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mario Bros. (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mario_Bros.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mario_Bros.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Mat Mania Challenge (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mat Mania Challenge (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mat Mania Challenge (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mat_Mania_Challenge.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mat_Mania_Challenge.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Mean 18 Ultimate Golf (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Mean 18 Ultimate Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Mean 18 Ultimate Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Mean_18.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Mean_18.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Meltdown (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Meltdown (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Meltdown (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Meltdown.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Meltdown.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Midnight Mutants (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Midnight Mutants (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Midnight Mutants (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Midnight_Mutants.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Midnight_Mutants.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Motor Psycho (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Motor Psycho (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Motor Psycho (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Motor_Psycho.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Motor_Psycho.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Ms Pac-Man (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ms. Pac-Man (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ms. Pac-Man (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ms_Pac-Man.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ms_Pac-Man.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Ninja Golf (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Ninja Golf (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Ninja Golf (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Ninja_Golf.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Ninja_Golf.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "One-on-One Basketball (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\One-on-One Basketball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\One-on-One Basketball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\One-on-One_Basketball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\One-on-One_Basketball.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Pete Rose Baseball (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pete Rose Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pete Rose Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pete_Rose_Baseball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pete_Rose_Baseball.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Planet Smashers (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Planet Smashers (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Planet Smashers (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Planet_Smashers.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Planet_Smashers.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Pole Position II (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Pole Position II (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Pole Position II (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Pole_Position_II.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Pole_Position_II.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "RealSports Baseball (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\RealSports Baseball (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\RealSports Baseball (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\RealSports_Baseball.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\RealSports_Baseball.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Robotron 2084 (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Robotron - 2084 (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Robotron - 2084 (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Robotron_2084.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Robotron_2084.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Scrapyard Dog (PAL) (Atari) (1990)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Scrapyard Dog (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Scrapyard Dog (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Scrapyard_Dog.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Scrapyard_Dog.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Summer Games (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Summer Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Summer Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Summer_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Summer_Games.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Huey UH-IX (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Huey UH-IX (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Huey UH-IX (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Huey_UH-IX.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Huey_UH-IX.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Super Skateboardin' (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Super Skateboardin' (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Super Skateboardin' (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Super_Skateboardin.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Super_Skateboardin.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Tank Command (PAL) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tank Command (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tank Command (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tank_Command.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tank_Command.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Title Match Pro Wrestling (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Title Match Pro Wrestling (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Title Match Pro Wrestling (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Title_Match_Pro_Wrestling.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Title_Match_Pro_Wrestling.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Tomcat - The F-14 Fighter Simulator (PAL) (Absolute) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tomcat - The F-14 Fighter Simulator (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tomcat - The F-14 Fighter Simulator (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\F-14_Tomcat.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\F-14_Tomcat.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Touchdown Football (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Touchdown Football (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Touchdown Football (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Touchdown_Football.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Touchdown_Football.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Tower Toppler (PAL) (Atari) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Tower Toppler (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Tower Toppler (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Tower_Toppler.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Tower_Toppler.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Water Ski (PAL) (Froggo) (1988)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Water Ski (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Water Ski (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Water_Ski.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Water_Ski.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Winter Games (Alternate) (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Winter_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter_Games.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Winter Games (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Winter Games (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Winter Games (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Winter_Games.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Winter_Games.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Xenophobe (PAL) (Atari) (1989)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xenophobe (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xenophobe (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xenophobe.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xenophobe.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "Xevious (PAL) (Atari) (1987)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\Xevious (USA).jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\Xevious (USA).jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\Xevious.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\Xevious.htm"))
            End If
        End If

        ' Box Art Does Not Yet Exist
        ' 9-10-2022 HTM files are not yet complete

        If lstAllGames.SelectedItem.ToString = "7iX (20220305)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\7iX.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\7iX.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\7iX.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\7iX.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "2048 (RC1a) (20211113)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\2048.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\2048.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\2048.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\2048.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "7800 XMAS - Santa vs The Nightmares (20201219u1)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\7800 XMAS.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\7800_XMAS.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\7800_XMAS.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\7800_XMAS.htm"))
            End If
        End If

        If lstAllGames.SelectedItem.ToString = "A Roach In Space - Part II - Electric Bugaloo (20201119)" Then
            If System.IO.File.Exists(strBoxArtFolder & "\A Roach In Space - Part II - Electric Bugaloo.jpg") Then
                pctBoxArt.BackgroundImage = Image.FromFile(strBoxArtFolder + "\A Roach In Space - Part II - Electric Bugaloo.jpg")
            End If
            If System.IO.File.Exists(strManualsFolder & "\A_Roach_In_Space_Part_II.htm") Then
                WebBrowser1.Navigate(New Uri(strManualsFolder + "\A_Roach_In_Space_Part_II.htm"))
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

        'While lstAllGames.Items.Count > 0
        'lstAllGames.Items.RemoveAt(lstAllGames.Items.Count - 1)
        'End While

        'For Each LBEntry In lstAllGames.Items
        'lstAllGames.Items.Remove(LBEntry)
        'Next

        lstAllGames.Items.Clear()
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
            lstAllGames.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

        'Save Game Folder to INI file

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 ROM Path", strFolder)


    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
    Private Sub lstAllGames_Format(sender As Object, e As ListControlConvertEventArgs) Handles lstAllGames.Format

    End Sub

    Private Sub lstAllGames_DoubleClick(sender As Object, e As EventArgs) Handles lstAllGames.DoubleClick
        Dim ProcessProperties2 As New ProcessStartInfo
        ProcessProperties2.WorkingDirectory = strA7800Folder + "\"
        ProcessProperties2.FileName = strA7800Folder + "\" + "a7800.exe"
        ProcessProperties2.Arguments = " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
        ProcessProperties2.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties2)
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
    End Sub
    Private Sub SetGameROMPathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGameROMPathToolStripMenuItem.Click
        lstAllGames.Items.Clear()
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
            lstAllGames.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

        'Save Game Folder to INI file

        My.Computer.Registry.CurrentUser.SetValue("Maximus78 ROM Path", strFolder)


    End Sub

    Private Sub SetGameBoxArtPathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGameBoxArtPathToolStripMenuItem.Click
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

    Private Sub SetA7800EmulatorPathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetA7800EmulatorPathToolStripMenuItem.Click
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

    Private Sub SetManualsScreenshotPathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetManualsScreenshotPathToolStripMenuItem.Click
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
        Dim ProcessProperties2 As New ProcessStartInfo
        ProcessProperties2.WorkingDirectory = strA7800Folder + "\"
        ProcessProperties2.FileName = strA7800Folder + "\" + "a7800.exe"
        ProcessProperties2.Arguments = " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
        ProcessProperties2.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties2)
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub NTSCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NTSCToolStripMenuItem.Click
        strArguments = "a7800"
        NTSCToolStripMenuItem.Checked = True
        PALToolStripMenuItem.Checked = False
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
    End Sub

    Private Sub PALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PALToolStripMenuItem.Click
        strArguments = "a7800p"
        NTSCToolStripMenuItem.Checked = False
        PALToolStripMenuItem.Checked = True
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
    End Sub
    Private Sub xmON_Click(sender As Object, e As EventArgs) Handles xmON.Click
        strAddArguments = "-cart1 xm -cart2"
        xmON.Checked = True
        xmOFF.Checked = False
        hscON.Checked = False
        hscOFF.Checked = True
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
    End Sub

    Private Sub xmOFF_Click(sender As Object, e As EventArgs) Handles xmOFF.Click
        strAddArguments = "-cart"
        xmOFF.Checked = True
        xmON.Checked = False
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
    End Sub

    Private Sub hscON_Click(sender As Object, e As EventArgs) Handles hscON.Click
        strAddArguments = "-cart1 hiscore -cart2"
        hscON.Checked = True
        hscOFF.Checked = False
        xmON.Checked = False
        xmOFF.Checked = True
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
    End Sub

    Private Sub hscOFF_Click(sender As Object, e As EventArgs) Handles hscOFF.Click
        strAddArguments = "-cart"
        hscOFF.Checked = True
        hscON.Checked = False
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
    End Sub

    Private Sub debugON_Click(sender As Object, e As EventArgs) Handles debugON.Click
        strDebug = "-debug"
        debugON.Checked = True
        debugOFF.Checked = False
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
    End Sub

    Private Sub debugOFF_Click(sender As Object, e As EventArgs) Handles debugOFF.Click
        strDebug = ""
        debugON.Checked = False
        debugOFF.Checked = True
        txtPath.Text = strA7800Folder + "\" + "a7800.exe" + " " + strArguments + " " + strAddArguments + " """ + strFolder + "\" + lstAllGames.Text + ".a78""" + " " + strDebug
    End Sub

    Private Sub Atari7800ProSystemOwnersManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Atari7800ProSystemOwnersManualToolStripMenuItem.Click
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\7800_Owners_Manual.htm"))
    End Sub

    Private Sub A7800UsersGuideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles A7800UsersGuideToolStripMenuItem.Click
        WebBrowser1.Navigate(New Uri(strManualsFolder + "\A7800_Manual.htm"))
    End Sub

    Private Sub EditA7800ConfigurationFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditA7800ConfigurationFileToolStripMenuItem.Click
        frmA7800Config.Show()
    End Sub
End Class