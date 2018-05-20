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
        Me.ThêmĐọcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýĐọcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThêmLoạiĐọcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLyLoạiĐọcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(282, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmĐọcGiảToolStripMenuItem, Me.QuảnLýĐọcGiảToolStripMenuItem, Me.ToolStripMenuItem1, Me.ThêmLoạiĐọcGiảToolStripMenuItem, Me.QuảnLyLoạiĐọcGiảToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.FileToolStripMenuItem.Text = "Quản lý đọc giả"
        '
        'ThêmĐọcGiảToolStripMenuItem
        '
        Me.ThêmĐọcGiảToolStripMenuItem.Name = "ThêmĐọcGiảToolStripMenuItem"
        Me.ThêmĐọcGiảToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ThêmĐọcGiảToolStripMenuItem.Text = "Thêm loại đọc giả"
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
        'ThêmLoạiĐọcGiảToolStripMenuItem
        '
        Me.ThêmLoạiĐọcGiảToolStripMenuItem.Name = "ThêmLoạiĐọcGiảToolStripMenuItem"
        Me.ThêmLoạiĐọcGiảToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ThêmLoạiĐọcGiảToolStripMenuItem.Text = "Thêm  đọc giả"
        '
        'QuảnLyLoạiĐọcGiảToolStripMenuItem
        '
        Me.QuảnLyLoạiĐọcGiảToolStripMenuItem.Name = "QuảnLyLoạiĐọcGiảToolStripMenuItem"
        Me.QuảnLyLoạiĐọcGiảToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.QuảnLyLoạiĐọcGiảToolStripMenuItem.Text = "Quản ly đọc giả"
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
    Friend WithEvents ThêmĐọcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýĐọcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ThêmLoạiĐọcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLyLoạiĐọcGiảToolStripMenuItem As ToolStripMenuItem
End Class
