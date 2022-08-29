Public Class frmRegisterContinuing

    Private Sub StudentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

    End Sub

    Private Sub frmRegisterContinuing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.StudentDataSet.Students)

    End Sub
End Class