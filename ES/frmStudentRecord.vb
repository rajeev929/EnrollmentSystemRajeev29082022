Public Class frmStudentRecord

    Private Sub StudentRecordBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentRecordBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentRecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentRecordDataSet)

    End Sub

    Private Sub frmStudentRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentRecordDataSet.StudentRecord' table. You can move, or remove it, as needed.
        Me.StudentRecordTableAdapter.Fill(Me.StudentRecordDataSet.StudentRecord)

    End Sub
End Class