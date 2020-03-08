<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.boxHome = New System.Windows.Forms.GroupBox()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buttonHow2Play = New System.Windows.Forms.Button()
        Me.buttonCredits = New System.Windows.Forms.Button()
        Me.buttonAbout = New System.Windows.Forms.Button()
        Me.buttonPlay = New System.Windows.Forms.Button()
        Me.boxHome.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boxHome
        '
        Me.boxHome.BackColor = System.Drawing.Color.Transparent
        Me.boxHome.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.boxHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boxHome.Controls.Add(Me.buttonExit)
        Me.boxHome.Controls.Add(Me.PictureBox1)
        Me.boxHome.Controls.Add(Me.buttonHow2Play)
        Me.boxHome.Controls.Add(Me.buttonCredits)
        Me.boxHome.Controls.Add(Me.buttonAbout)
        Me.boxHome.Controls.Add(Me.buttonPlay)
        Me.boxHome.Font = New System.Drawing.Font("CLANDESTINA", 100.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxHome.ForeColor = System.Drawing.Color.DarkRed
        Me.boxHome.Location = New System.Drawing.Point(12, -2)
        Me.boxHome.Name = "boxHome"
        Me.boxHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.boxHome.Size = New System.Drawing.Size(860, 651)
        Me.boxHome.TabIndex = 0
        Me.boxHome.TabStop = False
        Me.boxHome.Text = "QUIZ BRAWLERS"
        '
        'buttonExit
        '
        Me.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonExit.Font = New System.Drawing.Font("CLANDESTINA", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonExit.ForeColor = System.Drawing.Color.MidnightBlue
        Me.buttonExit.Location = New System.Drawing.Point(474, 540)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(340, 75)
        Me.buttonExit.TabIndex = 5
        Me.buttonExit.Text = "QUIT"
        Me.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.Picture1
        Me.PictureBox1.InitialImage = Global.WindowsApp1.My.Resources.Resources.Picture1
        Me.PictureBox1.Location = New System.Drawing.Point(31, 148)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(437, 471)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'buttonHow2Play
        '
        Me.buttonHow2Play.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonHow2Play.Font = New System.Drawing.Font("CLANDESTINA", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonHow2Play.ForeColor = System.Drawing.Color.MidnightBlue
        Me.buttonHow2Play.Location = New System.Drawing.Point(474, 378)
        Me.buttonHow2Play.Name = "buttonHow2Play"
        Me.buttonHow2Play.Size = New System.Drawing.Size(340, 75)
        Me.buttonHow2Play.TabIndex = 3
        Me.buttonHow2Play.Text = "HOW TO PLAY"
        Me.buttonHow2Play.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonHow2Play.UseVisualStyleBackColor = True
        '
        'buttonCredits
        '
        Me.buttonCredits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonCredits.Font = New System.Drawing.Font("CLANDESTINA", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonCredits.ForeColor = System.Drawing.Color.MidnightBlue
        Me.buttonCredits.Location = New System.Drawing.Point(474, 459)
        Me.buttonCredits.Name = "buttonCredits"
        Me.buttonCredits.Size = New System.Drawing.Size(340, 75)
        Me.buttonCredits.TabIndex = 2
        Me.buttonCredits.Text = "CREDITS"
        Me.buttonCredits.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonCredits.UseVisualStyleBackColor = True
        '
        'buttonAbout
        '
        Me.buttonAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonAbout.Font = New System.Drawing.Font("CLANDESTINA", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAbout.ForeColor = System.Drawing.Color.MidnightBlue
        Me.buttonAbout.Location = New System.Drawing.Point(474, 299)
        Me.buttonAbout.Name = "buttonAbout"
        Me.buttonAbout.Size = New System.Drawing.Size(340, 75)
        Me.buttonAbout.TabIndex = 1
        Me.buttonAbout.Text = "ABOUT"
        Me.buttonAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonAbout.UseVisualStyleBackColor = True
        '
        'buttonPlay
        '
        Me.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonPlay.Font = New System.Drawing.Font("CLANDESTINA", 80.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPlay.ForeColor = System.Drawing.Color.MidnightBlue
        Me.buttonPlay.Location = New System.Drawing.Point(474, 148)
        Me.buttonPlay.Name = "buttonPlay"
        Me.buttonPlay.Size = New System.Drawing.Size(340, 145)
        Me.buttonPlay.TabIndex = 0
        Me.buttonPlay.Text = "PLAY"
        Me.buttonPlay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonPlay.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.boxHome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "home"
        Me.Text = "QUIZ BRAWLERS"
        Me.boxHome.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttonPlay As Button
    Friend WithEvents buttonAbout As Button
    Friend WithEvents buttonCredits As Button
    Friend WithEvents buttonHow2Play As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents boxHome As GroupBox
    Friend WithEvents buttonExit As Button
End Class
