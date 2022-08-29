Imports System.Data.OleDb

Public Class frmLogin
    Dim conn As New OleDbConnection
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim sqlQRY As String = "SELECT * FROM Users Where Username = '" & Me.UsernameTextBox.Text & "' AND Password = '" & Me.PasswordTextBox.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, conn)
        Dim rdr As OleDbDataReader = cmd.ExecuteReader
        rdr.Read()
        If rdr.HasRows = True Then
            Dim Username As String = rdr("Username").ToString
            Dim Password As String = rdr("Password").ToString

            Dim conn As New System.Data.OleDb.OleDbConnection
            Dim strConnString As String

            strConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_es.mdb"
            conn.ConnectionString = strConnString
            conn.Open()

            Dim OleDBC As New OleDbCommand
            With OleDBC
                .Connection = conn
                .CommandText = "INSERT INTO `HistoryLog` (`Time`, `Actions`, `User`) VALUES ('" & ToolStripLabel3.Text & "', 'Login', '" & UsernameTextBox.Text & "')"
                .ExecuteNonQuery()
            End With

            UsernameTextBox.Text = ""
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
            mdiMain.Show()
            Me.Hide()

        ElseIf UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Please input a valid username or password!", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UsernameTextBox.Text = ""
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        Else
            MessageBox.Show("Username or password not found!", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UsernameTextBox.Text = ""
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        frmComLogin.Show()

        Me.Hide()

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cnString As String

        cnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_es.mdb"

        conn = New OleDbConnection(cnString)

        Try
            conn.Open()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ToolStripLabel3.Text = Date.Now

    End Sub
End Class
