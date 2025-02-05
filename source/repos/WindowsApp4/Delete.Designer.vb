<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Delete))
        Me.AsetPDTSPUDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsetPDTSPUDataSet = New WindowsApp4.AsetPDTSPUDataSet()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AsetPDTSPUDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsetPDTSPUDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AsetPDTSPUDataSetBindingSource
        '
        Me.AsetPDTSPUDataSetBindingSource.DataSource = Me.AsetPDTSPUDataSet
        Me.AsetPDTSPUDataSetBindingSource.Position = 0
        '
        'AsetPDTSPUDataSet
        '
        Me.AsetPDTSPUDataSet.DataSetName = "AsetPDTSPUDataSet"
        Me.AsetPDTSPUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.HelpToolStripMenuItem, Me.FontToolStripMenuItem, Me.TributeToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 28)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncreaseFontToolStripMenuItem, Me.DecreaseFontToolStripMenuItem})
        Me.FontToolStripMenuItem.Image = CType(resources.GetObject("FontToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'IncreaseFontToolStripMenuItem
        '
        Me.IncreaseFontToolStripMenuItem.Name = "IncreaseFontToolStripMenuItem"
        Me.IncreaseFontToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.IncreaseFontToolStripMenuItem.Text = "Increase Font"
        '
        'DecreaseFontToolStripMenuItem
        '
        Me.DecreaseFontToolStripMenuItem.Name = "DecreaseFontToolStripMenuItem"
        Me.DecreaseFontToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DecreaseFontToolStripMenuItem.Text = "Decrease Font"
        '
        'TributeToolStripMenuItem
        '
        Me.TributeToolStripMenuItem.Image = CType(resources.GetObject("TributeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TributeToolStripMenuItem.Name = "TributeToolStripMenuItem"
        Me.TributeToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.TributeToolStripMenuItem.Text = "Credit"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.LogoutToolStripMenuItem, Me.ResetPasswordToolStripMenuItem, Me.AccountInfo, Me.ToolStripSeparator1, Me.ChangeUserPasswordToolStripMenuItem, Me.ApproveRejectAccountToolStripMenuItem})
        Me.AccountToolStripMenuItem.Image = Global.WindowsApp4.My.Resources.Resources.image_removebg_preview__67_
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Enabled = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(196, 26)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.WindowsApp4.My.Resources.Resources.image_removebg_preview__68_1
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ResetPasswordToolStripMenuItem
        '
        Me.ResetPasswordToolStripMenuItem.Image = Global.WindowsApp4.My.Resources.Resources.reset_password_icon
        Me.ResetPasswordToolStripMenuItem.Name = "ResetPasswordToolStripMenuItem"
        Me.ResetPasswordToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ResetPasswordToolStripMenuItem.Text = "Reset Password"
        '
        'AccountInfo
        '
        Me.AccountInfo.Image = Global.WindowsApp4.My.Resources.Resources.image_removebg_preview__71_
        Me.AccountInfo.Name = "AccountInfo"
        Me.AccountInfo.Size = New System.Drawing.Size(196, 26)
        Me.AccountInfo.Text = "Account Information"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(193, 6)
        '
        'ChangeUserPasswordToolStripMenuItem
        '
        Me.ChangeUserPasswordToolStripMenuItem.Image = Global.WindowsApp4.My.Resources.Resources.image_removebg_preview__79_1
        Me.ChangeUserPasswordToolStripMenuItem.Name = "ChangeUserPasswordToolStripMenuItem"
        Me.ChangeUserPasswordToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ChangeUserPasswordToolStripMenuItem.Text = "Change User Password"
        '
        'ApproveRejectAccountToolStripMenuItem
        '
        Me.ApproveRejectAccountToolStripMenuItem.Image = Global.WindowsApp4.My.Resources.Resources.image_removebg_preview__80_
        Me.ApproveRejectAccountToolStripMenuItem.Name = "ApproveRejectAccountToolStripMenuItem"
        Me.ApproveRejectAccountToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ApproveRejectAccountToolStripMenuItem.Text = "Approve/Reject Account"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNama)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 499)
        Me.Panel1.TabIndex = 24
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(274, 461)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 28)
        Me.btnBack.TabIndex = 25
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.AsetPDTSPUDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 101)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(582, 334)
        Me.DataGridView1.TabIndex = 24
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(383, 74)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(62, 22)
        Me.btnCari.TabIndex = 23
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nama Aset :"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(232, 76)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(140, 20)
        Me.txtNama.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(226, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Hapus Aset"
        '
        'Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(600, 527)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maklumat Dewan & Kuarters Daerah Seberang Perai"
        CType(Me.AsetPDTSPUDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsetPDTSPUDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AsetPDTSPUDataSetBindingSource As BindingSource
    Friend WithEvents AsetPDTSPUDataSet As AsetPDTSPUDataSet
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCari As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
End Class
