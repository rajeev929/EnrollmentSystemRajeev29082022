Imports System.Data.OleDb
Imports System.Object
Public Class frmStudents

    Private Sub frmStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SYDataSet.SY' table. You can move, or remove it, as needed.
        Me.SYTableAdapter.Fill(Me.SYDataSet.SY)

        Me.GenderTableAdapter.Fill(Me.GenderDataSet.Gender)

        Me.SubjectGradeTableAdapter.Fill(Me.StudentDataSet.SubjectGrade)
        Me.StatusTableAdapter.Fill(Me.StatusDataSet.Status)
        Me.Year_LevelTableAdapter.Fill(Me.YearLevelDataSet.Year_Level)
        Me.StudentsTableAdapter.Fill(Me.StudentDataSet.Students)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        Me.BirthDateTextBox.Text = DateTimePicker1.Value

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        StudentsBindingSource.AddNew()

        Me.SchoolYearTextBox.Enabled = True
        Me.YearLevelComboBox.Enabled = True
        Me.FirstNameTextBox.Enabled = True
        Me.MiddleNameTextBox.Enabled = True
        Me.LastNameTextBox.Enabled = True
        Me.DateTimePicker1.Enabled = True
        Me.AgeTextBox.Enabled = True
        Me.GenderComboBox.Enabled = True
        Me.AddressTextBox.Enabled = True
        Me.ContactNoTextBox.Enabled = True
        Me.GuardianContactNoTextBox.Enabled = True
        Me.GuardianTextBox.Enabled = True
        Me.StatusComboBox.Enabled = True
        Me.btnSave.Enabled = True
        Me.btnSave.Enabled = True
        Me.btnNew.Enabled = False
        Me.YearLevelComboBox.Focus()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MessageBox.Show("Are you sure you want to exit this form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            frmOption.Show()
            Me.Hide()
        Else
            Return
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Me.YearLevelComboBox.Text = "" Or Me.SchoolYearTextBox.Text = "" Or Me.LastNameTextBox.Text = "" Or Me.FirstNameTextBox.Text = "" Or Me.MiddleNameTextBox.Text = "" Or Me.BirthDateTextBox.Text = "" Or Me.AgeTextBox.Text = "" Or Me.GenderComboBox.Text = "" Or Me.AddressTextBox.Text = "" Or Me.ContactNoTextBox.Text = "" Or Me.GuardianTextBox.Text = "" Or Me.GuardianContactNoTextBox.Text = "" Or Me.StatusComboBox.Text = "" Then
            MessageBox.Show("You missed a field! Must complete all fields needed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim conn As New System.Data.OleDb.OleDbConnection
            Dim strConnString As String

            strConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_es.mdb"
            conn.ConnectionString = strConnString
            conn.Open()

            Dim OleDBC As New OleDbCommand
            With OleDBC
                .Connection = conn
                .CommandText = "INSERT INTO `HistoryLog` (`Time`, `Actions`, `User`) VALUES ('" & ToolStripLabel3.Text & "', 'Added a new student(" & Me.FirstNameTextBox.Text & " " & Me.MiddleNameTextBox.Text & " " & Me.LastNameTextBox.Text & ")', '" & ToolStripLabel5.Text & "')"
                .ExecuteNonQuery()
            End With

            Me.Validate()
            Me.StudentsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

            MessageBox.Show("Data added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.SchoolYearTextBox.Enabled = False
            Me.YearLevelComboBox.Enabled = False
            Me.FirstNameTextBox.Enabled = False
            Me.MiddleNameTextBox.Enabled = False
            Me.LastNameTextBox.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.AgeTextBox.Enabled = False
            Me.GenderComboBox.Enabled = False
            Me.AddressTextBox.Enabled = False
            Me.ContactNoTextBox.Enabled = False
            Me.GuardianContactNoTextBox.Enabled = False
            Me.GuardianTextBox.Enabled = False
            Me.StatusComboBox.Enabled = False
            Me.btnSave.Enabled = False
            Me.btnNew.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

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
            frmLogin.Show()
            Me.Hide()
        Else
            Return
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ToolStripLabel3.Text = Date.Now

    End Sub
End Class