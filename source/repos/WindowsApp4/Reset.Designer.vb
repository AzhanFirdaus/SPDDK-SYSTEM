<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reset))
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtverify = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.btnChange)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.txtverify)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.HelpToolStripMenuItem, Me.FontToolStripMenuItem, Me.TributeToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 23
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
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUsername.Location = New System.Drawing.Point(213, 133)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(365, 25)
        Me.lblUsername.TabIndex = 19
        Me.lblUsername.Text = "{{Username}}"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(427, 321)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(124, 54)
        Me.btnChange.TabIndex = 17
        Me.btnChange.Text = "Tukar"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(246, 321)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(124, 54)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtverify
        '
        Me.txtverify.Location = New System.Drawing.Point(390, 252)
        Me.txtverify.Name = "txtverify"
        Me.txtverify.Size = New System.Drawing.Size(188, 22)
        Me.txtverify.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(214, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Sahkan Kata Laluan :"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(390, 188)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(188, 22)
        Me.txtpassword.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(214, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Kata Laluan Baru :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(246, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "SET SEMULA KATA LALUAN"
        '
        'Reset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maklumat Dewan & Kuarters Daerah Seberang Perai"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtverify As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnChange As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblUsername As Label
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
End Class
