
Public Class frmMain
    Private Sub ThêmĐọcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As frmLoaiDocGiaGUI = New frmLoaiDocGiaGUI()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmLoạiĐọcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmdg As frmDocGiaGUI = New frmDocGiaGUI()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuảnLýĐọcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýĐọcGiảToolStripMenuItem.Click
        Dim frm As frmQuanLyLoaiDocGia = New frmQuanLyLoaiDocGia()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLyLoạiĐọcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLyLoạiĐọcGiảToolStripMenuItem.Click
        Dim frm As frmQuanLyDocGia = New frmQuanLyDocGia()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiSáchToolStripMenuItem.Click
        Dim frm As frmLoaiSachGUI = New frmLoaiSachGUI()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýLoạiSáchToolStripMenuItem.Click
        Dim frm As frmQuanLyLoaiSach = New frmQuanLyLoaiSach()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuyĐịnhToolStripMenuItem.Click
        Dim frm As frmQuyDinh = New frmQuyDinh
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmTácGỉaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmTácGỉaToolStripMenuItem.Click
        Dim frm As frmTacGia = New frmTacGia
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmNXBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmNXBToolStripMenuItem.Click
        Dim frm As frmNhaXuatBan = New frmNhaXuatBan
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
