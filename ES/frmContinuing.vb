Imports System.Data.OleDb
Imports System.Object

Public Class frmContinuing

    Private Sub StudentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

    End Sub


    Private Sub StudentsBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

    End Sub


    Private Sub StudentsBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

    End Sub

    Private Sub frmContinuing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.GradingPeriodTableAdapter.Fill(Me.GradingPeriodDataSet.GradingPeriod)
        Me.Grades_Seniors_TableAdapter.FillBy(Me.StudentDataSet._Grades_Seniors_)
        Me.Grades_Juniors_TableAdapter.FillBy(Me.StudentDataSet._Grades_Juniors_)
        Me.Grades_Sophomore_TableAdapter.FillBy(Me.StudentDataSet._Grades_Sophomore_)
        Me.Grades_Freshmen_TableAdapter.FillBy(Me.StudentDataSet._Grades_Freshmen_)
        Me.SectionTableAdapter.Fill(Me.SectionDataSet.Section)
        Me.SYTableAdapter.Fill(Me.SYDataSet.SY)

        Me.GenderTableAdapter.Fill(Me.GenderDataSet.Gender)
        Me.StatusTableAdapter.Fill(Me.StatusDataSet.Status)
        Me.Year_LevelTableAdapter.Fill(Me.YearLevelDataSet.Year_Level)
        Me.StudentsTableAdapter.Fill(Me.StudentDataSet.Students)

        Me.BirthDateLabel1.Text = DateFormat.LongDate

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

        MessageBox.Show("Saved!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MessageBox.Show("Are you sure you want to exit this form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            frmOption.Show()
            Me.Hide()
        Else
            Return
        End If

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Dim conn As New System.Data.OleDb.OleDbConnection
        Dim strConnString As String

        strConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_es.mdb"
        conn.ConnectionString = strConnString
        conn.Open()

        Dim OleDBC As New OleDbCommand
        With OleDBC
            .Connection = conn
            .CommandText = "INSERT INTO `StudentRecord` (`LastName`, `FirstName`, `MiddleName`, `BirthDate`, `Age`, `Address`, `YearLevel`, `Gender`, `SchoolYear`) VALUES ('" & Me.LastNameLabel1.Text & "', '" & Me.FirstNameLabel1.Text & "', '" & Me.MiddleNameLabel1.Text & "', '" & Me.BirthDateLabel1.Text & "', '" & Me.AgeTextBox.Text & "', '" & Me.AddressLabel1.Text & "', '" & Me.YearLevelComboBox.Text & "', '" & Me.GenderComboBox.Text & "', '" & Me.SchoolYearComboBox.Text & "')"
            .ExecuteNonQuery()
        End With

        With OleDBC
            .Connection = conn
            .CommandText = "INSERT INTO `HistoryLog` (`Time`, `Actions`, `User`) VALUES ('" & ToolStripLabel3.Text & "', 'Updated a record of a student(" & Me.FirstNameLabel1.Text & " " & Me.MiddleNameLabel1.Text & " " & Me.LastNameLabel1.Text & ")', '" & ToolStripLabel5.Text & "')"
            .ExecuteNonQuery()
        End With

        Me.StatusComboBox.Text = "Enrolled(Continuing)"

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)


        MessageBox.Show("Saved!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim conn As New System.Data.OleDb.OleDbConnection
        Dim strConnString As String

        strConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_es.mdb"
        conn.ConnectionString = strConnString
        conn.Open()

        Dim OleDBC As New OleDbCommand
        With OleDBC
            .Connection = conn
            .CommandText = "INSERT INTO `HistoryLog` (`Time`, `Actions`, `User`) VALUES ('" & ToolStripLabel3.Text & "', 'Updated 2nd year grade of a student(" & Me.FirstNameLabel1.Text & " " & Me.MiddleNameLabel1.Text & " " & Me.LastNameLabel1.Text & ")', '" & ToolStripLabel5.Text & "')"
            .ExecuteNonQuery()
        End With

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

        Me.Grades_Sophomore_TableAdapter.FillBy(Me.StudentDataSet._Grades_Sophomore_)

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

        MessageBox.Show("Saved!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim conn As New System.Data.OleDb.OleDbConnection
        Dim strConnString As String

        strConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_es.mdb"
        conn.ConnectionString = strConnString
        conn.Open()

        Dim OleDBC As New OleDbCommand
        With OleDBC
            .Connection = conn
            .CommandText = "INSERT INTO `HistoryLog` (`Time`, `Actions`, `User`) VALUES ('" & ToolStripLabel3.Text & "', 'Updated 3rd year grade of a student(" & Me.FirstNameLabel1.Text & " " & Me.MiddleNameLabel1.Text & " " & Me.LastNameLabel1.Text & ")', '" & ToolStripLabel5.Text & "')"
            .ExecuteNonQuery()
        End With

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

        Me.Grades_Juniors_TableAdapter.FillBy(Me.StudentDataSet._Grades_Juniors_)

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

        MessageBox.Show("Saved!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim conn As New System.Data.OleDb.OleDbConnection
        Dim strConnString As String

        strConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_es.mdb"
        conn.ConnectionString = strConnString
        conn.Open()

        Dim OleDBC As New OleDbCommand
        With OleDBC
            .Connection = conn
            .CommandText = "INSERT INTO `StudentRecord` (`LastName`, `FirstName`, `MiddleName`, `BirthDate`, `Age`, `Address`, `YearLevel`, `Gender`, `SchoolYear`) VALUES ('" & Me.LastNameLabel1.Text & "', '" & Me.FirstNameLabel1.Text & "', '" & Me.MiddleNameLabel1.Text & "', '" & Me.BirthDateLabel1.Text & "', '" & Me.AgeTextBox.Text & "', '" & Me.AddressLabel1.Text & "', '" & Me.YearLevelComboBox.Text & "', '" & Me.GenderComboBox.Text & "', '" & Me.SchoolYearComboBox.Text & "')"
            .ExecuteNonQuery()
        End With

        With OleDBC
            .Connection = conn
            .CommandText = "INSERT INTO `HistoryLog` (`Time`, `Actions`, `User`) VALUES ('" & ToolStripLabel3.Text & "', 'Updated 4th year grade of a student(" & Me.FirstNameLabel1.Text & " " & Me.MiddleNameLabel1.Text & " " & Me.LastNameLabel1.Text & ")', '" & ToolStripLabel5.Text & "')"
            .ExecuteNonQuery()
        End With

        Me.StatusComboBox.Text = "Enrolled(Continuing)"

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

        Me.Grades_Seniors_TableAdapter.FillBy(Me.StudentDataSet._Grades_Seniors_)

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

        MessageBox.Show("Saved!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ToolStripLabel3.Text = Date.Now

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim conn As New System.Data.OleDb.OleDbConnection
        Dim strConnString As String

        strConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_es.mdb"
        conn.ConnectionString = strConnString
        conn.Open()

        Dim OleDBC As New OleDbCommand
        With OleDBC
            .Connection = conn
            .CommandText = "INSERT INTO `HistoryLog` (`Time`, `Actions`, `User`) VALUES ('" & ToolStripLabel3.Text & "', 'Updated a 1st year grade of a student(" & Me.FirstNameLabel1.Text & " " & Me.MiddleNameLabel1.Text & " " & Me.LastNameLabel1.Text & ")', '" & ToolStripLabel5.Text & "')"
            .ExecuteNonQuery()
        End With

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

        Me.Grades_Seniors_TableAdapter.FillBy(Me.StudentDataSet._Grades_Seniors_)

        MessageBox.Show("Saved!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        ToolStripLabel3.Text = Date.Now

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim conn As New System.Data.OleDb.OleDbConnection
        Dim strConnString As String

        strConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_es.mdb"
        conn.ConnectionString = strConnString
        conn.Open()

        Dim OleDBC As New OleDbCommand
        With OleDBC
            .Connection = conn
            .CommandText = "INSERT INTO `HistoryLog` (`Time`, `Actions`, `User`) VALUES ('" & ToolStripLabel3.Text & "', 'Updated a 1st year grade of a student(" & Me.FirstNameLabel1.Text & " " & Me.MiddleNameLabel1.Text & " " & Me.LastNameLabel1.Text & ")', '" & ToolStripLabel5.Text & "')"
            .ExecuteNonQuery()
        End With

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

        Me.Grades_Freshmen_TableAdapter.FillBy(Me.StudentDataSet._Grades_Freshmen_)

        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

        MessageBox.Show("Saved!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class