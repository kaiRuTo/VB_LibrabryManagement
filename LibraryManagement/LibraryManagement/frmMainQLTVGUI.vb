
Public Class frmMain
    Private Sub ThêmĐọcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmĐọcGiảToolStripMenuItem.Click
        Dim frm As frmLoaiDocGiaGUI = New frmLoaiDocGiaGUI()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThêmLoạiĐọcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiĐọcGiảToolStripMenuItem.Click
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
End Class
