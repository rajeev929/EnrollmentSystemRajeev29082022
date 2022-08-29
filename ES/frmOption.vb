Imports System.Data.OleDb

Public Class frmOption

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If MessageBox.Show("Are you sure you want to exit this form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim conn As New System.Data.OleDb.OleDbConnection
            Dim strConnString As String

            strConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_es.mdb"
            conn.ConnectionString = strConnString
            conn.Open()

            Dim OleDBC As New OleDbCommand
            With OleDBC
                .Connection = conn
                .CommandText = "INSERT INTO `HistoryLog` (`Time`, `Actions`, `User`) VALUES ('" & ToolStripLabel3.Text & "', 'Logout', '" & ToolStripLabel5.Text & "')"
                .ExecuteNonQuery()
            End With

            frmComLogin.Show()
            Me.Hide()
        Else
            Return
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        frmStudents.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        frmContinuing.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ToolStripLabel3.Text = Date.Now

    End Sub
End Class