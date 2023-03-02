<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Public strMsg As String
    'Global Variables (SE)
    Dim strFolder As String = ""
    Dim strFolderPAL As String = ""
    Dim strFolderHomebrews As String = ""
    Dim strFolderHacks As String = ""
    Dim strFolderDemos As String = ""
    Dim strFolderProtos As String = ""
    Dim strFolderUtilities As String = ""
    Dim strA7800Folder As String = ""
    Dim strBoxArtFolder As String = ""
    Dim strManualsFolder As String = ""
    Dim strArguments As String = ""
    Dim strAddArguments As String = ""
    Dim strDebug As String = ""
    Dim strFileName As String = ""
    Dim strTVTYPE As String = ""
    Dim strWindowMode As String = ""
    Dim strStatusBar As String = ""
    Dim strVideo As String = ""
    Dim strStretch As String = ""
    Dim strA7800WindowMode As String = ""
    Dim strVsync As String = ""
    Dim strTripleBuffer As String = ""

    Private Const MAX_RECENT_FILES As Integer = 10


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtA7800path = New System.Windows.Forms.TextBox()
        Me.txtRomPath = New System.Windows.Forms.TextBox()
        Me.txtBoxArtPath = New System.Windows.Forms.TextBox()
        Me.txtManualsPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.TabControlRoms = New System.Windows.Forms.TabControl()
        Me.tabNTSC = New System.Windows.Forms.TabPage()
        Me.lstNTSCRetail = New System.Windows.Forms.ListBox()
        Me.contextNTSC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.contextNTSCRetail = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddScreenshotsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addImage1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.addImage2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.addImage3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.addImage4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.addImage5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.addImage6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabPAL = New System.Windows.Forms.TabPage()
        Me.lstPALRetail = New System.Windows.Forms.ListBox()
        Me.tabHomebrews = New System.Windows.Forms.TabPage()
        Me.lstHomebrews = New System.Windows.Forms.ListBox()
        Me.tabHacks = New System.Windows.Forms.TabPage()
        Me.lstHacks = New System.Windows.Forms.ListBox()
        Me.tabDemos = New System.Windows.Forms.TabPage()
        Me.lstDemos = New System.Windows.Forms.ListBox()
        Me.tabProtos = New System.Windows.Forms.TabPage()
        Me.lstProtos = New System.Windows.Forms.ListBox()
        Me.tabUtilities = New System.Windows.Forms.TabPage()
        Me.lstUtilities = New System.Windows.Forms.ListBox()
        Me.tabFavorites = New System.Windows.Forms.TabPage()
        Me.lstFavorites = New System.Windows.Forms.ListBox()
        Me.contextFavorites = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveFromFavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAllFavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNTSCRetailPath = New System.Windows.Forms.TextBox()
        Me.btnSaveROMPaths = New System.Windows.Forms.Button()
        Me.txtPALRetailPath = New System.Windows.Forms.TextBox()
        Me.txtHomebrewPath = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtHacksPath = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDemosPath = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProtosPath = New System.Windows.Forms.TextBox()
        Me.txtUtilitiesPath = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtRootROMPath = New System.Windows.Forms.TextBox()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusTVType = New System.Windows.Forms.ToolStripTextBox()
        Me.statusPalette = New System.Windows.Forms.ToolStripTextBox()
        Me.statusXMhw = New System.Windows.Forms.ToolStripTextBox()
        Me.statusHSC = New System.Windows.Forms.ToolStripTextBox()
        Me.statusDebug = New System.Windows.Forms.ToolStripTextBox()
        Me.statusXM = New System.Windows.Forms.ToolStripTextBox()
        Me.statusVideo = New System.Windows.Forms.ToolStripTextBox()
        Me.BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoadGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartSelectedGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.RecentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAddFavorite = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveFavorite = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.SetGameROMPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetGameBoxArtPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetManualsScreenshotPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetA7800EmulatorPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.SetTVTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NTSCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.videoCompatibility = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.videoBasic = New System.Windows.Forms.ToolStripMenuItem()
        Me.videoCRT = New System.Windows.Forms.ToolStripMenuItem()
        Me.videoCRTDeluxe = New System.Windows.Forms.ToolStripMenuItem()
        Me.videoSuperEagle = New System.Windows.Forms.ToolStripMenuItem()
        Me.videoHLSL = New System.Windows.Forms.ToolStripMenuItem()
        Me.videoHQ2x = New System.Windows.Forms.ToolStripMenuItem()
        Me.videoHQ4x = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetPaletteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.paletteWARM = New System.Windows.Forms.ToolStripMenuItem()
        Me.paletteCOOL = New System.Windows.Forms.ToolStripMenuItem()
        Me.paletteHOT = New System.Windows.Forms.ToolStripMenuItem()
        Me.setStretchMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.stretchON = New System.Windows.Forms.ToolStripMenuItem()
        Me.stretchOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuWindowMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.fullscreenOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.fullScreenON = New System.Windows.Forms.ToolStripMenuItem()
        Me.setVSYNCMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.vsyncON = New System.Windows.Forms.ToolStripMenuItem()
        Me.vsyncOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.setTripleBufferMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.triplebufferON = New System.Windows.Forms.ToolStripMenuItem()
        Me.triplebufferOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.SetXMSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.xmON = New System.Windows.Forms.ToolStripMenuItem()
        Me.xmOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetHSCSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hscON = New System.Windows.Forms.ToolStripMenuItem()
        Me.hscOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox6 = New System.Windows.Forms.ToolStripTextBox()
        Me.setDeveloperMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.devON = New System.Windows.Forms.ToolStripMenuItem()
        Me.devOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetDebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.debugON = New System.Windows.Forms.ToolStripMenuItem()
        Me.debugOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox10 = New System.Windows.Forms.ToolStripTextBox()
        Me.EditA7800ConfigurationFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetAllOptionsToDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetAllHighScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusON = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.displayFULL = New System.Windows.Forms.ToolStripMenuItem()
        Me.displayMED = New System.Windows.Forms.ToolStripMenuItem()
        Me.displaySMALL = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.usersguideToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.A7800EmulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyboardMappingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TVAndVideoTipsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsersGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Atari7800ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonDefinitionsForGamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifficultySwitchOptionsForGamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripPalette = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripTVType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripVideo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripStretch = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripWindow = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripVsync = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripTripleBuffer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripXM = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripHSC = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripDev = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripDebug = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabEditor = New System.Windows.Forms.TabControl()
        Me.tabManuals = New System.Windows.Forms.TabPage()
        Me.tabHTMLEditor = New System.Windows.Forms.TabPage()
        Me.txtEditorFile = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSaveHTML = New System.Windows.Forms.Button()
        Me.txtHTMLEditor = New System.Windows.Forms.TextBox()
        Me.tabScreenshots = New System.Windows.Forms.TabPage()
        Me.btnSave6 = New System.Windows.Forms.Button()
        Me.btnLoad6 = New System.Windows.Forms.Button()
        Me.btnUnload6 = New System.Windows.Forms.Button()
        Me.btnSave5 = New System.Windows.Forms.Button()
        Me.btnLoad5 = New System.Windows.Forms.Button()
        Me.btnUnload5 = New System.Windows.Forms.Button()
        Me.btnSave4 = New System.Windows.Forms.Button()
        Me.btnLoad4 = New System.Windows.Forms.Button()
        Me.btnUnload4 = New System.Windows.Forms.Button()
        Me.btnSave3 = New System.Windows.Forms.Button()
        Me.btnLoad3 = New System.Windows.Forms.Button()
        Me.btnUnload3 = New System.Windows.Forms.Button()
        Me.btnSave2 = New System.Windows.Forms.Button()
        Me.btnLoad2 = New System.Windows.Forms.Button()
        Me.btnUnload2 = New System.Windows.Forms.Button()
        Me.btnSave1 = New System.Windows.Forms.Button()
        Me.btnLoad1 = New System.Windows.Forms.Button()
        Me.btnUnload1 = New System.Windows.Forms.Button()
        Me.Screenshot6 = New System.Windows.Forms.PictureBox()
        Me.Screenshot5 = New System.Windows.Forms.PictureBox()
        Me.Screenshot4 = New System.Windows.Forms.PictureBox()
        Me.Screenshot3 = New System.Windows.Forms.PictureBox()
        Me.Screenshot2 = New System.Windows.Forms.PictureBox()
        Me.Screenshot1 = New System.Windows.Forms.PictureBox()
        Me.pctBoxArt = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBoxArt = New System.Windows.Forms.TabPage()
        Me.tabHighScores = New System.Windows.Forms.TabPage()
        Me.txtInitials27 = New System.Windows.Forms.TextBox()
        Me.txtInitials26 = New System.Windows.Forms.TextBox()
        Me.txtInitials25 = New System.Windows.Forms.TextBox()
        Me.txtInitials24 = New System.Windows.Forms.TextBox()
        Me.txtInitials23 = New System.Windows.Forms.TextBox()
        Me.txtInitials22 = New System.Windows.Forms.TextBox()
        Me.txtInitials21 = New System.Windows.Forms.TextBox()
        Me.txtDate27 = New System.Windows.Forms.TextBox()
        Me.txtDate26 = New System.Windows.Forms.TextBox()
        Me.txtDate25 = New System.Windows.Forms.TextBox()
        Me.txtDate24 = New System.Windows.Forms.TextBox()
        Me.txtDate23 = New System.Windows.Forms.TextBox()
        Me.txtDate22 = New System.Windows.Forms.TextBox()
        Me.txtDate21 = New System.Windows.Forms.TextBox()
        Me.txtPlayer27 = New System.Windows.Forms.TextBox()
        Me.txtPlayer26 = New System.Windows.Forms.TextBox()
        Me.txtPlayer25 = New System.Windows.Forms.TextBox()
        Me.txtPlayer24 = New System.Windows.Forms.TextBox()
        Me.txtPlayer23 = New System.Windows.Forms.TextBox()
        Me.txtPlayer22 = New System.Windows.Forms.TextBox()
        Me.txtPlayer21 = New System.Windows.Forms.TextBox()
        Me.txtScore27 = New System.Windows.Forms.TextBox()
        Me.txtScore26 = New System.Windows.Forms.TextBox()
        Me.txtScore25 = New System.Windows.Forms.TextBox()
        Me.txtScore24 = New System.Windows.Forms.TextBox()
        Me.txtScore23 = New System.Windows.Forms.TextBox()
        Me.txtScore22 = New System.Windows.Forms.TextBox()
        Me.txtScore21 = New System.Windows.Forms.TextBox()
        Me.txtInitials20 = New System.Windows.Forms.TextBox()
        Me.txtInitials19 = New System.Windows.Forms.TextBox()
        Me.txtInitials18 = New System.Windows.Forms.TextBox()
        Me.txtInitials17 = New System.Windows.Forms.TextBox()
        Me.txtInitials16 = New System.Windows.Forms.TextBox()
        Me.txtInitials15 = New System.Windows.Forms.TextBox()
        Me.txtInitials14 = New System.Windows.Forms.TextBox()
        Me.txtInitials13 = New System.Windows.Forms.TextBox()
        Me.txtInitials12 = New System.Windows.Forms.TextBox()
        Me.txtInitials11 = New System.Windows.Forms.TextBox()
        Me.txtInitials10 = New System.Windows.Forms.TextBox()
        Me.txtInitials9 = New System.Windows.Forms.TextBox()
        Me.txtInitials8 = New System.Windows.Forms.TextBox()
        Me.txtInitials7 = New System.Windows.Forms.TextBox()
        Me.txtInitials6 = New System.Windows.Forms.TextBox()
        Me.txtInitials5 = New System.Windows.Forms.TextBox()
        Me.txtInitials4 = New System.Windows.Forms.TextBox()
        Me.txtInitials3 = New System.Windows.Forms.TextBox()
        Me.txtInitials2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtInitials1 = New System.Windows.Forms.TextBox()
        Me.txtDate20 = New System.Windows.Forms.TextBox()
        Me.txtDate19 = New System.Windows.Forms.TextBox()
        Me.txtDate18 = New System.Windows.Forms.TextBox()
        Me.txtDate17 = New System.Windows.Forms.TextBox()
        Me.txtDate16 = New System.Windows.Forms.TextBox()
        Me.txtDate15 = New System.Windows.Forms.TextBox()
        Me.txtDate14 = New System.Windows.Forms.TextBox()
        Me.txtDate13 = New System.Windows.Forms.TextBox()
        Me.txtDate12 = New System.Windows.Forms.TextBox()
        Me.txtPlayer20 = New System.Windows.Forms.TextBox()
        Me.txtPlayer19 = New System.Windows.Forms.TextBox()
        Me.txtPlayer18 = New System.Windows.Forms.TextBox()
        Me.txtPlayer17 = New System.Windows.Forms.TextBox()
        Me.txtPlayer16 = New System.Windows.Forms.TextBox()
        Me.txtPlayer15 = New System.Windows.Forms.TextBox()
        Me.txtPlayer14 = New System.Windows.Forms.TextBox()
        Me.txtPlayer13 = New System.Windows.Forms.TextBox()
        Me.txtPlayer12 = New System.Windows.Forms.TextBox()
        Me.txtScore20 = New System.Windows.Forms.TextBox()
        Me.txtScore19 = New System.Windows.Forms.TextBox()
        Me.txtScore18 = New System.Windows.Forms.TextBox()
        Me.txtScore17 = New System.Windows.Forms.TextBox()
        Me.txtScore16 = New System.Windows.Forms.TextBox()
        Me.txtScore15 = New System.Windows.Forms.TextBox()
        Me.txtScore14 = New System.Windows.Forms.TextBox()
        Me.txtScore13 = New System.Windows.Forms.TextBox()
        Me.txtScore12 = New System.Windows.Forms.TextBox()
        Me.txtDate11 = New System.Windows.Forms.TextBox()
        Me.txtPlayer11 = New System.Windows.Forms.TextBox()
        Me.txtScore11 = New System.Windows.Forms.TextBox()
        Me.txtDate10 = New System.Windows.Forms.TextBox()
        Me.txtDate9 = New System.Windows.Forms.TextBox()
        Me.txtDate8 = New System.Windows.Forms.TextBox()
        Me.txtDate7 = New System.Windows.Forms.TextBox()
        Me.txtDate6 = New System.Windows.Forms.TextBox()
        Me.txtDate5 = New System.Windows.Forms.TextBox()
        Me.txtDate4 = New System.Windows.Forms.TextBox()
        Me.txtDate3 = New System.Windows.Forms.TextBox()
        Me.txtDate2 = New System.Windows.Forms.TextBox()
        Me.txtPlayer10 = New System.Windows.Forms.TextBox()
        Me.txtPlayer9 = New System.Windows.Forms.TextBox()
        Me.txtPlayer8 = New System.Windows.Forms.TextBox()
        Me.txtPlayer7 = New System.Windows.Forms.TextBox()
        Me.txtPlayer6 = New System.Windows.Forms.TextBox()
        Me.txtPlayer5 = New System.Windows.Forms.TextBox()
        Me.txtPlayer4 = New System.Windows.Forms.TextBox()
        Me.txtPlayer3 = New System.Windows.Forms.TextBox()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.txtScore10 = New System.Windows.Forms.TextBox()
        Me.txtScore9 = New System.Windows.Forms.TextBox()
        Me.txtScore8 = New System.Windows.Forms.TextBox()
        Me.txtScore7 = New System.Windows.Forms.TextBox()
        Me.txtScore6 = New System.Windows.Forms.TextBox()
        Me.txtScore5 = New System.Windows.Forms.TextBox()
        Me.txtScore4 = New System.Windows.Forms.TextBox()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtDate1 = New System.Windows.Forms.TextBox()
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtScore1 = New System.Windows.Forms.TextBox()
        Me.tabDirectoryPaths = New System.Windows.Forms.TabPage()
        Me.ContextBoxArt = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateBoxArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControlRoms.SuspendLayout()
        Me.tabNTSC.SuspendLayout()
        Me.contextNTSC.SuspendLayout()
        Me.tabPAL.SuspendLayout()
        Me.tabHomebrews.SuspendLayout()
        Me.tabHacks.SuspendLayout()
        Me.tabDemos.SuspendLayout()
        Me.tabProtos.SuspendLayout()
        Me.tabUtilities.SuspendLayout()
        Me.tabFavorites.SuspendLayout()
        Me.contextFavorites.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabEditor.SuspendLayout()
        Me.tabManuals.SuspendLayout()
        Me.tabHTMLEditor.SuspendLayout()
        Me.tabScreenshots.SuspendLayout()
        CType(Me.Screenshot6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Screenshot5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Screenshot4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Screenshot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Screenshot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Screenshot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBoxArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabBoxArt.SuspendLayout()
        Me.tabHighScores.SuspendLayout()
        Me.tabDirectoryPaths.SuspendLayout()
        Me.ContextBoxArt.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(5, 5)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(492, 622)
        Me.WebBrowser1.TabIndex = 40
        Me.WebBrowser1.Url = New System.Uri("c:\a7800\manuals\Blank.htm", System.UriKind.Absolute)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "A7800 Path"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Game Info Path"
        '
        'txtA7800path
        '
        Me.txtA7800path.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtA7800path.ForeColor = System.Drawing.SystemColors.Window
        Me.txtA7800path.Location = New System.Drawing.Point(87, 28)
        Me.txtA7800path.Multiline = True
        Me.txtA7800path.Name = "txtA7800path"
        Me.txtA7800path.Size = New System.Drawing.Size(250, 20)
        Me.txtA7800path.TabIndex = 36
        '
        'txtRomPath
        '
        Me.txtRomPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtRomPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRomPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtRomPath.Location = New System.Drawing.Point(9, 42)
        Me.txtRomPath.Multiline = True
        Me.txtRomPath.Name = "txtRomPath"
        Me.txtRomPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRomPath.Size = New System.Drawing.Size(328, 29)
        Me.txtRomPath.TabIndex = 37
        '
        'txtBoxArtPath
        '
        Me.txtBoxArtPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtBoxArtPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtBoxArtPath.Location = New System.Drawing.Point(87, 54)
        Me.txtBoxArtPath.Multiline = True
        Me.txtBoxArtPath.Name = "txtBoxArtPath"
        Me.txtBoxArtPath.Size = New System.Drawing.Size(250, 20)
        Me.txtBoxArtPath.TabIndex = 38
        '
        'txtManualsPath
        '
        Me.txtManualsPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtManualsPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtManualsPath.Location = New System.Drawing.Point(87, 80)
        Me.txtManualsPath.Multiline = True
        Me.txtManualsPath.Name = "txtManualsPath"
        Me.txtManualsPath.Size = New System.Drawing.Size(250, 20)
        Me.txtManualsPath.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Root ROM Path"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Box Art Path"
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPath.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPath.Location = New System.Drawing.Point(6, 497)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPath.Size = New System.Drawing.Size(360, 125)
        Me.txtPath.TabIndex = 31
        '
        'TabControlRoms
        '
        Me.TabControlRoms.Controls.Add(Me.tabNTSC)
        Me.TabControlRoms.Controls.Add(Me.tabPAL)
        Me.TabControlRoms.Controls.Add(Me.tabHomebrews)
        Me.TabControlRoms.Controls.Add(Me.tabHacks)
        Me.TabControlRoms.Controls.Add(Me.tabDemos)
        Me.TabControlRoms.Controls.Add(Me.tabProtos)
        Me.TabControlRoms.Controls.Add(Me.tabUtilities)
        Me.TabControlRoms.Controls.Add(Me.tabFavorites)
        Me.TabControlRoms.Location = New System.Drawing.Point(12, 24)
        Me.TabControlRoms.Name = "TabControlRoms"
        Me.TabControlRoms.SelectedIndex = 0
        Me.TabControlRoms.Size = New System.Drawing.Size(442, 660)
        Me.TabControlRoms.TabIndex = 54
        '
        'tabNTSC
        '
        Me.tabNTSC.Controls.Add(Me.lstNTSCRetail)
        Me.tabNTSC.Location = New System.Drawing.Point(4, 22)
        Me.tabNTSC.Name = "tabNTSC"
        Me.tabNTSC.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNTSC.Size = New System.Drawing.Size(434, 634)
        Me.tabNTSC.TabIndex = 0
        Me.tabNTSC.Text = "NTSC Retail"
        Me.tabNTSC.UseVisualStyleBackColor = True
        '
        'lstNTSCRetail
        '
        Me.lstNTSCRetail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstNTSCRetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstNTSCRetail.ContextMenuStrip = Me.contextNTSC
        Me.lstNTSCRetail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNTSCRetail.FormattingEnabled = True
        Me.lstNTSCRetail.ItemHeight = 14
        Me.lstNTSCRetail.Location = New System.Drawing.Point(3, 3)
        Me.lstNTSCRetail.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstNTSCRetail.Name = "lstNTSCRetail"
        Me.lstNTSCRetail.Size = New System.Drawing.Size(427, 604)
        Me.lstNTSCRetail.TabIndex = 29
        '
        'contextNTSC
        '
        Me.contextNTSC.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextNTSC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contextNTSCRetail, Me.ToolStripSeparator4, Me.AddScreenshotsToolStripMenuItem})
        Me.contextNTSC.Name = "contextNTSC"
        Me.contextNTSC.Size = New System.Drawing.Size(163, 54)
        Me.contextNTSC.Text = "Add to Favorites"
        '
        'contextNTSCRetail
        '
        Me.contextNTSCRetail.Name = "contextNTSCRetail"
        Me.contextNTSCRetail.Size = New System.Drawing.Size(162, 22)
        Me.contextNTSCRetail.Text = "Add to Favorites"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(159, 6)
        '
        'AddScreenshotsToolStripMenuItem
        '
        Me.AddScreenshotsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addImage1, Me.addImage2, Me.addImage3, Me.addImage4, Me.addImage5, Me.addImage6})
        Me.AddScreenshotsToolStripMenuItem.Name = "AddScreenshotsToolStripMenuItem"
        Me.AddScreenshotsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AddScreenshotsToolStripMenuItem.Text = "Add Screenshots"
        '
        'addImage1
        '
        Me.addImage1.Name = "addImage1"
        Me.addImage1.Size = New System.Drawing.Size(116, 22)
        Me.addImage1.Text = "Image 1"
        '
        'addImage2
        '
        Me.addImage2.Name = "addImage2"
        Me.addImage2.Size = New System.Drawing.Size(116, 22)
        Me.addImage2.Text = "Image 2"
        '
        'addImage3
        '
        Me.addImage3.Name = "addImage3"
        Me.addImage3.Size = New System.Drawing.Size(116, 22)
        Me.addImage3.Text = "Image 3"
        '
        'addImage4
        '
        Me.addImage4.Name = "addImage4"
        Me.addImage4.Size = New System.Drawing.Size(116, 22)
        Me.addImage4.Text = "Image 4"
        '
        'addImage5
        '
        Me.addImage5.Name = "addImage5"
        Me.addImage5.Size = New System.Drawing.Size(116, 22)
        Me.addImage5.Text = "Image 5"
        '
        'addImage6
        '
        Me.addImage6.Name = "addImage6"
        Me.addImage6.Size = New System.Drawing.Size(116, 22)
        Me.addImage6.Text = "Image 6"
        '
        'tabPAL
        '
        Me.tabPAL.Controls.Add(Me.lstPALRetail)
        Me.tabPAL.Location = New System.Drawing.Point(4, 22)
        Me.tabPAL.Name = "tabPAL"
        Me.tabPAL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPAL.Size = New System.Drawing.Size(434, 634)
        Me.tabPAL.TabIndex = 1
        Me.tabPAL.Text = "PAL Retail"
        Me.tabPAL.UseVisualStyleBackColor = True
        '
        'lstPALRetail
        '
        Me.lstPALRetail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstPALRetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstPALRetail.ContextMenuStrip = Me.contextNTSC
        Me.lstPALRetail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPALRetail.FormattingEnabled = True
        Me.lstPALRetail.ItemHeight = 14
        Me.lstPALRetail.Location = New System.Drawing.Point(3, 2)
        Me.lstPALRetail.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstPALRetail.Name = "lstPALRetail"
        Me.lstPALRetail.Size = New System.Drawing.Size(427, 604)
        Me.lstPALRetail.TabIndex = 30
        '
        'tabHomebrews
        '
        Me.tabHomebrews.Controls.Add(Me.lstHomebrews)
        Me.tabHomebrews.Location = New System.Drawing.Point(4, 22)
        Me.tabHomebrews.Name = "tabHomebrews"
        Me.tabHomebrews.Size = New System.Drawing.Size(434, 634)
        Me.tabHomebrews.TabIndex = 2
        Me.tabHomebrews.Text = "Homebrews"
        Me.tabHomebrews.UseVisualStyleBackColor = True
        '
        'lstHomebrews
        '
        Me.lstHomebrews.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstHomebrews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstHomebrews.ContextMenuStrip = Me.contextNTSC
        Me.lstHomebrews.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHomebrews.FormattingEnabled = True
        Me.lstHomebrews.ItemHeight = 14
        Me.lstHomebrews.Location = New System.Drawing.Point(3, 2)
        Me.lstHomebrews.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstHomebrews.Name = "lstHomebrews"
        Me.lstHomebrews.Size = New System.Drawing.Size(427, 604)
        Me.lstHomebrews.TabIndex = 31
        '
        'tabHacks
        '
        Me.tabHacks.Controls.Add(Me.lstHacks)
        Me.tabHacks.Location = New System.Drawing.Point(4, 22)
        Me.tabHacks.Name = "tabHacks"
        Me.tabHacks.Size = New System.Drawing.Size(434, 634)
        Me.tabHacks.TabIndex = 3
        Me.tabHacks.Text = "Hacks"
        Me.tabHacks.UseVisualStyleBackColor = True
        '
        'lstHacks
        '
        Me.lstHacks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstHacks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstHacks.ContextMenuStrip = Me.contextNTSC
        Me.lstHacks.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHacks.FormattingEnabled = True
        Me.lstHacks.ItemHeight = 14
        Me.lstHacks.Location = New System.Drawing.Point(3, 2)
        Me.lstHacks.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstHacks.Name = "lstHacks"
        Me.lstHacks.Size = New System.Drawing.Size(427, 604)
        Me.lstHacks.TabIndex = 32
        '
        'tabDemos
        '
        Me.tabDemos.Controls.Add(Me.lstDemos)
        Me.tabDemos.Location = New System.Drawing.Point(4, 22)
        Me.tabDemos.Name = "tabDemos"
        Me.tabDemos.Size = New System.Drawing.Size(434, 634)
        Me.tabDemos.TabIndex = 4
        Me.tabDemos.Text = "Demos"
        Me.tabDemos.UseVisualStyleBackColor = True
        '
        'lstDemos
        '
        Me.lstDemos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstDemos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstDemos.ContextMenuStrip = Me.contextNTSC
        Me.lstDemos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDemos.FormattingEnabled = True
        Me.lstDemos.ItemHeight = 14
        Me.lstDemos.Location = New System.Drawing.Point(3, 2)
        Me.lstDemos.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstDemos.Name = "lstDemos"
        Me.lstDemos.Size = New System.Drawing.Size(427, 604)
        Me.lstDemos.TabIndex = 32
        '
        'tabProtos
        '
        Me.tabProtos.Controls.Add(Me.lstProtos)
        Me.tabProtos.Location = New System.Drawing.Point(4, 22)
        Me.tabProtos.Name = "tabProtos"
        Me.tabProtos.Size = New System.Drawing.Size(434, 634)
        Me.tabProtos.TabIndex = 5
        Me.tabProtos.Text = "Protos"
        Me.tabProtos.UseVisualStyleBackColor = True
        '
        'lstProtos
        '
        Me.lstProtos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstProtos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstProtos.ContextMenuStrip = Me.contextNTSC
        Me.lstProtos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProtos.FormattingEnabled = True
        Me.lstProtos.ItemHeight = 14
        Me.lstProtos.Location = New System.Drawing.Point(3, 2)
        Me.lstProtos.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstProtos.Name = "lstProtos"
        Me.lstProtos.Size = New System.Drawing.Size(427, 604)
        Me.lstProtos.TabIndex = 33
        '
        'tabUtilities
        '
        Me.tabUtilities.Controls.Add(Me.lstUtilities)
        Me.tabUtilities.Location = New System.Drawing.Point(4, 22)
        Me.tabUtilities.Name = "tabUtilities"
        Me.tabUtilities.Size = New System.Drawing.Size(434, 634)
        Me.tabUtilities.TabIndex = 6
        Me.tabUtilities.Text = "Utilities"
        Me.tabUtilities.UseVisualStyleBackColor = True
        '
        'lstUtilities
        '
        Me.lstUtilities.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstUtilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstUtilities.ContextMenuStrip = Me.contextNTSC
        Me.lstUtilities.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUtilities.FormattingEnabled = True
        Me.lstUtilities.ItemHeight = 14
        Me.lstUtilities.Location = New System.Drawing.Point(3, 2)
        Me.lstUtilities.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstUtilities.Name = "lstUtilities"
        Me.lstUtilities.Size = New System.Drawing.Size(427, 604)
        Me.lstUtilities.TabIndex = 33
        '
        'tabFavorites
        '
        Me.tabFavorites.Controls.Add(Me.lstFavorites)
        Me.tabFavorites.Location = New System.Drawing.Point(4, 22)
        Me.tabFavorites.Name = "tabFavorites"
        Me.tabFavorites.Size = New System.Drawing.Size(434, 634)
        Me.tabFavorites.TabIndex = 7
        Me.tabFavorites.Text = "Favorites"
        Me.tabFavorites.UseVisualStyleBackColor = True
        '
        'lstFavorites
        '
        Me.lstFavorites.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstFavorites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstFavorites.ContextMenuStrip = Me.contextFavorites
        Me.lstFavorites.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFavorites.FormattingEnabled = True
        Me.lstFavorites.ItemHeight = 14
        Me.lstFavorites.Location = New System.Drawing.Point(3, 2)
        Me.lstFavorites.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstFavorites.Name = "lstFavorites"
        Me.lstFavorites.Size = New System.Drawing.Size(427, 604)
        Me.lstFavorites.TabIndex = 34
        '
        'contextFavorites
        '
        Me.contextFavorites.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextFavorites.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveFromFavoritesToolStripMenuItem, Me.ToolStripSeparator3, Me.ClearAllFavoritesToolStripMenuItem})
        Me.contextFavorites.Name = "contextFavorites"
        Me.contextFavorites.Size = New System.Drawing.Size(226, 54)
        '
        'RemoveFromFavoritesToolStripMenuItem
        '
        Me.RemoveFromFavoritesToolStripMenuItem.Name = "RemoveFromFavoritesToolStripMenuItem"
        Me.RemoveFromFavoritesToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.RemoveFromFavoritesToolStripMenuItem.Text = "Remove Item From Favorites"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(222, 6)
        '
        'ClearAllFavoritesToolStripMenuItem
        '
        Me.ClearAllFavoritesToolStripMenuItem.Name = "ClearAllFavoritesToolStripMenuItem"
        Me.ClearAllFavoritesToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ClearAllFavoritesToolStripMenuItem.Text = "Clear All Favorites"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtNTSCRetailPath)
        Me.GroupBox2.Controls.Add(Me.btnSaveROMPaths)
        Me.GroupBox2.Controls.Add(Me.txtPALRetailPath)
        Me.GroupBox2.Controls.Add(Me.txtHomebrewPath)
        Me.GroupBox2.Controls.Add(Me.txtRomPath)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtHacksPath)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtDemosPath)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtProtosPath)
        Me.GroupBox2.Controls.Add(Me.txtUtilitiesPath)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 458)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ROM Directory Paths"
        '
        'txtNTSCRetailPath
        '
        Me.txtNTSCRetailPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtNTSCRetailPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNTSCRetailPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNTSCRetailPath.Location = New System.Drawing.Point(9, 90)
        Me.txtNTSCRetailPath.Multiline = True
        Me.txtNTSCRetailPath.Name = "txtNTSCRetailPath"
        Me.txtNTSCRetailPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNTSCRetailPath.Size = New System.Drawing.Size(328, 30)
        Me.txtNTSCRetailPath.TabIndex = 0
        '
        'btnSaveROMPaths
        '
        Me.btnSaveROMPaths.Location = New System.Drawing.Point(6, 423)
        Me.btnSaveROMPaths.Name = "btnSaveROMPaths"
        Me.btnSaveROMPaths.Size = New System.Drawing.Size(331, 27)
        Me.btnSaveROMPaths.TabIndex = 16
        Me.btnSaveROMPaths.Text = "Save ROM Paths to the Registry and Refresh all Lists"
        Me.btnSaveROMPaths.UseVisualStyleBackColor = True
        '
        'txtPALRetailPath
        '
        Me.txtPALRetailPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtPALRetailPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPALRetailPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPALRetailPath.Location = New System.Drawing.Point(9, 139)
        Me.txtPALRetailPath.Multiline = True
        Me.txtPALRetailPath.Name = "txtPALRetailPath"
        Me.txtPALRetailPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPALRetailPath.Size = New System.Drawing.Size(328, 30)
        Me.txtPALRetailPath.TabIndex = 1
        '
        'txtHomebrewPath
        '
        Me.txtHomebrewPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtHomebrewPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHomebrewPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtHomebrewPath.Location = New System.Drawing.Point(9, 188)
        Me.txtHomebrewPath.Multiline = True
        Me.txtHomebrewPath.Name = "txtHomebrewPath"
        Me.txtHomebrewPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHomebrewPath.Size = New System.Drawing.Size(328, 30)
        Me.txtHomebrewPath.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 372)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Utilities Subfolder"
        '
        'txtHacksPath
        '
        Me.txtHacksPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtHacksPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHacksPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtHacksPath.Location = New System.Drawing.Point(9, 237)
        Me.txtHacksPath.Multiline = True
        Me.txtHacksPath.Name = "txtHacksPath"
        Me.txtHacksPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHacksPath.Size = New System.Drawing.Size(328, 31)
        Me.txtHacksPath.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 321)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Prototypes Subfolder"
        '
        'txtDemosPath
        '
        Me.txtDemosPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtDemosPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDemosPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtDemosPath.Location = New System.Drawing.Point(9, 287)
        Me.txtDemosPath.Multiline = True
        Me.txtDemosPath.Name = "txtDemosPath"
        Me.txtDemosPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDemosPath.Size = New System.Drawing.Size(328, 31)
        Me.txtDemosPath.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Demos Subfolder"
        '
        'txtProtosPath
        '
        Me.txtProtosPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtProtosPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProtosPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtProtosPath.Location = New System.Drawing.Point(9, 337)
        Me.txtProtosPath.Multiline = True
        Me.txtProtosPath.Name = "txtProtosPath"
        Me.txtProtosPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProtosPath.Size = New System.Drawing.Size(328, 32)
        Me.txtProtosPath.TabIndex = 5
        '
        'txtUtilitiesPath
        '
        Me.txtUtilitiesPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtUtilitiesPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUtilitiesPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtUtilitiesPath.Location = New System.Drawing.Point(9, 388)
        Me.txtUtilitiesPath.Multiline = True
        Me.txtUtilitiesPath.Name = "txtUtilitiesPath"
        Me.txtUtilitiesPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUtilitiesPath.Size = New System.Drawing.Size(328, 29)
        Me.txtUtilitiesPath.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Hacks Subfolder"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "NTSC Retail Subfolder"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Homebrew Subfolder"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "PAL Retail Subfolder"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtA7800path)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtManualsPath)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBoxArtPath)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 152)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "A7800 Directory Paths"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(342, 27)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Save Changs to Registry (Application Restart Required)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtRootROMPath
        '
        Me.txtRootROMPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRootROMPath.Location = New System.Drawing.Point(6, 576)
        Me.txtRootROMPath.Multiline = True
        Me.txtRootROMPath.Name = "txtRootROMPath"
        Me.txtRootROMPath.ReadOnly = True
        Me.txtRootROMPath.Size = New System.Drawing.Size(360, 20)
        Me.txtRootROMPath.TabIndex = 14
        Me.txtRootROMPath.Visible = False
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.StatusToolStripMenuItem.Text = "Status Bar"
        '
        'statusTVType
        '
        Me.statusTVType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.statusTVType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.statusTVType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.statusTVType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusTVType.Name = "statusTVType"
        Me.statusTVType.ReadOnly = True
        Me.statusTVType.Size = New System.Drawing.Size(97, 20)
        Me.statusTVType.Text = "TV TYPE: NTSC"
        Me.statusTVType.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'statusPalette
        '
        Me.statusPalette.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.statusPalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.statusPalette.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.statusPalette.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.statusPalette.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusPalette.Name = "statusPalette"
        Me.statusPalette.ReadOnly = True
        Me.statusPalette.Size = New System.Drawing.Size(105, 20)
        Me.statusPalette.Text = "PALETTE: WARM"
        Me.statusPalette.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'statusXMhw
        '
        Me.statusXMhw.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.statusXMhw.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.statusXMhw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.statusXMhw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusXMhw.Name = "statusXMhw"
        Me.statusXMhw.ReadOnly = True
        Me.statusXMhw.Size = New System.Drawing.Size(58, 20)
        Me.statusXMhw.Text = "XM: OFF"
        Me.statusXMhw.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'statusHSC
        '
        Me.statusHSC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.statusHSC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.statusHSC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.statusHSC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusHSC.Name = "statusHSC"
        Me.statusHSC.ReadOnly = True
        Me.statusHSC.Size = New System.Drawing.Size(68, 20)
        Me.statusHSC.Text = "HSC: OFF"
        Me.statusHSC.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'statusDebug
        '
        Me.statusDebug.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.statusDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.statusDebug.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.statusDebug.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.statusDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusDebug.Name = "statusDebug"
        Me.statusDebug.ReadOnly = True
        Me.statusDebug.Size = New System.Drawing.Size(115, 20)
        Me.statusDebug.Text = "DEBUG MODE: OFF"
        Me.statusDebug.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'statusXM
        '
        Me.statusXM.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.statusXM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.statusXM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.statusXM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.statusXM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusXM.Name = "statusXM"
        Me.statusXM.ReadOnly = True
        Me.statusXM.Size = New System.Drawing.Size(98, 20)
        Me.statusXM.Text = "DEV MODE: OFF"
        Me.statusXM.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'statusVideo
        '
        Me.statusVideo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.statusVideo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.statusVideo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.statusVideo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.statusVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusVideo.Name = "statusVideo"
        Me.statusVideo.ReadOnly = True
        Me.statusVideo.Size = New System.Drawing.Size(122, 20)
        Me.statusVideo.Text = "VIDEO: BASIC"
        Me.statusVideo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BToolStripMenuItem
        '
        Me.BToolStripMenuItem.Name = "BToolStripMenuItem"
        Me.BToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.BToolStripMenuItem.Text = "00.99.17b"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1358, 25)
        Me.MenuStrip1.TabIndex = 56
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLoadGame, Me.StartSelectedGameToolStripMenuItem, Me.ToolStripSeparator15, Me.RecentToolStripMenuItem, Me.ToolStripSeparator7, Me.mnuAddFavorite, Me.mnuRemoveFavorite, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuLoadGame
        '
        Me.mnuLoadGame.Name = "mnuLoadGame"
        Me.mnuLoadGame.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuLoadGame.Size = New System.Drawing.Size(273, 22)
        Me.mnuLoadGame.Text = "Launch External ROM"
        '
        'StartSelectedGameToolStripMenuItem
        '
        Me.StartSelectedGameToolStripMenuItem.Name = "StartSelectedGameToolStripMenuItem"
        Me.StartSelectedGameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.StartSelectedGameToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.StartSelectedGameToolStripMenuItem.Text = "Launch ROM from List"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(270, 6)
        '
        'RecentToolStripMenuItem
        '
        Me.RecentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.RecentToolStripMenuItem.Name = "RecentToolStripMenuItem"
        Me.RecentToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.RecentToolStripMenuItem.Text = "Recent"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripMenuItem4.Text = "..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(270, 6)
        '
        'mnuAddFavorite
        '
        Me.mnuAddFavorite.Name = "mnuAddFavorite"
        Me.mnuAddFavorite.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAddFavorite.Size = New System.Drawing.Size(273, 22)
        Me.mnuAddFavorite.Text = "Add ROM to Favorites"
        '
        'mnuRemoveFavorite
        '
        Me.mnuRemoveFavorite.Name = "mnuRemoveFavorite"
        Me.mnuRemoveFavorite.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuRemoveFavorite.Size = New System.Drawing.Size(273, 22)
        Me.mnuRemoveFavorite.Text = "Remove ROM from Favorites"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(270, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(273, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.SetGameROMPathToolStripMenuItem, Me.SetGameBoxArtPathToolStripMenuItem, Me.SetManualsScreenshotPathToolStripMenuItem, Me.SetA7800EmulatorPathToolStripMenuItem, Me.ToolStripSeparator9, Me.ToolStripTextBox2, Me.SetTVTypeToolStripMenuItem, Me.ToolStripMenuItem2, Me.SetPaletteToolStripMenuItem, Me.setStretchMenuItem3, Me.menuWindowMode, Me.setVSYNCMenuItem3, Me.setTripleBufferMenuItem3, Me.ToolStripSeparator11, Me.ToolStripTextBox3, Me.SetXMSupportToolStripMenuItem, Me.SetHSCSupportToolStripMenuItem, Me.ToolStripSeparator12, Me.ToolStripTextBox6, Me.setDeveloperMenuItem1, Me.SetDebugToolStripMenuItem, Me.ToolStripSeparator13, Me.ToolStripTextBox10, Me.EditA7800ConfigurationFileToolStripMenuItem, Me.ToolStripSeparator1, Me.ResetAllOptionsToDefaultToolStripMenuItem, Me.ToolStripSeparator5, Me.ResetAllHighScoresToolStripMenuItem})
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(40, 21)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox1.Enabled = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.ReadOnly = True
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(252, 14)
        Me.ToolStripTextBox1.Text = "Select Directory Paths"
        '
        'SetGameROMPathToolStripMenuItem
        '
        Me.SetGameROMPathToolStripMenuItem.Name = "SetGameROMPathToolStripMenuItem"
        Me.SetGameROMPathToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.SetGameROMPathToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SetGameROMPathToolStripMenuItem.Text = "Game ROM Path"
        '
        'SetGameBoxArtPathToolStripMenuItem
        '
        Me.SetGameBoxArtPathToolStripMenuItem.Name = "SetGameBoxArtPathToolStripMenuItem"
        Me.SetGameBoxArtPathToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.SetGameBoxArtPathToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SetGameBoxArtPathToolStripMenuItem.Text = "Game Box Art Path"
        '
        'SetManualsScreenshotPathToolStripMenuItem
        '
        Me.SetManualsScreenshotPathToolStripMenuItem.Name = "SetManualsScreenshotPathToolStripMenuItem"
        Me.SetManualsScreenshotPathToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.SetManualsScreenshotPathToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SetManualsScreenshotPathToolStripMenuItem.Text = "Game Information Path"
        '
        'SetA7800EmulatorPathToolStripMenuItem
        '
        Me.SetA7800EmulatorPathToolStripMenuItem.Name = "SetA7800EmulatorPathToolStripMenuItem"
        Me.SetA7800EmulatorPathToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SetA7800EmulatorPathToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SetA7800EmulatorPathToolStripMenuItem.Text = "A7800 Emulator Path"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(309, 6)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox2.Enabled = False
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.ReadOnly = True
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(252, 14)
        Me.ToolStripTextBox2.Text = "Select TV and Video Options"
        '
        'SetTVTypeToolStripMenuItem
        '
        Me.SetTVTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NTSCToolStripMenuItem, Me.PALToolStripMenuItem})
        Me.SetTVTypeToolStripMenuItem.Name = "SetTVTypeToolStripMenuItem"
        Me.SetTVTypeToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SetTVTypeToolStripMenuItem.Text = "TV Type"
        '
        'NTSCToolStripMenuItem
        '
        Me.NTSCToolStripMenuItem.Checked = True
        Me.NTSCToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NTSCToolStripMenuItem.Name = "NTSCToolStripMenuItem"
        Me.NTSCToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NTSCToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NTSCToolStripMenuItem.Text = "NTSC"
        '
        'PALToolStripMenuItem
        '
        Me.PALToolStripMenuItem.Name = "PALToolStripMenuItem"
        Me.PALToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PALToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PALToolStripMenuItem.Text = "PAL"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.videoCompatibility, Me.ToolStripSeparator10, Me.videoBasic, Me.videoCRT, Me.videoCRTDeluxe, Me.videoSuperEagle, Me.videoHLSL, Me.videoHQ2x, Me.videoHQ4x})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(312, 22)
        Me.ToolStripMenuItem2.Text = "Video Output"
        '
        'videoCompatibility
        '
        Me.videoCompatibility.Name = "videoCompatibility"
        Me.videoCompatibility.Size = New System.Drawing.Size(233, 22)
        Me.videoCompatibility.Text = "Direct 3D Compatibility Mode"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(230, 6)
        '
        'videoBasic
        '
        Me.videoBasic.Checked = True
        Me.videoBasic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.videoBasic.Name = "videoBasic"
        Me.videoBasic.Size = New System.Drawing.Size(233, 22)
        Me.videoBasic.Text = "Basic"
        '
        'videoCRT
        '
        Me.videoCRT.Name = "videoCRT"
        Me.videoCRT.Size = New System.Drawing.Size(233, 22)
        Me.videoCRT.Text = "CRT"
        '
        'videoCRTDeluxe
        '
        Me.videoCRTDeluxe.Name = "videoCRTDeluxe"
        Me.videoCRTDeluxe.Size = New System.Drawing.Size(233, 22)
        Me.videoCRTDeluxe.Text = "CRT Deluxe"
        '
        'videoSuperEagle
        '
        Me.videoSuperEagle.Name = "videoSuperEagle"
        Me.videoSuperEagle.Size = New System.Drawing.Size(233, 22)
        Me.videoSuperEagle.Text = "Super Eagle"
        '
        'videoHLSL
        '
        Me.videoHLSL.Name = "videoHLSL"
        Me.videoHLSL.Size = New System.Drawing.Size(233, 22)
        Me.videoHLSL.Text = "HLSL"
        '
        'videoHQ2x
        '
        Me.videoHQ2x.Name = "videoHQ2x"
        Me.videoHQ2x.Size = New System.Drawing.Size(233, 22)
        Me.videoHQ2x.Text = "HQ2x"
        '
        'videoHQ4x
        '
        Me.videoHQ4x.Name = "videoHQ4x"
        Me.videoHQ4x.Size = New System.Drawing.Size(233, 22)
        Me.videoHQ4x.Text = "HQ4x"
        '
        'SetPaletteToolStripMenuItem
        '
        Me.SetPaletteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.paletteWARM, Me.paletteCOOL, Me.paletteHOT})
        Me.SetPaletteToolStripMenuItem.Name = "SetPaletteToolStripMenuItem"
        Me.SetPaletteToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SetPaletteToolStripMenuItem.Text = "Palette Colors"
        '
        'paletteWARM
        '
        Me.paletteWARM.Checked = True
        Me.paletteWARM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.paletteWARM.Name = "paletteWARM"
        Me.paletteWARM.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.paletteWARM.Size = New System.Drawing.Size(189, 22)
        Me.paletteWARM.Text = "Warm Palette"
        '
        'paletteCOOL
        '
        Me.paletteCOOL.Name = "paletteCOOL"
        Me.paletteCOOL.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F6), System.Windows.Forms.Keys)
        Me.paletteCOOL.Size = New System.Drawing.Size(189, 22)
        Me.paletteCOOL.Text = "Cool Palette"
        '
        'paletteHOT
        '
        Me.paletteHOT.Name = "paletteHOT"
        Me.paletteHOT.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F7), System.Windows.Forms.Keys)
        Me.paletteHOT.Size = New System.Drawing.Size(189, 22)
        Me.paletteHOT.Text = "Hot Palette"
        '
        'setStretchMenuItem3
        '
        Me.setStretchMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stretchON, Me.stretchOFF})
        Me.setStretchMenuItem3.Name = "setStretchMenuItem3"
        Me.setStretchMenuItem3.Size = New System.Drawing.Size(312, 22)
        Me.setStretchMenuItem3.Text = "Screen Stretch"
        '
        'stretchON
        '
        Me.stretchON.Name = "stretchON"
        Me.stretchON.Size = New System.Drawing.Size(90, 22)
        Me.stretchON.Text = "On"
        '
        'stretchOFF
        '
        Me.stretchOFF.Checked = True
        Me.stretchOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.stretchOFF.Name = "stretchOFF"
        Me.stretchOFF.Size = New System.Drawing.Size(90, 22)
        Me.stretchOFF.Text = "Off"
        '
        'menuWindowMode
        '
        Me.menuWindowMode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fullscreenOFF, Me.fullScreenON})
        Me.menuWindowMode.Name = "menuWindowMode"
        Me.menuWindowMode.Size = New System.Drawing.Size(312, 22)
        Me.menuWindowMode.Text = "Window Mode"
        '
        'fullscreenOFF
        '
        Me.fullscreenOFF.Checked = True
        Me.fullscreenOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.fullscreenOFF.Name = "fullscreenOFF"
        Me.fullscreenOFF.Size = New System.Drawing.Size(136, 22)
        Me.fullscreenOFF.Text = "Windowed"
        '
        'fullScreenON
        '
        Me.fullScreenON.Name = "fullScreenON"
        Me.fullScreenON.Size = New System.Drawing.Size(136, 22)
        Me.fullScreenON.Text = "Full Screen"
        '
        'setVSYNCMenuItem3
        '
        Me.setVSYNCMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.vsyncON, Me.vsyncOFF})
        Me.setVSYNCMenuItem3.Name = "setVSYNCMenuItem3"
        Me.setVSYNCMenuItem3.Size = New System.Drawing.Size(312, 22)
        Me.setVSYNCMenuItem3.Text = "VSync Wait"
        '
        'vsyncON
        '
        Me.vsyncON.Name = "vsyncON"
        Me.vsyncON.Size = New System.Drawing.Size(90, 22)
        Me.vsyncON.Text = "On"
        '
        'vsyncOFF
        '
        Me.vsyncOFF.Checked = True
        Me.vsyncOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.vsyncOFF.Name = "vsyncOFF"
        Me.vsyncOFF.Size = New System.Drawing.Size(90, 22)
        Me.vsyncOFF.Text = "Off"
        '
        'setTripleBufferMenuItem3
        '
        Me.setTripleBufferMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.triplebufferON, Me.triplebufferOFF})
        Me.setTripleBufferMenuItem3.Name = "setTripleBufferMenuItem3"
        Me.setTripleBufferMenuItem3.Size = New System.Drawing.Size(312, 22)
        Me.setTripleBufferMenuItem3.Text = "Triple Buffer"
        '
        'triplebufferON
        '
        Me.triplebufferON.Name = "triplebufferON"
        Me.triplebufferON.Size = New System.Drawing.Size(90, 22)
        Me.triplebufferON.Text = "On"
        '
        'triplebufferOFF
        '
        Me.triplebufferOFF.Checked = True
        Me.triplebufferOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.triplebufferOFF.Name = "triplebufferOFF"
        Me.triplebufferOFF.Size = New System.Drawing.Size(90, 22)
        Me.triplebufferOFF.Text = "Off"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(309, 6)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox3.Enabled = False
        Me.ToolStripTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.ReadOnly = True
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(252, 14)
        Me.ToolStripTextBox3.Text = "Select Add-On Hardware"
        '
        'SetXMSupportToolStripMenuItem
        '
        Me.SetXMSupportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.xmON, Me.xmOFF})
        Me.SetXMSupportToolStripMenuItem.Name = "SetXMSupportToolStripMenuItem"
        Me.SetXMSupportToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SetXMSupportToolStripMenuItem.Text = "XM Support"
        '
        'xmON
        '
        Me.xmON.Name = "xmON"
        Me.xmON.Size = New System.Drawing.Size(90, 22)
        Me.xmON.Text = "On"
        '
        'xmOFF
        '
        Me.xmOFF.Checked = True
        Me.xmOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.xmOFF.Name = "xmOFF"
        Me.xmOFF.Size = New System.Drawing.Size(90, 22)
        Me.xmOFF.Text = "Off"
        '
        'SetHSCSupportToolStripMenuItem
        '
        Me.SetHSCSupportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hscON, Me.hscOFF})
        Me.SetHSCSupportToolStripMenuItem.Name = "SetHSCSupportToolStripMenuItem"
        Me.SetHSCSupportToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SetHSCSupportToolStripMenuItem.Text = "HSC Support"
        '
        'hscON
        '
        Me.hscON.Name = "hscON"
        Me.hscON.Size = New System.Drawing.Size(90, 22)
        Me.hscON.Text = "On"
        '
        'hscOFF
        '
        Me.hscOFF.Checked = True
        Me.hscOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hscOFF.Name = "hscOFF"
        Me.hscOFF.Size = New System.Drawing.Size(90, 22)
        Me.hscOFF.Text = "Off"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(309, 6)
        '
        'ToolStripTextBox6
        '
        Me.ToolStripTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox6.Enabled = False
        Me.ToolStripTextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolStripTextBox6.Name = "ToolStripTextBox6"
        Me.ToolStripTextBox6.ReadOnly = True
        Me.ToolStripTextBox6.Size = New System.Drawing.Size(252, 14)
        Me.ToolStripTextBox6.Text = "Select Developer Options"
        '
        'setDeveloperMenuItem1
        '
        Me.setDeveloperMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.devON, Me.devOFF})
        Me.setDeveloperMenuItem1.Name = "setDeveloperMenuItem1"
        Me.setDeveloperMenuItem1.Size = New System.Drawing.Size(312, 22)
        Me.setDeveloperMenuItem1.Text = "Developer Mode"
        '
        'devON
        '
        Me.devON.Name = "devON"
        Me.devON.Size = New System.Drawing.Size(90, 22)
        Me.devON.Text = "On"
        '
        'devOFF
        '
        Me.devOFF.Checked = True
        Me.devOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.devOFF.Name = "devOFF"
        Me.devOFF.Size = New System.Drawing.Size(90, 22)
        Me.devOFF.Text = "Off"
        '
        'SetDebugToolStripMenuItem
        '
        Me.SetDebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.debugON, Me.debugOFF})
        Me.SetDebugToolStripMenuItem.Name = "SetDebugToolStripMenuItem"
        Me.SetDebugToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.SetDebugToolStripMenuItem.Text = "Debug Mode"
        '
        'debugON
        '
        Me.debugON.Name = "debugON"
        Me.debugON.Size = New System.Drawing.Size(90, 22)
        Me.debugON.Text = "On"
        '
        'debugOFF
        '
        Me.debugOFF.Checked = True
        Me.debugOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.debugOFF.Name = "debugOFF"
        Me.debugOFF.Size = New System.Drawing.Size(90, 22)
        Me.debugOFF.Text = "Off"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(309, 6)
        '
        'ToolStripTextBox10
        '
        Me.ToolStripTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox10.Enabled = False
        Me.ToolStripTextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox10.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolStripTextBox10.Name = "ToolStripTextBox10"
        Me.ToolStripTextBox10.ReadOnly = True
        Me.ToolStripTextBox10.Size = New System.Drawing.Size(252, 14)
        Me.ToolStripTextBox10.Text = "Select A7800 Emulator Options"
        '
        'EditA7800ConfigurationFileToolStripMenuItem
        '
        Me.EditA7800ConfigurationFileToolStripMenuItem.Name = "EditA7800ConfigurationFileToolStripMenuItem"
        Me.EditA7800ConfigurationFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditA7800ConfigurationFileToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.EditA7800ConfigurationFileToolStripMenuItem.Text = "Edit A7800 Configuration File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(309, 6)
        '
        'ResetAllOptionsToDefaultToolStripMenuItem
        '
        Me.ResetAllOptionsToDefaultToolStripMenuItem.Name = "ResetAllOptionsToDefaultToolStripMenuItem"
        Me.ResetAllOptionsToDefaultToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.ResetAllOptionsToDefaultToolStripMenuItem.Text = "Reset Edit Menu Options to Default"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(309, 6)
        '
        'ResetAllHighScoresToolStripMenuItem
        '
        Me.ResetAllHighScoresToolStripMenuItem.Name = "ResetAllHighScoresToolStripMenuItem"
        Me.ResetAllHighScoresToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.ResetAllHighScoresToolStripMenuItem.Text = "Reset All High Scores"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStatus, Me.WindowToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(45, 21)
        Me.ToolStripMenuItem1.Text = "View"
        '
        'mnuStatus
        '
        Me.mnuStatus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusON, Me.statusOFF})
        Me.mnuStatus.Name = "mnuStatus"
        Me.mnuStatus.Size = New System.Drawing.Size(180, 22)
        Me.mnuStatus.Text = "Status Bar"
        '
        'statusON
        '
        Me.statusON.Checked = True
        Me.statusON.CheckState = System.Windows.Forms.CheckState.Checked
        Me.statusON.Name = "statusON"
        Me.statusON.Size = New System.Drawing.Size(180, 22)
        Me.statusON.Text = "On"
        '
        'statusOFF
        '
        Me.statusOFF.Name = "statusOFF"
        Me.statusOFF.Size = New System.Drawing.Size(180, 22)
        Me.statusOFF.Text = "Off"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.displayFULL, Me.displayMED, Me.displaySMALL})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'displayFULL
        '
        Me.displayFULL.Checked = True
        Me.displayFULL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.displayFULL.Name = "displayFULL"
        Me.displayFULL.Size = New System.Drawing.Size(274, 22)
        Me.displayFULL.Text = "Full: Display All"
        '
        'displayMED
        '
        Me.displayMED.Name = "displayMED"
        Me.displayMED.Size = New System.Drawing.Size(274, 22)
        Me.displayMED.Text = "Medium: Game List and Box Art Only"
        '
        'displaySMALL
        '
        Me.displaySMALL.Name = "displaySMALL"
        Me.displaySMALL.Size = New System.Drawing.Size(274, 22)
        Me.displaySMALL.Text = "Small: Game List Only"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.usersguideToolStripMenuItem3, Me.ToolStripSeparator6, Me.A7800EmulatorToolStripMenuItem, Me.Atari7800ToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'usersguideToolStripMenuItem3
        '
        Me.usersguideToolStripMenuItem3.Name = "usersguideToolStripMenuItem3"
        Me.usersguideToolStripMenuItem3.Size = New System.Drawing.Size(270, 22)
        Me.usersguideToolStripMenuItem3.Text = "Maximus78 User's Guide"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(267, 6)
        '
        'A7800EmulatorToolStripMenuItem
        '
        Me.A7800EmulatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeyboardMappingsToolStripMenuItem, Me.TVAndVideoTipsToolStripMenuItem, Me.ToolStripSeparator8, Me.UsersGuideToolStripMenuItem})
        Me.A7800EmulatorToolStripMenuItem.Name = "A7800EmulatorToolStripMenuItem"
        Me.A7800EmulatorToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.A7800EmulatorToolStripMenuItem.Text = "A7800 Emulator Info"
        '
        'KeyboardMappingsToolStripMenuItem
        '
        Me.KeyboardMappingsToolStripMenuItem.Name = "KeyboardMappingsToolStripMenuItem"
        Me.KeyboardMappingsToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.KeyboardMappingsToolStripMenuItem.Text = "Default Keyboard Mappings"
        '
        'TVAndVideoTipsToolStripMenuItem
        '
        Me.TVAndVideoTipsToolStripMenuItem.Name = "TVAndVideoTipsToolStripMenuItem"
        Me.TVAndVideoTipsToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.TVAndVideoTipsToolStripMenuItem.Text = "TV, Video and Developer Info"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(228, 6)
        '
        'UsersGuideToolStripMenuItem
        '
        Me.UsersGuideToolStripMenuItem.Name = "UsersGuideToolStripMenuItem"
        Me.UsersGuideToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.UsersGuideToolStripMenuItem.Text = "A7800 User's Guide"
        '
        'Atari7800ToolStripMenuItem
        '
        Me.Atari7800ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonDefinitionsForGamesToolStripMenuItem, Me.DifficultySwitchOptionsForGamesToolStripMenuItem, Me.ToolStripSeparator14, Me.Atari7800ProSystemOwnersManualToolStripMenuItem1})
        Me.Atari7800ToolStripMenuItem.Name = "Atari7800ToolStripMenuItem"
        Me.Atari7800ToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.Atari7800ToolStripMenuItem.Text = "Atari 7800 Hardware and Game Info"
        '
        'ButtonDefinitionsForGamesToolStripMenuItem
        '
        Me.ButtonDefinitionsForGamesToolStripMenuItem.Name = "ButtonDefinitionsForGamesToolStripMenuItem"
        Me.ButtonDefinitionsForGamesToolStripMenuItem.Size = New System.Drawing.Size(294, 22)
        Me.ButtonDefinitionsForGamesToolStripMenuItem.Text = "Button Definitions for 7800 Games"
        '
        'DifficultySwitchOptionsForGamesToolStripMenuItem
        '
        Me.DifficultySwitchOptionsForGamesToolStripMenuItem.Name = "DifficultySwitchOptionsForGamesToolStripMenuItem"
        Me.DifficultySwitchOptionsForGamesToolStripMenuItem.Size = New System.Drawing.Size(294, 22)
        Me.DifficultySwitchOptionsForGamesToolStripMenuItem.Text = "Difficulty Switch Options for 7800 Games"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(291, 6)
        '
        'Atari7800ProSystemOwnersManualToolStripMenuItem1
        '
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem1.Name = "Atari7800ProSystemOwnersManualToolStripMenuItem1"
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem1.Size = New System.Drawing.Size(294, 22)
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem1.Text = "Atari 7800 ProSystem Owner's Manual"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.stripPalette, Me.stripTVType, Me.stripVideo, Me.stripStretch, Me.stripWindow, Me.stripVsync, Me.stripTripleBuffer, Me.stripXM, Me.stripHSC, Me.stripDev, Me.stripDebug})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 701)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1358, 24)
        Me.StatusStrip1.TabIndex = 57
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(65, 19)
        Me.ToolStripStatusLabel1.Text = " v0.99.31b  "
        '
        'stripPalette
        '
        Me.stripPalette.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripPalette.Name = "stripPalette"
        Me.stripPalette.Size = New System.Drawing.Size(91, 19)
        Me.stripPalette.Text = "Palette: Warm  "
        '
        'stripTVType
        '
        Me.stripTVType.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripTVType.Name = "stripTVType"
        Me.stripTVType.Size = New System.Drawing.Size(92, 19)
        Me.stripTVType.Text = "TV Type: NTSC  "
        '
        'stripVideo
        '
        Me.stripVideo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripVideo.Name = "stripVideo"
        Me.stripVideo.Size = New System.Drawing.Size(121, 19)
        Me.stripVideo.Text = "Video Output: Basic  "
        '
        'stripStretch
        '
        Me.stripStretch.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripStretch.Name = "stripStretch"
        Me.stripStretch.Size = New System.Drawing.Size(115, 19)
        Me.stripStretch.Text = "Screen Stretch: Off  "
        '
        'stripWindow
        '
        Me.stripWindow.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripWindow.Name = "stripWindow"
        Me.stripWindow.Size = New System.Drawing.Size(158, 19)
        Me.stripWindow.Text = "Window Mode: Windowed  "
        '
        'stripVsync
        '
        Me.stripVsync.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripVsync.Name = "stripVsync"
        Me.stripVsync.Size = New System.Drawing.Size(98, 19)
        Me.stripVsync.Text = "Vsync Wait: Off  "
        '
        'stripTripleBuffer
        '
        Me.stripTripleBuffer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripTripleBuffer.Name = "stripTripleBuffer"
        Me.stripTripleBuffer.Size = New System.Drawing.Size(103, 19)
        Me.stripTripleBuffer.Text = "Triple Buffer: Off  "
        '
        'stripXM
        '
        Me.stripXM.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripXM.Name = "stripXM"
        Me.stripXM.Size = New System.Drawing.Size(103, 19)
        Me.stripXM.Text = "XM Support: Off  "
        '
        'stripHSC
        '
        Me.stripHSC.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripHSC.Name = "stripHSC"
        Me.stripHSC.Size = New System.Drawing.Size(108, 19)
        Me.stripHSC.Text = "HSC Support: Off  "
        '
        'stripDev
        '
        Me.stripDev.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripDev.Name = "stripDev"
        Me.stripDev.Size = New System.Drawing.Size(94, 19)
        Me.stripDev.Text = "Dev Mode: Off  "
        '
        'stripDebug
        '
        Me.stripDebug.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripDebug.Name = "stripDebug"
        Me.stripDebug.Size = New System.Drawing.Size(109, 19)
        Me.stripDebug.Text = "Debug Mode: Off  "
        '
        'TabEditor
        '
        Me.TabEditor.Controls.Add(Me.tabManuals)
        Me.TabEditor.Controls.Add(Me.tabHTMLEditor)
        Me.TabEditor.Controls.Add(Me.tabScreenshots)
        Me.TabEditor.Location = New System.Drawing.Point(846, 24)
        Me.TabEditor.Multiline = True
        Me.TabEditor.Name = "TabEditor"
        Me.TabEditor.SelectedIndex = 0
        Me.TabEditor.Size = New System.Drawing.Size(500, 660)
        Me.TabEditor.TabIndex = 58
        '
        'tabManuals
        '
        Me.tabManuals.Controls.Add(Me.WebBrowser1)
        Me.tabManuals.Location = New System.Drawing.Point(4, 22)
        Me.tabManuals.Name = "tabManuals"
        Me.tabManuals.Padding = New System.Windows.Forms.Padding(3)
        Me.tabManuals.Size = New System.Drawing.Size(492, 634)
        Me.tabManuals.TabIndex = 0
        Me.tabManuals.Text = "Game Information"
        Me.tabManuals.UseVisualStyleBackColor = True
        '
        'tabHTMLEditor
        '
        Me.tabHTMLEditor.Controls.Add(Me.txtEditorFile)
        Me.tabHTMLEditor.Controls.Add(Me.btnLoad)
        Me.tabHTMLEditor.Controls.Add(Me.btnSaveHTML)
        Me.tabHTMLEditor.Controls.Add(Me.txtHTMLEditor)
        Me.tabHTMLEditor.Location = New System.Drawing.Point(4, 22)
        Me.tabHTMLEditor.Name = "tabHTMLEditor"
        Me.tabHTMLEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHTMLEditor.Size = New System.Drawing.Size(492, 634)
        Me.tabHTMLEditor.TabIndex = 1
        Me.tabHTMLEditor.Text = "Game Information HTML Editor"
        Me.tabHTMLEditor.UseVisualStyleBackColor = True
        '
        'txtEditorFile
        '
        Me.txtEditorFile.Location = New System.Drawing.Point(3, 6)
        Me.txtEditorFile.Name = "txtEditorFile"
        Me.txtEditorFile.Size = New System.Drawing.Size(380, 20)
        Me.txtEditorFile.TabIndex = 6
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(395, 118)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(101, 23)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        Me.btnLoad.Visible = False
        '
        'btnSaveHTML
        '
        Me.btnSaveHTML.Location = New System.Drawing.Point(395, 3)
        Me.btnSaveHTML.Name = "btnSaveHTML"
        Me.btnSaveHTML.Size = New System.Drawing.Size(101, 23)
        Me.btnSaveHTML.TabIndex = 4
        Me.btnSaveHTML.Text = "Save"
        Me.btnSaveHTML.UseVisualStyleBackColor = True
        '
        'txtHTMLEditor
        '
        Me.txtHTMLEditor.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHTMLEditor.Location = New System.Drawing.Point(3, 33)
        Me.txtHTMLEditor.Multiline = True
        Me.txtHTMLEditor.Name = "txtHTMLEditor"
        Me.txtHTMLEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHTMLEditor.Size = New System.Drawing.Size(498, 594)
        Me.txtHTMLEditor.TabIndex = 2
        '
        'tabScreenshots
        '
        Me.tabScreenshots.Controls.Add(Me.btnSave6)
        Me.tabScreenshots.Controls.Add(Me.btnLoad6)
        Me.tabScreenshots.Controls.Add(Me.btnUnload6)
        Me.tabScreenshots.Controls.Add(Me.btnSave5)
        Me.tabScreenshots.Controls.Add(Me.btnLoad5)
        Me.tabScreenshots.Controls.Add(Me.btnUnload5)
        Me.tabScreenshots.Controls.Add(Me.btnSave4)
        Me.tabScreenshots.Controls.Add(Me.btnLoad4)
        Me.tabScreenshots.Controls.Add(Me.btnUnload4)
        Me.tabScreenshots.Controls.Add(Me.btnSave3)
        Me.tabScreenshots.Controls.Add(Me.btnLoad3)
        Me.tabScreenshots.Controls.Add(Me.btnUnload3)
        Me.tabScreenshots.Controls.Add(Me.btnSave2)
        Me.tabScreenshots.Controls.Add(Me.btnLoad2)
        Me.tabScreenshots.Controls.Add(Me.btnUnload2)
        Me.tabScreenshots.Controls.Add(Me.btnSave1)
        Me.tabScreenshots.Controls.Add(Me.btnLoad1)
        Me.tabScreenshots.Controls.Add(Me.btnUnload1)
        Me.tabScreenshots.Controls.Add(Me.Screenshot6)
        Me.tabScreenshots.Controls.Add(Me.Screenshot5)
        Me.tabScreenshots.Controls.Add(Me.Screenshot4)
        Me.tabScreenshots.Controls.Add(Me.Screenshot3)
        Me.tabScreenshots.Controls.Add(Me.Screenshot2)
        Me.tabScreenshots.Controls.Add(Me.Screenshot1)
        Me.tabScreenshots.Location = New System.Drawing.Point(4, 22)
        Me.tabScreenshots.Name = "tabScreenshots"
        Me.tabScreenshots.Size = New System.Drawing.Size(492, 634)
        Me.tabScreenshots.TabIndex = 2
        Me.tabScreenshots.Text = "Screenshots"
        Me.tabScreenshots.UseVisualStyleBackColor = True
        '
        'btnSave6
        '
        Me.btnSave6.Location = New System.Drawing.Point(413, 599)
        Me.btnSave6.Name = "btnSave6"
        Me.btnSave6.Size = New System.Drawing.Size(69, 23)
        Me.btnSave6.TabIndex = 25
        Me.btnSave6.Text = "Save"
        Me.btnSave6.UseVisualStyleBackColor = True
        '
        'btnLoad6
        '
        Me.btnLoad6.Location = New System.Drawing.Point(258, 599)
        Me.btnLoad6.Name = "btnLoad6"
        Me.btnLoad6.Size = New System.Drawing.Size(72, 23)
        Me.btnLoad6.TabIndex = 24
        Me.btnLoad6.Text = "Load"
        Me.btnLoad6.UseVisualStyleBackColor = True
        '
        'btnUnload6
        '
        Me.btnUnload6.Location = New System.Drawing.Point(336, 599)
        Me.btnUnload6.Name = "btnUnload6"
        Me.btnUnload6.Size = New System.Drawing.Size(69, 23)
        Me.btnUnload6.TabIndex = 23
        Me.btnUnload6.Text = "Unload"
        Me.btnUnload6.UseVisualStyleBackColor = True
        '
        'btnSave5
        '
        Me.btnSave5.Location = New System.Drawing.Point(167, 600)
        Me.btnSave5.Name = "btnSave5"
        Me.btnSave5.Size = New System.Drawing.Size(69, 23)
        Me.btnSave5.TabIndex = 22
        Me.btnSave5.Text = "Save"
        Me.btnSave5.UseVisualStyleBackColor = True
        '
        'btnLoad5
        '
        Me.btnLoad5.Location = New System.Drawing.Point(12, 600)
        Me.btnLoad5.Name = "btnLoad5"
        Me.btnLoad5.Size = New System.Drawing.Size(72, 23)
        Me.btnLoad5.TabIndex = 21
        Me.btnLoad5.Text = "Load"
        Me.btnLoad5.UseVisualStyleBackColor = True
        '
        'btnUnload5
        '
        Me.btnUnload5.Location = New System.Drawing.Point(90, 600)
        Me.btnUnload5.Name = "btnUnload5"
        Me.btnUnload5.Size = New System.Drawing.Size(69, 23)
        Me.btnUnload5.TabIndex = 20
        Me.btnUnload5.Text = "Unload"
        Me.btnUnload5.UseVisualStyleBackColor = True
        '
        'btnSave4
        '
        Me.btnSave4.Location = New System.Drawing.Point(413, 392)
        Me.btnSave4.Name = "btnSave4"
        Me.btnSave4.Size = New System.Drawing.Size(69, 23)
        Me.btnSave4.TabIndex = 19
        Me.btnSave4.Text = "Save"
        Me.btnSave4.UseVisualStyleBackColor = True
        '
        'btnLoad4
        '
        Me.btnLoad4.Location = New System.Drawing.Point(258, 392)
        Me.btnLoad4.Name = "btnLoad4"
        Me.btnLoad4.Size = New System.Drawing.Size(72, 23)
        Me.btnLoad4.TabIndex = 18
        Me.btnLoad4.Text = "Load"
        Me.btnLoad4.UseVisualStyleBackColor = True
        '
        'btnUnload4
        '
        Me.btnUnload4.Location = New System.Drawing.Point(336, 392)
        Me.btnUnload4.Name = "btnUnload4"
        Me.btnUnload4.Size = New System.Drawing.Size(69, 23)
        Me.btnUnload4.TabIndex = 17
        Me.btnUnload4.Text = "Unload"
        Me.btnUnload4.UseVisualStyleBackColor = True
        '
        'btnSave3
        '
        Me.btnSave3.Location = New System.Drawing.Point(167, 393)
        Me.btnSave3.Name = "btnSave3"
        Me.btnSave3.Size = New System.Drawing.Size(69, 23)
        Me.btnSave3.TabIndex = 16
        Me.btnSave3.Text = "Save"
        Me.btnSave3.UseVisualStyleBackColor = True
        '
        'btnLoad3
        '
        Me.btnLoad3.Location = New System.Drawing.Point(12, 393)
        Me.btnLoad3.Name = "btnLoad3"
        Me.btnLoad3.Size = New System.Drawing.Size(72, 23)
        Me.btnLoad3.TabIndex = 15
        Me.btnLoad3.Text = "Load"
        Me.btnLoad3.UseVisualStyleBackColor = True
        '
        'btnUnload3
        '
        Me.btnUnload3.Location = New System.Drawing.Point(90, 393)
        Me.btnUnload3.Name = "btnUnload3"
        Me.btnUnload3.Size = New System.Drawing.Size(69, 23)
        Me.btnUnload3.TabIndex = 14
        Me.btnUnload3.Text = "Unload"
        Me.btnUnload3.UseVisualStyleBackColor = True
        '
        'btnSave2
        '
        Me.btnSave2.Location = New System.Drawing.Point(413, 186)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(69, 23)
        Me.btnSave2.TabIndex = 13
        Me.btnSave2.Text = "Save"
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'btnLoad2
        '
        Me.btnLoad2.Location = New System.Drawing.Point(258, 186)
        Me.btnLoad2.Name = "btnLoad2"
        Me.btnLoad2.Size = New System.Drawing.Size(72, 23)
        Me.btnLoad2.TabIndex = 12
        Me.btnLoad2.Text = "Load"
        Me.btnLoad2.UseVisualStyleBackColor = True
        '
        'btnUnload2
        '
        Me.btnUnload2.Location = New System.Drawing.Point(336, 186)
        Me.btnUnload2.Name = "btnUnload2"
        Me.btnUnload2.Size = New System.Drawing.Size(69, 23)
        Me.btnUnload2.TabIndex = 11
        Me.btnUnload2.Text = "Unload"
        Me.btnUnload2.UseVisualStyleBackColor = True
        '
        'btnSave1
        '
        Me.btnSave1.Location = New System.Drawing.Point(167, 187)
        Me.btnSave1.Name = "btnSave1"
        Me.btnSave1.Size = New System.Drawing.Size(69, 23)
        Me.btnSave1.TabIndex = 10
        Me.btnSave1.Text = "Save"
        Me.btnSave1.UseVisualStyleBackColor = True
        '
        'btnLoad1
        '
        Me.btnLoad1.Location = New System.Drawing.Point(12, 187)
        Me.btnLoad1.Name = "btnLoad1"
        Me.btnLoad1.Size = New System.Drawing.Size(72, 23)
        Me.btnLoad1.TabIndex = 9
        Me.btnLoad1.Text = "Load"
        Me.btnLoad1.UseVisualStyleBackColor = True
        '
        'btnUnload1
        '
        Me.btnUnload1.Location = New System.Drawing.Point(90, 187)
        Me.btnUnload1.Name = "btnUnload1"
        Me.btnUnload1.Size = New System.Drawing.Size(69, 23)
        Me.btnUnload1.TabIndex = 8
        Me.btnUnload1.Text = "Unload"
        Me.btnUnload1.UseVisualStyleBackColor = True
        '
        'Screenshot6
        '
        Me.Screenshot6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Screenshot6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Screenshot6.Location = New System.Drawing.Point(258, 429)
        Me.Screenshot6.Name = "Screenshot6"
        Me.Screenshot6.Size = New System.Drawing.Size(224, 168)
        Me.Screenshot6.TabIndex = 5
        Me.Screenshot6.TabStop = False
        '
        'Screenshot5
        '
        Me.Screenshot5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Screenshot5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Screenshot5.Location = New System.Drawing.Point(12, 429)
        Me.Screenshot5.Name = "Screenshot5"
        Me.Screenshot5.Size = New System.Drawing.Size(224, 168)
        Me.Screenshot5.TabIndex = 4
        Me.Screenshot5.TabStop = False
        '
        'Screenshot4
        '
        Me.Screenshot4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Screenshot4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Screenshot4.Location = New System.Drawing.Point(258, 222)
        Me.Screenshot4.Name = "Screenshot4"
        Me.Screenshot4.Size = New System.Drawing.Size(224, 168)
        Me.Screenshot4.TabIndex = 3
        Me.Screenshot4.TabStop = False
        '
        'Screenshot3
        '
        Me.Screenshot3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Screenshot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Screenshot3.Location = New System.Drawing.Point(12, 222)
        Me.Screenshot3.Name = "Screenshot3"
        Me.Screenshot3.Size = New System.Drawing.Size(224, 168)
        Me.Screenshot3.TabIndex = 2
        Me.Screenshot3.TabStop = False
        '
        'Screenshot2
        '
        Me.Screenshot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Screenshot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Screenshot2.Location = New System.Drawing.Point(258, 16)
        Me.Screenshot2.Name = "Screenshot2"
        Me.Screenshot2.Size = New System.Drawing.Size(224, 168)
        Me.Screenshot2.TabIndex = 1
        Me.Screenshot2.TabStop = False
        '
        'Screenshot1
        '
        Me.Screenshot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Screenshot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Screenshot1.InitialImage = Nothing
        Me.Screenshot1.Location = New System.Drawing.Point(12, 16)
        Me.Screenshot1.Name = "Screenshot1"
        Me.Screenshot1.Size = New System.Drawing.Size(224, 168)
        Me.Screenshot1.TabIndex = 0
        Me.Screenshot1.TabStop = False
        '
        'pctBoxArt
        '
        Me.pctBoxArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctBoxArt.Location = New System.Drawing.Point(6, 6)
        Me.pctBoxArt.Name = "pctBoxArt"
        Me.pctBoxArt.Size = New System.Drawing.Size(360, 485)
        Me.pctBoxArt.TabIndex = 33
        Me.pctBoxArt.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabBoxArt)
        Me.TabControl1.Controls.Add(Me.tabHighScores)
        Me.TabControl1.Controls.Add(Me.tabDirectoryPaths)
        Me.TabControl1.Location = New System.Drawing.Point(460, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(380, 659)
        Me.TabControl1.TabIndex = 59
        '
        'tabBoxArt
        '
        Me.tabBoxArt.Controls.Add(Me.txtPath)
        Me.tabBoxArt.Controls.Add(Me.pctBoxArt)
        Me.tabBoxArt.Location = New System.Drawing.Point(4, 22)
        Me.tabBoxArt.Name = "tabBoxArt"
        Me.tabBoxArt.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBoxArt.Size = New System.Drawing.Size(372, 633)
        Me.tabBoxArt.TabIndex = 0
        Me.tabBoxArt.Text = "Box Art"
        Me.tabBoxArt.UseVisualStyleBackColor = True
        '
        'tabHighScores
        '
        Me.tabHighScores.Controls.Add(Me.txtInitials27)
        Me.tabHighScores.Controls.Add(Me.txtInitials26)
        Me.tabHighScores.Controls.Add(Me.txtInitials25)
        Me.tabHighScores.Controls.Add(Me.txtInitials24)
        Me.tabHighScores.Controls.Add(Me.txtInitials23)
        Me.tabHighScores.Controls.Add(Me.txtInitials22)
        Me.tabHighScores.Controls.Add(Me.txtInitials21)
        Me.tabHighScores.Controls.Add(Me.txtDate27)
        Me.tabHighScores.Controls.Add(Me.txtDate26)
        Me.tabHighScores.Controls.Add(Me.txtDate25)
        Me.tabHighScores.Controls.Add(Me.txtDate24)
        Me.tabHighScores.Controls.Add(Me.txtDate23)
        Me.tabHighScores.Controls.Add(Me.txtDate22)
        Me.tabHighScores.Controls.Add(Me.txtDate21)
        Me.tabHighScores.Controls.Add(Me.txtPlayer27)
        Me.tabHighScores.Controls.Add(Me.txtPlayer26)
        Me.tabHighScores.Controls.Add(Me.txtPlayer25)
        Me.tabHighScores.Controls.Add(Me.txtPlayer24)
        Me.tabHighScores.Controls.Add(Me.txtPlayer23)
        Me.tabHighScores.Controls.Add(Me.txtPlayer22)
        Me.tabHighScores.Controls.Add(Me.txtPlayer21)
        Me.tabHighScores.Controls.Add(Me.txtScore27)
        Me.tabHighScores.Controls.Add(Me.txtScore26)
        Me.tabHighScores.Controls.Add(Me.txtScore25)
        Me.tabHighScores.Controls.Add(Me.txtScore24)
        Me.tabHighScores.Controls.Add(Me.txtScore23)
        Me.tabHighScores.Controls.Add(Me.txtScore22)
        Me.tabHighScores.Controls.Add(Me.txtScore21)
        Me.tabHighScores.Controls.Add(Me.txtInitials20)
        Me.tabHighScores.Controls.Add(Me.txtInitials19)
        Me.tabHighScores.Controls.Add(Me.txtInitials18)
        Me.tabHighScores.Controls.Add(Me.txtInitials17)
        Me.tabHighScores.Controls.Add(Me.txtInitials16)
        Me.tabHighScores.Controls.Add(Me.txtInitials15)
        Me.tabHighScores.Controls.Add(Me.txtInitials14)
        Me.tabHighScores.Controls.Add(Me.txtInitials13)
        Me.tabHighScores.Controls.Add(Me.txtInitials12)
        Me.tabHighScores.Controls.Add(Me.txtInitials11)
        Me.tabHighScores.Controls.Add(Me.txtInitials10)
        Me.tabHighScores.Controls.Add(Me.txtInitials9)
        Me.tabHighScores.Controls.Add(Me.txtInitials8)
        Me.tabHighScores.Controls.Add(Me.txtInitials7)
        Me.tabHighScores.Controls.Add(Me.txtInitials6)
        Me.tabHighScores.Controls.Add(Me.txtInitials5)
        Me.tabHighScores.Controls.Add(Me.txtInitials4)
        Me.tabHighScores.Controls.Add(Me.txtInitials3)
        Me.tabHighScores.Controls.Add(Me.txtInitials2)
        Me.tabHighScores.Controls.Add(Me.Label15)
        Me.tabHighScores.Controls.Add(Me.txtInitials1)
        Me.tabHighScores.Controls.Add(Me.txtDate20)
        Me.tabHighScores.Controls.Add(Me.txtDate19)
        Me.tabHighScores.Controls.Add(Me.txtDate18)
        Me.tabHighScores.Controls.Add(Me.txtDate17)
        Me.tabHighScores.Controls.Add(Me.txtDate16)
        Me.tabHighScores.Controls.Add(Me.txtDate15)
        Me.tabHighScores.Controls.Add(Me.txtDate14)
        Me.tabHighScores.Controls.Add(Me.txtDate13)
        Me.tabHighScores.Controls.Add(Me.txtDate12)
        Me.tabHighScores.Controls.Add(Me.txtPlayer20)
        Me.tabHighScores.Controls.Add(Me.txtPlayer19)
        Me.tabHighScores.Controls.Add(Me.txtPlayer18)
        Me.tabHighScores.Controls.Add(Me.txtPlayer17)
        Me.tabHighScores.Controls.Add(Me.txtPlayer16)
        Me.tabHighScores.Controls.Add(Me.txtPlayer15)
        Me.tabHighScores.Controls.Add(Me.txtPlayer14)
        Me.tabHighScores.Controls.Add(Me.txtPlayer13)
        Me.tabHighScores.Controls.Add(Me.txtPlayer12)
        Me.tabHighScores.Controls.Add(Me.txtScore20)
        Me.tabHighScores.Controls.Add(Me.txtScore19)
        Me.tabHighScores.Controls.Add(Me.txtScore18)
        Me.tabHighScores.Controls.Add(Me.txtScore17)
        Me.tabHighScores.Controls.Add(Me.txtScore16)
        Me.tabHighScores.Controls.Add(Me.txtScore15)
        Me.tabHighScores.Controls.Add(Me.txtScore14)
        Me.tabHighScores.Controls.Add(Me.txtScore13)
        Me.tabHighScores.Controls.Add(Me.txtScore12)
        Me.tabHighScores.Controls.Add(Me.txtDate11)
        Me.tabHighScores.Controls.Add(Me.txtPlayer11)
        Me.tabHighScores.Controls.Add(Me.txtScore11)
        Me.tabHighScores.Controls.Add(Me.txtDate10)
        Me.tabHighScores.Controls.Add(Me.txtDate9)
        Me.tabHighScores.Controls.Add(Me.txtDate8)
        Me.tabHighScores.Controls.Add(Me.txtDate7)
        Me.tabHighScores.Controls.Add(Me.txtDate6)
        Me.tabHighScores.Controls.Add(Me.txtDate5)
        Me.tabHighScores.Controls.Add(Me.txtDate4)
        Me.tabHighScores.Controls.Add(Me.txtDate3)
        Me.tabHighScores.Controls.Add(Me.txtDate2)
        Me.tabHighScores.Controls.Add(Me.txtPlayer10)
        Me.tabHighScores.Controls.Add(Me.txtPlayer9)
        Me.tabHighScores.Controls.Add(Me.txtPlayer8)
        Me.tabHighScores.Controls.Add(Me.txtPlayer7)
        Me.tabHighScores.Controls.Add(Me.txtPlayer6)
        Me.tabHighScores.Controls.Add(Me.txtPlayer5)
        Me.tabHighScores.Controls.Add(Me.txtPlayer4)
        Me.tabHighScores.Controls.Add(Me.txtPlayer3)
        Me.tabHighScores.Controls.Add(Me.txtPlayer2)
        Me.tabHighScores.Controls.Add(Me.txtScore10)
        Me.tabHighScores.Controls.Add(Me.txtScore9)
        Me.tabHighScores.Controls.Add(Me.txtScore8)
        Me.tabHighScores.Controls.Add(Me.txtScore7)
        Me.tabHighScores.Controls.Add(Me.txtScore6)
        Me.tabHighScores.Controls.Add(Me.txtScore5)
        Me.tabHighScores.Controls.Add(Me.txtScore4)
        Me.tabHighScores.Controls.Add(Me.txtScore3)
        Me.tabHighScores.Controls.Add(Me.txtScore2)
        Me.tabHighScores.Controls.Add(Me.txtDate1)
        Me.tabHighScores.Controls.Add(Me.txtPlayer1)
        Me.tabHighScores.Controls.Add(Me.Label14)
        Me.tabHighScores.Controls.Add(Me.Label13)
        Me.tabHighScores.Controls.Add(Me.Label12)
        Me.tabHighScores.Controls.Add(Me.txtScore1)
        Me.tabHighScores.Location = New System.Drawing.Point(4, 22)
        Me.tabHighScores.Name = "tabHighScores"
        Me.tabHighScores.Size = New System.Drawing.Size(372, 633)
        Me.tabHighScores.TabIndex = 2
        Me.tabHighScores.Text = "High Scores"
        Me.tabHighScores.UseVisualStyleBackColor = True
        '
        'txtInitials27
        '
        Me.txtInitials27.Location = New System.Drawing.Point(326, 603)
        Me.txtInitials27.Name = "txtInitials27"
        Me.txtInitials27.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials27.TabIndex = 114
        '
        'txtInitials26
        '
        Me.txtInitials26.Location = New System.Drawing.Point(326, 581)
        Me.txtInitials26.Name = "txtInitials26"
        Me.txtInitials26.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials26.TabIndex = 113
        '
        'txtInitials25
        '
        Me.txtInitials25.Location = New System.Drawing.Point(326, 559)
        Me.txtInitials25.Name = "txtInitials25"
        Me.txtInitials25.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials25.TabIndex = 112
        '
        'txtInitials24
        '
        Me.txtInitials24.Location = New System.Drawing.Point(326, 537)
        Me.txtInitials24.Name = "txtInitials24"
        Me.txtInitials24.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials24.TabIndex = 111
        '
        'txtInitials23
        '
        Me.txtInitials23.Location = New System.Drawing.Point(326, 515)
        Me.txtInitials23.Name = "txtInitials23"
        Me.txtInitials23.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials23.TabIndex = 110
        '
        'txtInitials22
        '
        Me.txtInitials22.Location = New System.Drawing.Point(326, 493)
        Me.txtInitials22.Name = "txtInitials22"
        Me.txtInitials22.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials22.TabIndex = 109
        '
        'txtInitials21
        '
        Me.txtInitials21.Location = New System.Drawing.Point(326, 471)
        Me.txtInitials21.Name = "txtInitials21"
        Me.txtInitials21.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials21.TabIndex = 108
        '
        'txtDate27
        '
        Me.txtDate27.Location = New System.Drawing.Point(264, 603)
        Me.txtDate27.Name = "txtDate27"
        Me.txtDate27.Size = New System.Drawing.Size(60, 20)
        Me.txtDate27.TabIndex = 107
        '
        'txtDate26
        '
        Me.txtDate26.Location = New System.Drawing.Point(264, 581)
        Me.txtDate26.Name = "txtDate26"
        Me.txtDate26.Size = New System.Drawing.Size(60, 20)
        Me.txtDate26.TabIndex = 106
        '
        'txtDate25
        '
        Me.txtDate25.Location = New System.Drawing.Point(264, 559)
        Me.txtDate25.Name = "txtDate25"
        Me.txtDate25.Size = New System.Drawing.Size(60, 20)
        Me.txtDate25.TabIndex = 105
        '
        'txtDate24
        '
        Me.txtDate24.Location = New System.Drawing.Point(264, 537)
        Me.txtDate24.Name = "txtDate24"
        Me.txtDate24.Size = New System.Drawing.Size(60, 20)
        Me.txtDate24.TabIndex = 104
        '
        'txtDate23
        '
        Me.txtDate23.Location = New System.Drawing.Point(264, 515)
        Me.txtDate23.Name = "txtDate23"
        Me.txtDate23.Size = New System.Drawing.Size(60, 20)
        Me.txtDate23.TabIndex = 103
        '
        'txtDate22
        '
        Me.txtDate22.Location = New System.Drawing.Point(264, 493)
        Me.txtDate22.Name = "txtDate22"
        Me.txtDate22.Size = New System.Drawing.Size(60, 20)
        Me.txtDate22.TabIndex = 102
        '
        'txtDate21
        '
        Me.txtDate21.Location = New System.Drawing.Point(264, 471)
        Me.txtDate21.Name = "txtDate21"
        Me.txtDate21.Size = New System.Drawing.Size(60, 20)
        Me.txtDate21.TabIndex = 101
        '
        'txtPlayer27
        '
        Me.txtPlayer27.Location = New System.Drawing.Point(99, 603)
        Me.txtPlayer27.Name = "txtPlayer27"
        Me.txtPlayer27.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer27.TabIndex = 100
        '
        'txtPlayer26
        '
        Me.txtPlayer26.Location = New System.Drawing.Point(99, 581)
        Me.txtPlayer26.Name = "txtPlayer26"
        Me.txtPlayer26.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer26.TabIndex = 99
        '
        'txtPlayer25
        '
        Me.txtPlayer25.Location = New System.Drawing.Point(99, 559)
        Me.txtPlayer25.Name = "txtPlayer25"
        Me.txtPlayer25.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer25.TabIndex = 98
        '
        'txtPlayer24
        '
        Me.txtPlayer24.Location = New System.Drawing.Point(99, 537)
        Me.txtPlayer24.Name = "txtPlayer24"
        Me.txtPlayer24.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer24.TabIndex = 97
        '
        'txtPlayer23
        '
        Me.txtPlayer23.Location = New System.Drawing.Point(99, 515)
        Me.txtPlayer23.Name = "txtPlayer23"
        Me.txtPlayer23.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer23.TabIndex = 96
        '
        'txtPlayer22
        '
        Me.txtPlayer22.Location = New System.Drawing.Point(99, 493)
        Me.txtPlayer22.Name = "txtPlayer22"
        Me.txtPlayer22.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer22.TabIndex = 95
        '
        'txtPlayer21
        '
        Me.txtPlayer21.Location = New System.Drawing.Point(99, 471)
        Me.txtPlayer21.Name = "txtPlayer21"
        Me.txtPlayer21.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer21.TabIndex = 94
        '
        'txtScore27
        '
        Me.txtScore27.Location = New System.Drawing.Point(15, 603)
        Me.txtScore27.Name = "txtScore27"
        Me.txtScore27.Size = New System.Drawing.Size(82, 20)
        Me.txtScore27.TabIndex = 93
        '
        'txtScore26
        '
        Me.txtScore26.Location = New System.Drawing.Point(15, 581)
        Me.txtScore26.Name = "txtScore26"
        Me.txtScore26.Size = New System.Drawing.Size(82, 20)
        Me.txtScore26.TabIndex = 92
        '
        'txtScore25
        '
        Me.txtScore25.Location = New System.Drawing.Point(15, 559)
        Me.txtScore25.Name = "txtScore25"
        Me.txtScore25.Size = New System.Drawing.Size(82, 20)
        Me.txtScore25.TabIndex = 91
        '
        'txtScore24
        '
        Me.txtScore24.Location = New System.Drawing.Point(15, 537)
        Me.txtScore24.Name = "txtScore24"
        Me.txtScore24.Size = New System.Drawing.Size(82, 20)
        Me.txtScore24.TabIndex = 90
        '
        'txtScore23
        '
        Me.txtScore23.Location = New System.Drawing.Point(15, 515)
        Me.txtScore23.Name = "txtScore23"
        Me.txtScore23.Size = New System.Drawing.Size(82, 20)
        Me.txtScore23.TabIndex = 89
        '
        'txtScore22
        '
        Me.txtScore22.Location = New System.Drawing.Point(15, 493)
        Me.txtScore22.Name = "txtScore22"
        Me.txtScore22.Size = New System.Drawing.Size(82, 20)
        Me.txtScore22.TabIndex = 88
        '
        'txtScore21
        '
        Me.txtScore21.Location = New System.Drawing.Point(15, 471)
        Me.txtScore21.Name = "txtScore21"
        Me.txtScore21.Size = New System.Drawing.Size(82, 20)
        Me.txtScore21.TabIndex = 87
        '
        'txtInitials20
        '
        Me.txtInitials20.Location = New System.Drawing.Point(326, 449)
        Me.txtInitials20.Name = "txtInitials20"
        Me.txtInitials20.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials20.TabIndex = 86
        '
        'txtInitials19
        '
        Me.txtInitials19.Location = New System.Drawing.Point(326, 427)
        Me.txtInitials19.Name = "txtInitials19"
        Me.txtInitials19.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials19.TabIndex = 85
        '
        'txtInitials18
        '
        Me.txtInitials18.Location = New System.Drawing.Point(326, 405)
        Me.txtInitials18.Name = "txtInitials18"
        Me.txtInitials18.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials18.TabIndex = 84
        '
        'txtInitials17
        '
        Me.txtInitials17.Location = New System.Drawing.Point(326, 383)
        Me.txtInitials17.Name = "txtInitials17"
        Me.txtInitials17.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials17.TabIndex = 83
        '
        'txtInitials16
        '
        Me.txtInitials16.Location = New System.Drawing.Point(326, 361)
        Me.txtInitials16.Name = "txtInitials16"
        Me.txtInitials16.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials16.TabIndex = 82
        '
        'txtInitials15
        '
        Me.txtInitials15.Location = New System.Drawing.Point(326, 339)
        Me.txtInitials15.Name = "txtInitials15"
        Me.txtInitials15.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials15.TabIndex = 81
        '
        'txtInitials14
        '
        Me.txtInitials14.Location = New System.Drawing.Point(326, 317)
        Me.txtInitials14.Name = "txtInitials14"
        Me.txtInitials14.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials14.TabIndex = 80
        '
        'txtInitials13
        '
        Me.txtInitials13.Location = New System.Drawing.Point(326, 295)
        Me.txtInitials13.Name = "txtInitials13"
        Me.txtInitials13.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials13.TabIndex = 79
        '
        'txtInitials12
        '
        Me.txtInitials12.Location = New System.Drawing.Point(326, 273)
        Me.txtInitials12.Name = "txtInitials12"
        Me.txtInitials12.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials12.TabIndex = 78
        '
        'txtInitials11
        '
        Me.txtInitials11.Location = New System.Drawing.Point(326, 251)
        Me.txtInitials11.Name = "txtInitials11"
        Me.txtInitials11.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials11.TabIndex = 77
        '
        'txtInitials10
        '
        Me.txtInitials10.Location = New System.Drawing.Point(326, 229)
        Me.txtInitials10.Name = "txtInitials10"
        Me.txtInitials10.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials10.TabIndex = 76
        '
        'txtInitials9
        '
        Me.txtInitials9.Location = New System.Drawing.Point(326, 207)
        Me.txtInitials9.Name = "txtInitials9"
        Me.txtInitials9.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials9.TabIndex = 75
        '
        'txtInitials8
        '
        Me.txtInitials8.Location = New System.Drawing.Point(326, 185)
        Me.txtInitials8.Name = "txtInitials8"
        Me.txtInitials8.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials8.TabIndex = 74
        '
        'txtInitials7
        '
        Me.txtInitials7.Location = New System.Drawing.Point(326, 163)
        Me.txtInitials7.Name = "txtInitials7"
        Me.txtInitials7.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials7.TabIndex = 73
        '
        'txtInitials6
        '
        Me.txtInitials6.Location = New System.Drawing.Point(326, 141)
        Me.txtInitials6.Name = "txtInitials6"
        Me.txtInitials6.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials6.TabIndex = 72
        '
        'txtInitials5
        '
        Me.txtInitials5.Location = New System.Drawing.Point(326, 119)
        Me.txtInitials5.Name = "txtInitials5"
        Me.txtInitials5.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials5.TabIndex = 71
        '
        'txtInitials4
        '
        Me.txtInitials4.Location = New System.Drawing.Point(326, 97)
        Me.txtInitials4.Name = "txtInitials4"
        Me.txtInitials4.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials4.TabIndex = 70
        '
        'txtInitials3
        '
        Me.txtInitials3.Location = New System.Drawing.Point(326, 75)
        Me.txtInitials3.Name = "txtInitials3"
        Me.txtInitials3.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials3.TabIndex = 69
        '
        'txtInitials2
        '
        Me.txtInitials2.Location = New System.Drawing.Point(326, 53)
        Me.txtInitials2.Name = "txtInitials2"
        Me.txtInitials2.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials2.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(323, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Initials"
        '
        'txtInitials1
        '
        Me.txtInitials1.Location = New System.Drawing.Point(326, 31)
        Me.txtInitials1.Name = "txtInitials1"
        Me.txtInitials1.Size = New System.Drawing.Size(33, 20)
        Me.txtInitials1.TabIndex = 66
        '
        'txtDate20
        '
        Me.txtDate20.Location = New System.Drawing.Point(264, 449)
        Me.txtDate20.Name = "txtDate20"
        Me.txtDate20.Size = New System.Drawing.Size(60, 20)
        Me.txtDate20.TabIndex = 65
        '
        'txtDate19
        '
        Me.txtDate19.Location = New System.Drawing.Point(264, 427)
        Me.txtDate19.Name = "txtDate19"
        Me.txtDate19.Size = New System.Drawing.Size(60, 20)
        Me.txtDate19.TabIndex = 64
        '
        'txtDate18
        '
        Me.txtDate18.Location = New System.Drawing.Point(264, 405)
        Me.txtDate18.Name = "txtDate18"
        Me.txtDate18.Size = New System.Drawing.Size(60, 20)
        Me.txtDate18.TabIndex = 63
        '
        'txtDate17
        '
        Me.txtDate17.Location = New System.Drawing.Point(264, 383)
        Me.txtDate17.Name = "txtDate17"
        Me.txtDate17.Size = New System.Drawing.Size(60, 20)
        Me.txtDate17.TabIndex = 62
        '
        'txtDate16
        '
        Me.txtDate16.Location = New System.Drawing.Point(264, 361)
        Me.txtDate16.Name = "txtDate16"
        Me.txtDate16.Size = New System.Drawing.Size(60, 20)
        Me.txtDate16.TabIndex = 61
        '
        'txtDate15
        '
        Me.txtDate15.Location = New System.Drawing.Point(264, 339)
        Me.txtDate15.Name = "txtDate15"
        Me.txtDate15.Size = New System.Drawing.Size(60, 20)
        Me.txtDate15.TabIndex = 60
        '
        'txtDate14
        '
        Me.txtDate14.Location = New System.Drawing.Point(264, 317)
        Me.txtDate14.Name = "txtDate14"
        Me.txtDate14.Size = New System.Drawing.Size(60, 20)
        Me.txtDate14.TabIndex = 59
        '
        'txtDate13
        '
        Me.txtDate13.Location = New System.Drawing.Point(264, 295)
        Me.txtDate13.Name = "txtDate13"
        Me.txtDate13.Size = New System.Drawing.Size(60, 20)
        Me.txtDate13.TabIndex = 58
        '
        'txtDate12
        '
        Me.txtDate12.Location = New System.Drawing.Point(264, 273)
        Me.txtDate12.Name = "txtDate12"
        Me.txtDate12.Size = New System.Drawing.Size(60, 20)
        Me.txtDate12.TabIndex = 57
        '
        'txtPlayer20
        '
        Me.txtPlayer20.Location = New System.Drawing.Point(99, 449)
        Me.txtPlayer20.Name = "txtPlayer20"
        Me.txtPlayer20.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer20.TabIndex = 56
        '
        'txtPlayer19
        '
        Me.txtPlayer19.Location = New System.Drawing.Point(99, 427)
        Me.txtPlayer19.Name = "txtPlayer19"
        Me.txtPlayer19.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer19.TabIndex = 55
        '
        'txtPlayer18
        '
        Me.txtPlayer18.Location = New System.Drawing.Point(99, 405)
        Me.txtPlayer18.Name = "txtPlayer18"
        Me.txtPlayer18.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer18.TabIndex = 54
        '
        'txtPlayer17
        '
        Me.txtPlayer17.Location = New System.Drawing.Point(99, 383)
        Me.txtPlayer17.Name = "txtPlayer17"
        Me.txtPlayer17.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer17.TabIndex = 53
        '
        'txtPlayer16
        '
        Me.txtPlayer16.Location = New System.Drawing.Point(99, 361)
        Me.txtPlayer16.Name = "txtPlayer16"
        Me.txtPlayer16.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer16.TabIndex = 52
        '
        'txtPlayer15
        '
        Me.txtPlayer15.Location = New System.Drawing.Point(99, 339)
        Me.txtPlayer15.Name = "txtPlayer15"
        Me.txtPlayer15.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer15.TabIndex = 51
        '
        'txtPlayer14
        '
        Me.txtPlayer14.Location = New System.Drawing.Point(99, 317)
        Me.txtPlayer14.Name = "txtPlayer14"
        Me.txtPlayer14.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer14.TabIndex = 50
        '
        'txtPlayer13
        '
        Me.txtPlayer13.Location = New System.Drawing.Point(99, 295)
        Me.txtPlayer13.Name = "txtPlayer13"
        Me.txtPlayer13.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer13.TabIndex = 49
        '
        'txtPlayer12
        '
        Me.txtPlayer12.Location = New System.Drawing.Point(99, 273)
        Me.txtPlayer12.Name = "txtPlayer12"
        Me.txtPlayer12.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer12.TabIndex = 48
        '
        'txtScore20
        '
        Me.txtScore20.Location = New System.Drawing.Point(15, 449)
        Me.txtScore20.Name = "txtScore20"
        Me.txtScore20.Size = New System.Drawing.Size(82, 20)
        Me.txtScore20.TabIndex = 47
        '
        'txtScore19
        '
        Me.txtScore19.Location = New System.Drawing.Point(15, 427)
        Me.txtScore19.Name = "txtScore19"
        Me.txtScore19.Size = New System.Drawing.Size(82, 20)
        Me.txtScore19.TabIndex = 46
        '
        'txtScore18
        '
        Me.txtScore18.Location = New System.Drawing.Point(15, 405)
        Me.txtScore18.Name = "txtScore18"
        Me.txtScore18.Size = New System.Drawing.Size(82, 20)
        Me.txtScore18.TabIndex = 45
        '
        'txtScore17
        '
        Me.txtScore17.Location = New System.Drawing.Point(15, 383)
        Me.txtScore17.Name = "txtScore17"
        Me.txtScore17.Size = New System.Drawing.Size(82, 20)
        Me.txtScore17.TabIndex = 44
        '
        'txtScore16
        '
        Me.txtScore16.Location = New System.Drawing.Point(15, 361)
        Me.txtScore16.Name = "txtScore16"
        Me.txtScore16.Size = New System.Drawing.Size(82, 20)
        Me.txtScore16.TabIndex = 43
        '
        'txtScore15
        '
        Me.txtScore15.Location = New System.Drawing.Point(15, 339)
        Me.txtScore15.Name = "txtScore15"
        Me.txtScore15.Size = New System.Drawing.Size(82, 20)
        Me.txtScore15.TabIndex = 42
        '
        'txtScore14
        '
        Me.txtScore14.Location = New System.Drawing.Point(15, 317)
        Me.txtScore14.Name = "txtScore14"
        Me.txtScore14.Size = New System.Drawing.Size(82, 20)
        Me.txtScore14.TabIndex = 41
        '
        'txtScore13
        '
        Me.txtScore13.Location = New System.Drawing.Point(15, 295)
        Me.txtScore13.Name = "txtScore13"
        Me.txtScore13.Size = New System.Drawing.Size(82, 20)
        Me.txtScore13.TabIndex = 40
        '
        'txtScore12
        '
        Me.txtScore12.Location = New System.Drawing.Point(15, 273)
        Me.txtScore12.Name = "txtScore12"
        Me.txtScore12.Size = New System.Drawing.Size(82, 20)
        Me.txtScore12.TabIndex = 39
        '
        'txtDate11
        '
        Me.txtDate11.Location = New System.Drawing.Point(264, 251)
        Me.txtDate11.Name = "txtDate11"
        Me.txtDate11.Size = New System.Drawing.Size(60, 20)
        Me.txtDate11.TabIndex = 38
        '
        'txtPlayer11
        '
        Me.txtPlayer11.Location = New System.Drawing.Point(99, 251)
        Me.txtPlayer11.Name = "txtPlayer11"
        Me.txtPlayer11.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer11.TabIndex = 37
        '
        'txtScore11
        '
        Me.txtScore11.Location = New System.Drawing.Point(15, 251)
        Me.txtScore11.Name = "txtScore11"
        Me.txtScore11.Size = New System.Drawing.Size(82, 20)
        Me.txtScore11.TabIndex = 36
        '
        'txtDate10
        '
        Me.txtDate10.Location = New System.Drawing.Point(264, 229)
        Me.txtDate10.Name = "txtDate10"
        Me.txtDate10.Size = New System.Drawing.Size(60, 20)
        Me.txtDate10.TabIndex = 32
        '
        'txtDate9
        '
        Me.txtDate9.Location = New System.Drawing.Point(264, 207)
        Me.txtDate9.Name = "txtDate9"
        Me.txtDate9.Size = New System.Drawing.Size(60, 20)
        Me.txtDate9.TabIndex = 31
        '
        'txtDate8
        '
        Me.txtDate8.Location = New System.Drawing.Point(264, 185)
        Me.txtDate8.Name = "txtDate8"
        Me.txtDate8.Size = New System.Drawing.Size(61, 20)
        Me.txtDate8.TabIndex = 30
        '
        'txtDate7
        '
        Me.txtDate7.Location = New System.Drawing.Point(264, 163)
        Me.txtDate7.Name = "txtDate7"
        Me.txtDate7.Size = New System.Drawing.Size(60, 20)
        Me.txtDate7.TabIndex = 29
        '
        'txtDate6
        '
        Me.txtDate6.Location = New System.Drawing.Point(264, 141)
        Me.txtDate6.Name = "txtDate6"
        Me.txtDate6.Size = New System.Drawing.Size(60, 20)
        Me.txtDate6.TabIndex = 28
        '
        'txtDate5
        '
        Me.txtDate5.Location = New System.Drawing.Point(264, 119)
        Me.txtDate5.Name = "txtDate5"
        Me.txtDate5.Size = New System.Drawing.Size(60, 20)
        Me.txtDate5.TabIndex = 27
        '
        'txtDate4
        '
        Me.txtDate4.Location = New System.Drawing.Point(264, 97)
        Me.txtDate4.Name = "txtDate4"
        Me.txtDate4.Size = New System.Drawing.Size(60, 20)
        Me.txtDate4.TabIndex = 26
        '
        'txtDate3
        '
        Me.txtDate3.Location = New System.Drawing.Point(264, 75)
        Me.txtDate3.Name = "txtDate3"
        Me.txtDate3.Size = New System.Drawing.Size(60, 20)
        Me.txtDate3.TabIndex = 25
        '
        'txtDate2
        '
        Me.txtDate2.Location = New System.Drawing.Point(264, 53)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.Size = New System.Drawing.Size(60, 20)
        Me.txtDate2.TabIndex = 24
        '
        'txtPlayer10
        '
        Me.txtPlayer10.Location = New System.Drawing.Point(99, 229)
        Me.txtPlayer10.Name = "txtPlayer10"
        Me.txtPlayer10.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer10.TabIndex = 23
        '
        'txtPlayer9
        '
        Me.txtPlayer9.Location = New System.Drawing.Point(99, 207)
        Me.txtPlayer9.Name = "txtPlayer9"
        Me.txtPlayer9.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer9.TabIndex = 22
        '
        'txtPlayer8
        '
        Me.txtPlayer8.Location = New System.Drawing.Point(99, 185)
        Me.txtPlayer8.Name = "txtPlayer8"
        Me.txtPlayer8.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer8.TabIndex = 21
        '
        'txtPlayer7
        '
        Me.txtPlayer7.Location = New System.Drawing.Point(99, 163)
        Me.txtPlayer7.Name = "txtPlayer7"
        Me.txtPlayer7.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer7.TabIndex = 20
        '
        'txtPlayer6
        '
        Me.txtPlayer6.Location = New System.Drawing.Point(99, 141)
        Me.txtPlayer6.Name = "txtPlayer6"
        Me.txtPlayer6.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer6.TabIndex = 19
        '
        'txtPlayer5
        '
        Me.txtPlayer5.Location = New System.Drawing.Point(99, 119)
        Me.txtPlayer5.Name = "txtPlayer5"
        Me.txtPlayer5.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer5.TabIndex = 18
        '
        'txtPlayer4
        '
        Me.txtPlayer4.Location = New System.Drawing.Point(99, 97)
        Me.txtPlayer4.Name = "txtPlayer4"
        Me.txtPlayer4.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer4.TabIndex = 17
        '
        'txtPlayer3
        '
        Me.txtPlayer3.Location = New System.Drawing.Point(99, 75)
        Me.txtPlayer3.Name = "txtPlayer3"
        Me.txtPlayer3.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer3.TabIndex = 16
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(99, 53)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer2.TabIndex = 15
        '
        'txtScore10
        '
        Me.txtScore10.Location = New System.Drawing.Point(15, 229)
        Me.txtScore10.Name = "txtScore10"
        Me.txtScore10.Size = New System.Drawing.Size(82, 20)
        Me.txtScore10.TabIndex = 14
        '
        'txtScore9
        '
        Me.txtScore9.Location = New System.Drawing.Point(15, 207)
        Me.txtScore9.Name = "txtScore9"
        Me.txtScore9.Size = New System.Drawing.Size(82, 20)
        Me.txtScore9.TabIndex = 13
        '
        'txtScore8
        '
        Me.txtScore8.Location = New System.Drawing.Point(15, 185)
        Me.txtScore8.Name = "txtScore8"
        Me.txtScore8.Size = New System.Drawing.Size(82, 20)
        Me.txtScore8.TabIndex = 12
        '
        'txtScore7
        '
        Me.txtScore7.Location = New System.Drawing.Point(15, 163)
        Me.txtScore7.Name = "txtScore7"
        Me.txtScore7.Size = New System.Drawing.Size(82, 20)
        Me.txtScore7.TabIndex = 11
        '
        'txtScore6
        '
        Me.txtScore6.Location = New System.Drawing.Point(15, 141)
        Me.txtScore6.Name = "txtScore6"
        Me.txtScore6.Size = New System.Drawing.Size(82, 20)
        Me.txtScore6.TabIndex = 10
        '
        'txtScore5
        '
        Me.txtScore5.Location = New System.Drawing.Point(15, 119)
        Me.txtScore5.Name = "txtScore5"
        Me.txtScore5.Size = New System.Drawing.Size(82, 20)
        Me.txtScore5.TabIndex = 9
        '
        'txtScore4
        '
        Me.txtScore4.Location = New System.Drawing.Point(15, 97)
        Me.txtScore4.Name = "txtScore4"
        Me.txtScore4.Size = New System.Drawing.Size(82, 20)
        Me.txtScore4.TabIndex = 8
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(15, 75)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(82, 20)
        Me.txtScore3.TabIndex = 7
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(15, 53)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(82, 20)
        Me.txtScore2.TabIndex = 6
        '
        'txtDate1
        '
        Me.txtDate1.Location = New System.Drawing.Point(264, 31)
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.Size = New System.Drawing.Size(60, 20)
        Me.txtDate1.TabIndex = 5
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(99, 31)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(163, 20)
        Me.txtPlayer1.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(261, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(100, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Game"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Score"
        '
        'txtScore1
        '
        Me.txtScore1.Location = New System.Drawing.Point(15, 31)
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.Size = New System.Drawing.Size(82, 20)
        Me.txtScore1.TabIndex = 0
        '
        'tabDirectoryPaths
        '
        Me.tabDirectoryPaths.Controls.Add(Me.GroupBox2)
        Me.tabDirectoryPaths.Controls.Add(Me.txtRootROMPath)
        Me.tabDirectoryPaths.Controls.Add(Me.GroupBox1)
        Me.tabDirectoryPaths.Location = New System.Drawing.Point(4, 22)
        Me.tabDirectoryPaths.Name = "tabDirectoryPaths"
        Me.tabDirectoryPaths.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDirectoryPaths.Size = New System.Drawing.Size(372, 633)
        Me.tabDirectoryPaths.TabIndex = 1
        Me.tabDirectoryPaths.Text = "Directory Paths"
        Me.tabDirectoryPaths.UseVisualStyleBackColor = True
        '
        'ContextBoxArt
        '
        Me.ContextBoxArt.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextBoxArt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateBoxArtToolStripMenuItem})
        Me.ContextBoxArt.Name = "ContextBoxArt"
        Me.ContextBoxArt.Size = New System.Drawing.Size(155, 26)
        '
        'UpdateBoxArtToolStripMenuItem
        '
        Me.UpdateBoxArtToolStripMenuItem.Name = "UpdateBoxArtToolStripMenuItem"
        Me.UpdateBoxArtToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.UpdateBoxArtToolStripMenuItem.Text = "Update Box Art"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(1358, 725)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TabEditor)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControlRoms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maximus78"
        Me.TabControlRoms.ResumeLayout(False)
        Me.tabNTSC.ResumeLayout(False)
        Me.contextNTSC.ResumeLayout(False)
        Me.tabPAL.ResumeLayout(False)
        Me.tabHomebrews.ResumeLayout(False)
        Me.tabHacks.ResumeLayout(False)
        Me.tabDemos.ResumeLayout(False)
        Me.tabProtos.ResumeLayout(False)
        Me.tabUtilities.ResumeLayout(False)
        Me.tabFavorites.ResumeLayout(False)
        Me.contextFavorites.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabEditor.ResumeLayout(False)
        Me.tabManuals.ResumeLayout(False)
        Me.tabHTMLEditor.ResumeLayout(False)
        Me.tabHTMLEditor.PerformLayout()
        Me.tabScreenshots.ResumeLayout(False)
        CType(Me.Screenshot6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Screenshot5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Screenshot4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Screenshot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Screenshot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Screenshot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBoxArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabBoxArt.ResumeLayout(False)
        Me.tabBoxArt.PerformLayout()
        Me.tabHighScores.ResumeLayout(False)
        Me.tabHighScores.PerformLayout()
        Me.tabDirectoryPaths.ResumeLayout(False)
        Me.tabDirectoryPaths.PerformLayout()
        Me.ContextBoxArt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtA7800path As TextBox
    Friend WithEvents txtRomPath As TextBox
    Friend WithEvents txtBoxArtPath As TextBox
    Friend WithEvents txtManualsPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents TabControlRoms As TabControl
    Friend WithEvents tabNTSC As TabPage
    Friend WithEvents tabPAL As TabPage
    Friend WithEvents tabHomebrews As TabPage
    Friend WithEvents tabHacks As TabPage
    Friend WithEvents tabDemos As TabPage
    Friend WithEvents tabProtos As TabPage
    Friend WithEvents tabUtilities As TabPage
    Friend WithEvents lstNTSCRetail As ListBox
    Friend WithEvents lstPALRetail As ListBox
    Friend WithEvents lstHomebrews As ListBox
    Friend WithEvents lstHacks As ListBox
    Friend WithEvents lstDemos As ListBox
    Friend WithEvents lstProtos As ListBox
    Friend WithEvents lstUtilities As ListBox
    Friend WithEvents txtUtilitiesPath As TextBox
    Friend WithEvents txtProtosPath As TextBox
    Friend WithEvents txtDemosPath As TextBox
    Friend WithEvents txtHacksPath As TextBox
    Friend WithEvents txtHomebrewPath As TextBox
    Friend WithEvents txtPALRetailPath As TextBox
    Friend WithEvents txtNTSCRetailPath As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRootROMPath As TextBox
    Friend WithEvents btnSaveROMPaths As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents statusTVType As ToolStripTextBox
    Friend WithEvents statusPalette As ToolStripTextBox
    Friend WithEvents statusXMhw As ToolStripTextBox
    Friend WithEvents statusHSC As ToolStripTextBox
    Public WithEvents statusDebug As ToolStripTextBox
    Friend WithEvents statusXM As ToolStripTextBox
    Friend WithEvents statusVideo As ToolStripTextBox
    Friend WithEvents BToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuLoadGame As ToolStripMenuItem
    Friend WithEvents StartSelectedGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents SetGameROMPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetGameBoxArtPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetManualsScreenshotPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetA7800EmulatorPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents SetTVTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NTSCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents videoCompatibility As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents videoBasic As ToolStripMenuItem
    Friend WithEvents videoCRT As ToolStripMenuItem
    Friend WithEvents videoCRTDeluxe As ToolStripMenuItem
    Friend WithEvents videoSuperEagle As ToolStripMenuItem
    Friend WithEvents videoHLSL As ToolStripMenuItem
    Friend WithEvents videoHQ2x As ToolStripMenuItem
    Friend WithEvents videoHQ4x As ToolStripMenuItem
    Friend WithEvents SetPaletteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents paletteWARM As ToolStripMenuItem
    Friend WithEvents paletteCOOL As ToolStripMenuItem
    Friend WithEvents paletteHOT As ToolStripMenuItem
    Friend WithEvents setStretchMenuItem3 As ToolStripMenuItem
    Friend WithEvents stretchON As ToolStripMenuItem
    Friend WithEvents stretchOFF As ToolStripMenuItem
    Friend WithEvents menuWindowMode As ToolStripMenuItem
    Friend WithEvents fullscreenOFF As ToolStripMenuItem
    Friend WithEvents fullScreenON As ToolStripMenuItem
    Friend WithEvents setVSYNCMenuItem3 As ToolStripMenuItem
    Friend WithEvents vsyncON As ToolStripMenuItem
    Friend WithEvents vsyncOFF As ToolStripMenuItem
    Friend WithEvents setTripleBufferMenuItem3 As ToolStripMenuItem
    Friend WithEvents triplebufferON As ToolStripMenuItem
    Friend WithEvents triplebufferOFF As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents SetXMSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents xmON As ToolStripMenuItem
    Friend WithEvents xmOFF As ToolStripMenuItem
    Friend WithEvents SetHSCSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents hscON As ToolStripMenuItem
    Friend WithEvents hscOFF As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox6 As ToolStripTextBox
    Friend WithEvents setDeveloperMenuItem1 As ToolStripMenuItem
    Friend WithEvents devON As ToolStripMenuItem
    Friend WithEvents devOFF As ToolStripMenuItem
    Friend WithEvents SetDebugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents debugON As ToolStripMenuItem
    Friend WithEvents debugOFF As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox10 As ToolStripTextBox
    Friend WithEvents EditA7800ConfigurationFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnuStatus As ToolStripMenuItem
    Friend WithEvents statusON As ToolStripMenuItem
    Friend WithEvents statusOFF As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents displayFULL As ToolStripMenuItem
    Friend WithEvents displayMED As ToolStripMenuItem
    Friend WithEvents displaySMALL As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stripTVType As ToolStripStatusLabel
    Friend WithEvents stripVideo As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents stripPalette As ToolStripStatusLabel
    Friend WithEvents stripStretch As ToolStripStatusLabel
    Friend WithEvents stripWindow As ToolStripStatusLabel
    Friend WithEvents stripVsync As ToolStripStatusLabel
    Friend WithEvents stripTripleBuffer As ToolStripStatusLabel
    Friend WithEvents stripXM As ToolStripStatusLabel
    Friend WithEvents stripHSC As ToolStripStatusLabel
    Friend WithEvents stripDev As ToolStripStatusLabel
    Friend WithEvents stripDebug As ToolStripStatusLabel
    Friend WithEvents TabEditor As TabControl
    Friend WithEvents tabManuals As TabPage
    Friend WithEvents tabHTMLEditor As TabPage
    Friend WithEvents txtHTMLEditor As TextBox
    Friend WithEvents btnSaveHTML As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents txtEditorFile As TextBox
    Friend WithEvents pctBoxArt As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabBoxArt As TabPage
    Friend WithEvents tabDirectoryPaths As TabPage
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ResetAllOptionsToDefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tabFavorites As TabPage
    Friend WithEvents lstFavorites As ListBox
    Friend WithEvents mnuAddFavorite As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuRemoveFavorite As ToolStripMenuItem
    Friend WithEvents contextNTSC As ContextMenuStrip
    Friend WithEvents contextNTSCRetail As ToolStripMenuItem
    Friend WithEvents tabScreenshots As TabPage
    Friend WithEvents Screenshot2 As PictureBox
    Friend WithEvents Screenshot1 As PictureBox
    Friend WithEvents Screenshot6 As PictureBox
    Friend WithEvents Screenshot5 As PictureBox
    Friend WithEvents Screenshot4 As PictureBox
    Friend WithEvents Screenshot3 As PictureBox
    Friend WithEvents contextFavorites As ContextMenuStrip
    Friend WithEvents RemoveFromFavoritesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnUnload1 As Button
    Friend WithEvents btnLoad1 As Button
    Friend WithEvents btnSave1 As Button
    Friend WithEvents btnSave2 As Button
    Friend WithEvents btnLoad2 As Button
    Friend WithEvents btnUnload2 As Button
    Friend WithEvents btnSave6 As Button
    Friend WithEvents btnLoad6 As Button
    Friend WithEvents btnUnload6 As Button
    Friend WithEvents btnSave5 As Button
    Friend WithEvents btnLoad5 As Button
    Friend WithEvents btnUnload5 As Button
    Friend WithEvents btnSave4 As Button
    Friend WithEvents btnLoad4 As Button
    Friend WithEvents btnUnload4 As Button
    Friend WithEvents btnSave3 As Button
    Friend WithEvents btnLoad3 As Button
    Friend WithEvents btnUnload3 As Button
    Friend WithEvents tabHighScores As TabPage
    Friend WithEvents AddScreenshotsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents addImage1 As ToolStripMenuItem
    Friend WithEvents addImage2 As ToolStripMenuItem
    Friend WithEvents addImage3 As ToolStripMenuItem
    Friend WithEvents addImage4 As ToolStripMenuItem
    Friend WithEvents addImage5 As ToolStripMenuItem
    Friend WithEvents addImage6 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ClearAllFavoritesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents txtDate10 As TextBox
    Friend WithEvents txtDate9 As TextBox
    Friend WithEvents txtDate8 As TextBox
    Friend WithEvents txtDate7 As TextBox
    Friend WithEvents txtDate6 As TextBox
    Friend WithEvents txtDate5 As TextBox
    Friend WithEvents txtDate4 As TextBox
    Friend WithEvents txtDate3 As TextBox
    Friend WithEvents txtDate2 As TextBox
    Friend WithEvents txtPlayer10 As TextBox
    Friend WithEvents txtPlayer9 As TextBox
    Friend WithEvents txtPlayer8 As TextBox
    Friend WithEvents txtPlayer7 As TextBox
    Friend WithEvents txtPlayer6 As TextBox
    Friend WithEvents txtPlayer5 As TextBox
    Friend WithEvents txtPlayer4 As TextBox
    Friend WithEvents txtPlayer3 As TextBox
    Friend WithEvents txtPlayer2 As TextBox
    Friend WithEvents txtScore10 As TextBox
    Friend WithEvents txtScore9 As TextBox
    Friend WithEvents txtScore8 As TextBox
    Friend WithEvents txtScore7 As TextBox
    Friend WithEvents txtScore6 As TextBox
    Friend WithEvents txtScore5 As TextBox
    Friend WithEvents txtScore4 As TextBox
    Friend WithEvents txtScore3 As TextBox
    Friend WithEvents txtScore2 As TextBox
    Friend WithEvents txtDate1 As TextBox
    Friend WithEvents txtPlayer1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtScore1 As TextBox
    Friend WithEvents txtInitials20 As TextBox
    Friend WithEvents txtInitials19 As TextBox
    Friend WithEvents txtInitials18 As TextBox
    Friend WithEvents txtInitials17 As TextBox
    Friend WithEvents txtInitials16 As TextBox
    Friend WithEvents txtInitials15 As TextBox
    Friend WithEvents txtInitials14 As TextBox
    Friend WithEvents txtInitials13 As TextBox
    Friend WithEvents txtInitials12 As TextBox
    Friend WithEvents txtInitials11 As TextBox
    Friend WithEvents txtInitials10 As TextBox
    Friend WithEvents txtInitials9 As TextBox
    Friend WithEvents txtInitials8 As TextBox
    Friend WithEvents txtInitials7 As TextBox
    Friend WithEvents txtInitials6 As TextBox
    Friend WithEvents txtInitials5 As TextBox
    Friend WithEvents txtInitials4 As TextBox
    Friend WithEvents txtInitials3 As TextBox
    Friend WithEvents txtInitials2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtInitials1 As TextBox
    Friend WithEvents txtDate20 As TextBox
    Friend WithEvents txtDate19 As TextBox
    Friend WithEvents txtDate18 As TextBox
    Friend WithEvents txtDate17 As TextBox
    Friend WithEvents txtDate16 As TextBox
    Friend WithEvents txtDate15 As TextBox
    Friend WithEvents txtDate14 As TextBox
    Friend WithEvents txtDate13 As TextBox
    Friend WithEvents txtDate12 As TextBox
    Friend WithEvents txtPlayer20 As TextBox
    Friend WithEvents txtPlayer19 As TextBox
    Friend WithEvents txtPlayer18 As TextBox
    Friend WithEvents txtPlayer17 As TextBox
    Friend WithEvents txtPlayer16 As TextBox
    Friend WithEvents txtPlayer15 As TextBox
    Friend WithEvents txtPlayer14 As TextBox
    Friend WithEvents txtPlayer13 As TextBox
    Friend WithEvents txtPlayer12 As TextBox
    Friend WithEvents txtScore20 As TextBox
    Friend WithEvents txtScore19 As TextBox
    Friend WithEvents txtScore18 As TextBox
    Friend WithEvents txtScore17 As TextBox
    Friend WithEvents txtScore16 As TextBox
    Friend WithEvents txtScore15 As TextBox
    Friend WithEvents txtScore14 As TextBox
    Friend WithEvents txtScore13 As TextBox
    Friend WithEvents txtScore12 As TextBox
    Friend WithEvents txtDate11 As TextBox
    Friend WithEvents txtPlayer11 As TextBox
    Friend WithEvents txtScore11 As TextBox
    Friend WithEvents txtScore23 As TextBox
    Friend WithEvents txtScore22 As TextBox
    Friend WithEvents txtScore21 As TextBox
    Friend WithEvents txtInitials27 As TextBox
    Friend WithEvents txtInitials26 As TextBox
    Friend WithEvents txtInitials25 As TextBox
    Friend WithEvents txtInitials24 As TextBox
    Friend WithEvents txtInitials23 As TextBox
    Friend WithEvents txtInitials22 As TextBox
    Friend WithEvents txtInitials21 As TextBox
    Friend WithEvents txtDate27 As TextBox
    Friend WithEvents txtDate26 As TextBox
    Friend WithEvents txtDate25 As TextBox
    Friend WithEvents txtDate24 As TextBox
    Friend WithEvents txtDate23 As TextBox
    Friend WithEvents txtDate22 As TextBox
    Friend WithEvents txtDate21 As TextBox
    Friend WithEvents txtPlayer27 As TextBox
    Friend WithEvents txtPlayer26 As TextBox
    Friend WithEvents txtPlayer25 As TextBox
    Friend WithEvents txtPlayer24 As TextBox
    Friend WithEvents txtPlayer23 As TextBox
    Friend WithEvents txtPlayer22 As TextBox
    Friend WithEvents txtPlayer21 As TextBox
    Friend WithEvents txtScore27 As TextBox
    Friend WithEvents txtScore26 As TextBox
    Friend WithEvents txtScore25 As TextBox
    Friend WithEvents txtScore24 As TextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ResetAllHighScoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextBoxArt As ContextMenuStrip
    Friend WithEvents UpdateBoxArtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents A7800EmulatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeyboardMappingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TVAndVideoTipsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Atari7800ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonDefinitionsForGamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DifficultySwitchOptionsForGamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Atari7800ProSystemOwnersManualToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UsersGuideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents RecentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents usersguideToolStripMenuItem3 As ToolStripMenuItem
End Class
