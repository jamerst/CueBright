<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.lnkLblLicense = New System.Windows.Forms.LinkLabel()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cMenuTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CueBrightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pBoxLogo = New System.Windows.Forms.PictureBox()
        Me.cMenuTray.SuspendLayout()
        CType(Me.pBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(12, 9)
        Me.lblDesc.MaximumSize = New System.Drawing.Size(375, 0)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(369, 221)
        Me.lblDesc.TabIndex = 0
        Me.lblDesc.Text = resources.GetString("lblDesc.Text")
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(277, 113)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(95, 23)
        Me.btnHide.TabIndex = 1
        Me.btnHide.Text = "Minimize to Tray"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'lnkLblLicense
        '
        Me.lnkLblLicense.AutoSize = True
        Me.lnkLblLicense.Location = New System.Drawing.Point(73, 204)
        Me.lnkLblLicense.Name = "lnkLblLicense"
        Me.lnkLblLicense.Size = New System.Drawing.Size(28, 13)
        Me.lnkLblLicense.TabIndex = 2
        Me.lnkLblLicense.TabStop = True
        Me.lnkLblLicense.Text = "here"
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.cMenuTray
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "CueBright"
        Me.TrayIcon.Visible = True
        '
        'cMenuTray
        '
        Me.cMenuTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CueBrightToolStripMenuItem, Me.ToolStripSeparator1, Me.DisableToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.cMenuTray.Name = "cMenuTray"
        Me.cMenuTray.Size = New System.Drawing.Size(128, 76)
        '
        'CueBrightToolStripMenuItem
        '
        Me.CueBrightToolStripMenuItem.Image = Global.CueBright.My.Resources.Resources.Logo
        Me.CueBrightToolStripMenuItem.Name = "CueBrightToolStripMenuItem"
        Me.CueBrightToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CueBrightToolStripMenuItem.Text = "CueBright"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(124, 6)
        '
        'DisableToolStripMenuItem
        '
        Me.DisableToolStripMenuItem.CheckOnClick = True
        Me.DisableToolStripMenuItem.Name = "DisableToolStripMenuItem"
        Me.DisableToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.DisableToolStripMenuItem.Text = "Disable"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.QuitToolStripMenuItem.Text = "Exit"
        '
        'pBoxLogo
        '
        Me.pBoxLogo.Image = Global.CueBright.My.Resources.Resources.Logo
        Me.pBoxLogo.Location = New System.Drawing.Point(277, 12)
        Me.pBoxLogo.Name = "pBoxLogo"
        Me.pBoxLogo.Size = New System.Drawing.Size(95, 95)
        Me.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pBoxLogo.TabIndex = 3
        Me.pBoxLogo.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 237)
        Me.Controls.Add(Me.pBoxLogo)
        Me.Controls.Add(Me.lnkLblLicense)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.lblDesc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CueBright"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.cMenuTray.ResumeLayout(False)
        CType(Me.pBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDesc As Label
    Friend WithEvents btnHide As Button
    Friend WithEvents lnkLblLicense As LinkLabel
    Friend WithEvents TrayIcon As NotifyIcon
    Friend WithEvents pBoxLogo As PictureBox
    Friend WithEvents cMenuTray As ContextMenuStrip
    Friend WithEvents CueBrightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DisableToolStripMenuItem As ToolStripMenuItem
End Class
