Public Class frmAdmin

    Private Sub UsersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserDataSet)

    End Sub

    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.UserDataSet.Users)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MessageBox.Show("Leave this form?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            Return
        End If

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        UsersBindingSource.AddNew()

        Me.UserNameTextBox.Enabled = True
        Me.PasswordTextBox.Enabled = True

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserDataSet)

        MessageBox.Show("Saved!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.UserNameTextBox.Enabled = False
        Me.PasswordTextBox.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        UsersBindingNavigator.DeleteItem.PerformClick()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.UserNameTextBox.Enabled = True
        Me.PasswordTextBox.Enabled = True

    End Sub
End Class