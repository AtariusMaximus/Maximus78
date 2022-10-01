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

    'Dim aPath As String = Application.StartupPath()
    'Dim strFolder As String = My.Computer.Registry.CurrentUser.GetValue("Maximus78 ROM Path")
    'Dim strA7800Folder As String = My.Computer.Registry.CurrentUser.GetValue("Maximus78 A7800 Path")

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
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
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.A7800UsersGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.pctBoxArt = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBoxArt = New System.Windows.Forms.TabPage()
        Me.tabDirectoryPaths = New System.Windows.Forms.TabPage()
        Me.TabControlRoms.SuspendLayout()
        Me.tabNTSC.SuspendLayout()
        Me.tabPAL.SuspendLayout()
        Me.tabHomebrews.SuspendLayout()
        Me.tabHacks.SuspendLayout()
        Me.tabDemos.SuspendLayout()
        Me.tabProtos.SuspendLayout()
        Me.tabUtilities.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabEditor.SuspendLayout()
        Me.tabManuals.SuspendLayout()
        Me.tabHTMLEditor.SuspendLayout()
        CType(Me.pctBoxArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabBoxArt.SuspendLayout()
        Me.tabDirectoryPaths.SuspendLayout()
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
        Me.TabControlRoms.Location = New System.Drawing.Point(12, 24)
        Me.TabControlRoms.Name = "TabControlRoms"
        Me.TabControlRoms.SelectedIndex = 0
        Me.TabControlRoms.Size = New System.Drawing.Size(441, 663)
        Me.TabControlRoms.TabIndex = 54
        '
        'tabNTSC
        '
        Me.tabNTSC.Controls.Add(Me.lstNTSCRetail)
        Me.tabNTSC.Location = New System.Drawing.Point(4, 22)
        Me.tabNTSC.Name = "tabNTSC"
        Me.tabNTSC.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNTSC.Size = New System.Drawing.Size(433, 637)
        Me.tabNTSC.TabIndex = 0
        Me.tabNTSC.Text = "NTSC Retail"
        Me.tabNTSC.UseVisualStyleBackColor = True
        '
        'lstNTSCRetail
        '
        Me.lstNTSCRetail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstNTSCRetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstNTSCRetail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNTSCRetail.FormattingEnabled = True
        Me.lstNTSCRetail.ItemHeight = 14
        Me.lstNTSCRetail.Location = New System.Drawing.Point(3, 3)
        Me.lstNTSCRetail.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstNTSCRetail.Name = "lstNTSCRetail"
        Me.lstNTSCRetail.Size = New System.Drawing.Size(427, 632)
        Me.lstNTSCRetail.TabIndex = 29
        '
        'tabPAL
        '
        Me.tabPAL.Controls.Add(Me.lstPALRetail)
        Me.tabPAL.Location = New System.Drawing.Point(4, 22)
        Me.tabPAL.Name = "tabPAL"
        Me.tabPAL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPAL.Size = New System.Drawing.Size(433, 637)
        Me.tabPAL.TabIndex = 1
        Me.tabPAL.Text = "PAL Retail"
        Me.tabPAL.UseVisualStyleBackColor = True
        '
        'lstPALRetail
        '
        Me.lstPALRetail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstPALRetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstPALRetail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPALRetail.FormattingEnabled = True
        Me.lstPALRetail.ItemHeight = 14
        Me.lstPALRetail.Location = New System.Drawing.Point(3, 2)
        Me.lstPALRetail.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstPALRetail.Name = "lstPALRetail"
        Me.lstPALRetail.Size = New System.Drawing.Size(427, 632)
        Me.lstPALRetail.TabIndex = 30
        '
        'tabHomebrews
        '
        Me.tabHomebrews.Controls.Add(Me.lstHomebrews)
        Me.tabHomebrews.Location = New System.Drawing.Point(4, 22)
        Me.tabHomebrews.Name = "tabHomebrews"
        Me.tabHomebrews.Size = New System.Drawing.Size(433, 637)
        Me.tabHomebrews.TabIndex = 2
        Me.tabHomebrews.Text = "Homebew"
        Me.tabHomebrews.UseVisualStyleBackColor = True
        '
        'lstHomebrews
        '
        Me.lstHomebrews.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstHomebrews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstHomebrews.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHomebrews.FormattingEnabled = True
        Me.lstHomebrews.ItemHeight = 14
        Me.lstHomebrews.Location = New System.Drawing.Point(3, 2)
        Me.lstHomebrews.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstHomebrews.Name = "lstHomebrews"
        Me.lstHomebrews.Size = New System.Drawing.Size(427, 632)
        Me.lstHomebrews.TabIndex = 31
        '
        'tabHacks
        '
        Me.tabHacks.Controls.Add(Me.lstHacks)
        Me.tabHacks.Location = New System.Drawing.Point(4, 22)
        Me.tabHacks.Name = "tabHacks"
        Me.tabHacks.Size = New System.Drawing.Size(433, 637)
        Me.tabHacks.TabIndex = 3
        Me.tabHacks.Text = "Hacks"
        Me.tabHacks.UseVisualStyleBackColor = True
        '
        'lstHacks
        '
        Me.lstHacks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstHacks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstHacks.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHacks.FormattingEnabled = True
        Me.lstHacks.ItemHeight = 14
        Me.lstHacks.Location = New System.Drawing.Point(3, 2)
        Me.lstHacks.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstHacks.Name = "lstHacks"
        Me.lstHacks.Size = New System.Drawing.Size(427, 632)
        Me.lstHacks.TabIndex = 32
        '
        'tabDemos
        '
        Me.tabDemos.Controls.Add(Me.lstDemos)
        Me.tabDemos.Location = New System.Drawing.Point(4, 22)
        Me.tabDemos.Name = "tabDemos"
        Me.tabDemos.Size = New System.Drawing.Size(433, 637)
        Me.tabDemos.TabIndex = 4
        Me.tabDemos.Text = "Demos"
        Me.tabDemos.UseVisualStyleBackColor = True
        '
        'lstDemos
        '
        Me.lstDemos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstDemos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstDemos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDemos.FormattingEnabled = True
        Me.lstDemos.ItemHeight = 14
        Me.lstDemos.Location = New System.Drawing.Point(3, 2)
        Me.lstDemos.Name = "lstDemos"
        Me.lstDemos.Size = New System.Drawing.Size(427, 632)
        Me.lstDemos.TabIndex = 32
        '
        'tabProtos
        '
        Me.tabProtos.Controls.Add(Me.lstProtos)
        Me.tabProtos.Location = New System.Drawing.Point(4, 22)
        Me.tabProtos.Name = "tabProtos"
        Me.tabProtos.Size = New System.Drawing.Size(433, 637)
        Me.tabProtos.TabIndex = 5
        Me.tabProtos.Text = "Protos"
        Me.tabProtos.UseVisualStyleBackColor = True
        '
        'lstProtos
        '
        Me.lstProtos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstProtos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstProtos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProtos.FormattingEnabled = True
        Me.lstProtos.ItemHeight = 14
        Me.lstProtos.Location = New System.Drawing.Point(3, 2)
        Me.lstProtos.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstProtos.Name = "lstProtos"
        Me.lstProtos.Size = New System.Drawing.Size(427, 632)
        Me.lstProtos.TabIndex = 33
        '
        'tabUtilities
        '
        Me.tabUtilities.Controls.Add(Me.lstUtilities)
        Me.tabUtilities.Location = New System.Drawing.Point(4, 22)
        Me.tabUtilities.Name = "tabUtilities"
        Me.tabUtilities.Size = New System.Drawing.Size(433, 637)
        Me.tabUtilities.TabIndex = 6
        Me.tabUtilities.Text = "Utilities"
        Me.tabUtilities.UseVisualStyleBackColor = True
        '
        'lstUtilities
        '
        Me.lstUtilities.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstUtilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstUtilities.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUtilities.FormattingEnabled = True
        Me.lstUtilities.ItemHeight = 14
        Me.lstUtilities.Location = New System.Drawing.Point(3, 2)
        Me.lstUtilities.MaximumSize = New System.Drawing.Size(427, 632)
        Me.lstUtilities.Name = "lstUtilities"
        Me.lstUtilities.Size = New System.Drawing.Size(427, 632)
        Me.lstUtilities.TabIndex = 33
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
        Me.statusTVType.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.statusPalette.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.statusXMhw.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.statusHSC.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.statusDebug.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.statusXM.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.statusVideo.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1358, 25)
        Me.MenuStrip1.TabIndex = 56
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLoadGame, Me.StartSelectedGameToolStripMenuItem, Me.ToolStripSeparator7, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuLoadGame
        '
        Me.mnuLoadGame.Name = "mnuLoadGame"
        Me.mnuLoadGame.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuLoadGame.Size = New System.Drawing.Size(233, 22)
        Me.mnuLoadGame.Text = "Launch External ROM"
        '
        'StartSelectedGameToolStripMenuItem
        '
        Me.StartSelectedGameToolStripMenuItem.Name = "StartSelectedGameToolStripMenuItem"
        Me.StartSelectedGameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.StartSelectedGameToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.StartSelectedGameToolStripMenuItem.Text = "Launch ROM from List"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(230, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(233, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.SetGameROMPathToolStripMenuItem, Me.SetGameBoxArtPathToolStripMenuItem, Me.SetManualsScreenshotPathToolStripMenuItem, Me.SetA7800EmulatorPathToolStripMenuItem, Me.ToolStripSeparator9, Me.ToolStripTextBox2, Me.SetTVTypeToolStripMenuItem, Me.ToolStripMenuItem2, Me.SetPaletteToolStripMenuItem, Me.setStretchMenuItem3, Me.menuWindowMode, Me.setVSYNCMenuItem3, Me.setTripleBufferMenuItem3, Me.ToolStripSeparator11, Me.ToolStripTextBox3, Me.SetXMSupportToolStripMenuItem, Me.SetHSCSupportToolStripMenuItem, Me.ToolStripSeparator12, Me.ToolStripTextBox6, Me.setDeveloperMenuItem1, Me.SetDebugToolStripMenuItem, Me.ToolStripSeparator13, Me.ToolStripTextBox10, Me.EditA7800ConfigurationFileToolStripMenuItem, Me.ToolStripSeparator1, Me.ResetAllOptionsToDefaultToolStripMenuItem})
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(40, 21)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox1.Enabled = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.ReadOnly = True
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(252, 16)
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
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.ReadOnly = True
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(252, 16)
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
        Me.NTSCToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NTSCToolStripMenuItem.Text = "NTSC"
        '
        'PALToolStripMenuItem
        '
        Me.PALToolStripMenuItem.Name = "PALToolStripMenuItem"
        Me.PALToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PALToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
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
        Me.videoCompatibility.Size = New System.Drawing.Size(237, 22)
        Me.videoCompatibility.Text = "Direct 3D Compatibility Mode"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(234, 6)
        '
        'videoBasic
        '
        Me.videoBasic.Checked = True
        Me.videoBasic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.videoBasic.Name = "videoBasic"
        Me.videoBasic.Size = New System.Drawing.Size(237, 22)
        Me.videoBasic.Text = "Basic"
        '
        'videoCRT
        '
        Me.videoCRT.Name = "videoCRT"
        Me.videoCRT.Size = New System.Drawing.Size(237, 22)
        Me.videoCRT.Text = "CRT"
        '
        'videoCRTDeluxe
        '
        Me.videoCRTDeluxe.Name = "videoCRTDeluxe"
        Me.videoCRTDeluxe.Size = New System.Drawing.Size(237, 22)
        Me.videoCRTDeluxe.Text = "CRT Deluxe"
        '
        'videoSuperEagle
        '
        Me.videoSuperEagle.Name = "videoSuperEagle"
        Me.videoSuperEagle.Size = New System.Drawing.Size(237, 22)
        Me.videoSuperEagle.Text = "Super Eagle"
        '
        'videoHLSL
        '
        Me.videoHLSL.Name = "videoHLSL"
        Me.videoHLSL.Size = New System.Drawing.Size(237, 22)
        Me.videoHLSL.Text = "HLSL"
        '
        'videoHQ2x
        '
        Me.videoHQ2x.Name = "videoHQ2x"
        Me.videoHQ2x.Size = New System.Drawing.Size(237, 22)
        Me.videoHQ2x.Text = "HQ2x"
        '
        'videoHQ4x
        '
        Me.videoHQ4x.Name = "videoHQ4x"
        Me.videoHQ4x.Size = New System.Drawing.Size(237, 22)
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
        Me.paletteWARM.Size = New System.Drawing.Size(192, 22)
        Me.paletteWARM.Text = "Warm Palette"
        '
        'paletteCOOL
        '
        Me.paletteCOOL.Name = "paletteCOOL"
        Me.paletteCOOL.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F6), System.Windows.Forms.Keys)
        Me.paletteCOOL.Size = New System.Drawing.Size(192, 22)
        Me.paletteCOOL.Text = "Cool Palette"
        '
        'paletteHOT
        '
        Me.paletteHOT.Name = "paletteHOT"
        Me.paletteHOT.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F7), System.Windows.Forms.Keys)
        Me.paletteHOT.Size = New System.Drawing.Size(192, 22)
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
        Me.stretchON.Size = New System.Drawing.Size(91, 22)
        Me.stretchON.Text = "On"
        '
        'stretchOFF
        '
        Me.stretchOFF.Checked = True
        Me.stretchOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.stretchOFF.Name = "stretchOFF"
        Me.stretchOFF.Size = New System.Drawing.Size(91, 22)
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
        Me.fullscreenOFF.Size = New System.Drawing.Size(133, 22)
        Me.fullscreenOFF.Text = "Windowed"
        '
        'fullScreenON
        '
        Me.fullScreenON.Name = "fullScreenON"
        Me.fullScreenON.Size = New System.Drawing.Size(133, 22)
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
        Me.vsyncON.Size = New System.Drawing.Size(91, 22)
        Me.vsyncON.Text = "On"
        '
        'vsyncOFF
        '
        Me.vsyncOFF.Checked = True
        Me.vsyncOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.vsyncOFF.Name = "vsyncOFF"
        Me.vsyncOFF.Size = New System.Drawing.Size(91, 22)
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
        Me.triplebufferON.Size = New System.Drawing.Size(91, 22)
        Me.triplebufferON.Text = "On"
        '
        'triplebufferOFF
        '
        Me.triplebufferOFF.Checked = True
        Me.triplebufferOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.triplebufferOFF.Name = "triplebufferOFF"
        Me.triplebufferOFF.Size = New System.Drawing.Size(91, 22)
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
        Me.ToolStripTextBox3.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.ReadOnly = True
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(252, 16)
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
        Me.xmON.Size = New System.Drawing.Size(91, 22)
        Me.xmON.Text = "On"
        '
        'xmOFF
        '
        Me.xmOFF.Checked = True
        Me.xmOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.xmOFF.Name = "xmOFF"
        Me.xmOFF.Size = New System.Drawing.Size(91, 22)
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
        Me.hscON.Size = New System.Drawing.Size(91, 22)
        Me.hscON.Text = "On"
        '
        'hscOFF
        '
        Me.hscOFF.Checked = True
        Me.hscOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hscOFF.Name = "hscOFF"
        Me.hscOFF.Size = New System.Drawing.Size(91, 22)
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
        Me.ToolStripTextBox6.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolStripTextBox6.Name = "ToolStripTextBox6"
        Me.ToolStripTextBox6.ReadOnly = True
        Me.ToolStripTextBox6.Size = New System.Drawing.Size(252, 16)
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
        Me.devON.Size = New System.Drawing.Size(91, 22)
        Me.devON.Text = "On"
        '
        'devOFF
        '
        Me.devOFF.Checked = True
        Me.devOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.devOFF.Name = "devOFF"
        Me.devOFF.Size = New System.Drawing.Size(91, 22)
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
        Me.debugON.Size = New System.Drawing.Size(91, 22)
        Me.debugON.Text = "On"
        '
        'debugOFF
        '
        Me.debugOFF.Checked = True
        Me.debugOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.debugOFF.Name = "debugOFF"
        Me.debugOFF.Size = New System.Drawing.Size(91, 22)
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
        Me.ToolStripTextBox10.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox10.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolStripTextBox10.Name = "ToolStripTextBox10"
        Me.ToolStripTextBox10.ReadOnly = True
        Me.ToolStripTextBox10.Size = New System.Drawing.Size(252, 16)
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
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStatus, Me.WindowToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(45, 21)
        Me.ToolStripMenuItem1.Text = "View"
        '
        'mnuStatus
        '
        Me.mnuStatus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusON, Me.statusOFF})
        Me.mnuStatus.Name = "mnuStatus"
        Me.mnuStatus.Size = New System.Drawing.Size(130, 22)
        Me.mnuStatus.Text = "Status Bar"
        '
        'statusON
        '
        Me.statusON.Name = "statusON"
        Me.statusON.Size = New System.Drawing.Size(91, 22)
        Me.statusON.Text = "On"
        '
        'statusOFF
        '
        Me.statusOFF.Checked = True
        Me.statusOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.statusOFF.Name = "statusOFF"
        Me.statusOFF.Size = New System.Drawing.Size(91, 22)
        Me.statusOFF.Text = "Off"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.displayFULL, Me.displayMED, Me.displaySMALL})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'displayFULL
        '
        Me.displayFULL.Checked = True
        Me.displayFULL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.displayFULL.Name = "displayFULL"
        Me.displayFULL.Size = New System.Drawing.Size(273, 22)
        Me.displayFULL.Text = "Full: Display All"
        '
        'displayMED
        '
        Me.displayMED.Name = "displayMED"
        Me.displayMED.Size = New System.Drawing.Size(273, 22)
        Me.displayMED.Text = "Medium: Game List and Box Art Only"
        '
        'displaySMALL
        '
        Me.displaySMALL.Name = "displaySMALL"
        Me.displaySMALL.Size = New System.Drawing.Size(273, 22)
        Me.displaySMALL.Text = "Small: Game List Only"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ToolStripSeparator14, Me.ViewToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(116, 6)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Atari7800ProSystemOwnersManualToolStripMenuItem, Me.A7800UsersGuideToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ViewToolStripMenuItem.Text = "Manuals"
        '
        'Atari7800ProSystemOwnersManualToolStripMenuItem
        '
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem.Name = "Atari7800ProSystemOwnersManualToolStripMenuItem"
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem.Text = "Atari 7800 ProSystem Owner's Manual"
        '
        'A7800UsersGuideToolStripMenuItem
        '
        Me.A7800UsersGuideToolStripMenuItem.Name = "A7800UsersGuideToolStripMenuItem"
        Me.A7800UsersGuideToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
        Me.A7800UsersGuideToolStripMenuItem.Text = "A7800 User's Manual"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.stripPalette, Me.stripTVType, Me.stripVideo, Me.stripStretch, Me.stripWindow, Me.stripVsync, Me.stripTripleBuffer, Me.stripXM, Me.stripHSC, Me.stripDev, Me.stripDebug})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 700)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1358, 25)
        Me.StatusStrip1.TabIndex = 57
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(65, 20)
        Me.ToolStripStatusLabel1.Text = " v0.99.22b  "
        '
        'stripPalette
        '
        Me.stripPalette.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripPalette.Name = "stripPalette"
        Me.stripPalette.Size = New System.Drawing.Size(90, 20)
        Me.stripPalette.Text = "Palette: Warm  "
        '
        'stripTVType
        '
        Me.stripTVType.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripTVType.Name = "stripTVType"
        Me.stripTVType.Size = New System.Drawing.Size(91, 20)
        Me.stripTVType.Text = "TV Type: NTSC  "
        '
        'stripVideo
        '
        Me.stripVideo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripVideo.Name = "stripVideo"
        Me.stripVideo.Size = New System.Drawing.Size(121, 20)
        Me.stripVideo.Text = "Video Output: Basic  "
        '
        'stripStretch
        '
        Me.stripStretch.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripStretch.Name = "stripStretch"
        Me.stripStretch.Size = New System.Drawing.Size(115, 20)
        Me.stripStretch.Text = "Screen Stretch: Off  "
        '
        'stripWindow
        '
        Me.stripWindow.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripWindow.Name = "stripWindow"
        Me.stripWindow.Size = New System.Drawing.Size(158, 20)
        Me.stripWindow.Text = "Window Mode: Windowed  "
        '
        'stripVsync
        '
        Me.stripVsync.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripVsync.Name = "stripVsync"
        Me.stripVsync.Size = New System.Drawing.Size(98, 20)
        Me.stripVsync.Text = "Vsync Wait: Off  "
        '
        'stripTripleBuffer
        '
        Me.stripTripleBuffer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripTripleBuffer.Name = "stripTripleBuffer"
        Me.stripTripleBuffer.Size = New System.Drawing.Size(103, 20)
        Me.stripTripleBuffer.Text = "Triple Buffer: Off  "
        '
        'stripXM
        '
        Me.stripXM.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripXM.Name = "stripXM"
        Me.stripXM.Size = New System.Drawing.Size(103, 20)
        Me.stripXM.Text = "XM Support: Off  "
        '
        'stripHSC
        '
        Me.stripHSC.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripHSC.Name = "stripHSC"
        Me.stripHSC.Size = New System.Drawing.Size(107, 20)
        Me.stripHSC.Text = "HSC Support: Off  "
        '
        'stripDev
        '
        Me.stripDev.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripDev.Name = "stripDev"
        Me.stripDev.Size = New System.Drawing.Size(94, 20)
        Me.stripDev.Text = "Dev Mode: Off  "
        '
        'stripDebug
        '
        Me.stripDebug.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stripDebug.Name = "stripDebug"
        Me.stripDebug.Size = New System.Drawing.Size(109, 20)
        Me.stripDebug.Text = "Debug Mode: Off  "
        '
        'TabEditor
        '
        Me.TabEditor.Controls.Add(Me.tabManuals)
        Me.TabEditor.Controls.Add(Me.tabHTMLEditor)
        Me.TabEditor.Location = New System.Drawing.Point(846, 24)
        Me.TabEditor.Multiline = True
        Me.TabEditor.Name = "TabEditor"
        Me.TabEditor.SelectedIndex = 0
        Me.TabEditor.Size = New System.Drawing.Size(512, 660)
        Me.TabEditor.TabIndex = 58
        '
        'tabManuals
        '
        Me.tabManuals.Controls.Add(Me.WebBrowser1)
        Me.tabManuals.Location = New System.Drawing.Point(4, 22)
        Me.tabManuals.Name = "tabManuals"
        Me.tabManuals.Padding = New System.Windows.Forms.Padding(3)
        Me.tabManuals.Size = New System.Drawing.Size(504, 634)
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
        Me.tabHTMLEditor.Size = New System.Drawing.Size(504, 634)
        Me.tabHTMLEditor.TabIndex = 1
        Me.tabHTMLEditor.Text = "Game Information HTML Editor      "
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
        Me.tabPAL.ResumeLayout(False)
        Me.tabHomebrews.ResumeLayout(False)
        Me.tabHacks.ResumeLayout(False)
        Me.tabDemos.ResumeLayout(False)
        Me.tabProtos.ResumeLayout(False)
        Me.tabUtilities.ResumeLayout(False)
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
        CType(Me.pctBoxArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabBoxArt.ResumeLayout(False)
        Me.tabBoxArt.PerformLayout()
        Me.tabDirectoryPaths.ResumeLayout(False)
        Me.tabDirectoryPaths.PerformLayout()
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
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Atari7800ProSystemOwnersManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents A7800UsersGuideToolStripMenuItem As ToolStripMenuItem
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
End Class
