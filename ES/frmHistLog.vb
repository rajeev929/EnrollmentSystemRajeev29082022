Public Class frmHistLog

    Private Sub HistoryLogBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.HistoryLogBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HistoryLogDataSet)

    End Sub

    Private Sub frmHistLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.HistoryLogTableAdapter.Fill(Me.HistoryLogDataSet.HistoryLog)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MessageBox.Show("Leave this form?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            Return
        End If

    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        HistoryLogBindingSource.MoveFirst()

    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click

        HistoryLogBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        HistoryLogBindingSource.MoveNext()

    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click

        HistoryLogBindingSource.MoveLast()

    End Sub
End Class