Public Class frmSplash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.ProgressBar2.Value = Me.ProgressBar2.Value + 1
        Me.Label2.Text = "Loading . . . (" & Me.ProgressBar2.Value & "%)"

        If Me.ProgressBar2.Value = 100 Then
            Me.Timer1.Enabled = False
            frmComLogin.Show()
            Me.Hide()
        End If

        If Me.ProgressBar2.Value = 5 Then
            Me.Label3.Text = "Loading Forms . . ."
        ElseIf Me.ProgressBar2.Value = 10 Then
            Me.Label3.Text = "Preparing Database . . ."
        ElseIf Me.ProgressBar2.Value = 50 Then
            Me.Label3.Text = "Ready . . ."
        ElseIf Me.ProgressBar2.Value = 70 Then
            Me.Label3.Text = "Launching Enrollment System . . ."
        End If

    End Sub

End Class