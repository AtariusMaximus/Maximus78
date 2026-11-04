Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Win32

''' <summary>
''' One ROM found on disk. <see cref="Name"/> is the file name without extension and is the key used
''' to look up box art, game info (.htm) and screenshots. <see cref="Display"/> is what the list shows.
''' </summary>
Public Class RomEntry
    Public ReadOnly Property Name As String
    Public ReadOnly Property FullPath As String
    Public Property Display As String

    Public Sub New(fullPath As String)
        Me.FullPath = fullPath
        Me.Name = Path.GetFileNameWithoutExtension(fullPath)
        Me.Display = Me.Name
    End Sub

    Public Overrides Function ToString() As String
        Return Display
    End Function
End Class

Public Enum RomCategory
    NTSCRetail
    PALRetail
    Homebrews
    Hacks
    Demos
    Prototypes
    Utilities
End Enum

''' <summary>
''' Folder scanning, folder auto-detection and artwork lookup. Nothing in here depends on Windows Forms,
''' so it can be exercised on its own.
''' </summary>
Public Module RomLibrary

    ''' <summary>ROM file extensions that are listed.</summary>
    Public ReadOnly RomExtensions As String() = {".a78"}

    ''' <summary>
    ''' Sub-folders that are never scanned. The ProPack ships a "Concerto" folder with builds tuned for that
    ''' cartridge; the regular builds are already in the normal folders, so scanning it would only add duplicates.
    ''' </summary>
    Public ReadOnly ExcludedFolderNames As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {"Concerto"}

    Public ReadOnly ImageExtensions As String() = {".png", ".jpg", ".jpeg", ".gif", ".bmp"}

    Private Const MaxScanDepth As Integer = 8

#Region "ROM scanning"

    ''' <summary>
    ''' Returns every ROM in <paramref name="folder"/> and all of its sub-folders (the ProPack's A, B, C, #... letter
    ''' folders), merged into one alphabetical list. A missing or blank folder returns an empty list.
    ''' </summary>
    Public Function ScanFolder(folder As String) As List(Of RomEntry)
        Dim result As New List(Of RomEntry)
        If String.IsNullOrWhiteSpace(folder) OrElse Not Directory.Exists(folder) Then Return result

        CollectRoms(folder, 0, result)
        result.Sort(Function(a, b) NaturalCompare(a.Name, b.Name))

        ' Two files with the same name in different sub-folders: keep both, tag the extras with their folder.
        Dim seen As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
        For Each rom In result
            If Not seen.Add(rom.Name) Then
                rom.Display = rom.Name & "  [" & RelativeFolder(folder, rom.FullPath) & "]"
            End If
        Next
        Return result
    End Function

    Private Sub CollectRoms(folder As String, depth As Integer, result As List(Of RomEntry))
        Try
            For Each file In Directory.EnumerateFiles(folder)
                If RomExtensions.Contains(Path.GetExtension(file), StringComparer.OrdinalIgnoreCase) Then
                    result.Add(New RomEntry(file))
                End If
            Next
            If depth >= MaxScanDepth Then Return
            For Each subFolder In Directory.EnumerateDirectories(folder)
                If Not ExcludedFolderNames.Contains(Path.GetFileName(subFolder)) Then
                    CollectRoms(subFolder, depth + 1, result)
                End If
            Next
        Catch ex As UnauthorizedAccessException
        Catch ex As IOException
        End Try
    End Sub

    Private Function RelativeFolder(root As String, file As String) As String
        Dim dir = Path.GetDirectoryName(file)
        Dim rootFull = Path.GetFullPath(root).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
        Dim dirFull = Path.GetFullPath(dir)
        If dirFull.StartsWith(rootFull, StringComparison.OrdinalIgnoreCase) Then
            Dim rel = dirFull.Substring(rootFull.Length).TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
            If rel.Length > 0 Then Return rel
        End If
        Return Path.GetFileName(dir)
    End Function

#End Region

#Region "Folder auto-detection"

    Private ReadOnly CategoryPatterns As New Dictionary(Of RomCategory, Regex) From {
        {RomCategory.NTSCRetail, New Regex("(^|[^a-z])ntsc($|[^a-z])", RegexOptions.IgnoreCase)},
        {RomCategory.PALRetail, New Regex("(^|[^a-z])pal($|[^a-z])", RegexOptions.IgnoreCase)},
        {RomCategory.Homebrews, New Regex("(^|[^a-z])homebrews?($|[^a-z])", RegexOptions.IgnoreCase)},
        {RomCategory.Hacks, New Regex("(^|[^a-z])hacks?($|[^a-z])", RegexOptions.IgnoreCase)},
        {RomCategory.Demos, New Regex("(^|[^a-z])demos?($|[^a-z])", RegexOptions.IgnoreCase)},
        {RomCategory.Prototypes, New Regex("(^|[^a-z])proto(type)?s?($|[^a-z])", RegexOptions.IgnoreCase)},
        {RomCategory.Utilities, New Regex("(^|[^a-z])utilit(y|ies)($|[^a-z])", RegexOptions.IgnoreCase)}
    }

    ''' <summary>
    ''' Looks under <paramref name="romRoot"/> for the ProPack category folders (Retail\NTSC, Retail\PAL, Homebrews,
    ''' Hacks, Demos, Prototypes, Utilities). Categories that cannot be found are left out of the result.
    ''' When several versions of the pack are side by side, the newest-looking folder name wins.
    ''' </summary>
    Public Function DetectCategoryFolders(romRoot As String) As Dictionary(Of RomCategory, String)
        Dim found As New Dictionary(Of RomCategory, String)
        If String.IsNullOrWhiteSpace(romRoot) OrElse Not Directory.Exists(romRoot) Then Return found

        Dim candidates As New Dictionary(Of RomCategory, List(Of String))
        For Each cat As RomCategory In [Enum].GetValues(GetType(RomCategory))
            candidates(cat) = New List(Of String)
        Next

        ' Breadth-first walk. A folder that matches a category is not descended into, so the letter
        ' folders below it are never mistaken for anything else.
        Dim queue As New Queue(Of Tuple(Of String, Integer))
        queue.Enqueue(Tuple.Create(romRoot, 0))
        Dim visited = 0
        While queue.Count > 0 AndAlso visited < 5000
            Dim item = queue.Dequeue()
            visited += 1
            Dim subFolders As String()
            Try
                subFolders = Directory.GetDirectories(item.Item1)
            Catch ex As Exception
                Continue While
            End Try
            For Each subFolder In subFolders
                Dim name = Path.GetFileName(subFolder)
                If ExcludedFolderNames.Contains(name) Then Continue For
                Dim matched = False
                For Each kv In CategoryPatterns
                    If kv.Value.IsMatch(name) Then
                        candidates(kv.Key).Add(subFolder)
                        matched = True
                        Exit For
                    End If
                Next
                If Not matched AndAlso item.Item2 < 4 Then queue.Enqueue(Tuple.Create(subFolder, item.Item2 + 1))
            Next
        End While

        For Each kv In candidates
            If kv.Value.Count = 0 Then Continue For
            Dim best = kv.Value.
                OrderBy(Function(p) If(IsRetailRegion(kv.Key) AndAlso Not p.ToLowerInvariant().Contains("retail"), 1, 0)).
                ThenByDescending(Function(p) p, Comparer(Of String).Create(AddressOf NaturalCompare)).
                First()
            found(kv.Key) = best
        Next
        Return found
    End Function

    Private Function IsRetailRegion(cat As RomCategory) As Boolean
        Return cat = RomCategory.NTSCRetail OrElse cat = RomCategory.PALRetail
    End Function

    ''' <summary>Finds a folder that contains a7800.exe in the usual install locations, or returns "".</summary>
    Public Function DetectA7800Folder() As String
        Dim roots As New List(Of String)
        Dim baseDir = AppDomain.CurrentDomain.BaseDirectory
        roots.Add(baseDir)
        Try
            Dim parent = Directory.GetParent(baseDir.TrimEnd(Path.DirectorySeparatorChar))
            If parent IsNot Nothing Then roots.Add(parent.FullName)
        Catch
        End Try
        For Each special In {Environment.SpecialFolder.UserProfile, Environment.SpecialFolder.MyDocuments,
                             Environment.SpecialFolder.DesktopDirectory, Environment.SpecialFolder.ProgramFiles,
                             Environment.SpecialFolder.ProgramFilesX86}
            Dim p = Environment.GetFolderPath(special)
            If p <> "" Then roots.Add(p)
        Next
        Dim profile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        If profile <> "" Then roots.Add(Path.Combine(profile, "Downloads"))
        Try
            For Each drive In DriveInfo.GetDrives()
                If drive.DriveType = DriveType.Fixed AndAlso drive.IsReady Then
                    roots.Add(drive.RootDirectory.FullName)
                    roots.Add(Path.Combine(drive.RootDirectory.FullName, "Emulators"))
                    roots.Add(Path.Combine(drive.RootDirectory.FullName, "Emulation"))
                    roots.Add(Path.Combine(drive.RootDirectory.FullName, "Games"))
                End If
            Next
        Catch
        End Try

        For Each root In roots
            If ContainsA7800(root) Then Return root.TrimEnd(Path.DirectorySeparatorChar)
            ' Also check folders such as "a7800", "A7800-win-v5.2" directly below the root.
            Try
                If Not Directory.Exists(root) Then Continue For
                For Each subFolder In Directory.GetDirectories(root)
                    If Path.GetFileName(subFolder).StartsWith("a7800", StringComparison.OrdinalIgnoreCase) AndAlso ContainsA7800(subFolder) Then
                        Return subFolder
                    End If
                Next
            Catch
            End Try
        Next
        Return ""
    End Function

    Private Function ContainsA7800(folder As String) As Boolean
        Try
            Return Directory.Exists(folder) AndAlso File.Exists(Path.Combine(folder, "a7800.exe"))
        Catch
            Return False
        End Try
    End Function

    ''' <summary>Returns the first of <paramref name="names"/> that exists below <paramref name="parent"/>, or "".</summary>
    Public Function FindSubfolder(parent As String, ParamArray names As String()) As String
        If String.IsNullOrWhiteSpace(parent) OrElse Not Directory.Exists(parent) Then Return ""
        For Each n In names
            Dim p = Path.Combine(parent, n)
            If Directory.Exists(p) Then Return p
        Next
        Return ""
    End Function

    Public Function DetectRomRoot(a7800Folder As String) As String
        Return FindSubfolder(a7800Folder, "roms", "ROMs", "Roms", "rom")
    End Function

    Public Function DetectBoxArtFolder(a7800Folder As String) As String
        Return FindSubfolder(a7800Folder, "boxart", "BoxArt", "Box Art", "box_art", "covers", "artwork")
    End Function

    Public Function DetectGameInfoFolder(a7800Folder As String) As String
        Return FindSubfolder(a7800Folder, "gameinfo", "GameInfo", "Game Info", "game_info", "manuals")
    End Function

