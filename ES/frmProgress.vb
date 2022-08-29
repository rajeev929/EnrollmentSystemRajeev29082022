Public Class frmProgress

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.ProgressBar1.Value = Me.ProgressBar1.Value + 1
        If Me.ProgressBar1.Value = 100 Then
            Me.Timer1.Enabled = False
            frmSplash.Show()
            Me.Hide()
        End If

    End Sub
End Class