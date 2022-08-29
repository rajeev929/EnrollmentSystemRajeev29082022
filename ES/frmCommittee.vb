Public Class frmCommittee

    Private Sub CommitteeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommitteeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CommitteeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CommitteeDataSet)

    End Sub

    Private Sub frmCommittee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CommitteeTableAdapter.Fill(Me.CommitteeDataSet.Committee)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MessageBox.Show("Leave this form?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            Return
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Me.Validate()
        Me.CommitteeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CommitteeDataSet)

        MessageBox.Show("Saved!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.UsernameTextBox.Enabled = False
        Me.PasswordTextBox.Enabled = False

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        CommitteeBindingSource.AddNew()

        Me.UsernameTextBox.Enabled = True
        Me.PasswordTextBox.Enabled = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.UsernameTextBox.Enabled = True
        Me.PasswordTextBox.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        CommitteeBindingNavigator.DeleteItem.PerformClick()

    End Sub
End Class