Public Class frmStudentList

    Private Sub StudentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

    End Sub

    Private Sub frmStudentList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SYDataSet.SY' table. You can move, or remove it, as needed.
        Me.SYTableAdapter.Fill(Me.SYDataSet.SY)

        Me.GenderTableAdapter.Fill(Me.GenderDataSet.Gender)
        Me.StatusTableAdapter.Fill(Me.StatusDataSet.Status)
        Me.Year_LevelTableAdapter.Fill(Me.YearLevelDataSet.Year_Level)
        Me.StudentsTableAdapter.Fill(Me.StudentDataSet.Students)

        Me.StudentsTableAdapter.FillBy1(Me.StudentDataSet.Students)

        txtSearch.Focus()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MessageBox.Show("Leave this form?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            Return
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        StudentsDataGridView.ReadOnly = False
        btnEdit.Text = "Edit Allowed"

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

        MessageBox.Show("Saved!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)

        StudentsDataGridView.ReadOnly = True
        btnEdit.Text = "Allow Edit"

        txtSearch.Focus()

    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click

        Me.StudentsTableAdapter.FillBy(Me.StudentDataSet.Students, Val(cboYearLevel.Text))

        txtSearch.Focus()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        Me.StudentsTableAdapter.FillBy1(Me.StudentDataSet.Students)

    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        StudentsBindingSource.MoveFirst()

    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click

        StudentsBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        StudentsBindingSource.MoveNext()

    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click

        StudentsBindingSource.MoveLast()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If cboSearch.Text = "Student ID" Then
            Me.StudentsTableAdapter.FillBy3(Me.StudentDataSet.Students, Val(txtSearch.Text))
        ElseIf cboSearch.Text = "Lastname" Then
            Me.StudentsTableAdapter.FillBy2(Me.StudentDataSet.Students, txtSearch.Text)
        ElseIf cboSearch.Text = "Firstname" Then
            Me.StudentsTableAdapter.FillBy4(Me.StudentDataSet.Students, txtSearch.Text)
        ElseIf cboSearch.Text = "Middlename" Then
            Me.StudentsTableAdapter.FillBy5(Me.StudentDataSet.Students, txtSearch.Text)
        Else
            MessageBox.Show("Parameter not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        txtSearch.Text = ""
        txtSearch.Focus()

    End Sub

    Private Sub cboSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearch.SelectedIndexChanged

        txtSearch.Focus()

    End Sub
End Class