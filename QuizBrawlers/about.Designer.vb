<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class about
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(about))
        Me.boxAbout = New System.Windows.Forms.GroupBox()
        Me.aboutButtonPrev = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Previous = New System.Windows.Forms.ToolTip(Me.components)
        Me.boxAbout.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxAbout
        '
        Me.boxAbout.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.boxAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boxAbout.Controls.Add(Me.aboutButtonPrev)
        Me.boxAbout.Controls.Add(Me.Panel1)
        Me.boxAbout.Cursor = System.Windows.Forms.Cursors.No
        Me.boxAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boxAbout.Font = New System.Drawing.Font("CLANDESTINA", 100.0!, System.Drawing.FontStyle.Bold)
        Me.boxAbout.ForeColor = System.Drawing.Color.DarkRed
        Me.boxAbout.Location = New System.Drawing.Point(12, 0)
        Me.boxAbout.Name = "boxAbout"
        Me.boxAbout.Size = New System.Drawing.Size(860, 649)
        Me.boxAbout.TabIndex = 0
        Me.boxAbout.TabStop = False
        Me.boxAbout.Text = "ABOUT"
        '
        'aboutButtonPrev
        '
        Me.aboutButtonPrev.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Picture4
        Me.aboutButtonPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.aboutButtonPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aboutButtonPrev.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.aboutButtonPrev.FlatAppearance.BorderSize = 5
        Me.aboutButtonPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.aboutButtonPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.aboutButtonPrev.Location = New System.Drawing.Point(749, 533)
        Me.aboutButtonPrev.Name = "aboutButtonPrev"
        Me.aboutButtonPrev.Size = New System.Drawing.Size(80, 80)
        Me.aboutButtonPrev.TabIndex = 1
        Me.aboutButtonPrev.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.unnamed
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(33, 186)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 340)
        Me.Panel1.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Allerta Stencil", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(39, 35)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox1.Size = New System.Drawing.Size(715, 270)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Quiz Brawlers is a form of game or mind sport, in which the players attempt to an" &
    "swer questions correctly. It is a game to test the knowledge about a certain sub" &
    "ject."
        '
        'Previous
        '
        Me.Previous.AutomaticDelay = 1
        Me.Previous.ShowAlways = True
        Me.Previous.ToolTipTitle = "Previous"
        '
        'about
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.boxAbout)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "about"
        Me.Text = "QUIZ BRAWLERS | About"
        Me.boxAbout.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boxAbout As GroupBox
    Friend WithEvents aboutButtonPrev As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Previous As ToolTip
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
