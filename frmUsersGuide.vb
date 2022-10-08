Public Class frmUserGuide
    Private Sub frmUserGuide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RichTextBox1.Rtf = My.Resources._Root
        TreeView1.ExpandAll()

    End Sub
    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick

        If e.Node.Text.Equals("Maximus78") Then
            Me.RichTextBox1.Rtf = My.Resources._Root
        End If
        If e.Node.Text.Equals("How is Maximus78 Licensed?") Then
            Me.RichTextBox1.Rtf = My.Resources._License
        End If
        If e.Node.Text.Equals("What are the installation requirements?") Then
            Me.RichTextBox1.Rtf = My.Resources._Requirements
        End If
        If e.Node.Text.Equals("Getting Started") Then
            Me.RichTextBox1.Rtf = My.Resources._GettingStarted
        End If
        If e.Node.Text.Equals("Download the A7800 Windows Package") Then
            Me.RichTextBox1.Rtf = My.Resources._A7800
        End If
        If e.Node.Text.Equals("Download the A7800 Optional Files") Then
            Me.RichTextBox1.Rtf = My.Resources._Optional
        End If
        If e.Node.Text.Equals("Download Trebor's 7800 ROM ProPack") Then
            Me.RichTextBox1.Rtf = My.Resources._ROMs
        End If
        If e.Node.Text.Equals("Download the Game Information archive") Then
            Me.RichTextBox1.Rtf = My.Resources._GameInfo
        End If
        If e.Node.Text.Equals("Download the Box Art zip file for Maximus78") Then
            Me.RichTextBox1.Rtf = My.Resources._BoxArt
        End If
        If e.Node.Text.Equals("Setting up Maximus78") Then
            Me.RichTextBox1.Rtf = My.Resources._Setup
        End If
        If e.Node.Text.Equals("First time Setup") Then
            Me.RichTextBox1.Rtf = My.Resources._FirstTime
        End If
        If e.Node.Text.Equals("Changing Directory Paths") Then
            Me.RichTextBox1.Rtf = My.Resources._DirPaths
        End If
        If e.Node.Text.Equals("Using Maximus78") Then
            Me.RichTextBox1.Rtf = My.Resources._UsingMaximus78
        End If
        If e.Node.Text.Equals("High Scores") Then
            Me.RichTextBox1.Rtf = My.Resources._HighScores
        End If
        If e.Node.Text.Equals("Screenshots") Then
            Me.RichTextBox1.Rtf = My.Resources._Screenshots
        End If
        If e.Node.Text.Equals("Loading") Then
            Me.RichTextBox1.Rtf = My.Resources._Loading
        End If
        If e.Node.Text.Equals("Unloading") Then
            Me.RichTextBox1.Rtf = My.Resources._Unloading
        End If
        If e.Node.Text.Equals("Saving") Then
            Me.RichTextBox1.Rtf = My.Resources._Saving
        End If
        If e.Node.Text.Equals("Game Information Window") Then
            Me.RichTextBox1.Rtf = My.Resources._GameInfoWindow
        End If
        If e.Node.Text.Equals("Game Information HTML Editor") Then
            Me.RichTextBox1.Rtf = My.Resources._GameInfoEditor
        End If
        If e.Node.Text.Equals("Box Art and A7800 Command Window") Then
            Me.RichTextBox1.Rtf = My.Resources._BoxArtCMD
        End If
        If e.Node.Text.Equals("Using the ROM Lists") Then
            Me.RichTextBox1.Rtf = My.Resources._UsingROMs
        End If
        If e.Node.Text.Equals("Favorites") Then
            Me.RichTextBox1.Rtf = My.Resources._Favorites
        End If
        If e.Node.Text.Equals("Launching a Game ROM from the List") Then
            Me.RichTextBox1.Rtf = My.Resources._Launching
        End If
        If e.Node.Text.Equals("Launching an External Game ROM") Then
            Me.RichTextBox1.Rtf = My.Resources._LaunchingExternal
        End If
        If e.Node.Text.Equals("Editing the A7800 Configuration File") Then
            Me.RichTextBox1.Rtf = My.Resources._A7800ConfigEditor
        End If
        If e.Node.Text.Equals("Using the A7800 TV and Video Options") Then
            Me.RichTextBox1.Rtf = My.Resources._UsingTVVideo
        End If
        If e.Node.Text.Equals("TV Type") Then
            Me.RichTextBox1.Rtf = My.Resources._TVType
        End If
        If e.Node.Text.Equals("Video Output") Then
            Me.RichTextBox1.Rtf = My.Resources._VideoOutput
        End If
        If e.Node.Text.Equals("Palette Colors") Then
            Me.RichTextBox1.Rtf = My.Resources._Palette
        End If
        If e.Node.Text.Equals("Screen Stretch") Then
            Me.RichTextBox1.Rtf = My.Resources._ScreenStretch
        End If
        If e.Node.Text.Equals("Window Mode") Then
            Me.RichTextBox1.Rtf = My.Resources._WindowMode
        End If
        If e.Node.Text.Equals("Vsync Wait") Then
            Me.RichTextBox1.Rtf = My.Resources._VsyncWait
        End If
        If e.Node.Text.Equals("Triple Buffer") Then
            Me.RichTextBox1.Rtf = My.Resources._TripleBuffer
        End If
        If e.Node.Text.Equals("Using the A7800 Hardware Options") Then
            Me.RichTextBox1.Rtf = My.Resources._A7800Hardware
        End If
        If e.Node.Text.Equals("XM") Then
            Me.RichTextBox1.Rtf = My.Resources._XM
        End If
        If e.Node.Text.Equals("High Score Cartridge") Then
            Me.RichTextBox1.Rtf = My.Resources._HSC
        End If
        If e.Node.Text.Equals("Using the A7800 Developer Options") Then
            Me.RichTextBox1.Rtf = My.Resources._A7800Dev
        End If
        If e.Node.Text.Equals("Developer Mode") Then
            Me.RichTextBox1.Rtf = My.Resources._DevMode
        End If
        If e.Node.Text.Equals("Debug Mode") Then
            Me.RichTextBox1.Rtf = My.Resources._DebugMode
        End If
        If e.Node.Text.Equals("Other Options") Then
            Me.RichTextBox1.Rtf = My.Resources._Other
        End If
        If e.Node.Text.Equals("Defaults") Then
            Me.RichTextBox1.Rtf = My.Resources._Defaults
        End If
        If e.Node.Text.Equals("Getting Help") Then
            Me.RichTextBox1.Rtf = My.Resources._GettingHelp
        End If



    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub
End Class