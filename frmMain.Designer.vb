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
    Dim strA7800Folder As String = ""
    Dim strBoxArtFolder As String = ""
    Dim strManualsFolder As String = ""
    Dim strArguments As String = ""
    Dim strAddArguments As String = ""
    Dim strDebug As String = ""

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
        Me.lstAllGames = New System.Windows.Forms.ListBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.pctBoxArt = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartSelectedGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetGameROMPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetGameBoxArtPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetManualsScreenshotPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetA7800EmulatorPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SetTVTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NTSCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SetXMSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.xmON = New System.Windows.Forms.ToolStripMenuItem()
        Me.xmOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetHSCSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hscON = New System.Windows.Forms.ToolStripMenuItem()
        Me.hscOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetDebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.debugON = New System.Windows.Forms.ToolStripMenuItem()
        Me.debugOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.A7800UsersGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtA7800path = New System.Windows.Forms.TextBox()
        Me.txtRomPath = New System.Windows.Forms.TextBox()
        Me.txtBoxArtPath = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txtManualsPath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditA7800ConfigurationFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pctBoxArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAllGames
        '
        Me.lstAllGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstAllGames.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAllGames.FormattingEnabled = True
        Me.lstAllGames.ItemHeight = 14
        Me.lstAllGames.Location = New System.Drawing.Point(12, 27)
        Me.lstAllGames.Name = "lstAllGames"
        Me.lstAllGames.Size = New System.Drawing.Size(441, 660)
        Me.lstAllGames.TabIndex = 29
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPath.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPath.Location = New System.Drawing.Point(6, 7)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPath.Size = New System.Drawing.Size(374, 99)
        Me.txtPath.TabIndex = 31
        '
        'pctBoxArt
        '
        Me.pctBoxArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctBoxArt.Location = New System.Drawing.Point(459, 28)
        Me.pctBoxArt.Name = "pctBoxArt"
        Me.pctBoxArt.Size = New System.Drawing.Size(394, 515)
        Me.pctBoxArt.TabIndex = 32
        Me.pctBoxArt.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartSelectedGameToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'StartSelectedGameToolStripMenuItem
        '
        Me.StartSelectedGameToolStripMenuItem.Name = "StartSelectedGameToolStripMenuItem"
        Me.StartSelectedGameToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StartSelectedGameToolStripMenuItem.Text = "Start Selected Game"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetGameROMPathToolStripMenuItem, Me.SetGameBoxArtPathToolStripMenuItem, Me.SetManualsScreenshotPathToolStripMenuItem, Me.SetA7800EmulatorPathToolStripMenuItem, Me.ToolStripSeparator3, Me.SetTVTypeToolStripMenuItem, Me.ToolStripSeparator4, Me.SetXMSupportToolStripMenuItem, Me.SetHSCSupportToolStripMenuItem, Me.SetDebugToolStripMenuItem, Me.ToolStripSeparator1, Me.EditA7800ConfigurationFileToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SetGameROMPathToolStripMenuItem
        '
        Me.SetGameROMPathToolStripMenuItem.Name = "SetGameROMPathToolStripMenuItem"
        Me.SetGameROMPathToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SetGameROMPathToolStripMenuItem.Text = "Set Game ROM Path"
        '
        'SetGameBoxArtPathToolStripMenuItem
        '
        Me.SetGameBoxArtPathToolStripMenuItem.Name = "SetGameBoxArtPathToolStripMenuItem"
        Me.SetGameBoxArtPathToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SetGameBoxArtPathToolStripMenuItem.Text = "Set Game Box Art Path"
        '
        'SetManualsScreenshotPathToolStripMenuItem
        '
        Me.SetManualsScreenshotPathToolStripMenuItem.Name = "SetManualsScreenshotPathToolStripMenuItem"
        Me.SetManualsScreenshotPathToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SetManualsScreenshotPathToolStripMenuItem.Text = "Set Manuals and Screenshot Path"
        '
        'SetA7800EmulatorPathToolStripMenuItem
        '
        Me.SetA7800EmulatorPathToolStripMenuItem.Name = "SetA7800EmulatorPathToolStripMenuItem"
        Me.SetA7800EmulatorPathToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SetA7800EmulatorPathToolStripMenuItem.Text = "Set A7800 Emulator Path"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(246, 6)
        '
        'SetTVTypeToolStripMenuItem
        '
        Me.SetTVTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NTSCToolStripMenuItem, Me.PALToolStripMenuItem})
        Me.SetTVTypeToolStripMenuItem.Name = "SetTVTypeToolStripMenuItem"
        Me.SetTVTypeToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SetTVTypeToolStripMenuItem.Text = "Set TV Type"
        '
        'NTSCToolStripMenuItem
        '
        Me.NTSCToolStripMenuItem.Checked = True
        Me.NTSCToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NTSCToolStripMenuItem.Name = "NTSCToolStripMenuItem"
        Me.NTSCToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NTSCToolStripMenuItem.Text = "NTSC"
        '
        'PALToolStripMenuItem
        '
        Me.PALToolStripMenuItem.Name = "PALToolStripMenuItem"
        Me.PALToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PALToolStripMenuItem.Text = "PAL"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(246, 6)
        '
        'SetXMSupportToolStripMenuItem
        '
        Me.SetXMSupportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.xmON, Me.xmOFF})
        Me.SetXMSupportToolStripMenuItem.Name = "SetXMSupportToolStripMenuItem"
        Me.SetXMSupportToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SetXMSupportToolStripMenuItem.Text = "Set XM Support"
        '
        'xmON
        '
        Me.xmON.Name = "xmON"
        Me.xmON.Size = New System.Drawing.Size(180, 22)
        Me.xmON.Text = "On"
        '
        'xmOFF
        '
        Me.xmOFF.Checked = True
        Me.xmOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.xmOFF.Name = "xmOFF"
        Me.xmOFF.Size = New System.Drawing.Size(180, 22)
        Me.xmOFF.Text = "Off"
        '
        'SetHSCSupportToolStripMenuItem
        '
        Me.SetHSCSupportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hscON, Me.hscOFF})
        Me.SetHSCSupportToolStripMenuItem.Name = "SetHSCSupportToolStripMenuItem"
        Me.SetHSCSupportToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SetHSCSupportToolStripMenuItem.Text = "Set HSC Support"
        '
        'hscON
        '
        Me.hscON.Name = "hscON"
        Me.hscON.Size = New System.Drawing.Size(180, 22)
        Me.hscON.Text = "On"
        '
        'hscOFF
        '
        Me.hscOFF.Checked = True
        Me.hscOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.hscOFF.Name = "hscOFF"
        Me.hscOFF.Size = New System.Drawing.Size(180, 22)
        Me.hscOFF.Text = "Off"
        '
        'SetDebugToolStripMenuItem
        '
        Me.SetDebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.debugON, Me.debugOFF})
        Me.SetDebugToolStripMenuItem.Name = "SetDebugToolStripMenuItem"
        Me.SetDebugToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SetDebugToolStripMenuItem.Text = "Set Debug"
        '
        'debugON
        '
        Me.debugON.Name = "debugON"
        Me.debugON.Size = New System.Drawing.Size(180, 22)
        Me.debugON.Text = "On"
        '
        'debugOFF
        '
        Me.debugOFF.Checked = True
        Me.debugOFF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.debugOFF.Name = "debugOFF"
        Me.debugOFF.Size = New System.Drawing.Size(180, 22)
        Me.debugOFF.Text = "Off"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ToolStripSeparator6, Me.ViewToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.AboutToolStripMenuItem.Text = "Version and License Information"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(239, 6)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Atari7800ProSystemOwnersManualToolStripMenuItem, Me.A7800UsersGuideToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ViewToolStripMenuItem.Text = "View Manuals"
        '
        'Atari7800ProSystemOwnersManualToolStripMenuItem
        '
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem.Name = "Atari7800ProSystemOwnersManualToolStripMenuItem"
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.Atari7800ProSystemOwnersManualToolStripMenuItem.Text = "Atari 7800 ProSystem Owner's Manual"
        '
        'A7800UsersGuideToolStripMenuItem
        '
        Me.A7800UsersGuideToolStripMenuItem.Name = "A7800UsersGuideToolStripMenuItem"
        Me.A7800UsersGuideToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.A7800UsersGuideToolStripMenuItem.Text = "A7800 User's Manual"
        '
        'txtA7800path
        '
        Me.txtA7800path.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtA7800path.ForeColor = System.Drawing.SystemColors.Window
        Me.txtA7800path.Location = New System.Drawing.Point(81, 3)
        Me.txtA7800path.Name = "txtA7800path"
        Me.txtA7800path.Size = New System.Drawing.Size(299, 20)
        Me.txtA7800path.TabIndex = 36
        '
        'txtRomPath
        '
        Me.txtRomPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtRomPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtRomPath.Location = New System.Drawing.Point(81, 29)
        Me.txtRomPath.Name = "txtRomPath"
        Me.txtRomPath.Size = New System.Drawing.Size(299, 20)
        Me.txtRomPath.TabIndex = 37
        '
        'txtBoxArtPath
        '
        Me.txtBoxArtPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtBoxArtPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtBoxArtPath.Location = New System.Drawing.Point(81, 55)
        Me.txtBoxArtPath.Name = "txtBoxArtPath"
        Me.txtBoxArtPath.Size = New System.Drawing.Size(299, 20)
        Me.txtBoxArtPath.TabIndex = 38
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(859, 27)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(479, 656)
        Me.WebBrowser1.TabIndex = 40
        Me.WebBrowser1.Url = New System.Uri("c:\a7800\manuals\Blank.htm", System.UriKind.Absolute)
        '
        'txtManualsPath
        '
        Me.txtManualsPath.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtManualsPath.ForeColor = System.Drawing.SystemColors.Window
        Me.txtManualsPath.Location = New System.Drawing.Point(81, 81)
        Me.txtManualsPath.Name = "txtManualsPath"
        Me.txtManualsPath.Size = New System.Drawing.Size(299, 20)
        Me.txtManualsPath.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Manuals Path"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "A7800 Path"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "ROM Path"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Box Art Path"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(459, 548)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(394, 139)
        Me.TabControl1.TabIndex = 53
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtPath)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(386, 113)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "A7800 Command"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtA7800path)
        Me.TabPage2.Controls.Add(Me.txtRomPath)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtBoxArtPath)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtManualsPath)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(386, 113)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Defined Directory Paths"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(246, 6)
        '
        'EditA7800ConfigurationFileToolStripMenuItem
        '
        Me.EditA7800ConfigurationFileToolStripMenuItem.Name = "EditA7800ConfigurationFileToolStripMenuItem"
        Me.EditA7800ConfigurationFileToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.EditA7800ConfigurationFileToolStripMenuItem.Text = "Edit A7800 Configuration File"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 693)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.pctBoxArt)
        Me.Controls.Add(Me.lstAllGames)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maximus78"
        CType(Me.pctBoxArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAllGames As ListBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents pctBoxArt As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtA7800path As TextBox
    Friend WithEvents txtRomPath As TextBox
    Friend WithEvents txtBoxArtPath As TextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents txtManualsPath As TextBox
    Friend WithEvents SetGameROMPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetGameBoxArtPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetManualsScreenshotPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetA7800EmulatorPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartSelectedGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SetTVTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NTSCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SetXMSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents xmON As ToolStripMenuItem
    Friend WithEvents xmOFF As ToolStripMenuItem
    Friend WithEvents SetHSCSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents hscON As ToolStripMenuItem
    Friend WithEvents hscOFF As ToolStripMenuItem
    Friend WithEvents SetDebugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents debugON As ToolStripMenuItem
    Friend WithEvents debugOFF As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Atari7800ProSystemOwnersManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents A7800UsersGuideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EditA7800ConfigurationFileToolStripMenuItem As ToolStripMenuItem
End Class
