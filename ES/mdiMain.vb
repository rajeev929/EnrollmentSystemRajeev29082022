Imports System.Windows.Forms

Public Class mdiMain

    Private Sub ManageListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageListToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

        frmStudentList.Show()

        frmStudentList.MdiParent = Me

    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmStudents.Show()

        frmStudents.MdiParent = Me

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        If MessageBox.Show("Are you sure you want to exit?", "Exit System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Return
        End If

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click

        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            frmLogin.Show()
            Me.Hide()
        Else
            Return
        End If

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

    End Sub

    Private Sub HistoryLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmHistLog.Show()

        frmHistLog.MdiParent = Me

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ToolStripLabel3.Text = Date.Now

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmAbout.Show()

        frmAbout.MdiParent = Me

    End Sub

    Private Sub ManageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

        frmAdmin.Show()
        frmAdmin.MdiParent = Me

    End Sub

    Private Sub EditUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditUsersToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

        frmCommittee.Show()
        frmCommittee.MdiParent = Me

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

        frmHistLog.Show()
        frmHistLog.MdiParent = Me

    End Sub

    Private Sub HistoryLogToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryLogToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

        frmHistLog.Show()
        frmHistLog.MdiParent = Me

    End Sub

    Private Sub StudentRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentRecordsToolStripMenuItem.Click

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

        frmStudentRecord.Show()
        frmStudentRecord.MdiParent = Me

    End Sub
End Class