#End Region

#Region "Helpers"

    ''' <summary>The part of a ROM or image name before the first " (" tag, e.g. "Donkey Kong (NTSC) (Atari)" → "Donkey Kong".</summary>
    Public Function BaseTitle(name As String) As String
        Dim i = name.IndexOf(" (", StringComparison.Ordinal)
        Dim t = If(i > 0, name.Substring(0, i), name)
        i = t.IndexOf(" [", StringComparison.Ordinal)
        If i > 0 Then t = t.Substring(0, i)
        Return t.Trim()
    End Function

    ''' <summary>Lower-case letters and digits only, so "K.C. Munchkin" and "KC Munchkin" compare equal.</summary>
    Public Function NormalizeTitle(s As String) As String
        Dim sb As New Text.StringBuilder(s.Length)
        For Each c In s.ToLowerInvariant()
            If Char.IsLetterOrDigit(c) Then sb.Append(c)
        Next
        Return sb.ToString()
    End Function

    ''' <summary>Case-insensitive compare that orders "Game 2" before "Game 10".</summary>
    Public Function NaturalCompare(a As String, b As String) As Integer
        If a Is Nothing Then Return If(b Is Nothing, 0, -1)
        If b Is Nothing Then Return 1
        Dim i = 0, j = 0
        While i < a.Length AndAlso j < b.Length
            If Char.IsDigit(a(i)) AndAlso Char.IsDigit(b(j)) Then
                Dim si = i, sj = j
                While i < a.Length AndAlso Char.IsDigit(a(i)) : i += 1 : End While
                While j < b.Length AndAlso Char.IsDigit(b(j)) : j += 1 : End While
                Dim na = a.Substring(si, i - si).TrimStart("0"c)
                Dim nb = b.Substring(sj, j - sj).TrimStart("0"c)
                If na.Length <> nb.Length Then Return na.Length.CompareTo(nb.Length)
                Dim c = String.CompareOrdinal(na, nb)
                If c <> 0 Then Return c
            Else
                Dim c = Char.ToLowerInvariant(a(i)).CompareTo(Char.ToLowerInvariant(b(j)))
                If c <> 0 Then Return c
                i += 1 : j += 1
            End If
        End While
        Return (a.Length - i).CompareTo(b.Length - j)
    End Function

#End Region

End Module

''' <summary>
''' Index of the box art folder. Replaces the old per-game If blocks: a ROM gets its art from, in order,
''' 1) an image with exactly the ROM's name, 2) the alias table, 3) an image whose title (text before the
''' first "(") matches, preferring clean retail scans such as "Title (USA).jpg" over hacks.
''' </summary>
Public Class BoxArtIndex

    ''' <summary>
    ''' Titles whose box art is named differently from the ROM. Keys are normalized base titles, values are image
    ''' names without extension. Users can add their own in "BoxArtAliases.txt" in the box art folder,
    ''' one per line as "ROM title = image name".
    ''' </summary>
    Private Shared ReadOnly BuiltInAliases As String(,) = {
        {"Donkey Kong Jr", "Donkey Kong Junior (USA)"},
        {"Baseball", "RealSports Baseball (USA)"},
        {"Bentley Bear's Crystal Quest", "Crystal Quest featuring Bentley Bear (USA) (Unl)"},
        {"Super Circus Atari Age", "Super Circus (USA) (Unl)"},
        {"Pac-Man Collection - 40th Anniversary Edition", "Pac-Man Collection (USA) (Unl)"},
        {"AtariLab - Temperature Module", "AtariLab - Temperature (Prototype)"}
    }

    Public Const AliasFileName As String = "BoxArtAliases.txt"

    Private ReadOnly _exact As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
    Private ReadOnly _byTitle As New Dictionary(Of String, List(Of String))
    Private ReadOnly _aliases As New Dictionary(Of String, String)

    Public ReadOnly Property Folder As String

    Public Sub New(folder As String)
        Me.Folder = If(folder, "")
        For i = 0 To BuiltInAliases.GetUpperBound(0)
            _aliases(NormalizeTitle(BuiltInAliases(i, 0))) = BuiltInAliases(i, 1)
        Next
        If Me.Folder = "" OrElse Not Directory.Exists(Me.Folder) Then Return

        Dim files As String() = {}
        Try
            files = Directory.GetFiles(Me.Folder)
        Catch
        End Try
        For Each f In files
            Dim ext = Path.GetExtension(f)
            If Not ImageExtensions.Contains(ext, StringComparer.OrdinalIgnoreCase) Then Continue For
            Dim name = Path.GetFileNameWithoutExtension(f)
            ' Backups written by "Update Box Art" are never shown.
            If name.EndsWith(".backup", StringComparison.OrdinalIgnoreCase) Then Continue For
            ' Same name in several formats: PNG wins, as before.
            If Not _exact.ContainsKey(name) OrElse ext.Equals(".png", StringComparison.OrdinalIgnoreCase) Then _exact(name) = f
            Dim key = NormalizeTitle(BaseTitle(name))
            If key = "" Then Continue For
            Dim list As List(Of String) = Nothing
            If Not _byTitle.TryGetValue(key, list) Then
                list = New List(Of String)
                _byTitle(key) = list
            End If
            list.Add(f)
        Next

        Dim aliasFile = Path.Combine(Me.Folder, AliasFileName)
        If File.Exists(aliasFile) Then
            Try
                For Each line In File.ReadAllLines(aliasFile)
                    Dim t = line.Trim()
                    If t = "" OrElse t.StartsWith("#") OrElse t.StartsWith("'") Then Continue For
                    Dim sep = t.IndexOf("="c)
                    If sep <= 0 Then Continue For
                    Dim key = NormalizeTitle(BaseTitle(t.Substring(0, sep).Trim()))
                    Dim value = t.Substring(sep + 1).Trim()
                    Dim valueExt = Path.GetExtension(value)
                    If ImageExtensions.Contains(valueExt, StringComparer.OrdinalIgnoreCase) Then value = Path.GetFileNameWithoutExtension(value)
                    If key <> "" AndAlso value <> "" Then _aliases(key) = value
                Next
            Catch
            End Try
        End If
    End Sub

    ''' <summary>Full path of the best box art for <paramref name="romName"/>, or Nothing.</summary>
    Public Function Resolve(romName As String) As String
        If String.IsNullOrEmpty(romName) Then Return Nothing
        Dim hit As String = Nothing
        If _exact.TryGetValue(romName, hit) Then Return hit

        Dim key = NormalizeTitle(BaseTitle(romName))
        Dim aliasName As String = Nothing
        If _aliases.TryGetValue(key, aliasName) AndAlso _exact.TryGetValue(aliasName, hit) Then Return hit

        Dim candidates As List(Of String) = Nothing
        If Not _byTitle.TryGetValue(key, candidates) Then Return Nothing

        Dim romLower = romName.ToLowerInvariant()
        Dim isPal = romLower.Contains("(pal)")
        Dim isHack = romLower.Contains("hack")
        Return candidates.
            OrderBy(Function(f)
                        Dim n = Path.GetFileNameWithoutExtension(f).ToLowerInvariant()
                        Dim score = 0
                        If n.Contains("hack") AndAlso Not isHack Then score += 10
                        If isPal Then
                            If n.Contains("(europe)") Then score -= 3
                            If n.Contains("(pal)") Then score -= 2
                            If n.Contains("(usa)") Then score -= 1
                        Else
                            If n.Contains("(usa)") Then score -= 3
                            If n.Contains("(ntsc)") Then score -= 2
                        End If
                        Return score
                    End Function).
            ThenBy(Function(f) Path.GetFileName(f).Length).
            First()
    End Function
