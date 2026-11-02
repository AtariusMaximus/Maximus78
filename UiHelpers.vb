Imports System.IO

''' <summary>Small Windows Forms helpers shared by the forms.</summary>
Public Module UiHelpers

    ''' <summary>
    ''' Shows the Explorer-style dialog and lets the user pick a folder. Returns Nothing when cancelled, so a
    ''' cancelled dialog never wipes out a path that was already set.
    ''' </summary>
    Public Function BrowseForFolder(title As String, Optional initialFolder As String = "") As String
        Using dlg As New OpenFileDialog With {
            .Title = title & "  (open the folder, then click Open)",
            .ValidateNames = False,
            .CheckFileExists = False,
            .CheckPathExists = True,
            .FileName = "Select this folder",
            .Filter = "Folders|no.files",
            .AutoUpgradeEnabled = True}
            If Not String.IsNullOrWhiteSpace(initialFolder) AndAlso Directory.Exists(initialFolder) Then
                dlg.InitialDirectory = initialFolder
            End If
            If dlg.ShowDialog() <> DialogResult.OK Then Return Nothing
            Dim folder = Path.GetDirectoryName(dlg.FileName)
            Return If(Directory.Exists(folder), folder, Nothing)
        End Using
    End Function

    ''' <summary>Asks for an image file. Returns Nothing when cancelled.</summary>
    Public Function BrowseForImage(title As String, Optional initialFolder As String = "") As String
        Using dlg As New OpenFileDialog With {
            .Title = title,
            .CheckFileExists = True,
            .Filter = "Images (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*"}
            If Not String.IsNullOrWhiteSpace(initialFolder) AndAlso Directory.Exists(initialFolder) Then
                dlg.InitialDirectory = initialFolder
            End If
            Return If(dlg.ShowDialog() = DialogResult.OK, dlg.FileName, Nothing)
        End Using
    End Function

    ''' <summary>
    ''' Loads an image without keeping the file open (Image.FromFile locks the file until the image is
    ''' disposed, which is why deleting or replacing screenshots used to fail). Returns Nothing on any error.
    ''' </summary>
    Public Function LoadImageUnlocked(file As String) As Image
        Try
            If String.IsNullOrEmpty(file) OrElse Not IO.File.Exists(file) Then Return Nothing
            Using ms As New MemoryStream(IO.File.ReadAllBytes(file))
                Using img = Image.FromStream(ms)
                    Return New Bitmap(img)
                End Using
            End Using
        Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>Replaces a picture box background image and frees the previous one.</summary>
    Public Sub SetBackground(box As Control, img As Image)
        Dim old = box.BackgroundImage
        box.BackgroundImage = img
        If old IsNot Nothing AndAlso old IsNot img Then old.Dispose()
    End Sub

End Module
