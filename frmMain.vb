Imports System.IO

Public Class frmMain

#Region "State"

    ''' <summary>One ROM tab: its list, the folder text box on the Directory Paths tab and its registry value.</summary>
    Private Class CategoryInfo
        Public Category As RomCategory
        Public List As ListBox
        Public Tab As TabPage
        Public PathBox As TextBox
        Public RegistryName As String
        Public AllRoms As New List(Of RomEntry)
    End Class

    Public Const AppVersion As String = "v0.99.40b"
    Private Const MAX_RECENT_FILES As Integer = 10
    Private Const FavoritesFileName As String = "Maximus78_Favorites.sav"

    Private _categories As List(Of CategoryInfo)
    Private _screenshots As PictureBox()
    Private _favorites As New List(Of String)
    Private _romIndex As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
    Private _boxArt As New BoxArtIndex("")

    Private _a7800Folder As String = ""
    Private _boxArtFolder As String = ""
    Private _manualsFolder As String = ""
    Private _windowMode As String = "Full"

    Private _currentRomName As String = ""
    Private _currentRomPath As String = ""
    Private _loading As Boolean
    Private _searchBox As ToolStripTextBox

#End Region

#Region "Startup"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loading = True

        _categories = New List(Of CategoryInfo) From {
            NewCategory(RomCategory.NTSCRetail, lstNTSCRetail, tabNTSC, txtNTSCRetailPath, "Maximus78 NTSC Retail ROM Subfolder"),
            NewCategory(RomCategory.PALRetail, lstPALRetail, tabPAL, txtPALRetailPath, "Maximus78 PAL Retail ROM Subfolder"),
            NewCategory(RomCategory.Homebrews, lstHomebrews, tabHomebrews, txtHomebrewPath, "Maximus78 Homebrews ROM Subfolder"),
            NewCategory(RomCategory.Hacks, lstHacks, tabHacks, txtHacksPath, "Maximus78 Hacks ROM Subfolder"),
            NewCategory(RomCategory.Demos, lstDemos, tabDemos, txtDemosPath, "Maximus78 Demos ROM Subfolder"),
            NewCategory(RomCategory.Prototypes, lstProtos, tabProtos, txtProtosPath, "Maximus78 Prototypes ROM Subfolder"),
            NewCategory(RomCategory.Utilities, lstUtilities, tabUtilities, txtUtilitiesPath, "Maximus78 Utilities ROM Subfolder")
        }
        _screenshots = {Screenshot1, Screenshot2, Screenshot3, Screenshot4, Screenshot5, Screenshot6}

        For Each cat In _categories
            AddHandler cat.List.SelectedIndexChanged, AddressOf RomList_SelectedIndexChanged
            AddHandler cat.List.DoubleClick, AddressOf RomList_DoubleClick
            AddHandler cat.List.KeyDown, AddressOf RomList_KeyDown
            AddHandler cat.List.MouseDown, AddressOf List_MouseDown
        Next
        AddHandler lstFavorites.KeyDown, AddressOf RomList_KeyDown
        AddHandler lstFavorites.MouseDown, AddressOf List_MouseDown
        AddHandler TabControlRoms.SelectedIndexChanged, AddressOf TabControlRoms_SelectedIndexChanged

        BuildExtraUi()

        ' First run: no A7800 folder stored yet.
        If IsUnsetPath(GetSetting("Maximus78 A7800 Path")) Then
            Using setup As New frmSetup()
                If setup.ShowDialog() <> DialogResult.OK Then
                    BeginInvoke(New MethodInvoker(AddressOf Close))
                    Return
                End If
            End Using
        End If

        LoadPathsFromRegistry()
        RestoreOptions()
        LoadHighScores()

        _windowMode = GetSetting("Maximus78 Display Mode", "Full")
        ApplyDisplayMode(_windowMode, save:=False)

        RefreshAllLists()
        LoadFavorites()
        LoadRecentFiles()
        ShowBlankInfo()

        _loading = False
        UpdateStatusStrip()
        BeginInvoke(New MethodInvoker(AddressOf CheckForMovedRomFolders))
    End Sub

    ''' <summary>
    ''' After a ROM pack update the old category folders (for example "Retail_v4_0\NTSC") usually no longer exist.
    ''' If that is the case, offer to find the new ones under the ROM folder.
    ''' </summary>
    Private Sub CheckForMovedRomFolders()
        Dim root = txtRomPath.Text.Trim()
        If root = "" OrElse Not Directory.Exists(root) Then Return
        Dim missing = _categories.Where(Function(c) Not Directory.Exists(c.PathBox.Text.Trim())).ToList()
        If missing.Count = 0 Then Return
        Dim found = DetectCategoryFolders(root)
        If Not missing.Any(Function(c) found.ContainsKey(c.Category)) Then Return
        DetectCategoriesInto(root, askToApply:=True)
    End Sub

    Private Function NewCategory(cat As RomCategory, list As ListBox, tab As TabPage, pathBox As TextBox, registryName As String) As CategoryInfo
        Return New CategoryInfo With {.Category = cat, .List = list, .Tab = tab, .PathBox = pathBox, .RegistryName = registryName}
    End Function

    ''' <summary>Controls added in code so the designer file stays untouched.</summary>
    Private Sub BuildExtraUi()
        ToolStripStatusLabel1.Text = " " & AppVersion & "  "

        ' Search box on the right of the menu bar: filters every ROM list and Favorites as you type.
        _searchBox = New ToolStripTextBox With {
            .Alignment = ToolStripItemAlignment.Right,
            .AutoSize = False,
            .Width = 200,
            .ToolTipText = "Type part of a game name to filter the lists (Esc clears)"}
        AddHandler _searchBox.TextChanged, Sub() ApplyFilterAll()
        AddHandler _searchBox.KeyDown, Sub(s, ev)
                                           If ev.KeyCode = Keys.Escape Then _searchBox.Clear() : ev.SuppressKeyPress = True
                                       End Sub
        MenuStrip1.Items.Add(_searchBox)
        MenuStrip1.Items.Add(New ToolStripLabel("Find:") With {.Alignment = ToolStripItemAlignment.Right})

        ' Edit menu: re-run the folder setup / auto-detection at any time.
        Dim setupItem As New ToolStripMenuItem("Folder Setup && Auto-Detect...")
        AddHandler setupItem.Click, AddressOf FolderSetupMenu_Click
        EditToolStripMenuItem.DropDownItems.Insert(0, setupItem)
        EditToolStripMenuItem.DropDownItems.Insert(1, New ToolStripSeparator())

        ' Directory Paths tab: make room for an Auto-Detect button next to the save button.
        btnSaveROMPaths.Width = 200
        btnSaveROMPaths.Text = "Save Paths && Refresh Lists"
        Dim autoDetect As New Button With {
            .Text = "Auto-Detect",
            .Location = New Point(btnSaveROMPaths.Right + 6, btnSaveROMPaths.Top),
            .Size = New Size(btnSaveROMPaths.Parent.ClientSize.Width - btnSaveROMPaths.Right - 15, btnSaveROMPaths.Height),
            .BackColor = btnSaveROMPaths.BackColor,
            .ForeColor = btnSaveROMPaths.ForeColor,
            .FlatStyle = btnSaveROMPaths.FlatStyle}
        AddHandler autoDetect.Click, AddressOf AutoDetectButton_Click
        btnSaveROMPaths.Parent.Controls.Add(autoDetect)
        Button1.Text = "Save Changes (applied immediately)"

        ' The "Update Box Art" menu existed but was never attached to the picture.
        pctBoxArt.ContextMenuStrip = ContextBoxArt
    End Sub

    Private Sub LoadPathsFromRegistry()
        _a7800Folder = StoredPath("Maximus78 A7800 Path")
        _boxArtFolder = StoredPath("Maximus78 Box Art Path")
        _manualsFolder = StoredPath("Maximus78 Manuals Path")

        txtA7800path.Text = _a7800Folder
        txtBoxArtPath.Text = _boxArtFolder
        txtManualsPath.Text = _manualsFolder
        txtRomPath.Text = StoredPath("Maximus78 ROM Path")
        txtRootROMPath.Text = txtRomPath.Text
        For Each cat In _categories
            cat.PathBox.Text = StoredPath(cat.RegistryName)
        Next
        _boxArt = New BoxArtIndex(_boxArtFolder)
    End Sub

    Private Function StoredPath(name As String) As String
        Dim v = GetSetting(name)
        Return If(IsUnsetPath(v), "", v.Trim())
    End Function

