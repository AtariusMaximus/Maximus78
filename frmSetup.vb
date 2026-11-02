Imports System.IO

''' <summary>
''' First-time setup (also available later from Edit > Folder Setup &amp; Auto-Detect). Every folder is
''' detected automatically where possible and can then be edited or browsed before clicking Continue.
''' Returns DialogResult.OK when the folders were saved.
''' </summary>
Public Class frmSetup

    Private _firstRun As Boolean
    Private _categoryBoxes As Dictionary(Of RomCategory, TextBox)

    Private Shared ReadOnly CategoryRegistryNames As New Dictionary(Of RomCategory, String) From {
        {RomCategory.NTSCRetail, "Maximus78 NTSC Retail ROM Subfolder"},
        {RomCategory.PALRetail, "Maximus78 PAL Retail ROM Subfolder"},
        {RomCategory.Homebrews, "Maximus78 Homebrews ROM Subfolder"},
        {RomCategory.Hacks, "Maximus78 Hacks ROM Subfolder"},
        {RomCategory.Demos, "Maximus78 Demos ROM Subfolder"},
        {RomCategory.Prototypes, "Maximus78 Prototypes ROM Subfolder"},
        {RomCategory.Utilities, "Maximus78 Utilities ROM Subfolder"}
    }

    Private Sub frmSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        _firstRun = IsUnsetPath(GetSetting("Maximus78 A7800 Path"))
        _categoryBoxes = New Dictionary(Of RomCategory, TextBox) From {
            {RomCategory.NTSCRetail, txtNTSCRetailPath},
            {RomCategory.PALRetail, txtPALRetailPath},
            {RomCategory.Homebrews, txtHomebrewPath},
            {RomCategory.Hacks, txtHacksPath},
            {RomCategory.Demos, txtDemosPath},
            {RomCategory.Prototypes, txtProtosPath},
            {RomCategory.Utilities, txtUtilitiesPath}
        }

        Try
            WebBrowser1.DocumentText = My.Resources.setup
        Catch
        End Try

        Label2.Text = "Folders are detected automatically. Review them, type a different path or click [.] to browse, then click Continue."
        Dim btnAutoDetect As New Button With {
            .Text = "Auto-Detect Folders",
            .Size = New Size(170, frmContinue.Height),
            .Location = New Point(frmContinue.Left - 180, frmContinue.Top)}
        AddHandler btnAutoDetect.Click, Sub() AutoDetect(overwrite:=True)
        frmContinue.Parent.Controls.Add(btnAutoDetect)

        If _firstRun Then
            AutoDetect(overwrite:=True)
        Else
            Text = "Maximus78 Folder Setup"
            TextBox4.Text = "  Review the folders Maximus78 uses. Auto-Detect fills in anything it can find; you can edit every path before clicking Continue."
            Button10.Text = "Cancel"
            txtA7800path.Text = StoredPath("Maximus78 A7800 Path")
            txtRomPath.Text = StoredPath("Maximus78 ROM Path")
            txtBoxArtPath.Text = StoredPath("Maximus78 Box Art Path")
            txtManualsPath.Text = StoredPath("Maximus78 Manuals Path")
            For Each kv In _categoryBoxes
                kv.Value.Text = StoredPath(CategoryRegistryNames(kv.Key))
            Next
            TabControl1.SelectedTab = TabPage2
        End If
    End Sub

    Private Shared Function StoredPath(name As String) As String
        Dim v = GetSetting(name)
        Return If(IsUnsetPath(v), "", v.Trim())
    End Function

    ''' <summary>
    ''' Fills in the folders: A7800 (where a7800.exe is), then its roms, boxart and gameinfo sub-folders, then the
    ''' ROM pack category folders below the ROM folder. With overwrite off, only empty boxes are filled.
    ''' </summary>
    Private Sub AutoDetect(overwrite As Boolean)
        Cursor = Cursors.WaitCursor
        Try
            Dim a7800 = txtA7800path.Text.Trim()
            If a7800 = "" OrElse Not File.Exists(Path.Combine(a7800, "a7800.exe")) Then
                Dim found = DetectA7800Folder()
                If found <> "" Then a7800 = found
            End If
            Fill(txtA7800path, a7800, overwrite)
            Fill(txtRomPath, DetectRomRoot(a7800), overwrite AndAlso Not Directory.Exists(txtRomPath.Text.Trim()))
            Fill(txtBoxArtPath, DetectBoxArtFolder(a7800), overwrite AndAlso Not Directory.Exists(txtBoxArtPath.Text.Trim()))
            Fill(txtManualsPath, DetectGameInfoFolder(a7800), overwrite AndAlso Not Directory.Exists(txtManualsPath.Text.Trim()))
            DetectCategories(overwrite)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DetectCategories(overwrite As Boolean)
        Dim found = DetectCategoryFolders(txtRomPath.Text.Trim())
        For Each kv In _categoryBoxes
            Dim p As String = Nothing
            If found.TryGetValue(kv.Key, p) Then Fill(kv.Value, p, overwrite)
        Next
    End Sub

    Private Shared Sub Fill(box As TextBox, value As String, overwrite As Boolean)
        If String.IsNullOrEmpty(value) Then Return
        If overwrite OrElse box.Text.Trim() = "" Then box.Text = value
    End Sub

    Private Sub Browse(box As TextBox, title As String)
        Dim folder = BrowseForFolder(title, If(box.Text.Trim() <> "", box.Text.Trim(), txtRomPath.Text.Trim()))
        If folder IsNot Nothing Then box.Text = folder
    End Sub

    Private Sub btnA7800_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Browse(txtA7800path, "Select the A7800 emulator folder (contains a7800.exe)")
        ' Fill in anything still blank from the new A7800 folder.
        AutoDetect(overwrite:=False)
    End Sub

    Private Sub btnGameROMpath_Click(sender As Object, e As EventArgs) Handles btnGameROMpath.Click
        Dim before = txtRomPath.Text
        Browse(txtRomPath, "Select the ROM folder (where Trebor's 7800 ROM PROPack is unzipped)")
        If txtRomPath.Text <> before Then DetectCategories(overwrite:=True)
    End Sub

    Private Sub btnBoxArtPath_Click(sender As Object, e As EventArgs) Handles btnBoxArtPath.Click
        Browse(txtBoxArtPath, "Select the Box Art folder")
    End Sub

    Private Sub btnManuals_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Browse(txtManualsPath, "Select the Game Info (manuals and screenshots) folder")
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Dim map As New Dictionary(Of Object, Tuple(Of TextBox, String)) From {
            {Button3, Tuple.Create(txtNTSCRetailPath, "NTSC Retail")},
            {Button4, Tuple.Create(txtPALRetailPath, "PAL Retail")},
            {Button5, Tuple.Create(txtHomebrewPath, "Homebrews")},
            {Button6, Tuple.Create(txtHacksPath, "Hacks")},
            {Button7, Tuple.Create(txtDemosPath, "Demos")},
            {Button8, Tuple.Create(txtProtosPath, "Prototypes")},
            {Button9, Tuple.Create(txtUtilitiesPath, "Utilities")}
        }
        Dim target = map(sender)
        Browse(target.Item1, "Select the " & target.Item2 & " ROM folder")
    End Sub

    Private Sub frmContinue_Click(sender As Object, e As EventArgs) Handles frmContinue.Click
        Dim a7800 = txtA7800path.Text.Trim()
        If a7800 = "" OrElse Not File.Exists(Path.Combine(a7800, "a7800.exe")) Then
            If MsgBox("a7800.exe was not found in the A7800 folder:" & vbCrLf & If(a7800 = "", "(blank)", a7800) & vbCrLf & vbCrLf &
                      "Games cannot be started until this is set. Continue anyway?",
                      MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Maximus78") <> MsgBoxResult.Yes Then Return
        End If

        SaveSetting("Maximus78 A7800 Path", a7800)
        SaveSetting("Maximus78 ROM Path", txtRomPath.Text.Trim())
        SaveSetting("Maximus78 Box Art Path", txtBoxArtPath.Text.Trim())
        SaveSetting("Maximus78 Manuals Path", txtManualsPath.Text.Trim())
        For Each kv In _categoryBoxes
            SaveSetting(CategoryRegistryNames(kv.Key), kv.Value.Text.Trim())
        Next

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class
