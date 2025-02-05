<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Result
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Result))
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.lblFasiliti = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCreatedAt = New System.Windows.Forms.Label()
        Me.lblAddedBy = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblPenyelia1 = New System.Windows.Forms.Label()
        Me.lblKategori = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKeluasan = New System.Windows.Forms.Label()
        Me.lblKoordinat = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnDownload)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.lblFasiliti)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblCreatedAt)
        Me.Panel1.Controls.Add(Me.lblAddedBy)
        Me.Panel1.Controls.Add(Me.lblTel)
        Me.Panel1.Controls.Add(Me.lblPenyelia1)
        Me.Panel1.Controls.Add(Me.lblKategori)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblKeluasan)
        Me.Panel1.Controls.Add(Me.lblKoordinat)
        Me.Panel1.Controls.Add(Me.lblAlamat)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblNama)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 531)
        Me.Panel1.TabIndex = 19
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.HelpToolStripMenuItem, Me.FontToolStripMenuItem, Me.TributeToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(896, 28)
        Me.MenuStrip1.TabIndex = 43
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
        'lblFasiliti
        '
        Me.lblFasiliti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFasiliti.BackColor = System.Drawing.Color.Transparent
        Me.lblFasiliti.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFasiliti.Location = New System.Drawing.Point(564, 297)
        Me.lblFasiliti.Name = "lblFasiliti"
        Me.lblFasiliti.Size = New System.Drawing.Size(164, 17)
        Me.lblFasiliti.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(648, 506)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Created At  :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(648, 479)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 16)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Added By :"
        '
        'lblCreatedAt
        '
        Me.lblCreatedAt.AutoSize = True
        Me.lblCreatedAt.Location = New System.Drawing.Point(730, 506)
        Me.lblCreatedAt.Name = "lblCreatedAt"
        Me.lblCreatedAt.Size = New System.Drawing.Size(0, 16)
        Me.lblCreatedAt.TabIndex = 39
        '
        'lblAddedBy
        '
        Me.lblAddedBy.AutoSize = True
        Me.lblAddedBy.Location = New System.Drawing.Point(721, 479)
        Me.lblAddedBy.Name = "lblAddedBy"
        Me.lblAddedBy.Size = New System.Drawing.Size(0, 16)
        Me.lblAddedBy.TabIndex = 38
        Me.lblAddedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTel
        '
        Me.lblTel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTel.BackColor = System.Drawing.Color.Transparent
        Me.lblTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTel.Location = New System.Drawing.Point(601, 401)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(164, 17)
        Me.lblTel.TabIndex = 37
        '
        'lblPenyelia1
        '
        Me.lblPenyelia1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPenyelia1.BackColor = System.Drawing.Color.Transparent
        Me.lblPenyelia1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPenyelia1.Location = New System.Drawing.Point(627, 345)
        Me.lblPenyelia1.Name = "lblPenyelia1"
        Me.lblPenyelia1.Size = New System.Drawing.Size(164, 17)
        Me.lblPenyelia1.TabIndex = 36
        '
        'lblKategori
        '
        Me.lblKategori.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKategori.BackColor = System.Drawing.Color.Transparent
        Me.lblKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblKategori.Location = New System.Drawing.Point(575, 102)
        Me.lblKategori.Name = "lblKategori"
        Me.lblKategori.Size = New System.Drawing.Size(164, 17)
        Me.lblKategori.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(488, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Kategori :"
        '
        'lblKeluasan
        '
        Me.lblKeluasan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKeluasan.BackColor = System.Drawing.Color.Transparent
        Me.lblKeluasan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblKeluasan.Location = New System.Drawing.Point(584, 243)
        Me.lblKeluasan.Name = "lblKeluasan"
        Me.lblKeluasan.Size = New System.Drawing.Size(164, 17)
        Me.lblKeluasan.TabIndex = 31
        '
        'lblKoordinat
        '
        Me.lblKoordinat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKoordinat.BackColor = System.Drawing.Color.Transparent
        Me.lblKoordinat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblKoordinat.Location = New System.Drawing.Point(584, 194)
        Me.lblKoordinat.Name = "lblKoordinat"
        Me.lblKoordinat.Size = New System.Drawing.Size(164, 17)
        Me.lblKoordinat.TabIndex = 30
        '
        'lblAlamat
        '
        Me.lblAlamat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlamat.BackColor = System.Drawing.Color.Transparent
        Me.lblAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAlamat.Location = New System.Drawing.Point(565, 145)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(164, 17)
        Me.lblAlamat.TabIndex = 29
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.Location = New System.Drawing.Point(21, 466)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(229, 43)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(491, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "No. Telefon :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(490, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Nama Penyelia :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(490, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fasiliti :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(490, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Keluasan :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(488, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Koordinat :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(488, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Alamat :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(21, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(441, 360)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(488, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nama :"
        '
        'lblNama
        '
        Me.lblNama.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNama.Location = New System.Drawing.Point(557, 58)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(164, 17)
        Me.lblNama.TabIndex = 19
        '
        'btnDownload
        '
        Me.btnDownload.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDownload.Location = New System.Drawing.Point(257, 466)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(112, 43)
        Me.btnDownload.TabIndex = 44
        Me.btnDownload.Text = "Download PDF"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Location = New System.Drawing.Point(375, 466)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(112, 43)
        Me.btnPrint.TabIndex = 45
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(896, 531)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Result"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maklumat Dewan & Kuarters Daerah Seberang Perai"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPenyelia1 As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblKeluasan As Label
    Friend WithEvents lblKoordinat As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblCreatedAt As Label
    Friend WithEvents lblAddedBy As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFasiliti As Label
    Friend WithEvents MenuStrip1 As MenuStrip
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
    Friend WithEvents AccountInfo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ChangeUserPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApproveRejectAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDownload As Button
End Class