End Class

''' <summary>Read/write helpers for HKCU\Software\Maximus78 (the same keys every earlier version used).</summary>
Public Module AppSettings
    Public Const RegistryPath As String = "Software\Maximus78"

    Public Function GetSetting(name As String, Optional defaultValue As String = "") As String
        Try
            Using key = Registry.CurrentUser.OpenSubKey(RegistryPath)
                If key Is Nothing Then Return defaultValue
                Dim v = key.GetValue(name)
                If v Is Nothing Then Return defaultValue
                Return v.ToString()
            End Using
        Catch
            Return defaultValue
        End Try
    End Function

    Public Sub SaveSetting(name As String, value As String)
        Try
            Using key = Registry.CurrentUser.CreateSubKey(RegistryPath)
                key.SetValue(name, If(value, ""))
            End Using
        Catch
        End Try
    End Sub

    Public Function GetHighScore(name As String) As String
        Try
            Using key = Registry.CurrentUser.OpenSubKey(RegistryPath & "\High_Scores")
                If key Is Nothing Then Return ""
                Return If(key.GetValue(name), "").ToString()
            End Using
        Catch
            Return ""
        End Try
    End Function

    Public Sub SaveHighScore(name As String, value As String)
        Try
            Using key = Registry.CurrentUser.CreateSubKey(RegistryPath & "\High_Scores")
                key.SetValue(name, If(value, ""))
            End Using
        Catch
        End Try
    End Sub

    ''' <summary>True when a stored folder setting is unset or still holds a placeholder from older versions.</summary>
    Public Function IsUnsetPath(value As String) As Boolean
        Return String.IsNullOrWhiteSpace(value) OrElse value = "1" OrElse value = "Change Folder Path"
    End Function
End Module
