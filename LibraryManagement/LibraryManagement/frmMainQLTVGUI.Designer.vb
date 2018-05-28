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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýĐọcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuảnLyLoạiĐọcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HệThốngSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmLoạiSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýLoạiSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HệThốngSáchToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(282, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýĐọcGiảToolStripMenuItem, Me.ToolStripMenuItem1, Me.QuảnLyLoạiĐọcGiảToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(137, 24)
        Me.FileToolStripMenuItem.Text = "Hệ thống đọc giả"
        '
        'QuảnLýĐọcGiảToolStripMenuItem
        '
        Me.QuảnLýĐọcGiảToolStripMenuItem.Name = "QuảnLýĐọcGiảToolStripMenuItem"
        Me.QuảnLýĐọcGiảToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.QuảnLýĐọcGiảToolStripMenuItem.Text = "Quản lý loại đọc giả"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(214, 6)
        '
        'QuảnLyLoạiĐọcGiảToolStripMenuItem
        '
        Me.QuảnLyLoạiĐọcGiảToolStripMenuItem.Name = "QuảnLyLoạiĐọcGiảToolStripMenuItem"
        Me.QuảnLyLoạiĐọcGiảToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.QuảnLyLoạiĐọcGiảToolStripMenuItem.Text = "Quản ly đọc giả"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(214, 6)
        '
        'HệThốngSáchToolStripMenuItem
        '
        Me.HệThốngSáchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmLoạiSáchToolStripMenuItem, Me.QuảnLýLoạiSáchToolStripMenuItem})
        Me.HệThốngSáchToolStripMenuItem.Name = "HệThốngSáchToolStripMenuItem"
        Me.HệThốngSáchToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.HệThốngSáchToolStripMenuItem.Text = "Hệ thống Sách"
        '
        'ThêmLoạiSáchToolStripMenuItem
        '
        Me.ThêmLoạiSáchToolStripMenuItem.Name = "ThêmLoạiSáchToolStripMenuItem"
        Me.ThêmLoạiSáchToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ThêmLoạiSáchToolStripMenuItem.Text = "Thêm Loại Sách"
        '
        'QuảnLýLoạiSáchToolStripMenuItem
        '
        Me.QuảnLýLoạiSáchToolStripMenuItem.Name = "QuảnLýLoạiSáchToolStripMenuItem"
        Me.QuảnLýLoạiSáchToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.QuảnLýLoạiSáchToolStripMenuItem.Text = "Quản lý loại sách"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Quản Lý Thư Viện"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýĐọcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents QuảnLyLoạiĐọcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents HệThốngSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmLoạiSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýLoạiSáchToolStripMenuItem As ToolStripMenuItem
End Class