#End Region

#Region "ROM lists"

    ''' <summary>Rescans every category folder (including all letter sub-folders) and refills the lists.</summary>
    Private Sub RefreshAllLists()
        Cursor = Cursors.WaitCursor
        Try
            _romIndex.Clear()
            For Each cat In _categories
                cat.AllRoms = ScanFolder(cat.PathBox.Text.Trim())
                For Each rom In cat.AllRoms
                    If Not _romIndex.ContainsKey(rom.Name) Then _romIndex(rom.Name) = rom.FullPath
                Next
                ApplyFilter(cat)
            Next
            ApplyFavoritesFilter()
        Finally
            Cursor = Cursors.Default
        End Try
        UpdateTitle()
    End Sub

    Private Function MatchesFilter(text As String) As Boolean
        Dim filter = If(_searchBox Is Nothing, "", _searchBox.Text.Trim())
        If filter = "" Then Return True
        For Each word In filter.Split(" "c)
            If word <> "" AndAlso text.IndexOf(word, StringComparison.OrdinalIgnoreCase) < 0 Then Return False
        Next
        Return True
    End Function

    Private Sub ApplyFilter(cat As CategoryInfo)
        Dim selected = TryCast(cat.List.SelectedItem, RomEntry)
        cat.List.BeginUpdate()
        cat.List.Items.Clear()
        cat.List.Items.AddRange(cat.AllRoms.Where(Function(r) MatchesFilter(r.Display)).Cast(Of Object)().ToArray())
        If selected IsNot Nothing AndAlso cat.List.Items.Contains(selected) Then cat.List.SelectedItem = selected
        cat.List.EndUpdate()
    End Sub

    Private Sub ApplyFavoritesFilter()
        Dim selected = TryCast(lstFavorites.SelectedItem, String)
        lstFavorites.BeginUpdate()
        lstFavorites.Items.Clear()
        lstFavorites.Items.AddRange(_favorites.Where(Function(f) MatchesFilter(f)).Cast(Of Object)().ToArray())
        If selected IsNot Nothing AndAlso lstFavorites.Items.Contains(selected) Then lstFavorites.SelectedItem = selected
        lstFavorites.EndUpdate()
    End Sub

    Private Sub ApplyFilterAll()
        For Each cat In _categories
            ApplyFilter(cat)
        Next
        ApplyFavoritesFilter()
        UpdateTitle()
    End Sub

    Private Function CurrentCategory() As CategoryInfo
        Return _categories.FirstOrDefault(Function(c) c.Tab Is TabControlRoms.SelectedTab)
    End Function

    Private Sub UpdateTitle()
        Dim cat = CurrentCategory()
        If cat IsNot Nothing Then
            Text = $"Maximus78 - {cat.Tab.Text}: {cat.List.Items.Count} of {cat.AllRoms.Count} ROMs"
        ElseIf TabControlRoms.SelectedTab Is tabFavorites Then
            Text = $"Maximus78 - Favorites: {lstFavorites.Items.Count}"
        Else
            Text = "Maximus78"
        End If
    End Sub

    ''' <summary>The game picked on the visible tab: its name (for artwork) and full ROM path.</summary>
    Private Function CurrentSelection(ByRef name As String, ByRef romPath As String) As Boolean
        name = "" : romPath = ""
        Dim cat = CurrentCategory()
        If cat IsNot Nothing Then
            Dim rom = TryCast(cat.List.SelectedItem, RomEntry)
            If rom Is Nothing Then Return False
            name = rom.Name : romPath = rom.FullPath
            Return True
        End If
        If TabControlRoms.SelectedTab Is tabFavorites Then
            Dim fav = TryCast(lstFavorites.SelectedItem, String)
            If fav Is Nothing Then Return False
            name = fav : romPath = FindRomPath(fav)
            Return True
        End If
        Return False
    End Function

    Private Function FindRomPath(romName As String) As String
        Dim p As String = Nothing
        Return If(_romIndex.TryGetValue(romName, p), p, "")
    End Function

    Private Sub RomList_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim rom = TryCast(DirectCast(sender, ListBox).SelectedItem, RomEntry)
        If rom IsNot Nothing Then ShowRomInfo(rom.Name, rom.FullPath)
    End Sub

    Private Sub lstFavorites_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFavorites.SelectedIndexChanged
        Dim fav = TryCast(lstFavorites.SelectedItem, String)
        If fav IsNot Nothing Then ShowRomInfo(fav, FindRomPath(fav))
    End Sub

    Private Sub RomList_DoubleClick(sender As Object, e As EventArgs)
        Dim rom = TryCast(DirectCast(sender, ListBox).SelectedItem, RomEntry)
        If rom IsNot Nothing Then Launch(rom.FullPath)
    End Sub

    Private Sub lstFavorites_DoubleClick(sender As Object, e As EventArgs) Handles lstFavorites.DoubleClick
        LaunchSelected()
    End Sub

    Private Sub RomList_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LaunchSelected()
        End If
    End Sub

    ''' <summary>Right-clicking a game selects it first, so the context menu acts on the game under the mouse.</summary>
    Private Sub List_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button <> MouseButtons.Right Then Return
        Dim list = DirectCast(sender, ListBox)
        Dim index = list.IndexFromPoint(e.Location)
        If index >= 0 Then list.SelectedIndex = index
    End Sub

    Private Sub TabControlRoms_SelectedIndexChanged(sender As Object, e As EventArgs)
        UpdateTitle()
        Dim name = "", romPath = ""
        If CurrentSelection(name, romPath) Then ShowRomInfo(name, romPath)
    End Sub

#End Region

#Region "Game information, box art and screenshots"

    Private Function ManualsFile(fileName As String) As String
        If _manualsFolder = "" Then Return ""
        Return Path.Combine(_manualsFolder, fileName)
    End Function

    Private Sub NavigateTo(file As String)
        Try
            If file <> "" AndAlso IO.File.Exists(file) Then
                WebBrowser1.Navigate(New Uri(file))
            Else
                WebBrowser1.Navigate("about:blank")
            End If
        Catch
        End Try
    End Sub

    Private Function BlankBoxArt() As Image
        If _boxArtFolder = "" Then Return Nothing
        Return LoadImageUnlocked(Path.Combine(_boxArtFolder, "Blank.jpg"))
    End Function

    Private Sub ShowBlankInfo()
        SetBackground(pctBoxArt, BlankBoxArt())
        NavigateTo(ManualsFile("blank.htm"))
        txtEditorFile.Text = ManualsFile("blank.htm")
        txtHTMLEditor.Text = ReadTextOrEmpty(txtEditorFile.Text)
        txtPath.Text = ""
    End Sub

    ''' <summary>
    ''' Shows everything Maximus78 knows about a game. Artwork is found by the ROM's file name:
    '''   box art:     &lt;box art folder&gt;\&lt;name&gt;.png/.jpg (or a close title match, see BoxArtIndex)
    '''   game info:   &lt;game info folder&gt;\&lt;name&gt;.htm
    '''   screenshots: &lt;game info folder&gt;\&lt;name&gt;.screenshot.1-6.png/.jpg
    ''' </summary>
    Private Sub ShowRomInfo(romName As String, romPath As String)
        _currentRomName = romName
        _currentRomPath = romPath

        Dim art = _boxArt.Resolve(romName)
        SetBackground(pctBoxArt, If(LoadImageUnlocked(art), BlankBoxArt()))

        Dim htm = ManualsFile(romName & ".htm")
        NavigateTo(If(htm <> "" AndAlso File.Exists(htm), htm, ManualsFile("blank.htm")))
        txtEditorFile.Text = htm
        txtHTMLEditor.Text = ReadTextOrEmpty(htm)

        For i = 1 To 6
            SetBackground(_screenshots(i - 1), LoadImageUnlocked(ExistingScreenshot(romName, i)))
        Next

        RefreshCommandPreview()
    End Sub

    Private Function ReadTextOrEmpty(file As String) As String
        Try
            If file <> "" AndAlso IO.File.Exists(file) Then Return IO.File.ReadAllText(file)
        Catch
        End Try
        Return ""
    End Function

    Private Function ScreenshotFile(romName As String, slot As Integer, ext As String) As String
        Return ManualsFile($"{romName}.screenshot.{slot}{ext}")
    End Function

    ''' <summary>The stored screenshot for a slot; a .jpg wins over a .png, as in earlier versions.</summary>
    Private Function ExistingScreenshot(romName As String, slot As Integer) As String
        For Each ext In {".jpg", ".png"}
            Dim f = ScreenshotFile(romName, slot, ext)
            If f <> "" AndAlso File.Exists(f) Then Return f
        Next
        Return ""
    End Function

    Private Shared Function SlotOf(sender As Object) As Integer
        Dim name = If(TryCast(sender, Control)?.Name, TryCast(sender, ToolStripItem)?.Name)
        If String.IsNullOrEmpty(name) Then Return 0
        Dim slot = AscW(name(name.Length - 1)) - AscW("0"c)
        Return If(slot >= 1 AndAlso slot <= 6, slot, 0)
    End Function

    Private Function EnsureGameSelected() As Boolean
        If _currentRomName = "" Then
            MsgBox("Select a game first.", MsgBoxStyle.Information, "Maximus78")
            Return False
        End If
        If _manualsFolder = "" OrElse Not Directory.Exists(_manualsFolder) Then
            MsgBox("Set the Game Info path first (Edit menu or the Directory Paths tab).", MsgBoxStyle.Information, "Maximus78")
            Return False
        End If
        Return True
    End Function

    ''' <summary>Clicking a screenshot or its Load button: pick an image to show in that slot (Save stores it).</summary>
    Private Function PickScreenshot(slot As Integer) As Boolean
        If slot = 0 OrElse Not EnsureGameSelected() Then Return False
        Dim file = BrowseForImage($"Select Screenshot {slot} for {_currentRomName}", _manualsFolder)
        If file Is Nothing Then Return False
        Dim img = LoadImageUnlocked(file)
        If img Is Nothing Then
            MsgBox("That file could not be opened as an image.", MsgBoxStyle.Exclamation, "Maximus78")
            Return False
        End If
        SetBackground(_screenshots(slot - 1), img)
        Return True
    End Function

    Private Sub SaveScreenshot(slot As Integer)
        If slot = 0 OrElse Not EnsureGameSelected() Then Return
        Dim img = _screenshots(slot - 1).BackgroundImage
        If img Is Nothing Then Return
        Dim png = ScreenshotFile(_currentRomName, slot, ".png")
        Dim jpg = ScreenshotFile(_currentRomName, slot, ".jpg")
        If File.Exists(png) OrElse File.Exists(jpg) Then
            If MsgBox($"Replace the saved screenshot {slot} for {_currentRomName}?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Maximus78") <> MsgBoxResult.Yes Then Return
        End If
        Try
            If File.Exists(jpg) Then File.Delete(jpg)
            img.Save(png, Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox("Could not save the screenshot: " & ex.Message, MsgBoxStyle.Exclamation, "Maximus78")
        End Try
    End Sub

    Private Sub UnloadScreenshot(slot As Integer)
        If slot = 0 OrElse _currentRomName = "" Then Return
        Dim saved = ExistingScreenshot(_currentRomName, slot)
        If saved <> "" Then
            If MsgBox($"Delete the saved screenshot {slot} for {_currentRomName}?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Maximus78") <> MsgBoxResult.Yes Then Return
            Try
                For Each ext In {".png", ".jpg"}
                    Dim f = ScreenshotFile(_currentRomName, slot, ext)
                    If File.Exists(f) Then File.Delete(f)
                Next
            Catch ex As Exception
                MsgBox("Could not delete the screenshot: " & ex.Message, MsgBoxStyle.Exclamation, "Maximus78")
                Return
            End Try
        End If
        SetBackground(_screenshots(slot - 1), Nothing)
    End Sub

    Private Sub Screenshot_Click(sender As Object, e As EventArgs) Handles Screenshot1.Click, Screenshot2.Click, Screenshot3.Click, Screenshot4.Click, Screenshot5.Click, Screenshot6.Click,
            btnLoad1.Click, btnLoad2.Click, btnLoad3.Click, btnLoad4.Click, btnLoad5.Click, btnLoad6.Click
        PickScreenshot(SlotOf(sender))
    End Sub

    Private Sub ScreenshotSave_Click(sender As Object, e As EventArgs) Handles btnSave1.Click, btnSave2.Click, btnSave3.Click, btnSave4.Click, btnSave5.Click, btnSave6.Click
        SaveScreenshot(SlotOf(sender))
    End Sub

    Private Sub ScreenshotUnload_Click(sender As Object, e As EventArgs) Handles btnUnload1.Click, btnUnload2.Click, btnUnload3.Click, btnUnload4.Click, btnUnload5.Click, btnUnload6.Click
        UnloadScreenshot(SlotOf(sender))
    End Sub

    ''' <summary>List context menu, Add Screenshots: pick and save in one step.</summary>
    Private Sub AddImage_Click(sender As Object, e As EventArgs) Handles addImage1.Click, addImage2.Click, addImage3.Click, addImage4.Click, addImage5.Click, addImage6.Click
        Dim slot = SlotOf(sender)
        If PickScreenshot(slot) Then SaveScreenshot(slot)
    End Sub

    ''' <summary>Right-click the box art: replace it. The previous image is kept as "&lt;name&gt;.backup.&lt;ext&gt;".</summary>
    Private Sub UpdateBoxArtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateBoxArtToolStripMenuItem.Click
        If _currentRomName = "" Then
            MsgBox("Select a game first.", MsgBoxStyle.Information, "Maximus78")
            Return
        End If
        If _boxArtFolder = "" OrElse Not Directory.Exists(_boxArtFolder) Then
            MsgBox("Set the Box Art path first (Edit menu or the Directory Paths tab).", MsgBoxStyle.Information, "Maximus78")
            Return
        End If
        Dim source = BrowseForImage("Select Box Art for " & _currentRomName, _boxArtFolder)
        If source Is Nothing Then Return
        Try
            Dim bytes = File.ReadAllBytes(source)
            Dim ext = Path.GetExtension(source).ToLowerInvariant()
            If ext = ".jpeg" Then ext = ".jpg"
            For Each oldExt In ImageExtensions
                Dim existing = Path.Combine(_boxArtFolder, _currentRomName & oldExt)
                If File.Exists(existing) Then
                    File.Copy(existing, Path.Combine(_boxArtFolder, _currentRomName & ".backup" & oldExt), True)
                    File.Delete(existing)
                End If
            Next
            File.WriteAllBytes(Path.Combine(_boxArtFolder, _currentRomName & ext), bytes)
        Catch ex As Exception
            MsgBox("Could not update the box art: " & ex.Message, MsgBoxStyle.Exclamation, "Maximus78")
        End Try
        _boxArt = New BoxArtIndex(_boxArtFolder)
        ShowRomInfo(_currentRomName, _currentRomPath)
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If Not EnsureGameSelected() Then Return
        txtEditorFile.Text = ManualsFile(_currentRomName & ".htm")
        txtHTMLEditor.Text = ReadTextOrEmpty(txtEditorFile.Text)
    End Sub

    Private Sub btnSaveHTML_Click(sender As Object, e As EventArgs) Handles btnSaveHTML.Click
        If txtEditorFile.Text = "" Then
            MsgBox("Set the Game Info path first (Edit menu or the Directory Paths tab).", MsgBoxStyle.Information, "Maximus78")
            Return
        End If
        Try
            File.WriteAllText(txtEditorFile.Text, txtHTMLEditor.Text)
        Catch ex As Exception
            MsgBox("Error writing file: " & ex.Message, MsgBoxStyle.Exclamation, "Maximus78")
            Return
        End Try
        NavigateTo(txtEditorFile.Text)
        MsgBox("Saved to " & txtEditorFile.Text, MsgBoxStyle.Information, "Maximus78")
    End Sub

#End Region

#Region "Launching A7800"

    Private Shared Function Quote(s As String) As String
        Return """" & s & """"
    End Function

    Private Function VideoArguments() As String
        If videoCompatibility.Checked Then Return "-video d3d"
        Dim chain As String = Nothing
        If videoBasic.Checked Then chain = "none"
        If videoCRT.Checked Then chain = "crt-geom"
        If videoCRTDeluxe.Checked Then chain = "crt-geom-deluxe"
        If videoSuperEagle.Checked Then chain = "super-eagle"
        If videoHLSL.Checked Then chain = "hlsl"
        If videoHQ2x.Checked Then chain = "hq2x"
        If videoHQ4x.Checked Then chain = "hq4x"
        Return If(chain Is Nothing, "", "-video bgfx -bgfx_screen_chains " & chain)
    End Function

    ''' <summary>A7800 command-line arguments for the current Edit menu settings.</summary>
    Private Function BuildArguments(romPath As String) As String
        ' Machine: a7800 (NTSC) / a7800p (PAL), plus dev, u1 (cool palette) or u2 (hot palette).
        Dim machine = "a7800" & If(PALToolStripMenuItem.Checked, "p", "")
        If devON.Checked Then
            machine &= "dev"
        ElseIf paletteCOOL.Checked Then
            machine &= "u1"
        ElseIf paletteHOT.Checked Then
            machine &= "u2"
        End If

        Dim cart = If(xmON.Checked, "-cart1 xm -cart2", If(hscON.Checked, "-cart1 hiscore -cart2", "-cart"))

        Dim parts As New List(Of String) From {machine, cart, Quote(romPath)}
        If debugON.Checked Then parts.Add("-debug")
        parts.Add(VideoArguments())
        If triplebufferON.Checked Then parts.Add("-triplebuffer")
        If vsyncON.Checked Then parts.Add("-waitvsync")
        If fullScreenON.Checked Then parts.Add("-nowindow")
        If stretchON.Checked Then parts.Add("-nokeepaspect")
        Return String.Join(" ", parts.Where(Function(p) p <> ""))
    End Function

    Private Function A7800Exe() As String
        Return If(_a7800Folder = "", "a7800.exe", Path.Combine(_a7800Folder, "a7800.exe"))
    End Function

    Private Sub RefreshCommandPreview()
        If _loading Then Return
        txtPath.Text = If(_currentRomPath = "", "", A7800Exe() & " " & BuildArguments(_currentRomPath))
    End Sub

    Private Sub Launch(romPath As String)
        If String.IsNullOrEmpty(romPath) OrElse Not File.Exists(romPath) Then
            MsgBox("The ROM file could not be found:" & vbCrLf & If(romPath, "") & vbCrLf & vbCrLf &
                   "Check the ROM folders on the Directory Paths tab.", MsgBoxStyle.Exclamation, "Maximus78")
            Return
        End If
        Dim exe = A7800Exe()
        If Not File.Exists(exe) Then
            MsgBox("a7800.exe was not found in:" & vbCrLf & _a7800Folder & vbCrLf & vbCrLf &
                   "Set the A7800 path from the Edit menu.", MsgBoxStyle.Exclamation, "Maximus78")
            Return
        End If
        Dim args = BuildArguments(romPath)
        Try
            Process.Start(New ProcessStartInfo(exe, args) With {.WorkingDirectory = _a7800Folder, .WindowStyle = ProcessWindowStyle.Normal})
        Catch ex As Exception
            MsgBox("Could not start A7800: " & ex.Message, MsgBoxStyle.Exclamation, "Maximus78")
            Return
        End Try
        txtPath.Text = exe & " " & args
        UpdateRecentFiles(romPath)
    End Sub

    Private Sub LaunchSelected()
        Dim name = "", romPath = ""
        If Not CurrentSelection(name, romPath) Then Return
        If romPath = "" Then
            MsgBox($"""{name}"" was not found in any ROM folder." & vbCrLf &
                   "It may have been renamed in a newer ROM pack.", MsgBoxStyle.Exclamation, "Maximus78")
            Return
        End If
        Launch(romPath)
    End Sub

    Private Sub StartSelectedGameToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles StartSelectedGameToolStripMenuItem.Click
        LaunchSelected()
    End Sub

    Private Sub mnuLoadGame_Click_1(sender As Object, e As EventArgs) Handles mnuLoadGame.Click
        Using dlg As New OpenFileDialog With {
            .Title = "Select Atari 7800 Game ROM",
            .Filter = "Atari 7800 ROMs (*.a78;*.bin)|*.a78;*.bin|All files (*.*)|*.*",
            .CheckFileExists = True}
            Dim start = If(txtRomPath.Text <> "" AndAlso Directory.Exists(txtRomPath.Text), txtRomPath.Text, _a7800Folder)
            If start <> "" AndAlso Directory.Exists(start) Then dlg.InitialDirectory = start
            If dlg.ShowDialog() = DialogResult.OK Then Launch(dlg.FileName)
        End Using
    End Sub

#End Region

#Region "Recent files"

    Private Sub LoadRecentFiles()
        If My.Settings.RecentFiles Is Nothing Then My.Settings.RecentFiles = New Specialized.StringCollection()
        RecentToolStripMenuItem.DropDownItems.Clear()
        For Each f In My.Settings.RecentFiles.Cast(Of String)()
            RecentToolStripMenuItem.DropDownItems.Add(New ToolStripMenuItem(f, Nothing, AddressOf RecentFileMenuItems_Click))
        Next
        RecentToolStripMenuItem.Enabled = RecentToolStripMenuItem.DropDownItems.Count > 0
    End Sub

    Private Sub UpdateRecentFiles(fileName As String)
        If My.Settings.RecentFiles Is Nothing Then My.Settings.RecentFiles = New Specialized.StringCollection()
        Dim recent = My.Settings.RecentFiles
        If recent.Contains(fileName) Then recent.Remove(fileName)
        recent.Insert(0, fileName)
        While recent.Count > MAX_RECENT_FILES
            recent.RemoveAt(MAX_RECENT_FILES)
        End While
        ' The app uses its own startup object, so settings are not saved automatically on exit.
        Try
            My.Settings.Save()
        Catch
        End Try
        LoadRecentFiles()
    End Sub

    Private Sub RecentFileMenuItems_Click(sender As Object, e As EventArgs)
        Launch(DirectCast(sender, ToolStripMenuItem).Text)
    End Sub

#End Region

#Region "Favorites"

    Private Function FavoritesFile() As String
        Return If(_a7800Folder = "", "", Path.Combine(_a7800Folder, FavoritesFileName))
    End Function

    Private Sub LoadFavorites()
        _favorites.Clear()
        Dim file = FavoritesFile()
        Try
            If file <> "" AndAlso IO.File.Exists(file) Then
                For Each line In IO.File.ReadAllLines(file)
                    Dim t = line.Trim()
                    If t <> "" AndAlso Not _favorites.Contains(t, StringComparer.OrdinalIgnoreCase) Then _favorites.Add(t)
                Next
            End If
        Catch
        End Try
        ApplyFavoritesFilter()
    End Sub

    Private Sub SaveFavorites()
        Dim file = FavoritesFile()
        If file = "" Then
            MsgBox("Set the A7800 path first; favorites are saved there.", MsgBoxStyle.Information, "Maximus78")
            Return
        End If
        Try
            IO.File.WriteAllLines(file, _favorites)
        Catch ex As Exception
            MsgBox("Could not save favorites: " & ex.Message, MsgBoxStyle.Exclamation, "Maximus78")
        End Try
        ApplyFavoritesFilter()
    End Sub

    Private Sub munAddFavorite_Click(sender As Object, e As EventArgs) Handles mnuAddFavorite.Click, contextNTSCRetail.Click
        Dim cat = CurrentCategory()
        Dim rom = If(cat Is Nothing, Nothing, TryCast(cat.List.SelectedItem, RomEntry))
        If rom Is Nothing Then Return
        If Not _favorites.Contains(rom.Name, StringComparer.OrdinalIgnoreCase) Then
            _favorites.Add(rom.Name)
            SaveFavorites()
        End If
    End Sub

    Private Sub mnuRemoveFavorite_Click(sender As Object, e As EventArgs) Handles mnuRemoveFavorite.Click, RemoveFromFavoritesToolStripMenuItem.Click
        If TabControlRoms.SelectedTab IsNot tabFavorites Then Return
        Dim fav = TryCast(lstFavorites.SelectedItem, String)
        If fav Is Nothing Then Return
        _favorites.Remove(fav)
        SaveFavorites()
    End Sub

    Private Sub ClearAllFavoritesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllFavoritesToolStripMenuItem.Click
        If _favorites.Count = 0 Then Return
        If MsgBox("Remove all favorites?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Maximus78") <> MsgBoxResult.Yes Then Return
        _favorites.Clear()
        SaveFavorites()
    End Sub

#End Region

#Region "Edit menu options"

    Private Shared Sub SelectOne(selected As ToolStripMenuItem, ParamArray group As ToolStripMenuItem())
        For Each item In group
            item.Checked = item Is selected
        Next
    End Sub

    Private Shared Function OnOff(value As Boolean) As String
        Return If(value, "On", "Off")
    End Function

    Private Function VideoItems() As ToolStripMenuItem()
        Return {videoCompatibility, videoBasic, videoCRT, videoCRTDeluxe, videoSuperEagle, videoHLSL, videoHQ2x, videoHQ4x}
    End Function

    ''' <summary>Registry names of the video options, in the same order as <see cref="VideoItems"/>.</summary>
    Private Shared ReadOnly VideoNames As String() = {"Compatibility", "Basic", "CRT", "CRT Deluxe", "Super Eagle", "HLSL", "HQ2x", "HQ4x"}

    Private Sub RestoreOptions()
        SelectOne(If(GetSetting("Maximus78 Box Option PAL") = "On", PALToolStripMenuItem, NTSCToolStripMenuItem), NTSCToolStripMenuItem, PALToolStripMenuItem)

        Dim palette = paletteWARM
        If GetSetting("Maximus78 Option Cool Palette") = "On" Then palette = paletteCOOL
        If GetSetting("Maximus78 Option Hot Palette") = "On" Then palette = paletteHOT
        SelectOne(palette, paletteWARM, paletteCOOL, paletteHOT)

        Dim video As ToolStripMenuItem = Nothing
        Dim items = VideoItems()
        For i = 0 To items.Length - 1
            If GetSetting("Maximus78 Box Video Option " & VideoNames(i)) = "On" Then video = items(i)
        Next
        SelectOne(video, items)

        SetOnOff(stretchON, stretchOFF, GetSetting("Maximus78 Window Option Stretch") = "On")
        SetOnOff(fullScreenON, fullscreenOFF, GetSetting("Maximus78 Window A7800 Full Screen") = "On")
        SetOnOff(vsyncON, vsyncOFF, GetSetting("Maximus78 Option Vsync Wait") = "On")
        SetOnOff(triplebufferON, triplebufferOFF, GetSetting("Maximus78 Option TripleBuffer") = "On")
        Dim xm = GetSetting("Maximus78 Option XM") = "On"
        SetOnOff(xmON, xmOFF, xm)
        SetOnOff(hscON, hscOFF, Not xm AndAlso GetSetting("Maximus78 Option HSC") = "On")
        Dim dev = GetSetting("Maximus78 Option Developer Mode") = "On"
        SetOnOff(devON, devOFF, dev)
        If dev Then SelectOne(paletteWARM, paletteWARM, paletteCOOL, paletteHOT)
        SetOnOff(debugON, debugOFF, GetSetting("Maximus78 Option Debug Mode") = "On")

        statusON.Checked = GetSetting("Maximus78 StatusBar") = "On"
        statusOFF.Checked = Not statusON.Checked
    End Sub

    Private Shared Sub SetOnOff(onItem As ToolStripMenuItem, offItem As ToolStripMenuItem, value As Boolean)
        onItem.Checked = value
        offItem.Checked = Not value
    End Sub

    Private Sub SaveOptions()
        SaveSetting("Maximus78 Box Option NTSC", OnOff(NTSCToolStripMenuItem.Checked))
        SaveSetting("Maximus78 Box Option PAL", OnOff(PALToolStripMenuItem.Checked))
        SaveSetting("Maximus78 Option Warm Palette", OnOff(paletteWARM.Checked))
        SaveSetting("Maximus78 Option Cool Palette", OnOff(paletteCOOL.Checked))
        SaveSetting("Maximus78 Option Hot Palette", OnOff(paletteHOT.Checked))
        Dim items = VideoItems()
        For i = 0 To items.Length - 1
            SaveSetting("Maximus78 Box Video Option " & VideoNames(i), OnOff(items(i).Checked))
        Next
        SaveSetting("Maximus78 Window Option Stretch", OnOff(stretchON.Checked))
        SaveSetting("Maximus78 Window A7800 Full Screen", OnOff(fullScreenON.Checked))
        SaveSetting("Maximus78 Option Vsync Wait", OnOff(vsyncON.Checked))
        SaveSetting("Maximus78 Option TripleBuffer", OnOff(triplebufferON.Checked))
        SaveSetting("Maximus78 Option XM", OnOff(xmON.Checked))
        SaveSetting("Maximus78 Option HSC", OnOff(hscON.Checked))
        SaveSetting("Maximus78 Option Developer Mode", OnOff(devON.Checked))
        SaveSetting("Maximus78 Option Debug Mode", OnOff(debugON.Checked))
    End Sub

    Private Sub UpdateStatusStrip()
        stripTVType.Text = "TV Type: " & If(PALToolStripMenuItem.Checked, "PAL", "NTSC") & "  "
        stripPalette.Text = "Palette: " & If(paletteCOOL.Checked, "Cool", If(paletteHOT.Checked, "Hot", "Warm")) & "  "
        Dim videoName = "A7800 Default"
        Dim items = VideoItems()
        For i = 0 To items.Length - 1
            If items(i).Checked Then videoName = VideoNames(i)
        Next
        stripVideo.Text = "Video Output: " & videoName & "  "
        stripStretch.Text = "Screen Stretch: " & OnOff(stretchON.Checked) & "  "
        stripWindow.Text = "Window Mode: " & If(fullScreenON.Checked, "Full Screen", "Windowed") & "  "
        stripVsync.Text = "Vsync Wait: " & OnOff(vsyncON.Checked) & "  "
        stripTripleBuffer.Text = "Triple Buffer: " & OnOff(triplebufferON.Checked) & "  "
        stripXM.Text = "XM Support: " & OnOff(xmON.Checked) & "  "
        stripHSC.Text = "HSC Support: " & OnOff(hscON.Checked) & "  "
        stripDev.Text = "Dev Mode: " & OnOff(devON.Checked) & "  "
        stripDebug.Text = "Debug Mode: " & OnOff(debugON.Checked) & "  "
    End Sub

    Private Sub OptionsChanged()
        If _loading Then Return
        SaveOptions()
        UpdateStatusStrip()
        RefreshCommandPreview()
    End Sub

    ''' <summary>Changing the TV type resets the palette to Warm and turns Developer Mode off.</summary>
    Private Sub TVType_Click(sender As Object, e As EventArgs) Handles NTSCToolStripMenuItem.Click, PALToolStripMenuItem.Click
        SelectOne(DirectCast(sender, ToolStripMenuItem), NTSCToolStripMenuItem, PALToolStripMenuItem)
        SelectOne(paletteWARM, paletteWARM, paletteCOOL, paletteHOT)
        SetOnOff(devON, devOFF, False)
        OptionsChanged()
    End Sub

    ''' <summary>The palette is part of the machine name, so picking one turns Developer Mode off.</summary>
    Private Sub Palette_Click(sender As Object, e As EventArgs) Handles paletteWARM.Click, paletteCOOL.Click, paletteHOT.Click
        SelectOne(DirectCast(sender, ToolStripMenuItem), paletteWARM, paletteCOOL, paletteHOT)
        SetOnOff(devON, devOFF, False)
        OptionsChanged()
    End Sub

    Private Sub Developer_Click(sender As Object, e As EventArgs) Handles devON.Click, devOFF.Click
        SetOnOff(devON, devOFF, sender Is devON)
        SelectOne(paletteWARM, paletteWARM, paletteCOOL, paletteHOT)
        OptionsChanged()
    End Sub

    Private Sub Video_Click(sender As Object, e As EventArgs) Handles videoCompatibility.Click, videoBasic.Click, videoCRT.Click, videoCRTDeluxe.Click,
            videoSuperEagle.Click, videoHLSL.Click, videoHQ2x.Click, videoHQ4x.Click
        SelectOne(DirectCast(sender, ToolStripMenuItem), VideoItems())
        OptionsChanged()
    End Sub

    ''' <summary>XM and the High Score Cartridge both use the first cartridge slot, so only one can be on.</summary>
    Private Sub XM_Click(sender As Object, e As EventArgs) Handles xmON.Click, xmOFF.Click
        SetOnOff(xmON, xmOFF, sender Is xmON)
        If xmON.Checked Then SetOnOff(hscON, hscOFF, False)
        OptionsChanged()
    End Sub

    Private Sub HSC_Click(sender As Object, e As EventArgs) Handles hscON.Click, hscOFF.Click
        SetOnOff(hscON, hscOFF, sender Is hscON)
        If hscON.Checked Then SetOnOff(xmON, xmOFF, False)
        OptionsChanged()
    End Sub

    ''' <summary>Simple On/Off menu pairs with no side effects on other options.</summary>
    Private Function OnOffPairs() As List(Of Tuple(Of ToolStripMenuItem, ToolStripMenuItem))
        Return New List(Of Tuple(Of ToolStripMenuItem, ToolStripMenuItem)) From {
            Tuple.Create(stretchON, stretchOFF), Tuple.Create(fullScreenON, fullscreenOFF), Tuple.Create(vsyncON, vsyncOFF),
            Tuple.Create(triplebufferON, triplebufferOFF), Tuple.Create(debugON, debugOFF)}
    End Function

    Private Sub Toggle_Click(sender As Object, e As EventArgs) Handles stretchON.Click, stretchOFF.Click, fullScreenON.Click, fullscreenOFF.Click,
            vsyncON.Click, vsyncOFF.Click, triplebufferON.Click, triplebufferOFF.Click, debugON.Click, debugOFF.Click
        For Each pair In OnOffPairs()
            If sender Is pair.Item1 OrElse sender Is pair.Item2 Then SetOnOff(pair.Item1, pair.Item2, sender Is pair.Item1)
        Next
        OptionsChanged()
    End Sub

    Private Sub ResetAllOptionsToDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAllOptionsToDefaultToolStripMenuItem.Click
        SelectOne(NTSCToolStripMenuItem, NTSCToolStripMenuItem, PALToolStripMenuItem)
        SelectOne(paletteWARM, paletteWARM, paletteCOOL, paletteHOT)
        SelectOne(videoBasic, VideoItems())
        For Each pair In OnOffPairs()
            SetOnOff(pair.Item1, pair.Item2, False)
        Next
        SetOnOff(xmON, xmOFF, False)
        SetOnOff(hscON, hscOFF, False)
        SetOnOff(devON, devOFF, False)
        OptionsChanged()
        MsgBox("All Edit Menu Options set to Default", MsgBoxStyle.Information, "Maximus78")
    End Sub

#End Region

#Region "Folder paths"

    Private Sub ApplyFolders(Optional rescan As Boolean = True)
        LoadPathsFromRegistry()
        LoadFavorites()
        If rescan Then RefreshAllLists()
        If _currentRomName <> "" Then ShowRomInfo(_currentRomName, FindRomPath(_currentRomName)) Else ShowBlankInfo()
    End Sub

    Private Sub FolderSetupMenu_Click(sender As Object, e As EventArgs)
        Using setup As New frmSetup()
            If setup.ShowDialog(Me) = DialogResult.OK Then ApplyFolders()
        End Using
    End Sub

    ''' <summary>Edit menu, Set Game ROM Path: choose the ProPack folder; the category folders are found automatically.</summary>
    Private Sub SetGameROMPathToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetGameROMPathToolStripMenuItem.Click
        Dim root = BrowseForFolder("Select the ROM folder (where Trebor's 7800 ROM PROPack is unzipped)", txtRomPath.Text)
        If root Is Nothing Then Return
        txtRomPath.Text = root
        SaveSetting("Maximus78 ROM Path", root)
        DetectCategoriesInto(root, askToApply:=True)
    End Sub

    Private Sub AutoDetectButton_Click(sender As Object, e As EventArgs)
        Dim root = txtRomPath.Text.Trim()
        If root = "" OrElse Not Directory.Exists(root) Then root = DetectRomRoot(txtA7800path.Text.Trim())
        If root = "" Then
            root = BrowseForFolder("Select the ROM folder (where Trebor's 7800 ROM PROPack is unzipped)", txtA7800path.Text)
            If root Is Nothing Then Return
        End If
        txtRomPath.Text = root
        DetectCategoriesInto(root, askToApply:=False)
    End Sub

    ''' <summary>Fills the category folder boxes from <paramref name="root"/>. Folders that are not found keep their current value.</summary>
    Private Sub DetectCategoriesInto(root As String, askToApply As Boolean)
        Dim found = DetectCategoryFolders(root)
        If found.Count = 0 Then
            MsgBox("No ROM pack category folders (NTSC, PAL, Homebrews, Hacks, Demos, Prototypes, Utilities) were found under:" & vbCrLf & root &
                   vbCrLf & vbCrLf & "You can type the folders on the Directory Paths tab.", MsgBoxStyle.Information, "Maximus78")
            Return
        End If
        Dim summary As New Text.StringBuilder()
        For Each cat In _categories
            Dim p As String = Nothing
            If found.TryGetValue(cat.Category, p) Then
                cat.PathBox.Text = p
                summary.AppendLine($"{cat.Tab.Text}:  {p}")
            Else
                summary.AppendLine($"{cat.Tab.Text}:  (not found, unchanged)")
            End If
        Next
        If askToApply Then
            If MsgBox("Found these ROM folders:" & vbCrLf & vbCrLf & summary.ToString() & vbCrLf & "Use them now?",
                      MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Maximus78") = MsgBoxResult.Yes Then
                btnSaveROMPaths_Click(Nothing, EventArgs.Empty)
            Else
                LoadPathsFromRegistry()
            End If
        Else
            TabControl1.SelectedTab = tabDirectoryPaths
            MsgBox("Found these ROM folders:" & vbCrLf & vbCrLf & summary.ToString() & vbCrLf &
                   "Review or edit them on the Directory Paths tab, then click Save.", MsgBoxStyle.Information, "Maximus78")
        End If
    End Sub

    Private Sub SetGameBoxArtPathToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetGameBoxArtPathToolStripMenuItem.Click
        Dim folder = BrowseForFolder("Select the Box Art folder", _boxArtFolder)
        If folder Is Nothing Then Return
        SaveSetting("Maximus78 Box Art Path", folder)
        ApplyFolders(rescan:=False)
    End Sub

    Private Sub SetManualsScreenshotPathToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetManualsScreenshotPathToolStripMenuItem.Click
        Dim folder = BrowseForFolder("Select the Game Info (manuals and screenshots) folder", _manualsFolder)
        If folder Is Nothing Then Return
        SaveSetting("Maximus78 Manuals Path", folder)
        ApplyFolders(rescan:=False)
    End Sub

    Private Sub SetA7800EmulatorPathToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetA7800EmulatorPathToolStripMenuItem.Click
        Dim folder = BrowseForFolder("Select the A7800 emulator folder (contains a7800.exe)", _a7800Folder)
        If folder Is Nothing Then Return
        If Not File.Exists(Path.Combine(folder, "a7800.exe")) Then
            MsgBox("Note: a7800.exe was not found in that folder.", MsgBoxStyle.Exclamation, "Maximus78")
        End If
        SaveSetting("Maximus78 A7800 Path", folder)
        ApplyFolders(rescan:=False)
    End Sub

    ''' <summary>Directory Paths tab: save the ROM category folders and rescan.</summary>
    Private Sub btnSaveROMPaths_Click(sender As Object, e As EventArgs) Handles btnSaveROMPaths.Click
        For Each cat In _categories
            SaveSetting(cat.RegistryName, cat.PathBox.Text.Trim())
        Next
        SaveSetting("Maximus78 ROM Path", txtRomPath.Text.Trim())
        RefreshAllLists()
    End Sub

    ''' <summary>Directory Paths tab: save the A7800, box art, game info and ROM root folders.</summary>
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SaveSetting("Maximus78 A7800 Path", txtA7800path.Text.Trim())
        SaveSetting("Maximus78 Box Art Path", txtBoxArtPath.Text.Trim())
        SaveSetting("Maximus78 Manuals Path", txtManualsPath.Text.Trim())
        SaveSetting("Maximus78 ROM Path", txtRomPath.Text.Trim())
        ApplyFolders(rescan:=False)
    End Sub

#End Region

#Region "Window layout and status bar"

    Private Sub ApplyDisplayMode(mode As String, save As Boolean)
        Dim listHeight = 632, tabHeight = 660
        Select Case mode
            Case "Med"
                Size = New Size(863, 732)
            Case "Small"
                Size = New Size(474, 355)
                listHeight = 260 : tabHeight = 284
            Case Else
                mode = "Full"
                Size = New Size(1366, 748)
        End Select
        _windowMode = mode
        For Each list In _categories.Select(Function(c) c.List).Concat({lstFavorites})
            list.Height = listHeight
        Next
        TabControlRoms.Height = tabHeight
        displayFULL.Checked = mode = "Full"
        displayMED.Checked = mode = "Med"
        displaySMALL.Checked = mode = "Small"
        ' The status bar only fits in the full-size window.
        StatusStrip1.Visible = mode = "Full" AndAlso GetSetting("Maximus78 StatusBar") = "On"
        statusON.Checked = StatusStrip1.Visible
        statusOFF.Checked = Not StatusStrip1.Visible
        If save Then SaveSetting("Maximus78 Display Mode", mode)
    End Sub

    Private Sub DisplayMode_Click(sender As Object, e As EventArgs) Handles displayFULL.Click, displayMED.Click, displaySMALL.Click
        ApplyDisplayMode(If(sender Is displayMED, "Med", If(sender Is displaySMALL, "Small", "Full")), save:=True)
    End Sub

    Private Sub statusON_Click_1(sender As Object, e As EventArgs) Handles statusON.Click
        If _windowMode <> "Full" Then
            MsgBox("Status Bar Unavailable in this Display Mode", MsgBoxStyle.Information, "Maximus78")
            Return
        End If
        SaveSetting("Maximus78 StatusBar", "On")
        ApplyDisplayMode(_windowMode, save:=False)
    End Sub

    Private Sub statusOFF_Click(sender As Object, e As EventArgs) Handles statusOFF.Click
        SaveSetting("Maximus78 StatusBar", "Off")
        ApplyDisplayMode(_windowMode, save:=False)
    End Sub

#End Region

#Region "High scores"

    Private Shared ReadOnly HighScoreFields As String() = {"Score", "Player", "Date", "Initials"}
    Private Const HighScoreRows As Integer = 27

    Private Iterator Function HighScoreBoxes() As IEnumerable(Of TextBox)
        For Each field In HighScoreFields
            For i = 1 To HighScoreRows
                Dim box = TryCast(Controls.Find("txt" & field & i, True).FirstOrDefault(), TextBox)
                If box IsNot Nothing Then
                    box.Tag = field & i
                    Yield box
                End If
            Next
        Next
    End Function

    Private Sub LoadHighScores()
        For Each box In HighScoreBoxes()
            box.Text = GetHighScore(CStr(box.Tag))
            AddHandler box.TextChanged, AddressOf HighScore_TextChanged
        Next
    End Sub

    Private Sub HighScore_TextChanged(sender As Object, e As EventArgs)
        Dim box = DirectCast(sender, TextBox)
        SaveHighScore(CStr(box.Tag), box.Text)
    End Sub

    Private Sub ResetAllHighScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAllHighScoresToolStripMenuItem.Click
        If MsgBox("Clear the whole high score table?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Maximus78") <> MsgBoxResult.Yes Then Return
        For Each box In HighScoreBoxes()
            box.Text = ""
        Next
    End Sub

#End Region

#Region "Help and other windows"

    Private Sub ShowHelpPage(fileName As String)
        ApplyDisplayMode("Full", save:=True)
        TabEditor.SelectedTab = tabManuals
        NavigateTo(ManualsFile(fileName))
    End Sub

    Private Sub TVAndVideoTipsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TVAndVideoTipsToolStripMenuItem.Click
        ShowHelpPage("A7800_Dev_Tips.htm")
    End Sub

    Private Sub Atari7800ProSystemOwnersManualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Atari7800ProSystemOwnersManualToolStripMenuItem1.Click
        ShowHelpPage("7800_Owners_Manual.htm")
    End Sub

    Private Sub UsersGuideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersGuideToolStripMenuItem.Click
        ShowHelpPage("A7800_Manual.htm")
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub usersguideToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles usersguideToolStripMenuItem3.Click
        frmUserGuide.Show()
    End Sub

    Private Sub EditA7800ConfigurationFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditA7800ConfigurationFileToolStripMenuItem.Click
        frmA7800Config.Show()
    End Sub

    Private Sub ButtonDefinitionsForGamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ButtonDefinitionsForGamesToolStripMenuItem.Click
        frmButtons.Show()
    End Sub

    Private Sub DifficultySwitchOptionsForGamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DifficultySwitchOptionsForGamesToolStripMenuItem.Click
        frmDifficulty.Show()
    End Sub

    Private Sub KeyboardMappingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeyboardMappingsToolStripMenuItem.Click
        frmMappings.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Close()
    End Sub

#End Region

End Class
