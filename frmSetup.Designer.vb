<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetup))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGameROMpath = New System.Windows.Forms.Button()
        Me.btnBoxArtPath = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtRomPath = New System.Windows.Forms.TextBox()
        Me.txtBoxArtPath = New System.Windows.Forms.TextBox()
        Me.txtManualsPath = New System.Windows.Forms.TextBox()
        Me.txtA7800path = New System.Windows.Forms.TextBox()
        Me.frmContinue = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-17, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 246)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnGameROMpath
        '
        Me.btnGameROMpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGameROMpath.Location = New System.Drawing.Point(6, 12)
        Me.btnGameROMpath.Name = "btnGameROMpath"
        Me.btnGameROMpath.Size = New System.Drawing.Size(154, 23)
        Me.btnGameROMpath.TabIndex = 2
        Me.btnGameROMpath.Text = "Path to your Game ROMs"
        Me.btnGameROMpath.UseVisualStyleBackColor = True
        '
        'btnBoxArtPath
        '
        Me.btnBoxArtPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoxArtPath.Location = New System.Drawing.Point(6, 41)
        Me.btnBoxArtPath.Name = "btnBoxArtPath"
        Me.btnBoxArtPath.Size = New System.Drawing.Size(154, 23)
        Me.btnBoxArtPath.TabIndex = 3
        Me.btnBoxArtPath.Text = "Path to your Box Art Folder"
        Me.btnBoxArtPath.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Path to your Manuals Folder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Path to the A7800 Emulator"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtRomPath
        '
        Me.txtRomPath.Location = New System.Drawing.Point(166, 15)
        Me.txtRomPath.Name = "txtRomPath"
        Me.txtRomPath.Size = New System.Drawing.Size(333, 21)
        Me.txtRomPath.TabIndex = 6
        '
        'txtBoxArtPath
        '
        Me.txtBoxArtPath.Location = New System.Drawing.Point(166, 44)
        Me.txtBoxArtPath.Name = "txtBoxArtPath"
        Me.txtBoxArtPath.Size = New System.Drawing.Size(333, 21)
        Me.txtBoxArtPath.TabIndex = 7
        '
        'txtManualsPath
        '
        Me.txtManualsPath.Location = New System.Drawing.Point(166, 73)
        Me.txtManualsPath.Name = "txtManualsPath"
        Me.txtManualsPath.Size = New System.Drawing.Size(333, 21)
        Me.txtManualsPath.TabIndex = 8
        '
        'txtA7800path
        '
        Me.txtA7800path.Location = New System.Drawing.Point(166, 102)
        Me.txtA7800path.Name = "txtA7800path"
        Me.txtA7800path.Size = New System.Drawing.Size(333, 21)
        Me.txtA7800path.TabIndex = 9
        '
        'frmContinue
        '
        Me.frmContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmContinue.Location = New System.Drawing.Point(356, 131)
        Me.frmContinue.Name = "frmContinue"
        Me.frmContinue.Size = New System.Drawing.Size(143, 33)
        Me.frmContinue.TabIndex = 10
        Me.frmContinue.Text = "Continue"
        Me.frmContinue.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(259, 12)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(529, 66)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(247, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(541, 305)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(533, 279)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Step 1: Review Setup Requirements"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(527, 273)
        Me.WebBrowser1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btnGameROMpath)
        Me.TabPage2.Controls.Add(Me.frmContinue)
        Me.TabPage2.Controls.Add(Me.btnBoxArtPath)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.txtA7800path)
        Me.TabPage2.Controls.Add(Me.txtRomPath)
        Me.TabPage2.Controls.Add(Me.txtManualsPath)
        Me.TabPage2.Controls.Add(Me.txtBoxArtPath)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(533, 279)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Step 2: Set Directory Paths"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Please Click Continue after all Directory Paths have been set."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(54, 269)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(141, 70)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(251, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(530, 13)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "It looks like this is the first time you've run Maximus78.  Please Complete the S" &
    "teps Below to get started."
        '
        'frmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(806, 359)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetup"
        Me.Text = "First Time Setup"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGameROMpath As Button
    Friend WithEvents btnBoxArtPath As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtRomPath As TextBox
    Friend WithEvents txtBoxArtPath As TextBox
    Friend WithEvents txtManualsPath As TextBox
    Friend WithEvents txtA7800path As TextBox
    Friend WithEvents frmContinue As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
