<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
    Public Sub New()
        InitializeComponent()
        ' Enable double buffering
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                ControlStyles.UserPaint Or
                ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        ' Draw the background image manually to avoid flickering
        If Me.BackgroundImage IsNot Nothing Then
            e.Graphics.DrawImage(Me.BackgroundImage, 0, 0, Me.Width, Me.Height)
        End If
        MyBase.OnPaint(e)
    End Sub
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxKategori = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxNama = New System.Windows.Forms.ComboBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncreaseFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TributeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangeUserPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApproveRejectAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(751, 38)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Maklumat Dewan Daerah Seberang Perai Utara"
        '
        'cbxKategori
        '
        Me.cbxKategori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cbxKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbxKategori.FormattingEnabled = True
        Me.cbxKategori.Location = New System.Drawing.Point(353, 221)
        Me.cbxKategori.Name = "cbxKategori"
        Me.cbxKategori.Size = New System.Drawing.Size(237, 28)
        Me.cbxKategori.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(203, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Kategori Aset :"
        '
        'btnCari
        '
        Me.btnCari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCari.BackColor = System.Drawing.Color.Snow
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Location = New System.Drawing.Point(344, 372)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(118, 47)
        Me.btnCari.TabIndex = 15
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(214, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nama Aset :"
        '
        'cbxNama
        '
        Me.cbxNama.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cbxNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbxNama.FormattingEnabled = True
        Me.cbxNama.Location = New System.Drawing.Point(353, 289)
        Me.cbxNama.Name = "cbxNama"
        Me.cbxNama.Size = New System.Drawing.Size(237, 28)
        Me.cbxNama.TabIndex = 17
        '
        'btnTambah
        '
        Me.btnTambah.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTambah.BackColor = System.Drawing.Color.Snow
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Location = New System.Drawing.Point(205, 372)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(123, 47)
        Me.btnTambah.TabIndex = 18
        Me.btnTambah.Text = "Tambah Maklumat"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.Snow
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(479, 372)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 47)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Hapus Maklumat"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnTambah)
        Me.Panel1.Controls.Add(Me.cbxNama)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbxKategori)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApp4.My.Resources.Resources.Coat_of_arms_of_Penang_svg
        Me.PictureBox2.Location = New System.Drawing.Point(386, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.HelpToolStripMenuItem, Me.FontToolStripMenuItem, Me.TributeToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncreaseFontToolStripMenuItem, Me.DecreaseFontToolStripMenuItem})
        Me.FontToolStripMenuItem.Image = CType(resources.GetObject("FontToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'IncreaseFontToolStripMenuItem
        '
        Me.IncreaseFontToolStripMenuItem.Name = "IncreaseFontToolStripMenuItem"
        Me.IncreaseFontToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.IncreaseFontToolStripMenuItem.Text = "Increase Font"
        '
        'DecreaseFontToolStripMenuItem
        '
        Me.DecreaseFontToolStripMenuItem.Name = "DecreaseFontToolStripMenuItem"
        Me.DecreaseFontToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.DecreaseFontToolStripMenuItem.Text = "Decrease Font"
        '
        'TributeToolStripMenuItem
        '
        Me.TributeToolStripMenuItem.Image = CType(resources.GetObject("TributeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TributeToolStripMenuItem.Name = "TributeToolStripMenuItem"
        Me.TributeToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.TributeToolStripMenuItem.Text = "Credit"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.LogoutToolStripMenuItem, Me.ResetPasswordToolStripMenuItem, Me.AccountInfo, Me.ToolStripSeparator1, Me.ChangeUserPasswordToolStripMenuItem, Me.ApproveRejectAccountToolStripMenuItem})
        Me.AccountToolStripMenuItem.Image = Global.WindowsApp4.My.Resources.Resources.image_removebg_preview__67_
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Enabled = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(241, 26)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.WindowsApp4.My.Resources.Resources.image_removebg_preview__68_1
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ResetPasswordToolStripMenuItem
        '
        Me.ResetPasswordToolStripMenuItem.Image = Global.WindowsApp4.My.Resources.Resources.reset_password_icon
        Me.ResetPasswordToolStripMenuItem.Name = "ResetPasswordToolStripMenuItem"
        Me.ResetPasswordToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.ResetPasswordToolStripMenuItem.Text = "Reset Password"
        '
        'AccountInfo
        '
        Me.AccountInfo.Image = Global.WindowsApp4.My.Resources.Resources.image_removebg_preview__71_
        Me.AccountInfo.Name = "AccountInfo"
        Me.AccountInfo.Size = New System.Drawing.Size(241, 26)
        Me.AccountInfo.Text = "Account Information"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(238, 6)
        '
        'ChangeUserPasswordToolStripMenuItem
        '
        Me.ChangeUserPasswordToolStripMenuItem.Image = Global.WindowsApp4.My.Resources.Resources.image_removebg_preview__79_1
        Me.ChangeUserPasswordToolStripMenuItem.Name = "ChangeUserPasswordToolStripMenuItem"
        Me.ChangeUserPasswordToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.ChangeUserPasswordToolStripMenuItem.Text = "Change User Password"
        '
        'ApproveRejectAccountToolStripMenuItem
        '
        Me.ApproveRejectAccountToolStripMenuItem.Image = Global.WindowsApp4.My.Resources.Resources.image_removebg_preview__80_
        Me.ApproveRejectAccountToolStripMenuItem.Name = "ApproveRejectAccountToolStripMenuItem"
        Me.ApproveRejectAccountToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.ApproveRejectAccountToolStripMenuItem.Text = "Approve/Reject Account"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maklumat Dewan & Kuarters Daerah Seberang Perai"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbxKategori As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxNama As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncreaseFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecreaseFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TributeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ChangeUserPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApproveRejectAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccountInfo As ToolStripMenuItem
End Class
